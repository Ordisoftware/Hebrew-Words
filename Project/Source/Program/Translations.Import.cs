﻿/// <license>
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
/// <edited> 2020-08 </edited>
using System;
using Ordisoftware.Core;

namespace Ordisoftware.Hebrew.Words
{

  /// <summary>
  /// Localization strings.
  /// </summary>
  static public partial class Translations
  {

    static public readonly TranslationsDictionary ImportLinesCountMismatch
      = new TranslationsDictionary
      {
        { Language.EN, "Incorrect elements." + Globals.NL2 +
                        "Non empty lines count: {0}" + Globals.NL2 +
                        "Must be even."
        },
        { Language.FR, "Elements incorrects." + Globals.NL2 +
                        "Nombre de lignes non vides: {0}" + Globals.NL2 +
                        "Doit être pair."
        }
      };

    static public readonly TranslationsDictionary ImportItemsCountMismatch
      = new TranslationsDictionary
      {
        { Language.EN, "Incorrect elements." + Globals.NL2 +
                        "Words count: {0}" + Globals.NL +
                        "Translations count: {1}" + Globals.NL +
                        "Must be equal."
        },
        { Language.FR, "Elements incorrects." + Globals.NL2 +
                        "Nombre de mots: {0}" + Globals.NL +
                        "Nombre de translations: {1}" + Globals.NL +
                        "Doit être égal."
        }
      };

    static public readonly TranslationsDictionary ImportWordsCountMismatch
      = new TranslationsDictionary
      {
        { Language.EN, "Incorrect elements." + Globals.NL2 +
                        "Verse words count: {0}" + Globals.NL +
                        "Imported words count: {1}" + Globals.NL2 +
                        "Must be equal."
        },
        { Language.FR, "Elements incorrects." + Globals.NL2 +
                        "Nombre de mots du verset: {0}" + Globals.NL +
                        "Nombre de mots importés: {1}" + Globals.NL +Globals.NL +
                        "Doit être égal."
        }
      };

    static public readonly TranslationsDictionary ImportWordMismatch
      = new TranslationsDictionary
      {
        { Language.EN, "Incorrect hebrew." + Globals.NL2 +
                        "Verse word: {0}" + Globals.NL +
                        "Imported word: {1}" + Globals.NL2 +
                        "Must be equal."
        },
        { Language.FR, "Hébreu incorrect." + Globals.NL2 +
                        "Mot du verset: {0}" + Globals.NL +
                        "Mot importé: {1}" + Globals.NL2 +
                        "Doit être égal."
        }
      };

    static public readonly TranslationsDictionary ImportHelp
      = new TranslationsDictionary
      {
        { Language.EN, "This console allows for example to import an MS Word verse table." + Globals.NL2 +
                        "This table must first be converted to text with | as a separator." + Globals.NL2 +
                        "The import text must be presented in groups of two lines:" + Globals.NL +
                        "- A first containing a list of Hebrew words according to the Hebrew.ttf font," + Globals.NL +
                        "- A second containing a list of translations." + Globals.NL2 +
                        "There can be as many groups of two lines as necessary." + Globals.NL2 +
                        "Imported translation fields can be edited in the result grid."
        },
        { Language.FR, "Cette console permet par exemple d'importer un tableau de verset MS Word." + Globals.NL2 +
                        "Ce tableau doit préalablement être convertit en texte avec | comme séparateur." + Globals.NL2 +
                        "Le texte d'import doit ainsi se présenter par groupe de deux lignes :" + Globals.NL +
                        "- Une première contenant une liste de mots hébreux selon la police Hebrew.ttf," + Globals.NL +
                        "- Une deuxième contenant une liste de traductions." + Globals.NL2 +
                        "Il peut y avoir autant de groupe de deux lignes que nécessaire." + Globals.NL2 +
                        "Les champs de traduction importés peuvent être édités dans la grille du résultat."
        }
      };

  }

}
