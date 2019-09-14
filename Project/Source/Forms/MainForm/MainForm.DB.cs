﻿/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2019 Olivier Rogier.
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
/// <edited> 2019-08 </edited>
using System;
using System.Drawing;
using System.IO;
using System.Linq;
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
      bool upgraded = false;
      var connection = new OdbcConnection(Program.Settings.ConnectionString);
      connection.Open();
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
        checkTable("Books", @"CREATE TABLE 'Books' 
                              ( 
                                ID text NOT NULL,
                                Number integer NOT NULL,
                                Hebrew text NOT NULL,
                                Name text NOT NULL,
                                Translation text NOT NULL,
                                CONSTRAINT Pk_Book_ID PRIMARY KEY ( ID ) 
                              )");
        checkTable("Chapters", @"CREATE TABLE Chapters 
                                 ( 
                                   ID text NOT NULL,
                                   BookID text NOT NULL,
                                   Number integer NOT NULL,
                                   ELS50 text NOT NULL,
                                   CONSTRAINT Pk_Chapter_ID PRIMARY KEY ( ID ), 
                                   FOREIGN KEY ( BookID ) REFERENCES Books( ID ) 
                                 )");
        checkTable("Verses", @"CREATE TABLE Verses 
                               ( 
                                 ID text NOT NULL,
                                 ChapterID text NOT NULL,
                                 Number integer NOT NULL,
                                 Comment text NOT NULL,
                                 CONSTRAINT Pk_Verse_ID PRIMARY KEY ( ID ), 
                                 FOREIGN KEY ( ChapterID ) REFERENCES Chapters( ID ) 
                               )");
        checkTable("Words", @"CREATE TABLE Words 
                              ( 
                                ID text NOT NULL,
                                VerseID text NOT NULL,
                                Number integer NOT NULL,
                                Original text NOT NULL,
                                Hebrew text NOT NULL,
                                Translation text NOT NULL,
                                CONSTRAINT Pk_Word_ID PRIMARY KEY ( ID ), 
                                FOREIGN KEY ( VerseID ) REFERENCES Verses( ID ) 
                              )");
        CreateDataIfNotExists();
      }
      finally
      {
        connection.Close();
      }
    }

    /// <summary>
    /// Create database content if not exists.
    /// </summary>
    public void CreateDataIfNotExists()
    {
      var connection = new OdbcConnection(Program.Settings.ConnectionString);
      connection.Open();
      var command = new OdbcCommand("select count(*) FROM Books", connection);
      if ( (int)command.ExecuteScalar() == 0 )
      {
        connection.Close();
        LoadFromFiles();
        TableAdapterManager.UpdateAll(DataSet);
      }
      else
      {
        BooksTableAdapter.Fill(DataSet.Books);
        foreach ( Data.DataSet.BooksRow book in DataSet.Books.Rows )
        {
          book.Hebrew = BooksNames.Hebrew[(Books)( book.Number - 1 )];
          book.Name = book.Name.Replace("_", " ");
        }
        TableAdapterManager.UpdateAll(DataSet);
      }
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
        string path = Program.DocumentsFolderPath;
        string strELS50 = "";
        void nextChapter()
        {
          chapter.ELS50 = "";
          DataSet.Chapters.AddChaptersRow(chapter);
          strELS50 = Letters.UnFinaleAll(strELS50);
          int i = strELS50.Length - 1;
          while ( i >= 0 && strELS50[i] != 't' ) i--;
          string res = "";
          for ( int p = i; p >= 0; p -= 50 ) res = strELS50[p] + res;
          chapter.ELS50 = res;
          strELS50 = "";
        }
        foreach ( Books bookid in Enum.GetValues(typeof(Books)) )
        {
          string filename = path + bookid.ToString().Replace("_", " ") + ".txt";
          if ( !File.Exists(filename) ) continue;
          string[] filecontent = File.ReadAllLines(filename);
          book = DataSet.Books.NewBooksRow();
          book.ID = Guid.NewGuid().ToString();
          book.Number = (int)bookid + 1;
          book.Hebrew = BooksNames.Hebrew[bookid];
          book.Name = bookid.ToString().Replace("_", " ");
          book.Translation = "";
          DataSet.Books.AddBooksRow(book);
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
              chapter = DataSet.Chapters.NewChaptersRow();
              chapter.Number = ++countChapters;
              chapter.ID = Guid.NewGuid().ToString(); ;
              chapter.BookID = book.ID;
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
                verse = DataSet.Verses.NewVersesRow();
                verse.Number = ++countVerses;
                verse.ID = Guid.NewGuid().ToString();
                verse.ChapterID = chapter.ID;
                verse.Comment = "";
                listWordsOriginal = list[0].Replace("-", " ").Split(' ').Reverse().ToArray();
                listWordsHebrew = convert(list[0]).Split(' ').Reverse().ToArray();
                DataSet.Verses.AddVersesRow(verse);
              }
              else
              {
                listWordsOriginal = line.Replace("-", " ").Split(' ').Reverse().ToArray();
                listWordsHebrew = convert(line).Split(' ').Reverse().ToArray();
              }
              for ( int i = 0; i < listWordsHebrew.Length; i++ )
                if ( listWordsHebrew[i] != "" )
                {
                  word = DataSet.Words.NewWordsRow();
                  word.Number = ++countWords;
                  word.ID = Guid.NewGuid().ToString();
                  word.VerseID = verse.ID;
                  word.Original = new string(listWordsOriginal[i].Reverse().ToArray());
                  word.Hebrew = listWordsHebrew[i];
                  word.Translation = "";
                  DataSet.Words.AddWordsRow(word);
                  strELS50 = listWordsHebrew[i] + strELS50;
                }
            }
          }
        }
        if ( chapter != null ) nextChapter();
        TableAdapterManager.UpdateAll(DataSet);
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
    }

    /// <summary>
    /// Load data from database fro the first time.
    /// </summary>
    private void LoadData()
    {
      PopulateData();
      SetView(Program.Settings.CurrentView, true);
      GoTo(Program.Settings.BookmarkMasterBook,
           Program.Settings.BookmarkMasterChapter,
           Program.Settings.BookmarkMasterVerse,
           true);
      ActionSave.PerformClick();
    }

    /// <summary>
    /// Reload data from database.
    /// </summary>
    private void ReLoadData(Action action)
    {
      PanelViewVerses.Controls.Clear();
      PanelSearchResults.Controls.Clear();
      PanelViewVerses.AutoScrollPosition = new Point(0, 0);
      PanelSearchResults.AutoScrollPosition = new Point(0, 0);
      SearchResults = null;
      Refresh();
      DataSet.Clear();
      action();
      History.Clear();
      LoadData();
    }

    /// <summary>
    /// Show a splash screen while loading data.
    /// </summary>
    private void PopulateData()
    {
      var form = new LoadingForm();
      form.ProgressBar.Maximum = 7;
      form.Show();
      form.Refresh();
      SetFormDisabled(true);
      IsLoadingData = true;
      try
      {
        form.ProgressBar.Value = 1;
        Refresh();
        CreateDatabaseIfNotExists();
        form.ProgressBar.Value = 2;
        Refresh();
        BooksTableAdapter.Fill(DataSet.Books);
        form.ProgressBar.Value = 3;
        Refresh();
        ChaptersTableAdapter.Fill(DataSet.Chapters);
        form.ProgressBar.Value = 4;
        Refresh();
        VersesTableAdapter.Fill(DataSet.Verses);
        form.ProgressBar.Value = 5;
        Refresh();
        WordsTableAdapter.Fill(DataSet.Words);
        form.ProgressBar.Value = 6;
        Refresh();
        InitBooksCombobox();
        Bookmarks.Load();
        UpdateBookmarks();
        form.ProgressBar.Value = 7;
        Refresh();
      }
      finally
      {
        IsLoadingData = false;
        form.Hide();
        SetFormDisabled(false);
      }
    }

  }

}
