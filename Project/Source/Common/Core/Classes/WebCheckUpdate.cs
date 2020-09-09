﻿/// <license>
/// This file is part of Ordisoftware Core Library.
/// Copyright 2004-2020 Olivier Rogier.
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
/// <edited> 2020-09 </edited>
using System;
using System.Linq;
using System.IO;
using System.Net;
using System.Threading;
using System.Collections.Generic;
using System.Windows.Forms;
using Ordisoftware.Core;

namespace Ordisoftware.Core
{

  /// <summary>
  /// Provide web check update.
  /// </summary>
  static class WebCheckUpdate
  {
    static public int DefaultCheckDaysInterval = 7;

    static private bool Mutex;

    /// <summary>
    /// Check if an update is available online and offer to install, download or open product web page.
    /// App version is "MAJOR.MINOR".
    /// </summary>
    /// <param name="checkAtStartup"></param>
    /// <param name="lastdone">The last done date.</param>
    /// <param name="auto">True if no user interaction else false</param>
    /// <returns>True if application must exist else false.</returns>
    static public bool Run(bool checkAtStartup, ref DateTime lastdone, bool auto)
    {
      if ( Mutex ) return false;
      if ( auto && !checkAtStartup ) return false;
      if ( auto && lastdone.AddDays(DefaultCheckDaysInterval) >= DateTime.Now ) return false;
      bool formEnabled = Globals.MainForm?.Enabled ?? false;
      try
      {
        Mutex = true;
        if ( Globals.MainForm != null ) Globals.MainForm.Enabled = false;
        LoadingForm.Instance.Initialize(SysTranslations.WebCheckUpdate.GetLang(), 3, 0, false);
        var files = Directory.GetFiles(Path.GetTempPath(), string.Format(Globals.SetupFileName, "*"));
        foreach ( string s in files ) SystemManager.TryCatch(() => File.Delete(s));
        LoadingForm.Instance.DoProgress();
        using ( WebClient client = new WebClient() )
        {
          var fileInfo = GetVersionAndChecksum(client);
          lastdone = DateTime.Now;
          LoadingForm.Instance.DoProgress();
          if ( fileInfo.Item1.CompareTo(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version) > 0 )
            return GetUserChoice(client, fileInfo);
          else
          if ( !auto )
            DisplayManager.ShowInformation(SysTranslations.NoNewVersionAvailable.GetLang());
        }
      }
      catch ( Exception ex )
      {
        DisplayManager.ShowWarning(DisplayManager.Title + " Check Update", ex.Message);
      }
      finally
      {
        LoadingForm.Instance.Hide();
        if ( Globals.MainForm != null ) Globals.MainForm.Enabled = formEnabled;
        Mutex = false;
      }
      return false;
    }

    /// <summary>
    /// Get the version available online with the file checksum.
    /// </summary>
    static private (Version version, string checksum) GetVersionAndChecksum(WebClient client)
    {
      List<string> lines = null;
      try
      {
        SystemManager.CheckServerCertificate(Globals.CheckUpdateURL);
        lines = client.DownloadString(Globals.CheckUpdateURL).SplitNoEmptyLines().Take(2).ToList();
        LoadingForm.Instance.DoProgress();
      }
      catch ( Exception ex )
      {
        throw new WebException(SysTranslations.CheckUpdateReadError.GetLang(ex.Message));
      }
      var list = new NullSafeOfStringDictionary<string>();
      foreach ( string line in lines )
      {
        var parts = line.Split(':');
        if ( parts.Length != 2 ) continue;
        list.Add(parts[0], parts[1]);
      }
      string fileVersion = list["Version"];
      string fileChecksum = list["Checksum"];
      if ( fileVersion.IsNullOrEmpty() || fileChecksum.IsNullOrEmpty() )
        throw new WebException(SysTranslations.CheckUpdateFileError.GetLang(lines.AsMultiLine()));
      string[] partsVersion = fileVersion.Split('.');
      Version version;
      try
      {
        switch ( partsVersion.Length )
        {
          case 2:
            version = new Version(Convert.ToInt32(partsVersion[0]),
                                  Convert.ToInt32(partsVersion[1]));
            break;
          case 3:
            version = new Version(Convert.ToInt32(partsVersion[0]),
                                  Convert.ToInt32(partsVersion[1]),
                                  Convert.ToInt32(partsVersion[2]));
            break;
          default:
            throw new ArgumentException(SysTranslations.CheckUpdateFileError.GetLang(lines.AsMultiLine()));
        }
      }
      catch ( Exception ex )
      {
        throw new WebException(SysTranslations.CheckUpdateFileError.GetLang(lines.AsMultiLine()) + Globals.NL2 +
                               ex.Message);
      }
      return (version, fileChecksum);
    }

    /// <summary>
    /// Ask to the user what to do.
    /// </summary>
    static private bool GetUserChoice(WebClient client, (Version version, string checksum) fileInfo)
    {
      string fileURL = string.Format(Globals.SetupFileURL, fileInfo.version.ToString());
      var result = WebUpdateForm.Run(fileInfo.version);
      switch ( result )
      {
        case WebUpdateSelection.None:
          break;
        case WebUpdateSelection.Download:
          SystemManager.CheckServerCertificate(fileURL);
          SystemManager.OpenWebLink(fileURL);
          break;
        case WebUpdateSelection.Install:
          return ProcessAutoInstall(client, fileInfo, fileURL);
        default:
          throw new NotImplementedExceptionEx(result.ToStringFull());
      }
      return false;
    }

    /// <summary>
    /// Process the automatic download and installation.
    /// </summary>
    static private bool ProcessAutoInstall(WebClient client,
                                           (Version version, string checksum) fileInfo,
                                           string fileURL)
    {
      LoadingForm.Instance.Initialize(SysTranslations.DownloadingNewVersion.GetLang(), 100, 0, false);
      SystemManager.CheckServerCertificate(fileURL);
      Exception ex = null;
      bool finished = false;
      string filePathTemp = Path.GetTempPath() + string.Format(Globals.SetupFileName, fileInfo.version.ToString());
      client.DownloadProgressChanged += downloadProgressChanged;
      client.DownloadFileCompleted += downloadFileCompleted;
      client.DownloadFileAsync(new Uri(fileURL), filePathTemp);
      while ( !finished )
      {
        Thread.Sleep(100);
        Application.DoEvents();
      }
      if ( ex != null ) throw ex;
      if ( !SystemManager.CheckIfFileIsExecutable(filePathTemp) )
        throw new IOException(SysTranslations.NotAnExecutableFile.GetLang(filePathTemp));
      if ( SystemManager.GetChecksum512(filePathTemp) != fileInfo.checksum )
        throw new IOException(SysTranslations.WrongFileChecksum.GetLang(filePathTemp));
      if ( SystemManager.RunShell(filePathTemp, "/SP- /SILENT") != null )
      {
        Globals.IsExiting = true;
        SystemManager.Exit();
        return true;
      }
      else
        return false;
      void downloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
      {
        LoadingForm.Instance.SetProgress(e.ProgressPercentage);
      }
      void downloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
      {
        finished = true;
        if ( e.Error == null ) return;
        HttpStatusCode code = 0;
        WebExceptionStatus status = 0;
        if ( e.Error is WebException we )
        {
          status = we.Status;
          if ( we.Response is HttpWebResponse response )
            code = response.StatusCode;
        }
        ex = new WebException(e.Error.Message + Globals.NL2 +
                              fileURL + Globals.NL2 +
                              status.ToStringFull() + Globals.NL +
                              code.ToStringFull());
      }
    }

  }

}
