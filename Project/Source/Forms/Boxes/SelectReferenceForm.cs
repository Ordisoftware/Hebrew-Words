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
    MainForm.Instance.Cursor = Cursors.WaitCursor;
    try
    {
      CreateDataSource();
    }
    finally
    {
      MainForm.Instance.Cursor = Cursors.Default;
    }
  }

  private void EditFilterChaptersWithTitle_CheckedChanged(object sender, EventArgs e)
  {
    Cursor = Cursors.WaitCursor;
    try
    {
      CreateDataSource();
    }
    finally
    {
      Cursor = Cursors.Default;
    }
  }

  private void EditFilterVersesTranslated_CheckedChanged(object sender, EventArgs e)
  {
    Cursor = Cursors.WaitCursor;
    try
    {
      CreateDataSource();
    }
    finally
    {
      Cursor = Cursors.Default;
    }
  }

  private void CreateDataSource()
  {
    var books = (IEnumerable<BookRow>)ApplicationDatabase.Instance.Books;
    if ( EditFilterChaptersWithTitle.Checked )
      books = books.Where(b => b.Chapters.Any(c => !c.Title.IsNullOrEmpty()));
    if ( EditFilterVersesTranslated.Checked )
      books = books.Where(b => b.Chapters.Any(c => c.Verses.Any(v => v.HasTranslation)));
    SelectBook.DataSource = new BindingListView<BookRow>(books.ToList());
  }

  private void SelectBook_SelectedIndexChanged(object sender, EventArgs e)
  {
    string id = ( SelectBook.SelectedItem as ObjectView<BookRow> )?.Object.ID ?? string.Empty;
    var chapters = ApplicationDatabase.Instance.Chapters.Where(chapter => chapter.BookID == id);
    if ( EditFilterChaptersWithTitle.Checked )
      chapters = chapters.Where(c => !c.Title.IsNullOrEmpty());
    if ( EditFilterVersesTranslated.Checked )
      chapters = chapters.Where(c => c.Verses.Any(v => v.HasTranslation));
    SelectChapter.DataSource = new BindingListView<ChapterRow>(chapters.ToList());
  }

  private void SelectChapter_SelectedIndexChanged(object sender, EventArgs e)
  {
    string id = ( SelectChapter.SelectedItem as ObjectView<ChapterRow> )?.Object.ID ?? string.Empty;
    var verses = ApplicationDatabase.Instance.Verses.Where(verse => verse.ChapterID == id);
    if ( EditFilterVersesTranslated.Checked )
      verses = verses.Where(v => v.HasTranslation);
    SelectVerse.DataSource = new BindingListView<VerseRow>(verses.ToList());
  }

}
