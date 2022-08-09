/// <license>
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
/// <edited> 2022-08 </edited>
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
  [SuppressMessage("Design", "MA0051:Method is too long", Justification = "N/A")]
  [SuppressMessage("Design", "GCop135:{0}", Justification = "N/A")]
  [SuppressMessage("Performance", "GCop317:This code is repeated {0} times in this method. If its value remains the same during the method execution, store it in a variable. Otherwise define a method (or Func<T> variable) instead of repeating the expression. [{1}]", Justification = "N/A")]
  protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
  {
    static bool scroll(Panel panel, int ypos, bool abs)
    {
      int dy = abs ? Math.Abs(panel.AutoScrollPosition.Y) : 0;
      panel.AutoScrollPosition = new Point(panel.AutoScrollPosition.X, ypos + dy);
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
        // Navigate in history
        case Keys.Control | Keys.Shift | Keys.P:
          ActionHistoryVerseBack.PerformClick();
          return true;
        case Keys.Control | Keys.Shift | Keys.N:
          ActionHistoryVerseNext.PerformClick();
          return true;
        // Change view and search
        case Keys.F1:
          ActionViewVerses.PerformClick();
          return true;
        case Keys.F2:
          ActionViewTranslations.PerformClick();
          return true;
        case Keys.F3:
        case Keys.Alt | Keys.F:
          if ( Settings.CurrentView != ViewMode.Search )
            ActionViewSearch.PerformClick();
          else
            RotateSearchTab();
          return true;
        case Keys.F4:
          ActionViewVerseFiltered.PerformClick();
          return true;
        case Keys.F5:
        case Keys.Shift | Keys.Control | Keys.F:
          ActionGoToReference.PerformClick();
          return true;
        case Keys.F6:
          ActionViewRawText.PerformClick();
          return true;
        case Keys.F7:
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
        case Keys.Alt | Keys.P:
          ActionTools.ShowDropDown();
          ActionGoToParashah.ShowDropDown();
          ActionGoToParashah.DropDownItems[0].Select();
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
          {
            ActionSearchWord.PerformClick();
            return true;
          }
          break;
        case Keys.Control | Keys.W:
          if ( ActiveControl is VerseControl controlVerseWord )
            if ( controlVerseWord.ActiveControl is WordControl controlWord )
            {
              ContextMenuStripWord.Show(controlWord.LabelHebrew, controlWord.LabelHebrew.Width, 5);
              ActionWordSearchOnline.ShowDropDown();
              ActionWordSearchOnline.DropDownItems[0].Select();
              return true;
            }
          break;
        case Keys.Shift | Keys.Control | Keys.W:
          if ( ActiveControl is VerseControl controlVerseWordDefault )
            if ( controlVerseWordDefault.ActiveControl is WordControl controlWordDefault )
            {
              HebrewTools.OpenWordProvider(Settings.SearchOnlineURL, controlWordDefault.Reference?.Word?.Hebrew);
              return true;
            }
          break;
        case Keys.Control | Keys.O:
          if ( ActiveControl is VerseControl controlVerseLabel )
          {
            ContextMenuStripVerse.Show(controlVerseLabel.LabelVerseNumber, controlVerseLabel.LabelVerseNumber.Width, 5);
            ActionVerseReadOnline.ShowDropDown();
            ActionVerseReadOnline.DropDownItems[0].Select();
            return true;
          }
          break;
        case Keys.Shift | Keys.Control | Keys.O:
          if ( ActiveControl is VerseControl controlVerseLabelDefault )
            HebrewTools.OpenBibleProvider(Settings.OpenVerseOnlineURL, controlVerseLabelDefault.Reference?.ToStringOnlyNumbers());
          break;
        case Keys.Control | Keys.Alt | Keys.I:
          if ( ActiveControl is VerseControl )
          {
            ActionImportConsole.PerformClick();
            return true;
          }
          break;
        case Keys.Control | Keys.Alt | Keys.Shift | Keys.I:
          if ( ActiveControl is VerseControl )
          {
            ActionImportConsoleAuto.PerformClick();
            return true;
          }
          break;
        // Verse navigation
        case Keys.Shift | Keys.Alt | Keys.Up:
          if ( NagigableViews.Contains(Settings.CurrentView) )
            if ( CurrentReference.Chapter.Number > 1 )
            {
              var chapter = CurrentReference.Book.Chapters.Find(c => c.Number == CurrentReference.Chapter.Number - 1);
              if ( chapter is not null )
              {
                var verse = chapter.Verses[chapter.Verses.Count - 1];
                GoToReference(new ReferenceItem(CurrentReference.Book, chapter, verse));
                return true;
              }
            }
          break;
        case Keys.Shift | Keys.Alt | Keys.Down:
          if ( NagigableViews.Contains(Settings.CurrentView) )
            if ( CurrentReference.Verse.Number < CurrentReference.Book.Chapters.Count )
            {
              var chapter = CurrentReference.Book.Chapters.Find(c => c.Number == CurrentReference.Chapter.Number + 1);
              if ( chapter is not null )
              {
                GoToReference(new ReferenceItem(CurrentReference.Book, chapter, chapter.Verses[0]));
                return true;
              }
            }
          break;
        case Keys.Shift | Keys.Alt | Keys.Left:
          if ( NagigableViews.Contains(Settings.CurrentView) )
            if ( CurrentReference.Verse.Number > 1 )
            {
              GoToReference(CurrentReference.Book.Number, CurrentReference.Chapter.Number, 1);
              return true;
            }
          break;
        case Keys.Shift | Keys.Alt | Keys.Right:
          if ( NagigableViews.Contains(Settings.CurrentView) )
            if ( CurrentReference.Verse.Number < CurrentReference.Chapter.Verses.Count )
            {
              GoToReference(CurrentReference.Book.Number, CurrentReference.Chapter.Number, CurrentReference.Chapter.Verses.Count);
              return true;
            }
          break;
        case Keys.Alt | Keys.Left:
          if ( NagigableViews.Contains(Settings.CurrentView) )
            if ( CurrentReference.Verse.Number > 1 )
            {
              GoToReference(CurrentReference.Book.Number, CurrentReference.Chapter.Number, CurrentReference.Verse.Number - 1);
              return true;
            }
          break;
        case Keys.Alt | Keys.Right:
          if ( NagigableViews.Contains(Settings.CurrentView) )
            if ( CurrentReference.Verse.Number < CurrentReference.Chapter.Verses.Count )
            {
              GoToReference(CurrentReference.Book.Number, CurrentReference.Chapter.Number, CurrentReference.Verse.Number + 1);
              return true;
            }
          break;
        // Scrolling bounds
        case Keys.Alt | Keys.Home:
          switch ( Settings.CurrentView )
          {
            case ViewMode.ChapterVerses:
              if ( SelectRenderAllVerses.Checked )
                scroll(PanelViewVerses, 0, false);
              else
                GoToReference(CurrentReference.Book.Number, CurrentReference.Chapter.Number, 1);
              return true;
            case ViewMode.VerseFiltered:
              return scroll(PanelViewVerseFiltered, 0, false);
            case ViewMode.Search:
              return scroll(PanelSearchResults, 0, false);
            case ViewMode.ChapterTranslation:
            case ViewMode.ChapterOriginal:
              GoToReference(CurrentReference.Book.Number, CurrentReference.Chapter.Number, 1);
              return true;
          }
          break;
        case Keys.Alt | Keys.End:
          switch ( Settings.CurrentView )
          {
            case ViewMode.ChapterVerses:
              if ( SelectRenderAllVerses.Checked )
                scroll(PanelViewVerses, PanelViewVerses.DisplayRectangle.Height, false);
              else
                GoToReference(CurrentReference.Book.Number, CurrentReference.Chapter.Number, CurrentReference.Chapter.Verses.Count);
              return true;
            case ViewMode.VerseFiltered:
              return scroll(PanelViewVerseFiltered, PanelViewVerseFiltered.DisplayRectangle.Height, false);
            case ViewMode.Search:
              return scroll(PanelSearchResults, PanelSearchResults.DisplayRectangle.Height, false);
            case ViewMode.ChapterTranslation:
            case ViewMode.ChapterOriginal:
              GoToReference(CurrentReference.Book.Number, CurrentReference.Chapter.Number, CurrentReference.Chapter.Verses.Count);
              return true;
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
