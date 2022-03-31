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
/// <edited> 2022-03 </edited>
namespace Ordisoftware.Hebrew.Words;

using Equin.ApplicationFramework;

partial class MainForm
{

  /// <summary>
  /// Indicates the last rendered panel having a render tool-tip.
  /// </summary>
  private Panel LastToolTipPanel;

  /// <summary>
  /// Does go to reference at startup.
  /// </summary>
  private void DoStartGoToReference()
  {
    if ( Settings.GoToMasterBookmarkAtStartup )
      GoToReference(Settings.BookmarkMasterBook,
           Settings.BookmarkMasterChapter,
           Settings.BookmarkMasterVerse,
           true);
    else
    if ( Settings.GoToLastVerseAtStartup )
      GoToReference(new ReferenceItem(Settings.LastReferenceBook,
                             Settings.LastReferenceChapter,
                             Settings.LastReferenceVerse,
                             Settings.LastReferenceWord),
           true);
    else
      GoToReference(1, 1, 1, true);
  }

  /// <summary>
  /// Goes to a book > chapter > verse reference.
  /// </summary>
  public void GoToReference(int book, int chapter, int verse, bool forceUpdateView = false, bool setViewChapterVerses = false, bool isHistory = false)
  {
    GoToReference(new ReferenceItem(book, chapter, verse), forceUpdateView, setViewChapterVerses, isHistory);
  }

  /// <summary>
  /// Goes to a book.chapter.verse reference.
  /// </summary>
  public void GoToReference(string reference, bool forceUpdateView = false, bool setViewChapterVerses = false, bool isHistory = false)
  {
    GoToReference(new ReferenceItem(reference), forceUpdateView, setViewChapterVerses, isHistory);
  }

  /// <summary>
  /// Goes to a reference instance.
  /// </summary>
  public void GoToReference(ReferenceItem reference, bool forceUpdateView = false, bool setViewChapterVerses = false, bool isHistory = false)
  {
    if ( reference is null ) return;
    if ( Globals.IsExiting ) return;
    if ( IsGoToRunning ) return;
    if ( setViewChapterVerses )
      SetView(ViewMode.ChapterVerses);
    if ( !forceUpdateView && reference.EqualsWordIncluded(CurrentReference) )
    {
      SetTanakItemFocus();
      return;
    }
    bool updated = false;
    NeedUpdateCurrentReference = false;
    if ( LastToolTipPanel is not null )
      ToolTipSearchResult.Hide(LastToolTipPanel);
    LastToolTipPanel = null;
    IsGoToRunning = true;
    try
    {
      checkComboBoxes();
    }
    finally
    {
      IsGoToRunning = false;
    }
    checkVerse();
    CurrentReference = new ReferenceItem(reference);
    Settings.LastReferenceBook = CurrentReference.Book.Number;
    Settings.LastReferenceChapter = CurrentReference.Chapter.Number;
    Settings.LastReferenceVerse = CurrentReference.Verse.Number;
    Settings.LastReferenceWord = CurrentReference.Word?.Number ?? 1;
    MoveVerseBindingSourceAndAddCurrentToHistory(isHistory);
    LabelTitleReferenceName.Text = " " + CurrentReference?.ToStringBasedOnPrefs().ToUpper() ?? string.Empty;
    LabelTitleReferenceName.Refresh();
    if ( updated || !SelectRenderAllVerses.Checked || forceUpdateView ) RenderAll();
    IsGoToRunning = true;
    try
    {
      SetTanakItemFocus();
    }
    finally
    {
      IsGoToRunning = false;
    }
    updateHistoryButtons();
    //
    // Update history buttons
    //
    void updateHistoryButtons()
    {
      if ( CurrentReference == null ) return;
      var list = HistoryItems.ToList();
      int index = list.FindIndex(( r => r.CompareTo(CurrentReference) == 0 ));
      if ( index == -1 ) return;
      ActionHistoryVerseNext.Enabled = index != 0;
      ActionHistoryVerseBack.Enabled = index != list.Count - 1;
    }
    //
    // Check combo boxes
    // 
    void checkComboBoxes()
    {
      if ( ( SelectBook.SelectedItem as ObjectView<BookRow> )?.Object.Number != reference.Book.Number )
      {
        var item = SelectBook.Items.AsIEnumerable<ObjectView<BookRow>>()
                                   .FirstOrDefault(item => item.Object.Number == reference.Book.Number);
        SelectBook.SelectedItem = item ?? throw new SystemException(AppTranslations.SelectedBookItemIsNull.GetLang());
        updated = true;
      }
      if ( SelectChapter.SelectedIndex != reference.Chapter?.Number - 1 )
      {
        SelectChapter.SelectedIndex = reference?.Chapter?.Number - 1 ?? -1;
        updated = true;
      }
    }
    //
    // Check verse
    //
    void checkVerse()
    {
      if ( reference.Verse is null )
      {
        var found = doCheckVerse();
        reference.Verse = found ?? reference.Chapter?.Verses.Find(v => v.Number == 1);
      }
      // Do check verse
      VerseRow doCheckVerse()
      {
        if ( reference.Chapter?.Verses.Find(v => v.Number == 1).IsFullyTranslated ?? false )
        {
          var found = CurrentReference.Chapter?.Verses?.Find(v => !v.HasTranslation || v.IsPartiallyTranslated);
          if ( found is not null )
          {
            ShowPanelToolTip(AppTranslations.FirstVerseToComplete.GetLang());
            return found;
          }
          else
          {
            ShowPanelToolTip(AppTranslations.NoVerseToComplete.GetLang());
            reference = CurrentReference;
            return null;
          }
        }
        else
        {
          var found = CurrentReference.Chapter?.Verses?.Find(v => v.HasTranslation);
          if ( found is not null )
          {
            ShowPanelToolTip(AppTranslations.FirstVerseTranslated.GetLang());
            return found;
          }
          else
          {
            ShowPanelToolTip(AppTranslations.NoVerseTranslated.GetLang());
            reference = CurrentReference;
            return null;
          }
        }
      }
    }
  }

  /// <summary>
  /// Sets Tanak item focus.
  /// </summary>
  [SuppressMessage("Design", "GCop135:{0}", Justification = "N/A")]
  void SetTanakItemFocus()
  {
    if ( CurrentReference is null ) return;
    switch ( Settings.CurrentView )
    {
      case ViewMode.ChapterVerses:
        var control = PanelViewVerses.Controls.OfType<VerseControl>()
                                     .FirstOrDefault(c => c.Reference.Verse.Number == CurrentReference.Verse?.Number);
        if ( control is not null )
        {
          PanelViewVerses.Focus();
          PanelViewVerses.ScrollControlIntoView(control);
          if ( CurrentReference?.Word is not null && control?.WordControls is not null )
            Array.Find(control?.WordControls, c => c.Reference?.Word == CurrentReference?.Word)?.Focus();
          else
            control.WordControls?.FirstOrDefault()?.Focus();
        }
        break;
      case ViewMode.ChapterTranslation:
        string strTr = $"{CurrentReference.Verse.Number}. ";
        searchRef(EditChapterTranslation, strTr, line => line.StartsWith(strTr, StringComparison.Ordinal));
        break;
      case ViewMode.ChapterOriginal:
        string strSrc = $":{CurrentReference.Verse.Number}";
        searchRef(EditChapterOriginal, strSrc, line => line.EndsWith(strSrc, StringComparison.Ordinal));
        break;
      case ViewMode.BookELS50:
        string strELS = $":{CurrentReference.Chapter.Number}";
        searchRef(EditChapterELS50, strELS, line => line.EndsWith(strELS, StringComparison.Ordinal));
        break;
    }
    //
    static void searchRef(RichTextBoxEx textbox, string str, Func<string, bool> check)
    {
      int pos = textbox.Lines.Where(line => check(line)).Select((_, index) => index).FirstOrDefault();
      textbox.Find(str, textbox.GetFirstCharIndexFromLine(pos), RichTextBoxFinds.None);
    }
  }

}
