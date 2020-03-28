/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2020 Olivier Rogier.
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
/// <edited> 2020-03 </edited>
using System;
using System.Linq;
using Ordisoftware.HebrewWords.Data;

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// Provide chapter reference item
  /// </summary>
  public class ChapterItem
  {

    public DataSet.ChaptersRow Chapter { get; set; }

    public override string ToString()
    {
      if ( Chapter == null ) return "";
      int nb = MainForm.Instance.CurrentReference.Book.GetChaptersRows().Count();
      string str = "";
      if ( nb >= 100 ) str = Chapter.Number.ToString("000");
      else
      if ( nb >= 10 ) str = Chapter.Number.ToString("00");
      else
      str = Chapter.Number.ToString();
      if ( Chapter.Memo != "" ) str += $" - {Chapter.Memo}";
      return str;
    }

    public ChapterItem(DataSet.ChaptersRow chapter)
    {
      Chapter = chapter;
    }

  }

}
