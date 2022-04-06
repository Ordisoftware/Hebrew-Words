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
/// <created> 2019-01 </created>
/// <edited> 2022-03 </edited>
namespace Ordisoftware.Hebrew.Words;

using Equin.ApplicationFramework;

partial class EditBooksForm : Form
{

  private BookRow SelectedBook
    => DataGridView.SelectedRows.Count == 1
       ? ( (ObjectView<BookRow>)DataGridView.SelectedRows[0].DataBoundItem ).Object
       : null;

  public EditBooksForm()
  {
    InitializeComponent();
    Icon = MainForm.Instance.Icon;
    ActionSearchOnline.InitializeFromProviders(HebrewGlobals.WebProvidersWord, (sender, e) =>
    {
      var menuitem = (ToolStripMenuItem)sender;
      HebrewTools.OpenWordProvider((string)menuitem.Tag, SelectedBook?.Hebrew);
    });
  }

  private void EditBooksForm_Load(object sender, EventArgs e)
  {
    DataGridView.DataSource = ApplicationDatabase.Instance.BooksAsBindingList;
    ActiveControl = DataGridView;
  }

  private void ActionClose_Click(object sender, EventArgs e)
  {
    Close();
  }

  private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
  {
    if ( e.ColumnIndex == ColumnTranslation.Index || e.ColumnIndex == ColumnLettriq.Index )
      if ( e.Value is null || e.Value == DBNull.Value )
        e.Value = string.Empty;
      else
        e.Value = ( (string)e.Value ).Trim();
  }

  private void DataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
  {
    if ( e.Button == MouseButtons.Right && e.RowIndex != -1 )
      DataGridView.Rows[e.RowIndex].Selected = true;
  }

  private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
  {
    if ( e.RowIndex < 0 || e.ColumnIndex < 0 )
      DataGridView.ClearSelection();
    else
    if ( DataGridView[e.ColumnIndex, e.RowIndex].Value == DBNull.Value )
      DataGridView.ClearSelection();
  }

  private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
  {
    if ( DataGridView.ReadOnly ) return;
    if ( e.RowIndex < 0 || e.ColumnIndex != ColumnMemo.Index ) return;
    using var form = new EditMemoForm();
    form.Text += (string)DataGridView.CurrentRow.Cells[ColumnMemo.Index].Value;
    form.TextBox.Text = SelectedBook.Memo;
    form.TextBox.SelectionStart = 0;
    if ( form.ShowDialog() == DialogResult.OK )
    {
      SelectedBook.Memo = form.TextBox.Text;
      DataGridView.RefreshEdit();
    }
  }

  private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    DataGridView.BeginEdit(false);
  }

  private void DataGridView_KeyDown(object sender, KeyEventArgs e)
  {
    if ( e.KeyCode == Keys.F2 || ( e.KeyCode == Keys.Enter && !DataGridView.IsCurrentCellInEditMode ) )
      DataGridView.BeginEdit(false);
    else
      return;
    e.Handled = true;
    e.SuppressKeyPress = true;
  }

  private void ActionSearchOnline_Click(object sender, EventArgs e)
  {
    HebrewTools.OpenWordProvider(Program.Settings.SearchOnlineURL, SelectedBook?.Hebrew);
  }

  private void ActionOpenHebrewLetters_Click(object sender, EventArgs e)
  {
    HebrewTools.OpenHebrewLetters(SelectedBook.Hebrew);
  }

  private void ActionSearchWord_Click(object sender, EventArgs e)
  {
    MainForm.Instance.SearchHebrewWord(SelectedBook?.Hebrew);
    Close();
  }

  private void ActionOpen_Click(object sender, EventArgs e)
  {
    MainForm.Instance.GoToReference(SelectedBook?.Number ?? 1, 1, 1, false, true);
    Close();
  }

  private void ActionCopyName_Click(object sender, EventArgs e)
  {
    string name = SelectedBook.Transcription;
    string tranlation = SelectedBook.Translation;
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
    Clipboard.SetText(SelectedBook?.Unicode);
  }

  private void ActionEditMemo_Click(object sender, EventArgs e)
  {
    using var form = new EditMemoForm();
    var book = SelectedBook;
    if ( SelectedBook is null ) return;
    form.Text += book.Transcription;
    form.TextBox.Text = book.Memo;
    form.TextBox.SelectionStart = 0;
    if ( form.ShowDialog() == DialogResult.OK )
      book.Memo = form.TextBox.Text;
  }

  private void ActionRestoreCommonNames_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if ( DisplayManager.QueryYesNo(AppTranslations.AskToRestoreBooksCommonNames.GetLang()) )
      foreach ( var book in ApplicationDatabase.Instance.Books.OrderBy(b => b.Number) )
        book.CommonName = OnlineBooks.Common.GetLang((TanakBook)( book.Number ));
  }

  private void ActionShowGrammarGuide_Click(object sender, EventArgs e)
  {
    Program.GrammarGuideForm.Popup();
  }

}
