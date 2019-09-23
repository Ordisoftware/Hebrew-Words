/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2019 Olivier Rogier.
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
/// <edited> 2019-09 </edited>
using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Ordisoftware.Core;

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// Provide the main program.
  /// </summary>
  static class Program
  {

    /// <summary>
    /// Indicate root folder path of the application.
    /// </summary>
    static public readonly string RootFolderPath
      = Directory.GetParent
        (
          Path.GetDirectoryName(Application.ExecutablePath
                                .Replace("\\Bin\\Debug\\", "\\Bin\\")
                                .Replace("\\Bin\\Release\\", "\\Bin\\"))
        ).FullName
      + Path.DirectorySeparatorChar;

    /// <summary>
    /// Indicate filename of the application's icon.
    /// </summary>
    static public readonly string IconFilename
      = RootFolderPath + "Application.ico";

    /// <summary>
    /// Indicate name of the help file.
    /// </summary>
    static public readonly string HelpFilename
      = RootFolderPath + "Help" + Path.DirectorySeparatorChar + "index-" + Localizer.Language + ".htm";

    /// <summary>
    /// Indicate the extension of database file.
    /// </summary>
    static public readonly string DBFileExtension
      = ".sqlite";

    /// <summary>
    /// Indicate name of the help file.
    /// </summary>
    static public readonly string GrammarGuideFilename
      = RootFolderPath + "Help" + Path.DirectorySeparatorChar + "grammar-%lang%.htm";

    /// <summary>
    /// Indicate application documents folder.
    /// </summary>
    static public readonly string DocumentsFolderPath
      = RootFolderPath + "Documents" + Path.DirectorySeparatorChar;

    /// <summary>
    /// Indicate user data folder in roaming.
    /// </summary>
    static public string UserDataFolderPath { get; private set; }

    /// <summary>
    /// Indicate user documents folder path.
    /// </summary>
    static public string UserDocumentsFolderPath { get; private set; }

    /// <summary>
    /// Indicate the default Settings instance.
    /// </summary>
    static public readonly Properties.Settings Settings = Properties.Settings.Default;

    /// <summary>
    /// Main entry-point for this application.
    /// </summary>
    /// <param name="args">Array of command-line argument strings.</param>
    [STAThread]
    static void Main(string[] args)
    {
      var assembly = typeof(Program).Assembly;
      var attribute = (GuidAttribute)assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0];
      string id = assembly.FullName + attribute.Value;
      bool created;
      var mutex = new Mutex(true, id, out created);
      if ( !created ) return;
      if ( Settings.UpgradeRequired )
      {
        Settings.Upgrade();
        Settings.UpgradeRequired = false;
        Settings.Save();
      }
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      try
      {
        if ( args.Length == 2 && args[0] == "/lang" )
          if ( args[1] == "en" || args[1] == "fr" )
            Settings.Language = args[1];
        if ( Settings.Language == "" )
          Settings.Language = Localizer.Language;
        Settings.Save();
        ApplyCurrentLanguage();
      }
      catch
      {
      }
      MainForm.Instance.Icon = Icon.ExtractAssociatedIcon(IconFilename);
      AboutBox.Instance.Icon = MainForm.Instance.Icon;
      GrammarGuideForm.Instance.Icon = MainForm.Instance.Icon;
      UserDataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                         + Path.DirectorySeparatorChar
                         + AboutBox.Instance.AssemblyCompany
                         + Path.DirectorySeparatorChar
                         + AboutBox.Instance.AssemblyTitle
                         + Path.DirectorySeparatorChar;
      UserDocumentsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                              + Path.DirectorySeparatorChar
                              + AboutBox.Instance.AssemblyCompany
                              + Path.DirectorySeparatorChar
                              + AboutBox.Instance.AssemblyTitle
                              + Path.DirectorySeparatorChar;
      Directory.CreateDirectory(UserDataFolderPath);
      Application.Run(MainForm.Instance);
    }

    static public void ApplyCurrentLanguage()
    {
      string lang = "en-US";
      if ( Settings.Language == "fr" )
        lang = "fr-FR";
      var culture = new CultureInfo(lang);
      foreach ( Form form in Application.OpenForms )
        if ( form != AboutBox.Instance && form != GrammarGuideForm.Instance )
          new Infralution.Localization.CultureManager().ManagedControl = form;
      new Infralution.Localization.CultureManager().ManagedControl = AboutBox.Instance;
      new Infralution.Localization.CultureManager().ManagedControl = GrammarGuideForm.Instance;
      Infralution.Localization.CultureManager.ApplicationUICulture = culture;
      AboutBox.Instance.AboutBox_Shown(null, null);
      GrammarGuideForm.Instance.GrammarGuideForm_Shown(null, null);
      if ( MainForm.Instance.IsReady )
      {
        MainForm.Instance.RenderTranslation();
        MainForm.Instance.RenderRawText();
        MainForm.Instance.RenderELS50();
        MainForm.Instance.SetView(Settings.CurrentView, true);
      }
    }

    static public void CheckUpdate(bool auto)
    {
      if ( auto && !Settings.CheckUpdateAtStartup ) return;
      try
      {
        string title = AboutBox.Instance.AssemblyTitle;
        string url = "http://www.ordisoftware.com/files/" + title.Replace(" ", "") + ".update";
        using ( WebClient client = new WebClient() )
        {
          string[] partsVersion = client.DownloadString(url).Split('.');
          var version = new Version(Convert.ToInt32(partsVersion[0]), Convert.ToInt32(partsVersion[1]));
          if ( version.CompareTo(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version) <= 0 )
          {
            if ( !auto )
              DisplayManager.Show(Translations.NoNewVersionAvailable.GetLang());
          }
          else
          if ( DisplayManager.QueryYesNo(Translations.NewVersionAvailable.GetLang(version) + Environment.NewLine +
                                         Environment.NewLine +
                                         Translations.AskDownloadNewVersion.GetLang()) )
            AboutBox.Instance.OpenApplicationHome();
        }
      }
      catch
      {
      }
    }

    static public void CenterToMainForm(this Form form)
    {
      form.Location = new Point(MainForm.Instance.Left + MainForm.Instance.Width / 2 - form.Width / 2,
                                MainForm.Instance.Top + MainForm.Instance.Height / 2 - form.Height / 2);
    }

    static public void RunShell(string filename, string arguments = "")
    {
      using ( var process = new Process() )
        try
        {
          process.StartInfo.FileName = filename;
          process.StartInfo.Arguments = arguments;
          process.Start();
        }
        catch ( Exception ex )
        {
          ex.Manage(new Exception(ex.Message + Environment.NewLine + process.StartInfo.FileName));
        }
    }

    static public void OpenHebrewLetters(string hebrew)
    {
      hebrew = HebrewLetters.SetFinale(hebrew, false);
      RunShell(Settings.HebrewLettersExe, hebrew);
    }

    static public void OpenOnlineConcordance(string hebrew)
    {
      RunShell(Settings.SearchOnlineURL + hebrew);
    }

    static public void OpenOnlineVerse(string url, int book, int chapter, int verse)
    {
      RunShell(url.Replace("%BOOKSB%", BooksNames.StudyBible[(Books)( book - 1 )])
                  .Replace("%BOOKBIBLEHUB%", BooksNames.BibleHub[(Books)( book - 1 )])
                  .Replace("%BOOKCHABAD%", BooksNames.Chabad[(Books)( book - 1 )])
                  .Replace("%BOOKMM%", BooksNames.MechonMamre[(Books)( book - 1 )])
                  .Replace("%BOOKDJEP%", BooksNames.Djep[(Books)( book - 1 )])
                  .Replace("%BOOKNUM%", book.ToString())
                  .Replace("%CHAPTERNUM%", chapter.ToString())
                  .Replace("%VERSENUM%", verse.ToString())
                  .Replace("%BOOKNUM#2%", book.ToString("00"))
                  .Replace("%CHAPTERNUM#2%", chapter.ToString("00"))
                  .Replace("%VERSENUM#2%", verse.ToString("00")));
    }

  }

}
