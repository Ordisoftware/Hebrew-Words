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
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ordisoftware.HebrewWords
{

  public partial class StatisticsForm : Form
  {

    private class BookStatistic
    {
      public Data.DataSet.BooksRow Book;
      public int CountChapters;
      public int CountVerses;
      public int CountWords;
      public int CountLetters;
    }

    public StatisticsForm()
    {
      InitializeComponent();
      Icon = MainForm.Instance.Icon;
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void StatisticsForm_Load(object sender, EventArgs e)
    {
      InitializeCounters();
      InitializeMiddle();
      foreach ( Data.DataSet.BooksRow book in MainForm.Instance.DataSet.Books.Rows )
        SelectBook.Items.Add(new BookItem() { Book = book });
      SelectBook.SelectedIndex = 0;
    }

    private Dictionary<Books, BookStatistic> CountersBooks = new Dictionary<Books, BookStatistic>();
    private BookStatistic CountersAll = new BookStatistic();
    private BookStatistic CountersTorah = new BookStatistic();
    private BookStatistic CountersSelected = new BookStatistic();

    private void InitializeCounters()
    {
      foreach ( Data.DataSet.BooksRow book in MainForm.Instance.DataSet.Books )
      {
        var stat = new BookStatistic() { Book = book };
        CountersBooks.Add(( (Books)book.Number ) - 1, stat);
        foreach ( Data.DataSet.ChaptersRow chapter in book.GetChaptersRows() )
        {
          stat.CountChapters++;
          foreach ( Data.DataSet.VersesRow verse in chapter.GetVersesRows() )
          {
            stat.CountVerses++;
            foreach ( Data.DataSet.WordsRow word in verse.GetWordsRows() )
            {
              stat.CountWords++;
              stat.CountLetters += word.Hebrew.Length;
            }
          }
        }
      }
      void count(Books book, BookStatistic counters)
      {
        try
        {
          counters.CountChapters += CountersBooks[book].CountChapters;
          counters.CountVerses += CountersBooks[book].CountVerses;
          counters.CountWords += CountersBooks[book].CountWords;
          counters.CountLetters += CountersBooks[book].CountLetters;
        }
        catch
        {
        }
      }
      foreach ( Books book in Enum.GetValues(typeof(Books)) )
        count(book, CountersAll);
      foreach ( Books book in Enum.GetValues(typeof(TorahBooks)) )
        count(book, CountersTorah);
      SetCounters(StatAllBooks, CountersAll);
      SetCounters(StatTorah, CountersTorah);
    }

    void SetCounters(StatControl control, BookStatistic stat)
    {
      control.LabelChapters.Text = stat.CountChapters.ToString();
      control.LabelVerses.Text = stat.CountVerses.ToString();
      control.LabelWords.Text = stat.CountWords.ToString();
      control.LabelLetters.Text = stat.CountLetters.ToString();
    }

    private void SelectBook_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        Books book = (Books)( ( (BookItem)SelectBook.SelectedItem ).Book.Number - 1 );
        CountersSelected = new BookStatistic();
        CountersSelected.CountChapters += CountersBooks[book].CountChapters;
        CountersSelected.CountVerses += CountersBooks[book].CountVerses;
        CountersSelected.CountWords += CountersBooks[book].CountWords;
        CountersSelected.CountLetters += CountersBooks[book].CountLetters;
      }
      catch
      {
      }
      SetCounters(StatBook, CountersSelected);
    }

    private void InitializeMiddle()
    {
      int lcount = (int)Math.Truncate((double)CountersTorah.CountLetters / 2.0);
      int index = 0;
      var books = from book in MainForm.Instance.DataSet.Books
                  where book.Number <= 5
                  orderby book.Number
                  select book;
      foreach ( Data.DataSet.BooksRow book in books )
        foreach ( Data.DataSet.ChaptersRow chapter in book.GetChaptersRows() )
          foreach ( Data.DataSet.VersesRow verse in chapter.GetVersesRows() )
            foreach ( Data.DataSet.WordsRow word in verse.GetWordsRows() )
              foreach ( char letter in word.Hebrew )
              {
                index++;
                if ( index == lcount )
                {
                  LabelMiddleReferenceValue.Tag = new ReferenceItem(book.Number, chapter.Number, verse.Number);
                  LabelMiddleReferenceValue.Text = LabelMiddleReferenceValue.Tag.ToString();
                  LabelMiddleWordValue.Text = word.Hebrew;
                  LabelMiddleLetterValue.Text = letter.ToString(); ;
                  return;
                }
              }
    }
  
    private void LabelMiddleValue_MouseEnter(object sender, EventArgs e)
    {
      var label = (Label)sender;
      label.Cursor = Cursors.Hand;
      label.ForeColor = System.Drawing.Color.DarkRed;
    }

    private void LabelMiddleValue_MouseLeave(object sender, EventArgs e)
    {
      var label = (Label)sender;
      label.Cursor = Cursors.Hand;
      label.ForeColor = System.Drawing.SystemColors.ControlText;
    }

    private void LabelMiddleValue_MouseClick(object sender, MouseEventArgs e)
    {
      Program.OpenHebrewLetters(((Label)sender).Text);
    }

    private void LabelMiddleReferenceValue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      var reference = (ReferenceItem)LabelMiddleReferenceValue.Tag;
      MainForm.Instance.GoTo(reference);
      Close();
    }
  }

}
