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

[SuppressMessage("Design", "GCop179:Do not hardcode numbers, strings or other values. Use constant fields, enums, config files or database as appropriate.", Justification = "<En attente>")]
static partial class ExportDocX
{

  // TODO add option to convert " in '«•' and '•»' (utiliser un bool alternatif depuis le premier rencontré)

  /// <summary>
  /// Indicates the DocX document.
  /// </summary>
  /// <remarks>
  /// Measures in float or double are in inch: 100f = 1 inch = 2.54cm.
  /// </remarks>
  static private DocX Document;

  static private readonly Properties.Settings Settings = Program.Settings;

  static private bool WithHebrew
    => Settings.ExportDocumentModel != ExportDocumentModel.OnlyTranslation
    && Settings.ExportDocumentModel != ExportDocumentModel.OnlyTranslationWithComment;

  static private bool WithTranslation
    => Settings.ExportDocumentModel != ExportDocumentModel.OnlyHebrew
    && Settings.ExportDocumentModel != ExportDocumentModel.OnlyHebrewWithComment;

  static private bool WithMemo
    => Settings.ExportDocumentModel == ExportDocumentModel.WordForWordWithComment
    || Settings.ExportDocumentModel == ExportDocumentModel.HebrewWithComment
    || Settings.ExportDocumentModel == ExportDocumentModel.OnlyHebrewWithComment
    || Settings.ExportDocumentModel == ExportDocumentModel.OnlyTranslationWithComment;

  /// <summary>
  /// Exports a book to MS Word file.
  /// </summary>
  [SuppressMessage("Style", "GCop408:Flag or switch parameters (bool) should go after all non-optional parameters. If the boolean parameter is not a flag or switch, split the method into two different methods, each doing one thing.", Justification = "Opinion")]
  static public void CreateBook(string filePath, BookRow book, Func<bool> showProgress)
  {
    using ( Document = DocX.Create(filePath, DocumentTypes.Document) )
      try
      {
        SetPageProperties();
        AddBookTitle(book, true);
        foreach ( ChapterRow chapter in book.Chapters )
        {
          if ( showProgress is not null && showProgress() ) break;
          AddChapterTitle(chapter, WithMemo);
          foreach ( VerseRow verse in chapter.Verses )
          {
            string referenceText = Settings.ExportWordPrintFullReference
              ? new ReferenceItem(book.Number, chapter.Number, verse.Number).ToStringOnlyNumbersNoBook()
              : verse.Number.ToString();
            AddVerse(verse, referenceText);
          }
        }
        Document.Save();
        if ( Settings.AutoOpenExportedFile )
          SystemManager.RunShell(filePath);
      }
      catch ( IOException ex )
      {
        DisplayManager.ShowError(ex.Message);
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
  }

  /// <summary>
  /// Exports a chapter to MS Word file.
  /// </summary>
  static public void CreateChapter(string filePath, BookRow book, ChapterRow chapter)
  {
    using ( Document = DocX.Create(filePath, DocumentTypes.Document) )
      try
      {
        SetPageProperties();
        AddBookTitle(book, WithMemo);
        AddChapterTitle(chapter, WithMemo);
        foreach ( VerseRow verse in chapter.Verses )
        {
          string strref = Settings.ExportWordPrintFullReference
            ? new ReferenceItem(book.Number, chapter.Number, verse.Number).ToStringOnlyNumbersNoBook()
            : verse.Number.ToString();
          AddVerse(verse, strref);
        }
        Document.Save();
        if ( Settings.AutoOpenExportedFile )
          SystemManager.RunShell(filePath);
      }
      catch ( IOException ex )
      {
        DisplayManager.ShowError(ex.Message);
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
  }

  /// <summary>
  /// Exports a verse to a MS Word file without book and chapter memos.
  /// </summary>
  static public void CreateVerse(string filePath, BookRow book, ChapterRow chapter, int verse)
  {
    using ( Document = DocX.Create(filePath, DocumentTypes.Document) )
      try
      {
        SetPageProperties();
        AddBookTitle(book, false);
        AddChapterTitle(chapter, false);
        string referenceText = Settings.ExportWordPrintFullReference
          ? new ReferenceItem(book.Number, chapter.Number, verse).ToStringOnlyNumbersNoBook()
          : verse.ToString();
        AddVerse(chapter.Verses[verse - 1], referenceText);
        Document.Save();
        if ( Settings.AutoOpenExportedFile )
          SystemManager.RunShell(filePath);
      }
      catch ( IOException ex )
      {
        DisplayManager.ShowError(ex.Message);
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
  }

}
