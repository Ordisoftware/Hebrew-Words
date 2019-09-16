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
using Ordisoftware.Core;

namespace Ordisoftware.HebrewWords
{

  public partial class MainForm
  {

    private void UpdateViewVerses()
    {
      CurrentReference.Verse = null;
      var itemBook = CurrentReference.Book;
      var itemChapter = CurrentReference.Chapter;
      EditELS50.Text = itemChapter.ELS50;
      EditELS50.SelectionStart = EditELS50.TextLength;
      var references = from book in DataSet.Books
                       from chapter in book.GetChaptersRows()
                       from verse in chapter.GetVersesRows()
                       where book.Number == itemBook.Number 
                          && chapter.Number == itemChapter.Number
                       select new ReferenceItem(book, chapter, verse);
      SetFormDisabled(true);
      PanelViewVerses.SuspendLayout();
      try
      {
        if ( PanelViewVerses.Controls.Count > 0 )
          PanelViewVerses.ScrollControlIntoView(PanelViewVerses.Controls[0]);
        PanelViewVerses.Controls.Clear();
        PanelViewVerses.AutoScrollPosition = new Point(0, 0);
        PanelViewVerses.Refresh();
        var control = new WordControl();
        control.Width = Program.Settings.WordControlWidth;
        int mX = 50;
        int mY = 50;
        int delta = 10;
        int width = ClientSize.Width - mX;
        int dx = control.Width + delta;
        int dy = control.Height + delta;
        int marginX = mX;
        int marginY = mY;
        int x = width - dx - marginX;
        int y = delta;
        int minx = x;
        int wordsCount = ( width - marginX ) / dx;
        int wordsWidth = wordsCount * dx;
        int textHeight;
        var textboxTemp = new TextBox();
        using ( Graphics g = textboxTemp.CreateGraphics() )
        {
          textHeight = TextRenderer.MeasureText(g, "Text", textboxTemp.Font).Height;
        }
        foreach ( var reference in references )
        {
          var label = new Label();
          label.Tag = reference;
          label.Location = new Point(x + dx + delta, y + delta / 4);
          label.AutoSize = false;
          label.Width = 40;
          label.ForeColor = Color.DarkBlue;
          label.Font = VerseNumberFont;
          label.Text = reference.Verse.Number.ToString();
          label.MouseEnter += LabelVerseNumber_MouseEnter;
          label.MouseLeave += LabelVerseNumber_MouseLeave;
          label.MouseClick += LabelVerseNumber_MouseClick;
          label.ContextMenuStrip = ContextMenuStripVerse;
          PanelViewVerses.Controls.Add(label);
          bool emptyline = false;
          foreach ( var word in reference.Verse.GetWordsRows() )
          {
            emptyline = false;
            control = new WordControl(reference);
            control.Word = word;
            control.Location = new Point(x, y);
            control.Width = Program.Settings.WordControlWidth;
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
          if ( Program.Settings.VerseCommentaryLinesCount > 1 )
          {
            editComment.Multiline = true;
            editComment.WordWrap = true;
            editComment.ScrollBars = ScrollBars.Vertical;
          }
          editComment.Location = new Point(width - wordsWidth - label.Width - delta, y + dy + delta);
          x = width - dx - marginX - 2;
          editComment.Width = wordsWidth - delta;
          editComment.Height = textHeight * ( Program.Settings.VerseCommentaryLinesCount + 1 ) - 3;
          editComment.Tag = reference;
          editComment.BackColor = Color.Honeydew;
          editComment.Text = reference.Verse.Comment;
          editComment.TextChanged += EditVerseComment_TextChanged;
          editComment.KeyDown += EditVerseComment_KeyDown;
          editComment.Enter += (sender, e) => 
          {
            if ( ComboBoxMutex ) return;
            CurrentReference = new ReferenceItem((ReferenceItem)((Control)sender).Tag);
            AddCurrentToHistory();
          };
          PanelViewVerses.Controls.Add(editComment);
          y = y + dy + marginY + editComment.Height;
        }
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
      finally
      {
        PanelViewVerses.ResumeLayout();
        SetFormDisabled(false);
      }
    }

    private void EditVerseComment_KeyDown(object sender, KeyEventArgs e)
    {
      var textbox = (TextBox)sender;
      var index = ( (Panel)textbox.Parent ).Controls.IndexOf(textbox) - 1;
      var control = (WordControl)( (Panel)textbox.Parent ).Controls[index];
      control.Focus();
      textbox.Focus();
    }

    private void EditVerseComment_TextChanged(object sender, EventArgs e)
    {
      if ( IsLoadingData ) return;
      var textbox = (TextBox)sender;
      ( (ReferenceItem)textbox.Tag ).Verse.Comment = textbox.Text;
      ActionSave.Enabled = true;
    }

    private void LabelVerseNumber_MouseEnter(object sender, EventArgs e)
    {
      var label = (Label)sender;
      label.Cursor = Cursors.Hand;
      label.ForeColor = Color.SteelBlue;
    }

    private void LabelVerseNumber_MouseLeave(object sender, EventArgs e)
    {
      var label = (Label)sender;
      label.Cursor = Cursors.Default;
      label.ForeColor = Color.DarkBlue;
    }

    private void LabelVerseNumber_MouseClick(object sender, MouseEventArgs e)
    {
      if ( e.Button == MouseButtons.Left )
        ActionOpenVerseOnline_Click(sender, null);
    }

  }

}
