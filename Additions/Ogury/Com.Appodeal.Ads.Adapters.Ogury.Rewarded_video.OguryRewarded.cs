using Android.App;
using Android.Runtime;
using Java.Lang;

namespace Com.Appodeal.Ads.Adapters.Ogury.Rewarded_video
{
	public partial class OguryRewarded : global::Com.Appodeal.Ads.Unified.UnifiedRewarded
	{
		[Register("load", "(Landroid/app/Activity;Lcom/appodeal/ads/unified/UnifiedRewardedParams;Lcom/appodeal/ads/adapters/ogury/OguryNetwork$RequestParams;Lcom/appodeal/ads/unified/UnifiedRewardedCallback;)V", "GetLoad_Landroid_app_Activity_Lcom_appodeal_ads_unified_UnifiedRewardedParams_Lcom_appodeal_ads_adapters_ogury_OguryNetwork_RequestParams_Lcom_appodeal_ads_unified_UnifiedRewardedCallback_Handler")]
		public override unsafe void Load(Activity activity, Object @params, Object networkParams, Object @callback)
		{
			LoadRewarded(activity,
				@params as Com.Appodeal.Ads.Unified.IUnifiedRewardedParams,
				networkParams as Com.Appodeal.Ads.Adapters.Ogury.OguryNetwork.RequestParams,
				@callback as Com.Appodeal.Ads.Unified.UnifiedRewardedCallback);
		}

		[Register("show", "(Landroid/app/Activity;Lcom/appodeal/ads/unified/UnifiedRewardedCallback;)V", "GetShow_Landroid_app_Activity_Lcom_appodeal_ads_unified_UnifiedRewardedCallback_Handler")]
		public override unsafe void Show(Activity activity, Object @callback)
		{
			ShowRewarded(activity,
				@callback as Com.Appodeal.Ads.Unified.UnifiedRewardedCallback);
		}
	}
}
