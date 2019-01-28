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
/// <created> 2015-06 </created>
/// <edited> 2015-06 </edited>
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using Ordisoftware.Core;
using Novacode;

namespace Ordisoftware.HebrewWords
{

  static public class ExportBooksDocX
  {

    static public Dictionary<string, string> ParashaNames = new Dictionary<string, string>()
    {
      { "01.01.1", "ty>arb t>rp" },
      { "09.06.1", "xn t>rp" },
      { "01.12.1", "kl kl t>rp" },
      { "01.18.1", "aryv t>rp" }
    };

    /// <summary>
    /// The document.
    /// </summary>
    /// <remarks>
    /// Measures in float or double are in inch: 100f = 1 inch = 2.65cm.
    /// </remarks>
    static private DocX Document = null;

    /// <summary>
    /// The font verdana.
    /// </summary>
    static private FontFamily FontVerdana = new FontFamily("Verdana");

    /// <summary>
    /// The font hebrew.
    /// </summary>
    static private FontFamily FontHebrew = new FontFamily("Hebrew");

    /// <summary>
    /// The font calibri.
    /// </summary>
    static private FontFamily FontCalibri = new FontFamily("Calibri");

    static int ColumnsCount = 4;
    static float TableWidth;
    static float ColumnVerseRefWidth;
    static float ColumnTitleWidth;
    static float ColumnVerseWidth;

    /*static int CentimeterToPixels(double Centimeter)
    {
      double pixel = -1;
      using ( Graphics g = new System.Drawing.Graphics() )
      {
        pixel = Centimeter * g.DpiY / 2.54d;
      }
      return (int)pixel;
    }*/

    /// <summary>
    /// Export to word.
    /// </summary>
    /// <param name="includeTranslation">true to include, false to exclude the translation.</param>
    /// <param name="showProgress">The show progress action.</param>
    static public void DoExport(Data.DataSet.BooksRow book, bool includeTranslation, Func<bool> showProgress)
    {
      //foreach ( AllBooks book in Enum.GetValues(typeof(TorahBooks)) )
      {
        string filename = @"d:\\" + book.Name + ".docx";
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
              {
                AddVerse(book, chapter, verse, includeTranslation);
              }
              //break;
            }
            Document.Save();
            //break;
          }
          catch ( Exception ex )
          {
            ex.Manage();
          }
      }
    }

    /// <summary>
    /// Adds a book title.
    /// </summary>
    /// <param name="book">The book.</param>
    static private void AddBookTitle(Data.DataSet.BooksRow book)
    {
      Document.InsertSectionPageBreak(false);
      AddTitle(book.Hebrew, FontHebrew, 32, "Heading1");
    }

    /// <summary>
    /// Adds a parasha title.
    /// </summary>
    /// <param name="strVerseRef">The verse reference.</param>
    static private void AddParashaTitle(string strVerseRef)
    {
      AddTitle(ParashaNames[strVerseRef], FontHebrew, 24, "Heading2");
    }

    /// <summary>
    /// Adds a title.
    /// </summary>
    /// <param name="str">The string.</param>
    /// <param name="font">The font.</param>
    /// <param name="size">The size.</param>
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

    static private void SetCellSize(Cell cell, int width, int marginTop, int marginBottom, int MarginLeft, int MarginRight)
    {
      cell.Width = width;
      cell.MarginTop = marginTop;
      cell.MarginBottom = marginBottom;
      cell.MarginLeft = MarginLeft;
      cell.MarginRight = MarginRight;
    }

    /// <summary>
    /// Adds a verse.
    /// </summary>
    /// <param name="book">The book.</param>
    /// <param name="chapter">The chapter.</param>
    /// <param name="verse">The verse.</param>
    /// <param name="includeTranslation">true to include, false to exclude the translation.</param>
    static private void AddVerse(Data.DataSet.BooksRow book, Data.DataSet.ChaptersRow chapter, Data.DataSet.VersesRow verse, bool includeTranslation)
    {
      string strVerseRef = verse.Number.ToString();
      if ( ParashaNames.Keys.Contains(strVerseRef) ) AddParashaTitle(strVerseRef);
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
          //pVerseRef.Color(System.Drawing.Color.FromArgb(16, 16, 16));
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
      Document.InsertParagraph("").FontSize(8);
    }

  }

}
