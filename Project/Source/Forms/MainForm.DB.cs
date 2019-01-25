/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2016-2019 Olivier Rogier.
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
/// <edited> 2019-01 </edited>
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Windows.Forms;
using Ordisoftware.Core;

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// Provide SQLite utilities methods.
  /// </summary>
  public partial class MainForm : Form
  {

    /// <summary>
    /// Check if tables exists or create them.
    /// </summary>
    public void CreateDatabaseIfNotExists()
    {
      var connection = new OdbcConnection(Program.Settings.ConnectionString);
      connection.Open();
      void check(string table, string sql)
      {
        var cmdCheckTable = new OdbcCommand("SELECT count(*) FROM sqlite_master " +
                                            "WHERE type = 'table' AND name = '" + table + "'", connection);
        int result = (int)cmdCheckTable.ExecuteScalar();
        if ( result == 0 )
        {
          var cmdCreateTable = new OdbcCommand(sql, connection);
          cmdCreateTable.ExecuteNonQuery();
        }
      }
      try
      {
        check("Books", @"CREATE TABLE 'Books' ( 
                           ID text NOT NULL,
                           Number integer NOT NULL,
                           Hebrew varchar(20) NOT NULL,
                           Name varchar(20) NOT NULL,
                           CONSTRAINT Pk_Book_ID PRIMARY KEY ( ID ) 
                         )");
        check("Chapters", @"CREATE TABLE Chapters ( 
                              ID text NOT NULL,
                              BookID text NOT NULL,
                              Number integer NOT NULL,
                              ELS50 text NOT NULL,
                              CONSTRAINT Pk_Chapter_ID PRIMARY KEY ( ID ), 
                              FOREIGN KEY ( BookID ) REFERENCES Books( ID ) 
                            )");
        check("Verses", @"CREATE TABLE Verses ( 
                            ID text NOT NULL,
                            ChapterID text NOT NULL,
                            Number integer NOT NULL,
                            Translation text NOT NULL,
                            CONSTRAINT Pk_Verse_ID PRIMARY KEY ( ID ), 
                            FOREIGN KEY ( ChapterID ) REFERENCES Chapters( ID ) 
                          )");
        check("Words", @"CREATE TABLE Words ( 
                           ID text NOT NULL,
                           VerseID text NOT NULL,
                           Number integer NOT NULL,
                           Hebrew text NOT NULL,
                           Translation text NOT NULL,
                           Comment text NOT NULL,
                           CONSTRAINT Pk_Word_ID PRIMARY KEY ( ID ), 
                           FOREIGN KEY ( VerseID ) REFERENCES Verses( ID ) 
                         )");
      }
      finally
      {
        connection.Close();
      }
    }

    /// <summary>
    /// Create or re-create database content
    /// </summary>
    public void CreateData()
    {
      var connection = new OdbcConnection(Program.Settings.ConnectionString);
      connection.Open();
      var command = new OdbcCommand("DELETE FROM Words", connection);
      command.ExecuteNonQuery();
      command = new OdbcCommand("DELETE FROM Verses", connection);
      command.ExecuteNonQuery();
      command = new OdbcCommand("DELETE FROM Chapters", connection);
      command.ExecuteNonQuery();
      command = new OdbcCommand("DELETE FROM Books", connection);
      command.ExecuteNonQuery();
      connection.Close();
      WordsTableAdapter.Fill(DataSet.Words);
      VersesTableAdapter.Fill(DataSet.Verses);
      ChaptersTableAdapter.Fill(DataSet.Chapters);
      BooksTableAdapter.Fill(DataSet.Books);
      LoadFromFiles();
      TableAdapterManager.UpdateAll(DataSet);
    }

    /// <summary>
    /// Load books content from hebrew text files.
    /// </summary>
    private void LoadFromFiles()
    {
      Func<string, string> convert = (str) =>
      {
        string result = "";
        foreach ( char c in str ) result += Letters.ConvertToKey(c);
        return result;
      };
      try
      {
        Data.DataSet.BooksRow book = null;
        Data.DataSet.ChaptersRow chapter = null;
        Data.DataSet.VersesRow verse = null;
        Data.DataSet.WordsRow word = null;
        string path = Program.DocumentsPath;
        foreach ( AllBooks bookid in Enum.GetValues(typeof(AllBooks)) )
        {
          UpdateProgress((int)bookid, Enum.GetValues(typeof(AllBooks)).Length);
          string filename = path + bookid.ToString() + ".txt";
          string[] filecontent = File.ReadAllLines(filename);
          book = DataSet.Books.NewBooksRow();
          book.ID = Guid.NewGuid().ToString();
          book.Number = (int)bookid + 1;
          book.Hebrew = bookid.ToString();
          book.Name = TorahNames.BookNames[bookid];
          DataSet.Books.AddBooksRow(book);
          int countChapters = 0;
          int countVerses = 0;
          int countWords = 0;
          bool verseAdded = false;
          string strELS50 = "";
          foreach ( string item in filecontent )
          {
            string line = item;
            if ( line.Contains("    ") )
            {
              if ( chapter != null )
              {
                chapter.ELS50 = "";
                DataSet.Chapters.AddChaptersRow(chapter);
                foreach ( var v in Letters.FinaleDisable ) strELS50 = strELS50.Replace(v.Key, v.Value);
                int i = strELS50.Length - 1;
                while ( i >= 0 && strELS50[i] != 't' ) i--;
                string res = "";
                for ( int p = i; p >= 0; p -= 50 ) res = strELS50[p] + res;
                chapter.ELS50 = res;
                strELS50 = "";
              }
              countVerses = 0;
              chapter = DataSet.Chapters.NewChaptersRow();
              chapter.Number = ++countChapters;
              chapter.ID = Guid.NewGuid().ToString(); ;
              chapter.BookID = book.ID;
            }
            else
            {
              line = line.Replace(":", "");
              var list = line.Split('\t');
              string[] listWords;
              if ( list.Length == 2 )
              {
                countWords = 0;
                verse = DataSet.Verses.NewVersesRow();
                verse.Number = ++countVerses;
                verse.ID = Guid.NewGuid().ToString();
                verse.ChapterID = chapter.ID;
                verse.Translation = "";
                listWords = convert(list[0]).Split(' ').Reverse().ToArray();
                verseAdded = true;
                DataSet.Verses.AddVersesRow(verse);
              }
              else
              {
                listWords = convert(line).Split(' ').Reverse().ToArray();
              }
              foreach ( string s in listWords )
                if (s != "")
                {
                  word = DataSet.Words.NewWordsRow();
                  word.Number = ++countWords;
                  word.ID = Guid.NewGuid().ToString();
                  word.VerseID = verse.ID;
                  word.Hebrew = s;
                  word.Translation = "";
                  word.Comment = "";
                  DataSet.Words.AddWordsRow(word);
                  strELS50 = s + strELS50;
                }
            }
          }
        }
        if ( chapter != null )
        {
          chapter.ELS50 = "";
          //chapter.InitializeHiddenVerse();
          DataSet.Chapters.AddChaptersRow(chapter);
        }
        TableAdapterManager.UpdateAll(DataSet);
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
    }

  }

}