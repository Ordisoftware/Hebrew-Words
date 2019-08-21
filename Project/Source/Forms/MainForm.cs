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
/// <edited> 2019-08 </edited>
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

    /// <summary>
    /// Indicate last showned tooltip.
    /// </summary>
    private ToolTip LastToolTip = new ToolTip();

    /// <summary>
    /// Default constructor.
    /// </summary>
    private MainForm()
    {
      InitializeComponent();
      Text = AboutBox.Instance.AssemblyTitle;
      SystemEvents.SessionEnding += SessionEnding;
    }

    /// <summary>
    /// Event handler. Called by MainForm for load events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void MainForm_Load(object sender, EventArgs e)
    {
      Program.Settings.Retrieve();
      SetView(Program.Settings.CurrentView, true);
    }

    /// <summary>
    /// Event handler. Called by MainForm for shown events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void MainForm_Shown(object sender, EventArgs e)
    {
      Refresh();
      var form = new LoadingForm();
      form.ProgressBar.Maximum = 6;
      form.Show();
      form.Refresh();
      Cursor = Cursors.WaitCursor;
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
        Cursor = Cursors.Default;
      }
      CheckUpdate(true);
    }

    /// <summary>
    /// Initialize books combobox.
    /// </summary>
    private void InitBooksCombobox()
    {
      SelectBook.Items.Clear();
      foreach ( Data.DataSet.BooksRow book in DataSet.Books.Rows )
        SelectBook.Items.Add(new BookItem() { Row = book });
      SelectBook.SelectedIndex = 0;
    }

    /// <summary>
    /// Initialize chapter combobox.
    /// </summary>
    private void InitChaptersCombobox()
    {
      if ( SelectBook.SelectedItem == null ) return;
      SelectChapter.Items.Clear();
      var list = ( (BookItem)SelectBook.SelectedItem ).Row.GetChaptersRows();
      foreach ( Data.DataSet.ChaptersRow chapter in list )
        SelectChapter.Items.Add(new ChapterItem() { Row = chapter });
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
      if ( DataSet.HasChanges() ) TableAdapterManager.UpdateAll(DataSet);
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

          string version = client.DownloadString(url);
          if ( version.CompareTo(AboutBox.Instance.AssemblyVersion) < 0 )
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
    /// Event handler. Called by ActionViewVerses for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionViewVerses_Click(object sender, EventArgs e)
    {
      if ( DataSet.HasChanges() ) TableAdapterManager.UpdateAll(DataSet);
      SetView(ViewModeType.Verses);
    }

    /// <summary>
    /// Event handler. Called by ActionViewTranslations for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionViewTranslations_Click(object sender, EventArgs e)
    {
      if ( DataSet.HasChanges() ) TableAdapterManager.UpdateAll(DataSet);
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
      if ( DataSet.HasChanges() ) TableAdapterManager.UpdateAll(DataSet);
      SetView(ViewModeType.ELS50);
    }

    /// <summary>
    /// Event handler. Called by ActionViewRawText for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionViewRawText_Click(object sender, EventArgs e)
    {
      SetView(ViewModeType.Text);
    }

    private void ActionViewSearch_Click(object sender, EventArgs e)
    {
      SetView(ViewModeType.Search);
    }

    /// <summary>
    /// Event handler. Called by ActionViewBooksTranslation for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionViewBooksTranslation_Click(object sender, EventArgs e)
    {
      if ( DataSet.HasChanges() ) TableAdapterManager.UpdateAll(DataSet);
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
    /// Event handler. Called by ActionBackup for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionBackup_Click(object sender, EventArgs e)
    {
      if ( DataSet.HasChanges() ) TableAdapterManager.UpdateAll(DataSet);
      string filename = "Hebrew-Words.sqlite";
      SaveFileDialogDB.FileName = filename;
      if ( SaveFileDialogDB.ShowDialog() == DialogResult.Cancel ) return;
      string pathSource = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Path.DirectorySeparatorChar
                        + AboutBox.Instance.AssemblyCompany + Path.DirectorySeparatorChar 
                        + AboutBox.Instance.AssemblyTitle + Path.DirectorySeparatorChar;
      File.Copy(pathSource + filename, SaveFileDialogDB.FileName);
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
      var book = ( (BookItem)SelectBook.SelectedItem ).Row;
      SaveFileDialogWord.FileName = book.Name + ".docx"; ;
      if ( SaveFileDialogWord.ShowDialog() == DialogResult.Cancel ) return;
      Cursor = Cursors.WaitCursor;
      var form = new ExportForm();
      try
      {
        form.ProgressBar.Value = 0;
        form.ProgressBar.Maximum = SelectChapter.Items.Count;
        form.Show();
        form.Refresh();
        Enabled = false;
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
        Cursor = Cursors.Default;
        Enabled = true;
        BringToFront();
      }
    }

    /// <summary>
    /// Event handler. Called by ActionExportChapter for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionExportChapter_Click(object sender, EventArgs e)
    {
      var book = ( (BookItem)SelectBook.SelectedItem ).Row;
      var chapter = ( (ChapterItem)SelectChapter.SelectedItem ).Row;
      SaveFileDialogWord.FileName = book.Name + " " + chapter.Number + ".docx"; ;
      if ( SaveFileDialogWord.ShowDialog() == DialogResult.Cancel ) return;
      Cursor = Cursors.WaitCursor;
      try
      {
        Enabled = false;
        ExportDocX.Run(SaveFileDialogWord.FileName, book, chapter, true);
      }
      finally
      {
        Cursor = Cursors.Default;
        Enabled = true;
        BringToFront();
      }
    }

    /// <summary>
    /// Event handler. Called by ActionFindVerse for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionFindVerse_Click(object sender, EventArgs e)
    {
      var form = new SelectVerseForm();
      form.EditVerseNumber.Maximum = ( (ChapterItem)SelectChapter.SelectedItem ).Row.GetVersesRows().Count();
      if ( form.ShowDialog() == DialogResult.OK )
      {
        int value = (int)form.EditVerseNumber.Value;
        if ( value > 0 )
          GoTo(SelectBook.SelectedIndex + 1, SelectChapter.SelectedIndex + 1, value);
        else
        {
          Data.DataSet.VersesRow found = null;
          var list = ( (ChapterItem)SelectChapter.SelectedItem ).Row.GetVersesRows();
          foreach ( Data.DataSet.VersesRow verse in list )
          {
            string str = "";
            foreach ( Data.DataSet.WordsRow word in verse.GetWordsRows() ) str += word.Translation;
              if ( str == "" )
              {
                found = verse;
                break;
              }
          }
          if (found != null)
            GoTo(SelectBook.SelectedIndex + 1, SelectChapter.SelectedIndex + 1, found.Number);
          else
            GoTo(SelectBook.SelectedIndex + 1, SelectChapter.SelectedIndex + 1, 1);
        }
      }
    }

    /// <summary>
    /// Event handler. Called by ActionCopyToClipboard for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionCopyToClipboard_Click(object sender, EventArgs e)
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
      InitChaptersCombobox();
      SetView(Program.Settings.CurrentView, true);
    }

    /// <summary>
    /// Event handler. Called by SelectChapter for selected index changed events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void SelectChapter_SelectedIndexChanged(object sender, EventArgs e)
    {
      UpdateViewVerses();
      UpdateViewTranslations();
      UpdateViewRawText();
      UpdateViewELS50();
      ActionSave.PerformClick();
    }

    /// <summary>
    /// Event handler. Called by WordControl for hebrew word mouse click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void HebrewWordMouseClick(object sender, MouseEventArgs e)
    {
      if ( e.Button == MouseButtons.Left )
        Program.OpenOnlineConcordance((string)( sender as Label ).Tag);
      else
      if ( e.Button == MouseButtons.Right )
      {
        string str = ( sender as Label ).Text;
        foreach ( var v in Letters.FinaleDisable ) str = str.Replace(v.Key, v.Value);
        Program.OpenHebrewLetters(str);
      }
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

    /// <summary>
    /// Go to book / chapter / verse into view verses panel.
    /// </summary>
    /// <param name="book"></param>
    /// <param name="chapter"></param>
    /// <param name="verse"></param>
    public void GoTo(int book, int chapter, int verse)
    {
      SetView(ViewModeType.Verses);
      SelectBook.SelectedIndex = book - 1;
      SelectChapter.SelectedIndex = chapter - 1;
      foreach ( var control in PanelViewVerses.Controls )
        if (control is Label)
        {
          var label = control as Label;
          if ( label.Text == verse.ToString() )
          {
            PanelViewVerses.Focus();
            PanelViewVerses.ScrollControlIntoView((TextBox)label.Tag);
            return;
          }
        }
    }

  }

  /// <summary>
  /// Provide book combobox item
  /// </summary>
  internal class BookItem
  {
    public Data.DataSet.BooksRow Row { get; set; }
    public override string ToString()
    {
      string str = Row.Number + ". " + Row.Name;
      if ( Row.Translation  != "" ) str += " (" + Row.Translation + ")";
      return str;
    }
  }

  /// <summary>
  /// Provide chapter combobox item
  /// </summary>
  internal class ChapterItem
  {
    public Data.DataSet.ChaptersRow Row { get; set; }
    public override string ToString()
    {
      return Row.Number.ToString();
    }
  }

}
