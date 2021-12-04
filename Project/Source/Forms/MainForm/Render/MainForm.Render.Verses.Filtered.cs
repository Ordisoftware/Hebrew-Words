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
/// <created> 2021-12 </created>
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class MainForm
{

  private void RenderVersesFiltered()
  {
    //if ( IsRendering ) return;
    //IsRendering = true;
    //Globals.ChronoRendering.Restart();
    //try
    //{
    //  if ( SelectRenderAllVerses.Checked ) PanelViewVerses.Visible = false;
    //  while ( PanelViewVerses.Controls.Count > 0 )
    //    PanelViewVerses.Controls[0].Dispose();
    //  if ( SelectRenderAllVerses.Checked ) SetFormDisabled(true);
    //  var itemBook = CurrentReference.Book;
    //  var itemChapter = CurrentReference.Chapter;
    //  if ( itemBook == null || itemChapter == null ) return;
    //  EditELS50.Text = itemChapter.ELS50;
    //  EditELS50.SelectionStart = EditELS50.TextLength;
    //  var references = SelectRenderAllVerses.Checked
    //                   ? from book in ApplicationDatabase.Instance.Books
    //                     from chapter in book.Chapters
    //                     from verse in chapter.Verses
    //                     where book.Number == itemBook.Number
    //                        && chapter.Number == itemChapter.Number
    //                     select new ReferenceItem(book, chapter, verse)
    //                   : new List<ReferenceItem> { CurrentReference };
    //}
    //catch ( Exception ex )
    //{
    //  ex.Manage();
    //}
    //finally
    //{
    //  if ( SelectRenderAllVerses.Checked )
    //    LabelProgress.Refresh();
    //  IsRendering = false;
    //  if ( SelectRenderAllVerses.Checked )
    //  {
    //    PanelViewVerses.Visible = true;
    //    LabelProgress.Text = "";
    //    SetFormDisabled(false);
    //  }
    //  Globals.ChronoRendering.Stop();
    //  Settings.BenchmarkRendering = Globals.ChronoRendering.ElapsedMilliseconds;
    //}
  }

}
