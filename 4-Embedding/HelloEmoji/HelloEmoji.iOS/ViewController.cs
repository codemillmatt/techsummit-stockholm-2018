using HelloJokes.Core;
using System;

using UIKit;
using Xamarin.Forms.Platform.iOS;

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

            getEmoji.TouchUpInside += (sender, e) =>
            {
                //9a. View Controller
                var landingController = new LandingPage().CreateViewController();

                //9b. Navigate to it
                NavigationController.PushViewController(landingController, true);
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

    }
}