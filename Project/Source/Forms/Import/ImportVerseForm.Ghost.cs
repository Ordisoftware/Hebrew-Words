/// <license>
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
/// <created> 2019-09 </created>
/// <edited> 2019-09 </edited>
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  public partial class ImportVerseForm : Form
  {

    private Data.DataSet.BooksRow GhostBook;
    private Data.DataSet.ChaptersRow GhostChapter;
    private Data.DataSet.VersesRow GhostVerse;
    private Data.DataSet.WordsRow[] GhostWords;

    private void CreateGhost()
    {
      var book = DataSet.Books.NewBooksRow();
      book.ID = Guid.NewGuid().ToString();
      book.Number = 0;
      book.Original = "";
      book.Hebrew = "";
      book.Name = "";
      book.Translation = "";
      book.Memo = "";
      MainForm.Instance.DataSet.Books.AddBooksRow(book);
      var chapter = DataSet.Chapters.NewChaptersRow();
      chapter.ID = Guid.NewGuid().ToString();
      chapter.BookID = book.ID;
      chapter.Number = 0;
      chapter.ELS50 = "";
      chapter.Memo = "";
      DataSet.Chapters.AddChaptersRow(chapter);
      var verse = MainForm.Instance.DataSet.Verses.NewVersesRow();
      verse.ID = Guid.NewGuid().ToString();
      verse.ChapterID = chapter.ID;
      verse.Number = 0;
      verse.Comment = "";
      DataSet.Verses.AddVersesRow(verse);
      var words = Reference.Verse.GetWordsRows();
      for ( int i = 0; i < words.Count(); i++ )
      {
        var word = MainForm.Instance.DataSet.Words.NewWordsRow();
        word.ID = Guid.NewGuid().ToString();
        word.VerseID = verse.ID;
        word.Number = words[i].Number;
        word.Original = words[i].Original;
        word.Hebrew = words[i].Hebrew;
        word.Translation = words[i].Translation;
        DataSet.Words.AddWordsRow(word);
      }
      ActionOK.Enabled = false;
    }

    private void DeleteGhost()
    {
      foreach ( var word in GhostWords.ToList() )
        DataSet.Words.RemoveWordsRow(word);
      DataSet.Verses.RemoveVersesRow(GhostVerse);
      DataSet.Chapters.RemoveChaptersRow(GhostChapter);
      DataSet.Books.RemoveBooksRow(GhostBook);
    }

  }

}
