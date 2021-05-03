using Android.App;
using Android.Runtime;
using Java.Lang;

namespace Com.Appodeal.Ads.Adapters.Ogury.Interstitial
{
	public partial class OguryInterstitial : global::Com.Appodeal.Ads.Unified.UnifiedInterstitial
	{
		[Register("load", "(Landroid/app/Activity;Lcom/appodeal/ads/unified/UnifiedInterstitialParams;Lcom/appodeal/ads/adapters/ogury/OguryNetwork$RequestParams;Lcom/appodeal/ads/unified/UnifiedInterstitialCallback;)V", "GetLoad_Landroid_app_Activity_Lcom_appodeal_ads_unified_UnifiedInterstitialParams_Lcom_appodeal_ads_adapters_ogury_OguryNetwork_RequestParams_Lcom_appodeal_ads_unified_UnifiedInterstitialCallback_Handler")]
		public override unsafe void Load(Activity activity, Object @params,  Object networkParams, Object @callback)
		{
			LoadInterstitial(activity,
				@params as Com.Appodeal.Ads.Unified.IUnifiedInterstitialParams,
				networkParams as Com.Appodeal.Ads.Adapters.Ogury.OguryNetwork.RequestParams,
				@callback as Com.Appodeal.Ads.Unified.UnifiedInterstitialCallback);
		}

		[Register("show", "(Landroid/app/Activity;Lcom/appodeal/ads/unified/UnifiedInterstitialCallback;)V", "GetShow_Landroid_app_Activity_Lcom_appodeal_ads_unified_UnifiedInterstitialCallback_Handler")]
		public override unsafe void Show(Activity activity, Object @callback)
		{
			ShowInterstitial(activity,
				@callback as Com.Appodeal.Ads.Unified.UnifiedInterstitialCallback);
		}
	}
}
