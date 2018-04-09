using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.PM;
using Android.Views;

using HelloJokes.Core;

using Xamarin.Forms.Platform.Android;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using HelloEmoji.Core;

namespace HelloEmoji.Droid
{
    [Activity(Label = "HelloEmoji", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Xamarin.Forms.Forms.Init(this, savedInstanceState);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Emoji";

            FragmentTransaction ft = FragmentManager.BeginTransaction();

            ft.Replace(Resource.Id.fragment_frame_layout, new MainFragment(), "main");

            ft.Commit();

        }
    }

    public class MainFragment : Fragment
    {
        public override Android.Views.View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.EmojiFragment, container, false);

            var getJoke = view.FindViewById<Button>(Resource.Id.getEmoji);

            getJoke.Click += async (sender, e) =>
            {
                var emojiText = view.FindViewById<TextView>(Resource.Id.emojiText);

                var emojiService = new EmojiService();
                var emojiInfo = await emojiService.GetRandomEmoji();
                emojiText.Text = emojiInfo.Emoji;
            };

            return view;
        }

    }

}

