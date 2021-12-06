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

using Equin.ApplicationFramework;

partial class MainForm
{

  /// <summary>
  /// Go to a book > chapter > verse reference.
  /// </summary>
  public void GoTo(int book, int chapter, int verse, bool forceUpdateView = false)
  {
    GoTo(new ReferenceItem(book, chapter, verse), forceUpdateView);
  }

  /// <summary>
  /// Go to a book.chapter.verse reference.
  /// </summary>
  public void GoTo(string reference, bool forceUpdateView = false)
  {
    SystemManager.TryCatch(() =>
    {
      int[] items = reference.Split('.').Select(int.Parse).ToArray();
      GoTo(new ReferenceItem(items[0], items[1], items[2]), forceUpdateView);
    });
  }

  private Panel LastToolTipPanel;

  /// <summary>
  /// Go to a reference instance.
  /// </summary>
  public void GoTo(ReferenceItem reference, bool forceUpdateView = false)
  {
    if ( reference == null ) return;
    if ( Globals.IsExiting ) return;
    if ( IsGoToRunning ) return;
    bool updated = false;
    IsGoToRunning = true;
    NeedUpdateCurrentReference = false;
    if ( LastToolTipPanel != null ) ToolTipSearchResult.Hide(LastToolTipPanel);
    LastToolTipPanel = null;
    checkComboBoxes();
    checkVerse();
    CurrentReference = new ReferenceItem(reference);
    MoveVerseBindingSourceAndAddCurrentToHistory();
    LabelTitleReferenceName.Text = " " + CurrentReference?.ToStringFull().ToUpper() ?? string.Empty;
    LabelTitleReferenceName.Refresh();
    if ( updated || !SelectRenderAllVerses.Checked || forceUpdateView ) RenderAll();
    setFocus();
    //
    // Check combo boxes
    // 
    void checkComboBoxes()
    {
      try
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
          SelectChapter.SelectedIndex = reference.Chapter.Number - 1;
          updated = true;
        }
      }
      finally
      {
        IsGoToRunning = false;
      }
    }
    //
    // Check verse
    //
    void checkVerse()
    {
      if ( reference.Verse == null )
      {
        var found = doCheckVerse();
        reference.Verse = found ?? reference.Chapter?.Verses.Find(v => v.Number == 1);
      }
      // Do check verse
      VerseRow doCheckVerse()
      {
        if ( reference.Chapter.Verses.Find(v => v.Number == 1).IsFullyTranslated )
        {
          var found = CurrentReference.Chapter?.Verses?.Find(v => !v.HasTranslation || v.IsPartiallyTranslated);
          if ( found != null )
          {
            showToolTip("Premier verset à compléter.");
            return found;
          }
          else
          {
            showToolTip("Aucun verset à compléter.");
            reference = CurrentReference;
            return null;
          }
        }
        else
        {
          var found = CurrentReference.Chapter?.Verses?.Find(v => v.IsFullyTranslated);
          if ( found != null )
          {
            showToolTip("Premier verset complètement traduit.");
            return found;
          }
          else
          {
            showToolTip("Aucun verset avec traduction complète.");
            reference = CurrentReference;
            return null;
          }
        }
        // Show tool tip
        void showToolTip(string str)
        {
          Panel panel = null;
          int width = TextRenderer.MeasureText(str, SystemFonts.SmallCaptionFont).Width;
          int x = 5;
          int y = 5;
          if ( Settings.CurrentView == ViewMode.Verses )
          {
            x = PanelViewVerses.PreferredSize.Width - 5 - width;
            panel = PanelViewVerses;
          }
          if ( Settings.CurrentView == ViewMode.Translation )
          {
            panel = PanelViewTranslations;
          }
          if ( panel != null ) ToolTipSearchResult.Show(str, panel, x, y, 4000);
          LastToolTipPanel = panel;
        }
      }
    }
    //
    // Set focus
    // 
    void setFocus()
    {
      switch ( Settings.CurrentView )
      {
        case ViewMode.Verses:
          var label = PanelViewVerses.GetAll<Label>()
                                     .FirstOrDefault(label => label.Text == reference.Verse?.Number.ToString());
          if ( label != null )
          {
            PanelViewVerses.Focus();
            PanelViewVerses.ScrollControlIntoView(label.Parent);
            if ( reference.Word != null )
              PanelViewVerses.GetAll<WordControl>()
                             .FirstOrDefault(wordcontrol => wordcontrol.Reference.Word == reference.Word)?
                             .Focus();
            else
              ( label.Parent.Controls[1] as WordControl )?.Focus();
          }
          break;
        case ViewMode.Translation:
          string strTr = reference.Verse.Number + ". ";
          searchRef(EditTranslations, strTr, line => line.StartsWith(strTr));
          break;
        case ViewMode.Text:
          string strSrc = ":" + reference.Verse.Number;
          searchRef(EditRawText, strSrc, line => line.EndsWith(strSrc));
          break;
      }
      // Search reference in text box
      static void searchRef(RichTextBox textbox, string str, Func<string, bool> check)
      {
        foreach ( string line in textbox.Lines )
          if ( check(line) )
          {
            textbox.SelectionStart = textbox.Find(str);
            textbox.SelectionLength = 0;
            textbox.ScrollToCaret();
            textbox.Focus();
            break;
          }
      }
    }
  }

}
