using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.network']/class[@name='RequestQueueHttpStack']"
	[global::Android.Runtime.Register ("com/mopub/network/RequestQueueHttpStack", DoNotGenerateAcw=true)]
	public partial class RequestQueueHttpStack : global::Com.Mopub.Volley.Toolbox.HurlStack {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/network/RequestQueueHttpStack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestQueueHttpStack); }
		}

		protected RequestQueueHttpStack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_mopub_volley_toolbox_HurlStack_UrlRewriter_Ljavax_net_ssl_SSLSocketFactory_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.network']/class[@name='RequestQueueHttpStack']/constructor[@name='RequestQueueHttpStack' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.volley.toolbox.HurlStack.UrlRewriter'] and parameter[3][@type='javax.net.ssl.SSLSocketFactory']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/mopub/volley/toolbox/HurlStack$UrlRewriter;Ljavax/net/ssl/SSLSocketFactory;)V", "")]
		public unsafe RequestQueueHttpStack (string p0, global::Com.Mopub.Volley.Toolbox.HurlStack.IUrlRewriter p1, global::Javax.Net.Ssl.SSLSocketFactory p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (RequestQueueHttpStack)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/mopub/volley/toolbox/HurlStack$UrlRewriter;Ljavax/net/ssl/SSLSocketFactory;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lcom/mopub/volley/toolbox/HurlStack$UrlRewriter;Ljavax/net/ssl/SSLSocketFactory;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_mopub_volley_toolbox_HurlStack_UrlRewriter_Ljavax_net_ssl_SSLSocketFactory_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_mopub_volley_toolbox_HurlStack_UrlRewriter_Ljavax_net_ssl_SSLSocketFactory_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/mopub/volley/toolbox/HurlStack$UrlRewriter;Ljavax/net/ssl/SSLSocketFactory;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_mopub_volley_toolbox_HurlStack_UrlRewriter_Ljavax_net_ssl_SSLSocketFactory_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_mopub_volley_toolbox_HurlStack_UrlRewriter_Ljavax_net_ssl_SSLSocketFactory_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_mopub_volley_toolbox_HurlStack_UrlRewriter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.network']/class[@name='RequestQueueHttpStack']/constructor[@name='RequestQueueHttpStack' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.volley.toolbox.HurlStack.UrlRewriter']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/mopub/volley/toolbox/HurlStack$UrlRewriter;)V", "")]
		public unsafe RequestQueueHttpStack (string p0, global::Com.Mopub.Volley.Toolbox.HurlStack.IUrlRewriter p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (RequestQueueHttpStack)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/mopub/volley/toolbox/HurlStack$UrlRewriter;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lcom/mopub/volley/toolbox/HurlStack$UrlRewriter;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_mopub_volley_toolbox_HurlStack_UrlRewriter_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_mopub_volley_toolbox_HurlStack_UrlRewriter_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/mopub/volley/toolbox/HurlStack$UrlRewriter;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_mopub_volley_toolbox_HurlStack_UrlRewriter_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_mopub_volley_toolbox_HurlStack_UrlRewriter_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.network']/class[@name='RequestQueueHttpStack']/constructor[@name='RequestQueueHttpStack' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe RequestQueueHttpStack (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (RequestQueueHttpStack)) {
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

	}
}
