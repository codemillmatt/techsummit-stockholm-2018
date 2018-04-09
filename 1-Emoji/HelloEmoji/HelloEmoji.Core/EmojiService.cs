using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace HelloEmoji.Core
{
    public class EmojiService
    {
        public async Task<EmojiInfo> GetEmoji()
        {
            var client = new HttpClient();

            var responseJson = await client.GetStringAsync("https://textsentiment.azurewebsites.net/api/RandomEmoji");

            return EmojiInfo.FromJson(responseJson);
        }
    }
}
