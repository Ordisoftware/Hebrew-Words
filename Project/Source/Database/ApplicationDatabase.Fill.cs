/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2023 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at
/// https://mozilla.org/MPL/2.0/.
/// If it is not possible or desirable to put the notice in a particular file,
/// then You may include the notice in a location(such as a LICENSE file in a
/// relevant directory) where a recipient would be likely to look for such a notice.
/// You may add additional accurate notices of copyright ownership.
/// </license>
/// <created> 2021-12 </created>
/// <edited> 2022-08 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class ApplicationDatabase
{

  static private readonly int NounValue = HebrewAlphabet.ValuesSimple[Array.IndexOf(HebrewAlphabet.KeyCodes, "n")];

  [SuppressMessage("Design", "MA0051:Method is too long", Justification = "N/A")]
  [SuppressMessage("Major Bug", "S2259:Null pointers should not be dereferenced", Justification = "N/A")]
  [SuppressMessage("Minor Code Smell", "S1643:Strings should not be concatenated using '+' in a loop", Justification = "N/A")]
  internal void FillFromFiles()
  {
    try
    {
      Globals.ChronoStartingApp.Stop();
      Globals.ChronoLoadData.Stop();
      MainForm.Instance.SetFormDisabled(true);
      Books.Clear();
      Loaded = false;
      BookRow book = null;
      ChapterRow chapter = null;
      VerseRow verse = null;
      WordRow word = null;
      string path = Program.TanakFolderPath;
      string strELS50 = "";
      void nextChapter()
      {
        book.Chapters.Add(chapter);
        Chapters.Add(chapter);
        chapter.ELS50 = CreateELS50(strELS50);
        strELS50 = "";
      }
      LoadingForm.Instance.DoProgress(operation: SysTranslations.CreatingData.GetLang());
      foreach ( TanakBook bookNumber in Enums.GetValues<TanakBook>() )
      {
        string filePath = Path.Combine(path, bookNumber.ToString().Replace('_', ' ') + ".txt");
        if ( !File.Exists(filePath) )
        {
          DisplayManager.ShowWarning(SysTranslations.FileNotFound.GetLang(filePath));
          continue;
        }
        var filecontent = File.ReadAllLines(filePath);
        book = new()
        {
          ID = Guid.NewGuid(),
          Number = (int)bookNumber,
          Unicode = BookInfos.Unicode[bookNumber],
          Hebrew = BookInfos.Hebrew[bookNumber],
          Transcription = BookInfos.Transcriptions.GetLang(bookNumber),
          CommonName = BookInfos.Common.GetLang(bookNumber),
          Translation = string.Empty,
          Lettriq = string.Empty,
          Memo = string.Empty
        };
        Books.Add(book);
        int countChapters = 0;
        int countVerses = 0;
        int countWords = 0;
        foreach ( string item in filecontent )
        {
          string line = item;
          if ( line.Contains("    ") )
          {
            if ( chapter is not null ) nextChapter();
            countVerses = 0;
            chapter = new()
            {
              ID = Guid.NewGuid(),
              BookID = book.ID,
              Number = ++countChapters,
              Title = string.Empty,
              Memo = string.Empty
            };
          }
          else
          {
            line = line.Replace(":", "");
            var list = line.Split('\t');
            string[] listWordsUnicode;
            string[] listWordsHebrew;
            if ( list.Length == 2 )
            {
              countWords = 0;
              verse = new()
              {
                ID = Guid.NewGuid(),
                ChapterID = chapter.ID,
                Number = ++countVerses,
                Concept = string.Empty,
                Comment = string.Empty
              };
              listWordsUnicode = [.. list[0].Replace('-', ' ').Split(' ').Reverse()];
              listWordsHebrew = [.. HebrewAlphabet.ToHebrewFont(list[0]).Split(' ')];
              chapter.Verses.Add(verse);
              Verses.Add(verse);
            }
            else
            {
              listWordsUnicode = [.. line.Replace('-', ' ').Split(' ').Reverse()];
              listWordsHebrew = [.. HebrewAlphabet.ToHebrewFont(line).Split(' ')];
            }
            for ( int index = 0; index < listWordsHebrew.Length; index++ )
            {
              ref var wordHebrew = ref listWordsHebrew[index];
              if ( wordHebrew.Length == 0 ) continue;
              string wordHebrewReversed = new([.. wordHebrew.Reverse()]);
              string wordUnicodeReversed = new([.. listWordsUnicode[index].Reverse()]);
              word = new()
              {
                ID = Guid.NewGuid(),
                VerseID = verse.ID,
                Number = ++countWords,
                Unicode = wordUnicodeReversed,
                Hebrew = wordHebrewReversed,
                Translation = string.Empty
              };
              verse.Words.Add(word);
              Words.Add(word);
              strELS50 = wordHebrewReversed + strELS50;
            }
          }
        }
      }
      if ( chapter is not null ) nextChapter();
      BeginTransaction();
      try
      {
        LoadingForm.Instance.DoProgress(operation: SysTranslations.SavingData.GetLang());
        Connection.InsertAll(Books);
        Connection.InsertAll(Chapters);
        Connection.InsertAll(Verses);
        Connection.InsertAll(Words);
        LoadingForm.Instance.DoProgress(operation: SysTranslations.Finalizing.GetLang());
        Commit();
        Vacuum(true);
      }
      catch
      {
        Rollback();
        throw;
      }
      Loaded = true;
    }
    catch ( Exception ex )
    {
      ex.Manage();
    }
    finally
    {
      MainForm.Instance.SetFormDisabled(false);
      Globals.ChronoStartingApp.Start();
      Globals.ChronoLoadData.Start();
    }
  }

  internal void RepairELS50()
  {
    try
    {
      foreach ( var chapter in Chapters )
        chapter.ELS50 = CreateELS50(chapter.Verses.Select(verse => verse.AsHebrew).Reverse().Join("").Replace(" ", ""));
      SaveAll();
    }
    catch ( Exception ex )
    {
      ex.Manage();
    }
  }

  [SuppressMessage("Minor Code Smell", "S1643:Strings should not be concatenated using '+' in a loop", Justification = "N/A")]
  private string CreateELS50(string strELS50)
  {
    strELS50 = HebrewAlphabet.UnFinalAll(strELS50);
    int index = strELS50.Length - 1;
    while ( index >= 0 && strELS50[index] != 't' ) index--;
    string result = "";
    for ( int pos = index; pos >= 0; pos -= NounValue ) result = strELS50[pos] + result;
    return result;
  }

}
