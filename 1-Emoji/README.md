# Demo 1 - Building a Traditional Xamarin App

The first demo goes through building a traditional Xamarin Android application, refactoring the core business logic out of the UI, then adding an iOS application to use that new core business logic.

## The Steps

### Android

1. Open Visual Studio!
1. Create a new blank Android application
1. Experiment with the UI using the Android designer
1. Add a label and button - make sure to give them a name in the properties
1. Get a reference for the button and label in the `MainActivity`
1. Create an event handler for the button's click
1. Add in a NuGet Package for `System.Net.Http`
1. Invoke the web service with C#
1. Before building the app - make sure you change the project to use the latest & greatest TLS settings
1. Update the label's `Text` property with the return from the web service.

### Shared Logic

1. Add a new .NET Standard library
1. Add the appropriate NuGet packages
1. Add a class to model the JSON which is returned from the web service
1. Add a class to facilitate invoking the web service
1. Refactor the code from the Android project's button click event into the new class which will now invoke the web service
1. Have the Android button click instantiate that new class and call the appropriate function to get the return value from the web service
1. Make sure the label is displaying the correct value

### iOS

1. Add a new iOS project
1. Play around with the designer - eventually adding a button and a label
1. Give each an ID from the properties dialog in the designer
1. Within the `ViewController` code, create a handler for the button's `TouchUpInside` event
1. Have some code in that event call out the new shared logic class that will invoke the web service
1. Update the label's `Text` property with the return value