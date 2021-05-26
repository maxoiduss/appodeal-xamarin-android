using Android.Runtime;

namespace Com.Appodeal.Ads.Adapters.Appodealx.Video
{
	public partial class AppodealX : global::Com.Appodeal.Ads.Unified.UnifiedVideo
	{
		public override unsafe void Load(global::Android.App.Activity activity, Java.Lang.Object @params, Java.Lang.Object networkParams, Java.Lang.Object @callback)
		{
			LoadVideo(activity,
				@params as Com.Appodeal.Ads.Unified.IUnifiedVideoParams,
				networkParams as Com.Appodeal.Ads.Adapters.Appodealx.AppodealXNetwork.RequestParams,
				@callback as Com.Appodeal.Ads.Unified.UnifiedVideoCallback);
		}

		public override unsafe void Show(global::Android.App.Activity activity, Java.Lang.Object @callback)
		{
			ShowVideo(activity,
				@callback as Com.Appodeal.Ads.Unified.UnifiedVideoCallback);
		}
	}
}
