using System;
using System.IO;
using System.Collections.Generic;

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
  using System.Collections.Generic;

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

  public partial class VersePart
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
    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    {
      MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
      DateParseHandling = DateParseHandling.None,
      Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
    };
  }

  internal class ParseIntegerConverter : JsonConverter
  {
    public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
      if ( reader.TokenType == JsonToken.Null ) return null;
      var value = serializer.Deserialize<string>(reader);
      long l;
      if ( Int64.TryParse(value, out l) )
      {
        return l;
      }
      throw new Exception("Cannot unmarshal type long");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
      if ( untypedValue == null )
      {
        serializer.Serialize(writer, null);
        return;
      }
      var value = (long)untypedValue;
      serializer.Serialize(writer, value.ToString());
      return;
    }

    public static readonly ParseIntegerConverter Singleton = new ParseIntegerConverter();
  }

}
