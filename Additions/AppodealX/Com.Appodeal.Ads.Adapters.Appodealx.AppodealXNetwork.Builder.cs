using Android.Runtime;

namespace Com.Appodeal.Ads.Adapters.Appodealx
{
	public partial class AppodealXNetwork : global::Com.Appodeal.Ads.AdNetwork
	{
		public partial class Builder : global::Com.Appodeal.Ads.AdNetworkBuilder
		{
			public override unsafe global::Com.Appodeal.Ads.AdNetwork Build()
			{
				return BuildNetwork();
			}
		}
	}
}

