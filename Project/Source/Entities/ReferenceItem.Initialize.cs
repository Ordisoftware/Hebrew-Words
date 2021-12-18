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
/// <created> 2016-04 </created>
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

/// <summary>
/// Provides reference item
/// </summary>
public partial class ReferenceItem
{

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

  private int[] Analyze(string reference)
  {
    int countSpaces = reference.Count(c => c == ' ');
    int countPoints = reference.Count(c => c == '.');
    if ( countSpaces == 0 && countPoints == 2 )
      return reference.Split('.').Select(int.Parse).ToArray();
    else
    if ( ( countSpaces == 1 || countSpaces == 2 ) && countPoints == 1 )
      try
      {
        var items = new int[3];
        var parts1 = reference.Split(' ');
        var parts2 = parts1.Last().Split('.');
        items[1] = int.Parse(parts2[0]);
        items[2] = int.Parse(parts2[1]);
        string book = countSpaces == 1 ? parts1[0] : parts1[0] + " " + parts1[1];
        items[0] = ApplicationDatabase.Instance.Books.First(b => b.Name.RawContains(book)
                                                              || b.CommonName.RawContains(book)).Number;
        return items;
      }
      catch ( Exception ex )
      {
        throw new ArgumentException(AppTranslations.ReferenceError.GetLang(reference), ex);
      }
    else
      throw new ArgumentException(AppTranslations.ReferenceError.GetLang(reference));
  }

}
