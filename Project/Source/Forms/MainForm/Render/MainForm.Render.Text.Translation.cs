﻿/// <license>
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

partial class MainForm
{

  public void RenderChapterTranslation(bool isGrouped = false)
  {
    RenderText(EditChapterTranslation, false, isGrouped, () =>
    {
      var builder = new StringBuilder(2048);
      foreach ( VerseRow verse in CurrentReference.Chapter.Verses )
      {
        builder.Append(verse.Number).Append(". ").Append(verse.Translation);
        if ( verse.Comment.Length > 0 )
        {
          builder.AppendLine();
          builder.AppendLine();
          builder.Append(verse.Comment);
        }
        builder.AppendLine();
        builder.AppendLine();
      }
      EditChapterTranslation.Text = builder.ToString();
    });
  }

}
