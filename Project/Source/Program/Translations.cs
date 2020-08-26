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
using Ordisoftware.HebrewCommon;

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// Localization strings.
  /// </summary>
  static public partial class Translations
  {

    static public readonly Dictionary<string, string> ApplicationDescription
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Literal word-for-word translation of the Hebrew Bible" },
        { Localizer.FR, "Traduction littérale mot-à-mot de la Bible hébraïque" }
      };

    static public readonly Dictionary<string, string> ProgressCreatingData
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Creating data..." },
        { Localizer.FR, "Création des données..." }
      };

    static public readonly Dictionary<string, string> AskToCreateNewDatabase
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Do you want to create a new database wich will replace the actual?" },
        { Localizer.FR, "Voulez-vous créer une nouvelle base de données qui remplacera l'actuelle ?" }
      };

    static public readonly Dictionary<string, string> AskToBackupDatabaseBeforeReplace
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Do you want to backup database before replace it?" },
        { Localizer.FR, "Voulez-vous archiver la base de données avant de la remplacer ?" }
      };

    static public readonly Dictionary<string, string> AskToRestoreBooksCommonNames
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Restore default books common names?" },
        { Localizer.FR, "Restaurer les noms communs par défaut des livres ?" }
      };

    static public readonly Dictionary<string, string> AskToEmptyHistory
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Empty history?" },
        { Localizer.FR, "Vider l'historique ?" }
      };

    static public readonly Dictionary<string, string> AskToEmptyBookmarks
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Empty bookmarks?" },
        { Localizer.FR, "Vider les signets?" }
      };

    static public readonly Dictionary<string, string> AskToDeleteBookmark
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Remove the bookmark?" },
        { Localizer.FR, "Effacer le signet ?" }
      };


    static public readonly Dictionary<string, string> BookChapterTitle
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "CHAPTER" },
        { Localizer.FR, "CHAPITRE" }
      };

    static public readonly Dictionary<ViewMode, Dictionary<string, string>> ViewPanelTitle
      = new Dictionary<ViewMode, Dictionary<string, string>>()
      {
        {
          ViewMode.Verses, new Dictionary<string, string>
          {
            { Localizer.EN, "Tanak Verses" },
            { Localizer.FR, "Versets du Tanak" }
          }
        },
        {
          ViewMode.Translations, new Dictionary<string, string>
          {
            { Localizer.EN, "Tanak Translation" },
            { Localizer.FR, "Traduction du Tanak" }
          }
        },
        {
          ViewMode.Text, new Dictionary<string, string>
          {
            { Localizer.EN, "Tanak Hebrew Text" },
            { Localizer.FR, "Texte Hébreu du Tanak" }
          }
        },
        {
          ViewMode.ELS50, new Dictionary<string, string>
          {
            { Localizer.EN, "Tanak ELS50 Verses" },
            { Localizer.FR, "Versets ELS50 du Tanak" }
          }
        },
        {
          ViewMode.Search, new Dictionary<string, string>
          {
            { Localizer.EN, "Search in the Tanak" },
            { Localizer.FR, "Recherche dans le Tanak" }
          }
        }
      };

  }

}
