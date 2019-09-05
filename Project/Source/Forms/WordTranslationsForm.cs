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

  public partial class WordTranslationsForm : Form
  {

    static public void Run(WordControl sender, List<ReferenceItem> items)
    {
      var form = new WordTranslationsForm();
      form.WordControl = sender;
      foreach ( var item in items )
      {
        var itemList = new ListViewItem(item.ToString());
        itemList.Tag = item;
        itemList.SubItems.Add(item.Word.Translation);
        form.ListView.Items.Add(itemList);
      }
      form.Show();
    }

    private WordControl WordControl;

    public WordTranslationsForm()
    {
      InitializeComponent();
      Text = MainForm.Instance.Text;
      Icon = MainForm.Instance.Icon;
    }

    private void WordTranslationsForm_Shown(object sender, EventArgs e)
    {
      ActiveControl = ListView;
    }

    private void ButtonClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void ListView_DoubleClick(object sender, EventArgs e)
    {
      ActionReachReference.PerformClick();
    }

    private void ActionReachReference_Click(object sender, EventArgs e)
    {
      if ( ListView.SelectedItems.Count < 1 ) return;
      var item = (ReferenceItem)ListView.SelectedItems[0].Tag;
      // todo add current verse to bookmarks list
      MainForm.Instance.GoTo(item.Book.Number, item.Chapter.Number, item.Verse.Number);
    }

    private void ActionCopyTranslation_Click(object sender, EventArgs e)
    {
      if ( ListView.SelectedItems.Count < 1 ) return;
      var str = ( (ReferenceItem)ListView.SelectedItems[0].Tag ).Word.Translation
                .Replace(".", "")
                .Replace(",", "")
                .Replace(" ;", "")
                .Replace(";", "")
                .Replace(" :", "")
                .Replace(":", "");
      Clipboard.SetText(str);
    }

    private void ActionUseTranslation_Click(object sender, EventArgs e)
    {
      if ( ListView.SelectedItems.Count < 1 ) return;
      var str = ( (ReferenceItem)ListView.SelectedItems[0].Tag ).Word.Translation
                .Replace(".", "")
                .Replace(",", "")
                .Replace(" ;", "")
                .Replace(";", "")
                .Replace(" :", "")
                .Replace(":", "");
      WordControl.EditTranslation.Text = str;
    }

  }

}
