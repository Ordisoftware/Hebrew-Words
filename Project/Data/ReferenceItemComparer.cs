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
/// <created> 2016-04 </created>
/// <edited> 2019-09 </edited>
using System;
using System.Collections.Generic;

namespace Ordisoftware.HebrewWords
{

  class ReferenceItemComparer : IEqualityComparer<ReferenceItem>
  {

    public bool Equals(ReferenceItem x, ReferenceItem y)
    {
      if ( Object.ReferenceEquals(x, null) && !Object.ReferenceEquals(y, null) )
        return false;
      if ( !Object.ReferenceEquals(x, null) && Object.ReferenceEquals(y, null) )
        return false;
      return ( x.Book?.Number ?? 0 ) == ( y.Book?.Number ?? 0 )
          && ( x.Chapter?.Number ?? 0 ) == ( y.Chapter?.Number ?? 0 )
          && ( x.Verse?.Number ?? 0 ) == ( y.Verse?.Number ?? 0 );
    }

    public int GetHashCode(ReferenceItem value)
    {
      int hashBook = value.Book?.Number.GetHashCode() ?? 0;
      int hashChapter = value.Chapter?.Number.GetHashCode() ?? 0;
      int hashVerse = value.Verse?.Number.GetHashCode() ?? 0;
      return hashBook ^ hashChapter ^ hashVerse;
    }

  }

}
