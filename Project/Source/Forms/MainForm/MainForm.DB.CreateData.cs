/// <license>
/// This file is part of Ordisoftware Hebrew Words.
/// Copyright 2012-2020 Olivier Rogier.
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
/// <edited> 2020-03 </edited>
using System;
using System.IO;
using System.Linq;
using System.Data;
using System.Data.Odbc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ordisoftware.Core;

namespace Ordisoftware.HebrewWords
{

  public partial class MainForm : Form
  {

    /// <summary>
    /// Create database content if not exists.
    /// </summary>
    public void CreateDataIfNotExists()
    {
      CreateConcordances();
      CreateBooks();
    }

    private void CreateConcordances()
    {
      int count = 0;
      using ( var connection = new OdbcConnection(Program.Settings.ConnectionString) )
      {
        connection.Open();
        var command = new OdbcCommand("select count(*) FROM StrongConcordances", connection);
        count = (int)command.ExecuteScalar();
        connection.Close();
      }
      if ( count != 0 )
        return;
      string filename = Program.AppCSVDocumentsFolderPath + "BHS-Strong-no\\brief_info_StrongNo.csv";
      var lines = File.ReadAllLines(filename).ToList();
      foreach ( string line in lines )
      {
        var items = line.Split('\t');
        var concordance = DataSet.StrongConcordances.NewStrongConcordancesRow();
        concordance.ID = items[0];
        concordance.Usage = items[1];
        concordance.Original = items[2];
        concordance.Hebrew = HebrewLetters.ConvertToHebrewFont(items[2].RemoveDiacritics());
        concordance.Transliteration = items[3];
        concordance.Phonetic = items[4];
        concordance.Translation = items[5];
        concordance.Memo = "";
        DataSet.StrongConcordances.AddStrongConcordancesRow(concordance);
      }
      TableAdapterManager.UpdateAll(DataSet);
    }

    private void CreateBooks()
    {
      int count = 0;
      using ( var connection = new OdbcConnection(Program.Settings.ConnectionString) )
      {
        connection.Open();
        var command = new OdbcCommand("select count(*) FROM Books", connection);
        count = (int)command.ExecuteScalar();
        connection.Close();
      }
      if ( count != 0 )
      {
        BooksTableAdapter.Fill(DataSet.Books);
        foreach ( Data.DataSet.BooksRow book in DataSet.Books.Rows )
        {
          Books enumBook = (Books)( book.Number - 1 );
          book.Hebrew = BooksNames.Hebrew[enumBook];
          book.Original = BooksNames.Original[enumBook];
          book.Name = Enum.GetName(typeof(Books), enumBook).Replace("_", " ");
          if ( book.CommonName == "" )
            book.CommonName = BooksNames.Common.GetLang(enumBook);
        }
        TableAdapterManager.UpdateAll(DataSet);
      }
      else
      {
        bool inprogress = true;
        int index = 0;
        int delta = 1;
        var form = new LoadingForm();
        form.LabelOperation.Text = Translations.CreatingData.GetLang();
        form.ProgressBar.Maximum = 64;
        form.Show();
        try
        {
          var taskProgress = new Task(() =>
          {
            while ( inprogress )
            {
              Application.DoEvents();
              index += delta;
              if ( index == form.ProgressBar.Maximum ) delta = -1;
              if ( index == 0 ) delta = +1;
              form.ProgressBar.SyncUI(() => form.ProgressBar.Value = index);
              this.SyncUI(Refresh);
              form.SyncUI(form.Refresh);
              Thread.Sleep(200);
            }
          });
          taskProgress.Start();
          var taskLoad = new Task(() =>
          {
            FillFromFiles();
          });
          taskLoad.Start();
          while ( inprogress )
          {
            Application.DoEvents();
            if ( taskLoad.IsCompleted ) inprogress = false;
            Thread.Sleep(200);
          }
          form.ProgressBar.Value = form.ProgressBar.Maximum;
        }
        finally
        {
          inprogress = false;
          form.Close();
        }
      }
    }

    Dictionary<int, SortedDictionary<string, WordWithConcordance>> VersesWithConcordances
      = new Dictionary<int, SortedDictionary<string, WordWithConcordance>>();

    private void ImportWordsConcordances()
    {
      CreateWordsConcordances();
      var form = new LoadingForm();
      form.LabelOperation.Text = "Importing strong's concordances...";
      form.Show();
      form.Refresh();
      form.ProgressBar.Maximum = DataSet.Chapters.Count;
      var errors = new List<string>();
      int indexVerse = 0;
      int indexWord = 0;
      try
      {
        foreach ( Data.DataSet.BooksRow book in Instance.DataSet.Books )
          foreach ( Data.DataSet.ChaptersRow chapter in book.GetChaptersRows() )
          {
            form.ProgressBar.PerformStep();
            Refresh();
            Application.DoEvents();
            foreach ( Data.DataSet.VersesRow verse in chapter.GetVersesRows() )
            {
              indexVerse++;
              indexWord = 0;
              int countBad = 0;
              if ( VersesWithConcordances.ContainsKey(indexVerse) )
                foreach ( Data.DataSet.WordsRow word in verse.GetWordsRows() )
                  if ( indexWord < VersesWithConcordances[indexVerse].Values.Count )
                  {
                    var concordance = VersesWithConcordances[indexVerse].Values.ElementAt(indexWord);
                    int nc = CommomCount(word.Hebrew, concordance.Hebrew);
                    if ( word.Hebrew == concordance.Hebrew
                      || nc >= Math.Min(word.Hebrew.Length, concordance.Hebrew.Length) - 1 )
                    {
                      // update fields
                      indexWord++;
                      countBad = 0;
                    }
                    else
                    {
                      errors.Add(new ReferenceItem(book, chapter, verse).ToString() + "." + indexWord + "\t\t" + 
                                 word.Hebrew + " <=> " + concordance.Hebrew + "\t\t" +
                                 word.Original + " <=> " + concordance.Original);
                      countBad++;
                      if ( countBad >= 4 )
                      {
                        errors.Add("!!!!! Verse mismatch !!!!!");
                        indexVerse--;
                        break;
                      }
                    }
                  }
            }
          }
        TableAdapterManager.UpdateAll(DataSet);
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
      finally
      {
        form.Close();
      }
      var f = new ImportStrongForm();
      f.RichTextBox.Text = string.Join(Environment.NewLine, errors.Take(10000));
      f.ShowDialog();
    }

    public int CommomCount<T>(IEnumerable<T> source, IEnumerable<T> sequence, IEqualityComparer<T> comparer = null)
    {
      if ( sequence == null )
        return 0;
      if ( comparer == null )
        comparer = EqualityComparer<T>.Default;
      return source.GroupBy(t => t, comparer)
             .Join(sequence.GroupBy(t => t, comparer),
                   g => g.Key,
                   g => g.Key,
                   (lg, rg) => lg.Zip(rg, (l, r) => l).Count(),
                   comparer)
             .Sum();
    }

    private void CreateWordsConcordances()
    {
      try
      {
        string filename = Program.AppCSVDocumentsFolderPath
                      + "OpenHebrewBible\\WLC_mappingTemplate_takenAway_wordWithoutSN.csv";
        var lines = File.ReadAllLines(filename).Skip(2).ToList();
        for ( int index = 0; index < lines.Count; index++ )
        {
          if ( lines[index] == "＠" )
          {
            continue;
          }
          var items = lines[index].Split('\t');
          if ( !int.TryParse(items[0], out int verseNum) )
          {
            MessageBox.Show("Bad number format at line n° " + index);
            continue;
          }
          if ( !VersesWithConcordances.ContainsKey(verseNum) )
            VersesWithConcordances.Add(verseNum, new SortedDictionary<string, WordWithConcordance>());
          if ( !VersesWithConcordances[verseNum].ContainsKey(items[2]) )
          {
            if ( items[7].Contains("】") )
              items[7] = items[7].Split('】')[1];
            items[3] = items[3].Replace("־", "");
            items[3] = items[3].Replace("׃", "");
            items[3] = items[3].Trim('(');
            items[3] = items[3].Trim(')');
            items[3] = items[3].Trim(" ׀".ToCharArray());
            items[3] = items[3].Trim(' ');
            items[3] = items[3].Trim(new char[] { Convert.ToChar(8234), Convert.ToChar(8236) });
            items[3] = items[3].Trim();
            var item = new WordWithConcordance();
            item.Original = items[3].RemoveDiacritics();
            item.Hebrew = new string(HebrewLetters.ConvertToHebrewFont(items[3].RemoveDiacritics()).Reverse().ToArray());
            item.Transliteration = items[4];
            item.Concordance = items[6];
            item.Translation = items[7];
            VersesWithConcordances[verseNum].Add(items[2], item);
          }
          else
          {
            MessageBox.Show("Duplicated at line n° " + index);
            continue;
          }
        }
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
    }

  }

  public class WordWithConcordance
  {
    public string Original;
    public string Hebrew;
    public string Transliteration;
    public string Concordance;
    public string Translation;
  }

}
