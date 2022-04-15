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
/// <edited> 2022-03 </edited>
namespace Ordisoftware.Hebrew.Words;

using Xceed.Document.NET;
using Xceed.Words.NET;

[SuppressMessage("Design", "GCop179:Do not hardcode numbers, strings or other values. Use constant fields, enums, config files or database as appropriate.", Justification = "<En attente>")]
static class ExportDocX
{

  // TODO add options to theme MSWord export
  // TODO add option to convert " in '«•' and '•»' (utiliser un bool alternatif depuis le premier rencontré)

  /// <summary>
  /// The document.
  /// </summary>
  /// <remarks>
  /// Measures in float or double are in inch: 100f = 1 inch = 2.54cm.
  /// </remarks>
  static private DocX Document;

  //static private read-only Font FontVerdana = new("Verdana");
  static private readonly Font FontHebrew = new("Hebrew");
  static private readonly Font FontCalibri = new("Calibri");

  static private float DocumentMargin = 75.0f;
  static private bool DocumentDifferentOddAndEvenPages = true;

  static private string Heading1 = "Heading1";
  static private int Heading1TextSize = 32;
  static private int Heading1TextSizeSub = 24;

  static private string Heading2 = "Heading2";
  static private int Heading2TextSize = 20;
  static private int Heading2TextSizeSub = 15;

  static private int TableWidth = 450;
  static private int WordColumnCount = 4;
  static private int CellVerseWidth = 55;
  static private int CellCommentWidth = TableWidth - CellVerseWidth;

  static private int MemoCellMargin = 8;
  static private int MemoTextSpacing = 5;
  static private int MemoTextSize = 10;

  static private int CellVerseMarginLeft = 5;
  static private int CellVerseMarginRight = 0;
  static private bool VerseRefTextInBold = true;
  static private int VerseRefTextSize = 12;
  static private int WordHebrewTextSize = 16;
  static private int WordTranslationTextSize = 10;
  static private int WordTextSpacing = 10;

  /// <summary>
  /// Exports a book to MS Word file.
  /// </summary>
  [SuppressMessage("Style", "GCop408:Flag or switch parameters (bool) should go after all non-optional parameters. If the boolean parameter is not a flag or switch, split the method into two different methods, each doing one thing.", Justification = "Opinion")]
  static public void Run(string filePath, BookRow book, bool withTranslation, bool withMemo, Func<bool> showProgress)
  {
    using ( Document = DocX.Create(filePath, DocumentTypes.Document) )
      try
      {
        SetPageMargins();
        AddBookTitle(book, true);
        foreach ( ChapterRow chapter in book.Chapters )
        {
          if ( showProgress is not null && showProgress() ) break;
          AddChapterTitle(chapter, withMemo);
          foreach ( VerseRow verse in chapter.Verses )
          {
            string strref = Program.Settings.ExportWordPrintFullReference
              ? new ReferenceItem(book.Number, chapter.Number, verse.Number).ToStringOnlyNumbersNoBook()
              : verse.Number.ToString();
            AddVerse(verse, withTranslation, withMemo, strref);
          }
        }
        Document.Save();
        if ( Program.Settings.AutoOpenExportedFile )
          SystemManager.RunShell(filePath);
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
  }

  /// <summary>
  /// Exports a chapter to MS Word file.
  /// </summary>
  static public void Run(string filePath, BookRow book, ChapterRow chapter, bool withTranslation, bool withMemo)
  {
    using ( Document = DocX.Create(filePath, DocumentTypes.Document) )
      try
      {
        SetPageMargins();
        AddBookTitle(book, withMemo);
        AddChapterTitle(chapter, withMemo);
        foreach ( VerseRow verse in chapter.Verses )
        {
          string strref = Program.Settings.ExportWordPrintFullReference
            ? new ReferenceItem(book.Number, chapter.Number, verse.Number).ToStringOnlyNumbersNoBook()
            : verse.Number.ToString();
          AddVerse(verse, withTranslation, withMemo, strref);
        }
        Document.Save();
        if ( Program.Settings.AutoOpenExportedFile )
          SystemManager.RunShell(filePath);
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
  }

  /// <summary>
  /// Exports a verse to a MS Word file without book and chapter memos.
  /// </summary>
  static public void Run(string filePath, BookRow book, ChapterRow chapter, int verse, bool withTranslation, bool withMemo)
  {
    using ( Document = DocX.Create(filePath, DocumentTypes.Document) )
      try
      {
        SetPageMargins();
        AddBookTitle(book, false);
        AddChapterTitle(chapter, false);
        string strref = Program.Settings.ExportWordPrintFullReference
          ? new ReferenceItem(book.Number, chapter.Number, verse).ToStringOnlyNumbersNoBook()
          : verse.ToString();
        AddVerse(chapter.Verses[verse - 1], withTranslation, withMemo, strref);
        Document.Save();
        if ( Program.Settings.AutoOpenExportedFile )
          SystemManager.RunShell(filePath);
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
  }

  /// <summary>
  /// Sets the MS Word document page margins.
  /// </summary>
  static private void SetPageMargins()
  {
    Document.MarginTop = DocumentMargin;
    Document.MarginBottom = DocumentMargin;
    Document.MarginLeft = DocumentMargin;
    Document.MarginRight = DocumentMargin;
    Document.DifferentOddAndEvenPages = DocumentDifferentOddAndEvenPages;
  }

  /// <summary>
  /// Adds a book title and memo tables.
  /// </summary>
  static private void AddBookTitle(BookRow book, bool withMemo)
  {
    AddTitle(book.Hebrew, FontHebrew, Heading1TextSize, Heading1);
    if ( book.Transcription.Length != 0 && book.Translation.Length != 0 )
      AddTitle(( book.Transcription + " - " + book.Translation ).ToUpper(), FontCalibri, Heading1TextSizeSub, Heading1);
    Document.InsertParagraph();
    Document.InsertParagraph();
    if ( withMemo && book.Memo.Length != 0 )
    {
      AddMemo(book.Memo);
      Document.InsertParagraph();
      Document.InsertParagraph();
    }
  }

  /// <summary>
  /// Adds a chapter title and memo tables.
  /// </summary>
  static private void AddChapterTitle(ChapterRow chapter, bool withMemo)
  {
    AddTitle($"{AppTranslations.BookChapterTitle.GetLang()} {chapter.Number}", FontCalibri, Heading2TextSize, Heading2);
    if ( chapter.Title.Length != 0 )
      AddTitle(chapter.Title, FontCalibri, Heading2TextSizeSub, Heading2);
    Document.InsertParagraph();
    Document.InsertParagraph();
    if ( withMemo && chapter.Memo.Length != 0 )
    {
      AddMemo(chapter.Memo);
      Document.InsertParagraph();
      Document.InsertParagraph();
    }
  }

  /// <summary>
  /// Adds a title paragraph.
  /// </summary>
  static private void AddTitle(string str, Font font, int size, string styleName)
  {
    if ( str.IsNullOrEmpty() ) return;
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
  }

  /// <summary>
  /// Adds a verse table with words and translations, and memo table.
  /// </summary>
  static private void AddVerse(VerseRow verse, bool withTranslation, bool withMemo, string fullref)
  {
    string strVerseRef = fullref ?? verse.Number.ToString();
    int rowFactor = Convert.ToInt32(withTranslation) + 1;
    int countWords = verse.Words.Count;
    int indexWord = countWords - 1;
    int countRows = ( (int)Math.Ceiling((double)countWords / WordColumnCount) ) * rowFactor;
    var table = Document.InsertTable(countRows, WordColumnCount + 1);
    table.Alignment = Alignment.right;
    table.Design = TableDesign.None;
    table.AutoFit = AutoFit.Contents;
    for ( int row = 0; row < countRows; row += rowFactor )
    {
      var cellVerse = table.Rows[row].Cells[WordColumnCount];
      cellVerse.Width = CellVerseWidth;
      cellVerse.MarginLeft = CellVerseMarginLeft;
      cellVerse.MarginRight = CellVerseMarginRight;
      if ( row == 0 )
      {
        var paragraphVerseRef = cellVerse.Paragraphs[0].Append(" " + strVerseRef);
        paragraphVerseRef.KeepWithNextParagraph(true);
        paragraphVerseRef.Font(FontCalibri);
        paragraphVerseRef.FontSize(VerseRefTextSize);
        if ( VerseRefTextInBold ) paragraphVerseRef.Bold();
        cellVerse.VerticalAlignment = VerticalAlignment.Center;
      }
      var words = verse.Words.OrderByDescending(w => w.Number).ToList();
      for ( int i = 3; i >= 0 && indexWord >= 0; i--, indexWord-- )
      {
        var cell = table.Rows[row].Cells[i];
        cell.VerticalAlignment = VerticalAlignment.Center;
        var word = words[indexWord];
        var paragraphWord = cell.Paragraphs[0].Append(word.Hebrew);
        paragraphWord.KeepWithNextParagraph(true);
        paragraphWord.Alignment = Alignment.right;
        paragraphWord.Font(FontHebrew);
        paragraphWord.FontSize(WordHebrewTextSize);
        paragraphWord.Spacing(1);
        if ( withTranslation )
        {
          var paragraphTranslation = table.Rows[row + 1].Cells[i].Paragraphs[0].Append(word.Translation);
          paragraphTranslation.KeepWithNextParagraph(true);
          paragraphTranslation.Alignment = Alignment.right;
          paragraphTranslation.Font(FontCalibri);
          paragraphTranslation.FontSize(WordTranslationTextSize);
          paragraphTranslation.SpacingAfter(WordTextSpacing);
        }
        else
          paragraphWord.SpacingAfter(WordTextSpacing);
      }
    }
    if ( withMemo && verse.Comment.Length > 0 )
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
    cellComment.SetBorder(TableCellBorderType.Top, new Border(BorderStyle.Tcbs_single, BorderSize.one, 0, Color.Gray));
    cellComment.SetBorder(TableCellBorderType.Bottom, new Border(BorderStyle.Tcbs_single, BorderSize.one, 0, Color.Gray));
    cellComment.SetBorder(TableCellBorderType.Left, new Border(BorderStyle.Tcbs_single, BorderSize.one, 0, Color.Gray));
    cellComment.SetBorder(TableCellBorderType.Right, new Border(BorderStyle.Tcbs_single, BorderSize.one, 0, Color.Gray));
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
