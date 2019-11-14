﻿/// <license>
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
/// <created> 2019-11 </created>
/// <edited> 2019-11 </edited>
using System;
using System.Linq;

namespace Ordisoftware.HebrewWords
{

  public class History : ReferencesList
  {

    public History()
    {
      Filename = Program.UserDataFolderPath + "History.txt";
    }

    public override void Add(ReferenceItem reference)
    {
      if ( Program.Settings.HistoryCount < 1 )
        return;
      foreach ( var item in Items.ToList() )
        if ( item.Equals(reference) )
          Items.Remove(item);
      Items.Insert(0, new ReferenceItem(reference));
      while ( Items.Count > Program.Settings.BookmarksCount )
        Items.RemoveAt(Items.Count - 1);
      Save();
    }

  }

}
