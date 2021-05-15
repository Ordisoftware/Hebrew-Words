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
/// <created> 2019-01 </created>
/// <edited> 2021-02 </edited>
using System;
using System.Data.Odbc;
using System.Windows.Forms;
using Ordisoftware.Core;
using System.Collections.Generic;
using SQLite;

namespace Ordisoftware.Hebrew.Words
{

  partial class MainForm : Form
  {

    private bool NeedUpgradeForConcordances;

    private OdbcConnection LockFileConnection;

    /// <summary>
    /// Check if tables and columns exists or create them.
    /// </summary>
    public void CreateSchemaIfNotExists()
    {
      SystemManager.TryCatchManage(() =>
      {
        SQLiteOdbcHelper.CreateOrUpdateDSN();
        LockFileConnection = new OdbcConnection(Program.Settings.ConnectionString);
        LockFileConnection.Open();
        if ( Program.Settings.VacuumAtStartup )
          Program.Settings.VacuumLastDone = LockFileConnection.Optimize(Program.Settings.VacuumLastDone);
        LockFileConnection.CheckTable("Books",
                                      @"CREATE TABLE Books
                                        ( 
                                          ID TEXT DEFAULT '' NOT NULL,
                                          Number INTEGER DEFAULT 0 NOT NULL,
                                          Original TEXT DEFAULT '' NOT NULL,
                                          Hebrew TEXT DEFAULT '' NOT NULL,
                                          Name TEXT DEFAULT '' NOT NULL,
                                          CommonName TEXT DEFAULT '' NOT NULL,
                                          Translation TEXT DEFAULT '' NOT NULL,
                                          Lettriq TEXT DEFAULT '' NOT NULL,
                                          Memo TEXT DEFAULT '' NOT NULL,
                                          PRIMARY KEY(ID) 
                                        )");
        LockFileConnection.CheckTable("Chapters",
                                      @"CREATE TABLE Chapters 
                                        ( 
                                          ID TEXT DEFAULT '' NOT NULL,
                                          BookID TEXT DEFAULT '' NOT NULL,
                                          Number INTEGER DEFAULT 0 NOT NULL,
                                          Title TEXT DEFAULT '' NOT NULL,
                                          Memo TEXT DEFAULT '' NOT NULL,
                                          ELS50 TEXT DEFAULT '' NOT NULL,
                                          FOREIGN KEY(BookID) REFERENCES Books(ID),
                                          PRIMARY KEY(ID)
                                        )");
        LockFileConnection.CheckTable("Verses",
                                      @"CREATE TABLE Verses 
                                        ( 
                                          ID TEXT DEFAULT '' NOT NULL,
                                          ChapterID TEXT DEFAULT '' NOT NULL,
                                          Number INTEGER DEFAULT 0 NOT NULL,
                                          Comment TEXT DEFAULT '' NOT NULL,
                                          FOREIGN KEY(ChapterID) REFERENCES Chapters(ID),
                                          PRIMARY KEY(ID)
                                        )");
        LockFileConnection.CheckTable("Words",
                                      @"CREATE TABLE Words 
                                        ( 
                                          ID TEXT DEFAULT '' NOT NULL,
                                          VerseID TEXT DEFAULT '' NOT NULL,
                                          Number INTEGER DEFAULT 0 NOT NULL,
                                          Original TEXT DEFAULT '' NOT NULL,
                                          Hebrew TEXT DEFAULT '' NOT NULL,
                                          Translation TEXT DEFAULT '' NOT NULL,
                                          FOREIGN KEY (VerseID) REFERENCES Verses(ID),
                                          PRIMARY KEY (ID)
                                        )");
        //CommonTranslation TEXT DEFAULT '' NOT NULL,
        //ConcordanceID TEXT DEFAULT '' NOT NULL,
        //Transliteration TEXT DEFAULT '' NOT NULL,
        //FOREIGN KEY ( ConcordanceID ) REFERENCES StrongConcordances( ID ) 
        bool b = Globals.IsDatabaseUpgraded;
        b = !LockFileConnection.CheckColumn("Books", "Original", "TEXT", "''", true) || b;
        b = !LockFileConnection.CheckColumn("Books", "CommonName", "TEXT", "''", true) || b;
        b = !LockFileConnection.CheckColumn("Books", "Memo", "TEXT", "''", true) || b;
        b = !LockFileConnection.CheckColumn("Books", "Lettriq", "TEXT", "''", true) || b;
        b = !LockFileConnection.CheckColumn("Chapters", "Title", "TEXT", "''", true) || b;
        b = !LockFileConnection.CheckColumn("Chapters", "Memo", "TEXT", "''", true) || b;
        Globals.IsDatabaseUpgraded = b;
        b = false;
        //b = !LockFileConnection.CheckColumn("Words", "CommonTranslation", "TEXT", "''", true) || b;
        //b = !LockFileConnection.CheckColumn("Words", "Transliteration", "TEXT", "''", true) || b;
        //b = !LockFileConnection.CheckColumn("Words", "ConcordanceID", "TEXT", "''", true) || b;
        NeedUpgradeForConcordances = b;
        Globals.IsDatabaseUpgraded = Globals.IsDatabaseUpgraded || b;
      });
    }

  }

  /*[Table("Books")]
  public class Book
  {
    [PrimaryKey]
    public string ID { get; set; }
    public int Number { get; set; }
    public string Original { get; set; }
    public string Hebrew { get; set; }
    public string Name { get; set; }
    public string CommonName { get; set; }
    public string Translation { get; set; }
    public string Lettriq { get; set; }
    public string Memo { get; set; }
    public List<Chapter> Chapters
      => ApplicationDatabase.Instance.Chapters.Where(item => item.BookID == ID).ToList();
  }

  [Table("Chapters")]
  public class Chapter
  {
    [PrimaryKey]
    public string ID { get; set; }
    public string BookID { get; set; }
    public int Number { get; set; }
    public string Title { get; set; }
    public string Memo { get; set; }
    public string ELS50 { get; set; }
    public List<Verse> Verses
      => ApplicationDatabase.Instance.Verses.Where(item => item.ChapterID == ID).ToList();
  }

  [Table("Verses")]
  public class Verse
  {
    [PrimaryKey]
    public string ID { get; set; }
    public string ChapterID { get; set; }
    public int Number { get; set; }
    public string Comment { get; set; }
    public List<Word> Words
      => ApplicationDatabase.Instance.Words.Where(item => item.VerseID == ID).ToList();
  }

  [Table("Words")]
  public class Word
  {
    [PrimaryKey]
    public string ID { get; set; }
    public string VerseID { get; set; }
    public string Code { get; set; }
    public int Number { get; set; }
    public string Original { get; set; }
    public string Hebrew { get; set; }
    public string Translation { get; set; }
  }

*/


}

/*
"StrongConcordances",
@"CREATE TABLE 'StrongConcordances' 
  ( 
    ID TEXT DEFAULT '' NOT NULL,
    Usage TEXT DEFAULT '' NOT NULL,
    Original TEXT DEFAULT '' NOT NULL,
    Hebrew TEXT DEFAULT '' NOT NULL,
    Transliteration TEXT DEFAULT '' NOT NULL,
    Phonetic TEXT DEFAULT '' NOT NULL,
    Translation TEXT DEFAULT '' NOT NULL,
    Memo TEXT DEFAULT '' NOT NULL,
    CONSTRAINT Pk_StrongConcordances_ID PRIMARY KEY ( ID ) 
  )");
*/

