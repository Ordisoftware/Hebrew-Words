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

  public void RenderChapterOriginal(bool isGrouped = false)
  {
    if ( !isGrouped && !CanRender ) return;
    if ( EditChapterOriginal.Tag is ReferenceItem reference
      && CurrentReference?.Book == reference.Book && CurrentReference?.Chapter == reference.Chapter )
    {
      if ( CurrentReference?.Verse != reference.Verse ) moveCaret();
      return;
    }
    bool tempRendering = Globals.IsRendering;
    Globals.IsRendering = true;
    EditChapterOriginal.BeginUpdate();
    try
    {
      EditChapterOriginal.Clear();
      EditChapterOriginal.Tag = CurrentReference;
      if ( CurrentReference?.Chapter?.Verses != null )
      {
        var builder = new StringBuilder();
        var box = new RichTextBoxEx();
        foreach ( VerseRow verse in CurrentReference.Chapter.Verses )
        {
          for ( int index = verse.Words.Count - 1; index >= 0; index-- )
            builder.Append(verse.Words[index].Hebrew).Append(" ");
          AddTextRightAligned(box, HebrewFont12, builder.ToString());
          AddTextRightAligned(box, LatinFont10, ":" + verse.Number);
          box.AppendText(Environment.NewLine);
          box.AppendText(Environment.NewLine);
          builder.Clear();
        }
        EditChapterOriginal.Rtf = box.Rtf;
      }
    }
    finally
    {
      Globals.IsRendering = tempRendering;
      EditChapterOriginal.EndUpdate();
      EditChapterOriginal.Focus();
      EditChapterOriginal.Refresh();
      moveCaret();
    }
    void moveCaret()
    {
      // TODO 
      EditChapterOriginal.SelectionStart = 0;
    }
  }

}
