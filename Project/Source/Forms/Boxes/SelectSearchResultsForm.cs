/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2019 Olivier Rogier.
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
/// <edited> 2019-09 </edited>
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Ordisoftware.HebrewWords.Data;

namespace Ordisoftware.HebrewWords
{

  public partial class SelectSearchResultsForm : Form
  {

    static public IEnumerable<ReferenceItem> Run(IEnumerable<ReferenceItem> references)
    {
      if ( references == null ) return null;
      var form = new SelectSearchResultsForm();
      form.References = references;
      if ( form.ShowDialog() == DialogResult.Cancel )
        form.References = null;
      return form.References;
    }

    private bool Initializing;
    private bool Mutex;

    private IEnumerable<ReferenceItem> References;
    private int Count;

    private SelectSearchResultsForm()
    {
      InitializeComponent();
      Text = AboutBox.Instance.AssemblyTitle;
      Icon = MainForm.Instance.Icon;
      LabelFound.Text = String.Format(LabelFound.Text, MainForm.SearchResultsCount);
      LabelFirst.Text = String.Format(LabelFirst.Text, Program.Settings.MaxRefCount);
    }

    private void SelectSearchResultsForm_Load(object sender, EventArgs e)
    {
      CreateReferences(References);
    }

    private void CreateReferences(IEnumerable<ReferenceItem> references)
    {
      Initializing = true;
      try
      {
        LabelCount.Text = "0";
        var query = from r in references
                    group r by r.Book into books
                    select new { Key = books.Key.Number, Count = books.Count() };
        SelectBooks.Items.Clear();
        foreach ( var item in query )
        {
          var row = SelectBooks.Items.Add(MainForm.Instance.DataSet.Books[item.Key - 1].Name);
          row.Tag = item.Key;
          row.SubItems.Add(item.Count.ToString());
        }
        Height = 50 + SelectBooks.Location.Y + SelectBooks.Items.Count * 15 + 75;
        ActiveControl = SelectBooks;
        SelectBooks.Focus();
        if ( References.Count() <= Program.Settings.MaxRefCount )
          LabelFirst.Visible = false;
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
      References = References.Where(r => list.Contains(r.Book.Number));
      if ( EditOnlyWithTranslation.Checked )
        References = References.Where(r => r.Verse.GetTranslation() != "");
      if ( EditOnlyWithoutTranslation.Checked )
        References = References.Where(r => r.Verse.GetTranslation() == "");
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
        CreateReferences(References.Where(r => r.Verse.GetTranslation() != ""));
      else
        CreateReferences(References);
    }

    private void EditOnlyWithoutTranslation_CheckedChanged(object sender, EventArgs e)
    {
      if ( Initializing || Mutex ) return;
      Mutex = true;
      EditOnlyWithTranslation.Checked = false;
      Mutex = false;
      if ( EditOnlyWithoutTranslation.Checked )
        CreateReferences(References.Where(r => r.Verse?.GetTranslation() == ""));
      else
        CreateReferences(References);
    }

    private void LabelCount_TextChanged(object sender, EventArgs e)
    {
      LabelCount.ForeColor = LabelCount.Text == "0" ? Color.DarkRed : Color.DarkGreen;
    }
  }
  
}
