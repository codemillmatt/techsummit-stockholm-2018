using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EmojiForms.Core
{
    public partial class MainEmojiPage : ContentPage
    {
        public MainEmojiPage()
        {
            InitializeComponent();

            //this is used before MVVM
            getEmoji.Clicked += async (object sender, EventArgs e) =>
            {
                var emojiService = new EmojiService();

                var emojiInfo = await emojiService.GetEmoji();

                emojiText.Text = emojiInfo.Emoji;
            };


            //BindingContext = new MainEmojiViewModel();
        }
    }
}
