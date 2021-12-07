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
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class MainForm
{

  private void CreateSearchResults()
  {
    ClearSearchResults();
    if ( SelectSearchInBook.SelectedItem == null ) return;
    //
    bool checkWordHebrew(WordRow row) => row.Hebrew.Contains(SearchWord1) || row.Hebrew.Contains(SearchWord2);
    bool checkTranslatedAll(VerseRow verse) => verse.HasTranslation;
    bool checkTranslatedAllFully(VerseRow verse) => verse.IsFullyTranslated;
    bool checkTranslatedAllPartially(VerseRow verse) => verse.IsPartiallyTranslated;
    bool checkTranslatedAllUntranslated(VerseRow verse) => !verse.HasTranslation;
    bool checkWordTranslation(WordRow row) => checkWordNoHebrew(row.Translation.ToLower().RemoveDiacritics());
    bool checkVerseComment(VerseRow row) => checkWordNoHebrew(row.Comment.ToLower().RemoveDiacritics());
    bool checkWordNoHebrew(string str)
      => SearchWord1.Contains(",")
         ? SearchWord1.Split(',').Select(item => item.Trim()).Any(item => item.Length >= 2 && str.Contains(item))
         : str.Contains(SearchWord1);
    //
    if ( SelectSearchType.SelectedTab == SelectSearchTypeHebrew )
    {
      SearchWord1 = EditLetters.TextBox.Text;
      SearchWord2 = HebrewAlphabet.SetFinal(SearchWord1, true);
      CheckWord = checkWordHebrew;
    }
    else
    if ( SelectSearchType.SelectedTab == SelectSearchTypeTranslation )
    {
      SearchWord1 = EditSearchTranslation.Text.ToLower().RemoveDiacritics();
      // TODO assign depending on radiogroup
      CheckWord = checkWordTranslation;
      CheckVerse = checkVerseComment;
    }
    else
    if ( SelectSearchType.SelectedTab == SelectSearchTypeVerses )
    {
      if ( SelectSearchRequestAllTranslated.Checked ) CheckVerse = checkTranslatedAll;
      if ( SelectSearchRequestAllFullyTranslated.Checked ) CheckVerse = checkTranslatedAllFully;
      if ( SelectSearchRequestAllPartiallyTranslated.Checked ) CheckVerse = checkTranslatedAllPartially;
      if ( SelectSearchRequestAllUntranslated.Checked ) CheckVerse = checkTranslatedAllUntranslated;
    }
    else
      throw new AdvancedNotImplementedException(SelectSearchType.SelectedTab.Text);
    //
    int bookSelected = ( (BookRow)SelectSearchInBook.SelectedItem ).Number;
    bool isBookSelected(int index)
    {
      return ( EditSearchInTorah.Checked && index <= BooksBounds.Torah.Max )
          || ( EditSearchInNeviim.Checked && index >= BooksBounds.Neviim.Min && index <= BooksBounds.Neviim.Max )
          || ( EditSearchInKetouvim.Checked && index >= BooksBounds.Ketouvim.Min )
          || ( SelectSearchInBook.Enabled && index == bookSelected );
    }
    //
    IEnumerable<ReferenceItem> createSearch(Func<VerseRow, WordRow, bool> check)
      => from book in ApplicationDatabase.Instance.Books
         from chapter in book.Chapters
         from verse in chapter.Verses
         from word in verse.Words
         where isBookSelected(book.Number) && check(verse, word)
         select new ReferenceItem(book, chapter, verse);
    //
    if ( SearchWord1.Length >= 2 && CheckWord != null && CheckVerse != null )
      SearchResults = createSearch((verse, word) => CheckWord(word) || CheckVerse(verse));
    else
    if ( SearchWord1.Length >= 2 && CheckVerse == null )
      SearchResults = createSearch((_, word) => CheckWord(word));
    else
    if ( CheckVerse != null )
      SearchResults = createSearch((verse, _) => CheckVerse(verse));
    //
    if ( SearchResults != null )
    {
      SearchResults = SearchResults.Distinct(new ReferenceItem.ReferenceComparer());
      Cursor = Cursors.WaitCursor;
      try
      {
        SearchResultsCount = SearchResults.Count();
      }
      finally
      {
        Cursor = Cursors.Default;
      }
      if ( SearchResultsCount > Settings.FoundReferencesToOpenDialog )
      {
        SearchResults = SelectSearchResultsForm.Run(SearchResults);
        if ( SearchResults?.Any() != true )
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
    //
    UpdatePagingCount();
    RenderSearch();
  }

}
