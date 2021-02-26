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
/// <edited> 2019-09 </edited>
using System;
using Ordisoftware.Hebrew.Words.Data;
  
namespace Ordisoftware.Hebrew.Words
{

  static class DataSetHelper
  {

    static public string GetTranslation(this DataSet.VersesRow verse)
    {
      string result = "";
      foreach ( DataSet.WordsRow word in verse.GetWordsRows() )
      {
        var str = word.Translation.Trim();
        result += str != "" ? str + " " : "[...] ";
      }
      return result.Trim();
    }

    static public bool IsTranslated(this DataSet.VersesRow verse)
    {
      foreach ( DataSet.WordsRow word in verse.GetWordsRows() )
        if ( word.Translation.Trim() != "" )
          return true;
      return false;
    }

    static public bool IsFullyTranslated(this DataSet.VersesRow verse)
    {
      foreach ( DataSet.WordsRow word in verse.GetWordsRows() )
        if ( word.Translation.Trim() == "" )
          return false;
      return true;
    }

    static public bool IsPartiallyTranslated(this DataSet.VersesRow verse)
    {
      bool? haveEmpty = null;
      bool? haveTranslation = null;
      foreach ( DataSet.WordsRow word in verse.GetWordsRows() )
      {
        if ( word.Translation.Trim() == "" )
          haveEmpty = true;
        if ( word.Translation.Trim() != "" )
          haveTranslation = true;
        if ( haveEmpty.HasValue && haveEmpty.Value == true
          && haveTranslation.HasValue && haveTranslation.Value == true )
          return true;
      }
      return false;
    }

  }

}
