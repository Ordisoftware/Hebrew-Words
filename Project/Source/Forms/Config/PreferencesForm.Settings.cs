/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2016-2023 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at
/// https://mozilla.org/MPL/2.0/.
/// If it is not possible or desirable to put the notice in a particular file,
/// then You may include the notice in a location(such as a LICENSE file in a
/// relevant directory) where a recipient would be likely to look for such a notice.
/// You may add additional accurate notices of copyright ownership.
/// </license>
/// <created> 2020-12 </created>
/// <edited> 2022-04 </edited>
namespace Ordisoftware.Hebrew.Words;

using System.Configuration;
using System.Xml.Linq;
using System.Xml.XPath;

/// <summary>
/// Provides form to edit the preferences.
/// </summary>
/// <seealso cref="T:System.Windows.Forms.Form"/>
partial class PreferencesForm
{

  private readonly NullSafeOfStringDictionary<DataExportTarget> ExportTarget
    = ExportHelper.CreateExportTargets(DataExportTarget.XML);

  private void DoResetSettings()
  {
    if ( !DisplayManager.QueryYesNo(SysTranslations.AskToResetPreferences.GetLang()) ) return;
    StatisticsForm.Instance.Hide();
    long starttime = Settings.BenchmarkStartingApp;
    long loadtime = Settings.BenchmarkLoadData;
    var lastupdate = Settings.CheckUpdateLastDone;
    var lastvacuum = Settings.VacuumLastDone;
    Settings.Reset();
    Settings.SetFirstAndUpgradeFlagsOff();
    Settings.CheckUpdateLastDone = lastupdate;
    Settings.VacuumLastDone = lastvacuum;
    Settings.LanguageSelected = Languages.Current;
    Settings.BenchmarkStartingApp = starttime;
    Settings.BenchmarkLoadData = loadtime;
    Settings.RestoreMainForm();
    Program.TranscriptionGuideForm.CenterToMainFormElseScreen();
    Program.GrammarGuideForm.CenterToMainFormElseScreen();
    SystemManager.TryCatch(Settings.Store);
    DoReset = true;
    Reseted = true;
    Close();
  }

  private void DoExportSettings()
  {
    SaveSettingsDialog.FileName = "Settings";
    if ( SaveSettingsDialog.ShowDialog() != DialogResult.OK ) return;
    TabControl.SelectedIndex = 0;
    SaveSettings();
    Settings.Store();
    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
    config.SaveAs(SaveSettingsDialog.FileName);
  }

  private void DoImportSettings()
  {
    OpenSettingsDialog.FileName = string.Empty;
    if ( OpenSettingsDialog.ShowDialog() != DialogResult.OK ) return;
    StatisticsForm.Instance.Hide();
    long starttime = Settings.BenchmarkStartingApp;
    long loadtime = Settings.BenchmarkLoadData;
    try
    {
      var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
      string context = Properties.Settings.Default.Context["GroupName"].ToString();
      var xmldata = XDocument.Load(OpenSettingsDialog.FileName);
      var settings = xmldata.XPathSelectElements("//" + context);
      var section = config.GetSectionGroup("userSettings").Sections[context].SectionInformation;
      section.SetRawXml(settings.Single().ToString());
      config.Save(ConfigurationSaveMode.Modified);
      ConfigurationManager.RefreshSection("userSettings");
      Settings.Reload();
      Settings.BenchmarkStartingApp = starttime;
      Settings.BenchmarkLoadData = loadtime;
      Settings.Retrieve();
      SystemManager.TryCatch(Settings.Store);
      Settings.SetFirstAndUpgradeFlagsOff();
      Program.UpdateLocalization();
      LanguageChanged = true;
      DoReset = true;
      Reseted = true;
      Close();
    }
    catch ( Exception ex )
    {
      DisplayManager.ShowError(ex.Message);
      Settings.Reload();
    }
  }

}
