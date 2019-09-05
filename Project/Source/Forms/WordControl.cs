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
/// <created> 2012-10 </created>
/// <edited> 2019-09 </edited>
using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  public partial class WordControl : UserControl
  {

    public event MouseEventHandler HebrewMouseClick
    {
      add { LabelHebrew.MouseClick += value; }
      remove { LabelHebrew.MouseClick -= value; }
    }

    public Data.DataSet.WordsRow Word
    {
      get
      {
        return _Word;
      }
      set
      {
        _Word = value;
        LabelHebrew.Text = value.Hebrew;
        EditTranslation.Text = value.Translation;
        LabelHebrew.Tag = value.Original;
      }
    }

    private Data.DataSet.WordsRow _Word;

    public WordControl()
    {
      InitializeComponent();
    }
    
    private void EditTranslation_TextChanged(object sender, EventArgs e)
    {
      if ( MainForm.Instance.IsLoading ) return;
      _Word.Translation = EditTranslation.Text;
      MainForm.Instance.ActionSave.Enabled = true;
    }

    private void LabelHebrew_MouseEnter(object sender, EventArgs e)
    {
      LabelHebrew.Cursor = Cursors.Hand;
      LabelHebrew.ForeColor = Color.DarkRed;
    }

    private void LabelHebrew_MouseLeave(object sender, EventArgs e)
    {
      LabelHebrew.Cursor = Cursors.Default;
      LabelHebrew.ForeColor = SystemColors.ControlText;
    }

    private void LabelHebrew_Click(object sender, EventArgs e)
    {
      switch ( Program.Settings.HebrewWordClickOpen )
      {
        case HebrewWordClickOpen.HebrewLetters:
          Program.OpenHebrewLetters(LabelHebrew.Text);
          break;
        case HebrewWordClickOpen.OnlineSearch:
          Program.OpenOnlineConcordance((string)LabelHebrew.Tag);
          break;
      }
    }

    private void ActionOpenHebrewLetters_Click(object sender, EventArgs e)
    {
      Program.OpenHebrewLetters(( (ContextMenuStrip)( (ToolStripMenuItem)sender ).Owner ).SourceControl.Text);
    }

    private void ActionOnlineSearch_Click(object sender, EventArgs e)
    {
      Program.OpenOnlineConcordance((string)( (ContextMenuStrip)( (ToolStripMenuItem)sender ).Owner ).SourceControl.Tag);
    }

    private void ActionCopy_Click(object sender, EventArgs e)
    {
      Clipboard.SetText(( (ContextMenuStrip)( (ToolStripMenuItem)sender ).Owner ).SourceControl.Text);
    }

    private void ActionSearch_Click(object sender, EventArgs e)
    {
      MainForm.Instance.SearchWord(( (ContextMenuStrip)( (ToolStripMenuItem)sender ).Owner ).SourceControl.Text);
    }

    private void ActionSearchTranslated_Click(object sender, EventArgs e)
    {
      string wordHebrew = ( (ContextMenuStrip)( (ToolStripMenuItem)sender ).Owner ).SourceControl.Text;
      var list = from book in MainForm.Instance.DataSet.Books
                 from chapter in book.GetChaptersRows()
                 from verse in chapter.GetVersesRows()
                 from word in verse.GetWordsRows()
                 where word.Hebrew == wordHebrew
                    && word.Translation != ""
                 select new ReferenceItem { Book = book, Chapter = chapter, Verse = verse, Word = word };
      string result = "";
      foreach ( var item in list )
        result += item.Word.Translation + Environment.NewLine;
      WordTranslationsForm.Run(this, list.ToList());
    }

  }

}
