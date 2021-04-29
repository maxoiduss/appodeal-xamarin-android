using Android.Runtime;

namespace Com.Appodeal.Ads.Adapters.Appodeal.Native_ad
{
	public partial class AppodealNative : global::Com.Appodeal.Ads.Unified.UnifiedNative
	{
		[Register("load", "(Landroid/app/Activity;Lcom/appodeal/ads/unified/UnifiedNativeParams;Lcom/appodeal/ads/adapters/appodeal/AppodealNativeNetwork$RequestParams;Lcom/appodeal/ads/unified/UnifiedNativeCallback;)V", "GetLoad_Landroid_app_Activity_Lcom_appodeal_ads_unified_UnifiedNativeParams_Lcom_appodeal_ads_adapters_appodeal_AppodealNativeNetwork_RequestParams_Lcom_appodeal_ads_unified_UnifiedNativeCallback_Handler")]
		public override unsafe void Load(Android.App.Activity activity, Java.Lang.Object @params, Java.Lang.Object networkParams, Java.Lang.Object @callback)
		{
			LoadNative(activity,
				@params as Com.Appodeal.Ads.Unified.IUnifiedNativeParams,
				networkParams as Com.Appodeal.Ads.Adapters.Appodeal.AppodealNativeNetwork.RequestParams,
				@callback as Com.Appodeal.Ads.Unified.UnifiedNativeCallback);
		}
	}
}
