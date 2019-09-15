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
using System.Collections.Generic;

namespace Ordisoftware.HebrewWords
{

  static public class BooksNames
  {

    static public Dictionary<Books, string> Hebrew = new Dictionary<Books, string>()
    {
      // Torah
      { Books.Bereshit, "ty>arb" },
      { Books.Shemot, "tvm>" },
      { Books.Vayiqra, "arqyv" },
      { Books.Bamidbar, "rbdmb" },
      { Books.Devarim, "myrbd" },
      // Nevi'im
      { Books.Yehoshoua, "i>vhy" },
      { Books.Shoftim, "mytpv>" },
      { Books.Shemouel_1, "a lavm>" },
      { Books.Shemouel_2, "b lavm>" },
      { Books.Melakim_1, "a myklm" },
      { Books.Melakim_2, "b myklm" },
      { Books.Isayah, "hyi>y" },
      { Books.Yirmyah, "hymry" },
      { Books.Yehezkel, "laqzxy" },
      { Books.Hosea, "i>vh" },
      { Books.Yoel, "lavy" },
      { Books.Amos, "cvmi" },
      { Books.Obadyah, "hydbvi" },
      { Books.Yonah, "hnvy" },
      { Books.Mikah, "hkym" },
      { Books.Nahoum, "mvxn" },
      { Books.Habaquq, "qvqbx" },
      { Books.Zefaniah, "hynpj" },
      { Books.Hagai, "ygx" },
      { Books.Zakaria, "hyrkz" },
      { Books.Malaki, "ykalm" },
      // Ketouvim
      { Books.Tehilim, "mylht" },
      { Books.Mishlei, "yl>m" },
      { Books.Iyyov, "bvya" },
      { Books.Chir_HaChirim, "myry>h ry>" },
      { Books.Ruth, "tvr" },
      { Books.Eikha, "hkya" },
      { Books.Qohelet, "tlhq" },
      { Books.Esther, "rtsa" },
      { Books.Daniel, "lanyd" },
      { Books.Ezra, "arzi" },
      { Books.Nehemiah, "hymxn" },
      { Books.Divrei_HaYamim_1, "a mymyh yrbd" },
      { Books.Divrei_HaYamim_2, "b mymyh yrbd" }
    };

    static public Dictionary<Books, string> StudyBible = new Dictionary<Books, string>()
    {
      // Torah
      { Books.Bereshit, "Genesis" },
      { Books.Shemot, "Exodus" },
      { Books.Vayiqra, "Leviticus" },
      { Books.Bamidbar, "Numbers" },
      { Books.Devarim, "Deuteronomy" },
      // Nevi'im
      { Books.Yehoshoua, "Joshua" },
      { Books.Shoftim, "Judges" },
      { Books.Shemouel_1, "1 Samuel" },
      { Books.Shemouel_2, "2 Samuel" },
      { Books.Melakim_1, "1 Kings" },
      { Books.Melakim_2, "2 Kings" },
      { Books.Isayah, "Isaiah" },
      { Books.Yirmyah, "Jeremiah" },
      { Books.Yehezkel, "Ezekiel" },
      { Books.Hosea, "Hosea" },
      { Books.Yoel, "Joel" },
      { Books.Amos, "Amos" },
      { Books.Obadyah, "Obadiah" },
      { Books.Yonah, "Jonah" },
      { Books.Mikah, "Micah" },
      { Books.Nahoum, "Nahum" },
      { Books.Habaquq, "Habakkuk" },
      { Books.Zefaniah, "Zephaniah" },
      { Books.Hagai, "Haggai" },
      { Books.Zakaria, "Zechariah" },
      { Books.Malaki, "Malachi" },
      // Ketouvim
      { Books.Tehilim, "Psalms" },
      { Books.Mishlei, "Proverbs" },
      { Books.Iyyov, "Job" },
      { Books.Chir_HaChirim, "Song of Songs" },
      { Books.Ruth, "Ruth" },
      { Books.Eikha, "Lamentations" },
      { Books.Qohelet, "Ecclesiastes" },
      { Books.Esther, "Esther" },
      { Books.Daniel, "Daniel" },
      { Books.Ezra, "Ezra" },
      { Books.Nehemiah, "Nehemiah" },
      { Books.Divrei_HaYamim_1, "1 Chronicles" },
      { Books.Divrei_HaYamim_2, "2 Chronicles" }
    };

  }

}
