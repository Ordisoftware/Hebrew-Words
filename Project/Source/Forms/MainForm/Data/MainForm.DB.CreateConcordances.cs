/// <license>
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
/// <edited> 2019-09 </edited>
namespace Ordisoftware.Hebrew.Words;

partial class MainForm : Form
{

  /*private void CreateConcordances()
  {
    int count = 0;
    using ( var connection = new OdbcConnection(Settings.ConnectionString) )
    {
      connection.Open();
      var command = new OdbcCommand("select count(*) FROM StrongConcordances", connection);
      count = (int)command.ExecuteScalar();
      connection.Close();
    }
    if ( count != 0 )
      return;
    string filePath = Path.Combine(Program.AppCSVDocumentsFolderPath, "BHS-Strong-no\\brief_info_StrongNo.csv");
    var lines = File.ReadAllLines(filePath).ToList();
    foreach ( string line in lines )
    {
      var items = line.Split('\t');
      var concordance = DataSet.StrongConcordances.NewStrongConcordancesRow();
      concordance.ID = items[0];
      concordance.Usage = items[1];
      concordance.Original = items[2];
      concordance.Hebrew = HebrewAlphabet.ToHebrewFont(items[2].RemoveDiacritics());
      concordance.Transliteration = items[3];
      concordance.Phonetic = items[4];
      concordance.Translation = items[5];
      concordance.Memo = "";
      DataSet.StrongConcordances.AddStrongConcordancesRow(concordance);
    }
    TableAdapterManager.UpdateAll(DataSet);
  }*/

  //Dictionary<int, SortedDictionary<string, WordWithConcordance>> VersesWithConcordances
  //  = new Dictionary<int, SortedDictionary<string, WordWithConcordance>>();

  private void ImportWordsConcordances()
  {
    //CreateWordsConcordances();
    LoadingForm.Instance.Initialize("Importing strong's concordances...",
                                    ApplicationDatabase.Instance.Books.Sum(book => book.Chapters.Count));
    LoadingForm.Instance.TopMost = false;
    var errors = new List<string>();
    int indexBook = -1;
    try
    {
      foreach ( BookRow book in ApplicationDatabase.Instance.Books )
      {
        indexBook++;
        int indexVerse = -1;
        if ( indexBook >= 1 ) break;
        foreach ( ChapterRow chapter in book.Chapters )
        {
          LoadingForm.Instance.DoProgress();
          foreach ( VerseRow verse in chapter.Verses )
          {
            indexVerse++;
            int indexWord = -1;
            int countBad = 0;
            var words = Program.JsonBibleBookGenesis[indexVerse].Items;
            //.SelectMany(w => new { strong = w.I, word = w.Word.Split('#') })//.Replace("-", "").Replace("׃", "").Split(' '))
            //.ToArray();
            /*if ( verse.Words.Length != words.Length )
            {
              errors.Add("##### " + new ReferenceItem(book, chapter, verse).ToString() + " words count mismatch");
              //indexVerse--;
              continue;
            }*/
            if ( indexVerse < Program.JsonBibleBookGenesis.Length )
              foreach ( WordRow word in verse.Words )
              {
                indexWord++;
                if ( indexWord < words.Length )
                {
                  var unicode = words[indexWord].Word;
                  var hebrew = HebrewAlphabet.ToHebrewFont(unicode);
                  hebrew = HebrewAlphabet.OnlyHebrewFont(hebrew);
                  int nc = CommonCount(word.Hebrew, hebrew);
                  if ( word.Hebrew == hebrew || nc >= Math.Min(word.Hebrew.Length, hebrew.Length) - 1 )
                  {
                    // TODO update fields
                    countBad = 0;
                  }
                  else
                  {
                    errors.Add(new ReferenceItem(book, chapter, verse).ToString() + "." + ( indexWord + 1 ) + "\t\t" +
                               word.Hebrew + " <=> " + hebrew + "\t\t" +
                               word.Original + " <=> " + unicode + "\t\t" + words[indexWord].Number + " : " + words[indexWord].Text);
                    countBad++;
                    if ( countBad >= 4 )
                    {
                      errors.Add("!!!!! Verse mismatch !!!!!");
                      //indexVerse--;
                      //continue;
                    }
                  }
                }
                else
                {
                  errors.Add(new ReferenceItem(book, chapter, verse).ToString() + "." + ( indexWord + 1 ) + "\t\t" +
                             word.Hebrew + " is missing or at wrong place\t\t" +
                             word.Original + " is missing or at wrong place");
                  countBad++;
                  if ( countBad >= 4 )
                  {
                    errors.Add("!!!!! Verse mismatch !!!!!");
                    //indexVerse--;
                    //continue;
                  }
                }
              }
            else
              errors.Add(new ReferenceItem(book, chapter, verse).ToString() + " is missing.");
          }
        }
      }
      // TODO update TableAdapterManager.UpdateAll(DataSet);
    }
    catch ( Exception ex )
    {
      ex.Manage();
    }
    finally
    {
      LoadingForm.Instance.Hide();
    }
    var f = new ImportStrongForm();
    f.RichTextBox.Text = string.Join(Environment.NewLine, errors.Take(10000));
    f.ShowDialog();
  }

  public int CommonCount<T>(IEnumerable<T> source, IEnumerable<T> sequence, IEqualityComparer<T> comparer = null)
  {
    if ( sequence == null )
      return 0;
    if ( comparer == null )
      comparer = EqualityComparer<T>.Default;
    return source.GroupBy(t => t, comparer)
                 .Join(sequence.GroupBy(t => t, comparer),
                                        g => g.Key,
                                        g => g.Key,
                                        (lg, rg) => lg.Zip(rg, (l, _) => l).Count(), comparer)
                 .Sum();
  }

  /*private void CreateWordsConcordances()
  {
    try
    {
      string filePath = Program.AppCSVDocumentsFolderPath
                    + "OpenHebrewBible\\WLC_mappingTemplate_takenAway_wordWithoutSN.csv";
      var lines = File.ReadAllLines(filePath).Skip(2).ToList();
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
          item.Hebrew = new string(HebrewAlphabet.ToHebrewFont(items[3].RemoveDiacritics()).ToArray());
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
  }*/

}

class WordWithConcordance
{
  public string Original;
  public string Hebrew;
  public string Transliteration;
  public string Concordance;
  public string Translation;
}
