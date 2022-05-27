/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2022 Olivier Rogier.
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
/// <edited> 2022-05 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class MainForm
{

  [SuppressMessage("IDisposableAnalyzers.Correctness", "IDISP001:Dispose created", Justification = "<En attente>")]
  private void UpdateBookmarks()
  {
    try
    {
      if ( Settings.AutoSortBookmarks )
        BookmarkItems.Sort();
      while ( ActionBookmarks.DropDownItems.Count > BookmarkMenuIndex )
        ActionBookmarks.DropDownItems.RemoveAt(BookmarkMenuIndex);
      var bookmarkMaster = new ReferenceItem(Settings.BookmarkMasterBook,
                                             Settings.BookmarkMasterChapter,
                                             Settings.BookmarkMasterVerse);
      void bookmarkClicked(object sender, MouseEventArgs e)
      {
        if ( e.Button != MouseButtons.Right ) return;
        var menuitem = (ToolStripMenuItem)sender;
        if ( !DisplayManager.QueryYesNo(SysTranslations.AskToDeleteBookmark.GetLang((ReferenceItem)menuitem.Tag)) )
          return;
        if ( menuitem == ActionGoToBookmarkMain )
        {
          Settings.BookmarkMasterBook = 1;
          Settings.BookmarkMasterChapter = 1;
          Settings.BookmarkMasterVerse = 1;
          UpdateBookmarks();
        }
        else
        {
          BookmarkItems.Remove((ReferenceItem)menuitem.Tag);
          UpdateBookmarks();
        }
      }
      ActionGoToBookmarkMain.Text = bookmarkMaster.ToStringBasedOnPrefs();
      // TODO option if ( Settings.BookmarksAndHistoryShowVerse )
      // TODO improve display
      ActionGoToBookmarkMain.Text += " - " + bookmarkMaster.Verse.Translation.Substring(0, Math.Min(150, bookmarkMaster.Verse.Translation.Length));
      ActionGoToBookmarkMain.Tag = bookmarkMaster;
      ActionGoToBookmarkMain.MouseUp += bookmarkClicked;
      if ( bookmarkMaster.CompareTo(CurrentReference) == 0 )
        ActionGoToBookmarkMain.Font = new Font(ActionGoToBookmarkMain.Font, FontStyle.Bold);
      else
        ActionGoToBookmarkMain.Font = new Font(ActionGoToBookmarkMain.Font, FontStyle.Regular);
      if ( BookmarkItems.Count > 0 )
      {
        foreach ( var reference in BookmarkItems )
        {
          var item = (ToolStripMenuItem)ActionBookmarks.DropDownItems.Add(reference.ToStringBasedOnPrefs());
          //if ( Settings.BookmarksAndHistoryShowVerse )
          // TODO improve display
          item.Text += " - " + reference.Verse.Translation.Substring(0, Math.Min(125, reference.Verse.Translation.Length));
          item.Tag = reference;
          item.Click += GoToBookmark;
          item.MouseUp += bookmarkClicked;
          item.ImageScaling = ToolStripItemImageScaling.None;
          item.Image = ActionGoToBookmarks.Image;
          if ( reference.CompareTo(CurrentReference) == 0 )
            item.Font = new Font(item.Font, FontStyle.Bold);
        }
      }
      ActionClearBookmarks.Enabled = BookmarkItems.Count > 0 && ActionBookmarks.DropDownItems.Count > BookmarkMenuIndex;
      ActionSortBookmarks.Enabled = BookmarkItems.Count > 0 && !Settings.AutoSortBookmarks;
      SeparatorBookmarks.Visible = BookmarkItems.Count > 0;
    }
    catch ( Exception ex )
    {
      ex.Manage();
    }
  }

}
