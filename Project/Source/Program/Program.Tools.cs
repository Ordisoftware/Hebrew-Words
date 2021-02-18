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
/// <edited> 2020-04 </edited>
using System;
using Ordisoftware.Core;

namespace Ordisoftware.Hebrew.Words
{

  /// <summary>
  /// Provide Program class.
  /// </summary>
  static partial class Program
  {

    /// <summary>
    /// Start Hebrew Letters process.
    /// </summary>
    /// <param name="hebrew">The hebrew font chars of teh word.</param>
    static public void OpenHebrewLetters(string hebrew)
    {
      HebrewTools.OpenHebrewLetters(hebrew, Settings.HebrewLettersExe);
    }

    /// <summary>
    /// Open default online concordance search url.
    /// </summary>
    /// <param name="hebrew">The hebrew font chars of teh word.</param>
    static public void OpenOnlineConcordance(string hebrew)
    {
      SystemManager.RunShell(Settings.SearchOnlineURL.Replace("%WORD%", hebrew));
    }

  }

}
