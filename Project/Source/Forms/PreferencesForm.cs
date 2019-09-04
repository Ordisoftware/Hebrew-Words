/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2019 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at 
/// https://mozilla.org/MPL/2.0/.
/// If it is not possible or desirable to put the notice in a particular file, 
/// then You may include the notice in a location(such as a LICENSE file in a 
/// relevant directory) where a recipient would be likely to look for such a notice.
/// You may add additional accurate notices of copyright ownership.
/// </license>
/// <created> 2019-01 </created>
/// <edited> 2019-09 </edited>
using System;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// Form for viewing the preferences.
  /// </summary>
  /// <seealso cref="T:System.Windows.Forms.Form"/>
  public partial class PreferencesForm : Form
  {

    /// <summary>
    /// Default constructor.
    /// </summary>
    public PreferencesForm()
    {
      InitializeComponent();
      Icon = MainForm.Instance.Icon;
    }

    /// <summary>
    /// Event handler. Called by PreferencesForm for shown events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void PreferencesForm_Shown(object sender, EventArgs e)
    {
      EditHebrewLettersPath.Text = Program.Settings.HebrewLettersExe;
      EditOnlineSearch.Text = Program.Settings.SearchOnline;
      EditBackupPath.Text = Program.Settings.BackupPath;
      EditBackupCount.Value = Program.Settings.BackupCount;
      EditAutoSaveDelay.Value = Program.Settings.AutoSaveDelay;
      SelectOpenHebrewLetters.Checked = Program.Settings.HebrewWordClickOpen == HebrewWordClickOpen.HebrewLetters;
      SelectOpenOnlineSearch.Checked = Program.Settings.HebrewWordClickOpen == HebrewWordClickOpen.OnlineSearch;
    }

    /// <summary>
    /// Event handler. Called by PreferencesForm for closing events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void PreferencesForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Program.Settings.HebrewLettersExe = EditHebrewLettersPath.Text;
      Program.Settings.SearchOnline = EditOnlineSearch.Text;
      Program.Settings.BackupPath = EditBackupPath.Text;
      Program.Settings.BackupCount = (int)EditBackupCount.Value;
      Program.Settings.AutoSaveDelay = (int)EditAutoSaveDelay.Value;
      if ( SelectOpenHebrewLetters.Checked )
        Program.Settings.HebrewWordClickOpen = HebrewWordClickOpen.HebrewLetters;
      if ( SelectOpenOnlineSearch.Checked )
        Program.Settings.HebrewWordClickOpen = HebrewWordClickOpen.OnlineSearch;
      MainForm.Instance.TimerAutoSave.Enabled = Program.Settings.AutoSaveDelay != 0;
      if ( MainForm.Instance.TimerAutoSave.Enabled )
        MainForm.Instance.TimerAutoSave.Interval = Program.Settings.AutoSaveDelay * 60 * 1000;
      Program.Settings.Store();
    }

    /// <summary>
    /// Event handler. Called by ActionSelect for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionSelect_Click(object sender, EventArgs e)
    {
      OpenFileDialog.FileName = EditHebrewLettersPath.Text;
      if ( OpenFileDialog.ShowDialog() == DialogResult.OK )
        EditHebrewLettersPath.Text = OpenFileDialog.FileName;
    }
  }

}
