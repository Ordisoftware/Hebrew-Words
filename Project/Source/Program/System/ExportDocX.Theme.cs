/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2022 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at
/// https://mozilla.org/MPL/2.0/.
/// If it is not possible or desirable to put the notice in a particular file,
/// then You may include the notice in a location(such as a LICENSE file in a
/// relevant directory) where a recipient would be likely to look for such a notice.
/// You may add additional accurate notices of copyright ownership.
/// </license>
/// <created> 2015-06 </created>
/// <edited> 2022-04 </edited>
namespace Ordisoftware.Hebrew.Words;

using Xceed.Document.NET;
using Xceed.Words.NET;

public enum ExportDocumentTheme
{
  Small,
  Medium,
  Large
}

[SuppressMessage("Design", "GCop179:Do not hardcode numbers, strings or other values. Use constant fields, enums, config files or database as appropriate.", Justification = "<En attente>")]
static partial class ExportDocX
{

  static public ExportDocumentTheme Theme => Program.Settings.ExportDocumentTheme;

  //static private read-only Font FontVerdana = new("Verdana");
  static private readonly float DocumentMargin = 75.0f;

  static private readonly bool DocumentDifferentOddAndEvenPages = true;

  static private readonly Font FontHebrew = new("Hebrew");
  static private readonly Font FontCalibri = new("Calibri");

  static private readonly int TableWidth = 450;

  static private readonly int CellCommentWidth = TableWidth - CellVerseWidth;

  static private readonly int MemoCellMargin = 8;
  static private readonly int MemoTextSpacing = 5;
  static private readonly int WordTextSpacing = 15;
  static private readonly int CellVerseMarginLeft = 5;
  static private readonly int CellVerseMarginRight = 0;

  static private readonly bool VerseRefTextInBold = false;

  static private string Heading1 = "Heading1";

  static private int Heading1TextSize => Theme switch
  {
    ExportDocumentTheme.Small => 20,
    ExportDocumentTheme.Medium => 28,
    ExportDocumentTheme.Large => 32
  };
  static private int Heading1TextSizeSub => Theme switch
  {
    ExportDocumentTheme.Small => 16,
    ExportDocumentTheme.Medium => 22,
    ExportDocumentTheme.Large => 24
  };

  static private string Heading2 = "Heading2";

  static private int Heading2TextSize => Theme switch
  {
    ExportDocumentTheme.Small => 16,
    ExportDocumentTheme.Medium => 18,
    ExportDocumentTheme.Large => 20
  };

  static private int Heading2TextSizeSub => Theme switch
  {
    ExportDocumentTheme.Small => 12,
    ExportDocumentTheme.Medium => 14,
    ExportDocumentTheme.Large => 16
  };

  static private int WordColumnCount => Theme switch
  {
    ExportDocumentTheme.Small => 5,
    ExportDocumentTheme.Medium => 5,
    ExportDocumentTheme.Large => 4
  };

  static private int CellVerseWidth => Theme switch
  {
    ExportDocumentTheme.Small => 40,
    ExportDocumentTheme.Medium => 50,
    ExportDocumentTheme.Large => 55
  };

  static private int WordHebrewTextSize => Theme switch
  {
    ExportDocumentTheme.Small => 12,
    ExportDocumentTheme.Medium => 14,
    ExportDocumentTheme.Large => 18
  };

  static private int VerseRefTextSize => Theme switch
  {
    ExportDocumentTheme.Small => 8,
    ExportDocumentTheme.Medium => 10,
    ExportDocumentTheme.Large => 12
  };

  static private int WordTranslationTextSize => Theme switch
  {
    ExportDocumentTheme.Small => 8,
    ExportDocumentTheme.Medium => 10,
    ExportDocumentTheme.Large => 12
  };

  static private int MemoTextSize => Theme switch
  {
    ExportDocumentTheme.Small => 8,
    ExportDocumentTheme.Medium => 10,
    ExportDocumentTheme.Large => 12
  };

}
