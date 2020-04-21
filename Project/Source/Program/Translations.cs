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

    static public readonly Dictionary<ViewMode, Dictionary<string, string>> ViewPanelTitle
      = new Dictionary<ViewMode, Dictionary<string, string>>()
      {
        {
          ViewMode.Verses, new Dictionary<string, string>
          {
            { "en", "Tanak Verses" },
            { "fr", "Versets du Tanak" }
          }
        },
        {
          ViewMode.Translations, new Dictionary<string, string>
          {
            { "en", "Tanak Translation" },
            { "fr", "Traduction du Tanak" }
          }
        },
        {
          ViewMode.Text, new Dictionary<string, string>
          {
            { "en", "Tanak Hebrew Text" },
            { "fr", "Texte Hébreu du Tanak" }
          }
        },
        {
          ViewMode.ELS50, new Dictionary<string, string>
          {
            { "en", "Tanak ELS50 Verses" },
            { "fr", "Versets ELS50 du Tanak" }
          }
        },
        {
          ViewMode.Search, new Dictionary<string, string>
          {
            { "en", "Search in the Tanak" },
            { "fr", "Recherche dans le Tanak" }
          }
        }
      };

  }

}
