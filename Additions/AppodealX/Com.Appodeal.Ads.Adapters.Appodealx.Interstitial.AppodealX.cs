using Android.Runtime;

namespace Com.Appodeal.Ads.Adapters.Appodealx.Interstitial
{
	public partial class AppodealX : global::Com.Appodeal.Ads.Unified.UnifiedInterstitial
	{
		[Register("load", "(Landroid/app/Activity;Lcom/appodeal/ads/unified/UnifiedInterstitialParams;Lcom/appodeal/ads/adapters/appodealx/AppodealXNetwork$RequestParams;Lcom/appodeal/ads/unified/UnifiedInterstitialCallback;)V", "GetLoad_Landroid_app_Activity_Lcom_appodeal_ads_unified_UnifiedInterstitialParams_Lcom_appodeal_ads_adapters_appodealx_AppodealXNetwork_RequestParams_Lcom_appodeal_ads_unified_UnifiedInterstitialCallback_Handler")]
		public override unsafe void Load(global::Android.App.Activity activity, Java.Lang.Object @params, Java.Lang.Object networkParams, Java.Lang.Object @callback)
		{
			LoadInterstitial(activity,
				@params as Com.Appodeal.Ads.Unified.IUnifiedInterstitialParams,
				networkParams as Com.Appodeal.Ads.Adapters.Appodealx.AppodealXNetwork.RequestParams,
				@callback as Com.Appodeal.Ads.Unified.UnifiedInterstitialCallback);
		}

		[Register("show", "(Landroid/app/Activity;Lcom/appodeal/ads/unified/UnifiedInterstitialCallback;)V", "GetShow_Landroid_app_Activity_Lcom_appodeal_ads_unified_UnifiedInterstitialCallback_Handler")]
		public override unsafe void Show(global::Android.App.Activity activity, Java.Lang.Object @callback)
		{
			ShowInterstitial(activity,
				@callback as Com.Appodeal.Ads.Unified.UnifiedInterstitialCallback);
		}
	}
}
