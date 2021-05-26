using Android.Runtime;

namespace Com.Appodeal.Ads.Adapters.Appodealx.Interstitial
{
	public partial class AppodealX : global::Com.Appodeal.Ads.Unified.UnifiedInterstitial
	{
		public override unsafe void Load(global::Android.App.Activity activity, Java.Lang.Object @params, Java.Lang.Object networkParams, Java.Lang.Object @callback)
		{
			LoadInterstitial(activity,
				@params as Com.Appodeal.Ads.Unified.IUnifiedInterstitialParams,
				networkParams as Com.Appodeal.Ads.Adapters.Appodealx.AppodealXNetwork.RequestParams,
				@callback as Com.Appodeal.Ads.Unified.UnifiedInterstitialCallback);
		}

		public override unsafe void Show(global::Android.App.Activity activity, Java.Lang.Object @callback)
		{
			ShowInterstitial(activity,
				@callback as Com.Appodeal.Ads.Unified.UnifiedInterstitialCallback);
		}
	}
}
