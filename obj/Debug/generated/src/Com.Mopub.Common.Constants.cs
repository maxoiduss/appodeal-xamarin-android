using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='Constants']"
	[global::Android.Runtime.Register ("com/mopub/common/Constants", DoNotGenerateAcw=true)]
	public partial class Constants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='Constants']/field[@name='AD_HANDLER']"
		[Register ("AD_HANDLER")]
		public const string AdHandler = (string) "/m/ad";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='Constants']/field[@name='CONVERSION_TRACKING_HANDLER']"
		[Register ("CONVERSION_TRACKING_HANDLER")]
		public const string ConversionTrackingHandler = (string) "/m/open";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='Constants']/field[@name='HOST']"
		[Register ("HOST")]
		public const string Host = (string) "ads.mopub.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='Constants']/field[@name='HTTP']"
		[Register ("HTTP")]
		public const string Http = (string) "http";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='Constants']/field[@name='HTTPS']"
		[Register ("HTTPS")]
		public const string Https = (string) "https";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='Constants']/field[@name='POSITIONING_HANDLER']"
		[Register ("POSITIONING_HANDLER")]
		public const string PositioningHandler = (string) "/m/pos";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='Constants']/field[@name='TEN_MB']"
		[Register ("TEN_MB")]
		public const int TenMb = (int) 10485760;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='Constants']/field[@name='TEN_SECONDS_MILLIS']"
		[Register ("TEN_SECONDS_MILLIS")]
		public const int TenSecondsMillis = (int) 10000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='Constants']/field[@name='THIRTY_SECONDS_MILLIS']"
		[Register ("THIRTY_SECONDS_MILLIS")]
		public const int ThirtySecondsMillis = (int) 30000;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/Constants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Constants); }
		}

		protected Constants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
