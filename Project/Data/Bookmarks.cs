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
/// <created> 2019-09 </created>
/// <edited> 2019-09 </edited>
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Ordisoftware.Core;

namespace Ordisoftware.HebrewWords
{

  public class Bookmarks
  {

    private string Filename
    {
      get
      {
        return Program.UserDataFolderPath + "Bookmarks.txt";
      }
    }

    private readonly List<ReferenceItem> Items 
      = new List<ReferenceItem>();

    public void Load()
    {
      Items.Clear();
      if ( !File.Exists(Filename) )
        return;
      try
      {
        var list = File.ReadLines(Filename);
        for ( int index = list.Count() - 1; index >= 0; index-- )
        {
          string item = list.ElementAt(index);
          if ( item == "" || item.Count(c => c == '.') != 2 )
            continue;
          var parts = item.Split('.');
          Items.Add(new ReferenceItem(Convert.ToInt32(parts[0]),
                                      Convert.ToInt32(parts[1]),
                                      Convert.ToInt32(parts[2])));
        }
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
    }

    public void Save()
    {
      try
      {
        if ( MainForm.Instance.IsLoadingData )
          return;
        var items = new List<string>();
        foreach ( var reference in Items )
          items.Add(reference.ToStringNumbers());
        File.WriteAllLines(Filename, items);
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
    }

    public void Add(ReferenceItem reference)
    {
      if ( Program.Settings.BookmarksCount < 1 )
        return;
      foreach ( var value in Items )
        if ( value.Equals(reference) )
          return;
      Items.Insert(0, reference);
    }

  }

}
