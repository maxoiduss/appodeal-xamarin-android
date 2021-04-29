using Android.Runtime;

namespace Com.Appodeal.Ads.Adapters.Appodealx.Banner
{
	public partial class AppodealX : global::Com.Appodeal.Ads.Unified.UnifiedBanner
	{
		[Register("load", "(Landroid/app/Activity;Lcom/appodeal/ads/unified/UnifiedBannerParams;Lcom/appodeal/ads/adapters/appodealx/AppodealXNetwork$RequestParams;Lcom/appodeal/ads/unified/UnifiedBannerCallback;)V", "GetLoad_Landroid_app_Activity_Lcom_appodeal_ads_unified_UnifiedBannerParams_Lcom_appodeal_ads_adapters_appodealx_AppodealXNetwork_RequestParams_Lcom_appodeal_ads_unified_UnifiedBannerCallback_Handler")]
		public override unsafe void Load(Android.App.Activity activity, Java.Lang.Object @params, Java.Lang.Object networkParams, Java.Lang.Object @callback)
		{
			LoadBanner(activity,
				@params as Com.Appodeal.Ads.Unified.IUnifiedBannerParams,
				networkParams as Com.Appodeal.Ads.Adapters.Appodealx.AppodealXNetwork.RequestParams,
				@callback as Com.Appodeal.Ads.Unified.UnifiedBannerCallback);
		}
	}
}
