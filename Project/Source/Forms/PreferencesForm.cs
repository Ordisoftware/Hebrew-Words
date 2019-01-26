/// <license>
/// This file is part of Ordisoftware Hebrew Calendar.
/// Copyright 2016-2019 Olivier Rogier.
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
/// <edited> 2019-01 </edited>
using System;
using System.Drawing;
using System.Drawing.Text;
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
    }

    /// <summary>
    /// Event handler. Called by PreferencesForm for shown events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void PreferencesForm_Shown(object sender, EventArgs e)
    {
      EditPath.Text = Program.Settings.HebrewLettersExe;
      EditSearch.Text = Program.Settings.SearchOnline;
    }

    /// <summary>
    /// Event handler. Called by PreferencesForm for closing events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void PreferencesForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Program.Settings.HebrewLettersExe = EditPath.Text;
      Program.Settings.SearchOnline = EditSearch.Text;
      Program.Settings.Save();
    }

    private void ActionSelect_Click(object sender, EventArgs e)
    {
      OpenFileDialog.FileName = EditPath.Text;
      if ( OpenFileDialog.ShowDialog() == DialogResult.OK )
        EditPath.Text = OpenFileDialog.FileName;
    }
  }

}
