# Demo 4 - Xamarin.Forms Embedding

Xamarin.Forms embedding is a way to bring the goodness of Xamarin.Forms into your traditional Xamarin application.

## Overall Setup

1. Add the Xamarin.Forms NuGet to each platform project and the shared project.

## Shared / Core Project

1. Add any `ContentPages` you need.

## Android

1. Call `Forms.Init()`
1. Make sure you're using `Fragments`
1. Add a `FrameLayout` to the main.axml 
1. Assuming your `FrameLayout` is named `fragment_frame_layout` and the new `Content` page's class is named `LandingPage`, run the following:

```language-csharp
var landingFragment = new LandingPage().CreateFragment(this);

FragmentTransaction ft = FragmentManager.BeginTransaction();
ft.Replace(Resource.Id.fragment_frame_layout, landingFragment, "main");

ft.Commit();
```

## iOS

1. Call `Forms.Init()`
1. Assuming the `ContentPage` class is named `LandingPage` and you are using a `UINavigationController` to display view conrollers (stack-based navigation), execute the following code:

```language-csharp
var landingVC = new LandingPage().CreateViewController();

NavigationController.PushViewController(landingVC, true);
```