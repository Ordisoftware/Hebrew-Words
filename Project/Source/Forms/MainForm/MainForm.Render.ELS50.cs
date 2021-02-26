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
/// <edited> 2019-09 </edited>
using System;

namespace Ordisoftware.Hebrew.Words
{

  public partial class MainForm
  {

    public void RenderELS50()
    {
      EditELS50All.Clear();
      var list = CurrentReference.Book.GetChaptersRows();
      foreach ( Data.DataSet.ChaptersRow chapter in list )
      {
        AddTextRightAligned(EditELS50All, HebrewFont12, chapter.ELS50);
        AddTextRightAligned(EditELS50All, LatinFont10, " :" + chapter.Number);
        EditELS50All.AppendText(Environment.NewLine);
      }
      EditELS50All.SelectionStart = 0;
      EditELS50All.Focus();
    }

  }

}
