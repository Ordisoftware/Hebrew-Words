/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2022 Olivier Rogier.
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
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

/// <summary>
/// Provides reference item
/// </summary>
public partial class ReferenceItem
{

  public sealed class ReferenceComparer : IEqualityComparer<ReferenceItem>
  {

    bool IEqualityComparer<ReferenceItem>.Equals(ReferenceItem x, ReferenceItem y)
      => x == y;

    int IEqualityComparer<ReferenceItem>.GetHashCode(ReferenceItem obj)
      => obj?.GetHashCode() ?? 0;

  }

  public sealed class WordTranslationComparer : IEqualityComparer<ReferenceItem>
  {

    bool IEqualityComparer<ReferenceItem>.Equals(ReferenceItem x, ReferenceItem y)
      => x is not null && y is not null && ( x.Word?.Translation ?? "" ) == ( y.Word?.Translation ?? "" );

    int IEqualityComparer<ReferenceItem>.GetHashCode(ReferenceItem obj)
      => obj?.Word?.Translation.GetHashCode() ?? 0;

  }

}
