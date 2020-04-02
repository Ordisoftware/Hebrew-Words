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
/// <created> 2019-09 </created>
/// <edited> 2019-09 </edited>
using System;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  public partial class MainForm
  {

    private void UpdateBookmarks()
    {
      while ( MenuBookmarks.DropDownItems.Count > 6 )
        MenuBookmarks.DropDownItems.RemoveAt(6);
      var bookmarkMaster = new ReferenceItem(Program.Settings.BookmarkMasterBook,
                                             Program.Settings.BookmarkMasterChapter,
                                             Program.Settings.BookmarkMasterVerse);
      MouseEventHandler bookmarkClicked = (sender, e) =>
      {
        if ( e.Button != MouseButtons.Right ) return;
        var menuitem = (ToolStripMenuItem)sender;
        if ( menuitem.Tag == bookmarkMaster )
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
      };
      ActionGoToBookmarkMaster.Text = bookmarkMaster.ToString();
      ActionGoToBookmarkMaster.Tag = bookmarkMaster;
      ActionGoToBookmarkMaster.MouseDown += bookmarkClicked;
      ActionSortBookmarks.Enabled = Bookmarks.Count > 0;
      ActionClearBookmarks.Enabled = Bookmarks.Count > 0;
      if ( !ActionClearBookmarks.Enabled ) return;
      MenuBookmarks.DropDownItems.Add("-");
      foreach ( var reference in Bookmarks )
      {
        var item = (ToolStripMenuItem)MenuBookmarks.DropDownItems.Add(reference.ToString());
        item.Tag = reference;
        item.Click += GoToBookmark;
        item.MouseDown += bookmarkClicked;
        item.ImageScaling = ToolStripItemImageScaling.None;
        item.Image = ActionAddToBookmarks.Image;
      }
    }

  }

}
