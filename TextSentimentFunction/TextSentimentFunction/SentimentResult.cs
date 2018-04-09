using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace TextSentimentFunction
{
    public class SentimentResult
    {
        [JsonProperty("detectedLanguage")]
        public string DetectedLanguage { get; set; }

        [JsonProperty("feeling")]
        public string Feeling { get; set; }

        [JsonProperty("sentimentAnalysis")]
        public double SentimentAnalysis { get; set; }

        [JsonProperty("languageCountry")]
        public string LanguageCountry { get; set; }

        public void ScoreResult()
        {
            if (SentimentAnalysis < .4)
            {
                Feeling = "😢";
            }
            else if (SentimentAnalysis < .8)
            {
                Feeling = "😐";
            }
            else
            {
                Feeling = "😁";
            }

            if (DetectedLanguage == "en")
                LanguageCountry = "🇬🇧";
            else if (DetectedLanguage == "de")
                LanguageCountry = "🇩🇪";
            else if (DetectedLanguage == "sv")
                LanguageCountry = "🇸🇪";
            else if (DetectedLanguage == "es")
                LanguageCountry = "🇪🇸";
            else
                LanguageCountry = "🤷‍";
                 
        }
    }
}
