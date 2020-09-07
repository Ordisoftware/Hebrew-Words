/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2020 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at 
/// https://mozilla.org/MPL/2.0/.
/// If it is not possible or desirable to put the notice in a particular file, 
/// then You may include the notice in a location(such as a LICENSE file in a 
/// relevant directory) where a recipient would be likely to look for such a notice.
/// You may add additional accurate notices of copyright ownership.
/// </license>
/// <created> 2019-01 </created>
/// <edited> 2020-03 </edited>
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Ordisoftware.Core;

namespace Ordisoftware.Hebrew.Words
{

  /// <summary>
  /// Form for viewing the preferences.
  /// </summary>
  /// <seealso cref="T:System.Windows.Forms.Form"/>
  public partial class PreferencesForm : Form
  {

    static private bool First;
    static private bool LanguageChanged;
    static private int CommentaryLinesCountPrevious;
    static private int WordControlWidthPrevious;
    static private int MaxrefCountPrevious;
    static private bool UpdateViewRequired;

    static public bool Run()
    {
      First = true;
      var form = new PreferencesForm();
      form.ShowDialog();
      while ( LanguageChanged )
      {
        LanguageChanged = false;
        form = new PreferencesForm();
        form.ShowDialog();
      }
      return UpdateViewRequired;
    }

    /// <summary>
    /// Default constructor.
    /// </summary>
    private PreferencesForm()
    {
      InitializeComponent();
      Icon = MainForm.Instance.Icon;
      // TODO init from helper
      EventHandler action1 = (sender, e) =>
      {
        EditOnlineVerseURL.Text = (string)( (ToolStripMenuItem)sender ).Tag;
      };
      EventHandler action2 = (sender, e) =>
      {
        EditOnlineSearch.Text = (string)( (ToolStripMenuItem)sender ).Tag;
      };
      foreach ( var item in ProvidersCollection.OnlineBibleProviders.Items )
        if ( item.Name == "-" )
          MenuSelectOnlineVerseURL.Items.Add(new ToolStripSeparator());
        else
          MenuSelectOnlineVerseURL.Items.Add(item.CreateMenuItem(action1));
      foreach ( var item in ProvidersCollection.OnlineWordProviders.Items )
        if ( item.Name == "-" )
          MenuSelectSearchRequest.Items.Add(new ToolStripSeparator());
        else
          MenuSelectSearchRequest.Items.Add(item.CreateMenuItem(action2));
    }

    /// <summary>
    /// Event handler. Called by PreferencesForm for load events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void PreferencesForm_Load(object sender, EventArgs e)
    {
      this.CenterToMainFormElseScreen();
    }

    /// <summary>
    /// Event handler. Called by PreferencesForm for shown events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void PreferencesForm_Shown(object sender, EventArgs e)
    {
      TopMost = MainForm.Instance.TopMost;
      BringToFront();
      UpdateLanguagesButtons();
      EditHebrewLettersPath.Text = Program.Settings.HebrewLettersExe;
      EditOnlineSearch.Text = Program.Settings.SearchOnlineURL;
      EditOnlineVerseURL.Text = Program.Settings.OpenVerseOnlineURL;
      EditBackupPath.Text = Program.Settings.BackupPath;
      EditBackupCount.Value = Program.Settings.BackupCount;
      EditAutoSaveDelay.Value = Program.Settings.AutoSaveDelay;
      EditCommentaryLinesCount.Value = Program.Settings.VerseCommentaryLinesCount;
      EditWordControlWidth.Value = Program.Settings.WordControlWidth;
      EditBookmarksCount.Value = Program.Settings.BookmarksCount;
      EditHistoryCount.Value = Program.Settings.HistoryCount;
      EditMaxRefCount.Value = Program.Settings.FoundReferencesViewable;
      EditMinRefCount.Value = Program.Settings.FoundReferencesToOpenDialog;
      SelectOpenHebrewLetters.Checked = Program.Settings.HebrewWordClickOpen == HebrewWordClickOpen.HebrewLetters;
      SelectOpenOnlineSearch.Checked = Program.Settings.HebrewWordClickOpen == HebrewWordClickOpen.OnlineSearch;
      SelectOpenTranslated.Checked = Program.Settings.HebrewWordClickOpen == HebrewWordClickOpen.SearchTranslated;
      SelectOpenNothing.Checked = Program.Settings.HebrewWordClickOpen == HebrewWordClickOpen.Nothing;
      if ( First )
      {
        CommentaryLinesCountPrevious = (int)EditCommentaryLinesCount.Value;
        WordControlWidthPrevious = (int)EditWordControlWidth.Value;
        MaxrefCountPrevious = (int)EditMaxRefCount.Value;
        First = false;
      }
    }

    /// <summary>
    /// Event handler. Called by PreferencesForm for closed events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void PreferencesForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Program.Settings.HebrewLettersExe = EditHebrewLettersPath.Text;
      Program.Settings.SearchOnlineURL = EditOnlineSearch.Text;
      Program.Settings.OpenVerseOnlineURL = EditOnlineVerseURL.Text;
      Program.Settings.BackupPath = EditBackupPath.Text.EndsWith(Path.DirectorySeparatorChar.ToString())
                                  ? EditBackupPath.Text
                                  : EditBackupPath.Text + Path.DirectorySeparatorChar;
      Program.Settings.BackupCount = (int)EditBackupCount.Value;
      Program.Settings.AutoSaveDelay = (int)EditAutoSaveDelay.Value;
      Program.Settings.VerseCommentaryLinesCount = (int)EditCommentaryLinesCount.Value;
      Program.Settings.WordControlWidth = (int)EditWordControlWidth.Value;
      Program.Settings.BookmarksCount = (int)EditBookmarksCount.Value;
      Program.Settings.HistoryCount = (int)EditHistoryCount.Value;
      Program.Settings.FoundReferencesViewable = (int)EditMaxRefCount.Value;
      Program.Settings.FoundReferencesToOpenDialog = (int)EditMinRefCount.Value;
      if ( SelectOpenHebrewLetters.Checked )
        Program.Settings.HebrewWordClickOpen = HebrewWordClickOpen.HebrewLetters;
      if ( SelectOpenOnlineSearch.Checked )
        Program.Settings.HebrewWordClickOpen = HebrewWordClickOpen.OnlineSearch;
      if ( SelectOpenTranslated.Checked )
        Program.Settings.HebrewWordClickOpen = HebrewWordClickOpen.SearchTranslated;
      if ( SelectOpenNothing.Checked )
        Program.Settings.HebrewWordClickOpen = HebrewWordClickOpen.Nothing;
      MainForm.Instance.TimerAutoSave.Enabled = Program.Settings.AutoSaveDelay != 0;
      if ( MainForm.Instance.TimerAutoSave.Enabled )
        MainForm.Instance.TimerAutoSave.Interval = Program.Settings.AutoSaveDelay * 60 * 1000;
      Program.Settings.Store();
      UpdateViewRequired = CommentaryLinesCountPrevious != (int)EditCommentaryLinesCount.Value
                        || WordControlWidthPrevious != (int)EditWordControlWidth.Value
                        || MaxrefCountPrevious != (int)EditMaxRefCount.Value;
    }

    private void UpdateLanguagesButtons()
    {
      if ( Program.Settings.LanguageSelected == Language.EN )
      {
        ActionSelectLangEN.BackColor = SystemColors.ControlLightLight;
        ActionSelectLangFR.BackColor = SystemColors.Control;
      }
      if ( Program.Settings.LanguageSelected == Language.FR )
      {
        ActionSelectLangFR.BackColor = SystemColors.ControlLightLight;
        ActionSelectLangEN.BackColor = SystemColors.Control;
      }
    }

    private void ActionSelectLangEN_Click(object sender, EventArgs e)
    {
      Program.Settings.LanguageSelected = Language.EN;
      Program.UpdateLocalization();
      UpdateLanguagesButtons();
      LanguageChanged = true;
      Close();
    }

    private void ActionSelectLangFR_Click(object sender, EventArgs e)
    {
      Program.Settings.LanguageSelected = Language.FR;
      Program.UpdateLocalization();
      UpdateLanguagesButtons();
      LanguageChanged = true;
      Close();
    }

    /// <summary>
    /// Event handler. Called by ActionReset for link clicked events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      if ( !DisplayManager.QueryYesNo(Localizer.AskToResetPreferences.GetLang()) ) return;
      Program.Settings.Reset();
      Program.Settings.Reload();
      Program.Settings.LanguageSelected = Languages.Current;
      Program.Settings.Store();
      Directory.CreateDirectory(Globals.UserDocumentsFolderPath);
      Program.Settings.BackupPath = Globals.UserDocumentsFolderPath;
      PreferencesForm_Shown(null, null);
      Program.GrammarGuideForm.CenterToMainFormElseScreen();
    }

    /// <summary>
    /// Event handler. Called by ActionSelectHebrewLettersPath for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionSelectHebrewLettersPath_Click(object sender, EventArgs e)
    {
      OpenFileDialog.InitialDirectory = Path.GetDirectoryName(EditHebrewLettersPath.Text);
      OpenFileDialog.FileName = Path.GetFileName(EditHebrewLettersPath.Text);
      if ( OpenFileDialog.ShowDialog() == DialogResult.OK )
        EditHebrewLettersPath.Text = OpenFileDialog.FileName;
    }

    /// <summary>
    /// Event handler. Called by ActionSelectBackupPath for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionSelectBackupPath_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog.SelectedPath = EditBackupPath.Text;
      if ( FolderBrowserDialog.ShowDialog() == DialogResult.OK )
        EditBackupPath.Text = FolderBrowserDialog.SelectedPath;
    }

    private void EditMaxRefCount_ValueChanged(object sender, EventArgs e)
    {
      EditMinRefCount.Maximum = EditMaxRefCount.Value;
    }

    private void ActionSelectOnlineSearch_Click(object sender, EventArgs e)
    {
      MenuSelectSearchRequest.Show(ActionSelectOnlineSearch, new Point(0, ActionSelectOnlineSearch.Height));
    }

    private void ActionSelectOnlineVerseURL_Click(object sender, EventArgs e)
    {
      MenuSelectOnlineVerseURL.Show(ActionSelectOnlineVerseURL, new Point(0, ActionSelectOnlineVerseURL.Height));
    }

    private void ActionOnlineVerseHelp_Click(object sender, EventArgs e)
    {
      DisplayManager.ShowInformation(Translations.OpenOnlineVerseNotice.GetLang());
    }

    private void ActionOnlineSearchHelp_Click(object sender, EventArgs e)
    {
      DisplayManager.ShowInformation(Translations.OpenOnlineSearchNotice.GetLang());
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      //Core.Diagnostics.Debugger.Active = EditEnableDebugger.Checked; + add load/shown
    }

  }

}
