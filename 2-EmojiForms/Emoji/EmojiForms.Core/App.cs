using System;
using Xamarin.Forms;

namespace EmojiForms.Core
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new MainEmojiPage());
        }

    }
}
