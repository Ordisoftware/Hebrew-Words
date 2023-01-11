/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2023 Olivier Rogier.
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
[Table("Books")]
public partial class BookRow : AbstractRowWithMemo
{

  /// <summary>
  /// Obsolete: Value comes from a dictionary.
  /// </summary>
  [NotNull]
  [Column("Original")]
  [SuppressMessage("Critical Bug", "S4275:Getters and setters should access the expected fields", Justification = "N/A")]
  public string Unicode
  {
    get => BookInfos.Unicode[(TanakBook)Number];
    set
    {
      if ( _Unicode == value ) return;
      _Unicode = value;
      NotifyPropertyChanged(nameof(Unicode));
    }
  }
  private string _Unicode = string.Empty;

  /// <summary>
  /// Obsolete: Value comes from a dictionary.
  /// </summary>
  [NotNull]
  [SuppressMessage("Critical Bug", "S4275:Getters and setters should access the expected fields", Justification = "N/A")]
  public string Hebrew
  {
    get => BookInfos.Hebrew[(TanakBook)Number];
    set
    {
      if ( _Hebrew == value ) return;
      _Hebrew = value;
      NotifyPropertyChanged(nameof(Hebrew));
    }
  }
  private string _Hebrew = string.Empty;

  /// <summary>
  /// Obsolete: Value comes from a dictionary.
  /// </summary>
  [NotNull]
  [Column("Name")]
  [SuppressMessage("Critical Bug", "S4275:Getters and setters should access the expected fields", Justification = "N/A")]
  public string Transcription
  {
    get => BookInfos.Transcriptions.GetLang((TanakBook)Number);
    set
    {
      if ( _Transcription == value ) return;
      _Transcription = value;
      NotifyPropertyChanged(nameof(Transcription));
    }
  }
  private string _Transcription = string.Empty;

  /// <summary>
  /// Obsolete: Value comes from a dictionary.
  /// </summary>
  [NotNull]
  [SuppressMessage("Critical Bug", "S4275:Getters and setters should access the expected fields", Justification = "N/A")]
  public string CommonName
  {
    get => BookInfos.Common.GetLang((TanakBook)Number);
    set
    {
      if ( _CommonName == value ) return;
      _CommonName = value;
      NotifyPropertyChanged(nameof(CommonName));
    }
  }
  private string _CommonName = string.Empty;

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
  private string _Translation = string.Empty;

  [NotNull]
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
  private string _Lettriq = string.Empty;

  public List<ChapterRow> Chapters { get; } = new();

}
