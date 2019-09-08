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
/// <edited> 2019-09 </edited>
using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  public partial class MainForm
  {

    private Font HebrewFont = new Font("Hebrew", 12f);

    private Font LatinFont = new Font("Verdana", 10f);

    private void AddTextRightAligned(RichTextBox control, Font font, string str)
    {
      AddTextRightAligned(control, font, str, SystemColors.ControlText);
    }

    private void AddTextRightAligned(RichTextBox control, Font font, string str, Color color)
    {
      control.SelectionFont = font;
      control.SelectionColor = color;
      control.SelectedText = str;
      control.SelectionAlignment = HorizontalAlignment.Right;
    }

    private void UpdateViews()
    {
      UpdateViewVerses();
      UpdateViewTranslations();
      UpdateViewRawText();
      UpdateViewELS50();
    }

    private void UpdateViewTranslations()
    {
      EditTranslations.Clear();
      var list = ( (ChapterItem)SelectChapter.SelectedItem ).Chapter.GetVersesRows();
      foreach ( Data.DataSet.VersesRow verse in list )
      {
        string str = verse.Number + ". ";
        foreach ( Data.DataSet.WordsRow word in verse.GetWordsRows() )
          str = str + word.Translation + " ";
        str = str.Remove(str.Length - 1, 1);
        EditTranslations.SelectedText = str;
        if ( verse.Comment != "" )
        {
          EditTranslations.SelectedText = Environment.NewLine + Environment.NewLine;
          EditTranslations.SelectedText = verse.Comment;
        }
        EditTranslations.SelectedText = Environment.NewLine + Environment.NewLine;
      }
      EditTranslations.SelectionStart = 0;
    }

    private void UpdateViewRawText()
    {
      EditRawText.Clear();
      var list = ( (ChapterItem)SelectChapter.SelectedItem ).Chapter.GetVersesRows();
      foreach ( Data.DataSet.VersesRow verse in list )
      {
        string str = "";
        foreach ( Data.DataSet.WordsRow word in verse.GetWordsRows() )
          str = word.Hebrew + " " + str;
        AddTextRightAligned(EditRawText, HebrewFont, str);
        AddTextRightAligned(EditRawText, LatinFont, ":" + verse.Number);
        EditRawText.AppendText(Environment.NewLine + Environment.NewLine);
      }
      EditRawText.SelectionStart = 0;
    }

    private void UpdateViewELS50()
    {
      EditELS50All.Clear();
      var list = ( (BookItem)SelectBook.SelectedItem ).Book.GetChaptersRows();
      foreach ( Data.DataSet.ChaptersRow chapter in list )
      {
        AddTextRightAligned(EditELS50All, HebrewFont, chapter.ELS50);
        AddTextRightAligned(EditELS50All, LatinFont, " :" + chapter.Number);
        EditELS50All.AppendText(Environment.NewLine);
      }
      EditELS50All.SelectionStart = 0;
    }

    private void UpdateViewSearch()
    {
      Cursor = Cursors.WaitCursor;
      EditSearchResults.SuspendLayout();
      try
      {
        EditSearchResults.Clear();
        string str1 = EditLetters.Input.Text;
        if ( str1 == "" ) return;
        string str2 = Letters.SetFinale(str1, true);
        var books = !EditSearchOnlyTorah.Checked
                  ? DataSet.Books.ToList()
                  : ( from book in DataSet.Books
                      where book.Number <= 5
                      orderby book.Number
                      select book ).ToList();
        foreach ( Data.DataSet.BooksRow book in books )
          foreach ( Data.DataSet.ChaptersRow chapter in book.GetChaptersRows() )
            foreach ( Data.DataSet.VersesRow verse in chapter.GetVersesRows() )
            {
              string strTranslation = "";
              foreach ( Data.DataSet.WordsRow word in verse.GetWordsRows() )
                if ( word.Hebrew.Contains(str1) || word.Hebrew.Contains(str2) )
                {
                  foreach ( Data.DataSet.WordsRow w in verse.GetWordsRows().Reverse() )
                  {
                    var color = w.Hebrew.Contains(str1) || w.Hebrew.Contains(str2)
                              ? Color.DarkRed
                              : SystemColors.ControlText;
                    AddTextRightAligned(EditSearchResults, HebrewFont, " ");
                    AddTextRightAligned(EditSearchResults, HebrewFont, w.Hebrew, color);
                    strTranslation = w.Translation + " " + strTranslation;
                  }
                  string strRef = " :" + verse.Number + "." + chapter.Number + "." + book.Name;
                  AddTextRightAligned(EditSearchResults, LatinFont, strRef);
                  EditSearchResults.AppendText(Environment.NewLine);
                  EditSearchResults.AppendText(strTranslation);
                  EditSearchResults.AppendText(Environment.NewLine + Environment.NewLine);
                  break;
                }
            }
        EditSearchResults.SelectionStart = 0;
      }
      finally
      {
        EditSearchResults.ResumeLayout();
        Cursor = Cursors.Default;
      }
    }

    private void UpdateViewVerses()
    {
      var item = (ChapterItem)SelectChapter.SelectedItem;
      EditELS50.Text = item.Chapter.ELS50;
      EditELS50.SelectionStart = EditELS50.TextLength;
      Cursor = Cursors.WaitCursor;
      PanelViewVerses.SuspendLayout();
      try
      {
        if ( PanelViewVerses.Controls.Count > 0 )
          PanelViewVerses.ScrollControlIntoView(PanelViewVerses.Controls[0]);
        PanelViewVerses.Controls.Clear();
        var control = new WordControl();
        int margin = 45;
        int delta = 10;
        int width = Width - margin;
        int dx = control.Width;
        int dy = control.Height;
        int marginX = margin + delta;
        int marginY = margin;
        int x = width - dx - marginX;
        int y = delta;
        int minx = x;
        foreach ( var verse in item.Chapter.GetVersesRows() )
        {
          var label = new Label();
          label.AutoSize = false;
          label.Width = 40;
          label.ForeColor = Color.DarkBlue;
          label.Font = new Font("Calibri", 13f, FontStyle.Bold);
          label.Location = new Point(x + dx + delta, y + 2);
          label.Text = verse.Number.ToString();
          label.MouseEnter += LabelVerseNumberMouseEnter;
          label.MouseLeave += LabelVerseNumberMouseLeave;
          label.MouseClick += LabelVerseNumberMouseClick;
          label.ContextMenuStrip = ContextMenuStripVerse;
          PanelViewVerses.Controls.Add(label);
          bool emptyline = false;
          foreach ( var word in verse.GetWordsRows() )
          {
            emptyline = false;
            var reference = new ReferenceItem();
            reference.Book = ( (BookItem)SelectBook.SelectedItem ).Book;
            reference.Chapter = ( (ChapterItem)SelectChapter.SelectedItem ).Chapter;
            reference.Verse = verse;
            control = new WordControl(reference);
            control.Word = word;
            control.Location = new Point(x, y);
            PanelViewVerses.Controls.Add(control);
            x -= dx;
            if ( x < delta )
            {
              if ( x < minx + dx + delta ) minx = x;
              x = width - dx - marginX;
              y += dy;
              emptyline = true;
            }
          }
          if ( emptyline ) y -= dy;
          var editComment = new TextBox();
          label.Tag = editComment;
          if ( Program.Settings.CommentaryLinesCount > 1 )
          {
            editComment.Multiline = true;
            editComment.WordWrap = true;
            editComment.ScrollBars = ScrollBars.Vertical;
          }
          editComment.Location = new Point(minx + dx, y + dy + delta);
          x = width - dx - marginX - 2;
          editComment.Width = x - minx;
          editComment.Height = editComment.Height * Program.Settings.CommentaryLinesCount - 3;
          editComment.Tag = verse;
          editComment.BackColor = Color.Honeydew;
          editComment.Text = verse.Comment;
          editComment.TextChanged += VerseCommentTextChanged;
          PanelViewVerses.Controls.Add(editComment);
          y = y + dy + marginY + editComment.Height;
        }
      }
      finally
      {
        PanelViewVerses.ResumeLayout();
        Cursor = Cursors.Default;
      }
    }
    
    private void VerseCommentTextChanged(object sender, EventArgs e)
    {
      if ( IsLoading ) return;
      if ( !( sender is TextBox ) ) throw new Exception("Wrong sender type: TextBox expected.");
      var textbox = (TextBox)sender;
      ( (Data.DataSet.VersesRow)textbox.Tag ).Comment = textbox.Text;
      ActionSave.Enabled = true;
    }

    private void LabelVerseNumberMouseEnter(object sender, EventArgs e)
    {
      if ( !( sender is Label ) ) throw new Exception("Wrong sender type: Label expected.");
      var label = (Label)sender;
      label.Cursor = Cursors.Hand;
      label.ForeColor = Color.Blue;
    }

    private void LabelVerseNumberMouseLeave(object sender, EventArgs e)
    {
      if ( !( sender is Label ) ) throw new Exception("Wrong sender type: Label expected.");
      var label = (Label)sender;
      label.Cursor = Cursors.Default;
      label.ForeColor = Color.DarkBlue;
    }

    private void LabelVerseNumberMouseClick(object sender, MouseEventArgs e)
    {
      if ( e.Button == MouseButtons.Left )
        ActionOpenVerseOnline_Click(sender, null);
    }

  }

}
