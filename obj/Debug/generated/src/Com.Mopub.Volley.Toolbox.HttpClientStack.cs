using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley.Toolbox {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='HttpClientStack']"
	[global::Android.Runtime.Register ("com/mopub/volley/toolbox/HttpClientStack", DoNotGenerateAcw=true)]
	public partial class HttpClientStack : global::Java.Lang.Object, global::Com.Mopub.Volley.Toolbox.IHttpStack {


		static IntPtr mClient_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='HttpClientStack']/field[@name='mClient']"
		[Register ("mClient")]
		protected global::Org.Apache.Http.Client.IHttpClient MClient {
			get {
				if (mClient_jfieldId == IntPtr.Zero)
					mClient_jfieldId = JNIEnv.GetFieldID (class_ref, "mClient", "Lorg/apache/http/client/HttpClient;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mClient_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Client.IHttpClient> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mClient_jfieldId == IntPtr.Zero)
					mClient_jfieldId = JNIEnv.GetFieldID (class_ref, "mClient", "Lorg/apache/http/client/HttpClient;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mClient_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='HttpClientStack.HttpPatch']"
		[global::Android.Runtime.Register ("com/mopub/volley/toolbox/HttpClientStack$HttpPatch", DoNotGenerateAcw=true)]
		public sealed partial class HttpPatch : global::Org.Apache.Http.Client.Methods.HttpEntityEnclosingRequestBase {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='HttpClientStack.HttpPatch']/field[@name='METHOD_NAME']"
			[Register ("METHOD_NAME")]
			public const string MethodName = (string) "PATCH";
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/volley/toolbox/HttpClientStack$HttpPatch", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HttpPatch); }
			}

			internal HttpPatch (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='HttpClientStack.HttpPatch']/constructor[@name='HttpClientStack.HttpPatch' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe HttpPatch (string p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (GetType () != typeof (HttpPatch)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_ctor_Ljava_net_URI_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='HttpClientStack.HttpPatch']/constructor[@name='HttpClientStack.HttpPatch' and count(parameter)=1 and parameter[1][@type='java.net.URI']]"
			[Register (".ctor", "(Ljava/net/URI;)V", "")]
			public unsafe HttpPatch (global::Java.Net.URI p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (HttpPatch)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/net/URI;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/net/URI;)V", __args);
						return;
					}

					if (id_ctor_Ljava_net_URI_ == IntPtr.Zero)
						id_ctor_Ljava_net_URI_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/net/URI;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_net_URI_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_net_URI_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='HttpClientStack.HttpPatch']/constructor[@name='HttpClientStack.HttpPatch' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe HttpPatch ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (HttpPatch)) {
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

			static IntPtr id_getMethod;
			public override unsafe string Method {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='HttpClientStack.HttpPatch']/method[@name='getMethod' and count(parameter)=0]"
				[Register ("getMethod", "()Ljava/lang/String;", "GetGetMethodHandler")]
				get {
					if (id_getMethod == IntPtr.Zero)
						id_getMethod = JNIEnv.GetMethodID (class_ref, "getMethod", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMethod), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/toolbox/HttpClientStack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpClientStack); }
		}

		protected HttpClientStack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_apache_http_client_HttpClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='HttpClientStack']/constructor[@name='HttpClientStack' and count(parameter)=1 and parameter[1][@type='org.apache.http.client.HttpClient']]"
		[Register (".ctor", "(Lorg/apache/http/client/HttpClient;)V", "")]
		public unsafe HttpClientStack (global::Org.Apache.Http.Client.IHttpClient p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (HttpClientStack)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/apache/http/client/HttpClient;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/apache/http/client/HttpClient;)V", __args);
					return;
				}

				if (id_ctor_Lorg_apache_http_client_HttpClient_ == IntPtr.Zero)
					id_ctor_Lorg_apache_http_client_HttpClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/http/client/HttpClient;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_http_client_HttpClient_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_apache_http_client_HttpClient_, __args);
			} finally {
			}
		}

		static Delegate cb_onPrepareRequest_Lorg_apache_http_client_methods_HttpUriRequest_;
#pragma warning disable 0169
		static Delegate GetOnPrepareRequest_Lorg_apache_http_client_methods_HttpUriRequest_Handler ()
		{
			if (cb_onPrepareRequest_Lorg_apache_http_client_methods_HttpUriRequest_ == null)
				cb_onPrepareRequest_Lorg_apache_http_client_methods_HttpUriRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPrepareRequest_Lorg_apache_http_client_methods_HttpUriRequest_);
			return cb_onPrepareRequest_Lorg_apache_http_client_methods_HttpUriRequest_;
		}

		static void n_OnPrepareRequest_Lorg_apache_http_client_methods_HttpUriRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Toolbox.HttpClientStack __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.HttpClientStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Http.Client.Methods.IHttpUriRequest p0 = (global::Org.Apache.Http.Client.Methods.IHttpUriRequest)global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Client.Methods.IHttpUriRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPrepareRequest (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPrepareRequest_Lorg_apache_http_client_methods_HttpUriRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='HttpClientStack']/method[@name='onPrepareRequest' and count(parameter)=1 and parameter[1][@type='org.apache.http.client.methods.HttpUriRequest']]"
		[Register ("onPrepareRequest", "(Lorg/apache/http/client/methods/HttpUriRequest;)V", "GetOnPrepareRequest_Lorg_apache_http_client_methods_HttpUriRequest_Handler")]
		protected virtual unsafe void OnPrepareRequest (global::Org.Apache.Http.Client.Methods.IHttpUriRequest p0)
		{
			if (id_onPrepareRequest_Lorg_apache_http_client_methods_HttpUriRequest_ == IntPtr.Zero)
				id_onPrepareRequest_Lorg_apache_http_client_methods_HttpUriRequest_ = JNIEnv.GetMethodID (class_ref, "onPrepareRequest", "(Lorg/apache/http/client/methods/HttpUriRequest;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onPrepareRequest_Lorg_apache_http_client_methods_HttpUriRequest_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPrepareRequest", "(Lorg/apache/http/client/methods/HttpUriRequest;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_performRequest_Lcom_mopub_volley_Request_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetPerformRequest_Lcom_mopub_volley_Request_Ljava_util_Map_Handler ()
		{
			if (cb_performRequest_Lcom_mopub_volley_Request_Ljava_util_Map_ == null)
				cb_performRequest_Lcom_mopub_volley_Request_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PerformRequest_Lcom_mopub_volley_Request_Ljava_util_Map_);
			return cb_performRequest_Lcom_mopub_volley_Request_Ljava_util_Map_;
		}

		static IntPtr n_PerformRequest_Lcom_mopub_volley_Request_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Volley.Toolbox.HttpClientStack __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.HttpClientStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PerformRequest (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_performRequest_Lcom_mopub_volley_Request_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='HttpClientStack']/method[@name='performRequest' and count(parameter)=2 and parameter[1][@type='com.mopub.volley.Request'] and parameter[2][@type='java.util.Map']]"
		[Register ("performRequest", "(Lcom/mopub/volley/Request;Ljava/util/Map;)Lorg/apache/http/HttpResponse;", "GetPerformRequest_Lcom_mopub_volley_Request_Ljava_util_Map_Handler")]
		public virtual unsafe global::Org.Apache.Http.IHttpResponse PerformRequest (global::Com.Mopub.Volley.Request p0, global::System.Collections.IDictionary p1)
		{
			if (id_performRequest_Lcom_mopub_volley_Request_Ljava_util_Map_ == IntPtr.Zero)
				id_performRequest_Lcom_mopub_volley_Request_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "performRequest", "(Lcom/mopub/volley/Request;Ljava/util/Map;)Lorg/apache/http/HttpResponse;");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Org.Apache.Http.IHttpResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHttpResponse> (JNIEnv.CallObjectMethod  (Handle, id_performRequest_Lcom_mopub_volley_Request_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHttpResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "performRequest", "(Lcom/mopub/volley/Request;Ljava/util/Map;)Lorg/apache/http/HttpResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
