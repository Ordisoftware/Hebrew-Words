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
using System.Linq;
using System.Windows.Forms;
using Ordisoftware.Core;

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
        if ( form.DataSet.HasChanges() )
        {
          MainForm.Instance.TableAdapterManager.UpdateAll(form.DataSet);
          foreach ( WordControl control in MainForm.Instance.PanelViewVerses.Controls.OfType<WordControl>() )
            control.EditTranslation.Text = control.Reference.Word.Translation;
        }
        MainForm.Instance.ActionSave.PerformClick();
      }
    }

    private bool IsResultValid;

    private Data.DataSet DataSet;

    private ReferenceItem Reference;

    private ImportVerseForm()
    {
      InitializeComponent();
      this.CenterToMainForm();
      Icon = MainForm.Instance.Icon;
      ActiveControl = EditSource;
    }

    private ImportVerseForm(ReferenceItem reference)
      : this()
    {
      Text += " - " + reference.ToString();
      DataSet = MainForm.Instance.DataSet;
      Reference = reference;
      CreateGhost();
    }

    private void ImportVerseForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      DeleteGhost();
    }

    private void EditSource_TextChanged(object sender, EventArgs e)
    {
      var lines = EditSource.Lines.Where(line => line != "").ToList();
      ActionAnalyse.Enabled = EditSource.Text != "" && lines.Count % 2 == 0;
      IsResultValid = false;
      ActionOK.Enabled = false;
    }

    private void ActionAnalyse_Click(object sender, EventArgs e)
    {
      DoAnalyse();
      if ( IsResultValid )
        DataGridView.Focus();
      else
        EditSource.Focus();
      ActionOK.Enabled = IsResultValid;
    }

    private void ActionOK_Click(object sender, EventArgs e)
    {
      var wordsReference = Reference.Verse.GetWordsRows();
      for ( int index = 0; index < ImportResults.Count; index++ )
        if ( ImportResults[index].Hebrew == wordsReference[index].Hebrew )
          wordsReference[index].Translation = ImportResults[index].ImportedTranslation;
      Close();
    }

    private void ActionHelp_Click(object sender, EventArgs e)
    {
      DisplayManager.Show(Translations.ImportHelpText.GetLang());
    }
  }

}
