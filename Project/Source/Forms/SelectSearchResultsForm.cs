using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  public partial class SelectSearchResultsForm : Form
  {

    static public IEnumerable<ReferenceItem> Run(IEnumerable<ReferenceItem> references)
    {
      var form = new SelectSearchResultsForm();
      form.References = references;
      if ( form.ShowDialog() == DialogResult.Cancel )
        form.References = null;
      return form.References;
    }

    private IEnumerable<ReferenceItem> References;

    private int Count;

    private SelectSearchResultsForm()
    {
      InitializeComponent();
      Text = AboutBox.Instance.AssemblyTitle;
      Icon = MainForm.Instance.Icon;
      LabelFound.Text = String.Format(LabelFound.Text, MainForm.SearchResultsCount);
      LabelFirst.Text = String.Format(LabelFirst.Text, MainForm.MaxSearchResults);
    }

    private void SelectSearchResultsForm_Load(object sender, EventArgs e)
    {
      var query = from r in References
                  group r by r.Book into books
                  select new { Key = books.Key.Number, Count = books.Count() };
      foreach ( var item in query )
      {
        var row = SelectBooks.Items.Add(MainForm.Instance.DataSet.Books[item.Key - 1].Name);
        row.Tag = item.Key;
        row.SubItems.Add(item.Count.ToString());
      }
      ActiveControl = SelectBooks;
      SelectBooks.Focus();
      if ( References.Count() <= MainForm.MaxSearchResults )
        LabelFirst.Visible = false;
    }

    private void SelectBooks_ItemChecked(object sender, ItemCheckedEventArgs e)
    {
      if ( e.Item.Checked )
        Count += Convert.ToInt32(e.Item.SubItems[1].Text);
      else
        Count -= Convert.ToInt32(e.Item.SubItems[1].Text);
      LabelCount.Text = Count.ToString();
      ActionSelect.Enabled = Count > 0;
    }

    private void ActionSelect_Click(object sender, EventArgs e)
    {
      var list = new List<int>();
      foreach ( ListViewItem item in SelectBooks.Items )
        if ( item.Checked )
          list.Add((int)item.Tag);
      References = References.Where(r => list.Contains(r.Book.Number));
      DialogResult = DialogResult.Yes;
    }

    private void ActionAll_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.No;
    }

  }
  
}
