﻿/// <license>
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

/// <summary>
/// Provide application's main form.
/// </summary>
/// <seealso cref="T:System.Windows.Forms.Form"/>
partial class MainForm : Form
{

  /// <summary>
  /// Create system information menu items.
  /// </summary>
  public void CreateSystemInformationMenu()
  {
    CommonMenusControl.CreateInstance(ToolStrip,
                                      ref ActionInformation,
                                      AppTranslations.NoticeNewFeatures,
                                      ActionWebCheckUpdate_Click,
                                      ActionViewLog_Click,
                                      ActionViewStats_Click);
    InitializeSpecialMenus();
  }

  /// <summary>
  /// Create web links menu items.
  /// </summary>
  public void InitializeSpecialMenus()
  {
    CreateProvidersLinks();
    CommonMenusControl.Instance.ActionViewStats.Enabled = Settings.UsageStatisticsEnabled;
    CommonMenusControl.Instance.ActionViewLog.Enabled = DebugManager.TraceEnabled;
    ActionWebLinks.Visible = Settings.WebLinksMenuEnabled;
    if ( Settings.WebLinksMenuEnabled )
      ActionWebLinks.InitializeFromWebLinks(InitializeSpecialMenus);
  }

  /// <summary>
  /// Create providers links menu items.
  /// </summary>
  private void CreateProvidersLinks()
  {
    ActionSearchOnline.InitializeFromProviders(HebrewGlobals.WebProvidersWord, (sender, e) =>
    {
      if ( ActiveControl is not WordControl ) return;
      var menuitem = (ToolStripMenuItem)sender;
      string word = ( (WordControl)ActiveControl ).Reference.Word.Hebrew;
      HebrewTools.OpenWordProvider((string)menuitem.Tag, word);
    });
    ActionOpenVerseOnline.InitializeFromProviders(HebrewGlobals.WebProvidersBible, (sender, e) =>
    {
      var menuitem = sender as ToolStripMenuItem;
      var contextmenu = ( menuitem?.GetCurrentParent() as ToolStripDropDownMenu )?.OwnerItem?.Owner as ContextMenuStrip;
      var control = contextmenu?.SourceControl as Label;
      if ( control is LinkLabel && Settings.CurrentView == ViewMode.Search )
      {
        var reference = (ReferenceItem)control.Tag;
        HebrewTools.OpenBibleProvider((string)menuitem.Tag,
                                      reference.Book.Number,
                                      reference.Chapter.Number,
                                      reference.Verse.Number);
      }
      else
      if ( control is Label && Settings.CurrentView == ViewMode.Verses )
        HebrewTools.OpenBibleProvider((string)menuitem.Tag,
                                      CurrentReference.Book.Number,
                                      CurrentReference.Chapter.Number,
                                      Convert.ToInt32(control.Text));
    });
  }

}