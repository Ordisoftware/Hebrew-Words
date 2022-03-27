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
            AddVerse(verse, includeTranslation);
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
          AddVerse(verse, includeTranslation);
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
        AddVerse(chapter.Verses[verse - 1], includeTranslation);
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
    Document.MarginTop = 100.0f;
    Document.MarginBottom = 100.0f;
    Document.MarginLeft = 100.0f;
    Document.MarginRight = 100.0f;
    Document.DifferentOddAndEvenPages = true;
  }

  static private void AddBookTitle(BookRow book)
  {
    AddTitle(book.Hebrew, FontHebrew, 32, "Heading1");
    if ( book.Translation.Length == 0 ) return;
    var table = Document.InsertTable(1, 2);
    table.Alignment = Alignment.right;
    table.Design = TableDesign.None;
    table.Rows[0].Cells[0].Width = 555;
    table.Rows[0].Cells[1].Width = 55;
    var paragraph = table.Rows[0].Cells[0].Paragraphs[0];
    paragraph.Append(book.Translation);
    paragraph.Direction = Direction.RightToLeft;
    paragraph.Font(FontCalibri);
    paragraph.FontSize(16);
    paragraph.Bold();
    Document.InsertParagraph().AppendLine();
  }

  static private void AddChapterTitle(ChapterRow chapter)
  {
    AddTitle($"{AppTranslations.BookChapterTitle.GetLang()} {chapter.Number}", FontCalibri, 20, "Heading2");
  }

  static private void AddTitle(string str, Font font, int size, string styleName)
  {
    var table = Document.InsertTable(1, 2);
    table.Alignment = Alignment.right;
    table.Design = TableDesign.None;
    table.Rows[0].Cells[0].Width = 555;
    table.Rows[0].Cells[1].Width = 55;
    var paragraph = table.Rows[0].Cells[0].Paragraphs[0];
    paragraph.StyleName = styleName;
    paragraph.Append(str);
    paragraph.Direction = Direction.RightToLeft;
    paragraph.Font(font);
    paragraph.FontSize(size);
    Document.InsertParagraph().AppendLine();
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

  static private void AddVerse(VerseRow verse, bool includeTranslation)
  {
    string strVerseRef = verse.Number.ToString();
    int rowFactor = Convert.ToInt32(includeTranslation) + 1;
    int countWords = verse.Words.Count;
    const int CountColumns = 4;
    int indexWord = countWords - 1;
    int countRows = ( (int)Math.Ceiling((double)countWords / CountColumns) ) * rowFactor;
    var table = Document.InsertTable(countRows, CountColumns + 1);
    table.Alignment = Alignment.right;
    table.Design = TableDesign.None;
    for ( int row = 0; row < countRows; row += rowFactor )
    {
      var cellVerse = table.Rows[row].Cells[CountColumns];
      SetCellSize(cellVerse, 55, 0, includeTranslation ? 0 : 5, 0, 0);
      if ( includeTranslation )
      {
        var cellTranslation = table.Rows[row + 1].Cells[CountColumns];
        SetCellSize(cellTranslation, 55, 0, 5, 0, 0);
      }
      if ( row == 0 )
      {
        var pVerseRef = cellVerse.Paragraphs[0].Append(strVerseRef);
        pVerseRef.Direction = Direction.RightToLeft;
        pVerseRef.Font(FontCalibri);
        pVerseRef.FontSize(12);
        pVerseRef.Bold();
        cellVerse.VerticalAlignment = VerticalAlignment.Center;
      }
      var words = verse.Words.OrderByDescending(w => w.Number).ToList();
      for ( int i = 3; i >= 0 && indexWord >= 0; i--, indexWord-- )
      {
        var word = words[indexWord];
        string strWord = word.Hebrew;
        var cell = table.Rows[row].Cells[i];
        var pVerse = cell.Paragraphs[0].Append(strWord);
        cell.MarginTop = 5;
        pVerse.Direction = Direction.RightToLeft;
        pVerse.Font(FontHebrew);
        pVerse.FontSize(16);
        pVerse.Spacing(1);
        if ( includeTranslation )
        {
          string strTranslation = word.Translation;
          var pTranslation = table.Rows[row + 1].Cells[i].Paragraphs[0].Append(strTranslation);
          pTranslation.Direction = Direction.LeftToRight;
          pTranslation.Alignment = Alignment.right;
          pTranslation.Font(FontCalibri);
          pTranslation.FontSize(10);
        }
      }
    }
    if ( verse.Comment.Length > 0 )
    {
      Document.InsertParagraph("").FontSize(8);
      table = Document.InsertTable(1, 2);
      table.Alignment = Alignment.right;
      table.Design = TableDesign.None;
      table.Rows[0].Cells[0].Width = 555;
      table.Rows[0].Cells[1].Width = 55;
      var paragraph = table.Rows[0].Cells[0].Paragraphs[0];
      paragraph.Append(verse.Comment);
      paragraph.Direction = Direction.LeftToRight;
      paragraph.Font(FontCalibri);
      paragraph.FontSize(10);
    }
    Document.InsertParagraph().AppendLine();
  }

}
