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
/// Provides sorted auto dictionary.
/// </summary>
[Serializable]
public class SortedAutoDictionary<TKey, TValue> : SortedDictionary<TKey, TValue>
where TValue : new()
{

  public SortedAutoDictionary()
  {
  }

  public SortedAutoDictionary(IDictionary<TKey, TValue> dictionary) : base(dictionary)
  {
  }

  public SortedAutoDictionary(IComparer<TKey> comparer) : base(comparer)
  {
  }

  public SortedAutoDictionary(IDictionary<TKey, TValue> dictionary, IComparer<TKey> comparer) : base(dictionary, comparer)
  {
  }

  public new TValue this[TKey key]
  {
    get
    {
      if ( TryGetValue(key, out TValue value) ) return value;
      var valueNew = new TValue();
      Add(key, valueNew);
      return valueNew;
    }
    set
    {
      if ( ContainsKey(key) )
        base[key] = value;
      else
        Add(key, value);
    }
  }

}
