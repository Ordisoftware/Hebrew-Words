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
          var list = File.ReadLines(_BookmarksFilename);
          for (int index = list.Count() - 1; index >= 0; index-- )
          {
            string item = list.ElementAt(index);
            if ( item == "" || item.Count(c => c == '.') != 2 ) continue;
            var parts = item.Split('.');
            var reference = new ReferenceItem();
            reference.Book = DataSet.Books[Convert.ToInt32(parts[0]) - 1];
            reference.Chapter = reference.Book.GetChaptersRows()[Convert.ToInt32(parts[1]) - 1];
            reference.Verse = reference.Chapter.GetVersesRows()[Convert.ToInt32(parts[2]) - 1];
            AddBookmark(reference);
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
      foreach ( var reference in _Bookmarks )
      {
        item = MenuBookmarks.DropDownItems.Add(reference.ToString());
        item.Tag = reference;
        item.Click += Item_Click;
        item.ImageScaling = ToolStripItemImageScaling.None;
        item.Image = ActionAddToBookmarks.Image;
      }
      SaveBookmarks();
    }

    private void Item_Click(object sender, EventArgs e)
    {
      GoTo((ReferenceItem)( (ToolStripMenuItem)sender ).Tag);
    }

  }

}
