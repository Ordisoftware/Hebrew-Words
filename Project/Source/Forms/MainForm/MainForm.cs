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
/// <edited> 2020-03 </edited>
using System;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Data.Odbc;
using Microsoft.Win32;
using Ordisoftware.Core;
using Ordisoftware.Hebrew.Words.Data;

namespace Ordisoftware.Hebrew.Words
{

  /// <summary>
  /// Provide application's main form.
  /// </summary>
  /// <seealso cref="T:System.Windows.Forms.Form"/>
  partial class MainForm : Form
  {

    /// <summary>
    /// Indicate the singleton instance.
    /// </summary>
    static public readonly MainForm Instance;

    /// <summary>
    /// Static constructor.
    /// </summary>
    static MainForm()
    {
      Instance = new MainForm();
    }

    /// <summary>
    /// Default constructor.
    /// </summary>
    private MainForm()
    {
      InitializeComponent();
      SoundItem.Initialize();
      Text = Globals.AssemblyTitle;
      SystemEvents.SessionEnding += SessionEnding;
      SystemManager.TryCatch(() => { Icon = new Icon(Globals.ApplicationIconFilePath); });
      CurrentReference = new ReferenceItem(null, null, null, null);
      Bookmarks = new Bookmarks(Program.BookmarksFilePath);
      History = new History(Program.HistoryFilePath);
      ActionGoToBookmarkMaster.Click += new EventHandler(GoToBookmark);
      CreateProvidersLinks();
      ActionSearchOnline.InitializeFromProviders(OnlineProviders.OnlineWordProviders, (sender, e) =>
      {
        if ( !( ActiveControl is WordControl ) ) return;
        var menuitem = (ToolStripMenuItem)sender;
        string word = ( (WordControl)ActiveControl ).Reference.Word.Original;
        SystemManager.RunShell(( (string)menuitem.Tag ).Replace("%WORD%", word));
      });
    }

    /// <summary>
    /// Create system information menu items.
    /// </summary>
    public void CreateSystemInformationMenu()
    {
      CommonMenusControl.CreateInstance(ToolStrip,
                                        ref ActionInformation,
                                        AppTranslations.NoticeNewFeatures,
                                        ActionAbout_Click,
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
      ActionWebLinks.Visible = Settings.WebLinksMenuEnabled;
      if ( Settings.WebLinksMenuEnabled )
        ActionWebLinks.InitializeFromWebLinks(InitializeSpecialMenus);
    }

    /// <summary>
    /// Create providers links menu items.
    /// </summary>
    private void CreateProvidersLinks()
    {
      ContextMenuStripVerse.InitializeFromProviders(OnlineProviders.OnlineBibleProviders, (sender, e) =>
      {
        var menuitem = (ToolStripMenuItem)sender;
        var control = ( (ContextMenuStrip)menuitem.Owner ).SourceControl;
        if ( control is LinkLabel && Settings.CurrentView == ViewMode.Search )
        {
          var reference = (ReferenceItem)control.Tag;
          HebrewTools.OpenOnlineVerse((string)menuitem.Tag,
                                      reference.Book.Number,
                                      reference.Chapter.Number,
                                      reference.Verse.Number);
        }
        else
        if ( control is Label && Settings.CurrentView == ViewMode.Verses )
          HebrewTools.OpenOnlineVerse((string)menuitem.Tag,
                                      CurrentReference.Book.Number,
                                      CurrentReference.Chapter.Number,
                                      Convert.ToInt32(control.Text));
      });
    }

    /// <summary>
    /// Event handler. Called by MainForm for load events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void MainForm_Load(object sender, EventArgs e)
    {
      if ( Globals.IsExiting ) return;
      Settings.Retrieve();
      ProcessLocksTable.Lock();
      SystemManager.TryCatch(() => new System.Media.SoundPlayer(Globals.EmptySoundFilePath).Play());
      SystemManager.TryCatch(() => MediaMixer.SetApplicationVolume(Process.GetCurrentProcess().Id,
                                                                   Settings.ApplicationVolume));
      var lastdone = Settings.CheckUpdateLastDone;
      bool exit = WebCheckUpdate.Run(Settings.CheckUpdateAtStartup,
                                     ref lastdone,
                                     Settings.CheckUpdateAtStartupDaysInterval,
                                     true);
      Settings.CheckUpdateLastDone = lastdone;
      if ( exit )
      {
        SystemManager.Exit();
        return;
      }
      if ( Settings.SearchOnlineURL == "https://www.google.com/search?q=strong+hebrew+" )
      {
        Settings.SearchOnlineURL = "https://www.pealim.com/search/?q=%WORD%";
        Settings.Save();
      }
      UpdateSearchButtons();
      BookmarksMenuFirstIndex = MenuBookmarks.DropDownItems.Count;
      CommonMenusControl.Instance.ActionViewStats.Enabled = Settings.UsageStatisticsEnabled;
      CommonMenusControl.Instance.ActionViewLog.Enabled = DebugManager.TraceEnabled;
      DebugManager.TraceEnabledChanged += value => CommonMenusControl.Instance.ActionViewLog.Enabled = value;
    }

    /// <summary>
    /// Event handler. Called by MainForm for shown events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void MainForm_Shown(object sender, EventArgs e)
    {
      if ( Globals.IsExiting ) return;
      Refresh();
      InitializeDialogsDirectory();
      DoBackupDB();
      LoadData();
      TimerAutoSave.Enabled = Settings.AutoSaveDelay != 0;
      if ( TimerAutoSave.Enabled )
        TimerAutoSave.Interval = Settings.AutoSaveDelay * 60 * 1000;
      Globals.IsReady = true;
      bool auto = false;
      if ( SystemManager.CommandLineOptions != null )
        try
        {
          var options = ApplicationCommandLine.Instance;
          if ( !string.IsNullOrEmpty(options.ReferenceToGo) )
          {
            GoTo(options.ReferenceToGo);
            auto = true;
          }
          else
          if ( !string.IsNullOrEmpty(options.WordHebrew) )
          {
            auto = true;
            defaultGoTo();
            SearchHebrewWord(options.WordHebrew);
          }
          else
          if ( !string.IsNullOrEmpty(options.WordUnicode) )
          {
            auto = true;
            defaultGoTo();
            SearchHebrewWord(HebrewAlphabet.ToHebrewFont(options.WordHebrew));
          }
          else
          if ( !string.IsNullOrEmpty(options.WordTranslated) )
          {
            auto = true;
            defaultGoTo();
            SearchTranslatedWord(options.WordTranslated);
          }
        }
        catch
        {
        }
      if ( !auto ) defaultGoTo();
      ActionSave.PerformClick();
      void defaultGoTo()
      {
        if ( Program.Settings.GoToMasterBookmarkAtStartup )
          GoTo(Program.Settings.BookmarkMasterBook,
               Program.Settings.BookmarkMasterChapter,
               Program.Settings.BookmarkMasterVerse,
               true);
        else
          GoTo(1, 1, 1, true);
      }
      if ( Globals.SettingsUpgraded && Settings.ShowLastNewInVersionAfterUpdate )
        SystemManager.TryCatch(() =>
        {
          var menuRoot = CommonMenusControl.Instance.ActionViewVersionNews;
          var menuItem = menuRoot.DropDownItems.Cast<ToolStripItem>().LastOrDefault();
          if ( menuItem != null ) menuItem.PerformClick();
        });
    }

    /// <summary>
    /// Event handler. Called by MainForm for form closing events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Form closing event information.</param>
    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if ( Globals.IsExiting ) return;
      if ( !Globals.IsReady ) return;
      ActionSave.PerformClick();
      if ( e.CloseReason != CloseReason.None && e.CloseReason != CloseReason.UserClosing )
      {
        Globals.IsExiting = true;
        return;
      }
      if ( EditConfirmClosing.Checked && !Globals.IsSessionEnding )
        if ( !DisplayManager.QueryYesNo(SysTranslations.AskToExitApplication.GetLang()) )
          e.Cancel = true;
        else
          Globals.IsExiting = true;
    }

    /// <summary>
    /// Event handler. Called by MainForm for form closed events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Form closing event information.</param>
    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Settings.Store();
      ProcessLocksTable.Unlock();
    }

    /// <summary>
    /// Event handler. Called by MainForm for client size and location changed events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void MainForm_WindowsChanged(object sender, EventArgs e)
    {
      if ( Globals.IsExiting ) return;
      if ( !Globals.IsReady ) return;
      if ( !Visible ) return;
      if ( WindowState != FormWindowState.Normal ) return;
      EditScreenNone.PerformClick();
    }

    /// <summary>
    /// Session ending event.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Session ending event information.</param>
    private void SessionEnding(object sender, SessionEndingEventArgs e)
    {
      Globals.IsExiting = true;
      Globals.IsSessionEnding = true;
      Globals.AllowClose = true;
      foreach ( Form form in Application.OpenForms )
        if ( form != this && form.Visible )
          try { form.Close(); }
          catch { }
      Close();
    }

    /// <summary>
    /// Set the initial directories of dialog boxes.
    /// </summary>
    public void InitializeDialogsDirectory()
    {
      OpenFileDialogDB.InitialDirectory = Settings.BackupPath;
      SaveFileDialogDB.InitialDirectory = Settings.BackupPath;
      SaveFileDialogMSWord.InitialDirectory = Settings.BackupPath;
      SaveFileDialogRTF.InitialDirectory = Settings.BackupPath;
    }

    /// <summary>
    /// Set form disabled or enabled.
    /// </summary>
    public void SetFormDisabled(bool disabled)
    {
      Cursor = disabled ? Cursors.WaitCursor : Cursors.Default;
      ToolStrip.Enabled = !disabled;
      PanelNavigation.Enabled = !disabled;
      PanelMainCenter.Enabled = !disabled;
      Refresh();
    }

    /// <summary>
    /// Initialize books combobox.
    /// </summary>
    private void InitBooksCombobox()
    {
      SelectBook.Items.Clear();
      SelectSearchInBook.Items.Clear();
      foreach ( Data.DataSet.BooksRow book in DataSet.Books.Rows )
      {
        var item = new BookItem(book);
        SelectBook.Items.Add(item);
        SelectSearchInBook.Items.Add(item);
      }
      try
      {
        SelectBook.SelectedIndex = 0;
        foreach ( var item in SelectSearchInBook.Items )
          if ( ( (BookItem)item ).Book.Number == Settings.SearchInBookSelectedNumber )
            SelectSearchInBook.SelectedItem = item;
        if ( SelectSearchInBook.SelectedIndex == -1 )
          SelectSearchInBook.SelectedIndex = 0;
      }
      finally
      {
      }
    }

    /// <summary>
    /// Initialize chapter combobox.
    /// </summary>
    private void InitChaptersCombobox()
    {
      if ( SelectBook.SelectedItem == null ) return;
      SelectChapter.Items.Clear();
      var list = ( (BookItem)SelectBook.SelectedItem ).Book.GetChaptersRows();
      foreach ( Data.DataSet.ChaptersRow chapter in list )
        SelectChapter.Items.Add(new ChapterItem(chapter));
      SelectChapter.SelectedIndex = 0;
    }

    /// <summary>
    /// Timer event for tooltips.
    /// </summary>
    private void TimerTooltip_Tick(object sender, EventArgs e)
    {
      if ( !EditShowTips.Checked ) return;
      var item = (ToolStripItem)LastToolTip.Tag;
      var location = new Point(item.Bounds.Left, item.Bounds.Top + ActionExit.Height + 5);
      LastToolTip.Tag = sender;
      LastToolTip.Show(item.ToolTipText, ToolStrip, location, 3000);
      TimerTooltip.Enabled = false;
    }

    /// <summary>
    /// Show tooltip on mouse enter event.
    /// </summary>
    private void ShowToolTipOnMouseEnter(object sender, EventArgs e)
    {
      if ( !EditShowTips.Checked ) return;
      if ( !( sender is ToolStripItem ) ) return;
      if ( LastToolTip.Tag == sender ) return;
      LastToolTip.Tag = sender;
      if ( ( (ToolStripItem)sender ).ToolTipText == "" ) return;
      TimerTooltip.Enabled = true;
    }

    /// <summary>
    /// Hide tooltip on mouse leave event.
    /// </summary>
    private void ShowToolTipOnMouseLeave(object sender, EventArgs e)
    {
      if ( !EditShowTips.Checked ) return;
      TimerTooltip.Enabled = false;
      LastToolTip.Tag = null;
      LastToolTip.Hide(ToolStrip);
    }

    /// <summary>
    /// Event handler. Called by ActionViewVerses for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionViewVerses_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      if ( Settings.CurrentView == ViewMode.Verses ) return;
      SetView(ViewMode.Verses);
      GoTo(CurrentReference);
    }

    /// <summary>
    /// Event handler. Called by ActionViewTranslations for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionViewTranslations_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      if ( Settings.CurrentView == ViewMode.Translations ) return;
      SetView(ViewMode.Translations);
      RenderTranslation();
      GoTo(CurrentReference);
    }

    /// <summary>
    /// Event handler. Called by ActionViewRawText for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionViewRawText_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      if ( Settings.CurrentView == ViewMode.Text ) return;
      SetView(ViewMode.Text);
      GoTo(CurrentReference);
    }

    /// <summary>
    /// Event handler. Called by ActionViewELS50 for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionViewELS50_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      if ( Settings.CurrentView == ViewMode.ELS50 ) return;
      SetView(ViewMode.ELS50);
    }

    /// <summary>
    /// Event handler. Called by ActionViewSearch for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionViewSearch_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      if ( Settings.CurrentView == ViewMode.Search )
        RotateSearchTab();
      else
        SetView(ViewMode.Search);
      SelectSearchType_Selected(null, null);
    }

    /// <summary>
    /// Event handler. Called by SelectSearchType for selected events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void SelectSearchType_Selected(object sender, TabControlEventArgs e)
    {
      if ( SelectSearchType.SelectedTab == SelectSearchTypeHebrew )
      {
        ActiveControl = EditLetters;
        EditLetters.Focus();
      }
      else
      if ( SelectSearchType.SelectedTab == SelectSearchTypeTranslation )
      {
        ActiveControl = EditSearchTranslation;
        EditSearchTranslation.Focus();
      }
      UpdateSearchButtons();
    }

    /// <summary>
    /// Event handler. Called by ActionRefresh for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionRefresh_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      int book = CurrentReference.Book.Number;
      int chapter = CurrentReference.Chapter.Number;
      int verse = CurrentReference.Verse?.Number ?? 1;
      RenderAll();
      RenderSearch();
      GoTo(book, chapter, verse);
    }

    /// <summary>
    /// Event handler. Called by ActionCloseWindows for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionCloseWindows_Click(object sender, EventArgs e)
    {
      bool value = Settings.CloseSearchTranslatedFormReturnToReference;
      try
      {
        Settings.CloseSearchTranslatedFormReturnToReference = false;
        foreach ( var form in SearchTranslatedForm.Forms.ToList() )
          form.Close();
      }
      finally
      {
        Settings.CloseSearchTranslatedFormReturnToReference = value;
      }
    }

    /// <summary>
    /// Event handler. Called by ActionCopyToClipboard for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionCopyToClipboard_Click(object sender, EventArgs e)
    {
      switch ( Settings.CurrentView )
      {
        case ViewMode.Translations:
          Clipboard.SetText(EditTranslations.Text);
          break;
        case ViewMode.Text:
          Clipboard.SetText(EditRawText.Text);
          break;
        case ViewMode.ELS50:
          Clipboard.SetText(EditELS50All.Text);
          break;
      }
    }

    /// <summary>
    /// Event handler. Called by ActionShowGrammarGuide for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionShowGrammarGuide_Click(object sender, EventArgs e)
    {
      if ( Program.GrammarGuideForm.WindowState == FormWindowState.Minimized )
        Program.GrammarGuideForm.WindowState = FormWindowState.Normal;
      Program.GrammarGuideForm.Show();
      Program.GrammarGuideForm.BringToFront();
    }

    /// <summary>
    /// Event handler. Called by ActionViewBooksTranslation for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionViewBooksTranslation_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      if ( !EditBooksForm.Run() ) return;
      Refresh();
      Globals.IsLoadingData = true;
      try
      {
        int book = CurrentReference.Book.Number;
        int chapter = CurrentReference.Chapter.Number;
        int verse = CurrentReference.Verse?.Number ?? 1;
        InitBooksCombobox();

        // TODO fix text box translation/title/memo vidés...

        GoTo(book, chapter, verse);
      }
      finally
      {
        Globals.IsLoadingData = false;
        ActionSave.PerformClick();
      }
    }

    /// <summary>
    /// Event handler. Called by ActionViewParashot for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionViewParashot_Click(object sender, EventArgs e)
    {
      ParashotForm.Run();
    }

    /// <summary>
    /// Event handler. Called by ActionViewStatistics for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionViewStatistics_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      var reference = StatisticsForm.Run();
      if ( reference != null )
      {
        SetView(ViewMode.Verses);
        GoTo(reference);
      }
    }

    /// <summary>
    /// Event handler. Called by ActionStartHebrewLetters for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionStartHebrewLetters_Click(object sender, EventArgs e)
    {
      HebrewTools.OpenHebrewLetters(( ActiveControl as WordControl )?.Reference.Word.Hebrew ?? "",
                                    Settings.HebrewLettersExe);
    }

    /// <summary>
    /// Event handler. Called by ActionNew for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionNew_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      if ( DisplayManager.QueryYesNo(AppTranslations.AskToBackupDatabaseBeforeReplace.GetLang()) )
        ActionBackup.PerformClick();
      if ( !DisplayManager.QueryYesNo(AppTranslations.AskToCreateNewDatabase.GetLang()) )
        return;
      ReLoadData(() =>
      {
        File.Delete(Path.Combine(Globals.UserDataFolderPath, Globals.DatabaseFileName));
      });
    }

    /// <summary>
    /// Event handler. Called by ActionRestore for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionRestore_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      if ( DisplayManager.QueryYesNo(AppTranslations.AskToBackupDatabaseBeforeReplace.GetLang()) )
        ActionBackup.PerformClick();
      if ( OpenFileDialogDB.ShowDialog() == DialogResult.Cancel )
        return;
      ReLoadData(() =>
      {
        File.Delete(Path.Combine(Globals.UserDataFolderPath, Globals.DatabaseFileName));
        File.Copy(OpenFileDialogDB.FileName, Path.Combine(Globals.UserDataFolderPath, Globals.DatabaseFileName));
      });
    }

    /// <summary>
    /// Event handler. Called by ActionBackup for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionBackup_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      SaveFileDialogDB.FileName = Globals.DatabaseFileName;
      if ( SaveFileDialogDB.ShowDialog() == DialogResult.Cancel ) return;
      if ( File.Exists(SaveFileDialogDB.FileName) ) File.Delete(SaveFileDialogDB.FileName);
      File.Copy(Path.Combine(Globals.UserDataFolderPath, Globals.DatabaseFileName), SaveFileDialogDB.FileName);
    }

    /// <summary>
    /// Event handler. Called by ActionOpenBackupPath for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionOpenBackupPath_Click(object sender, EventArgs e)
    {
      SystemManager.RunShell(Settings.BackupPath);
    }

    /// <summary>
    /// Event handler. Called by ActionSave for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionSave_Click(object sender, EventArgs e)
    {
      if ( DataSet.HasChanges() )
        TableAdapterManager.UpdateAll(DataSet);
      ActionSave.Enabled = false;
    }

    /// <summary>
    /// Event handler. Called by TimerAutoSave for tick events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void TimerAutoSave_Tick(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
    }

    /// <summary>
    /// Event handler. Called by ActionVacuum for tick events.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ActionVacuum_Click(object sender, EventArgs e)
    {
      if ( !DisplayManager.QueryYesNo(SysTranslations.AskToOptimizeDatabase.GetLang()) )
        return;
      ActionSave.PerformClick();
      ReLoadData(() =>
      {
        using ( var connection = new OdbcConnection(Settings.ConnectionString) )
          try
          {
            Settings.VacuumLastDone = connection.Optimize(Settings.VacuumLastDone, -1, true);
          }
          finally
          {
            connection.Close();
          }
      });
    }

    /// <summary>
    /// Event handler. Called by ActionPreferences for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionPreferences_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      bool refresh = PreferencesForm.Run();
      InitializeDialogsDirectory();
      UpdateBookmarks();
      UpdateHistory();
      if ( refresh )
      {
        Refresh();
        RenderVerses();
        UpdatePagingCount();
        RenderSearch();
        var reference = Instance.CurrentReference;
        int verse = reference.Verse == null ? 1 : reference.Verse.Number;
        GoTo(reference.Book.Number, reference.Chapter.Number, verse);
      }
    }

    /// <summary>
    /// Event handler. Called by ActionResetWinSettings for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionResetWinSettings_Click(object sender, EventArgs e)
    {
      if ( DisplayManager.QueryYesNo(SysTranslations.AskToRestoreWindowPosition.GetLang()) )
      {
        Settings.RestoreMainForm();
        ActionRefresh.PerformClick();
      }
    }

    /// <summary>
    /// Event handler. Called by SelectScreenPosition for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    public void EditScreenPosition_Click(object sender, EventArgs e)
    {
      DoScreenPosition(sender, e);
    }

    /// <summary>
    /// Event handler. Called by ActionAbout for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    public void ActionAbout_Click(object sender, EventArgs e)
    {
      if ( AboutBox.Instance.Visible )
        AboutBox.Instance.BringToFront();
      else
        AboutBox.Instance.ShowDialog();
    }

    /// <summary>
    /// Event handler. Called by ActionWebCheckUpdate for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    public void ActionWebCheckUpdate_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      var lastdone = Settings.CheckUpdateLastDone;
      bool exit = WebCheckUpdate.Run(Settings.CheckUpdateAtStartup,
                                     ref lastdone,
                                     Settings.CheckUpdateAtStartupDaysInterval,
                                     e == null);
      Settings.CheckUpdateLastDone = lastdone;
      if ( exit ) Close();
    }

    public void ActionViewLog_Click(object sender, EventArgs e)
    {
      DebugManager.TraceForm.Popup();
    }

    private void ActionViewStats_Click(object sender, EventArgs e)
    {
      // TODO usage stats form and rename tanak stats
      //StatisticsForm.Run();
    }

    /// <summary>
    /// Event handler. Called by ActionExit for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionExit_Click(object sender, EventArgs e)
    {
      Close();
    }

    /// <summary>
    /// Event handler. Called by ActionExportBook for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionExportBook_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      DoExportBook();
    }

    /// <summary>
    /// Event handler. Called by ActionExportChapter for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionExportChapter_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      DoExportChapter();
    }

    /// <summary>
    /// Event handler. Called by ActionELS50CopyToClipboard for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionELS50CopyToClipboard_Click(object sender, EventArgs e)
    {
      Clipboard.SetText(EditELS50.Text);
    }

    /// <summary>
    /// Event handler. Called by SelectBook for selected index changed events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void SelectBook_SelectedIndexChanged(object sender, EventArgs e)
    {
      CurrentReference = new ReferenceItem(( (BookItem)SelectBook.SelectedItem ).Book.Number, 1, 1);
      InitChaptersCombobox();
    }

    /// <summary>
    /// Event handler. Called by SelectChapter for selected index changed events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void SelectChapter_SelectedIndexChanged(object sender, EventArgs e)
    {
      if ( IsComboBoxChanging ) return;
      IsComboBoxChanging = true;
      try
      {
        EditBookTranslation.Text = "";
        EditChapterTitle.Text = "";
        EditChapterMemo.Text = "";
        ActionSave.PerformClick();
        CurrentReference = new ReferenceItem(CurrentReference.Book.Number,
                                             ( (ChapterItem)SelectChapter.SelectedItem ).Chapter.Number,
                                             1);
        RenderAll();
        GoTo(CurrentReference);
      }
      finally
      {
        IsComboBoxChanging = false;
      }
    }

    /// <summary>
    /// Event handler. Called by PanelLetterSearch for key press events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void PanelLetterSearch_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ( e.KeyChar == '\r' ) ActionSearchRun.PerformClick();
    }

    /// <summary>
    /// Event handler. Called by EditLetters for input text changed events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void EditLetters_InputTextChanged(object sender, EventArgs e)
    {
      UpdateSearchButtons();
    }

    /// <summary>
    /// Event handler. Called by EditSearchTranslation for text changed events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void EditSearchTranslation_TextChanged(object sender, EventArgs e)
    {
      UpdateSearchButtons();
    }

    /// <summary>
    /// Event handler. Called by ActionSearchWord for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionSearchWord_Click(object sender, EventArgs e)
    {
      CreateSearchResults();
    }

    /// <summary>
    /// Event handler. Called by ActionSearchClear for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionSearchClear_Click(object sender, EventArgs e)
    {
      EditLetters.Input.Text = "";
      EditSearchTranslation.Text = "";
      Settings.Save();
      ClearSearchResults();
      UpdateSearchButtons();
      RenderSearch();
    }

    private void ActionSearchInAddAll_Click(object sender, EventArgs e)
    {
      EditSearchInTorah.Checked = true;
      EditSearchInNeviim.Checked = true;
      EditSearchInKetouvim.Checked = true;
    }

    private void ActionSearchInRemoveAll_Click(object sender, EventArgs e)
    {
      EditSearchInTorah.Checked = false;
      EditSearchInNeviim.Checked = false;
      EditSearchInKetouvim.Checked = false;
    }

    /// <summary>
    /// Event handler. Called by SelectSearchInBook selected index changed events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void SelectSearchInBook_SelectedIndexChanged(object sender, EventArgs e)
    {
      Settings.SearchInBookSelectedNumber = ( (BookItem)SelectSearchInBook.SelectedItem ).Book.Number;
      Settings.Save();
    }

    /// <summary>
    /// Event handler. Called by EditSearchInSelectBook for checked changed events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void EditSearchInSelectBook_CheckedChanged(object sender, EventArgs e)
    {
      SelectSearchInBook.Enabled = !EditSearchInTorah.Checked
                                && !EditSearchInNeviim.Checked
                                && !EditSearchInKetouvim.Checked;
    }

    /// <summary>
    /// Event handler. Called by PanelViewVerses for mouse click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void PanelViewVerses_MouseClick(object sender, MouseEventArgs e)
    {
      PanelViewVerses.Focus();
      GoTo(CurrentReference);
    }

    /// <summary>
    /// Event handler. Called by PanelSearchResults for mouse click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void PanelSearchResults_MouseClick(object sender, MouseEventArgs e)
    {
      PanelSearchResults.Focus();
    }

    /// <summary>
    /// Event handler. Called by ActionExportVerse for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionExportVerse_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      DoExportVerse(sender);
    }

    /// <summary>
    /// Event handler. Called by ActionCopyTranslation for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionCopyTranslation_Click(object sender, EventArgs e)
    {
      var menuitem = (ToolStripMenuItem)sender;
      var control = ( (ContextMenuStrip)menuitem.Owner ).SourceControl;
      if ( control is LinkLabel && Settings.CurrentView == ViewMode.Search )
      {
        var reference = (ReferenceItem)control.Tag;
        var verse = reference.Verse;
        Clipboard.SetText($"{reference.ToStringFull()}: {verse.GetTranslation()}");
      }
      else
      if ( control is Label && Settings.CurrentView == ViewMode.Verses )
      {
        var reference = ( (ReferenceItem)( (Control)control.Tag ).Tag );
        var verse = reference.Verse;
        Clipboard.SetText($"{reference.ToStringFull()}: {verse.GetTranslation()}");
      }
    }

    /// <summary>
    /// Event handler. Called by ActionSetAsBookmarkMaster for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionSetAsBookmarkMaster_Click(object sender, EventArgs e)
    {
      var menuitem = (ToolStripMenuItem)sender;
      var control = ( (ContextMenuStrip)menuitem.Owner ).SourceControl;
      if ( control is LinkLabel && Settings.CurrentView == ViewMode.Search )
      {
        var reference = (ReferenceItem)control.Tag;
        Settings.BookmarkMasterBook = reference.Book.Number;
        Settings.BookmarkMasterChapter = reference.Chapter.Number;
        Settings.BookmarkMasterVerse = reference.Verse.Number;
      }
      else
      if ( control is Label && Settings.CurrentView == ViewMode.Verses )
      {
        Settings.BookmarkMasterBook = CurrentReference.Book.Number;
        Settings.BookmarkMasterChapter = CurrentReference.Chapter.Number;
        Settings.BookmarkMasterVerse = Convert.ToInt32(control.Text);
      }
      Settings.Store();
      UpdateBookmarks();
    }

    /// <summary>
    /// Event handler. Called by ActionAddToBookmarks for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionAddToBookmarks_Click(object sender, EventArgs e)
    {
      var menuitem = (ToolStripMenuItem)sender;
      var control = ( (ContextMenuStrip)menuitem.Owner ).SourceControl;
      ReferenceItem reference = null;
      if ( control is LinkLabel && Settings.CurrentView == ViewMode.Search )
      {
        reference = (ReferenceItem)control.Tag;
        reference = new ReferenceItem(reference.Book.Number,
                                      reference.Chapter.Number,
                                      reference.Verse.Number);
      }
      else
      if ( control is Label && Settings.CurrentView == ViewMode.Verses )
      {
        int index = Convert.ToInt32(control.Text) - 1;
        reference = new ReferenceItem(CurrentReference.Book.Number,
                                      CurrentReference.Chapter.Number,
                                      CurrentReference.Chapter.GetVersesRows()[index].Number);
      }
      Bookmarks.Add(reference);
      UpdateBookmarks();
    }

    /// <summary>
    /// Event handler. Called by ActionImportConsole for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionImportConsole_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      var menuitem = (ToolStripMenuItem)sender;
      var control = ( (ContextMenuStrip)menuitem.Owner ).SourceControl;
      ReferenceItem reference = null;
      if ( control is LinkLabel && Settings.CurrentView == ViewMode.Search )
      {
        reference = (ReferenceItem)control.Tag;
        reference = new ReferenceItem(reference.Book.Number,
                                      reference.Chapter.Number,
                                      reference.Verse.Number);
      }
      else
      if ( control is Label && Settings.CurrentView == ViewMode.Verses )
      {
        int index = Convert.ToInt32(control.Text) - 1;
        reference = new ReferenceItem(CurrentReference.Book.Number,
                                      CurrentReference.Chapter.Number,
                                      CurrentReference.Chapter.GetVersesRows()[index].Number);
      }
      ImportVerseForm.Run(reference);
    }

    /// <summary>
    /// Event handler. Called by ActionClearHistory for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionClearHistory_Click(object sender, EventArgs e)
    {
      if ( !DisplayManager.QueryYesNo(SysTranslations.AskToEmptyHistory.GetLang()) ) return;
      History.Clear();
      UpdateHistory();
    }

    /// <summary>
    /// Event handler. Called by ActionClearBookmarks for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionClearBookmarks_Click(object sender, EventArgs e)
    {
      if ( !DisplayManager.QueryYesNo(SysTranslations.AskToEmptyBookmarks.GetLang()) ) return;
      Settings.BookmarkMasterBook = 1;
      Settings.BookmarkMasterChapter = 1;
      Settings.BookmarkMasterVerse = 1;
      Bookmarks.Clear();
      Settings.Store();
      UpdateBookmarks();
    }

    /// <summary>
    /// Event handler. Called by ActionSortBookmarks for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionSortBookmarks_Click(object sender, EventArgs e)
    {
      Bookmarks.Sort();
      UpdateBookmarks();
      MenuBookmarks.ShowDropDown();
    }

    private void ActionAddBookmark_Click(object sender, EventArgs e)
    {
      Bookmarks.Add(SelectReferenceForm.Run());
      UpdateBookmarks();
    }

    /// <summary>
    /// Event handler. Called by ActionGoToVerse for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionGoToVerse_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      GoTo(SelectReferenceForm.Run());
    }

    /// <summary>
    /// Event handler. Called by ActionSearchVerse for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionSearchVerse_Click(object sender, EventArgs e)
    {
      GoTo(SelectVerseForm.Run());
    }

    /// <summary>
    /// Search a hebrew word.
    /// </summary>
    /// <param name="word"></param>
    public void SearchHebrewWord(string word)
    {
      SetView(ViewMode.Search);
      SelectSearchType.SelectedTab = SelectSearchTypeHebrew;
      EditLetters.Input.Text = HebrewAlphabet.SetFinal(word, false);
      EditLetters.Input.SelectionStart = EditLetters.Input.Text.Length;
    }

    /// <summary>
    /// Search a translated word.
    /// </summary>
    /// <param name="word"></param>
    public void SearchTranslatedWord(string word)
    {
      SetView(ViewMode.Search);
      SelectSearchType.SelectedTab = SelectSearchTypeTranslation;
      EditLetters.Input.Text = word;
      EditLetters.Input.SelectionStart = EditSearchTranslation.Text.Length;
    }

    /// <summary>
    /// Event handler. Called by ActionSearchNavigateFirst for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionSearchNavigateFirst_Click(object sender, EventArgs e)
    {
      if ( IsRenderingSearch ) return;
      PagingCurrent = 1;
      RenderSearch();
    }

    /// <summary>
    /// Event handler. Called by ActionSearchNavigatePrevious for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionSearchNavigatePrevious_Click(object sender, EventArgs e)
    {
      if ( IsRenderingSearch ) return;
      PagingCurrent--;
      RenderSearch();
    }

    /// <summary>
    /// Event handler. Called by ActionSearchNavigateNext for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionSearchNavigateNext_Click(object sender, EventArgs e)
    {
      if ( IsRenderingSearch ) return;
      PagingCurrent++;
      RenderSearch();
    }

    /// <summary>
    /// Event handler. Called by ActionSearchNavigateLast for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionSearchNavigateLast_Click(object sender, EventArgs e)
    {
      if ( IsRenderingSearch ) return;
      PagingCurrent = PagingCount;
      RenderSearch();
    }

    /// <summary>
    /// Event handler. Called by SelectSearchPaging for value changed events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void SelectSearchPaging_ValueChanged(object sender, EventArgs e)
    {
      if ( PagingCurrent != SelectSearchPaging.Value )
      {
        PagingCurrent = SelectSearchPaging.Value;
        if ( PreviousSeachPagingPosition == -1 )
          RenderSearch();
        else
          EditSearchPaging.Text = SelectSearchPaging.Value + "/" + PagingCount + " (" + SearchResultsCount + ")";
      }
    }

    /// <summary>
    /// Event handler. Called by SelectSearchPaging for mouse down events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void SelectSearchPaging_MouseDown(object sender, MouseEventArgs e)
    {
      PreviousSeachPagingPosition = SelectSearchPaging.Value;
    }

    /// <summary>
    /// Event handler. Called by SelectSearchPaging for mouse up for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void SelectSearchPaging_MouseUp(object sender, MouseEventArgs e)
    {
      if ( PreviousSeachPagingPosition != SelectSearchPaging.Value )
        RenderSearch();
      PreviousSeachPagingPosition = -1;
    }

    private void ActionImportConcordances_Click(object sender, EventArgs e)
    {
      new ImportStrongForm().ShowDialog();
    }

    private void EditDbTextBox_Enter(object sender, EventArgs e)
    {
      var control = (Control)sender;
      control.BackColor = Color.Ivory;
    }

    private void EditDbTextBox_Leave(object sender, EventArgs e)
    {
      var control = (Control)sender;
      control.BackColor = Color.LightYellow;
    }

    private void EditBookTranslation_TextChanged(object sender, EventArgs e)
    {
      if ( IsComboBoxChanging ) return;
      CurrentReference.Book.Translation = EditBookTranslation.Text;
      ActionSave.Enabled = true;
    }

    private void EditChapterTitle_TextChanged(object sender, EventArgs e)
    {
      if ( IsComboBoxChanging ) return;
      CurrentReference.Chapter.Title = EditChapterTitle.Text;
      ActionSave.Enabled = true;
    }

    private void EditChapterMemo_TextChanged(object sender, EventArgs e)
    {
      if ( IsComboBoxChanging ) return;
      CurrentReference.Chapter.Memo = EditChapterMemo.Text;
      ActionSave.Enabled = true;
    }

    private void ActionEditBookMemo_Click(object sender, EventArgs e)
    {
      var form = new EditMemoForm();
      form.Text += ( (BookItem)SelectBook.SelectedItem ).Book.Name;
      form.TextBox.Text = CurrentReference.Book.Memo;
      form.TextBox.SelectionStart = 0;
      if ( form.ShowDialog() == DialogResult.OK )
      {
        CurrentReference.Book.Memo = form.TextBox.Text;
        ActionSave.PerformClick();
      }
    }

    private void ActionEditChapterMemo_Click(object sender, EventArgs e)
    {
      var form = new EditMemoForm();
      form.Text += ( (BookItem)SelectBook.SelectedItem ).Book.Name
                 + " " + AppTranslations.BookChapterTitle.GetLang().ToLower()
                 + " " + ( (ChapterItem)SelectChapter.SelectedItem ).Chapter.Number;
      form.TextBox.Text = CurrentReference.Chapter.Memo;
      form.TextBox.SelectionStart = 0;
      if ( form.ShowDialog() == DialogResult.OK )
      {
        EditChapterMemo.Text = form.TextBox.Text;
        ActionSave.PerformClick();
      }
    }

    /*private WordControl GetWordControl(object sender)
    {
      WordControl control = null;
      if ( sender is ToolStripMenuItem )
        control = (WordControl)( (ContextMenuStrip)( (ToolStripMenuItem)sender ).GetCurrentParent() ).SourceControl.Parent;
      else
      if ( sender is ContextMenuStrip )
      {
        control = (WordControl)( (ContextMenuStrip)sender ).SourceControl;
      }
      else
      if ( sender is WordControl )
        control = (WordControl)sender;
      else
        ;
      return control;
    }*/

    private void ActionCopyWordTranslation_Click(object sender, EventArgs e)
    {
      Clipboard.SetText(CurrentReference.Word.Translation);
    }

    private void ActionCopyUnicodeChars_Click(object sender, EventArgs e)
    {
      Clipboard.SetText(CurrentReference.Word.Original);
    }

    private void ActionCopyFontChars_Click(object sender, EventArgs e)
    {
      Clipboard.SetText(CurrentReference.Word.Hebrew);
    }

    private void ActionSearchTranslated_Click(object sender, EventArgs e)
    {
      if ( ActiveControl is WordControl )
        SearchTranslatedForm.Run((WordControl)ActiveControl);
    }

    private void ActionSearchWordInDatabase_Click(object sender, EventArgs e)
    {
      SearchHebrewWord(CurrentReference.Word.Hebrew);
    }

    private void ActionSearchOnline_Click(object sender, EventArgs e)
    {
      if ( !( ActiveControl is WordControl ) ) return;
      Program.OpenOnlineConcordance(( (WordControl)ActiveControl ).Reference.Word.Original);
    }

    private void GoToBookmark(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      if ( Program.Settings.CurrentView == ViewMode.ELS50
        || Program.Settings.CurrentView == ViewMode.Search )
        SetView(ViewMode.Verses);
      GoTo((ReferenceItem)( (ToolStripMenuItem)sender ).Tag);
    }

    private void CalculateSumValueOfTorahLetters(object sender, EventArgs e)
    {
      long value = 0;
      var books = from book in DataSet.Books
                  where book.Number <= BooksBounds.Torah.Max
                  select book;
      foreach ( Data.DataSet.BooksRow book in books )
        foreach ( Data.DataSet.ChaptersRow chapter in book.GetChaptersRows() )
          foreach ( Data.DataSet.VersesRow verse in chapter.GetVersesRows() )
            foreach ( Data.DataSet.WordsRow word in verse.GetWordsRows() )
              foreach ( char letter in word.Hebrew )
              {
                int index = Array.IndexOf(HebrewAlphabet.Codes, HebrewAlphabet.SetFinal(letter.ToString(), false));
                if ( index == -1 ) { }
                value += HebrewAlphabet.ValuesSimple[index];
              }
      DisplayManager.Show(value.ToString());
    }

    private void ActionOpenShorashim_Click(object sender, EventArgs e)
    {

    }
  }

}
