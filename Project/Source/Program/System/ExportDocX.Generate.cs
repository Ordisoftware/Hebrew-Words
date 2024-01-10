/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2024 Olivier Rogier.
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

  static private readonly Border TheBorder = new(BorderStyle.Tcbs_single, BorderSize.one, 0, Color.Gray);

  /// <summary>
  /// Sets the MS Word document page properties like orientation and margins.
  /// </summary>
  [SuppressMessage("Performance", "U2U1008:Parentheses can be used to enable constant evaluation", Justification = "<En attente>")]
  static private void SetPageProperties()
  {
    Document.PageLayout.Orientation = Program.Settings.ExportDocumentLandscape
      ? Orientation.Landscape
      : Orientation.Portrait;
    Document.PageWidth = (int)( Program.Settings.ExportDocumentPageWidth / 0.0352778f / 10 );
    Document.PageHeight = (int)( Program.Settings.ExportDocumentPageHeight / 0.0352778f / 10 );
    Document.MarginTop = (int)( Program.Settings.ExportDocumentMarginTop / 0.0352778f / 10 );
    Document.MarginBottom = (int)( Program.Settings.ExportDocumentMarginBottom / 0.0352778f / 10 );
    Document.MarginLeft = (int)( Program.Settings.ExportDocumentMarginLeft / 0.0352778f / 10 );
    Document.MarginRight = (int)( Program.Settings.ExportDocumentMarginRight / 0.0352778f / 10 );
    Document.MarginHeader = (int)( Program.Settings.ExportDocumentMarginHeader / 0.0352778f / 10 );
    Document.MarginFooter = (int)( Program.Settings.ExportDocumentMarginFooter / 0.0352778f / 10 );
    Document.DifferentFirstPage = Program.Settings.ExportDocumentDifferentFirstPage;
    Document.DifferentOddAndEvenPages = Program.Settings.ExportDocumentDifferentOddAndEvenPages;
  }

  /// <summary>
  /// Adds a book's title and memo tables.
  /// </summary>
  static private void AddBookTitle(BookRow book, bool withMemo)
  {
    AddTitle(book.Hebrew, FontHebrew, Heading1TextSize, Heading1).Alignment = Alignment.center;
    if ( WithTranslation )
      if ( book.Transcription.Length != 0 && book.Translation.Length != 0 )
        AddTitle(( book.Transcription + " - " + book.Translation ).ToUpper(), FontCalibri, Heading1TextSizeSub, Heading1).Alignment = Alignment.center;
    Document.InsertParagraph();
    Document.InsertParagraph();
    if ( !withMemo || book.Memo.Length == 0 ) return;
    AddMemo(book.Memo);
    Document.InsertParagraph();
    Document.InsertParagraph();
  }

  /// <summary>
  /// Adds a chapter's title and memo tables.
  /// </summary>
  static private void AddChapterTitle(ChapterRow chapter, bool withMemo)
  {
    AddTitle($"{AppTranslations.BookChapterTitle.GetLang()} {chapter.Number}", FontCalibri, Heading2TextSize, Heading2);
    if ( WithTranslation )
      if ( chapter.Title.Length != 0 )
        AddTitle(chapter.Title, FontCalibri, Heading2TextSizeSub, Heading2);
    Document.InsertParagraph();
    Document.InsertParagraph();
    if ( !withMemo || chapter.Memo.Length == 0 ) return;
    AddMemo(chapter.Memo);
    Document.InsertParagraph();
    Document.InsertParagraph();
  }

  /// <summary>
  /// Adds a title's paragraph.
  /// </summary>
  static private Paragraph AddTitle(string str, Font font, int size, string styleName)
  {
    if ( str.IsNullOrEmpty() ) str = SysTranslations.EmptySlot.GetLang();
    var table = Document.InsertTable(1, 2);
    table.Alignment = Alignment.right;
    table.Design = TableDesign.None;
    table.Rows[0].Cells[0].Width = CellCommentWidth;
    table.Rows[0].Cells[1].Width = CellVerseWidth;
    var paragraph = table.Rows[0].Cells[0].Paragraphs[0];
    if ( !styleName.IsNullOrEmpty() )
      paragraph.StyleName = styleName;
    paragraph.Append(str);
    paragraph.Direction = Direction.RightToLeft;
    paragraph.Font(font);
    paragraph.Color(Color.Black);
    paragraph.FontSize(size);
    paragraph.SpacingBefore(0);
    paragraph.SpacingAfter(0);
    paragraph.LineSpacingBefore = 0;
    paragraph.LineSpacingAfter = 0;
    return paragraph;
  }

  /// <summary>
  /// Adds a verse's words with translations and memo tables.
  /// </summary>
  static private void AddVerse(VerseRow verse, string fullref)
  {
    // TODO use if (WithHebrew) ...
    string strVerseRef = fullref ?? verse.Number.ToString();
    int rowFactor = Convert.ToInt32(WithTranslation) + 1;
    int countWords = verse.Words.Count;
    int indexWord = countWords - 1;
    int countRows = ( (int)Math.Ceiling((double)countWords / WordColumnsCount) ) * rowFactor;
    var table = Document.InsertTable(countRows, WordColumnsCount + 1);
    table.Alignment = Alignment.right;
    table.Design = TableDesign.None;
    table.AutoFit = AutoFit.Contents;
    foreach ( var paragraph in table.Paragraphs )
      paragraph.KeepWithNextParagraph(true);
    for ( int row = 0; row < countRows; row += rowFactor )
    {
      var cellVerse = table.Rows[row].Cells[WordColumnsCount];
      cellVerse.Width = CellVerseWidth;
      cellVerse.MarginLeft = CellVerseMarginLeft;
      cellVerse.MarginRight = CellVerseMarginRight;
      if ( row == 0 )
      {
        var paragraphVerseRef = cellVerse.Paragraphs[0].Append(" " + strVerseRef);
        paragraphVerseRef.Font(FontCalibri);
        paragraphVerseRef.FontSize(VerseRefTextSize);
        paragraphVerseRef.SpacingAfter(WordTextSpacing);
        if ( Settings.ExportDocumentVerseRefInBold ) paragraphVerseRef.Bold();
        cellVerse.VerticalAlignment = VerticalAlignment.Center;
      }
      var words = verse.Words.OrderByDescending(w => w.Number).ToList();
      for ( int column = WordColumnsCount - 1; column >= 0 && indexWord >= 0; column--, indexWord-- )
      {
        var cell = table.Rows[row].Cells[column];
        cell.VerticalAlignment = VerticalAlignment.Center;
        var word = words[indexWord];
        var paragraphWord = cell.Paragraphs[0].Append(word.Hebrew);
        paragraphWord.Alignment = Alignment.right;
        paragraphWord.Font(FontHebrew);
        paragraphWord.FontSize(WordHebrewTextSize);
        paragraphWord.Spacing(1);
        if ( WithTranslation )
        {
          var paragraphTranslation = table.Rows[row + 1].Cells[column].Paragraphs[0].Append(word.Translation);
          paragraphTranslation.Alignment = Alignment.right;
          paragraphTranslation.Font(FontCalibri);
          paragraphTranslation.FontSize(WordTranslationTextSize);
          paragraphTranslation.SpacingAfter(WordTextSpacing);
        }
        else
          paragraphWord.SpacingAfter(WordTextSpacing);
      }
    }
    if ( WithMemo && verse.Comment.Length > 0 )
    {
      Document.InsertParagraph();
      AddMemo(verse.Comment);
      Document.InsertParagraph();
    }
    else
      Document.InsertParagraph();
    Document.InsertParagraph();
  }

  /// <summary>
  /// Add a memo table.
  /// </summary>
  private static void AddMemo(string text)
  {
    var lines = text.SplitNoEmptyLines();
    var table = Document.InsertTable(1, 2);
    table.Alignment = Alignment.right;
    table.Design = TableDesign.None;
    var cellComment = table.Rows[0].Cells[0];
    cellComment.Width = CellCommentWidth;
    cellComment.MarginLeft = MemoCellMargin;
    cellComment.MarginRight = MemoCellMargin;
    cellComment.MarginTop = MemoCellMargin;
    cellComment.MarginBottom = MemoCellMargin;
    cellComment.SetBorder(TableCellBorderType.Top, TheBorder);
    cellComment.SetBorder(TableCellBorderType.Bottom, TheBorder);
    cellComment.SetBorder(TableCellBorderType.Left, TheBorder);
    cellComment.SetBorder(TableCellBorderType.Right, TheBorder);
    var cellVerse = table.Rows[0].Cells[1];
    cellVerse.Width = CellVerseWidth;
    cellVerse.MarginLeft = MemoCellMargin;
    cellVerse.MarginRight = MemoCellMargin;
    cellVerse.MarginTop = MemoCellMargin;
    cellVerse.MarginBottom = MemoCellMargin;
    table.Rows[0].Cells[0].RemoveParagraphAt(0);
    for ( int index = 0, indexEnd = lines.Length - 1; index <= indexEnd; index++ )
    {
      string line = lines[index];
      var paragraph = table.Rows[0].Cells[0].InsertParagraph(line);
      paragraph.Font(FontCalibri);
      paragraph.FontSize(MemoTextSize);
      paragraph.Alignment = Alignment.both;
      if ( index != 0 ) paragraph.SpacingBefore(MemoTextSpacing);
      if ( index != indexEnd ) paragraph.SpacingAfter(MemoTextSpacing);
    }
  }

}
