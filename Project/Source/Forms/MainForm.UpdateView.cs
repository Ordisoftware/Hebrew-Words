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

    private void AddText(RichTextBox control, Font font, string str)
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

    private void UpdateViewTranslations()
    {
      EditTranslations.Clear();
      var list = ( (ChapterItem)SelectChapter.SelectedItem ).Row.GetVersesRows();
      foreach ( Data.DataSet.VersesRow verse in list )
      {
        string str = verse.Number + ". ";
        foreach ( Data.DataSet.WordsRow word in verse.GetWordsRows() )
          str = str + word.Translation + " ";
        str = str.Remove(str.Length - 1, 1);
        EditTranslations.SelectedText = str;
        if ( verse.Comment != "" )
          EditTranslations.SelectedText = " {" + verse.Comment + "}";
        EditTranslations.SelectedText = Environment.NewLine + Environment.NewLine;
      }
      EditTranslations.SelectionStart = 0;
    }

    private void UpdateViewRawText()
    {
      EditRawText.Clear();
      var list = ( (ChapterItem)SelectChapter.SelectedItem ).Row.GetVersesRows();
      foreach ( Data.DataSet.VersesRow verse in list )
      {
        string str = "";
        foreach ( Data.DataSet.WordsRow word in verse.GetWordsRows() )
          str = word.Hebrew + " " + str;
        AddText(EditRawText, HebrewFont, str);
        AddText(EditRawText, LatinFont, ":" + verse.Number);
        EditRawText.AppendText(Environment.NewLine + Environment.NewLine);
      }
      EditRawText.SelectionStart = 0;
    }

    private void UpdateViewSearch()
    {
      Cursor = Cursors.WaitCursor;
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
              foreach ( Data.DataSet.WordsRow word in verse.GetWordsRows() )
                if ( word.Hebrew.Contains(str1) || word.Hebrew.Contains(str2) )
                {
                  string str = "";
                  foreach ( Data.DataSet.WordsRow w in verse.GetWordsRows().Reverse() )
                  {
                    var color = w.Hebrew.Contains(str1) || w.Hebrew.Contains(str2)
                              ? Color.DarkRed
                              : SystemColors.ControlText;
                    AddText(EditSearchResults, HebrewFont, " ");
                    AddTextRightAligned(EditSearchResults, HebrewFont, w.Hebrew, color);
                  }
                  string strRef = " :" + verse.Number + "." + chapter.Number + "." + book.Name;
                  AddText(EditSearchResults, LatinFont, strRef);
                  EditSearchResults.AppendText(Environment.NewLine + Environment.NewLine);
                  break;
                }
        EditSearchResults.SelectionStart = 0;
      }
      finally
      {
        Cursor = Cursors.Default;
      }
    }

    private void UpdateViewELS50()
    {
      EditELS50All.Clear();
      var list = ( (BookItem)SelectBook.SelectedItem ).Row.GetChaptersRows();
      foreach ( Data.DataSet.ChaptersRow chapter in list )
      {
        AddText(EditELS50All, HebrewFont, chapter.ELS50);
        AddText(EditELS50All, LatinFont, " :" + chapter.Number);
        EditELS50All.AppendText(Environment.NewLine);
      }
      EditELS50All.SelectionStart = 0;
    }

    private void UpdateViewVerses()
    {
      var item = (ChapterItem)SelectChapter.SelectedItem;
      EditELS50.Text = item.Row.ELS50;
      EditELS50.SelectionStart = EditELS50.TextLength;
      PanelViewVerses.SuspendLayout();
      try
      {
        if (PanelViewVerses.Controls.Count > 0)
          PanelViewVerses.ScrollControlIntoView(PanelViewVerses.Controls[0]);
        PanelViewVerses.Controls.Clear();
        var control = new WordControl();
        int margin = 50;
        int delta = 10;
        int width = Width - margin;
        int dx = control.Width;
        int dy = control.Height;
        int marginX = margin + delta;
        int marginY = margin;
        int x = width - dx - marginX;
        int y = delta;
        int minx = x;
        foreach ( var verse in item.Row.GetVersesRows() )
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
          PanelViewVerses.Controls.Add(label);
          bool emptyline = false;
          foreach ( var word in verse.GetWordsRows() )
          {
            emptyline = false;
            control = new WordControl();
            control.HebrewMouseClick += HebrewWordMouseClick;
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
          var edit = new TextBox();
          label.Tag = edit;
          edit.Location = new Point(minx + dx, y + dy + delta);
          x = width - dx - marginX - 2;
          edit.Width = x - minx;
          edit.Tag = verse;
          edit.BackColor = Color.Honeydew;
          edit.Text = verse.Comment;
          edit.TextChanged += VerseCommentTextChanged;
          PanelViewVerses.Controls.Add(edit);
          y = y + dy + marginY + edit.Height;
        }
      }
      finally
      {
        PanelViewVerses.ResumeLayout();
      }
    }

    private void VerseCommentTextChanged(object sender, EventArgs e)
    {
      var textbox = (TextBox)sender;
      ( (Data.DataSet.VersesRow)textbox.Tag ).Comment = textbox.Text;
      ActionSave.Enabled = true;
    }

    private void LabelVerseNumberMouseEnter(object sender, EventArgs e)
    {
      ( sender as Label ).Cursor = Cursors.Hand;
      ( sender as Label ).ForeColor = Color.Blue;
    }

    private void LabelVerseNumberMouseLeave(object sender, EventArgs e)
    {
      ( sender as Label ).Cursor = Cursors.Default;
      ( sender as Label ).ForeColor = Color.DarkBlue;
    }

    private void LabelVerseNumberMouseClick(object sender, MouseEventArgs e)
    {
      Program.OpenOnlineVerse((Books)SelectBook.SelectedIndex, 
                              SelectChapter.SelectedIndex + 1, 
                              Convert.ToInt32(( sender as Label ).Text));
    }

  }

}
