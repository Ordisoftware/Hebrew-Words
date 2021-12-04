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
  /// Go to book / chapter / verse into view verses panel.
  /// </summary>
  public void GoTo(string reference, bool forceUpdateView = false)
  {
    SystemManager.TryCatch(() =>
    {
      int[] items = reference.Split('.').Select(int.Parse).ToArray();
      GoTo(new ReferenceItem(items[0], items[1], items[2]), forceUpdateView);
    });
  }

  /// <summary>
  /// Go to book / chapter / verse into view verses panel.
  /// </summary>
  public void GoTo(int book, int chapter, int verse, bool forceUpdateView = false)
  {
    GoTo(new ReferenceItem(book, chapter, verse), forceUpdateView);
  }

  /// <summary>
  /// Go to book / chapter / verse into view verses panel.
  /// </summary>
  public void GoTo(ReferenceItem reference, bool forceUpdateView = false)
  {
    if ( reference == null ) return;
    if ( IsGoToRunning ) return;
    if ( Globals.IsExiting ) return;
    IsGoToRunning = true;
    bool updated = false;
    try
    {
      if ( ( SelectBook.SelectedItem as ObjectView<BookRow> )?.Object.Number != reference.Book.Number )
      {
        var item = SelectBook.Items.AsIEnumerable<ObjectView<BookRow>>()
                                   .FirstOrDefault(item => item.Object.Number == reference.Book.Number);
        SelectBook.SelectedItem = item ?? throw new SystemException("Book combo-box internal index error.");
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
    if ( reference.Verse == null )
    {
      var found = CurrentReference.Chapter?.Verses?.Find(v => !v.HasTranslation);
      reference.Verse = found ?? reference.Chapter?.Verses[0];
    }
    CurrentReference = new ReferenceItem(reference);
    MoveVerseBindingSourceAndAddCurrentToHistory();
    if ( updated || !SelectRenderAllVerses.Checked || forceUpdateView )
      RenderAll();
    // 
    switch ( Program.Settings.CurrentView )
    {
      case ViewMode.Verses:
        var label = PanelViewVerses.GetAll<Label>()
                                   .Where(label => label.Text == reference.Verse?.Number.ToString())
                                   .FirstOrDefault();
        if ( label != null )
        {
          PanelViewVerses.Focus();
          PanelViewVerses.ScrollControlIntoView(label.Parent);
          //PanelViewVerses.ScrollControlIntoView((Control)label.Tag);
          if ( reference.Word != null )
            PanelViewVerses.GetAll<WordControl>()
                           .Where(wordcontrol => wordcontrol.Reference.Word == reference.Word)
                           .FirstOrDefault()?
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
    //
    void searchRef(RichTextBox textbox, string str, Func<string, bool> check)
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
