
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
/// <created> 2016-04 </created>
/// <edited> 2019-09 </edited>
namespace Ordisoftware.Hebrew.Words;

/// <summary>
/// The application's main form.
/// </summary>
/// <seealso cref="T:System.Windows.Forms.Form"/>
partial class MainForm
{

  /// <summary>
  /// Provides view connector.
  /// </summary>
  private sealed class ViewConnector
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
  public void SetView(ViewMode view)
  {
    SetView(view, false);
  }

  /// <summary>
  /// Set the view panel.
  /// </summary>
  /// <param name="view">The view mode.</param>
  /// <param name="first">true to first.</param>
  public void SetView(ViewMode view, bool first)
  {
    var ViewPanels = new Dictionary<ViewMode, ViewConnector>()
    {
      {
        ViewMode.Verses,
        new ViewConnector
        {
          MenuItem = ActionViewVerses,
          Panel = PanelViewVerses,
          Focused = PanelViewVerses
        }
      },
      {
        ViewMode.VerseFiltered,
        new ViewConnector
        {
          MenuItem = ActionViewVerseFiltered,
          Panel = PanelViewVerseFiltered,
          Focused = PanelViewVerseFiltered
        }
      },
      {
        ViewMode.Translation,
        new ViewConnector
        {
          MenuItem = ActionViewTranslations,
          Panel = PanelViewTranslations,
          Focused = EditTranslations
        }
      },
      {
        ViewMode.Text,
        new ViewConnector
        {
          MenuItem = ActionViewRawText,
          Panel = PanelViewRawText,
          Focused = EditRawText
        }
      },
      {
        ViewMode.ELS50,
        new ViewConnector
        {
          MenuItem = ActionViewELS50,
          Panel = PanelViewELS50,
          Focused = EditELS50All
        }
      },
      {
        ViewMode.Search,
        new ViewConnector
        {
          MenuItem = ActionViewSearch,
          Panel = PanelViewSearch,
          Focused = SelectSearchType
        }
      }
    };
    if ( Settings.CurrentView == view && !first )
    {
      if ( Settings.CurrentView == ViewMode.Search )
        RotateSearchTab();
      return;
    }
    if ( first )
    {
      UpdateFilters(null, null);
      SelectSearchType.SelectedIndex = Settings.CurrentSearchTypeTab;
      var radio1 = SelectSearchTypeTranslation.Controls.OfType<RadioButton>().FirstOrDefault(c => c.TabIndex == Settings.SearchTranslationRadioButtonIndex);
      if ( radio1 != null ) radio1.Checked = true;
      var radio2 = SelectSearchTypeVerses.Controls.OfType<RadioButton>().FirstOrDefault(c => c.TabIndex == Settings.SearchVerseRadioButtonIndex);
      if ( radio2 != null ) radio2.Checked = true;
    }
    else
      ActionSave.PerformClick();
    ViewPanels[Settings.CurrentView].MenuItem.Checked = false;
    ViewPanels[Settings.CurrentView].Panel.Parent = null;
    ViewPanels[view].MenuItem.Checked = true;
    ViewPanels[view].Panel.Parent = PanelMainCenter;
    if ( view != ViewMode.Search ) ViewPanels[view].Focused?.Focus();
    Settings.CurrentView = view;
    UpdateButtons();
    Refresh();
    switch ( view )
    {
      case ViewMode.Verses:
      case ViewMode.Text:
        GoTo(CurrentReference);
        break;
      case ViewMode.Translation:
        RenderTranslation();
        GoTo(CurrentReference);
        break;
      case ViewMode.Search:
        SelectSearchType_Selected(null, null);
        break;
    }
    //
    void UpdateButtons()
    {
      LabelTitle.Text = AppTranslations.ViewPanelTitle.GetLang(view).ToUpper();
      //
      PanelNavigation.Visible = view != ViewMode.VerseFiltered && view != ViewMode.Search;
      //
      ActionCopyToClipboard.Enabled = view == ViewMode.Translation;
      //
      ActionExportBook.Enabled = view == ViewMode.Verses || view == ViewMode.ELS50;
      SelectBook.Enabled = view != ViewMode.Search;
      LabelSelectBook.Enabled = SelectBook.Enabled;
      //
      ActionExportChapter.Enabled = view == ViewMode.Verses || view == ViewMode.Translation || view == ViewMode.Text;
      SelectChapter.Enabled = ActionExportChapter.Enabled;
      LabelSelectChapter.Enabled = ActionExportChapter.Enabled;
      //
      EditBookTranslation.Enabled = ActionExportBook.Enabled;
      EditChapterTitle.Enabled = ActionExportChapter.Enabled;
      EditChapterMemo.Enabled = ActionExportChapter.Enabled;
      ActionEditBookMemo.Enabled = ActionExportChapter.Enabled;
      //
      ActionSearchVerse.Enabled = view == ViewMode.Verses || view == ViewMode.Translation || view == ViewMode.Text;
    }
  }

}
