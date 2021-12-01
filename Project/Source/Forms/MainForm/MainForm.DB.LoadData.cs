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
/// <edited> 2021-04 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class MainForm : Form
{

  private void OnLoadingData(string caption)
  {
    LoadingForm.Instance.DoProgress(operation: "Loading book: " + caption);
  }

  /// <summary>
  /// Load data from database fro the first time.
  /// </summary>
  private void LoadData()
  {
    try
    {
      LoadingForm.Instance.Initialize("", 39, quantify: false);
      DBApp.LoadingData += OnLoadingData;
      DBApp.Open();
      DBApp.LoadingData -= OnLoadingData;
      LoadingForm.Instance.Hide();
      Thread.Sleep(5000);
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
  /// Show a splash screen while loading data.
  /// </summary>
  private void PopulateData()
  {
    SetFormDisabled(true);
    Globals.IsLoadingData = true;
    try
    {
      CreateSchemaIfNotExists();
      CreateDataIfNotExists();
      //process(DataSet.StrongConcordances, StrongConcordancesTableAdapter);
      process(DataSet.Books, () => BooksTableAdapter.Fill(DataSet.Books));
      process(DataSet.Chapters, () => ChaptersTableAdapter.Fill(DataSet.Chapters));
      process(DataSet.Verses, () => VersesTableAdapter.Fill(DataSet.Verses));
      process(DataSet.Words, () => WordsTableAdapter.Fill(DataSet.Words));
      InitBooksCombobox();
      //if ( NeedUpgradeForConcordances )
      ImportWordsConcordances();
    }
    finally
    {
      Globals.IsLoadingData = false;
      LoadingForm.Instance.Hide();
      SetFormDisabled(false);
    }
    void process(DataTable table, Action action)
    {
      string str = SysTranslations.ProgressLoadingData.GetLang() + " " + table.TableName;
      LoadingForm.Instance.Initialize(str, LockFileConnection.GetRowsCount(table.TableName) * 2);
      table.RowChanged += update;
      table.BeginLoadData();
      action();
      table.EndLoadData();
      table.RowChanged -= update;
    }
    void update(object sender, DataRowChangeEventArgs e)
    {
      if ( !Globals.IsGenerating ) LoadingForm.Instance.DoProgress();
    }
  }

}
