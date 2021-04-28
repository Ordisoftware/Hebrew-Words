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
        Settings.Save();
        Globals.Settings = Settings;
        Globals.MainForm = MainForm.Instance;
        DebugManager.Enabled = Settings.DebuggerEnabled;
        DebugManager.TraceEnabled = Settings.TraceEnabled;
        UpdateLocalization();
        Globals.ChronoStartingApp.Stop();
        ProcessCommandLineOptions();
        Globals.ChronoStartingApp.Start();
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
      Application.Run(MainForm.Instance);
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
#pragma warning disable S5773 // Types allowed to be deserialized should be restricted
        var command = new BinaryFormatter().Deserialize(server) as string;
#pragma warning restore S5773 // Types allowed to be deserialized should be restricted
        if ( !Globals.IsReady ) return;
        if ( command == nameof(ApplicationCommandLine.Instance.ShowMainForm) )
          MainForm.Instance.SyncUI(() => MainForm.Instance.Popup());
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
      if ( ApplicationCommandLine.Instance.HideMainForm )
        SystemManager.IPCSend(nameof(ApplicationCommandLine.Instance.HideMainForm));
      if ( ApplicationCommandLine.Instance.ShowMainForm )
        SystemManager.IPCSend(nameof(ApplicationCommandLine.Instance.ShowMainForm));
    }

    /// <summary>
    /// Check if settings must be reseted.
    /// </summary>
    private static void CheckSettingsReset(bool force = false)
    {
      try
      {
        if ( force /*|| Settings.UpgradeResetRequiredVx_y*/ )
        {
#pragma warning disable S2583 // Conditionally executed code should be reachable
          if ( !force && !Settings.FirstLaunch )
#pragma warning restore S2583 // Conditionally executed code should be reachable
            DisplayManager.ShowInformation(SysTranslations.UpgradeResetRequired.GetLang());
          Settings.Reset();
          Settings.LanguageSelected = Languages.Current;
          Settings.SetUpgradeFlagsOff();
        }
        if ( Settings.FirstLaunchV3_0 )
        {
          Settings.SetFirstAndUpgradeFlagsOff();
          Settings.FirstLaunch = true;
        }
        if ( Settings.LanguageSelected == Language.None )
          Settings.LanguageSelected = Languages.Current;
        Settings.Save();
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
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
      try
      {
        void update(Form form)
        {
          new Infralution.Localization.CultureManager().ManagedControl = form;
          ComponentResourceManager resources = new ComponentResourceManager(form.GetType());
          resources.Apply(form.Controls);
        }
        string lang = "en-US";
        if ( Settings.LanguageSelected == Language.FR ) lang = "fr-FR";
        var culture = new CultureInfo(lang);
        Thread.CurrentThread.CurrentCulture = culture;
        Thread.CurrentThread.CurrentUICulture = culture;
        MessageBoxEx.CloseAll();
        AboutBox.Instance.Hide();
        foreach ( Form form in Application.OpenForms )
        {
          if ( form != AboutBox.Instance && form != GrammarGuideForm )
            update(form);
          if ( form is ShowTextForm formShowText )
            formShowText.Relocalize();
        }
        string tempLogTitle = DebugManager.TraceForm.Text;
        string tempLogContent = DebugManager.TraceForm.TextBox.Text;
        new Infralution.Localization.CultureManager().ManagedControl = AboutBox.Instance;
        //new Infralution.Localization.CultureManager().ManagedControl = StatisticsForm.Instance;
        new Infralution.Localization.CultureManager().ManagedControl = DebugManager.TraceForm;
        new Infralution.Localization.CultureManager().ManagedControl = GrammarGuideForm;
        Infralution.Localization.CultureManager.ApplicationUICulture = culture;
        // Various updates
        DebugManager.TraceForm.Text = tempLogTitle;
        DebugManager.TraceForm.AppendText(tempLogContent);
        AboutBox.Instance.AboutBox_Shown(null, null);
        GrammarGuideForm.HTMLBrowserForm_Shown(null, null);
        LoadingForm.Instance.Relocalize();
        TextBoxEx.Relocalize();
        MainForm.Instance.CreateSystemInformationMenu();
        if ( Globals.IsReady )
        {
          MainForm.Instance.RenderTranslation();
          MainForm.Instance.RenderRawText();
          MainForm.Instance.RenderELS50();
          MainForm.Instance.SetView(Settings.CurrentView, true);
        }
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
