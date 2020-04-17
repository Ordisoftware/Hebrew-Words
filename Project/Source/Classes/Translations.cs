/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2020 Olivier Rogier.
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
/// <edited> 2020-04 </edited>
using System;
using System.Collections.Generic;

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// Localization strings.
  /// </summary>
  static public partial class Translations
  {

    static public string NewLine { get { return Environment.NewLine; } }

    static public readonly Dictionary<string, string> ApplicationDescription
      = new Dictionary<string, string>()
      {
        { "en", "Literal word-for-word translation of the Hebrew Bible" },
        { "fr", "Traduction littérale mot-à-mot de la Bible hébraïque" }
      };

    static public readonly Dictionary<string, string> AboutBoxTitle
      = new Dictionary<string, string>()
      {
        { "en", "About {0}" },
        { "fr", "À propos de {0}" }
      };

    static public readonly Dictionary<string, string> AboutBoxVersion
      = new Dictionary<string, string>()
      {
        { "en", "Version {0}" },
        { "fr", "Version {0}" }
      };

    static public readonly Dictionary<string, string> NotYetAvailable
      = new Dictionary<string, string>()
      {
        { "en", "Not yet available." },
        { "fr", "Pas encore disponible." }
      };

    static public readonly Dictionary<string, string> AskToExitApplication
      = new Dictionary<string, string>()
      {
        { "en", "Exit application?" },
        { "fr", "Quitter l'application ?" }
      };

    static public readonly Dictionary<string, string> NoNewVersionAvailable
      = new Dictionary<string, string>()
      {
        { "en", "There is no new version available." },
        { "fr", "Il n'y a pas de nouvelle version de disponible." }
      };

    static public readonly Dictionary<string, string> NewVersionAvailable
      = new Dictionary<string, string>()
      {
        { "en", "A newer version is available : {0}" },
        { "fr", "Une nouvelle version est disponible : {0}" }
      };

    static public readonly Dictionary<string, string> AskToDownloadNewVersion
      = new Dictionary<string, string>()
      {
        { "en", "Do you want to open the download page?" },
        { "fr", "Voulez-vous ouvrir la page de téléchargement ?" }
      };

    static public readonly Dictionary<string, string> FileNotFound
      = new Dictionary<string, string>()
      {
        { "en", "File not found: " + NewLine + NewLine + "{0}" },
        { "fr", "Fichier non trouvé :" + NewLine + NewLine + "{0}" }
      };

    static public readonly Dictionary<string, string> AskToRestoreWindowPosition
      = new Dictionary<string, string>()
      {
        { "en", "This action will restore windows position." + NewLine + NewLine +
                "Do you want to continue?" },
        { "fr", "Cette action va restaurer la position de la fenêtre."  + NewLine + NewLine +
                "Voulez-vous continuer ?" }
      };

    static public readonly Dictionary<string, string> AskToOpenAllLinks
      = new Dictionary<string, string>()
      {
        { "en", "Do you want to open all \"{0]\" links?" },
        { "fr", "Voulez-vous ouvrir tous les liens de \"{0}\" ?" }
      };

    static public readonly Dictionary<string, string> AskToResetPreferences
      = new Dictionary<string, string>()
      {
        { "en", "Preferences will be reseted to their default values." + NewLine + NewLine +
                "Do you want to continue?" },
        { "fr", "Les préférences vont être réinitialisées à leurs valeurs par défaut." + NewLine + NewLine +
                "Voulez-vous continuer ?" }
      };

    static public readonly Dictionary<string, string> AskToDownloadHebrewLetters
      = new Dictionary<string, string>()
      {
        { "en", "Hebrew Letters not found." + NewLine +
                "Check preferences." + NewLine + NewLine +
                "Do you want to download it?" },
        { "fr", "Hebrew Letters n'a pas été trouvé." + NewLine +
                "Vérifiez les préférences." + NewLine + NewLine +
                "Voulez-vous le télécharger ?" }
      };

    static public readonly Dictionary<string, string> ProgressCreatingData
      = new Dictionary<string, string>()
      {
        { "en", "Creating data..." },
        { "fr", "Création des données..." }
      };

    static public readonly Dictionary<string, string> AskToCreateNewDatabase
      = new Dictionary<string, string>()
      {
        { "en", "Do you want to create a new database wich will replace the actual?" },
        { "fr", "Voulez-vous créer une nouvelle base de données qui remplacera l'actuelle ?" }
      };

    static public readonly Dictionary<string, string> AskToBackupDatabaseBeforeReplace
      = new Dictionary<string, string>()
      {
        { "en", "Do you want to backup database before replace it?" },
        { "fr", "Voulez-vous archiver la base de données avant de la remplacer ?" }
      };

    static public readonly Dictionary<string, string> AskToRestoreBooksCommonNames
      = new Dictionary<string, string>()
      {
        { "en", "Restore default books common names?" },
        { "fr", "Restaurer les noms communs par défaut des livres ?" }
      };

    static public readonly Dictionary<string, string> AskToEmptyHistory
      = new Dictionary<string, string>()
      {
        { "en", "Empty history?" },
        { "fr", "Vider l'historique ?" }
      };

    static public readonly Dictionary<string, string> AskToEmptyBookmarks
      = new Dictionary<string, string>()
      {
        { "en", "Empty bookmarks?" },
        { "fr", "Vider les signets?" }
      };

    static public readonly Dictionary<string, string> AskToDeleteBookmark
      = new Dictionary<string, string>()
      {
        { "en", "Remove the bookmark?" },
        { "fr", "Effacer le signet ?" }
      };


    static public readonly Dictionary<string, string> BookChapterTitle
      = new Dictionary<string, string>()
      {
        { "en", "CHAPTER" },
        { "fr", "CHAPITRE" }
      };

    static public readonly Dictionary<ViewModeType, Dictionary<string, string>> ViewPanelTitle
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
