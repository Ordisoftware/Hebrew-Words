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
using System.Collections.Generic;
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

    private void InitSearchResults()
    {
      SearchResults = null;
      SearchResultsCount = 0;
      CheckWord = null;
      CheckVerse = null;
      SearchWord1 = "";
      SearchWord2 = "";
      PagingCount = 0;
      PagingCurrent = 0;
    }

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
        ActionSearchWord.Enabled = ( SelectSearchType.SelectedTab == SelectSearchTypeHebrew 
                                     && EditLetters.Input.Text.Length >= 2 )
                                || ( SelectSearchType.SelectedTab == SelectSearchTypeTranslation 
                                     && EditSearchTranslation.Text.Length >= 2 )
                                || ( SelectSearchType.SelectedTab == SelectSearchTypeVerses );
        ActionClearWord.Enabled = SearchResultsCount > 0 
                               || EditLetters.Input.Text != "" 
                               || EditSearchTranslation.Text != "";
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

  }

}
