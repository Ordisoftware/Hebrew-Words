﻿/// <license>
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
/// <created> 2016-04 </created>
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

/// <summary>
/// The application's main form.
/// </summary>
/// <seealso cref="T:System.Windows.Forms.Form"/>
partial class MainForm
{

  private bool DoScreenPositionMutex;

  /// <summary>
  /// Enables double-buffering.
  /// </summary>
  protected override CreateParams CreateParams
  {
    get
    {
      var cp = base.CreateParams;
      if ( Settings.WindowsDoubleBufferingEnabled
        && Settings.CurrentView != ViewMode.ChapterTranslation
        && Settings.CurrentView != ViewMode.ChapterOriginal
        && Settings.CurrentView != ViewMode.BookELS50 )
      {
        cp.ExStyle |= 0x02000000; // + WS_EX_COMPOSITED
        //cp.Style &= ~0x02000000;  // - WS_CLIPCHILDREN
      }
      return cp;
    }
  }

  /// <summary>
  /// Centers the form to the screen.
  /// </summary>
  public new void CenterToScreen()
  {
    base.CenterToScreen();
  }

  /// <summary>
  /// Executes the screen location operation.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  protected void DoScreenPosition(object sender, EventArgs e)
  {
    if ( DoScreenPositionMutex ) return;
    try
    {
      DoScreenPositionMutex = true;
      if ( sender is ToolStripMenuItem menuItem )
      {
        foreach ( ToolStripMenuItem item in ( (ToolStripMenuItem)menuItem.OwnerItem ).DropDownItems )
          item.Checked = item == menuItem;
      }
      if ( Globals.IsReady ) Settings.Store();
      this.SetLocation(Settings.MainFormPosition);
    }
    finally
    {
      DoScreenPositionMutex = false;
    }
  }

  /// <summary>
  /// Show tool tip in view panel.
  /// </summary>
  void ShowPanelToolTip(string str)
  {
    Panel panel = null;
    int width = TextRenderer.MeasureText(str, SystemFonts.SmallCaptionFont).Width;
    int x = 5;
    const int y = 5;
    switch ( Settings.CurrentView )
    {
      case ViewMode.ChapterVerses:
        panel = PanelViewVerses;
        x = panel.ClientSize.Width - 15 - width;
        break;
      case ViewMode.ChapterTranslation:
        panel = PanelViewTranslations;
        break;
      case ViewMode.Search:
        panel = PanelSearchResults;
        x = panel.ClientSize.Width - 10 - width;
        break;
    }
    if ( panel is not null ) ToolTipSearchResult.Show(str, panel, x, y, 4000);
    LastToolTipPanel = panel;
  }

}
