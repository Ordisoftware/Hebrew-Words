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
/// <created> 2012-10 </created>
/// <edited> 2019-09 </edited>
using System;
using System.Collections.Generic;

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// Provide Hebrew Words default values.
  /// </summary>
  static public class Letters
  {

    /// <summary>
    /// Indicate letters keyboard codes.
    /// </summary>
    static public readonly string[] Codes = 
    {
      "a", "b", "g", "d", "h", "v", "z", "x", "u", "y", "k",
      "l", "m", "n", "c", "i", "p", "j", "q", "r", ">", "t"
    };

    /// <summary>
    /// Indicate finale letters enabled keys values.
    /// </summary>
    static private Dictionary<char, char> FinaleDisable = new Dictionary<char, char>()
    {
      { '!', 'k' }, { ',', 'm' }, { ']', 'n' }, { '[', 'p' }, { '/', 'j' }
    };

    /// <summary>
    /// Indicate finale letters disabled keys values.
    /// </summary>
    static private Dictionary<char, char> FinaleEnable = new Dictionary<char, char>()
    {
      { 'k', '!' }, { 'm', ',' }, { 'n', ']' }, { 'p', '[' }, { 'j', '/' }
    };

    /// <summary>
    // Convert finale letters from www.fourmilab.ch/etexts/www/hebrew/Bible.
    /// </summary>
    static public string SetFinale(string str, bool enable)
    {
      var array = enable ? FinaleEnable : FinaleDisable;
      str = str.Trim();
      if ( str.Length == 0 ) return str;
      char c = str[0];
      foreach ( var v in array )
        if ( c == v.Key )
        {
          c = v.Value;
          break;
        }
      str = c + str.Remove(0, 1);
      return str;
    }

    /// <summary>
    // Convert all finale letters to non finale.
    /// </summary>
    static public string UnFinaleAll(string str)
    {
      foreach ( var v in FinaleDisable )
        str = str.Replace(v.Key, v.Value);
      return str;
    }

    /// <summary>
    // Convert letters from www.fourmilab.ch/etexts/www/hebrew/Bible to font codes.
    /// </summary>
    static public char ConvertToKey(char c)
    {
      switch ( c )
      {
        case 'א': return 'a';
        case 'ב': return 'b';
        case 'ג': return 'g';
        case 'ד': return 'd';
        case 'ה': return 'h';
        case 'ו': return 'v';
        case 'ז': return 'z';
        case 'ח': return 'x';
        case 'ט': return 'u';
        case 'י': return 'y';
        case 'כ': return 'k';
        case 'ך': return '!';
        case 'ל': return 'l';
        case 'מ': return 'm';
        case 'ם': return ',';
        case 'נ': return 'n';
        case 'ן': return ']';
        case 'ס': return 'c';
        case 'ע': return 'i';
        case 'פ': return 'p';
        case 'ף': return '[';
        case 'צ': return 'j';
        case 'ץ': return '/';
        case 'ק': return 'q';
        case 'ר': return 'r';
        case 'ש': return '>';
        case 'ת': return 't';
        case ':': return '.';
        case '-': return ' ';
        default: return c;
      }
    }

  }

}
