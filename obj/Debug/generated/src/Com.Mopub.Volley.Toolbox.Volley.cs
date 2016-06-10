using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley.Toolbox {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='Volley']"
	[global::Android.Runtime.Register ("com/mopub/volley/toolbox/Volley", DoNotGenerateAcw=true)]
	public partial class Volley : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/toolbox/Volley", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Volley); }
		}

		protected Volley (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='Volley']/constructor[@name='Volley' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Volley ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Volley)) {
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

		static IntPtr id_newRequestQueue_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='Volley']/method[@name='newRequestQueue' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("newRequestQueue", "(Landroid/content/Context;)Lcom/mopub/volley/RequestQueue;", "")]
		public static unsafe global::Com.Mopub.Volley.RequestQueue NewRequestQueue (global::Android.Content.Context p0)
		{
			if (id_newRequestQueue_Landroid_content_Context_ == IntPtr.Zero)
				id_newRequestQueue_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "newRequestQueue", "(Landroid/content/Context;)Lcom/mopub/volley/RequestQueue;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Mopub.Volley.RequestQueue __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.RequestQueue> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newRequestQueue_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newRequestQueue_Landroid_content_Context_Lcom_mopub_volley_toolbox_HttpStack_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='Volley']/method[@name='newRequestQueue' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.volley.toolbox.HttpStack']]"
		[Register ("newRequestQueue", "(Landroid/content/Context;Lcom/mopub/volley/toolbox/HttpStack;)Lcom/mopub/volley/RequestQueue;", "")]
		public static unsafe global::Com.Mopub.Volley.RequestQueue NewRequestQueue (global::Android.Content.Context p0, global::Com.Mopub.Volley.Toolbox.IHttpStack p1)
		{
			if (id_newRequestQueue_Landroid_content_Context_Lcom_mopub_volley_toolbox_HttpStack_ == IntPtr.Zero)
				id_newRequestQueue_Landroid_content_Context_Lcom_mopub_volley_toolbox_HttpStack_ = JNIEnv.GetStaticMethodID (class_ref, "newRequestQueue", "(Landroid/content/Context;Lcom/mopub/volley/toolbox/HttpStack;)Lcom/mopub/volley/RequestQueue;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Mopub.Volley.RequestQueue __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.RequestQueue> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newRequestQueue_Landroid_content_Context_Lcom_mopub_volley_toolbox_HttpStack_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
