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
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Ordisoftware.Core;

namespace Ordisoftware.HebrewWords
{

  public partial class MainForm
  {
    private List<ReferenceItem> _Bookmarks = new List<ReferenceItem>();

    private string _BookmarksFilename { get { return Program.UserDataFolder + "Bookmarks.txt"; } }

    private void LoadBookmarks()
    {
      if ( File.Exists(_BookmarksFilename) )
        try
        {
          _Bookmarks.Clear();
          var list = File.ReadLines(_BookmarksFilename);
          for (int index = list.Count() - 1; index >= 0; index-- )
          {
            string item = list.ElementAt(index);
            if ( item == "" || item.Count(c => c == '.') != 2 ) continue;
            var parts = item.Split('.');
            AddBookmark(new ReferenceItem(Convert.ToInt32(parts[0]),
                                          Convert.ToInt32(parts[1]),
                                          Convert.ToInt32(parts[2])));
          }
        }
        catch ( Exception ex )
        {
          DisplayManager.ShowError(ex.Message);
        }
    }

    private void SaveBookmarks()
    {
      try
      {
        if ( IsLoading ) return;
        var items = new List<string>();
        foreach ( var reference in _Bookmarks )
          items.Add(reference.Book.Number + "." + reference.Chapter.Number + "." + reference.Verse.Number);
        File.WriteAllLines(_BookmarksFilename, items);
      }
      catch ( Exception ex )
      {
        DisplayManager.ShowError(ex.Message);
      }
    }

    private void AddBookmark(ReferenceItem reference)
    {
      if ( Program.Settings.BookmarksCount < 1 ) return;
      foreach ( var value in _Bookmarks )
        if ( value.ToString() == reference.ToString() )
          return;
      _Bookmarks.Insert(0, reference);
    }

    internal void UpdateBookmarks()
    {
      while ( MenuBookmarks.DropDownItems.Count > 2 )
        MenuBookmarks.DropDownItems.RemoveAt(2);
      while ( _Bookmarks.Count > Program.Settings.BookmarksCount )
        _Bookmarks.RemoveAt(_Bookmarks.Count - 1);
      var bookmarkMaster = new ReferenceItem(Program.Settings.BookmarkMasterBook,
                                             Program.Settings.BookmarkMasterChapter,
                                             Program.Settings.BookmarkMasterVerse);
      EventHandler gotoBookmark = (sender, e) =>
      {
        GoTo((ReferenceItem)( (ToolStripMenuItem)sender ).Tag);
      };
      MouseEventHandler bookmarkClicked = (sender, e) =>
      {
        if ( e.Button != MouseButtons.Right ) return;
        var menuitem = (ToolStripMenuItem)sender;
        if ( menuitem.Tag == bookmarkMaster )
        {
          Program.Settings.BookmarkMasterBook = 1;
          Program.Settings.BookmarkMasterChapter = 1;
          Program.Settings.BookmarkMasterVerse = 1;
          SaveBookmarks();
          UpdateBookmarks();
        }
        else
        {
          _Bookmarks.Remove((ReferenceItem)menuitem.Tag);
          SaveBookmarks();
          UpdateBookmarks();
        }
      };
      ToolStripMenuItem item = (ToolStripMenuItem)MenuBookmarks.DropDownItems.Add(bookmarkMaster.ToString());
      item.Tag = bookmarkMaster;
      item.Click += gotoBookmark;
      item.MouseDown += bookmarkClicked;
      item.ImageScaling = ToolStripItemImageScaling.None;
      item.Image = ActionSetAsBookmarkMaster.Image;
      MenuBookmarks.DropDownItems.Add("-");
      foreach ( var reference in _Bookmarks )
      {
        item = (ToolStripMenuItem)MenuBookmarks.DropDownItems.Add(reference.ToString());
        item.Tag = reference;
        item.Click += gotoBookmark;
        item.MouseDown += bookmarkClicked;
        item.ImageScaling = ToolStripItemImageScaling.None;
        item.Image = ActionAddToBookmarks.Image;
      }
      SaveBookmarks();
    }

  }

}
