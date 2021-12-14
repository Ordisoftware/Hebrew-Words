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
/// <created> 2021-02 </created>
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

/// <summary>
/// Localization strings.
/// </summary>
static partial class AppTranslations
{

  static public readonly NullSafeDictionary<string, TranslationsDictionary> NoticeNewFeatures = new()
  {

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
                      "• Added online search a word for several providers : Pealim, Sefaria, Dict.com, Wiktionary, Google, Bing, Reverso, Glosbe." + Globals.NL +
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
                      "• Ajout de la recherche en ligne d'un mot pour plusieurs fournisseurs : Pealim, Sefaria, Dict.com, Wiktionary, Google, Bing, Reverso, Glosbe." + Globals.NL +
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
    },

  };

}
