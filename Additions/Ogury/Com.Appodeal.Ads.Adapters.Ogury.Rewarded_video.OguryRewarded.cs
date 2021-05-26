using Android.App;
using Android.Runtime;
using Java.Lang;

namespace Com.Appodeal.Ads.Adapters.Ogury.Rewarded_video
{
	public partial class OguryRewarded : global::Com.Appodeal.Ads.Unified.UnifiedRewarded
	{
		public override unsafe void Load(Activity activity, Object @params, Object networkParams, Object @callback)
		{
			LoadRewarded(activity,
				@params as Com.Appodeal.Ads.Unified.IUnifiedRewardedParams,
				networkParams as Com.Appodeal.Ads.Adapters.Ogury.OguryNetwork.RequestParams,
				@callback as Com.Appodeal.Ads.Unified.UnifiedRewardedCallback);
		}

		public override unsafe void Show(Activity activity, Object @callback)
		{
			ShowRewarded(activity,
				@callback as Com.Appodeal.Ads.Unified.UnifiedRewardedCallback);
		}
	}
}
