/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2021 Olivier Rogier.
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
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

using Equin.ApplicationFramework;

class ApplicationDatabase : SQLiteDatabase
{

  static public readonly string BooksTableName = nameof(Books);
  static public readonly string ChaptersTableName = nameof(BookRow.Chapters);
  static public readonly string VersesTableName = nameof(ChapterRow.Verses);
  static public readonly string WordsTableName = nameof(VerseRow.Words);

  static public ApplicationDatabase Instance { get; protected set; }

  static ApplicationDatabase()
  {
    Restart();
  }

  static public void Restart()
  {
    Instance?.Close();
    Instance = new ApplicationDatabase();
  }

  public List<BookRow> Books { get; private set; }
  public List<ChapterRow> Chapters { get; private set; } = new();
  public List<VerseRow> Verses { get; private set; } = new();
  public List<WordRow> Words { get; private set; } = new();

  public BindingListView<BookRow> BooksAsBindingList { get; private set; }

  private ApplicationDatabase() : base(Globals.ApplicationDatabaseFilePath)
  {
    AutoLoadAllAtOpen = false;
  }

  protected override void Vacuum(bool force = false)
  {
    var settings = Program.Settings;
    if ( settings.VacuumAtStartup || force )
    {
      var dateNew = Connection.Optimize(settings.VacuumLastDone, settings.VacuumAtStartupDaysInterval, force);
      if ( settings.VacuumLastDone != dateNew )
      {
        HebrewDatabase.Instance.Connection.Optimize(dateNew, force: true);
        settings.VacuumLastDone = dateNew;
      }
    }
  }

  protected override void DoClose()
  {
    if ( Books == null ) return;
    if ( ClearListsOnCloseOrRelease ) Books?.Clear();
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
    BooksAsBindingList = new BindingListView<BookRow>(Books);
    OnDataLoaded(SysTranslations.DataBinded.GetLang());
  }

  protected override void DoSaveAll()
  {
    if ( !HasChanges ) return;
    CheckAccess(Books, BooksTableName);
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
    if ( Connection.CheckTable(BooksTableName) )
    {
      bool b = Globals.IsDatabaseUpgraded;
      b = !Connection.CheckColumn(BooksTableName, nameof(BookRow.Original), "") || b;
      b = !Connection.CheckColumn(BooksTableName, nameof(BookRow.CommonName), "") || b;
      b = !Connection.CheckColumn(BooksTableName, nameof(BookRow.Memo), "") || b;
      b = !Connection.CheckColumn(BooksTableName, nameof(BookRow.Lettriq), "") || b;
      b = !Connection.CheckColumn(ChaptersTableName, nameof(ChapterRow.Title), "") || b;
      b = !Connection.CheckColumn(ChaptersTableName, nameof(ChapterRow.Memo), "") || b;
      Globals.IsDatabaseUpgraded = b;
    }
  }

  protected override bool CreateDataIfNotExist(bool reset = false)
  {
    long countBooks = Connection.GetRowsCount(BooksTableName);
    long countChapters = Connection.GetRowsCount(ChaptersTableName);
    long countVerses = Connection.GetRowsCount(VersesTableName);
    long countWords = Connection.GetRowsCount(WordsTableName);
    if ( countBooks != 0 && Globals.IsDatabaseUpgraded )
    {
      foreach ( BookRow book in Books )
      {
        TanakBook enumBook = (TanakBook)book.Number;
        book.Name = Enum.GetName(typeof(TanakBook), enumBook).Replace("_", " ");
        book.Hebrew = BooksNames.Hebrew[enumBook];
        if ( book.Original.Length == 0 )
          book.Original = BooksNames.Unicode[enumBook];
        if ( book.CommonName.Length == 0 )
          book.CommonName = BooksNames.Common.GetLang(enumBook);
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

  private void FillFromFiles()
  {
    try
    {
      Globals.ChronoStartingApp.Stop();
      Globals.ChronoLoadData.Stop();
      MainForm.Instance.SetFormDisabled(true);
      Books.Clear();
      Loaded = false;
      BookRow book = null;
      ChapterRow chapter = null;
      VerseRow verse = null;
      WordRow word = null;
      string path = Program.TanakFolderPath;
      string strELS50 = "";
      void nextChapter()
      {
        book.Chapters.Add(chapter);
        Chapters.Add(chapter);
        strELS50 = HebrewAlphabet.UnFinalAll(strELS50);
        int i = strELS50.Length - 1;
        while ( i >= 0 && strELS50[i] != 't' ) i--;
        string res = "";
        for ( int p = i; p >= 0; p -= 50 ) res = strELS50[p] + res;
        chapter.ELS50 = res;
        strELS50 = "";
      }
      var books = Enums.GetValues<TanakBook>();
      LoadingForm.Instance.DoProgress(operation: SysTranslations.CreatingData.GetLang());
      foreach ( TanakBook bookid in books )
      {
        string filePath = Path.Combine(path, bookid.ToString().Replace("_", " ") + ".txt");
        if ( !File.Exists(filePath) )
        {
          DisplayManager.ShowWarning(SysTranslations.FileNotFound.GetLang(filePath));
          continue;
        }
        string[] filecontent = File.ReadAllLines(filePath);
        book = new();
        book.ID = Guid.NewGuid();
        book.Number = (int)bookid;
        book.Original = BooksNames.Unicode[bookid];
        book.Hebrew = BooksNames.Hebrew[bookid];
        book.Name = bookid.ToString().Replace("_", " ");
        book.CommonName = BooksNames.Common.GetLang(bookid);
        book.Translation = string.Empty;
        book.Lettriq = string.Empty;
        book.Memo = string.Empty;
        Books.Add(book);
        int countChapters = 0;
        int countVerses = 0;
        int countWords = 0;
        foreach ( string item in filecontent )
        {
          string line = item;
          if ( line.Contains("    ") )
          {
            if ( chapter != null ) nextChapter();
            countVerses = 0;
            chapter = new();
            chapter.ID = Guid.NewGuid();
            chapter.BookID = book.ID;
            chapter.Number = ++countChapters;
            chapter.Title = string.Empty;
            chapter.Memo = string.Empty;
          }
          else
          {
            line = line.Replace(":", "");
            var list = line.Split('\t');
            string[] listWordsOriginal;
            string[] listWordsHebrew;
            if ( list.Length == 2 )
            {
              countWords = 0;
              verse = new();
              verse.ID = Guid.NewGuid();
              verse.ChapterID = chapter.ID;
              verse.Number = ++countVerses;
              listWordsOriginal = list[0].Replace("-", " ").Split(' ').Reverse().ToArray();
              listWordsHebrew = HebrewAlphabet.ToHebrewFont(list[0]).Split(' ').ToArray();
              chapter.Verses.Add(verse);
              Verses.Add(verse);
            }
            else
            {
              listWordsOriginal = line.Replace("-", " ").Split(' ').Reverse().ToArray();
              listWordsHebrew = HebrewAlphabet.ToHebrewFont(line).Split(' ').ToArray();
            }
            for ( int i = 0; i < listWordsHebrew.Length; i++ )
              if ( listWordsHebrew[i].Length > 0 )
              {
                word = new();
                word.ID = Guid.NewGuid();
                word.VerseID = verse.ID;
                word.Number = ++countWords;
                word.Original = new string(listWordsOriginal[i].Reverse().ToArray());
                word.Hebrew = new string(listWordsHebrew[i].ToCharArray().Reverse().ToArray());
                word.Translation = string.Empty;
                verse.Words.Add(word);
                Words.Add(word);
                strELS50 = listWordsHebrew[i] + strELS50;
              }
          }
        }
      }
      if ( chapter != null ) nextChapter();
      BeginTransaction();
      try
      {
        LoadingForm.Instance.DoProgress(operation: SysTranslations.SavingData.GetLang());
        Connection.InsertAll(Books);
        Connection.InsertAll(Chapters);
        Connection.InsertAll(Verses);
        Connection.InsertAll(Words);
        LoadingForm.Instance.DoProgress(operation: SysTranslations.Finalizing.GetLang());
        Commit();
        Vacuum(true);
      }
      catch
      {
        Rollback();
        throw;
      }
      Loaded = true;
    }
    catch ( Exception ex )
    {
      ex.Manage();
    }
    finally
    {
      MainForm.Instance.SetFormDisabled(false);
      Globals.ChronoStartingApp.Start();
      Globals.ChronoLoadData.Start();
    }
  }

}
