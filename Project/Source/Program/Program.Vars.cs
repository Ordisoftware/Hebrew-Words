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
/// <edited> 2020-04 </edited>
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Ordisoftware.HebrewCommon;

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// Provide Program class.
  /// </summary>
  static partial class Program
  {

    /// <summary>
    /// Indicate if the application is exiting.
    /// </summary>
    static public bool IsExiting = false;

    /// <summary>
    /// Indicate if is in loading data stage.
    /// </summary>
    static public bool IsLoadingData = false;

    /// <summary>
    /// Indicate if the application is ready for the user.
    /// </summary>
    static public bool IsReady = false;

    /// <summary>
    /// Indicate if windows session is ending.
    /// </summary>
    static public bool IsSessionEnding = false;

    /// <summary>
    /// Indicate if application can be closed.
    /// </summary>
    static public bool AllowClose = false;

    /// <summary>
    /// Indicate the default Settings instance.
    /// </summary>
    static public readonly Properties.Settings Settings 
      = Properties.Settings.Default;

    /// <summary>
    /// Indicate the check update URL.
    /// </summary>
    static public string CheckUpdateURL
    {
      get
      {
        string title = AboutBox.Instance.AssemblyTitle;
        return $"http://{AboutBox.Instance.AssemblyTrademark}/files/{title.Replace(" ", "")}.update";
      }
    }

    /// <summary>
    /// Indicate the download application URL.
    /// </summary>
    static public string DownloadApplicationURL
    {
      get
      {
        return AboutBox.Instance.AssemblyProduct;
      }
    }

    /// <summary>
    /// Indicate the GitHub repository.
    /// </summary>
    static public string GitHubRepositoryURL
    {
      get
      {
        string title = AboutBox.Instance.AssemblyTitle;
        return $"https://github.com/{AboutBox.Instance.CompanyName}/{title.Replace(" ", "-")}";
      }
    }

    /// <summary>
    /// Indicate root folder path of the application.
    /// </summary>
    static public readonly string AppRootFolderPath
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
    static public readonly string AppDocumentsFolderPath
      = AppRootFolderPath + "Documents" + Path.DirectorySeparatorChar;

    /// <summary>
    /// Indicate application documents folder.
    /// </summary>
    static public readonly string TanakFolderPath
      = AppDocumentsFolderPath + "Tanak" + Path.DirectorySeparatorChar;

    /// <summary>
    /// Indicate application documents folder.
    /// </summary>
    static public readonly string ParashaFolderPath
      = AppDocumentsFolderPath + "Parasha" + Path.DirectorySeparatorChar;

    /// <summary>
    /// Indicate application documents folder.
    /// </summary>
    static public readonly string LinksFolderPath
      = AppDocumentsFolderPath + "Links" + Path.DirectorySeparatorChar;

    /// <summary>
    /// Indicate user data folder in roaming.
    /// </summary>
    static public string UserDataFolderPath
    {
      get
      {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                    + Path.DirectorySeparatorChar
                    + AboutBox.Instance.AssemblyCompany
                    + Path.DirectorySeparatorChar
                    + AboutBox.Instance.AssemblyTitle
                    + Path.DirectorySeparatorChar;
        Directory.CreateDirectory(path);
        return path;
      }
    }

    /// <summary>
    /// Indicate user documents folder path.
    /// </summary>
    static public string UserDocumentsFolderPath
    {
      get
      {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                    + Path.DirectorySeparatorChar
                    + AboutBox.Instance.AssemblyCompany
                    + Path.DirectorySeparatorChar
                    + AboutBox.Instance.AssemblyTitle
                    + Path.DirectorySeparatorChar;
        Directory.CreateDirectory(path);
        return path;
      }
    }

    /// <summary>
    /// Indicate the extension of database file.
    /// </summary>
    static public readonly string DBFileExtension
      = ".sqlite";

    /// <summary>
    /// Indicate filename of the application's icon.
    /// </summary>
    static public readonly string IconFilename
      = AppRootFolderPath + "Application.ico";

    /// <summary>
    /// Indicate filename of the help.
    /// </summary>
    static public string HelpFilename
    {
      get
      {
        return AppRootFolderPath + $"Help{Path.DirectorySeparatorChar}index-{Localizer.Language}.htm";
      }
    }

    /// <summary>
    /// Indicate filename of the grammar guide.
    /// </summary>
    static public string GrammarGuideFilename
    {
      get
      {
        return AppRootFolderPath + $"Help{Path.DirectorySeparatorChar}grammar-{Localizer.Language}.htm";
      }
    }

    /// <summary>
    /// Indicate filename of the online search a word providers.
    /// </summary>
    static public readonly string OnlineWordProvidersFileName
      = AppDocumentsFolderPath + "OnlineWordProviders.txt";

    /// <summary>
    /// Indicate filename of the online bible search a verse providers.
    /// </summary>
    static public readonly string OnlineBibleProvidersFileName
      = AppDocumentsFolderPath + "OnlineBibleProviders.txt";

    /// <summary>
    /// Indicate online search a word providers.
    /// </summary>
    static public readonly OnlineProviders OnlineWordProviders
      = new OnlineProviders(OnlineWordProvidersFileName);

    /// <summary>
    /// Indicate online bible search a verse providers.
    /// </summary>
    static public readonly OnlineProviders OnlineBibleProviders
      = new OnlineProviders(OnlineBibleProvidersFileName);

    /// <summary>
    /// Indicate online links providers.
    /// </summary>
    static public readonly List<OnlineProviders> OnlineLinksProviders
      = new List<OnlineProviders>();

    /// <summary>
    /// Indicate filename of the bookmaks.
    /// </summary>
    static public string BookmarksFilename
    {
      get
      {
        return UserDataFolderPath + "Bookmarks.txt";
      }
    }

    /// <summary>
    /// Indicate filename of the history.
    /// </summary>
    static public string HistoryFilename
    {
      get
      {
        return UserDataFolderPath + "History.txt";
      }
    }

    /// <summary>
    /// Static constructor.
    /// </summary>
    static Program()
    {
      foreach ( var file in Directory.GetFiles(LinksFolderPath, "*.txt") )
        OnlineLinksProviders.Add(new OnlineProviders(file));
    }

  }

}
