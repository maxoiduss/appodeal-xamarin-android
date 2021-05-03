using System;

namespace Com.Smaato.Sdk.Core.Network
{
	public partial class NetworkHttpRequest : Java.Lang.Object, global::Com.Smaato.Sdk.Core.Network.INetworkRequest
	{
		unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> INetworkRequest.Headers => GetHeaders();
	}
}
