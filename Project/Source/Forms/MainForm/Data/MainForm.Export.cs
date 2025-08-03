/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2025 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at
/// https://mozilla.org/MPL/2.0/.
/// If it is not possible or desirable to put the notice in a particular file,
/// then You may include the notice in a location(such as a LICENSE file in a
/// relevant directory) where a recipient would be likely to look for such a notice.
/// You may add additional accurate notices of copyright ownership.
/// </license>
/// <created> 2019-01 </created>
/// <edited> 2022-03 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class MainForm
{

  [SuppressMessage("Correctness", "SS018:Add cases for missing enum member.", Justification = "N/A")]
  private void DoExportBook()
  {
    var book = CurrentReference.Book;
    switch ( Settings.CurrentView )
    {
      case ViewMode.ChapterVerses:
        SaveFileDialogMSWord.FileName = book.Transcription + ".docx";
        if ( SaveFileDialogMSWord.ShowDialog() == DialogResult.Cancel ) return;
        var form = new ExportingForm();
        SetFormDisabled(true);
        try
        {
          form.ProgressBar.Value = 0;
          form.ProgressBar.Maximum = SelectChapter.Items.Count;
          form.Show();
          form.Refresh();
          bool showProgress()
          {
            form.ProgressBar.PerformStep();
            Application.DoEvents();
            return form.CancelRequired;
          }
          ExportDocX.CreateBook(SaveFileDialogMSWord.FileName, book, showProgress);
        }
        finally
        {
          SetFormDisabled(false);
          form.Close();
        }
        break;
      case ViewMode.BookELS50:
        SaveFileDialogRTF.FileName = book.Transcription + " ELS50.rtf";
        if ( SaveFileDialogRTF.ShowDialog() == DialogResult.Cancel ) return;
        EditChapterELS50.SaveFile(SaveFileDialogRTF.FileName);
        if ( Settings.AutoOpenExportedFile )
          SystemManager.RunShell(SaveFileDialogRTF.FileName);
        break;
      default:
        throw new AdvNotImplementedException(Settings.CurrentView);
    }
  }

  [SuppressMessage("Correctness", "SS018:Add cases for missing enum member.", Justification = "N/A")]
  private void DoExportChapter()
  {
    var book = CurrentReference.Book;
    var chapter = CurrentReference.Chapter;
    switch ( Settings.CurrentView )
    {
      case ViewMode.ChapterVerses:
        SaveFileDialogMSWord.FileName = $"{book.Transcription} {chapter.Number}.docx";
        if ( SaveFileDialogMSWord.ShowDialog() == DialogResult.Cancel ) return;
        SetFormDisabled(true);
        try
        {
          ExportDocX.CreateChapter(SaveFileDialogMSWord.FileName, book, chapter);
        }
        finally
        {
          SetFormDisabled(false);
        }
        break;
      case ViewMode.ChapterTranslation:
        SaveFileDialogRTF.FileName = $"{book.Transcription} {chapter.Number} Translation.rtf";
        if ( SaveFileDialogRTF.ShowDialog() == DialogResult.Cancel ) return;
        TextBoxTranslations.SaveFile(SaveFileDialogRTF.FileName);
        if ( Settings.AutoOpenExportedFile )
          SystemManager.RunShell(SaveFileDialogRTF.FileName);
        break;
      case ViewMode.ChapterOriginal:
        SaveFileDialogRTF.FileName = $"{book.Transcription} {chapter.Number} Hebrew.rtf";
        if ( SaveFileDialogRTF.ShowDialog() == DialogResult.Cancel ) return;
        EditChapterOriginal.SaveFile(SaveFileDialogRTF.FileName);
        if ( Settings.AutoOpenExportedFile )
          SystemManager.RunShell(SaveFileDialogRTF.FileName);
        break;
      default:
        throw new AdvNotImplementedException(Settings.CurrentView);
    }
  }

  private void DoExportVerse(object sender)
  {
    var menuitem = (ToolStripMenuItem)sender;
    var control = ( (ContextMenuStrip)menuitem.Owner ).SourceControl;
    if ( control is LinkLabel && Settings.CurrentView == ViewMode.Search )
    {
      var reference = (ReferenceItem)control.Tag;
      var book = reference.Book;
      var chapter = reference.Chapter;
      var verse = reference.Verse;
      SaveFileDialogMSWord.FileName = new ReferenceItem(book, chapter, verse) + ".docx";
      if ( SaveFileDialogMSWord.ShowDialog() == DialogResult.Cancel ) return;
      ExportDocX.CreateVerse(SaveFileDialogMSWord.FileName, book, chapter, verse.Number);
    }
    else
    if ( control is Label && Settings.CurrentView == ViewMode.ChapterVerses )
    {
      var book = CurrentReference.Book;
      var chapter = CurrentReference.Chapter;
      int verse = Convert.ToInt32(control.Text);
      SaveFileDialogMSWord.FileName = new ReferenceItem(book.Number, chapter.Number, verse) + ".docx";
      if ( SaveFileDialogMSWord.ShowDialog() == DialogResult.Cancel ) return;
      ExportDocX.CreateVerse(SaveFileDialogMSWord.FileName, book, chapter, verse);
    }
    else
      throw new AdvNotImplementedException(Settings.CurrentView);
  }

}
