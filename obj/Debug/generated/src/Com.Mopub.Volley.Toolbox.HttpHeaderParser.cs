using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley.Toolbox {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='HttpHeaderParser']"
	[global::Android.Runtime.Register ("com/mopub/volley/toolbox/HttpHeaderParser", DoNotGenerateAcw=true)]
	public partial class HttpHeaderParser : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/toolbox/HttpHeaderParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpHeaderParser); }
		}

		protected HttpHeaderParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='HttpHeaderParser']/constructor[@name='HttpHeaderParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpHeaderParser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HttpHeaderParser)) {
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

		static IntPtr id_parseCacheHeaders_Lcom_mopub_volley_NetworkResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='HttpHeaderParser']/method[@name='parseCacheHeaders' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.NetworkResponse']]"
		[Register ("parseCacheHeaders", "(Lcom/mopub/volley/NetworkResponse;)Lcom/mopub/volley/Cache$Entry;", "")]
		public static unsafe global::Com.Mopub.Volley.CacheEntry ParseCacheHeaders (global::Com.Mopub.Volley.NetworkResponse p0)
		{
			if (id_parseCacheHeaders_Lcom_mopub_volley_NetworkResponse_ == IntPtr.Zero)
				id_parseCacheHeaders_Lcom_mopub_volley_NetworkResponse_ = JNIEnv.GetStaticMethodID (class_ref, "parseCacheHeaders", "(Lcom/mopub/volley/NetworkResponse;)Lcom/mopub/volley/Cache$Entry;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Mopub.Volley.CacheEntry __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.CacheEntry> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseCacheHeaders_Lcom_mopub_volley_NetworkResponse_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_parseCharset_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='HttpHeaderParser']/method[@name='parseCharset' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("parseCharset", "(Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string ParseCharset (global::System.Collections.IDictionary p0)
		{
			if (id_parseCharset_Ljava_util_Map_ == IntPtr.Zero)
				id_parseCharset_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "parseCharset", "(Ljava/util/Map;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseCharset_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_parseDateAsEpoch_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='HttpHeaderParser']/method[@name='parseDateAsEpoch' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseDateAsEpoch", "(Ljava/lang/String;)J", "")]
		public static unsafe long ParseDateAsEpoch (string p0)
		{
			if (id_parseDateAsEpoch_Ljava_lang_String_ == IntPtr.Zero)
				id_parseDateAsEpoch_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseDateAsEpoch", "(Ljava/lang/String;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_parseDateAsEpoch_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
