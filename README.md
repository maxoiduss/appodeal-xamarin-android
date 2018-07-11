# Appodeal Android SDK Xamarin Bindings

## Download



## How to update manually

Please follow this steps to update AppodealBindings.dll to the latest Appodeal Android SDK:

1. First of all Clone this repository with: `git clone https://github.com/appodeal/appodeal-xamarin-android.git`.
2. Go to the `appodeal-xamarin-android/Jars` folder and remove all jar and aar files.
3. Download latest Appodeal Android SDK: [stable](https://www.appodeal.com/sdk/documentation?framework=1&full=1&platform=1) or [beta](https://www.appodeal.com/sdk/android_beta). It's recommended to download "using MultiDex" version.
4. Unzip downloaded Appodeal Android SDK. Put all jar files from the root folder, aar files from `aar` folder and picaso.jar from optional folder to `appodeal-xamarin-android/Jars`.
5. Open `AppodealXamarinPlugin.sln` with Microsoft Visual Studio.
6. Open `AppodealXamarinPlugin > Jar` folder in Solution Explorer. You should remove all items which are not exist.
7. Add all new items. To do that just perform right mouse button click on `Jars` folder and select `Add > Existing Item`. In new dialog go to `Jars` folder, select all files and click `Add`.
8. Change build properties of all items according to the following rule: build action for all jar files (except appodeal.jar) must be `EmbeddedReferenceJar`, for all aar files build action is `LibraryProjectZip`, and for appodeal.jar build action is `EmbeddedJar`.
9. Select Release build in Visual Studio toolbar.
10. Press right mouse button on AppodealXamarinPlugin in Solution Explorer and choose properties. In application tab find `Compile using Android version` parameter and select Android 8.0 or newer. If Android 8.0 is not available, see [Update](#Update) section.
10. Click Build > Rebuild Solution.
11. In case if build was successfull, you will see a similar output in your console:
```
Build succeeded.
Time Elapsed 00:00:06.20
========== Rebuild All: 1 succeeded, 0 failed, 0 skipped ==========
```

New version of plugin is in `appodeal-xamarin-android/bin/Release` folder.

# Update
## Android SDK
To update Android SDK go to `Tools > Android > Android SDK Manager`.
Make sure that you have last Android SDK Tools, Android Platform Tools, Android SDL Build-Tools, Android Support Library, Android Support Repository, Google Play Services and Google Play Repository. Also Android 8.0.0 or newer should be installed.

## Xamarin Tools
To update Xamarin tools go to `Tools > Options... > Xamarin > Other`. Find `Xamarin for Visual Studio Updates` section and click `Check Now...`. Follow instructions.