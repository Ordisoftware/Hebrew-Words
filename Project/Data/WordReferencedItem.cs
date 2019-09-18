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
using Ordisoftware.HebrewWords.Data;

namespace Ordisoftware.HebrewWords
{

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
      try
      {
        Word = Verse.GetWordsRows()[word - 1];
      }
      catch
      {
        throw new Exception(String.Format("Bad word index: {0}.{1}.{2}:{3}", book, chapter, verse, word));
      }
    }

    public WordReferencedItem(ReferenceItem reference, DataSet.WordsRow word)
      : base(reference)
    {
      Word = word;
    }

    static public bool Equals(WordReferencedItem x, WordReferencedItem y)
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

    public bool Equals(WordReferencedItem y)
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
