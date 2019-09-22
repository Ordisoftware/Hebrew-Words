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
using System.Linq;
using Ordisoftware.HebrewWords.Data;

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// Provide reference item
  /// </summary>
  public class ReferenceItem
  {

    public DataSet.BooksRow Book { get; set; }
    public DataSet.ChaptersRow Chapter { get; set; }
    public DataSet.VersesRow Verse { get; set; }
    public DataSet.WordsRow Word { get; set; }

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
      : this(book, chapter, verse, null)
    {
    }

    public ReferenceItem(DataSet.BooksRow book, DataSet.ChaptersRow chapter, DataSet.VersesRow verse, DataSet.WordsRow word)
    {
      Book = book;
      Chapter = chapter;
      Verse = verse;
      Word = word;
    }

    public ReferenceItem(ReferenceItem item)
      : this(item.Book?.Number ?? 0, item.Chapter?.Number ?? 0, item.Verse?.Number ?? 0, item.Word?.Number ?? 0)
    {
    }

    public ReferenceItem(ReferenceItem reference, DataSet.WordsRow word)
      : this(reference)
    {
      Word = word;
    }

    public ReferenceItem(int book, int chapter, int verse)
      : this(book, chapter, verse, 0)
    {
    }

    public ReferenceItem(int book, int chapter, int verse, int word)
    {
      try
      {
        Book = MainForm.Instance.DataSet.Books.Where(b => b.Number == book).Single();
        Chapter = Book.GetChaptersRows()[chapter - 1];
        Verse = verse == 0 ? null : Chapter.GetVersesRows()[verse - 1];
        Word = word == 0 ? null : Verse.GetWordsRows()[word - 1];
      }
      catch
      {
        throw new Exception(String.Format("Bad reference: {0}.{1}.{2}.{3}", book, chapter, verse, word));
      }
    }

    static public bool Equals(ReferenceItem x, ReferenceItem y)
    {
      if ( Object.ReferenceEquals(x, null) && !Object.ReferenceEquals(y, null) )
        return false;
      if ( !Object.ReferenceEquals(x, null) && Object.ReferenceEquals(y, null) )
        return false;
      try
      {
        return ( x.Book?.Number ?? 0 ) == ( y.Book?.Number ?? 0 )
            && ( x.Chapter?.Number ?? 0 ) == ( y.Chapter?.Number ?? 0 )
            && ( x.Verse?.Number ?? 0 ) == ( y.Verse?.Number ?? 0 )
            && ( x.Word?.Number ?? 0 ) == ( y.Word?.Number ?? 0 );
      }
      catch
      {
        return false;
      }
    }

    public bool Equals(ReferenceItem y)
    {
      return Equals(this, y);
    }

    public override int GetHashCode()
    {
      int hashBook = Book?.Number.GetHashCode() ?? 0;
      int hashChapter = Chapter?.Number.GetHashCode() ?? 0;
      int hashVerse = Verse?.Number.GetHashCode() ?? 0;
      int hashWord = Word?.Number.GetHashCode() ?? 0;
      return hashBook ^ hashChapter ^ hashVerse ^ hashWord;
    }

  }

}
