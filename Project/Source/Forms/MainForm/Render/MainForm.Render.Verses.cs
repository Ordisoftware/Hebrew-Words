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
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class MainForm
{

  private void RenderVerses()
  {
    if ( IsRendering ) return;
    IsRendering = true;
    Globals.ChronoRendering.Restart();
    try
    {
      if ( SelectRenderAllVerses.Checked ) PanelViewVerses.Visible = false;
      while ( PanelViewVerses.Controls.Count > 0 )
        PanelViewVerses.Controls[0].Dispose();
      if ( SelectRenderAllVerses.Checked ) SetFormDisabled(true);
      var itemBook = CurrentReference.Book;
      var itemChapter = CurrentReference.Chapter;
      if ( itemBook == null || itemChapter == null ) return;
      EditELS50.Text = itemChapter.ELS50;
      EditELS50.SelectionStart = EditELS50.TextLength;
      var references = SelectRenderAllVerses.Checked
                       ? from book in ApplicationDatabase.Instance.Books
                         from chapter in book.Chapters
                         from verse in chapter.Verses
                         where book.Number == itemBook.Number
                            && chapter.Number == itemChapter.Number
                         select new ReferenceItem(book, chapter, verse)
                       : new List<ReferenceItem> { CurrentReference };
      var wordcontrol = new WordControl { Width = Program.Settings.WordControlWidth };
      const int widthLabel = 40;
      const int mX = 50;
      const int mY = 50;
      const int delta = 10;
      const int deltaMul2 = delta * 2;
      const int deltaDiv4 = delta / 4;
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
      Panel panel;
      Label label;
      TextBoxEx editComment;
      int dx_delta = dx + delta;
      int dy_delta = dy + delta;
      int dx_marginX = dx + marginX;
      int dx_MarginX_2 = dx + marginX + 2;
      int minx_dx_delta = minx + dx + delta;
      int heightComment = textHeight * ( verseLineCount + 1 ) - 3;
      int dy_marginY_commentHeight = dy + marginY + heightComment;
      int widthWords_widthLabel_delta = widthWords + widthLabel + delta;
      int yPanel = 0;
      int controlsCount = references.Count() * 2 + references.Select(r => r.Verse.Words.Count).Sum();
      foreach ( var reference in references )
      {
        y = deltaMul2;
        panel = new Panel();
        label = new Label
        {
          Location = new Point(x + dx_delta, y + deltaDiv4),
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
        panel.Controls.Add(label);
        bool emptyline = false;
        foreach ( var word in reference.Verse.Words )
        {
          emptyline = false;
          wordcontrol = new WordControl(new ReferenceItem(reference, word));
          wordcontrol.LabelHebrew.ContextMenuStrip = ContextMenuStripWord;
          wordcontrol.Width = widthWord;
          wordcontrol.Location = new Point(x, y);
          panel.Controls.Add(wordcontrol);
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
        editComment.Tag = reference;  // TODO reorg Tags using panel to get ref
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
        editComment.BackColor = Color.Honeydew;
        editComment.Text = reference.Verse.Comment;
        editComment.Enter += EditVerseComment_Enter;
        editComment.Leave += EditVerseComment_Leave;
        editComment.DataBindings.Add("Text", reference.Verse, "Comment", false, DataSourceUpdateMode.OnPropertyChanged);
        panel.Controls.Add(editComment);
        y += dy_marginY_commentHeight;
        panel.Location = new Point(0, yPanel);
        panel.Width = PanelViewVerses.ClientSize.Width - deltaMul2;
        panel.Height = y;
        yPanel += y;
        PanelViewVerses.Controls.Add(panel);
        if ( SelectRenderAllVerses.Checked )
          LabelProgress.Text = AppTranslations.Rendering.GetLang(controlsCount, CurrentReference.Chapter.Verses.Count);
      }
    }
    catch ( Exception ex )
    {
      ex.Manage();
    }
    finally
    {
      if ( SelectRenderAllVerses.Checked )
        LabelProgress.Refresh();
      IsRendering = false;
      if ( SelectRenderAllVerses.Checked )
      {
        PanelViewVerses.Visible = true;
        LabelProgress.Text = "";
        SetFormDisabled(false);
      }
      Globals.ChronoRendering.Stop();
      Settings.BenchmarkRendering = Globals.ChronoRendering.ElapsedMilliseconds;
    }
  }

  private void EditVerseComment_Enter(object sender, EventArgs e)
  {
    var control = (Control)sender;
    control.BackColor = Color.AliceBlue;
    if ( IsComboBoxChanging ) return;
    CurrentReference = new ReferenceItem((ReferenceItem)( (Control)sender ).Tag);
    MoveVerseBindingSourceAndAddCurrentToHistory();
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
    if ( sender is Label label && label.Parent.Controls[1] is WordControl control )
      control.Focus();
  }

  private void LabelVerseNumber_MouseClick(object sender, MouseEventArgs e)
  {
    if ( e.Button != MouseButtons.Left ) return;
    if ( sender is Label label && label.Parent.Controls[1] is WordControl control )
      HebrewTools.OpenBibleProvider(Program.Settings.OpenVerseOnlineURL,
                                    control.Reference.Book.Number,
                                    control.Reference.Chapter.Number,
                                    control.Reference.Verse.Number);
  }

}
