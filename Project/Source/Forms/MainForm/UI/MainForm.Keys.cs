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
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class MainForm
{

  private readonly int ScrollIncrement = 25;

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

  // TODO update keys

  /// <summary>
  /// Process the command key.
  /// </summary>
  /// <seealso cref="M:System.Windows.Forms.Form.ProcessCmdKey(Message@,Keys)"/>
  protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
  {
    static bool scroll(Panel panel, int y, bool abs)
    {
      int dy = abs ? Math.Abs(panel.AutoScrollPosition.Y) : 0;
      panel.AutoScrollPosition = new Point(panel.AutoScrollPosition.X, y + dy);
      return true;
    }
    switch ( keyData )
    {
      // System close
      case Keys.Alt | Keys.Control | Keys.F4:
        ActionExit.PerformClick();
        return true;
      case Keys.Escape:
        if ( IsRendering ) Globals.CancelRequired = true;
        break;
      // System tools
      case Keys.F9:
        ActionPreferences.PerformClick();
        return true;
      // Change view
      case Keys.Control | Keys.Shift | Keys.Tab:
        SetView(Settings.CurrentView.Previous());
        return true;
      case Keys.Control | Keys.Tab:
        SetView(Settings.CurrentView.Next());
        return true;
      // View
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
      // Actions
      case Keys.Control | Keys.S:
        ActionSave.PerformClick();
        return true;
      case Keys.Control | Keys.F:
        ActionSearchVerse.PerformClick();
        return true;
      case Keys.Alt | Keys.F:
        ActionViewSearch.PerformClick();
        return true;
      case Keys.Shift | Keys.Control | Keys.F:
        ActionGoToReference.PerformClick();
        return true;
      // Application menus
      case Keys.Alt | Keys.D:
        ActionDatabase.ShowDropDown();
        return true;
      case Keys.Alt | Keys.B:
        ActionBookmarks.ShowDropDown();
        return true;
      case Keys.Alt | Keys.T:
        ActionTools.ShowDropDown();
        return true;
      case Keys.Alt | Keys.L:
        if ( ActionWebLinks.Enabled )
          ActionWebLinks.ShowDropDown();
        return true;
      // System menus
      case Keys.Alt | Keys.S:
        ActionSettings.ShowDropDown();
        return true;
      case Keys.Alt | Keys.I:
        ActionInformation.ShowDropDown();
        return true;
      // Scrolling small
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
      // Scrolling large
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
      // Scrolling bounds
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
