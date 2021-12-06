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
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

/// <summary>
/// Provides reference item
/// </summary>
partial class ReferenceItem
{

  #region Overloads

  public static bool operator ==(ReferenceItem left, ReferenceItem right)
  {
    if ( left is null )
      return right is null;
    else
      return left.CompareTo(right) == 0;
  }

  public static bool operator !=(ReferenceItem left, ReferenceItem right)
  {
    if ( left is null )
      return right is not null;
    else
      return left.CompareTo(right) != 0;
  }

  public static bool operator <(ReferenceItem left, ReferenceItem right)
  {
    return left.CompareTo(right) < 0;
  }

  public static bool operator <=(ReferenceItem left, ReferenceItem right)
  {
    return left.CompareTo(right) <= 0;
  }

  public static bool operator >(ReferenceItem left, ReferenceItem right)
  {
    return left.CompareTo(right) > 0;
  }

  public static bool operator >=(ReferenceItem left, ReferenceItem right)
  {
    return left.CompareTo(right) >= 0;
  }

  #endregion

  #region Equals

  static public bool Equals(ReferenceItem x, ReferenceItem y)
  {
    return x != null
        && y != null
        && ( x.Book?.Number ?? 0 ) == ( y.Book?.Number ?? 0 )
        && ( x.Chapter?.Number ?? 0 ) == ( y.Chapter?.Number ?? 0 )
        && ( x.Verse?.Number ?? 0 ) == ( y.Verse?.Number ?? 0 );
  }

  public override bool Equals(object obj)
  {
    return Equals(this, obj as ReferenceItem);
  }

  public bool Equals(ReferenceItem other)
  {
    return Equals(this, other);
  }

  static public bool EqualsWordIncluded(ReferenceItem x, ReferenceItem y)
  {
    return x != null
        && y != null
        && ( x.Book?.Number ?? 0 ) == ( y.Book?.Number ?? 0 )
        && ( x.Chapter?.Number ?? 0 ) == ( y.Chapter?.Number ?? 0 )
        && ( x.Verse?.Number ?? 0 ) == ( y.Verse?.Number ?? 0 )
        && ( x.Word?.Number ?? 0 ) == ( y.Word?.Number ?? 0 );
  }

  public bool EqualsWordIncluded(ReferenceItem y)
  {
    return EqualsWordIncluded(this, y);
  }

  #endregion

  #region CompareTo

  public int CompareTo(ReferenceItem other)
  {
    if ( other == null )
    {
      if ( Book == null && Chapter == null && Verse == null )
        return 0;
      else
        return 1;
    }
    else
    if ( ( Book?.Number ?? 0 ) == ( other.Book?.Number ?? 0 )
      && ( Chapter?.Number ?? 0 ) == ( other.Chapter?.Number ?? 0 )
      && ( Verse?.Number ?? 0 ) == ( other.Verse?.Number ?? 0 ) )
      return 0;
    else
    if ( ( Book?.Number ?? 0 ) < ( other.Book?.Number ?? 0 ) )
      return -1;
    else
    if ( ( Book?.Number ?? 0 ) == ( other.Book?.Number ?? 0 )
      && ( Chapter?.Number ?? 0 ) < ( other.Chapter?.Number ?? 0 ) )
      return -1;
    else
    if ( ( Book?.Number ?? 0 ) == ( other.Book?.Number ?? 0 )
      && ( Chapter?.Number ?? 0 ) == ( other.Chapter?.Number ?? 0 )
      && ( Verse?.Number ?? 0 ) < ( other.Verse?.Number ?? 0 ) )
      return -1;
    else
      return 1;
  }

  public int CompareToWordIncluded(ReferenceItem other)
  {
    if ( other == null )
    {
      if ( Book == null && Chapter == null && Verse == null && Word == null )
        return 0;
      else
        return 1;
    }
    else
    if ( ( Book?.Number ?? 0 ) == ( other.Book?.Number ?? 0 )
      && ( Chapter?.Number ?? 0 ) == ( other.Chapter?.Number ?? 0 )
      && ( Verse?.Number ?? 0 ) == ( other.Verse?.Number ?? 0 )
      && ( Word?.Number ?? 0 ) == ( other.Word?.Number ?? 0 ) )
      return 0;
    else
    if ( ( Book?.Number ?? 0 ) < ( other.Book?.Number ?? 0 ) )
      return -1;
    else
    if ( ( Book?.Number ?? 0 ) == ( other.Book?.Number ?? 0 )
      && ( Chapter?.Number ?? 0 ) < ( other.Chapter?.Number ?? 0 ) )
      return -1;
    else
    if ( ( Book?.Number ?? 0 ) == ( other.Book?.Number ?? 0 )
      && ( Chapter?.Number ?? 0 ) == ( other.Chapter?.Number ?? 0 )
      && ( Verse?.Number ?? 0 ) < ( other.Verse?.Number ?? 0 ) )
      return -1;
    else
    if ( ( Book?.Number ?? 0 ) == ( other.Book?.Number ?? 0 )
      && ( Chapter?.Number ?? 0 ) == ( other.Chapter?.Number ?? 0 )
      && ( Verse?.Number ?? 0 ) == ( other.Verse?.Number ?? 0 )
      && ( Word?.Number ?? 0 ) < ( other.Word?.Number ?? 0 ) )
      return -1;
    else
      return 1;
  }

  #endregion

}
