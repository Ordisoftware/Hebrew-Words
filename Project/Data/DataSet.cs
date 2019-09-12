namespace Ordisoftware.HebrewWords.Data
{

  partial class DataSet
  {

  }

  static public class DataSetHelper
  {

    static public string GetTranslation(this DataSet.VersesRow verse)
    {
      string result = "";
      foreach ( DataSet.WordsRow word in verse.GetWordsRows() )
        result = result + word.Translation + " ";
      return result.Trim();
    }

  }

}
