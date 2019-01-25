/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2019 Olivier Rogier. 
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
using System.Collections.Generic;

namespace Ordisoftware.HebrewWords
{

  public enum Book
  {
    // Torah
    Bereshit, Shemot, Vayiqra, Bamidbar, Devarim,
    // Neviim
    Yehoshoua, Shoftim, Shemouel, Melakhim,
    Isayah, Yirmyah, Yehezkel,
    Hosea, Yoel, Amos, Obadyah, Yonah, Mikah, Nahoum,
    Habaquq, Zefaniah, Hagai, Zakarya, Malaki,
    // Ketouvim
    Tehilim, Mishlei, Iyyov,
    ChirHaChirim, Ruth, Eikha, Qohelet, Esther,
    Daniel, Ezra, Nehemiah, DivreiHaYamim
  };

  static public class TorahHebrewNames
  {

    static public Dictionary<Book, string> Books = new Dictionary<Book, string>()
    {
      // Torah
      { Book.Bereshit, "ty>arb rpc" },
      { Book.Shemot, "tvm> rpc" },
      { Book.Vayiqra, "arqyv rpc" },
      { Book.Bamidbar, "rbdmb rpc" },
      { Book.Devarim, "myrbd rpc" },
      // Nevi'im
      { Book.Yehoshoua, "i>vhy rpc" },
      { Book.Shoftim, "mytpv> rpc" },
      { Book.Shemouel, "" },
      { Book.Melakhim, "" },
      { Book.Isayah, "hyi>y rpc" },
      { Book.Yirmyah, "" },
      { Book.Yehezkel, "laqzxy rpc" },

      { Book.Zakarya, "hyrkz rpc" },
      // Ketouvim
      { Book.Tehilim, "mylht rpc" },
      { Book.Mishlei, "yl>m rpc" },
      { Book.Iyyov, "" },
    };

  }
  
}
