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

  private void SaveSettings()
  {
    Settings.DebuggerEnabled = EditDebuggerEnabled.Checked;
    Settings.VacuumAtStartup = EditVacuumAtStartup.Checked;
    Settings.VacuumAtStartupDaysInterval = (int)EditVacuumAtStartupInterval.Value;
    Settings.HebrewLettersExe = EditHebrewLettersPath.Text;
    Settings.CalculatorExe = EditCalculatorPath.Text;
    Settings.AutoOpenExportFolder = EditAutoOpenExportFolder.Checked;
    Settings.AutoOpenExportedFile = EditAutoOpenExportedFile.Checked;
    Settings.CheckUpdateAtStartup = EditCheckUpdateAtStartup.Checked;
    Settings.CheckUpdateAtStartupDaysInterval = (int)EditCheckUpdateAtStartupInterval.Value;
    Settings.TraceEnabled = EditLogEnabled.Checked;
    Settings.ExportFolder = EditExportFolder.Text;
    Settings.BackupFolder = EditBackupFolder.Text;
    Settings.ApplicationVolume = EditVolume.Value;
    Settings.UsageStatisticsEnabled = EditUsageStatisticsEnabled.Checked;
    Settings.WindowsDoubleBufferingEnabled = EditWindowsDoubleBufferingEnabled.Checked;
    Settings.ShowLastNewInVersionAfterUpdate = EditShowLastNewInVersionAfterUpdate.Checked;
    Settings.WebLinksMenuEnabled = EditWebLinksMenuEnabled.Checked;
    Program.Settings.SearchOnlineURL = EditOnlineSearch.Text;
    Program.Settings.OpenVerseOnlineURL = EditOnlineVerseURL.Text;
    Program.Settings.BackupCount = (int)EditAutoBackupCount.Value;
    Program.Settings.AutoSaveDelay = (int)EditAutoSaveDelay.Value;
    Program.Settings.VerseCommentaryLinesCount = (int)EditCommentLinesCount.Value;
    Program.Settings.WordControlWidth = (int)EditWordControlWidth.Value;
    Program.Settings.BookmarksCount = (int)EditBookmarksCount.Value;
    Program.Settings.HistoryCount = (int)EditHistoryCount.Value;
    Program.Settings.FoundReferencesViewable = (int)EditSearchDisplayMaxRef.Value;
    Program.Settings.FoundReferencesToOpenDialog = (int)EditSearchMinRefForDialog.Value;
    // Word click action 1
    if ( GroupBoxHebrewWordClick0.Checked ) Program.Settings.HebrewWordClickAction = HebrewWordClickAction.ContextMenu;
    if ( GroupBoxHebrewWordClick1.Checked ) Program.Settings.HebrewWordClickAction = HebrewWordClickAction.OnlineSearch;
    if ( GroupBoxHebrewWordClick2.Checked ) Program.Settings.HebrewWordClickAction = HebrewWordClickAction.SearchTranslated;
    if ( GroupBoxHebrewWordClick3.Checked ) Program.Settings.HebrewWordClickAction = HebrewWordClickAction.HebrewLetters;
    if ( GroupBoxHebrewWordClick4.Checked ) Program.Settings.HebrewWordClickAction = HebrewWordClickAction.Nothing;
    // Word click action 2
    if ( GroupBoxHebrewWordClickShift0.Checked ) Program.Settings.HebrewWordShiftClickAction = HebrewWordClickAction.ContextMenu;
    if ( GroupBoxHebrewWordClickShift1.Checked ) Program.Settings.HebrewWordShiftClickAction = HebrewWordClickAction.OnlineSearch;
    if ( GroupBoxHebrewWordClickShift2.Checked ) Program.Settings.HebrewWordShiftClickAction = HebrewWordClickAction.SearchTranslated;
    if ( GroupBoxHebrewWordClickShift3.Checked ) Program.Settings.HebrewWordShiftClickAction = HebrewWordClickAction.HebrewLetters;
    if ( GroupBoxHebrewWordClickShift4.Checked ) Program.Settings.HebrewWordShiftClickAction = HebrewWordClickAction.Nothing;
    // Word click action 3
    if ( GroupBoxHebrewWordClickCtrl0.Checked ) Program.Settings.HebrewWordCtrlClickAction = HebrewWordClickAction.ContextMenu;
    if ( GroupBoxHebrewWordClickCtrl1.Checked ) Program.Settings.HebrewWordCtrlClickAction = HebrewWordClickAction.OnlineSearch;
    if ( GroupBoxHebrewWordClickCtrl2.Checked ) Program.Settings.HebrewWordCtrlClickAction = HebrewWordClickAction.SearchTranslated;
    if ( GroupBoxHebrewWordClickCtrl3.Checked ) Program.Settings.HebrewWordCtrlClickAction = HebrewWordClickAction.HebrewLetters;
    if ( GroupBoxHebrewWordClickCtrl4.Checked ) Program.Settings.HebrewWordCtrlClickAction = HebrewWordClickAction.Nothing;
    // Word click action 4
    if ( GroupBoxHebrewWordClickShiftCtrl0.Checked ) Program.Settings.HebrewWordShiftCtrlClickAction = HebrewWordClickAction.ContextMenu;
    if ( GroupBoxHebrewWordClickShiftCtrl1.Checked ) Program.Settings.HebrewWordShiftCtrlClickAction = HebrewWordClickAction.OnlineSearch;
    if ( GroupBoxHebrewWordClickShiftCtrl2.Checked ) Program.Settings.HebrewWordShiftCtrlClickAction = HebrewWordClickAction.SearchTranslated;
    if ( GroupBoxHebrewWordClickShiftCtrl3.Checked ) Program.Settings.HebrewWordShiftCtrlClickAction = HebrewWordClickAction.HebrewLetters;
    if ( GroupBoxHebrewWordClickShiftCtrl4.Checked ) Program.Settings.HebrewWordShiftCtrlClickAction = HebrewWordClickAction.Nothing;
    // Translated double clock
    if ( GroupBoxTranslatedItemDoubleClick1.Checked ) Program.Settings.TranslatedItemDoubleClickAction = TranslatedItemDoubleClickAction.UseTranslation;
    if ( GroupBoxTranslatedItemDoubleClick2.Checked ) Program.Settings.TranslatedItemDoubleClickAction = TranslatedItemDoubleClickAction.AddTranslation;
    if ( GroupBoxTranslatedItemDoubleClick3.Checked ) Program.Settings.TranslatedItemDoubleClickAction = TranslatedItemDoubleClickAction.ReachReference;
    if ( GroupBoxTranslatedItemDoubleClick4.Checked ) Program.Settings.TranslatedItemDoubleClickAction = TranslatedItemDoubleClickAction.Nothing;
    // Verse label click action
    if ( GroupBoxVerseLabelClick1.Checked ) Program.Settings.VerseLabelClickAction = VerseLabelClickAction.OnlineRead;
    if ( GroupBoxVerseLabelClick2.Checked ) Program.Settings.VerseLabelClickAction = VerseLabelClickAction.ContextMenu;
    if ( GroupBoxVerseLabelClick3.Checked ) Program.Settings.VerseLabelClickAction = VerseLabelClickAction.Select;
    if ( GroupBoxVerseLabelClick4.Checked ) Program.Settings.VerseLabelClickAction = VerseLabelClickAction.Nothing;
    // Timer auto-save
    MainForm.Instance.TimerAutoSave.Enabled = Program.Settings.AutoSaveDelay != 0;
    if ( MainForm.Instance.TimerAutoSave.Enabled )
      MainForm.Instance.TimerAutoSave.Interval = Program.Settings.AutoSaveDelay * 60 * 1000;
    // End
    Program.Settings.Store();
    UpdateViewRequired = CommentaryLinesCountPrevious != (int)EditCommentLinesCount.Value
                      || WordControlWidthPrevious != (int)EditWordControlWidth.Value
                      || MaxrefCountPrevious != (int)EditSearchDisplayMaxRef.Value;
  }

}
