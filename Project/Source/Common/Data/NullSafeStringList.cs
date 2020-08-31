﻿/// <license>
/// This file is part of Ordisoftware Hebrew Calendar/Letters/Words.
/// Copyright 2012-2020 Olivier Rogier.
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
using System;
using System.Linq;
using System.Collections.Generic;

namespace Ordisoftware.HebrewCommon
{

  /// <summary>
  /// Provide null safe string list.
  /// </summary>
  public class NullSafeStringList : List<string>
  {

    public NullSafeStringList()
    {
    }

    public NullSafeStringList(int capacity) : base(capacity)
    {
    }

    public NullSafeStringList(IEnumerable<string> collection) : base(collection)
    {
    }

    public new string this[int index]
    {
      get
      {
        CheckIndex(index);
        return index < Count ? base[index] : "";
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
      if ( index < 0 )
        throw new IndexOutOfRangeException(Localizer.IndexCantBeNegative.GetLang(nameof(NullSafeStringList), index));
    }

    private void CreateOutOfRange(int index, string value)
    {
      Capacity = index + 1;
      AddRange(Enumerable.Repeat("", index + 1 - Count));
      base[index] = value;
    }

  }

}
