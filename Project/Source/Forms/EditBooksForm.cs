using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
  }

}
