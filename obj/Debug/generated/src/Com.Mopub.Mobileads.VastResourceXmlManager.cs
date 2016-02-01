using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastResourceXmlManager']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/VastResourceXmlManager", DoNotGenerateAcw=true)]
	public partial class VastResourceXmlManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastResourceXmlManager']/field[@name='CREATIVE_TYPE']"
		[Register ("CREATIVE_TYPE")]
		public const string CreativeType = (string) "creativeType";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastResourceXmlManager']/field[@name='HTML_RESOURCE']"
		[Register ("HTML_RESOURCE")]
		public const string HtmlResource = (string) "HTMLResource";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastResourceXmlManager']/field[@name='IFRAME_RESOURCE']"
		[Register ("IFRAME_RESOURCE")]
		public const string IframeResource = (string) "IFrameResource";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastResourceXmlManager']/field[@name='STATIC_RESOURCE']"
		[Register ("STATIC_RESOURCE")]
		public const string StaticResource = (string) "StaticResource";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/VastResourceXmlManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VastResourceXmlManager); }
		}

		protected VastResourceXmlManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
