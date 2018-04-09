using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;

namespace TextSentimentFunction
{
    public static class AnalysisService
    {
        static TextAnalyticsAPI client = new TextAnalyticsAPI
        {
            AzureRegion = AzureRegions.Westeurope,
            SubscriptionKey = ""
        };

        public static async Task<SentimentResult> AnalyzeWords(string words)
        {
            SentimentResult sentimentResult = new SentimentResult();
            try
            {
                var sentimentInput = new MultiLanguageInput(text: words, id: "1");

                // First find out the input language
                var detectLanguageInput = new Input(id: "1", text: words);
                var languageResult = await client.DetectLanguageAsync(new BatchInput(new List<Input> { detectLanguageInput }), numberOfLanguagesToDetect: 1);

                if (languageResult.Errors.Count > 0)
                    return null;

                sentimentResult.DetectedLanguage = languageResult.Documents.FirstOrDefault().DetectedLanguages.FirstOrDefault().Iso6391Name;

                // Setup for the sentiment
                sentimentInput.Language = sentimentResult.DetectedLanguage;
                var mlbi = new MultiLanguageBatchInput(new List<MultiLanguageInput>() { sentimentInput });

                // Find the sentiment!
                var sentimentResultCall = await client.SentimentAsync(mlbi);

                if (sentimentResultCall.Errors.Count > 0)
                    return null;

                sentimentResult.SentimentAnalysis = sentimentResultCall.Documents.FirstOrDefault().Score ?? 0;

                sentimentResult.ScoreResult();

                return sentimentResult;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

            return sentimentResult;
        }

        public static EmojiResult RandomEmojis()
        {
            List<EmojiResult> source = new List<EmojiResult>
            {
                new EmojiResult { Emoji = "😁" },
                new EmojiResult { Emoji = "👍" },
                new EmojiResult { Emoji = "😲" },
                new EmojiResult { Emoji = "🍩" },
                new EmojiResult { Emoji = "😎" },
                new EmojiResult { Emoji = "😘" },
                new EmojiResult { Emoji = "✨" },
                new EmojiResult { Emoji = "🤢" },
                new EmojiResult { Emoji = "😰" },
                new EmojiResult { Emoji = "👽" },
                new EmojiResult { Emoji = "🍍" },
                new EmojiResult { Emoji = "🦉" },
                new EmojiResult { Emoji = "🤓" },
                new EmojiResult { Emoji = "🤣" }
            };

            var randomIndex = new Random().Next(0, source.Count);

            return source[randomIndex];
        }
    }
}
