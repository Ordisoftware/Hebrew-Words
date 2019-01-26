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
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void StatisticsForm_Load(object sender, EventArgs e)
    {
      Initialize();
      foreach ( Data.DataSet.BooksRow book in MainForm.Instance.DataSet.Books.Rows )
        EditBook.Items.Add(new BookItem() { Row = book });
      EditBook.SelectedIndex = 0;
    }

    private Dictionary<Books, BookStatistic> CountersBooks = new Dictionary<Books, BookStatistic>();
    private BookStatistic CountersAll = new BookStatistic();
    private BookStatistic CountersTorah = new BookStatistic();
    private BookStatistic CountersSelected = new BookStatistic();

    private void Initialize()
    {
      int countBooks = 0;
      foreach ( Data.DataSet.BooksRow book in MainForm.Instance.DataSet.Books )
      {
        countBooks++;
        var stat = new BookStatistic() { Book = book };
        CountersBooks.Add(((Books)book.Number) - 1, stat);
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

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        Books book = (Books)( ( (BookItem)EditBook.SelectedItem ).Row.Number - 1 );
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

  }

}


      /*int i = 0;
      foreach ( AllBooks b in Enum.GetValues(typeof(TorahBooks)) )
      {
        ccount = 0;
        foreach ( var c in Books.Instance[b] )
        {
          ccount++;
          vcount = 0;
          foreach ( var v in c )
          {
            vcount++;
            wcount = 0;
            foreach ( var w in v )
            {
              wcount++;
              string s = w.Hebrew.Replace(' ', '\0');
              foreach ( var l in Letters.FinaleDisable )
                s = s.Replace(l.Key, l.Value);
              foreach ( char l in s )
              {
                i++;
                if ( i >= lcount / 2 )
                {
                  AddText(panelVerses.LatinFont, GetRefText(true, vcount - 1, ccount - 1, b));
                  AddLine();
                  AddText(panelVerses.LatinFont, "Milieu de la Torah - Verse : ");
                  AddText(panelVerses.HebrewFont, v.ToString());
                  AddLine();
                  AddText(panelVerses.LatinFont, "Milieu de la Torah - Word : ");
                  AddText(panelVerses.HebrewFont, w.Hebrew);
                  AddLine();
                  AddText(panelVerses.LatinFont, "Milieu de la Torah - Letter : ");
                  AddText(panelVerses.HebrewFont, l.ToString());
                  AddLine();
                  return;
                }
              }
            }
          }
        }
        }*/