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

  public enum Books
  {
    // Torah
    Bereshit, Shemot, Vayiqra, Bamidbar, Devarim,
    // Neviim
    Yehoshoua, Shoftim, Shemouel_1, Shemouel_2, Melakhim_1, Melakhim_2,
    Isayah, Yirmyah, Yehezkel,
    Hosea, Yoel, Amos, Obadyah, Yonah, Mikah, Nahoum,
    Habaquq, Zefaniah, Hagai, Zakaria, Malaki,
    // Ketouvim
    Tehilim, Mishlei, Iyyov,
    Chir_HaChirim, Ruth, Eikha, Qohelet, Esther,
    Daniel, Ezra, Nehemiah, Divrei_HaYamim_1, Divrei_HaYamim_2
  };

  public enum TorahBooks
  {
    Bereshit = Books.Bereshit,
    Shemot = Books.Shemot,
    Vayiqra = Books.Vayiqra,
    Bamidbar = Books.Bamidbar,
    Devarim = Books.Devarim
  };

  static public class TorahHebrewNames
  {

    static public Dictionary<Books, string> Books = new Dictionary<Books, string>()
    {
      // Torah
      { HebrewWords.Books.Bereshit, "ty>arb" },
      { HebrewWords.Books.Shemot, "tvm>" },
      { HebrewWords.Books.Vayiqra, "arqyv" },
      { HebrewWords.Books.Bamidbar, "rbdmb" },
      { HebrewWords.Books.Devarim, "myrbd" },
      // Nevi'im
      { HebrewWords.Books.Yehoshoua, "i>vhy" },
      { HebrewWords.Books.Shoftim, "mytpv>" },
      { HebrewWords.Books.Shemouel_1, "" },
      { HebrewWords.Books.Shemouel_2, "" },
      { HebrewWords.Books.Melakhim_1, "" },
      { HebrewWords.Books.Melakhim_2, "" },
      { HebrewWords.Books.Isayah, "hyi>y" },
      { HebrewWords.Books.Yirmyah, "" },
      { HebrewWords.Books.Yehezkel, "laqzxy" },
      { HebrewWords.Books.Hosea, "" },
      { HebrewWords.Books.Yoel, "" },
      { HebrewWords.Books.Amos, "" },
      { HebrewWords.Books.Obadyah, "" },
      { HebrewWords.Books.Yonah, "" },
      { HebrewWords.Books.Mikah, "" },
      { HebrewWords.Books.Nahoum, "" },
      { HebrewWords.Books.Habaquq, "" },
      { HebrewWords.Books.Zefaniah, "" },
      { HebrewWords.Books.Hagai, "" },
      { HebrewWords.Books.Zakaria, "hyrkz" },
      { HebrewWords.Books.Malaki, "" },
      // Ketouvim
      { HebrewWords.Books.Tehilim, "mylht" },
      { HebrewWords.Books.Mishlei, "yl>m" },
      { HebrewWords.Books.Iyyov, "" },
      { HebrewWords.Books.Chir_HaChirim, "" },
      { HebrewWords.Books.Ruth, "" },
      { HebrewWords.Books.Eikha, "" },
      { HebrewWords.Books.Qohelet, "" },
      { HebrewWords.Books.Esther, "" },
      { HebrewWords.Books.Daniel, "" },
      { HebrewWords.Books.Ezra, "" },
      { HebrewWords.Books.Nehemiah, "" },
      { HebrewWords.Books.Divrei_HaYamim_1, "" },
      { HebrewWords.Books.Divrei_HaYamim_2, "" }
    };

  }
  
}
