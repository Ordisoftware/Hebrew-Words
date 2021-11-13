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
/// <created> 2019-09 </created>
/// <edited> 2020-03 </edited>
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Ordisoftware.Hebrew.Words
{

  partial class ImportVerseForm : Form
  {

    private Data.DataSet.BooksRow GhostBook;
    private Data.DataSet.ChaptersRow GhostChapter;
    private Data.DataSet.VersesRow GhostVerse;
    private Data.DataSet.WordsRow[] GhostWords;

    private void CreateGhost()
    {
      GhostBook = DataSet.Books.NewBooksRow();
      GhostBook.ID = Guid.NewGuid().ToString();
      GhostBook.Number = 0;
      GhostBook.Original = "";
      GhostBook.Hebrew = "";
      GhostBook.Name = "";
      GhostBook.CommonName = "";
      GhostBook.Translation = "";
      GhostBook.Memo = "";
      DataSet.Books.AddBooksRow(GhostBook);
      GhostChapter = DataSet.Chapters.NewChaptersRow();
      GhostChapter.ID = Guid.NewGuid().ToString();
      GhostChapter.BookID = GhostBook.ID;
      GhostChapter.Number = 0;
      GhostChapter.ELS50 = "";
      GhostChapter.Title = "";
      GhostChapter.Memo = "";
      DataSet.Chapters.AddChaptersRow(GhostChapter);
      GhostVerse = DataSet.Verses.NewVersesRow();
      GhostVerse.ID = Guid.NewGuid().ToString();
      GhostVerse.ChapterID = GhostChapter.ID;
      GhostVerse.Number = 0;
      GhostVerse.Comment = "";
      DataSet.Verses.AddVersesRow(GhostVerse);
      var words = Reference.Verse.GetWordsRows();
      for ( int i = 0; i < words.Length; i++ )
      {
        var word = DataSet.Words.NewWordsRow();
        word.ID = Guid.NewGuid().ToString();
        word.VerseID = GhostVerse.ID;
        word.Number = words[i].Number;
        word.Original = words[i].Original;
        word.Hebrew = words[i].Hebrew;
        word.Translation = words[i].Translation;
        DataSet.Words.AddWordsRow(word);
      }
      GhostWords = GhostVerse.GetWordsRows();
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
