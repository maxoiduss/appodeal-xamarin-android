using Android.Runtime;

namespace Com.Appodeal.Ads.Adapters.Appodealx.Rewarded_video
{
	public partial class AppodealX : global::Com.Appodeal.Ads.Unified.UnifiedRewarded
	{
		public override unsafe void Load(Android.App.Activity activity, Java.Lang.Object @params, Java.Lang.Object networkParams, Java.Lang.Object @callback)
		{
			LoadRewarded(activity,
				@params as Com.Appodeal.Ads.Unified.IUnifiedRewardedParams,
				networkParams as Com.Appodeal.Ads.Adapters.Appodealx.AppodealXNetwork.RequestParams,
				@callback as Com.Appodeal.Ads.Unified.UnifiedRewardedCallback);
		}

		public override unsafe void Show(global::Android.App.Activity activity, Java.Lang.Object @callback)
		{
			ShowRewarded(activity,
				@callback as Com.Appodeal.Ads.Unified.UnifiedRewardedCallback);
		}
	}
}
