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
using System.Collections.Generic;
using System.ComponentModel;
using SQLite;
using SQLiteNetExtensions.Attributes;

[Serializable]
[Table("Chapters")]
public class ChapterRow : INotifyPropertyChanged
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

  [ForeignKey(typeof(BookRow))]
  [NotNull]
  public string BookID
  {
    get => _BookID;
    set
    {
      if ( _BookID == value ) return;
      _BookID = value;
      NotifyPropertyChanged(nameof(BookID));
    }
  }
  private string _BookID;

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
  public string Title
  {
    get => _Title;
    set
    {
      if ( _Title == value ) return;
      _Title = value;
      NotifyPropertyChanged(nameof(Title));
    }
  }
  private string _Title;

  [NotNull]
  public string Memo
  {
    get => _Memo;
    set
    {
      if ( _Memo == value ) return;
      _Memo = value;
      NotifyPropertyChanged(nameof(Memo));
    }
  }
  private string _Memo;

  [NotNull]
  public string ELS50
  {
    get => _ELS50;
    set
    {
      if ( _ELS50 == value ) return;
      _ELS50 = value;
      NotifyPropertyChanged(nameof(ELS50));
    }
  }
  private string _ELS50;

  [field: NonSerialized]
  public readonly List<VerseRow> Verses = new();

}
