/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2020 Olivier Rogier.
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
/// <edited> 2020-04 </edited>
using System;
using System.Linq;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO.Pipes;
using System.Windows.Forms;
using Ordisoftware.HebrewCommon;

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// Provide Program class.
  /// </summary>
  static partial class Program
  {

    /// <summary>
    /// Indicate the default Settings instance.
    /// </summary>
    static public readonly Properties.Settings Settings
      = Properties.Settings.Default;

    /// <summary>
    /// Process startup method.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
      if ( !SystemManager.CheckApplicationOnlyOneInstance(IPCRequest) ) return;
      bool upgrade = Settings.UpgradeRequired;
      Settings.CheckUpgradeRequired(ref upgrade);
      Settings.UpgradeRequired = upgrade;
      CheckSettingsReset();
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Globals.Settings = Settings;
      Globals.MainForm = MainForm.Instance;
      DebugManager.Enabled = Settings.DebuggerEnabled;
      Language lang = Settings.LanguageSelected;
      SystemManager.CheckCommandLineArguments(args, ref lang);
      Settings.LanguageSelected = lang;
      UpdateLocalization();
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
    private static void CheckSettingsReset()
    {
      if ( !Languages.Managed.Contains(Settings.LanguageSelected) )
      {
        string langCode = Settings.Language;
        var langValue = Languages.Values[langCode];
        if ( langValue != Language.None )
          Settings.LanguageSelected = langValue;
        else
          Settings.LanguageSelected = Languages.Current;
      }
      else
        Settings.LanguageSelected = Languages.Current;
    }

    /// <summary>
    /// Update localization strings to the whole application.
    /// </summary>
    static internal void UpdateLocalization()
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
      MainForm.Instance.InitializeSpecialMenus();
      AboutBox.Instance.AboutBox_Shown(null, null);
      GrammarGuideForm.HTMLBrowserForm_Shown(null, null);
      UndoRedoTextBox.Relocalize();
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
