﻿/// <license>
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
using System.Globalization;
using System.Linq;
using System.Text;

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// Provide localization.
  /// </summary>
  static public class Localizer
  {

    static public readonly string[] AvailableLanguages = { "en", "fr" };

    static public readonly string DefaultLanguage = "en";

    static public string Language
    {
      get
      {
        string lang = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
        if ( !AvailableLanguages.Contains(lang) )
          lang = DefaultLanguage;
        return lang;
      }
    }

    /// <summary>
    /// Get the string translation.
    /// </summary>
    /// <param name="values">The dictionary containing langs>translations.</param>
    /// <returns></returns>
    static public string GetLang(this Dictionary<string, string> values)
    {
      return values[Language];
    }

    /// <summary>
    /// Get the string translation.
    /// </summary>
    /// <param name="values">The dictionary containing langs>translations.</param>
    /// <returns></returns>
    static public string GetLang(this Dictionary<string, string> values, params object[] parameters)
    {
      return String.Format(values.GetLang(), parameters);
    }

    /// <summary>
    /// Get the string list translation.
    /// </summary>
    /// <param name="values">The dictionary containing langs>translations.</param>
    /// <returns></returns>
    static public string[] GetLang(this Dictionary<string, string[]> values)
    {
      return values[Language];
    }

    /// <summary>
    /// Get the string translation of an enum value.
    /// </summary>
    /// <typeparam name="T">The type that is an enum.</typeparam>
    /// <param name="values">The dictionary containing values>langs>translations.</param>
    /// <param name="value">The value to translate.</param>
    /// <returns></returns>
    static public string GetLang<T>(this Dictionary<T, Dictionary<string, string>> values, T value)
    {
      return values[value][Language];
    }

    /// <summary>
    /// Remove diacritics letters.
    /// </summary>
    public static string RemoveDiacritics(this string text)
    {
      if ( string.IsNullOrEmpty(text) )
        return string.Empty;
      var normalizedString = text.Normalize(NormalizationForm.FormD);
      var stringBuilder = new StringBuilder();
      foreach ( var c in normalizedString )
      {
        var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
        if ( unicodeCategory != UnicodeCategory.NonSpacingMark )
          stringBuilder.Append(c);
      }
      return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
    }

  }

}
