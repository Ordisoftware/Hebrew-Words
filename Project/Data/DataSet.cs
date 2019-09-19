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
      {
        var str = word.Translation.Trim();
        result += str != "" ? str + " " : "[...] ";
      }
      return result.Trim();
    }

    static public bool IsTranslated(this DataSet.VersesRow verse)
    {
      foreach ( DataSet.WordsRow word in verse.GetWordsRows() )
        if ( word.Translation.Trim() != "" )
          return true;
      return false;
    }

    static public bool IsFullyTranslated(this DataSet.VersesRow verse)
    {
      foreach ( DataSet.WordsRow word in verse.GetWordsRows() )
        if ( word.Translation.Trim() == "" )
          return false;
      return true;
    }

    static public bool IsPartiallyTranslated(this DataSet.VersesRow verse)
    {
      bool? haveEmpty = null;
      bool? haveTranslation = null;
      foreach ( DataSet.WordsRow word in verse.GetWordsRows() )
      {
        if ( word.Translation.Trim() == "" )
          haveEmpty = true;
        if ( word.Translation.Trim() != "" )
          haveTranslation = true;
        if ( haveEmpty.HasValue && haveEmpty.Value == true
          && haveTranslation.HasValue && haveTranslation.Value == true )
          return true;
      }
      return false;
    }

  }

}
