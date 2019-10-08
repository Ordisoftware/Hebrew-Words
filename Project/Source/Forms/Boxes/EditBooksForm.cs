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
/// <created> 2019-01 </created>
/// <edited> 2019-09 </edited>
using System;
using System.Windows.Forms;

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
    }

    private void EditBooksForm_Load(object sender, EventArgs e)
    {
      EditBooks.DataSource = MainForm.Instance.BooksBindingSource;
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void EditBooksForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Validate();
      MainForm.Instance.BooksBindingSource.EndEdit();
      UpdateViewRequired = MainForm.Instance.DataSet.HasChanges();
      MainForm.Instance.TableAdapterManager.UpdateAll(DataSet);
    }

    private void BooksDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if ( e.ColumnIndex == 3 )
        e.Value = ((string)e.Value).Trim();
    }

    private void ActionOnlineSearch_Click(object sender, EventArgs e)
    {
      var row = ( (System.Data.DataRowView)EditBooks.SelectedRows[0].DataBoundItem ).Row;
      string strOriginal = ((Data.DataSet.BooksRow)row).Original;
      foreach ( string item in strOriginal.Split(' ') )
      {
        Program.OpenOnlineConcordance(item);
        System.Threading.Thread.Sleep(2500);
      }
    }

    private void ActionOpenHebrewLetters_Click(object sender, EventArgs e)
    {
      string strHebrew = (string)EditBooks.SelectedRows[0].Cells[1].Value;
      if ( strHebrew.StartsWith("a ") ) strHebrew = strHebrew.Substring(2, strHebrew.Length - 2);
      else
      if ( strHebrew.StartsWith("b ") ) strHebrew = strHebrew.Substring(2, strHebrew.Length - 2);
      foreach ( string item in strHebrew.Split(' ') )
        Program.OpenHebrewLetters(item);
    }

    private void ActionCopyName_Click(object sender, EventArgs e)
    {
      string strName = (string)EditBooks.SelectedRows[0].Cells[2].Value;
      if ( strName.StartsWith("a ") ) strName = strName.Substring(2, strName.Length - 2);
      else
      if ( strName.StartsWith("b ") ) strName = strName.Substring(2, strName.Length - 2);
      string strTranlation = (string)EditBooks.SelectedRows[0].Cells[3].Value;
      if ( strTranlation != "" )
        strName += " (" + strTranlation + ")";
      Clipboard.SetText(strName);
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

  }

}
