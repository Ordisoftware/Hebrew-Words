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
  /// Provide book combobox item
  /// </summary>
  public class BookItem
  {
    public Data.DataSet.BooksRow Row { get; set; }
    public override string ToString()
    {
      string str = Row.Number + ". " + Row.Name;
      if ( Row.Translation != "" ) str += " (" + Row.Translation + ")";
      return str;
    }
  }

  /// <summary>
  /// Provide chapter combobox item
  /// </summary>
  public class ChapterItem
  {
    public Data.DataSet.ChaptersRow Row { get; set; }
    public override string ToString()
    {
      return Row.Number.ToString();
    }
  }

  /// <summary>
  /// Provide reference item
  /// </summary>
  public class ReferenceItem
  {
    public int Book { get; set; }
    public int Chapter { get; set; }
    public int Verse { get; set; }
    public override string ToString()
    {
      return BooksNames.Hebrew[(Books)Book - 1] + " " + Chapter + "." + Verse;
    }
  }

  /// <summary>
  /// Provide reference item with word
  /// </summary>
  public class WordReferencedItem : ReferenceItem
  {
    public Data.DataSet.WordsRow Word { get; set; }
  }

}
