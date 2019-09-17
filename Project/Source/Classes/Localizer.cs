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
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// Provide localization.
  /// </summary>
  static public class Localizer
  {

    static public readonly string NewLine = Environment.NewLine;

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

    static public readonly Dictionary<string, string> ApplicationDescriptionText
      = new Dictionary<string, string>()
      {
        { "en", "A tool for the literal translation of the Hebrew Bible" },
        { "fr", "Un utilitaire pour la traduction littérale de la Bible hébraïque" }
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
        { "en", "This action will restore windows position." + NewLine + NewLine +
                "Do you want to continue?" },
        { "fr", "Cette action va restaurer la position de la fenêtre"  + NewLine + NewLine +
                "Voulez-vous continuer ?" }
      };

    static public readonly Dictionary<string, string> NewDatabaseAdvertText
      = new Dictionary<string, string>()
      {
        { "en", "Do you want to create a new database wich will replace the actual?" },
        { "fr", "Voulez-vous créer une nouvelle base de données qui remplacera l'actuelle ?" }
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
        { "en", "This will restore all letters to default values." + NewLine + NewLine +
                "Do you want to continue?" },
        { "fr", "Cela va restaurer les lettres à leurs valeurs par défaut." + NewLine + NewLine +
                "Voulez-vous continuer ?" }
      };

    static public readonly Dictionary<string, string> CreatingDataText
      = new Dictionary<string, string>()
      {
        { "en", "Creating data..." },
        { "fr", "Création des données..." }
      };

    static public readonly Dictionary<string, string> NotYetAvailableText
      = new Dictionary<string, string>()
      {
        { "en", "Not yet available." },
        { "fr", "Pas encore disponible." }
      };

    static public readonly Dictionary<string, string> BookChapterText
      = new Dictionary<string, string>()
      {
        { "en", "CHAPTER" },
        { "fr", "CHAPITRE" }
      };

    static public readonly Dictionary<ViewModeType, Dictionary<string, string>> ViewPanelText
      = new Dictionary<ViewModeType, Dictionary<string, string>>()
      {
        {
          ViewModeType.Verses, new Dictionary<string, string>
          {
            { "en", "Tanak Verses" },
            { "fr", "Versets du Tanak" }
          }
        },
        {
          ViewModeType.Translations, new Dictionary<string, string>
          {
            { "en", "Tanak Translation" },
            { "fr", "Traduction du Tanak" }
          }
        },
        {
          ViewModeType.Text, new Dictionary<string, string>
          {
            { "en", "Tanak Hebrew Text" },
            { "fr", "Texte Hébreu du Tanak" }
          }
        },
        {
          ViewModeType.ELS50, new Dictionary<string, string>
          {
            { "en", "Tanak ELS50 Verses" },
            { "fr", "Versets ELS50 du Tanak" }
          }
        },
        {
          ViewModeType.Search, new Dictionary<string, string>
          {
            { "en", "Search in the Tanak" },
            { "fr", "Recherche dans le Tanak" }
          }
        }
      };

  }

}
