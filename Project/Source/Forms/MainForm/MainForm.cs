/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2023 Olivier Rogier.
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

using Equin.ApplicationFramework;

// TODO refactor duplicate code for context menus items

/// <summary>
/// Provides application's main form.
/// </summary>
/// <seealso cref="T:System.Windows.Forms.Form"/>
sealed partial class MainForm : Form
{

  #region Singleton

  /// <summary>
  /// Indicates the singleton instance.
  /// </summary>
  static internal MainForm Instance { get; private set; }

  /// <summary>
  /// Static constructor.
  /// </summary>
  static MainForm()
  {
    Instance = new MainForm();
  }

  #endregion

  #region Form Management

  /// <summary>
  /// Default constructor.
  /// </summary>
  private MainForm()
  {
    InitializeComponent();
    DoConstructor();
  }

  /// <summary>
  /// Event handler. Called by MainForm for load events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void MainForm_Load(object sender, EventArgs e)
  {
    DoFormLoad(sender, e);
  }

  /// <summary>
  /// Event handler. Called by MainForm for shown events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void MainForm_Shown(object sender, EventArgs e)
  {
    DoFormShown(sender, e);
  }

  /// <summary>
  /// Event handler. Called by MainForm for form closing events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
  {
    DoFormClosing(sender, e);
  }

  /// <summary>
  /// Event handler. Called by MainForm for form closed events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
  {
    DoFormClosed(sender, e);
  }

  /// <summary>
  /// Event handler. Called by MainForm for resize events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void MainForm_Resize(object sender, EventArgs e)
  {
    MainMenuSeparatorLeftButtons.Visible = Width < MinimumSize.Width + 50;
  }

  private bool PreviousWindowsStateToggle = true;
  private FormWindowState PreviousWindowsState;

  /// <summary>
  /// Event handler. Called by MainForm for windows changed events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  [SuppressMessage("Design", "GCop179:Do not hardcode numbers, strings or other values. Use constant fields, enums, config files or database as appropriate.", Justification = "<En attente>")]
  private void MainForm_WindowsChanged(object sender, EventArgs e)
  {
    if ( !Visible ) return;
    if ( !Globals.IsReady ) return;
    if ( Globals.IsExiting ) return;
    if ( PreviousWindowsStateToggle )
    {
      PreviousWindowsStateToggle = false;
      return;
    }
    if ( WindowState == FormWindowState.Normal )
    {
      SelectVerse.DropDownWidth = Math.Max(ActionEditChapterMemo.Right - SelectVerse.Left + 5, 350);
      if ( PreviousWindowsState != WindowState )
        if ( !SelectRenderAllVerses.Checked )
          ActionRefresh.PerformClick();
      if ( PreviousWindowsState == FormWindowState.Normal )
        EditScreenNone.PerformClick();
    }
    else
    if ( WindowState == FormWindowState.Maximized )
    {
      if ( PreviousWindowsState != WindowState )
        if ( !SelectRenderAllVerses.Checked )
        {
          SelectVerse.DropDownWidth = Math.Max(ActionEditChapterMemo.Right - SelectVerse.Left + 5, 350);
          ActionRefresh.PerformClick();
        }
    }
    PreviousWindowsState = WindowState;
    PreviousWindowsStateToggle = true;
  }

  private int ResizeBeginWidth;

  private void MainForm_ResizeBegin(object sender, EventArgs e)
  {
    ResizeBeginWidth = ClientSize.Width;
  }

  private void MainForm_ResizeEnd(object sender, EventArgs e)
  {
    if ( !SelectRenderAllVerses.Checked && ResizeBeginWidth != ClientSize.Width )
    {
      SelectVerse.DropDownWidth = EditVerseTitle.Width;
      ActionRefresh.PerformClick();
    }
  }

  /// <summary>
  /// Set form disabled or enabled.
  /// </summary>
  public void SetFormDisabled(bool disabled)
  {
    Cursor = disabled ? Cursors.WaitCursor : Cursors.Default;
    ToolStrip.Enabled = !disabled;
    PanelNavigation.Enabled = !disabled;
    EditChapterMemo.Multiline = !disabled;
    PanelMainCenter.Enabled = !disabled;
    Refresh();
  }

  #endregion

  #region Top Menu Tool-Tips

  /// <summary>
  /// Event handler. Called by TimerTooltip for tick events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void TimerTooltip_Tick(object sender, EventArgs e)
  {
    if ( !EditShowTips.Checked ) return;
    var item = (ToolStripItem)LastToolTip.Tag;
    var location = new Point(item.Bounds.Left, item.Bounds.Top + ActionExit.Height + 5);
    LastToolTip.Tag = sender;
    LastToolTip.Show(item.ToolTipText, ToolStrip, location, Globals.ToolTipDelay);
    TimerTooltip.Enabled = false;
  }

  /// <summary>
  /// Event handler. Called by ShowToolTip for on mouse enter events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ShowToolTip_OnMouseEnter(object sender, EventArgs e)
  {
    if ( !EditShowTips.Checked ) return;
    if ( sender is not ToolStripItem ) return;
    if ( LastToolTip.Tag == sender ) return;
    LastToolTip.Tag = sender;
    if ( ( (ToolStripItem)sender ).ToolTipText.Length == 0 ) return;
    TimerTooltip.Enabled = true;
  }

  /// <summary>
  /// Event handler. Called by ShowToolTip for on mouse leave events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ShowToolTip_OnMouseLeave(object sender, EventArgs e)
  {
    if ( !EditShowTips.Checked ) return;
    TimerTooltip.Enabled = false;
    LastToolTip.Tag = null;
    LastToolTip.Hide(ToolStrip);
  }

  #endregion

  #region Menu System

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
  /// Event handler. Called by ActionExit for mouse up events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionExit_MouseUp(object sender, MouseEventArgs e)
  {
    if ( e.Button == MouseButtons.Right )
      Close();
  }

  /// <summary>
  /// Event handler. Called by ActionPreferences for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  internal void ActionPreferences_Click(object sender, EventArgs e)
  {
    ActionSave.PerformClick();
    Settings.Store();
    bool refresh = PreferencesForm.Run(sender is int index ? index : -1);
    UpdateBookmarks();
    UpdateHistory();
    InitializeSpecialMenus();
    InitializeDialogsDirectory();
    if ( refresh )
      try
      {
        Cursor = Cursors.WaitCursor;
        var reference = Instance.CurrentReference;
        BooksBindingSource.ResetBindings(false);
        ChaptersBindingSource.ResetBindings(false);
        VersesBindingSource.ResetBindings(false);
        WordsBindingSource.ResetBindings(false);
        FilterBooksBindingSource.ResetBindings(false);
        FilterChaptersBindingSource.ResetBindings(false);
        FilterVersesBindingSource.ResetBindings(false);
        CreateFilterDataSource();
        SelectSearchInBook.DataSource = new BindingList<BookRow>(ApplicationDatabase.Instance.Books);
        UpdateCurrentReference();
        RenderAll(true);
        VerseControl.ResetMetricsRequired = true;
        WordControl.ResetMetricsRequired = true;
        int book = reference.Book?.Number ?? 1;
        int chapter = reference.Chapter?.Number ?? 1;
        int verse = reference.Verse?.Number ?? 1;
        int word = reference.Verse?.Number ?? 1;
        GoToReference(new ReferenceItem(book, chapter, verse, word), true);
      }
      finally
      {
        Cursor = Cursors.Default;
      }
  }

  #endregion

  #region Menu Settings

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
  /// Event handler. Called by EditScreenPosition for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  public void EditScreenPosition_Click(object sender, EventArgs e)
  {
    DoScreenPosition(sender, e);
  }

  /// <summary>
  /// Event handler. Called by ActionShowKeyboardNotice for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionShowKeyboardNotice_Click(object sender, EventArgs e)
  {
    Globals.KeyboardShortcutsNotice?.Popup();
  }

  /// <summary>
  /// Event handler. Called by EditDialogBoxesSettings for checked changed events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  public void EditDialogBoxesSettings_CheckedChanged(object sender, EventArgs e)
  {
    Settings.SoundsEnabled = EditSoundsEnabled.Checked;
    DisplayManager.AdvancedFormUseSounds = EditSoundsEnabled.Checked;
    DisplayManager.FormStyle = EditUseAdvancedDialogBoxes.Checked
      ? MessageBoxFormStyle.Advanced
      : MessageBoxFormStyle.System;
    DisplayManager.IconStyle = DisplayManager.FormStyle switch
    {
      MessageBoxFormStyle.System => EditSoundsEnabled.Checked
        ? MessageBoxIconStyle.ForceInformation
        : MessageBoxIconStyle.ForceNone,
      MessageBoxFormStyle.Advanced => MessageBoxIconStyle.ForceInformation,
      _ => throw new AdvNotImplementedException(DisplayManager.FormStyle),
    };
  }

  /// <summary>
  /// Event handler. Called by EditShowSuccessDialogs for checked changed events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void EditShowSuccessDialogs_CheckedChanged(object sender, EventArgs e)
  {
    Settings.ShowSuccessDialogs = EditShowSuccessDialogs.Checked;
    DisplayManager.ShowSuccessDialogs = EditShowSuccessDialogs.Checked;
  }

  private void EditChapterTranslationOption_Click(object sender, EventArgs e)
  {
    ActionRefresh.PerformClick();
  }

  #endregion

  #region Menu Information

  /// <summary>
  /// Event handler. Called by ActionWebCheckUpdate for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  public void ActionWebCheckUpdate_Click(object sender, EventArgs e)
  {
    var lastdone = Settings.CheckUpdateLastDone;
    bool exit = WebCheckUpdate.Run(ref lastdone,
                                   Settings.CheckUpdateAtStartupDaysInterval,
                                   e is null,
                                   Settings.CheckUpdateAtStartup);
    Settings.CheckUpdateLastDone = lastdone;
    if ( exit )
    {
      Globals.AllowClose = true;
      Close();
    }
  }

  /// <summary>
  /// Event handler. Called by ActionViewLog for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  public void ActionViewLog_Click(object sender, EventArgs e)
  {
    DebugManager.TraceForm.Popup();
  }

  /// <summary>
  /// Event handler. Called by ActionViewStats for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  public void ActionViewStats_Click(object sender, EventArgs e)
  {
    StatisticsForm.Run();
  }

  #endregion

  #region Menu Tools

  /// <summary>
  /// Event handler. Called by ActionShowBooksBoard for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionShowBooksBoard_Click(object sender, EventArgs e)
  {
    ActionSave.PerformClick();
    using var form = new EditBooksForm();
    form.ShowDialog();
    GoToReference(CurrentReference);
    ActionSave.PerformClick();
  }

  /// <summary>
  /// Event handler. Called by ActionShowParashotBoard for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionShowParashotBoard_Click(object sender, EventArgs e)
  {
    ParashotForm.Run();
  }

  /// <summary>
  /// Event handler. Called by ActionShowCelebrationVersesBoard for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionShowCelebrationVersesBoard_Click(object sender, EventArgs e)
  {
    CelebrationVersesBoardForm.Run(TorahCelebration.Pessah,
                                   nameof(Settings.CelebrationVersesBoardFormLocation),
                                   nameof(Settings.CelebrationVersesBoardFormClientSize),
                                   string.Empty,
                                   true,
                                   null); // TODO create setting
  }

  /// <summary>
  /// Event handler. Called by ActionShowTranscriptionGuide for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionShowTranscriptionGuide_Click(object sender, EventArgs e)
  {
    Program.TranscriptionGuideForm.Popup();
  }

  /// <summary>
  /// Event handler. Called by ActionShowGrammarGuide for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionShowGrammarGuide_Click(object sender, EventArgs e)
  {
    Program.GrammarGuideForm.Popup();
  }

  /// <summary>
  /// Event handler. Called by ActionOpenCalculator for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionOpenCalculator_Click(object sender, EventArgs e)
  {
    SystemManager.RunShell(Settings.CalculatorExe);
  }

  /// <summary>
  /// Event handler. Called by ActionViewBibleStatistics for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionViewBibleStatistics_Click(object sender, EventArgs e)
  {
    ActionSave.PerformClick();
    BibleStatisticsForm.Run();
  }

  #endregion

  #region Menu Application View

  /// <summary>
  /// Event handler. Called by ActionViewVerses for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionViewVerses_Click(object sender, EventArgs e)
  {
    SetView(ViewMode.ChapterVerses);
  }

  /// <summary>
  /// Event handler. Called by ActionViewFilters for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionViewFilters_Click(object sender, EventArgs e)
  {
    SetView(ViewMode.VerseFiltered);
  }

  /// <summary>
  /// Event handler. Called by ActionViewTranslations for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionViewTranslations_Click(object sender, EventArgs e)
  {
    SetView(ViewMode.ChapterTranslation);
  }

  /// <summary>
  /// Event handler. Called by ActionViewSearch for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionViewSearch_Click(object sender, EventArgs e)
  {
    SetView(ViewMode.Search);
  }

  /// <summary>
  /// Event handler. Called by ActionViewRawText for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionViewRawText_Click(object sender, EventArgs e)
  {
    SetView(ViewMode.ChapterOriginal);
  }

  /// <summary>
  /// Event handler. Called by ActionViewELS50 for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionViewELS50_Click(object sender, EventArgs e)
  {
    SetView(ViewMode.BookELS50);
  }

  /// <summary>
  /// Event handler. Called by SelectSearchType for selected events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void SelectSearchType_Selected(object sender, TabControlEventArgs e)
  {
    Settings.CurrentSearchTypeTab = SelectSearchType.SelectedIndex;
    if ( SelectSearchType.SelectedTab == SelectSearchTypeHebrew )
    {
      ActiveControl = EditSearchWord;
      EditSearchWord.Focus();
    }
    else
    if ( SelectSearchType.SelectedTab == SelectSearchTypeTranslation )
    {
      ActiveControl = EditSearchTranslation;
      EditSearchTranslation.Focus();
    }
    UpdateSearchButtons();
  }

  #endregion

  #region Menu Application Actions

  /// <summary>
  /// Event handler. Called by ActionGoToVerse for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionGoToVerse_Click(object sender, EventArgs e)
  {
    ActionSave.PerformClick();
    var reference = SelectReferenceForm.Run();
    if ( reference is null ) return;
    if ( IsSearchOrFilteredOrELS50(Settings.CurrentView) )
      SetView(ViewMode.ChapterVerses);
    GoToReference(reference, true);
  }

  /// <summary>
  /// Event handler. Called by ActionViewVersesByDateUpdated for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionViewVersesByDateUpdated_Click(object sender, EventArgs e)
  {
    var reference = SelectVersesByDateUpdatedForm.Run();
    if ( reference is null ) return;
    if ( IsSearchOrFilteredOrELS50(Settings.CurrentView) )
      SetView(ViewMode.ChapterVerses);
    GoToReference(reference, true);
  }

  /// <summary>
  /// Event handler. Called by ActionRefresh for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionRefresh_Click(object sender, EventArgs e)
  {
    if ( !Globals.IsReady ) return;
    if ( Globals.IsExiting ) return;
    ActionRefresh.Visible = false;
    ActionRefresh.Visible = true;
    ActionSave.PerformClick();
    VerseControl.ResetMetricsRequired = true;
    WordControl.ResetMetricsRequired = true;
    int book = CurrentReference?.Book?.Number ?? 1;
    int chapter = CurrentReference?.Chapter?.Number ?? 1;
    int verse = CurrentReference?.Verse?.Number ?? 1;
    int word = CurrentReference?.Verse?.Number ?? 1;
    GoToReference(new ReferenceItem(book, chapter, verse, word), true);
  }

  /// <summary>
  /// Event handler. Called by ActionCloseTranslatedWindows for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  [SuppressMessage("Performance", "U2U1203:Use foreach efficiently", Justification = "Collection is modified")]
  private void ActionCloseTranslatedWindows_Click(object sender, EventArgs e)
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
      case ViewMode.ChapterTranslation:
        Clipboard.SetText(GetChapterTranslationText());
        break;
      case ViewMode.ChapterOriginal:
        Clipboard.SetText(GetChapterOriginalText());
        break;
      case ViewMode.BookELS50:
        Clipboard.SetText(GetBookELS50Text());
        break;
      default:
        throw new AdvNotImplementedException(Settings.CurrentView);
    }
    DisplayManager.ShowSuccessOrSound(SysTranslations.DataCopiedToClipboard.GetLang(),
                                      Globals.ClipboardSoundFilePath);
  }

  #endregion

  #region Menu Application Database

  /// <summary>
  /// Event handler. Called by ActionNew for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionNew_Click(object sender, EventArgs e)
  {
    ActionSave.PerformClick();
    if ( DisplayManager.QueryYesNo(AppTranslations.AskToBackupDatabaseBeforeReplace.GetLang()) )
      ActionDatabaseBackup.PerformClick();
    if ( !DisplayManager.QueryYesNo(AppTranslations.AskToCreateNewDatabase.GetLang()) )
      return;
    ReLoadData(() => File.Delete(Path.Combine(Globals.UserDataFolderPath, Globals.ApplicationDatabaseFileName)));
  }

  /// <summary>
  /// Event handler. Called by ActionRestore for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionRestore_Click(object sender, EventArgs e)
  {
    ActionSave.PerformClick();
    if ( Settings.DatabaseRestoreAskToBackup )
      if ( DisplayManager.QueryYesNo(AppTranslations.AskToBackupDatabaseBeforeReplace.GetLang()) )
        ActionDatabaseBackup.PerformClick();
    if ( OpenFileDialogDB.ShowDialog() == DialogResult.Cancel )
      return;
    string fileName = Path.GetFileNameWithoutExtension(OpenFileDialogDB.FileName);
    if ( !DisplayManager.QueryYesNo(AppTranslations.AskToReplaceDatabase.GetLang(fileName)) )
      return;
    ReLoadData(() =>
    {
      File.Delete(Path.Combine(Globals.UserDataFolderPath, Globals.ApplicationDatabaseFileName));
      File.Copy(OpenFileDialogDB.FileName, Path.Combine(Globals.UserDataFolderPath, Globals.ApplicationDatabaseFileName));
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
    SaveFileDialogDB.FileName = Globals.ApplicationDatabaseFileName;
    if ( SaveFileDialogDB.ShowDialog() == DialogResult.Cancel ) return;
    if ( File.Exists(SaveFileDialogDB.FileName) ) File.Delete(SaveFileDialogDB.FileName);
    File.Copy(Path.Combine(Globals.UserDataFolderPath, Globals.ApplicationDatabaseFileName), SaveFileDialogDB.FileName);
  }

  /// <summary>
  /// Event handler. Called by ActionVacuum for tick events.
  /// </summary>
  [SuppressMessage("Usage", "GCop517:'{0}()' returns a value but doesn't change the object. It's meaningless to call it without using the returned result.", Justification = "N/A")]
  private void ActionVacuum_Click(object sender, EventArgs e)
  {
    var temp = Cursor;
    try
    {
      Cursor = Cursors.WaitCursor;
      Settings.VacuumLastDone = ApplicationDatabase.Instance
                                                   .Connection
                                                   .Optimize(Settings.VacuumLastDone,
                                                             Settings.VacuumAtStartupDaysInterval,
                                                             true);
      HebrewDatabase.Instance.Connection.Optimize(DateTime.MinValue, force: true);
      ApplicationStatistics.UpdateDBCommonFileSizeRequired = true;
      ApplicationStatistics.UpdateDBFileSizeRequired = true;
      DisplayManager.Show(SysTranslations.DatabaseVacuumSuccess.GetLang());
    }
    finally
    {
      Cursor = temp;
    }
  }

  /// <summary>
  /// Event handler. Called by ActionOpenExportFolder for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionOpenExportFolder_Click(object sender, EventArgs e)
  {
    SystemManager.RunShell(Settings.GetExportDirectory());
  }

  /// <summary>
  /// Event handler. Called by ActionOpenBackupPath for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionOpenBackupPath_Click(object sender, EventArgs e)
  {
    SystemManager.RunShell(Settings.GetBackupDirectory());
  }

  /// <summary>
  /// Event handler. Called by ActionOpenFolderDatabase for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionOpenFolderDatabase_Click(object sender, EventArgs e)
  {
    SystemManager.RunShell(Globals.DatabaseFolderPath);
  }

  /// <summary>
  /// Event handler. Called by ActionSave for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionSave_Click(object sender, EventArgs e)
  {
    if ( ApplicationDatabase.Instance.HasChanges )
      ApplicationDatabase.Instance.SaveAll();
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
  /// Event handler. Called by ActionNormalizeTexts for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionNormalizeTexts_Click(object sender, EventArgs e)
  {
    ActionSave.PerformClick();
    if ( Settings.DatabaseRestoreAskToBackup )
      if ( DisplayManager.QueryYesNo(AppTranslations.AskToBackupDatabaseBeforeReplace.GetLang()) )
        ActionDatabaseBackup.PerformClick();
    using var form = new NormalizeTextsForm();
    if ( form.ShowDialog() == DialogResult.OK )
      ApplicationDatabase.Instance.DoNormalizeTexts();
  }

  #endregion

  #region Export and Import

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
    Clipboard.SetText(EditELS50Single.Text);
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
  /// Event handler. Called by ActionVerseReadDefault for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionVerseReadDefault_Click(object sender, EventArgs e)
  {
    if ( ActiveControl is VerseControl controlVerseLabelDefault )
      HebrewTools.OpenBibleProvider(Settings.OpenVerseOnlineURL,
                                    controlVerseLabelDefault.Reference?.ToStringOnlyNumbers());
    else
    if ( Settings.CurrentView == ViewMode.Search )
      if ( sender is ToolStripMenuItem menuitem )
        if ( ( (ContextMenuStrip)menuitem.Owner ).SourceControl is LinkLabel control )
          HebrewTools.OpenBibleProvider(Settings.OpenVerseOnlineURL,
                                        ( (ReferenceItem)control.Tag )?.ToStringOnlyNumbers());
  }

  /// <summary>
  /// Event handler. Called by ActionCopyFontCharsVerse for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionCopyFontCharsVerse_Click(object sender, EventArgs e)
  {
    if ( ActiveControl is VerseControl controlVerse )
      Clipboard.SetText(controlVerse.Reference?.Verse.AsHebrew);
    else
    if ( Settings.CurrentView == ViewMode.Search )
      if ( sender is ToolStripMenuItem menuitem )
        if ( ( (ContextMenuStrip)menuitem.Owner ).SourceControl is LinkLabel control )
          Clipboard.SetText(( (ReferenceItem)control.Tag )?.Verse.AsHebrew);
  }

  /// <summary>
  /// Event handler. Called by ActionCopyUnicodeCharsVerse for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionCopyUnicodeCharsVerse_Click(object sender, EventArgs e)
  {
    if ( ActiveControl is VerseControl controlVerse )
      Clipboard.SetText(controlVerse.Reference?.Verse.AsUnicode);
    else
    if ( Settings.CurrentView == ViewMode.Search )
      if ( sender is ToolStripMenuItem menuitem )
        if ( ( (ContextMenuStrip)menuitem.Owner ).SourceControl is LinkLabel control )
          Clipboard.SetText(( (ReferenceItem)control.Tag )?.Verse.AsUnicode);
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
      Clipboard.SetText($"{reference.ToStringFull()}: {verse.Translation}");
    }
    else
    if ( control is Label label && Settings.CurrentView == ViewMode.ChapterVerses )
    {
      var reference = ( (VerseControl)label.Parent ).Reference;
      var verse = reference.Verse;
      Clipboard.SetText($"{reference.ToStringFull()}: {verse.Translation}");
    }
  }

  /// <summary>
  /// Event handler. Called by ActionCopyTranslationWithComment for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionCopyTranslationWithComment_Click(object sender, EventArgs e)
  {
    var menuitem = (ToolStripMenuItem)sender;
    var control = ( (ContextMenuStrip)menuitem.Owner ).SourceControl;
    if ( control is LinkLabel && Settings.CurrentView == ViewMode.Search )
    {
      var reference = (ReferenceItem)control.Tag;
      var verse = reference.Verse;
      // TODO refactor in verse row ?
      Clipboard.SetText($"{reference.ToStringFull()} : {verse.Translation}{Globals.NL2}{verse.Comment}");
    }
    else
    if ( control is Label label && Settings.CurrentView == ViewMode.ChapterVerses )
    {
      var reference = ( (VerseControl)label.Parent ).Reference;
      var verse = reference.Verse;
      Clipboard.SetText($"{reference.ToStringFull()} : {verse.Translation}{Globals.NL2}{verse.Comment}");
    }
  }

  /// <summary>
  /// Event handler. Called by ActionImportConsole for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionImportConsole_Click(object sender, EventArgs e)
  {
    ActionSave.PerformClick();
    var control = sender == ActionImportConsole
                  ? ActiveControl
                  : ( (ContextMenuStrip)ActionImportConsole.Owner ).SourceControl;
    ReferenceItem reference = null;
    if ( control is VerseControl versecontrol )
    {
      reference = versecontrol.Reference;
    }
    else
    if ( control is LinkLabel && Settings.CurrentView == ViewMode.Search )
    {
      reference = (ReferenceItem)control.Tag;
      reference = new ReferenceItem(reference.Book.Number,
                                    reference.Chapter.Number,
                                    reference.Verse.Number);
    }
    else
    if ( control is Label && Settings.CurrentView == ViewMode.ChapterVerses )
    {
      int index = Convert.ToInt32(control.Text) - 1;
      reference = new ReferenceItem(CurrentReference.Book.Number,
                                    CurrentReference.Chapter.Number,
                                    CurrentReference.Chapter.Verses[index].Number);
    }
    ImportVerseForm.Run(reference, sender == ActionImportConsoleAuto);
  }

  /// <summary>
  /// Event handler. Called by ActionImportConcordances for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionImportConcordances_Click(object sender, EventArgs e)
  {
    using var form = new ImportStrongForm();
    form.ShowDialog();
  }

  private void ActionTakeScreenshotWindow_Click(object sender, EventArgs e)
  {
    TextBoxBase control = null;
    int selectionStart = 0;
    int selectionLength = 0;
    // Get control
    if ( ActiveControl is VerseControl controlVerse )
    {
      if ( controlVerse.ActiveControl is WordControl wordControl )
        control = wordControl.ActiveControl as TextBoxBase;
      else
      if ( controlVerse.ActiveControl is TextBox textbox )
        control = textbox;
    }
    else
    if ( ActiveControl is RichTextBoxEx controlRichTextBoxEx )
      control = controlRichTextBoxEx;
    else
    if ( ActiveControl is TextBox controlTextBox )
      if ( controlTextBox.BackColor == ControlHelper.FocusedGeneralTextBoxColor )
        control = controlTextBox;
    // Process control
    if ( control is not null )
    {
      if ( control.BackColor == ControlHelper.FocusedControlCurrentColor )
        control.BackColor = ControlHelper.FocusedControlOriginalColor;
      else
        control = null;
      if ( control?.SelectionLength > 0 )
      {
        selectionStart = control.SelectionStart;
        selectionLength = control.SelectionLength;
        control.SelectionStart = 0;
        control.SelectionLength = 0;
      }
    }
    // Take screenshot
    using var bitmap = this.GetBitmap();
    Clipboard.SetImage(bitmap);
    DisplayManager.ShowSuccessOrSound(SysTranslations.ScreenshotDone.GetLang(),
                                      Globals.ScreenshotSoundFilePath);
    // Restore screenshot
    if ( control is not null )
    {
      control.BackColor = ControlHelper.FocusedControlCurrentColor;
      if ( selectionLength > 0 )
      {
        control.SelectionStart = selectionStart;
        control.SelectionLength = selectionLength;
      }
    }
  }

  private void ActionTakeScreenshotView_Click(object sender, EventArgs e)
  {
    bool colorRemoved = false;
    if ( ActiveControl.BackColor == ControlHelper.FocusedControlCurrentColor )
    {
      colorRemoved = true;
      ActiveControl.BackColor = ControlHelper.FocusedControlOriginalColor;
    }
    using var bitmap = PanelMain.GetBitmap();
    Clipboard.SetImage(bitmap);
    DisplayManager.ShowSuccessOrSound(SysTranslations.ScreenshotDone.GetLang(),
                                      Globals.ScreenshotSoundFilePath);
    if ( colorRemoved )
      ActiveControl.BackColor = ControlHelper.FocusedControlCurrentColor;
  }

  #endregion

  #region Menu Bookmarks and History

  /// <summary>
  /// Event handler. Called by ActionAddBookmark for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionAddBookmark_Click(object sender, EventArgs e)
  {
    BookmarkItems.Add(SelectReferenceForm.Run());
    UpdateBookmarks();
  }

  private void ActionHistoryVerseNext_Click(object sender, EventArgs e)
  {
    if ( CurrentReference is null ) return;
    if ( !IsVersesOrTranslationOrOriginal(Settings.CurrentView) )
      SetView(ViewMode.ChapterVerses);
    var list = HistoryItems.ToList();
    int index = list.FindIndex(r => r.CompareTo(CurrentReference) == 0);
    if ( index > 0 ) GoToReference(list[index - 1], isHistory: true);
  }

  private void ActionHistoryVerseBack_Click(object sender, EventArgs e)
  {
    if ( CurrentReference is null ) return;
    if ( !IsVersesOrTranslationOrOriginal(Settings.CurrentView) )
      SetView(ViewMode.ChapterVerses);
    var list = HistoryItems.ToList();
    int index = list.FindIndex(r => r.CompareTo(CurrentReference) == 0);
    if ( index >= 0 && index < list.Count - 1 ) GoToReference(list[index + 1], isHistory: true);
  }

  /// <summary>
  /// Event handler. Called by ActionSetAsBookmarkMain for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionSetAsBookmarkMain_Click(object sender, EventArgs e)
  {
    var menuitem = (ToolStripMenuItem)sender;
    var control = ( (ContextMenuStrip)menuitem.Owner ).SourceControl;
    if ( control is LinkLabel && Settings.CurrentView == ViewMode.Search )
    {
      var reference = (ReferenceItem)control.Tag;
      Settings.BookmarkMainBook = reference.Book.Number;
      Settings.BookmarkMainChapter = reference.Chapter.Number;
      Settings.BookmarkMainVerse = reference.Verse.Number;
    }
    else
    if ( control is Label && Settings.CurrentView == ViewMode.ChapterVerses )
    {
      Settings.BookmarkMainBook = CurrentReference.Book.Number;
      Settings.BookmarkMainChapter = CurrentReference.Chapter.Number;
      Settings.BookmarkMainVerse = Convert.ToInt32(control.Text);
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
    if ( control is Label && IsVersesOrFiltered(Settings.CurrentView) )
    {
      int index = Convert.ToInt32(control.Text) - 1;
      reference = new ReferenceItem(CurrentReference.Book.Number,
                                    CurrentReference.Chapter.Number,
                                    CurrentReference.Chapter.Verses[index].Number);
    }
    BookmarkItems.Add(reference);
    UpdateBookmarks();
  }

  /// <summary>
  /// Event handler. Called by ActionRemoveFromBookmarks for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionRemoveFromBookmarks_Click(object sender, EventArgs e)
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
    if ( control is Label && IsVersesOrFiltered(Settings.CurrentView) )
    {
      int index = Convert.ToInt32(control.Text) - 1;
      reference = new ReferenceItem(CurrentReference.Book.Number,
                                    CurrentReference.Chapter.Number,
                                    CurrentReference.Chapter.Verses[index].Number);
    }
    BookmarkItems.Remove(reference);
    UpdateBookmarks();
  }

  /// <summary>
  /// Event handler. Called by ActionClearHistory for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionClearHistory_Click(object sender, EventArgs e)
  {
    if ( !DisplayManager.QueryYesNo(SysTranslations.AskToEmptyHistory.GetLang()) ) return;
    HistoryItems.Clear();
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
    Settings.BookmarkMainBook = 1;
    Settings.BookmarkMainChapter = 1;
    Settings.BookmarkMainVerse = 1;
    BookmarkItems.Clear();
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
    BookmarkItems.Sort();
    UpdateBookmarks();
    ActionBookmarks.ShowDropDown();
  }

  /// <summary>
  /// Go to bookmark reference.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void GoToBookmark(object sender, EventArgs e)
  {
    ProcessGoToBookmarkOrHistory((ReferenceItem)( (ToolStripMenuItem)sender ).Tag, false);
  }

  /// <summary>
  /// Go to history reference.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void GoToHistory(object sender, EventArgs e)
  {
    ProcessGoToBookmarkOrHistory((ReferenceItem)( (ToolStripMenuItem)sender ).Tag, true);
  }

  /// <summary>
  /// Process go to history reference.
  /// </summary>
  private void ProcessGoToBookmarkOrHistory(ReferenceItem reference, bool isHistory)
  {
    ActionSave.PerformClick();
    if ( IsSearchOrFilteredOrELS50(Settings.CurrentView) )
      SetView(ViewMode.ChapterVerses);
    GoToReference(reference, isHistory: isHistory);
  }

  #endregion

  #region View Verses Navigation

  private bool TextBoxMutex;
  private bool DisableChapterPos;
  private bool NeedUpdateCurrentReference;
  private bool UpdateCurrentReferenceMutex;

  /// <summary>
  /// Event handler. Called by ActionSelectRenderAllVersesKeepHelp for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionSelectRenderAllVersesKeepHelp_Click(object sender, EventArgs e)
  {
    DisplayManager.ShowInformation(AppTranslations.RenderAllVersesKeepNotice.GetLang());
  }

  /// <summary>
  /// Event handler. Called by SelectRenderAllVerses for checked changed events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void SelectRenderAllVerses_CheckedChanged(object sender, EventArgs e)
  {
    ActionRefresh.PerformClick();
  }

  /// <summary>
  /// Event handler. Called by SelectBook for selected index changed events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void SelectBook_SelectedIndexChanged(object sender, EventArgs e)
  {
    if ( Globals.IsLoadingData ) return;
    if ( TextBoxMutex ) return;
    DisableChapterPos = true;
  }

  /// <summary>
  /// Event handler. Called by SelectChapter for selected index changed events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void SelectChapter_SelectedIndexChanged(object sender, EventArgs e)
  {
    if ( Globals.IsLoadingData ) return;
    NeedUpdateCurrentReference = true;
  }

  /// <summary>
  /// Event handler. Called by SelectVerse for selected index changed events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void SelectVerse_SelectedIndexChanged(object sender, EventArgs e)
  {
    if ( IsGoToRunning ) return;
    if ( Globals.IsLoadingData ) return;
    if ( Globals.IsRendering ) return;
    if ( Globals.IsExiting ) return;
    if ( NeedUpdateCurrentReference ) return;
    var reference = new ReferenceItem(CurrentReference.Book.Number,
                                      CurrentReference.Chapter.Number,
                                      ( (VerseRow)SelectVerse.SelectedItem ).Number);
    if ( reference != CurrentReference )
      GoToReference(reference);
  }

  /// <summary>
  /// Event handler. Called by BookRowBindingSource for position changed events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void BookRowBindingSource_PositionChanged(object sender, EventArgs e)
  {
    if ( Globals.IsLoadingData ) return;
    UpdateCurrentReference();
  }

  /// <summary>
  /// Event handler. Called by ChaptersBindingSource for position changed events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ChaptersBindingSource_PositionChanged(object sender, EventArgs e)
  {
    if ( Globals.IsLoadingData ) return;
    if ( DisableChapterPos )
      DisableChapterPos = false;
    else
      UpdateCurrentReference();
  }

  /// <summary>
  /// Event handler. Called by BookRowBindingSource for list changed events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">List changed event information.</param>
  private void BookRowBindingSource_ListChanged(object sender, ListChangedEventArgs e)
  {
    if ( Globals.IsLoadingData ) return;
    NeedUpdateCurrentReference = true;
  }

  /// <summary>
  /// Event handler. Called by ChaptersBindingSource for list changed events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">List changed event information.</param>
  [SuppressMessage("Major Code Smell", "S4144:Methods should not have identical implementations", Justification = "N/A")]
  private void ChaptersBindingSource_ListChanged(object sender, ListChangedEventArgs e)
  {
    if ( Globals.IsLoadingData ) return;
    NeedUpdateCurrentReference = true;
  }

  /// <summary>
  /// Event handler. Called by EditDbTextBox for enter events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void EditDbTextBox_Enter(object sender, EventArgs e)
  {
    ( (Control)sender ).ChangeControlColor(ControlHelper.FocusedGeneralTextBoxColor);
    TextBoxMutex = true;
  }

  /// <summary>
  /// Event handler. Called by EditDbTextBox for leave events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void EditDbTextBox_Leave(object sender, EventArgs e)
  {
    ( (Control)sender ).RestoreControlColor();
    TextBoxMutex = false;
    if ( Settings.AutoSaveOnLeaveControl )
      Instance.ActionSave_Click(Instance.ActionSave, EventArgs.Empty);
  }

  /// <summary>
  /// Updates the current reference.
  /// </summary>
  private void UpdateCurrentReference()
  {
    if ( Globals.IsLoadingData ) return;
    if ( !NeedUpdateCurrentReference ) return;
    if ( UpdateCurrentReferenceMutex ) return;
    UpdateCurrentReferenceMutex = true;
    try
    {
      var referenceOld = CurrentReference is null ? null : new ReferenceItem(CurrentReference);
      var referenceNew = new ReferenceItem(( SelectBook.SelectedItem as ObjectView<BookRow> )?.Object.Number ?? 1,
                                           ( SelectChapter.SelectedItem as ChapterRow )?.Number ?? 1,
                                           ( SelectVerse.SelectedItem as VerseRow )?.Number ?? 1);
      if ( referenceOld == referenceNew ) return;
      ActionSave.PerformClick();
      GoToReference(referenceNew, true);
    }
    finally
    {
      DisableChapterPos = false;
      NeedUpdateCurrentReference = false;
      UpdateCurrentReferenceMutex = false;
    }
  }

  /// <summary>
  /// Event handler. Called by EditELS50 for text changed events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void EditELS50_TextChanged(object sender, EventArgs e)
  {
    int width = TextRenderer.MeasureText(EditELS50Single.Text, EditELS50Single.Font).Width;
    EditELS50HScrollBar.Enabled = width > EditELS50Single.Width;
    EditELS50HScrollBar.Value = EditELS50HScrollBar.Maximum;
  }

  /// <summary>
  /// Event handler. Called by EditELS50HScrollBar for scroll events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Scroll event information.</param>
  private void EditELS50HScrollBar_Scroll(object sender, ScrollEventArgs e)
  {
    var edit = EditELS50Single;
    var bar = EditELS50HScrollBar;
    edit.SelectionLength = 0;
    if ( bar.Value >= -bar.LargeChange )
      edit.SelectionStart = edit.Text.Length;
    else
    if ( bar.Value <= bar.Minimum + bar.LargeChange )
      edit.SelectionStart = 0;
    else
      edit.SelectionStart = edit.Text.Length - ( edit.Text.Length * bar.Value / bar.Minimum );
    edit.ScrollToCaret();
  }

  private void UpdateELS50ScrollBar()
  {
    var edit = EditELS50Single;
    var bar = EditELS50HScrollBar;
    bar.Value = bar.Minimum - ( edit.SelectionStart * bar.Minimum / edit.Text.Length );
  }

  private void EditELS50Single_KeyDown(object sender, KeyEventArgs e)
  {
    UpdateELS50ScrollBar();
  }

  private void EditELS50Single_MouseClick(object sender, MouseEventArgs e)
  {
    UpdateELS50ScrollBar();
  }

  private void EditELS50Single_DragDrop(object sender, DragEventArgs e)
  {
    UpdateELS50ScrollBar();
  }

  private void EditELS50Single_MouseLeave(object sender, EventArgs e)
  {
    UpdateELS50ScrollBar();
  }

  #endregion

  #region View Verses Interaction

  /// <summary>
  /// Event handler. Called by PanelViewVerses for mouse click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void PanelViewVerses_MouseClick(object sender, MouseEventArgs e)
  {
    PanelViewVerses.Focus();
    GoToReference(CurrentReference);
  }

  /// <summary>
  /// Event handler. Called by ActionEditBookMemo for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionEditBookMemo_Click(object sender, EventArgs e)
  {
    if ( CurrentReference is null ) return;
    if ( EditMemoForm.Run(CurrentReference.Book.Transcription, CurrentReference.Book.Memo, out var memo) )
      CurrentReference.Book.Memo = memo;
  }

  /// <summary>
  /// Event handler. Called by ActionEditChapterMemo for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionEditChapterMemo_Click(object sender, EventArgs e)
  {
    if ( CurrentReference is null ) return;
    string title = string.Join(" ",
                               CurrentReference.Book.Transcription,
                               AppTranslations.BookChapterTitle.GetLang().ToLower(),
                               CurrentReference.Chapter.Number);
    if ( EditMemoForm.Run(title, CurrentReference.Chapter.Memo, out var memo) )
      CurrentReference.Chapter.Memo = memo;
  }

  /// <summary>
  /// Event handler. Called by ActionSearchTranslated for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionSearchTranslated_Click(object sender, EventArgs e)
  {
    if ( ActiveControl is VerseControl controlVerse && controlVerse.ActiveControl is WordControl controlWord )
      SearchTranslatedForm.Run(controlWord);
  }

  /// <summary>
  /// Event handler. Called by ActionSearchWordInDatabase for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionSearchWord_Click(object sender, EventArgs e)
  {
    if ( ActiveControl is VerseControl controlVerse && controlVerse.ActiveControl is WordControl controlWord )
      SearchHebrewWord(controlWord.Reference?.Word?.Hebrew);
  }

  private void ActionWordSearchDefault_Click(object sender, EventArgs e)
  {
    if ( ActiveControl is VerseControl controlVerse && controlVerse.ActiveControl is WordControl controlWord )
      HebrewTools.OpenWordProvider(Settings.SearchOnlineURL, controlWord.Reference?.Word?.Hebrew);
  }

  /// <summary>
  /// Event handler. Called by ActionStartHebrewLetters for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionStartHebrewLetters_Click(object sender, EventArgs e)
  {
    if ( ActiveControl is VerseControl controlVerse && controlVerse.ActiveControl is WordControl controlWord )
      HebrewTools.OpenHebrewLetters(controlWord.Reference?.Word?.Hebrew);
    else
    if ( Settings.CurrentView == ViewMode.Search && !EditSearchWord.InputText.IsEmpty() )
      HebrewTools.OpenHebrewLetters(EditSearchWord.InputText);
    else
      HebrewTools.OpenHebrewLetters(string.Empty);
  }

  /// <summary>
  /// Event handler. Called by ContextMenuStripVerse for opening events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ContextMenuStripVerse_Opening(object sender, CancelEventArgs e)
  {
    ReferenceItem reference;
    var contextmenu = sender as ContextMenuStrip;
    var control = contextmenu?.SourceControl;
    if ( control is LinkLabel && Settings.CurrentView == ViewMode.Search )
      reference = (ReferenceItem)control.Tag;
    else
    if ( control is Label label && IsVersesOrFiltered(Settings.CurrentView) )
      reference = ( (VerseControl)label.Parent ).Reference;
    else
      return;
    ActionSetAsBookmarkMain.Enabled = !( Settings.BookmarkMainBook == reference.Book.Number
                                         && Settings.BookmarkMainChapter == reference.Chapter.Number
                                         && Settings.BookmarkMainVerse == reference.Verse.Number );
    ActionAddToBookmarks.Enabled = !BookmarkItems.Contains(reference);
    ActionRemoveFromBookmarks.Enabled = BookmarkItems.Contains(reference);

  }

  /// <summary>
  /// Event handler. Called by ActionCopyWordTranslation for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionCopyWordTranslation_Click(object sender, EventArgs e)
  {
    Clipboard.SetText(CurrentReference?.Word?.Translation);
  }

  /// <summary>
  /// Event handler. Called by ActionCopyUnicodeChars for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionCopyUnicodeChars_Click(object sender, EventArgs e)
  {
    if ( ActiveControl is VerseControl controlVerse && controlVerse.ActiveControl is WordControl controlWord )
      Clipboard.SetText(controlWord.Reference?.Word?.Unicode);
  }

  /// <summary>
  /// Event handler. Called by ActionCopyFontChars for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionCopyFontChars_Click(object sender, EventArgs e)
  {
    if ( ActiveControl is VerseControl controlVerse && controlVerse.ActiveControl is WordControl controlWord )
      Clipboard.SetText(controlWord.Reference?.Word?.Hebrew);
  }

  /// <summary>
  /// Event handler. Called by ActionCountOccurencesTorah for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  [SuppressMessage("Performance", "U2U1208:Do not call LINQ methods whose effect is undone by subsequent methods", Justification = "N/A")]
  private void ActionCountOccurencesTorah_Click(object sender, EventArgs e)
  {
    if ( ActiveControl is not VerseControl controlVerse || controlVerse.ActiveControl is not WordControl controlWord )
      return;
    string str = controlWord.Reference?.Word?.Unicode;
    int max = BooksBounds.Torah.Max;
    var query = from book in ApplicationDatabase.Instance.Books
                from chapter in book.Chapters
                from verse in chapter.Verses
                from word in verse.Words
                where book.Number <= max
                   && chapter.BookID == book.ID
                   && verse.ChapterID == chapter.ID
                   && word.VerseID == verse.ID
                   && word.Unicode == str
                select word;
    DisplayManager.Show($"Number of {str} occurrences in Torah is {query.Count()}");
  }

  /// <summary>
  /// Event handler. Called by ActionCountOccurencesTanak for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  [SuppressMessage("Performance", "U2U1208:Do not call LINQ methods whose effect is undone by subsequent methods", Justification = "N/A")]
  private void ActionCountOccurencesTanak_Click(object sender, EventArgs e)
  {
    if ( ActiveControl is not VerseControl controlVerse || controlVerse.ActiveControl is not WordControl controlWord )
      return;
    string str = controlWord.Reference?.Word?.Unicode;
    var query = from book in ApplicationDatabase.Instance.Books
                from chapter in book.Chapters
                from verse in chapter.Verses
                from word in verse.Words
                where chapter.BookID == book.ID
                   && verse.ChapterID == chapter.ID
                   && word.VerseID == verse.ID
                   && word.Unicode == str
                select word;
    DisplayManager.Show($"Number of {str} occurrences in Tanak is {query.Count()}");
  }

  #endregion

  #region Verses Filtered

  private Dictionary<TextBox, bool> FilterModified;

  /// <summary>
  /// Updates the filters.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void UpdateFilters(object sender, EventArgs e)
  {
    var temp = Cursor;
    Cursor = Cursors.WaitCursor;
    try
    {
      CreateFilterDataSource();
    }
    finally
    {
      Cursor = temp;
    }
  }

  /// <summary>
  /// Event handler. Called by ActionClearFilterBook for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionClearFilterBook_Click(object sender, EventArgs e)
  {
    EditFilterBook.Text = string.Empty;
    UpdateFilters(sender, e);
  }

  /// <summary>
  /// Event handler. Called by ActionClearFilterChapter for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionClearFilterChapter_Click(object sender, EventArgs e)
  {
    EditFilterChapter.Text = string.Empty;
    UpdateFilters(sender, e);
  }

  /// <summary>
  /// Event handler. Called by ActionClearFilterVerse for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionClearFilterVerse_Click(object sender, EventArgs e)
  {
    EditFilterVerse.Text = string.Empty;
    UpdateFilters(sender, e);
  }

  /// <summary>
  /// Event handler. Called by EditFilter for text changed events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void EditFilter_TextChanged(object sender, EventArgs e)
  {
    FilterModified[(TextBox)sender] = true;
    ActionApplyFilterBook.Enabled = EditFilterBook.Text.Length != 0;
    ActionApplyFilterChapter.Enabled = EditFilterChapter.Text.Length != 0;
    ActionApplyFilterVerse.Enabled = EditFilterVerse.Text.Length != 0;
    ActionClearFilterBook.Enabled = EditFilterBook.Text.Length != 0;
    ActionClearFilterChapter.Enabled = EditFilterChapter.Text.Length != 0;
    ActionClearFilterVerse.Enabled = EditFilterVerse.Text.Length != 0;
  }

  /// <summary>
  /// Event handler. Called by EditFilterBook for key up events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Key event information.</param>
  private void EditFilterBook_KeyUp(object sender, KeyEventArgs e)
  {
    if ( e.KeyCode == Keys.Enter && FilterModified[(TextBox)sender] )
    {
      FilterModified[(TextBox)sender] = false;
      UpdateFilters(sender, e);
    }
  }

  /// <summary>
  /// Event handler. Called by EditFilter for leave events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void EditFilter_Leave(object sender, EventArgs e)
  {
    if ( FilterModified[(TextBox)sender] )
    {
      FilterModified[(TextBox)sender] = false;
      UpdateFilters(sender, e);
    }
  }

  /// <summary>
  /// Creates filter data source.
  /// </summary>
  [SuppressMessage("Refactoring", "GCop635:The condition of the where clause is very long and should be turned into a method.", Justification = "N/A")]
  private void CreateFilterDataSource()
  {
    var books = (IEnumerable<BookRow>)ApplicationDatabase.Instance.Books;
    if ( EditFilterChaptersWithTitle.Checked )
      books = books.Where(b => b.Chapters.Exists(c => !c.Title.IsNullOrEmpty()));
    if ( EditFilterVersesTranslated.Checked )
      books = books.Where(b => b.Chapters.Exists(c => c.Verses.Exists(v => v.HasTranslation)));
    if ( EditFilterBook.Text.Length != 0 )
    {
      string filterBook = EditFilterBook.Text;
      books = books.Where(b => b.Transcription.RawContains(filterBook)
                            || b.CommonName.RawContains(filterBook)
                            || b.Translation.RawContains(filterBook)
                            || b.Lettriq.RawContains(filterBook)
                            || b.Memo.RawContains(filterBook));
    }
    if ( EditFilterChapter.Text.Length != 0 )
    {
      string filterChapter = EditFilterChapter.Text;
      books = books.Where(b => b.Chapters.Exists(c => c.Title.RawContains(filterChapter)
                                                   || c.Memo.RawContains(filterChapter)));
    }
    if ( EditFilterVerse.Text.Length != 0 )
    {
      string filterVerse = EditFilterVerse.Text;
      books = books.Where(b => b.Chapters.Exists(c => c.Verses.Exists(v => v.Title.RawContains(filterVerse)
                                                                        || v.Concept.RawContains(filterVerse)
                                                                        || v.Translation.RawContains(filterVerse)
                                                                        || v.Comment.RawContains(filterVerse))));
    }
    var list = books.ToList();
    SelectFilterBook.DataSource = new BindingList<BookRow>(list);
    if ( list.Count == 0 )
    {
      SelectFilterChapter.DataSource = null;
      SelectFilterVerse.DataSource = null;
    }
  }

  /// <summary>
  /// Event handler. Called by SelectFilterBook for selected index changed events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void SelectFilterBook_SelectedIndexChanged(object sender, EventArgs e)
  {
    if ( SelectFilterBook.SelectedItem is null )
    {
      SelectFilterChapter.DataSource = null;
      SelectFilterVerse.DataSource = null;
      return;
    }
    var id = ( (BookRow)SelectFilterBook.SelectedItem ).ID;
    var chapters = ApplicationDatabase.Instance.Chapters.Where(chapter => chapter.BookID == id);
    if ( EditFilterChaptersWithTitle.Checked )
      chapters = chapters.Where(c => !c.Title.IsNullOrEmpty());
    if ( EditFilterVersesTranslated.Checked )
      chapters = chapters.Where(c => c.Verses.Exists(v => v.HasTranslation));
    if ( EditFilterChapter.Text.Length != 0 )
    {
      string filterChapter = EditFilterChapter.Text;
      chapters = chapters.Where(c => c.Title.RawContains(filterChapter)
                                  || c.Memo.RawContains(filterChapter));
    }
    if ( EditFilterVerse.Text.Length != 0 )
    {
      string filterVerse = EditFilterVerse.Text;
      chapters = chapters.Where(c => c.Verses.Exists(v => v.Title.RawContains(filterVerse)
                                                       || v.Concept.RawContains(filterVerse)
                                                       || v.Translation.RawContains(filterVerse)
                                                       || v.Comment.RawContains(filterVerse)));
    }
    var list = chapters.ToList();
    SelectFilterChapter.DataSource = new BindingList<ChapterRow>(list);
    if ( list.Count == 0 )
      SelectFilterVerse.DataSource = null;
  }

  /// <summary>
  /// Event handler. Called by SelectFilterChapter for selected index changed events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void SelectFilterChapter_SelectedIndexChanged(object sender, EventArgs e)
  {
    if ( SelectFilterChapter.SelectedItem is null )
    {
      SelectFilterVerse.DataSource = null;
      return;
    }
    var id = ( (ChapterRow)SelectFilterChapter.SelectedItem ).ID;
    var verses = ApplicationDatabase.Instance.Verses.Where(verse => verse.ChapterID == id);
    if ( EditFilterVersesTranslated.Checked )
      verses = verses.Where(v => v.HasTranslation);
    if ( EditFilterVerse.Text.Length != 0 )
    {
      string filterVerse = EditFilterVerse.Text;
      verses = verses.Where(v => v.Title.RawContains(filterVerse)
                              || v.Concept.RawContains(filterVerse)
                              || v.Translation.RawContains(filterVerse)
                              || v.Comment.RawContains(filterVerse));
    }
    SelectFilterVerse.DataSource = new BindingList<VerseRow>(verses.ToList());
  }

  /// <summary>
  /// Event handler. Called by SelectFilterVerse for selected index changed events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void SelectFilterVerse_SelectedIndexChanged(object sender, EventArgs e)
  {
    RenderVerseFiltered();
  }

  /// <summary>
  /// Event handler. Called by ActionGoFromVerseFilteredToVersesPanel for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionGoFromVerseFilteredToVersesPanel_Click(object sender, EventArgs e)
  {
    SetView(ViewMode.ChapterVerses);
    GoToReference(new ReferenceItem(( SelectFilterBook.SelectedItem as BookRow )?.Number ?? 1,
                                    ( SelectFilterChapter.SelectedItem as ChapterRow )?.Number ?? 1,
                                    ( SelectFilterVerse.SelectedItem as VerseRow )?.Number ?? 1));
  }

  /// <summary>
  /// Event handler. Called by ActionInfoFilterVerses for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionInfoFilterVerses_Click(object sender, EventArgs e)
  {
    DisplayManager.ShowInformation(AppTranslations.FilterVersesNotice.GetLang());
  }

  #endregion

  #region View Search

  /// <summary>
  /// Event handler. Called by SelectSearchTranslationOnlyTranslations for checked changed events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void SelectSearchTranslationOnlyTranslations_CheckedChanged(object sender, EventArgs e)
  {
    Settings.SearchTranslationRadioButtonIndex = ( sender as RadioButton )?.TabIndex ?? 0;
  }

  /// <summary>
  /// Event handler. Called by SelectSearchRequestAllTranslated for checked changed events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void SelectSearchRequestAllTranslated_CheckedChanged(object sender, EventArgs e)
  {
    Settings.SearchVerseRadioButtonIndex = ( sender as RadioButton )?.TabIndex ?? 0;
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
    EditSearchWord.UpdateControls();
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
  private void ActionSearchRun_Click(object sender, EventArgs e)
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
    EditSearchWord.TextBox.Text = "";
    EditSearchTranslation.Text = "";
    SystemManager.TryCatch(Settings.Save);
    ClearSearchResults();
    UpdateSearchButtons();
    RenderSearch();
  }

  /// <summary>
  /// Event handler. Called by ActionSearchInAddAll for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionSearchInAddAll_Click(object sender, EventArgs e)
  {
    EditSearchInTorah.Checked = true;
    EditSearchInNeviim.Checked = true;
    EditSearchInKetouvim.Checked = true;
  }

  /// <summary>
  /// Event handler. Called by ActionSearchInRemoveAll for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
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
    Settings.SearchInBookSelectedNumber = ( SelectSearchInBook.SelectedItem as BookRow )?.Number ?? 1;
    SystemManager.TryCatch(Settings.Save);
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
  /// Event handler. Called by PanelSearchResults for mouse click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void PanelSearchResults_MouseClick(object sender, MouseEventArgs e)
  {
    PanelSearchResults.Focus();
  }

  /// <summary>
  /// Event handler. Called by ActionSearchVerse for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionSearchVerse_Click(object sender, EventArgs e)
  {
    GoToReference(SelectVerseForm.Run());
  }

  /// <summary>
  /// Search a hebrew word.
  /// </summary>
  public void SearchHebrewWord(string word)
  {
    SetView(ViewMode.Search);
    SelectSearchType.SelectedTab = SelectSearchTypeHebrew;
    EditSearchWord.InitialWord = HebrewAlphabet.SetFinal(word, false);
    EditSearchWord.TextBox.Text = EditSearchWord.InitialWord;
    EditSearchWord.TextBox.SelectionStart = EditSearchWord.TextBox.Text.Length;
    ActionSearchRun.PerformClick();
  }

  /// <summary>
  /// Search a translated word.
  /// </summary>
  public void SearchTranslatedWord(string word)
  {
    SetView(ViewMode.Search);
    SelectSearchType.SelectedTab = SelectSearchTypeTranslation;
    EditSearchTranslation.Text = word;
    ActionSearchRun.PerformClick();
  }

  /// <summary>
  /// Event handler. Called by ActionSearchNavigateFirst for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionSearchNavigateFirst_Click(object sender, EventArgs e)
  {
    if ( Globals.IsRendering ) return;
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
    if ( Globals.IsRendering ) return;
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
    if ( Globals.IsRendering ) return;
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
    if ( Globals.IsRendering ) return;
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
        EditSearchPaging.Text = $"{SelectSearchPaging.Value}/{PagingCount} ({SearchResultsCount})";
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

  #endregion

  #region Temp and Tests

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

  #endregion

}
