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
/// <edited> 2019-01 </edited>
using Ordisoftware.Core;
using System;
using System.Data;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  public partial class EditBooksForm : Form
  {

    public EditBooksForm()
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
      TableAdapterManager.UpdateAll(dataSet);
    }

    private void ActionCopyHebrewName_Click(object sender, EventArgs e)
    {
      var book = (Data.DataSet.BooksRow)((DataRowView)BooksBindingSource.Current).Row;
      MessageBox.Show(book.Name);
    }

    private void BooksDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if ( e.ColumnIndex == 2 )
        e.Value = ( (string)e.Value ).Replace("_", " ");
    }

    private void ActionOpenHebrewLetters_Click(object sender, EventArgs e)
    {
      using ( var process = new System.Diagnostics.Process() )
        try
        {
          process.StartInfo.FileName = Program.Settings.HebrewLettersExe;
          var book = (Data.DataSet.BooksRow)( (DataRowView)BooksBindingSource.Current ).Row;
          string str = book.Hebrew;
          foreach ( var v in Letters.FinaleDisable ) str = str.Replace(v.Key, v.Value);
          process.StartInfo.Arguments = str;
          process.Start();
        }
        catch ( Exception ex )
        {
          ex.Manage();
        }

    }
  }

}
