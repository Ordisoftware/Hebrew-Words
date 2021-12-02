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
/// <created> 2021-12 </created>
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

public partial class VerseRow
{

  public string GetTranslation()
  {
    var result = new StringBuilder();
    foreach ( var str in Words.Select(word => word.Translation.Trim()) )
      result.Append(str.Length > 0 ? str + " " : "[...] ");
    return result.ToString().Trim();
  }

  public bool HasTranslation()
  {
    return Words.Any(word => word.Translation.Trim().Length > 0);
  }

  public bool IsFullyTranslated()
  {
    return Words.All(word => word.Translation.Trim().Length > 0);
  }

  public bool IsPartiallyTranslated()
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
