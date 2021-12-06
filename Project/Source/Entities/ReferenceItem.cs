﻿/// <license>
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
partial class ReferenceItem : IEquatable<ReferenceItem>, IComparable<ReferenceItem>
{

  const string NULL = "(null)";

  public BookRow Book { get; set; }
  public ChapterRow Chapter { get; set; }
  public VerseRow Verse { get; set; }
  public WordRow Word { get; set; }

  public override string ToString()
  {
    return ( Book?.Name ?? NULL ) + " " +
           ( Chapter?.Number.ToString() ?? NULL ) + "." +
           ( Verse?.Number.ToString() ?? NULL );
  }

  public string ToStringFull()
  {
    return ( Book?.Name ?? NULL ) + " (" +
           ( Book?.CommonName ?? NULL ) + ") " +
           ( Chapter?.Number.ToString() ?? NULL ) + "." +
           ( Verse?.Number.ToString() ?? NULL );
  }

  public string ToStringOnlyNumbers()
  {
    return ( Book?.Number.ToString() ?? NULL ) + "." +
           ( Chapter?.Number.ToString() ?? NULL ) + "." +
           ( Verse?.Number.ToString() ?? NULL );
  }

  public string ToStringOnlyNumbersWordIncluded()
  {
    return ( Book?.Number.ToString() ?? NULL ) + "." +
           ( Chapter?.Number.ToString() ?? NULL ) + "." +
           ( Verse?.Number.ToString() ?? NULL ) + ":" +
           ( Verse?.Number.ToString() ?? NULL );
  }

  public override int GetHashCode()
  {
    return ( Book?.Number.GetHashCode() ?? 0 )
         ^ ( Chapter?.Number.GetHashCode() ?? 0 )
         ^ ( Verse?.Number.GetHashCode() ?? 0 );
  }

  public int GetHashCodeWordIncluded()
  {
    return ( Book?.Number.GetHashCode() ?? 0 )
         ^ ( Chapter?.Number.GetHashCode() ?? 0 )
         ^ ( Verse?.Number.GetHashCode() ?? 0 )
         ^ ( Word?.Number.GetHashCode() ?? 0 );
  }

  private ReferenceItem()
  {
  }

  public ReferenceItem(BookRow book, ChapterRow chapter, VerseRow verse)
  : this(book, chapter, verse, null)
  {
  }

  public ReferenceItem(BookRow book, ChapterRow chapter, VerseRow verse, WordRow word)
  {
    Book = book;
    Chapter = chapter;
    Verse = verse;
    Word = word;
  }

  public ReferenceItem(ReferenceItem reference, WordRow word)
  : this(reference)
  {
    Word = word;
  }

  public ReferenceItem(ReferenceItem item)
  : this(item.Book?.Number ?? 0, item.Chapter?.Number ?? 0, item.Verse?.Number ?? 0, item.Word?.Number ?? 0)
  {
  }

  public ReferenceItem(int book, int chapter, int verse)
  : this(book, chapter, verse, 0)
  {
  }

  public ReferenceItem(int book, int chapter, int verse, int word)
  {
    try
    {
      Book = ApplicationDatabase.Instance.Books?.SingleOrDefault(b => b.Number == book);
      Chapter = Book?.Chapters?.Find(c => c.Number == chapter);
      Verse = Chapter.Verses?.Find(v => v.Number == verse);
      Word = Verse?.Words?.Find(w => w.Number == word);
    }
    catch ( Exception ex )
    {
      throw new Exception(AppTranslations.ReferenceError.GetLang(ToStringOnlyNumbersWordIncluded(), ex.Message), ex);
    }
  }

}
