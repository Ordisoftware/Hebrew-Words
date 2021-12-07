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
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class MainForm
{

  private void RenderVerses()
  {
    if ( Globals.IsRendering ) return;
    Globals.IsRendering = true;
    Globals.ChronoRendering.Restart();
    try
    {
      if ( SelectRenderAllVerses.Checked ) PanelViewVerses.Visible = false;
      if ( SelectRenderAllVerses.Checked ) SetFormDisabled(true);
      var itemBook = CurrentReference.Book;
      var itemChapter = CurrentReference.Chapter;
      if ( itemBook == null || itemChapter == null ) return;
      EditELS50.Text = itemChapter.ELS50;
      EditELS50.SelectionStart = EditELS50.TextLength;
      var references = SelectRenderAllVerses.Checked
                 ? ( from book in ApplicationDatabase.Instance.Books
                     from chapter in book.Chapters
                     from verse in chapter.Verses
                     where book.Number == itemBook.Number
                        && chapter.Number == itemChapter.Number
                     select new ReferenceItem(book, chapter, verse) ).ToList()
                 : new List<ReferenceItem> { CurrentReference };
      int controlsCount = references.Count * 2 + references.Select(r => r.Verse.Words.Count).Sum();
      LabelProgress.Text = AppTranslations.Rendering.GetLang(controlsCount, CurrentReference.Chapter.Verses.Count).ToUpper();
      LabelProgress.Refresh();
      RenderVerses(PanelViewVerses, references);
    }
    catch ( Exception ex )
    {
      ex.Manage();
    }
    finally
    {
      Globals.IsRendering = false;
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
