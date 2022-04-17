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
/// <edited> 2022-03 </edited>
namespace Ordisoftware.Hebrew.Words;

using SQLite;

[Serializable]
[Table("Verses")]
public partial class VerseRow : AbstractRow
{

  [NotNull]
  [Indexed]
  public Guid ChapterID
  {
    get => _ChapterID;
    set
    {
      if ( _ChapterID == value ) return;
      _ChapterID = value;
      NotifyPropertyChanged(nameof(ChapterID));
    }
  }
  private Guid _ChapterID;

  [NotNull]
  public string Comment
  {
    get => _Comment;
    set
    {
      if ( _Comment == value ) return;
      _Comment = value;
      NotifyPropertyChanged(nameof(Comment));
    }
  }
  private string _Comment = string.Empty;

  public List<WordRow> Words { get; } = new();

}
