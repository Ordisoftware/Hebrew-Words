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
/// <created> 2016-04 </created>
/// <edited> 2022-03 </edited>
namespace Ordisoftware.Hebrew.Words;

using System.IO.Pipes;
using System.Runtime.Serialization.Formatters.Binary;

/// <summary>
/// Provides Program class.
/// </summary>
static partial class Program
{

  /// <summary>
  /// Process startup method.
  /// </summary>
  [STAThread]
  static void Main(string[] args)
  {
    try
    {
      Globals.ChronoStartingApp.Start();
      Globals.SoftpediaURL = "https://www.softpedia.com/get/Others/Home-Education/Hebrew-Words.shtml";
      Globals.AlternativeToURL = "";
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      var lang = Settings.LanguageSelected;
      SystemManager.CheckCommandLineArguments<ApplicationCommandLine>(args, ref lang);
      SystemManager.IPCSendCommands = IPCSendCommands;
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
      Globals.MainForm = MainForm.Instance;
      DebugManager.TraceEnabled = Settings.TraceEnabled;
      DebugManager.Enabled = Settings.DebuggerEnabled;
      HebrewGlobals.GetHebrewCalendarExePath = () => string.Empty;
      HebrewGlobals.GetHebrewLettersExePath = () => Settings.HebrewLettersExe;
      HebrewGlobals.GetHebrewWordsExePath = () => Globals.ApplicationExeFullPath;
      HebrewGlobals.GetCustomWebSearchPattern = () => Settings.CustomWebSearch;
      Globals.ChronoStartingApp.Stop();
      ProcessCommandLineOptions();
      Globals.ChronoStartingApp.Start();
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
  }

  /// <summary>
  /// Checks if settings must be reseted.
  /// </summary>
  [SuppressMessage("Performance", "U2U1017:Initialized locals should be used", Justification = "N/A")]
  [SuppressMessage("Design", "GCop179:Do not hardcode numbers, strings or other values. Use constant fields, enums, config files or database as appropriate.", Justification = "<En attente>")]
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
        Settings.VerseCommentaryLinesCount = 5;
        Settings.VerseWordTranslationLinesCount = 2;
        Settings.WordControlWidth = 210;
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
      SystemManager.TryCatch(Settings.Save);
    }
    catch ( Exception ex )
    {
      ex.Manage();
    }
  }

  /// <summary>
  /// IPC requests.
  /// </summary>
  [SuppressMessage("CodeQuality", "IDE0079:Retirer la suppression inutile", Justification = "N/A")]
  [SuppressMessage("Vulnerability", "SEC0029:Insecure Deserialization", Justification = "N/A")]
  static void IPCRequests(IAsyncResult ar)
  {
    var server = ar.AsyncState as NamedPipeServerStream;
    try
    {
      server.EndWaitForConnection(ar);
      if ( new BinaryFormatter().Deserialize(server) is not string command ) return;
      if ( !Globals.IsReady ) return;
      var lang = Settings.LanguageSelected;
      SystemManager.CheckCommandLineArguments<ApplicationCommandLine>(command.SplitKeepEmptyLines(" "), ref lang);
      var form = MainForm.Instance;
      var cmd = ApplicationCommandLine.Instance;
      if ( cmd is null ) return;
      Action action = null;
      if ( cmd.ShowMainForm ) action = () => form.Popup();
      if ( !cmd.ReferenceToGo.IsNullOrEmpty() ) action = () => form.GoToReference(cmd.ReferenceToGo, false, true);
      if ( !cmd.SearchWord.IsNullOrEmpty() ) action = () => form.SearchHebrewWord(cmd.SearchWord);
      if ( !cmd.SearchTranslated.IsNullOrEmpty() ) action = () => form.SearchTranslatedWord(cmd.SearchTranslated);
      if ( action is not null )
        SystemManager.TryCatch(() =>
        {
          form.ToolStrip.SyncUI(() => MainForm.Instance.Popup());
          form.ToolStrip.SyncUI(action);
        });
    }
    finally
    {
      server.Close();
      SystemManager.CreateIPCServer(IPCRequests);
    }
  }

  /// <summary>
  /// Sends IPC commands.
  /// </summary>
  static private void IPCSendCommands()
  {
    var cmd = ApplicationCommandLine.Instance;
    if ( cmd is null ) return;
    if ( cmd.HideMainForm ) SystemManager.IPCSend(nameof(cmd.HideMainForm));
    if ( cmd.ShowMainForm ) SystemManager.IPCSend(nameof(cmd.ShowMainForm));
    if ( !cmd.ReferenceToGo.IsNullOrEmpty() ) SystemManager.IPCSend($"--verse {cmd.ReferenceToGo}");
    if ( !cmd.SearchWord.IsNullOrEmpty() ) SystemManager.IPCSend($"--word {cmd.SearchWord}");
    if ( !cmd.SearchTranslated.IsNullOrEmpty() ) SystemManager.IPCSend($"--translated {cmd.SearchTranslated}");
  }

  /// <summary>
  /// Processes command line options.
  /// </summary>
  static private void ProcessCommandLineOptions()
  {
    try
    {
      if ( SystemManager.CommandLineOptions is null ) return;
      if ( SystemManager.CommandLineOptions.ResetSettings )
      {
        SystemManager.CleanAllLocalAppSettingsFolders();
        CheckSettingsReset(true);
      }
      else
      if ( !Settings.FirstLaunch && SystemManager.CommandLineOptions?.HideMainForm == true )
        Globals.ForceStartupHide = true;
    }
    catch ( Exception ex )
    {
      ex.Manage();
    }
  }

  /// <summary>
  /// Updates localization strings to the whole application.
  /// </summary>
  [SuppressMessage("IDisposableAnalyzers.Correctness", "IDISP004:Don't ignore created IDisposable", Justification = "<En attente>")]
  static public void UpdateLocalization()
  {
    Globals.ChronoTranslate.Restart();
    Task task = null;
    try
    {
      static void update(Form form)
      {
        new Infralution.Localization.CultureManager().ManagedControl = form;
        var resources = new ComponentResourceManager(form.GetType());
        resources.ApplyResources(form.Controls);
      }
      string lang = "en-US";
      if ( Settings.LanguageSelected == Language.FR ) lang = "fr-FR";
      var culture = new CultureInfo(lang);
      Thread.CurrentThread.CurrentCulture = culture;
      Thread.CurrentThread.CurrentUICulture = culture;
      task = new Task(HebrewGlobals.LoadProviders);
      task.Start();
      if ( Globals.IsReady )
      {
        MessageBoxEx.CloseAll();
        AboutBox.Instance.Hide();
        //StatisticsForm.Instance.Hide();
      }
      else
        update(MainForm.Instance);
      new Infralution.Localization.CultureManager().ManagedControl = StatisticsForm.Instance;
      new Infralution.Localization.CultureManager().ManagedControl = AboutBox.Instance;
      new Infralution.Localization.CultureManager().ManagedControl = GrammarGuideForm;
      new Infralution.Localization.CultureManager().ManagedControl = BibleStatisticsForm.Instance;
      Infralution.Localization.CultureManager.ApplicationUICulture = culture;
      var formsToSkip = new Form[] { DebugManager.TraceForm, AboutBox.Instance, GrammarGuideForm };
      foreach ( Form form in Application.OpenForms.GetAll().Except(formsToSkip) )
      {
        update(form);
        if ( form is ShowTextForm formShowText )
          formShowText.Relocalize();
      }
      // Various updates
      if ( Globals.IsReady )
      {
        LoadingForm.Instance.Relocalize();
        TextBoxEx.Relocalize();
        AboutBox.Instance.AboutBox_Shown(null, null);
        GrammarGuideForm.HTMLBrowserForm_Shown(null, null);
        MainForm.Instance.RenderChapterTranslation();
        MainForm.Instance.RenderChapterOriginal();
        MainForm.Instance.RenderChapterELS50();
        MainForm.Instance.SetView(Settings.CurrentView, true);
      }
      task?.Wait();
      MainForm.Instance.CreateSystemInformationMenu();
    }
    catch ( Exception ex )
    {
      ex.Manage();
    }
    finally
    {
      Globals.ChronoTranslate.Stop();
      Settings.BenchmarkTranslate = Globals.ChronoTranslate.ElapsedMilliseconds;
    }
  }

}
