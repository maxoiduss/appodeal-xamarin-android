using Android.Runtime;

namespace Com.Appodeal.Ads.Adapters.Appodealx
{
	public partial class AppodealXNetwork
	{
		public partial class Builder
		{
			[Register("build", "()Lcom/appodeal/ads/adapters/appodealx/AppodealXNetwork;", "GetBuildHandler")]
			public override unsafe Com.Appodeal.Ads.AdNetwork Build()
			{
				return BuildNetwork();
			}
		}
	}
}

