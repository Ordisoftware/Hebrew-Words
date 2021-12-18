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
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

using Equin.ApplicationFramework;

/// <summary>
/// Provides application's main form.
/// </summary>
/// <seealso cref="T:System.Windows.Forms.Form"/>
partial class MainForm : Form
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

  private bool PreviousWindowsStateToggle = true;
  private FormWindowState PreviousWindowsState;

  /// <summary>
  /// Event handler. Called by MainForm for windows changed events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
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
      SelectVerse.DropDownWidth = ActionEditChapterMemo.Right - SelectVerse.Left + 5;
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
          SelectVerse.DropDownWidth = ActionEditChapterMemo.Right - SelectVerse.Left + 5;
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
      SelectVerse.DropDownWidth = ActionEditChapterMemo.Right - SelectVerse.Left + 5;
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
    LastToolTip.Show(item.ToolTipText, ToolStrip, location, 3000);
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
  private void ActionPreferences_Click(object sender, EventArgs e)
  {
    ActionSave.PerformClick();
    Settings.Store();
    bool refresh = PreferencesForm.Run();
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
        int verse = reference.Verse == null ? 1 : reference.Verse.Number;
        int word = reference.Word == null ? 1 : reference.Word.Number;
        GoTo(new ReferenceItem(reference.Book.Number, reference.Chapter.Number, verse, word));
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
    Globals.NoticeKeyboardShortcutsForm?.Popup();
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
    switch ( DisplayManager.FormStyle )
    {
      case MessageBoxFormStyle.System:
        DisplayManager.IconStyle = EditSoundsEnabled.Checked
                                   ? MessageBoxIconStyle.ForceInformation
                                   : MessageBoxIconStyle.ForceNone;
        break;
      case MessageBoxFormStyle.Advanced:
        DisplayManager.IconStyle = MessageBoxIconStyle.ForceInformation;
        break;
    }
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
    bool exit = WebCheckUpdate.Run(Settings.CheckUpdateAtStartup,
                                   ref lastdone,
                                   Settings.CheckUpdateAtStartupDaysInterval,
                                   e == null);
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
  /// Event handler. Called by ActionViewBooksTranslation for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionViewBooksTranslation_Click(object sender, EventArgs e)
  {
    ActionSave.PerformClick();
    new EditBooksForm().ShowDialog();
    GoTo(CurrentReference);
    ActionSave.PerformClick();
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
    var reference = BibleStatisticsForm.Run();
    if ( reference != null )
    {
      SetView(ViewMode.ChapterVerses);
      GoTo(reference);
    }
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
    GoTo(SelectReferenceForm.Run());
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
    int book = CurrentReference.Book.Number;
    int chapter = CurrentReference.Chapter.Number;
    int verse = CurrentReference.Verse?.Number ?? 1;
    VerseControl.ResetMetricsRequired = true;
    WordControl.ResetMetricsRequired = true;
    GoTo(book, chapter, verse, true);
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
      case ViewMode.ChapterTranslation:
        Clipboard.SetText(EditChapterTranslation.Text);
        break;
      case ViewMode.ChapterOriginal:
        Clipboard.SetText(EditChapterOriginal.Text);
        break;
      case ViewMode.BookELS50:
        Clipboard.SetText(EditChapterELS50.Text);
        break;
      default:
        throw new AdvancedNotImplementedException(Settings.CurrentView);
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
      ActionBackup.PerformClick();
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
    if ( DisplayManager.QueryYesNo(AppTranslations.AskToBackupDatabaseBeforeReplace.GetLang()) )
      ActionBackup.PerformClick();
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
  /// <param name="sender"></param>
  /// <param name="e"></param>
  private void ActionVacuum_Click(object sender, EventArgs e)
  {
    Settings.VacuumLastDone = ApplicationDatabase.Instance
                                                 .Connection
                                                 .Optimize(Settings.VacuumLastDone,
                                                           Settings.VacuumAtStartupDaysInterval,
                                                           true);
    HebrewDatabase.Instance.Connection.Optimize(DateTime.MinValue, force: true);
    //ApplicationStatistics.UpdateDBCommonFileSizeRequired = true;
    //ApplicationStatistics.UpdateDBFileSizeRequired = true;
    DisplayManager.Show(SysTranslations.DatabaseVacuumSuccess.GetLang());
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
  /// Event handler. Called by ActionOpenExportFolder for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionOpenExportFolder_Click(object sender, EventArgs e)
  {
    SystemManager.RunShell(Settings.GetExportDirectory());
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
  /// Event handler. Called by ActionImportConsole for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionImportConsole_Click(object sender, EventArgs e)
  {
    ActionSave.PerformClick();
    var control = e == null ? sender as VerseControl : ( (ContextMenuStrip)ActionImportConsole.Owner ).SourceControl;
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
    ImportVerseForm.Run(reference);
  }

  /// <summary>
  /// Event handler. Called by ActionImportConcordances for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionImportConcordances_Click(object sender, EventArgs e)
  {
    new ImportStrongForm().ShowDialog();
  }

  #endregion

  #region ContextMenu Verse

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
    if ( control is Label label && ( Settings.CurrentView == ViewMode.ChapterVerses || Settings.CurrentView == ViewMode.VerseFiltered ) )
      reference = ( (VerseControl)label.Parent ).Reference;
    else
      return;
    ActionSetAsBookmarkMain.Enabled = !( Settings.BookmarkMasterBook == reference.Book.Number
                                         && Settings.BookmarkMasterChapter == reference.Chapter.Number
                                         && Settings.BookmarkMasterVerse == reference.Verse.Number );
    ActionAddToBookmarks.Enabled = !Bookmarks.Contains(reference);

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
    if ( control is Label && Settings.CurrentView == ViewMode.ChapterVerses )
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
    if ( control is Label && ( Settings.CurrentView == ViewMode.ChapterVerses || Settings.CurrentView == ViewMode.VerseFiltered ) )
    {
      int index = Convert.ToInt32(control.Text) - 1;
      reference = new ReferenceItem(CurrentReference.Book.Number,
                                    CurrentReference.Chapter.Number,
                                    CurrentReference.Chapter.Verses[index].Number);
    }
    Bookmarks.Add(reference);
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
    ActionBookmarks.ShowDropDown();
  }

  /// <summary>
  /// Event handler. Called by ActionAddBookmark for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionAddBookmark_Click(object sender, EventArgs e)
  {
    Bookmarks.Add(SelectReferenceForm.Run());
    UpdateBookmarks();
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
      GoTo(reference);
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
    var control = (Control)sender;
    control.BackColor = Color.Ivory;
    TextBoxMutex = true;
  }

  /// <summary>
  /// Event handler. Called by EditDbTextBox for leave events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void EditDbTextBox_Leave(object sender, EventArgs e)
  {
    var control = (Control)sender;
    control.BackColor = Color.LightYellow;
    TextBoxMutex = false;
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
      var referenceOld = CurrentReference == null ? null : new ReferenceItem(CurrentReference);
      var referenceNew = new ReferenceItem(( SelectBook.SelectedItem as ObjectView<BookRow> )?.Object.Number ?? 1,
                                           ( SelectChapter.SelectedItem as ChapterRow )?.Number ?? 1,
                                           ( SelectVerse.SelectedItem as VerseRow )?.Number ?? 1/* TODO ???? 1*/);
      if ( referenceOld == referenceNew ) return;
      ActionSave.PerformClick();
      GoTo(referenceNew, true);
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
    EditELS50HScrollBar.Value = EditELS50HScrollBar.Maximum;
    EditELS50HScrollBar.Enabled = TextRenderer.MeasureText(EditELS50Single.Text, EditELS50Single.Font).Width > EditELS50Single.Width;
  }

  /// <summary>
  /// Event handler. Called by EditELS50HScrollBar for scroll events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Scroll event information.</param>
  private void EditELS50HScrollBar_Scroll(object sender, ScrollEventArgs e)
  {
    EditELS50Single.SelectionLength = 0;
    if ( EditELS50HScrollBar.Value >= -EditELS50HScrollBar.LargeChange )
      EditELS50Single.SelectionStart = EditELS50Single.Text.Length;
    else
    if ( EditELS50HScrollBar.Value <= EditELS50HScrollBar.Minimum + EditELS50HScrollBar.LargeChange )
      EditELS50Single.SelectionStart = 0;
    else
      EditELS50Single.SelectionStart = EditELS50Single.Text.Length
                               - ( EditELS50Single.Text.Length * EditELS50HScrollBar.Value / EditELS50HScrollBar.Minimum );
    EditELS50Single.ScrollToCaret();
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
    GoTo(CurrentReference);
  }

  /// <summary>
  /// Event handler. Called by ActionEditBookMemo for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionEditBookMemo_Click(object sender, EventArgs e)
  {
    var form = new EditMemoForm();
    form.Text += ( SelectBook.SelectedItem as ObjectView<BookRow> )?.Object.Name ?? string.Empty;
    form.TextBox.Text = CurrentReference.Book.Memo;
    form.TextBox.SelectionStart = 0;
    if ( form.ShowDialog() == DialogResult.OK )
      CurrentReference.Book.Memo = form.TextBox.Text;
  }

  /// <summary>
  /// Event handler. Called by ActionEditChapterMemo for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionEditChapterMemo_Click(object sender, EventArgs e)
  {
    var form = new EditMemoForm();
    form.Text += ( SelectBook.SelectedItem as ObjectView<BookRow> )?.Object.Name
               + " " + AppTranslations.BookChapterTitle.GetLang().ToLower()
               + " " + ( SelectChapter.SelectedItem as ChapterRow )?.Number
              ?? string.Empty;
    form.TextBox.Text = CurrentReference.Chapter.Memo;
    form.TextBox.SelectionStart = 0;
    if ( form.ShowDialog() == DialogResult.OK )
      EditChapterMemo.Text = form.TextBox.Text;
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
    Clipboard.SetText(CurrentReference?.Word?.Original);
  }

  /// <summary>
  /// Event handler. Called by ActionCopyFontChars for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionCopyFontChars_Click(object sender, EventArgs e)
  {
    Clipboard.SetText(CurrentReference?.Word?.Hebrew);
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

  /// <summary>
  /// Event handler. Called by ActionStartHebrewLetters for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void ActionStartHebrewLetters_Click(object sender, EventArgs e)
  {
    if ( ActiveControl is VerseControl controlVerse && controlVerse.ActiveControl is WordControl controlWord )
      HebrewTools.OpenHebrewLetters(controlWord.Reference?.Word?.Hebrew, Settings.HebrewLettersExe);
    else
    if ( Settings.CurrentView == ViewMode.Search && !EditSearchWord.InputText.IsEmpty() )
      HebrewTools.OpenHebrewLetters(EditSearchWord.InputText, Settings.HebrewLettersExe);
    else
      HebrewTools.OpenHebrewLetters(string.Empty, Settings.HebrewLettersExe);
  }

  /// <summary>
  /// Go to bookmark.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void GoToBookmark(object sender, EventArgs e)
  {
    ActionSave.PerformClick();
    if ( Settings.CurrentView == ViewMode.VerseFiltered
      || Settings.CurrentView == ViewMode.BookELS50
      || Settings.CurrentView == ViewMode.Search )
      SetView(ViewMode.ChapterVerses);
    GoTo((ReferenceItem)( (ToolStripMenuItem)sender ).Tag);
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
    ActionApplyFilterBook.Enabled = EditFilterBook.Text != string.Empty;
    ActionApplyFilterChapter.Enabled = EditFilterChapter.Text != string.Empty;
    ActionApplyFilterVerse.Enabled = EditFilterVerse.Text != string.Empty;
    ActionClearFilterBook.Enabled = EditFilterBook.Text != string.Empty;
    ActionClearFilterChapter.Enabled = EditFilterChapter.Text != string.Empty;
    ActionClearFilterVerse.Enabled = EditFilterVerse.Text != string.Empty;
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
  private void CreateFilterDataSource()
  {
    var books = (IEnumerable<BookRow>)ApplicationDatabase.Instance.Books;
    if ( EditFilterChaptersWithTitle.Checked )
      books = books.Where(b => b.Chapters.Any(c => !c.Title.IsNullOrEmpty()));
    if ( EditFilterVersesTranslated.Checked )
      books = books.Where(b => b.Chapters.Any(c => c.Verses.Any(v => v.HasTranslation)));
    if ( EditFilterBook.Text != string.Empty )
      books = books.Where(b => b.Name.RawContains(EditFilterBook.Text)
                            || b.CommonName.RawContains(EditFilterBook.Text)
                            || b.Translation.RawContains(EditFilterBook.Text)
                            || b.Lettriq.RawContains(EditFilterBook.Text)
                            || b.Memo.RawContains(EditFilterBook.Text));
    if ( EditFilterChapter.Text != string.Empty )
      books = books.Where(b => b.Chapters.Any(c => c.Title.RawContains(EditFilterChapter.Text)
                                                || c.Memo.RawContains(EditFilterChapter.Text)));

    if ( EditFilterVerse.Text != string.Empty )
      books = books.Where(b => b.Chapters.Any(c => c.Verses.Any(v => v.Translation.RawContains(EditFilterVerse.Text)
                                                                  || v.Comment.RawContains(EditFilterVerse.Text))));
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
    if ( SelectFilterBook.SelectedItem == null )
    {
      SelectFilterChapter.DataSource = null;
      SelectFilterVerse.DataSource = null;
      return;
    }
    Guid id = ( (BookRow)SelectFilterBook.SelectedItem ).ID;
    var chapters = ApplicationDatabase.Instance.Chapters.Where(chapter => chapter.BookID == id);
    if ( EditFilterChaptersWithTitle.Checked )
      chapters = chapters.Where(c => !c.Title.IsNullOrEmpty());
    if ( EditFilterVersesTranslated.Checked )
      chapters = chapters.Where(c => c.Verses.Any(v => v.HasTranslation));
    if ( EditFilterChapter.Text != string.Empty )
      chapters = chapters.Where(c => c.Title.RawContains(EditFilterChapter.Text)
                                  || c.Memo.RawContains(EditFilterChapter.Text));
    if ( EditFilterVerse.Text != string.Empty )
      chapters = chapters.Where(c => c.Verses.Any(v => v.Translation.RawContains(EditFilterVerse.Text)
                                                    || v.Comment.RawContains(EditFilterVerse.Text)));
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
    if ( SelectFilterChapter.SelectedItem == null )
    {
      SelectFilterVerse.DataSource = null;
      return;
    }
    Guid id = ( (ChapterRow)SelectFilterChapter.SelectedItem ).ID;
    var verses = ApplicationDatabase.Instance.Verses.Where(verse => verse.ChapterID == id);
    if ( EditFilterVersesTranslated.Checked )
      verses = verses.Where(v => v.HasTranslation);
    if ( EditFilterVerse.Text != string.Empty )
      verses = verses.Where(v => v.Translation.RawContains(EditFilterVerse.Text)
                              || v.Comment.RawContains(EditFilterVerse.Text));
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
    GoTo(new ReferenceItem(( SelectFilterBook.SelectedItem as BookRow )?.Number ?? 1,
                           ( SelectFilterChapter.SelectedItem as ChapterRow )?.Number ?? 1,
                           ( SelectFilterVerse.SelectedItem as VerseRow )?.Number ?? 1));
  }

  /// <summary>
  /// Event handler. Called by LabelInfoFilterVerses for click events.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void LabelInfoFilterVerses_Click(object sender, EventArgs e)
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
    EditSearchWord.TextBox.Text = HebrewAlphabet.SetFinal(word, false);
    EditSearchWord.TextBox.SelectionStart = EditSearchWord.TextBox.Text.Length;
    ActionSearchRun.PerformClick();
  }

  /// <summary>
  /// Search a translated word.
  /// </summary>
  /// <param name="word"></param>
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

  /// <summary>
  /// Calculates the sum value of torah letters.
  /// </summary>
  /// <param name="sender">Source of the event.</param>
  /// <param name="e">Event information.</param>
  private void CalculateSumValueOfTorahLetters(object sender, EventArgs e)
  {
    long value = 0;
    var books = from book in ApplicationDatabase.Instance.Books
                where book.Number <= BooksBounds.Torah.Max
                select book;
    foreach ( BookRow book in books )
      foreach ( ChapterRow chapter in book.Chapters )
        foreach ( VerseRow verse in chapter.Verses )
          foreach ( WordRow word in verse.Words )
            foreach ( char letter in word.Hebrew )
            {
              int index = Array.IndexOf(HebrewAlphabet.Codes, HebrewAlphabet.SetFinal(letter.ToString(), false));
              if ( index == -1 ) { }
              value += HebrewAlphabet.ValuesSimple[index];
            }
    DisplayManager.Show(value.ToString());
  }

  #endregion

}
