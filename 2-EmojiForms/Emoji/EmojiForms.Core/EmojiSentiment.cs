using Newtonsoft.Json;

namespace EmojiForms.Core
{

    public partial class EmojiSentiment
    {
        [JsonProperty("detectedLanguage")]
        public string DetectedLanguage { get; set; }

        [JsonProperty("feeling")]
        public string Feeling { get; set; }

        [JsonProperty("sentimentAnalysis")]
        public double SentimentAnalysis { get; set; }

        [JsonProperty("languageCountry")]
        public string LanguageCountry { get; set; }
    }

    public partial class EmojiSentiment
    {
        public static EmojiSentiment FromJson(string json) => JsonConvert.DeserializeObject<EmojiSentiment>(json);
    }

}