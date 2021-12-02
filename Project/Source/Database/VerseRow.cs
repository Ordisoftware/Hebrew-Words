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

using System;
using System.ComponentModel;
using SQLite;
using SQLiteNetExtensions.Attributes;

[Serializable]
[Table("Verses")]
public partial class VerseRow : INotifyPropertyChanged
{

  [field: NonSerialized]
  public event PropertyChangedEventHandler PropertyChanged;

  protected void NotifyPropertyChanged(string p)
  {
    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(p));
    ApplicationDatabase.Instance.AddToModified(this);
  }

  [PrimaryKey]
  [NotNull]
  public string ID
  {
    get => _ID;
    set
    {
      if ( _ID == value ) return;
      _ID = value;
      NotifyPropertyChanged(nameof(ID));
    }
  }
  private string _ID;

  [ForeignKey(typeof(ChapterRow))]
  [NotNull]
  public string ChapterID
  {
    get => _ChapterID;
    set
    {
      if ( _ChapterID == value ) return;
      _ChapterID = value;
      NotifyPropertyChanged(nameof(ChapterID));
    }
  }
  private string _ChapterID;

  [NotNull]
  public int Number
  {
    get => _Number;
    set
    {
      if ( _Number == value ) return;
      _Number = value;
      NotifyPropertyChanged(nameof(Number));
    }
  }
  private int _Number;

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
  private string _Comment;

  public List<WordRow> Words { get; } = new();

}
