/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2025 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at
/// https://mozilla.org/MPL/2.0/.
/// If it is not possible or desirable to put the notice in a particular file,
/// then You may include the notice in a location(such as a LICENSE file in a
/// relevant directory) where a recipient would be likely to look for such a notice.
/// You may add additional accurate notices of copyright ownership.
/// </license>
/// <created> 2021-12 </created>
/// <edited> 2022-08 </edited>
namespace Ordisoftware.Hebrew.Words;

using Equin.ApplicationFramework;

partial class ApplicationDatabase : SQLiteDatabase
{

  static public readonly string BooksTableName = nameof(Books);
  static public readonly string ChaptersTableName = nameof(BookRow.Chapters);
  static public readonly string VersesTableName = nameof(ChapterRow.Verses);
  static public readonly string WordsTableName = nameof(VerseRow.Words);

  static private readonly Properties.Settings Settings = Program.Settings;

  static public ApplicationDatabase Instance { get; private set; }

  static ApplicationDatabase()
  {
    Restart();
  }

  static public void Restart()
  {
    Instance?.Close();
    Instance?.Dispose();
    Instance = new ApplicationDatabase();
  }

  public List<BookRow> Books { get; private set; }
  public List<ChapterRow> Chapters { get; private set; } = [];
  public List<VerseRow> Verses { get; private set; } = [];
  public List<WordRow> Words { get; private set; } = [];

  [SuppressMessage("IDisposableAnalyzers.Correctness", "IDISP006:Implement IDisposable", Justification = "<En attente>")]
  public BindingListView<BookRow> BooksAsBindingList { get; private set; }

  private ApplicationDatabase() : base(Globals.ApplicationDatabaseFilePath)
  {
    AutoLoadAllAtOpen = false;
  }

  protected override void AutoVacuum()
  {
    if ( Settings.VacuumAtStartup )
    {
      var dateNew = Connection.Optimize(Settings.VacuumLastDone, Settings.VacuumAtStartupDaysInterval);
      if ( Settings.VacuumLastDone != dateNew )
      {
        HebrewDatabase.Instance.Connection.Optimize(dateNew, force: true);
        Settings.VacuumLastDone = dateNew;
      }
    }
  }

  protected override void DoClose()
  {
    if ( Books is null ) return;
    if ( ClearListsOnCloseOrRelease ) Books.Clear();
    Books = null;
  }

  protected override void CreateTables()
  {
    Connection.CreateTable<BookRow>();
    Connection.CreateTable<ChapterRow>();
    Connection.CreateTable<VerseRow>();
    Connection.CreateTable<WordRow>();
  }

  protected override void DoLoadAll()
  {
    Books = new(Connection.Table<BookRow>());
    OnLoadingData(SysTranslations.LoadingData.GetLang());
    Parallel.ForEach(Books, (book) =>
    {
      string idBook = book.ID.ToString();
      book.Chapters.AddRange(Connection.DeferredQuery<ChapterRow>("SELECT * FROM Chapters WHERE BookID = ?", idBook));
      Parallel.ForEach(book.Chapters, (chapter) =>
      {
        string idChapter = chapter.ID.ToString();
        chapter.Verses.AddRange(Connection.DeferredQuery<VerseRow>("SELECT * FROM Verses WHERE ChapterID = ?", idChapter));
        Parallel.ForEach(chapter.Verses, (verse) =>
        {
          string idVerse = verse.ID.ToString();
          verse.Words.AddRange(Connection.DeferredQuery<WordRow>("SELECT * FROM Words WHERE VerseID = ?", idVerse));
        });
      });
    });
    Chapters = Books.SelectMany(b => b.Chapters).ToList();
    Verses = Chapters.SelectMany(c => c.Verses).ToList();
    Words = Verses.SelectMany(v => v.Words).ToList();
    OnDataLoaded(SysTranslations.DataLoaded.GetLang());
  }

  protected override void CreateBindingLists()
  {
    OnLoadingData(SysTranslations.BindingData.GetLang());
    BooksAsBindingList?.Dispose();
    BooksAsBindingList = new BindingListView<BookRow>(Books);
    OnDataLoaded(SysTranslations.DataBinded.GetLang());
  }

  protected override void DoSaveAll()
  {
    DoTheSaveAll();
  }

  public void SaveAllWithoutUpdateDateModified()
  {
    DoTheSaveAll(false);
  }

  private void DoTheSaveAll(bool updateModifiedDate = true)
  {
    if ( !HasChanges ) return;
    CheckAccess(Books, BooksTableName);
    if ( updateModifiedDate )
      foreach ( AbstractRow row in ModifiedObjects.Cast<AbstractRow>() )
        row.DateModified = DateTime.Now;
    Connection.UpdateAll(ModifiedObjects);
    ModifiedObjects.Clear();
  }

  public void DeleteAll()
  {
    CheckConnected();
    CheckAccess(Books, BooksTableName);
    Connection.DeleteAll<WordRow>();
    Connection.DeleteAll<VerseRow>();
    Connection.DeleteAll<ChapterRow>();
    Connection.DeleteAll<BookRow>();
    Books.Clear();
  }

  protected override void UpgradeSchema()
  {
    base.UpgradeSchema();
    bool upgrade = Globals.IsDatabaseUpgraded;
    if ( Connection.CheckTable(BooksTableName) )
    {
      checkColumnText(BooksTableName, nameof(BookRow.CommonName));
      checkColumnText(BooksTableName, nameof(BookRow.Lettriq));
      checkColumnText(BooksTableName, nameof(BookRow.Memo));
      checkColumnText(ChaptersTableName, nameof(ChapterRow.Title));
      checkColumnText(ChaptersTableName, nameof(ChapterRow.Memo));
      checkColumnText(VersesTableName, nameof(VerseRow.Title));
      checkColumnText(VersesTableName, nameof(VerseRow.Concept));
    }
    Globals.IsDatabaseUpgraded = upgrade;
    //
    void checkColumnText(string table, string column)
      => upgrade = !Connection.CheckColumn(table, column, "TEXT", "''", true) || upgrade;
  }

  protected override bool CreateDataIfNotExist(bool reset = false)
  {
    long countBooks = Connection.CountRows(BooksTableName);
    long countChapters = Connection.CountRows(ChaptersTableName);
    long countVerses = Connection.CountRows(VersesTableName);
    long countWords = Connection.CountRows(WordsTableName);
    if ( countBooks != 0 && Globals.IsDatabaseUpgraded )
    {
      foreach ( BookRow book in Books )
      {
        var bookNumber = (TanakBook)book.Number;
        book.Unicode = BookInfos.Unicode[bookNumber];
        book.Hebrew = BookInfos.Hebrew[bookNumber];
        book.Transcription = BookInfos.Transcriptions.GetLang(bookNumber);
        book.CommonName = BookInfos.Common.GetLang(bookNumber);
      }
      SaveAll();
    }
    if ( ( countBooks == 0 && countChapters == 0 && countVerses == 0 && countWords == 0 )
      || ( ObjectHelper.CheckIfOneIsTrueAndSomeOthersNot(countBooks == 0, countChapters == 0, countVerses == 0, countWords == 0)
        && DisplayManager.QueryYesNoAbort(SysTranslations.AskToResetCorruptedDatabase.GetLang($"Books.Count = {countBooks}{Globals.NL}Chapters.Count = {countChapters}{Globals.NL}Verses.Count = {countVerses}{Globals.NL}Words.Count = {countWords}"),
                                          onAbort: () => Environment.Exit(-1)) == DialogResult.Yes ) )
      try
      {
        LoadingForm.Instance.Initialize(SysTranslations.CreatingData.GetLang(), 3 + 1, quantify: false);
        FillFromFiles();
        return true;
      }
      finally
      {
        LoadingForm.Instance.Hide();
      }
    return false;
  }

}
