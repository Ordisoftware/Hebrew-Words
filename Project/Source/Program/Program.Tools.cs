﻿/// <license>
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
/// <edited> 2020-03 </edited>
using System;
using System.IO;
using Ordisoftware.HebrewCommon;
using Ordisoftware.Core;

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// Provide Program class.
  /// </summary>
  static partial class Program
  {

    /// <summary>
    /// Start Hebrew Letters process.
    /// </summary>
    /// <param name="hebrew">The hebrew font chars of teh word.</param>
    static public void OpenHebrewLetters(string hebrew)
    {
      if ( !File.Exists(Settings.HebrewLettersExe) )
      {
        if ( DisplayManager.QueryYesNo(Translations.AskToDownloadHebrewLetters.GetLang()) )
          MainForm.Instance.ActionDownloadHebrewLetters.PerformClick();
        return;
      }
      hebrew = HebrewAlphabet.SetFinal(hebrew, false);
      if ( hebrew.StartsWith("a ") )
        hebrew = hebrew.Substring(2, hebrew.Length - 2);
      else
      if ( hebrew.StartsWith("b ") )
        hebrew = hebrew.Substring(2, hebrew.Length - 2);
      foreach ( string item in hebrew.Split(' ') )
        RunShell(Settings.HebrewLettersExe, item);
    }

    /// <summary>
    /// Open default online concordance search url.
    /// </summary>
    /// <param name="hebrew">The hebrew font chars of teh word.</param>
    static public void OpenOnlineConcordance(string hebrew)
    {
      RunShell(Settings.SearchOnlineURL.Replace("%WORD%", hebrew));
    }

    /// <summary>
    /// Open default online verse search url.
    /// </summary>
    static public void OpenOnlineVerse(string url, int book, int chapter, int verse)
    {
      RunShell(url.Replace("%BOOKSB%", BooksNames.StudyBible[(Books)( book - 1 )])
                  .Replace("%BOOKBIBLEHUB%", BooksNames.BibleHub[(Books)( book - 1 )])
                  .Replace("%BOOKCHABAD%", BooksNames.Chabad[(Books)( book - 1 )])
                  .Replace("%BOOKMM%", BooksNames.MechonMamre[(Books)( book - 1 )])
                  .Replace("%BOOKDJEP%", BooksNames.Djep[(Books)( book - 1 )])
                  .Replace("%BOOKNUM%", book.ToString())
                  .Replace("%CHAPTERNUM%", chapter.ToString())
                  .Replace("%VERSENUM%", verse.ToString())
                  .Replace("%BOOKNUM#2%", book.ToString("00"))
                  .Replace("%CHAPTERNUM#2%", chapter.ToString("00"))
                  .Replace("%VERSENUM#2%", verse.ToString("00")));
    }

  }

}
