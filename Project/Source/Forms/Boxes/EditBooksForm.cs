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

  static public bool Run()
  {
    var form = new EditBooksForm();
    form.ShowDialog();
    return form.UpdateViewRequired;
  }

  private bool UpdateViewRequired;

  private EditBooksForm()
  {
    InitializeComponent();
    Icon = MainForm.Instance.Icon;
    int index = 0;
    foreach ( var item in HebrewGlobals.WebProvidersWord.Items )
      if ( item.Name == "-" )
        ActionSearchOnline.DropDownItems.Insert(index++, new ToolStripSeparator());
      else
        ActionSearchOnline.DropDownItems.Insert(index++, item.CreateMenuItem(action));
    //
    void action(object sender, EventArgs e)
    {
      var menuitem = (ToolStripMenuItem)sender;
      var book = (BookRow)EditBooks.SelectedRows[0].DataBoundItem;
      HebrewTools.OpenHebrewLetters(book.Original, Program.Settings.HebrewLettersExe);
    }
  }

  private void EditBooksForm_Load(object sender, EventArgs e)
  {
    EditBooks.DataSource = new BindingList<BookRow>(ApplicationDatabase.Instance.Books);
    ActiveControl = EditBooks;
  }

  private void EditBooksForm_FormClosing(object sender, FormClosingEventArgs e)
  {
    MainForm.Instance.ActionSave.PerformClick();
  }

  private void BooksDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
  {
    if ( e.ColumnIndex == 3 ) e.Value = ( (string)e.Value ).Trim();
  }

  private void EditBooks_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
  {
    if ( e.Button == MouseButtons.Right )
    {
      int rowSelected = e.RowIndex;
      if ( e.RowIndex != -1 )
      {
        //TODO remove? EditBooks.ClearSelection();
        EditBooks.Rows[rowSelected].Selected = true;
        //TODO remove? BooksBindingSource.Position = e.RowIndex;
      }
    }
  }

  private void ActionSearchOnline_Click(object sender, EventArgs e)
  {
    var book = (BookRow)EditBooks.SelectedRows[0].DataBoundItem;
    HebrewTools.OpenWordProvider(Program.Settings.SearchOnlineURL, book.Hebrew);
  }

  private void ActionOpenHebrewLetters_Click(object sender, EventArgs e)
  {
    HebrewTools.OpenHebrewLetters((string)EditBooks.SelectedRows[0].Cells[ColumnHebrew.Index].Value, Program.Settings.HebrewLettersExe);
  }

  private void ActionSearchWord_Click(object sender, EventArgs e)
  {
    Close();
    var book = (BookRow)EditBooks.SelectedRows[0].DataBoundItem;
    MainForm.Instance.SearchHebrewWord(book.Hebrew);
  }

  private void ActionOpen_Click(object sender, EventArgs e)
  {
    Close();
    var book = (BookRow)EditBooks.SelectedRows[0].DataBoundItem;
    MainForm.Instance.GoTo(book.Number, 1, 1);
  }

  private void ActionCopyName_Click(object sender, EventArgs e)
  {
    string strCommonName = (string)EditBooks.SelectedRows[0].Cells[ColumnName.Index].Value;
    string strTranlation = (string)EditBooks.SelectedRows[0].Cells[ColumnTranslation.Index].Value;
    if ( strTranlation.Length > 0 )
      strCommonName += $" ({strTranlation})";
    Clipboard.SetText(strCommonName);
  }

  private void ActionCopyFontChars_Click(object sender, EventArgs e)
  {
    var book = (BookRow)EditBooks.SelectedRows[0].DataBoundItem;
    Clipboard.SetText(book.Hebrew);
  }

  private void ActionCopyUnicodeChars_Click(object sender, EventArgs e)
  {
    var book = (BookRow)EditBooks.SelectedRows[0].DataBoundItem;
    Clipboard.SetText(book.Original);
  }

  private void ActionEditMemo_Click(object sender, EventArgs e)
  {
    var form = new EditMemoForm();
    var book = (BookRow)EditBooks.SelectedRows[0].DataBoundItem;
    form.Text += book.Name;
    form.TextBox.Text = book.Memo;
    form.TextBox.SelectionStart = 0;
    if ( form.ShowDialog() == DialogResult.OK )
      book.Memo = form.TextBox.Text;
  }

  private void ActionRestoreCommonNames_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if ( DisplayManager.QueryYesNo(AppTranslations.AskToRestoreBooksCommonNames.GetLang()) )
      foreach ( var book in ApplicationDatabase.Instance.Books )
        book.CommonName = BooksNames.Common.GetLang((TanakBook)( book.Number - 1 ));
  }

}
