using System;

using UIKit;
using HelloEmoji.Core;

namespace HelloJokes.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            getEmoji.TouchUpInside += async (sender, e) =>
            {
                var emojiService = new EmojiService();

                var emojiInfo = await emojiService.GetEmoji();

                emojiText.Text = emojiInfo.Emoji;
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }

    }
}