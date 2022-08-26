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
    EditDateStart.Enabled = SelectDateStart.Checked;
    EditDateEnd.Enabled = SelectDateEnd.Checked;
    //TODO delete var date = new DateTime(1900, 1, 1);
    //if ( EditDateStart.Value.Date == date )
    EditDateStart.Value = DateTime.Now.Date.AddDays(-7);
    //if ( EditDateEnd.Value.Date == date )
    EditDateEnd.Value = DateTime.Now.Date;
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

  private class VerseItem
  {
    public int Id { get; set; }
    public string BookTranscription { get; set; }
    public int BookNumber { get; set; }
    public int ChapterNumber { get; set; }
    public int Number { get; set; }
    public string Translation { get; set; }
    public DateTime DateModified { get; set; }
  }

  [SuppressMessage("Performance", "U2U1212:Capture intermediate results in lambda expressions", Justification = "N/A")]
  private void UpdateQuery(bool focusGrid = true)
  {
    BindingSource.DataSource = null;
    var query = from verse in ApplicationDatabase.Instance.Verses
                join chapter in ApplicationDatabase.Instance.Chapters on verse.ChapterID equals chapter.ID
                join book in ApplicationDatabase.Instance.Books on chapter.BookID equals book.ID
                where EditOnlyFullyTranslated.Checked
                      ? verse.IsFullyTranslated
                      : EditOnlyPartiallyTranslated.Checked
                        ? verse.IsPartiallyTranslated
                        : verse.HasTranslation
                select new VerseItem
                {
                  BookTranscription = book.Transcription,
                  BookNumber = book.Number,
                  ChapterNumber = chapter.Number,
                  Number = verse.Number,
                  Translation = verse.Translation,
                  DateModified = new DateTime(Math.Max(verse.DateModified.Ticks,
                                                       verse.Words.Max(w => w.DateModified.Ticks)))
                };
    query = query.OrderByDescending(v => v.DateModified);
    int countAll = query.Count();
    if ( SelectDateStart.Checked ) query = query.Where(v => v.DateModified.Date >= EditDateStart.Value.Date);
    if ( SelectDateEnd.Checked ) query = query.Where(v => v.DateModified.Date <= EditDateEnd.Value.Date);
    var list = query.Take((int)EditDisplayCount.Value).ToList();
    int countToDisplay = list.Count;
    if ( countToDisplay == 0 )
      ActionOK.Enabled = false;
    else
    {
      int index = 0;
      foreach ( var item in list ) item.Id = ++index;
      BindingSource.DataSource = list;
      ActionOK.Enabled = countToDisplay > 0;
    }
    Text = AppTranslations.SelectVersesByDateUpdatedFormTitle.GetLang(countToDisplay, countAll);
    if ( focusGrid ) ActiveControl = DataGridView;
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
    Close();
  }

  private void EditFontSize_ValueChanged(object sender, EventArgs e)
  {
    DataGridView.Font = new Font("Microsoft Sans Serif", (float)EditFontSize.Value);
  }

  private void EditDisplayCount_ValueChanged(object sender, EventArgs e)
  {
    bool update = !OptionsMutex;
    OptionsMutex = true;
    if ( update ) UpdateQuery(false);
    OptionsMutex = false;
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

  private void SelectDateStart_CheckedChanged(object sender, EventArgs e)
  {
    bool update = !OptionsMutex;
    OptionsMutex = true;
    EditDateStart.Enabled = SelectDateStart.Checked;
    CheckDates();
    if ( update ) UpdateQuery();
    OptionsMutex = false;
  }

  private void SelectDateEnd_CheckedChanged(object sender, EventArgs e)
  {
    bool update = !OptionsMutex;
    OptionsMutex = true;
    EditDateEnd.Enabled = SelectDateEnd.Checked;
    CheckDates();
    if ( update ) UpdateQuery(false);
    OptionsMutex = false;
  }

  private void EditDate_ValueChanged(object sender, EventArgs e)
  {
    if ( OptionsMutex ) return;
    OptionsMutex = true;
    CheckDates();
    UpdateQuery(false);
    OptionsMutex = false;
  }

  private void CheckDates()
  {
    if ( SelectDateStart.Checked && SelectDateEnd.Checked )
      if ( EditDateStart.Value > EditDateEnd.Value )
      {
        var temp = EditDateStart.Value;
        EditDateStart.Value = EditDateEnd.Value;
        EditDateEnd.Value = temp;
      }
  }

}
