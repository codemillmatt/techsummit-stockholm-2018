using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmojiForms.Core
{
    public class EmojiService
    {
        public async Task<EmojiInfo> GetEmoji()
        {
            var client = new HttpClient();

            var responseJson = await client.GetStringAsync("https://textsentiment.azurewebsites.net/api/RandomEmoji");

            return EmojiInfo.FromJson(responseJson);
        }

        public async Task<EmojiSentiment> GetSentiment(string sentence)
        {
            var client = new HttpClient();

            var url = $"https://textsentiment.azurewebsites.net/api/TextSentiment?sentence={sentence}";

            var responseJson = await client.GetStringAsync(url);

            return EmojiSentiment.FromJson(responseJson);
        }
    }
}
