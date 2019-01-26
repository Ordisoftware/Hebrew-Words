/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2016-2019 Olivier Rogier.
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
using System.Drawing;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  public partial class MainForm
  {

    private void UpdateTranslations()
    {
      EditTranslations.Clear();
      var list = ( (ChapterItem)EditChapter.SelectedItem ).Row.GetVersesRows();
      foreach ( Data.DataSet.VersesRow verse in list )
      {
        string str = verse.Number + ". ";
        foreach ( Data.DataSet.WordsRow word in verse.GetWordsRows() )
          str = str + word.Translation + " ";
        str = str.Remove(str.Length - 1, 1);
        EditTranslations.SelectedText = str + Environment.NewLine;
      }
      EditTranslations.SelectionStart = 0;
    }

    private void UpdateViewELS50()
    {
      void add(Font font, string str)
      {
        EditELS50All.SelectionFont = font;
        EditELS50All.SelectedText = str;
      }
      EditELS50All.Clear();
      var list = ( (BookItem)EditBook.SelectedItem ).Row.GetChaptersRows();
      foreach ( Data.DataSet.ChaptersRow chapter in list )
      {
        add(HebrewFont, chapter.ELS50);
        add(LatinFont, " :" + chapter.Number);
        EditELS50All.AppendText(Environment.NewLine);
      }
      EditELS50All.SelectAll();
      EditELS50All.SelectionAlignment = HorizontalAlignment.Right;
      EditELS50All.SelectionLength = 0;
    }

    private void UpdateViewRawText()
    {
      void add(Font font, string str)
      {
        EditRawText.SelectionFont = font;
        EditRawText.SelectedText = str;
      }
      EditRawText.Clear();
      var list = ( (ChapterItem)EditChapter.SelectedItem ).Row.GetVersesRows();
      foreach ( Data.DataSet.VersesRow verse in list )
      {
        string str = "";
        foreach ( Data.DataSet.WordsRow word in verse.GetWordsRows() )
          str = word.Hebrew + " " + str;
        add(HebrewFont, str);
        add(LatinFont, ":" + verse.Number);
        EditRawText.AppendText(Environment.NewLine);
      }
      EditRawText.SelectAll();
      EditRawText.SelectionAlignment = HorizontalAlignment.Right;
      EditRawText.SelectionLength = 0;
    }

    private void UpdateViewVerses()
    {
      var item = (ChapterItem)EditChapter.SelectedItem;
      EditELS50.Text = item.Row.ELS50;
      PanelViewVerses.SuspendLayout();
      try
      {
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
        foreach ( var verse in item.Row.GetVersesRows() )
        {
          var label = new Label();
          label.AutoSize = false;
          label.Width = 40;
          label.Font = new Font("Calibri", 12f, FontStyle.Bold);
          label.Location = new Point(x + dx + 0, y + 5);
          label.Text = verse.Number.ToString();
          PanelViewVerses.Controls.Add(label);
          bool emptyline = false;
          foreach ( var word in verse.GetWordsRows() )
          {
            emptyline = false;
            control = new WordControl();
            control.HebrewClicked += HebrewWordClicked;
            control.Word = word;
            control.Location = new Point(x, y);
            PanelViewVerses.Controls.Add(control);
            x -= dx;
            if ( x < delta )
            {
              x = width - dx - marginX;
              y += dy;
              emptyline = true;
            }
          }
          if ( emptyline ) y -= dy;
          x = width - dx - marginX;
          y = y + dy + marginY;
        }
      }
      finally
      {
        PanelViewVerses.ResumeLayout();
      }
    }

  }

}
