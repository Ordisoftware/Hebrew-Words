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
/// <edited> 2021-02 </edited>
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
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Globals.SoftpediaURL = "https://www.softpedia.com/get/Others/Home-Education/Hebrew-Words.shtml";
      Globals.AlternativeToURL = "";
      if ( !SystemManager.CheckApplicationOnlyOneInstance(IPCRequest) ) return;
      Globals.SettingsUpgraded = Settings.UpgradeRequired;
      Settings.CheckUpgradeRequired(ref Globals.SettingsUpgraded);
      Settings.UpgradeRequired = Globals.SettingsUpgraded;
      CheckSettingsReset();
      Globals.Settings = Settings;
      Globals.MainForm = MainForm.Instance;
      DebugManager.Enabled = Settings.DebuggerEnabled;
      DebugManager.TraceEnabled = Settings.TraceEnabled;
      Language lang = Settings.LanguageSelected;
      SystemManager.CheckCommandLineArguments<ApplicationCommandLine>(args, ref lang);
      Settings.LanguageSelected = lang;
      UpdateLocalization();
      ProcessCommandLineOptions();
      Application.Run(MainForm.Instance);
    }

    /// <summary>
    /// Bring to front the app in case of duplicate process start.
    /// </summary>
    /// <param name="ar"></param>
    static void IPCRequest(IAsyncResult ar)
    {
      var server = ar.AsyncState as NamedPipeServerStream;
      server.EndWaitForConnection(ar);
      var command = new BinaryFormatter().Deserialize(server) as string;
      if ( command == "BringToFront" )
        if ( MainForm.Instance.Visible )
          MainForm.Instance.SyncUI(() =>
          {
            if ( MainForm.Instance.WindowState == FormWindowState.Minimized )
              MainForm.Instance.WindowState = Settings.MainFormState;
            var old = MainForm.Instance.TopMost;
            MainForm.Instance.TopMost = true;
            MainForm.Instance.BringToFront();
            MainForm.Instance.Show();
            MainForm.Instance.TopMost = old;
          });
        else
          MainForm.Instance.SyncUI(() => MainForm.Instance.Show());
      server.Close();
      SystemManager.CreateIPCServer(IPCRequest);
    }

    /// <summary>
    /// Check if settings must be reseted.
    /// </summary>
    private static void CheckSettingsReset(bool force = false)
    {
      if ( force )
      {
        if ( !force && !Settings.FirstLaunch )
          DisplayManager.ShowInformation(SysTranslations.UpgradeResetRequired.GetLang());
        Settings.Reset();
        Settings.LanguageSelected = Languages.Current;
      }
      if ( Settings.LanguageSelected == Language.None )
        Settings.LanguageSelected = Languages.Current;
      Settings.Save();
    }

    /// <summary>
    /// Process command line options.
    /// </summary>
    static private void ProcessCommandLineOptions()
    {
      if ( SystemManager.CommandLineOptions != null )
        if ( SystemManager.CommandLineOptions.ResetSettings )
        {
          SystemManager.CleanAllLocalAppSettingsFolders();
          CheckSettingsReset(true);
        }
        else
        if ( !Settings.FirstLaunch
          && SystemManager.CommandLineOptions != null
          && SystemManager.CommandLineOptions.HideGUI )
          Globals.ForceStartupHide = true;
    }

    /// <summary>
    /// Update localization strings to the whole application.
    /// </summary>
    static public void UpdateLocalization()
    {
      string lang = "en-US";
      if ( Settings.LanguageSelected == Language.FR ) lang = "fr-FR";
      var culture = new CultureInfo(lang);
      Thread.CurrentThread.CurrentCulture = culture;
      Thread.CurrentThread.CurrentUICulture = culture;
      AboutBox.Instance.Hide();
      Action<Form> update = form =>
      {
        new Infralution.Localization.CultureManager().ManagedControl = form;
        ComponentResourceManager resources = new ComponentResourceManager(form.GetType());
        resources.Apply(form.Controls);
      };
      foreach ( Form form in Application.OpenForms )
        if ( form != AboutBox.Instance && form != GrammarGuideForm )
          update(form);
      new Infralution.Localization.CultureManager().ManagedControl = AboutBox.Instance;
      new Infralution.Localization.CultureManager().ManagedControl = GrammarGuideForm;
      Infralution.Localization.CultureManager.ApplicationUICulture = culture;
      // Various updates
      AboutBox.Instance.AboutBox_Shown(null, null);
      GrammarGuideForm.HTMLBrowserForm_Shown(null, null);
      UndoRedoTextBox.Relocalize();
      MainForm.Instance.CreateSystemInformationMenu();
      if ( Globals.IsReady )
      {
        MainForm.Instance.RenderTranslation();
        MainForm.Instance.RenderRawText();
        MainForm.Instance.RenderELS50();
        MainForm.Instance.SetView(Settings.CurrentView, true);
      }
    }

  }

}

/*static public void UpdateLocalization()
    {
      string lang = "en-US";
      if ( Settings.Language == "fr" ) lang = "fr-FR";
      var culture = new CultureInfo(lang);
      Thread.CurrentThread.CurrentCulture = culture;
      Thread.CurrentThread.CurrentUICulture = culture;
      foreach ( Form form in Application.OpenForms )
        if ( form != AboutBox.Instance && form != GrammarGuideForm )
        {
          new Infralution.Localization.CultureManager().ManagedControl = form;
          ComponentResourceManager resources = new ComponentResourceManager(form.GetType());
          ApplyResources(resources, form.Controls);
        }
      new Infralution.Localization.CultureManager().ManagedControl = AboutBox.Instance;
      new Infralution.Localization.CultureManager().ManagedControl = GrammarGuideForm;
      Infralution.Localization.CultureManager.ApplicationUICulture = culture;
      AboutBox.Instance.AboutBox_Shown(null, null);
      GrammarGuideForm.HTMLBrowserForm_Shown(null, null);
      if ( MainForm.Instance.IsReady )
      {
        MainForm.Instance.RenderTranslation();
        MainForm.Instance.RenderRawText();
        MainForm.Instance.RenderELS50();
        MainForm.Instance.SetView(Settings.CurrentView, true);
      }
    }

  }*/