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
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class MainForm : Form
{

  /// <summary>
  /// Reload data from database.
  /// </summary>
  private void ReLoadData(Action actionBeforeRestart = null)
  {
    ActionCloseWindows.PerformClick();
    ActionSearchClear.PerformClick();
    PanelViewVerses.AutoScrollPosition = new Point(0, 0);
    PanelSearchResults.AutoScrollPosition = new Point(0, 0);
    PanelViewVerses.Controls.Clear();
    PanelSearchResults.Controls.Clear();
    SearchResults = null;
    Refresh();
    ApplicationDatabase.Instance.Close();
    actionBeforeRestart?.Invoke();
    ApplicationDatabase.Restart();
    LoadData();
    DoStartGoTo();
  }

  /// <summary>
  /// Load data from database fro the first time.
  /// </summary>
  private void LoadData()
  {
    Globals.ChronoLoadData.Start();
    try
    {
      try
      {
        PopulateData();
      }
      catch ( Exception ex )
      {
        Globals.ChronoLoadData.Stop();
        DisplayManager.ShowError(SysTranslations.ApplicationMustExit[Language.FR] + Globals.NL2 +
                                 SysTranslations.ContactSupport[Language.FR]);
        ex.Manage();
        Environment.Exit(-1);
      }
      try
      {
        Bookmarks.Load(UpdateBookmarks);
        History.Load(UpdateHistory);
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
        Globals.ChronoLoadData.Stop();
        ex.Manage();
      }
    }
    finally
    {
      Globals.ChronoLoadData.Stop();
      Settings.BenchmarkLoadData = Globals.ChronoLoadData.ElapsedMilliseconds;
    }
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
      //process(DataSet.StrongConcordances, StrongConcordancesTableAdapter);
      LoadingForm.Instance.Initialize("", Enums.GetValues<TanakBook>().Count + 1 + 1 + 1, quantify: false);
      ApplicationDatabase.Instance.LoadingData += OnLoadingData;
      ApplicationDatabase.Instance.Open();
      ApplicationDatabase.Instance.LoadAll();
      ApplicationDatabase.Instance.LoadingData -= OnLoadingData;
      LoadingForm.Instance.DoProgress(operation: SysTranslations.Finalizing.GetLang());
      BooksBindingSource.DataSource = ApplicationDatabase.Instance.BooksAsBindingList;
      SelectSearchInBook.DataSource = new BindingList<BookRow>(ApplicationDatabase.Instance.Books);
      //if ( NeedUpgradeForConcordances ) ImportWordsConcordances();
    }
    finally
    {
      Globals.IsLoadingData = false;
      LoadingForm.Instance.Hide();
      SetFormDisabled(false);
    }
    //
    void OnLoadingData(string caption)
    {
      LoadingForm.Instance.DoProgress(operation: caption);
    }

  }

}
