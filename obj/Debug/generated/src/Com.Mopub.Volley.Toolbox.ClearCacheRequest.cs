using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley.Toolbox {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ClearCacheRequest']"
	[global::Android.Runtime.Register ("com/mopub/volley/toolbox/ClearCacheRequest", DoNotGenerateAcw=true)]
	public partial class ClearCacheRequest : global::Com.Mopub.Volley.Request {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/toolbox/ClearCacheRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClearCacheRequest); }
		}

		protected ClearCacheRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mopub_volley_Cache_Ljava_lang_Runnable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ClearCacheRequest']/constructor[@name='ClearCacheRequest' and count(parameter)=2 and parameter[1][@type='com.mopub.volley.Cache'] and parameter[2][@type='java.lang.Runnable']]"
		[Register (".ctor", "(Lcom/mopub/volley/Cache;Ljava/lang/Runnable;)V", "")]
		public unsafe ClearCacheRequest (global::Com.Mopub.Volley.ICache p0, global::Java.Lang.IRunnable p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ClearCacheRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/volley/Cache;Ljava/lang/Runnable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/volley/Cache;Ljava/lang/Runnable;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mopub_volley_Cache_Ljava_lang_Runnable_ == IntPtr.Zero)
					id_ctor_Lcom_mopub_volley_Cache_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/volley/Cache;Ljava/lang/Runnable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_volley_Cache_Ljava_lang_Runnable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_volley_Cache_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

		static Delegate cb_deliverResponse_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDeliverResponse_Ljava_lang_Object_Handler ()
		{
			if (cb_deliverResponse_Ljava_lang_Object_ == null)
				cb_deliverResponse_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeliverResponse_Ljava_lang_Object_);
			return cb_deliverResponse_Ljava_lang_Object_;
		}

		static void n_DeliverResponse_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Toolbox.ClearCacheRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ClearCacheRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeliverResponse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deliverResponse_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ClearCacheRequest']/method[@name='deliverResponse' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("deliverResponse", "(Ljava/lang/Object;)V", "GetDeliverResponse_Ljava_lang_Object_Handler")]
		protected override unsafe void DeliverResponse (global::Java.Lang.Object p0)
		{
			if (id_deliverResponse_Ljava_lang_Object_ == IntPtr.Zero)
				id_deliverResponse_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "deliverResponse", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_deliverResponse_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deliverResponse", "(Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_;
#pragma warning disable 0169
		static Delegate GetParseNetworkResponse_Lcom_mopub_volley_NetworkResponse_Handler ()
		{
			if (cb_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_ == null)
				cb_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ParseNetworkResponse_Lcom_mopub_volley_NetworkResponse_);
			return cb_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_;
		}

		static IntPtr n_ParseNetworkResponse_Lcom_mopub_volley_NetworkResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Toolbox.ClearCacheRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ClearCacheRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.NetworkResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.NetworkResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ParseNetworkResponse (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ClearCacheRequest']/method[@name='parseNetworkResponse' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.NetworkResponse']]"
		[Register ("parseNetworkResponse", "(Lcom/mopub/volley/NetworkResponse;)Lcom/mopub/volley/Response;", "GetParseNetworkResponse_Lcom_mopub_volley_NetworkResponse_Handler")]
		protected override unsafe global::Com.Mopub.Volley.Response ParseNetworkResponse (global::Com.Mopub.Volley.NetworkResponse p0)
		{
			if (id_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_ == IntPtr.Zero)
				id_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_ = JNIEnv.GetMethodID (class_ref, "parseNetworkResponse", "(Lcom/mopub/volley/NetworkResponse;)Lcom/mopub/volley/Response;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mopub.Volley.Response __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Response> (JNIEnv.CallObjectMethod  (Handle, id_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Response> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parseNetworkResponse", "(Lcom/mopub/volley/NetworkResponse;)Lcom/mopub/volley/Response;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
