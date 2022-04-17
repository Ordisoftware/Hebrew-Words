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
/// Provides reference item
/// </summary>
public partial class ReferenceItem
{

  [SuppressMessage("Usage", "MA0015:Specify the parameter name in ArgumentException", Justification = "N/A")]
  private void Initialize(int book, int chapter, int verse, int word)
  {
    try
    {
      Book = ApplicationDatabase.Instance.Books?.Find(b => b.Number == book);
      Chapter = Book?.Chapters?.Find(c => c.Number == chapter);
      Verse = Chapter?.Verses?.Find(v => v.Number == verse);
      Word = Verse?.Words?.Find(w => w.Number == word);
    }
    catch ( Exception ex )
    {
      string msg = AppTranslations.ReferenceError.GetLang($"{book}.{chapter}.{verse}:{word}", ex.Message);
      throw new ArgumentException(msg, ex);
    }
  }

  [SuppressMessage("Usage", "MA0015:Specify the parameter name in ArgumentException", Justification = "N/A")]
  private int[] Analyze(string reference)
  {
    if ( !reference.IsNullOrEmpty() )
    {
      reference = reference.Trim().SanitizeEmptyLinesAndSpaces();
      int countSpaces = reference.Count(c => c == ' ');
      int countPoints = reference.Count(c => c == '.');
      if ( countPoints == 0 && !reference.Any(c => char.IsNumber(c)) )
        return new int[] { getBookRef(reference), 1, 1 };
      if ( countSpaces == 0 && char.IsNumber(reference[0]) )
      {
        if ( countPoints == 0 )
          return Enumerable.Append(Enumerable.Append(reference.Split('.').Select(int.Parse), 1), 1).ToArray();
        if ( countPoints == 1 )
          return Enumerable.Append(reference.Split('.').Select(int.Parse), 1).ToArray();
        if ( countPoints >= 2 )
          return reference.Split('.').Select(int.Parse).Take(3).ToArray();
      }
      else
        try
        {
          var itemsVerse = new int[3];
          var partsAllSpaced = reference.Split(' ');
          var partVerseRef = partsAllSpaced[partsAllSpaced.Length - 1].Split('.');
          if ( partVerseRef.Length >= 1 )
            itemsVerse[1] = int.Parse(partVerseRef[0]);
          if ( partVerseRef.Length >= 2 )
            itemsVerse[2] = int.Parse(partVerseRef[1]);
          string book = countSpaces == 1
            ? partsAllSpaced[0]
            : partsAllSpaced[0] + " " + partsAllSpaced[1];
          itemsVerse[0] = getBookRef(book);
          return itemsVerse;
        }
        catch ( Exception ex )
        {
          throw new ArgumentException(AppTranslations.ReferenceError.GetLang(reference), ex);
        }
    }
    throw new ArgumentException(AppTranslations.ReferenceError.GetLang(reference));
    //
    int getBookRef(string name)
    {
      return ApplicationDatabase.Instance.Books.First(book => book.Transcription.RawContains(name)
                                                           || book.CommonName.RawContains(name)).Number;
    }
  }

}
