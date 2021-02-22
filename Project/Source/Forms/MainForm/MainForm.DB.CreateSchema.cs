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
/// <edited> 2020-04 </edited>
using System;
using System.Data.Odbc;
using System.Windows.Forms;
using Ordisoftware.Core;

namespace Ordisoftware.Hebrew.Words
{

  public partial class MainForm : Form
  {

    //private bool NeedUpgradeForConcordances;

    private OdbcConnection LockFileConnection;

    /// <summary>
    /// Check if tables and columns exists or create them.
    /// </summary>
    public void CreateSchemaIfNotExists()
    {
      bool upgraded = false;
      SystemManager.TryCatchManage(() =>
      {
        SQLiteOdbcHelper.CreateOrUpdateDSN();
        LockFileConnection = new OdbcConnection(Program.Settings.ConnectionString);
        LockFileConnection.Open();
        if ( Program.Settings.VacuumAtStartup )
          Program.Settings.VacuumLastDone = LockFileConnection.Optimize(Program.Settings.VacuumLastDone);
        LockFileConnection.CheckTable("Books",
                                      @"CREATE TABLE 'Books' 
                                          ( 
                                            ID TEXT DEFAULT '' NOT NULL,
                                            Number INTEGER NOT NULL,
                                            Original TEXT DEFAULT '' NOT NULL,
                                            Hebrew TEXT DEFAULT '' NOT NULL,
                                            Name TEXT DEFAULT '' NOT NULL,
                                            CommonName TEXT DEFAULT '' NOT NULL,
                                            Translation TEXT DEFAULT '' NOT NULL,
                                            Lettriq TEXT DEFAULT '' NOT NULL,
                                            Memo TEXT DEFAULT '' NOT NULL,
                                            CONSTRAINT Pk_Book_ID PRIMARY KEY ( ID ) 
                                          )");
        LockFileConnection.CheckTable("Chapters",
                                      @"CREATE TABLE Chapters 
                                          ( 
                                            ID TEXT DEFAULT '' NOT NULL,
                                            BookID TEXT DEFAULT '' NOT NULL,
                                            Number INTEGER NOT NULL,
                                            Title TEXT DEFAULT '' NOT NULL,
                                            Memo TEXT DEFAULT '' NOT NULL,
                                            ELS50 TEXT DEFAULT '' NOT NULL,
                                            CONSTRAINT Pk_Chapter_ID PRIMARY KEY ( ID ), 
                                            FOREIGN KEY ( BookID ) REFERENCES Books( ID ) 
                                          )");
        LockFileConnection.CheckTable("Verses",
                                      @"CREATE TABLE Verses 
                                          ( 
                                            ID TEXT DEFAULT '' NOT NULL,
                                            ChapterID TEXT DEFAULT '' NOT NULL,
                                            Number INTEGER NOT NULL,
                                            Comment TEXT DEFAULT '' NOT NULL,
                                            CONSTRAINT Pk_Verse_ID PRIMARY KEY ( ID ), 
                                            FOREIGN KEY ( ChapterID ) REFERENCES Chapters( ID ) 
                                          )");
        LockFileConnection.CheckTable("Words",
                                      @"CREATE TABLE Words 
                                          ( 
                                            ID TEXT DEFAULT '' NOT NULL,
                                            VerseID TEXT DEFAULT '' NOT NULL,
                                            Number INTEGER NOT NULL,
                                            Original TEXT DEFAULT '' NOT NULL,
                                            Hebrew TEXT DEFAULT '' NOT NULL,
                                            Translation TEXT DEFAULT '' NOT NULL,
                                            CONSTRAINT Pk_Word_ID PRIMARY KEY ( ID ), 
                                            FOREIGN KEY ( VerseID ) REFERENCES Verses( ID ) 
                                          )");
        //Transliteration TEXT DEFAULT '' NOT NULL,
        //ClassicTranslation TEXT DEFAULT '' NOT NULL,
        //ConcordanceID TEXT DEFAULT '' NOT NULL,
        //FOREIGN KEY ( ConcordanceID ) REFERENCES StrongConcordances( ID ) 
        LockFileConnection.CheckColumn("Books", "Original", "TEXT", "''", true);
        LockFileConnection.CheckColumn("Books", "CommonName", "TEXT", "''", true);
        LockFileConnection.CheckColumn("Books", "Memo", "TEXT", "''", true);
        LockFileConnection.CheckColumn("Books", "Lettriq", "TEXT", "''", true);
        LockFileConnection.CheckColumn("Chapters", "Title", "TEXT", "''", true);
        LockFileConnection.CheckColumn("Chapters", "Memo", "TEXT", "''", true);
        //upgraded = !connection.CheckColumn("Words", "ClassicTranslation", sqlColumn);
        //upgraded = !connection.CheckColumn("Words", "Transliteration", sqlColumn);
        //upgraded = !connection.CheckColumn("Words", "ConcordanceID", sqlColumn);
        //NeedUpgradeForConcordances = upgraded;
      });
    }

  }

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
