﻿/// <license>
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
using System.Data;
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
      Text = AboutBox.Instance.AssemblyTitle;
      Icon = MainForm.Instance.Icon;
    }

    private void EditBooksForm_Load(object sender, EventArgs e)
    {
      BooksTableAdapter.Fill(dataSet.Books);
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void EditBooksForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Validate();
      BooksBindingSource.EndEdit();
      UpdateViewRequired = dataSet.HasChanges();
      TableAdapterManager.UpdateAll(dataSet);
    }

    private void BooksDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if ( e.ColumnIndex == 2 ) e.Value = (string)e.Value;
    }

    private void ActionOpenHebrewLetters_Click(object sender, EventArgs e)
    {
      var book = (Data.DataSet.BooksRow)( (DataRowView)BooksBindingSource.Current ).Row;
      Program.OpenHebrewLetters(book.Hebrew);
    }

    private void ActionCopyHebrewName_Click(object sender, EventArgs e)
    {
      var book = (Data.DataSet.BooksRow)( (DataRowView)BooksBindingSource.Current ).Row;
      Clipboard.SetText(book.Name);
    }

  }

}
