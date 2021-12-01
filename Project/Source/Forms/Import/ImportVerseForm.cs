/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2021 Olivier Rogier.
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
/// <edited> 2020-03 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class ImportVerseForm : Form
{

  static public void Run(ReferenceItem reference)
  {
    var form = new ImportVerseForm(reference);
    var result = form.ShowDialog();
    if ( result == DialogResult.Cancel )
      ; //TODO cancel changes form.DataSet.RejectChanges();
    else
    {
      // TODO apply
      //if ( form.DataSet.HasChanges() )
      //{
      //  MainForm.Instance.TableAdapterManager.UpdateAll(form.DataSet);
      //  foreach ( WordControl control in MainForm.Instance.PanelViewVerses.Controls.OfType<WordControl>() )
      //    control.EditTranslation.Text = control.Reference.Word.Translation;
      //}
      MainForm.Instance.ActionSave.PerformClick();
    }
  }

  private bool IsResultValid;

  private readonly ReferenceItem Reference;

  private ImportVerseForm()
  {
    InitializeComponent();
    Icon = MainForm.Instance.Icon;
    ActiveControl = EditSource;
    this.CenterToMainFormElseScreen();
  }

  private ImportVerseForm(ReferenceItem reference)
  {
    Text += " - " + reference.ToString();
    Reference = reference;
    CreateGhost();
  }

  private void ImportVerseForm_FormClosed(object sender, FormClosedEventArgs e)
  {
    DeleteGhost();
    SystemManager.TryCatch(Program.Settings.Save);
  }

  private void ImportVerseForm_Shown(object sender, EventArgs e)
  {
    PanelMain.SplitterDistance = Program.Settings.ImportVerseFormSplitterDistance;
    DataGridView.Columns[0].Width = Program.Settings.ImportVerseFormGridColumnWidthHebrew;
    DataGridView.Columns[1].Width = Program.Settings.ImportVerseFormGridColumnWidthTranslationCurrent;
  }

  private void PanelMain_SplitterMoving(object sender, SplitterCancelEventArgs e)
  {
    Program.Settings.ImportVerseFormSplitterDistance = PanelMain.SplitterDistance;
  }

  private void DataGridView_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
  {
    if ( !Created ) return;
    Program.Settings.ImportVerseFormGridColumnWidthHebrew = DataGridView.Columns[0].Width;
    Program.Settings.ImportVerseFormGridColumnWidthTranslationCurrent = DataGridView.Columns[1].Width;
  }

  private void EditSource_TextChanged(object sender, EventArgs e)
  {
    var lines = EditSource.Lines.Where(line => line.Length > 0).ToList();
    ActionAnalyse.Enabled = EditSource.Text.Length > 0 && lines.Count % 2 == 0;
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
    var wordsReference = Reference.Verse.Words;
    for ( int index = 0; index < ImportResults.Count; index++ )
      if ( ImportResults[index].Hebrew == wordsReference[index].Hebrew )
        wordsReference[index].Translation = ImportResults[index].ImportedTranslation;
    Close();
  }

  private void ActionHelp_Click(object sender, EventArgs e)
  {
    DisplayManager.ShowInformation(AppTranslations.ImportHelp.GetLang());
  }

}
