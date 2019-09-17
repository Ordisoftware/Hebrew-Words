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
using System;

namespace Ordisoftware.HebrewWords
{

  public enum Books
  {
    // Torah
    Bereshit, Shemot, Vayiqra, Bamidbar, Devarim,
    // Nevi'im
    Yehoshoua, Shoftim, Shemouel_I, Shemouel_II, Melakim_I, Melakim_II,
    Isayah, Yirmyah, Yehezqel,
    Hoshea, Yoel, Amos, Obadyah, Yonah, Mikah, Nahoum,
    Habaqouq, Tsephaniah, Hagai, Zekaria, Malaki,
    // Ketouvim
    Tehilim, Mishlei, Iyov,
    Shir_HaShirim, Routh, Eikah, Qohelet, Esther,
    Daniel, Ezra, Nehemiah, Divrei_HaYamim_I, Divrei_HaYamim_II
  };

  public enum TorahBooks
  {
    Bereshit = Books.Bereshit,
    Shemot = Books.Shemot,
    Vayiqra = Books.Vayiqra,
    Bamidbar = Books.Bamidbar,
    Devarim = Books.Devarim
  };

}
