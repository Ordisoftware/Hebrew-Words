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
/// <created> 2019-09 </created>
/// <edited> 2019-09 </edited>
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Ordisoftware.Core;

namespace Ordisoftware.Hebrew.Words
{

  public partial class ImportVerseForm : Form
  {

    private const char ElementsSeparator = '|';

    private ImportverseResults ImportResults = new ImportverseResults();

    private void DoAnalyse()
    {
      var foundWords = new List<string>();
      var foundTranslation = new List<string>();
      DataGridView.DataSource = null;
      ImportResults.Clear();
      var lines = EditSource.Lines.Where(line => line != "").ToList();
      if ( lines.Count % 2 != 0 )
      {
        IsResultValid = false;
        DisplayManager.ShowError(Translations.ImportLinesCountMismatch.GetLang(lines.Count));
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
          DisplayManager.ShowError(Translations.ImportItemsCountMismatch.GetLang(lineHebrewElements.Length, 
                                                                                 lineTranslationElements.Length));
          return;
        }
        foundWords.AddRange(lineHebrewElements.Reverse());
        foundTranslation.AddRange(lineTranslationElements.Reverse());
      }
      var wordsReference = Reference.Verse.GetWordsRows();
      if ( foundWords.Count != wordsReference.Count() )
      {
        IsResultValid = false;
        DisplayManager.ShowError(Translations.ImportWordsCountMismatch.GetLang(wordsReference.Count(),
                                                                               foundWords.Count));
        return;
      }
      for ( int index = 0; index < foundWords.Count; index++ )
      {
        if ( foundWords[index] != wordsReference[index].Hebrew )
        {
          IsResultValid = false;
          DisplayManager.ShowError(Translations.ImportWordMismatch.GetLang(wordsReference[index].Hebrew,
                                                                           foundWords[index]));
          return;
        }
        var item = new ImportVerseResult();
        item.Hebrew = wordsReference[index].Hebrew;
        item.CurrentTranslation = wordsReference[index].Translation;
        item.ImportedTranslation = foundTranslation[index];
        ImportResults.Add(item);
      }
      IsResultValid = true;
      DataGridView.DataSource = ImportResults;
    }

  }

}
