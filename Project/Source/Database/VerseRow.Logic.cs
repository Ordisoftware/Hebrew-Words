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

  /// <summary>
  /// Indicates if the verse has at least one word translated.
  /// </summary>
  public bool HasTranslation
    => Words.Exists(word => word.Translation.Trim().Length > 0);

  /// <summary>
  /// Indicates if all the words of the verse are translated.
  /// </summary>
  public bool IsFullyTranslated
    => Words.TrueForAll(word => word.Translation.Trim().Length > 0);

  /// <summary>
  /// Indicates if all the words of the verse are not translated.
  /// </summary>
  /// <returns>True if none or not all words are translated.</returns>
  public bool IsFullyUntranslated
    => Words.TrueForAll(word => word.Translation.Trim().Length == 0);

  /// <summary>
  /// Indicates if at least one word is not translated while one is.
  /// </summary>
  public bool IsPartiallyTranslated
  {
    get
    {
      bool? haveEmpty = null;
      bool? haveTranslation = null;
      foreach ( int length in Words.Select(word => word.Translation.Trim().Length) )
      {
        if ( length == 0 ) haveEmpty = true;
        if ( length > 0 ) haveTranslation = true;
        if ( haveEmpty == true && haveTranslation == true ) return true;
      }
      return false;
    }
  }

}
