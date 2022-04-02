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
/// <created> 2019-01 </created>
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class SelectVerseForm : Form
{

  static public ReferenceItem Run()
  {
    using var form = new SelectVerseForm();
    form.EditVerseNumber.Maximum = MainForm.Instance.CurrentReference.Chapter.Verses.Count;
    if ( form.ShowDialog() != DialogResult.OK ) return null;
    return new ReferenceItem(MainForm.Instance.CurrentReference.Book.Number,
                             MainForm.Instance.CurrentReference.Chapter.Number,
                             (int)form.EditVerseNumber.Value);
  }

  private SelectVerseForm()
  {
    InitializeComponent();
    EditVerseNumber.Select(0, 1);
  }

  private void ActionHelp_Click(object sender, EventArgs e)
  {
    DisplayManager.ShowInformation(AppTranslations.SearchReferenceNotice.GetLang());
  }

  private void SelectVerseFromFirstToLast_Click(object sender, EventArgs e)
  {
    if ( sender is RadioButton control )
      control.Checked = true;
  }

  private void EditVerseNumber_ValueChanged(object sender, EventArgs e)
  {
    PanelOptions.Enabled = EditVerseNumber.Value == 0;
  }

  private void EditVerseNumber_KeyPress(object sender, KeyPressEventArgs e)
  {
    EditVerseNumber_ValueChanged(sender, e);
  }

  private void EditVerseNumber_KeyUp(object sender, KeyEventArgs e)
  {
    EditVerseNumber_ValueChanged(sender, e);
  }

}
