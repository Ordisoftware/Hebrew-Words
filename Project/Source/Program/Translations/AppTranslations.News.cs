﻿/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2025 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at
/// https://mozilla.org/MPL/2.0/.
/// If it is not possible or desirable to put the notice in a particular file,
/// then You may include the notice in a location(such as a LICENSE file in a
/// relevant directory) where a recipient would be likely to look for such a notice.
/// You may add additional accurate notices of copyright ownership.
/// </license>
/// <created> 2021-02 </created>
/// <edited> 2022-12 </edited>
namespace Ordisoftware.Hebrew.Words;

/// <summary>
/// Localization strings.
/// </summary>
static partial class AppTranslations
{

  static public readonly TranslationsDictionary PreviewFunctions = new()
  {
    [Language.EN] = "    • Web links edition",
    [Language.FR] = "    • Edition des liens web"
  };

  static public readonly NullSafeDictionary<string, TranslationsDictionary> NoticeNewFeatures = new()
  {

    //Template
    //["x.y"] = new TranslationsDictionary
    //{
    //  [Language.EN] = """

    //                  """,

    //  [Language.FR] = """

    //                  """,
    //},

    ["3.15"] = new TranslationsDictionary
    {
      [Language.EN] = """
                      • Add celebration verses board.
                      • Change export behavior to set default sub-folders to `Boards` and `Verses`.
                      • Improve web update checker security.
                      • Improve IPC interoperability security.
                      • Code improvement and refactoring.
                      • Some UI/UX fixes and improvements.
                      • Add links for Peninei Halakha and some others.
                      """,

      [Language.FR] = """
                      • Ajout d'un tableau des versets des célébrations.
                      • Modification de l'exportation pour définir les sous-dossiers par défaut pour `Boards` et `Verses`.
                      • Amélioration la sécurité du vérificateur de mise à jour Web.
                      • Amélioration la sécurité de l'interopérabilité IPC.
                      • Amélioration et refactorisation du code.
                      • Quelques correctifs et améliorations UI/UX.
                      • Ajouter des liens pour Peninei Halakha et quelques autres.
                      """,
    },

    ["3.14"] = new TranslationsDictionary
    {
      [Language.EN] = "• Add search parashah text box in parashot board.",

      [Language.FR] = "• Ajout d'une zone de texte de recherche de parashah dans le tableau des parashot."
    },

    ["3.12"] = new TranslationsDictionary
    {
      [Language.EN] = "• Add translated word filter to the window of verses by updated date.",

      [Language.FR] = "• Ajout d'un filtre de mot traduit à la fenêtre des versets par date de mise à jour.",
    },

    ["3.11"] = new TranslationsDictionary
    {
      [Language.EN] = "• Add date filters to the window of verses by updated date." + Globals.NL +
                      "• Many fixes in the window of verses by updated date.",

      [Language.FR] = "• Ajout des filtres de date à la fenêtre des versets par date de mise à jour." + Globals.NL +
                      "• Beaucoup de corrections dans la fenêtre des versets par date de mise à jour.",
    },

    ["3.9"] = new TranslationsDictionary
    {
      [Language.EN] = "• Add view verses by date of modification.",

      [Language.FR] = "• Ajout de l'affichage des versets par date de modification."
    },

    ["3.6"] = new TranslationsDictionary
    {
      [Language.EN] = "• Add menu item in Database to open the database folder." + Globals.NL +
                      "• Add theme colors for verse number and hebrew hover link." + Globals.NL +
                      "• Fix preferences form does not load theme colors." + Globals.NL +
                      "• Fix theming reseted to pastel when opening preferences." + Globals.NL +
                      "• Fix message boxes sometimes incorrectly drawn like when deleting bookmarks using mouse right click." + Globals.NL +
                      "• Remove focused control color and selection when taking screenshot.",

      [Language.FR] = "• Ajout d'un élément de menu dans Base de données pour ouvrir le dossier de la base de données." + Globals.NL +
                      "• Ajout de couleurs de thème pour le numéro de verset et le survol du lien hébreu." + Globals.NL +
                      "• Correction du formulaire de préférences qui ne charge pas les couleurs du thème." + Globals.NL +
                      "• Correction du thème réinitialisé au pastel lors de l'ouverture des préférences." + Globals.NL +
                      "• Correction des boîtes de message parfois mal dessinées, comme lors de la suppression de signets à l'aide du clic droit de la souris." + Globals.NL +
                      "• Suppression de la couleur et de la sélection des contrôles cibles lors de la capture d'écran.",
    },

    ["3.5"] = new TranslationsDictionary
    {
      [Language.EN] = "• Add menu items in Tools to take a screenshot of the window or the current view." + Globals.NL +
                      "• Add option to enable or disable the display of Hebrew book's name with its common name." + Globals.NL +
                      "• Add option to enable or disable the display of parashah name with the book's name." + Globals.NL +
                      "• Add option to enable or disable the display of parashah name in bookmarks and history." + Globals.NL +
                      "• Add option to enable or disable the display of translation in bookmarks and history." + Globals.NL +
                      "• Improve search reference to replace `,` or `:` or `-` or `_` by `.` (works also for IPC command)." + Globals.NL +
                      "• Fix commande line go to a reference to replace spaces by `% 20` (see FAQ)." + Globals.NL +
                      "• Few fixes and improvements.",

      [Language.FR] = "• Ajout d'éléments de menu dans Outils pour faire une capture d'écran de la fenêtre ou de la vue en cours." + Globals.NL +
                      "• Ajout d'une option pour activer ou désactiver l'affichage du nom du livre hébreu avec son nom commun." + Globals.NL +
                      "• Ajout d'une option pour activer ou désactiver l'affichage du nom de parashah avec le nom du livre." + Globals.NL +
                      "• Ajout d'une option pour activer ou désactiver l'affichage du nom de parashah dans les signets et l'historique." + Globals.NL +
                      "• Ajout d'une option pour activer ou désactiver l'affichage de la traduction dans les signets et l'historique." + Globals.NL +
                      "• Amélioration de la recherche d'une référence pour remplacer `,` ou `:` ou `-` ou `_` par `.` (fonctionne également pour la commande IPC)." + Globals.NL +
                      "• Correction de la ligne de commande pour aller à une référence afin de remplacer les espaces par `%20` (voir FAQ)." + Globals.NL +
                      "• Quelques correctifs et améliorations."
    },

    ["3.3"] = new TranslationsDictionary
    {
      [Language.EN] = "• Repair ELS50 verses incorrectly generated by a previous version.",

      [Language.FR] = "• Réparation des versets ELS50 générés de manière incorrecte par une version précédente."
    },

    ["3.0"] = new TranslationsDictionary
    {

      [Language.EN] = "• SQLite ODBC Driver is no more needed." + Globals.NL +
                      "• Overall performances are optimized." + Globals.NL +
                      "• Added and improved keyboard shortcuts" + Globals.NL +
                      "• Added verse navigator in the verses view panel." + Globals.NL +
                      "• Added option to render only current verse or all of the chapter." + Globals.NL +
                      "• Added book name translation text box in the navigation panel." + Globals.NL +
                      "• Added chapter title and memo text boxes in the navigation panel." + Globals.NL +
                      "• Added buttons to edit book and chapter memos in the navigation panel." + Globals.NL +
                      "• Added online search a word for several providers : Pealim, Sefaria, Wiktionary, Google, Bing..." + Globals.NL +
                      "• Added filter verses view panel." + Globals.NL +
                      "• Added parashot board with literal translations, lettriqs, verses references, study tools, edition and export." + Globals.NL +
                      "• Added options to choose mouse actions on words and verses." + Globals.NL +
                      "• Added menu for web links." + Globals.NL +
                      "• Added theming options." + Globals.NL +
                      "• Added usage statistics form in tools menu." + Globals.NL +
                      "• Added command line options." + Globals.NL +
                      "• Improved search options." + Globals.NL +
                      "• Improved about box." + Globals.NL +
                      "• Improved message boxes." + Globals.NL +
                      "• Improved check update." + Globals.NL +
                      "• Improved debugger." + Globals.NL +
                      "• Many fixes and improvements.",

      [Language.FR] = "• Le pilote SQLite ODBC n'est plus nécessaire." + Globals.NL +
                      "• Les performances globales sont optimisées." + Globals.NL +
                      "• Ajout et amélioration des raccourcis clavier." + Globals.NL +
                      "• Ajout du navigateur de verset dans le panneau d'affichage des versets." + Globals.NL +
                      "• Ajout d'une option pour afficher uniquement le verset actuel ou tout le chapitre." + Globals.NL +
                      "• Ajout d'une zone de texte de traduction du nom du livre dans le panneau de navigation." + Globals.NL +
                      "• Ajout de zones de texte de titre de chapitre et de mémo dans le panneau de navigation." + Globals.NL +
                      "• Ajout de boutons pour modifier les mémos de livre et de chapitre dans le panneau de navigation." + Globals.NL +
                      "• Ajout de la recherche en ligne d'un mot pour plusieurs fournisseurs : Pealim, Sefaria, Wiktionary, Google, Bing..." + Globals.NL +
                      "• Ajout d'un panneau d'affichage des versets de filtre." + Globals.NL +
                      "• Ajout d'un tableau de parashot avec traductions littérales, lettriqs, références de versets, outils d'étude, édition et exportation." + Globals.NL +
                      "• Ajout d'options pour choisir les actions de la souris sur les mots et les vers." + Globals.NL +
                      "• Ajout d'un menu pour les liens Web." + Globals.NL +
                      "• Ajout d'options de thème." + Globals.NL +
                      "• Ajout d'un formulaire de statistiques d'utilisation dans le menu Outils." + Globals.NL +
                      "• Ajout d'options de ligne de commande." + Globals.NL +
                      "• Amélioration des options de recherche." + Globals.NL +
                      "• Amélioration de la boîte à propos." + Globals.NL +
                      "• Amélioration des boîtes de messages." + Globals.NL +
                      "• Amélioration de la mise à jour." + Globals.NL +
                      "• Amélioration du débogueur." + Globals.NL +
                      "• Beaucoup de correctifs et d'améliorations."
    },

    ["2.x"] = new TranslationsDictionary
    {
      [Language.EN] = "• Added context menu on Hebrew words and verse numbers." + Globals.NL +
                      "• Added search for translations already made of a word." + Globals.NL +
                      "• Added master bookmark used at startup." + Globals.NL +
                      "• Added bookmarks." + Globals.NL +
                      "• Added history." + Globals.NL +
                      "• Added grammar guide." + Globals.NL +
                      "• Added import verse console" + Globals.NL +
                      "• Improved UI." + Globals.NL +
                      "• Improved verses, translations and search rendering and filters." + Globals.NL +
                      "• Improved statistics." + Globals.NL +
                      "• Improved tools." + Globals.NL +
                      "• Improved settings." + Globals.NL +
                      "• Some fixes and improvements.",

      [Language.FR] = "• Ajout d'un menu contextuel sur les mots hébreux et les numéros de versets." + Globals.NL +
                      "• Ajout de la recherche des traductions déjà effectuées d'un mot." + Globals.NL +
                      "• Ajout du signet principal utilisé au démarrage." + Globals.NL +
                      "• Ajout de signets." + Globals.NL +
                      "• Ajout de l'histoire." + Globals.NL +
                      "• Ajout d'un guide de grammaire." + Globals.NL +
                      "• Ajout d'une console d'import de verset." + Globals.NL +
                      "• Interface utilisateur améliorée." + Globals.NL +
                      "• Versets, traductions, rendus et filtres de recherche améliorés." + Globals.NL +
                      "• Statistiques améliorées." + Globals.NL +
                      "• Outils améliorés." + Globals.NL +
                      "• Paramètres améliorés." + Globals.NL +
                      "• Quelques corrections et améliorations."
    },

    ["1.x"] = new TranslationsDictionary
    {
      [Language.EN] = "• Initial release." + Globals.NL +
                      "• Board of Book Names." + Globals.NL +
                      "• Translation of every word of every verse via a dedicated editing area." + Globals.NL +
                      "• Export verses, chapters and books to MS Word DOCX or RTF." + Globals.NL +
                      "• Backup and restore database." + Globals.NL +
                      "• Tools for studying verses online." + Globals.NL +
                      "• Some statistics on the content of the Tanak.",

      [Language.FR] = "• Version initiale." + Globals.NL +
                      "• Tableau des noms des livres." + Globals.NL +
                      "• Traduction de chaque mot de chaque verset via une zone d'édition dédiée." + Globals.NL +
                      "• Export des versets, des chapitres et des livres en MS Word DOCX ou RTF." + Globals.NL +
                      "• Backup and restore database." + Globals.NL +
                      "• Outils pour étudier les versets en ligne." + Globals.NL +
                      "• Quelques statistiques sur le contenu du Tanak."
    }

  };

}
