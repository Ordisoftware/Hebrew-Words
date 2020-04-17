/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2020 Olivier Rogier.
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
/// <edited> 2020-04 </edited>
using System;
using System.Collections.Generic;

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// Localization strings.
  /// </summary>
  static public partial class Translations
  {

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

  }

}
