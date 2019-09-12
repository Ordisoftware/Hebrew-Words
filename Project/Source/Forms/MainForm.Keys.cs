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
/// <created> 2019-01 </created>
/// <edited> 2019-09 </edited>
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  public partial class MainForm
  {

    private bool InProcess;
    private bool CancelRequired;

    private int ScrollIncrement = 25;

    /// <summary>
    /// Process the command key.
    /// </summary>
    /// <seealso cref="M:System.Windows.Forms.Form.ProcessCmdKey(Message@,Keys)"/>
    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
      Func<Panel, int, bool, bool> scroll = (panel, y, abs) =>
      {
        panel.AutoScrollPosition = new Point(panel.AutoScrollPosition.X, 
                                             (abs ? Math.Abs(PanelViewVerses.AutoScrollPosition.Y) : 0) + y);
        return true;
      };
      switch ( keyData )
      {
        case Keys.Escape:
          if ( InProcess ) CancelRequired = true;
          break;
        case Keys.Control | Keys.F:
          ActionSearchVerse.PerformClick();
          return true;
        case Keys.Control | Keys.S:
          ActionSave.PerformClick();
          return true;
        case Keys.F1:
          ActionViewVerses.PerformClick();
          return true;
        case Keys.F2:
          ActionViewTranslations.PerformClick();
          return true;
        case Keys.F3:
          ActionViewRawText.PerformClick();
          return true;
        case Keys.F4:
          ActionViewELS50.PerformClick();
          return true;
        case Keys.F5:
          ActionViewSearch.PerformClick();
          return true;
        case Keys.F8:
          ActionPreferences.PerformClick();
          return true;
        case Keys.F11:
          ActionHelp.PerformClick();
          return true;
        case Keys.F12:
          ActionAbout.PerformClick();
          return true;
        case Keys.Control | Keys.Up:
          switch ( Program.Settings.CurrentView )
          {
            case ViewModeType.Verses:
              return scroll(PanelViewVerses, -ScrollIncrement, true);
            case ViewModeType.Search:
              return scroll(PanelSearchResults, -ScrollIncrement, true);
          }
          break;
        case Keys.Control | Keys.Down:
          switch ( Program.Settings.CurrentView )
          {
            case ViewModeType.Verses:
              return scroll(PanelViewVerses, ScrollIncrement, true);
            case ViewModeType.Search:
              return scroll(PanelSearchResults, ScrollIncrement, true);
          }
          break;
        case Keys.PageUp:
          switch ( Program.Settings.CurrentView )
          {
            case ViewModeType.Verses:
              return scroll(PanelViewVerses, -PanelViewVerses.Height, true);
            case ViewModeType.Search:
              return scroll(PanelSearchResults, -PanelViewVerses.Height, true);
          }
          break;
        case Keys.PageDown:
          switch ( Program.Settings.CurrentView )
          {
            case ViewModeType.Verses:
              return scroll(PanelViewVerses, PanelViewVerses.Height, true);
            case ViewModeType.Search:
              return scroll(PanelSearchResults, PanelViewVerses.Height, true);
          }
          break;
        case Keys.Control | Keys.Home:
          switch ( Program.Settings.CurrentView )
          {
            case ViewModeType.Verses:
              return scroll(PanelViewVerses, 0, false);
            case ViewModeType.Search:
              return scroll(PanelSearchResults, 0, false);
          }
          break;
        case Keys.Control | Keys.End:
          switch ( Program.Settings.CurrentView )
          {
            case ViewModeType.Verses:
              return scroll(PanelViewVerses, PanelViewVerses.DisplayRectangle.Height, false);
            case ViewModeType.Search:
              return scroll(PanelSearchResults, PanelSearchResults.DisplayRectangle.Height, false);
          }
          break;
      }
      return base.ProcessCmdKey(ref msg, keyData);
    }

  }

}
