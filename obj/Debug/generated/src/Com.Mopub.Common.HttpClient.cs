using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='HttpClient']"
	[global::Android.Runtime.Register ("com/mopub/common/HttpClient", DoNotGenerateAcw=true)]
	public partial class HttpClient : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/HttpClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpClient); }
		}

		protected HttpClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common']/class[@name='HttpClient']/constructor[@name='HttpClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpClient ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HttpClient)) {
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

		static IntPtr id_getHttpClient;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='HttpClient']/method[@name='getHttpClient' and count(parameter)=0]"
		[Register ("getHttpClient", "()Landroid/net/http/AndroidHttpClient;", "")]
		public static unsafe global::Android.Net.Http.AndroidHttpClient GetHttpClient ()
		{
			if (id_getHttpClient == IntPtr.Zero)
				id_getHttpClient = JNIEnv.GetStaticMethodID (class_ref, "getHttpClient", "()Landroid/net/http/AndroidHttpClient;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.Net.Http.AndroidHttpClient> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getHttpClient), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_initializeHttpGet_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='HttpClient']/method[@name='initializeHttpGet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("initializeHttpGet", "(Ljava/lang/String;)Lorg/apache/http/client/methods/HttpGet;", "")]
		public static unsafe global::Org.Apache.Http.Client.Methods.HttpGet InitializeHttpGet (string p0)
		{
			if (id_initializeHttpGet_Ljava_lang_String_ == IntPtr.Zero)
				id_initializeHttpGet_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "initializeHttpGet", "(Ljava/lang/String;)Lorg/apache/http/client/methods/HttpGet;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Apache.Http.Client.Methods.HttpGet __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Client.Methods.HttpGet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_initializeHttpGet_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_initializeHttpGet_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='HttpClient']/method[@name='initializeHttpGet' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("initializeHttpGet", "(Ljava/lang/String;Landroid/content/Context;)Lorg/apache/http/client/methods/HttpGet;", "")]
		public static unsafe global::Org.Apache.Http.Client.Methods.HttpGet InitializeHttpGet (string p0, global::Android.Content.Context p1)
		{
			if (id_initializeHttpGet_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_initializeHttpGet_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "initializeHttpGet", "(Ljava/lang/String;Landroid/content/Context;)Lorg/apache/http/client/methods/HttpGet;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Org.Apache.Http.Client.Methods.HttpGet __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Client.Methods.HttpGet> (JNIEnv.CallStaticObjectMethod  (class_ref, id_initializeHttpGet_Ljava_lang_String_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_urlEncode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='HttpClient']/method[@name='urlEncode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("urlEncode", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string UrlEncode (string p0)
		{
			if (id_urlEncode_Ljava_lang_String_ == IntPtr.Zero)
				id_urlEncode_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "urlEncode", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_urlEncode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
