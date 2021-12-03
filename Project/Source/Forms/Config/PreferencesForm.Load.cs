/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2016-2021 Olivier Rogier.
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
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

/// <summary>
/// Provides form to edit the preferences.
/// </summary>
/// <seealso cref="T:System.Windows.Forms.Form"/>
partial class PreferencesForm
{

  private void LoadSettings()
  {
    SystemManager.TryCatch(() => EditDebuggerEnabled.Checked = Settings.DebuggerEnabled);
    SystemManager.TryCatch(() => EditVacuumAtStartup.Checked = Settings.VacuumAtStartup);
    SystemManager.TryCatch(() => EditVacuumAtStartupInterval.Value = Settings.VacuumAtStartupDaysInterval);
    SystemManager.TryCatch(() => EditHebrewLettersPath.Text = Settings.HebrewLettersExe);
    SystemManager.TryCatch(() => EditCalculatorPath.Text = Settings.CalculatorExe);
    SystemManager.TryCatch(() => EditAutoOpenExportFolder.Checked = Settings.AutoOpenExportFolder);
    SystemManager.TryCatch(() => EditAutoOpenExportedFile.Checked = Settings.AutoOpenExportedFile);
    SystemManager.TryCatch(() => EditCheckUpdateAtStartup.Checked = Settings.CheckUpdateAtStartup);
    SystemManager.TryCatch(() => EditCheckUpdateAtStartupInterval.Value = Settings.CheckUpdateAtStartupDaysInterval);
    SystemManager.TryCatch(() => EditLogEnabled.Checked = Settings.TraceEnabled);
    SystemManager.TryCatch(() => EditExportFolder.Text = Settings.ExportFolder);
    SystemManager.TryCatch(() => EditBackupFolder.Text = Settings.BackupFolder);
    SystemManager.TryCatch(() => EditVolume.Value = Settings.ApplicationVolume);
    SystemManager.TryCatch(() => EditUsageStatisticsEnabled.Checked = Settings.UsageStatisticsEnabled);
    SystemManager.TryCatch(() => EditWindowsDoubleBufferingEnabled.Checked = Settings.WindowsDoubleBufferingEnabled);
    SystemManager.TryCatch(() => EditShowLastNewInVersionAfterUpdate.Checked = Settings.ShowLastNewInVersionAfterUpdate);
    SystemManager.TryCatch(() => EditWebLinksMenuEnabled.Checked = Settings.WebLinksMenuEnabled);
    SystemManager.TryCatch(() => EditOnlineSearch.Text = Program.Settings.SearchOnlineURL);
    SystemManager.TryCatch(() => EditOnlineVerseURL.Text = Program.Settings.OpenVerseOnlineURL);
    SystemManager.TryCatch(() => EditBackupCount.Value = Program.Settings.BackupCount);
    SystemManager.TryCatch(() => EditAutoSaveDelay.Value = Program.Settings.AutoSaveDelay);
    SystemManager.TryCatch(() => EditCommentaryLinesCount.Value = Program.Settings.VerseCommentaryLinesCount);
    SystemManager.TryCatch(() => EditWordControlWidth.Value = Program.Settings.WordControlWidth);
    SystemManager.TryCatch(() => EditBookmarksCount.Value = Program.Settings.BookmarksCount);
    SystemManager.TryCatch(() => EditHistoryCount.Value = Program.Settings.HistoryCount);
    SystemManager.TryCatch(() => EditMaxRefCount.Value = Program.Settings.FoundReferencesViewable);
    SystemManager.TryCatch(() => EditMinRefCount.Value = Program.Settings.FoundReferencesToOpenDialog);
    // Word click action
    SelectOpenHebrewLetters.Checked = Program.Settings.HebrewWordClickOpen == HebrewWordClickOpen.HebrewLetters;
    SelectOpenOnlineSearch.Checked = Program.Settings.HebrewWordClickOpen == HebrewWordClickOpen.OnlineSearch;
    SelectOpenTranslated.Checked = Program.Settings.HebrewWordClickOpen == HebrewWordClickOpen.SearchTranslated;
    SelectOpenNothing.Checked = Program.Settings.HebrewWordClickOpen == HebrewWordClickOpen.Nothing;
    //
    if ( First )
    {
      CommentaryLinesCountPrevious = (int)EditCommentaryLinesCount.Value;
      WordControlWidthPrevious = (int)EditWordControlWidth.Value;
      MaxrefCountPrevious = (int)EditMaxRefCount.Value;
      First = false;
    }
    // Special
    SystemManager.TryCatch(() => LabelLastStartupCheckDate.Text = Settings.CheckUpdateLastDone.ToShortDateString() + " " + Settings.CheckUpdateLastDone.ToShortTimeString());
    SystemManager.TryCatch(() => LabelLastDBOptimizeDate.Text = Settings.VacuumLastDone.ToShortDateString() + " " + Settings.VacuumLastDone.ToShortTimeString());
    // System
    EditLogEnabled.Enabled = DebugManager.Enabled;
  }

}
