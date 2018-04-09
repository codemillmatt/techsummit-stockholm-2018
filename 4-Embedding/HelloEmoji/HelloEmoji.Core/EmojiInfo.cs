namespace HelloEmoji.Core
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class EmojiInfo
    {
        [JsonProperty("emoji")]
        public string Emoji { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("timestamp")]
        public System.DateTimeOffset Timestamp { get; set; }
    }

    public partial class EmojiInfo
    {
        public static EmojiInfo FromJson(string json) => JsonConvert.DeserializeObject<EmojiInfo>(json);
    }
}
