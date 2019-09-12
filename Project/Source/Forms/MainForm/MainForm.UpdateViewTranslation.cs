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
/// <edited> 2019-09 </edited>
using System;
using Ordisoftware.HebrewWords.Data;

namespace Ordisoftware.HebrewWords
{

  public partial class MainForm
  {

    private void UpdateViewTranslations()
    {
      EditTranslations.Clear();
      var list = ( (ChapterItem)SelectChapter.SelectedItem ).Chapter.GetVersesRows();
      foreach ( DataSet.VersesRow verse in list )
      {
        string str = verse.Number + ". ";
        EditTranslations.SelectedText = str + verse.GetTranslation();
        if ( verse.Comment != "" )
        {
          EditTranslations.SelectedText = Environment.NewLine + Environment.NewLine;
          EditTranslations.SelectedText = verse.Comment;
        }
        EditTranslations.SelectedText = Environment.NewLine + Environment.NewLine;
      }
      EditTranslations.SelectionStart = 0;
      EditTranslations.Focus();
    }

  }

}
