/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2025 Olivier Rogier.
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
/// <edited> 2023-01 </edited>
namespace Ordisoftware.Hebrew.Words;

/// <summary>
/// Provides Program class.
/// </summary>
static partial class Program
{

  // TODO calc nb occurrence each letter

  /// <summary>
  /// Process startup method.
  /// </summary>
  [STAThread]
  static void Main(string[] args)
  {
    try
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      //
      Globals.ChronoStartingApp.Start();
      Globals.SoftpediaURL = "https://www.softpedia.com/get/Others/Home-Education/Hebrew-Words.shtml";
      Globals.AlternativeToURL = string.Empty;
      CommonMenusControl.PreviewFunctions = AppTranslations.PreviewFunctions;
      //
      var lang = Settings.LanguageSelected;
      SystemManager.CheckCommandLineArguments<ApplicationCommandLine>(args, ref lang);
      if ( !SystemManager.CheckApplicationOnlyOneInstance(IPCRequests) ) return;
      bool upgrade = Settings.UpgradeRequired;
      Globals.IsSettingsUpgraded = upgrade;
      Settings.CheckUpgradeRequired(ref upgrade);
      Settings.UpgradeRequired = upgrade;
      Globals.IsSettingsUpgraded = Globals.IsSettingsUpgraded && !Settings.FirstLaunch;
      CheckSettingsReset();
      if ( lang != Language.None ) Settings.LanguageSelected = lang;
      SystemManager.TryCatch(Settings.Save);
      Globals.Settings = Settings;
      //
      //Globals.SpellCheckEnabled = Settings.SpellCheckEnabled;
      //TextBoxEx.InstanceCreated += TextBox_UpdateSpellChecker;
      //TextBoxEx.UpdateSpellChecker += TextBox_UpdateSpellChecker;
      //TextBoxEx.Relocalized += TextBox_Relocalized;
      //TextBox_Relocalized();
      Globals.MainForm = MainForm.Instance;
      DebugManager.TraceEnabled = Settings.TraceEnabled;
      DebugManager.Enabled = Settings.DebuggerEnabled;
      //
      HebrewGlobals.GetHebrewCalendarExecutablePath = () => string.Empty;
      HebrewGlobals.GetHebrewLettersExecutablePath = () => Settings.HebrewLettersExe;
      HebrewGlobals.GetHebrewWordsExecutablePath = () => Globals.ApplicationExecutableFullPath;
      HebrewGlobals.GetCustomWebSearchPattern = () => Settings.CustomWebSearch;
      //
      Globals.ChronoStartingApp.Stop();
      ProcessCommandLineOptions();
      Globals.ChronoStartingApp.Start();
      //
      LoadingForm.Instance.Hidden = Settings.LoadingFormHidden;
      AboutBox.LicenseAsRTF = Properties.Resources.MPL_2_0;
      AboutBox.DescriptionText = AppTranslations.ApplicationDescription;
      AboutBox.Instance.ActionViewStats.Enabled = Settings.UsageStatisticsEnabled;
    }
    catch ( Exception ex )
    {
      ex.Manage();
    }
    Application.Run(MainForm.Instance);
    SystemManager.Exit();
  }

  /// <summary>
  /// Checks if settings must be reseted.
  /// </summary>
  [SuppressMessage("Performance", "U2U1017:Initialized locals should be used", Justification = "N/A")]
  private static void CheckSettingsReset(bool force = false)
  {
    var resetForceVersions = Array.Empty<bool>();
    try
    {
      // Check reset
      if ( force || resetForceVersions.Contains(true) )
      {
        if ( !force && !Settings.FirstLaunch )
          DisplayManager.ShowInformation(SysTranslations.UpgradeResetRequired.GetLang());
        Settings.Reset();
        Settings.LanguageSelected = Languages.Current;
        Settings.SetUpgradeFlagsOff();
      }
      if ( Settings.FirstLaunchV3_0 )
      {
        Settings.SetFirstAndUpgradeFlagsOff();
        Settings.VacuumAtStartup = true;
        Settings.CurrentView = ViewMode.ChapterVerses;
        Settings.VerseCommentaryLinesCount = Convert.ToInt32(Settings.Properties["VerseCommentaryLinesCount"].DefaultValue);
        Settings.VerseWordTranslationLinesCount = Convert.ToInt32(Settings.Properties["VerseWordTranslationLinesCount"].DefaultValue);
        Settings.WordControlWidth = Convert.ToInt32(Settings.Properties["WordControlWidth"].DefaultValue);
        if ( Settings.SearchOnlineURL == "https://www.google.com/search?q=strong+hebrew+" )
          Settings.SearchOnlineURL = "https://www.pealim.com/search/?q=%WORD%";
      }
      // Check language
      if ( Settings.LanguageSelected == Language.None )
        Settings.LanguageSelected = Languages.Current;
      // Check applications
      string pathLettersFolder = Path.Combine(Globals.CompanyProgramFilesFolderPath, "Hebrew Letters", "Bin");
      string pathLettersOld = Path.Combine(pathLettersFolder, "Ordisoftware.HebrewLetters.exe");
      string pathLettersDefault = (string)Settings.Properties["HebrewLettersExe"].DefaultValue;
      // Check applications : Letters
      if ( !File.Exists(Settings.HebrewLettersExe) )
        if ( File.Exists(pathLettersOld) )
          Settings.HebrewLettersExe = pathLettersOld;
        else
        if ( File.Exists(pathLettersDefault) )
          Settings.HebrewLettersExe = pathLettersDefault;
      // Save settings
      bool previewModeNotified = Settings.PreviewModeNotified;
      SystemCommandLine.CheckPreviewNotice(ref previewModeNotified);
      Settings.PreviewModeNotified = previewModeNotified;
      SystemManager.TryCatch(Settings.Save);
    }
    catch ( Exception ex )
    {
      ex.Manage();
    }
  }

}
