/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2023 Olivier Rogier.
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
/// <edited> 2022-04 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class MainForm
{

  [SuppressMessage("Style", "GCop408:Flag or switch parameters (bool) should go after all non-optional parameters. If the boolean parameter is not a flag or switch, split the method into two different methods, each doing one thing.", Justification = "Opinion")]
  private void RenderText(RichTextBoxEx textbox, bool isChapterElseBook, bool isGrouped, Action render)
  {
    if ( !isGrouped && !CanRender ) return;
    var chapter = CurrentReference?.Chapter;
    if ( textbox.Tag is ReferenceItem reference
      && CurrentReference?.Book == reference.Book
      && isChapterElseBook
      && chapter == reference.Chapter )
    {
      var verse = CurrentReference?.Verse;
      if ( ( isChapterElseBook && verse != reference.Verse ) || chapter != reference.Chapter )
        SetTanakItemFocus();
      return;
    }
    bool tempRendering = Globals.IsRendering;
    Globals.IsRendering = true;
    textbox.BeginUpdate();
    try
    {
      textbox.Clear();
      textbox.Tag = CurrentReference;
      if ( ( isChapterElseBook && chapter?.Verses is not null ) || chapter is not null )
        render?.Invoke();
    }
    finally
    {
      Globals.IsRendering = tempRendering;
      textbox.EndUpdate();
      textbox.Refresh();
      textbox.Focus();
      SetTanakItemFocus();
    }
  }

  private void AddTextRightAligned(RichTextBoxEx textbox, Font font, string str)
  {
    AddTextRightAligned(textbox, font, str, SystemColors.ControlText);
  }

  private void AddTextRightAligned(RichTextBoxEx textbox, Font font, string str, Color color)
  {
    textbox.SelectionFont = font;
    textbox.SelectionColor = color;
    textbox.SelectionAlignment = TextAlign.Right;
    textbox.AppendText(str);
  }

  private string GetChapterTranslationText(bool forceUnicode = false)
  {
    if ( EditIncludeOriginalText.Checked )

      if ( forceUnicode || !EditExportUseHebrewFontElseUnicodeChars.Checked )
        if ( EditIncludeComment.Checked )
          return CurrentReference.Chapter.UnicodeWithTranslationWithComments;
        else
          return CurrentReference.Chapter.UnicodeWithTranslation;
      else
      if ( EditIncludeComment.Checked )
        return CurrentReference.Chapter.HebrewWithTranslationWithComments;
      else
        return CurrentReference.Chapter.HebrewWithTranslation;
    else
    if ( EditIncludeComment.Checked )
      return CurrentReference.Chapter.TranslationWithComments;
    else
      return CurrentReference.Chapter.Translation;
  }

  private string GetChapterOriginalText()
  {
    if ( EditExportUseHebrewFontElseUnicodeChars.Checked )
      return CurrentReference.Chapter.AsHebrewWithNumber;
    else
      return CurrentReference.Chapter.AsUnicodeWithNumber;
  }

  private string GetBookELS50Text()
  {
    if ( EditExportUseHebrewFontElseUnicodeChars.Checked )
      return CurrentReference.Book.ELS50AsHebrewWithNumber;
    else
      return CurrentReference.Book.ELS50AsUnicodeWithNumber;
  }

}
