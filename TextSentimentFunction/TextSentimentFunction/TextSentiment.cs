
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace TextSentimentFunction
{
    public static class TextSentiment
    {
        [FunctionName("TextSentiment")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)]HttpRequest req, TraceWriter log)
        {
            log.Info("Sentiment started");

            string sentence = req.Query["sentence"];

            if (string.IsNullOrEmpty(sentence))
            {
                log.Error("Sentence is empty");

                return (ActionResult)new BadRequestResult();
            }

            log.Info($"About to analyze: {sentence}");

            var score = await AnalysisService.AnalyzeWords(sentence);

            return (ActionResult)new OkObjectResult(score);
        }

        [FunctionName("RandomEmoji")]
        public static IActionResult GetRandomEmoji([HttpTrigger(AuthorizationLevel.Anonymous,"get")] HttpRequest req, TraceWriter log)
        {
            log.Info("Started to get random emojis");

            var randomEmoji = AnalysisService.RandomEmojis();

            log.Info($"Random: {randomEmoji.Emoji}");

            return (ActionResult)new OkObjectResult(randomEmoji);
        }
    }
}
