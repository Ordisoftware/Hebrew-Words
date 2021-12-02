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
/// Provide verse reference item
/// </summary>
class VerseItem
{

  public VerseRow Verse { get; set; }

  public override string ToString()
  {
    if ( Verse == null ) return "";
    int nb = ApplicationDatabase.Instance.AllChapters.Find(chapter => chapter.ID == Verse.ChapterID).Verses.Count;
    string str;
    if ( nb >= 100 )
      str = Verse.Number.ToString("000");
    else
    if ( nb >= 10 )
      str = Verse.Number.ToString("00");
    else
      str = Verse.Number.ToString();
    if ( Verse.IsTranslated() ) str += $" - {Verse.GetTranslation()}";
    return str;
  }

  public VerseItem(VerseRow verse)
  {
    Verse = verse;
  }

}
