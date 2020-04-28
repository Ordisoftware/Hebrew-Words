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

    static public readonly Dictionary<string, string> OpenOnlineSearchNotice
      = new Dictionary<string, string>()
      {
        { "en", "Use the %WORD% tag to replace the value." },
        { "fr", "Utiliser le tag %WORD% pour remplacer la valeur." },
      };

    static public readonly Dictionary<string, string> OpenOnlineVerseNotice
      = new Dictionary<string, string>()
      {
        { "en", "Use the following tags to replace values:" + NewLine + NewLine +
                "%BOOKSB% : StudyBible.org book name" + NewLine +
                "%BOOKBIBLEHUB% : BibleHub.org book name" + NewLine +
                "%BOOKCHABAD% : Chabad.org book name" + NewLine +
                "%BOOKEL% : LEvangile.com book name" + NewLine +
                "%BOOKMM% : Mechon-Mamre.org book name" + NewLine +
                "%BOOKDJEP% : Djep.hd.free.fr book name" + NewLine + NewLine +
                "%BOOKNUM% : Book number" + NewLine +
                "%CHAPTERNUM% : Chapter number" + NewLine +
                "%VERSENUM% : Verse number" + NewLine + NewLine +
                "%BOOKNUM#2% : Book number in two digits" + NewLine +
                "%CHAPTERNUM#2% : Chapter number in two digits" + NewLine +
                "%VERSENUM#2% : Verse number in two digits" },
        { "fr", "Utiliser les tags suivants pour remplacer les valeurs :" + NewLine + NewLine +
                "%BOOKSB% : Nom du livre StudyBible.org" + NewLine +
                "%BOOKBIBLEHUB% : Nom du livre BibleHub.org" + NewLine +
                "%BOOKCHABAD% : Nom du livre Chabad.org" + NewLine +
                "%BOOKEL% : Nom du livre LEvangile.com" + NewLine +
                "%BOOKMM% : Nom du livre Mechon-Mamre.org" + NewLine +
                "%BOOKDJEP% : Nom du livre Djep.hd.free.fr" + NewLine + NewLine +
                "%BOOKNUM% : Numéro du livre" + NewLine +
                "%CHAPTERNUM% : Numéro du chaptre" + NewLine +
                "%VERSENUM% : Numéro du verset" + NewLine + NewLine +
                "%BOOKNUM#2% : Numéro du livre sur 2 digits" + NewLine +
                "%CHAPTERNUM#2% : Numéro du chapitre sur 2 digits" + NewLine +
                "%VERSENUM#2% : Numéro du verset sur 2 digits" },
      };

  }

}
