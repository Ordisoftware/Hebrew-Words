﻿/// <license>
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
/// <edited> 2022-08 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class MainForm
{

  private void RenderChapterVerses(bool isGrouped = false)
  {
    if ( !isGrouped && !CanRender ) return;
    bool tempRendering = Globals.IsRendering;
    Globals.IsRendering = true;
    Globals.ChronoRendering.Restart();
    try
    {
      var itemBook = CurrentReference.Book;
      var itemChapter = CurrentReference.Chapter;
      if ( itemBook is null || itemChapter is null ) return;
      EditELS50Single.Text = itemChapter.ELS50;
      EditELS50Single.SelectionStart = EditELS50Single.TextLength;
      int numberBook = itemBook.Number;
      int numberChapter = itemChapter.Number;
      var references = SelectRenderAllVerses.Checked
        ? ( from book in ApplicationDatabase.Instance.Books
            from chapter in book.Chapters
            from verse in chapter.Verses
            where book.Number == numberBook && chapter.Number == numberChapter
            select new ReferenceItem(book, chapter, verse) ).ToList()
        : [CurrentReference];
      if ( SelectRenderAllVerses.Checked )
      {
        int controlsCount = references.Count * 2 + references.Sum(r => r.Verse.Words.Count);
        int countVerses = CurrentReference.Chapter.Verses.Count;
        LabelProgress.Text = AppTranslations.Rendering.GetLang(controlsCount, countVerses).ToUpper();
        LabelProgress.Refresh();
        PanelViewVerses.Visible = false;
        SetFormDisabled(true);
      }
      PanelViewVerses.DisposeAllControls();
      if ( references.Count > 0 )
      {
        int ypos = 0;
        var controls = new VerseControl[references.Count];
        for ( int index = 0; index < references.Count; index++ )
        {
          var control = new VerseControl(PanelViewVerses, references[index]) { Top = ypos };
          controls[index] = control;
          ypos += control.Height;
        }
        PanelViewVerses.Controls.AddRange(controls);
      }
    }
    catch ( Exception ex )
    {
      ex.Manage();
    }
    finally
    {
      Globals.IsRendering = tempRendering;
      if ( SelectRenderAllVerses.Checked )
      {
        PanelViewVerses.Visible = true;
        LabelProgress.Text = "";
        SetFormDisabled(false);
      }
      Globals.ChronoRendering.Stop();
      Settings.BenchmarkRendering = Globals.ChronoRendering.ElapsedMilliseconds;
    }
  }

}
