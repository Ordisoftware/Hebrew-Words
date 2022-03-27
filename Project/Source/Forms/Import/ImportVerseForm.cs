/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2022 Olivier Rogier.
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
/// <edited> 2022-03 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class ImportVerseForm : Form
{

  static public void Run(ReferenceItem reference)
  {
    using var form = new ImportVerseForm(reference);
    if ( form.ShowDialog() != DialogResult.OK ) return;
    var pairs = from word in reference.Verse.Words
                from wordNew in form.WordMatches
                where word.Number == wordNew.Number
                select (word, wordNew);
    foreach ( var (word, wordNew) in pairs )
      word.Translation = wordNew.ImportedTranslation;
    MainForm.Instance.ActionSave.PerformClick();
  }

  private bool IsResultValid;

  private readonly ReferenceItem Reference;

  private ImportVerseForm()
  {
    InitializeComponent();
    Icon = MainForm.Instance.Icon;
    ActiveControl = EditSource;
  }

  private ImportVerseForm(ReferenceItem reference) : this()
  {
    Text += $" - {reference}";
    Reference = reference;
  }

  private void ImportVerseForm_Load(object sender, EventArgs e)
  {
    this.CenterToMainFormElseScreen();
  }

  private void ImportVerseForm_FormClosed(object sender, FormClosedEventArgs e)
  {
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
    for ( int index = 0; index < WordMatches.Count; index++ )
      if ( WordMatches[index].Hebrew == wordsReference[index].Hebrew )
        wordsReference[index].Translation = WordMatches[index].ImportedTranslation;
    Close();
  }

  private void ActionHelp_Click(object sender, EventArgs e)
  {
    DisplayManager.ShowInformation(AppTranslations.ImportNotice.GetLang());
  }

}
