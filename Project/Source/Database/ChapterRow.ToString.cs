/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2022 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at
/// https://mozilla.org/MPL/2.0/.
/// If it is not possible or desirable to put the notice in a particular file,
/// then You may include the notice in a location(such as a LICENSE file in a
/// relevant directory) where a recipient would be likely to look for such a notice.
/// You may add additional accurate notices of copyright ownership.
/// </license>
/// <created> 2021-12 </created>
/// <edited> 2022-08 </edited>
namespace Ordisoftware.Hebrew.Words;

public partial class ChapterRow
{

  public override string ToString()
  {
    return Title.Length > 0
      ? NumberFormatted + $". {Title}"
      : NumberFormatted;
  }

  public string NumberFormatted
    => FormatNumber(ApplicationDatabase.Instance.Books.Find(b => b.ID == BookID)?.Chapters.Count ?? 0);

  public string AsHebrew
    => Verses.Select(verse => verse.AsHebrew).AsMultiDoubleLine();

  public string AsHebrewWithNumber
    => Verses.Select(verse => verse.AsHebrewWithNumber).AsMultiDoubleLine();

  public string AsUnicode
    => Verses.Select(verse => verse.AsUnicode).AsMultiDoubleLine();

  public string AsUnicodeWithNumber
    => Verses.Select(verse => verse.AsUnicodeWithNumber).AsMultiDoubleLine();

  public string Translation
    => Verses.Select(verse => verse.ToString()).AsMultiDoubleLine();

  public string TranslationWithComments
    => Verses.Select(verse => verse.ToStringWithComment()).AsMultiDoubleLine();

  public string OnlyComments
    => Verses.Select(verse => $"{verse.Number} :{Globals.NL2}{verse.Comment}").AsMultiDoubleLine();

  public string HebrewWithTranslation
    => Verses.Select(verse => $"{verse.NumberFormatted}: {verse.AsHebrew}{Globals.NL2}{verse.Translation}").AsMultiDoubleLine();

  public string HebrewWithTranslationWithComments
    => Verses.Select(verse => $"{verse.NumberFormatted}: {verse.AsHebrew}{Globals.NL2}" +
                              ( verse.Comment.Length == 0
                                ? verse.Translation
                                : verse.Translation + Globals.NL2 + verse.Comment )).AsMultiDoubleLine();

  public string UnicodeWithTranslation
    => Verses.Select(verse => $"{verse.NumberFormatted}: {verse.AsUnicode}{Globals.NL2}{verse.Translation}").AsMultiDoubleLine();

  public string UnicodeWithTranslationWithComments
    => Verses.Select(verse => $"{verse.NumberFormatted}: {verse.AsUnicode}{Globals.NL2}" +
                              ( verse.Comment.Length == 0
                                ? verse.Translation
                                : verse.Translation + Globals.NL2 + verse.Comment )).AsMultiDoubleLine();

}
