/// <license>
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
/// <edited> 2022-08 </edited>
namespace Ordisoftware.Hebrew.Words;

public partial class VerseRow
{

  // TODO debug error null after changing lang and go to filtered verse (need to reload combox or update bindings ?)
  public string NumberFormatted
    => FormatNumber(ApplicationDatabase.Instance.Chapters.Find(c => c.ID == ChapterID)?.Verses?.Count ?? 0);

  public override string ToString()
    => HasTranslation ? TranslationWithNumber : NumberFormatted;

  public string ToStringWithComment()
  {
    return _Comment.Length == 0 ? ToString() : ToString() + Globals.NL2 + _Comment;
  }

  /// <summary>
  /// Indicates the translation sentence of the verse with [...] in place of the untranslated words
  /// and with new lines replaced by spaces.
  /// </summary>
  public string Translation
    => Words.Select(word =>
    {
      var str = word.Translation;
      return str.Length > 0 ? str : "[...]";
    }).AsMultiSpace().Replace(Globals.NL, " ");

  public string TranslationWithNumber
    => NumberFormatted + ". " + Translation;

  /// <summary>
  /// Indicates the text of the word using the Hebrew font.
  /// </summary>
  public string AsHebrew
    => Words.Select(word => word.Hebrew).Reverse().AsMultiSpace();

  public string AsHebrewWithNumber
    => $"{NumberFormatted} : " + Words.Select(word => word.Hebrew).Reverse().AsMultiSpace();

  /// <summary>
  /// Indicates the text of the word using Unicode codes.
  /// </summary>
  public string AsUnicode
    => Words.Select(word => word.Unicode).AsMultiSpace();

  public string AsUnicodeWithNumber
    => $"{NumberFormatted} : " + Words.Select(word => word.Unicode).AsMultiSpace();

}
