/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2023 Olivier Rogier.
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
/// <edited> 2022-03 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class MainForm
{

  private List<FileInfo> GetFiles(string pathname, string pattern)
  {
    var list = Directory.Exists(pathname)
      ? Directory.GetFiles(pathname, pattern, SearchOption.TopDirectoryOnly)
      : Array.Empty<string>();
    return ( from file in list select new FileInfo(file) ).OrderBy(file => file.CreationTime).ToList();
  }

  private void DoBackupDB()
  {
    SystemManager.TryCatchManage(() =>
    {
      if ( Settings.BackupCount == 0 ) return;
      const string partBackup = "AutoBackup ";
      string partFilename = Globals.AssemblyTitle.Replace(' ', '-');
      string filter = partBackup + partFilename + "*" + Globals.DatabaseFileExtension;
      var list = GetFiles(Settings.GetBackupDirectory(), filter).OrderBy(f => f.Name).ToList();
      while ( list.Count >= Settings.BackupCount )
      {
        File.Delete(list[0].FullName);
        list.RemoveAt(0);
      }
      string fileSource = Path.Combine(Globals.UserDataFolderPath, partFilename + Globals.DatabaseFileExtension);
      if ( File.Exists(fileSource) )
      {
        var date = DateTime.Now;
        string strDate = string.Format("{0:00}-{1:00}-{2:00}@{3:00}h{4:00}m{5:00}s",
                                       date.Year, date.Month, date.Day,
                                       date.Hour, date.Minute, date.Second);
        string partPath = Path.Combine(Settings.GetBackupDirectory(), partBackup);
        string fileDest = partPath + partFilename + " " + strDate + Globals.DatabaseFileExtension;
        File.Copy(fileSource, fileDest);
      }
    });
  }

}
