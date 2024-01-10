/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2024 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at
/// https://mozilla.org/MPL/2.0/.
/// If it is not possible or desirable to put the notice in a particular file,
/// then You may include the notice in a location(such as a LICENSE file in a
/// relevant directory) where a recipient would be likely to look for such a notice.
/// You may add additional accurate notices of copyright ownership.
/// </license>
/// <created> 2016-04 </created>
/// <edited> 2022-11 </edited>
namespace Ordisoftware.Hebrew.Words;

/// <summary>
/// The application's main form.
/// </summary>
/// <seealso cref="T:System.Windows.Forms.Form"/>
partial class MainForm
{

  private ViewConnectors<ViewMode, ToolStripButton> ViewConnectors;

  private void InitializeViewConnectors()
  {
    ViewConnectors = new ViewConnectors<ViewMode, ToolStripButton>
    {
      {
        ViewMode.ChapterVerses,
        new ViewConnector<ToolStripButton>
        {
          Component = ActionViewVerses,
          Panel = PanelViewVerses,
          Focused = PanelViewVerses
        }
      },
      {
        ViewMode.VerseFiltered,
        new ViewConnector<ToolStripButton>
        {
          Component = ActionViewVerseFiltered,
          Panel = PanelViewVerseFiltered,
          Focused = PanelViewVerseFiltered
        }
      },
      {
        ViewMode.ChapterTranslation,
        new ViewConnector<ToolStripButton>
        {
          Component = ActionViewTranslations,
          Panel = PanelViewTranslations,
          Focused = TextBoxTranslations
        }
      },
      {
        ViewMode.ChapterOriginal,
        new ViewConnector<ToolStripButton>
        {
          Component = ActionViewRawText,
          Panel = PanelViewOriginalText,
          Focused = EditChapterOriginal
        }
      },
      {
        ViewMode.BookELS50,
        new ViewConnector<ToolStripButton>
        {
          Component = ActionViewELS50,
          Panel = PanelViewELS50,
          Focused = EditChapterELS50
        }
      },
      {
        ViewMode.Search,
        new ViewConnector<ToolStripButton>
        {
          Component = ActionViewSearch,
          Panel = PanelViewSearch,
          Focused = SelectSearchType
        }
      }
    };
  }

}
