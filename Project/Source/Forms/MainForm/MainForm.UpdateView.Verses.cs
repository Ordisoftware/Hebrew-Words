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
      if ( RenderInProcess ) return;
      RenderInProcess = true;
      try
      {
        PanelViewVerses.SuspendLayout();
        PanelViewVerses.AutoScrollPosition = new Point(0, 0);
        PanelViewVerses.Visible = false;
        SetFormDisabled(true);
        PanelViewVerses.AutoScrollPosition = new Point(0, 0);
        PanelViewVerses.Controls.Clear();
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
        var wordcontrol = new WordControl();
        wordcontrol.Width = Program.Settings.WordControlWidth;
        int mX = 50;
        int mY = 50;
        int delta = 10;
        int width = ClientSize.Width - mX;
        int dx = wordcontrol.Width + delta;
        int dy = wordcontrol.Height + delta;
        int marginX = mX;
        int marginY = mY;
        int x = width - dx - marginX;
        int y = delta;
        int minx = x;
        int wordsCount = ( width - marginX ) / dx;
        int wordsWidth = wordsCount * dx;
        int widthWord = Program.Settings.WordControlWidth;
        int verseLineCount = Program.Settings.VerseCommentaryLinesCount;
        int textHeight;
        var textboxTemp = new TextBox();
        using ( Graphics g = textboxTemp.CreateGraphics() )
        {
          textHeight = TextRenderer.MeasureText(g, "Text", textboxTemp.Font).Height;
        }
        Label label;
        TextBox editComment;
        int indexControl = 0;
        int capacity = references.Count() * 2 + references.Select(r => r.Verse.GetWordsRows().Count()).Sum();
        Control[] controls = new Control[capacity];
        int dx_delta = dx + delta;
        int deltaDIV4 = delta / 4;
        int minx_dx_delta = minx + dx + delta;
        int dx_marginX = dx + marginX;
        int heightComment = textHeight * ( verseLineCount + 1 ) - 3;
        int dy_marginY_commentHeight = dy + marginY + heightComment;
        foreach ( var reference in references )
        {
          label = new Label();
          label.Tag = reference;
          label.Location = new Point(x + dx_delta, y + deltaDIV4);
          label.AutoSize = false;
          label.Width = 40;
          label.ForeColor = Color.DarkBlue;
          label.Font = VerseNumberFont;
          label.Text = reference.Verse.Number.ToString();
          label.MouseEnter += LabelVerseNumber_MouseEnter;
          label.MouseLeave += LabelVerseNumber_MouseLeave;
          label.MouseClick += LabelVerseNumber_MouseClick;
          label.ContextMenuStrip = ContextMenuStripVerse;
          controls[indexControl++] = label;
          bool emptyline = false;
          foreach ( var word in reference.Verse.GetWordsRows() )
          {
            emptyline = false;
            wordcontrol = new WordControl(reference);
            wordcontrol.Word = word;
            wordcontrol.Width = widthWord;
            wordcontrol.Location = new Point(x, y);
            controls[indexControl++] = wordcontrol;
            x -= dx;
            if ( x < delta )
            {
              if ( x < minx_dx_delta ) minx = x;
              x = width - dx_marginX;
              y += dy;
              emptyline = true;
            }
          }
          if ( emptyline ) y -= dy;
          editComment = new TextBox();
          label.Tag = editComment;
          if ( verseLineCount > 1 )
          {
            editComment.Multiline = true;
            editComment.WordWrap = true;
            editComment.ScrollBars = ScrollBars.Vertical;
          }
          int dy_delta = dy + delta;
          editComment.Location = new Point(width - wordsWidth - label.Width - delta, y + dy_delta);
          int dx_MarginX_2 = dx + marginX + 2;
          x = width - dx_MarginX_2;
          editComment.Width = wordsWidth - delta;
          editComment.Height = heightComment;
          editComment.Tag = reference;
          editComment.BackColor = Color.Honeydew;
          editComment.Text = reference.Verse.Comment;
          editComment.TextChanged += EditVerseComment_TextChanged;
          editComment.KeyDown += EditVerseComment_KeyDown;
          editComment.Enter += EditVerseComment_Enter;
          editComment.Leave += EditVerseComment_Leave;
          controls[indexControl++] = editComment;
          y = y + dy_marginY_commentHeight;
        }
        PanelViewVerses.Controls.AddRange(controls);
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
      finally
      {
        RenderInProcess = false;
        SetFormDisabled(false);
        PanelViewVerses.Visible = true;
        PanelViewVerses.ResumeLayout();
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
      var control = (Control)sender;
      ( (ReferenceItem)control.Tag ).Verse.Comment = control.Text;
      ActionSave.Enabled = true;
    }

    private void EditVerseComment_Enter(object sender, EventArgs e)
    {
      var control = (Control)sender;
      control.BackColor = Color.AliceBlue;
      if ( ComboBoxMutex ) return;
      CurrentReference = new ReferenceItem((ReferenceItem)( (Control)sender ).Tag);
      AddCurrentToHistory();
    }

    private void EditVerseComment_Leave(object sender, EventArgs e)
    {
      var control = (Control)sender;
      control.BackColor = Color.Honeydew;
    }

    private void LabelVerseNumber_MouseEnter(object sender, EventArgs e)
    {
      var control = (Control)sender;
      control.Cursor = Cursors.Hand;
      control.ForeColor = Color.SteelBlue;
    }

    private void LabelVerseNumber_MouseLeave(object sender, EventArgs e)
    {
      var control = (Control)sender;
      control.Cursor = Cursors.Default;
      control.ForeColor = Color.DarkBlue;
    }

    private void LabelVerseNumber_MouseClick(object sender, MouseEventArgs e)
    {
      if ( e.Button != MouseButtons.Left ) return;
      Program.OpenOnlineVerse(Program.Settings.OpenVerseOnlineURL,
                              SelectBook.SelectedIndex + 1,
                              SelectChapter.SelectedIndex + 1,
                              Convert.ToInt32(( (Label)sender ).Text));
    }

  }

}
