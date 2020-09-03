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
/// <created> 2019-01 </created>
/// <edited> 2020-03 </edited>
using System;
using System.Windows.Forms;
using Ordisoftware.HebrewCommon;

namespace Ordisoftware.HebrewWords
{

  public partial class EditBooksForm : Form
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
      EventHandler action = (sender, e) =>
      {
        var menuitem = (ToolStripMenuItem)sender;
        var control = ( (ContextMenuStrip)menuitem.OwnerItem.Owner ).SourceControl;
        var row = ( (System.Data.DataRowView)EditBooks.SelectedRows[0].DataBoundItem ).Row;
        string strOriginal = ( (Data.DataSet.BooksRow)row ).Original;
        foreach ( string item in strOriginal.Split(' ') )
        {
          SystemManager.RunShell(( (string)menuitem.Tag ).Replace("%WORD%", item));
        }
      };
      foreach ( var item in Globals.OnlineWordProviders.Items )
      {
        if ( item.Name == "-" )
          ActionSearchOnline.DropDownItems.Insert(index++, new ToolStripSeparator());
        else
          ActionSearchOnline.DropDownItems.Insert(index++, item.CreateMenuItem(action));
      }
    }

    private void EditBooksForm_Load(object sender, EventArgs e)
    {
      EditBooks.DataSource = MainForm.Instance.BooksBindingSource;
      ActiveControl = EditBooks;
    }

    private void EditBooksForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Validate();
      MainForm.Instance.BooksBindingSource.EndEdit();
      UpdateViewRequired = MainForm.Instance.DataSet.HasChanges();
      MainForm.Instance.TableAdapterManager.UpdateAll(MainForm.Instance.DataSet);
    }

    private void BooksDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if ( e.ColumnIndex == 3 )
        e.Value = ( (string)e.Value ).Trim();
    }

    private void EditBooks_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
    {
      if ( e.Button == MouseButtons.Right )
      {
        int rowSelected = e.RowIndex;
        if ( e.RowIndex != -1 )
        {
          EditBooks.ClearSelection();
          EditBooks.Rows[rowSelected].Selected = true;
          BooksBindingSource.Position = e.RowIndex;
        }
      }
    }

    private void ActionSearchOnline_Click(object sender, EventArgs e)
    {
      var row = ( (System.Data.DataRowView)EditBooks.SelectedRows[0].DataBoundItem ).Row;
      Program.OpenOnlineConcordance(( (Data.DataSet.BooksRow)row ).Original);
    }

    private void ActionOpenHebrewLetters_Click(object sender, EventArgs e)
    {
      Program.OpenHebrewLetters((string)EditBooks.SelectedRows[0].Cells[1].Value);
    }

    private void ActionSearchWord_Click(object sender, EventArgs e)
    {
      var row = ( (System.Data.DataRowView)EditBooks.SelectedRows[0].DataBoundItem ).Row;
      MainForm.Instance.SearchWord(( (Data.DataSet.BooksRow)row ).Hebrew);

      // TODO form to select one word from multiple having more than 1 char

      Close();
    }

    private void ActionCopyName_Click(object sender, EventArgs e)
    {
      string strName = (string)EditBooks.SelectedRows[0].Cells[2].Value;
      if ( strName.StartsWith("a ") ) strName = strName.Substring(2, strName.Length - 2);
      else
      if ( strName.StartsWith("b ") ) strName = strName.Substring(2, strName.Length - 2);
      string strCommonName = (string)EditBooks.SelectedRows[0].Cells[3].Value;
      if ( strCommonName != "" )
        strName += " (" + strCommonName + ")";
      string strTranlation = (string)EditBooks.SelectedRows[0].Cells[4].Value;
      if ( strTranlation != "" )
        strName += " - " + strTranlation;
      Clipboard.SetText(strName);
    }

    private void ActionCopyFontChars_Click(object sender, EventArgs e)
    {
      var row = ( (System.Data.DataRowView)EditBooks.SelectedRows[0].DataBoundItem ).Row;
      Clipboard.SetText(( (Data.DataSet.BooksRow)row ).Hebrew);
    }

    private void ActionCopyUnicodeChars_Click(object sender, EventArgs e)
    {
      var row = ( (System.Data.DataRowView)EditBooks.SelectedRows[0].DataBoundItem ).Row;
      Clipboard.SetText(( (Data.DataSet.BooksRow)row ).Original);
    }

    private void ActionEditMemo_Click(object sender, EventArgs e)
    {
      var form = new EditMemoForm();
      var row = ( (System.Data.DataRowView)EditBooks.SelectedRows[0].DataBoundItem ).Row;
      var book = (Data.DataSet.BooksRow)row;
      form.Text += book.Name;
      form.TextBox.Text = book.Memo;
      form.TextBox.SelectionStart = 0;
      if ( form.ShowDialog() == DialogResult.OK )
        book.Memo = form.TextBox.Text;
    }

    private void ActionRestoreCommonNames_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      if ( DisplayManager.QueryYesNo(Translations.AskToRestoreBooksCommonNames.GetLang()) )
        foreach ( Data.DataSet.BooksRow book in MainForm.Instance.DataSet.Books.Rows )
          book.CommonName = BooksNames.Common.GetLang((Books)( book.Number - 1 ));
    }

    private void ActionOpen_Click(object sender, EventArgs e)
    {
      var row = ( (System.Data.DataRowView)EditBooks.SelectedRows[0].DataBoundItem ).Row;
      MainForm.Instance.GoTo(( (Data.DataSet.BooksRow)row ).Number, 1, 1);
      Close();
    }

  }

}
