/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2020 Olivier Rogier.
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
using Ordisoftware.HebrewCommon;

namespace Ordisoftware.HebrewWords
{

  public partial class MainForm : Form
  {

    private bool NeedUpgradeForConcordances;

    /// <summary>
    /// Check if tables and columns exists or create them.
    /// </summary>
    public void CreateSchemaIfNotExists()
    {
      bool upgraded = false;
      using ( var connection = new OdbcConnection(Program.Settings.ConnectionString) )
      {
        connection.Open();
        if ( Program.Settings.VacuumAtStartup )
        {
          bool doVacuum = true;
          if ( Program.Settings.VacuumLastDone != null )
            doVacuum = Program.Settings.VacuumLastDone.AddDays(7) <= DateTime.Now;
          if ( doVacuum )
          {
            connection.CheckIntegrity();
            connection.Vacuum();
            Program.Settings.VacuumLastDone = DateTime.Now;
          }
        }
        try
        {
          void checkTable(string table, string sql)
          {
            var command = new OdbcCommand("SELECT count(*) FROM sqlite_master " +
                                          "WHERE type = 'table' AND name = '" + table + "'", connection);
            int result = (int)command.ExecuteScalar();
            if ( result == 0 )
            {
              var cmdCreateTable = new OdbcCommand(sql, connection);
              cmdCreateTable.ExecuteNonQuery();
              upgraded = true;
            }
          }
          void checkColumn(string table, string column, string sql)
          {
            var command = new OdbcCommand("PRAGMA table_info(" + table + ")", connection);
            var reader = command.ExecuteReader();
            int nameIndex = reader.GetOrdinal("Name");
            bool b = false;
            while ( reader.Read() )
              if ( reader.GetString(nameIndex).Equals(column) )
              {
                b = true;
                break;
              }
            if ( !b )
            {
              var cmdCreateColumn = new OdbcCommand(sql, connection);
              cmdCreateColumn.ExecuteNonQuery();
              upgraded = true;
            }
          }
          /*checkTable("StrongConcordances", @"CREATE TABLE 'StrongConcordances' 
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
                                            )");*/
          checkTable("Books", @"CREATE TABLE 'Books' 
                              ( 
                                ID TEXT DEFAULT '' NOT NULL,
                                Number INTEGER NOT NULL,
                                Original TEXT DEFAULT '' NOT NULL,
                                Hebrew TEXT DEFAULT '' NOT NULL,
                                Name TEXT DEFAULT '' NOT NULL,
                                CommonName TEXT DEFAULT '' NOT NULL,
                                Translation TEXT DEFAULT '' NOT NULL,
                                Memo TEXT DEFAULT '' NOT NULL,
                                CONSTRAINT Pk_Book_ID PRIMARY KEY ( ID ) 
                              )");
          checkTable("Chapters", @"CREATE TABLE Chapters 
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
          checkTable("Verses", @"CREATE TABLE Verses 
                               ( 
                                 ID TEXT DEFAULT '' NOT NULL,
                                 ChapterID TEXT DEFAULT '' NOT NULL,
                                 Number INTEGER NOT NULL,
                                 Comment TEXT DEFAULT '' NOT NULL,
                                 CONSTRAINT Pk_Verse_ID PRIMARY KEY ( ID ), 
                                 FOREIGN KEY ( ChapterID ) REFERENCES Chapters( ID ) 
                               )");
          checkTable("Words", @"CREATE TABLE Words 
                              ( 
                                ID TEXT DEFAULT '' NOT NULL,
                                VerseID TEXT DEFAULT '' NOT NULL,
                                Number INTEGER NOT NULL,
                                Original TEXT DEFAULT '' NOT NULL,
                                Hebrew TEXT DEFAULT '' NOT NULL,
                                Translation TEXT DEFAULT '' NOT NULL,
                                ClassicTranslation TEXT DEFAULT '' NOT NULL,
                                Transliteration TEXT DEFAULT '' NOT NULL,
                                CONSTRAINT Pk_Word_ID PRIMARY KEY ( ID ), 
                                FOREIGN KEY ( VerseID ) REFERENCES Verses( ID ) 
                              )");
                              //ConcordanceID TEXT DEFAULT '' NOT NULL,
                              //FOREIGN KEY ( ConcordanceID ) REFERENCES StrongConcordances( ID ) 
          checkColumn("Books", "Original", "ALTER TABLE Books ADD COLUMN Original TEXT DEFAULT '' NOT NULL;");
          checkColumn("Books", "CommonName", "ALTER TABLE Books ADD COLUMN CommonName TEXT DEFAULT '' NOT NULL;");
          checkColumn("Books", "Memo", "ALTER TABLE Books ADD COLUMN Memo TEXT DEFAULT '' NOT NULL;");
          checkColumn("Chapters", "Title", "ALTER TABLE Chapters ADD COLUMN Title TEXT DEFAULT '' NOT NULL;");
          checkColumn("Chapters", "Memo", "ALTER TABLE Chapters ADD COLUMN Memo TEXT DEFAULT '' NOT NULL;");
          upgraded = false;
          checkColumn("Words", "ClassicTranslation", "ALTER TABLE Words ADD COLUMN ClassicTranslation TEXT DEFAULT '' NOT NULL;");
          checkColumn("Words", "Transliteration", "ALTER TABLE Words ADD COLUMN Transliteration TEXT DEFAULT '' NOT NULL;");
          checkColumn("Words", "ConcordanceID", "ALTER TABLE Words ADD COLUMN ConcordanceID TEXT DEFAULT '' NOT NULL;");
          NeedUpgradeForConcordances = upgraded;
        }
        finally
        {
          connection.Close();
        }
      }
    }

  }

}
