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
/// <created> 2021-12 </created>
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

using SQLite;

[Serializable]
[Table("Words")]
public class WordRow : AbstractRow
{

  [NotNull]
  [Indexed]
  public Guid VerseID
  {
    get => _VerseID;
    set
    {
      if ( _VerseID == value ) return;
      _VerseID = value;
      NotifyPropertyChanged(nameof(VerseID));
    }
  }
  private Guid _VerseID;

  [NotNull]
  public string Original
  {
    get => _Original;
    set
    {
      if ( _Original == value ) return;
      _Original = value;
      NotifyPropertyChanged(nameof(Original));
    }
  }
  private string _Original;

  [NotNull]
  public string Hebrew
  {
    get => _Hebrew;
    set
    {
      if ( _Hebrew == value ) return;
      _Hebrew = value;
      NotifyPropertyChanged(nameof(Hebrew));
    }
  }
  private string _Hebrew;

  [NotNull]
  public string Translation
  {
    get => _Translation;
    set
    {
      if ( _Translation == value ) return;
      _Translation = value;
      NotifyPropertyChanged(nameof(Translation));
    }
  }
  private string _Translation;

}
