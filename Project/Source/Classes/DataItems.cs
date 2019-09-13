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
      if ( Book == null ) return "";
      string str = Book.Number + ". " + Book.Name;
      if ( Book.Translation != "" ) str += " (" + Book.Translation + ")";
      return str;
    }
    public BookItem(DataSet.BooksRow book)
    {
      Book = book;
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
      return Chapter?.Number.ToString() ?? "";
    }
    public ChapterItem(DataSet.ChaptersRow chapter)
    {
      Chapter = chapter;
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
      return ( Book?.Name ?? "(null)" ) + " " +
             ( Chapter?.Number.ToString() ?? "(null)" ) + "." +
             ( Verse?.Number.ToString() ?? "(null)" );
    }
    public string ToStringNumbers()
    {
      return ( Book?.Number.ToString() ?? "(null)" ) + " " +
             ( Chapter?.Number.ToString() ?? "(null)" ) + "." +
             ( Verse?.Number.ToString() ?? "(null)" );
    }
    private ReferenceItem()
    {
    }
    public ReferenceItem(DataSet.BooksRow book, DataSet.ChaptersRow chapter, DataSet.VersesRow verse)
    {
      Book = book;
      Chapter = chapter;
      Verse = verse;
    }
    public ReferenceItem(ReferenceItem item)
      : this(item.Book.Number, item.Chapter.Number, item.Verse?.Number ?? 1)
    {
    }
    public ReferenceItem(int book, int chapter, int verse)
    {
      Book = MainForm.Instance.DataSet.Books[book - 1];
      Chapter = Book.GetChaptersRows()[chapter - 1];
      Verse = Chapter.GetVersesRows()[verse - 1];
    }
    static public bool Equals(ReferenceItem x, ReferenceItem y)
    {
      if ( Object.ReferenceEquals(x, null) && !Object.ReferenceEquals(y, null) )
        return false;
      if ( !Object.ReferenceEquals(x, null) && Object.ReferenceEquals(y, null) )
        return false;
      return x.Book.Number == y.Book.Number
          && x.Chapter.Number == y.Chapter.Number
          && ( x.Verse?.Number ?? 0 ) == ( y.Verse?.Number ?? 0 );
    }
    public bool Equals(ReferenceItem y)
    {
      return Equals(this, y);
    }
    public int GetHashCode()
    {
      int hashBook = Book.Number.GetHashCode();
      int hashChapter = Book.Number.GetHashCode();
      int hashVerse = Book?.Number.GetHashCode() ?? 1;
      return hashBook ^ hashChapter ^ hashVerse;
    }
  }

  /// <summary>
  /// Provide reference item with word
  /// </summary>
  public class WordReferencedItem : ReferenceItem
  {
    public DataSet.WordsRow Word { get; set; }
    public WordReferencedItem(DataSet.BooksRow book, 
                              DataSet.ChaptersRow chapter, 
                              DataSet.VersesRow verse, 
                              DataSet.WordsRow word)
      : base(book, chapter, verse)
    {
      Word = word;
    }
    public WordReferencedItem(int book, int chapter, int verse, int word)
      : base(book, chapter, verse)
    {
      Word = Verse.GetWordsRows()[word - 1];
    }
    public WordReferencedItem(ReferenceItem reference, DataSet.WordsRow word)
      : base(reference)
    {
      Word = word;
    }
  }

  class ReferenceItemComparer : IEqualityComparer<ReferenceItem>
  {
    public bool Equals(ReferenceItem x, ReferenceItem y)
    {
      if ( Object.ReferenceEquals(x, null) && !Object.ReferenceEquals(y, null) )
        return false;
      if ( !Object.ReferenceEquals(x, null) && Object.ReferenceEquals(y, null) )
        return false;
      return x.Book.Number == y.Book.Number
          && x.Chapter.Number == y.Chapter.Number
          && ( x.Verse?.Number ?? 0 ) == ( y.Verse?.Number ?? 0 );
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
