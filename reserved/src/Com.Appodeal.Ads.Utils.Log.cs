using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appodeal.ads.utils']/class[@name='Log']"
	[global::Android.Runtime.Register ("com/appodeal/ads/utils/Log", DoNotGenerateAcw=true)]
	public partial class Log : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.appodeal.ads.utils']/class[@name='Log.LogLevel']"
		[global::Android.Runtime.Register ("com/appodeal/ads/utils/Log$LogLevel", DoNotGenerateAcw=true)]
		public sealed partial class LogLevel : global::Java.Lang.Enum {


			static IntPtr debug_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads.utils']/class[@name='Log.LogLevel']/field[@name='debug']"
			[Register ("debug")]
			public static global::Com.Appodeal.Ads.Utils.Log.LogLevel debug {
				get {
					if (debug_jfieldId == IntPtr.Zero)
						debug_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "debug", "Lcom/appodeal/ads/utils/Log$LogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, debug_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Utils.Log.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr none_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads.utils']/class[@name='Log.LogLevel']/field[@name='none']"
			[Register ("none")]
			public static global::Com.Appodeal.Ads.Utils.Log.LogLevel none {
				get {
					if (none_jfieldId == IntPtr.Zero)
						none_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "none", "Lcom/appodeal/ads/utils/Log$LogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, none_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Utils.Log.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr verbose_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads.utils']/class[@name='Log.LogLevel']/field[@name='verbose']"
			[Register ("verbose")]
			public static global::Com.Appodeal.Ads.Utils.Log.LogLevel verbose {
				get {
					if (verbose_jfieldId == IntPtr.Zero)
						verbose_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "verbose", "Lcom/appodeal/ads/utils/Log$LogLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, verbose_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Utils.Log.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/appodeal/ads/utils/Log$LogLevel", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LogLevel); }
			}

			internal LogLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public unsafe int Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads.utils']/class[@name='Log.LogLevel']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()I", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
					try {
						return JNIEnv.CallIntMethod  (Handle, id_getValue);
					} finally {
					}
				}
			}

			static IntPtr id_fromInteger_Ljava_lang_Integer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads.utils']/class[@name='Log.LogLevel']/method[@name='fromInteger' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("fromInteger", "(Ljava/lang/Integer;)Lcom/appodeal/ads/utils/Log$LogLevel;", "")]
			public static unsafe global::Com.Appodeal.Ads.Utils.Log.LogLevel FromInteger (global::Java.Lang.Integer p0)
			{
				if (id_fromInteger_Ljava_lang_Integer_ == IntPtr.Zero)
					id_fromInteger_Ljava_lang_Integer_ = JNIEnv.GetStaticMethodID (class_ref, "fromInteger", "(Ljava/lang/Integer;)Lcom/appodeal/ads/utils/Log$LogLevel;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Appodeal.Ads.Utils.Log.LogLevel __ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Utils.Log.LogLevel> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromInteger_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_names;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads.utils']/class[@name='Log.LogLevel']/method[@name='names' and count(parameter)=0]"
			[Register ("names", "()[Ljava/lang/String;", "")]
			public static unsafe string[] Names ()
			{
				if (id_names == IntPtr.Zero)
					id_names = JNIEnv.GetStaticMethodID (class_ref, "names", "()[Ljava/lang/String;");
				try {
					return (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_names), JniHandleOwnership.TransferLocalRef, typeof (string));
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads.utils']/class[@name='Log.LogLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/appodeal/ads/utils/Log$LogLevel;", "")]
			public static unsafe global::Com.Appodeal.Ads.Utils.Log.LogLevel ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/appodeal/ads/utils/Log$LogLevel;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Appodeal.Ads.Utils.Log.LogLevel __ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Utils.Log.LogLevel> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads.utils']/class[@name='Log.LogLevel']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/appodeal/ads/utils/Log$LogLevel;", "")]
			public static unsafe global::Com.Appodeal.Ads.Utils.Log.LogLevel[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/appodeal/ads/utils/Log$LogLevel;");
				try {
					return (global::Com.Appodeal.Ads.Utils.Log.LogLevel[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Appodeal.Ads.Utils.Log.LogLevel));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/appodeal/ads/utils/Log", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Log); }
		}

		protected Log (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a_Ljava_lang_String_Lcom_appodeal_ads_utils_Log_LogLevel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads.utils']/class[@name='Log']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.appodeal.ads.utils.Log.LogLevel']]"
		[Register ("a", "(Ljava/lang/String;Lcom/appodeal/ads/utils/Log$LogLevel;)V", "")]
		public static unsafe void A (string p0, global::Com.Appodeal.Ads.Utils.Log.LogLevel p1)
		{
			if (id_a_Ljava_lang_String_Lcom_appodeal_ads_utils_Log_LogLevel_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Lcom_appodeal_ads_utils_Log_LogLevel_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;Lcom/appodeal/ads/utils/Log$LogLevel;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Ljava_lang_String_Lcom_appodeal_ads_utils_Log_LogLevel_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_a_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads.utils']/class[@name='Log']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("a", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void A (global::Java.Lang.Throwable p0)
		{
			if (id_a_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_a_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

	}
}
