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
/// <created> 2019-09 </created>
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class SelectSearchResultsForm : Form
{

  static public IEnumerable<ReferenceItem> Run(IEnumerable<ReferenceItem> references)
  {
    if ( references == null ) return new List<ReferenceItem>();
    var form = new SelectSearchResultsForm(references);
    if ( form.ShowDialog() == DialogResult.Cancel )
      form.References = null;
    return form.References;
  }

  private bool Initializing;
  private bool Mutex;

  private IEnumerable<ReferenceItem> References;
  private readonly IEnumerable<ReferenceItem> OriginalReferences;
  private int Count;

  private SelectSearchResultsForm()
  {
    InitializeComponent();
    Text = Globals.AssemblyTitle;
    Icon = MainForm.Instance.Icon;
  }

  private SelectSearchResultsForm(IEnumerable<ReferenceItem> references)
  : this()
  {
    OriginalReferences = references.ToList();
    LabelFound.Text = String.Format(LabelFound.Text, OriginalReferences.Count());
  }

  private void SelectSearchResultsForm_Load(object sender, EventArgs e)
  {
    CreateReferences(OriginalReferences);
  }

  private void CreateReferences(IEnumerable<ReferenceItem> references)
  {
    Initializing = true;
    try
    {
      References = references.ToList();
      Count = 0;
      LabelCount.Text = "0";
      var query = from r in references
                  group r by r.Book into books
                  select new { Key = books.Key.Number, Count = books.Count() };
      SelectBooks.Items.Clear();
      foreach ( var item in query )
      {
        var row = SelectBooks.Items.Add(ApplicationDatabase.Instance.Books.Single(b => b.Number == item.Key).Name);
        row.Tag = item.Key;
        row.SubItems.Add(item.Count.ToString());
      }
      int textHeight;
      using ( Graphics g = SelectBooks.CreateGraphics() )
      {
        textHeight = TextRenderer.MeasureText(g, "Text", SelectBooks.Font).Height + 4;
      }
      Height = Height - ClientSize.Height
             + SelectBooks.Location.Y
             + SelectBooks.Items.Count * textHeight + SelectBooks.Height - SelectBooks.ClientSize.Height
             + Height - EditOnlyWithTranslation.Location.Y;
      ActiveControl = SelectBooks;
      SelectBooks.Focus();
    }
    finally
    {
      Initializing = false;
    }
  }

  private void ActionSelect_Click(object sender, EventArgs e)
  {
    var list = new List<int>();
    foreach ( ListViewItem item in SelectBooks.Items )
      if ( item.Checked )
        list.Add((int)item.Tag);
    References = OriginalReferences.Where(r => list.Contains(r.Book.Number));
    if ( EditOnlyWithTranslation.Checked )
      References = References.Where(r => r.Verse.HasTranslation());
    if ( EditOnlyWithoutTranslation.Checked )
      References = References.Where(r => !r.Verse.HasTranslation());
    DialogResult = DialogResult.Yes;
  }

  private void ActionAll_Click(object sender, EventArgs e)
  {
    DialogResult = DialogResult.No;
  }

  private void SelectBooks_ItemChecked(object sender, ItemCheckedEventArgs e)
  {
    if ( Initializing ) return;
    if ( e.Item.SubItems.Count == 0 ) return;
    if ( e.Item.Checked )
      Count += Convert.ToInt32(e.Item.SubItems[1].Text);
    else
      Count -= Convert.ToInt32(e.Item.SubItems[1].Text);
    LabelCount.Text = Count.ToString();
    ActionSelect.Enabled = Count > 0;
  }

  private void EditOnlyWithTranslation_CheckedChanged(object sender, EventArgs e)
  {
    if ( Initializing || Mutex ) return;
    Mutex = true;
    EditOnlyWithoutTranslation.Checked = false;
    Mutex = false;
    if ( EditOnlyWithTranslation.Checked )
    {
      CreateReferences(OriginalReferences.Where(r => r.Verse.HasTranslation()));
      ActionAddAll.PerformClick();
    }
    else
      CreateReferences(OriginalReferences.ToList());
  }

  private void EditOnlyWithoutTranslation_CheckedChanged(object sender, EventArgs e)
  {
    if ( Initializing || Mutex ) return;
    Mutex = true;
    EditOnlyWithTranslation.Checked = false;
    Mutex = false;
    if ( EditOnlyWithoutTranslation.Checked )
    {
      CreateReferences(OriginalReferences.Where(r => !r.Verse.HasTranslation()));
      ActionAddAll.PerformClick();
    }
    else
      CreateReferences(OriginalReferences.ToList());
  }

  private void LabelCount_TextChanged(object sender, EventArgs e)
  {
    LabelCount.ForeColor = LabelCount.Text == "0" ? Color.DarkRed : Color.DarkGreen;
  }

  private void ActionAddAll_Click(object sender, EventArgs e)
  {
    foreach ( ListViewItem item in SelectBooks.Items )
      item.Checked = true;
  }

  private void ActionRemoveAll_Click(object sender, EventArgs e)
  {
    foreach ( ListViewItem item in SelectBooks.Items )
      item.Checked = false;
  }

}
