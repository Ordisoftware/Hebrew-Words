/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2016-2021 Olivier Rogier.
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

/// <summary>
/// Provides form to edit the preferences.
/// </summary>
/// <seealso cref="T:System.Windows.Forms.Form"/>
partial class PreferencesForm
{

  static private readonly Properties.Settings Settings = Program.Settings;

  static public int TabIndexApplication { get; private set; }
  static public int TabIndexStartup { get; private set; }
  static public int TabIndexRendering { get; private set; }
  static public int TabIndexTools { get; private set; }
  static public int TabIndexPaths { get; private set; }

  // Intervals Min, Max, Default, Increment
  static public readonly (int, int, int, int) CheckUpdateInterval = (1, 28, 7, 1);
  static public readonly (int, int, int, int) AutoBackupCountInterval = (0, 30, 5, 1);
  static public readonly (int, int, int, int) AutoSaveDelayInterval = (0, 15, 5, 1);
  static public readonly (int, int, int, int) BookmarksCountInterval = (0, 50, 20, 1);
  static public readonly (int, int, int, int) CommentLinesCountInterval = (1, 20, 2, 1);
  static public readonly (int, int, int, int) WordTranslationLinesCountInterval = (1, 5, 1, 1);
  static public readonly (int, int, int, int) HistoryCountInterval = (0, 50, 20, 1);
  static public readonly (int, int, int, int) SearchDisplayMaxRefInterval = (10, 100, 20, 5);
  static public readonly (int, int, int, int) SearchMinRefForDialogInterval = (0, 200, 20, 5);
  static public readonly (int, int, int, int) WordControlWidthInterval = (150, 500, 210, 5);
  static public readonly (int, int, int, int) FontSizeHebrewInterval = (12, 24, 16, 1);
  static public readonly (int, int, int, int) FontSizeTranslationInterval = (8, 16, 10, 1);
  static public readonly (int, int, int, int) FontSizeCommentaryInterval = (8, 16, 8, 1);

  static private bool First;
  static private bool LanguageChanged;
  static private bool UpdateViewRequired;
  static private int TranslateLinesCountPrevious;
  static private int CommentaryLinesCountPrevious;
  static private int WordControlWidthPrevious;
  static private int MaxrefCountPrevious;
  static private int FontSizeHebrewPrevious;
  static private int FontSizeTranslationPrevious;
  static private int FontSizeCommentaryPrevious;
  static private bool BookNameHebrewWithCommonNamePrevious;

  static public bool Reseted { get; private set; }
  static private bool DoReset;

  static PreferencesForm()
  {
    using var form = new PreferencesForm();
    TabIndexApplication = form.TabControl.TabPages.IndexOf(form.TabPageApplication);
    TabIndexStartup = form.TabControl.TabPages.IndexOf(form.TabPageStartup);
    TabIndexRendering = form.TabControl.TabPages.IndexOf(form.TabPageRendering);
    TabIndexTools = form.TabControl.TabPages.IndexOf(form.TabPageTools);
    TabIndexPaths = form.TabControl.TabPages.IndexOf(form.TabPagePaths);
  }

  static public bool Run(int index = -1)
  {
    First = true;
    Reseted = false;
    Language lang = Settings.LanguageSelected;
    var form = new PreferencesForm();
    if ( !MainForm.Instance.Visible )
      form.ShowInTaskbar = true;
    if ( index >= 0 )
      form.TabControl.SelectedIndex = index;
    else
      form.TabControl.SelectedIndex = Settings.PreferencesFormSelectedTabIndex;
    form.ShowDialog();
    while ( LanguageChanged || DoReset )
    {
      LanguageChanged = false;
      DoReset = false;
      form.Dispose();
      form = new PreferencesForm();
      if ( !MainForm.Instance.Visible )
        form.ShowInTaskbar = true;
      form.ShowDialog();
    }
    MainForm.Instance.InitializeDialogsDirectory();
    bool result = Reseted || UpdateViewRequired || lang != Settings.LanguageSelected;
    Settings.PreferencesFormSelectedTabIndex = form.TabControl.SelectedIndex;
    form.Dispose();
    return result;
  }

}
