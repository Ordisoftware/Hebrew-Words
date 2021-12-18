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
sealed public partial class ReferenceItem : IEquatable<ReferenceItem>, IComparable<ReferenceItem>
{

  public BookRow Book { get; set; }
  public ChapterRow Chapter { get; set; }
  public VerseRow Verse { get; set; }
  public WordRow Word { get; set; }

  private ReferenceItem()
  {
  }

  public ReferenceItem(BookRow book, ChapterRow chapter, VerseRow verse)
  {
    Book = book;
    Chapter = chapter;
    Verse = verse;
  }

  public ReferenceItem(BookRow book, ChapterRow chapter, VerseRow verse, WordRow word)
  : this(book, chapter, verse)
  {
    Word = word;
  }

  public ReferenceItem(ReferenceItem reference)
  : this(reference.Book, reference.Chapter, reference.Verse, reference.Word)
  {
  }

  public ReferenceItem(ReferenceItem reference, WordRow word)
  : this(reference.Book, reference.Chapter, reference.Verse, word)
  {
  }

  public ReferenceItem(int book, int chapter, int verse)
  : this(book, chapter, verse, 0)
  {
  }

  public ReferenceItem(int book, int chapter, int verse, int word)
  {
    Initialize(book, chapter, verse, word);
  }

  public ReferenceItem(string reference)
  {
    var items = Analyze(reference);
    Initialize(items[0], items[1], items[2], 0);
  }

}
