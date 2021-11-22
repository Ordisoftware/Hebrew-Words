﻿/// <license>
/// This file is part of Ordisoftware Hebrew Calendar/Letters/Words.
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
/// <edited> 2021-10 </edited>
namespace Ordisoftware.Hebrew;

using Ordisoftware.Core;

/// <summary>
/// Localization strings.
/// </summary>
static class HebrewTranslations
{

  static public readonly NullSafeDictionary<Language, string[]> Letters = new()
  {
    [Language.EN] = new string[]
    {
      "Alef", "Bet", "Gimel", "Dalet", "He", "Vav", "Zayin", "'Het", "Tet", "Yod", "Kaf",
      "Lamed", "Mem", "Nun", "Samek", "'Ayin", "Pay", "Tsadi", "Qof", "Resh", "Shin", "Tav"
    },

    [Language.FR] = new string[]
    {
      "Alef", "Bet", "Guimel", "Dalet", "Hé", "Vav", "Zayin", "'Het", "Tet", "Youd", "Kaf",
      "Lamed", "Mem", "Noun", "Samek", "'Ayin", "Pé", "Tsadi", "Qouf", "Resh", "Shin", "Tav"
    }
  };

  static public readonly TranslationsDictionary GrammarGuideTitle = new()
  {
    [Language.EN] = "Grammar guide",
    [Language.FR] = "Guide de grammaire"
  };

  static public readonly TranslationsDictionary MethodNoticeTitle = new()
  {
    [Language.EN] = "Lettriq analysis method notice",
    [Language.FR] = "Notice de la méthode d'analyse lettrique"
  };

  static public readonly TranslationsDictionary Hebrew = new()
  {
    [Language.EN] = "Hebrew",
    [Language.FR] = "Hébreu"
  };

  static public readonly TranslationsDictionary Unicode = new()
  {
    [Language.EN] = "Unicode",
    [Language.FR] = "Unicode"
  };

  static public readonly TranslationsDictionary Translation = new()
  {
    [Language.EN] = "Translation",
    [Language.FR] = "Traduction"
  };

  static public readonly TranslationsDictionary Transcription = new()
  {
    [Language.EN] = "Transcription",
    [Language.FR] = "Transcription"
  };

  static public readonly TranslationsDictionary Lettriq = new()
  {
    [Language.EN] = "Lettriq",
    [Language.FR] = "Lettrique"
  };

  static public readonly TranslationsDictionary ParashahReading = new()
  {
    [Language.EN] = "Parashah reading",
    [Language.FR] = "Lecture de la Parashah"
  };

  static public readonly TranslationsDictionary AskToDownload = new()
  {
    [Language.EN] = "Do you want to download it?",
    [Language.FR] = "Voulez-vous le télécharger ?"
  };

  static public readonly TranslationsDictionary AskToDownloadHebrewLetters = new()
  {
    [Language.EN] = "Hebrew Letters not found." + Globals.NL +
                    SysTranslations.AskToCheckPreferences[Language.EN] + Globals.NL2 +
                    AskToDownload[Language.EN],

    [Language.FR] = "Hebrew Letters n'a pas été trouvé." + Globals.NL +
                    SysTranslations.AskToCheckPreferences[Language.FR] + Globals.NL2 +
                    AskToDownload[Language.FR]
  };

  static public readonly TranslationsDictionary AskToDownloadHebrewWords = new()
  {
    [Language.EN] = "Hebrew Words not found." + Globals.NL +
                    SysTranslations.AskToCheckPreferences[Language.EN] + Globals.NL2 +
                    AskToDownload[Language.EN],

    [Language.FR] = "Hebrew Words n'a pas été trouvé." + Globals.NL +
                    SysTranslations.AskToCheckPreferences[Language.FR] + Globals.NL2 +
                    AskToDownload[Language.FR]
  };

  static public readonly TranslationsDictionary BoardExportFileName = new()
  {
    [Language.EN] = "Board {0}",
    [Language.FR] = "Board {0}",
  };

  static public readonly TranslationsDictionary WeeklyParashah = new()
  {
    [Language.EN] = "Weekly parashah",
    [Language.FR] = "Parashah de la semaine"
  };

  static public readonly TranslationsDictionary ParashahNotFound = new()
  {
    [Language.EN] = "Parashah not found : it's Pesach or data are not generated.",
    [Language.FR] = "Parashah non trouvée : c'est Pessa'h ou les données n'ont pas été générées."
  };

  static public readonly TranslationsDictionary NoticeOnlineWordProvider = new()
  {
    [Language.EN] = "Use the following tags to replace values:" + Globals.NL2 +
                    "%WORD% : the Unicode value" + Globals.NL +
                    "%FIRSTLETTER% : first letter of the Unicode value",

    [Language.FR] = "Utiliser les tags suivants pour remplacer les valeurs :" + Globals.NL2 +
                    "%WORD% : la valeur Unicode" + Globals.NL +
                    "%FIRSTLETTER% : première lettre de la valeur Unicode"
  };

  static public readonly TranslationsDictionary NoticeOnlineBibleProvider = new()
  {
    [Language.EN] = "Use the following tags to replace values:" + Globals.NL2 +
                    "%BOOKSB% : StudyBible.org book name" + Globals.NL +
                    "%BOOKBIBLEHUB% : BibleHub.org and SainteBible.com book name" + Globals.NL +
                    "%BOOKSEFARIA% : Sefaria.org book name" + Globals.NL +
                    "%BOOKCHABAD% : Chabad.org book name" + Globals.NL +
                    "%BOOKMM% : Mechon-Mamre.org book name" + Globals.NL +
                    "%BOOKDJEP% : Djep.hd.free.fr book name" + Globals.NL +
                    Globals.NL +
                    "%BOOKNUM% : Book number" + Globals.NL +
                    "%CHAPTERNUM% : Chapter number" + Globals.NL +
                    "%VERSENUM% : Verse number" + Globals.NL +
                    Globals.NL +
                    "%BOOKNUM#2% : Book number in two digits" + Globals.NL +
                    "%CHAPTERNUM#2% : Chapter number in two digits" + Globals.NL +
                    "%VERSENUM#2% : Verse number in two digits",

    [Language.FR] = "Utiliser les tags suivants pour remplacer les valeurs :" + Globals.NL2 +
                    "%BOOKSB% : Nom du livre StudyBible.org" + Globals.NL +
                    "%BOOKBIBLEHUB% : Nom du livre BibleHub.org et SainteBible.com" + Globals.NL +
                    "%BOOKSEFARIA% : Sefaria.org book name" + Globals.NL +
                    "%BOOKCHABAD% : Nom du livre Chabad.org" + Globals.NL +
                    "%BOOKMM% : Nom du livre Mechon-Mamre.org" + Globals.NL +
                    "%BOOKDJEP% : Nom du livre Djep.hd.free.fr" + Globals.NL +
                    Globals.NL +
                    "%BOOKNUM% : Numéro du livre" + Globals.NL +
                    "%CHAPTERNUM% : Numéro du chapitre" + Globals.NL +
                    "%VERSENUM% : Numéro du verset" + Globals.NL +
                    Globals.NL +
                    "%BOOKNUM#2% : Numéro du livre sur 2 digits" + Globals.NL +
                    "%CHAPTERNUM#2% : Numéro du chapitre sur 2 digits" + Globals.NL +
                    "%VERSENUM#2% : Numéro du verset sur 2 digits"
  };

}
