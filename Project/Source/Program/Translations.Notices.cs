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

    static public readonly TranslationsDictionary OpenOnlineSearchNotice
      = new TranslationsDictionary
      {
        { Language.EN, "Use the %WORD% tag to replace the value." },
        { Language.FR, "Utiliser le tag %WORD% pour remplacer la valeur." },
      };

    static public readonly TranslationsDictionary OpenOnlineVerseNotice
      = new TranslationsDictionary
      {
        { Language.EN, "Use the following tags to replace values:" + Globals.NL2 +
                        "%BOOKSB% : StudyBible.org book name" + Globals.NL +
                        "%BOOKBIBLEHUB% : BibleHub.org book name" + Globals.NL +
                        "%BOOKSEFARIA% : Sefaria.org book name" + Globals.NL +
                        "%BOOKCHABAD% : Chabad.org book name" + Globals.NL +
                        "%BOOKMM% : Mechon-Mamre.org book name" + Globals.NL +
                        "%BOOKEL% : LEvangile.com book name" + Globals.NL +
                        "%BOOKDJEP% : Djep.hd.free.fr book name" + Globals.NL2 +
                        "%BOOKNUM% : Book number" + Globals.NL +
                        "%CHAPTERNUM% : Chapter number" + Globals.NL +
                        "%VERSENUM% : Verse number" + Globals.NL2 +
                        "%BOOKNUM#2% : Book number in two digits" + Globals.NL +
                        "%CHAPTERNUM#2% : Chapter number in two digits" + Globals.NL +
                        "%VERSENUM#2% : Verse number in two digits"
        },
        { Language.FR, "Utiliser les tags suivants pour remplacer les valeurs :" + Globals.NL2 +
                        "%BOOKSB% : Nom du livre StudyBible.org" + Globals.NL +
                        "%BOOKBIBLEHUB% : Nom du livre BibleHub.org" + Globals.NL +
                        "%BOOKSEFARIA% : Nom du livre Sefaria.org" + Globals.NL +
                        "%BOOKCHABAD% : Nom du livre Chabad.org" + Globals.NL +
                        "%BOOKMM% : Nom du livre Mechon-Mamre.org" + Globals.NL +
                        "%BOOKEL% : Nom du livre LEvangile.com" + Globals.NL +
                        "%BOOKDJEP% : Nom du livre Djep.hd.free.fr" + Globals.NL2 +
                        "%BOOKNUM% : Numéro du livre" + Globals.NL +
                        "%CHAPTERNUM% : Numéro du chaptre" + Globals.NL +
                        "%VERSENUM% : Numéro du verset" + Globals.NL2 +
                        "%BOOKNUM#2% : Numéro du livre sur 2 digits" + Globals.NL +
                        "%CHAPTERNUM#2% : Numéro du chapitre sur 2 digits" + Globals.NL +
                        "%VERSENUM#2% : Numéro du verset sur 2 digits"
        },
      };

  }

}
