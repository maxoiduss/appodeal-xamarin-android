using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastIconXmlManager']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/VastIconXmlManager", DoNotGenerateAcw=true)]
	public partial class VastIconXmlManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastIconXmlManager']/field[@name='DURATION']"
		[Register ("DURATION")]
		public const string Duration = (string) "duration";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastIconXmlManager']/field[@name='HEIGHT']"
		[Register ("HEIGHT")]
		public const string Height = (string) "height";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastIconXmlManager']/field[@name='ICON_CLICKS']"
		[Register ("ICON_CLICKS")]
		public const string IconClicks = (string) "IconClicks";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastIconXmlManager']/field[@name='ICON_CLICK_THROUGH']"
		[Register ("ICON_CLICK_THROUGH")]
		public const string IconClickThrough = (string) "IconClickThrough";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastIconXmlManager']/field[@name='ICON_CLICK_TRACKING']"
		[Register ("ICON_CLICK_TRACKING")]
		public const string IconClickTracking = (string) "IconClickTracking";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastIconXmlManager']/field[@name='ICON_VIEW_TRACKING']"
		[Register ("ICON_VIEW_TRACKING")]
		public const string IconViewTracking = (string) "IconViewTracking";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastIconXmlManager']/field[@name='OFFSET']"
		[Register ("OFFSET")]
		public const string Offset = (string) "offset";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastIconXmlManager']/field[@name='WIDTH']"
		[Register ("WIDTH")]
		public const string Width = (string) "width";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/VastIconXmlManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VastIconXmlManager); }
		}

		protected VastIconXmlManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
