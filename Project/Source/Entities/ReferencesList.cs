/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2025 Olivier Rogier.
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
/// <edited> 2022-03 </edited>
namespace Ordisoftware.Hebrew.Words;

abstract class ReferencesList : IEnumerable<ReferenceItem>
{

  private bool Mutex;

  protected readonly List<ReferenceItem> Items = [];

  protected readonly string FilePath;

  public int Count => Items.Count;

  public ReferenceItem this[int index] => Items[index];

  IEnumerator<ReferenceItem> IEnumerable<ReferenceItem>.GetEnumerator() => Items.GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator() => Items.GetEnumerator();

  public abstract void Add(ReferenceItem reference);

  public void Clear()
  {
    Items.Clear();
    Save();
  }

  public void Sort()
  {
    Items.Sort();
    Save();
  }

  public void Load(Action actionAfter)
  {
    Items.Clear();
    if ( !File.Exists(FilePath) ) return;
    try
    {
      foreach ( var item in File.ReadLines(FilePath).Where(item => item.Length != 0
                                                                && item.Where(c => c == '.').Take(3).Count() == 2) )
      {
        var parts = item.Split('.');
        SystemManager.TryCatch(() => Items.Add(new ReferenceItem(Convert.ToInt32(parts[0]),
                                                                 Convert.ToInt32(parts[1]),
                                                                 Convert.ToInt32(parts[2]))));
      }
    }
    catch ( Exception ex )
    {
      ex.Manage();
    }
    finally
    {
      actionAfter?.Invoke();
    }
  }

  public void Save()
  {
    if ( Globals.IsLoadingData || Mutex ) return;
    Mutex = true;
    try
    {
      var items = new List<string>();
      foreach ( var item in Items )
        items.Add(item.ToStringOnlyNumbers());
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
