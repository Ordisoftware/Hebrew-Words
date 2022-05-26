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
/// <created> 2020-08 </created>
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

/// <summary>
/// Provides application statistics.
/// </summary>
class ApplicationStatistics
{

  static public readonly ApplicationStatistics Instance = new();

  public string StartingTime
    => Program.Settings.BenchmarkStartingApp.FormatMilliseconds();

  public string TranslateTime
    => Program.Settings.BenchmarkTranslate.FormatMilliseconds();

  public string LoadDataTime
    => Program.Settings.BenchmarkLoadData.FormatMilliseconds();

  public string RenderingTime
    => Program.Settings.BenchmarkRendering.FormatMilliseconds();

  public string DBTotalRecordsCount
    => ( ApplicationDatabase.Instance.Books?.Count +
         ApplicationDatabase.Instance.Chapters?.Count +
         ApplicationDatabase.Instance.Verses?.Count +
         ApplicationDatabase.Instance.Words?.Count ).ToString() ?? SysTranslations.NullSlot.GetLang();

  public string DBEngine
    => SQLiteNetORM.EngineNameAndVersion;

  public string DBProvider
    => SQLiteNetORM.ProviderName;

  public string DBFileSize
  {
    get
    {
      if ( UpdateDBFileSizeRequired )
      {
        UpdateDBFileSizeRequired = false;
        _DBFileSize = SystemManager.GetFileSize(Globals.ApplicationDatabaseFilePath).FormatBytesSize();
      }
      return _DBFileSize;
    }
  }
  static private string _DBFileSize;
  static internal bool UpdateDBFileSizeRequired { get; set; } = true;

  public string DBMemorySize
  {
    get
    {
      if ( UpdateDBMemorySizeRequired )
        try
        {
          LoadingForm.Instance.Initialize(SysTranslations.CalcutalingDataMemorySize.GetLang(), 4, quantify: false);
          UpdateDBMemorySizeRequired = false;
          long size1 = ApplicationDatabase.Instance.Books?.SizeOf() ?? 0;
          LoadingForm.Instance.DoProgress();
          long size2 = ApplicationDatabase.Instance.Chapters?.SizeOf() ?? 0;
          LoadingForm.Instance.DoProgress();
          long size3 = ApplicationDatabase.Instance.Verses?.SizeOf() ?? 0;
          LoadingForm.Instance.DoProgress();
          long size4 = ApplicationDatabase.Instance.Words?.SizeOf() ?? 0;
          LoadingForm.Instance.DoProgress();
          _DBMemorySize = size1 > 0 && size2 > 0 && size3 > 0 && size4 > 0
            ? ( size1 + size2 + size3 + size4 ).FormatBytesSize()
            : size1 == 0 && size2 == 0 && size3 == 0 && size4 == 0
              ? SysTranslations.DatabaseTableClosed.GetLang()
              : "-";
        }
        finally
        {
          LoadingForm.Instance.Hide();
        }
      return _DBMemorySize;
    }
  }
  static private string _DBMemorySize;
  static internal bool UpdateDBMemorySizeRequired { get; set; } = true;

  public string DBCommonFileSize
  {
    get
    {
      if ( UpdateDBCommonFileSizeRequired )
      {
        UpdateDBCommonFileSizeRequired = false;
        _DBCommonFileSize = SystemManager.GetFileSize(Globals.CommonDatabaseFilePath).FormatBytesSize();
      }
      return _DBCommonFileSize;
    }
  }
  static private string _DBCommonFileSize;
  static internal bool UpdateDBCommonFileSizeRequired { get; set; } = true;

  public string DBParashotMemorySize
  {
    get
    {
      if ( UpdateDBParashotMemorySizeRequired )
      {
        UpdateDBParashotMemorySizeRequired = false;
        long size = HebrewDatabase.Instance.Parashot?.SizeOf() ?? 0;
        _DBParashotMemorySize = size > 0
          ? size.FormatBytesSize()
          : size == 0
            ? SysTranslations.DatabaseTableClosed.GetLang()
            : "-";
      }
      return _DBParashotMemorySize;
    }
  }
  static private string _DBParashotMemorySize;
  static internal bool UpdateDBParashotMemorySizeRequired { get; set; } = true;

}
