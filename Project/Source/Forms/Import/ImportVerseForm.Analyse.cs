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
/// <created> 2019-09 </created>
/// <edited> 2019-09 </edited>
namespace Ordisoftware.Hebrew.Words;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Ordisoftware.Core;

partial class ImportVerseForm : Form
{

  private const char ElementsSeparator = '|';

  private readonly ImportverseResults ImportResults = new();

  private void DoAnalyse()
  {
    var foundWords = new List<string>();
    var foundTranslation = new List<string>();
    DataGridView.DataSource = null;
    ImportResults.Clear();
    var lines = EditSource.Lines.Where(line => line.Length > 0).ToList();
    if ( lines.Count % 2 != 0 )
    {
      IsResultValid = false;
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
        IsResultValid = false;
        DisplayManager.ShowError(AppTranslations.ImportItemsCountMismatch.GetLang(lineHebrewElements.Length,
                                                                                  lineTranslationElements.Length));
        return;
      }
      foundWords.AddRange(lineHebrewElements.Reverse());
      foundTranslation.AddRange(lineTranslationElements.Reverse());
    }
    var wordsReference = Reference.Verse.GetWordsRows();
    if ( foundWords.Count != wordsReference.Length )
    {
      IsResultValid = false;
      DisplayManager.ShowError(AppTranslations.ImportWordsCountMismatch.GetLang(wordsReference.Length,
                                                                                foundWords.Count));
      return;
    }
    for ( int index = 0; index < foundWords.Count; index++ )
    {
      if ( foundWords[index] != wordsReference[index].Hebrew )
      {
        IsResultValid = false;
        DisplayManager.ShowError(AppTranslations.ImportWordMismatch.GetLang(wordsReference[index].Hebrew,
                                                                            foundWords[index]));
        return;
      }
      var item = new ImportVerseResult
      {
        Hebrew = wordsReference[index].Hebrew,
        CurrentTranslation = wordsReference[index].Translation,
        ImportedTranslation = foundTranslation[index]
      };
      ImportResults.Add(item);
    }
    IsResultValid = true;
    DataGridView.DataSource = ImportResults;
  }

}
