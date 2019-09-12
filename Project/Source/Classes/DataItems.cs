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
/// <created> 2016-04 </created>
/// <edited> 2019-09 </edited>
using System;
using System.Collections.Generic;
using Ordisoftware.HebrewWords.Data;

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// Provide book reference item
  /// </summary>
  public class BookItem
  {
    public DataSet.BooksRow Book { get; set; }
    public override string ToString()
    {
      string str = Book.Number + ". " + Book.Name;
      if ( Book.Translation != "" ) str += " (" + Book.Translation + ")";
      return str;
    }
  }

  /// <summary>
  /// Provide chapter reference item
  /// </summary>
  public class ChapterItem
  {
    public DataSet.ChaptersRow Chapter { get; set; }
    public override string ToString()
    {
      return Chapter.Number.ToString();
    }
  }

  /// <summary>
  /// Provide reference item
  /// </summary>
  public class ReferenceItem
  {
    public DataSet.BooksRow Book { get; set; }
    public DataSet.ChaptersRow Chapter { get; set; }
    public DataSet.VersesRow Verse { get; set; }
    public string Translation { get { return Verse.GetTranslation(); } }
    public string Text { get { return ToString(); } }
    public override string ToString()
    {
      return Book.Name + " " + Chapter.Number + "." + Verse.Number;
    }
    public string ToStringNumbers()
    {
      return Book.Number + "." + Chapter.Number + "." + Verse.Number;
    }
    public ReferenceItem()
    {
    }
    public ReferenceItem(int book, int chapter, int verse)
    {
      Book = MainForm.Instance.DataSet.Books[book - 1];
      Chapter = Book.GetChaptersRows()[chapter - 1];
      Verse = Chapter.GetVersesRows()[verse - 1];
    }
  }

  /// <summary>
  /// Provide reference item with word
  /// </summary>
  public class WordReferencedItem : ReferenceItem
  {
    public DataSet.WordsRow Word { get; set; }
    public WordReferencedItem()
      : base()
    {
    }
    public WordReferencedItem(ReferenceItem reference, DataSet.WordsRow word)
      : base()
    {
      Book = reference.Book;
      Chapter = reference.Chapter;
      Verse = reference.Verse;
      Word = word;
    }
    public WordReferencedItem(int book, int chapter, int verse)
      : base(book, chapter, verse)
    {
    }
  }

  class ReferenceItemComparer : IEqualityComparer<ReferenceItem>
  {
    public bool Equals(ReferenceItem x, ReferenceItem y)
    {
      if ( Object.ReferenceEquals(x, y) ) return true;
      if ( Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null) )
        return false;
      return x.Book.Number == y.Book.Number
          && x.Chapter.Number == y.Chapter.Number
          && x.Verse.Number == y.Verse.Number;
    }
    public int GetHashCode(ReferenceItem value)
    {
      if ( Object.ReferenceEquals(value, null) ) return 0;
      int hashBook = value.Book.Number.GetHashCode();
      int hashChapter = value.Book.Number.GetHashCode();
      int hashVerse = value.Book?.Number.GetHashCode() ?? 1;
      return hashBook ^ hashChapter ^ hashVerse;
    }
  }

}
