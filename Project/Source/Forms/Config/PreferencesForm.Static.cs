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
/// <created> 2016-04 </created>
/// <edited> 2022-04 </edited>
namespace Ordisoftware.Hebrew.Words;

/// <summary>
/// Provides form to edit the preferences.
/// </summary>
/// <seealso cref="T:System.Windows.Forms.Form"/>
partial class PreferencesForm
{

  static private readonly Properties.Settings Settings = Program.Settings;

  // Tab pages indexes
  static public int TabIndexApplication { get; private set; }
  static public int TabIndexStartup { get; private set; }
  static public int TabIndexBookmarks { get; private set; }
  static public int TabIndexEditing { get; private set; }
  static public int TabIndexRendering { get; private set; }
  static public int TabIndexTheme { get; private set; }
  static public int TabIndexMouse { get; private set; }
  static public int TabIndexMSWord { get; private set; }
  static public int TabIndexExport { get; private set; }
  static public int TabIndexPaths { get; private set; }
  static public int TabIndexTools { get; private set; }

  // Numeric intervals as (Min, Max, Default, Increment)
  static public readonly (int, int, int, int) AutoBackupCountInterval = (0, 30, 5, 1);
  static public readonly (int, int, int, int) AutoSaveDelayInterval = (0, 15, 5, 1);
  static public readonly (int, int, int, int) BookmarksCountInterval = (0, 50, 20, 1);
  static public readonly (int, int, int, int) CheckUpdateInterval = (1, 28, 7, 1);
  static public readonly (int, int, int, int) CommentLinesCountInterval = (0, 50, 2, 1);
  static public readonly (int, int, int, int) DocumentMarginHFInterval = (0, 40, 13, 1);
  static public readonly (int, int, int, int) DocumentMarginInterval = (0, 50, 20, 1);
  static public readonly (int, int, int, int) DocumentPageHeightInterval = (37, 1414, 297, 1);
  static public readonly (int, int, int, int) DocumentPageWidthInterval = (26, 1000, 210, 1);
  static public readonly (int, int, int, int) DocumentWordColumnsCountInterval = (4, 12, 5, 1);
  static public readonly (int, int, int, int) FontSizeCommentaryInterval = (8, 16, 10, 1);
  static public readonly (int, int, int, int) FontSizeHebrewInterval = (12, 24, 16, 1);
  static public readonly (int, int, int, int) FontSizeTranslationInterval = (8, 16, 10, 1);
  static public readonly (int, int, int, int) HistoryCountInterval = (0, 50, 30, 1);
  static public readonly (int, int, int, int) SearchDisplayMaxRefInterval = (10, 100, 20, 5);
  static public readonly (int, int, int, int) SearchMinRefForDialogInterval = (0, 200, 20, 5);
  static public readonly (int, int, int, int) WordControlWidthInterval = (150, 500, 205, 5);
  static public readonly (int, int, int, int) WordTranslationLinesCountInterval = (1, 5, 1, 1);
  //static public readonly (int, int, int, int) PrintingMarginInterval = (10, 160, 60, 10);

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
    TabIndexBookmarks = form.TabControl.TabPages.IndexOf(form.TabPageBookmarks);
    TabIndexEditing = form.TabControl.TabPages.IndexOf(form.TabPageEditing);
    TabIndexRendering = form.TabControl.TabPages.IndexOf(form.TabPageRendering);
    TabIndexTheme = form.TabControl.TabPages.IndexOf(form.TabPageTheme);
    TabIndexMouse = form.TabControl.TabPages.IndexOf(form.TabPageMouse);
    TabIndexMSWord = form.TabControl.TabPages.IndexOf(form.TabPageMSWord);
    TabIndexExport = form.TabControl.TabPages.IndexOf(form.TabPagePaths);
    TabIndexPaths = form.TabControl.TabPages.IndexOf(form.TabPagePaths);
    TabIndexTools = form.TabControl.TabPages.IndexOf(form.TabPageTools);
  }

  static public bool Run(int index = -1)
  {
    First = true;
    Reseted = false;
    var lang = Settings.LanguageSelected;
    var form = new PreferencesForm();
    if ( !MainForm.Instance.Visible )
      form.ShowInTaskbar = true;
    form.TabControl.SelectedIndex = index >= 0 ? index : Settings.PreferencesFormSelectedTabIndex;
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
    var result = Reseted
              || UpdateViewRequired
              || lang != Settings.LanguageSelected
              || TranslateLinesCountPrevious != (int)form.EditWordTranslateLinesCount.Value
              || CommentaryLinesCountPrevious != (int)form.EditCommentaryLinesCount.Value
              || WordControlWidthPrevious != (int)form.EditWordControlWidth.Value
              || MaxrefCountPrevious != (int)form.EditSearchDisplayMaxRef.Value
              || FontSizeHebrewPrevious != (int)form.EditFontSizeHebrew.Value
              || FontSizeTranslationPrevious != (int)form.EditFontSizeTranslation.Value
              || FontSizeCommentaryPrevious != (int)form.EditFontSizeCommentary.Value
              || BookNameHebrewWithCommonNamePrevious != form.EditBookNameHebrewWithCommonName.Checked;
    form.Dispose();
    return result;
  }

}
