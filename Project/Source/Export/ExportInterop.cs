/*/// <license>
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
/// <created> 2015-06 </created>
/// <edited> 2015-06 </edited>
using System;
using System.Drawing;
using Ordisoftware.Core;
using Ordisoftware.Core.Diagnostics;
using System.Drawing;
using System.Linq;
using Microsoft.Office.Interop.Word;

// Change Reference to "Microsoft Office [installed version] Object Library"
// Sample: Word 2007 = 12.0 & Word 2010 = 14.0

namespace Ordisoftware.HebrewWords
{

  static public class ExportBooksInterop
  {

    static public Dictionary<string, string> ParashaNames = new Dictionary<string, string>()
    {
      { "01.01.1", "ty>arb t>rp" },
      { "09.06.1", "xn t>rp" },
      { "01.12.1", "kl kl t>rp" },
      { "01.18.1", "aryv t>rp" }
    };

    /// <summary>
    /// The font verse reference.
    /// </summary>
    static private string fontVerseRef = "Verdana";

    /// <summary>
    /// The font hebrew.
    /// </summary>
    static private string fontHebrew = "Hebrew";

    /// <summary>
    /// The font translation.
    /// </summary>
    static private string fontTranslation = "Calibri";

    /// <summary>
    /// The word application.
    /// </summary>
    static private _Application WordApp;

    /// <summary>
    /// The document.
    /// </summary>
    static private _Document Document;

    /// <summary>
    /// The object end of document flag.
    /// </summary>
    static object EndOfRangeIndex = "\\endofdoc";

    /// <summary>
    /// The object missing.
    /// </summary>
    static object MissingValue = System.Reflection.Missing.Value;

    static int ColumnsCount = 4;
    static float TableWidth;
    static float ColumnVerseRefWidth;
    static float ColumnTitleWidth;
    static float ColumnVerseWidth;

    /// <summary>
    /// Export to word.
    /// </summary>
    /// <param name="includeVerseRef">true to include, false to exclude the verse reference.</param>
    /// <param name="includeTranslation">true to include, false to exclude the translation.</param>
    /// <param name="showProgress">The show progress action.</param>
    static public void DoExport(Data.DataSet.BooksRow book, bool includeVerseRef, bool includeTranslation, Action<string> showProgress)
    {

      string wordprocess = @"c:\Program Files\Microsoft Office\Office14\WINWORD.EXE";
      //foreach ( Books book in Enum.GetValues(typeof(TorahBooks)) )
      {
        string filename = @"e:\\Torah " + book.Name + ".docx";
        WordApp = new Application();
        WordApp.Visible = true;
        TableWidth = WordApp.CentimetersToPoints(15f);
        ColumnVerseRefWidth = WordApp.CentimetersToPoints(1.5f);
        ColumnTitleWidth = TableWidth - ColumnVerseRefWidth;
        ColumnVerseWidth = ColumnTitleWidth / ColumnsCount;
        Document = WordApp.Documents.Add(ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue);
        Document.PageSetup.TopMargin = WordApp.CentimetersToPoints(3f);
        Document.PageSetup.BottomMargin = WordApp.CentimetersToPoints(3f);
        Document.PageSetup.LeftMargin = WordApp.CentimetersToPoints(2.5f);
        Document.PageSetup.RightMargin = WordApp.CentimetersToPoints(2.5f);
        Document.PageSetup.Gutter = WordApp.CentimetersToPoints(1f);
        Document.PageSetup.MirrorMargins = -1;
        Document.PageSetup.PaperSize = Microsoft.Office.Interop.Word.WdPaperSize.wdPaperA4;
        Document.PageSetup.OddAndEvenPagesHeaderFooter = -1;
        AddBookTitle(book.Hebrew);
        for ( int chapter = 0; chapter < Books.Instance[book].Count(); chapter++ )
        {
          //if ( showProgress != null ) showProgress(book.ToString() + "." + chapter.ToString()); 
          for ( int verse = 0; verse < Books.Instance[book][chapter].Count(); verse++ )
          {
            if ( showProgress != null ) showProgress(book.ToString() + "." + chapter.ToString() + "." + verse.ToString());
            AddVerse(book, chapter, verse, includeVerseRef, includeTranslation);
            //break;
          }
          //break;
        }
        object objFileName = (object)filename;
        //Document.SaveAs(ref objFileName, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing, ref objMissing);
        //break;
      }
    }

    /// <summary>
    /// Add line.
    /// </summary>
    static private void AddLine()
    {
      object range = Document.Bookmarks.get_Item(ref EndOfRangeIndex).Range;
      var paragraph = Document.Content.Paragraphs.Add(ref range);
      paragraph.Format.SpaceBefore = 0;
      paragraph.Format.SpaceAfter = 0;
      paragraph.Range.Font.Size = 8;
    }

    /// <summary>
    /// Adds a book title.
    /// </summary>
    /// <param name="book">The book.</param>
    static private void AddBookTitle(Data.DataSet.BooksRow book)
    {
      object type = WdBreakType.wdSectionBreakOddPage;
      Document.Bookmarks.get_Item(ref EndOfRangeIndex).Range.InsertBreak(ref type);
      AddTitle(book.Hebrew + " rpc", 32);
    }

    /// <summary>
    /// Adds a parasha title.
    /// </summary>
    /// <param name="strVerseRef">The verse reference.</param>
    static private void AddParashaTitle(string strVerseRef)
    {
      AddTitle(ParashaNames[strVerseRef] + " t>rp", 24);
    }

    /// <summary>
    /// Adds a title.
    /// </summary>
    /// <param name="str">The string.</param>
    /// <param name="size">The size.</param>
    static private void AddTitle(string str, int size)
    {
      var range = Document.Bookmarks.get_Item(ref EndOfRangeIndex).Range;
      var table = Document.Tables.Add(range, 1, 2, ref MissingValue, ref MissingValue);
      table.PreferredWidthType = WdPreferredWidthType.wdPreferredWidthPoints;
      table.Rows.Alignment = WdRowAlignment.wdAlignRowRight;
      table.Rows[1].Range.Font.Name = fontHebrew;
      table.Rows[1].Range.Font.Size = size;
      table.Columns[1].Width = ColumnTitleWidth;
      table.Columns[2].Width = ColumnVerseRefWidth;
      table.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
      table.Range.ParagraphFormat.SpaceBefore = 0;
      table.Range.ParagraphFormat.SpaceAfter = 24;
      table.Borders.Enable = 0;
      table.Cell(1, 1).Range.Text = str;
      AddLine();
    }

    /// <summary>
    /// Adds a verse.
    /// </summary>
    /// <param name="book">The book.</param>
    /// <param name="chapter">The chapter.</param>
    /// <param name="verse">The verse.</param>
    /// <param name="includeVerseRef">true to include, false to exclude the verse reference.</param>
    /// <param name="includeTranslation">true to include, false to exclude the translation.</param>
    static private void AddVerse(Data.DataSet.BooksRow book, int chapter, int verse, bool includeVerseRef, bool includeTranslation)
    {
      string strVerseRef = String.Format("{0,2:00}.{1,2:00}.{2,1:0}", verse + 1, chapter + 1, (int)book + 1);
      if ( ParashaNames.Keys.Contains(strVerseRef) ) AddParashaTitle(strVerseRef);
      int rowFactor = includeTranslation ? 2 : 1;
      int countWords = Books.Instance[book][chapter][verse].Count;
      int indexWord = countWords - 1;
      int countRows = ((int)Math.Ceiling((double)(countWords / ColumnsCount)) + 1) * ( rowFactor);
      var rangeTable = Document.Bookmarks.get_Item(ref EndOfRangeIndex).Range;
      var table = Document.Tables.Add(rangeTable, countRows, ColumnsCount + 1, ref MissingValue, ref MissingValue);
      table.PreferredWidthType = WdPreferredWidthType.wdPreferredWidthPoints;
      table.Rows.Alignment = WdRowAlignment.wdAlignRowRight;
      table.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
      table.Range.ParagraphFormat.SpaceBefore = 10;
      table.Range.ParagraphFormat.SpaceAfter = 0;
      table.Range.Font.Name = "Hebrew";
      table.Range.Font.Size = 16;
      table.Range.Font.Spacing = 1;
      table.Columns[ColumnsCount + 1].Width = ColumnVerseRefWidth;
      for ( int index = 1; index <= ColumnsCount; index++ ) 
        table.Columns[index].Width = ColumnVerseWidth;
      for ( int row = 1; row <= countRows; row += rowFactor )
      {
        table.Rows[row].Range.Cells.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
        if ( row == 1 )
        {
          var cellVerseRef = table.Cell(row, ColumnsCount + 1);
          cellVerseRef.Range.Font.Color = WdColor.wdColorGray50;
          cellVerseRef.Range.Font.Name = fontVerseRef;
          cellVerseRef.Range.Font.Size = 8;
          table.Range.Font.Spacing = 0;
          cellVerseRef.Range.Text = strVerseRef;
        }
        if ( includeTranslation )
        {
          var rangeRow = table.Rows[row + 1].Range;
          rangeRow.ParagraphFormat.SpaceBefore = 0;
          rangeRow.ParagraphFormat.SpaceAfter = 0;
          rangeRow.Font.Name = fontTranslation;
          rangeRow.Font.Size = 8;
          rangeRow.Font.Spacing = 0;
        }
        for ( int i = ColumnsCount; i >= 1 && indexWord >= 0; i--, indexWord-- )
        {
          var word = Books.Instance[book][chapter][verse][indexWord];
          table.Cell(row, i).Range.Text = word.Hebrew;
          if ( includeTranslation ) table.Cell(row + 1, i).Range.Text = word.Translation;
        }
      }
      AddLine();
    }

  }

}
*/