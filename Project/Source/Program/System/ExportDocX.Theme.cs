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

static partial class ExportDocX
{

  //static private read-only Font FontVerdana = new("Verdana");

  static private readonly Font FontHebrew = new("Hebrew");
  static private readonly Font FontCalibri = new("Calibri");

  static private readonly int TableWidth = 450;

  static private readonly int CellCommentWidth = TableWidth - ExportDocXTheming.CellVerseWidth;

  static private readonly int MemoCellMargin = 8;
  static private readonly int MemoTextSpacing = 5;
  static private readonly int WordTextSpacing = 15;
  static private readonly int CellVerseMarginLeft = 5;
  static private readonly int CellVerseMarginRight = 0;

  static private readonly bool VerseRefTextInBold = false;

  static private string Heading1 = "Heading1";

  static private string Heading2 = "Heading2";

}
