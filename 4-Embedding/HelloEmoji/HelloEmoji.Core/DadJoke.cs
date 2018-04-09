using System;
using System.Collections.Generic;
using System.Net;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HelloJokes.Core
{
    public partial class DadJoke
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("joke")]
        public string Joke { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }
    }

    public partial class DadJoke
    {
        public static DadJoke FromJson(string json) => JsonConvert.DeserializeObject<DadJoke>(json, HelloJokes.Core.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this DadJoke self) => JsonConvert.SerializeObject(self, HelloJokes.Core.Converter.Settings);
    }

    internal class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter()
                {
                    DateTimeStyles = DateTimeStyles.AssumeUniversal,
                },
            },
        };
    }
}

