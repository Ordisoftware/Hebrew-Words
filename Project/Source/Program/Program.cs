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
/// <created> 2016-04 </created>
/// <edited> 2021-12 </edited>
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
      Language lang = Settings.LanguageSelected;
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
  private static void CheckSettingsReset(bool force = false)
  {
    var resetForceVersions = new bool[]
    {
    };
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
        Settings.FirstLaunch = true;
        Settings.VacuumAtStartup = true;
        Settings.CurrentView = ViewMode.ChapterVerses;
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
  static void IPCRequests(IAsyncResult ar)
  {
    var server = ar.AsyncState as NamedPipeServerStream;
    try
    {
      server.EndWaitForConnection(ar);
      if ( new BinaryFormatter().Deserialize(server) is not string command ) return;
      if ( !Globals.IsReady ) return;
      var form = MainForm.Instance;
      var cmd = ApplicationCommandLine.Instance;
      Action action = command switch
      {
        nameof(cmd.ShowMainForm) => () => form.Popup(),
        nameof(cmd.ReferenceToGo) => () => form.GoTo(cmd.ReferenceToGo),
        nameof(cmd.SearchWord) => () => form.SearchHebrewWord(cmd.SearchWord),
        nameof(cmd.SearchTranslated) => () => form.SearchTranslatedWord(cmd.SearchTranslated),
        _ => null
      };
      if ( action != null ) SystemManager.TryCatch(() => form.ToolStrip.SyncUI(action));
    }
    finally
    {
      server.Close();
      if ( Globals.IsReady )
        SystemManager.CreateIPCServer(IPCRequests);
    }
  }

  /// <summary>
  /// Sends IPC commands.
  /// </summary>
  static private void IPCSendCommands()
  {
    var cmd = ApplicationCommandLine.Instance;
    if ( cmd == null ) return;
    if ( cmd.HideMainForm ) SystemManager.IPCSend(nameof(cmd.HideMainForm));
    if ( cmd.ShowMainForm ) SystemManager.IPCSend(nameof(cmd.ShowMainForm));
    if ( !cmd.ReferenceToGo.IsNullOrEmpty() ) SystemManager.IPCSend(nameof(cmd.ReferenceToGo));
    if ( !cmd.SearchTranslated.IsNullOrEmpty() ) SystemManager.IPCSend(nameof(cmd.SearchTranslated));
  }

  /// <summary>
  /// Processes command line options.
  /// </summary>
  static private void ProcessCommandLineOptions()
  {
    try
    {
      if ( SystemManager.CommandLineOptions == null ) return;
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
  static public void UpdateLocalization()
  {
    Globals.ChronoTranslate.Restart();
    Task task = null;
    try
    {
      static void update(Form form)
      {
        new Infralution.Localization.CultureManager().ManagedControl = form;
        ComponentResourceManager resources = new(form.GetType());
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
      }
      else
        update(MainForm.Instance);
      new Infralution.Localization.CultureManager().ManagedControl = StatisticsForm.Instance;
      new Infralution.Localization.CultureManager().ManagedControl = AboutBox.Instance;
      new Infralution.Localization.CultureManager().ManagedControl = GrammarGuideForm;
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
