/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2019 Olivier Rogier.
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
/// <edited> 2019-09 </edited>
using Microsoft.Win32;
using Ordisoftware.Core;
using System;
using System.Linq;
using System.IO;
using System.Data;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Ordisoftware.HebrewWords.Data;

namespace Ordisoftware.HebrewWords
{

  /// <summary>
  /// Provide application's main form.
  /// </summary>
  /// <seealso cref="T:System.Windows.Forms.Form"/>
  public partial class MainForm : Form
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
    /// Indicate last showned tooltip.
    /// </summary>
    private ToolTip LastToolTip = new ToolTip();

    /// <summary>
    /// Indicate previous seach paging position.
    /// </summary>
    private int PreviousSeachPagingPosition = -1;

    /// <summary>
    /// Indicate current bible reference.
    /// </summary>
    public ReferenceItem CurrentReference { get; set; }

    /// <summary>
    /// Indicate combobox mutex.
    /// </summary>
    public bool ComboBoxMutex { get; private set; }

    /// <summary>
    /// Indicate if the application is ready for the user.
    /// </summary>
    public bool IsReady { get; private set; }

    /// <summary>
    /// Indicate if is in loading data stage.
    /// </summary>
    public bool IsLoadingData { get; private set; }

    /// <summary>
    /// Indicate if GoTo is running.
    /// </summary>
    private bool IsGoToRunning;

    /// <summary>
    /// Indicate if windows session is ending.
    /// </summary>
    private bool IsSessionEnding;

    /// <summary>
    /// Default constructor.
    /// </summary>
    private MainForm()
    {
      InitializeComponent();
      Text = AboutBox.Instance.AssemblyTitle;
      SystemEvents.SessionEnding += SessionEnding;
      CurrentReference = new ReferenceItem(null, null, null);
      int index = 1;
      EventHandler action = (sender, e) =>
      {
        Program.OpenOnlineVerse((string)( (ToolStripMenuItem)sender ).Tag,
                                SelectBook.SelectedIndex + 1,
                                SelectChapter.SelectedIndex + 1,
                                Convert.ToInt32(ContextMenuStripVerse.SourceControl.Text));
      };
      foreach ( var item in OnlineBibleProviders.Items )
        ContextMenuStripVerse.Items.Insert(index++, item.CreateMenuItem(action, ActionOpenVerseOnline.Image));
    }

    /// <summary>
    /// Event handler. Called by MainForm for load events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void MainForm_Load(object sender, EventArgs e)
    {
      Program.Settings.Retrieve();
      UpdateSearchButtons();
    }

    /// <summary>
    /// Event handler. Called by MainForm for shown events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void MainForm_Shown(object sender, EventArgs e)
    {
      Refresh();
      InitializeDialogsDirectory();
      CheckUpdate(true);
      DoBackupDB();
      LoadData();
      TimerAutoSave.Enabled = Program.Settings.AutoSaveDelay != 0;
      if ( TimerAutoSave.Enabled )
        TimerAutoSave.Interval = Program.Settings.AutoSaveDelay * 60 * 1000;
      IsReady = true;
    }

    /// <summary>
    /// Set the initial directories of dialog boxes.
    /// </summary>
    internal void InitializeDialogsDirectory()
    {
      OpenFileDialogDB.InitialDirectory = Program.Settings.BackupPath;
      SaveFileDialogDB.InitialDirectory = Program.Settings.BackupPath;
      SaveFileDialogWord.InitialDirectory = Program.Settings.BackupPath;
      SaveFileDialogRTF.InitialDirectory = Program.Settings.BackupPath;
    }

    /// <summary>
    /// Set form disabled or enabled.
    /// </summary>
    private void SetFormDisabled(bool disabled)
    {
      Cursor = disabled ? Cursors.WaitCursor : Cursors.Default;
      ToolStrip.Enabled = !disabled;
      PanelNavigation.Enabled = !disabled;
      PanelMainCenter.Enabled = !disabled;
    }

    /// <summary>
    /// Initialize books combobox.
    /// </summary>
    internal void InitBooksCombobox()
    {
      SelectBook.Items.Clear();
      foreach ( Data.DataSet.BooksRow book in DataSet.Books.Rows )
        SelectBook.Items.Add(new BookItem(book));
      SelectBook.SelectedIndex = 0;
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
    /// Event handler. Called by MainForm for form closing events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Form closing event information.</param>
    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      ActionSave.PerformClick();
      if ( EditConfirmClosing.Checked && !IsSessionEnding )
        if ( !DisplayManager.QueryYesNo(Localizer.ExitApplicationText.GetLang()) )
          e.Cancel = true;
    }

    /// <summary>
    /// Event handler. Called by MainForm for form closed events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Form closing event information.</param>
    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Program.Settings.Store();
    }

    /// <summary>
    /// Session ending event.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Session ending event information.</param>
    private void SessionEnding(object sender, SessionEndingEventArgs e)
    {
      IsSessionEnding = true;
      Close();
    }

    /// <summary>
    /// Check if a newer version is available.
    /// </summary>
    private void CheckUpdate(bool auto)
    {
      if ( auto && !Program.Settings.CheckUpdateAtStartup ) return;
      try
      {
        string title = AboutBox.Instance.AssemblyTitle;
        string url = "http://www.ordisoftware.com/files/" + title.Replace(" ", "") + ".update";
        using ( WebClient client = new WebClient() )
        {
          string[] partsVersion = client.DownloadString(url).Split('.');
          var version = new Version(Convert.ToInt32(partsVersion[0]), Convert.ToInt32(partsVersion[1]));
          if ( version.CompareTo(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version) <= 0 )
          {
            if ( !auto )
              DisplayManager.Show(Localizer.CheckUpdateNoNewText.GetLang());
          }
          else
          if ( DisplayManager.QueryYesNo(Localizer.CheckUpdateResultText.GetLang() + version + Environment.NewLine +
                                         Environment.NewLine +
                                         Localizer.CheckUpdateAskDownloadText.GetLang()) )
            AboutBox.Instance.OpenApplicationHome();
        }
      }
      catch
      {
      }
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
    /// Event handler. Called by MainForm for client size and location changed events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void MainForm_WindowsChanged(object sender, EventArgs e)
    {
      if ( !IsReady ) return;
      EditScreenNone.PerformClick();
    }

    /// <summary>
    /// Event handler. Called by ActionViewVerses for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionViewVerses_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      if ( Program.Settings.CurrentView == ViewModeType.Verses ) return;
      SetView(ViewModeType.Verses);
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
      if ( Program.Settings.CurrentView == ViewModeType.Translations ) return;
      SetView(ViewModeType.Translations);
      UpdateViewTranslations();
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
      if ( Program.Settings.CurrentView == ViewModeType.Text ) return;
      SetView(ViewModeType.Text);
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
      if ( Program.Settings.CurrentView == ViewModeType.ELS50 ) return;
      SetView(ViewModeType.ELS50);
    }

    /// <summary>
    /// Event handler. Called by ActionViewSearch for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionViewSearch_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      if ( Program.Settings.CurrentView == ViewModeType.Search )
        RotateSearchTab();
      else
        SetView(ViewModeType.Search);
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
        EditLetters.Input.Focus();
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
      int book = CurrentReference.Book.Number;
      int chapter = CurrentReference.Chapter.Number;
      int verse = CurrentReference.Verse?.Number ?? 1;
      UpdateViews();
      RenderSearchResults();
      GoTo(book, chapter, verse);
    }

    /// <summary>
    /// Event handler. Called by ActionCloseWindows for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionCloseWindows_Click(object sender, EventArgs e)
    {
      bool value = Program.Settings.CloseSearchTranslatedFormReturnToReference;
      try
      {
        Program.Settings.CloseSearchTranslatedFormReturnToReference = false;
        foreach ( var form in SearchTranslatedForm.Forms.ToList() )
          form.Close();
      }
      finally
      {
        Program.Settings.CloseSearchTranslatedFormReturnToReference = value;
      }
    }

    /// <summary>
    /// Event handler. Called by ActionCopyToClipboard for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionCopyToClipboard_Click(object sender, EventArgs e)
    {
      switch ( Program.Settings.CurrentView )
      {
        case ViewModeType.Translations:
          Clipboard.SetText(EditTranslations.Text);
          break;
        case ViewModeType.Text:
          Clipboard.SetText(EditRawText.Text);
          break;
        case ViewModeType.ELS50:
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
      if ( GrammarGuideForm.Instance.WindowState == FormWindowState.Minimized )
        GrammarGuideForm.Instance.WindowState = FormWindowState.Normal;
      GrammarGuideForm.Instance.Show();
      GrammarGuideForm.Instance.BringToFront();
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
      IsLoadingData = true;
      try
      {
        int book = CurrentReference.Book.Number;
        int chapter = CurrentReference.Chapter.Number;
        int verse = CurrentReference.Verse?.Number ?? 1;
        BooksTableAdapter.Fill(DataSet.Books);
        InitBooksCombobox();
        Bookmarks.Load();
        UpdateBookmarks();
        GoTo(book, chapter, verse);
      }
      finally
      {
        IsLoadingData = false;
      }
    }

    /// <summary>
    /// Event handler. Called by ActionViewStatistics for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionViewStatistics_Click(object sender, EventArgs e)
    {
      var reference = StatisticsForm.Run();
      if ( reference != null ) GoTo(reference);
    }

    /// <summary>
    /// Event handler. Called by ActionStartHebrewLetters for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionStartHebrewLetters_Click(object sender, EventArgs e)
    {
      Program.RunShell(Program.Settings.HebrewLettersExe);
    }

    /// <summary>
    /// Event handler. Called by ActionOpenWebsiteURL for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionOpenWebsiteURL_Click(object sender, EventArgs e)
    {
      string url = (string)( (ToolStripItem)sender ).Tag;
      SystemManager.OpenWebLink(url);
    }

    /// <summary>
    /// Event handler. Called by ActionNew for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionNew_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      if ( DisplayManager.QueryYesNo(Localizer.BackupBeforeRestoreText.GetLang()) )
        ActionBackup.PerformClick();
      if ( !DisplayManager.QueryYesNo(Localizer.NewDatabaseAdvertText.GetLang()) )
        return;
      string filename = AboutBox.Instance.AssemblyTitle.Replace(" ", "-") + Program.DBFileExtension;
      ReLoadData(() =>
      {
        File.Delete(Program.UserDataFolderPath + filename);
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
      if ( DisplayManager.QueryYesNo(Localizer.BackupBeforeRestoreText.GetLang()) )
        ActionBackup.PerformClick();
      string filename = AboutBox.Instance.AssemblyTitle.Replace(" ", "-") + Program.DBFileExtension;
      if ( OpenFileDialogDB.ShowDialog() == DialogResult.Cancel )
        return;
      ReLoadData(() =>
      {
        File.Delete(Program.UserDataFolderPath + filename);
        File.Copy(OpenFileDialogDB.FileName, Program.UserDataFolderPath + filename);
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
      string filename = AboutBox.Instance.AssemblyTitle.Replace(" ", "-") + Program.DBFileExtension;
      SaveFileDialogDB.FileName = filename;
      if ( SaveFileDialogDB.ShowDialog() == DialogResult.Cancel ) return;
      if ( File.Exists(SaveFileDialogDB.FileName) ) File.Delete(SaveFileDialogDB.FileName);
      File.Copy(Program.UserDataFolderPath + filename, SaveFileDialogDB.FileName);
    }

    /// <summary>
    /// Event handler. Called by ActionOpenBackupPath for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionOpenBackupPath_Click(object sender, EventArgs e)
    {
      Program.RunShell(Program.Settings.BackupPath);
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
    /// Event handler. Called by ActionPreferences for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionPreferences_Click(object sender, EventArgs e)
    {
      bool refresh = PreferencesForm.Run();
      InitializeDialogsDirectory();
      UpdateBookmarks();
      UpdateHistory();
      if ( refresh )
      {
        Refresh();
        UpdateViewVerses();
        UpdatePagingCount();
        RenderSearchResults();
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
      if ( DisplayManager.QueryYesNo(Localizer.RestoreWinPosText.GetLang()) )
      {
        Program.Settings.RestoreMainForm();
        ActionRefresh.PerformClick();
      }
    }

    /// <summary>
    /// Event handler. Called by EditScreenPosition for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    internal void EditScreenPosition_Click(object sender, EventArgs e)
    {
      DoScreenPosition(sender, e);
    }

    /// <summary>
    /// Event handler. Called by ActionAbout for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionAbout_Click(object sender, EventArgs e)
    {
      if ( AboutBox.Instance.Visible )
        AboutBox.Instance.BringToFront();
      else
        AboutBox.Instance.ShowDialog();
    }

    /// <summary>
    /// Event handler. Called by ActionHelp for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionHelp_Click(object sender, EventArgs e)
    {
      Program.RunShell(Program.HelpFilename);
    }

    /// <summary>
    /// Event handler. Called by ActionWebHome for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionWebHome_Click(object sender, EventArgs e)
    {
      AboutBox.Instance.OpenApplicationHome();
    }

    /// <summary>
    /// Event handler. Called by ActionWebContact for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionWebContact_Click(object sender, EventArgs e)
    {
      AboutBox.Instance.OpenContactPage();
    }

    /// <summary>
    /// Event handler. Called by ActionWebCheckUpdate for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionWebCheckUpdate_Click(object sender, EventArgs e)
    {
      CheckUpdate(false);
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
      DoExportBook();
    }

    /// <summary>
    /// Event handler. Called by ActionExportChapter for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionExportChapter_Click(object sender, EventArgs e)
    {
      DoExportChapter();
    }

    /// <summary>
    /// Event handler. Called by ActionSearchVerse for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionSearchVerse_Click(object sender, EventArgs e)
    {
      GoToVerse();
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
      if ( ComboBoxMutex ) return;
      ComboBoxMutex = true;
      try
      {
        ActionSave.PerformClick();
        CurrentReference = new ReferenceItem(CurrentReference.Book.Number,
                                             ( (ChapterItem)SelectChapter.SelectedItem ).Chapter.Number,
                                             1);
        UpdateViews();
        GoTo(CurrentReference);
      }
      finally
      {
        ComboBoxMutex = false;
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
    /// Event handler. Called by EditSearchTranslation for text changed events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void EditSearchTranslation_TextChanged(object sender, EventArgs e)
    {
      UpdateSearchButtons();
    }

    /// <summary>
    /// Event handler. Called by ActionClearWord for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionClearWord_Click(object sender, EventArgs e)
    {
      EditLetters.Input.Text = "";
      EditSearchTranslation.Text = "";
      InitSearchResults();
      UpdateSearchButtons();
      RenderSearchResults();
    }

    /// <summary>
    /// Event handler. Called by ActionSearchWord click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionSearchWord_Click(object sender, EventArgs e)
    {
      CreateSearchResults();
    }

    /// <summary>
    /// Event handler. Called by PanelViewVerses mouse click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void PanelViewVerses_MouseClick(object sender, MouseEventArgs e)
    {
      PanelViewVerses.Focus();
    }

    /// <summary>
    /// Event handler. Called by PanelSearchResults mouse click events.
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
      DoExportVerse(sender);
    }

    /// <summary>
    /// Event handler. Called by ActionCopyTranslation for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionCopyTranslation_Click(object sender, EventArgs e)
    {
      var verse = ( (ReferenceItem)( (Control)ContextMenuStripVerse.SourceControl.Tag ).Tag ).Verse;
      Clipboard.SetText(verse.GetTranslation());
    }

    /// <summary>
    /// Event handler. Called by ActionSetAsBookmarkMaster for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionSetAsBookmarkMaster_Click(object sender, EventArgs e)
    {
      Program.Settings.BookmarkMasterBook = CurrentReference.Book.Number;
      Program.Settings.BookmarkMasterChapter = CurrentReference.Chapter.Number;
      Program.Settings.BookmarkMasterVerse = Convert.ToInt32(ContextMenuStripVerse.SourceControl.Text);
      Program.Settings.Store();
      UpdateBookmarks();
    }

    /// <summary>
    /// Event handler. Called by ActionAddToBookmarks for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionAddToBookmarks_Click(object sender, EventArgs e)
    {
      int index = Convert.ToInt32(ContextMenuStripVerse.SourceControl.Text) - 1;
      var item = new ReferenceItem(CurrentReference.Book.Number,
                                   CurrentReference.Chapter.Number,
                                   CurrentReference.Chapter.GetVersesRows()[index].Number);
      Bookmarks.Add(item);
      UpdateBookmarks();
    }

    /// <summary>
    /// Event handler. Called by ActionClearBookmarks for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionClearBookmarks_Click(object sender, EventArgs e)
    {
      Program.Settings.BookmarkMasterBook = 1;
      Program.Settings.BookmarkMasterChapter = 1;
      Program.Settings.BookmarkMasterVerse = 1;
      Bookmarks.Clear();
      Program.Settings.Store();
      Bookmarks.Save();
      UpdateBookmarks();
    }

    /// <summary>
    /// Event handler. Called by ActionImportConsole for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionImportConsole_Click(object sender, EventArgs e)
    {
      DisplayManager.ShowAdvert(Localizer.NotYetAvailableText.GetLang());
    }

    /// <summary>
    /// Search a hebrew word.
    /// </summary>
    /// <param name="word"></param>
    public void SearchWord(string word)
    {
      ActionViewSearch.PerformClick();
      SelectSearchType.SelectedTab = SelectSearchTypeHebrew;
      EditLetters.Input.Text = Letters.SetFinale(word, false);
      EditLetters.Input.SelectionStart = EditLetters.Input.TextLength;
    }

    /// <summary>
    /// Event handler. Called by ActionSearchNavigateFirst for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionSearchNavigateFirst_Click(object sender, EventArgs e)
    {
      if ( RenderSearchResultsInProcess ) return;
      PagingCurrent = 1;
      RenderSearchResults();
    }

    /// <summary>
    /// Event handler. Called by ActionSearchNavigatePrevious for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionSearchNavigatePrevious_Click(object sender, EventArgs e)
    {
      if ( RenderSearchResultsInProcess ) return;
      PagingCurrent--;
      RenderSearchResults();
    }

    /// <summary>
    /// Event handler. Called by ActionSearchNavigateNext for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionSearchNavigateNext_Click(object sender, EventArgs e)
    {
      if ( RenderSearchResultsInProcess ) return;
      PagingCurrent++;
      RenderSearchResults();
    }

    /// <summary>
    /// Event handler. Called by ActionSearchNavigateLast for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionSearchNavigateLast_Click(object sender, EventArgs e)
    {
      if ( RenderSearchResultsInProcess ) return;
      PagingCurrent = PagingCount;
      RenderSearchResults();
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
          RenderSearchResults();
        else
          EditSearchPaging.Text = SelectSearchPaging.Value + "/" + PagingCount;
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
      if ( PreviousSeachPagingPosition != SelectSearchPaging.Value)
        RenderSearchResults();
      PreviousSeachPagingPosition = -1;
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
  }

}
