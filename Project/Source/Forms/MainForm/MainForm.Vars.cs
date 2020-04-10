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
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Ordisoftware.HebrewWords.Data;

namespace Ordisoftware.HebrewWords
{

  public partial class MainForm
  {

    private const int PopulateDataPaging = 10000;

    /// <summary>
    /// Indicate last showned tooltip.
    /// </summary>
    private ToolTip LastToolTip = new ToolTip();

    /// <summary>
    /// Indicate current bible reference.
    /// </summary>
    public ReferenceItem CurrentReference { get; set; }

    /// <summary>
    /// Indicate if is in loading data stage.
    /// </summary>
    public bool IsLoadingData { get; private set; }

    /// <summary>
    /// Indicate if the application is ready for the user.
    /// </summary>
    public bool IsReady { get; private set; }

    /// <summary>
    /// Indicate if windows session is ending.
    /// </summary>
    private bool IsSessionEnding;

    /// <summary>
    /// Indicate is combobox selection is changing.
    /// </summary>
    public bool IsComboBoxChanging { get; private set; }

    /// <summary>
    /// Indicate if rendering view is in running.
    /// </summary>
    public bool IsRenderingSearch { get; private set; }

    /// <summary>
    /// Indicate if GoTo is running.
    /// </summary>
    private bool IsGoToRunning;

    /// <summary>
    /// Indicate if current processing must be cancelled.
    /// </summary>
    private bool CancelRequired;

    /// <summary>
    /// Indicate previous seach paging position.
    /// </summary>
    private int PreviousSeachPagingPosition = -1;

    private int BookmarksMenuFirstIndex;

    private Bookmarks Bookmarks;
    private History History;

    private IEnumerable<ReferenceItem> SearchResults;

    internal int SearchResultsCount { get; private set; }

    private int PagingCountDisableForm = 50;
    private int PagingCurrent = 0;
    private int PagingCount = 0;

    private Func<DataSet.WordsRow, bool> CheckWord;
    private Func<DataSet.VersesRow, bool> CheckVerse;

    private string SearchWord1;
    private string SearchWord2;

    private readonly Font HebrewFont12 = new Font("Hebrew", 12f);

    private readonly Font LatinFont10 = new Font("Verdana", 10f);

    private readonly Font LatinFont8 = new Font("Verdana", 8f);

    private readonly Font VerseNumberFont = new Font("Calibri", 13f, FontStyle.Bold);

  }

}
