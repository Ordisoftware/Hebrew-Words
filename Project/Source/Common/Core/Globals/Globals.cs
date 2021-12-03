﻿/// <license>
/// This file is part of Ordisoftware Core Library.
/// Copyright 2004-2021 Olivier Rogier.
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
/// <edited> 2021-11 </edited>
namespace Ordisoftware.Core;

/// <summary>
/// Provides global variables.
/// </summary>
static partial class Globals
{

  /// <summary>
  /// Indicates new line.
  /// </summary>
  static public readonly string NL = Environment.NewLine;
  static public readonly string NL2 = NL + NL;
  static public readonly string NL3 = NL2 + NL;
  static public readonly string NL4 = NL3 + NL;
  static public readonly string NL5 = NL4 + NL;

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
  static public readonly Stopwatch ChronoStartingApp = new();
  static public readonly Stopwatch ChronoTranslate = new();
  static public readonly Stopwatch ChronoLoadData = new();
  static public readonly Stopwatch ChronoCreateData = new();
  static public readonly Stopwatch ChronoShowData = new();
  static public readonly Stopwatch ChronoRendering = new();

  /// <summary>
  /// Indicates keyboard shortcuts notice form.
  /// </summary>
  static public ShowTextForm NoticeKeyboardShortcutsForm { get; internal set; }

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
  static public readonly string DevLanguageVersion = "10.0";

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
    => AssemblyTitle.Replace(" ", "-");

  /// <summary>
  /// Indicates the application process name.
  /// </summary>
  static public string ProcessName
    => Path.GetFileNameWithoutExtension(Application.ExecutablePath);

  /// <summary>
  /// Indicates the application process ID.
  /// </summary>
  static public int ProcessId
    => Process.GetCurrentProcess().Id;

  /// <summary>
  /// Indicates the number of application running processes count.
  /// </summary>
  static public int ApplicationInstancesCount
    => Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length;

  /// <summary>
  /// Indicates running processes whose names starts with "AssemblyCompany.".
  /// </summary>
  static public IEnumerable<Process> SameCompanyRunningProcesses
    => Process.GetProcesses().Where(p => p.ProcessName.StartsWith(AssemblyCompany + "."));

  /// <summary>
  /// Indicates running processes whose names starts with "[AssemblyCompany]." not being this one.
  /// </summary>
  static public IEnumerable<Process> ConcurrentRunningProcesses
    => SameCompanyRunningProcesses.Where(p => p.Id != ProcessId);

  /// <summary>
  /// Indicates running processes being the same as this application not being this one.
  /// </summary>
  static public IEnumerable<Process> SameRunningProcessesNotThisOne
    => ConcurrentRunningProcesses.Where(p => p.ProcessName == ProcessName);

  /// <summary>
  /// Indicates if the executable has been generated in debug mode.
  /// </summary>
  static public bool IsDebugExecutable
  {
    get
    {
      bool isDebug = false;
      CheckDebugExecutable(ref isDebug);
      return isDebug;
    }
  }

  [Conditional("DEBUG")]
  static private void CheckDebugExecutable(ref bool isDebug)
    => isDebug = true;

  /// <summary>
  /// Indicates if the running app is from dev folder else user installed.
  /// </summary>
  static public bool IsDevExecutable
    => Application.ExecutablePath.Contains(DebugDirectoryCombination)
       || Application.ExecutablePath.Contains(ReleaseDirectoryCombination);

  /// <summary>
  /// Indicates if the code is in design time
  /// </summary>
  public static bool IsDesignTime
    => System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime;

  /// <summary>
  /// Indicates if the code is executed from the IDE else from a running app.
  /// </summary>
  public static bool IsVisualStudioDesigner
    => ProcessName == "devenv";

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
  /// Static constructor.
  /// </summary>
  static Globals()
  {
#if DEBUG
    if ( !IsVisualStudioDesigner )
    {
      bool conditional = IsExiting;
      StackMethods.PurgeResourceImages(AssemblyTitle, ProjectFolderPath, ref conditional);
      IsExiting = conditional;
    }
#endif
  }

}
