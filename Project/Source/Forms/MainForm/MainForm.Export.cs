/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2020 Olivier Rogier.
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
/// <edited> 2019-09 </edited>
using System;
using System.Windows.Forms;
using Ordisoftware.HebrewCommon;
using Ordisoftware.Core;

namespace Ordisoftware.HebrewWords
{

  public partial class MainForm
  {

    private void DoExportBook()
    {
      var book = CurrentReference.Book;
      switch ( Program.Settings.CurrentView )
      {
        case ViewMode.Verses:
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
            Func<bool> showProgress = () =>
            {
              form.ProgressBar.PerformStep();
              Application.DoEvents();
              return form.CancelRequired;
            };
            ExportDocX.Run(SaveFileDialogMSWord.FileName, book, true, showProgress);
          }
          finally
          {
            SetFormDisabled(false);
            form.Close();
          }
          break;
        case ViewMode.ELS50:
          SaveFileDialogRTF.FileName = book.Name + " ELS50.rtf";
          if ( SaveFileDialogRTF.ShowDialog() == DialogResult.Cancel ) return;
          EditELS50All.SaveFile(SaveFileDialogRTF.FileName);
          if ( Program.Settings.OpenGeneratedMSWordFiles )
            SystemHelper.RunShell(SaveFileDialogRTF.FileName);
          break;
        default:
          DisplayManager.ShowAdvert("Not implemented.");
          break;
      }
    }

    private void DoExportChapter()
    {
      var book = CurrentReference.Book;
      var chapter = CurrentReference.Chapter;
      switch ( Program.Settings.CurrentView )
      {
        case ViewMode.Verses:
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
        case ViewMode.Translations:
          SaveFileDialogRTF.FileName = book.Name + " " + chapter.Number + " Translation.rtf";
          if ( SaveFileDialogRTF.ShowDialog() == DialogResult.Cancel ) return;
          EditTranslations.SaveFile(SaveFileDialogRTF.FileName);
          if ( Program.Settings.OpenGeneratedMSWordFiles )
            SystemHelper.RunShell(SaveFileDialogRTF.FileName);
          break;
        case ViewMode.Text:
          SaveFileDialogRTF.FileName = book.Name + " " + chapter.Number + " Hebrew.rtf";
          if ( SaveFileDialogRTF.ShowDialog() == DialogResult.Cancel ) return;
          EditRawText.SaveFile(SaveFileDialogRTF.FileName);
          if ( Program.Settings.OpenGeneratedMSWordFiles )
            SystemHelper.RunShell(SaveFileDialogRTF.FileName);
          break;
        default:
          DisplayManager.ShowAdvert("Not implemented.");
          break;
      }
    }

    private void DoExportVerse(object sender)
    {
      var menuitem = (ToolStripMenuItem)sender;
      var control = ( (ContextMenuStrip)menuitem.Owner ).SourceControl;
      if ( control is LinkLabel && Program.Settings.CurrentView == ViewMode.Search )
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
      if ( control is Label && Program.Settings.CurrentView == ViewMode.Verses )
      {
        var book = CurrentReference.Book;
        var chapter = CurrentReference.Chapter;
        int verse = Convert.ToInt32(control.Text);
        SaveFileDialogMSWord.FileName = new ReferenceItem(book.Number, chapter.Number, verse).ToString() + ".docx";
        if ( SaveFileDialogMSWord.ShowDialog() == DialogResult.Cancel ) return;
        ExportDocX.Run(SaveFileDialogMSWord.FileName, book, chapter, true, verse);
      }
    }

  }

}
