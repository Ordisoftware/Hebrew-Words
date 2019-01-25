/// <license>
/// This file is part of Ordisoftware Hebrew Letters.
/// Copyright 2016-2019 Olivier Rogier.
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
/// <edited> 2019-01 </edited>
using Microsoft.Win32;
using Ordisoftware.Core;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
    /// INdicate filename of the help file.
    /// </summary>
    static public readonly string HelpFilename
      = Directory.GetParent(Path.GetDirectoryName(Application.ExecutablePath.Replace("\\Debug\\", "\\").Replace("\\Release\\", "\\"))).FullName + Path.DirectorySeparatorChar
      + "Help" + Path.DirectorySeparatorChar
      + "index.htm";

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
    /// INdicate last showned tooltip.
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

    private void MainForm_Shown(object sender, EventArgs e)
    {
      Refresh();
      Cursor = Cursors.WaitCursor;
      try
      {
        CreateDatabaseIfNotExists();
        BooksTableAdapter.Fill(DataSet.Books);
        WordsTableAdapter.Fill(DataSet.Words);
        VersesTableAdapter.Fill(DataSet.Verses);
        ChaptersTableAdapter.Fill(DataSet.Chapters);
        InitBooksCombobox();
      }
      finally
      {
        Cursor = Cursors.Default;
      }
    }

    private class BookItem
    {
      public Data.DataSet.BooksRow Row { get; set; }
      public override string ToString() { return Row.Name; }
    }

    private class ChapterItem
    {
      public Data.DataSet.ChaptersRow Row { get; set; }
      public override string ToString() { return Row.Number.ToString(); }
    }

    private void InitBooksCombobox()
    {
      EditBook.Items.Clear();
      foreach ( Data.DataSet.BooksRow book in DataSet.Books.Rows )
        EditBook.Items.Add(new BookItem() { Row = book });
      EditBook.SelectedIndex = 0;
    }

    private void InitChaptersCombobox()
    {
      if ( EditBook.SelectedItem == null ) return;
      EditChapter.Items.Clear();
      foreach ( Data.DataSet.ChaptersRow chapter in ( (BookItem)EditBook.SelectedItem ).Row.GetChaptersRows() )
        EditChapter.Items.Add(new ChapterItem() { Row = chapter });
      EditChapter.SelectedIndex = 0;
    }

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
    /// Event handler. Called by ActionViewSearch for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionViewSearch_Click(object sender, EventArgs e)
    {
      if ( DataSet.HasChanges() ) TableAdapterManager.UpdateAll(DataSet);
      SetView(ViewModeType.Verses);
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
          process.StartInfo.FileName = HelpFilename;
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
    /// Event handler. Called by ActionExit for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void ActionExit_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void EditBook_SelectedIndexChanged(object sender, EventArgs e)
    {
      InitChaptersCombobox();
    }

    private void EditChapter_SelectedIndexChanged(object sender, EventArgs e)
    {
      UpdateView();
    }

    private void HebrewWordClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      using ( var process = new Process() )
        try
        {
          process.StartInfo.FileName = @"c:\Program Files\Ordisoftware\Hebrew Letters\Bin\Ordisoftware.HebrewLetters.exe";
          process.StartInfo.Arguments = (sender as LinkLabel).Text;
          process.Start();
        }
        catch ( Exception ex )
        {
          DisplayManager.ShowError(ex.Message);
        }
    }

    private void UpdateView()
    {
      EditELS50.Text = ( (ChapterItem)EditChapter.SelectedItem ).Row.ELS50;
      EditVerses.SuspendLayout();
      try
      {
        EditVerses.Controls.Clear();
        var control = new WordControl();
        int dx = control.Width;
        int dy = control.Height;
        int marginX = 50 + 10;
        int marginY = 50;
        int x = EditVerses.Size.Width - dx - marginX;
        int y = 10;
        foreach ( var verse in ( (ChapterItem)EditChapter.SelectedItem ).Row.GetVersesRows() )
        {
          var label = new Label();
          label.AutoSize = false;
          label.Width = 40;
          label.Font = new Font("Calibri", 12f, FontStyle.Bold);
          label.Location = new Point(x + dx + 0, y);
          label.Text = verse.Number.ToString();
          EditVerses.Controls.Add(label);
          bool emptyline = false;
          foreach ( var word in verse.GetWordsRows() )
          {
            emptyline = false;
            control = new WordControl();
            control.HebrewClicked += HebrewWordClicked;
            control.Word = word;
            control.Location = new Point(x, y);
            EditVerses.Controls.Add(control);
            x -= dx;
            if ( x < 10 )
            {
              x = EditVerses.Size.Width - dx - marginX;
              y += dy;
              emptyline = true;
            }
          }
          if (emptyline) y -= dy;
          x = EditVerses.Size.Width - dx - marginX;
          y = y + dy + marginY;
        }
      }
      finally
      {
        EditVerses.ResumeLayout();
      }
    }

  }

}