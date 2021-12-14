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
      [Language.EN] = "" + Globals.NL +
                      "",

      [Language.FR] = "" + Globals.NL +
                      ""
    },

    ["2.x"] = new TranslationsDictionary
    {
      [Language.EN] = "Added context menu on Hebrew words and verse numbers." + Globals.NL +
                      "Added search for translations already made of a word." + Globals.NL +
                      "Added master bookmark used at startup." + Globals.NL +
                      "Added bookmarks." + Globals.NL +
                      "Added history." + Globals.NL +
                      "Added grammar guide." + Globals.NL +
                      "Added import verse console" + Globals.NL +
                      "Improved UI." + Globals.NL +
                      "Improved verses, translations and search rendering and filters." + Globals.NL +
                      "Improved statistics." + Globals.NL +
                      "Improved tools." + Globals.NL +
                      "Improved settings." + Globals.NL +
                      "Some fixes and improvements.",

      [Language.FR] = "Ajout d'un menu contextuel sur les mots hébreux et les numéros de versets." + Globals.NL +
                      "Ajout de la recherche des traductions déjà effectuées d'un mot." + Globals.NL +
                      "Ajout du signet principal utilisé au démarrage." + Globals.NL +
                      "Ajout de signets." + Globals.NL +
                      "Ajout de l'histoire." + Globals.NL +
                      "Ajout d'un guide de grammaire." + Globals.NL +
                      "Ajout d'une console d'import de verset." + Globals.NL +
                      "Interface utilisateur améliorée." + Globals.NL +
                      "Versets, traductions, rendus et filtres de recherche améliorés." + Globals.NL +
                      "Statistiques améliorées." + Globals.NL +
                      "Outils améliorés." + Globals.NL +
                      "Paramètres améliorés." + Globals.NL +
                      "Quelques corrections et améliorations."
    },

    ["1.x"] = new TranslationsDictionary
    {
      [Language.EN] = "Initial release." + Globals.NL +
                      "Board of Book Names." + Globals.NL +
                      "Translation of every word of every verse via a dedicated editing area." + Globals.NL +
                      "Export verses, chapters and books to MS Word DOCX or RTF." + Globals.NL +
                      "Backup and restore database." + Globals.NL +
                      "Tools for studying verses online." + Globals.NL +
                      "Some statistics on the content of the Tanak.",

      [Language.FR] = "Version initiale." + Globals.NL +
                      "Tableau des noms des livres." + Globals.NL +
                      "Traduction de chaque mot de chaque verset via une zone d'édition dédiée." + Globals.NL +
                      "Export des versets, des chapitres et des livres en MS Word DOCX ou RTF." + Globals.NL +
                      "Backup and restore database." + Globals.NL +
                      "Outils pour étudier les versets en ligne." + Globals.NL +
                      "Quelques statistiques sur le contenu du Tanak."
    },

  };

}
