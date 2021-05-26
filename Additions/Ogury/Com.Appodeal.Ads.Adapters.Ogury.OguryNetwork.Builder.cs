using Android.Runtime;

namespace Com.Appodeal.Ads.Adapters.Ogury
{
	public partial class OguryNetwork : global::Com.Appodeal.Ads.AdNetwork
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
