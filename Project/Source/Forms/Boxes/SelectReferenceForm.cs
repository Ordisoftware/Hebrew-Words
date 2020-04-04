/// <license>
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
/// <created> 2019-09 </created>
/// <edited> 2019-09 </edited>
using System;
using System.Linq;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  public partial class SelectReferenceForm : Form
  {

    static public ReferenceItem Run()
    {
      var form = new SelectReferenceForm();
      if ( form.ShowDialog() != DialogResult.OK ) return null;
      return new ReferenceItem(( (BookItem)form.SelectBook.SelectedItem ).Book.Number,
                               ( (ChapterItem)form.SelectChapter.SelectedItem ).Chapter.Number, 
                               (int)form.SelectVerse.Value);
    }

    private SelectReferenceForm()
    {
      InitializeComponent();
      foreach ( Data.DataSet.BooksRow book in MainForm.Instance.DataSet.Books.Rows )
        SelectBook.Items.Add(new BookItem(book));
      SelectBook.SelectedIndex = 0;
    }

    private void SelectBook_SelectedIndexChanged(object sender, EventArgs e)
    {
      SelectChapter.Items.Clear();
      foreach ( Data.DataSet.ChaptersRow chapter in ( (BookItem)SelectBook.SelectedItem ).Book.GetChaptersRows() )
        SelectChapter.Items.Add(new ChapterItem(chapter));
      SelectChapter.SelectedIndex = 0;
    }

    private void SelectChapter_SelectedIndexChanged(object sender, EventArgs e)
    {
      SelectVerse.Value = 1;
      SelectVerse.Maximum = ( (ChapterItem)SelectChapter.SelectedItem ).Chapter.GetVersesRows().Count();
    }

    private void SelectVerse_ValueChanged(object sender, EventArgs e)
    {
      if ( SelectVerse.Value > SelectVerse.Maximum )
        SelectVerse.Value = SelectVerse.Maximum;
    }

    private void SelectValue_Enter(object sender, EventArgs e)
    {
      var control = (NumericUpDown)sender;
      control.Select(0, control.Value.ToString().Length);
    }

  }

}
