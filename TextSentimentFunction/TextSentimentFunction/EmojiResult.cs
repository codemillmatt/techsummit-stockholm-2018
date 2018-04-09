using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TextSentimentFunction
{
    public class EmojiResult
    {
        [JsonProperty("emoji")]
        public string Emoji { get; set; }

        [JsonProperty("id")]
        public string Id => Guid.NewGuid().ToString();

        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp => DateTimeOffset.UtcNow;
    }
}
