﻿/// <license>
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
/// <created> 2012-10 </created>
/// <edited> 2019-09 </edited>
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  public partial class WordControl : UserControl
  {

    public event MouseEventHandler HebrewMouseClick
    {
      add { LabelHebrew.MouseClick += value; }
      remove { LabelHebrew.MouseClick -= value; }
    }

    public ReferenceItem Reference
    {
      get;
      private set;
    }

    public WordControl()
    {
      InitializeComponent();
    }

    public WordControl(ReferenceItem reference) : this()
    {
      Reference = reference;
      LabelHebrew.Text = reference.Word.Hebrew;
      EditTranslation.Text = reference.Word.Translation;
      LabelHebrew.Tag = reference.Word.Original;
    }

    public new bool Focus()
    {
      if ( MainForm.Instance.RenderInProcess ) return false;
      EditTranslation.Focus();
      return true;
    }

    private void WordControl_Click(object sender, EventArgs e)
    {
      Focus();
    }

    private void LabelHebrew_MouseDown(object sender, MouseEventArgs e)
    {
      EditTranslation.Focus();
    }

    private void EditTranslation_Enter(object sender, EventArgs e)
    {
      if ( MainForm.Instance.RenderInProcess ) return;
      EditTranslation.BackColor = Color.AliceBlue;
      EditTranslation.SelectionStart = 0;
      if ( MainForm.Instance.ComboBoxMutex ) return;
      MainForm.Instance.CurrentReference = new ReferenceItem(Reference);
      MainForm.Instance.AddCurrentToHistory();
    }

    private void EditTranslation_Leave(object sender, EventArgs e)
    {
      EditTranslation.BackColor = SystemColors.Window;
    }

    private void EditTranslation_KeyDown(object sender, KeyEventArgs e)
    {
      Focus();
    }

    private void EditTranslation_TextChanged(object sender, EventArgs e)
    {
      if ( MainForm.Instance.IsLoadingData ) return;
      if ( MainForm.Instance.RenderInProcess ) return;
      if ( Reference.Word != null ) Reference.Word.Translation = EditTranslation.Text;
      Focus();
      MainForm.Instance.ActionSave.Enabled = true;
    }

    private void LabelHebrew_MouseEnter(object sender, EventArgs e)
    {
      LabelHebrew.Cursor = Cursors.Hand;
      LabelHebrew.ForeColor = Color.DarkRed;
    }

    private void LabelHebrew_MouseLeave(object sender, EventArgs e)
    {
      LabelHebrew.Cursor = Cursors.Default;
      LabelHebrew.ForeColor = SystemColors.ControlText;
    }

    private void LabelHebrew_Click(object sender, EventArgs e)
    {
      EditTranslation.Focus();
      switch ( Program.Settings.HebrewWordClickOpen )
      {
        case HebrewWordClickOpen.HebrewLetters:
          Program.OpenHebrewLetters(LabelHebrew.Text);
          break;
        case HebrewWordClickOpen.OnlineSearch:
          Program.OpenOnlineConcordance((string)LabelHebrew.Tag);
          break;
        case HebrewWordClickOpen.SearchTranslated:
          ActionSearchTranslated.PerformClick();
          break;
      }
    }

    private void ActionOpenHebrewLetters_Click(object sender, EventArgs e)
    {
      Program.OpenHebrewLetters(LabelHebrew.Text);
    }

    private void ActionOnlineSearch_Click(object sender, EventArgs e)
    {
      Program.OpenOnlineConcordance((string)LabelHebrew.Tag);
    }

    private void ActionCopy_Click(object sender, EventArgs e)
    {
      Clipboard.SetText(Reference.Word.Original);
    }

    private void ActionSearch_Click(object sender, EventArgs e)
    {
      MainForm.Instance.SearchWord(LabelHebrew.Text);
    }

    private void ActionSearchTranslated_Click(object sender, EventArgs e)
    {
      SearchTranslatedForm.Run(this);
    }

  }

}
