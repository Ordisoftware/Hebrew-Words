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

partial class SelectReferenceForm : Form
{

  static public ReferenceItem Run()
  {
    var form = new SelectReferenceForm();
    if ( form.ShowDialog() != DialogResult.OK ) return null;
    return new ReferenceItem(( form.SelectFilterBook.SelectedItem as BookRow )?.Number ?? 1,
                             ( form.SelectFilterChapter.SelectedItem as ChapterRow )?.Number ?? 1,
                             ( form.SelectFilterVerse.SelectedItem as VerseRow )?.Number ?? 1);
  }

  private readonly Dictionary<TextBox, bool> FilterModified;

  private SelectReferenceForm()
  {
    InitializeComponent();
    Icon = MainForm.Instance.Icon;
    FilterModified = new()
    {
      { EditFilterBook, false },
      { EditFilterChapter, false },
      { EditFilterVerse, false },
    };
    UpdateFilters(null, null);
  }

  private void UpdateFilters(object sender, EventArgs e)
  {
    Cursor = Cursors.WaitCursor;
    try { CreateFilterDataSource(); }
    finally { Cursor = Cursors.Default; }
  }

  private void ActionClearFilterBook_Click(object sender, EventArgs e)
  {
    EditFilterBook.Text = string.Empty;
    UpdateFilters(sender, e);
  }

  private void ActionClearFilterChapter_Click(object sender, EventArgs e)
  {
    EditFilterChapter.Text = string.Empty;
    UpdateFilters(sender, e);
  }

  private void ActionClearFilterVerse_Click(object sender, EventArgs e)
  {
    EditFilterVerse.Text = string.Empty;
    UpdateFilters(sender, e);
  }

  private void EditFilter_TextChanged(object sender, EventArgs e)
  {
    FilterModified[(TextBox)sender] = true;
  }

  private void EditFilterBook_KeyUp(object sender, KeyEventArgs e)
  {
    if ( e.KeyCode == Keys.Enter && FilterModified[(TextBox)sender] )
    {
      FilterModified[(TextBox)sender] = false;
      UpdateFilters(sender, e);
    }
  }

  private void EditFilter_Leave(object sender, EventArgs e)
  {
    if ( FilterModified[(TextBox)sender] )
    {
      FilterModified[(TextBox)sender] = false;
      UpdateFilters(sender, e);
    }
  }

  private void CreateFilterDataSource()
  {
    var books = (IEnumerable<BookRow>)ApplicationDatabase.Instance.Books;
    if ( EditFilterChaptersWithTitle.Checked )
      books = books.Where(b => b.Chapters.Any(c => !c.Title.IsNullOrEmpty()));
    if ( EditFilterVersesTranslated.Checked )
      books = books.Where(b => b.Chapters.Any(c => c.Verses.Any(v => v.HasTranslation)));
    if ( EditFilterBook.Text != string.Empty )
      books = books.Where(b => b.Name.RawContains(EditFilterBook.Text)
                            || b.CommonName.RawContains(EditFilterBook.Text)
                            || b.Lettriq.RawContains(EditFilterBook.Text)
                            || b.Memo.RawContains(EditFilterBook.Text)
                            || b.Translation.RawContains(EditFilterBook.Text));
    if ( EditFilterChapter.Text != string.Empty )
      books = books.Where(b => b.Chapters.Any(c => c.Title.RawContains(EditFilterChapter.Text)
                                                || c.Memo.RawContains(EditFilterChapter.Text)));
    if ( EditFilterVerse.Text != string.Empty )
      books = books.Where(b => b.Chapters.Any(c => c.Verses.Any(v => v.Translation.RawContains(EditFilterVerse.Text)
                                                                  || v.Comment.RawContains(EditFilterVerse.Text))));
    var list = books.ToList();
    SelectFilterBook.DataSource = new BindingList<BookRow>(list);
    if ( list.Count == 0 )
    {
      SelectFilterChapter.DataSource = null;
      SelectFilterVerse.DataSource = null;
    }
  }

  private void SelectFilterBook_SelectedIndexChanged(object sender, EventArgs e)
  {
    string id = ( SelectFilterBook.SelectedItem as BookRow )?.ID;
    if ( id == null )
    {
      SelectFilterChapter.DataSource = null;
      SelectFilterVerse.DataSource = null;
      return;
    }
    var chapters = ApplicationDatabase.Instance.Chapters.Where(chapter => chapter.BookID == id);
    if ( EditFilterChaptersWithTitle.Checked )
      chapters = chapters.Where(c => !c.Title.IsNullOrEmpty());
    if ( EditFilterVersesTranslated.Checked )
      chapters = chapters.Where(c => c.Verses.Any(v => v.HasTranslation));
    if ( EditFilterChapter.Text != string.Empty )
      chapters = chapters.Where(c => c.Title.RawContains(EditFilterChapter.Text)
                                  || c.Memo.RawContains(EditFilterChapter.Text));
    if ( EditFilterVerse.Text != string.Empty )
      chapters = chapters.Where(c => c.Verses.Any(v => v.Translation.RawContains(EditFilterVerse.Text)
                                                    || v.Comment.RawContains(EditFilterVerse.Text)));
    var list = chapters.ToList();
    SelectFilterChapter.DataSource = new BindingList<ChapterRow>(list);
    if ( list.Count == 0 )
      SelectFilterVerse.DataSource = null;
  }

  private void SelectFilterChapter_SelectedIndexChanged(object sender, EventArgs e)
  {
    string id = ( SelectFilterChapter.SelectedItem as ChapterRow )?.ID;
    if ( id == null )
    {
      SelectFilterVerse.DataSource = null;
      return;
    }
    var verses = ApplicationDatabase.Instance.Verses.Where(verse => verse.ChapterID == id);
    if ( EditFilterVersesTranslated.Checked )
      verses = verses.Where(v => v.HasTranslation);
    if ( EditFilterVerse.Text != string.Empty )
      verses = verses.Where(v => v.Translation.RawContains(EditFilterVerse.Text)
                              || v.Comment.RawContains(EditFilterVerse.Text));
    SelectFilterVerse.DataSource = new BindingList<VerseRow>(verses.ToList());
  }

}
