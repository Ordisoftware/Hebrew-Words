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

using Microsoft.Win32;

/// <summary>
/// Provides application's main form.
/// </summary>
/// <seealso cref="T:System.Windows.Forms.Form"/>
partial class MainForm : Form
{

  /// <summary>
  /// Does constructor
  /// </summary>
  private void DoConstructor()
  {
    Interlocks.Take();
    new Task(InitializeIconsAndSound).Start();
    new Task(InitializeDialogsDirectory).Start();
    SystemManager.TryCatch(() => Icon = new Icon(Globals.ApplicationIconFilePath));
    Text = Globals.AssemblyTitle;
    ToolStrip.Renderer = new CheckedButtonsToolStripRenderer();
    SystemEvents.SessionEnding += SessionEnding;
    CurrentReference = new ReferenceItem(null, null, null, null);
  }

  /// <summary>
  /// Does Form Load event.
  /// </summary>
  private void DoFormLoad(object sender, EventArgs e)
  {
    if ( Globals.IsExiting ) return;
    Settings.Retrieve();
    Program.UpdateLocalization();
    StatisticsForm.Run(true, Settings.UsageStatisticsEnabled);
    Globals.ChronoStartingApp.Stop();
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
    Globals.ChronoStartingApp.Start();
    UpdateSearchButtons();
    BookmarksMenuFirstIndex = ActionBookmarks.DropDownItems.Count;
    DebugManager.TraceEnabledChanged += value => CommonMenusControl.Instance.ActionViewLog.Enabled = value;
  }

  /// <summary>
  /// Does Form Shown event.
  /// </summary>
  private void DoFormShown(object sender, EventArgs e)
  {
    if ( Globals.IsExiting ) return;
    Refresh();
    this.InitDropDowns();
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
          auto = true;
          GoTo(options.ReferenceToGo);
        }
        else
        if ( !string.IsNullOrEmpty(options.SearchWord) )
        {
          auto = true;
          DoStartGoTo();
          // TODO recup code Letters
          SearchHebrewWord(HebrewAlphabet.ToHebrewFont(options.SearchWord));
        }
        else
        if ( !string.IsNullOrEmpty(options.SearchTranslated) )
        {
          auto = true;
          DoStartGoTo();
          SearchTranslatedWord(options.SearchTranslated);
        }
      }
      catch
      {
      }
    if ( !auto ) DoStartGoTo();
    ActionSave.PerformClick();
    FilterModified = new()
    {
      { EditFilterBook, false },
      { EditFilterChapter, false },
      { EditFilterVerse, false },
    };
    Globals.NoticeKeyboardShortcutsForm = new ShowTextForm(AppTranslations.NoticeKeyboardShortcutsTitle,
                                                           AppTranslations.NoticeKeyboardShortcuts,
                                                           true, false, 340, 450, false, false);
    Globals.NoticeKeyboardShortcutsForm.TextBox.BackColor = Globals.NoticeKeyboardShortcutsForm.BackColor;
    Globals.NoticeKeyboardShortcutsForm.TextBox.BorderStyle = BorderStyle.None;
    Globals.NoticeKeyboardShortcutsForm.Padding = new Padding(20, 20, 10, 10);
    Globals.ChronoStartingApp.Stop();
    Settings.BenchmarkStartingApp = Globals.ChronoStartingApp.ElapsedMilliseconds;
    SystemManager.TryCatch(Settings.Save);
    SystemManager.TryCatchManage(ProcessNewsAndCommandLine);
    ApplicationDatabase.Instance.Modified += (_, _) => ActionSave.Enabled = true;
    ApplicationDatabase.Instance.Saved += _ => ActionSave.Enabled = false;
    SelectRenderAllVersesKeep.Enabled = SelectRenderAllVerses.Checked;
  }

  private void DoStartGoTo()
  {
    if ( Settings.GoToMasterBookmarkAtStartup )
      GoTo(Settings.BookmarkMasterBook,
           Settings.BookmarkMasterChapter,
           Settings.BookmarkMasterVerse,
           true);
    else
      GoTo(1, 1, 1, true);
  }

  /// <summary>
  /// Shows news and process command line options.
  /// </summary>
  private void ProcessNewsAndCommandLine()
  {
    if ( Globals.IsSettingsUpgraded && Settings.ShowLastNewInVersionAfterUpdate )
    {
      SystemManager.TryCatch(CommonMenusControl.Instance.ShowLastNews);
      Application.DoEvents();
      Thread.Sleep(500);
    }
    // COmmand lines actions here
  }

  /// <summary>
  /// Does Form Closing event.
  /// </summary>
  private void DoFormClosing(object sender, FormClosingEventArgs e)
  {
    if ( !Globals.IsReady ) return;
    if ( Globals.IsExiting ) return;
    ActionSave.PerformClick();
    if ( e.CloseReason != CloseReason.None && e.CloseReason != CloseReason.UserClosing )
      Globals.IsExiting = true;
    else
    if ( EditConfirmClosing.Checked && !Globals.IsSessionEnding )
      if ( !DisplayManager.QueryYesNo(SysTranslations.AskToExitApplication.GetLang()) )
        e.Cancel = true;
      else
        Globals.IsExiting = true;
  }

  /// <summary>
  /// Does Form Closed event.
  /// </summary>
  private void DoFormClosed(object sender, FormClosedEventArgs e)
  {
    DebugManager.Trace(LogTraceEvent.Data, e.CloseReason.ToStringFull());
    if ( !Settings.RenderAllChapterVersesKeep && Settings.RenderAllChapterVerses )
      Settings.RenderAllChapterVerses = false;
    Globals.IsExiting = true;
    Globals.IsSessionEnding = true;
    Globals.AllowClose = true;
    SystemManager.TryCatch(Settings.Store);
    Interlocks.Release();
    TimerTooltip.Stop();
    FormsHelper.CloseAll();
  }

  /// <summary>
  /// Does Session Ending event.
  /// </summary>
  private void SessionEnding(object sender, SessionEndingEventArgs e)
  {
    if ( Globals.IsExiting || Globals.IsSessionEnding ) return;
    DebugManager.Enter();
    try
    {
      DebugManager.Trace(LogTraceEvent.Data, e?.Reason.ToStringFull() ?? nameof(NativeMethods.WM_QUERYENDSESSION));
      Close();
    }
    finally
    {
      DebugManager.Leave();
    }
  }

  /// <summary>
  /// WndProc override.
  /// </summary>
  protected override void WndProc(ref Message m)
  {
    switch ( m.Msg )
    {
      case NativeMethods.WM_QUERYENDSESSION:
        SessionEnding(this, null);
        break;
      default:
        base.WndProc(ref m);
        break;
    }
  }

  /// <summary>
  /// Sets the initial directories of dialog boxes.
  /// </summary>
  public void InitializeDialogsDirectory()
  {
    OpenFileDialogDB.InitialDirectory = Settings.GetBackupDirectory();
    SaveFileDialogDB.InitialDirectory = Settings.GetBackupDirectory();
    SaveFileDialogMSWord.InitialDirectory = Settings.GetExportDirectory();
    SaveFileDialogRTF.InitialDirectory = Settings.GetExportDirectory();
  }

  /// <summary>
  /// Initializes icons
  /// </summary>
  private void InitializeIconsAndSound()
  {
    SoundItem.Initialize();
    SystemManager.TryCatch(() => new SoundPlayer(Globals.EmptySoundFilePath).Play());
    SystemManager.TryCatch(() => MediaMixer.SetApplicationVolume(Globals.ProcessId, Settings.ApplicationVolume));
  }

}
