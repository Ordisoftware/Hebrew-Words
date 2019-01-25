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

    private void UpdateVerses()
    {
      var item = (ChapterItem)EditChapter.SelectedItem;
      EditELS50.Text = item.Row.ELS50;
      PanelViewVerses.SuspendLayout();
      try
      {
        PanelViewVerses.Controls.Clear();
        var control = new WordControl();
        int width = Width - 50;
        int dx = control.Width;
        int dy = control.Height;
        int marginX = 50 + 10;
        int marginY = 50;
        int x = width - dx - marginX;
        int y = 10;
        foreach ( var verse in item.Row.GetVersesRows() )
        {
          var label = new Label();
          label.AutoSize = false;
          label.Width = 40;
          label.Font = new Font("Calibri", 12f, FontStyle.Bold);
          label.Location = new Point(x + dx + 0, y);
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
            if ( x < 10 )
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
