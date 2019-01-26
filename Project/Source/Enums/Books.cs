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
    Yehoshoua, Shoftim, Shemouel_1, Shemouel_2, Melakhim_1, Melakhim_2,
    Isayah, Yirmyah, Yehezkel,
    Hosea, Yoel, Amos, Obadyah, Yonah, Mikah, Nahoum,
    Habaquq, Zefaniah, Hagai, Zakarya, Malaki,
    // Ketouvim
    Tehilim, Mishlei, Iyyov,
    Chir_HaChirim, Ruth, Eikha, Qohelet, Esther,
    Daniel, Ezra, Nehemiah, Divrei_HaYamim_1, Divrei_HaYamim_2
  };

  static public class TorahHebrewNames
  {

    static public Dictionary<Book, string> Books = new Dictionary<Book, string>()
    {
      // Torah
      { Book.Bereshit, "ty>arb" },
      { Book.Shemot, "tvm>" },
      { Book.Vayiqra, "arqyv" },
      { Book.Bamidbar, "rbdmb" },
      { Book.Devarim, "myrbd" },
      // Nevi'im
      { Book.Yehoshoua, "i>vhy" },
      { Book.Shoftim, "mytpv>" },
      { Book.Shemouel_1, "" },
      { Book.Shemouel_2, "" },
      { Book.Melakhim_1, "" },
      { Book.Melakhim_2, "" },
      { Book.Isayah, "hyi>y" },
      { Book.Yirmyah, "" },
      { Book.Yehezkel, "laqzxy" },
      { Book.Hosea, "" },
      { Book.Yoel, "" },
      { Book.Amos, "" },
      { Book.Obadyah, "" },
      { Book.Yonah, "" },
      { Book.Mikah, "" },
      { Book.Nahoum, "" },
      { Book.Habaquq, "" },
      { Book.Zefaniah, "" },
      { Book.Hagai, "" },
      { Book.Zakarya, "hyrkz" },
      { Book.Malaki, "" },
      // Ketouvim
      { Book.Tehilim, "mylht" },
      { Book.Mishlei, "yl>m" },
      { Book.Iyyov, "" },
      { Book.Chir_HaChirim, "" },
      { Book.Ruth, "" },
      { Book.Eikha, "" },
      { Book.Qohelet, "" },
      { Book.Esther, "" },
      { Book.Daniel, "" },
      { Book.Ezra, "" },
      { Book.Nehemiah, "" },
      { Book.Divrei_HaYamim_1, "" },
      { Book.Divrei_HaYamim_2, "" }
    };

  }
  
}
