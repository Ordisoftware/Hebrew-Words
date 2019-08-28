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
/// <edited> 2019-05 </edited>
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// Provide localization.
  /// </summary>
  static public class Localizer
  {

    /// <summary>
    /// Get the string translation.
    /// </summary>
    /// <param name="values">The dictionary containing langs>translations.</param>
    /// <returns></returns>
    static public string GetLang(this Dictionary<string, string> values)
    {
      string lang = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
      if ( !values.ContainsKey(lang) ) lang = "en";
      return values[lang];
    }

    /// <summary>
    /// Get the string list translation.
    /// </summary>
    /// <param name="values">The dictionary containing langs>translations.</param>
    /// <returns></returns>
    static public string[] GetLang(this Dictionary<string, string[]> values)
    {
      string lang = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
      if ( !values.ContainsKey(lang) ) lang = "en";
      return values[lang];
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
      string lang = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
      if ( !values[value].ContainsKey(lang) ) lang = "en";
      return values[value][lang];
    }

    /// <summary>
    /// Return the string list translation of a Dico list.
    /// </summary>
    /// <param name="index">The index.</param>
    /// <returns></returns>
    static public List<string> GetLang(this List<Letters.MeaningTranslation> values, int index)
    {
      string lang = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
      if ( !values[index].ContainsKey(lang) ) lang = "en";
      List<string> value;
      values[index].TryGetValue(lang, out value);
      return value;
    }

    static public readonly Dictionary<string, string> ApplicationDescriptionText
      = new Dictionary<string, string>()
      {
        { "en", "A tool that helps for the translation of the Bible's hebrew words" },
        { "fr", "Un utilitaire qui aide à la traduction des mots hébreux de la Bible" }
      };

    static public readonly Dictionary<string, string> ExitApplicationText
      = new Dictionary<string, string>()
      {
        { "en", "Exit application?" },
        { "fr", "Quitter l'application ?" }
      };

    static public readonly Dictionary<string, string> CheckUpdateNoNewText
      = new Dictionary<string, string>()
      {
        { "en", "There is no new version available." },
        { "fr", "Il n'y a pas de nouvelle version de disponible." }
      };

    static public readonly Dictionary<string, string> CheckUpdateResultText
      = new Dictionary<string, string>()
      {
        { "en", "A newer version is available : " },
        { "fr", "Une nouvelle version est disponible : " }
      };

    static public readonly Dictionary<string, string> CheckUpdateAskDownloadText
      = new Dictionary<string, string>()
      {
        { "en", "Do you want to open the download page?" },
        { "fr", "Voulez-vous ouvrir la page de téléchargement ?" }
      };

    static public readonly Dictionary<string, string> RestoreWinPosText
      = new Dictionary<string, string>()
      {
        { "en", "This action will restore windows position." + Environment.NewLine + Environment.NewLine +
                "Do you want to continue?" },
        { "fr", "Cette action va restaurer la position de la fenêtre"  + Environment.NewLine + Environment.NewLine +
                "Voulez-vous continuer ?" }
      };

    static public readonly Dictionary<string, string> BackupBeforeRestoreText
      = new Dictionary<string, string>()
      {
        { "en", "Do you want to backup database before replace it?" },
        { "fr", "Voulez-vous archiver la base de données avant de la remplacer ?" }
      };

    static public readonly Dictionary<string, string> RestoreLettersDefaultText
      = new Dictionary<string, string>()
      {
        { "en", "This will restore all letters to default values." + Environment.NewLine + Environment.NewLine +
                "Do you want to continue?" },
        { "fr", "Cela va restaurer les lettres à leurs valeurs par défaut." + Environment.NewLine + Environment.NewLine +
                "Voulez-vous continuer ?" }
      };

    static public readonly Dictionary<string, string> BookChapterText
      = new Dictionary<string, string>()
      {
        { "en", "CHAPTER" },
        { "fr", "CHAPITRE" }
      };

  }

}
