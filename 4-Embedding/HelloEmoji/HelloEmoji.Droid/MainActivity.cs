using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.PM;
using Android.Views;

using HelloJokes.Core;

using Xamarin.Forms.Platform.Android;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;

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

            // Create fragment
            var landingFragment = new LandingPage().CreateFragment(this);

            // Replace fragment
            ft.Replace(Resource.Id.fragment_frame_layout, landingFragment, "main");

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
                var jokeText = view.FindViewById<TextView>(Resource.Id.emojiText);

                var jokeService = new JokeService();
                jokeText.Text = (await jokeService.GetJoke()).Joke;
            };

            return view;
        }

    }

}

