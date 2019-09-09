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
using System.IO;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

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

    public bool IsLoading { get; private set; }

    /// <summary>
    /// Indicate last showned tooltip.
    /// </summary>
    private ToolTip _LastToolTip = new ToolTip();

    public ReferenceItem CurrentReference { get; private set; }

    /// <summary>
    /// Default constructor.
    /// </summary>
    private MainForm()
    {
      InitializeComponent();
      Text = AboutBox.Instance.AssemblyTitle;
      SystemEvents.SessionEnding += SessionEnding;
      CurrentReference = new ReferenceItem();
    }

    /// <summary>
    /// Event handler. Called by MainForm for load events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void MainForm_Load(object sender, EventArgs e)
    {
      Program.Settings.Retrieve();
    }

    /// <summary>
    /// Event handler. Called by MainForm for shown events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void MainForm_Shown(object sender, EventArgs e)
    {
      IsLoading = true;
      OpenFileDialogDB.InitialDirectory = Program.UserDocumentsFolder;
      SaveFileDialogDB.InitialDirectory = Program.UserDocumentsFolder;
      SaveFileDialogWord.InitialDirectory = Program.UserDocumentsFolder;
      SaveFileDialogRTF.InitialDirectory = Program.UserDocumentsFolder;
      CheckUpdate(true);
      DoBackupDB();
      LoadData();
      TimerAutoSave.Enabled = Program.Settings.AutoSaveDelay != 0;
      if ( TimerAutoSave.Enabled )
        TimerAutoSave.Interval = Program.Settings.AutoSaveDelay * 60 * 1000;
      LoadBookmarks();
      UpdateBookmarks();
      IsLoading = false;
      GoTo(Program.Settings.BookmarkMasterBook, 
           Program.Settings.BookmarkMasterChapter, 
           Program.Settings.BookmarkMasterVerse);
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
    /// Show a splash screen chile loading data.
    /// </summary>
    private void LoadData()
    {
      Refresh();
      var form = new LoadingForm();
      form.ProgressBar.Maximum = 6;
      form.Show();
      form.Refresh();
      SetFormDisabled(true);
      try
      {
        form.ProgressBar.Value = 1;
        CreateDatabaseIfNotExists();
        form.ProgressBar.Value = 2;
        BooksTableAdapter.Fill(DataSet.Books);
        form.ProgressBar.Value = 3;
        WordsTableAdapter.Fill(DataSet.Words);
        form.ProgressBar.Value = 4;
        VersesTableAdapter.Fill(DataSet.Verses);
        form.ProgressBar.Value = 5;
        ChaptersTableAdapter.Fill(DataSet.Chapters);
        form.ProgressBar.Value = 6;
        InitBooksCombobox();
      }
      finally
      {
        form.Hide();
        SetFormDisabled(false);
        SetView(Program.Settings.CurrentView, true);
        ActionSave.Enabled = false;
      }
    }

    /// <summary>
    /// Initialize books combobox.
    /// </summary>
    internal void InitBooksCombobox()
    {
      SelectBook.Items.Clear();
      foreach ( Data.DataSet.BooksRow book in DataSet.Books.Rows )
        SelectBook.Items.Add(new BookItem() { Book = book });
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
        SelectChapter.Items.Add(new ChapterItem() { Chapter = chapter });
      SelectChapter.SelectedIndex = 0;
    }

    /// <summary>
    /// Event handler. Called by MainForm for form client size changed events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Form closing event information.</param>
    private void MainForm_ClientSizeChanged(object sender, EventArgs e)
    {
      InitChaptersCombobox();
    }

    /// <summary>
    /// Event handler. Called by MainForm for form closing events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Form closing event information.</param>
    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      ActionSave.PerformClick();
      if ( EditConfirmClosing.Checked )
        if ( !DisplayManager.QueryYesNo(Localizer.ExitApplicationText.GetLang()) )
        {
          e.Cancel = true;
          return;
        }
    }

    /// <summary>
    /// Event handler. Called by MainForm_Form for form closed events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Form closing event information.</param>
    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Program.Settings.Store();
    }

    /// <summary>
    /// Session ending.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Session ending event information.</param>
    private void SessionEnding(object sender, SessionEndingEventArgs e)
    {
      Close();
    }

    /// <summary>
    /// Check if a newer version is available.
    /// </summary>
    private void CheckUpdate(bool auto)
    {
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
      var item = (ToolStripItem)_LastToolTip.Tag;
      var location = new Point(item.Bounds.Left, item.Bounds.Top + ActionExit.Height + 5);
      _LastToolTip.Tag = sender;
      _LastToolTip.Show(item.ToolTipText, ToolStrip, location, 3000);
      TimerTooltip.Enabled = false;
    }

    /// <summary>
    /// Show tooltip on mouse enter event.
    /// </summary>
    private void ShowToolTipOnMouseEnter(object sender, EventArgs e)
    {
      if ( !EditShowTips.Checked ) return;
      if ( !( sender is ToolStripItem ) ) return;
      if ( _LastToolTip.Tag == sender ) return;
      _LastToolTip.Tag = sender;
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
      _LastToolTip.Tag = null;
      _LastToolTip.Hide(ToolStrip);
    }

    /// <summary>
    /// Event handler. Called by ActionViewVerses for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionViewVerses_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      SetView(ViewModeType.Verses);
    }

    /// <summary>
    /// Event handler. Called by ActionViewTranslations for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionViewTranslations_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      SetView(ViewModeType.Translations);
      UpdateViewTranslations();
    }

    /// <summary>
    /// Event handler. Called by ActionViewELS50 for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionViewELS50_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      SetView(ViewModeType.ELS50);
    }

    /// <summary>
    /// Event handler. Called by ActionViewRawText for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionViewRawText_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      SetView(ViewModeType.Text);
    }

    /// <summary>
    /// Event handler. Called by ActionView for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionViewSearch_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      SetView(ViewModeType.Search);
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
    /// Event handler. Called by ActionViewBooksTranslation for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionViewBooksTranslation_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      new EditBooksForm().ShowDialog();
      BooksTableAdapter.Fill(DataSet.Books);
      InitBooksCombobox();
    }

    /// <summary>
    /// Event handler. Called by ActionViewStatistics for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionViewStatistics_Click(object sender, EventArgs e)
    {
      new StatisticsForm().ShowDialog();
    }

    /// <summary>
    /// Event handler. Called by ActionNew for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionNew_Click(object sender, EventArgs e)
    {
      ActionSave.PerformClick();
      if ( !DisplayManager.QueryYesNo(Localizer.NewDatabaseAdvertText.GetLang()) )
        return;
      if ( DisplayManager.QueryYesNo(Localizer.BackupBeforeRestoreText.GetLang()) )
        ActionBackup.PerformClick();
      string filename = AboutBox.Instance.AssemblyTitle.Replace(" ", "-") + Program.DBFileExtension;
      DataSet.Clear();
      File.Delete(Program.UserDataFolder + filename);
      LoadData();
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
      DataSet.Clear();
      File.Delete(Program.UserDataFolder + filename);
      File.Copy(OpenFileDialogDB.FileName, Program.UserDataFolder + filename);
      LoadData();
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
      if ( SaveFileDialogDB.ShowDialog() == DialogResult.Cancel ) return;
      if ( File.Exists(SaveFileDialogDB.FileName) ) File.Delete(SaveFileDialogDB.FileName);
      File.Copy(Program.UserDataFolder + filename, SaveFileDialogDB.FileName);
    }

    /// <summary>
    /// Event handler. Called by ActionSave for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionSave_Click(object sender, EventArgs e)
    {
      if ( DataSet.HasChanges() ) TableAdapterManager.UpdateAll(DataSet);
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
      new PreferencesForm().ShowDialog();
      
    }

    /// <summary>
    /// Event handler. Called by ActionResetWinSettings for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionResetWinSettings_Click(object sender, EventArgs e)
    {
      if ( DisplayManager.QueryYesNo(Localizer.RestoreWinPosText.GetLang()) )
        Program.Settings.RestoreMainForm();
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
      using ( var process = new Process() )
        try
        {
          process.StartInfo.FileName = Program.HelpFilename;
          process.Start();
        }
        catch ( Exception ex )
        {
          DisplayManager.ShowError(ex.Message);
        }
    }

    /// <summary>
    /// Event handler. Called by ActionApplicationHome for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionApplicationHome_Click(object sender, EventArgs e)
    {
      AboutBox.Instance.OpenApplicationHome();
    }

    /// <summary>
    /// Event handler. Called by ActionContact for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionContact_Click(object sender, EventArgs e)
    {
      AboutBox.Instance.OpenContactPage();
    }

    /// <summary>
    /// Event handler. Called by ActionCheckUpdate for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionCheckUpdate_Click(object sender, EventArgs e)
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
      var book = ( (BookItem)SelectBook.SelectedItem ).Book;
      switch ( Program.Settings.CurrentView )
      {
        case ViewModeType.Verses:
          SaveFileDialogWord.FileName = book.Name + ".docx";
          if ( SaveFileDialogWord.ShowDialog() == DialogResult.Cancel ) return;
          Cursor = Cursors.WaitCursor;
          var form = new ExportForm();
          SetFormDisabled(true);
          try
          {
            form.ProgressBar.Value = 0;
            form.ProgressBar.Maximum = SelectChapter.Items.Count;
            form.Show();
            form.Refresh();
            Func<bool> showProgress = () =>
            {
              form.ProgressBar.PerformStep();
              Application.DoEvents();
              return form.CancelRequired;
            };
            ExportDocX.Run(SaveFileDialogWord.FileName, book, true, showProgress);
          }
          finally
          {
            form.Close();
            SetFormDisabled(false);
          }
          break;
        case ViewModeType.Text:
          SaveFileDialogRTF.FileName = book.Name + " Hebrew.rtf";
          if ( SaveFileDialogRTF.ShowDialog() == DialogResult.Cancel ) return;
          EditRawText.SaveFile(SaveFileDialogRTF.FileName);
          break;
        case ViewModeType.ELS50:
          SaveFileDialogRTF.FileName = book.Name + " ELS50.rtf";
          if ( SaveFileDialogRTF.ShowDialog() == DialogResult.Cancel ) return;
          EditELS50All.SaveFile(SaveFileDialogRTF.FileName);
          break;
      }
    }

    /// <summary>
    /// Event handler. Called by ActionExportChapter for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionExportChapter_Click(object sender, EventArgs e)
    {
      var book = ( (BookItem)SelectBook.SelectedItem ).Book;
      var chapter = ( (ChapterItem)SelectChapter.SelectedItem ).Chapter;
      switch ( Program.Settings.CurrentView )
      {
        case ViewModeType.Verses:
          SaveFileDialogWord.FileName = book.Name + " " + chapter.Number + ".docx";
          if ( SaveFileDialogWord.ShowDialog() == DialogResult.Cancel ) return;
          SetFormDisabled(true);
          try
          {
            ExportDocX.Run(SaveFileDialogWord.FileName, book, chapter, true);
          }
          finally
          {
            SetFormDisabled(false);
          }
          break;
        case ViewModeType.Translations:
          SaveFileDialogRTF.FileName = book.Name + " " + chapter.Number + " Translation.rtf";
          if ( SaveFileDialogRTF.ShowDialog() == DialogResult.Cancel ) return;
          EditTranslations.SaveFile(SaveFileDialogRTF.FileName);
          break;
      }
    }

    /// <summary>
    /// Event handler. Called by ActionSearchVerse for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionSearchVerse_Click(object sender, EventArgs e)
    {
      var form = new SelectVerseForm();
      form.EditVerseNumber.Maximum = ( (ChapterItem)SelectChapter.SelectedItem ).Chapter.GetVersesRows().Count();
      if ( form.ShowDialog() == DialogResult.OK )
      {
        int value = (int)form.EditVerseNumber.Value;
        if ( value > 0 )
          GoTo(SelectBook.SelectedIndex + 1, SelectChapter.SelectedIndex + 1, value);
        else
        {
          Data.DataSet.VersesRow found = null;
          var list = ( (ChapterItem)SelectChapter.SelectedItem ).Chapter.GetVersesRows();
          foreach ( Data.DataSet.VersesRow verse in list )
          {
            string str = "";
            foreach ( Data.DataSet.WordsRow word in verse.GetWordsRows() )
              str += word.Translation;
            if ( str == "" )
            {
              found = verse;
              break;
            }
          }
          if ( found != null )
            GoTo(SelectBook.SelectedIndex + 1, SelectChapter.SelectedIndex + 1, found.Number);
          else
            GoTo(SelectBook.SelectedIndex + 1, SelectChapter.SelectedIndex + 1, 1);
        }
      }
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
      CurrentReference.Book = ( (BookItem)SelectBook.SelectedItem ).Book;
      InitChaptersCombobox();
    }

    /// <summary>
    /// Event handler. Called by SelectChapter for selected index changed events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void SelectChapter_SelectedIndexChanged(object sender, EventArgs e)
    {
      CurrentReference.Chapter = ( (ChapterItem)SelectChapter.SelectedItem ).Chapter;
      if ( !IsGotoRunning ) UpdateViews();
      SetView(Program.Settings.CurrentView, true);
      ActionSave.PerformClick();
    }

    /// <summary>
    /// Event handler. Called by PanelLetterSearch key press events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void PanelLetterSearch_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ( e.KeyChar == '\r' ) ActionSearchWord.PerformClick();
    }

    /// <summary>
    /// Event handler. Called by ActionClearWord click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionClearWord_Click(object sender, EventArgs e)
    {
      EditLetters.Input.Text = "";
      ActionSearchWord.PerformClick();
    }

    /// <summary>
    /// Event handler. Called by ActionSearchWord click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionSearchWord_Click(object sender, EventArgs e)
    {
      UpdateViewSearch();
    }

    /// <summary>
    /// Event handler. Called by PanelViewVerses click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void PanelViewVerses_MouseClick(object sender, MouseEventArgs e)
    {
      PanelViewVerses.Focus();
    }

    private bool IsGotoRunning = false;


    /// <summary>
    /// Go to book / chapter / verse into view verses panel.
    /// </summary>
    /// <param name="book"></param>
    /// <param name="chapter"></param>
    /// <param name="verse"></param>
    public void GoTo(int book, int chapter, int verse)
    {
      var reference = new ReferenceItem();
      reference.Book = DataSet.Books[book - 1];
      reference.Chapter = reference.Book.GetChaptersRows()[chapter - 1];
      reference.Verse = reference.Chapter.GetVersesRows()[verse - 1];
      GoTo(reference);
    }

    /// <summary>
    /// Go to book / chapter / verse into view verses panel.
    /// </summary>
    /// <param name="reference">ReferenceItem instance.</param>
    public void GoTo(ReferenceItem reference)
    {
      if ( reference == null ) return;
      SetView(ViewModeType.Verses);
      IsGotoRunning = true;
      bool updated = false;
      try
      {
        if ( SelectBook.SelectedIndex != reference.Book.Number - 1 )
        {
          SelectBook.SelectedIndex = reference.Book.Number - 1;
          updated = true;
        }
        if ( SelectChapter.SelectedIndex != reference.Chapter.Number - 1 )
        {
          SelectChapter.SelectedIndex = reference.Chapter.Number - 1;
          updated = true;
        }
      }
      finally
      {
        IsGotoRunning = false;
      }
      if ( updated )
        UpdateViews();
      if ( reference.Verse != null )
        foreach ( var control in PanelViewVerses.Controls )
          if ( control is Label )
          {
            var label = control as Label;
            if ( label.Text == reference.Verse.Number.ToString() )
            {
              PanelViewVerses.Focus();
              PanelViewVerses.ScrollControlIntoView(label);
              PanelViewVerses.ScrollControlIntoView((TextBox)label.Tag);
              break;
            }
          }
      CurrentReference = reference;
    }

    public void SearchWord(string word)
    {
      ActionViewSearch.PerformClick();
      EditLetters.Input.Text = word;
    }

    private Control GetMenuItemSourceControl(object sender)
    {
      if ( !( sender is ToolStripMenuItem ) ) throw new Exception("Wrong sender type: ToolStripMenuItem expected.");
      return ( (ContextMenuStrip)( (ToolStripMenuItem)sender ).Owner ).SourceControl;
    }

    private void ActionOpenVerseOnline_Click(object sender, EventArgs e)
    {
      int verse;
      if ( sender is Label )
        verse = Convert.ToInt32(( (Label)sender ).Text);
      else
      if ( sender is ToolStripMenuItem )
        verse = Convert.ToInt32(GetMenuItemSourceControl(sender).Text);
      else
        throw new Exception("Wrong sender type: Label or ToolStripMenuItem expected.");
      Program.OpenOnlineVerse((Books)SelectBook.SelectedIndex, SelectChapter.SelectedIndex + 1, verse);
    }

    private void ActionExportVerse_Click(object sender, EventArgs e)
    {
      var book = ( (BookItem)SelectBook.SelectedItem ).Book;
      var chapter = ( (ChapterItem)SelectChapter.SelectedItem ).Chapter;
      int verse = Convert.ToInt32(GetMenuItemSourceControl(sender).Text);
      SaveFileDialogWord.FileName = book.Name + " " + chapter.Number + "." + verse-- + ".docx";
      if ( SaveFileDialogWord.ShowDialog() == DialogResult.Cancel ) return;
      ExportDocX.Run(SaveFileDialogWord.FileName, book, chapter, true, verse);
    }

    private void ActionSetAsBookmarkMaster_Click(object sender, EventArgs e)
    {
      Program.Settings.BookmarkMasterBook = ( (BookItem)SelectBook.SelectedItem ).Book.Number;
      Program.Settings.BookmarkMasterChapter = ( (ChapterItem)SelectChapter.SelectedItem ).Chapter.Number;
      int verse = Convert.ToInt32(GetMenuItemSourceControl(sender).Text);
      Program.Settings.BookmarkMasterVerse = verse;
      Program.Settings.Store();
      UpdateBookmarks();
    }

    private void ActionAddToBookmarks_Click(object sender, EventArgs e)
    {
      var item = new ReferenceItem();
      item.Book = CurrentReference.Book;
      item.Chapter = CurrentReference.Chapter;
      int index = Convert.ToInt32(GetMenuItemSourceControl(sender).Text) - 1;
      item.Verse = CurrentReference.Chapter.GetVersesRows()[index];
      AddBookmark(item);
      UpdateBookmarks();
    }

    private void ActionClearBookmarks_Click(object sender, EventArgs e)
    {
      Program.Settings.BookmarkMasterBook = 1;
      Program.Settings.BookmarkMasterChapter = 1;
      Program.Settings.BookmarkMasterVerse = 1;
      _Bookmarks.Clear();
      Program.Settings.Store();
      SaveBookmarks();
      UpdateBookmarks();
    }

  }

}
