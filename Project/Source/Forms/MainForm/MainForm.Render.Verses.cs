/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2021 Olivier Rogier.
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
/// <edited> 2021-04 </edited>
namespace Ordisoftware.Hebrew.Words;

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Ordisoftware.Core;

partial class MainForm
{

  private void RenderVerses()
  {
    if ( IsRenderingSearch ) return;
    IsRenderingSearch = true;
    try
    {
      PanelViewVerses.AutoScrollPosition = new Point(0, 0);
      //PanelViewVerses.Visible = false;
      SetFormDisabled(true);
      PanelViewVerses.AutoScrollPosition = new Point(0, 0);
      while ( PanelViewVerses.Controls.Count > 1 )
        PanelViewVerses.Controls[1].Dispose();
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
      var wordcontrol = new WordControl { Width = Program.Settings.WordControlWidth };
      const int widthLabel = 40;
      const int mX = 50;
      const int mY = 50;
      const int delta = 10;
      int width = ClientSize.Width - mX;
      int dx = wordcontrol.Width + delta;
      int dy = wordcontrol.Height + delta;
      const int marginX = mX;
      const int marginY = mY;
      int x = width - dx - marginX;
      int y = delta;
      int minx = x;
      int wordsCount = ( width - marginX ) / dx;
      int widthWords = wordsCount * dx;
      int widthWord = Program.Settings.WordControlWidth;
      int verseLineCount = Program.Settings.VerseCommentaryLinesCount;
      int textHeight;
      var textboxTemp = new TextBoxEx();
      using ( Graphics g = textboxTemp.CreateGraphics() )
      {
        textHeight = TextRenderer.MeasureText(g, "Text", textboxTemp.Font).Height;
      }
      Label label;
      TextBoxEx editComment;
      int indexControl = 0;
      int capacity = references.Count() * 2 + references.Select(r => r.Verse.GetWordsRows().Length).Sum();
      Control[] controls = new Control[capacity];
      const int deltaDIV4 = delta / 4;
      int dx_delta = dx + delta;
      int dy_delta = dy + delta;
      int dx_marginX = dx + marginX;
      int dx_MarginX_2 = dx + marginX + 2;
      int minx_dx_delta = minx + dx + delta;
      int heightComment = textHeight * ( verseLineCount + 1 ) - 3;
      int dy_marginY_commentHeight = dy + marginY + heightComment;
      int widthWords_widthLabel_delta = widthWords + widthLabel + delta;
      foreach ( var reference in references )
      {
        label = new Label
        {
          Tag = reference,
          Location = new Point(x + dx_delta, y + deltaDIV4),
          AutoSize = false,
          Width = widthLabel,
          ForeColor = Color.DarkBlue,
          Font = VerseNumberFont,
          Text = reference.Verse.Number.ToString(),
          ContextMenuStrip = ContextMenuStripVerse
        };
        label.MouseEnter += LabelVerseNumber_MouseEnter;
        label.MouseLeave += LabelVerseNumber_MouseLeave;
        label.MouseDown += LabelVerseNumber_MouseDown;
        label.MouseClick += LabelVerseNumber_MouseClick;
        controls[indexControl++] = label;
        bool emptyline = false;
        foreach ( var word in reference.Verse.GetWordsRows() )
        {
          emptyline = false;
          wordcontrol = new WordControl(new ReferenceItem(reference, word));
          wordcontrol.LabelHebrew.ContextMenuStrip = ContextMenuStripWord;
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
        editComment = new TextBoxEx();
        label.Tag = editComment;
        if ( verseLineCount > 1 )
        {
          editComment.Multiline = true;
          editComment.WordWrap = true;
          editComment.ScrollBars = ScrollBars.Vertical;
        }
        editComment.Location = new Point(width - widthWords_widthLabel_delta, y + dy_delta);
        x = width - dx_MarginX_2;
        editComment.Width = widthWords - delta;
        editComment.Height = heightComment;
        editComment.Tag = reference;
        editComment.BackColor = Color.Honeydew;
        editComment.Text = reference.Verse.Comment;
        editComment.TextChanged += EditVerseComment_TextChanged;
        editComment.KeyDown += EditVerseComment_KeyDown;
        editComment.Enter += EditVerseComment_Enter;
        editComment.Leave += EditVerseComment_Leave;
        controls[indexControl++] = editComment;
        y += dy_marginY_commentHeight;
      }
      PanelViewVerses.Controls.AddRange(controls);
    }
    catch ( Exception ex )
    {
      ex.Manage();
    }
    finally
    {
      IsRenderingSearch = false;
      SetFormDisabled(false);
      PanelViewVerses.Visible = true;
    }
  }

  private void EditVerseComment_KeyDown(object sender, KeyEventArgs e)
  {
    //var control = (Control)sender;
    //var index = ( (Panel)control.Parent ).Controls.IndexOf(control) - 1;
    //var wordcontrol = (WordControl)( (Panel)control.Parent ).Controls[index];
    //wordcontrol.Focus();
  }

  private void EditVerseComment_TextChanged(object sender, EventArgs e)
  {
    if ( Globals.IsLoadingData ) return;
    var control = (Control)sender;
    ( (ReferenceItem)control.Tag ).Verse.Comment = control.Text;
    ActionSave.Enabled = true;
  }

  private void EditVerseComment_Enter(object sender, EventArgs e)
  {
    var control = (Control)sender;
    control.BackColor = Color.AliceBlue;
    if ( IsComboBoxChanging ) return;
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

  private void LabelVerseNumber_MouseDown(object sender, EventArgs e)
  {
    if ( PanelViewVerses.Controls[PanelViewVerses.Controls.IndexOf((Control)sender) + 1] is WordControl control )
      control.Focus();
  }

  private void LabelVerseNumber_MouseClick(object sender, MouseEventArgs e)
  {
    if ( e.Button != MouseButtons.Left ) return;
    var control = PanelViewVerses.Controls[PanelViewVerses.Controls.IndexOf((Control)sender) + 1] as WordControl;
    //if ( control != null ) control.Focus();
    HebrewTools.OpenBibleProvider(Program.Settings.OpenVerseOnlineURL,
                                  control.Reference.Book.Number,
                                  control.Reference.Chapter.Number,
                                  control.Reference.Verse.Number);
    /*HebrewTools.OpenOnlineVerse(Program.Settings.OpenVerseOnlineURL,
                                control.Reference.Book.Number,
                                CurrentReference.Chapter.Number,
                                Convert.ToInt32(( (Label)sender ).Text));*/
  }

}
