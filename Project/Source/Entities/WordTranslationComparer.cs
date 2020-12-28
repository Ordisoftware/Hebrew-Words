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
/// <created> 2016-04 </created>
/// <edited> 2019-09 </edited>
using System;
using System.Collections.Generic;

namespace Ordisoftware.Hebrew.Words
{

  class WordTranslationComparer : IEqualityComparer<ReferenceItem>
  {

    public bool Equals(ReferenceItem x, ReferenceItem y)
    {
      return !ReferenceEquals(x, null) && !ReferenceEquals(y, null)
          && ( x.Word?.Translation ?? "" ) == ( y.Word?.Translation ?? "" );
    }

    public int GetHashCode(ReferenceItem value)
    {
      return value?.Word?.Translation.GetHashCode() ?? 0;
    }

  }

}
