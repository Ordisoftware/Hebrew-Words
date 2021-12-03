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
/// <created> 2019-01 </created>
/// <edited> 2021-12 </edited>
namespace Ordisoftware.Hebrew.Words;

using Equin.ApplicationFramework;

partial class BibleStatisticsForm : Form
{

  private sealed class BookStatistic
  {
    public BookRow Book;
    public int CountChapters;
    public int CountVerses;
    public int CountWords;
    public int CountLetters;
  }

  static public ReferenceItem Run()
  {
    var form = new BibleStatisticsForm();
    form.ShowDialog();
    return form.Reference;
  }

  private ReferenceItem Reference;

  private BibleStatisticsForm()
  {
    InitializeComponent();
    MainForm.Instance.SetFormDisabled(true);
    try
    {
      InitializeCounters();
      InitializeMiddle();
      InitializeOccurences();
      SelectBook.DataSource = ApplicationDatabase.Instance.BooksAsBindingList;
      SelectBook.DisplayMember = "Name";
    }
    finally
    {
      MainForm.Instance.SetFormDisabled(false);
    }
  }

  private void ActionClose_Click(object sender, EventArgs e)
  {
    Close();
  }

  private readonly Dictionary<TanakBook, BookStatistic> CountersBooks = new();
  private readonly BookStatistic CountersAll = new();
  private readonly BookStatistic CountersTorah = new();
  private BookStatistic CountersSelected = new();

  private void InitializeCounters()
  {
    foreach ( BookRow book in ApplicationDatabase.Instance.Books )
    {
      var stat = new BookStatistic() { Book = book };
      CountersBooks.Add(( (TanakBook)book.Number ) - 1, stat);
      foreach ( ChapterRow chapter in book.Chapters )
      {
        stat.CountChapters++;
        foreach ( VerseRow verse in chapter.Verses )
        {
          stat.CountVerses++;
          foreach ( var hebrew in verse.Words.Select(word => word.Hebrew) )
          {
            stat.CountWords++;
            stat.CountLetters += hebrew.Length;
            if ( hebrew.Length > LabelLongestWordValue.Text.Length )
            {
              LabelLongestWordValue.Text = hebrew;
              LabelLongestReferenceValue.Tag = new ReferenceItem(book.Number, chapter.Number, verse.Number);
            }
          }
        }
      }
    }
    if ( LabelLongestReferenceValue.Tag != null )
      LabelLongestReferenceValue.Text = ( (ReferenceItem)LabelLongestReferenceValue.Tag ).ToString();
    void count(TanakBook book, BookStatistic counters)
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
    foreach ( TanakBook book in Enum.GetValues(typeof(TanakBook)) )
      count(book, CountersAll);
    foreach ( TanakBook book in Enum.GetValues(typeof(TorahBook)) )
      count(book, CountersTorah);
    SetCounters(StatAllBooks, CountersAll);
    SetCounters(StatTorah, CountersTorah);
  }

  void SetCounters(StatControl control, BookStatistic stat)
  {
    control.LabelChaptersValue.Text = stat.CountChapters.ToString();
    control.LabelVersesValue.Text = stat.CountVerses.ToString();
    control.LabelWordsValue.Text = stat.CountWords.ToString();
    control.LabelLettersValue.Text = stat.CountLetters.ToString();
  }

  private void InitializeMiddle()
  {
    int lcount = (int)Math.Truncate(CountersTorah.CountLetters / 2.0);
    int index = 0;
    var books = from book in ApplicationDatabase.Instance.Books
                where book.Number <= BooksBounds.Torah.Max
                select book;
    foreach ( var book in books )
      foreach ( var chapter in book.Chapters )
        foreach ( var verse in chapter.Verses )
          foreach ( var hebrew in verse.Words.Select(word => word.Hebrew) )
            foreach ( char letter in hebrew )
            {
              index++;
              if ( index == lcount )
              {
                LabelMiddleReferenceValue.Tag = new ReferenceItem(book.Number, chapter.Number, verse.Number);
                LabelMiddleReferenceValue.Text = LabelMiddleReferenceValue.Tag.ToString();
                LabelMiddleWordValue.Text = hebrew;
                LabelMiddleLetterValue.Text = letter.ToString();
                return;
              }
            }
  }

  private void InitializeOccurences()
  {
    string getCount(Func<string, bool> check)
    {
      var query = from book in ApplicationDatabase.Instance.Books
                  from chapter in book.Chapters
                  from verse in chapter.Verses
                  from word in verse.Words
                  where check(word.Hebrew) && book.Number <= BooksBounds.Torah.Max
                  select word;
      return query.Count().ToString();
    }
    LabelCountTorahValue.Text = getCount(s => s.Contains("hrvt"));
    LabelCountElohimValue.Text = getCount(s => HebrewAlphabet.SetFinal(s, false).Contains("myhla"));
    LabelCountYHVHValue.Text = getCount(s => s.Contains("hvhy"));
    LabelCountMoshehValue.Text = getCount(s => s.EndsWith("h>m"));
    LabelCountMitsvahValue.Text = getCount(s => s.Contains("hvjm") || s.Contains("tvjm"));
  }

  private void SelectBook_SelectedIndexChanged(object sender, EventArgs e)
  {
    try
    {
      TanakBook book = (TanakBook)( ( SelectBook.SelectedItem as ObjectView<BookRow> ).Object.Number - 1 );
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
    HebrewTools.OpenHebrewLetters(( (Label)sender ).Text, Program.Settings.HebrewLettersExe);
  }

  private void LabelReferenceValue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    Reference = (ReferenceItem)( (LinkLabel)sender ).Tag;
    Close();
  }

}