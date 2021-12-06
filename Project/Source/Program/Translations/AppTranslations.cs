/// <license>
/// This file is part of Ordisoftware Hebrew Words.
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
/// <created> 2016-04 </created>
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

static partial class AppTranslations
{

  static public readonly TranslationsDictionary ApplicationDescription = new()
  {
    [Language.EN] = "Literal word-for-word translator of the Hebrew Bible",
    [Language.FR] = "Traducteur littéral mot-à-mot de la Bible hébraïque"
  };

  static public readonly TranslationsDictionary AskToCreateNewDatabase = new()
  {
    [Language.EN] = "Do you want to create a new database which will replace the actual?",
    [Language.FR] = "Voulez-vous créer une nouvelle base de données qui remplacera l'actuelle ?"
  };

  static public readonly TranslationsDictionary AskToBackupDatabaseBeforeReplace = new()
  {
    [Language.EN] = "Do you want to backup database before replace it?",
    [Language.FR] = "Voulez-vous archiver la base de données avant de la remplacer ?"
  };

  static public readonly TranslationsDictionary AskToRestoreBooksCommonNames = new()
  {
    [Language.EN] = "Restore default books common names?",
    [Language.FR] = "Restaurer les noms communs par défaut des livres ?"
  };

  static public readonly TranslationsDictionary Rendering = new()
  {
    [Language.EN] = "Rendering {0} controls for {1} verses...",
    [Language.FR] = "Fourniture de {0} contrôles pour {1} versets..."
  };

  static public readonly TranslationsDictionary ReferenceError = new()
  {
    [Language.EN] = $"Error with reference: {{0}}{Globals.NL2}{{1}}",
    [Language.FR] = $"Erreur avec la référence : {{0}}{Globals.NL2}{{1}}"
  };

  static public readonly TranslationsDictionary ImportLinesCountMismatch = new()
  {
    [Language.EN] = "Incorrect elements." + Globals.NL2 +
                    "Non empty lines count: {0}" + Globals.NL2 +
                    "Must be even.",

    [Language.FR] = "Elements incorrects." + Globals.NL2 +
                    "Nombre de lignes non vides: {0}" + Globals.NL2 +
                    "Doit être pair."
  };

  static public readonly TranslationsDictionary ImportItemsCountMismatch = new()
  {
    [Language.EN] = "Incorrect elements." + Globals.NL2 +
                    "Words count: {0}" + Globals.NL +
                    "Translations count: {1}" + Globals.NL +
                    "Must be equal.",

    [Language.FR] = "Elements incorrects." + Globals.NL2 +
                    "Nombre de mots: {0}" + Globals.NL +
                    "Nombre de translations: {1}" + Globals.NL +
                    "Doit être égal."
  };

  static public readonly TranslationsDictionary ImportWordsCountMismatch = new()
  {
    [Language.EN] = "Incorrect elements." + Globals.NL2 +
                    "Verse words count: {0}" + Globals.NL +
                    "Imported words count: {1}" + Globals.NL2 +
                    "Must be equal.",

    [Language.FR] = "Elements incorrects." + Globals.NL2 +
                    "Nombre de mots du verset: {0}" + Globals.NL +
                    "Nombre de mots importés: {1}" + Globals.NL + Globals.NL +
                    "Doit être égal."
  };

  static public readonly TranslationsDictionary ImportWordMismatch = new()
  {
    [Language.EN] = "Incorrect Hebrew." + Globals.NL2 +
                    "Verse word: {0}" + Globals.NL +
                    "Imported word: {1}" + Globals.NL2 +
                    "Must be equal.",

    [Language.FR] = "Hébreu incorrect." + Globals.NL2 +
                    "Mot du verset: {0}" + Globals.NL +
                    "Mot importé: {1}" + Globals.NL2 +
                    "Doit être égal."
  };

  static public readonly TranslationsDictionary BookChapterTitle = new()
  {
    [Language.EN] = "CHAPTER",
    [Language.FR] = "CHAPITRE"
  };

  static public readonly NullSafeDictionary<ViewMode, TranslationsDictionary> ViewPanelTitle = new()
  {
    [ViewMode.Verses] = new TranslationsDictionary
    {
      [Language.EN] = "Tanak Verses",
      [Language.FR] = "Versets du Tanak"
    },
    [ViewMode.VerseFiltered] = new TranslationsDictionary
    {
      [Language.EN] = "Tanak Verse Filtered",
      [Language.FR] = "Verset du Tanak filtré"
    },
    [ViewMode.Translation] = new TranslationsDictionary
    {
      [Language.EN] = "Tanak Translation",
      [Language.FR] = "Traduction du Tanak"
    },
    [ViewMode.Text] = new TranslationsDictionary
    {
      [Language.EN] = "Tanak Hebrew Text",
      [Language.FR] = "Texte Hébreu du Tanak"
    },
    [ViewMode.ELS50] = new TranslationsDictionary
    {
      [Language.EN] = "Tanak ELS50 Verses",
      [Language.FR] = "Versets ELS50 du Tanak"
    },
    [ViewMode.Search] = new TranslationsDictionary
    {
      [Language.EN] = "Search in the Tanak",
      [Language.FR] = "Recherche dans le Tanak"
    }
  };

}
