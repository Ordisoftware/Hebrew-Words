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
/// <created> 2016-04 </created>
/// <edited> 2019-08 </edited>
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// The application's main form.
  /// </summary>
  /// <seealso cref="T:System.Windows.Forms.Form"/>
  public partial class MainForm
  {

    /// <summary>
    /// Provide view connector.
    /// </summary>
    private class ViewConnector
    {

      /// <summary>
      /// The menu item.
      /// </summary>
      public ToolStripButton MenuItem;

      /// <summary>
      /// The panel.
      /// </summary>
      public Panel Panel;

      /// <summary>
      /// The focused control.
      /// </summary>
      public Control Focused;

    }

    /// <summary>
    /// Set the view panel.
    /// </summary>
    /// <param name="view">The view mode.</param>
    internal void SetView(ViewModeType view)
    {
      SetView(view, false);
    }

    /// <summary>
    /// Set the view panel.
    /// </summary>
    /// <param name="view">The view mode.</param>
    /// <param name="first">true to first.</param>
    internal void SetView(ViewModeType view, bool first)
    {
      var ViewPanels = new Dictionary<ViewModeType, ViewConnector>()
      {
        {
          ViewModeType.Verses,
          new ViewConnector
          {
            MenuItem = ActionViewVerses,
            Panel = PanelViewVerses,
            Focused = PanelViewVerses
          }
        },
        {
          ViewModeType.Translations,
          new ViewConnector
          {
            MenuItem = ActionViewTranslations,
            Panel = PanelViewTranslations,
            Focused = EditTranslations
          }
        },
        {
          ViewModeType.Text,
          new ViewConnector
          {
            MenuItem = ActionViewRawText,
            Panel = PanelViewRawText,
            Focused = EditRawText
          }
        },
        {
          ViewModeType.ELS50,
          new ViewConnector
          {
            MenuItem = ActionViewELS50,
            Panel = PanelViewELS50,
            Focused = EditELS50All
          }
        },
        {
          ViewModeType.Search,
          new ViewConnector
          {
            MenuItem = ActionViewSearch,
            Panel = PanelViewSearch2,
            Focused = EditLetters
          }
        }
      };
      if ( Program.Settings.CurrentView == view && !first ) return;
      ViewPanels[Program.Settings.CurrentView].MenuItem.Checked = false;
      ViewPanels[Program.Settings.CurrentView].Panel.Parent = null;
      ViewPanels[view].MenuItem.Checked = true;
      ViewPanels[view].Panel.Parent = PanelMainCenter;
      if ( ViewPanels[view].Focused != null ) ViewPanels[view].Focused.Focus();
      Program.Settings.CurrentView = view;
      ActionCopyToClipboard.Enabled = view == ViewModeType.Translations
                                   || view == ViewModeType.Text
                                   || view == ViewModeType.ELS50;
      ActionExportChapter.Enabled = view == ViewModeType.Verses
                                 || view == ViewModeType.Translations;
      SelectChapter.Enabled = ActionExportChapter.Enabled && view == ViewModeType.Search;
      SelectBook.Enabled = view != ViewModeType.Search;
      ActionExportBook.Enabled = view != ViewModeType.Search;
      LabelSelectBook.Enabled = ActionExportBook.Enabled;
      LabelSelectChapter.Enabled = ActionExportChapter.Enabled;
    }

  }

}
