/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2022 Olivier Rogier.
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
/// <edited> 2022-05 </edited>
namespace Ordisoftware.Hebrew.Words;

/// <summary>
/// Provides application's main form.
/// </summary>
/// <seealso cref="T:System.Windows.Forms.Form"/>
partial class MainForm : Form
{

  /// <summary>
  /// Creates system information menu items.
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
    InitializeGoToParashahMenu();
  }

  /// <summary>
  /// Initializes special menus.
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
  /// Creates providers links menu items.
  /// </summary>
  private void CreateProvidersLinks()
  {
    // Word search online
    ActionWordSearchOnline.InitializeFromProviders(HebrewGlobals.WebProvidersWord, (sender, e) =>
    {
      if ( sender is not ToolStripMenuItem menuitem ) return;
      var contextmenu = ( menuitem?.GetCurrentParent() as ToolStripDropDownMenu )?.OwnerItem?.Owner as ContextMenuStrip;
      var control = contextmenu?.SourceControl?.Parent as WordControl;
      string word = control?.Reference.Word.Hebrew ?? string.Empty;
      HebrewTools.OpenWordProvider((string)menuitem.Tag, word);
    });
    // Verse read online
    ActionVerseReadOnline.InitializeFromProviders(HebrewGlobals.WebProvidersBible, (sender, e) =>
    {
      var menuitem = sender as ToolStripMenuItem;
      var contextmenu = ( menuitem?.GetCurrentParent() as ToolStripDropDownMenu )?.OwnerItem?.Owner as ContextMenuStrip;
      var control = contextmenu?.SourceControl;
      if ( control is LinkLabel && Settings.CurrentView == ViewMode.Search )
      {
        var reference = (ReferenceItem)control.Tag;
        HebrewTools.OpenBibleProvider((string)menuitem.Tag,
                                      reference.Book.Number,
                                      reference.Chapter.Number,
                                      reference.Verse.Number);
      }
      else
      if ( control is Label label && ( Settings.CurrentView == ViewMode.ChapterVerses
                                    || Settings.CurrentView == ViewMode.VerseFiltered ) )
      {
        var reference = ( (VerseControl)label.Parent ).Reference;
        HebrewTools.OpenBibleProvider((string)menuitem.Tag,
                                      reference.Book.Number,
                                      reference.Chapter.Number,
                                      reference.Verse.Number);
      }
    });
  }

  [SuppressMessage("IDisposableAnalyzers.Correctness", "IDISP001:Dispose created", Justification = "Analysis error")]
  [SuppressMessage("Naming", "GCop201:Use camelCasing when declaring {0}", Justification = "N/A")]
  private void InitializeGoToParashahMenu()
  {
    foreach ( var book in ParashotFactory.Instance.Items.Keys )
    {
      var menuitem = new ToolStripMenuItem(book.ToString(), ActionVerseReadDefault.Image);
      menuitem.ImageScaling = ToolStripItemImageScaling.None;
      ActionGoToParashah.DropDownItems.Add(menuitem);
      foreach ( var parashah in ParashotFactory.Instance.Items[book] )
      {
        var subitem = menuitem.DropDownItems.Add(parashah.Name, ActionDummyParashah.Image);
        subitem.ImageScaling = ToolStripItemImageScaling.None;
        subitem.Click += (_s, _e) => GoToReference(parashah.FullReferenceBegin);
      }
    }

  }

}
