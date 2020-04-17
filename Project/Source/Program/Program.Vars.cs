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
using System.IO;
using Ordisoftware.HebrewCommon;

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// Provide Program class.
  /// </summary>
  static partial class Program
  {

    /// <summary>
    /// Indicate application documents folder.
    /// </summary>
    static public readonly string TanakFolderPath
      = Globals.DocumentsFolderPath + "Tanak" + Path.DirectorySeparatorChar;

    /// <summary>
    /// Indicate application documents folder.
    /// </summary>
    static public readonly string ParashaFolderPath
      = Globals.DocumentsFolderPath + "Parasha" + Path.DirectorySeparatorChar;

    /// <summary>
    /// Indicate filename of the bookmaks.
    /// </summary>
    static public string BookmarksFilename
      = Globals.UserDataFolderPath + "Bookmarks.txt";

    /// <summary>
    /// Indicate filename of the history.
    /// </summary>
    static public string HistoryFilename
    = Globals.UserDataFolderPath + "History.txt";

    /// <summary>
    /// Indicate filename of the grammar guide.
    /// </summary>
    static public string GrammarGuideFilename
      = Globals.HelpFolderPath + $"grammar-%LANG%.htm";

    /// <summary>
    /// Indicate the grammar guide form.
    /// </summary>
    static public HTMLBrowserForm GrammarGuideForm
    {
      get
      {
        if ( _GrammarGuideForm == null )
          _GrammarGuideForm = HTMLBrowserForm.Create(Translations.GrammarGuideTitle, GrammarGuideFilename);
        return _GrammarGuideForm;
      }
    }
    static public HTMLBrowserForm _GrammarGuideForm;


  }

}
