// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace HelloJokes.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel emojiText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton getEmoji { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (emojiText != null) {
                emojiText.Dispose ();
                emojiText = null;
            }

            if (getEmoji != null) {
                getEmoji.Dispose ();
                getEmoji = null;
            }
        }
    }
}