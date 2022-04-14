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

  /// <summary>
  /// The document.
  /// </summary>
  /// <remarks>
  /// Measures in float or double are in inch: 100f = 1 inch.
  /// </remarks>
  static private DocX Document;

  //static private read-only Font FontVerdana = new("Verdana");
  static private readonly Font FontHebrew = new("Hebrew");
  static private readonly Font FontCalibri = new("Calibri");

  static private readonly int TableWidth = 450;
  static private readonly int WordColumnCount = 4;
  static private readonly int CellVerseWidth = 55;
  static private readonly int CellCommentWidth = TableWidth - CellVerseWidth;

  [SuppressMessage("Style", "GCop408:Flag or switch parameters (bool) should go after all non-optional parameters. If the boolean parameter is not a flag or switch, split the method into two different methods, each doing one thing.", Justification = "Opinion")]
  static public void Run(string filePath,
                         BookRow book,
                         bool includeTranslation,
                         Func<bool> showProgress)
  {
    using ( Document = DocX.Create(filePath, DocumentTypes.Document) )
      try
      {
        SetPageMargins();
        AddBookTitle(book);
        foreach ( ChapterRow chapter in book.Chapters )
        {
          if ( showProgress is not null && showProgress() ) break;
          AddChapterTitle(chapter);
          foreach ( VerseRow verse in chapter.Verses )
          {
            string strref = Program.Settings.ExportWordPrintFullReference
              ? new ReferenceItem(book.Number, chapter.Number, verse.Number).ToStringOnlyNumbersNoBook()
              : verse.Number.ToString();
            AddVerse(verse, includeTranslation, strref);
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

  static public void Run(string filePath,
                         BookRow book,
                         ChapterRow chapter,
                         bool includeTranslation)
  {
    using ( Document = DocX.Create(filePath, DocumentTypes.Document) )
      try
      {
        SetPageMargins();
        AddBookTitle(book);
        AddChapterTitle(chapter);
        foreach ( VerseRow verse in chapter.Verses )
        {
          string strref = Program.Settings.ExportWordPrintFullReference
            ? new ReferenceItem(book.Number, chapter.Number, verse.Number).ToStringOnlyNumbersNoBook()
            : verse.Number.ToString();
          AddVerse(verse, includeTranslation, strref);
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

  static public void Run(string filePath,
                         BookRow book,
                         ChapterRow chapter,
                         int verse,
                         bool includeTranslation)
  {
    using ( Document = DocX.Create(filePath, DocumentTypes.Document) )
      try
      {
        SetPageMargins();
        AddBookTitle(book);
        AddChapterTitle(chapter);
        string strref = Program.Settings.ExportWordPrintFullReference
          ? new ReferenceItem(book.Number, chapter.Number, verse).ToStringOnlyNumbersNoBook()
          : verse.ToString();
        AddVerse(chapter.Verses[verse - 1], includeTranslation, strref);
        Document.Save();
        if ( Program.Settings.AutoOpenExportedFile )
          SystemManager.RunShell(filePath);
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
  }

  static private void SetPageMargins()
  {
    Document.MarginTop = 75.0f;
    Document.MarginBottom = 75.0f;
    Document.MarginLeft = 75.0f;
    Document.MarginRight = 75.0f;
    Document.DifferentOddAndEvenPages = true;
  }

  static private void AddBookTitle(BookRow book)
  {
    bool hasSubtitle = book.Transcription.Length != 0 && book.Translation.Length != 0;
    AddTitle(book.Hebrew, FontHebrew, 32, "Heading1", !hasSubtitle);
    if ( hasSubtitle )
      AddTitle(( book.Transcription + " - " + book.Translation ).ToUpper(), FontCalibri, 20, "Heading1");
  }

  static private void AddChapterTitle(ChapterRow chapter)
  {
    bool hasSubtitle = chapter.Title.Length != 0 || chapter.Memo.Length != 0;
    AddTitle($"{AppTranslations.BookChapterTitle.GetLang()} {chapter.Number}", FontCalibri, 20, "Heading2", !hasSubtitle);
    if ( chapter.Title.Length != 0 )
      AddTitle(chapter.Title, FontCalibri, 15, "Heading2", chapter.Memo.Length == 0);
    if ( chapter.Memo.Length != 0 )
    {
      AddMemo(chapter.Memo);
      Document.InsertParagraph().AppendLine();
    }
    Document.InsertParagraph("").AppendLine();
  }

  static private void AddTitle(string str, Font font, int size, string styleName, bool blankline = true)
  {
    if ( str.IsNullOrEmpty() ) return;
    var table = Document.InsertTable(1, 2);
    table.Alignment = Alignment.right;
    table.Design = TableDesign.None;
    table.Rows[0].Cells[0].Width = CellCommentWidth;
    table.Rows[0].Cells[1].Width = CellVerseWidth;
    var paragraph = table.Rows[0].Cells[0].Paragraphs[0];
    if ( !styleName.IsNullOrEmpty() ) paragraph.StyleName = styleName;
    paragraph.Append(str);
    paragraph.Direction = Direction.RightToLeft;
    paragraph.Font(font);
    paragraph.Color(Color.Black);
    paragraph.FontSize(size);
    paragraph.SpacingBefore(0);
    paragraph.SpacingAfter(0);
    paragraph.LineSpacingBefore = 0;
    paragraph.LineSpacingAfter = 0;
    if ( blankline ) Document.InsertParagraph("").AppendLine();
  }

  static private void SetCellSize(Cell cell,
                                  int width,
                                  int marginTop,
                                  int marginBottom,
                                  int marginLeft,
                                  int marginRight)
  {
    cell.Width = width;
    cell.MarginTop = marginTop;
    cell.MarginBottom = marginBottom;
    cell.MarginLeft = marginLeft;
    cell.MarginRight = marginRight;
  }

  static private void AddVerse(VerseRow verse, bool includeTranslation, string fullref)
  {
    // TODO add option to prefs
    string strVerseRef = fullref ?? verse.Number.ToString();
    int rowFactor = Convert.ToInt32(includeTranslation) + 1;
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
      // T O D O option for line style verse & comment
      //cellVerse.SetBorder(TableCellBorderType.Right, new Border(BorderStyle.Tcbs_double, BorderSize.one, 1, Color.Gray));
      //if ( includeTranslation )
      //{
      //  var cellTranslation = table.Rows[row + 1].Cells[WordColumnCount];
      //  cellTranslation.SetBorder(TableCellBorderType.Right, new Border(BorderStyle.Tcbs_double, BorderSize.one, 1, Color.Gray));
      //}
      if ( row == 0 )
      {
        var pVerseRef = cellVerse.Paragraphs[0].Append(" " + strVerseRef);
        pVerseRef.Font(FontCalibri);
        pVerseRef.FontSize(14);
        pVerseRef.Bold();
        cellVerse.VerticalAlignment = VerticalAlignment.Center;
      }
      var words = verse.Words.OrderByDescending(w => w.Number).ToList();
      for ( int i = 3; i >= 0 && indexWord >= 0; i--, indexWord-- )
      {
        var word = words[indexWord];
        string strWord = word.Hebrew;
        var cell = table.Rows[row].Cells[i];
        cell.MarginTop = 5;
        var pWord = cell.Paragraphs[0].Append(strWord);
        pWord.Alignment = Alignment.right;
        pWord.Font(FontHebrew);
        pWord.FontSize(16);
        pWord.Spacing(1);
        if ( includeTranslation )
        {
          string strTranslation = word.Translation;
          var pTranslation = table.Rows[row + 1].Cells[i].Paragraphs[0].Append(strTranslation);
          pTranslation.Alignment = Alignment.right;
          pTranslation.Font(FontCalibri);
          pTranslation.FontSize(10);
        }
      }
    }
    AddMemo(verse.Comment);
    Document.InsertParagraph().AppendLine();
  }

  private static void AddMemo(string text)
  {
    if ( text.Length > 0 )
    {
      var lines = text.SplitNoEmptyLines();
      Document.InsertParagraph("").FontSize(8);
      var table = Document.InsertTable(1, 2);
      table.Alignment = Alignment.right;
      table.Design = TableDesign.None;
      var cellComment = table.Rows[0].Cells[0];
      cellComment.Width = CellCommentWidth;
      cellComment.SetBorder(TableCellBorderType.Top, new Border(BorderStyle.Tcbs_single, BorderSize.one, 1, Color.Gray));
      cellComment.SetBorder(TableCellBorderType.Left, new Border(BorderStyle.Tcbs_single, BorderSize.one, 1, Color.Gray));
      cellComment.SetBorder(TableCellBorderType.Right, new Border(BorderStyle.Tcbs_single, BorderSize.one, 1, Color.Gray));
      cellComment.SetBorder(TableCellBorderType.Bottom, new Border(BorderStyle.Tcbs_single, BorderSize.one, 1, Color.Gray));
      var cellVerse = table.Rows[0].Cells[1];
      cellVerse.Width = CellVerseWidth;
      table.Rows[0].Cells[0].RemoveParagraphAt(0);
      foreach ( string line in lines )
      {
        var paragraph = table.Rows[0].Cells[0].InsertParagraph(line);
        paragraph.Font(FontCalibri);
        paragraph.FontSize(10);
        paragraph.SpacingBefore(5);
        paragraph.SpacingAfter(5);
        paragraph.Alignment = Alignment.both;
      }
    }
  }

}
