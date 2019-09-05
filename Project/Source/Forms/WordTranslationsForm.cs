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
/// <created> 2019-09 </created>
/// <edited> 2019-09 </edited>
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  public partial class WordTranslationsForm : Form
  {

    static public void Run(ReferenceItem reference, WordControl sender, List<WordReferencedItem> items)
    {
      var form = new WordTranslationsForm();
      form.Reference = reference;
      form.WordControl = sender;
      form.LabelReference.Text = reference.ToString();
      foreach ( var item in items )
      {
        var itemList = new ListViewItem(item.ToString());
        itemList.Tag = item;
        itemList.SubItems.Add(item.Word.Translation);
        form.ListView.Items.Add(itemList);
      }
      form.Show();
    }

    private ReferenceItem Reference;
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

    private void WordTranslationsForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      LabelReference_LinkClicked(null, null);
    }

    private void ButtonClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void LabelReference_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      MainForm.Instance.GoTo(Reference);
    }

    private void ListView_DoubleClick(object sender, EventArgs e)
    {
      ActionReachReference.PerformClick();
    }

    private void ActionReachReference_Click(object sender, EventArgs e)
    {
      if ( ListView.SelectedItems.Count < 1 ) return;
      MainForm.Instance.GoTo((ReferenceItem)ListView.SelectedItems[0].Tag);
    }

    private string CleanTranslation(string str)
    {
      return str.Replace(".", "")
                .Replace(",", "")
                .Replace(" ;", "")
                .Replace(";", "")
                .Replace(" :", "")
                .Replace(":", "");
    }

    private void ActionCopyTranslation_Click(object sender, EventArgs e)
    {
      if ( ListView.SelectedItems.Count < 1 ) return;
      var str = CleanTranslation(( (WordReferencedItem)ListView.SelectedItems[0].Tag ).Word.Translation);
      Clipboard.SetText(str);
    }

    private void ActionUseTranslation_Click(object sender, EventArgs e)
    {
      if ( ListView.SelectedItems.Count < 1 ) return;
      var str = CleanTranslation(( (WordReferencedItem)ListView.SelectedItems[0].Tag ).Word.Translation);
      WordControl.EditTranslation.Text = str;
    }

  }

}
