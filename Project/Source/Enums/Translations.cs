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
/// <edited> 2019-10 </edited>
using System;
using System.Collections.Generic;

namespace Ordisoftware.HebrewWords
{

  static public class Translations
  {

    static public readonly string NewLine = Environment.NewLine;

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

    static public readonly Dictionary<string, string> ApplicationDescription
      = new Dictionary<string, string>()
      {
        { "en", "A tool for the literal translation of the Hebrew Bible" },
        { "fr", "Un outil pour la traduction littérale de la Bible hébraïque" }
      };

    static public readonly Dictionary<string, string> ExitApplication
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

    static public readonly Dictionary<string, string> AskDownloadNewVersion
      = new Dictionary<string, string>()
      {
        { "en", "Do you want to open the download page?" },
        { "fr", "Voulez-vous ouvrir la page de téléchargement ?" }
      };

    static public readonly Dictionary<string, string> RestoreWindowPosition
      = new Dictionary<string, string>()
      {
        { "en", "This action will restore windows position." + NewLine + NewLine +
                "Do you want to continue?" },
        { "fr", "Cette action va restaurer la position de la fenêtre"  + NewLine + NewLine +
                "Voulez-vous continuer ?" }
      };

    static public readonly Dictionary<string, string> CreateNewDatabase
      = new Dictionary<string, string>()
      {
        { "en", "Do you want to create a new database wich will replace the actual?" },
        { "fr", "Voulez-vous créer une nouvelle base de données qui remplacera l'actuelle ?" }
      };

    static public readonly Dictionary<string, string> BackupDatabaseBeforeReplace
      = new Dictionary<string, string>()
      {
        { "en", "Do you want to backup database before replace it?" },
        { "fr", "Voulez-vous archiver la base de données avant de la remplacer ?" }
      };

    static public readonly Dictionary<string, string> ResetPreferences
      = new Dictionary<string, string>()
      {
        { "en", "Do you want to reset the preferences" + NewLine +
                "to their default values?" },
        { "fr", "Voulez-vous réinitialiser les préférences" + NewLine +
                "à leurs valeurs par défaut ?" }
      };

    static public readonly Dictionary<string, string> CreatingData
      = new Dictionary<string, string>()
      {
        { "en", "Creating data..." },
        { "fr", "Création des données..." }
      };

    static public readonly Dictionary<string, string> FileNotFound
      = new Dictionary<string, string>()
      {
        { "en", "File not found: " + NewLine + NewLine + "{0}" },
        { "fr", "Fichier non trouvé :" + NewLine + NewLine + "{0}" }
      };

    static public readonly Dictionary<string, string> NotYetAvailable
      = new Dictionary<string, string>()
      {
        { "en", "Not yet available." },
        { "fr", "Pas encore disponible." }
      };

    static public readonly Dictionary<string, string> ImportLinesCountMismatch
      = new Dictionary<string, string>()
      {
        { "en", "Incorrect elements." + NewLine + NewLine +
                "Non empty lines count: {0}" + NewLine + NewLine +
                "Must be even." },
        { "fr", "Elements incorrects." + NewLine + NewLine +
                "Nombre de lignes non vides: {0}" + NewLine + NewLine +
                "Doit être pair." }
      };

    static public readonly Dictionary<string, string> ImportItemsCountMismatch
      = new Dictionary<string, string>()
      {
        { "en", "Incorrect elements." + NewLine + NewLine +
                "Words count: {0}" + NewLine +
                "Translations count: {1}" + NewLine +
                "Must be equal."},
        { "fr", "Elements incorrects." + NewLine + NewLine +
                "Nombre de mots: {0}" + NewLine +
                "Nombre de translations: {1}" + NewLine +
                "Doit être égal." }
      };

    static public readonly Dictionary<string, string> ImportWordsCountMismatch
      = new Dictionary<string, string>()
      {
        { "en", "Incorrect elements." + NewLine + NewLine +
                "Verse words count: {0}" + NewLine +
                "Imported words count: {1}" + NewLine + NewLine +
                "Must be equal." },
        { "fr", "Elements incorrects." + NewLine + NewLine +
                "Nombre de mots du verset: {0}" + NewLine + 
                "Nombre de mots importés: {1}" + NewLine +NewLine +
                "Doit être égal." }
      };

    static public readonly Dictionary<string, string> ImportWordMismatch
      = new Dictionary<string, string>()
      {
        { "en", "Incorrect hebrew." + NewLine + NewLine +
                "Verse word: {0}" + NewLine +
                "Imported word: {1}" + NewLine + NewLine +
                "Must be equal." },
        { "fr", "Hébreu incorrect." + NewLine + NewLine +
                "Mot du verset: {0}" + NewLine +
                "Mot importé: {1}" + NewLine + NewLine +
                "Doit être égal." }
      };

    static public readonly Dictionary<string, string> ImportHelp
      = new Dictionary<string, string>()
      {
        { "en", "This console allows for example to import an MS Word verse table." + NewLine + NewLine +
                 "This table must first be converted to text with | as a separator." + NewLine + NewLine +
                 "The import text must be presented in groups of two lines:" + NewLine +
                 "- A first containing a list of Hebrew words according to the Hebrew.ttf font," + NewLine +
                 "- A second containing a list of translations." + NewLine + NewLine +
                 "There can be as many groups of two lines as necessary." + NewLine + NewLine +
                 "Imported translation fields can be edited in the result grid." },
        { "fr", "Cette console permet par exemple d'importer un tableau de verset MS Word." + NewLine + NewLine +
                "Ce tableau doit préalablement être convertit en texte avec | comme séparateur." + NewLine + NewLine +
                "Le texte d'import doit ainsi se présenter par groupe de deux lignes :" + NewLine +
                "- Une première contenant une liste de mots hébreux selon la police Hebrew.ttf," + NewLine +
                "- Une deuxième contenant une liste de traductions." + NewLine + NewLine +
                "Il peut y avoir autant de groupe de deux lignes que nécessaire." + NewLine + NewLine +
                "Les champs de traduction importés peuvent être édités dans la grille du résultat." }
      };

    static public readonly Dictionary<string, string> BookChapterTitle
      = new Dictionary<string, string>()
      {
        { "en", "CHAPTER" },
        { "fr", "CHAPITRE" }
      };

    static public readonly Dictionary<string, string> OpenOnlineVerseHelp
      = new Dictionary<string, string>()
      {
        { "en", "Use the following tags to replace values:" + NewLine + NewLine +
                "%BOOKSB% : StudyBible.org book name" + NewLine +
                "%BOOKBIBLEHUB% : BibleHub.org book name" + NewLine +
                "%BOOKCHABAD% : Chabad.org book name" + NewLine +
                "%BOOKMM% : Mechon-Mamre.org book name" + NewLine +
                "%BOOKDJEP% : Djep.hd.free.fr book name" + NewLine + NewLine +
                "%BOOKNUM% : Book number" + NewLine +
                "%CHAPTERNUM% : Chapter number" + NewLine +
                "%VERSENUM% : Verse number" + NewLine + NewLine +
                "%BOOKNUM#2% : Book number in two digits" + NewLine +
                "%CHAPTERNUM#2% : Chapter number in two digits" + NewLine +
                "%VERSENUM#2% : Verse number in two digits" },
        { "fr", "Utiliser les tags suivants pour remplacer les valeurs :" + NewLine + NewLine +
                "%BOOKSB% : Nom du livre StudyBible.org" + NewLine +
                "%BOOKBIBLEHUB% : Nom du livre BibleHub.org" + NewLine +
                "%BOOKCHABAD% : Nom du livre Chabad.org" + NewLine +
                "%BOOKMM% : Nom du livre Mechon-Mamre.org" + NewLine +
                "%BOOKDJEP% : Nom du livre Djep.hd.free.fr" + NewLine + NewLine +
                "%BOOKNUM% : Numéro du livre" + NewLine +
                "%CHAPTERNUM% : Numéro du chaptre" + NewLine +
                "%VERSENUM% : Numéro du verset" + NewLine + NewLine +
                "%BOOKNUM#2% : Numéro du livre sur 2 digits" + NewLine +
                "%CHAPTERNUM#2% : Numéro du chapitre sur 2 digits" + NewLine +
                "%VERSENUM#2% : Numéro du verset sur 2 digits" },
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
