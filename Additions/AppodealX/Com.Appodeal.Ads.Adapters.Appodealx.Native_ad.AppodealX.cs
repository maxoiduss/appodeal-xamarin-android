using Android.Runtime;

namespace Com.Appodeal.Ads.Adapters.Appodealx.Native_ad
{
	public partial class AppodealX : global::Com.Appodeal.Ads.Unified.UnifiedNative
	{
		public override unsafe void Load(Android.App.Activity activity, Java.Lang.Object @params, Java.Lang.Object networkParams, Java.Lang.Object @callback)
		{
			LoadNative(activity,
				@params as Com.Appodeal.Ads.Unified.IUnifiedNativeParams,
				networkParams as Com.Appodeal.Ads.Adapters.Appodealx.AppodealXNetwork.RequestParams,
				@callback as Com.Appodeal.Ads.Unified.UnifiedNativeCallback);
		}
	}
}
