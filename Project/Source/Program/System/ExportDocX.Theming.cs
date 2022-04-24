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
/// <created> 2022-04 </created>
/// <edited> 2022-04 </edited>
namespace Ordisoftware.Hebrew.Words;

using Xceed.Document.NET;

static partial class ExportDocX
{

  static private float TableWidth => Document.PageWidth - Document.MarginLeft - Document.MarginRight;

  static private float CellCommentWidth => TableWidth - CellVerseWidth;

  static public int WordColumnsCount
    => Program.Settings.ExportDocumentOverrideWordColumnsCount
       ? Program.Settings.ExportDocumentWordColumnsCount
       : (int)Math.Truncate(0.66 * ( CellCommentWidth / CellVerseWidth ));

  static private readonly bool VerseRefTextInBold = false;

  static private readonly Font FontHebrew = new("Hebrew");
  static private readonly Font FontCalibri = new("Calibri");

  static private string Heading1 = "Heading1";
  static private string Heading2 = "Heading2";

  static public ExportDocumentTheme Theme => Program.Settings.ExportDocumentTheme;

  static private int MemoCellMargin => Theme switch
  {
    ExportDocumentTheme.Small => 4,
    ExportDocumentTheme.Medium => 6,
    ExportDocumentTheme.Large => 8
  };

  static private int MemoTextSpacing => Theme switch
  {
    ExportDocumentTheme.Small => 3,
    ExportDocumentTheme.Medium => 4,
    ExportDocumentTheme.Large => 5
  };

  static private int WordTextSpacing => Theme switch
  {
    ExportDocumentTheme.Small => 5,
    ExportDocumentTheme.Medium => 10,
    ExportDocumentTheme.Large => 15
  };

  static private int CellVerseMarginLeft => Theme switch
  {
    ExportDocumentTheme.Small => 5,
    ExportDocumentTheme.Medium => 5,
    ExportDocumentTheme.Large => 5
  };

  static private int CellVerseMarginRight => Theme switch
  {
    ExportDocumentTheme.Small => 0,
    ExportDocumentTheme.Medium => 0,
    ExportDocumentTheme.Large => 0
  };

  static public int Heading1TextSize => Theme switch
  {
    ExportDocumentTheme.Small => 24,
    ExportDocumentTheme.Medium => 28,
    ExportDocumentTheme.Large => 32
  };

  static public int Heading1TextSizeSub => Theme switch
  {
    ExportDocumentTheme.Small => 14,
    ExportDocumentTheme.Medium => 18,
    ExportDocumentTheme.Large => 24
  };

  static public int Heading2TextSize => Theme switch
  {
    ExportDocumentTheme.Small => 16,
    ExportDocumentTheme.Medium => 18,
    ExportDocumentTheme.Large => 20
  };

  static public int Heading2TextSizeSub => Theme switch
  {
    ExportDocumentTheme.Small => 12,
    ExportDocumentTheme.Medium => 14,
    ExportDocumentTheme.Large => 16
  };

  static public int CellVerseWidth => Theme switch
  {
    ExportDocumentTheme.Small => 40,
    ExportDocumentTheme.Medium => 50,
    ExportDocumentTheme.Large => 55
  };

  static public int WordHebrewTextSize => Theme switch
  {
    ExportDocumentTheme.Small => 12,
    ExportDocumentTheme.Medium => 14,
    ExportDocumentTheme.Large => 18
  };

  static public int VerseRefTextSize => Theme switch
  {
    ExportDocumentTheme.Small => 8,
    ExportDocumentTheme.Medium => 10,
    ExportDocumentTheme.Large => 12
  };

  static public int WordTranslationTextSize => Theme switch
  {
    ExportDocumentTheme.Small => 8,
    ExportDocumentTheme.Medium => 10,
    ExportDocumentTheme.Large => 12
  };

  static public int MemoTextSize => Theme switch
  {
    ExportDocumentTheme.Small => 8,
    ExportDocumentTheme.Medium => 10,
    ExportDocumentTheme.Large => 12
  };

}
