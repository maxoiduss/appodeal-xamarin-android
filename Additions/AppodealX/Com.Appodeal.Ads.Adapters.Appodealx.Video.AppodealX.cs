using Android.Runtime;

namespace Com.Appodeal.Ads.Adapters.Appodealx.Video
{
	public partial class AppodealX : global::Com.Appodeal.Ads.Unified.UnifiedVideo
	{
		[Register("load", "(Landroid/app/Activity;Lcom/appodeal/ads/unified/UnifiedVideoParams;Lcom/appodeal/ads/adapters/appodealx/AppodealXNetwork$RequestParams;Lcom/appodeal/ads/unified/UnifiedVideoCallback;)V", "GetLoad_Landroid_app_Activity_Lcom_appodeal_ads_unified_UnifiedVideoParams_Lcom_appodeal_ads_adapters_appodealx_AppodealXNetwork_RequestParams_Lcom_appodeal_ads_unified_UnifiedVideoCallback_Handler")]
		public override unsafe void Load(global::Android.App.Activity activity, Java.Lang.Object @params, Java.Lang.Object networkParams, Java.Lang.Object @callback)
		{
			LoadVideo(activity,
				@params as Com.Appodeal.Ads.Unified.IUnifiedVideoParams,
				networkParams as Com.Appodeal.Ads.Adapters.Appodealx.AppodealXNetwork.RequestParams,
				@callback as Com.Appodeal.Ads.Unified.UnifiedVideoCallback);
		}

		[Register("show", "(Landroid/app/Activity;Lcom/appodeal/ads/unified/UnifiedVideoCallback;)V", "GetShow_Landroid_app_Activity_Lcom_appodeal_ads_unified_UnifiedVideoCallback_Handler")]
		public override unsafe void Show(global::Android.App.Activity activity, Java.Lang.Object @callback)
		{
			ShowVideo(activity,
				@callback as Com.Appodeal.Ads.Unified.UnifiedVideoCallback);
		}
	}
}
