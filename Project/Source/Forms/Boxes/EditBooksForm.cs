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

partial class EditBooksForm : Form
{

  private BookRow SelectedBook
    => EditBooks.SelectedRows.Count == 1 ? (BookRow)EditBooks.SelectedRows[0].DataBoundItem : null;

  public EditBooksForm()
  {
    InitializeComponent();
    Icon = MainForm.Instance.Icon;
    int index = 0;
    foreach ( var item in HebrewGlobals.WebProvidersWord.Items )
      if ( item.Name == "-" )
        ActionSearchOnline.DropDownItems.Insert(index++, new ToolStripSeparator());
      else
        ActionSearchOnline.DropDownItems.Insert(index++, item.CreateMenuItem((sender, e) =>
        {
          var menuitem = (ToolStripMenuItem)sender;
          HebrewTools.OpenHebrewLetters(SelectedBook?.Original, Program.Settings.HebrewLettersExe);
        }));
  }

  private void EditBooksForm_Load(object sender, EventArgs e)
  {
    EditBooks.DataSource = new BindingList<BookRow>(ApplicationDatabase.Instance.Books);
    ActiveControl = EditBooks;
  }

  private void ActionClose_Click(object sender, EventArgs e)
  {
    Close();
  }

  private void BooksDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
  {
    if ( e.ColumnIndex == 3 ) e.Value = ( (string)e.Value ).Trim();
  }

  private void EditBooks_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
  {
    if ( e.Button == MouseButtons.Right && e.RowIndex != -1 )
      EditBooks.Rows[e.RowIndex].Selected = true;
  }

  private void ActionSearchOnline_Click(object sender, EventArgs e)
  {
    HebrewTools.OpenWordProvider(Program.Settings.SearchOnlineURL, SelectedBook?.Hebrew);
  }

  private void ActionOpenHebrewLetters_Click(object sender, EventArgs e)
  {
    HebrewTools.OpenHebrewLetters((string)EditBooks.SelectedRows[0].Cells[ColumnHebrew.Index].Value, Program.Settings.HebrewLettersExe);
  }

  private void ActionSearchWord_Click(object sender, EventArgs e)
  {
    MainForm.Instance.SearchHebrewWord(SelectedBook?.Hebrew);
    Close();
  }

  private void ActionOpen_Click(object sender, EventArgs e)
  {
    MainForm.Instance.SetView(ViewMode.ChapterVerses);
    MainForm.Instance.GoTo(SelectedBook?.Number ?? 1, 1, 1);
    Close();
  }

  private void ActionCopyName_Click(object sender, EventArgs e)
  {
    string name = (string)EditBooks.SelectedRows[0].Cells[ColumnName.Index].Value;
    string tranlation = (string)EditBooks.SelectedRows[0].Cells[ColumnTranslation.Index].Value;
    if ( tranlation.Length > 0 )
      name += $" ({tranlation})";
    Clipboard.SetText(name);
  }

  private void ActionCopyFontChars_Click(object sender, EventArgs e)
  {
    Clipboard.SetText(SelectedBook?.Hebrew);
  }

  private void ActionCopyUnicodeChars_Click(object sender, EventArgs e)
  {
    Clipboard.SetText(SelectedBook?.Original);
  }

  private void ActionEditMemo_Click(object sender, EventArgs e)
  {
    var form = new EditMemoForm();
    var book = SelectedBook;
    if ( SelectedBook == null ) return;
    form.Text += book.Name;
    form.TextBox.Text = book.Memo;
    form.TextBox.SelectionStart = 0;
    if ( form.ShowDialog() == DialogResult.OK )
      book.Memo = form.TextBox.Text;
  }

  private void ActionRestoreCommonNames_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if ( DisplayManager.QueryYesNo(AppTranslations.AskToRestoreBooksCommonNames.GetLang()) )
      foreach ( var book in ApplicationDatabase.Instance.Books.OrderBy(b => b.Number) )
        book.CommonName = BooksNames.Common.GetLang((TanakBook)( book.Number ));
  }

}
