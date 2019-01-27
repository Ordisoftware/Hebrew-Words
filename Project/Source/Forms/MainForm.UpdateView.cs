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
/// <created> 2019-01 </created>
/// <edited> 2019-01 </edited>
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  public partial class MainForm
  {

    private void AddText(RichTextBox control, Font font, string str)
    {
      control.SelectionFont = font;
      control.SelectedText = str;
    }

    private void AlignRight(RichTextBox control)
    {
      EditRawText.SelectAll();
      EditRawText.SelectionAlignment = HorizontalAlignment.Right;
      EditRawText.SelectionLength = 0;
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
        EditTranslations.SelectedText = str + Environment.NewLine + Environment.NewLine;
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
      AlignRight(EditRawText);
    }

    private void UpdateViewSearch()
    {
      string str1 = EditLetters.Input.Text;
      string str2 = Letters.SetFinale(str1, true);
      EditSearchResults.Clear();
      foreach ( Data.DataSet.BooksRow book in DataSet.Books )
        foreach ( Data.DataSet.ChaptersRow chapter in book.GetChaptersRows() )
          foreach ( Data.DataSet.VersesRow verse in chapter.GetVersesRows() )
            foreach ( Data.DataSet.WordsRow word in verse.GetWordsRows() )
              if ( word.Hebrew.Contains(str1) || word.Hebrew.Contains(str2) )
              {
                string str = "";
                foreach ( Data.DataSet.WordsRow word2 in verse.GetWordsRows() )
                  str = word2.Hebrew + " " + str;
                AddText(EditSearchResults, HebrewFont, str);
                AddText(EditSearchResults, LatinFont, ":" + verse.Number + "." + chapter.Number + "." + book.Name);
                EditSearchResults.AppendText(Environment.NewLine + Environment.NewLine);
                break;
              }
      AlignRight(EditSearchResults);
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
      AlignRight(EditELS50All);
    }

    private void UpdateViewVerses()
    {
      var item = (ChapterItem)SelectChapter.SelectedItem;
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
            control.HebrewMouseClick += HebrewWordMouseClick;
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
