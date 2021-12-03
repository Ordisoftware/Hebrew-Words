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

  /// <summary>
  /// Does form load.
  /// </summary>
  private void DoFormLoad()
  {
    SaveSettingsDialog.InitialDirectory = Program.Settings.GetExportDirectory();
    OpenSettingsDialog.InitialDirectory = SaveSettingsDialog.InitialDirectory;
    SaveSettingsDialog.Filter = ExportTarget.CreateFilters();
    OpenSettingsDialog.Filter = SaveSettingsDialog.Filter;
    LoadEditIntervals();
    LoadExportFileFormats();
  }

  /// <summary>
  /// Does form show.
  /// </summary>
  private void DoFormShow()
  {
    SystemManager.TryCatchManage(() => Globals.BringToFrontApplicationHotKey.Active = false);
    TopMost = MainForm.Instance.TopMost;
    BringToFront();
    UpdateLanguagesButtons();
    LoadSettings();
    CheckFirstLaunchNoticesAndChoices();
    EditVacuumAtStartup_CheckedChanged(null, null);
    EditCheckUpdateAtStartup_CheckedChanged(null, null);
    EditLogEnabled_CheckedChanged(null, null);
    ActiveControl = ActionClose;
    ActionResetSettings.TabStop = false;
    IsReady = true;
  }

  /// <summary>
  /// Checks the first launch to show notices and ask user preferences for generation.
  /// </summary>
  private void CheckFirstLaunchNoticesAndChoices()
  {
    bool changed = false;
    if ( Settings.FirstLaunch )
    {
      changed = true;
    }
    if ( changed )
    {
      changed = true;
    }
    if ( changed )
    {
      Settings.SetFirstAndUpgradeFlagsOff();
      SystemManager.TryCatch(Settings.Store);
    }
  }

  /// <summary>
  /// Does form closing.
  /// </summary>
  private void DoFormClosing(object sender, FormClosingEventArgs e)
  {
    if ( DoReset ) return;
    SaveSettings();
    SystemManager.TryCatch(Settings.Store);
  }

  /// <summary>
  /// Loads edit intervals.
  /// </summary>
  private void LoadEditIntervals()
  {
    setInterval(EditCheckUpdateAtStartupInterval, LabelCheckUpdateAtStartupInfo, CheckUpdateInterval);
    setInterval(EditVacuumAtStartupInterval, LabelOptimizeDatabaseIntervalInfo, CheckUpdateInterval);
    setInterval(EditPrintingMargin, LabelPrintingMarginIntervalInfo, PrintingMarginInterval);
    setInterval(EditPrintPageCountWarning, LabelPrintPageCountWarningIntervalInfo, PrintPageCountWarningInterval);
    setInterval(EditSaveImageCountWarning, LabelSaveImageCountWarningIntervalInfo, SaveImageCountWarningInterval);
    //
    static void setInterval(NumericUpDown control, Label label, (int, int, int, int) interval)
    {
      control.Minimum = interval.Item1;
      control.Maximum = interval.Item2;
      control.Value = interval.Item3;
      control.Increment = interval.Item4;
      if ( label != null ) label.Text = interval.Item1 + " - " + interval.Item2 + " (" + interval.Item3 + ")";
    }
  }

  /// <summary>
  /// Loads export file formats.
  /// </summary>
  private void LoadExportFileFormats()
  {
    EditDataExportFileFormat.Fill(Program.BoardExportTargets, Settings.ExportDataPreferredTarget);
    EditImageExportFileFormat.Fill(Program.ImageExportTargets, Settings.ExportImagePreferredTarget);
  }

}
