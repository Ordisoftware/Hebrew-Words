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
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Windows.Forms;
using Ordisoftware.Core;

namespace Ordisoftware.HebrewWords
{

  public partial class MainForm : Form
  {

    /// <summary>
    /// Load data from database fro the first time.
    /// </summary>
    private void LoadData()
    {
      try
      {

        PopulateData();
        if ( Program.Settings.OpenLastViewAtStartup )
          SetView(Program.Settings.CurrentView, true);
        else
        {
          SetView(ViewModeType.Verses, true);
          Program.Settings.CurrentSearchTypeTab = 0;
        }
        if ( Program.Settings.GoToMasterBookmarkAtStartup )
          GoTo(Program.Settings.BookmarkMasterBook,
               Program.Settings.BookmarkMasterChapter,
               Program.Settings.BookmarkMasterVerse,
               true);
        else
          GoTo(1, 1, 1, true);
        ActionSave.PerformClick();
      }
      catch ( OdbcException ex )
      {
        DisplayManager.ShowError(ex.Message);
        Application.Exit();
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
    }

    /// <summary>
    /// Reload data from database.
    /// </summary>
    private void ReLoadData(Action action = null)
    {
      ActionCloseWindows.PerformClick();
      ActionSearchClear.PerformClick();
      PanelViewVerses.AutoScrollPosition = new Point(0, 0);
      PanelSearchResults.AutoScrollPosition = new Point(0, 0);
      PanelViewVerses.Controls.Clear();
      PanelSearchResults.Controls.Clear();
      SearchResults = null;
      Refresh();
      DataSet.Clear();
      if (action != null) action();
      History.Clear();
      LoadData();
    }

    /// <summary>
    /// Get the rows count of a table.
    /// </summary>
    private int GetRowsCount(string tableName)
    {
      int count = 0;
      using ( var connection = new OdbcConnection(Program.Settings.ConnectionString) )
      {
        connection.Open();
        try
        {
          var command = new OdbcCommand("SELECT COUNT(ID) FROM [" + tableName + "]", connection);
          var reader = command.ExecuteReader();
          if ( reader.Read() ) count = (int)reader[0];
        }
        finally
        {
          connection.Close();
        }
      }
      return count;
    }

    /// <summary>
    /// Show a splash screen while loading data.
    /// </summary>
    private void PopulateData()
    {
      DataRowChangeEventHandler progress = null;
      var form = new LoadingForm();
      form.Show();
      form.Refresh();
      SetFormDisabled(true);
      IsLoadingData = true;
      try
      {
        CreateSchemaIfNotExists();
        CreateDataIfNotExists();
        form.Refresh();
        int rowsCount = GetRowsCount(DataSet.StrongConcordances.TableName)
                      + GetRowsCount(DataSet.Books.TableName)
                      + GetRowsCount(DataSet.Chapters.TableName)
                      + GetRowsCount(DataSet.Verses.TableName)
                      + GetRowsCount(DataSet.Words.TableName);
        int step = 0;
        form.ProgressBar.Maximum = rowsCount / PopulateDataPaging * 2;
        progress = (sender, e) =>
        {
          step++;
          if ( step < PopulateDataPaging ) return;
          form.ProgressBar.PerformStep();
          step = 0;
          Refresh();
          Application.DoEvents();
        };
        DataSet.StrongConcordances.RowChanged += progress;
        DataSet.Books.RowChanged += progress;
        DataSet.Chapters.RowChanged += progress;
        DataSet.Verses.RowChanged += progress;
        DataSet.Words.RowChanged += progress;
        try
        {
          DataSet.StrongConcordances.BeginLoadData();
          DataSet.Books.BeginLoadData();
          DataSet.Chapters.BeginLoadData();
          DataSet.Verses.BeginLoadData();
          DataSet.Words.BeginLoadData();
          StrongConcordancesTableAdapter.Fill(DataSet.StrongConcordances);
          BooksTableAdapter.Fill(DataSet.Books);
          ChaptersTableAdapter.Fill(DataSet.Chapters);
          VersesTableAdapter.Fill(DataSet.Verses);
          WordsTableAdapter.Fill(DataSet.Words);
          DataSet.StrongConcordances.EndLoadData();
          DataSet.Books.EndLoadData();
          DataSet.Chapters.EndLoadData();
          DataSet.Verses.EndLoadData();
          DataSet.Words.EndLoadData();
          InitBooksCombobox();
          Bookmarks.Load();
          UpdateBookmarks();
          History.Load();
          UpdateHistory();
          //if ( NeedUpgradeForConcordances ) ImportWordsConcordances();
        }
        finally
        {
          DataSet.StrongConcordances.RowChanged -= progress;
          DataSet.Books.RowChanged -= progress;
          DataSet.Chapters.RowChanged -= progress;
          DataSet.Verses.RowChanged -= progress;
          DataSet.Words.RowChanged -= progress;
        }
      }
      catch ( OdbcException ex )
      {
        DisplayManager.ShowError(ex.Message);
        Application.Exit();
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
      finally
      {
        IsLoadingData = false;
        form.Close();
        SetFormDisabled(false);
      }
    }

  }

}
