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
    SystemManager.TryCatch(() => EditOnlineSearch.Text = Settings.SearchOnlineURL);
    SystemManager.TryCatch(() => EditOnlineVerseURL.Text = Settings.OpenVerseOnlineURL);
    SystemManager.TryCatch(() => EditAutoBackupCount.Value = Settings.BackupCount);
    SystemManager.TryCatch(() => EditAutoSaveDelay.Value = Settings.AutoSaveDelay);
    SystemManager.TryCatch(() => EditCommentaryLinesCount.Value = Settings.VerseCommentaryLinesCount);
    SystemManager.TryCatch(() => EditWordTranslateLinesCount.Value = Settings.VerseWordTranslationLinesCount);
    SystemManager.TryCatch(() => EditWordControlWidth.Value = Settings.WordControlWidth);
    SystemManager.TryCatch(() => EditBookmarksCount.Value = Settings.BookmarksCount);
    SystemManager.TryCatch(() => EditHistoryCount.Value = Settings.HistoryCount);
    SystemManager.TryCatch(() => EditSearchDisplayMaxRef.Value = Settings.FoundReferencesViewable);
    SystemManager.TryCatch(() => EditSearchMinRefForDialog.Value = Settings.FoundReferencesToOpenDialog);
    SystemManager.TryCatch(() => EditFontSizeHebrew.Value = Settings.FontSizeHebrew);
    SystemManager.TryCatch(() => EditFontSizeTranslation.Value = Settings.FontSizeTranslation);
    SystemManager.TryCatch(() => EditFontSizeCommentary.Value = Settings.FontSizeCommentary);
    SystemManager.TryCatch(() => EditBookNameHebrewWithCommonName.Checked = Settings.BookNameHebrewWithCommonName);
    SystemManager.TryCatch(() => EditCommentLineAddPrefix.Checked = Settings.CommentLineAddPrefix);
    SystemManager.TryCatch(() => EditCommentLinePrefix.Text = Settings.CommentLinePrefix);
    SystemManager.TryCatch(() => EditCommentLineRemovePrefix.Checked = Settings.CommentLineRemovePrefix);
    // Word click action 1
    GroupBoxHebrewWordClick0.Checked = Settings.HebrewWordClickAction == HebrewWordClickAction.ContextMenu;
    GroupBoxHebrewWordClick1.Checked = Settings.HebrewWordClickAction == HebrewWordClickAction.OnlineSearch;
    GroupBoxHebrewWordClick2.Checked = Settings.HebrewWordClickAction == HebrewWordClickAction.SearchTranslated;
    GroupBoxHebrewWordClick3.Checked = Settings.HebrewWordClickAction == HebrewWordClickAction.SearchInDatabase;
    GroupBoxHebrewWordClick4.Checked = Settings.HebrewWordClickAction == HebrewWordClickAction.HebrewLetters;
    GroupBoxHebrewWordClick5.Checked = Settings.HebrewWordClickAction == HebrewWordClickAction.Nothing;
    // Word click action 2
    GroupBoxHebrewWordClickShift0.Checked = Settings.HebrewWordShiftClickAction == HebrewWordClickAction.ContextMenu;
    GroupBoxHebrewWordClickShift1.Checked = Settings.HebrewWordShiftClickAction == HebrewWordClickAction.OnlineSearch;
    GroupBoxHebrewWordClickShift2.Checked = Settings.HebrewWordShiftClickAction == HebrewWordClickAction.SearchTranslated;
    GroupBoxHebrewWordClickShift3.Checked = Settings.HebrewWordShiftClickAction == HebrewWordClickAction.SearchInDatabase;
    GroupBoxHebrewWordClickShift4.Checked = Settings.HebrewWordShiftClickAction == HebrewWordClickAction.HebrewLetters;
    GroupBoxHebrewWordClickShift5.Checked = Settings.HebrewWordShiftClickAction == HebrewWordClickAction.Nothing;
    // Word click action 3
    GroupBoxHebrewWordClickCtrl0.Checked = Settings.HebrewWordCtrlClickAction == HebrewWordClickAction.ContextMenu;
    GroupBoxHebrewWordClickCtrl1.Checked = Settings.HebrewWordCtrlClickAction == HebrewWordClickAction.OnlineSearch;
    GroupBoxHebrewWordClickCtrl2.Checked = Settings.HebrewWordCtrlClickAction == HebrewWordClickAction.SearchTranslated;
    GroupBoxHebrewWordClickCtrl3.Checked = Settings.HebrewWordCtrlClickAction == HebrewWordClickAction.SearchInDatabase;
    GroupBoxHebrewWordClickCtrl4.Checked = Settings.HebrewWordCtrlClickAction == HebrewWordClickAction.HebrewLetters;
    GroupBoxHebrewWordClickCtrl5.Checked = Settings.HebrewWordCtrlClickAction == HebrewWordClickAction.Nothing;
    // Word click action 4
    GroupBoxHebrewWordClickShiftCtrl0.Checked = Settings.HebrewWordShiftCtrlClickAction == HebrewWordClickAction.ContextMenu;
    GroupBoxHebrewWordClickShiftCtrl1.Checked = Settings.HebrewWordShiftCtrlClickAction == HebrewWordClickAction.OnlineSearch;
    GroupBoxHebrewWordClickShiftCtrl2.Checked = Settings.HebrewWordShiftCtrlClickAction == HebrewWordClickAction.SearchTranslated;
    GroupBoxHebrewWordClickShiftCtrl3.Checked = Settings.HebrewWordShiftCtrlClickAction == HebrewWordClickAction.SearchInDatabase;
    GroupBoxHebrewWordClickShiftCtrl4.Checked = Settings.HebrewWordShiftCtrlClickAction == HebrewWordClickAction.HebrewLetters;
    GroupBoxHebrewWordClickShiftCtrl5.Checked = Settings.HebrewWordShiftCtrlClickAction == HebrewWordClickAction.Nothing;
    // Translated double clock
    GroupBoxTranslatedItemDoubleClick1.Checked = Settings.TranslatedItemDoubleClickAction == TranslatedItemDoubleClickAction.UseTranslation;
    GroupBoxTranslatedItemDoubleClick1.Checked = Settings.TranslatedItemDoubleClickAction == TranslatedItemDoubleClickAction.UseTranslation;
    GroupBoxTranslatedItemDoubleClick2.Checked = Settings.TranslatedItemDoubleClickAction == TranslatedItemDoubleClickAction.AddTranslation;
    GroupBoxTranslatedItemDoubleClick3.Checked = Settings.TranslatedItemDoubleClickAction == TranslatedItemDoubleClickAction.ReachReference;
    GroupBoxTranslatedItemDoubleClick4.Checked = Settings.TranslatedItemDoubleClickAction == TranslatedItemDoubleClickAction.Nothing;
    // Verse label click action
    GroupBoxVerseLabelClick1.Checked = Settings.VerseLabelClickAction == VerseLabelClickAction.OnlineRead;
    GroupBoxVerseLabelClick2.Checked = Settings.VerseLabelClickAction == VerseLabelClickAction.ContextMenu;
    GroupBoxVerseLabelClick3.Checked = Settings.VerseLabelClickAction == VerseLabelClickAction.Select;
    GroupBoxVerseLabelClick4.Checked = Settings.VerseLabelClickAction == VerseLabelClickAction.Nothing;
    //
    if ( First )
    {
      TranslateLinesCountPrevious = (int)EditWordTranslateLinesCount.Value;
      CommentaryLinesCountPrevious = (int)EditCommentaryLinesCount.Value;
      WordControlWidthPrevious = (int)EditWordControlWidth.Value;
      MaxrefCountPrevious = (int)EditSearchDisplayMaxRef.Value;
      First = false;
    }
    // Special
    SystemManager.TryCatch(() => LabelLastStartupCheckDate.Text = Settings.CheckUpdateLastDone.ToShortDateString() + " " + Settings.CheckUpdateLastDone.ToShortTimeString());
    SystemManager.TryCatch(() => LabelLastDBOptimizeDate.Text = Settings.VacuumLastDone.ToShortDateString() + " " + Settings.VacuumLastDone.ToShortTimeString());
    // System
    EditLogEnabled.Enabled = DebugManager.Enabled;
  }

}
