using System;
using System.IO;
using System.Collections.Generic;

namespace Ordisoftware.Hebrew.Words
{
  static public partial class JsonHelper
  {
    static public Dictionary<string, Json.Strong.StrongItem> LoadStrongs(string filePath)
    {
      return Json.Strong.StrongItem.FromJson(File.ReadAllText(filePath))[0];
    }
  }
}

// https://github.com/quicktype/quicktype-vs
namespace Ordisoftware.Hebrew.Words.Json.Strong
{
  using System;
  using System.Collections.Generic;

  using System.Globalization;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  public partial class StrongItem
  {
    [JsonProperty("lemma")]
    public string Lemma { get; set; }

    [JsonProperty("xlit")]
    public string Xlit { get; set; }

    [JsonProperty("pron")]
    public string Pron { get; set; }

    [JsonProperty("derivation", NullValueHandling = NullValueHandling.Ignore)]
    public string Derivation { get; set; }

    [JsonProperty("strongs_def")]
    public string StrongsDef { get; set; }

    [JsonProperty("kjv_def", NullValueHandling = NullValueHandling.Ignore)]
    public string KjvDef { get; set; }
  }

  public partial class StrongItem
  {
    public static Dictionary<string, StrongItem>[] FromJson(string json)
      => JsonConvert.DeserializeObject<Dictionary<string, StrongItem>[]>(json, Converter.Settings);
  }

  public static class Serialize
  {
    public static string ToJson(this Dictionary<string, StrongItem>[] self)
      => JsonConvert.SerializeObject(self, Converter.Settings);
  }

  internal static class Converter
  {
    public static readonly JsonSerializerSettings Settings = new()
    {
      MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
      DateParseHandling = DateParseHandling.None,
      Converters = { new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal } },
    };
  }

}
