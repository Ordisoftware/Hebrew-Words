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
/// <created> 2016-04 </created>
/// <edited> 2022-03 </edited>
namespace Ordisoftware.Hebrew.Words;

/// <summary>
/// Provides reference item
/// </summary>
public partial class ReferenceItem
{

  #region GetHashCode

  [SuppressMessage("Correctness", "SS008:GetHashCode() refers to mutable or static member", Justification = "Immutable")]
  public override int GetHashCode()
    => ( Book?.Number.GetHashCode() ?? 0 )
     ^ ( Chapter?.Number.GetHashCode() ?? 0 )
     ^ ( Verse?.Number.GetHashCode() ?? 0 );

  [SuppressMessage("Correctness", "SS008:GetHashCode() refers to mutable or static member", Justification = "Immutable")]
  public int GetHashCodeWordIncluded()
    => ( Book?.Number.GetHashCode() ?? 0 )
     ^ ( Chapter?.Number.GetHashCode() ?? 0 )
     ^ ( Verse?.Number.GetHashCode() ?? 0 )
     ^ ( Word?.Number.GetHashCode() ?? 0 );

  #endregion

  #region Overloads

  public static bool operator ==(ReferenceItem left, ReferenceItem right)
    => left is null
       ? right is null
       : left.CompareTo(right) == 0;

  public static bool operator !=(ReferenceItem left, ReferenceItem right)
    => left is null
       ? right is not null
       : left.CompareTo(right) != 0;

  public static bool operator <(ReferenceItem left, ReferenceItem right)
    => left is null
       ? right is not null
       : left.CompareTo(right) < 0;

  public static bool operator <=(ReferenceItem left, ReferenceItem right)
    => left is null
       ? right is null
       : left.CompareTo(right) <= 0;

  [SuppressMessage("Style", "IDE0075:Simplifier l’expression conditionnelle", Justification = "Opinion")]
  [SuppressMessage("Simplification", "RCS1104:Simplify conditional expression.", Justification = "Opinion")]
  [SuppressMessage("Minor Code Smell", "S1125:Boolean literals should not be redundant", Justification = "Opinion")]
  public static bool operator >(ReferenceItem left, ReferenceItem right)
    => left is null
       ? false
       : left.CompareTo(right) > 0;

  public static bool operator >=(ReferenceItem left, ReferenceItem right)
    => left is null
       ? right is null
       : left.CompareTo(right) >= 0;

  #endregion

  #region Equals

  [SuppressMessage("Style", "IDE0075:Simplifier l’expression conditionnelle", Justification = "Opinion")]
  [SuppressMessage("Simplification", "RCS1104:Simplify conditional expression.", Justification = "Opinion")]
  [SuppressMessage("Minor Code Smell", "S1125:Boolean literals should not be redundant", Justification = "Opinion")]
  public override bool Equals(object obj)
    => obj is ReferenceItem reference
       ? this == reference
       : false;

  [SuppressMessage("Design", "GCop129:Change to an instance method, instead of taking a parameter '{0}' with the same type as the class.", Justification = "N/A")]
  static public bool Equals(ReferenceItem instance, ReferenceItem instanceOther)
    => instance == instanceOther;

  public bool Equals(ReferenceItem other)
    => this == other;

  [SuppressMessage("Design", "GCop129:Change to an instance method, instead of taking a parameter '{0}' with the same type as the class.", Justification = "N/A")]
  static public bool EqualsWordIncluded(ReferenceItem reference, ReferenceItem referenceOther)
    => reference == referenceOther && ( reference.Word?.Number ?? 0 ) == ( referenceOther.Word?.Number ?? 0 );

  public bool EqualsWordIncluded(ReferenceItem other)
    => EqualsWordIncluded(this, other);

  #endregion

  #region CompareTo

  [SuppressMessage("Performance", "GCop317:This code is repeated {0} times in this method. If its value remains the same during the method execution, store it in a variable. Otherwise define a method (or Func<T> variable) instead of repeating the expression. [{1}]", Justification = "N/A")]
  public int CompareTo(ReferenceItem other)
  {
    if ( other is null )
      return Book is null && Chapter is null && Verse is null ? 0 : 1;
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

  [SuppressMessage("Performance", "GCop317:This code is repeated {0} times in this method. If its value remains the same during the method execution, store it in a variable. Otherwise define a method (or Func<T> variable) instead of repeating the expression. [{1}]", Justification = "N/A")]
  public int CompareToWordIncluded(ReferenceItem other)
  {
    if ( other is null )
      return Book is null && Chapter is null && Verse is null && Word is null ? 0 : 1;
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
