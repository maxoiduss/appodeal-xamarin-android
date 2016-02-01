using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='DataKeys']"
	[global::Android.Runtime.Register ("com/mopub/common/DataKeys", DoNotGenerateAcw=true)]
	public partial class DataKeys : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='DataKeys']/field[@name='AD_HEIGHT']"
		[Register ("AD_HEIGHT")]
		public const string AdHeight = (string) "com_mopub_ad_height";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='DataKeys']/field[@name='AD_REPORT_KEY']"
		[Register ("AD_REPORT_KEY")]
		public const string AdReportKey = (string) "mopub-intent-ad-report";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='DataKeys']/field[@name='AD_UNIT_ID_KEY']"
		[Register ("AD_UNIT_ID_KEY")]
		public const string AdUnitIdKey = (string) "com_mopub_ad_unit_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='DataKeys']/field[@name='AD_WIDTH']"
		[Register ("AD_WIDTH")]
		public const string AdWidth = (string) "com_mopub_ad_width";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='DataKeys']/field[@name='BROADCAST_IDENTIFIER_KEY']"
		[Register ("BROADCAST_IDENTIFIER_KEY")]
		public const string BroadcastIdentifierKey = (string) "broadcastIdentifier";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='DataKeys']/field[@name='CLICKTHROUGH_URL_KEY']"
		[Register ("CLICKTHROUGH_URL_KEY")]
		public const string ClickthroughUrlKey = (string) "Clickthrough-Url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='DataKeys']/field[@name='CREATIVE_ORIENTATION_KEY']"
		[Register ("CREATIVE_ORIENTATION_KEY")]
		public const string CreativeOrientationKey = (string) "com_mopub_orientation";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='DataKeys']/field[@name='HTML_RESPONSE_BODY_KEY']"
		[Register ("HTML_RESPONSE_BODY_KEY")]
		public const string HtmlResponseBodyKey = (string) "Html-Response-Body";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='DataKeys']/field[@name='JSON_BODY_KEY']"
		[Register ("JSON_BODY_KEY")]
		public const string JsonBodyKey = (string) "com_mopub_native_json";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='DataKeys']/field[@name='REDIRECT_URL_KEY']"
		[Register ("REDIRECT_URL_KEY")]
		public const string RedirectUrlKey = (string) "Redirect-Url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='DataKeys']/field[@name='SCROLLABLE_KEY']"
		[Register ("SCROLLABLE_KEY")]
		public const string ScrollableKey = (string) "Scrollable";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/DataKeys", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataKeys); }
		}

		protected DataKeys (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common']/class[@name='DataKeys']/constructor[@name='DataKeys' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DataKeys ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DataKeys)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
