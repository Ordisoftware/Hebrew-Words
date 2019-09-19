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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  public partial class ImportVerseForm : Form
  {

    static public void Run(ReferenceItem reference)
    {
      var form = new ImportVerseForm(reference);
      var result = form.ShowDialog();
      if ( result == DialogResult.Cancel )
        form.DataSet.RejectChanges();
      else
      {
        form.DataSet.AcceptChanges();
        MainForm.Instance.ActionSave.PerformClick();
      }
    }

    private bool IsResultValid;

    private Data.DataSet DataSet;

    private ReferenceItem Reference;

    private ImportVerseForm()
    {
      InitializeComponent();
      Icon = MainForm.Instance.Icon;
    }

    private ImportVerseForm(ReferenceItem reference)
      : this()
    {
      DataSet = MainForm.Instance.DataSet;
      Reference = reference;
      CreateGhost();
      GhostBook = DataSet.Books[0];
      GhostChapter = GhostBook.GetChaptersRows()[0];
      GhostVerse = GhostChapter.GetVersesRows()[0];
      GhostWords = GhostVerse.GetWordsRows();
    }

    private void ImportVerseForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      DeleteGhost();
    }

    private void EditSource_TextChanged(object sender, EventArgs e)
    {
      ActionAnalyse.Enabled = EditSource.Text != "";
    }

    private void ActionAnalyse_Click(object sender, EventArgs e)
    {
      DoAnalyse();
      ActionOK.Enabled = IsResultValid;
    }

    private void ActionOK_Click(object sender, EventArgs e)
    {
      DoImport();
      Close();
    }

  }

}
