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
/// <created> 2019-09 </created>
/// <edited> 2019-09 </edited>
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  public partial class MainForm
  {

    private List<ReferenceItem> Bookmarks = new List<ReferenceItem>();

    internal void UpdateBookmarks()
    {
      while ( MenuBookmarks.DropDownItems.Count > 2 )
        MenuBookmarks.DropDownItems.RemoveAt(2);
      var bookmarkMaster = new ReferenceItem();
      bookmarkMaster.Book = DataSet.Books[Program.Settings.BookmarkMasterBook - 1];
      bookmarkMaster.Chapter = DataSet.Chapters[Program.Settings.BookmarkMasterChapter - 1];
      bookmarkMaster.Verse = DataSet.Verses[Program.Settings.BookmarkMasterVerse - 1];
      ToolStripItem item = MenuBookmarks.DropDownItems.Add(bookmarkMaster.ToString());
      item.Tag = bookmarkMaster;
      item.Click += Item_Click;
      item.ImageScaling = ToolStripItemImageScaling.None;
      item.Image = ActionSetAsBookmarkMaster.Image;
      MenuBookmarks.DropDownItems.Add("-");
      foreach ( var reference in Bookmarks )
      {
        item = MenuBookmarks.DropDownItems.Add(reference.ToString());
        item.Tag = reference;
        item.Click += Item_Click;
        item.ImageScaling = ToolStripItemImageScaling.None;
        item.Image = ActionAddToBookmarks.Image;
      }
    }

    private void Item_Click(object sender, EventArgs e)
    {
      GoTo((ReferenceItem)( (ToolStripMenuItem)sender ).Tag);
    }

    internal void AddBookmark(ReferenceItem reference)
    {
      Bookmarks.Add(reference);
    }

  }

}
