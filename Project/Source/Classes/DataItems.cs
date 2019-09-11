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

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// Provide book reference item
  /// </summary>
  public class BookItem
  {
    public Data.DataSet.BooksRow Book { get; set; }
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
    public Data.DataSet.ChaptersRow Chapter { get; set; }
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
    public Data.DataSet.BooksRow Book { get; set; }
    public Data.DataSet.ChaptersRow Chapter { get; set; }
    public Data.DataSet.VersesRow Verse { get; set; }
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
    public Data.DataSet.WordsRow Word { get; set; }
    public WordReferencedItem()
      : base()
    {
    }
    public WordReferencedItem(int book, int chapter, int verse)
      : base(book, chapter, verse)
    {
    }
  }

}