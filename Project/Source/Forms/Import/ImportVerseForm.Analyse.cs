/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2025 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at
/// https://mozilla.org/MPL/2.0/.
/// If it is not possible or desirable to put the notice in a particular file,
/// then You may include the notice in a location(such as a LICENSE file in a
/// relevant directory) where a recipient would be likely to look for such a notice.
/// You may add additional accurate notices of copyright ownership.
/// </license>
/// <created> 2019-09 </created>
/// <edited> 2022-03 </edited>
namespace Ordisoftware.Hebrew.Words;

sealed partial class ImportVerseForm : Form
{

  private readonly char[] ElementsSeparator = ['|', '\t'];

  private readonly List<ImportWordMatch> WordMatches = [];

  [SuppressMessage("Performance", "U2U1015:Do not index an array multiple times within a loop body", Justification = "N/A")]
  private void DoAnalyse()
  {
    // TODO trim numbers from all first lines in addition to spaces and tabs
    IsResultValid = false;
    var foundWords = new List<string>();
    var foundTranslation = new List<string>();
    DataGridView.DataSource = null;
    WordMatches.Clear();
    var lines = EditSource.Lines.Where(line => line.Length > 0).ToList();
    if ( lines.Count % 2 != 0 )
    {
      DisplayManager.ShowError(AppTranslations.ImportLinesCountMismatch.GetLang(lines.Count));
      return;
    }
    for ( int indexLineEven = 0; indexLineEven < lines.Count; indexLineEven += 2 )
    {
      string lineHebrew = lines[indexLineEven];
      string lineTranslation = lines[indexLineEven + 1];
      var lineHebrewElements = lineHebrew.Trim(ElementsSeparator).Split(ElementsSeparator);
      var lineTranslationElements = lineTranslation.Trim(ElementsSeparator).Split(ElementsSeparator);
      for ( int index = 0; index < lineHebrewElements.Length; index++ )
        lineHebrewElements[index] = lineHebrewElements[index].Trim();
      for ( int index = 0; index < lineTranslationElements.Length; index++ )
        lineTranslationElements[index] = lineTranslationElements[index].Trim();
      if ( lineHebrewElements.Length == 0
        || lineTranslationElements.Length == 0
        || lineHebrewElements.Length != lineTranslationElements.Length )
      {
        DisplayManager.ShowError(AppTranslations.ImportItemsCountMismatch.GetLang(lineHebrewElements.Length,
                                                                                  lineTranslationElements.Length));
        return;
      }
      foundWords.AddRange(lineHebrewElements.Reverse());
      foundTranslation.AddRange(lineTranslationElements.Reverse());
    }
    var wordsReference = Reference.Verse.Words;
    if ( foundWords.Count != wordsReference.Count )
    {
      DisplayManager.ShowError(AppTranslations.ImportWordsCountMismatch.GetLang(wordsReference.Count,
                                                                                foundWords.Count));
      return;
    }
    for ( int index = 0; index < foundWords.Count; index++ )
    {
      if ( foundWords[index] != wordsReference[index].Hebrew )
      {
        DisplayManager.ShowError(AppTranslations.ImportWordMismatch.GetLang(wordsReference[index].Hebrew,
                                                                            foundWords[index]));
        return;
      }
      var item = new ImportWordMatch
      {
        Number = wordsReference[index].Number,
        Hebrew = wordsReference[index].Hebrew,
        CurrentTranslation = wordsReference[index].Translation,
        ImportedTranslation = foundTranslation[index]
      };
      WordMatches.Add(item);
    }
    IsResultValid = true;
    DataGridView.DataSource = WordMatches;
  }

}
