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
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using Ordisoftware.Core;

namespace Ordisoftware.HebrewWords
{

  public partial class MainForm
  {

    static private string SearchWord1;
    static private string SearchWord2;

    private IEnumerable<ReferenceItem> SearchResults;
    static public int SearchResultsCount { get; private set; }

    private bool CheckSearchedWord(string str)
    {
      return str.Contains(SearchWord1) || str.Contains(SearchWord2);
    }

    private void UpdateViewSearch()
    {
      SetFormDisabled(true);
      try
      {
        SearchResults = null;
        PanelSearchResults.Controls.Clear();
        SearchWord1 = EditLetters.Input.Text;
        if ( SearchWord1 == "" ) return;
        if ( SearchWord1.Length < 2 ) return;
        SearchWord2 = Letters.SetFinale(SearchWord1, true);
        int limit = EditSearchOnlyTorah.Checked ? 5 : DataSet.Books.Count();
        SearchResults = from book in DataSet.Books
                        from chapter in book.GetChaptersRows()
                        from verse in chapter.GetVersesRows()
                        from word in verse.GetWordsRows()
                        where book.Number <= limit && CheckSearchedWord(word.Hebrew)
                        select new ReferenceItem(book, chapter, verse);
        SearchResults = SearchResults.Distinct(new ReferenceItemComparer());
        SearchResultsCount = SearchResults.Count();
        if ( SearchResultsCount > Program.Settings.MinimalFoundToOpenDialog )
          SearchResults = SelectSearchResultsForm.Run(SearchResults);
        RenderSearchResults();
      }
      finally
      {
        SetFormDisabled(false);
      }
    }

    private void RenderSearchResults()
    {
      if ( InProcess ) return;
      InProcess = true;
      SetFormDisabled(true);
      PanelSearchResults.SuspendLayout();
      try
      {
        PanelSearchResults.Controls.Clear();
        PanelSearchResults.Refresh();
        PanelViewVerses.AutoScrollPosition = new Point(0, 0);
        GC.Collect();
        LabelFindRefCount.Text = "0";
        if ( SearchResults == null ) return;
        int index = 0;
        int indexDelta = 0;
        int indexDeltaMax = 10;
        int referenceSize = 160;
        int marginX = 10;
        int marginY = 10;
        int minX = marginX;
        int maxX = PanelSearchResults.ClientSize.Width - marginX;
        int x = 0;
        int y = 0;
        int xx;
        foreach ( var reference in SearchResults )
        {
          Application.DoEvents();
          if ( CancelRequired ) { CancelRequired = false; break; }
          ++index;
          ++indexDelta;
          if ( indexDelta >= indexDeltaMax )
          {
            indexDelta = 0;
            LabelFindRefCount.Text = index + "/" + SearchResultsCount;
            LabelFindRefCount.Refresh();
          }
          x = maxX;
          y += marginY;
          var linklabel = new LinkLabel();
          linklabel.AutoSize = true;
          linklabel.Tag = reference;
          linklabel.Text = reference.ToString();
          linklabel.Font = LatinFont8;
          linklabel.LinkColor = Color.DarkBlue;
          linklabel.LinkClicked += (sender, e) => 
          {
            SetView(ViewModeType.Verses);
            GoTo((ReferenceItem)( (Control)sender ).Tag);
          };
          linklabel.Location = new Point(x = x - referenceSize, y);
          PanelSearchResults.Controls.Add(linklabel);
          x -= marginX;
          xx = x;
          Label label = null;
          foreach ( Data.DataSet.WordsRow word in reference.Verse.GetWordsRows() )
          {
            label = new Label();
            label.Text = word.Hebrew;
            label.AutoSize = true;
            label.Font = HebrewFont12;
            label.ForeColor = CheckSearchedWord(word.Hebrew)
                            ? Color.DarkRed
                            : SystemColors.ControlText;
            x -= label.PreferredSize.Width;
            if ( x < minX )
            {
              x = xx - label.PreferredWidth;
              y += label.PreferredHeight;
            }
            label.Location = new Point(x, y);
            PanelSearchResults.Controls.Add(label);
          }
          y += label.PreferredHeight + marginY;
          string translation = reference.Translation;
          if ( translation != "" )
          {
            label = new Label();
            label.AutoSize = true;
            label.MaximumSize = new Size(xx - marginX, label.MaximumSize.Height);
            label.Text = translation;
            label.Location = new Point(xx - label.PreferredSize.Width, y);
            PanelSearchResults.Controls.Add(label);
            y += label.PreferredHeight + marginY;
          }
          if ( index >= Program.Settings.MaxRefCount ) break;
        }
        LabelFindRefCount.Text = index.ToString();
      }
      catch ( Exception ex )
      {
        DisplayManager.ShowError(ex.Message);
      }
      finally
      {
        InProcess = false;
        SetFormDisabled(false);
        PanelSearchResults.ResumeLayout();
        PanelSearchResults.Focus();
      }
    }

  }

}
