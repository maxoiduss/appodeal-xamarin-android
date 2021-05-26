using Android.App;
using Android.Runtime;
using Java.Lang;

namespace Com.Appodeal.Ads.Adapters.Ogury.Interstitial
{
	public partial class OguryInterstitial : global::Com.Appodeal.Ads.Unified.UnifiedInterstitial
	{
		public override unsafe void Load(Activity activity, Object @params,  Object networkParams, Object @callback)
		{
			LoadInterstitial(activity,
				@params as Com.Appodeal.Ads.Unified.IUnifiedInterstitialParams,
				networkParams as Com.Appodeal.Ads.Adapters.Ogury.OguryNetwork.RequestParams,
				@callback as Com.Appodeal.Ads.Unified.UnifiedInterstitialCallback);
		}

		public override unsafe void Show(Activity activity, Object @callback)
		{
			var cllbk = @callback as Com.Appodeal.Ads.Unified.UnifiedInterstitialCallback;
			if (cllbk == null)
			{
				System.Diagnostics.Debug.WriteLine("!!! @callback as Com.Appodeal.Ads.Unified.UnifiedInterstitialCallback = null");
			}
			else System.Diagnostics.Debug.WriteLine("!!! @callback = " + cllbk.ToString());

			ShowInterstitial(activity,
				cllbk);
		}
	}
}
