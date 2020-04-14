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
/// <created> 2019-08 </created>
/// <edited> 2019-08 </edited>
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Ordisoftware.HebrewCommon;

namespace Ordisoftware.HebrewWords
{

  public partial class MainForm
  {

    private List<FileInfo> GetFiles(string pathname, string pattern)
    {
      string[] list = Directory.Exists(pathname)
                    ? Directory.GetFiles(pathname, pattern, SearchOption.TopDirectoryOnly)
                    : new string[0];
      return ( from file in list select new FileInfo(file) ).OrderBy(file => file.CreationTime).ToList();
    }

    private void DoBackupDB()
    {
      if ( Program.Settings.BackupCount == 0 ) return;
      string partFilename = Globals.AssemblyTitle.Replace(" ", "-");
      string partBackup = "AutoBackup ";
      var list = GetFiles(Program.Settings.BackupPath, partBackup + partFilename + "*" + Globals.DBFileExtension);
      while ( list.Count >= Program.Settings.BackupCount )
      {
        File.Delete(list[0].FullName);
        list.RemoveAt(0);
      }
      string partPath = Program.Settings.BackupPath + partBackup;
      var date = DateTime.Now;
      string strDate = String.Format("{0:00}-{1:00}-{2:00}@{3:00}h{4:00}m{5:00}s",
                                     date.Year, date.Month, date.Day,
                                     date.Hour, date.Minute, date.Second);
      string fileSource = Globals.UserDataFolderPath + partFilename + Globals.DBFileExtension;
      string fileDest = partPath + partFilename + " " + strDate + Globals.DBFileExtension;
      if ( File.Exists(fileSource) ) File.Copy(fileSource, fileDest);
    }

  }

}
