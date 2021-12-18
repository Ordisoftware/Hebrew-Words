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

  static public readonly TranslationsDictionary SearchReferenceNotice = new()
  {

    [Language.EN] = "Usage:" + Globals.NL2 +
                    "'[Book number].[Chapter number].[Verse number]" + Globals.NL2 +
                    "'[Book name] [Chapter number].[Verse number]" + Globals.NL2 +
                    "The name of the book is not case sensitive and may be partial, so the first book found is taken, such as 'Kings I' for 'King'.",

    [Language.FR] = "Utilisation :" + Globals.NL2 +
                    "'[Numéro du livre].[Numéro du chapitre].[Numéro du verset]" + Globals.NL2 +
                    "'[Nom du livre] [Numéro du chapitre].[Numéro du verset]" + Globals.NL2 +
                    "Le nom du livre n'est pas sensible à la casse et peut être partiel, ainsi le premier livre trouvé est pris, tel que 'Rois I' pour 'Roi'.",
  };

  static public readonly TranslationsDictionary SearchVerseNotice = new()
  {

    [Language.EN] = "Use 0 to go to the first:" + Globals.NL2 +
                    "- Verse not translated or partially translated if verse 1 is completely translated." + Globals.NL2 +
                    "- First verse translated or partially translated if verse 1 is not even partially translated.",

    [Language.FR] = "Utilisez 0 pour aller au premier :" + Globals.NL2 +
                    "- Verset non traduit ou partiellement traduit si le verset 1 est complètement traduit." + Globals.NL2 +
                    "- Premier verset traduit ou partiellement traduit si le verset 1 n'est pas traduit même partiellement."
  };

  static public readonly TranslationsDictionary FilterVersesNotice = new()
  {

    [Language.EN] = "Filter books on the transcription of the Hebrew name, the common name, the translation, the lettriq and the memo." + Globals.NL2 +
                    "Filter chapters on the title and the memo." + Globals.NL2 +
                    "Filter verses on the translation and the comment." + Globals.NL2 +
                    "Only one word or sentence per filter." + Globals.NL2 +
                    "The filters are cumulative without case or signs, press Enter or exit the input box to start the query.",

    [Language.FR] = "Filtre les livres sur la transcription du nom hébreu, le nom commun, la traduction, la lettrique et le mémo." + Globals.NL2 +
                    "Filtre les chapitres sur le titre et le mémo." + Globals.NL2 +
                    "Filtre les versets sur la traduction et le commentaire." + Globals.NL2 +
                    "Un seul mot ou phrase par filtre." + Globals.NL2 +
                    "Note: Les filtres sont cumulatifs sans casse ni signes, appuyez sur Entrée ou quittez la zone de saisie pour lancer la requête."

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
                    "This table must first be converted to text with | as a separator or a tab." + Globals.NL2 +
                    "The import text must be presented in groups of two lines:" + Globals.NL +
                    "- A first containing a list of Hebrew words according to the Hebrew.ttf font," + Globals.NL +
                    "- A second containing a list of translations." + Globals.NL2 +
                    "There can be as many groups of two lines as necessary." + Globals.NL2 +
                    "Imported translation fields can be edited in the result grid.",

    [Language.FR] = "Cette console permet par exemple d'importer un tableau de verset MS Word." + Globals.NL2 +
                    "Ce tableau doit préalablement être convertit en texte avec | comme séparateur ou une tabulation." + Globals.NL2 +
                    "Le texte d'import doit ainsi se présenter par groupe de deux lignes :" + Globals.NL +
                    "- Une première contenant une liste de mots hébreux selon la police Hebrew.ttf," + Globals.NL +
                    "- Une deuxième contenant une liste de traductions." + Globals.NL2 +
                    "Il peut y avoir autant de groupe de deux lignes que nécessaire." + Globals.NL2 +
                    "Les champs de traduction importés peuvent être édités dans la grille du résultat."
  };

}
