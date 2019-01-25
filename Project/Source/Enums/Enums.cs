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
    Zecharia, Joshua, Judges, Ezekiel,
    /* Samuel, Kings,*/ Isaiah, //Jeremiah, Hosea, Joel, Amos, Obadiah,
    // Jonah, Micah, Nahum, Habakkuk, Zephaniah, Haggai, Malachi,
    // Ketouvim
    /* Chronicles,*/ Tehilim, /*Job, */Proverbs //, Ruth, Song of Songs, Ecclesiastes, 
    // Lamentations, Esther, Daniel, Ezra, Nehemiah
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
    Zecharia = AllBooks.Zecharia,
    Joshua = AllBooks.Joshua,
    Judges = AllBooks.Judges,
    Ezekiel = AllBooks.Ezekiel,
    Isaiah = AllBooks.Isaiah
  };

  public enum KetouvimBooks
  {
    Tehilim = AllBooks.Tehilim,
    Proverbs = AllBooks.Proverbs,
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
      { AllBooks.Zecharia, "hyrkz rpc" },
      { AllBooks.Joshua, "i>vhy rpc" },
      { AllBooks.Judges, "mytpv> rpc" },
      { AllBooks.Ezekiel, "laqzxy rpc" },
      { AllBooks.Isaiah, "hyi>y rpc" },
      // Ketouvim
      { AllBooks.Tehilim, "mylht rpc" },
      { AllBooks.Proverbs, "yl>m rpc" }
    };

    static public Dictionary<string, string> Parashot = new Dictionary<string, string>()
    {
      { "01.01.1", "ty>arb t>rp" },
      { "09.06.1", "xn t>rp" },
      { "01.12.1", "kl kl t>rp" },
      { "01.18.1", "aryv t>rp" }
    };

  }

}