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
using SQLite;

[Serializable]
[Table("Books")]
public class BookRow : AbstractRow
{

  [NotNull]
  [DefaultValue("")]
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
  [DefaultValue("")]
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
  [DefaultValue("")]
  public string Name
  {
    get => _Name;
    set
    {
      if ( _Name == value ) return;
      _Name = value;
      NotifyPropertyChanged(nameof(Name));
    }
  }
  private string _Name;

  [NotNull]
  [DefaultValue("")]
  public string CommonName
  {
    get => _CommonName;
    set
    {
      if ( _CommonName == value ) return;
      _CommonName = value;
      NotifyPropertyChanged(nameof(CommonName));
    }
  }
  private string _CommonName;

  [NotNull]
  [DefaultValue("")]
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

  [NotNull]
  [DefaultValue("")]
  public string Lettriq
  {
    get => _Lettriq;
    set
    {
      if ( _Lettriq == value ) return;
      _Lettriq = value;
      NotifyPropertyChanged(nameof(Lettriq));
    }
  }
  private string _Lettriq;

  [NotNull]
  [DefaultValue("")]
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

  public List<ChapterRow> Chapters { get; } = new();

  public override string ToString()
  {
    string str = $"{FormatNumber(ApplicationDatabase.Instance.Books.Count)}. {Name}";
    if ( CommonName.Length > 0 ) str += $" ({CommonName})";
    if ( Translation.Length > 0 ) str += $" - {Translation}";
    return str;
  }

}
