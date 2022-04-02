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
/// <created> 2019-01 </created>
/// <edited> 2022-03 </edited>
namespace Ordisoftware.Hebrew.Words;

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
    using var form = new BibleStatisticsForm();
    form.ShowDialog();
    return form.Reference;
  }

  private ReferenceItem Reference;

  private BibleStatisticsForm()
  {
    var temp = MainForm.Instance.Cursor;
    MainForm.Instance.Cursor = Cursors.WaitCursor;
    try
    {
      InitializeComponent();
      InitializeCounters();
      InitializeMiddle();
      InitializeOccurences();
      SelectBook.DataSource = new BindingList<BookRow>(ApplicationDatabase.Instance.Books);
      SelectBook.DisplayMember = "Name";
    }
    finally
    {
      MainForm.Instance.Cursor = temp;
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
      var stat = new BookStatistic { Book = book };
      CountersBooks.Add((TanakBook)book.Number, stat);
      foreach ( ChapterRow chapter in book.Chapters )
      {
        stat.CountChapters++;
        foreach ( VerseRow verse in chapter.Verses )
        {
          stat.CountVerses++;
          foreach ( var word in verse.Words )
          {
            stat.CountWords++;
            stat.CountLetters += word.Hebrew.Length;
            if ( word.Hebrew.Length > LabelLongestWordValue.Text.Length )
            {
              LabelLongestWordValue.Text = word.Hebrew;
              LabelLongestReferenceValue.Tag = new ReferenceItem(book.Number, chapter.Number, verse.Number, word.Number);
            }
          }
        }
      }
    }
    if ( LabelLongestReferenceValue.Tag is not null )
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
    int max = BooksBounds.Torah.Max;
    foreach ( var book in ApplicationDatabase.Instance.Books.Where(book => book.Number <= max) )
      foreach ( var chapter in book.Chapters )
        foreach ( var verse in chapter.Verses )
          foreach ( var word in verse.Words )
            foreach ( char letter in word.Hebrew )
            {
              index++;
              if ( index == lcount )
              {
                LabelMiddleReferenceValue.Tag = new ReferenceItem(book.Number, chapter.Number, verse.Number, word.Number);
                LabelMiddleReferenceValue.Text = LabelMiddleReferenceValue.Tag.ToString();
                LabelMiddleWordValue.Text = word.Hebrew;
                LabelMiddleLetterValue.Text = letter.ToString();
                return;
              }
            }
  }

  private void SelectBook_SelectedIndexChanged(object sender, EventArgs e)
  {
    try
    {
      var book = (TanakBook)( (BookRow)SelectBook.SelectedItem ).Number;
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
    label.ForeColor = Color.DarkRed;
  }

  private void LabelMiddleValue_MouseLeave(object sender, EventArgs e)
  {
    var label = (Label)sender;
    label.Cursor = Cursors.Hand;
    label.ForeColor = SystemColors.ControlText;
  }

  private void LabelMiddleValue_MouseClick(object sender, MouseEventArgs e)
  {
    HebrewTools.OpenHebrewLetters(( (Label)sender ).Text);
  }

  private void LabelReferenceValue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    Reference = (ReferenceItem)( (LinkLabel)sender ).Tag;
    Close();
  }

  private List<(string Key, int Count)> OccurencesMostFrequent;

  [SuppressMessage("Performance", "U2U1208:Do not call LINQ methods whose effect is undone by subsequent methods", Justification = "N/A")]
  private void InitializeOccurences()
  {
    int max = BooksBounds.Torah.Max;
    // Specific words
    int xpos = 15;
    int ypos = 25;
    addCountOne("Torah", "hrvt", s => s.Contains("hrvt"));
    addCountOne("Israël", "lar>y", s => s.Contains("lar>y"));
    addCountOne("Elohim", "myhla", s => s.Contains("myhla"));
    addCountOne("YHVH", "hvhy", s => s.Contains("hvhy"));
    addCountOne("Mosheh", "h>m", s => s.Contains("h>m"));
    addCountOne("Aharon", "]rha", s => s.Contains("nrha"));
    addCountOne("Mitsvah", "vjm", s => s.Contains("hvjm") || s.Contains("tvjm"));
    addCountOne("Shalom", "mvl>", s => s.Contains("mvl>"));
    addCountOne("Hébreu", "yrbi", s => s.Contains("yrbi"));
    addCountOne("Kodesh", ">dq", s => s.Contains(">dq"));
    addCountOne("Shabat", "tb>", s => s.Contains("tb>"));
    addCountOne("Yehoudi", "ydvhy", s => s.Contains("ydvhy"));
    addCountOne("Ahavah", "hbha", s => s.Contains("hbha"));
    addCountOne("Kosher", "r>k", s => s.Contains("r>k"));
    // Most frequent words
    if ( OccurencesMostFrequent is null )
    {
      var query = from word in ApplicationDatabase.Instance.Words
                  group word by word.Hebrew into grouping
                  select new
                  {
                    grouping.Key,
                    Count = grouping.Count()
                  };
      OccurencesMostFrequent = query.OrderByDescending(item => item.Count)
                                    .Take(40)
                                    .Select(item => (item.Key, item.Count))
                                    .ToList();
    }
    xpos = 15;
    ypos = 25;
    for ( int index = 0; index < OccurencesMostFrequent.Count; index += 10 )
    {
      foreach ( var item in OccurencesMostFrequent.Skip(index).Take(10) )
      {
        addControls(GroupBoxMostFrequentWords, item.Key, item.Key, item.Count, true);
        ypos += 20;
      }
      xpos += 180;
      ypos = 25;
    }
    //
    void addCountOne(string caption, string hebrew, Func<string, bool> check)
    {
      var query1 = from book in ApplicationDatabase.Instance.Books
                   from chapter in book.Chapters
                   from verse in chapter.Verses
                   from word in verse.Words
                   where book.Number <= max
                      && chapter.BookID == book.ID
                      && verse.ChapterID == chapter.ID
                      && word.VerseID == verse.ID
                      && check(HebrewAlphabet.SetFinal(word.Hebrew, false))
                   select word;
      var query2 = from book in ApplicationDatabase.Instance.Books
                   from chapter in book.Chapters
                   from verse in chapter.Verses
                   from word in verse.Words
                   where chapter.BookID == book.ID
                      && verse.ChapterID == chapter.ID
                      && word.VerseID == verse.ID
                      && check(HebrewAlphabet.SetFinal(word.Hebrew, false))
                   select word;
      addControls(GroupBoxOccurencesTorah, caption, hebrew, query1.Count());
      addControls(GroupBoxOccurencesAll, caption, hebrew, query2.Count());
      ypos += 20;
    }
    //
    void addControls(GroupBox group, string caption, string hebrew, int value, bool isHebrew = false)
    {
      var linklabel = new LinkLabel()
      {
        LinkBehavior = LinkBehavior.NeverUnderline,
        TextAlign = ContentAlignment.TopLeft,
        LinkColor = Color.Navy,
        ActiveLinkColor = Color.MediumBlue,
        AutoSize = true,
        Left = xpos,
        Top = ypos,
        Text = caption
      };
      if ( isHebrew )
      {
        linklabel.Font = new Font("Hebrew", 12);
        linklabel.Top -= 5;
      }
      linklabel.Click += (_, _) =>
      {
        Close();
        if ( group == GroupBoxOccurencesTorah )
        {
          Program.Settings.SearchInTorah = true;
          Program.Settings.SearchInKetouvim = false;
          Program.Settings.SearchInNeviim = false;
        }
        else
        {
          Program.Settings.SearchInTorah = true;
          Program.Settings.SearchInKetouvim = true;
          Program.Settings.SearchInNeviim = true;
        }
        MainForm.Instance.SearchHebrewWord(hebrew);
      };
      var labelValue = new Label()
      {
        AutoSize = false,
        Size = new Size(50, 13),
        Left = xpos + 60,
        Top = ypos,
        TextAlign = ContentAlignment.TopRight,
        Text = value.ToString()
      };
      group.Controls.Add(linklabel);
      group.Controls.Add(labelValue);
    }
  }

}
