# Demo 2 - Xamarin.Forms

In this demo you saw how Xamarin.Forms reduces the amount of code you have to write. Xamarin.Forms provides an API that contains numerous UI elements that exist in all platforms (iOS, Android, UWP, etc.). By providing access to the common properties and methods to these common elements, Xamarin.Forms allows you to write a 100% cross-platform app - all from the shared code layer!

## The Steps - iOS and Android

You do not need to do anything specific within the Android or iOS project - other than to create a new Xamarin.Forms project. All of the plumbing will be created for you.

## The Steps - Shared Logic

In the shared logic project - the `Application` class is where everything originates from. There is a `MainPage` property - set this property to the `ContentPage` (usually a XAML file) that you want to appear first in your application.

Within that `ContentPage` you can add UI elements through XAML. You can interact with those UI elements either in the code behind - by giving those elements names, or in _view models_ by providing a binding context to the page and then binding properties for UI elements to the properties in the view models. When one changes the other changes automatically for you!! You then handle UI events via `Command`s in the view models.

You can learn more about [Xamarin.Forms here](https://msou.co/bgv) and specifically about the [MVVM architecture here](https://msou.co/bgw).
