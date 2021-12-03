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

  #region Export and import

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

  private void EditVolume_ValueChanged(object sender, EventArgs e)
  {
    MediaMixer.SetApplicationVolume(Globals.ProcessId, EditVolume.Value);
    LabelVolumeValue.Text = EditVolume.Value + "%";
    if ( !IsReady ) return;
    Settings.ApplicationVolume = EditVolume.Value;
    SystemManager.TryCatch(Settings.Store);
    DisplayManager.DoSound(Globals.ClipboardSoundFilePath);
  }

  #endregion

  #region Startup

  private void EditCheckUpdateAtStartup_CheckedChanged(object sender, EventArgs e)
  {
    EditCheckUpdateEveryWeek.Enabled = EditCheckUpdateAtStartup.Checked;
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
    Settings.ExportDataPreferredTarget = ( (KVPDataExportTarget)EditDataExportFileFormat.SelectedItem ).Key;
  }

  private void EditImageExportFileFormat_Format(object sender, ListControlConvertEventArgs e)
  {
    e.Value = ( (KVPImageExportTarget)e.ListItem ).Key.ToString();
  }

  private void EditImageExportFileFormat_SelectedIndexChanged(object sender, EventArgs e)
  {
    if ( !IsReady ) return;
    Settings.ExportImagePreferredTarget = ( (KVPImageExportTarget)EditImageExportFileFormat.SelectedItem ).Key;
  }

  #endregion

  #region Paths

  private void ActionSelectExportFolder_Click(object sender, EventArgs e)
  {
    SystemManager.TryCatch(() => FolderBrowserDialog.SelectedPath = Settings.GetExportDirectory());
    if ( FolderBrowserDialog.ShowDialog() == DialogResult.OK )
      EditExportFolder.Text = FolderBrowserDialog.SelectedPath;
  }

  private void DoActionSelectPath(FileDialog dialog, TextBox edit)
  {
    SystemManager.TryCatch(() => dialog.InitialDirectory = Path.GetDirectoryName(edit.Text));
    SystemManager.TryCatch(() => dialog.FileName = Path.GetFileName(edit.Text));
    if ( OpenExeFileDialog.ShowDialog() == DialogResult.OK )
      edit.Text = dialog.FileName;
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

}
