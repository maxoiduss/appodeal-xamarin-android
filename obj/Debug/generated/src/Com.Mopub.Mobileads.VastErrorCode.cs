using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastErrorCode']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/VastErrorCode", DoNotGenerateAcw=true)]
	public sealed partial class VastErrorCode : global::Java.Lang.Enum {


		static IntPtr GENERAL_COMPANION_AD_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastErrorCode']/field[@name='GENERAL_COMPANION_AD_ERROR']"
		[Register ("GENERAL_COMPANION_AD_ERROR")]
		public static global::Com.Mopub.Mobileads.VastErrorCode GeneralCompanionAdError {
			get {
				if (GENERAL_COMPANION_AD_ERROR_jfieldId == IntPtr.Zero)
					GENERAL_COMPANION_AD_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GENERAL_COMPANION_AD_ERROR", "Lcom/mopub/mobileads/VastErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GENERAL_COMPANION_AD_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr GENERAL_LINEAR_AD_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastErrorCode']/field[@name='GENERAL_LINEAR_AD_ERROR']"
		[Register ("GENERAL_LINEAR_AD_ERROR")]
		public static global::Com.Mopub.Mobileads.VastErrorCode GeneralLinearAdError {
			get {
				if (GENERAL_LINEAR_AD_ERROR_jfieldId == IntPtr.Zero)
					GENERAL_LINEAR_AD_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GENERAL_LINEAR_AD_ERROR", "Lcom/mopub/mobileads/VastErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GENERAL_LINEAR_AD_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NO_ADS_VAST_RESPONSE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastErrorCode']/field[@name='NO_ADS_VAST_RESPONSE']"
		[Register ("NO_ADS_VAST_RESPONSE")]
		public static global::Com.Mopub.Mobileads.VastErrorCode NoAdsVastResponse {
			get {
				if (NO_ADS_VAST_RESPONSE_jfieldId == IntPtr.Zero)
					NO_ADS_VAST_RESPONSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_ADS_VAST_RESPONSE", "Lcom/mopub/mobileads/VastErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_ADS_VAST_RESPONSE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNDEFINED_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastErrorCode']/field[@name='UNDEFINED_ERROR']"
		[Register ("UNDEFINED_ERROR")]
		public static global::Com.Mopub.Mobileads.VastErrorCode UndefinedError {
			get {
				if (UNDEFINED_ERROR_jfieldId == IntPtr.Zero)
					UNDEFINED_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNDEFINED_ERROR", "Lcom/mopub/mobileads/VastErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNDEFINED_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr WRAPPER_TIMEOUT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastErrorCode']/field[@name='WRAPPER_TIMEOUT']"
		[Register ("WRAPPER_TIMEOUT")]
		public static global::Com.Mopub.Mobileads.VastErrorCode WrapperTimeout {
			get {
				if (WRAPPER_TIMEOUT_jfieldId == IntPtr.Zero)
					WRAPPER_TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WRAPPER_TIMEOUT", "Lcom/mopub/mobileads/VastErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WRAPPER_TIMEOUT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr XML_PARSING_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastErrorCode']/field[@name='XML_PARSING_ERROR']"
		[Register ("XML_PARSING_ERROR")]
		public static global::Com.Mopub.Mobileads.VastErrorCode XmlParsingError {
			get {
				if (XML_PARSING_ERROR_jfieldId == IntPtr.Zero)
					XML_PARSING_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "XML_PARSING_ERROR", "Lcom/mopub/mobileads/VastErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, XML_PARSING_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/VastErrorCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VastErrorCode); }
		}

		internal VastErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastErrorCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/mobileads/VastErrorCode;", "")]
		public static unsafe global::Com.Mopub.Mobileads.VastErrorCode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/mobileads/VastErrorCode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Mopub.Mobileads.VastErrorCode __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastErrorCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastErrorCode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/mopub/mobileads/VastErrorCode;", "")]
		public static unsafe global::Com.Mopub.Mobileads.VastErrorCode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/mobileads/VastErrorCode;");
			try {
				return (global::Com.Mopub.Mobileads.VastErrorCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Mobileads.VastErrorCode));
			} finally {
			}
		}

	}
}
