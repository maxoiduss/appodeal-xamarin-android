using Android.Runtime;

namespace Com.Appodeal.Ads.Adapters.Appodealx.Banner
{
	public partial class AppodealX : global::Com.Appodeal.Ads.Unified.UnifiedBanner
	{
		public override unsafe void Load(Android.App.Activity activity, Java.Lang.Object @params, Java.Lang.Object networkParams, Java.Lang.Object @callback)
		{
			LoadBanner(activity,
				@params as Com.Appodeal.Ads.Unified.IUnifiedBannerParams,
				networkParams as Com.Appodeal.Ads.Adapters.Appodealx.AppodealXNetwork.RequestParams,
				@callback as Com.Appodeal.Ads.Unified.UnifiedBannerCallback);
		}
	}
}
