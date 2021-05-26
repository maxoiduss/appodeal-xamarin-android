using System.Text;
using Org.Json;

namespace Com.Appodeal.Ads
{
	public partial class NetworkRequest : Java.Lang.Object
	{
		public partial class SimpleJsonObjectDataBinder : global::Com.Appodeal.Ads.NetworkRequest.RequestDataBinder
		{
			protected override Java.Lang.Object A(global::Com.Appodeal.Ads.NetworkRequest p0, Java.Net.URLConnection p1, byte[] p2)
			{
				return C(p0, p1, p2);
			}

			protected override byte[] A(global::Com.Appodeal.Ads.NetworkRequest p0, Java.Net.URLConnection p1, Java.Lang.Object p2)
			{
				return (p2 is JSONObject param1JSONObject) ? Encoding.UTF8.GetBytes(param1JSONObject.ToString()) : null;
			}

			protected override void A(global::Com.Appodeal.Ads.NetworkRequest p0, Java.Net.URLConnection p1)
			{
				p1.SetRequestProperty("Content-Type", "application/json; charset=UTF-8");
			}
		}
	}
}
