﻿/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2020 Olivier Rogier.
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
/// <edited> 2019-09 </edited>
using System;
using System.Diagnostics;
using System.Windows.Forms;
using Ordisoftware.HebrewCommon;

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// Provide the about box.
  /// </summary>
  /// <seealso cref="T:System.Windows.Forms.Form"/>
  public partial class AboutBox : Form
  {

    /// <summary>
    /// Indicate the singleton instance.
    /// </summary>
    static internal AboutBox Instance { get; private set; }

    /// <summary>
    /// Static constructor.
    /// </summary>
    static AboutBox()
    {
      Instance = new AboutBox();
    }

    /// <summary>
    /// Default constructor.
    /// </summary>
    private AboutBox()
    {
      InitializeComponent();
      Icon = MainForm.Instance.Icon;
      ActiveControl = ActionClose;
    }

    /// <summary>
    /// Event handler. Called by AboutBox for load events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void AboutBox_Load(object sender, EventArgs e)
    {
      this.CenterToMainFormElseScreen();
      editLicense.Rtf = Properties.Resources.MPL_2_0;
    }

    internal void AboutBox_Shown(object sender, EventArgs e)
    {
      Text = Localizer.AboutBoxTitle.GetLang(Globals.AssemblyTitle);
      labelTitle.Text = Globals.AssemblyTitle;
      labelDescription.Text = Translations.ApplicationDescription.GetLang();
      labelVersion.Text = Localizer.AboutBoxVersion.GetLang(Globals.AssemblyVersion);
      labelCopyright.Text = Globals.AssemblyCopyright;
      labelTrademark.Text = Globals.AssemblyTrademark;
      TopMost = MainForm.Instance.TopMost;
      BringToFront();
    }

    /// <summary>
    /// Event handler. Called by labelIconsProvider for link clicked events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Link label link clicked event information.</param>
    private void labelIconsProvider_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      SystemManager.OpenWebLink(((LinkLabel)sender).Text);
    }

    /// <summary>
    /// Event handler. Called by labelTrademarkName for link clicked events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Link label link clicked event information.</param>
    private void labelTrademarkName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      SystemManager.OpenAuthorHome();
    }

    /// <summary>
    /// Event handler. Called by editLicense for link clicked events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Link clicked event information.</param>
    private void editLicense_LinkClicked(object sender, LinkClickedEventArgs e)
    {
      Process.Start(e.LinkText);
    }

  }

}
