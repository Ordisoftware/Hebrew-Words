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

  static new public ApplicationDatabase Instance { get; protected set; }

  static ApplicationDatabase()
  {
    Instance = new ApplicationDatabase();
    SQLiteDatabase.Instance = Instance;
  }

  public List<Book> Books { get; private set; }
  public List<Chapter> Chapters { get; private set; }
  public List<Verse> Verses { get; private set; }
  public List<Word> Words { get; private set; }

  public BindingListView<Book> BooksAsBindingList { get; private set; }
  //public BindingListView<Chapter> ChaptersAsBindingList { get; private set; }
  //public BindingListView<Verse> VersesAsBindingList { get; private set; }
  //public BindingListView<Word> WordsAsBindingList { get; private set; }

  private ApplicationDatabase() : base(Globals.ApplicationDatabaseFilePath)
  {
  }

  public override void Open()
  {
    base.Open();
    if ( Program.Settings.VacuumAtStartup )
    {
      var dateNew = Connection.Optimize(Program.Settings.VacuumLastDone, Program.Settings.VacuumAtStartupDaysInterval);
      if ( Program.Settings.VacuumLastDone != dateNew )
      {
        HebrewDatabase.Instance.Connection.Optimize(dateNew, force: true);
        Program.Settings.VacuumLastDone = dateNew;
      }
    }
  }

  protected override void DoClose()
  {
    if ( Books == null && Chapters == null && Verses == null && Words == null ) return;
    if ( ClearListsOnCloseAndRelease )
    {
      Words?.Clear();
      Verses?.Clear();
      Chapters?.Clear();
      Books?.Clear();
    }
    Words = null;
    Verses = null;
    Chapters = null;
    Books = null;
  }

  protected override void CreateTables()
  {
    Connection.CreateTable<Book>();
    Connection.CreateTable<Chapter>();
    Connection.CreateTable<Verse>();
    Connection.CreateTable<Word>();
  }

  public override void LoadAll()
  {
    base.LoadAll();
    Books = Connection.Table<Book>().ToList();
    Chapters = Connection.Table<Chapter>().ToList();
    Verses = Connection.Table<Verse>().ToList();
    Words = Connection.Table<Word>().ToList();
    BooksAsBindingList = new BindingListView<Book>(Books);
    //ChaptersAsBindingList = new BindingListView<Chapter>(Chapters);
    //VersesAsBindingList = new BindingListView<Verse>(Verses);
    //WordsAsBindingList = new BindingListView<Word>(Words);
  }

  protected override void DoSaveAll()
  {
    CheckAccess(Books, nameof(Books));
    CheckAccess(Chapters, nameof(Chapters));
    CheckAccess(Verses, nameof(Verses));
    CheckAccess(Words, nameof(Words));
    Connection.UpdateAll(Books);
    Connection.UpdateAll(Chapters);
    Connection.UpdateAll(Verses);
    Connection.UpdateAll(Words);
  }

  public void DeleteAll()
  {
    CheckConnected();
    CheckAccess(Words, nameof(Words));
    CheckAccess(Verses, nameof(Verses));
    CheckAccess(Chapters, nameof(Chapters));
    CheckAccess(Books, nameof(Books));
    Connection.DeleteAll<Word>();
    Connection.DeleteAll<Verse>();
    Connection.DeleteAll<Chapter>();
    Connection.DeleteAll<Book>();
    Words.Clear();
    Verses.Clear();
    Chapters.Clear();
    Books.Clear();
  }

  protected override void UpgradeSchema()
  {
    base.UpgradeSchema();
  }

  public override void CreateDataIfNotExist(bool reset = false)
  {
    base.CreateDataIfNotExist(reset);
  }

}
