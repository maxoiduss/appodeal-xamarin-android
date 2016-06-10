using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.network']/class[@name='ScribeRequestManager']"
	[global::Android.Runtime.Register ("com/mopub/network/ScribeRequestManager", DoNotGenerateAcw=true)]
	public partial class ScribeRequestManager : global::Com.Mopub.Network.RequestManager, global::Com.Mopub.Network.ScribeRequest.IListener {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/network/ScribeRequestManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScribeRequestManager); }
		}

		protected ScribeRequestManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Looper_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.network']/class[@name='ScribeRequestManager']/constructor[@name='ScribeRequestManager' and count(parameter)=1 and parameter[1][@type='android.os.Looper']]"
		[Register (".ctor", "(Landroid/os/Looper;)V", "")]
		public unsafe ScribeRequestManager (global::Android.OS.Looper p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ScribeRequestManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Looper;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Looper;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Looper_ == IntPtr.Zero)
					id_ctor_Landroid_os_Looper_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Looper;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Looper_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Looper_, __args);
			} finally {
			}
		}

		static Delegate cb_onErrorResponse_Lcom_mopub_volley_VolleyError_;
#pragma warning disable 0169
		static Delegate GetOnErrorResponse_Lcom_mopub_volley_VolleyError_Handler ()
		{
			if (cb_onErrorResponse_Lcom_mopub_volley_VolleyError_ == null)
				cb_onErrorResponse_Lcom_mopub_volley_VolleyError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnErrorResponse_Lcom_mopub_volley_VolleyError_);
			return cb_onErrorResponse_Lcom_mopub_volley_VolleyError_;
		}

		static void n_OnErrorResponse_Lcom_mopub_volley_VolleyError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Network.ScribeRequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.ScribeRequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.VolleyError p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.VolleyError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnErrorResponse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onErrorResponse_Lcom_mopub_volley_VolleyError_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='ScribeRequestManager']/method[@name='onErrorResponse' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.VolleyError']]"
		[Register ("onErrorResponse", "(Lcom/mopub/volley/VolleyError;)V", "GetOnErrorResponse_Lcom_mopub_volley_VolleyError_Handler")]
		public virtual unsafe void OnErrorResponse (global::Com.Mopub.Volley.VolleyError p0)
		{
			if (id_onErrorResponse_Lcom_mopub_volley_VolleyError_ == IntPtr.Zero)
				id_onErrorResponse_Lcom_mopub_volley_VolleyError_ = JNIEnv.GetMethodID (class_ref, "onErrorResponse", "(Lcom/mopub/volley/VolleyError;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onErrorResponse_Lcom_mopub_volley_VolleyError_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onErrorResponse", "(Lcom/mopub/volley/VolleyError;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onResponse;
#pragma warning disable 0169
		static Delegate GetOnResponseHandler ()
		{
			if (cb_onResponse == null)
				cb_onResponse = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResponse);
			return cb_onResponse;
		}

		static void n_OnResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.ScribeRequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.ScribeRequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResponse ();
		}
#pragma warning restore 0169

		static IntPtr id_onResponse;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='ScribeRequestManager']/method[@name='onResponse' and count(parameter)=0]"
		[Register ("onResponse", "()V", "GetOnResponseHandler")]
		public virtual unsafe void OnResponse ()
		{
			if (id_onResponse == IntPtr.Zero)
				id_onResponse = JNIEnv.GetMethodID (class_ref, "onResponse", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onResponse);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResponse", "()V"));
			} finally {
			}
		}

	}
}
