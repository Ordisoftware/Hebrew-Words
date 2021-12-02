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
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

/// <summary>
/// Provide chapter reference item
/// </summary>
class ChapterItem
{

  public ChapterRow Chapter { get; set; }

  public override string ToString()
  {
    if ( Chapter == null ) return "";
    int nb = ApplicationDatabase.Instance.Books.Find(book => book.ID == Chapter.BookID).Chapters.Count;
    string str;
    if ( nb >= 100 )
      str = Chapter.Number.ToString("000");
    else
    if ( nb >= 10 )
      str = Chapter.Number.ToString("00");
    else
      str = Chapter.Number.ToString();
    if ( Chapter.Title.Length > 0 ) str += $" - {Chapter.Title}";
    return str;
  }

  public ChapterItem(ChapterRow chapter)
  {
    Chapter = chapter;
  }

}
