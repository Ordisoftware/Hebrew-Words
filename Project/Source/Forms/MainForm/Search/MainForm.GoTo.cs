using Equin.ApplicationFramework;
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
    IsGoToRunning = true;
    bool updated = false;
    try
    {
      if ( ( SelectBook.SelectedItem as ObjectView<BookRow> )?.Object.Number != reference.Book.Number )
      {
        foreach ( var item in SelectBook.Items )
          if ( ( item as ObjectView<BookRow> )?.Object.Number == reference.Book.Number )
          {
            SelectBook.SelectedItem = item;
            updated = true;
            break;
          }
        if ( !updated ) throw new Exception("Book combo-box index error.");
      }
      if ( SelectChapter.SelectedIndex > 0 )
        if ( SelectChapter.SelectedIndex != reference.Chapter.Number - 1 )
        {
          SelectChapter.SelectedIndex = reference.Chapter.Number - 1;
          updated = true;
        }
    }
    finally
    {
      IsGoToRunning = false;
      CurrentReference = new ReferenceItem(reference);
      AddCurrentToHistory();
    }
    if ( Globals.IsLoadingData ) return;
    if ( updated || forceUpdateView )
      RenderAll();
    if ( reference.Verse == null )
    {
      var found = CurrentReference.Chapter?.Verses?.Find(v => !v.HasTranslation());
      reference.Verse = found ?? reference.Chapter?.Verses[0];
    }
  Label:
    switch ( Program.Settings.CurrentView )
    {
      case ViewMode.Verses:
        foreach ( var control in PanelViewVerses.Controls )
          if ( control is Label )
          {
            var label = control as Label;
            if ( label.Text == reference.Verse?.Number.ToString() )
            {
              PanelViewVerses.Focus();
              PanelViewVerses.ScrollControlIntoView(label);
              PanelViewVerses.ScrollControlIntoView((Control)label.Tag);
              int index = PanelViewVerses.Controls.IndexOf(label);
              ( PanelViewVerses.Controls[index + 1] as WordControl )?.Focus();
              break;
            }
          }
        if ( reference.Word != null )
          foreach ( Control control in PanelViewVerses.Controls )
            if ( control is WordControl wordcontrol )
              if ( wordcontrol.Reference.Word == reference.Word )
              {
                control.Focus();
                break;
              }
        break;
      case ViewMode.Translations:
        foreach ( string line in EditTranslations.Lines )
        {
          string s = reference.Verse.Number + ". ";
          if ( line.StartsWith(s) )
          {
            EditTranslations.SelectionStart = EditTranslations.Find(s);
            EditTranslations.SelectionLength = 0;
            EditTranslations.ScrollToCaret();
            EditTranslations.Focus();
          }
        }
        break;
      case ViewMode.Text:
        foreach ( string line in EditRawText.Lines )
        {
          string s = ":" + reference.Verse.Number;
          if ( line.EndsWith(s) )
          {
            EditRawText.SelectionStart = EditRawText.Find(s);
            EditRawText.SelectionLength = 0;
            EditRawText.ScrollToCaret();
            EditRawText.Focus();
          }
        }
        break;
      default:
        SetView(ViewMode.Verses);
        goto Label;
    }
  }

}
