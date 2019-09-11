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

    private void UpdateViewSearch()
    {
      Cursor = Cursors.WaitCursor;
      EditSearchResults.SuspendLayout();
      try
      {
        EditSearchResults.Clear();
        LabelFindRefCount.Text = "0";
        string str1 = EditLetters.Input.Text;
        if ( str1 == "" ) return;
        if ( str1.Length < 2 ) return;
        string str2 = Letters.SetFinale(str1, true);
        int limit = EditSearchOnlyTorah.Checked ? 5 : DataSet.Books.Count();
        var query = from book in DataSet.Books
                    from chapter in book.GetChaptersRows()
                    from verse in chapter.GetVersesRows()
                    from word in verse.GetWordsRows()
                    where book.Number <= limit
                       && ( word.Hebrew.Contains(str1) || word.Hebrew.Contains(str2) )
                    orderby book.Number, chapter.Number, verse.Number
                    select new ReferenceItem
                    {
                      Book = book,
                      Chapter = chapter,
                      Verse = verse
                    };
        var list = query.Distinct(new ReferenceItemComparer());
        int count = list.Count();
        if ( count > 500 )
          if ( !DisplayManager.QueryYesNo(Localizer.SearchResultsText.GetLang(count.ToString())) )
            return;
        LabelFindRefCount.Text = count.ToString();

        foreach ( var item in list )
        {
          string strTranslation = "";
          foreach ( Data.DataSet.WordsRow w in item.Verse.GetWordsRows().Reverse() )
          {
            var color = w.Hebrew.Contains(str1) || w.Hebrew.Contains(str2)
                      ? Color.DarkRed
                      : SystemColors.ControlText;
            AddTextRightAligned(EditSearchResults, HebrewFont, " ");
            AddTextRightAligned(EditSearchResults, HebrewFont, w.Hebrew, color);
            strTranslation = w.Translation + " " + strTranslation;
          }
          string strRef = " :" + item.Verse.Number + "." + item.Chapter.Number + "." + item.Book.Name;
          AddTextRightAligned(EditSearchResults, LatinFont, strRef);
          EditSearchResults.AppendText(Environment.NewLine);
          EditSearchResults.AppendText(strTranslation.Trim());
          EditSearchResults.AppendText(Environment.NewLine + Environment.NewLine);
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
