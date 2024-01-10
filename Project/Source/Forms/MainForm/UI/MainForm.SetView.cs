using Ordisoftware.Core;
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
/// <created> 2016-04 </created>
/// <edited> 2022-11 </edited>
namespace Ordisoftware.Hebrew.Words;

/// <summary>
/// The application's main form.
/// </summary>
/// <seealso cref="T:System.Windows.Forms.Form"/>
partial class MainForm
{

  public bool IsVersesOrFiltered(ViewMode view)
    => view == ViewMode.ChapterVerses || view == ViewMode.VerseFiltered;

  public bool IsSearchOrFiltered(ViewMode view)
    => view == ViewMode.ChapterVerses || view == ViewMode.VerseFiltered;

  public bool IsVersesOrTranslationOrOriginal(ViewMode view)
    => view == ViewMode.ChapterVerses || view == ViewMode.ChapterTranslation || view == ViewMode.ChapterOriginal;

  public bool IsTranslationOrOriginalOrELS50(ViewMode view)
    => view == ViewMode.ChapterTranslation || view == ViewMode.ChapterOriginal || view == ViewMode.BookELS50;

  public bool IsSearchOrFilteredOrELS50(ViewMode view)
   => view == ViewMode.Search || view == ViewMode.VerseFiltered || view == ViewMode.BookELS50;

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
  [SuppressMessage("Design", "MA0051:Method is too long", Justification = "N/A")]
  [SuppressMessage("Design", "GCop135:{0}", Justification = "N/A")]
  public void SetView(ViewMode view, bool first)
  {
    if ( Settings.CurrentView == view && !first )
    {
      if ( Settings.CurrentView == ViewMode.Search )
        RotateSearchTab();
      return;
    }
    checkFirst();
    ViewConnectors[Settings.CurrentView].Component.Checked = false;
    ViewConnectors[Settings.CurrentView].Panel.Parent = null;
    ViewConnectors[view].Component.Checked = true;
    ViewConnectors[view].Panel.Parent = PanelMainCenter;
    if ( view != ViewMode.Search )
      ViewConnectors[view].Focused?.Focus();
    Settings.CurrentView = view;
    updateControls();
    switch ( view )
    {
      case ViewMode.ChapterVerses:
      case ViewMode.ChapterOriginal:
      case ViewMode.ChapterTranslation:
      case ViewMode.BookELS50:
        SetTanakItemFocus();
        break;
      case ViewMode.Search:
        SelectSearchType_Selected(null, null);
        break;
      case ViewMode.VerseFiltered:
        VerseControl.ResetMetricsRequired = true;
        WordControl.ResetMetricsRequired = true;
        RenderVerseFiltered();
        break;
      default:
        throw new AdvNotImplementedException(view);
    }
    //
    void checkFirst()
    {
      if ( first )
      {
        UpdateFilters(null, null);
        SelectSearchType.SelectedIndex = Settings.CurrentSearchTypeTab;
        setRadio(SelectSearchTypeTranslation, Settings.SearchTranslationRadioButtonIndex);
        setRadio(SelectSearchTypeVerses, Settings.SearchVerseRadioButtonIndex);
        void setRadio(TabPage page, int index)
        {
          var radio = page.Controls.OfType<RadioButton>().FirstOrDefault(c => c.TabIndex == index);
          if ( radio is not null ) radio.Checked = true;
        }
      }
      else
      {
        ActionSave.PerformClick();
        if ( !Settings.RenderAllChapterVersesKeep && Settings.RenderAllChapterVerses )
          if ( IsSearchOrFiltered(view) )
            Settings.RenderAllChapterVerses = false;
      }
    }
    //
    void updateControls()
    {
      LabelTitle.Text = AppTranslations.ViewPanelTitle.GetLang(view).ToUpper();
      LabelTitle.Refresh();
      //
      PanelNavigation.Visible = view != ViewMode.VerseFiltered && view != ViewMode.Search;
      PanelMain.Refresh();
      //
      ActionCopyToClipboard.Enabled = IsTranslationOrOriginalOrELS50(view);
      ActionExportBook.Enabled = PanelNavigation.Visible
                              && view != ViewMode.ChapterTranslation  // TODO remove when ready
                              && view != ViewMode.ChapterOriginal;    // TODO remove when ready
      ActionExportChapter.Enabled = PanelNavigation.Visible
                                 && view != ViewMode.BookELS50;       // TODO remove wgen ready
                                                                      //
      SelectBook.Enabled = PanelNavigation.Visible;
      SelectBookNavigator.Enabled = SelectBook.Enabled;
      LabelSelectBook.Enabled = SelectBook.Enabled;
      EditBookTranslation.Enabled = SelectBook.Enabled;
      ActionEditBookMemo.Enabled = SelectBook.Enabled;
      //
      SelectChapter.Enabled = PanelNavigation.Visible;
      SelectChapterNavigator.Enabled = SelectChapter.Enabled;
      LabelSelectChapter.Enabled = SelectChapter.Enabled;
      EditChapterTitle.Enabled = SelectChapter.Enabled;
      EditChapterMemo.Enabled = SelectChapter.Enabled;
      //
      SelectVerse.Enabled = PanelNavigation.Visible && view != ViewMode.BookELS50;
      SelectVerseNavigator.Enabled = SelectVerse.Enabled;
      LabelSelectVerse.Enabled = SelectVerse.Enabled;
      LabelVerseTitle.Enabled = SelectVerse.Enabled;
      EditVerseTitle.Enabled = SelectVerse.Enabled;
      LabelVerseConcept.Enabled = SelectVerse.Enabled;
      EditVerseConcept.Enabled = SelectVerse.Enabled;
      SelectRenderAllVerses.Enabled = SelectVerse.Enabled && view == ViewMode.ChapterVerses;
      SelectRenderAllVersesKeep.Enabled = SelectRenderAllVerses.Enabled;
      ActionSelectRenderAllVersesKeepHelp.Enabled = SelectRenderAllVerses.Enabled;
      ActionSearchVerse.Enabled = SelectVerse.Enabled;
      //
      UpdateHistoryButtons();
    }
  }

}
