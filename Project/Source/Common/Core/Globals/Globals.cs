﻿/// <license>
/// This file is part of Ordisoftware Core Library.
/// Copyright 2004-2025 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at
/// https://mozilla.org/MPL/2.0/.
/// If it is not possible or desirable to put the notice in a particular file,
/// then You may include the notice in a location(such as a LICENSE file in a
/// relevant directory) where a recipient would be likely to look for such a notice.
/// You may add additional accurate notices of copyright ownership.
/// </license>
/// <created> 2016-04 </created>
/// <edited> 2025-02 </edited>
namespace Ordisoftware.Core;

/// <summary>
/// Provides global variables.
/// </summary>
static public partial class Globals
{

  /// <summary>
  /// Indicates new line.
  /// </summary>
  static public readonly string NL = Environment.NewLine;
  static public readonly string NL2 = NL + NL;
  static public readonly string NL3 = NL2 + NL;
  static public readonly string NL4 = NL3 + NL;
  static public readonly string NL5 = NL4 + NL;

#pragma warning disable VSSpell001 // Spell Check
  public const int WS_EX_COMPOSITED = 0x02000000;
  public const int WS_CLIPCHILDREN = ~0x02000000;
#pragma warning restore VSSpell001 // Spell Check

  public const int MaxErrorsAllowed = 20;
  public const int MaxFilesAllowed = 20;

  public const int ToolTipDelay = 3000;
  public const int TrayIconTextLimit = 63;
  public const int WindowDetectionMargin = 80;

  public const int MilliSecondsInOneMinute = 60000;
  public const int MilliSecondsInOneSecond = 1000;
  public const int SecondsInOneMinute = 60;
  public const int HoursInOneDay = 24;

  static public readonly int DaysOfWeekCount = Enums.GetValues<DayOfWeek>().Count;

  static public readonly Size IconSize16 = new(16, 16);

  /// <summary>
  /// Indicates bullet.
  /// </summary>
  static public string Bullet { get; set; } = "•";

  /// <summary>
  /// Indicates list separator.
  /// </summary>
  static public string ListSeparator { get; set; } = "-";

  /// <summary>
  /// Indicates CSV separator.
  /// </summary>
  static public char CSVSeparator { get; set; } = ';';

  /// <summary>
  /// Indicates CSV separator.
  /// </summary>
  static public string KeyValuePairSeparator { get; set; } = "=>";

  /// <summary>
  /// Indicates if SSL certificate is preloaded.
  /// </summary>
  static public bool PreLoadSSLCertificate { get; set; } = true;

  /// <summary>
  /// Indicates if the application must go to tray icon at startup.
  /// </summary>
  static public bool ForceStartupHide { get; set; }

  /// <summary>
  /// Indicates StopWatches.
  /// </summary>
  static public readonly AdvStopwatch ChronoStartingApp = new();
  static public readonly AdvStopwatch ChronoTranslate = new();
  static public readonly AdvStopwatch ChronoLoadData = new();
  static public readonly AdvStopwatch ChronoCreateData = new();
  static public readonly AdvStopwatch ChronoShowData = new();
  static public readonly AdvStopwatch ChronoRendering = new();
  static public readonly AdvStopwatch ChronoBatch = new();
  static public readonly AdvStopwatch ChronoSubBatch = new();

  /// <summary>
  /// Indicates keyboard shortcuts notice form.
  /// </summary>
  static public ShowTextForm KeyboardShortcutsNotice { get; internal set; }

  /// <summary>
  /// Indicates IDE name.
  /// </summary>
  static public readonly string IDEName = "Visual Studio";

  /// <summary>
  /// Indicates IDE version.
  /// </summary>
  static public readonly string IDEVersion = "2022";

  /// <summary>
  /// Indicates programming language name.
  /// </summary>
  static public readonly string DevLanguageName = "C#";

  /// <summary>
  /// Indicates programming language version.
  /// </summary>
  static public readonly string DevLanguageVersion = "11.0";

  /// <summary>
  /// Indicates IDE name and version.
  /// </summary>
  static public string IDENameAndVersion => $"{IDEName} {IDEVersion}";

  /// <summary>
  /// Indicates programming language name and version.
  /// </summary>
  static public string DevLanguageNameAndVersion => $"{DevLanguageName} {DevLanguageVersion}";

  /// <summary>
  /// Indicates the application code (title without space).
  /// </summary>
  static public string ApplicationCode
    => AssemblyTitle.Replace(" ", string.Empty);

  /// <summary>
  /// Indicates the application GitHub code (title with '-' instead of space.
  /// </summary>
  static public string ApplicationGitHubCode
    => AssemblyTitle.Replace(' ', '-');

  /// <summary>
  /// Indicates the main form.
  /// </summary>
  static public Form MainForm
  {
    get => _MainForm ?? ( Application.OpenForms.Count > 0 ? Application.OpenForms[0] : Form.ActiveForm );
    set => _MainForm = value;
  }
  static private Form _MainForm;

  /// <summary>
  /// Indicates brint to front application system hot key.
  /// </summary>
  static public readonly SystemHotKey BringToFrontApplicationHotKey = new();

  /// <summary>
  /// Indicates if spell check is enabled.
  /// </summary>
  static public bool SpellCheckEnabled { get; set; }

#if DEBUG
  /// <summary>
  /// Static constructor.
  /// </summary>
  static Globals()
  {
    if ( !IsVisualStudioDesigner )
    {
      bool conditional = IsExiting;
      StackMethods.PurgeResourceImages(AssemblyTitle, ProjectFolderPath, ref conditional);
      IsExiting = conditional;
    }
  }
#endif

}
