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

using KVPDataExportTarget = KeyValuePair<DataExportTarget, string>;
using KVPImageExportTarget = KeyValuePair<ImageExportTarget, string>;

/// <summary>
/// Provides form to edit the preferences.
/// </summary>
/// <seealso cref="T:System.Windows.Forms.Form"/>
partial class PreferencesForm : Form
{

  private bool IsReady;

  #region Form Management

  /// <summary>
  /// Default constructor.
  /// </summary>
  private PreferencesForm()
  {
    InitializeComponent();
    Icon = MainForm.Instance.Icon;
    this.InitDropDowns();
    void action1(object sender, EventArgs e)
    {
      EditOnlineVerseURL.Text = (string)( (ToolStripMenuItem)sender ).Tag;
    }
    void action2(object sender, EventArgs e)
    {
      EditOnlineSearch.Text = (string)( (ToolStripMenuItem)sender ).Tag;
    }
    foreach ( var item in HebrewGlobals.WebProvidersBible.Items )
      if ( item.Name == "-" )
        MenuSelectOnlineVerseURL.Items.Add(new ToolStripSeparator());
      else
        MenuSelectOnlineVerseURL.Items.Add(item.CreateMenuItem(action1));
    foreach ( var item in HebrewGlobals.WebProvidersWord.Items )
      if ( item.Name == "-" )
        MenuSelectSearchRequest.Items.Add(new ToolStripSeparator());
      else
        MenuSelectSearchRequest.Items.Add(item.CreateMenuItem(action2));
  }

  /// <summary>
  /// Event handler. Called by PreferencesForm for load events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void PreferencesForm_Load(object sender, EventArgs e)
  {
    this.CenterToMainFormElseScreen();
    DoFormLoad();
  }

  /// <summary>
  /// Event handler. Called by PreferencesForm for shown events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void PreferencesForm_Shown(object sender, EventArgs e)
  {
    DoFormShow();
  }

  /// <summary>
  /// Event handler. Called by PreferencesForm for closing events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void PreferencesForm_FormClosing(object sender, FormClosingEventArgs e)
  {
    if ( e.CloseReason != CloseReason.None && e.CloseReason != CloseReason.UserClosing ) return;
    DoFormClosing(sender, e);
  }

  /// <summary>
  /// Event handler. Called by PreferencesForm for closed events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void PreferencesForm_FormClosed(object sender, FormClosedEventArgs e)
  {
    IsReady = false;
  }

  #endregion

  #region Export and Import Settings

  private void ActionExportSettings_Click(object sender, EventArgs e)
  {
    DoExportSettings();
  }

  private void ActionImportSettings_Click(object sender, EventArgs e)
  {
    DoImportSettings();
  }

  private void ActionResetSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    DoResetSettings();
  }

  #endregion

  #region Language

  private void ActionSelectLangEN_Click(object sender, EventArgs e)
  {
    if ( Settings.LanguageSelected == Language.EN ) return;
    Settings.LanguageSelected = Language.EN;
    Program.UpdateLocalization();
    UpdateLanguagesButtons();
    LanguageChanged = true;
    Close();
  }

  private void ActionSelectLangFR_Click(object sender, EventArgs e)
  {
    if ( Settings.LanguageSelected == Language.FR ) return;
    Settings.LanguageSelected = Language.FR;
    Program.UpdateLocalization();
    UpdateLanguagesButtons();
    LanguageChanged = true;
    Close();
  }

  private void UpdateLanguagesButtons()
  {
    if ( Settings.LanguageSelected == Language.EN )
    {
      ActionSelectLangEN.BackColor = SystemColors.ControlLightLight;
      ActionSelectLangFR.BackColor = SystemColors.Control;
    }
    if ( Settings.LanguageSelected == Language.FR )
    {
      ActionSelectLangFR.BackColor = SystemColors.ControlLightLight;
      ActionSelectLangEN.BackColor = SystemColors.Control;
    }
  }

  #endregion

  #region Application

  private void EditDebuggerEnabled_CheckedChanged(object sender, EventArgs e)
  {
    if ( !EditDebuggerEnabled.Checked )
      EditLogEnabled.Checked = false;
    DebugManager.Enabled = EditDebuggerEnabled.Checked;
    EditLogEnabled.Enabled = DebugManager.Enabled;
  }

  private void EditLogEnabled_CheckedChanged(object sender, EventArgs e)
  {
    DebugManager.TraceEnabled = EditLogEnabled.Checked;
    CommonMenusControl.Instance.ActionViewLog.Enabled = DebugManager.TraceEnabled;
    StatisticsForm.Instance.ActionViewLog.Enabled = DebugManager.TraceEnabled;
  }

  private void EditUsageStatisticsEnabled_CheckedChanged(object sender, EventArgs e)
  {
    CommonMenusControl.Instance.ActionViewStats.Enabled = EditUsageStatisticsEnabled.Checked;
    AboutBox.Instance.ActionViewStats.Enabled = EditUsageStatisticsEnabled.Checked;
    StatisticsForm.Instance.Timer.Enabled = EditUsageStatisticsEnabled.Checked;
    if ( !EditUsageStatisticsEnabled.Checked )
      StatisticsForm.Instance.Close();
  }

  private void EditBookNameHebrewWithCommonName_CheckedChanged(object sender, EventArgs e)
  {
    UpdateViewRequired = true;
  }

  private void EditVolume_ValueChanged(object sender, EventArgs e)
  {
    MediaMixer.SetApplicationVolume(Globals.ProcessId, EditVolume.Value);
    LabelVolumeValue.Text = "${EditVolume.Value}%";
    if ( !IsReady ) return;
    Settings.ApplicationVolume = EditVolume.Value;
    SystemManager.TryCatch(Settings.Store);
    DisplayManager.DoSound(Globals.ClipboardSoundFilePath);
  }

  private void EditSearchHebrewCharsInBold_CheckedChanged(object sender, EventArgs e)
  {
    MainForm.Instance.EditSearchWord.HebrewCharsInBold = EditSearchHebrewCharsInBold.Checked;
  }

  #endregion

  #region Startup

  private void EditGoToMasterBookmarkAtStartup_CheckedChanged(object sender, EventArgs e)
  {
    if ( EditGoToMasterBookmarkAtStartup.Checked && EditGoToLastVerseAtStartup.Checked )
      EditGoToLastVerseAtStartup.Checked = false;
  }

  private void EditGoToLastVerseAtStartup_CheckedChanged(object sender, EventArgs e)
  {
    if ( EditGoToMasterBookmarkAtStartup.Checked && EditGoToLastVerseAtStartup.Checked )
      EditGoToMasterBookmarkAtStartup.Checked = false;
  }

  private void EditCheckUpdateAtStartup_CheckedChanged(object sender, EventArgs e)
  {
    EditCheckUpdateAtStartupInterval.Enabled = EditCheckUpdateAtStartup.Checked;
  }

  private void EditVacuumAtStartup_CheckedChanged(object sender, EventArgs e)
  {
    EditVacuumAtStartupInterval.Enabled = EditVacuumAtStartup.Checked;
  }

  #endregion

  #region Export Save, Copy and Print

  private void EditAutoOpenExportFolder_CheckedChanged(object sender, EventArgs e)
  {
    if ( EditAutoOpenExportedFile.Checked && EditAutoOpenExportFolder.Checked )
      EditAutoOpenExportedFile.Checked = false;
  }

  private void EditAutoOpenExportedFile_CheckedChanged(object sender, EventArgs e)
  {
    if ( EditAutoOpenExportedFile.Checked && EditAutoOpenExportFolder.Checked )
      EditAutoOpenExportFolder.Checked = false;
  }

  private void EditDataExportFileFormat_Format(object sender, ListControlConvertEventArgs e)
  {
    e.Value = ( (KVPDataExportTarget)e.ListItem ).Key.ToString();
  }

  private void EditDataExportFileFormat_SelectedIndexChanged(object sender, EventArgs e)
  {
    if ( !IsReady ) return;
    Settings.ExportDataPreferredTarget = ( (KVPDataExportTarget)SelectDataExportFileFormat.SelectedItem ).Key;
  }

  private void EditImageExportFileFormat_Format(object sender, ListControlConvertEventArgs e)
  {
    e.Value = ( (KVPImageExportTarget)e.ListItem ).Key.ToString();
  }

  private void EditImageExportFileFormat_SelectedIndexChanged(object sender, EventArgs e)
  {
    if ( !IsReady ) return;
    Settings.ExportImagePreferredTarget = ( (KVPImageExportTarget)SelectImageExportFileFormat.SelectedItem ).Key;
  }

  #endregion

  #region Paths

  private void ActionSelectExportFolder_Click(object sender, EventArgs e)
  {
    SystemManager.TryCatch(() => FolderBrowserDialog.SelectedPath = Settings.GetExportDirectory());
    if ( FolderBrowserDialog.ShowDialog() == DialogResult.OK )
      EditExportFolder.Text = FolderBrowserDialog.SelectedPath;
  }

  private void DoActionSelectPath(OpenFileDialog dialog, TextBoxEx edit)
  {
    SystemManager.TryCatch(() => dialog.InitialDirectory = Path.GetDirectoryName(edit.Text));
    SystemManager.TryCatch(() => dialog.FileName = Path.GetFileName(edit.Text));
    if ( OpenExeFileDialog.ShowDialog() == DialogResult.OK )
      edit.Text = dialog.FileName;
  }

  private void ActionSelectBackupFolder_Click(object sender, EventArgs e)
  {
    SystemManager.TryCatch(() => FolderBrowserDialog.SelectedPath = Settings.GetBackupDirectory());
    if ( FolderBrowserDialog.ShowDialog() == DialogResult.OK )
      EditBackupFolder.Text = FolderBrowserDialog.SelectedPath;
  }

  private void ActionSelectCalculatorPath_Click(object sender, EventArgs e)
  {
    DoActionSelectPath(OpenExeFileDialog, EditCalculatorPath);
  }

  private void ActionSelectHebrewLettersPath_Click(object sender, EventArgs e)
  {
    DoActionSelectPath(OpenExeFileDialog, EditHebrewLettersPath);
  }

  private void ActionResetExportFolder_Click(object sender, EventArgs e)
  {
    if ( DisplayManager.QueryYesNo(SysTranslations.AskToResetParameter.GetLang()) )
      EditExportFolder.Text = (string)Settings.Properties[nameof(Settings.ExportFolder)].DefaultValue;
  }

  private void ActionResetBackupFolder_Click(object sender, EventArgs e)
  {
    if ( DisplayManager.QueryYesNo(SysTranslations.AskToResetParameter.GetLang()) )
      EditBackupFolder.Text = (string)Settings.Properties[nameof(Settings.BackupFolder)].DefaultValue;
  }
  private void ActionResetCalculatorPath_Click(object sender, EventArgs e)
  {
    if ( DisplayManager.QueryYesNo(SysTranslations.AskToResetParameter.GetLang()) )
      EditCalculatorPath.Text = (string)Settings.Properties[nameof(Settings.CalculatorExe)].DefaultValue;
  }

  private void ActionResetHebrewLettersPath_Click(object sender, EventArgs e)
  {
    if ( DisplayManager.QueryYesNo(SysTranslations.AskToResetParameter.GetLang()) )
      EditHebrewLettersPath.Text = (string)Settings.Properties[nameof(Settings.HebrewLettersExe)].DefaultValue;
  }

  #endregion

  #region Rendering

  private void EditMaxRefCount_ValueChanged(object sender, EventArgs e)
  {
    EditSearchMinRefForDialog.Maximum = EditSearchDisplayMaxRef.Value;
  }

  private void ActionSelectOnlineSearch_Click(object sender, EventArgs e)
  {
    MenuSelectSearchRequest.Show(ActionSelectOnlineSearch, new Point(0, ActionSelectOnlineSearch.Height));
  }

  private void ActionOnlineSearchHelp_Click(object sender, EventArgs e)
  {
    DisplayManager.ShowInformation(HebrewTranslations.NoticeOnlineWordProvider.GetLang());
  }

  private void ActionOnlineVerseHelp_Click(object sender, EventArgs e)
  {
    DisplayManager.ShowInformation(HebrewTranslations.NoticeOnlineBibleProvider.GetLang());
  }

  private void ActionSelectOnlineVerseURL_Click(object sender, EventArgs e)
  {
    MenuSelectOnlineVerseURL.Show(ActionSelectOnlineVerseURL, new Point(0, ActionSelectOnlineVerseURL.Height));
  }

  private void EditRenderWordControl_ValueChanged(object sender, EventArgs e)
  {
    WordControl.ResetMetricsRequired = true;
  }

  private void EditRenderVerseControl_ValueChanged(object sender, EventArgs e)
  {
    VerseControl.ResetMetricsRequired = true;
  }

  private void ActionResetRendering_Click(object sender, EventArgs e)
  {
    EditWordControlWidth.Value = WordControlWidthInterval.Item3;
    EditWordTranslateLinesCount.Value = WordTranslationLinesCountInterval.Item3;
    EditCommentaryLinesCount.Value = CommentLinesCountInterval.Item3;
    EditFontSizeHebrew.Value = FontSizeHebrewInterval.Item3;
    EditFontSizeTranslation.Value = FontSizeTranslationInterval.Item3;
    EditFontSizeCommentary.Value = FontSizeCommentaryInterval.Item3;
    EditSearchDisplayMaxRef.Value = SearchDisplayMaxRefInterval.Item3;
    EditSearchMinRefForDialog.Value = SearchMinRefForDialogInterval.Item3;
  }

  #endregion

  #region Comment Prefixes

  private void EditCommentLineAddPrefix_CheckedChanged(object sender, EventArgs e)
  {
    if ( IsReady )
      if ( EditCommentLineAddPrefix.Checked && EditCommentLineRemovePrefix.Checked )
        EditCommentLineRemovePrefix.Checked = false;
    EditCommentLinePrefix.Enabled = EditCommentLineAddPrefix.Checked || EditCommentLineRemovePrefix.Checked;
    ActionCheckAllComments.Enabled = EditCommentLinePrefix.Enabled;
  }

  private void EditCommentLineRemovePrefix_CheckedChanged(object sender, EventArgs e)
  {
    if ( IsReady )
      if ( EditCommentLineAddPrefix.Checked && EditCommentLineRemovePrefix.Checked )
        EditCommentLineAddPrefix.Checked = false;
    EditCommentLinePrefix.Enabled = EditCommentLineAddPrefix.Checked || EditCommentLineRemovePrefix.Checked;
    ActionCheckAllComments.Enabled = EditCommentLinePrefix.Enabled;
  }

  private void ActionCheckAllComments_Click(object sender, EventArgs e)
  {
    string msg = EditCommentLineAddPrefix.Checked
      ? AppTranslations.CommentPrefixAddAll.GetLang(EditCommentLinePrefix.Text)
      : AppTranslations.CommentPrefixRemoveAll.GetLang(EditCommentLinePrefix.Text);
    if ( !DisplayManager.QueryYesNo(msg) ) return;
    Settings.CommentLineAddPrefix = EditCommentLineAddPrefix.Checked;
    Settings.CommentLineRemovePrefix = EditCommentLineRemovePrefix.Checked;
    Settings.CommentLinePrefix = EditCommentLinePrefix.Text;
    var verses = ApplicationDatabase.Instance.Verses;
    for ( int index = 0; index < verses.Count; index++ )
      verses[index].Comment = VerseControl.CheckComment(verses[index].Comment);
    MainForm.Instance.ActionSave.PerformClick();
    // TODO improve to call ActionNormalizeTexts.PerformClick and move code
  }

  #endregion

  #region Theme

  private void EditColor_Click(object sender, EventArgs e)
  {
    var panel = (Panel)sender;
    DialogColor.Color = panel.BackColor;
    if ( DialogColor.ShowDialog() == DialogResult.Cancel ) return;
    panel.BackColor = DialogColor.Color;
    SaveColors();
    MainForm.Instance.InitializeTheme();
    UpdateViewRequired = true;
  }

  private void ActionOpenTheme_Click(object sender, EventArgs e)
  {
    DoOpenTheme();
  }

  private void ActionSaveTheme_Click(object sender, EventArgs e)
  {
    DoSaveTheme();
  }

  private void ActionUseColorsPastel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    SetThemePastel();
  }

  private void ActionUseColorsSystem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    SetThemeSystem();
  }

  #endregion

}
