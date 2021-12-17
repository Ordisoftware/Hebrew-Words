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

  static public readonly TranslationsDictionary AskToReplaceDatabase = new()
  {
    [Language.EN] = "Do you want to replace the actual database with the selected backup?" + Globals.NL2 + "{0}",
    [Language.FR] = "Voulez-vous remplacer la base de données actuelle avec l'archive sélectionnée ?" + Globals.NL2 + "{0}"
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

  static public readonly TranslationsDictionary SelectedBookItemIsNull = new()
  {
    [Language.EN] = "Book index error: selected item is null.",
    [Language.FR] = "Erreur d'index de livre : l'item sélectionné est null."
  };

  static public readonly TranslationsDictionary ChapterBookItemIsNull = new()
  {
    [Language.EN] = "Chapter index error: selected item is null.",
    [Language.FR] = "Erreur d'index de chapitre : l'item sélectionné est null."
  };

  static public readonly TranslationsDictionary VerseBookItemIsNull = new()
  {
    [Language.EN] = "Verse index error: selected item is null.",
    [Language.FR] = "Erreur d'index de verset: l'item sélectionné est null."
  };

  static public readonly TranslationsDictionary WordBookItemIsNull = new()
  {
    [Language.EN] = "Word index error: selected item is null.",
    [Language.FR] = "Erreur d'index de mot: l'item sélectionné est null."
  };

  static public readonly TranslationsDictionary CommentPrefixAddAll = new()
  {
    [Language.EN] = "Update all line prefixes of all comments according to the selected option?" + Globals.NL2 +
                    "Add: {0}",

    [Language.FR] = "Mettre à jour tous les préfixes des lignes de tous les commentaires en fonction de l'option sélectionnée ?" + Globals.NL2 +
                    "Ajouter : {0}"
  };

  static public readonly TranslationsDictionary CommentPrefixRemoveAll = new()
  {
    [Language.EN] = "Update all line prefixes of all comments according to the selected option?" + Globals.NL2 +
                    "Remove: {0}",

    [Language.FR] = "Mettre à jour tous les préfixes des lignes de tous les commentaires en fonction de l'option sélectionnée ?" + Globals.NL2 +
                    "Enlever : {0}"
  };

  static public readonly TranslationsDictionary NoSearchResultFound = new()
  {
    [Language.EN] = "No result found",
    [Language.FR] = "Aucun résultat trouvé"
  };

  static public readonly TranslationsDictionary FirstVerseToComplete = new()
  {
    [Language.EN] = "First verse to complete",
    [Language.FR] = "Premier verset à compléter"
  };

  static public readonly TranslationsDictionary NoVerseToComplete = new()
  {
    [Language.EN] = "No verse to complete",
    [Language.FR] = "Aucun verset à compléter"
  };

  static public readonly TranslationsDictionary FirstVerseTranslated = new()
  {
    [Language.EN] = "First verse translated",
    [Language.FR] = "Premier verset traduit"
  };

  static public readonly TranslationsDictionary NoVerseTranslated = new()
  {
    [Language.EN] = "No verse with translation",
    [Language.FR] = "Aucun verset avec traduction"
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
                    "Translations count: {1}" + Globals.NL2 +
                    "Must be equal.",

    [Language.FR] = "Elements incorrects." + Globals.NL2 +
                    "Nombre de mots: {0}" + Globals.NL +
                    "Nombre de translations: {1}" + Globals.NL2 +
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
                    "Nombre de mots importés: {1}" + Globals.NL2 +
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
    [ViewMode.ChapterVerses] = new TranslationsDictionary
    {
      [Language.EN] = "Tanak Verses",
      [Language.FR] = "Versets du Tanak"
    },
    [ViewMode.VerseFiltered] = new TranslationsDictionary
    {
      [Language.EN] = "Tanak Verse Filtered",
      [Language.FR] = "Verset du Tanak filtré"
    },
    [ViewMode.ChapterTranslation] = new TranslationsDictionary
    {
      [Language.EN] = "Tanak Translation",
      [Language.FR] = "Traduction du Tanak"
    },
    [ViewMode.ChapterOriginal] = new TranslationsDictionary
    {
      [Language.EN] = "Tanak Hebrew Text",
      [Language.FR] = "Texte Hébreu du Tanak"
    },
    [ViewMode.BookELS50] = new TranslationsDictionary
    {
      [Language.EN] = "Tanak ELS50 Verses",
      [Language.FR] = "Versets ELS50 du Tanak"
    },
    [ViewMode.Search] = new TranslationsDictionary
    {
      [Language.EN] = "Search in the Tanak",
      [Language.FR] = "Chercher dans le Tanak"
    }
  };

}
