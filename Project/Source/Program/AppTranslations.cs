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
/// <edited> 2021-02 </edited>
namespace Ordisoftware.Hebrew.Words;

using Ordisoftware.Core;

static partial class AppTranslations
{

  static public readonly TranslationsDictionary ApplicationDescription = new()
  {
    [Language.EN] = "Literal word-for-word translator of the Hebrew Bible",
    [Language.FR] = "Traducteur littéral mot-à-mot de la Bible hébraïque"
  };

  static public readonly TranslationsDictionary AskToCreateNewDatabase = new()
  {
    [Language.EN] = "Do you want to create a new database wich will replace the actual?",
    [Language.FR] = "Voulez-vous créer une nouvelle base de données qui remplacera l'actuelle ?"
  };

  static public readonly TranslationsDictionary AskToBackupDatabaseBeforeReplace = new()
  {
    [Language.EN] = "Do you want to backup database before replace it?",
    [Language.FR] = "Voulez-vous archiver la base de données avant de la remplacer ?"
  };

  static public readonly TranslationsDictionary AskToRestoreBooksCommonNames = new()
  {
    { Language.EN, "Restore default books common names?" },
    { Language.FR, "Restaurer les noms communs par défaut des livres ?" }
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
    [Language.EN] = "Incorrect hebrew." + Globals.NL2 +
                    "Verse word: {0}" + Globals.NL +
                    "Imported word: {1}" + Globals.NL2 +
                    "Must be equal.",

    [Language.FR] = "Hébreu incorrect." + Globals.NL2 +
                    "Mot du verset: {0}" + Globals.NL +
                    "Mot importé: {1}" + Globals.NL2 +
                    "Doit être égal."
  };

  static public readonly TranslationsDictionary ImportHelp = new()
  {
    [Language.EN] = "This console allows for example to import an MS Word verse table." + Globals.NL2 +
                     "This table must first be converted to text with | as a separator." + Globals.NL2 +
                     "The import text must be presented in groups of two lines:" + Globals.NL +
                     "- A first containing a list of Hebrew words according to the Hebrew.ttf font," + Globals.NL +
                     "- A second containing a list of translations." + Globals.NL2 +
                     "There can be as many groups of two lines as necessary." + Globals.NL2 +
                     "Imported translation fields can be edited in the result grid.",

    [Language.FR] = "Cette console permet par exemple d'importer un tableau de verset MS Word." + Globals.NL2 +
                    "Ce tableau doit préalablement être convertit en texte avec | comme séparateur." + Globals.NL2 +
                    "Le texte d'import doit ainsi se présenter par groupe de deux lignes :" + Globals.NL +
                    "- Une première contenant une liste de mots hébreux selon la police Hebrew.ttf," + Globals.NL +
                    "- Une deuxième contenant une liste de traductions." + Globals.NL2 +
                    "Il peut y avoir autant de groupe de deux lignes que nécessaire." + Globals.NL2 +
                    "Les champs de traduction importés peuvent être édités dans la grille du résultat."
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
    [ViewMode.Translations] = new TranslationsDictionary
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
