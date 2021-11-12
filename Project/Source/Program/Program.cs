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
/// <edited> 2021-04 </edited>
using System;
using System.ComponentModel;
using System.Globalization;
using System.IO.Pipes;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using Ordisoftware.Core;
using System.IO;
using System.Threading.Tasks;

namespace Ordisoftware.Hebrew.Words
{

  /// <summary>
  /// Provide Program class.
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
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
      Application.Run(MainForm.Instance);
    }

    /// <summary>
    /// Check if settings must be reseted.
    /// </summary>
    private static void CheckSettingsReset(bool force = false)
    {
      try
      {
        // Check reset
        if ( force
        /*|| Settings.UpgradeResetRequiredVx_y*/ )
        {
#pragma warning disable S2583 // Conditionally executed code should be reachable - irrelevant
          if ( !force && !Settings.FirstLaunch )
            DisplayManager.ShowInformation(SysTranslations.UpgradeResetRequired.GetLang());
#pragma warning restore S2583 // Conditionally executed code should be reachable - irrelevant
          Settings.Reset();
          Settings.LanguageSelected = Languages.Current;
          Settings.SetUpgradeFlagsOff();
        }
        if ( Settings.FirstLaunchV3_0 )
        {
          Settings.SetFirstAndUpgradeFlagsOff();
          Settings.FirstLaunch = true;
        }
        // Check language
        if ( Settings.LanguageSelected == Language.None )
          Settings.LanguageSelected = Languages.Current;
        // Check applications
        string pathLettersFolder = Path.Combine(Globals.CompanyProgramFilesFolderPath, "Hebrew Letters", "Bin");
        string pathLettersOld = Path.Combine(pathLettersFolder, "Ordisoftware.HebrewLetters.exe");
        string pathLettersDefault = (string)Settings.Properties["HebrewLettersExe"].DefaultValue;
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
        if ( command == nameof(ApplicationCommandLine.Instance.ShowMainForm) )
          MainForm.Instance.SyncUI(() => MainForm.Instance.Popup());
        if ( command == nameof(ApplicationCommandLine.Instance.ReferenceToGo) )
          MainForm.Instance.SyncUI(() => MainForm.Instance.GoTo(ApplicationCommandLine.Instance.ReferenceToGo));
        if ( command == nameof(ApplicationCommandLine.Instance.SearchWord) )
          MainForm.Instance.SyncUI(() => MainForm.Instance.SearchHebrewWord(ApplicationCommandLine.Instance.SearchWord));
        if ( command == nameof(ApplicationCommandLine.Instance.SearchWord) )
          MainForm.Instance.SyncUI(() => MainForm.Instance.SearchTranslatedWord(ApplicationCommandLine.Instance.SearchTranslated));
      }
      finally
      {
        server.Close();
        if ( Globals.IsReady )
          SystemManager.CreateIPCServer(IPCRequests);
      }
    }

    /// <summary>
    /// Send IPC commands.
    /// </summary>
    static private void IPCSendCommands()
    {
      if ( ApplicationCommandLine.Instance == null ) return;
      if ( ApplicationCommandLine.Instance.HideMainForm )
        SystemManager.IPCSend(nameof(ApplicationCommandLine.Instance.HideMainForm));
      if ( ApplicationCommandLine.Instance.ShowMainForm )
        SystemManager.IPCSend(nameof(ApplicationCommandLine.Instance.ShowMainForm));
      if ( !ApplicationCommandLine.Instance.ReferenceToGo.IsNullOrEmpty() )
        SystemManager.IPCSend(nameof(ApplicationCommandLine.Instance.ReferenceToGo));
      if ( !ApplicationCommandLine.Instance.SearchTranslated.IsNullOrEmpty() )
        SystemManager.IPCSend(nameof(ApplicationCommandLine.Instance.SearchTranslated));
    }

    /// <summary>
    /// Process command line options.
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
        if ( !Settings.FirstLaunch
          && SystemManager.CommandLineOptions != null
          && SystemManager.CommandLineOptions.HideMainForm )
          Globals.ForceStartupHide = true;
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
    }

    /// <summary>
    /// Update localization strings to the whole application.
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
        new Infralution.Localization.CultureManager().ManagedControl = AboutBox.Instance;
        new Infralution.Localization.CultureManager().ManagedControl = GrammarGuideForm;
        Infralution.Localization.CultureManager.ApplicationUICulture = culture;
        foreach ( Form form in Application.OpenForms )
        {
          if ( form != DebugManager.TraceForm
            && form != AboutBox.Instance
            && form != GrammarGuideForm )
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
          MainForm.Instance.RenderTranslation();
          MainForm.Instance.RenderRawText();
          MainForm.Instance.RenderELS50();
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

}
