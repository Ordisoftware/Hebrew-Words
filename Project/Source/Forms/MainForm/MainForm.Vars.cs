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

partial class MainForm
{

  /// <summary>
  /// Indicates the default Settings instance.
  /// </summary>
  private readonly Properties.Settings Settings = Program.Settings;

  static internal List<Parashah> UserParashot { get; set; } = new List<Parashah>();

  /// <summary>
  /// Indicates last shown tool-tip.
  /// </summary>
  private readonly ToolTip LastToolTip = new();

  /// <summary>
  /// Indicates current bible reference.
  /// </summary>
  public ReferenceItem CurrentReference { get; set; }

  /// <summary>
  /// Indicates is combo-box selection is changing.
  /// </summary>
  public bool IsComboBoxChanging { get; private set; }

  /// <summary>
  /// Indicates if rendering view is in running.
  /// </summary>
  public bool IsRendering { get; private set; }

  /// <summary>
  /// Indicates if GoTo is running.
  /// </summary>
  private bool IsGoToRunning;

  /// <summary>
  /// Indicates previous each paging position.
  /// </summary>
  private int PreviousSeachPagingPosition = -1;

  private Bookmarks Bookmarks { get; init; }
  private History History { get; init; }

  private int BookmarksMenuFirstIndex;

  private IEnumerable<ReferenceItem> SearchResults;

  public int SearchResultsCount { get; private set; }

  private readonly int PagingCountDisableForm = 50;
  private int PagingCurrent;
  private int PagingCount;

  private Func<WordRow, bool> CheckWord;
  private Func<VerseRow, bool> CheckVerse;

  private string SearchWord1;
  private string SearchWord2;

  private readonly Font HebrewFont12 = new("Hebrew", 12f);

  private readonly Font LatinFont10 = new("Verdana", 10f);

  private readonly Font LatinFont8 = new("Verdana", 8f);

  private readonly Font VerseNumberFont = new("Calibri", 13f, FontStyle.Bold);

  public ApplicationDatabase DBApp = ApplicationDatabase.Instance;
  public HebrewDatabase DBHebrew = HebrewDatabase.Instance;

}
