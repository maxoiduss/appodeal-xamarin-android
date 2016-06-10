using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.network']/class[@name='MoPubRequestQueue']"
	[global::Android.Runtime.Register ("com/mopub/network/MoPubRequestQueue", DoNotGenerateAcw=true)]
	public partial class MoPubRequestQueue : global::Com.Mopub.Volley.RequestQueue {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.network']/class[@name='MoPubRequestQueue.DelayedRequestHelper']"
		[global::Android.Runtime.Register ("com/mopub/network/MoPubRequestQueue$DelayedRequestHelper", DoNotGenerateAcw=true)]
		public partial class DelayedRequestHelper : global::Java.Lang.Object {

			protected DelayedRequestHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/network/MoPubRequestQueue", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoPubRequestQueue); }
		}

		protected MoPubRequestQueue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_addDelayedRequest_Lcom_mopub_volley_Request_I;
#pragma warning disable 0169
		static Delegate GetAddDelayedRequest_Lcom_mopub_volley_Request_IHandler ()
		{
			if (cb_addDelayedRequest_Lcom_mopub_volley_Request_I == null)
				cb_addDelayedRequest_Lcom_mopub_volley_Request_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_AddDelayedRequest_Lcom_mopub_volley_Request_I);
			return cb_addDelayedRequest_Lcom_mopub_volley_Request_I;
		}

		static void n_AddDelayedRequest_Lcom_mopub_volley_Request_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Mopub.Network.MoPubRequestQueue __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.MoPubRequestQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddDelayedRequest (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addDelayedRequest_Lcom_mopub_volley_Request_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='MoPubRequestQueue']/method[@name='addDelayedRequest' and count(parameter)=2 and parameter[1][@type='com.mopub.volley.Request'] and parameter[2][@type='int']]"
		[Register ("addDelayedRequest", "(Lcom/mopub/volley/Request;I)V", "GetAddDelayedRequest_Lcom_mopub_volley_Request_IHandler")]
		public virtual unsafe void AddDelayedRequest (global::Com.Mopub.Volley.Request p0, int p1)
		{
			if (id_addDelayedRequest_Lcom_mopub_volley_Request_I == IntPtr.Zero)
				id_addDelayedRequest_Lcom_mopub_volley_Request_I = JNIEnv.GetMethodID (class_ref, "addDelayedRequest", "(Lcom/mopub/volley/Request;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addDelayedRequest_Lcom_mopub_volley_Request_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addDelayedRequest", "(Lcom/mopub/volley/Request;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_cancel_Lcom_mopub_volley_Request_;
#pragma warning disable 0169
		static Delegate GetCancel_Lcom_mopub_volley_Request_Handler ()
		{
			if (cb_cancel_Lcom_mopub_volley_Request_ == null)
				cb_cancel_Lcom_mopub_volley_Request_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Cancel_Lcom_mopub_volley_Request_);
			return cb_cancel_Lcom_mopub_volley_Request_;
		}

		static void n_Cancel_Lcom_mopub_volley_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Network.MoPubRequestQueue __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.MoPubRequestQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Cancel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_cancel_Lcom_mopub_volley_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='MoPubRequestQueue']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.Request']]"
		[Register ("cancel", "(Lcom/mopub/volley/Request;)V", "GetCancel_Lcom_mopub_volley_Request_Handler")]
		public virtual unsafe void Cancel (global::Com.Mopub.Volley.Request p0)
		{
			if (id_cancel_Lcom_mopub_volley_Request_ == IntPtr.Zero)
				id_cancel_Lcom_mopub_volley_Request_ = JNIEnv.GetMethodID (class_ref, "cancel", "(Lcom/mopub/volley/Request;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cancel_Lcom_mopub_volley_Request_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "(Lcom/mopub/volley/Request;)V"), __args);
			} finally {
			}
		}

	}
}
