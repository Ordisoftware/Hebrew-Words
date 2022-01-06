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
/// <created> 2019-09 </created>
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class SelectReferenceForm : Form
{

  static public ReferenceItem Run()
  {
    using var form = new SelectReferenceForm();
    while ( true )
      try
      {
        var reference = Run(form);
        if ( reference == null ) return null;
        if ( reference.Book == null ) throw new Exception();
        if ( reference.Chapter == null ) reference = new ReferenceItem(reference.Book.Number, 1, 1);
        if ( reference.Verse == null ) reference = new ReferenceItem(reference.Book.Number, reference.Chapter.Number, 1);
        return reference;
      }
      catch
      {
        DisplayManager.ShowError("Bad reference.");
      }
  }

  static private ReferenceItem Run(SelectReferenceForm form)
  {
    if ( form.ShowDialog() != DialogResult.OK ) return null;
    if ( !form.EditReference.Text.IsNullOrEmpty() )
      return new ReferenceItem(form.EditReference.Text.Trim().Replace("  ", " "));
    else
      return new ReferenceItem(( form.SelectBook.SelectedItem as BookRow )?.Number ?? 1,
                               ( form.SelectChapter.SelectedItem as ChapterRow )?.Number ?? 1,
                               ( form.SelectVerse.SelectedItem as VerseRow )?.Number ?? 1);
  }

  private SelectReferenceForm()
  {
    InitializeComponent();
    Icon = MainForm.Instance.Icon;
    FilterBooksBindingSource.DataSource = new BindingList<BookRow>(ApplicationDatabase.Instance.Books);
    ActiveControl = EditReference;
  }

  private void ActionHelp_Click(object sender, EventArgs e)
  {
    DisplayManager.ShowInformation(AppTranslations.SearchReferenceNotice.GetLang());
  }

}
