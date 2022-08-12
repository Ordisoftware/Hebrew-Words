using System.Linq;
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
/// <created> 2022-08 </created>
/// <edited> 2022-08 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class SelectVersesByDateUpdatedForm : Form
{

  static private ReferenceItem Reference = new(1, 1, 1);

  static public ReferenceItem Run()
  {
    using var form = new SelectVersesByDateUpdatedForm();
    return form.ShowDialog() == DialogResult.OK ? Reference : null;
  }

  private SelectVersesByDateUpdatedForm()
  {
    InitializeComponent();
    Icon = MainForm.Instance.Icon;
    int count = 0;
    var query = from verse in ApplicationDatabase.Instance.Verses
                join chapter in ApplicationDatabase.Instance.Chapters on verse.ChapterID equals chapter.ID
                join book in ApplicationDatabase.Instance.Books on chapter.BookID equals book.ID
                where verse.HasTranslation
                orderby verse.DateModified descending
                select new
                {
                  ID = ++count,
                  BookTranscription = book.Transcription,
                  BookNumber = book.Number,
                  ChapterNumber = chapter.Number,
                  verse.Number,
                  verse.Translation,
                  verse.DateModified
                };
    BindingSource.DataSource = query.Take((int)EditDisplayCount.Value);
    ActiveControl = DataGridView;
  }

  private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    ActionOK.PerformClick();
  }

  private void ActionOK_Click(object sender, EventArgs e)
  {
    if ( DataGridView.SelectedRows.Count > 0 )
    {
      var row = DataGridView.SelectedRows[0];
      int book = (int)row.Cells[ColumnBookNumber.Index].Value;
      int chapter = (int)row.Cells[ColumnChapterNumber.Index].Value;
      int verse = (int)row.Cells[ColumnVerseNumber.Index].Value;
      Reference = new ReferenceItem(book, chapter, verse);
    }
  }

}
