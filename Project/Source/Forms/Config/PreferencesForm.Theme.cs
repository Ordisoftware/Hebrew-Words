/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2016-2024 Olivier Rogier.
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
/// <edited> 2022-08 </edited>
namespace Ordisoftware.Hebrew.Words;

using MoreLinq;

/// <summary>
/// Provides form to edit the preferences.
/// </summary>
/// <seealso cref="T:System.Windows.Forms.Form"/>
partial class PreferencesForm
{

  private void SetThemePastel()
  {
    EditThemeNavigatorItems.BackColor = Color.LightYellow;
    EditThemeCurrentControl.BackColor = Color.AliceBlue;
    EditThemeTranslationBack.BackColor = SystemColors.Window;
    EditThemeCommentaryBack.BackColor = Color.Honeydew;
    EditThemeSearchLettersBack.BackColor = Color.LightYellow;
    EditThemeSearchWordBack.BackColor = Color.AliceBlue;
    EditThemeVerseNumberColor.BackColor = Color.DarkBlue;
    EditThemeVerseNumberColorHover.BackColor = Color.RoyalBlue;
    EditThemeVerseHebrewColor.BackColor = SystemColors.ControlText;
    EditThemeVerseHebrewColorHover.BackColor = Color.DarkRed;
    EditThemeTranslationTextColor.BackColor = SystemColors.ControlText;
    //
    SaveColors();
    MainForm.Instance.InitializeTheme();
    UpdateViewRequired = true;
  }

  private void SetThemeSystem()
  {
    EditThemeNavigatorItems.BackColor = SystemColors.Window;
    EditThemeCurrentControl.BackColor = SystemColors.Window;
    EditThemeTranslationBack.BackColor = SystemColors.Window;
    EditThemeCommentaryBack.BackColor = SystemColors.Window;
    EditThemeSearchLettersBack.BackColor = SystemColors.Control;
    EditThemeSearchWordBack.BackColor = SystemColors.Window;
    EditThemeVerseNumberColor.BackColor = SystemColors.ControlText;
    EditThemeVerseNumberColorHover.BackColor = SystemColors.HotTrack;
    EditThemeVerseHebrewColor.BackColor = SystemColors.ControlText;
    EditThemeVerseHebrewColorHover.BackColor = SystemColors.HotTrack;
    EditThemeTranslationTextColor.BackColor = SystemColors.ControlText;
    SaveColors();
    MainForm.Instance.InitializeTheme();
    UpdateViewRequired = true;
  }

  private void DoOpenTheme()
  {
    SystemManager.TryCatch(() => OpenThemeDialog.InitialDirectory = Settings.GetExportSettingsDirectory());
    if ( OpenThemeDialog.ShowDialog() != DialogResult.OK ) return;
    var items = new NullSafeOfStringDictionary<string>();
    if ( !items.LoadKeyValuePairs(OpenThemeDialog.FileName, "=") ) return;
    TabPageTheme.Controls.OfType<Panel>().ForEach(panel =>
    {
      string name = panel.Name.Substring(4);
      if ( items.TryGetValue(name, out var color) )
        panel.BackColor = ColorTranslator.FromHtml(color);
    });
    SaveColors();
    MainForm.Instance.InitializeTheme();
  }

  private void DoSaveTheme()
  {
    SystemManager.TryCatch(() =>
    {
      SaveThemeDialog.InitialDirectory = Settings.GetExportSettingsDirectory();
      SaveThemeDialog.FileName = "Theme.ini";
    });
    if ( SaveThemeDialog.ShowDialog() != DialogResult.OK ) return;
    var items = new List<string>();
    TabPageTheme.Controls.OfType<Panel>().ForEach(panel => items.Add(makeLine(panel)));
    File.WriteAllLines(SaveThemeDialog.FileName, items);
    //
    static string makeLine(Panel panel)
    {
      return panel.Name.Substring(4) + "=" + ColorTranslator.ToHtml(panel.BackColor);
    }
  }

}
