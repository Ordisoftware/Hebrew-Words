/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2021 Olivier Rogier.
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
/// <edited> 2021-04 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class MainForm
{

  private void DoExportBook()
  {
    var book = CurrentReference.Book;
    switch ( Settings.CurrentView )
    {
      case ViewMode.ChapterVerses:
        SaveFileDialogMSWord.FileName = book.Name + ".docx";
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
          ExportDocX.Run(SaveFileDialogMSWord.FileName, book, true, showProgress);
        }
        finally
        {
          SetFormDisabled(false);
          form.Close();
        }
        break;
      case ViewMode.BookELS50:
        SaveFileDialogRTF.FileName = book.Name + " ELS50.rtf";
        if ( SaveFileDialogRTF.ShowDialog() == DialogResult.Cancel ) return;
        EditChapterELS50.SaveFile(SaveFileDialogRTF.FileName);
        if ( Settings.AutoOpenExportedFile )
          SystemManager.RunShell(SaveFileDialogRTF.FileName);
        break;
      default:
        throw new AdvancedNotImplementedException(Settings.CurrentView);
    }
  }

  private void DoExportChapter()
  {
    var book = CurrentReference.Book;
    var chapter = CurrentReference.Chapter;
    switch ( Settings.CurrentView )
    {
      case ViewMode.ChapterVerses:
        SaveFileDialogMSWord.FileName = book.Name + " " + chapter.Number + ".docx";
        if ( SaveFileDialogMSWord.ShowDialog() == DialogResult.Cancel ) return;
        SetFormDisabled(true);
        try
        {
          ExportDocX.Run(SaveFileDialogMSWord.FileName, book, chapter, true);
        }
        finally
        {
          SetFormDisabled(false);
        }
        break;
      case ViewMode.ChapterTranslation:
        SaveFileDialogRTF.FileName = book.Name + " " + chapter.Number + " Translation.rtf";
        if ( SaveFileDialogRTF.ShowDialog() == DialogResult.Cancel ) return;
        EditChapterTranslation.SaveFile(SaveFileDialogRTF.FileName);
        if ( Settings.AutoOpenExportedFile )
          SystemManager.RunShell(SaveFileDialogRTF.FileName);
        break;
      case ViewMode.ChapterOriginal:
        SaveFileDialogRTF.FileName = book.Name + " " + chapter.Number + " Hebrew.rtf";
        if ( SaveFileDialogRTF.ShowDialog() == DialogResult.Cancel ) return;
        EditChapterOriginal.SaveFile(SaveFileDialogRTF.FileName);
        if ( Settings.AutoOpenExportedFile )
          SystemManager.RunShell(SaveFileDialogRTF.FileName);
        break;
      default:
        throw new AdvancedNotImplementedException(Settings.CurrentView);
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
      SaveFileDialogMSWord.FileName = new ReferenceItem(book, chapter, verse).ToString() + ".docx";
      if ( SaveFileDialogMSWord.ShowDialog() == DialogResult.Cancel ) return;
      ExportDocX.Run(SaveFileDialogMSWord.FileName, book, chapter, true, verse.Number);
    }
    else
    if ( control is Label && Settings.CurrentView == ViewMode.ChapterVerses )
    {
      var book = CurrentReference.Book;
      var chapter = CurrentReference.Chapter;
      int verse = Convert.ToInt32(control.Text);
      SaveFileDialogMSWord.FileName = new ReferenceItem(book.Number, chapter.Number, verse).ToString() + ".docx";
      if ( SaveFileDialogMSWord.ShowDialog() == DialogResult.Cancel ) return;
      ExportDocX.Run(SaveFileDialogMSWord.FileName, book, chapter, true, verse);
    }
    else
      throw new AdvancedNotImplementedException(Settings.CurrentView);
  }

}
