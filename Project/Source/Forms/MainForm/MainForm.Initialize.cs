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
/// <edited> 2022-03 </edited>
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
  [SuppressMessage("Design", "GCop179:Do not hardcode numbers, strings or other values. Use constant fields, enums, config files or database as appropriate.", Justification = "<En attente>")]
  private void DoConstructor()
  {
    Interlocks.Take();
    new Task(InitializeIconsAndSound).Start();
    new Task(InitializeDialogsDirectory).Start();
    new Task(() => BookmarkItems = new Bookmarks(Program.BookmarksFilePath)).Start();
    new Task(() => HistoryItems = new History(Program.HistoryFilePath)).Start();
    SystemManager.TryCatch(() => Icon = new Icon(Globals.ApplicationIconFilePath));
    Text = Globals.AssemblyTitle;
    ToolStrip.Renderer = new CheckedButtonsToolStripRenderer();
    CurrentReference = new ReferenceItem(null, null, null, null);
    ActionGoToBookmarkMain.Click += GoToBookmark;
    SystemEvents.SessionEnding += SessionEnding;
    EditELS50HScrollBar.Minimum = -100;
    EditELS50HScrollBar.Maximum = 0;
    EditELS50HScrollBar.LargeChange = 20;
    EditELS50HScrollBar.SmallChange = 10;
    EditSearchWord.ContextMenuDetailsVisible = false;
    NativeMethods.ClipboardViewerNext = NativeMethods.SetClipboardViewer(Handle);
    HebrewGlobals.GetHebrewLettersExePath = () => Settings.HebrewLettersExe;
    InitializeTheme();
    if ( !ApplicationCommandLine.Instance.IsPreviewEnabled ) // TODO remove when ready
    {
      ActionNormalizeTexts.Visible = false;
      SeparatorActionNormalizeTexts.Visible = false;
    }
  }

  /// <summary>
  /// Does Form Load event.
  /// </summary>
  private void DoFormLoad(object sender, EventArgs e)
  {
    if ( Globals.IsExiting ) return;
    Settings.Retrieve();
    EditSearchWord.HebrewCharsInBold = Settings.LettersControlHebrewCharsInBold;
    PreviousWindowsState = WindowState; // TODO move in settings helper and update calendar & letters
    Program.UpdateLocalization();
    StatisticsForm.Run(true, Settings.UsageStatisticsEnabled);
    Globals.ChronoStartingApp.Stop();
    var lastdone = Settings.CheckUpdateLastDone;
    bool exit = WebCheckUpdate.Run(ref lastdone,
                                   Settings.CheckUpdateAtStartupDaysInterval,
                                   Settings.CheckUpdateAtStartup,
                                   true);
    Settings.CheckUpdateLastDone = lastdone;
    if ( exit )
    {
      SystemManager.Exit();
      return;
    }
    Globals.ChronoStartingApp.Start();
    MainForm_ResizeEnd(null, null);
    UpdateSearchButtons();
    BookmarkMenuIndex = ActionBookmarks.DropDownItems.Count;
    HistoryIndexMenu = ActionHistory.DropDownItems.Count;
    EditSearchWord.ActionClear.Visible = false;
    EditSearchWord.PanelSeparatorActionClear.Visible = false;
    DebugManager.TraceEnabledChanged += value => CommonMenusControl.Instance.ActionViewLog.Enabled = value;
  }

  /// <summary>
  /// Does Form Shown event.
  /// </summary>
  [SuppressMessage("Design", "GCop179:Do not hardcode numbers, strings or other values. Use constant fields, enums, config files or database as appropriate.", Justification = "<En attente>")]
  private void DoFormShown(object sender, EventArgs e)
  {
    if ( Globals.IsExiting ) return;
    this.InitDropDowns();
    Refresh();
    DoBackupDB();
    LoadData();
    TimerAutoSave.Enabled = Settings.AutoSaveDelay != 0;
    if ( TimerAutoSave.Enabled )
      TimerAutoSave.Interval = Settings.AutoSaveDelay * Globals.MilliSecondsInOneMinute;
    Globals.IsReady = true;
    int height = TextRenderer.MeasureText("A", SelectBook.Font).Height;
    SelectBook.DropDownHeight = Math.Min(600, height * ( SelectBook.Items.Count + 1 ));
    SelectVerse.DropDownWidth = Math.Max(SelectVerse.DropDownWidth, ActionEditChapterMemo.Right - SelectVerse.Left + 5);
    FilterModified = new()
    {
      { EditFilterBook, false },
      { EditFilterChapter, false },
      { EditFilterVerse, false },
    };
    Globals.NoticeKeyboardShortcutsForm = new ShowTextForm(AppTranslations.NoticeKeyboardShortcutsTitle,
                                                           AppTranslations.NoticeKeyboardShortcuts,
                                                           true, false,
                                                           MessageBoxEx.DefaultHeightBig,
                                                           MessageBoxEx.DefaultHeightHuge,
                                                           false, false);
    Globals.NoticeKeyboardShortcutsForm.TextBox.BackColor = Globals.NoticeKeyboardShortcutsForm.BackColor;
    Globals.NoticeKeyboardShortcutsForm.TextBox.BorderStyle = BorderStyle.None;
    Globals.NoticeKeyboardShortcutsForm.Padding = new Padding(20, 20, 10, 10);
    Globals.ChronoStartingApp.Stop();
    Settings.BenchmarkStartingApp = Globals.ChronoStartingApp.ElapsedMilliseconds;
    SystemManager.TryCatch(Settings.Save);
    SystemManager.TryCatchManage(ProcessNewsAndCommandLine);
    ApplicationDatabase.Instance.Modified += (_, _) => ActionSave.Enabled = true;
    ApplicationDatabase.Instance.Saved += _ => ActionSave.Enabled = false;
    PanelTitleInner.Controls.OfType<Label>().ForEach(label => label.Visible = true);
    Settings.SetFirstAndUpgradeFlagsOff();
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
    bool auto = false;
    if ( SystemManager.CommandLineOptions is not null )
      try
      {
        var options = ApplicationCommandLine.Instance;
        if ( !string.IsNullOrEmpty(options.ReferenceToGo) )
        {
          auto = true;
          GoToReference(options.ReferenceToGo);
        }
        else
        if ( !string.IsNullOrEmpty(options.SearchWord) )
        {
          auto = true;
          DoStartGoToReference();
          var word = HebrewAlphabet.ContainsUnicode(options.SearchWord)
                     ? HebrewAlphabet.ToHebrewFont(options.SearchWord)
                     : HebrewAlphabet.OnlyHebrewFont(options.SearchWord);
          SearchHebrewWord(word);
        }
        else
        if ( !string.IsNullOrEmpty(options.SearchTranslated) )
        {
          auto = true;
          DoStartGoToReference();
          SearchTranslatedWord(options.SearchTranslated);
        }
      }
      catch
      {
      }
    if ( !auto ) DoStartGoToReference();
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
    Globals.IsExiting = true;
    Globals.IsSessionEnding = true;
    Globals.AllowClose = true;
    if ( !Settings.RenderAllChapterVersesKeep && Settings.RenderAllChapterVerses )
      Settings.RenderAllChapterVerses = false;
    Settings.Store();
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
  [SuppressMessage("Naming", "GCop204:Rename the variable '{0}' to something clear and meaningful.", Justification = "N/A")]
  protected override void WndProc(ref Message m)
  {
    switch ( m.Msg )
    {
      case NativeMethods.WM_QUERYENDSESSION:
        SessionEnding(this, null);
        break;
      case NativeMethods.WM_DRAWCLIPBOARD:
        EditSearchWord.CheckClipboardContentType();
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
    string directoryBackup = Settings.GetBackupDirectory();
    string directoryExport = Settings.GetExportDirectory();
    OpenFileDialogDB.InitialDirectory = directoryBackup;
    SaveFileDialogDB.InitialDirectory = directoryBackup;
    SaveFileDialogMSWord.InitialDirectory = directoryExport;
    SaveFileDialogRTF.InitialDirectory = directoryExport;
    SaveDataBoardDialog.InitialDirectory = directoryExport;
    SaveDataBoardDialog.Filter = Program.BoardExportTargets.CreateFilters();
  }

  /// <summary>
  /// Initializes icons
  /// </summary>
  private void InitializeIconsAndSound()
  {
    SoundItem.Initialize();
    SystemManager.TryCatch(() => DisplayManager.DoSound(Globals.EmptySoundFilePath));
    SystemManager.TryCatch(() => MediaMixer.SetApplicationVolume(Globals.ProcessId, Settings.ApplicationVolume));
  }

  /// <summary>
  /// Sets colors.
  /// </summary>
  internal void InitializeTheme()
  {
    // Navigator items
    EditBookTranslation.BackColor = Settings.ThemeNavigatorItems;
    EditChapterTitle.BackColor = Settings.ThemeNavigatorItems;
    EditELS50Single.BackColor = Settings.ThemeNavigatorItems;
    EditChapterMemo.BackColor = Settings.ThemeNavigatorItems;
    // Letters control
    EditSearchWord.LettersBackColor = Settings.ThemeSearchLettersBack;
    EditSearchWord.InputBackColor = Settings.ThemeSearchWordBack;
    EditSearchTranslation.BackColor = Settings.ThemeSearchWordBack;
  }

}
