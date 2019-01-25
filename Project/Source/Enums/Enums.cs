/// <license>
/// This file is part of Ordisoftware Hebrew Letters.
/// Copyright 2012-2015 Olivier Rogier. 
/// See www.ordisoftware.com for more information.
/// Project is registered at Depotnumerique.com (Agence des Depots Numeriques).
/// This program is free software: you can redistribute it and/or modify it under the terms of
/// the GNU General Public License (GPL v3) as published by the Free Software Foundation,
/// either version 3 of the License, or (at your option) any later version.
/// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
/// without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
/// See the GNU General Public License for more details.
/// You should have received a copy of the GNU General Public License along with this program.
/// If not, see www.gnu.org/licenses website.
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