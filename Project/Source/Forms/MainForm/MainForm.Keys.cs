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
/// <created> 2019-01 </created>
/// <edited> 2020-03 </edited>
using System;
using System.Drawing;
using System.Windows.Forms;
using Ordisoftware.Core;

namespace Ordisoftware.Hebrew.Words
{

  partial class MainForm
  {

    private int ScrollIncrement = 25;

    /// <summary>
    /// Rotate current search tab.
    /// </summary>
    private void RotateSearchTab()
    {
      if ( SelectSearchType.SelectedTab == SelectSearchTypeHebrew )
        SelectSearchType.SelectedTab = SelectSearchTypeTranslation;
      else
      if ( SelectSearchType.SelectedTab == SelectSearchTypeTranslation )
        SelectSearchType.SelectedTab = SelectSearchTypeVerses;
      else
      if ( SelectSearchType.SelectedTab == SelectSearchTypeVerses )
        SelectSearchType.SelectedTab = SelectSearchTypeHebrew;
    }

    /// <summary>
    /// Process the command key.
    /// </summary>
    /// <seealso cref="M:System.Windows.Forms.Form.ProcessCmdKey(Message@,Keys)"/>
    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
      Func<Panel, int, bool, bool> scroll = (panel, y, abs) =>
      {
        int dy = abs ? Math.Abs(panel.AutoScrollPosition.Y) : 0;
        panel.AutoScrollPosition = new Point(panel.AutoScrollPosition.X, y + dy);
        return true;
      };
      switch ( keyData )
      {
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
          if ( Program.Settings.CurrentView != ViewMode.Search )
            ActionViewSearch.PerformClick();
          else
            RotateSearchTab();
          return true;
        case Keys.Control | Keys.S:
          ActionSave.PerformClick();
          return true;
        case Keys.Control | Keys.R:
          ActionGoToReference.PerformClick();
          return true;
        case Keys.Control | Keys.F:
          ActionSearchVerse.PerformClick();
          return true;
        case Keys.Control | Keys.B:
          ActionViewBooksTranslation.PerformClick();
          return true;
        case Keys.Control | Keys.H:
          ActionStartHebrewLetters.PerformClick();
          return true;
        case Keys.Control | Keys.L:
          ActionOpenShorashon.PerformClick();
          return true;
        case Keys.Escape:
          if ( IsRenderingSearch ) Globals.CancelRequired = true;
          break;
        case Keys.Control | Keys.Up:
          if ( ActiveControl is TextBox ) return false;
          switch ( Program.Settings.CurrentView )
          {
            case ViewMode.Verses:
              return scroll(PanelViewVerses, -ScrollIncrement, true);
            case ViewMode.Search:
              return scroll(PanelSearchResults, -ScrollIncrement, true);
          }
          break;
        case Keys.Control | Keys.Down:
          if ( ActiveControl is TextBox ) return false;
          switch ( Program.Settings.CurrentView )
          {
            case ViewMode.Verses:
              return scroll(PanelViewVerses, ScrollIncrement, true);
            case ViewMode.Search:
              return scroll(PanelSearchResults, ScrollIncrement, true);
          }
          break;
        case Keys.PageUp:
          if ( ActiveControl is TextBox ) return false;
          switch ( Program.Settings.CurrentView )
          {
            case ViewMode.Verses:
              return scroll(PanelViewVerses, -PanelViewVerses.Height, true);
            case ViewMode.Search:
              return scroll(PanelSearchResults, -PanelViewVerses.Height, true);
          }
          break;
        case Keys.PageDown:
          if ( ActiveControl is TextBox ) return false;
          switch ( Program.Settings.CurrentView )
          {
            case ViewMode.Verses:
              return scroll(PanelViewVerses, PanelViewVerses.Height, true);
            case ViewMode.Search:
              return scroll(PanelSearchResults, PanelViewVerses.Height, true);
          }
          break;
        case Keys.Control | Keys.Home:
          if ( ActiveControl is TextBox ) return false;
          switch ( Program.Settings.CurrentView )
          {
            case ViewMode.Verses:
              return scroll(PanelViewVerses, 0, false);
            case ViewMode.Search:
              return scroll(PanelSearchResults, 0, false);
          }
          break;
        case Keys.Control | Keys.End:
          if ( ActiveControl is TextBox ) return false;
          switch ( Program.Settings.CurrentView )
          {
            case ViewMode.Verses:
              return scroll(PanelViewVerses, PanelViewVerses.DisplayRectangle.Height, false);
            case ViewMode.Search:
              return scroll(PanelSearchResults, PanelSearchResults.DisplayRectangle.Height, false);
          }
          break;
      }
      return base.ProcessCmdKey(ref msg, keyData);
    }

  }

}
