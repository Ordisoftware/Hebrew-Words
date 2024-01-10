/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2024 Olivier Rogier.
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
/// <edited> 2022-08 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class MainForm
{

  private const int BookmarkMinWidth = 100;

  private string GetExtract(string text) => text.Substring(0, Math.Min(BookmarkMinWidth, text.Length));

  [SuppressMessage("IDisposableAnalyzers.Correctness", "IDISP001:Dispose created", Justification = "<En attente>")]
  private void UpdateBookmarks()
  {
    try
    {
      if ( Settings.AutoSortBookmarks )
        BookmarkItems.Sort();
      while ( ActionBookmarks.DropDownItems.Count > BookmarkMenuIndex )
        ActionBookmarks.DropDownItems.RemoveAt(BookmarkMenuIndex);
      var bookmarkMain = new ReferenceItem(Settings.BookmarkMainBook,
                                           Settings.BookmarkMainChapter,
                                           Settings.BookmarkMainVerse);
      void bookmarkClicked(object sender, MouseEventArgs e)
      {
        if ( e.Button != MouseButtons.Right ) return;
        var menuitem = (ToolStripMenuItem)sender;
        if ( !DisplayManager.QueryYesNo(SysTranslations.AskToDeleteBookmark.GetLang((ReferenceItem)menuitem.Tag)) )
          return;
        if ( menuitem == ActionGoToBookmarkMain )
        {
          Settings.BookmarkMainBook = 1;
          Settings.BookmarkMainChapter = 1;
          Settings.BookmarkMainVerse = 1;
          UpdateBookmarks();
        }
        else
        {
          BookmarkItems.Remove((ReferenceItem)menuitem.Tag);
          UpdateBookmarks();
        }
      }
      ActionGoToBookmarkMain.Text = bookmarkMain.ToStringBasedOnPreferences(!Settings.BookmarksWithParashah);
      if ( Settings.BookmarksWithTranslation )
        ActionGoToBookmarkMain.Text += $" - {GetExtract(bookmarkMain.Verse.Translation)}"; // TODO improve display
      ActionGoToBookmarkMain.Tag = bookmarkMain;
      ActionGoToBookmarkMain.MouseUp += bookmarkClicked;
      if ( bookmarkMain.CompareTo(CurrentReference) == 0 )
        ActionGoToBookmarkMain.Font = new Font(ActionGoToBookmarkMain.Font, FontStyle.Bold);
      else
        ActionGoToBookmarkMain.Font = new Font(ActionGoToBookmarkMain.Font, FontStyle.Regular);
      if ( BookmarkItems.Count > 0 )
      {
        foreach ( var reference in BookmarkItems )
        {
          string text = reference.ToStringBasedOnPreferences(!Settings.BookmarksWithParashah);
          if ( Settings.BookmarksWithTranslation )
            text += $" - {GetExtract(reference.Verse.Translation)}"; // TODO improve display
          var item = (ToolStripMenuItem)ActionBookmarks.DropDownItems.Add(text);
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
