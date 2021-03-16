﻿/// <license>
/// This file is part of Ordisoftware Hebrew Calendar/Letters/Words.
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
/// <created> 2012-10 </created>
/// <edited> 2021-02 </edited>
using System;
using Ordisoftware.Core;

namespace Ordisoftware.Hebrew
{

  public struct BookBound
  {
    public int Min;
    public int Max;
  }

  static partial class BooksBounds
  {
    static public readonly BookBound Torah = new BookBound
    {
      Min = EnumHelper.Min<TorahBooks>() + 1,
      Max = EnumHelper.Max<TorahBooks>() + 1
    };
    static public readonly BookBound Neviim = new BookBound
    {
      Min = EnumHelper.Min<NeviimBooks>() + 1,
      Max = EnumHelper.Max<NeviimBooks>() + 1
    };
    static public readonly BookBound Ketouvim = new BookBound
    {
      Min = EnumHelper.Min<KetouvimBooks>() + 1,
      Max = EnumHelper.Max<KetouvimBooks>() + 1
    };
  }

}
