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
/// <created> 2019-09 </created>
/// <edited> 2019-09 </edited>
using System;
using System.Linq;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  public partial class SearchTranslatedForm : Form
  {

    static public void Run(WordControl sender, ReferenceItem reference)
    {
      var form = new SearchTranslatedForm();
      form.Reference = reference;
      form.WordControl = sender;
      form.LabelReference.Text = reference.ToString();
      form.EditHebrew.Text = sender.LabelHebrew.Text;
      form.Show();
    }

    private ReferenceItem Reference;
    private WordControl WordControl;

    private SearchTranslatedForm()
    {
      InitializeComponent();
      Icon = MainForm.Instance.Icon;
    }

    private void WordTranslationsForm_Shown(object sender, EventArgs e)
    {
      ActionUpdate.PerformClick();
    }

    private void WordTranslationsForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      LabelReference_LinkClicked(null, null);
      WordControl.Focus();
    }

    private void ButtonClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
      if ( keyData == Keys.Escape )
      {
        Close();
        return true;
      }
      return base.ProcessCmdKey(ref msg, keyData);
    }

    private void ActionUpdate_Click(object sender, EventArgs e)
    {
      ListView.Items.Clear();
      string wordHebrew = EditHebrew.Text;
      Func<string, bool> checkWholeWord = str => { return str == wordHebrew; };
      Func<string, bool> checkContains = str => { return str.Contains(wordHebrew); };
      Func<string, bool> check = EditWholeWord.Checked ? checkWholeWord : checkContains;
      var references = from book in MainForm.Instance.DataSet.Books
                       from chapter in book.GetChaptersRows()
                       from verse in chapter.GetVersesRows()
                       from word in verse.GetWordsRows()
                       where check(word.Hebrew) && word.Translation != ""
                       select new WordReferencedItem
                       {
                         Book = book,
                         Chapter = chapter,
                         Verse = verse,
                         Word = word
                       };
      foreach ( var item in references )
      {
        var itemList = new ListViewItem(item.ToString());
        itemList.Tag = item;
        itemList.SubItems.Add(item.Word.Translation);
        ListView.Items.Add(itemList);
      }
      ActiveControl = ListView;
    }

    private void LabelReference_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      ReachReferencedWord(new WordReferencedItem(Reference, WordControl.Word));
    }

    private void ListView_DoubleClick(object sender, EventArgs e)
    {
      ActionUseTranslation.PerformClick();
    }

    private void ReachReferencedWord(WordReferencedItem reference)
    {
      MainForm.Instance.GoTo(reference);
      foreach ( Control control in MainForm.Instance.PanelViewVerses.Controls )
        if ( control is WordControl )
          if ( ( (WordControl)control ).Word == reference.Word )
            ( (WordControl)control ).Focus();
      Focus();
      BringToFront();
    }

    private void ActionReachReference_Click(object sender, EventArgs e)
    {
      if ( ListView.SelectedItems.Count < 1 ) return;
      ReachReferencedWord((WordReferencedItem)ListView.SelectedItems[0].Tag);
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
      Close();
    }

  }

}
