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
/// <edited> 2015-06 </edited>
using System.Collections.Generic;

namespace Ordisoftware.HebrewWords
{

  public enum AllBooks
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

  public enum TorahBooks
  {
    Bereshit = AllBooks.Bereshit,
    Shemot = AllBooks.Shemot,
    Vayiqra = AllBooks.Vayiqra,
    Bamidbar = AllBooks.Bamidbar,
    Devarim = AllBooks.Devarim
  };

  public enum NeviimBooks
  {
    Joshua = AllBooks.Yehoshoua,
    Judges = AllBooks.Shoftim,
    Isaiah = AllBooks.Isayah,
    Ezekiel = AllBooks.Yehezkel,
    Zekaria = AllBooks.Zakarya
  };

  public enum KetouvimBooks
  {
    Tehilim = AllBooks.Tehilim,
    Mishlei = AllBooks.Mishlei,
  };

  static public class TorahHebrewNames
  {

    static public Dictionary<AllBooks, string> Books = new Dictionary<AllBooks, string>()
    {
      // Torah
      { AllBooks.Bereshit, "ty>arb rpc" },
      { AllBooks.Shemot, "tvm> rpc" },
      { AllBooks.Vayiqra, "arqyv rpc" },
      { AllBooks.Bamidbar, "rbdmb rpc" },
      { AllBooks.Devarim, "myrbd rpc" },
      // Nevi'im
      { AllBooks.Zakarya, "hyrkz rpc" },
      { AllBooks.Yehoshoua, "i>vhy rpc" },
      { AllBooks.Shoftim, "mytpv> rpc" },
      { AllBooks.Yehezkel, "laqzxy rpc" },
      { AllBooks.Isayah, "hyi>y rpc" },
      // Ketouvim
      { AllBooks.Tehilim, "mylht rpc" },
      { AllBooks.Mishlei, "yl>m rpc" }
    };

  }

}