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
public abstract class AbstractRow : INotifyPropertyChanged
{

  [field: NonSerialized]
  public event PropertyChangedEventHandler PropertyChanged;

  protected void NotifyPropertyChanged(string property)
  {
    if ( !ApplicationDatabase.Instance.Loaded || !ApplicationDatabase.Instance.BindingsEnabled ) return;
    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
    ApplicationDatabase.Instance.AddToModified(this);
  }

  protected string FormatNumber(int count)
    => count switch
    {
      >= 100 => Number.ToString("000"),
      >= 10 => Number.ToString("00"),
      _ => Number.ToString()
    };

  [PrimaryKey]
  public Guid ID
  {
    get => _ID;
    set
    {
      if ( _ID == value ) return;
      _ID = value;
      NotifyPropertyChanged(nameof(ID));
    }
  }
  private Guid _ID;

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

}
