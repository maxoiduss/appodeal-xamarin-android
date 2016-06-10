using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='HttpClients']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/util/HttpClients", DoNotGenerateAcw=true)]
	public partial class HttpClients : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/util/HttpClients", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpClients); }
		}

		protected HttpClients (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='HttpClients']/constructor[@name='HttpClients' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpClients ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HttpClients)) {
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

		static IntPtr id_safeShutdown_Lorg_apache_http_client_HttpClient_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.util']/class[@name='HttpClients']/method[@name='safeShutdown' and count(parameter)=1 and parameter[1][@type='org.apache.http.client.HttpClient']]"
		[Register ("safeShutdown", "(Lorg/apache/http/client/HttpClient;)V", "")]
		public static unsafe void SafeShutdown (global::Org.Apache.Http.Client.IHttpClient p0)
		{
			if (id_safeShutdown_Lorg_apache_http_client_HttpClient_ == IntPtr.Zero)
				id_safeShutdown_Lorg_apache_http_client_HttpClient_ = JNIEnv.GetStaticMethodID (class_ref, "safeShutdown", "(Lorg/apache/http/client/HttpClient;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_safeShutdown_Lorg_apache_http_client_HttpClient_, __args);
			} finally {
			}
		}

	}
}
