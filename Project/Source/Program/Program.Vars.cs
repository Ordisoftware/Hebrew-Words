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
/// <edited> 2020-04 </edited>
using System;
using System.IO;
using Ordisoftware.Core;

namespace Ordisoftware.Hebrew.Words
{

  /// <summary>
  /// Provide Program class.
  /// </summary>
  static partial class Program
  {

    /// <summary>
    /// Indicate the default Settings instance.
    /// </summary>
    static public readonly Properties.Settings Settings
      = Properties.Settings.Default;

    /// <summary>
    /// Indicate application documents folder.
    /// </summary>
    static public string TanakFolderPath
      => Path.Combine(Globals.DocumentsFolderPath, "Tanak");

    /// <summary>
    /// Indicate application documents folder.
    /// </summary>
    static public string ParashaFolderPath
      => Path.Combine(Globals.DocumentsFolderPath, "Parasha");

    /// <summary>
    /// Indicate file path of the bookmaks.
    /// </summary>
    static public string BookmarksFilePath
      => Path.Combine(Globals.UserDataFolderPath, "Bookmarks.txt");

    /// <summary>
    /// Indicate file path of the history.
    /// </summary>
    static public string HistoryFilePath
    => Path.Combine(Globals.UserDataFolderPath, "History.txt");

    /// <summary>
    /// Indicate the grammar guide form.
    /// </summary>
    static public HTMLBrowserForm GrammarGuideForm
    {
      get
      {
        if ( _GrammarGuideForm == null )
          _GrammarGuideForm = new HTMLBrowserForm(HebrewTranslations.GrammarGuideTitle,
                                                  OnlineProviders.HebrewGrammarGuideFilePath,
                                                  nameof(Settings.GrammarGuideFormLocation),
                                                  nameof(Settings.GrammarGuideFormSize));
        return _GrammarGuideForm;
      }
    }
    static public HTMLBrowserForm _GrammarGuideForm;

  }

}
