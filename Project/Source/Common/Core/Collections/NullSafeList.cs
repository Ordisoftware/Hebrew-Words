﻿/// <license>
/// This file is part of Ordisoftware Core Library.
/// Copyright 2004-2025 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at
/// https://mozilla.org/MPL/2.0/.
/// If it is not possible or desirable to put the notice in a particular file,
/// then You may include the notice in a location(such as a LICENSE file in a
/// relevant directory) where a recipient would be likely to look for such a notice.
/// You may add additional accurate notices of copyright ownership.
/// </license>
/// <created> 2020-08 </created>
/// <edited> 2020-08 </edited>
namespace Ordisoftware.Core;

/// <summary>
/// Provides null safe list.
/// </summary>
[Serializable]
public class NullSafeList<T> : List<T>
where T : class
{

  public NullSafeList()
  {
  }

  public NullSafeList(int capacity) : base(capacity)
  {
  }

  public NullSafeList(IEnumerable<T> collection) : base(collection)
  {
  }

  public new T this[int index]
  {
    get
    {
      CheckIndex(index);
      return index < Count ? base[index] : null;
    }
    set
    {
      CheckIndex(index);
      if ( index < Count )
        base[index] = value;
      else
        CreateOutOfRange(index, value);
    }
  }

  private void CheckIndex(int index)
  {
    if ( index >= 0 ) return;
    string message = SysTranslations.IndexCantBeNegative.GetLang(nameof(NullSafeStringList), index);
    throw new IndexOutOfRangeException(message);
  }

  private void CreateOutOfRange(int index, T value)
  {
    Capacity = index + 1;
    int count = index + 1 - Count;
    for ( int i = 0; i < count; i++ )
      Add(null);
    base[index] = value;
  }

}
