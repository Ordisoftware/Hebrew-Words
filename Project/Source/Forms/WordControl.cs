/// <license>
/// This file is part of Ordisoftware Hebrew Letters.
/// Copyright 2012-2015 Olivier Rogier. 
/// See www.ordisoftware.com for more information.
/// Project is registered at Depotnumerique.com (Agence des Depots Numeriques).
/// This program is free software: you can redistribute it and/or modify it under the terms of
/// the GNU General Public License (GPL v3) as published by the Free Software Foundation,
/// either version 3 of the License, or (at your option) any later version.
/// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
/// without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
/// See the GNU General Public License for more details.
/// You should have received a copy of the GNU General Public License along with this program.
/// If not, see www.gnu.org/licenses website.
/// </license>
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  public partial class WordControl : UserControl
  {

    public event LinkLabelLinkClickedEventHandler HebrewClicked
    {
      add { LabelHebrew.LinkClicked += value; }
      remove { LabelHebrew.LinkClicked -= value; }
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

    private void EditComment_TextChanged(object sender, System.EventArgs e)
    {
    }
  }

}
