/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2021 Olivier Rogier.
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
/// <edited> 2021-04 </edited>
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Ordisoftware.Core;

namespace Ordisoftware.Hebrew.Words
{

  abstract class ReferencesList : IEnumerable<ReferenceItem>
  {

    protected readonly List<ReferenceItem> Items = new List<ReferenceItem>();

    protected string FilePath;

    public int Count { get { return Items.Count; } }

    public ReferenceItem this[int index] { get { return Items[index]; } }

    IEnumerator<ReferenceItem> IEnumerable<ReferenceItem>.GetEnumerator()
    {
      return Items.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return Items.GetEnumerator();
    }

    public void Clear()
    {
      Items.Clear();
      Save();
    }

    public void Sort()
    {
      Items.Sort();
    }

    public abstract void Add(ReferenceItem reference);

    public void Load()
    {
      Items.Clear();
      if ( !File.Exists(FilePath) )
        return;
      try
      {
        var list = File.ReadLines(FilePath);
        foreach ( string item in list )
        {
          if ( item == "" || item.Count(c => c == '.') != 2 )
            continue;
          var parts = item.Split('.');
          try
          {
            Items.Add(new ReferenceItem(Convert.ToInt32(parts[0]),
                                        Convert.ToInt32(parts[1]),
                                        Convert.ToInt32(parts[2])));
          }
          catch
          {
          }
        }
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
    }

    private bool Mutex;

    public void Save()
    {
      if ( Mutex ) return;
      Mutex = true;
      try
      {
        if ( Globals.IsLoadingData )
          return;
        var items = new List<string>();
        foreach ( var item in Items )
          items.Add(item.ToStringNumbers());
        File.WriteAllLines(FilePath, items);
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
      finally
      {
        Mutex = false;
      }
    }

    protected ReferencesList(string filePath)
    {
      FilePath = filePath;
    }
  }

}
