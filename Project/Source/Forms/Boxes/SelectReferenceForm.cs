/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2024 Olivier Rogier.
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
/// <edited> 2022-03 </edited>
namespace Ordisoftware.Hebrew.Words;

sealed partial class SelectReferenceForm : Form
{

  static private ReferenceItem LastReference = new(1, 1, 1);

  static public ReferenceItem Run()
  {
    using var form = new SelectReferenceForm();
    while ( true )
      try
      {
        if ( form.ShowDialog() != DialogResult.OK ) return null;
        LastReference = new ReferenceItem(form.EditReference.Text);
        if ( LastReference.Book is null )
          throw new KeyNotFoundException(nameof(LastReference.Book));
        if ( LastReference.Chapter is null )
          LastReference = new ReferenceItem(LastReference.Book.Number, 1, 1);
        if ( LastReference.Verse is null )
          LastReference = new ReferenceItem(LastReference.Book.Number, LastReference.Chapter.Number, 1);
        return LastReference;
      }
      catch
      {
        DisplayManager.ShowError(AppTranslations.BadReference.GetLang(form.EditReference.Text));
      }
  }

  private SelectReferenceForm()
  {
    InitializeComponent();
    Icon = MainForm.Instance.Icon;
    FilterBooksBindingSource.DataSource = new BindingList<BookRow>(ApplicationDatabase.Instance.Books);
    ActiveControl = EditReference;
    EditReference.Text = LastReference.ToString();
    SelectBook.SelectedIndex = LastReference.Book.Number - 1;
    SelectChapter.SelectedIndex = LastReference.Chapter.Number - 1;
    SelectVerse.SelectedIndex = LastReference.Verse.Number - 1;
  }

  private void SelectBook_SelectedIndexChanged(object sender, EventArgs e)
  {
    if ( !Created ) return;
    EditReference.Text = new ReferenceItem(( SelectBook.SelectedItem as BookRow )?.Number ?? 1,
                                           ( SelectChapter.SelectedItem as ChapterRow )?.Number ?? 1,
                                           ( SelectVerse.SelectedItem as VerseRow )?.Number ?? 1).ToString();
  }

  private void ActionHelp_Click(object sender, EventArgs e)
  {
    DisplayManager.ShowInformation(AppTranslations.SelectVerseNotice.GetLang());
  }

}
