/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2020 Olivier Rogier.
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
using Ordisoftware.Core;

namespace Ordisoftware.HebrewWords
{

  public partial class MainForm
  {

    private void ClearSearchResults()
    {
      CheckWord = null;
      CheckVerse = null;
      SearchResults = null;
      SearchResultsCount = 0;
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
        ActionSearchRun.Enabled = ( SelectSearchType.SelectedTab == SelectSearchTypeHebrew 
                                     && EditLetters.TextInput.Length >= 2 )
                                || ( SelectSearchType.SelectedTab == SelectSearchTypeTranslation 
                                     && EditSearchTranslation.Text.Length >= 2 )
                                || ( SelectSearchType.SelectedTab == SelectSearchTypeVerses );
        ActionNavigateSearchFirst.Enabled = SearchResultsCount > 0 && PagingCurrent != 1;
        ActionSearchNavigatePrevious.Enabled = SearchResultsCount > 0 && PagingCurrent > 1;
        ActionSearchNavigateNext.Enabled = SearchResultsCount > 0 && PagingCurrent < PagingCount;
        ActionSearchNavigateLast.Enabled = SearchResultsCount > 0 && PagingCurrent != PagingCount;
        EditSearchPaging.Enabled = SearchResultsCount > 0;
        SelectSearchPaging.Visible = PagingCount > 1;
        SelectSearchPaging.Minimum = SearchResultsCount == 0 ? 0 : 1;
        SelectSearchPaging.Maximum = PagingCount;
        SelectSearchPaging.Value = PagingCount == 0 ? 0 : PagingCurrent;
        EditSearchPaging.Text = SearchResultsCount == 0 
                              ? "0" 
                              : PagingCurrent + "/" + PagingCount + " (" + SearchResultsCount + ")";
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
    }

  }

}
