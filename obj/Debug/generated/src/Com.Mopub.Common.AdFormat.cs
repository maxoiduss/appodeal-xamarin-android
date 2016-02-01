using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='AdFormat']"
	[global::Android.Runtime.Register ("com/mopub/common/AdFormat", DoNotGenerateAcw=true)]
	public sealed partial class AdFormat : global::Java.Lang.Enum {


		static IntPtr BANNER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='AdFormat']/field[@name='BANNER']"
		[Register ("BANNER")]
		public static global::Com.Mopub.Common.AdFormat Banner {
			get {
				if (BANNER_jfieldId == IntPtr.Zero)
					BANNER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BANNER", "Lcom/mopub/common/AdFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BANNER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INTERSTITIAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='AdFormat']/field[@name='INTERSTITIAL']"
		[Register ("INTERSTITIAL")]
		public static global::Com.Mopub.Common.AdFormat Interstitial {
			get {
				if (INTERSTITIAL_jfieldId == IntPtr.Zero)
					INTERSTITIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERSTITIAL", "Lcom/mopub/common/AdFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERSTITIAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NATIVE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='AdFormat']/field[@name='NATIVE']"
		[Register ("NATIVE")]
		public static global::Com.Mopub.Common.AdFormat Native {
			get {
				if (NATIVE_jfieldId == IntPtr.Zero)
					NATIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NATIVE", "Lcom/mopub/common/AdFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NATIVE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr REWARDED_VIDEO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='AdFormat']/field[@name='REWARDED_VIDEO']"
		[Register ("REWARDED_VIDEO")]
		public static global::Com.Mopub.Common.AdFormat RewardedVideo {
			get {
				if (REWARDED_VIDEO_jfieldId == IntPtr.Zero)
					REWARDED_VIDEO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REWARDED_VIDEO", "Lcom/mopub/common/AdFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REWARDED_VIDEO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/AdFormat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdFormat); }
		}

		internal AdFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='AdFormat']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/common/AdFormat;", "")]
		public static unsafe global::Com.Mopub.Common.AdFormat ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/common/AdFormat;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Mopub.Common.AdFormat __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='AdFormat']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/mopub/common/AdFormat;", "")]
		public static unsafe global::Com.Mopub.Common.AdFormat[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/common/AdFormat;");
			try {
				return (global::Com.Mopub.Common.AdFormat[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Common.AdFormat));
			} finally {
			}
		}

	}
}
