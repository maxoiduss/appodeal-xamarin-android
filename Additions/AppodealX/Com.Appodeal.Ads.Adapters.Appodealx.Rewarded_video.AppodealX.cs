using Android.Runtime;

namespace Com.Appodeal.Ads.Adapters.Appodealx.Rewarded_video
{
	public partial class AppodealX : global::Com.Appodeal.Ads.Unified.UnifiedRewarded
	{
		[Register("load", "(Landroid/app/Activity;Lcom/appodeal/ads/unified/UnifiedRewardedParams;Lcom/appodeal/ads/adapters/appodealx/AppodealXNetwork$RequestParams;Lcom/appodeal/ads/unified/UnifiedRewardedCallback;)V", "GetLoad_Landroid_app_Activity_Lcom_appodeal_ads_unified_UnifiedRewardedParams_Lcom_appodeal_ads_adapters_appodealx_AppodealXNetwork_RequestParams_Lcom_appodeal_ads_unified_UnifiedRewardedCallback_Handler")]
		public override unsafe void Load(Android.App.Activity activity, Java.Lang.Object @params, Java.Lang.Object networkParams, Java.Lang.Object @callback)
		{
			LoadRewarded(activity,
				@params as Com.Appodeal.Ads.Unified.IUnifiedRewardedParams,
				networkParams as Com.Appodeal.Ads.Adapters.Appodealx.AppodealXNetwork.RequestParams,
				@callback as Com.Appodeal.Ads.Unified.UnifiedRewardedCallback);
		}

		[Register("show", "(Landroid/app/Activity;Lcom/appodeal/ads/unified/UnifiedRewardedCallback;)V", "GetShow_Landroid_app_Activity_Lcom_appodeal_ads_unified_UnifiedRewardedCallback_Handler")]
		public override unsafe void Show(global::Android.App.Activity activity, Java.Lang.Object @callback)
		{
			ShowRewarded(activity,
				@callback as Com.Appodeal.Ads.Unified.UnifiedRewardedCallback);
		}
	}
}
