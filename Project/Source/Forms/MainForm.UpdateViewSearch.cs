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

namespace Ordisoftware.HebrewWords
{

  public partial class MainForm
  {

    private void UpdateViewSearch()
    {
      Cursor = Cursors.WaitCursor;
      EditSearchResults.SuspendLayout();
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
            {
              string strTranslation = "";
              foreach ( Data.DataSet.WordsRow word in verse.GetWordsRows() )
                if ( word.Hebrew.Contains(str1) || word.Hebrew.Contains(str2) )
                {
                  foreach ( Data.DataSet.WordsRow w in verse.GetWordsRows().Reverse() )
                  {
                    var color = w.Hebrew.Contains(str1) || w.Hebrew.Contains(str2)
                              ? Color.DarkRed
                              : SystemColors.ControlText;
                    AddTextRightAligned(EditSearchResults, HebrewFont, " ");
                    AddTextRightAligned(EditSearchResults, HebrewFont, w.Hebrew, color);
                    strTranslation = w.Translation + " " + strTranslation;
                  }
                  string strRef = " :" + verse.Number + "." + chapter.Number + "." + book.Name;
                  AddTextRightAligned(EditSearchResults, LatinFont, strRef);
                  EditSearchResults.AppendText(Environment.NewLine);
                  EditSearchResults.AppendText(strTranslation);
                  EditSearchResults.AppendText(Environment.NewLine + Environment.NewLine);
                  break;
                }
            }
        EditSearchResults.SelectionStart = 0;
        EditSearchResults.Focus();
      }
      finally
      {
        EditSearchResults.ResumeLayout();
        Cursor = Cursors.Default;
      }
    }

  }

}