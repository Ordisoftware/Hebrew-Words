﻿/// <license>
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
using System.Linq;
using Ordisoftware.Core;
using Novacode;

namespace Ordisoftware.HebrewWords
{

  static public class ExportDocX
  {

    /// <summary>
    /// The document.
    /// </summary>
    /// <remarks>
    /// Measures in float or double are in inch: 100f = 1 inch = 2.65cm.
    /// </remarks>
    static private DocX Document = null;

    static private FontFamily FontVerdana = new FontFamily("Verdana");

    static private FontFamily FontHebrew = new FontFamily("Hebrew");

    static private FontFamily FontCalibri = new FontFamily("Calibri");

    static int ColumnsCount = 4;
    static float TableWidth;
    static float ColumnVerseRefWidth;
    static float ColumnTitleWidth;
    static float ColumnVerseWidth;

    static public void Run(string filename, Data.DataSet.BooksRow book, bool includeTranslation, Func<bool> showProgress)
    {
      {
        using ( Document = DocX.Create(filename, DocumentTypes.Document) )
          try
          {
            Document.MarginTop = 113.5f;
            Document.MarginBottom = 113.5f;
            Document.MarginLeft = 94.5f;
            Document.MarginRight = 94.5f;
            Document.DifferentOddAndEvenPages = true;
            AddBookTitle(book);
            foreach ( Data.DataSet.ChaptersRow chapter in book.GetChaptersRows() )
            {
              if ( showProgress != null )
                if ( showProgress() )
                  break;
              foreach ( Data.DataSet.VersesRow verse in chapter.GetVersesRows() )
                AddVerse(verse, includeTranslation);
            }
            Document.Save();
          }
          catch ( Exception ex )
          {
            ex.Manage();
          }
      }
    }

    static private void AddBookTitle(Data.DataSet.BooksRow book)
    {
      Document.InsertSectionPageBreak(false);
      AddTitle(book.Hebrew, FontHebrew, 32, "Heading1");
    }

    static private void AddTitle(string str, FontFamily font, int size, string styleName)
    {
      Table table = Document.InsertTable(1, 2);
      table.Alignment = Alignment.right;
      table.Design = TableDesign.None;
      table.Rows[0].Cells[0].Width = 555;
      table.Rows[0].Cells[1].Width = 55;
      var paragraph = table.Rows[0].Cells[0].Paragraphs.First();
      paragraph.StyleName = styleName;
      paragraph.Append(str);
      paragraph.Direction = Direction.RightToLeft;
      paragraph.Font(font);
      paragraph.FontSize(size);
      Document.InsertParagraph().AppendLine();
    }

    static private void AddComment(string str, FontFamily font, int size)
    {
      Document.InsertParagraph("").FontSize(8);
      Table table = Document.InsertTable(1, 2);
      table.Alignment = Alignment.right;
      table.Design = TableDesign.None;
      table.Rows[0].Cells[0].Width = 555;
      table.Rows[0].Cells[1].Width = 55;
      var paragraph = table.Rows[0].Cells[0].Paragraphs.First();
      paragraph.Append(str);
      paragraph.Direction = Direction.LeftToRight;
      paragraph.Font(font);
      paragraph.FontSize(size);
      paragraph.Italic();
    }

    static private void SetCellSize(Cell cell, int width, int marginTop, int marginBottom, int MarginLeft, int MarginRight)
    {
      cell.Width = width;
      cell.MarginTop = marginTop;
      cell.MarginBottom = marginBottom;
      cell.MarginLeft = MarginLeft;
      cell.MarginRight = MarginRight;
    }

    static private void AddVerse(Data.DataSet.VersesRow verse, bool includeTranslation)
    {
      string strVerseRef = verse.Number.ToString();
      int rowFactor = Convert.ToInt32(includeTranslation) + 1;
      int countWords = verse.GetWordsRows().Count();
      int CountColumns = 4;
      int indexWord = countWords - 1;
      int countRows = ( (int)Math.Ceiling((double)countWords / (double)CountColumns) ) * rowFactor;
      Table table = Document.InsertTable(countRows, CountColumns + 1);
      table.Alignment = Alignment.right;
      table.Design = TableDesign.None;
      for ( int row = 0; row < countRows; row += rowFactor )
      {
        var cellVerse = table.Rows[row].Cells[CountColumns];
        SetCellSize(cellVerse, 55, 5, 0, 0, 0);
        if ( includeTranslation )
        {
          var cellTranslation = table.Rows[row + 1].Cells[CountColumns];
          SetCellSize(cellTranslation, 55, 5, 0, 0, 0);
        }
        if ( row == 0 )
        {
          var pVerseRef = cellVerse.Paragraphs.First().Append(strVerseRef);
          pVerseRef.Direction = Direction.RightToLeft;
          pVerseRef.Font(FontCalibri);
          pVerseRef.FontSize(12);
          pVerseRef.Bold();
          cellVerse.VerticalAlignment = VerticalAlignment.Center;
        }
        var words = verse.GetWordsRows().OrderByDescending(w => w.Number).ToList();
        for ( int i = 3; i >= 0 && indexWord >= 0; i--, indexWord-- )
        {
          var word = words[indexWord];
          string strWord = word.Hebrew;
          string strTranslation = word.Translation;
          var cell = table.Rows[row].Cells[i];
          var pVerse = cell.Paragraphs.First().Append(strWord);
          cell.MarginTop = 5;
          pVerse.Direction = Direction.RightToLeft;
          pVerse.Font(FontHebrew);
          pVerse.FontSize(16);
          pVerse.Spacing(1);
          if ( includeTranslation )
          {
            table.Rows[row + 1].Cells[i].MarginTop = 0;
            var pTranslation = table.Rows[row + 1].Cells[i].Paragraphs.First().Append(strTranslation);
            pTranslation.Direction = Direction.LeftToRight;
            pTranslation.Alignment = Alignment.right;
            pTranslation.Font(FontCalibri);
            pTranslation.FontSize(10);
          }
        }
      }
      if ( verse.Comment != "") AddComment(verse.Comment, FontCalibri, 10);
      Document.InsertParagraph().AppendLine();
    }

  }

}
