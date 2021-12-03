﻿/// <license>
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
/// <created> 2019-09 </created>
/// <edited> 2021-04 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class MainForm
{

  private void UpdateBookmarks()
  {
    try
    {
      if ( Program.Settings.AutoSortBookmarks )
        Bookmarks.Sort();
      while ( MenuBookmarks.DropDownItems.Count > BookmarksMenuFirstIndex )
        MenuBookmarks.DropDownItems.RemoveAt(BookmarksMenuFirstIndex);
      var bookmarkMaster = new ReferenceItem(Program.Settings.BookmarkMasterBook,
                                             Program.Settings.BookmarkMasterChapter,
                                             Program.Settings.BookmarkMasterVerse);
      void bookmarkClicked(object sender, MouseEventArgs e)
      {
        if ( e.Button != MouseButtons.Right ) return;
        // bug reentrance (?) if ( !DisplayManager.QueryYesNo(AppTranslations.DeleteBookmark.GetLang()) ) return;
        var menuitem = (ToolStripMenuItem)sender;
        if ( menuitem.Tag as ReferenceItem == bookmarkMaster )
        {
          Program.Settings.BookmarkMasterBook = 1;
          Program.Settings.BookmarkMasterChapter = 1;
          Program.Settings.BookmarkMasterVerse = 1;
          UpdateBookmarks();
        }
        else
        {
          Bookmarks.Remove((ReferenceItem)menuitem.Tag);
          UpdateBookmarks();
        }
      }
      ActionGoToBookmarkMain.Text = bookmarkMaster.ToStringFull();
      ActionGoToBookmarkMain.Tag = bookmarkMaster;
      ActionGoToBookmarkMain.MouseUp += bookmarkClicked;
      if ( Bookmarks.Count > 0 )
      {
        foreach ( var reference in Bookmarks )
        {
          var item = (ToolStripMenuItem)MenuBookmarks.DropDownItems.Add(reference.ToStringFull());
          item.Tag = reference;
          item.Click += GoToBookmark;
          item.MouseUp += bookmarkClicked;
          item.ImageScaling = ToolStripItemImageScaling.None;
          item.Image = ActionAddToBookmarks.Image;
        }
      }
      ActionClearBookmarks.Enabled = Bookmarks.Count > 0
                                  && MenuBookmarks.DropDownItems.Count > BookmarksMenuFirstIndex;
      ActionSortBookmarks.Enabled = Bookmarks.Count > 0
                                 && !Program.Settings.AutoSortBookmarks;
    }
    catch ( Exception ex )
    {
      ex.Manage();
    }
  }

}