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

  static public readonly Properties.Settings Settings = Properties.Settings.Default;

  static public ReferenceItem Run()
  {
    using var form = new SelectVersesByDateUpdatedForm();
    return form.ShowDialog() == DialogResult.OK ? form.Reference : null;
  }

  private bool OptionsMutex = true;

  private ReferenceItem Reference = new(1, 1, 1);

  private SelectVersesByDateUpdatedForm()
  {
    InitializeComponent();
    Icon = MainForm.Instance.Icon;
  }

  private void SelectVersesByDateUpdatedForm_Load(object sender, EventArgs e)
  {
    Location = Settings.SelectVersesByDateUpdatedFormLocation;
    ClientSize = Settings.SelectVersesByDateUpdatedFormClientSize;
    this.CheckLocationOrCenterToMainFormElseScreen();
    WindowState = Settings.SelectVersesByDateUpdatedFormWindowState;
    EditOnlyFullyTranslated.Checked = Settings.SelectVersesByDateUpdatedFormOnlyFullyTranslated;
    EditOnlyPartiallyTranslated.Checked = Settings.SelectVersesByDateUpdatedFormOnlyPartiallyTranslated;
    OptionsMutex = false;
  }

  private void SelectVersesByDateUpdatedForm_Shown(object sender, EventArgs e)
  {
    EditFontSize_ValueChanged(null, null);
    UpdateQuery();
  }

  private void SelectVersesByDateUpdatedForm_FormClosed(object sender, FormClosedEventArgs e)
  {
    if ( WindowState == FormWindowState.Minimized )
      WindowState = FormWindowState.Normal;
    Settings.SelectVersesByDateUpdatedFormWindowState = WindowState;
    if ( WindowState == FormWindowState.Maximized )
      WindowState = FormWindowState.Normal;
    Settings.SelectVersesByDateUpdatedFormLocation = Location;
    Settings.SelectVersesByDateUpdatedFormClientSize = ClientSize;
    Settings.SelectVersesByDateUpdatedFormOnlyFullyTranslated = EditOnlyFullyTranslated.Checked;
    Settings.SelectVersesByDateUpdatedFormOnlyPartiallyTranslated = EditOnlyPartiallyTranslated.Checked;
    SystemManager.TryCatch(Settings.Save);
    BindingSource.DataSource = null;
  }

  [SuppressMessage("Performance", "U2U1212:Capture intermediate results in lambda expressions", Justification = "N/A")]
  private void UpdateQuery()
  {
    BindingSource.DataSource = null;
    int count = 0;
    var query = from verse in ApplicationDatabase.Instance.Verses
                join chapter in ApplicationDatabase.Instance.Chapters on verse.ChapterID equals chapter.ID
                join book in ApplicationDatabase.Instance.Books on chapter.BookID equals book.ID
                where EditOnlyFullyTranslated.Checked
                      ? verse.IsFullyTranslated
                      : EditOnlyPartiallyTranslated.Checked
                        ? verse.IsPartiallyTranslated
                        : verse.HasTranslation
                orderby verse.DateModified descending
                select new
                {
                  ID = ++count,
                  BookTranscription = book.Transcription,
                  BookNumber = book.Number,
                  ChapterNumber = chapter.Number,
                  verse.Number,
                  verse.Translation,
                  DateModified = new DateTime(Math.Max(verse.DateModified.Ticks,
                                                       verse.Words.Max(w => w.DateModified.Ticks)))
                };
    query = query.Take((int)EditDisplayCount.Value);
    count = query.Count();
    if ( count > 0 )
      BindingSource.DataSource = query;
    ActionOK.Enabled = count > 0;
    ActiveControl = DataGridView;
    Text = AppTranslations.SelectVersesByDateUpdatedFormTitle.GetLang(count);

  }

  private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    ActionOK.PerformClick();
  }

  private void DataGridView_KeyDown(object sender, KeyEventArgs e)
  {
    if ( e.KeyCode == Keys.Enter )
    {
      e.SuppressKeyPress = true;
      e.Handled = true;
      ActionOK.PerformClick();
    }
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

  private void EditFontSize_ValueChanged(object sender, EventArgs e)
  {
    DataGridView.Font = new Font("Microsoft Sans Serif", (float)EditFontSize.Value);
    // TODO remove if ( DataGridView.Rows.Count > 0 ) DataGridView.ColumnHeadersHeight = DataGridView.Rows[0].Height + 5;
  }

  private void EditDisplayCount_ValueChanged(object sender, EventArgs e)
  {
    UpdateQuery();
  }

  private void EditOnlyFullyTranslated_CheckedChanged(object sender, EventArgs e)
  {
    bool update = !OptionsMutex;
    OptionsMutex = true;
    if ( EditOnlyFullyTranslated.Checked && EditOnlyPartiallyTranslated.Checked )
      EditOnlyPartiallyTranslated.Checked = false;
    if ( update ) UpdateQuery();
    OptionsMutex = false;
  }

  private void EditOnlyPartiallyTranslated_CheckedChanged(object sender, EventArgs e)
  {
    bool update = !OptionsMutex;
    OptionsMutex = true;
    if ( EditOnlyFullyTranslated.Checked && EditOnlyPartiallyTranslated.Checked )
      EditOnlyFullyTranslated.Checked = false;
    if ( update ) UpdateQuery();
    OptionsMutex = false;
  }

}
