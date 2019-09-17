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
using System.Windows.Forms;
using Ordisoftware.Core;
using Ordisoftware.HebrewWords.Data;

namespace Ordisoftware.HebrewWords
{

  public partial class MainForm
  {

    private IEnumerable<ReferenceItem> SearchResults;

    internal int SearchResultsCount { get; private set; }

    private int PagingCountDisableForm = 50;
    private int PagingCurrent = 0;
    private int PagingCount = 0;

    private Func<DataSet.WordsRow, bool> CheckWord;
    private Func<DataSet.VersesRow, bool> CheckVerse;

    private string SearchWord1;
    private string SearchWord2;

    private void UpdatePagingCount()
    {
      PagingCount = SearchResultsCount / Program.Settings.FoundReferencesViewable;
      if ( SearchResultsCount % Program.Settings.FoundReferencesViewable > 0 )
        PagingCount++;
      PagingCurrent = PagingCount == 0 ? 0 : 1;
    }

    private void UpdateSearchButtons()
    {
      try
      {
        ActionSearchWord.Enabled = EditLetters.Input.Text.Length >= 2;
        ActionClearWord.Enabled = SearchResultsCount > 0 || EditLetters.Input.Text != "";
        ActionNavigateFirst.Enabled = SearchResultsCount > 0 && PagingCurrent != 1;
        ActionNavigatePrevious.Enabled = SearchResultsCount > 0 && PagingCurrent > 1;
        ActionNavigateNext.Enabled = SearchResultsCount > 0 && PagingCurrent < PagingCount;
        ActionNavigateLast.Enabled = SearchResultsCount > 0 && PagingCurrent != PagingCount;
        EditSearchPaging.Enabled = SearchResultsCount > 0;
        LabelSearchCount.Visible = SearchResultsCount > 0;
        LabelSearchCount.Text = SearchResultsCount.ToString();
        LabelSearchCount.Visible = SearchResultsCount > 0;
        TrackBarSearchPaging.Visible = PagingCount > 1;
        TrackBarSearchPaging.Minimum = SearchResultsCount == 0 ? 0 : 1;
        TrackBarSearchPaging.Maximum = PagingCount;
        TrackBarSearchPaging.Value = PagingCount == 0 ? 0 : PagingCurrent;
        EditSearchPaging.Text = SearchResultsCount == 0 ? "0" : PagingCurrent + "/" + PagingCount;
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
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
      if ( SearchWord1 != "" && SearchWord1.Length >= 2 && CheckVerse == null )
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
          if ( SearchResults == null )
            SearchResultsCount = 0;
          else
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
      UpdatePagingCount();
      RenderSearchResults();
    }

  }

}
