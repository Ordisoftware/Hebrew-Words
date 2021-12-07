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

  private void RenderVerses(Panel container, List<ReferenceItem> references)
  {
    container.DisposeAllControls();
    var dummy = new VerseControl();
    int dy = dummy.Padding.Top + dummy.Padding.Bottom + dummy.Padding.Bottom;
    int widthWord = Program.Settings.WordControlWidth;
    int countLines = Program.Settings.VerseCommentaryLinesCount;
    int count = references.Count;
    if ( count == 0 )
      return;
    else
    if ( count == 1 )
      render(references[0]);
    else
      for ( int i = count - 1; i >= 0; i-- ) render(references[i]);
    int commentMargin = ( (VerseControl)container.Controls[0] ).WordControls.Min(c => c.Left) + dummy.Padding.Left;
    foreach ( VerseControl panel in container.Controls )
      panel.PanelCommentLeft.Width = commentMargin;
    //
    void render(ReferenceItem reference)
    {
      var panel = new VerseControl(reference, widthWord, countLines, ContextMenuStripVerse, ContextMenuStripWord);
      container.Controls.Add(panel);
      if ( panel.WordControls.Length > 0 )
      {
        var last = panel.WordControls[panel.WordControls.Length - 1];
        panel.Height = last.Top + last.Height + panel.EditComment.Height + dy;
      }
    }
  }

}
