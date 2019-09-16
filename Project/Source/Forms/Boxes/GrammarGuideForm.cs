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
/// <created> 2019-09 </created>
/// <edited> 2019-09 </edited>
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  public partial class GrammarGuideForm : Form
  {

    static internal GrammarGuideForm Instance;

    static GrammarGuideForm()
    {
      Instance = new GrammarGuideForm();
    }

    private GrammarGuideForm()
    {
      InitializeComponent();
      Icon = MainForm.Instance.Icon;
    }

    private void GrammarGuideForm_Load(object sender, EventArgs e)
    {
      if ( Location.X == -1 && Location.Y == -1 )
        Location = new Point(MainForm.Instance.Left + MainForm.Instance.Width / 2 - Width / 2,
                             MainForm.Instance.Top + MainForm.Instance.Height / 2 - Height / 2);
      WebBrowser.Navigate(Program.GrammarGuideFilename.Replace("%lang%", Localizer.GetSupported()));
    }

    private void GrammarGuideForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = true;
      Hide();
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
      switch ( keyData )
      {
        case Keys.Escape:
          Close();
          break;
      }
      return base.ProcessCmdKey(ref msg, keyData);
    }

  }

}
