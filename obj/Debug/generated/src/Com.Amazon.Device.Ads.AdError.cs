using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Device.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdError']"
	[global::Android.Runtime.Register ("com/amazon/device/ads/AdError", DoNotGenerateAcw=true)]
	public partial class AdError : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdError.ErrorCode']"
		[global::Android.Runtime.Register ("com/amazon/device/ads/AdError$ErrorCode", DoNotGenerateAcw=true)]
		public sealed partial class ErrorCode : global::Java.Lang.Enum {


			static IntPtr INTERNAL_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdError.ErrorCode']/field[@name='INTERNAL_ERROR']"
			[Register ("INTERNAL_ERROR")]
			public static global::Com.Amazon.Device.Ads.AdError.ErrorCode InternalError {
				get {
					if (INTERNAL_ERROR_jfieldId == IntPtr.Zero)
						INTERNAL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL_ERROR", "Lcom/amazon/device/ads/AdError$ErrorCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERNAL_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdError.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NETWORK_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdError.ErrorCode']/field[@name='NETWORK_ERROR']"
			[Register ("NETWORK_ERROR")]
			public static global::Com.Amazon.Device.Ads.AdError.ErrorCode NetworkError {
				get {
					if (NETWORK_ERROR_jfieldId == IntPtr.Zero)
						NETWORK_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_ERROR", "Lcom/amazon/device/ads/AdError$ErrorCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdError.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NETWORK_TIMEOUT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdError.ErrorCode']/field[@name='NETWORK_TIMEOUT']"
			[Register ("NETWORK_TIMEOUT")]
			public static global::Com.Amazon.Device.Ads.AdError.ErrorCode NetworkTimeout {
				get {
					if (NETWORK_TIMEOUT_jfieldId == IntPtr.Zero)
						NETWORK_TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_TIMEOUT", "Lcom/amazon/device/ads/AdError$ErrorCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_TIMEOUT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdError.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NO_FILL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdError.ErrorCode']/field[@name='NO_FILL']"
			[Register ("NO_FILL")]
			public static global::Com.Amazon.Device.Ads.AdError.ErrorCode NoFill {
				get {
					if (NO_FILL_jfieldId == IntPtr.Zero)
						NO_FILL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_FILL", "Lcom/amazon/device/ads/AdError$ErrorCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_FILL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdError.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REQUEST_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdError.ErrorCode']/field[@name='REQUEST_ERROR']"
			[Register ("REQUEST_ERROR")]
			public static global::Com.Amazon.Device.Ads.AdError.ErrorCode RequestError {
				get {
					if (REQUEST_ERROR_jfieldId == IntPtr.Zero)
						REQUEST_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REQUEST_ERROR", "Lcom/amazon/device/ads/AdError$ErrorCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REQUEST_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdError.ErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/device/ads/AdError$ErrorCode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ErrorCode); }
			}

			internal ErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdError.ErrorCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/device/ads/AdError$ErrorCode;", "")]
			public static unsafe global::Com.Amazon.Device.Ads.AdError.ErrorCode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/device/ads/AdError$ErrorCode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Amazon.Device.Ads.AdError.ErrorCode __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdError.ErrorCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdError.ErrorCode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amazon/device/ads/AdError$ErrorCode;", "")]
			public static unsafe global::Com.Amazon.Device.Ads.AdError.ErrorCode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/device/ads/AdError$ErrorCode;");
				try {
					return (global::Com.Amazon.Device.Ads.AdError.ErrorCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Device.Ads.AdError.ErrorCode));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/device/ads/AdError", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdError); }
		}

		protected AdError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getCode;
#pragma warning disable 0169
		static Delegate GetGetCodeHandler ()
		{
			if (cb_getCode == null)
				cb_getCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCode);
			return cb_getCode;
		}

		static IntPtr n_GetCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.AdError __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Code);
		}
#pragma warning restore 0169

		static IntPtr id_getCode;
		public virtual unsafe global::Com.Amazon.Device.Ads.AdError.ErrorCode Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdError']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()Lcom/amazon/device/ads/AdError$ErrorCode;", "GetGetCodeHandler")]
			get {
				if (id_getCode == IntPtr.Zero)
					id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()Lcom/amazon/device/ads/AdError$ErrorCode;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdError.ErrorCode> (JNIEnv.CallObjectMethod  (Handle, id_getCode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdError.ErrorCode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCode", "()Lcom/amazon/device/ads/AdError$ErrorCode;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.AdError __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdError']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
