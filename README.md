# Tech Summit 2018 Demos

Welcome to the repository of all demos featured in the __Mobile Development with Xamarin__ session in the 2018 Microsoft Tech Summit!

The intention of the repository is to help you through buiding mobile applications using Xamarin and give you tips and tricks when using some of the great tools that Xamarin provides - such as the Live Player!

## The Slides

You can view the slides from the talk [here](https://www.slideshare.net/MatthewSoucoup/mobile-development-with-xamarin).

## Xamarin Overview

Xamarin is a framework that enables you to build 100% native, cross-platform applications using the power of C# and .NET. By building native apps, you can access all of the underlying APIs that the platforms expose _(without having to wait on another vendor to expose them for you)_,  get the look and feel of an app as the user would expect it for the operating system, and have native performance! Fast, fast fast!!

Not only that, but Xamarin enables you to share the core business logic of your app - things such as REST calls - with each platform! This greatly reduces the amount of code you need to write.

### Xamarin.Forms

Xamarin.Forms is a framework that abstracts common elements that are present in each platform, things like buttons or labels, into a single API that you can develop against. Now not only are you sharing core business logic across all of the platforms - but now you are sharing the user interface construction as well!

Xamarin.Forms includes more than common UI commponents - it features a full MVVM framework, a dependency framework, a messaging service, and an animation API amongst other things.

### Xamaring Live Player

The Live Player is a tool that reduces the amount of time you need to spend in the compile - debug cycle. It allows you to make changes to Xamarin.Forms XAML files and see those changes appear instantly within an app running on device or in a simulator/emulator ... without have to recompile the project!

Live player extends beyond UI changes too! You can also make changes to logic and have those changes instantly take effect.

### Xamarin.Forms Embedding

Xamarin.Forms is a powerful framework and is suited for many applications. However, if you find yourself needing to build a traditional Xamarin app, you can still use Xamarin.Forms pages within it by using Xamarin.Forms embedding.

Forms embedding works with `ContentPages`, and even things such as the messaging center work as well.

## The Demos

### Demo 1

The first demo goes through building a traditional Xamarin Android application, refactoring the core business logic out of the UI, then adding an iOS application to use that new core business logic.

### Demo 2

The second demo shows off the power of Xamarin.Forms by demonstrating a full Forms app that makes use of several features of Azure including [CosmosDB](https://msou.co/bf0), [Azure Functions](https://msou.co/bfz), and [Azure Active Directory](https://msou.co/bfy).

### Demo 3

The third demo showcases Live Player and its ability to reflect changes made to an app on the fly without having to go through a compile-deploy debug cycle. The power of the Xamarin.Forms animation framework is also showcases.

### Demo 4

Finally, Xamarin.Forms embedding is demonstrated. The first demo is extended to use a Xamarin.Forms `ContentPage` from the core logic project. And multiple means of displaying that `ContentPage` are featured.
