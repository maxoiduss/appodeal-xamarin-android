using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/AdTypeTranslator", DoNotGenerateAcw=true)]
	public partial class AdTypeTranslator : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator']/field[@name='BANNER_SUFFIX']"
		[Register ("BANNER_SUFFIX")]
		public const string BannerSuffix = (string) "_banner";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator']/field[@name='INTERSTITIAL_SUFFIX']"
		[Register ("INTERSTITIAL_SUFFIX")]
		public const string InterstitialSuffix = (string) "_interstitial";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator.CustomEventType']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/AdTypeTranslator$CustomEventType", DoNotGenerateAcw=true)]
		public sealed partial class CustomEventType : global::Java.Lang.Enum {


			static IntPtr GOOGLE_PLAY_SERVICES_BANNER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator.CustomEventType']/field[@name='GOOGLE_PLAY_SERVICES_BANNER']"
			[Register ("GOOGLE_PLAY_SERVICES_BANNER")]
			public static global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType GooglePlayServicesBanner {
				get {
					if (GOOGLE_PLAY_SERVICES_BANNER_jfieldId == IntPtr.Zero)
						GOOGLE_PLAY_SERVICES_BANNER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GOOGLE_PLAY_SERVICES_BANNER", "Lcom/mopub/mobileads/AdTypeTranslator$CustomEventType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GOOGLE_PLAY_SERVICES_BANNER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr GOOGLE_PLAY_SERVICES_INTERSTITIAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator.CustomEventType']/field[@name='GOOGLE_PLAY_SERVICES_INTERSTITIAL']"
			[Register ("GOOGLE_PLAY_SERVICES_INTERSTITIAL")]
			public static global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType GooglePlayServicesInterstitial {
				get {
					if (GOOGLE_PLAY_SERVICES_INTERSTITIAL_jfieldId == IntPtr.Zero)
						GOOGLE_PLAY_SERVICES_INTERSTITIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GOOGLE_PLAY_SERVICES_INTERSTITIAL", "Lcom/mopub/mobileads/AdTypeTranslator$CustomEventType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GOOGLE_PLAY_SERVICES_INTERSTITIAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr HTML_BANNER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator.CustomEventType']/field[@name='HTML_BANNER']"
			[Register ("HTML_BANNER")]
			public static global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType HtmlBanner {
				get {
					if (HTML_BANNER_jfieldId == IntPtr.Zero)
						HTML_BANNER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HTML_BANNER", "Lcom/mopub/mobileads/AdTypeTranslator$CustomEventType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HTML_BANNER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr HTML_INTERSTITIAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator.CustomEventType']/field[@name='HTML_INTERSTITIAL']"
			[Register ("HTML_INTERSTITIAL")]
			public static global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType HtmlInterstitial {
				get {
					if (HTML_INTERSTITIAL_jfieldId == IntPtr.Zero)
						HTML_INTERSTITIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HTML_INTERSTITIAL", "Lcom/mopub/mobileads/AdTypeTranslator$CustomEventType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HTML_INTERSTITIAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MILLENNIAL_BANNER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator.CustomEventType']/field[@name='MILLENNIAL_BANNER']"
			[Register ("MILLENNIAL_BANNER")]
			public static global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType MillennialBanner {
				get {
					if (MILLENNIAL_BANNER_jfieldId == IntPtr.Zero)
						MILLENNIAL_BANNER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MILLENNIAL_BANNER", "Lcom/mopub/mobileads/AdTypeTranslator$CustomEventType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MILLENNIAL_BANNER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MILLENNIAL_INTERSTITIAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator.CustomEventType']/field[@name='MILLENNIAL_INTERSTITIAL']"
			[Register ("MILLENNIAL_INTERSTITIAL")]
			public static global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType MillennialInterstitial {
				get {
					if (MILLENNIAL_INTERSTITIAL_jfieldId == IntPtr.Zero)
						MILLENNIAL_INTERSTITIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MILLENNIAL_INTERSTITIAL", "Lcom/mopub/mobileads/AdTypeTranslator$CustomEventType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MILLENNIAL_INTERSTITIAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MOPUB_NATIVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator.CustomEventType']/field[@name='MOPUB_NATIVE']"
			[Register ("MOPUB_NATIVE")]
			public static global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType MopubNative {
				get {
					if (MOPUB_NATIVE_jfieldId == IntPtr.Zero)
						MOPUB_NATIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOPUB_NATIVE", "Lcom/mopub/mobileads/AdTypeTranslator$CustomEventType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MOPUB_NATIVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MRAID_BANNER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator.CustomEventType']/field[@name='MRAID_BANNER']"
			[Register ("MRAID_BANNER")]
			public static global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType MraidBanner {
				get {
					if (MRAID_BANNER_jfieldId == IntPtr.Zero)
						MRAID_BANNER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MRAID_BANNER", "Lcom/mopub/mobileads/AdTypeTranslator$CustomEventType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MRAID_BANNER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MRAID_INTERSTITIAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator.CustomEventType']/field[@name='MRAID_INTERSTITIAL']"
			[Register ("MRAID_INTERSTITIAL")]
			public static global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType MraidInterstitial {
				get {
					if (MRAID_INTERSTITIAL_jfieldId == IntPtr.Zero)
						MRAID_INTERSTITIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MRAID_INTERSTITIAL", "Lcom/mopub/mobileads/AdTypeTranslator$CustomEventType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MRAID_INTERSTITIAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNSPECIFIED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator.CustomEventType']/field[@name='UNSPECIFIED']"
			[Register ("UNSPECIFIED")]
			public static global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType Unspecified {
				get {
					if (UNSPECIFIED_jfieldId == IntPtr.Zero)
						UNSPECIFIED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSPECIFIED", "Lcom/mopub/mobileads/AdTypeTranslator$CustomEventType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNSPECIFIED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VAST_VIDEO_INTERSTITIAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator.CustomEventType']/field[@name='VAST_VIDEO_INTERSTITIAL']"
			[Register ("VAST_VIDEO_INTERSTITIAL")]
			public static global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType VastVideoInterstitial {
				get {
					if (VAST_VIDEO_INTERSTITIAL_jfieldId == IntPtr.Zero)
						VAST_VIDEO_INTERSTITIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VAST_VIDEO_INTERSTITIAL", "Lcom/mopub/mobileads/AdTypeTranslator$CustomEventType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VAST_VIDEO_INTERSTITIAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/AdTypeTranslator$CustomEventType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CustomEventType); }
			}

			internal CustomEventType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator.CustomEventType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/mobileads/AdTypeTranslator$CustomEventType;", "")]
			public static unsafe global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/mobileads/AdTypeTranslator$CustomEventType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator.CustomEventType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/mobileads/AdTypeTranslator$CustomEventType;", "")]
			public static unsafe global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/mobileads/AdTypeTranslator$CustomEventType;");
				try {
					return (global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Mobileads.AdTypeTranslator.CustomEventType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/AdTypeTranslator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdTypeTranslator); }
		}

		protected AdTypeTranslator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator']/constructor[@name='AdTypeTranslator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AdTypeTranslator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AdTypeTranslator)) {
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

		static IntPtr id_getCustomEventName_Lcom_mopub_common_AdFormat_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdTypeTranslator']/method[@name='getCustomEventName' and count(parameter)=4 and parameter[1][@type='com.mopub.common.AdFormat'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map']]"
		[Register ("getCustomEventName", "(Lcom/mopub/common/AdFormat;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string GetCustomEventName (global::Com.Mopub.Common.AdFormat p0, string p1, string p2, global::System.Collections.IDictionary p3)
		{
			if (id_getCustomEventName_Lcom_mopub_common_AdFormat_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_getCustomEventName_Lcom_mopub_common_AdFormat_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "getCustomEventName", "(Lcom/mopub/common/AdFormat;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCustomEventName_Lcom_mopub_common_AdFormat_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}
