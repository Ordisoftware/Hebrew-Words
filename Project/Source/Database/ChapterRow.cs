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
/// <edited> 2022-06 </edited>
namespace Ordisoftware.Hebrew.Words;

using SQLite;

[Serializable]
[Table("Chapters")]
public partial class ChapterRow : AbstractRowWithTitleAndMemo
{

  [NotNull]
  [Indexed]
  public Guid BookID
  {
    get => _BookID;
    set
    {
      if ( _BookID == value ) return;
      _BookID = value;
      NotifyPropertyChanged(nameof(BookID));
    }
  }
  private Guid _BookID;

  [NotNull]
  [Column("ELS50")]
  public string ELS50
  {
    get => _ELS50AsHebrew;
    set
    {
      if ( _ELS50AsHebrew == value ) return;
      _ELS50AsHebrew = value;
      NotifyPropertyChanged(nameof(ELS50));
    }
  }
  private string _ELS50AsHebrew = string.Empty;

  public string ELS50AsHebrewWithNumber
    => $"{_ELS50AsHebrew} :{NumberFormatted}";

  public string ELS50AsUnicode
    => HebrewAlphabet.ToUnicodeChars(_ELS50AsHebrew);

  public string ELS50AsUnicodeWithNumber
    => $"{ELS50AsUnicode} :{NumberFormatted}";

  public List<VerseRow> Verses { get; } = new();

}
