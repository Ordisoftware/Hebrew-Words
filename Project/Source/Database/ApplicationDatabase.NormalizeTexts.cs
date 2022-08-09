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
/// <created> 2021-12 </created>
/// <edited> 2022-08 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class ApplicationDatabase
{

  public void DoNormalizeTexts()
  {

    //foreach ( var book in Instance.Books )
    //{
    //  book.Translation = book.Translation.Titleize();
    //  book.Lettriq = book.Lettriq.Titleize();

    //  var memo = Program.Settings.NormalizeRemoveEmptyLines
    //    ? book.Memo.SplitNoEmptyLines()
    //    : book.Memo.SplitKeepEmptyLines();

    //  for ( int index = 0; index < book.Memo.Length; index++ )
    //  {
    //    memo[index] = memo[index].Trim();
    //    memo[index] = memo[index].Titleize();
    //    if ( !memo[index].EndsWith(".", StringComparison.Ordinal) )
    //      memo[index] += ".";
    //  }
    //  book.Memo = memo.AsMultiLine();
    //}

    //foreach ( var chapter in Chapters )
    //{
    //}

    //foreach ( var verse in Verses )
    //{
    //  verse.Comment = VerseControl.CheckComment(verse.Comment);
    //}

  }

}
