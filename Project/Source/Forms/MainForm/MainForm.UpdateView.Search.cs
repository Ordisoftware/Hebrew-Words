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
using Ordisoftware.HebrewWords.Data;

namespace Ordisoftware.HebrewWords
{

  public partial class MainForm
  {

    private int PagingWaiter = 50;
    private int PagingCurrent = 0;
    private int PagingCount = 0;

    private IEnumerable<ReferenceItem> SearchResults;

    internal int SearchResultsCount { get; private set; }

    private Func<DataSet.WordsRow, bool> CheckWord;
    private Func<DataSet.VersesRow, bool> CheckVerse;

    private string SearchWord1;
    private string SearchWord2;

    private void UpdateSearchButtons()
    {
      ActionNavigateFirst.Enabled = PagingCurrent != 0;
      ActionNavigatePrevious.Enabled = PagingCurrent > 0;
      ActionNavigateNext.Enabled = PagingCurrent < PagingCount - 1;
      ActionNavigateLast.Enabled = PagingCurrent != PagingCount - 1;
      EditSearchPaging.Enabled = SearchResultsCount > 0;
    }

    private void CreateSearchResults()
    {
      SearchResults = null;
      SearchResultsCount = 0;
      CheckWord = null;
      CheckVerse = null;
      SearchWord1 = "";
      SearchWord2 = "";
      int limit = EditSearchOnlyTorah.Checked ? 5 : DataSet.Books.Count();
      Func<DataSet.WordsRow, bool> checkWordHebrew = row =>
      {
        return row.Hebrew.Contains(SearchWord1) || row.Hebrew.Contains(SearchWord2);
      };
      Func<DataSet.WordsRow, bool> checkWordTranslation = row =>
      {
        var str = row.Translation.ToLower().RemoveDiacritics();
        if ( !SearchWord1.Contains(",") )
          return str.Contains(SearchWord1);
        else
        {
          var list = SearchWord1.Split(',');
          foreach ( string item in list )
          {
            var exp = item.Trim();
            if ( exp.Length >= 2 )
              if ( str.Contains(exp) )
                return true;
          }
          return false;
        }
      };
      Func<DataSet.VersesRow, bool> checkTranslatedAll = verse =>
      {
        return verse.IsTranslated();
      };
      Func<DataSet.VersesRow, bool> checkTranslatedAllFully = verse =>
      {
        return verse.IsFullyTranslated();
      };
      Func<DataSet.VersesRow, bool> checkTranslatedAllPartially = verse =>
      {
        return verse.IsPartiallyTranslated();
      };
      Func<DataSet.VersesRow, bool> checkTranslatedAllUntranslated = verse =>
      {
        return verse.IsUntranslated();
      };
      if ( SelectSearchType.SelectedTab == SelectSearchTypeHebrew )
      {
        SearchWord1 = EditLetters.Input.Text;
        SearchWord2 = Letters.SetFinale(SearchWord1, true);
        CheckWord = checkWordHebrew;
      }
      if ( SelectSearchType.SelectedTab == SelectSearchTypeTranslation )
      {
        SearchWord1 = EditSearchTranslation.Text.ToLower().RemoveDiacritics();
        CheckWord = checkWordTranslation;
      }
      if ( SelectSearchType.SelectedTab == SelectSearchTypeRequest )
      {
        if ( SelectSearchRequestAllTranslated.Checked )
          CheckVerse = checkTranslatedAll;
        if ( SelectSearchRequestAllFullyTranslated.Checked )
          CheckVerse = checkTranslatedAllFully;
        if ( SelectSearchRequestAllPartiallyTranslated.Checked )
          CheckVerse = checkTranslatedAllPartially;
        if ( SelectSearchRequestAllUntranslated.Checked )
          CheckVerse = checkTranslatedAllUntranslated;
      }
      if ( SearchWord1 != "" && SearchWord1.Length >= 2 && CheckVerse == null)
      {
        SearchResults = from book in DataSet.Books
                        from chapter in book.GetChaptersRows()
                        from verse in chapter.GetVersesRows()
                        from word in verse.GetWordsRows()
                        where book.Number <= limit && CheckWord(word)
                        select new ReferenceItem(book, chapter, verse);
      }
      else
      if ( CheckVerse != null )
      {
        SearchResults = from book in DataSet.Books
                        from chapter in book.GetChaptersRows()
                        from verse in chapter.GetVersesRows()
                        where book.Number <= limit && CheckVerse(verse)
                        select new ReferenceItem(book, chapter, verse);
      }
      if ( SearchResults != null )
      {
        SearchResults = SearchResults.Distinct(new ReferenceItemComparer());
        Cursor = Cursors.WaitCursor;
        try
        {
          SearchResultsCount = SearchResults.Count();
        }
        finally
        {
          Cursor = Cursors.Default;
        }
        if ( SearchResultsCount > Program.Settings.FoundReferencesToOpenDialog )
        {
          SearchResults = SelectSearchResultsForm.Run(SearchResults);
          if ( SearchResults != null )
            try
            {
              Cursor = Cursors.WaitCursor;
              SearchResultsCount = SearchResults.Count();
            }
            finally
            {
              Cursor = Cursors.Default;
            }
        }
      }
      PagingCurrent = 0;
      RenderSearchResults();
    }

    private void RenderSearchResults()
    {
      if ( InProcess ) return;
      PanelSearchResults.Controls.Clear();
      PanelSearchResults.AutoScrollPosition = new Point(0, 0);
      PanelSearchResults.Refresh();
      GC.Collect();
      EditSearchPaging.Text = "0";
      TrackBarSearchPaging.Maximum = 1;
      TrackBarSearchPaging.Enabled = false;
      if ( SearchResults == null || SearchResultsCount == 0 ) return;
      InProcess = true;
      if ( Program.Settings.FoundReferencesViewable > PagingWaiter ) SetFormDisabled(true);
      PanelSearchResults.SuspendLayout();
      try
      {
        int modulo = SearchResultsCount % Program.Settings.FoundReferencesViewable;
        PagingCount = (int)Math.Round((double)SearchResultsCount / Program.Settings.FoundReferencesViewable,
                                      MidpointRounding.ToEven);
        if ( modulo > 0 ) PagingCount++;
        TrackBarSearchPaging.Enabled = true;
        TrackBarSearchPaging.Maximum = PagingCount;
        TrackBarSearchPaging.Value = PagingCurrent + 1;
        var results = SearchResults.ToList()
                      .Skip(PagingCurrent * Program.Settings.FoundReferencesViewable)
                      .Take(Program.Settings.FoundReferencesViewable);
        EditSearchPaging.Text = (PagingCurrent + 1) + "/" + PagingCount;
        UpdateSearchButtons();
        int referenceSize = 160;
        int marginX = 10;
        int marginY = 10;
        int minX = marginX;
        int maxX = PanelSearchResults.ClientSize.Width - marginX;
        int x = 0;
        int y = 0;
        int xx;
        foreach ( var reference in results )
        {
          Application.DoEvents();
          if ( CancelRequired ) { CancelRequired = false; break; }
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
          foreach ( DataSet.WordsRow word in reference.Verse.GetWordsRows() )
          {
            label = new Label();
            label.Text = word.Hebrew.Trim();
            label.AutoSize = true;
            label.Font = HebrewFont12;
            if ( CheckWord != null )
            {
              if ( CheckWord(word) )
              {
                label.Tag = new WordReferencedItem(reference, word);
                label.ForeColor = Color.DarkRed;
                label.MouseEnter += (sender, e) =>
                {
                  ( (Control)sender ).Cursor = Cursors.Hand;
                };
                label.MouseLeave += (sender, e) =>
                {
                  ( (Control)sender ).Cursor = Cursors.Default;
                };
                label.MouseClick += (sender, e) =>
                {
                  SetView(ViewModeType.Verses);
                  var item = (WordReferencedItem)( (Control)sender ).Tag;
                  GoTo(item);
                  foreach ( Control control in PanelViewVerses.Controls )
                    if ( control is WordControl )
                      if ( ( (WordControl)control ).Word == item.Word )
                        control.Focus();
                };
              }
              else
                label.ForeColor = SystemColors.ControlText;
            }
            x -= label.PreferredSize.Width;
            if ( x < minX )
            {
              x = xx - label.PreferredWidth;
              y += label.PreferredHeight;
            }
            label.Location = new Point(x, y);
            label.Click += (sender, e) => PanelSearchResults.Focus();
            PanelSearchResults.Controls.Add(label);
          }
          y += label.PreferredHeight + marginY;
          if ( reference.Verse.IsTranslated() )
          {
            label = new Label();
            label.AutoSize = true;
            label.MaximumSize = new Size(xx - marginX, label.MaximumSize.Height);
            label.Text = reference.Verse.GetTranslation();
            label.Location = new Point(xx - label.PreferredSize.Width, y);
            label.Click += (sender, e) => PanelSearchResults.Focus();
            PanelSearchResults.Controls.Add(label);
            y += label.PreferredHeight + marginY;
          }
        }
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
      finally
      {
        InProcess = false;
        if ( Program.Settings.FoundReferencesViewable > PagingWaiter ) SetFormDisabled(false);
        PanelSearchResults.ResumeLayout();
        PanelSearchResults.Focus();
      }
    }

  }

}
