#pragma warning disable VSSpell001 // Spell Check
namespace Ordisoftware.Hebrew.Words
{
  static public partial class JsonHelper
  {
    static public Json.Verse.JsonVerse[] LoadBook(string filePath)
    {
      return Json.Verse.JsonVerse.FromJson(File.ReadAllText(filePath));
    }
  }
}

// https://github.com/quicktype/quicktype-vs
namespace Ordisoftware.Hebrew.Words.Json.Verse
{
  using System;

  using System.Globalization;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  public partial class JsonVerse
  {
    [JsonProperty("verse")]
    public VersePart[] Items { get; set; }

    [JsonProperty("id")]
    [JsonConverter(typeof(ParseIntegerConverter))]
    public long Id { get; set; }
  }

  public class VersePart
  {
    [JsonProperty("i")]
    public long I { get; set; }

    [JsonProperty("text")]
    public string Text { get; set; }

    [JsonProperty("word")]
    public string Word { get; set; }

    [JsonProperty("number")]
    public string Number { get; set; }
  }

  public partial class JsonVerse
  {
    public static JsonVerse[] FromJson(string json) => JsonConvert.DeserializeObject<JsonVerse[]>(json, Converter.Settings);
  }

  public static class Serialize
  {
    public static string ToJson(this JsonVerse[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
  }

  internal static class Converter
  {
    public static readonly JsonSerializerSettings Settings = new()
    {
      MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
      DateParseHandling = DateParseHandling.None,
      Converters = { new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal } }
    };
  }

  internal class ParseIntegerConverter : JsonConverter
  {
    public override bool CanConvert(Type objectType) => objectType == typeof(long) || objectType == typeof(long?);

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
      if ( reader.TokenType == JsonToken.Null ) return null;
      var value = serializer.Deserialize<string>(reader);
      if ( Int64.TryParse(value, out long l) )
        return l;
      throw new Exception("Cannot unmarshal type long");
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
      if ( value is null )
      {
        serializer.Serialize(writer, null);
        return;
      }
      var valueTyped = (long)value;
      serializer.Serialize(writer, valueTyped.ToString());
    }

    public static readonly ParseIntegerConverter Singleton = new();
  }

}
#pragma warning restore VSSpell001 // Spell Check
