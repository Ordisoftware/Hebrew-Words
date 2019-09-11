namespace Ordisoftware.HebrewWords.Data
{

  partial class DataSet
  {

    public string GetTranslation(VersesRow verse)
    {
      string result = "";
      foreach ( WordsRow word in verse.GetWordsRows() )
        result = result + word.Translation + " ";
      return result.Remove(result.Length - 1, 1);
    }

  }

}
