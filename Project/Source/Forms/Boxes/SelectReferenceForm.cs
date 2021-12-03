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
/// <created> 2019-09 </created>
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

using Equin.ApplicationFramework;

partial class SelectReferenceForm : Form
{

  static public ReferenceItem Run()
  {
    var form = new SelectReferenceForm();
    if ( form.ShowDialog() != DialogResult.OK ) return null;
    return new ReferenceItem(( form.SelectBook.SelectedItem as ObjectView<BookRow> )?.Object.Number ?? 1,
                             ( form.SelectChapter.SelectedItem as ChapterRow )?.Number ?? 1,
                             ( form.SelectVerse.SelectedItem as VerseRow )?.Number ?? 1);
  }

  private SelectReferenceForm()
  {
    InitializeComponent();
    Icon = MainForm.Instance.Icon;
    RefreshBooks();
  }

  private void SelectBook_SelectedIndexChanged(object sender, EventArgs e)
  {
    RefreshChapters();
  }

  private void SelectChapter_SelectedIndexChanged(object sender, EventArgs e)
  {
    RefreshVerses();
  }

  private void EditFilter_SelectedIndexChanged(object sender, EventArgs e)
  {
    RefreshBooks();
  }

  private void RefreshBooks()
  {
    if ( Mutex ) return;
    Mutex = true;
    try
    {
      //SelectBook.Items.Clear();
      //foreach ( var book in ApplicationDatabase.Instance.Books )
      //{
      //  bool selected = false;
      //  foreach ( var chapter in book.Chapters )
      //    if ( !EditFilterChaptersWithTitle.Checked || chapter.Title.Length > 0 )
      //      foreach ( var verse in chapter.Verses )
      //        if ( !EditFilterVersesTranslated.Checked || verse.HasTranslation() )
      //          selected = true;
      //  if ( selected )
      //    SelectBook.Items.Add(new BookItem(book));
      //}
      //if ( SelectBook.Items.Count > 0 )
      //{
      //  SelectBook.Enabled = true;
      //  SelectBook.SelectedIndex = 0;
      //}
      //else
      //  SelectBook.Enabled = false;
    }
    finally
    {
      Mutex = false;
    }
    RefreshChapters();
  }

  private bool Mutex;

  private void RefreshChapters()
  {
    if ( Mutex ) return;
    Mutex = true;
    try
    {
      //SelectChapter.Items.Clear();
      //SelectVerse.Items.Clear();
      //if ( SelectBook.SelectedItem != null )
      //{
      //  var book = ( (BookItem)SelectBook.SelectedItem ).Book;
      //  var list = (IEnumerable<ChapterRow>)book.Chapters;
      //  if ( EditFilterChaptersWithTitle.Checked )
      //    list = list.Where(chapter => chapter.Title.Length > 0);
      //  if ( EditFilterVersesTranslated.Checked )
      //    list = list.Where(chapter => chapter.Verses.Any(verse => verse.HasTranslation()));
      //  foreach ( var chapter in list )
      //    SelectChapter.Items.Add(new ChapterItem(chapter));
      //}
      //if ( SelectChapter.Items.Count > 0 )
      //{
      //  SelectChapter.Enabled = true;
      //  SelectChapter.SelectedIndex = 0;
      //}
      //else
      //  SelectChapter.Enabled = false;
    }
    finally
    {
      Mutex = false;
    }
    RefreshVerses();
  }

  private void RefreshVerses()
  {
    if ( Mutex ) return;
    Mutex = true;
    try
    {
      //SelectVerse.Items.Clear();
      //if ( SelectChapter.SelectedItem != null )
      //{
      //  var chapter = ( (ChapterItem)SelectChapter.SelectedItem ).Chapter;
      //  foreach ( VerseRow verse in chapter.Verses )
      //    SelectVerse.Items.Add(new VerseItem(verse));
      //}
      //if ( SelectVerse.Items.Count > 0 )
      //{
      //  SelectVerse.Enabled = true;
      //  SelectVerse.SelectedIndex = 0;
      //}
      //else
      //  SelectVerse.Enabled = false;
    }
    finally
    {
      Mutex = false;
    }
  }

}
