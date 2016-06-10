using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']"
	[global::Android.Runtime.Register ("com/mopub/common/util/ResponseHeader", DoNotGenerateAcw=true)]
	public sealed partial class ResponseHeader : global::Java.Lang.Enum {


		static IntPtr ACCEPT_LANGUAGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/field[@name='ACCEPT_LANGUAGE']"
		[Register ("ACCEPT_LANGUAGE")]
		public static global::Com.Mopub.Common.Util.ResponseHeader AcceptLanguage {
			get {
				if (ACCEPT_LANGUAGE_jfieldId == IntPtr.Zero)
					ACCEPT_LANGUAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCEPT_LANGUAGE", "Lcom/mopub/common/util/ResponseHeader;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACCEPT_LANGUAGE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AD_TIMEOUT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/field[@name='AD_TIMEOUT']"
		[Register ("AD_TIMEOUT")]
		public static global::Com.Mopub.Common.Util.ResponseHeader AdTimeout {
			get {
				if (AD_TIMEOUT_jfieldId == IntPtr.Zero)
					AD_TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AD_TIMEOUT", "Lcom/mopub/common/util/ResponseHeader;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AD_TIMEOUT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AD_TYPE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/field[@name='AD_TYPE']"
		[Register ("AD_TYPE")]
		public static global::Com.Mopub.Common.Util.ResponseHeader AdType {
			get {
				if (AD_TYPE_jfieldId == IntPtr.Zero)
					AD_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AD_TYPE", "Lcom/mopub/common/util/ResponseHeader;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AD_TYPE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CLICK_TRACKING_URL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/field[@name='CLICK_TRACKING_URL']"
		[Register ("CLICK_TRACKING_URL")]
		public static global::Com.Mopub.Common.Util.ResponseHeader ClickTrackingUrl {
			get {
				if (CLICK_TRACKING_URL_jfieldId == IntPtr.Zero)
					CLICK_TRACKING_URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLICK_TRACKING_URL", "Lcom/mopub/common/util/ResponseHeader;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLICK_TRACKING_URL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CUSTOM_EVENT_DATA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/field[@name='CUSTOM_EVENT_DATA']"
		[Register ("CUSTOM_EVENT_DATA")]
		public static global::Com.Mopub.Common.Util.ResponseHeader CustomEventData {
			get {
				if (CUSTOM_EVENT_DATA_jfieldId == IntPtr.Zero)
					CUSTOM_EVENT_DATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CUSTOM_EVENT_DATA", "Lcom/mopub/common/util/ResponseHeader;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CUSTOM_EVENT_DATA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CUSTOM_EVENT_HTML_DATA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/field[@name='CUSTOM_EVENT_HTML_DATA']"
		[Register ("CUSTOM_EVENT_HTML_DATA")]
		public static global::Com.Mopub.Common.Util.ResponseHeader CustomEventHtmlData {
			get {
				if (CUSTOM_EVENT_HTML_DATA_jfieldId == IntPtr.Zero)
					CUSTOM_EVENT_HTML_DATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CUSTOM_EVENT_HTML_DATA", "Lcom/mopub/common/util/ResponseHeader;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CUSTOM_EVENT_HTML_DATA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CUSTOM_EVENT_NAME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/field[@name='CUSTOM_EVENT_NAME']"
		[Register ("CUSTOM_EVENT_NAME")]
		public static global::Com.Mopub.Common.Util.ResponseHeader CustomEventName {
			get {
				if (CUSTOM_EVENT_NAME_jfieldId == IntPtr.Zero)
					CUSTOM_EVENT_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CUSTOM_EVENT_NAME", "Lcom/mopub/common/util/ResponseHeader;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CUSTOM_EVENT_NAME_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CUSTOM_SELECTOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/field[@name='CUSTOM_SELECTOR']"
		[Register ("CUSTOM_SELECTOR")]
		public static global::Com.Mopub.Common.Util.ResponseHeader CustomSelector {
			get {
				if (CUSTOM_SELECTOR_jfieldId == IntPtr.Zero)
					CUSTOM_SELECTOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CUSTOM_SELECTOR", "Lcom/mopub/common/util/ResponseHeader;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CUSTOM_SELECTOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DSP_CREATIVE_ID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/field[@name='DSP_CREATIVE_ID']"
		[Register ("DSP_CREATIVE_ID")]
		public static global::Com.Mopub.Common.Util.ResponseHeader DspCreativeId {
			get {
				if (DSP_CREATIVE_ID_jfieldId == IntPtr.Zero)
					DSP_CREATIVE_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DSP_CREATIVE_ID", "Lcom/mopub/common/util/ResponseHeader;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DSP_CREATIVE_ID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FAIL_URL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/field[@name='FAIL_URL']"
		[Register ("FAIL_URL")]
		public static global::Com.Mopub.Common.Util.ResponseHeader FailUrl {
			get {
				if (FAIL_URL_jfieldId == IntPtr.Zero)
					FAIL_URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAIL_URL", "Lcom/mopub/common/util/ResponseHeader;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAIL_URL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FULL_AD_TYPE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/field[@name='FULL_AD_TYPE']"
		[Register ("FULL_AD_TYPE")]
		public static global::Com.Mopub.Common.Util.ResponseHeader FullAdType {
			get {
				if (FULL_AD_TYPE_jfieldId == IntPtr.Zero)
					FULL_AD_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FULL_AD_TYPE", "Lcom/mopub/common/util/ResponseHeader;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FULL_AD_TYPE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HEIGHT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/field[@name='HEIGHT']"
		[Register ("HEIGHT")]
		public static global::Com.Mopub.Common.Util.ResponseHeader Height {
			get {
				if (HEIGHT_jfieldId == IntPtr.Zero)
					HEIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HEIGHT", "Lcom/mopub/common/util/ResponseHeader;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HEIGHT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr IMPRESSION_URL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/field[@name='IMPRESSION_URL']"
		[Register ("IMPRESSION_URL")]
		public static global::Com.Mopub.Common.Util.ResponseHeader ImpressionUrl {
			get {
				if (IMPRESSION_URL_jfieldId == IntPtr.Zero)
					IMPRESSION_URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IMPRESSION_URL", "Lcom/mopub/common/util/ResponseHeader;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IMPRESSION_URL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LOCATION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/field[@name='LOCATION']"
		[Register ("LOCATION")]
		public static global::Com.Mopub.Common.Util.ResponseHeader Location {
			get {
				if (LOCATION_jfieldId == IntPtr.Zero)
					LOCATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOCATION", "Lcom/mopub/common/util/ResponseHeader;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOCATION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NATIVE_PARAMS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/field[@name='NATIVE_PARAMS']"
		[Register ("NATIVE_PARAMS")]
		public static global::Com.Mopub.Common.Util.ResponseHeader NativeParams {
			get {
				if (NATIVE_PARAMS_jfieldId == IntPtr.Zero)
					NATIVE_PARAMS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NATIVE_PARAMS", "Lcom/mopub/common/util/ResponseHeader;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NATIVE_PARAMS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NETWORK_TYPE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/field[@name='NETWORK_TYPE']"
		[Register ("NETWORK_TYPE")]
		public static global::Com.Mopub.Common.Util.ResponseHeader NetworkType {
			get {
				if (NETWORK_TYPE_jfieldId == IntPtr.Zero)
					NETWORK_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_TYPE", "Lcom/mopub/common/util/ResponseHeader;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_TYPE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ORIENTATION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/field[@name='ORIENTATION']"
		[Register ("ORIENTATION")]
		public static global::Com.Mopub.Common.Util.ResponseHeader Orientation {
			get {
				if (ORIENTATION_jfieldId == IntPtr.Zero)
					ORIENTATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ORIENTATION", "Lcom/mopub/common/util/ResponseHeader;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ORIENTATION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr REDIRECT_URL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/field[@name='REDIRECT_URL']"
		[Register ("REDIRECT_URL")]
		public static global::Com.Mopub.Common.Util.ResponseHeader RedirectUrl {
			get {
				if (REDIRECT_URL_jfieldId == IntPtr.Zero)
					REDIRECT_URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REDIRECT_URL", "Lcom/mopub/common/util/ResponseHeader;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REDIRECT_URL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr REFRESH_TIME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/field[@name='REFRESH_TIME']"
		[Register ("REFRESH_TIME")]
		public static global::Com.Mopub.Common.Util.ResponseHeader RefreshTime {
			get {
				if (REFRESH_TIME_jfieldId == IntPtr.Zero)
					REFRESH_TIME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REFRESH_TIME", "Lcom/mopub/common/util/ResponseHeader;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REFRESH_TIME_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SCROLLABLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/field[@name='SCROLLABLE']"
		[Register ("SCROLLABLE")]
		public static global::Com.Mopub.Common.Util.ResponseHeader Scrollable {
			get {
				if (SCROLLABLE_jfieldId == IntPtr.Zero)
					SCROLLABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SCROLLABLE", "Lcom/mopub/common/util/ResponseHeader;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SCROLLABLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr USER_AGENT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/field[@name='USER_AGENT']"
		[Register ("USER_AGENT")]
		public static global::Com.Mopub.Common.Util.ResponseHeader UserAgent {
			get {
				if (USER_AGENT_jfieldId == IntPtr.Zero)
					USER_AGENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_AGENT", "Lcom/mopub/common/util/ResponseHeader;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_AGENT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr WARMUP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/field[@name='WARMUP']"
		[Register ("WARMUP")]
		public static global::Com.Mopub.Common.Util.ResponseHeader Warmup {
			get {
				if (WARMUP_jfieldId == IntPtr.Zero)
					WARMUP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WARMUP", "Lcom/mopub/common/util/ResponseHeader;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WARMUP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr WIDTH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/field[@name='WIDTH']"
		[Register ("WIDTH")]
		public static global::Com.Mopub.Common.Util.ResponseHeader Width {
			get {
				if (WIDTH_jfieldId == IntPtr.Zero)
					WIDTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WIDTH", "Lcom/mopub/common/util/ResponseHeader;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WIDTH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/util/ResponseHeader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResponseHeader); }
		}

		internal ResponseHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getKey;
		public unsafe string Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/method[@name='getKey' and count(parameter)=0]"
			[Register ("getKey", "()Ljava/lang/String;", "GetGetKeyHandler")]
			get {
				if (id_getKey == IntPtr.Zero)
					id_getKey = JNIEnv.GetMethodID (class_ref, "getKey", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getKey), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/common/util/ResponseHeader;", "")]
		public static unsafe global::Com.Mopub.Common.Util.ResponseHeader ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/common/util/ResponseHeader;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Mopub.Common.Util.ResponseHeader __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ResponseHeader']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/mopub/common/util/ResponseHeader;", "")]
		public static unsafe global::Com.Mopub.Common.Util.ResponseHeader[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/common/util/ResponseHeader;");
			try {
				return (global::Com.Mopub.Common.Util.ResponseHeader[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Common.Util.ResponseHeader));
			} finally {
			}
		}

	}
}
