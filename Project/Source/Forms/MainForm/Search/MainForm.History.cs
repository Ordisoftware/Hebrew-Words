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
/// <created> 2019-09 </created>
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class MainForm
{

  public void MoveVerseBindingSourceAndAddCurrentToHistory()
  {
    if ( Settings.CurrentView == ViewMode.ChapterVerses )
    {
      int pos = CurrentReference.Verse.Number - 1;
      if ( pos != VersesBindingSource.Position )
        VersesBindingSource.Position = pos;
    }
    History.Add(CurrentReference);
    UpdateHistory();
  }

  private void UpdateHistory()
  {
    try
    {
      while ( ActionHistory.DropDownItems.Count > 1 )
        ActionHistory.DropDownItems.RemoveAt(1);
      if ( History.Count > 0 )
      {
        ActionHistory.DropDownItems.Add("-");
        foreach ( var reference in History )
        {
          ToolStripMenuItem item = (ToolStripMenuItem)ActionHistory.DropDownItems.Add(reference.ToStringFull());
          item.Tag = reference;
          item.Click += GoToBookmark;
          item.ImageScaling = ToolStripItemImageScaling.None;
          item.Image = ActionGoToBookmarks.Image;
        }
      }
      ActionClearHistory.Enabled = History.Count > 0;
    }
    catch ( Exception ex )
    {
      ex.Manage();
    }
  }

}
