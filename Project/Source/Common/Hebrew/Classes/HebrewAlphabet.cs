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
/// <edited> 2021-08 </edited>
namespace Ordisoftware.Hebrew;

/// <summary>
/// Provides Hebrew letters class to manage Hebrew font and Unicode chars
/// from text available at www.fourmilab.ch/etexts/www/hebrew/Bible.
/// </summary>
static class HebrewAlphabet
{

  public const int ConcordanceFirst = 1;
  public const int ConcordanceLast = 8674;

  /// <summary>
  /// Indicates letters keyboard codes for Hebrew font.
  /// </summary>
  static public readonly string[] Codes =
  {
    "a", "b", "g", "d", "h", "v", "z", "x", "u", "y", "k",
    "l", "m", "n", "c", "i", "p", "j", "q", "r", ">", "t"
  };

  /// <summary>
  /// Indicates letters simple values.
  /// </summary>
  static public readonly int[] ValuesSimple =
  {
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20,
    30, 40, 50, 60, 70, 80, 90, 100, 200, 300, 400
  };

  /// <summary>
  /// Indicates letters full values.
  /// </summary>
  static public readonly int[] ValuesFull =
  {
    111, 412, 83, 434, 6, 12, 67, 418, 419, 20, 100,
    74, 90, 106, 120, 130, 81, 104, 186, 510, 360, 406
  };

  /// <summary>
  /// Indicates letters names in Hebrew font chars.
  /// </summary>
  static public readonly string[] Names =
  {
    "pla", "tyb", "lmyg", "tld", "ah", "vv", "]yz", "tx", "tu", "dvy", "pk",
    "dml", ",m", "]vn", "!mc", "]yi", "hp", "ydj", "pvq", ">r", "]y>", "vt",
  };


  /// <summary>
  /// Indicates final letters disabled keyboard codes for Hebrew font.
  /// </summary>
  static private readonly char[][] FinalDisable =
  {
    new char[] { '!', 'k' },
    new char[] { ',', 'm' },
    new char[] { ']', 'n' },
    new char[] { '[', 'p' },
    new char[] { '/', 'j' }
  };

  /// <summary>
  /// Indicates final letters enabled keyboard codes for Hebrew font.
  /// </summary>
  static private readonly char[][] FinalEnable =
  {
    new char[] { 'k', '!' },
    new char[] { 'm', ',' },
    new char[] { 'n', ']' },
    new char[] { 'p', '[' },
    new char[] { 'j', '/' }
  };

  /// <summary>
  /// Indicates if a string contains some Hebrew Unicode chars.
  /// </summary>
  static public bool ContainsUnicode(string str)
  {
    return !str.IsNullOrEmpty() && str.Any(c => c >= '\u0590' && c <= '\u05FF');
  }

  /// <summary>
  /// Indicates if a string contains only Hebrew Unicode chars or spaces regardless of diacritics and capitals.
  /// </summary>
  static public bool IsValidUnicode(string str)
  {
    str = str.RemoveDiacritics().ToLower();
    return !str.IsNullOrEmpty() && str.All(c => c == ' ' || c >= '\u0590' && c <= '\u05FF');
  }

  /// <summary>
  /// Indicates if a string contains only Hebrew font chars or spaces regardless of diacritics and capitals and finals.
  /// </summary>
  static public bool IsValidHebrew(string str)
  {
    str = UnFinalAll(str.RemoveDiacritics().ToLower());
    return !str.IsNullOrEmpty() && str.All(c => c == ' ' || Codes.Contains(c.ToString()));
  }

  /// <summary>
  /// Sets final letter.
  /// </summary>
  /// <param name="hebrew">The word in Hebrew font chars.</param>
  /// <param name="enable">On else off</param>
  static public string SetFinal(string hebrew, bool enable)
  {
    if ( hebrew.IsNullOrEmpty() ) return string.Empty;
    hebrew = hebrew.Trim();
    if ( hebrew.IsNullOrEmpty() ) return string.Empty;
    var array = enable ? FinalEnable : FinalDisable;
    char c = hebrew[0];
    foreach ( var v in array )
      if ( c == v[0] )
      {
        c = v[1];
        break;
      }
    return c + hebrew.Remove(0, 1);
  }

  /// <summary>
  /// Converts all final letters to non final.
  /// </summary>
  /// <param name="hebrew">The sentence having some words.</param>
  static public string UnFinalAll(string hebrew)
  {
    if ( hebrew.IsNullOrEmpty() ) return string.Empty;
    foreach ( var v in FinalDisable )
      hebrew = hebrew.Replace(v[0], v[1]);
    return hebrew;
  }

  /// <summary>
  /// Returns only allowed chars for Hebrew font.
  /// </summary>
  static public string OnlyHebrewFont(string str)
  {
    if ( str.IsNullOrEmpty() ) return string.Empty;
    var result = new StringBuilder();
    str = UnFinalAll(str);
    foreach ( var c in str.RemoveDiacritics().ToLower().Where(c => Codes.Contains(c.ToString())) )
      result.Append(c);
    return result.ToString();
  }

  /// <summary>
  /// Returns only allowed chars for Hebrew font.
  /// </summary>
  static public string OnlyUnicode(string str)
  {
    if ( str.IsNullOrEmpty() ) return string.Empty;
    var result = new StringBuilder();
    foreach ( char c in str.RemoveDiacritics().ToLower() )
      if ( c >= '\u0590' && c <= '\u05FF' )
        result.Append(c);
    return result.ToString();
  }

  /// <summary>
  /// Converts Unicode Hebrew chars to Hebrew font chars.
  /// </summary>
  static public string ToHebrewFont(string Unicode)
  {
    if ( Unicode.IsNullOrEmpty() ) return string.Empty;
    string result = string.Empty;
    foreach ( char c in Unicode.RemoveDiacritics().ToLower() )
      result = UnicodeToHebrew(c) + result;
    return result;
  }

  /// <summary>
  /// Converts Hebrew font chars to Unicode Hebrew chars.
  /// </summary>
  static public string ToUnicode(string str)
  {
    if ( str.IsNullOrEmpty() ) return string.Empty;
    string result = string.Empty;
    foreach ( char c in str.RemoveDiacritics().ToLower() )
      result = HebrewToUnicode(c) + result;
    return result;
  }

  /// <summary>
  /// Converts Unicode Hebrew chars to Hebrew font chars.
  /// </summary>
  static public char UnicodeToHebrew(char c)
  {
    return c switch
    {
      'א' => 'a',
      'ב' => 'b',
      'ג' => 'g',
      'ד' => 'd',
      'ה' => 'h',
      'ו' => 'v',
      'ז' => 'z',
      'ח' => 'x',
      'ט' => 'u',
      'י' => 'y',
      'כ' => 'k',
      'ך' => '!',
      'ל' => 'l',
      'מ' => 'm',
      'ם' => ',',
      'נ' => 'n',
      'ן' => ']',
      'ס' => 'c',
      'ע' => 'i',
      'פ' => 'p',
      'ף' => '[',
      'צ' => 'j',
      'ץ' => '/',
      'ק' => 'q',
      'ר' => 'r',
      'ש' => '>',
      'ת' => 't',
      ':' => '.',
      '-' => ' ',
      _ => ' ',
    };
  }

  /// <summary>
  /// Converts Hebrew font chars to Unicode Hebrew chars.
  /// </summary>
  static public char HebrewToUnicode(char c)
  {
    return c switch
    {
      'a' => 'א',
      'b' => 'ב',
      'g' => 'ג',
      'd' => 'ד',
      'h' => 'ה',
      'v' => 'ו',
      'z' => 'ז',
      'x' => 'ח',
      'u' => 'ט',
      'y' => 'י',
      'k' => 'כ',
      '!' => 'ך',
      'l' => 'ל',
      'm' => 'מ',
      ',' => 'ם',
      'n' => 'נ',
      ']' => 'ן',
      'c' => 'ס',
      'i' => 'ע',
      'p' => 'פ',
      '[' => 'ף',
      'j' => 'צ',
      '/' => 'ץ',
      'q' => 'ק',
      'r' => 'ר',
      '>' => 'ש',
      't' => 'ת',
      '.' => ':',
      ' ' => ' ',
      _ => ' ',
    };
  }

}