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
/// <created> 2019-01 </created>
/// <edited> 2020-03 </edited>
using System;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Windows.Forms;
using Ordisoftware.Core;

namespace Ordisoftware.Hebrew.Words
{

  partial class MainForm : Form
  {

    /// <summary>
    /// Load data from database fro the first time.
    /// </summary>
    private void LoadData()
    {
      try
      {
        PopulateData();
      }
      catch ( Exception ex )
      {
        DisplayManager.ShowError(SysTranslations.ApplicationMustExit[Language.FR] + Globals.NL2 +
                                 SysTranslations.ContactSupport[Language.FR]);
        ex.Manage();
        Environment.Exit(-1);
      }
      try
      {
        Bookmarks.Load();
        UpdateBookmarks();
        History.Load();
        UpdateHistory();
        if ( Program.Settings.OpenLastViewAtStartup )
          SetView(Program.Settings.CurrentView, true);
        else
        {
          SetView(ViewMode.Verses, true);
          Program.Settings.CurrentSearchTypeTab = 0;
        }
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
      action?.Invoke();
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
      void update(object sender, DataRowChangeEventArgs e)
      {
        if ( !Globals.IsGenerating ) LoadingForm.Instance.DoProgress();
      };
      void load(DataTable table, Action action)
      {
        LoadingForm.Instance.Initialize(SysTranslations.ProgressLoadingData.GetLang() + " " + table.TableName,
                                        GetRowsCount(table.TableName) * 2);
        action();
      }
      SetFormDisabled(true);
      Globals.IsLoadingData = true;
      try
      {
        CreateSchemaIfNotExists();
        CreateDataIfNotExists();
        int step = 0;
        //DataSet.StrongConcordances.RowChanged += progress;
        DataSet.Books.RowChanged += update;
        DataSet.Chapters.RowChanged += update;
        DataSet.Verses.RowChanged += update;
        DataSet.Words.RowChanged += update;
        try
        {
          //DataSet.StrongConcordances.BeginLoadData();
          DataSet.Books.BeginLoadData();
          DataSet.Chapters.BeginLoadData();
          DataSet.Verses.BeginLoadData();
          DataSet.Words.BeginLoadData();
          //StrongConcordancesTableAdapter.Fill(DataSet.StrongConcordances);
          load(DataSet.Books, () => BooksTableAdapter.Fill(DataSet.Books));
          load(DataSet.Chapters, () => ChaptersTableAdapter.Fill(DataSet.Chapters));
          load(DataSet.Verses, () => VersesTableAdapter.Fill(DataSet.Verses));
          load(DataSet.Words, () => WordsTableAdapter.Fill(DataSet.Words));
          //DataSet.StrongConcordances.EndLoadData();
          DataSet.Books.EndLoadData();
          DataSet.Chapters.EndLoadData();
          DataSet.Verses.EndLoadData();
          DataSet.Words.EndLoadData();
          InitBooksCombobox();
          //if ( NeedUpgradeForConcordances ) ImportWordsConcordances();
        }
        finally
        {
          //DataSet.StrongConcordances.RowChanged -= progress;
          DataSet.Books.RowChanged -= update;
          DataSet.Chapters.RowChanged -= update;
          DataSet.Verses.RowChanged -= update;
          DataSet.Words.RowChanged -= update;
        }
      }
      finally
      {
        LoadingForm.Instance.Hide();
        Globals.IsLoadingData = false;
        SetFormDisabled(false);
      }
    }

  }

}
