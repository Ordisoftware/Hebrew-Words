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
using Ordisoftware.HebrewCommon;

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
        { Localizer.EN, "Incorrect elements." + Localizer.NL + Localizer.NL +
                        "Non empty lines count: {0}" + Localizer.NL + Localizer.NL +
                        "Must be even." },
        { Localizer.FR, "Elements incorrects." + Localizer.NL + Localizer.NL +
                        "Nombre de lignes non vides: {0}" + Localizer.NL + Localizer.NL +
                        "Doit être pair." }
      };

    static public readonly Dictionary<string, string> ImportItemsCountMismatch
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Incorrect elements." + Localizer.NL + Localizer.NL +
                        "Words count: {0}" + Localizer.NL +
                        "Translations count: {1}" + Localizer.NL +
                        "Must be equal."},
        { Localizer.FR, "Elements incorrects." + Localizer.NL + Localizer.NL +
                        "Nombre de mots: {0}" + Localizer.NL +
                        "Nombre de translations: {1}" + Localizer.NL +
                        "Doit être égal." }
      };

    static public readonly Dictionary<string, string> ImportWordsCountMismatch
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Incorrect elements." + Localizer.NL + Localizer.NL +
                        "Verse words count: {0}" + Localizer.NL +
                        "Imported words count: {1}" + Localizer.NL + Localizer.NL +
                        "Must be equal." },
        { Localizer.FR, "Elements incorrects." + Localizer.NL + Localizer.NL +
                        "Nombre de mots du verset: {0}" + Localizer.NL +
                        "Nombre de mots importés: {1}" + Localizer.NL +Localizer.NL +
                        "Doit être égal." }
      };

    static public readonly Dictionary<string, string> ImportWordMismatch
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Incorrect hebrew." + Localizer.NL + Localizer.NL +
                        "Verse word: {0}" + Localizer.NL +
                        "Imported word: {1}" + Localizer.NL + Localizer.NL +
                        "Must be equal." },
        { Localizer.FR, "Hébreu incorrect." + Localizer.NL + Localizer.NL +
                        "Mot du verset: {0}" + Localizer.NL +
                        "Mot importé: {1}" + Localizer.NL + Localizer.NL +
                        "Doit être égal." }
      };

    static public readonly Dictionary<string, string> ImportHelp
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "This console allows for example to import an MS Word verse table." + Localizer.NL + Localizer.NL +
                        "This table must first be converted to text with | as a separator." + Localizer.NL + Localizer.NL +
                        "The import text must be presented in groups of two lines:" + Localizer.NL +
                        "- A first containing a list of Hebrew words according to the Hebrew.ttf font," + Localizer.NL +
                        "- A second containing a list of translations." + Localizer.NL + Localizer.NL +
                        "There can be as many groups of two lines as necessary." + Localizer.NL + Localizer.NL +
                        "Imported translation fields can be edited in the result grid." },
        { Localizer.FR, "Cette console permet par exemple d'importer un tableau de verset MS Word." + Localizer.NL + Localizer.NL +
                        "Ce tableau doit préalablement être convertit en texte avec | comme séparateur." + Localizer.NL + Localizer.NL +
                        "Le texte d'import doit ainsi se présenter par groupe de deux lignes :" + Localizer.NL +
                        "- Une première contenant une liste de mots hébreux selon la police Hebrew.ttf," + Localizer.NL +
                        "- Une deuxième contenant une liste de traductions." + Localizer.NL + Localizer.NL +
                        "Il peut y avoir autant de groupe de deux lignes que nécessaire." + Localizer.NL + Localizer.NL +
                        "Les champs de traduction importés peuvent être édités dans la grille du résultat." }
      };

  }

}
