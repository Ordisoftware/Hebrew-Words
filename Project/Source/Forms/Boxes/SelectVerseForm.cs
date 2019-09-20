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
/// <created> 2019-01 </created>
/// <edited> 2019-01 </edited>
using System;
using System.Linq;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  public partial class SelectVerseForm : Form
  {

    static public ReferenceItem Run()
    {
      var form = new SelectVerseForm();
      form.EditVerseNumber.Maximum = MainForm.Instance.CurrentReference.Chapter.GetVersesRows().Count();
      if ( form.ShowDialog() != DialogResult.OK ) return null;
      int value = (int)form.EditVerseNumber.Value;
      return new ReferenceItem(MainForm.Instance.CurrentReference.Book.Number,
                               MainForm.Instance.CurrentReference.Chapter.Number,
                               (int)form.EditVerseNumber.Value);
    }

    private SelectVerseForm()
    {
      InitializeComponent();
      Text = AboutBox.Instance.AssemblyTitle;
      EditVerseNumber.Select(0, 1);
    }

  }

}
