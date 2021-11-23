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
/// <edited> 2020-03 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class MainForm
{

  public void AddCurrentToHistory()
  {
    History.Add(CurrentReference);
    UpdateHistory();
  }

  private void UpdateHistory()
  {
    try
    {
      while ( MenuHistory.DropDownItems.Count > 1 )
        MenuHistory.DropDownItems.RemoveAt(1);
      if ( History.Count > 0 )
      {
        MenuHistory.DropDownItems.Add("-");
        foreach ( var reference in History )
        {
          ToolStripMenuItem item = (ToolStripMenuItem)MenuHistory.DropDownItems.Add(reference.ToStringFull());
          item.Tag = reference;
          item.Click += GoToBookmark;
          item.ImageScaling = ToolStripItemImageScaling.None;
          item.Image = ActionAddToBookmarks.Image;
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
