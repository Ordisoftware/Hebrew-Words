/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2016-2022 Olivier Rogier.
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
/// <edited> 2022-03 </edited>
namespace Ordisoftware.Hebrew.Words;

/// <summary>
/// Provides form to edit the preferences.
/// </summary>
/// <seealso cref="T:System.Windows.Forms.Form"/>
partial class PreferencesForm
{

  [SuppressMessage("Design", "MA0051:Method is too long", Justification = "N/A")]
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
    Settings.SearchOnlineURL = EditOnlineSearch.Text;
    Settings.OpenVerseOnlineURL = EditOnlineVerseURL.Text;
    Settings.BackupCount = (int)EditAutoBackupCount.Value;
    Settings.AutoSaveDelay = (int)EditAutoSaveDelay.Value;
    Settings.VerseCommentaryLinesCount = (int)EditCommentaryLinesCount.Value;
    Settings.VerseWordTranslationLinesCount = (int)EditWordTranslateLinesCount.Value;
    Settings.WordControlWidth = (int)EditWordControlWidth.Value;
    Settings.BookmarksCount = (int)EditBookmarksCount.Value;
    Settings.HistoryCount = (int)EditHistoryCount.Value;
    Settings.FoundReferencesViewable = (int)EditSearchDisplayMaxRef.Value;
    Settings.FoundReferencesToOpenDialog = (int)EditSearchMinRefForDialog.Value;
    Settings.FontSizeHebrew = (int)EditFontSizeHebrew.Value;
    Settings.FontSizeTranslation = (int)EditFontSizeTranslation.Value;
    Settings.FontSizeCommentary = (int)EditFontSizeCommentary.Value;
    Settings.BookNameHebrewWithCommonName = EditBookNameHebrewWithCommonName.Checked;
    Settings.CommentLineAddPrefix = EditCommentLineAddPrefix.Checked;
    Settings.CommentLineRemovePrefix = EditCommentLineRemovePrefix.Checked;
    Settings.CommentLinePrefix = EditCommentLinePrefix.Text;
    Settings.GoToMasterBookmarkAtStartup = EditGoToMasterBookmarkAtStartup.Checked;
    Settings.GoToMasterBookmarkAtStartup = EditGoToMasterBookmarkAtStartup.Checked;
    Settings.GoToLastVerseAtStartup = EditGoToLastVerseAtStartup.Checked;
    Settings.AutoSortBookmarks = EditAutoSortBookmarks.Checked;
    Settings.AutoSaveOnLeaveControl = EditAutoSaveOnLeaveControl.Checked;
    Settings.LettersControlHebrewCharsInBold = EditSearchHebrewCharsInBold.Checked;
    SaveColors();
    // Word click action 1
    if ( GroupBoxHebrewWordClick0.Checked ) Settings.HebrewWordClickAction = HebrewWordClickAction.ContextMenu;
    if ( GroupBoxHebrewWordClick1.Checked ) Settings.HebrewWordClickAction = HebrewWordClickAction.OnlineSearch;
    if ( GroupBoxHebrewWordClick2.Checked ) Settings.HebrewWordClickAction = HebrewWordClickAction.SearchTranslated;
    if ( GroupBoxHebrewWordClick3.Checked ) Settings.HebrewWordClickAction = HebrewWordClickAction.SearchInDatabase;
    if ( GroupBoxHebrewWordClick4.Checked ) Settings.HebrewWordClickAction = HebrewWordClickAction.HebrewLetters;
    if ( GroupBoxHebrewWordClick5.Checked ) Settings.HebrewWordClickAction = HebrewWordClickAction.Nothing;
    // Word click action 2
    if ( GroupBoxHebrewWordClickShift0.Checked ) Settings.HebrewWordShiftClickAction = HebrewWordClickAction.ContextMenu;
    if ( GroupBoxHebrewWordClickShift1.Checked ) Settings.HebrewWordShiftClickAction = HebrewWordClickAction.OnlineSearch;
    if ( GroupBoxHebrewWordClickShift2.Checked ) Settings.HebrewWordShiftClickAction = HebrewWordClickAction.SearchTranslated;
    if ( GroupBoxHebrewWordClickShift3.Checked ) Settings.HebrewWordShiftClickAction = HebrewWordClickAction.SearchInDatabase;
    if ( GroupBoxHebrewWordClickShift4.Checked ) Settings.HebrewWordShiftClickAction = HebrewWordClickAction.HebrewLetters;
    if ( GroupBoxHebrewWordClickShift5.Checked ) Settings.HebrewWordShiftClickAction = HebrewWordClickAction.Nothing;
    // Word click action 3
    if ( GroupBoxHebrewWordClickCtrl0.Checked ) Settings.HebrewWordCtrlClickAction = HebrewWordClickAction.ContextMenu;
    if ( GroupBoxHebrewWordClickCtrl1.Checked ) Settings.HebrewWordCtrlClickAction = HebrewWordClickAction.OnlineSearch;
    if ( GroupBoxHebrewWordClickCtrl2.Checked ) Settings.HebrewWordCtrlClickAction = HebrewWordClickAction.SearchTranslated;
    if ( GroupBoxHebrewWordClickCtrl3.Checked ) Settings.HebrewWordCtrlClickAction = HebrewWordClickAction.SearchInDatabase;
    if ( GroupBoxHebrewWordClickCtrl4.Checked ) Settings.HebrewWordCtrlClickAction = HebrewWordClickAction.HebrewLetters;
    if ( GroupBoxHebrewWordClickCtrl5.Checked ) Settings.HebrewWordCtrlClickAction = HebrewWordClickAction.Nothing;
    // Word click action 4
    if ( GroupBoxHebrewWordClickShiftCtrl0.Checked ) Settings.HebrewWordShiftCtrlClickAction = HebrewWordClickAction.ContextMenu;
    if ( GroupBoxHebrewWordClickShiftCtrl1.Checked ) Settings.HebrewWordShiftCtrlClickAction = HebrewWordClickAction.OnlineSearch;
    if ( GroupBoxHebrewWordClickShiftCtrl2.Checked ) Settings.HebrewWordShiftCtrlClickAction = HebrewWordClickAction.SearchTranslated;
    if ( GroupBoxHebrewWordClickShiftCtrl3.Checked ) Settings.HebrewWordShiftCtrlClickAction = HebrewWordClickAction.SearchInDatabase;
    if ( GroupBoxHebrewWordClickShiftCtrl4.Checked ) Settings.HebrewWordShiftCtrlClickAction = HebrewWordClickAction.HebrewLetters;
    if ( GroupBoxHebrewWordClickShiftCtrl5.Checked ) Settings.HebrewWordShiftCtrlClickAction = HebrewWordClickAction.Nothing;
    // Translated double clock
    if ( GroupBoxTranslatedItemDoubleClick1.Checked ) Settings.TranslatedItemDoubleClickAction = TranslatedItemDoubleClickAction.UseTranslation;
    if ( GroupBoxTranslatedItemDoubleClick2.Checked ) Settings.TranslatedItemDoubleClickAction = TranslatedItemDoubleClickAction.AddTranslation;
    if ( GroupBoxTranslatedItemDoubleClick3.Checked ) Settings.TranslatedItemDoubleClickAction = TranslatedItemDoubleClickAction.ReachReference;
    if ( GroupBoxTranslatedItemDoubleClick4.Checked ) Settings.TranslatedItemDoubleClickAction = TranslatedItemDoubleClickAction.Nothing;
    // Verse label click action
    if ( GroupBoxVerseLabelClick1.Checked ) Settings.VerseLabelClickAction = VerseLabelClickAction.OnlineRead;
    if ( GroupBoxVerseLabelClick2.Checked ) Settings.VerseLabelClickAction = VerseLabelClickAction.ContextMenu;
    if ( GroupBoxVerseLabelClick3.Checked ) Settings.VerseLabelClickAction = VerseLabelClickAction.Select;
    if ( GroupBoxVerseLabelClick4.Checked ) Settings.VerseLabelClickAction = VerseLabelClickAction.Nothing;
    // Timer auto-save
    MainForm.Instance.TimerAutoSave.Enabled = Settings.AutoSaveDelay != 0;
    if ( MainForm.Instance.TimerAutoSave.Enabled )
      MainForm.Instance.TimerAutoSave.Interval = Settings.AutoSaveDelay * Globals.MilliSecondsInOneMinute;
    // End
    Settings.PreferencesFormSelectedTabIndex = TabControl.SelectedIndex;
    Settings.Store();
  }

  private void SaveColors()
  {
    Settings.ThemeNavigatorItems = EditThemeNavigatorItems.BackColor;
    Settings.ThemeCurrentControl = EditThemeCurrentControl.BackColor;
    Settings.ThemeTranslationBack = EditThemeTranslationBack.BackColor;
    Settings.ThemeCommentaryBack = EditThemeCommentaryBack.BackColor;
    Settings.ThemeSearchLettersBack = EditThemeSearchLettersBack.BackColor;
    Settings.ThemeSearchWordBack = EditThemeSearchWordBack.BackColor;
  }

}
