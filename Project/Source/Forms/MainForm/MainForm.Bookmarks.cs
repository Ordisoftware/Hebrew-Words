/// <license>
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
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  public partial class MainForm
  {

    private void GoToBookmark(object sender, EventArgs e)
    {
      if ( Program.Settings.CurrentView == ViewModeType.ELS50 
        || Program.Settings.CurrentView == ViewModeType.Search )
        SetView(ViewModeType.Verses);
      GoTo((ReferenceItem)( (ToolStripMenuItem)sender ).Tag);
      ActionSave.PerformClick();
    }

    internal void UpdateBookmarks()
    {
      while ( MenuBookmarks.DropDownItems.Count > 4 )
        MenuBookmarks.DropDownItems.RemoveAt(4);
      Bookmarks.Save();
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
          Bookmarks.Save();
          UpdateBookmarks();
        }
        else
        {
          Bookmarks.Remove((ReferenceItem)menuitem.Tag);
          Bookmarks.Save();
          UpdateBookmarks();
        }
      };
      ToolStripMenuItem item = (ToolStripMenuItem)MenuBookmarks.DropDownItems.Add(bookmarkMaster.ToString());
      item.Tag = bookmarkMaster;
      item.Click += GoToBookmark;
      item.MouseDown += bookmarkClicked;
      item.ImageScaling = ToolStripItemImageScaling.None;
      item.Image = ActionSetAsBookmarkMaster.Image;
      MenuBookmarks.DropDownItems.Add("-");
      foreach ( var reference in Bookmarks )
      {
        item = (ToolStripMenuItem)MenuBookmarks.DropDownItems.Add(reference.ToString());
        item.Tag = reference;
        item.Click += GoToBookmark;
        item.MouseDown += bookmarkClicked;
        item.ImageScaling = ToolStripItemImageScaling.None;
        item.Image = ActionAddToBookmarks.Image;
      }
    }

    internal void AddCurrentToHistory()
    {
      for ( int index = 0; index < History.Count; )
        if ( History[index].Equals(CurrentReference) )
          History.RemoveAt(index);
        else
          index++;
      History.Insert(0, new ReferenceItem(CurrentReference));
      UpdateHistory();
    }

    private void UpdateHistory()
    {
      MenuHistory.DropDownItems.Clear();
      while ( History.Count > Program.Settings.HistoryCount )
        History.RemoveAt(History.Count - 1);
      foreach ( var reference in History )
      {
        ToolStripMenuItem item = (ToolStripMenuItem)MenuHistory.DropDownItems.Add(reference.ToString());
        item.Tag = reference;
        item.Click += GoToBookmark;
        item.ImageScaling = ToolStripItemImageScaling.None;
        item.Image = ActionAddToBookmarks.Image;
      }
    }

  }

}