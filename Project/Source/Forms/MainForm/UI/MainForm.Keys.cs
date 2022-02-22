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

  private static readonly ViewMode[] NagigableViews = new[]
  {
    ViewMode.ChapterVerses,
    ViewMode.ChapterTranslation,
    ViewMode.ChapterOriginal
  };

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
    if ( Globals.IsReady )
      switch ( keyData )
      {
        // Top menu system
        case Keys.Alt | Keys.S:
          ActionSettings.ShowDropDown();
          return true;
        case Keys.Alt | Keys.I:
          ActionInformation.ShowDropDown();
          return true;
        case Keys.F9:
          ActionPreferences.PerformClick();
          return true;
        // Rotate view
        case Keys.Control | Keys.Shift | Keys.Tab:
          SetView(Settings.CurrentView.Previous());
          return true;
        case Keys.Control | Keys.Tab:
          SetView(Settings.CurrentView.Next());
          return true;
        // Change view
        case Keys.F1:
          ActionViewVerses.PerformClick();
          return true;
        case Keys.F2:
          ActionViewTranslations.PerformClick();
          return true;
        case Keys.F3:
          ActionViewVerseFiltered.PerformClick();
          return true;
        case Keys.F4:
        case Keys.Alt | Keys.F:
          if ( Settings.CurrentView != ViewMode.Search )
            ActionViewSearch.PerformClick();
          else
            RotateSearchTab();
          return true;
        case Keys.F5:
          ActionViewRawText.PerformClick();
          return true;
        case Keys.F6:
          ActionViewELS50.PerformClick();
          return true;
        // Top menu system
        case Keys.Alt | Keys.T:
          ActionTools.ShowDropDown();
          return true;
        case Keys.Alt | Keys.L:
          if ( ActionWebLinks.Enabled )
            ActionWebLinks.ShowDropDown();
          return true;
        // Top menu drop downs
        case Keys.Alt | Keys.B:
          ActionBookmarks.ShowDropDown();
          return true;
        case Keys.Alt | Keys.H:
          ActionHistory.ShowDropDown();
          return true;
        case Keys.Alt | Keys.D:
          ActionDatabase.ShowDropDown();
          return true;
        // Top menu actions
        case Keys.F7:
        case Keys.Shift | Keys.Control | Keys.F:
          ActionGoToReference.PerformClick();
          return true;
        case Keys.F8:
        case Keys.Control | Keys.R:
          ActionRefresh.PerformClick();
          return true;
        case Keys.Control | Keys.F:
          ActionSearchVerse.PerformClick();
          return true;
        case Keys.Control | Keys.S:
          ActionSave.PerformClick();
          return true;
        // Context menus
        case Keys.Control | Keys.T:
          if ( ActiveControl is VerseControl )
            ActionSearchTranslated.PerformClick();
          break;
        case Keys.Control | Keys.K:
          if ( ActiveControl is VerseControl )
            ActionSearchWord.PerformClick();
          break;
        case Keys.Control | Keys.W:
          if ( ActiveControl is VerseControl controlVerseWord )
            if ( controlVerseWord.ActiveControl is WordControl controlWord )
            {
              ContextMenuStripWord.Show(controlWord.LabelHebrew, controlWord.LabelHebrew.Width, 5);
              ActionWordSearchOnline.ShowDropDown();
              ActionWordSearchOnline.DropDownItems[0].Select();
            }
          break;
        case Keys.Shift | Keys.Control | Keys.W:
          if ( ActiveControl is VerseControl controlVerseWordDefault )
            if ( controlVerseWordDefault.ActiveControl is WordControl controlWordDefault )
              HebrewTools.OpenWordProvider(Settings.SearchOnlineURL, controlWordDefault.Reference?.Word?.Hebrew, Settings.CustomWebSearch);
          break;
        case Keys.Control | Keys.O:
          if ( ActiveControl is VerseControl controlVerseLabel )
          {
            ContextMenuStripVerse.Show(controlVerseLabel.LabelVerseNumber, controlVerseLabel.LabelVerseNumber.Width, 5);
            ActionVerseReadOnline.ShowDropDown();
            ActionVerseReadOnline.DropDownItems[0].Select();
          }
          break;
        case Keys.Shift | Keys.Control | Keys.O:
          if ( ActiveControl is VerseControl controlVerseLabelDefault )
            HebrewTools.OpenBibleProvider(Settings.OpenVerseOnlineURL, controlVerseLabelDefault.Reference?.ToStringOnlyNumbers());
          break;
        case Keys.Control | Keys.Alt | Keys.I:
          if ( ActiveControl is VerseControl )
            ActionImportConsole.PerformClick();
          return true;
        // Verse navigation
        case Keys.Shift | Keys.Alt | Keys.Up:
          if ( NagigableViews.Contains(Settings.CurrentView) )
            if ( CurrentReference.Chapter.Number > 1 )
            {
              var chapter = CurrentReference.Book.Chapters.Find(c => c.Number == CurrentReference.Chapter.Number - 1);
              if ( chapter is not null ) GoTo(new ReferenceItem(CurrentReference.Book, chapter, chapter.Verses.Last()));
            }
          break;
        case Keys.Shift | Keys.Alt | Keys.Down:
          if ( NagigableViews.Contains(Settings.CurrentView) )
            if ( CurrentReference.Verse.Number < CurrentReference.Book.Chapters.Count - 1 )
            {
              var chapter = CurrentReference.Book.Chapters.Find(c => c.Number == CurrentReference.Chapter.Number + 1);
              if ( chapter is not null ) GoTo(new ReferenceItem(CurrentReference.Book, chapter, chapter.Verses[0]));
            }
          break;
        case Keys.Shift | Keys.Alt | Keys.Left:
          if ( NagigableViews.Contains(Settings.CurrentView) )
            if ( CurrentReference.Verse.Number > 1 )
              GoTo(CurrentReference.Book.Number, CurrentReference.Chapter.Number, 1);
          break;
        case Keys.Shift | Keys.Alt | Keys.Right:
          if ( NagigableViews.Contains(Settings.CurrentView) )
            if ( CurrentReference.Verse.Number < CurrentReference.Chapter.Verses.Count - 1 )
              GoTo(CurrentReference.Book.Number, CurrentReference.Chapter.Number, CurrentReference.Chapter.Verses.Count - 1);
          break;
        case Keys.Alt | Keys.Left:
          if ( NagigableViews.Contains(Settings.CurrentView) )
            if ( CurrentReference.Verse.Number > 1 )
              GoTo(CurrentReference.Book.Number, CurrentReference.Chapter.Number, CurrentReference.Verse.Number - 1);
          break;
        case Keys.Alt | Keys.Right:
          if ( NagigableViews.Contains(Settings.CurrentView) )
            if ( CurrentReference.Verse.Number < CurrentReference.Chapter.Verses.Count - 1 )
              GoTo(CurrentReference.Book.Number, CurrentReference.Chapter.Number, CurrentReference.Verse.Number + 1);
          break;
        // Scrolling bounds
        case Keys.Alt | Keys.Home:
          switch ( Settings.CurrentView )
          {
            case ViewMode.ChapterVerses:
              return scroll(PanelViewVerses, 0, false);
            case ViewMode.VerseFiltered:
              return scroll(PanelViewVerseFiltered, 0, false);
            case ViewMode.Search:
              return scroll(PanelSearchResults, 0, false);
          }
          break;
        case Keys.Alt | Keys.End:
          switch ( Settings.CurrentView )
          {
            case ViewMode.ChapterVerses:
              return scroll(PanelViewVerses, PanelViewVerses.DisplayRectangle.Height, false);
            case ViewMode.VerseFiltered:
              return scroll(PanelViewVerseFiltered, PanelViewVerseFiltered.DisplayRectangle.Height, false);
            case ViewMode.Search:
              return scroll(PanelSearchResults, PanelSearchResults.DisplayRectangle.Height, false);
          }
          break;
        // Scrolling small
        case Keys.Alt | Keys.Up:
          switch ( Settings.CurrentView )
          {
            case ViewMode.ChapterVerses:
              return scroll(PanelViewVerses, -ScrollIncrement, true);
            case ViewMode.VerseFiltered:
              return scroll(PanelViewVerseFiltered, -ScrollIncrement, true);
            case ViewMode.Search:
              return scroll(PanelSearchResults, -ScrollIncrement, true);
          }
          break;
        case Keys.Alt | Keys.Down:
          switch ( Settings.CurrentView )
          {
            case ViewMode.ChapterVerses:
              return scroll(PanelViewVerses, ScrollIncrement, true);
            case ViewMode.VerseFiltered:
              return scroll(PanelViewVerseFiltered, ScrollIncrement, true);
            case ViewMode.Search:
              return scroll(PanelSearchResults, ScrollIncrement, true);
          }
          break;
        // Scrolling large
        case Keys.Alt | Keys.PageUp:
          switch ( Settings.CurrentView )
          {
            case ViewMode.ChapterVerses:
              return scroll(PanelViewVerses, -PanelViewVerses.Height, true);
            case ViewMode.VerseFiltered:
              return scroll(PanelViewVerseFiltered, -PanelViewVerseFiltered.Height, true);
            case ViewMode.Search:
              return scroll(PanelSearchResults, -PanelViewVerses.Height, true);
          }
          break;
        case Keys.Alt | Keys.PageDown:
          switch ( Settings.CurrentView )
          {
            case ViewMode.ChapterVerses:
              return scroll(PanelViewVerses, PanelViewVerses.Height, true);
            case ViewMode.VerseFiltered:
              return scroll(PanelViewVerseFiltered, PanelViewVerseFiltered.Height, true);
            case ViewMode.Search:
              return scroll(PanelSearchResults, PanelViewVerses.Height, true);
          }
          break;
      }
    return base.ProcessCmdKey(ref msg, keyData);
  }

}
