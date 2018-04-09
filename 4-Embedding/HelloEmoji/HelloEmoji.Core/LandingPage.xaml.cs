using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HelloEmoji.Core;

namespace HelloJokes.Core
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();

            okButton.Clicked += OkButton_Clicked;
        }

        private async void OkButton_Clicked(object sender, EventArgs e)
        {
            var emojiService = new EmojiService();

            var emojiInfo = await emojiService.GetRandomEmoji();

            emojiText.Text = emojiInfo.Emoji;

            emojiText.FontSize = 48;
        }
    }
}