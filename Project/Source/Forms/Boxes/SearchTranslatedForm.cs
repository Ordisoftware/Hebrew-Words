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
/// <created> 2019-09 </created>
/// <edited> 2020-03 </edited>
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Ordisoftware.Core;

namespace Ordisoftware.Hebrew.Words
{

  public partial class SearchTranslatedForm : Form
  {

    static internal readonly List<SearchTranslatedForm> Forms = new List<SearchTranslatedForm>();

    static public void Run(WordControl sender)
    {
      if ( sender == null || sender.Reference == null ) return;
      foreach ( SearchTranslatedForm f in Forms.ToList() )
        if ( f.WordControl.Reference.EqualsWord(sender.Reference) )
        {
          if ( f.WindowState == FormWindowState.Minimized )
            f.WindowState = FormWindowState.Normal;
          f.Show();
          f.BringToFront();
          return;
        }
      var form = new SearchTranslatedForm(sender);
      form.Show();
      form.Location = new Point(Program.Settings.SearchTranslatedFormLocation.X,
                                Program.Settings.SearchTranslatedFormLocation.Y);
      if ( form.Location.X < 0 && form.Location.Y < 0 )
      {
        form.CenterToMainFormElseScreen();
        Program.Settings.SearchTranslatedFormLocation = new Point(form.Location.X, form.Location.Y);
        Program.Settings.Save();
      }
      MainForm.Instance.ActionCloseWindows.Enabled = Forms.Count > 0;
    }

    private WordControl WordControl;
    private bool Mutex;

    private SearchTranslatedForm()
    {
      InitializeComponent();
      Icon = MainForm.Instance.Icon;
      MaximumSize = new Size(MaximumSize.Width, Screen.PrimaryScreen.WorkingArea.Height);
      EditDistinct.Checked = Program.Settings.SearchTranslatedFormFilterDistinct;
    }

    private SearchTranslatedForm(WordControl sender)
      : this()
    {
      Forms.Add(this);
      WordControl = sender;
      LabelReference.Text = sender.Reference.ToString();
      Mutex = true;
      EditHebrew.Text = sender.LabelHebrew.Text;
      Mutex = false;
      Text = sender.Reference.ToString() + " #" + sender.Reference.Word.Number;
      UpdateResult();
      ActiveControl = ListView;
      if ( ListView.Items.Count > 0 )
        ListView.Items[0].Selected = true;
    }

    private void SearchTranslatedForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if ( EditReturn.Checked )
      {
        LabelReference_LinkClicked(null, null);
        WordControl.Focus();
      }
    }

    private void SearchTranslatedForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Forms.Remove(this);
      MainForm.Instance.ActionCloseWindows.Enabled = Forms.Count > 0;
      Program.Settings.SearchTranslatedFormLocation = new Point(Location.X, Location.Y);
      Program.Settings.SearchTranslatedFormFilterDistinct = EditDistinct.Checked;
      Program.Settings.Save();
    }

    private void ButtonClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void ListView_Resize(object sender, EventArgs e)
    {
      ListView.Columns[1].Width = -2;
    }

    private void ListView_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
    {
      ListView.Columns[1].Width = -2;
      Program.Settings.FoundReferencesColumnRefWidth = ListView.Columns[0].Width;
    }

    private void ListView_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (ListView.SelectedItems.Count > 0)
        LabelHebrewWordSource.Text = ((ReferenceItem)ListView.SelectedItems[0].Tag).Word.Hebrew;
    }

    private bool KeyProcessed = false;

    private void EditHebrew_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ( e.KeyChar == '\r' )
        UpdateResult();
      else
      if ( !HebrewAlphabet.Codes.Contains(Convert.ToString(e.KeyChar)) )
        e.KeyChar = '\x0';
      else
        KeyProcessed = true;
    }

    private void EditHebrew_KeyUp(object sender, KeyEventArgs e)
    {
      if ( KeyProcessed )
      {
        KeyProcessed = false;
        if ( EditHebrew.SelectionStart != 0 )
          EditHebrew.SelectionStart = EditHebrew.SelectionStart - 1;
      }
    }

    private void LabelReference_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      ReachReferencedWord(new ReferenceItem(WordControl.Reference));
    }

    private void ListView_DoubleClick(object sender, EventArgs e)
    {
      switch ( Program.Settings.TranslatedItemDoubleClickOpen )
      {
        case TranslatedItemDoubleClickOpen.ReachReference:
          ActionReachReference.PerformClick();
          break;
        case TranslatedItemDoubleClickOpen.UseTranslation:
          ActionUseTranslation.PerformClick();
          break;
        case TranslatedItemDoubleClickOpen.AddTranslation:
          ActionAddTranslation.PerformClick();
          break;
        default:
          throw new NotImplementedExceptionEx(Program.Settings.TranslatedItemDoubleClickOpen.ToStringFull());
      }
    }

    private void ReachReferencedWord(ReferenceItem reference)
    {
      MainForm.Instance.GoTo(reference);
    }

    private void ActionReachReference_Click(object sender, EventArgs e)
    {
      if ( ListView.SelectedItems.Count < 1 ) return;
      ReachReferencedWord((ReferenceItem)ListView.SelectedItems[0].Tag);
    }

    private string CleanTranslation(string str)
    {
      return str.Replace(".", "")
                .Replace(",", "")
                .Replace(";", "")
                .Replace(":", "")
                .Replace("!", "")
                .Replace("?", "")
                .Trim();
    }

    private void ActionCopyTranslation_Click(object sender, EventArgs e)
    {
      if ( ListView.SelectedItems.Count < 1 ) return;
      var str = CleanTranslation(( (ReferenceItem)ListView.SelectedItems[0].Tag ).Word.Translation);
      Clipboard.SetText(str);
    }

    private void ActionUseTranslation_Click(object sender, EventArgs e)
    {
      if ( ListView.SelectedItems.Count < 1 ) return;
      var str = CleanTranslation(( (ReferenceItem)ListView.SelectedItems[0].Tag ).Word.Translation);
      WordControl.Reference.Word.Translation = str;
      WordControl.EditTranslation.Text = str;
      Close();
    }

    private void ActionAddTranslation_Click(object sender, EventArgs e)
    {
      if ( ListView.SelectedItems.Count < 1 ) return;
      var str = CleanTranslation(( (ReferenceItem)ListView.SelectedItems[0].Tag ).Word.Translation);
      if ( WordControl.Reference.Word.Translation.Trim() == "" )
      {
        WordControl.Reference.Word.Translation = str;
        WordControl.EditTranslation.Text = str;
      }
      else
      {
        WordControl.Reference.Word.Translation += " / " + str;
        WordControl.EditTranslation.Text = WordControl.Reference.Word.Translation;
      }
    }

    private void EditHebrew_TextChanged(object sender, EventArgs e)
    {
      if ( Mutex ) return;
      if (EditWholeWord.Checked)
        EditWholeWord.Checked = false;
      else
        UpdateResult();
    }

    private void ActionDelLast_Click(object sender, EventArgs e)
    {
      if ( EditHebrew.Text.Length <= 2 ) return;
      EditHebrew.Text = EditHebrew.Text.Remove(0, 1);
      UpdateResult();
    }

    private void ActionDelFirst_Click(object sender, EventArgs e)
    {
      if ( EditHebrew.Text.Length <= 2 ) return;
      EditHebrew.Text = EditHebrew.Text.Remove(EditHebrew.Text.Length - 1, 1);
      UpdateResult();
    }

    private void ActionReset_Click(object sender, EventArgs e)
    {
      EditHebrew.Text = WordControl.Reference.Word.Hebrew;
      EditWholeWord.Checked = true;
      UpdateResult();
    }

    private void EditFilter_CheckedChanged(object sender, EventArgs e)
    {
      UpdateResult();
    }

    private void UpdateResult()
    {
      if ( Mutex ) return;
      Mutex = true;
      try
      {
        ListView.Items.Clear();
        string wordHebrew = EditHebrew.Text;
        if ( wordHebrew.Length < 2 ) return;
        Func<string, bool> checkWholeWord = str => { return str == wordHebrew; };
        Func<string, bool> checkContains = str => { return str.Contains(wordHebrew); };
        Func<string, bool> check = EditWholeWord.Checked ? checkWholeWord : checkContains;
        var references = from book in MainForm.Instance.DataSet.Books
                         from chapter in book.GetChaptersRows()
                         from verse in chapter.GetVersesRows()
                         from word in verse.GetWordsRows()
                         where check(word.Hebrew) && word.Translation != ""
                         select new ReferenceItem(book, chapter, verse, word);
        if ( EditDistinct.Checked )
          references = references.Distinct(new WordTranslationComparer());
        foreach ( var item in references )
        {
          var itemList = new ListViewItem(item.ToString());
          itemList.Tag = item;
          itemList.SubItems.Add(item.Word.Translation);
          ListView.Items.Add(itemList);
        }
      }
      finally
      {
        Mutex = false;
      }
    }

  }

}
