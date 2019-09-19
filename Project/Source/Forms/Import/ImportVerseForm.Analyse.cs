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
/// <created> 2019-09 </created>
/// <edited> 2019-09 </edited>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ordisoftware.Core;

namespace Ordisoftware.HebrewWords
{

  public partial class ImportVerseForm : Form
  {

    private const char ElementsSeparator = '|';

    private List<string> FounWords = new List<string>();
    private List<string> FoundTranslation = new List<string>();

    private void DoAnalyse()
    {
      FounWords.Clear();
      FoundTranslation.Clear();
      var lines = EditSource.Lines.Where(line => line != "").ToList();
      if ( lines.Count % 2 != 0 )
      {
        IsResultValid = false;
        DisplayManager.ShowError("Incorrect input lines count: must be even.");
        return;
      }
      for ( int indexLineEven = 0; indexLineEven < lines.Count; indexLineEven += 2 )
      {
        string lineHebrew = lines[indexLineEven];
        string lineTranslation = lines[indexLineEven + 1];
        var lineHebrewElements = lineHebrew.Split(ElementsSeparator);
        var lineTranslationElements = lineTranslation.Split(ElementsSeparator);
        for ( int index = 0; index < lineHebrewElements.Length; index++ )
          lineHebrewElements[index] = lineHebrewElements[index].Trim();
        for ( int index = 0; index < lineTranslationElements.Length; index++ )
          lineTranslationElements[index] = lineTranslationElements[index].Trim();
        if ( lineHebrewElements.Length == 0
          || lineTranslationElements.Length == 0
          || lineHebrewElements.Length != lineTranslationElements.Length )
        {
          IsResultValid = false;
          DisplayManager.ShowError("Incorrect elements count: hebrew words count and translations count does not match.");
          return;
        }
        FounWords.AddRange(lineHebrewElements);
        FoundTranslation.AddRange(lineTranslationElements);
      }
      FounWords.Reverse();
      FoundTranslation.Reverse();
      var wordsReference = Reference.Verse.GetWordsRows();
      if ( wordsReference.Count() != FounWords.Count)
      {
        IsResultValid = false;
        DisplayManager.ShowError("Incorrect element count: verse words count and imported words count does not match.");
        return;
      }
      for ( int index = 0; index < FounWords.Count; index++ )
      {
        if ( FounWords[index] != wordsReference[index].Hebrew )
        {
          IsResultValid = false;
          DisplayManager.ShowError("Incorrect hebrew words: verse words and imported words does not match.");
          return;
        }
        TextBoxTest.AppendText(FounWords[index] + " : " + FoundTranslation[index]);
        TextBoxTest.AppendText(Environment.NewLine);
      }
      IsResultValid = true;
    }

  }

}
