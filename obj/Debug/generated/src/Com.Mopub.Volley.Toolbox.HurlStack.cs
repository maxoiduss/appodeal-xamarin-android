using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley.Toolbox {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='HurlStack']"
	[global::Android.Runtime.Register ("com/mopub/volley/toolbox/HurlStack", DoNotGenerateAcw=true)]
	public partial class HurlStack : global::Java.Lang.Object, global::Com.Mopub.Volley.Toolbox.IHttpStack {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.volley.toolbox']/interface[@name='HurlStack.UrlRewriter']"
		[Register ("com/mopub/volley/toolbox/HurlStack$UrlRewriter", "", "Com.Mopub.Volley.Toolbox.HurlStack/IUrlRewriterInvoker")]
		public partial interface IUrlRewriter : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/interface[@name='HurlStack.UrlRewriter']/method[@name='rewriteUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("rewriteUrl", "(Ljava/lang/String;)Ljava/lang/String;", "GetRewriteUrl_Ljava_lang_String_Handler:Com.Mopub.Volley.Toolbox.HurlStack/IUrlRewriterInvoker, AppodealXamarinPlugin")]
			string RewriteUrl (string p0);

		}

		[global::Android.Runtime.Register ("com/mopub/volley/toolbox/HurlStack$UrlRewriter", DoNotGenerateAcw=true)]
		internal class IUrlRewriterInvoker : global::Java.Lang.Object, IUrlRewriter {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/volley/toolbox/HurlStack$UrlRewriter");
			IntPtr class_ref;

			public static IUrlRewriter GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IUrlRewriter> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.volley.toolbox.HurlStack.UrlRewriter"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IUrlRewriterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IUrlRewriterInvoker); }
			}

			static Delegate cb_rewriteUrl_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetRewriteUrl_Ljava_lang_String_Handler ()
			{
				if (cb_rewriteUrl_Ljava_lang_String_ == null)
					cb_rewriteUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RewriteUrl_Ljava_lang_String_);
				return cb_rewriteUrl_Ljava_lang_String_;
			}

			static IntPtr n_RewriteUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Volley.Toolbox.HurlStack.IUrlRewriter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.HurlStack.IUrlRewriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.RewriteUrl (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_rewriteUrl_Ljava_lang_String_;
			public unsafe string RewriteUrl (string p0)
			{
				if (id_rewriteUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_rewriteUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "rewriteUrl", "(Ljava/lang/String;)Ljava/lang/String;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_rewriteUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/toolbox/HurlStack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HurlStack); }
		}

		protected HurlStack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mopub_volley_toolbox_HurlStack_UrlRewriter_Ljavax_net_ssl_SSLSocketFactory_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='HurlStack']/constructor[@name='HurlStack' and count(parameter)=2 and parameter[1][@type='com.mopub.volley.toolbox.HurlStack.UrlRewriter'] and parameter[2][@type='javax.net.ssl.SSLSocketFactory']]"
		[Register (".ctor", "(Lcom/mopub/volley/toolbox/HurlStack$UrlRewriter;Ljavax/net/ssl/SSLSocketFactory;)V", "")]
		public unsafe HurlStack (global::Com.Mopub.Volley.Toolbox.HurlStack.IUrlRewriter p0, global::Javax.Net.Ssl.SSLSocketFactory p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (HurlStack)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/volley/toolbox/HurlStack$UrlRewriter;Ljavax/net/ssl/SSLSocketFactory;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/volley/toolbox/HurlStack$UrlRewriter;Ljavax/net/ssl/SSLSocketFactory;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mopub_volley_toolbox_HurlStack_UrlRewriter_Ljavax_net_ssl_SSLSocketFactory_ == IntPtr.Zero)
					id_ctor_Lcom_mopub_volley_toolbox_HurlStack_UrlRewriter_Ljavax_net_ssl_SSLSocketFactory_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/volley/toolbox/HurlStack$UrlRewriter;Ljavax/net/ssl/SSLSocketFactory;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_volley_toolbox_HurlStack_UrlRewriter_Ljavax_net_ssl_SSLSocketFactory_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_volley_toolbox_HurlStack_UrlRewriter_Ljavax_net_ssl_SSLSocketFactory_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_mopub_volley_toolbox_HurlStack_UrlRewriter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='HurlStack']/constructor[@name='HurlStack' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.toolbox.HurlStack.UrlRewriter']]"
		[Register (".ctor", "(Lcom/mopub/volley/toolbox/HurlStack$UrlRewriter;)V", "")]
		public unsafe HurlStack (global::Com.Mopub.Volley.Toolbox.HurlStack.IUrlRewriter p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (HurlStack)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/volley/toolbox/HurlStack$UrlRewriter;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/volley/toolbox/HurlStack$UrlRewriter;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mopub_volley_toolbox_HurlStack_UrlRewriter_ == IntPtr.Zero)
					id_ctor_Lcom_mopub_volley_toolbox_HurlStack_UrlRewriter_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/volley/toolbox/HurlStack$UrlRewriter;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_volley_toolbox_HurlStack_UrlRewriter_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_volley_toolbox_HurlStack_UrlRewriter_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='HurlStack']/constructor[@name='HurlStack' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HurlStack ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HurlStack)) {
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

		static Delegate cb_createConnection_Ljava_net_URL_;
#pragma warning disable 0169
		static Delegate GetCreateConnection_Ljava_net_URL_Handler ()
		{
			if (cb_createConnection_Ljava_net_URL_ == null)
				cb_createConnection_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateConnection_Ljava_net_URL_);
			return cb_createConnection_Ljava_net_URL_;
		}

		static IntPtr n_CreateConnection_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Toolbox.HurlStack __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.HurlStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URL p0 = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateConnection (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createConnection_Ljava_net_URL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='HurlStack']/method[@name='createConnection' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register ("createConnection", "(Ljava/net/URL;)Ljava/net/HttpURLConnection;", "GetCreateConnection_Ljava_net_URL_Handler")]
		protected virtual unsafe global::Java.Net.HttpURLConnection CreateConnection (global::Java.Net.URL p0)
		{
			if (id_createConnection_Ljava_net_URL_ == IntPtr.Zero)
				id_createConnection_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "createConnection", "(Ljava/net/URL;)Ljava/net/HttpURLConnection;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Net.HttpURLConnection __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (JNIEnv.CallObjectMethod  (Handle, id_createConnection_Ljava_net_URL_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createConnection", "(Ljava/net/URL;)Ljava/net/HttpURLConnection;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
			global::Com.Mopub.Volley.Toolbox.HurlStack __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.HurlStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PerformRequest (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_performRequest_Lcom_mopub_volley_Request_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='HurlStack']/method[@name='performRequest' and count(parameter)=2 and parameter[1][@type='com.mopub.volley.Request'] and parameter[2][@type='java.util.Map']]"
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
