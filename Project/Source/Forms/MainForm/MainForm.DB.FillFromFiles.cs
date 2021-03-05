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
using System.Data;
using System.Data.Odbc;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EnumsNET;
using Ordisoftware.Core;

namespace Ordisoftware.Hebrew.Words
{

  partial class MainForm : Form
  {

    /// <summary>
    /// Fill tables from hebrew text files.
    /// </summary>
    private void FillFromFiles()
    {
      try
      {
        Data.DataSet.BooksRow book = null;
        Data.DataSet.ChaptersRow chapter = null;
        Data.DataSet.VersesRow verse = null;
        Data.DataSet.WordsRow word = null;
        string path = Program.TanakFolderPath;
        string strELS50 = "";
        void nextChapter()
        {
          chapter.ELS50 = "";
          DataSet.Chapters.AddChaptersRow(chapter);
          strELS50 = HebrewAlphabet.UnFinalAll(strELS50);
          int i = strELS50.Length - 1;
          while ( i >= 0 && strELS50[i] != 't' ) i--;
          string res = "";
          for ( int p = i; p >= 0; p -= 50 ) res = strELS50[p] + res;
          chapter.ELS50 = res;
          strELS50 = "";
        }
        var books = Enums.GetValues<Books>();
        LoadingForm.Instance.Initialize(SysTranslations.ProgressCreatingData.GetLang(), books.Count);
        foreach ( Books bookid in books )
        {
          LoadingForm.Instance.DoProgress();
          string filePath = Path.Combine(path, bookid.ToString().Replace("_", " ") + ".txt");
          if ( !File.Exists(filePath) )
          {
            DisplayManager.ShowWarning(SysTranslations.FileNotFound.GetLang(filePath));
            continue;
          }
          string[] filecontent = File.ReadAllLines(filePath);
          book = DataSet.Books.NewBooksRow();
          book.ID = Guid.NewGuid().ToString();
          book.Number = (int)bookid + 1;
          book.Original = BooksNames.Original[bookid];
          book.Hebrew = BooksNames.Hebrew[bookid];
          book.Name = bookid.ToString().Replace("_", " ");
          book.CommonName = BooksNames.Common.GetLang(bookid);
          book.Translation = "";
          book.Memo = "";
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
              chapter.ID = Guid.NewGuid().ToString();
              chapter.BookID = book.ID;
              chapter.Number = ++countChapters;
              chapter.Title = "";
              chapter.Memo = "";
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
                verse.ID = Guid.NewGuid().ToString();
                verse.ChapterID = chapter.ID;
                verse.Number = ++countVerses;
                verse.Comment = "";
                listWordsOriginal = list[0].Replace("-", " ").Split(' ').Reverse().ToArray();
                listWordsHebrew = HebrewAlphabet.ToHebrewFont(list[0]).Split(' ').ToArray();
                DataSet.Verses.AddVersesRow(verse);
              }
              else
              {
                listWordsOriginal = line.Replace("-", " ").Split(' ').Reverse().ToArray();
                listWordsHebrew = HebrewAlphabet.ToHebrewFont(line).Split(' ').ToArray();
              }
              for ( int i = 0; i < listWordsHebrew.Length; i++ )
                if ( listWordsHebrew[i] != "" )
                {
                  word = DataSet.Words.NewWordsRow();
                  word.ID = Guid.NewGuid().ToString();
                  word.VerseID = verse.ID;
                  word.Number = ++countWords;
                  word.Original = new string(listWordsOriginal[i].Reverse().ToArray());
                  word.Hebrew = new string(listWordsHebrew[i].ToCharArray().Reverse().ToArray());
                  word.Translation = "";
                  DataSet.Words.AddWordsRow(word);
                  strELS50 = listWordsHebrew[i] + strELS50;
                }
            }
          }
        }
        if ( chapter != null ) nextChapter();
        int count = DataSet.Books.Count
                  + DataSet.Chapters.Count
                  + DataSet.Verses.Count
                  + DataSet.Words.Count;
        // TODO update table by table
        LoadingForm.Instance.Initialize("Updating...", count);
        void update(object sender, OdbcRowUpdatedEventArgs rowEvent)
        {
          if ( !Globals.IsGenerating ) LoadingForm.Instance.DoProgress();
        };
        TableAdapterManager.BooksTableAdapter.Adapter.RowUpdated += update;
        TableAdapterManager.ChaptersTableAdapter.Adapter.RowUpdated += update;
        TableAdapterManager.VersesTableAdapter.Adapter.RowUpdated += update;
        TableAdapterManager.WordsTableAdapter.Adapter.RowUpdated += update;
        try
        {
          TableAdapterManager.UpdateAll(DataSet);
        }
        finally
        {
          TableAdapterManager.BooksTableAdapter.Adapter.RowUpdated -= update;
          TableAdapterManager.ChaptersTableAdapter.Adapter.RowUpdated -= update;
          TableAdapterManager.VersesTableAdapter.Adapter.RowUpdated -= update;
          TableAdapterManager.WordsTableAdapter.Adapter.RowUpdated -= update;
        }
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
    }

  }

}
