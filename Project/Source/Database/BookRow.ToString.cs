﻿/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2025 Olivier Rogier.
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
/// <edited> 2022-04 </edited>
namespace Ordisoftware.Hebrew.Words;

public partial class BookRow
{

  public override string ToString()
  {
    string str = $"{NumberFormatted}. {Transcription}";
    if ( CommonName.Length > 0 && Program.Settings.BookNameHebrewWithCommonName ) str += $" ({CommonName})";
    if ( Translation.Length > 0 ) str += $" - {Translation}";
    return str;
  }

  public string NumberFormatted
    => FormatNumber(ApplicationDatabase.Instance.Books.Count);

  public string ELS50AsHebrew
    => Chapters.Select(chapter => chapter.ELS50).AsMultiDoubleLine();

  public string ELS50AsHebrewWithNumber
    => Chapters.Select(chapter => chapter.ELS50AsHebrewWithNumber).AsMultiDoubleLine();

  public string ELS50AsUnicode
    => Chapters.Select(chapter => chapter.ELS50AsUnicode).AsMultiDoubleLine();

  public string ELS50AsUnicodeWithNumber
    => Chapters.Select(chapter => chapter.ELS50AsUnicodeWithNumber).AsMultiDoubleLine();

}
