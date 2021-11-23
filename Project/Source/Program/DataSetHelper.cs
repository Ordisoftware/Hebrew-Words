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
/// <created> 2019-09 </created>
/// <edited> 2021-04 </edited>
namespace Ordisoftware.Hebrew.Words;

using Ordisoftware.Hebrew.Words.Data;

static class DataSetHelper
{

  static public string GetTranslation(this DataSet.VersesRow verse)
  {
    var result = new StringBuilder();
    foreach ( DataSet.WordsRow word in verse.GetWordsRows() )
    {
      var str = word.Translation.Trim();
      result.Append(str.Length > 0 ? str + " " : "[...] ");
    }
    return result.ToString().Trim();
  }

  static public bool IsTranslated(this DataSet.VersesRow verse)
  {
    foreach ( DataSet.WordsRow word in verse.GetWordsRows() )
      if ( word.Translation.Trim().Length > 0 )
        return true;
    return false;
  }

  static public bool IsFullyTranslated(this DataSet.VersesRow verse)
  {
    foreach ( DataSet.WordsRow word in verse.GetWordsRows() )
      if ( word.Translation.Trim().Length == 0 )
        return false;
    return true;
  }

  static public bool IsPartiallyTranslated(this DataSet.VersesRow verse)
  {
    bool? haveEmpty = null;
    bool? haveTranslation = null;
    foreach ( DataSet.WordsRow word in verse.GetWordsRows() )
    {
      if ( word.Translation.Trim().Length == 0 )
        haveEmpty = true;
      if ( word.Translation.Trim().Length > 0 )
        haveTranslation = true;
      if ( haveEmpty == true && haveTranslation == true )
        return true;
    }
    return false;
  }

}
