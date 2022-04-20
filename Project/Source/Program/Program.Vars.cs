/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2022 Olivier Rogier.
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
/// <edited> 2022-03 </edited>
namespace Ordisoftware.Hebrew.Words;

/// <summary>
/// Provides Program class.
/// </summary>
static partial class Program
{

  /// <summary>
  /// Indicates the default Settings instance.
  /// </summary>
  static public readonly Properties.Settings Settings
    = Properties.Settings.Default;

  static public readonly NullSafeOfStringDictionary<DataExportTarget> BoardExportTargets
    = ExportHelper.CreateExportTargets(DataExportTarget.TXT, DataExportTarget.CSV, DataExportTarget.JSON);

  /// <summary>
  /// Indicates image export targets
  /// </summary>
  static public readonly NullSafeOfStringDictionary<ImageExportTarget> ImageExportTargets
    = ExportHelper.CreateExportTargets<ImageExportTarget>().SetUnsupported(ImageExportTarget.GIF);

  /// <summary>
  /// Indicates application tanak documents folder.
  /// </summary>
  static public string TanakFolderPath
    => Path.Combine(Globals.DocumentsFolderPath, "Tanak");

  /// <summary>
  /// Indicates file path of the bookmaks.
  /// </summary>
  static public string BookmarksFilePath
    => Path.Combine(Globals.UserDataFolderPath, "Bookmarks.txt");

  /// <summary>
  /// Indicates file path of the history.
  /// </summary>
  static public string HistoryFilePath
  => Path.Combine(Globals.UserDataFolderPath, "History.txt");

  /// <summary>
  /// Indicates the transcription guide form.
  /// </summary>
  static public HTMLBrowserForm TranscriptionGuideForm
  {
    get
    {
      return _TranscriptionGuideForm ??= new HTMLBrowserForm(HebrewTranslations.TranscriptionGuideTitle,
                                                       HebrewGlobals.HebrewTranscriptionGuideFilePath,
                                                       nameof(Settings.GrammarGuideFormLocation),
                                                       nameof(Settings.GrammarGuideFormSize));
    }
  }
  static private HTMLBrowserForm _TranscriptionGuideForm;
  /// <summary>
  /// Indicates the grammar guide form.
  /// </summary>
  static public HTMLBrowserForm GrammarGuideForm
  {
    get
    {
      return _GrammarGuideForm ??= new HTMLBrowserForm(HebrewTranslations.GrammarGuideTitle,
                                                       HebrewGlobals.HebrewGrammarGuideFilePath,
                                                       nameof(Settings.GrammarGuideFormLocation),
                                                       nameof(Settings.GrammarGuideFormSize));
    }
  }
  static private HTMLBrowserForm _GrammarGuideForm;

  static public string HebrewStrongsJsonFilePath
    => Path.Combine(Globals.DocumentsFolderPath, @"Strongs\strongs-hebrew-dictionary.js");

  static public string GreekStrongsJsonFilePath
    => Path.Combine(Globals.DocumentsFolderPath, @"Strongs\strongs-greek-dictionary.js");

  static public string BibleJsonFilePath
    => Path.Combine(Globals.DocumentsFolderPath, @"Bible\genesis.json");

  static public readonly Dictionary<string, Json.Strong.StrongItem> HebrewJsonStrongs
    = Globals.IsVisualStudioDesigner ? null : JsonHelper.LoadStrongs(HebrewStrongsJsonFilePath);

  static public readonly Dictionary<string, Json.Strong.StrongItem> GreekJsonStrongs
    = Globals.IsVisualStudioDesigner ? null : JsonHelper.LoadStrongs(GreekStrongsJsonFilePath);

  static public readonly Json.Verse.JsonVerse[] JsonBibleBookGenesis
    = Globals.IsVisualStudioDesigner ? null : JsonHelper.LoadBook(BibleJsonFilePath);

}
