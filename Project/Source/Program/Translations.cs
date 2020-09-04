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
/// <edited> 2020-08 </edited>
using System;
using Ordisoftware.HebrewCommon;

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// Localization strings.
  /// </summary>
  static public partial class Translations
  {

    static public readonly TranslationsDictionary ApplicationDescription
      = new TranslationsDictionary
      {
        { Language.EN, "Literal word-for-word translation of the Hebrew Bible" },
        { Language.FR, "Traduction littérale mot-à-mot de la Bible hébraïque" }
      };

    static public readonly TranslationsDictionary AskToCreateNewDatabase
      = new TranslationsDictionary
      {
        { Language.EN, "Do you want to create a new database wich will replace the actual?" },
        { Language.FR, "Voulez-vous créer une nouvelle base de données qui remplacera l'actuelle ?" }
      };

    static public readonly TranslationsDictionary AskToBackupDatabaseBeforeReplace
      = new TranslationsDictionary
      {
        { Language.EN, "Do you want to backup database before replace it?" },
        { Language.FR, "Voulez-vous archiver la base de données avant de la remplacer ?" }
      };

    static public readonly TranslationsDictionary AskToRestoreBooksCommonNames
      = new TranslationsDictionary
      {
        { Language.EN, "Restore default books common names?" },
        { Language.FR, "Restaurer les noms communs par défaut des livres ?" }
      };

    static public readonly TranslationsDictionary BookChapterTitle
      = new TranslationsDictionary
      {
        { Language.EN, "CHAPTER" },
        { Language.FR, "CHAPITRE" }
      };

    static public readonly NullSafeDictionary<ViewMode, TranslationsDictionary> ViewPanelTitle
      = new NullSafeDictionary<ViewMode, TranslationsDictionary>()
      {
        {
          ViewMode.Verses, new TranslationsDictionary
          {
            { Language.EN, "Tanak Verses" },
            { Language.FR, "Versets du Tanak" }
          }
        },
        {
          ViewMode.Translations, new TranslationsDictionary
          {
            { Language.EN, "Tanak Translation" },
            { Language.FR, "Traduction du Tanak" }
          }
        },
        {
          ViewMode.Text, new TranslationsDictionary
          {
            { Language.EN, "Tanak Hebrew Text" },
            { Language.FR, "Texte Hébreu du Tanak" }
          }
        },
        {
          ViewMode.ELS50, new TranslationsDictionary
          {
            { Language.EN, "Tanak ELS50 Verses" },
            { Language.FR, "Versets ELS50 du Tanak" }
          }
        },
        {
          ViewMode.Search, new TranslationsDictionary
          {
            { Language.EN, "Search in the Tanak" },
            { Language.FR, "Recherche dans le Tanak" }
          }
        }
      };

  }

}
