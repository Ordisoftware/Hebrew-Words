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

    static public void Run(List<ReferenceItem> items)
    {
      var form = new WordTranslationsForm();
      foreach ( var item in items )
      {
        var itemList = new ListViewItem(item.ToString());
        itemList.Tag = item;
        itemList.SubItems.Add(item.Word.Translation);
        form.ListView.Items.Add(itemList);
      }
      form.ShowDialog();
    }

    public WordTranslationsForm()
    {
      InitializeComponent();
      Icon = MainForm.Instance.Icon;
    }

    private void ListView_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
    {
      if ( e.Item.Tag != null ) Cursor = Cursors.Hand;
    }

  }

}
