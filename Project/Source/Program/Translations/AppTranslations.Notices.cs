/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2024 Olivier Rogier.
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
/// <edited> 2022-08 </edited>
namespace Ordisoftware.Hebrew.Words;

static partial class AppTranslations
{

  static public readonly TranslationsDictionary SelectVerseNotice = new()
  {

    [Language.EN] = "Search a book using its number, transcription or common name (English or French case and diacritics insensitive using . or , or : or - or _)." + Globals.NL2 +
                    "Samples:" + Globals.NL2 +
                    "    bereshit 1.1" + Globals.NL +
                    "    judges 10,2" + Globals.NL +
                    "    tehilim 3" + Globals.NL +
                    "    1.2.3",

    [Language.FR] = "Chercher un livre par son numéro, transcription ou nom commun (anglais ou français casse et diacritique insensible en utilisant . ou , ou : ou - ou _)." + Globals.NL2 +
                    "Examples:" + Globals.NL2 +
                    "    bereshit 1.1" + Globals.NL +
                    "    juges 10,2" + Globals.NL +
                    "    psaume 3" + Globals.NL +
                    "    1.2.3"

  };

  static public readonly TranslationsDictionary FilterVersesNotice = new()
  {

    [Language.EN] = "Filter books on any number, transcription, common name, translation, lettriq and memo." + Globals.NL2 +
                    "Filter chapters on the title and the memo." + Globals.NL2 +
                    "Filter verses on the title, translation and the comment." + Globals.NL2 +
                    "Only one word or sentence per filter." + Globals.NL2 +
                    "Case and signs are not considered." + Globals.NL2 +
                    "Press Enter or exit the input box to start the query.",

    [Language.FR] = "Filtre les livres sur toute transcription, nom commun, traduction, lettrique et mémo." + Globals.NL2 +
                    "Filtre les chapitres sur le titre et le mémo." + Globals.NL2 +
                    "Filtre les versets sur le titre, la traduction et le commentaire." + Globals.NL2 +
                    "Un seul mot ou phrase par filtre." + Globals.NL2 +
                    "La casse et les signes ne sont pas considérés." + Globals.NL2 +
                    "Appuyez sur Entrée ou quittez la zone de saisie pour lancer la requête."

  };

  static public readonly TranslationsDictionary FilterTranslationNotice = new()
  {

    [Language.EN] = "Filter verses on the title, translation and the comment." + Globals.NL2 +
                    "Only one word or sentence." + Globals.NL2 +
                    "Case and signs are not considered." + Globals.NL2 +
                    "Press Enter or exit the input box to start the query.",

    [Language.FR] = "Filtre les versets sur le titre, la traduction et le commentaire." + Globals.NL2 +
                    "Un seul mot ou phrase." + Globals.NL2 +
                    "La casse et les signes ne sont pas considérés." + Globals.NL2 +
                    "Appuyez sur Entrée ou quittez la zone de saisie pour lancer la requête."

  };

  static public readonly TranslationsDictionary RenderAllVersesKeepNotice = new()
  {

    [Language.EN] = "If keep rendering all verses in the chapter is unchecked, this option will be disabled by switching to the filter and search verse views, and thus only one verse will be displayed again. Closing the app will not retain the option to view all verses." + Globals.NL2 +
                    "This allow allows the application to run faster if the machine is not powerful enough or if it is personal preference.",

    [Language.FR] = "Si conserver le rendu de tous les versets du chapitre est décoché, cette option sera désactivée en basculant vers les vues de filtrage et de recherche de versets, et ainsi un seul verset sera à nouveau affiché. La fermeture de l'application ne conservera pas l'option d'affichage de tous les versets." + Globals.NL2 +
                    "Cela permet une exécution plus rapide de l'application en cas de machine pas assez puissante ou de préférence personnelle."
  };

  static public readonly TranslationsDictionary ImportNotice = new()
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

}
