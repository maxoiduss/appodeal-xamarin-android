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

# Plugin Integration
## Add Referece to the plugin
Add AppodealXamarinPlugin.dll to the references of your project.
Click right mouse button on your project References in Solution Explorer and select `Add Referece...`. Choose `Browse` tab, click `Browse...` button. Find and select AppodealXamarinPlugin.dll and click `Add` button.

## Enabling MultiDex
Click right mouse button on your project in Solution Explorer. Select Android options and check `Enable Multi-Dex`.

## Third party dependencies
Appodeal plugin has some 3rd party dependencies which you can add to your project via NuGet:
`Tools > NuGet Package Manager > Manage NuGet Packages for Solution...`
Go to `Browse` tab, find and install the following dependencies:
- Xamarin.GooglePlayServices.Ads
- Xamarin.Android.Support.v4
- Xamarin.Android.Support.v7.RecyclerView

## AndroidManifest
It's required to modify AndroidManifest.xml of your project (Properties > AndroidManifest.xml in Solution Explorer). You can find all required activities and permissions on the page from which Appodeal Android SDK was downloaded.

# API
## SDK Initialization
Import Appodeal plugin to your script:
```
using Com.Appodeal.Ads;
```
To initialize SDK, you need to add the following code in onCreate method of your main activity:
```
String appKey = "8178c1a000db58116d071f4093c4ba4632b6efed59d96a1c";
Appodeal.Initialize(this, appKey, Appodeal.INTERSTITIAL | Appodeal.BANNER);
```

To initialize only interstitials use Appodeal.Initialize(this, appKey, Appodeal.INTERSTITIAL)

To initialize only rewarded video use Appodeal.Initialize(this, appKey, Appodeal.REWARDED_VIDEO)

To initialize only non-skippable video use Appodeal.Initialize(this, appKey, Appodeal.NON_SKIPPABLE_VIDEO)

To initialize only banners use Appodeal.Initialize(this, appKey, Appodeal.BANNER)

To initialize only 300*250 banners: use Appodeal.Initialize(this, "8178c1a000db58116d071f4093c4ba4632b6efed59d96a1c", Appodeal.MREC);

To initialize only native ads: use Appodeal.Initialize(this, "8178c1a000db58116d071f4093c4ba4632b6efed59d96a1c", Appodeal.NATIVE);

## Interstitial Integration
### Display interstitial
```
Appodeal.Show(this, Appodeal.INTERSTITIAL);
```
### Setting up interstitial callbacks and showing Interstitial ad after it was loaded
Add new class with InterstitialCallbacks
```
public class MainActivity : Activity, InterstitialCallbacks
```
Add this method to your class:
```
public void OnInterstitialLoaded(bool b) { Appodeal.Show(this, Appodeal.INTERSTITIAL); }
public void OnInterstitialFailedToLoad() { }
public void OnInterstitialShown() { }
public void OnInterstitialClosed() { }
public void OnInterstitialClicked() { }
```
Add this call to your code after initialization:
```
Appodeal.SetInterstitialCallbacks(this);
```
### Checking if interstitial is loaded
```
Appodeal.IsLoaded(Appodeal.INTERSTITIAL);
```

### Setting Interstitial callbacks
Extend your class with IInterstitialCallbacks, for example:
```
public class MainActivity : Activity, IInterstitialCallbacks
```
Then after initialization call:
```
Appodeal.setInterstitialCallbacks(this);
```
Now you can use following callback methods in your class:
```
public void OnInterstitialLoaded(bool isPrecache) { }
public void OnInterstitialFailedToLoad() { }
public void OnInterstitialShown() { }
public void OnInterstitialClosed() { }
public void OnInterstitialClicked() { }
```
## Rewarded (Non-skippable) Video Integration
### Display Rewarded (Non-skippable) Video
```
Appodeal.Show(this, Appodeal.REWARDED_VIDEO);
```
### Checking if rewarded video is loaded
```
Appodeal.IsLoaded(Appodeal.REWARDED_VIDEO);
```
### Setting rewarded video callbacks
Extend your class with IRewardedVideoCallbacks, for example:
```
public class MainActivity : Activity, IRewardedVideoCallbacks
```
Then after initialization call:
```
Appodeal.setRewardedVideoCallbacks(this);
```
Now you can use following callback methods in your class:
```
public void OnRewardedVideoLoaded(bool isPrecache) { }
public void OnRewardedVideoFailedToLoad() { }
public void OnRewardedVideoShown() { }
public void OnRewardedVideoClosed(bool finished) { }
public void OnRewardedVideoFinished(double amount, string name) { }
```

## Native Ads
### Caching native
```
Appodeal.Cache(this, Appodeal.NATIVE);
```
### Caching multiple native ads
```
Appodeal.Cache(this, Appodeal.NATIVE, 3);
```
### Check if NativeAd was loaded
```
Appodeal.IsLoaded(Appodeal.NATIVE);
```
### Get loaded native ads
To get loaded native ads use the following method:
```
Appodeal.GetNativeAds(int amount);
```
This method returns List with up to amount loaded native ads
### Native ads callbacks
```
Appodeal.SetNativeCallbacks(new NativeCallbacks() {
  @Override
  public void OnNativeLoaded() {
    Log.d("Appodeal", "onNativeLoaded");
  }
  @Override
  public void OnNativeFailedToLoad() {
    Log.d("Appodeal", "onNativeFailedToLoad");
  }
  @Override
  public void OnNativeShown(NativeAd nativeAd) {
    Log.d("Appodeal", "onNativeShown");
  }
  @Override
  public void OnNativeClicked(NativeAd nativeAd) {
    Log.d("Appodeal", "onNativeClicked");
  }
});
```
### Image caching
To disable caching of native icons or images/video if you are not planning to use both, use the following methods before native ads initialization
```
Appodeal.SetAutoCacheNativeIcons(false);
Appodeal.SetAutoCacheNativeMedia(false);
```

### Native video
To show video native ads you should use NativeMediaView. If where is no video on NativeAd object, main image will be shown automatocally.
#### Native video settings
To control whether you want to show video native ads, use the following methods:

Appodeal.SetNativeAdType(Native.NativeAdType.Auto) - both static image and video native ads will be loaded

Appodeal.SetNativeAdType(Native.NativeAdType.NoVideo) - only static image native ads will be loaded

Appodeal.SetNativeAdType(Native.NativeAdType.Video) - only video native ads will be loaded

### NativeAd object

After native ads are cached using Appodeal.Сache(), list of NativeAd objects are returned in onNativeLoaded callback. NativeAd object has the following methods:

nativeAd.GetTitle() - String. Title of native ad. Mandatory. Should always be displayed. Max length 25 symbols.

nativeAd.GetCallToAction() - String. Call to action text. Mandatory. Should be displayed. Max length 25 symbols.

nativeAd.GetDescription() - String. Text description of native ad. Optional. Max length 100 symbols.

nativeAd.GetRating() - Float. Rating of the app in [0-5] range.

nativeAd.GetAgeRestrictions() - String. App age restriction. Optional, may return null.

nativeAd.GetIcon() - Bitmap: Icon. Either icon or image is mandatory to display.

nativeAd.GetImage() - Bitmap: Image. Either icon or image is mandatory to display.

nativeAd.GetIconUrl() - String. Returns URL of the Icon. Disable automatic caching of icons using Appodeal.setAutoCacheNativeIcons(false) if you are planning on caching icons yourself.

nativeAd.GetMainImageUrl() - String. Returns URL of the Image. Disable automatic caching of images using Appodeal.SetAutoCacheNativeMedia(false) if you are do not want to use images/video. Deprecated, should use NativeMediaView to show main image or video.

nativeAd.GetProviderView(context) - View. If returned view is not null it is mandatory to display it in any corner of native ad. 

nativeAd.ContainsVideo() - Returns true if NativeAd object contains video.

nativeAd.IsPrecache() - Boolean. Returns true if NativeAd is precache.

nativeAd.GetAdProvider() - Boolean. Return ad provider name.

nativeAd.Destroy() - Destroy Native ad and unregister from tracking. You can't use this instance on NativeAd after call Destroy().

### Native ads requirements
All of the fields of native ad marked as mandatory must be displayed.

Every ad should have a sign that clearly indicates that it is an ad. For example "Ad" or "Sponsored".

Provided images can be resized to fit your ad space but should not be significantly distorted or cropped.

### Using templates
Appodeal SDK provides 3 types of templates for native ads:

- NativeAdViewNewsFeed
- NativeAdViewAppWall
- NativeAdViewContentStream

If you want to use one of these templates, you can add the selected template in the layout:
```
<com.appodeal.ads.native_ad.views.NativeAdViewNewsFeed
android:id="@+id/native_ad_view_news_feed"
android:layout_width="match_parent"
android:layout_height="wrap_content"
android:layout_marginBottom="10dp">
</com.appodeal.ads.native_ad.views.NativeAdViewNewsFeed>

<com.appodeal.ads.native_ad.views.NativeAdViewAppWall
android:id="@+id/native_ad_view_app_wall"
android:layout_width="wrap_content"
android:layout_height="wrap_content"
android:layout_marginBottom="10dp">
</com.appodeal.ads.native_ad.views.NativeAdViewAppWall>

<com.appodeal.ads.native_ad.views.NativeAdViewContentStream
android:id="@+id/native_ad_view_content_stream"
android:layout_width="match_parent"
android:layout_height="wrap_content"
android:layout_marginBottom="10dp">
</com.appodeal.ads.native_ad.views.NativeAdViewContentStream>
```
And when you need to show an ad:
```
NativeAdViewNewsFeed nav_nf = (NativeAdViewNewsFeed) mActivity.FindViewById(R.id.native_ad_view_news_feed);
nav_nf.setNativeAd(mNativeAd);

NativeAdViewAppWall nav_aw = (NativeAdViewAppWall) mActivity.FindViewById(R.id.native_ad_view_app_wall);
nav_aw.setNativeAd(mNativeAd);

NativeAdViewContentStream nav_cs = (NativeAdViewContentStream) mActivity.FindViewById(R.id.native_ad_view_content_stream);
nav_cs.setNativeAd(mNativeAd);
```
You can also create a view programmatically and add it to the screen:
```
RelativeLayout holder = (RelativeLayout) mActivity.FindViewById(R.id.native_template_holder);
NativeAdViewAppWall nativeAdView = new NativeAdViewAppWall(mActivity, mNativeAd);
holder.AddView(nativeAdView);
```
Template elements:
```
ImageView GetNativeMediaView()
ImageView GetIconView()
TextView GetTitleView()
TextView GetDescriptionView()
TextView GetCallToActionView()
RatingBar GetRatingBar()
```
By default, native ads are labeled «Ad». You can replace it with «Sponsored»:
```
nav.ShowSponsored(true)
```
To change the color of the call-to-action button in the templates use:
```
nav.SetCallToActionColor(int color)
nav.SetCallToActionColor(String color)
```

## Banner Integration
### Display banner at the top/bottom of the screen
```
Appodeal.Show(this, Appodeal.BANNER_BOTTOM);
```
### Display banner at the top of the screen
```
Appodeal.Show(this, Appodeal.BANNER_TOP);
```
### Checking if banner is loaded
```
Appodeal.IsLoaded(Appodeal.BANNER);
```
### Hiding banner
```
Appodeal.Hide(this, Appodeal.BANNER);
```
### Destroying cached banner
```
Appodeal.Destroy(Appodeal.BANNER);
```
### Setting banner callbacks
Extend your class with IBannerCallbacks, for example:
```
public class MainActivity : Activity, IBannerCallbacks
```
Then after initialization call:
```
Appodeal.setBannerCallbacks(this);
```
Now you can use following callback methods in your class:
```
public void OnBannerLoaded(int height, bool isPrecache) { }
public void OnBannerFailedToLoad() { }
public void OnBannerShown() { }
public void OnBannerClicked() { }
```
## Display Ad
```
Appodeal.Show(this, adTypes);
```
Show() returns a boolean value indicating whether show call was passed to appropriate SDK

To display interstitial use Appodeal.Show(this, Appodeal.INTERSTITIAL)

To display rewarded video use Appodeal.Show(this, Appodeal.REWARDED_VIDEO)

To display non-skippable video use Appodeal.Show(this, Appodeal.NON_SKIPPABLE_VIDEO)

To display interstitial or video use Appodeal.Show(this, Appodeal.INTERSTITIAL | Appodeal.SKIPPABLE_VIDEO)

To display banner at the bottom of the screen use Appodeal.Show(this, Appodeal.BANNER_BOTTOM)

To display banner at the top of the screen use Appodeal.Show(this, Appodeal.BANNER_TOP)

To display banner in the view specified in layout file use Appodeal.Show(this, Appodeal.BANNER_VIEW)

## Hiding Banner
To hide banner you need to call the following code in activity:
```
Appodeal.Hide(this, Appodeal.BANNER);
```

## Advanced Features
### Enabling test mode
```
Appodeal.SetTesting(true);
```
In test mode test, ads will be shown and debug data will be written to logcat

### Enabling logging
```
Appodeal.SetLogging(true);
```
### Checking if ad is loaded
```
Appodeal.IsLoaded(adTypes);
```

To check if interstitial is loaded use Appodeal.IsLoaded(Appodeal.INTERSTITIAL)

To check if rewarded video is loaded use Appodeal.IsLoaded(Appodeal.REWARDED_VIDEO)

To check if non-skippable video is loaded use Appodeal.IsLoaded(Appodeal.NON_SKIPPABLE_VIDEO)

To check if banner is loaded use Appodeal.IsLoaded(Appodeal.BANNER)

### Checking if loaded ad is precache

```
Appodeal.IsPrecache(adTypes);
```
### Manual ad caching
```
Appodeal.Cache(this, adTypes);
```
You should disable automatic caching before SDK initialization using SetAutoCache(adTypes, false).

To cache interstitial use Appodeal.Cache(this, Appodeal.INTERSTITIAL)

To cache rewarded video use Appodeal.Cache(this, Appodeal.REWARDED_VIDEO)

To cache non-skippable video use Appodeal.Cache(this, Appodeal.NON_SKIPPABLE_VIDEO)

To cache interstitial and video use Appodeal.Cache(this, Appodeal.INTERSTITIAL | Appodeal.SKIPPABLE_VIDEO)

To cache banner use Appodeal.Cache(this, Appodeal.BANNER)

### Enabling or disabling automatic caching
```
Appodeal.SetAutoCache(adTypes, false);
```
Should be used before SDK initialization

To disable automatic caching for interstitials use Appodeal.SetAutoCache(Appodeal.INTERSTITIAL, false)

To disable automatic caching for rewarded videos use Appodeal.SetAutoCache(Appodeal.REWARDED_VIDEO, false)

To disable automatic caching for non-skippable videos use Appodeal.SetAutoCache(Appodeal.NON_SKIPPABLE_VIDEO, false)

To disable automatic caching for banners use Appodeal.SetAutoCache(Appodeal.BANNER, false)

### Triggering onLoaded callback on precache
```
Appodeal.SetTriggerOnLoadedOnPrecache(adTypes, true);
```
Currently supported only for interstitials, banners and MREC
### Display banner in the view specified in layout file
Add com.appodeal.ads.BannerView to your layout file:
```
<com.appodeal.ads.BannerView 
  android:id="@+id/appodealBannerView" 
  android:layout_width="match_parent" 
  android:layout_height="wrap_content" 
  android:visibility="gone" />
```
Set view id before SDK initialization
```
Appodeal.SetBannerViewId(R.id.appodealBannerView);
```
Now you can show banner in the view specified:
```
Appodeal.Show(this, Appodeal.BANNER_VIEW);
```
### Using programmatically created banner view
Create banner view
```
Appodeal.GetBannerView(this);
```
Add view to your layout and then show banner in it:
```
Appodeal.Show(this, Appodeal.BANNER_VIEW);
```

### Handling orientation change
If your activity is recreated on screen rotation banner will disappear. To prevent that you need to call the following method in onResume of your activity:
```
public void OnResume() {
  base.OnResume();
  Appodeal.OnResume(this, Appodeal.BANNER);
}
```
### Disabling networks
```
Appodeal.DisableNetwork(this, (String)network);
```
```
Appodeal.DisableNetwork(this, (String)network, adTypes);
```
Available parameters: "amazon_ads", "applovin", "chartboost", "mopub", "unity_ads", "mailru", "facebook", "adcolony", "vungle", "yandex", "startapp", "avocarrot", "flurry", "pubnative", "cheetah", "inner-active", "revmob".

Should be used before SDK initialization
```
Appodeal.DisableNetwork(this, "startapp", Appodeal.BANNER | Appodeal.INTERSTITIAL)
```
### Disabling location permission check
To disable toast messages ACCESS_COARSE_LOCATION permission is missing, use the following method:
```
Appodeal.DisableLocationPermissionCheck();
```
Should be used before SDK initialization.
### Tracking in-app purchase
```
Appodeal.TrackInAppPurchase((Context) this, amount, currencyCode)
```
Tracks in-app purchase information and sends info to our servers for analytics. Example:
```
Appodeal.TrackInAppPurchase(this, 5, "USD")
```

## Setting User Data
### Initialization
Our SDK provides the transfer of user data for better ad targeting and higher eCPM. All parameters are optional and can be defined partially.

To obtain reference to the user settings, please call this before Appodeal initialization:
```
UserSettings userSettings = Appodeal.GetUserSettings((Context) this);
```

### Set the age of the user
Positive integer value.
```
userSettings.SetAge(25);
```
### Specify gender of the user
```
userSettings.SetGender(UserSettings.Gender.FEMALE);
```
### Set UserID for S2S Callbacks
```
userSettings.SetUserId("User123");
```