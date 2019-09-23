/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2019 Olivier Rogier.
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
/// <edited> 2019-09 </edited>
using System.IO;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  static partial class Program
  {

    /// <summary>
    /// Indicate the default Settings instance.
    /// </summary>
    static public readonly Properties.Settings Settings = Properties.Settings.Default;

    /// <summary>
    /// Indicate root folder path of the application.
    /// </summary>
    static public readonly string RootFolderPath
      = Directory.GetParent
        (
          Path.GetDirectoryName(Application.ExecutablePath
                                .Replace("\\Bin\\Debug\\", "\\Bin\\")
                                .Replace("\\Bin\\Release\\", "\\Bin\\"))
        ).FullName
      + Path.DirectorySeparatorChar;

    /// <summary>
    /// Indicate application documents folder.
    /// </summary>
    static public readonly string DocumentsFolderPath
      = RootFolderPath + "Documents" + Path.DirectorySeparatorChar;

    /// <summary>
    /// Indicate user data folder in roaming.
    /// </summary>
    static public string UserDataFolderPath { get; private set; }

    /// <summary>
    /// Indicate user documents folder path.
    /// </summary>
    static public string UserDocumentsFolderPath { get; private set; }

    /// <summary>
    /// Indicate the extension of database file.
    /// </summary>
    static public readonly string DBFileExtension
      = ".sqlite";

    /// <summary>
    /// Indicate filename of the application's icon.
    /// </summary>
    static public readonly string IconFilename
      = RootFolderPath + "Application.ico";

    /// <summary>
    /// Indicate name of the help file.
    /// </summary>
    static public readonly string HelpFilename
      = RootFolderPath + "Help" + Path.DirectorySeparatorChar + "index-" + Localizer.Language + ".htm";

    /// <summary>
    /// Indicate name of the help file.
    /// </summary>
    static public readonly string GrammarGuideFilename
      = RootFolderPath + "Help" + Path.DirectorySeparatorChar + "grammar-%lang%.htm";

  }

}
