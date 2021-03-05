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
/// <created> 2016-04 </created>
/// <edited> 2021-02 </edited>
using System;
using System.Linq;
using Ordisoftware.Core;
using Ordisoftware.Hebrew.Words.Data;

namespace Ordisoftware.Hebrew.Words
{

  /// <summary>
  /// Provide reference item
  /// </summary>
  class ReferenceItem : IEquatable<ReferenceItem>, IComparable<ReferenceItem>
  {

    const string NULL = "(null)";

    public DataSet.BooksRow Book { get; set; }
    public DataSet.ChaptersRow Chapter { get; set; }
    public DataSet.VersesRow Verse { get; set; }
    public DataSet.WordsRow Word { get; set; }

    public override string ToString()
    {
      return ( Book?.Name ?? NULL ) + " " +
             ( Chapter?.Number.ToString() ?? NULL ) + "." +
             ( Verse?.Number.ToString() ?? NULL );
    }

    public string ToStringFull()
    {
      return ( Book?.Name ?? NULL ) + " (" +
             ( Book?.CommonName ?? NULL ) + ") " +
             ( Chapter?.Number.ToString() ?? NULL ) + "." +
             ( Verse?.Number.ToString() ?? NULL );
    }

    public string ToStringNumbers()
    {
      return ( Book?.Number.ToString() ?? NULL ) + "." +
             ( Chapter?.Number.ToString() ?? NULL ) + "." +
             ( Verse?.Number.ToString() ?? NULL );
    }

    private ReferenceItem()
    {
    }

    public ReferenceItem(DataSet.BooksRow book,
                         DataSet.ChaptersRow chapter,
                         DataSet.VersesRow verse)
      : this(book, chapter, verse, null)
    {
    }

    public ReferenceItem(DataSet.BooksRow book,
                         DataSet.ChaptersRow chapter,
                         DataSet.VersesRow verse,
                         DataSet.WordsRow word)
    {
      Book = book;
      Chapter = chapter;
      Verse = verse;
      Word = word;
    }

    public ReferenceItem(ReferenceItem reference,
                         DataSet.WordsRow word)
      : this(reference)
    {
      Word = word;
    }

    public ReferenceItem(ReferenceItem item)
      : this(item.Book?.Number ?? 0, item.Chapter?.Number ?? 0, item.Verse?.Number ?? 0, item.Word?.Number ?? 0)
    {
    }

    public ReferenceItem(int book, int chapter, int verse)
      : this(book, chapter, verse, 0)
    {
    }

    public ReferenceItem(int book, int chapter, int verse, int word)
    {
      try
      {
        Book = MainForm.Instance.DataSet.Books.Where(b => b.Number == book).SingleOrDefault();
        Chapter = Book?.GetChaptersRows()[chapter - 1] ?? null;
        Verse = verse == 0 ? null : Chapter?.GetVersesRows()[verse - 1] ?? null;
        Word = word == 0 ? null : Verse?.GetWordsRows()[word - 1] ?? null;
      }
      catch ( Exception ex )
      {
        throw new Exception($"Error with reference: {book}.{chapter}.{verse}:{word}{Globals.NL2}{ex.Message}");
      }
    }

    static public bool Equals(ReferenceItem x, ReferenceItem y)
    {
      return !ReferenceEquals(x, null) && !ReferenceEquals(y, null)
          && ( x.Book?.Number ?? 0 ) == ( y.Book?.Number ?? 0 )
          && ( x.Chapter?.Number ?? 0 ) == ( y.Chapter?.Number ?? 0 )
          && ( x.Verse?.Number ?? 0 ) == ( y.Verse?.Number ?? 0 );
    }

    public override bool Equals(object obj)
    {
      return Equals(this, obj as ReferenceItem);
    }

    public bool Equals(ReferenceItem y)
    {
      return Equals(this, y);
    }

    public bool EqualsWord(ReferenceItem y)
    {
      return Equals(y) && ( Word?.Number ?? 0 ) == ( y.Word?.Number ?? 0 );
    }

    public override int GetHashCode()
    {
      return ( Book?.Number.GetHashCode() ?? 0 )
           ^ ( Chapter?.Number.GetHashCode() ?? 0 )
           ^ ( Verse?.Number.GetHashCode() ?? 0 );
    }

    public int CompareTo(ReferenceItem other)
    {
      if ( other == null )
        return 1;
      else
      {
        if ( ( Book?.Number ?? 0 ) == ( other.Book?.Number ?? 0 )
          && ( Chapter?.Number ?? 0 ) == ( other.Chapter?.Number ?? 0 )
          && ( Verse?.Number ?? 0 ) == ( other.Verse?.Number ?? 0 ) )
          return 0;
        else
        if ( ( Book?.Number ?? 0 ) < ( other.Book?.Number ?? 0 ) )
          return -1;
        else
        if ( ( Book?.Number ?? 0 ) == ( other.Book?.Number ?? 0 )
          && ( Chapter?.Number ?? 0 ) < ( other.Chapter?.Number ?? 0 ) )
          return -1;
        else
        if ( ( Book?.Number ?? 0 ) == ( other.Book?.Number ?? 0 )
          && ( Chapter?.Number ?? 0 ) == ( other.Chapter?.Number ?? 0 )
          && ( Verse?.Number ?? 0 ) < ( other.Verse?.Number ?? 0 ) )
          return -1;
        else
          return 1;
      }

    }

  }

}