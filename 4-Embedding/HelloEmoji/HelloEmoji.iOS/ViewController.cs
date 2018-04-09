using HelloJokes.Core;
using System;

using UIKit;
using Xamarin.Forms.Platform.iOS;
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
                 var emojiInfo = await emojiService.GetRandomEmoji();
                 emojiText.Text = emojiInfo.Emoji;
             };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

    }
}