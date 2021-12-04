﻿/// <license>
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
/// <created> 2021-12 </created>
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class MainForm
{

  private void RenderVersesFiltered()
  {
    if ( IsRendering ) return;
    IsRendering = true;
    try
    {
      var references = new List<ReferenceItem>();
      references.Add(new ReferenceItem(( SelectFilterBook.SelectedItem as BookRow )?.Number ?? 1,
                                       ( SelectFilterChapter.SelectedItem as ChapterRow )?.Number ?? 1,
                                       ( SelectFilterVerse.SelectedItem as VerseRow )?.Number ?? 1));
      RenderVerses(PanelViewFiltersVerse, references);
    }
    catch ( Exception ex )
    {
      ex.Manage();
    }
    finally
    {
      IsRendering = false;
    }
  }

}
