/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2016-2019 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at 
/// https://mozilla.org/MPL/2.0/.
/// If it is not possible or desirable to put the notice in a particular file, 
/// then You may include the notice in a location(such as a LICENSE file in a 
/// relevant directory) where a recipient would be likely to look for such a notice.
/// You may add additional accurate notices of copyright ownership.
/// </license>
/// <created> 2012-10 </created>
/// <edited> 2019-01 </edited>
using System;
using System.Collections.Generic;

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// Provide Hebrew Words default values.
  /// </summary>
  static public class Letters
  {

    /// <summary>
    /// Provide letter meaning translation
    /// </summary>
    public class MeaningTranslation : Dictionary<string, List<string>>
    {
    }

    /// <summary>
    /// Indicate letters keyboard codes.
    /// </summary>
    static public readonly string[] Codes = 
    {
      "a", "b", "g", "d", "h", "v", "z", "x", "u", "y", "k",
      "l", "m", "n", "c", "i", "p", "j", "q", "r", ">", "t"
    };

  }

}
