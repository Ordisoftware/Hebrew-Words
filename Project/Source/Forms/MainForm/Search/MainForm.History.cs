/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2025 Olivier Rogier.
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

  [SuppressMessage("IDisposableAnalyzers.Correctness", "IDISP001:Dispose created", Justification = "<En attente>")]
  private void UpdateHistory()
  {
    try
    {
      while ( ActionHistory.DropDownItems.Count > HistoryIndexMenu )
        ActionHistory.DropDownItems.RemoveAt(HistoryIndexMenu);
      if ( HistoryItems.Count > 0 )
      {
        foreach ( var reference in HistoryItems )
        {
          string text = reference.ToStringBasedOnPreferences(!Settings.BookmarksWithParashah);
          if ( Settings.BookmarksWithTranslation )
            text += $" - {GetExtract(reference.Verse.Translation)}"; // TODO improve display
          var item = (ToolStripMenuItem)ActionHistory.DropDownItems.Add(text);
          item.Tag = reference;
          item.Click += GoToHistory;
          item.ImageScaling = ToolStripItemImageScaling.None;
          item.Image = ActionGoToHistory.Image;
          if ( reference.CompareTo(CurrentReference) == 0 )
            item.Font = new Font(item.Font.Name, item.Font.Size, FontStyle.Bold);
        }
      }
      ActionHistory.Enabled = HistoryItems.Count > 0;
    }
    catch ( Exception ex )
    {
      ex.Manage();
    }
  }

  public void MoveVerseBindingSourceAndAddCurrentToHistory(bool isHistory = false)
  {
    if ( IsGoToRunning ) return;
    if ( Settings.CurrentView == ViewMode.ChapterVerses )
    {
      int pos = CurrentReference.Verse?.Number - 1 ?? -1;
      if ( pos != VersesBindingSource.Position )
        VersesBindingSource.Position = pos;
    }
    if ( !isHistory )
      HistoryItems.Add(CurrentReference);
    UpdateHistory();
    UpdateBookmarks();
  }

}
