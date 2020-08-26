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

    static public readonly Dictionary<string, string> OpenOnlineSearchNotice
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Use the %WORD% tag to replace the value." },
        { Localizer.FR, "Utiliser le tag %WORD% pour remplacer la valeur." },
      };

    static public readonly Dictionary<string, string> OpenOnlineVerseNotice
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Use the following tags to replace values:" + Localizer.NL + Localizer.NL +
                        "%BOOKSB% : StudyBible.org book name" + Localizer.NL +
                        "%BOOKBIBLEHUB% : BibleHub.org book name" + Localizer.NL +
                        "%BOOKCHABAD% : Chabad.org book name" + Localizer.NL +
                        "%BOOKEL% : LEvangile.com book name" + Localizer.NL +
                        "%BOOKMM% : Mechon-Mamre.org book name" + Localizer.NL +
                        "%BOOKDJEP% : Djep.hd.free.fr book name" + Localizer.NL + Localizer.NL +
                        "%BOOKNUM% : Book number" + Localizer.NL +
                        "%CHAPTERNUM% : Chapter number" + Localizer.NL +
                        "%VERSENUM% : Verse number" + Localizer.NL + Localizer.NL +
                        "%BOOKNUM#2% : Book number in two digits" + Localizer.NL +
                        "%CHAPTERNUM#2% : Chapter number in two digits" + Localizer.NL +
                        "%VERSENUM#2% : Verse number in two digits" },
        { Localizer.FR, "Utiliser les tags suivants pour remplacer les valeurs :" + Localizer.NL + Localizer.NL +
                        "%BOOKSB% : Nom du livre StudyBible.org" + Localizer.NL +
                        "%BOOKBIBLEHUB% : Nom du livre BibleHub.org" + Localizer.NL +
                        "%BOOKCHABAD% : Nom du livre Chabad.org" + Localizer.NL +
                        "%BOOKEL% : Nom du livre LEvangile.com" + Localizer.NL +
                        "%BOOKMM% : Nom du livre Mechon-Mamre.org" + Localizer.NL +
                        "%BOOKDJEP% : Nom du livre Djep.hd.free.fr" + Localizer.NL + Localizer.NL +
                        "%BOOKNUM% : Numéro du livre" + Localizer.NL +
                        "%CHAPTERNUM% : Numéro du chaptre" + Localizer.NL +
                        "%VERSENUM% : Numéro du verset" + Localizer.NL + Localizer.NL +
                        "%BOOKNUM#2% : Numéro du livre sur 2 digits" + Localizer.NL +
                        "%CHAPTERNUM#2% : Numéro du chapitre sur 2 digits" + Localizer.NL +
                        "%VERSENUM#2% : Numéro du verset sur 2 digits" },
      };

  }

}
