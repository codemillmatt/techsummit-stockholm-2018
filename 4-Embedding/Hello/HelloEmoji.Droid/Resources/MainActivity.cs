using Android.App;
using Android.Widget;
using Android.OS;

using HelloEmoji.Core;

namespace HelloEmoji.Droid
{
    [Activity(Label = "HelloEmoji", MainLauncher = true, Icon = "@mipmap/ic_logo")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            var getEmoji = FindViewById<Button>(Resource.Id.getEmoji);
            var emojiText = FindViewById<TextView>(Resource.Id.emojiText);

            getEmoji.Click += async (sender, e) =>
            {
                var emojiService = new EmojiService();
                var emojiInfo = await emojiService.GetEmoji();

                emojiText.Text = emojiInfo.Emoji;
            };
        }
    }
}

