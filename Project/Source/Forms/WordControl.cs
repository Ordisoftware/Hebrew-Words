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
/// <created> 2012-10 </created>
/// <edited> 2015-06 </edited>
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  public partial class WordControl : UserControl
  {

    public event MouseEventHandler HebrewMouseClick
    {
      add { LabelHebrew.MouseClick += value; }
      remove { LabelHebrew.MouseClick -= value; }
    }

    public Data.DataSet.WordsRow Word
    {
      get
      {
        return _Word;
      }
      set
      {
        _Word = value;
        LabelHebrew.Text = value.Hebrew;
        EditTranslation.Text = value.Translation;
        LabelHebrew.Tag = value.Original;
      }
    }

    private Data.DataSet.WordsRow _Word;

    public WordControl()
    {
      InitializeComponent();
    }
    
    private void EditTranslation_TextChanged(object sender, System.EventArgs e)
    {
      _Word.Translation = EditTranslation.Text;
    }

  }

}
