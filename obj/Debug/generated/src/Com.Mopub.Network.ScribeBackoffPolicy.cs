using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.network']/class[@name='ScribeBackoffPolicy']"
	[global::Android.Runtime.Register ("com/mopub/network/ScribeBackoffPolicy", DoNotGenerateAcw=true)]
	public partial class ScribeBackoffPolicy : global::Com.Mopub.Network.BackoffPolicy {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/network/ScribeBackoffPolicy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScribeBackoffPolicy); }
		}

		protected ScribeBackoffPolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.network']/class[@name='ScribeBackoffPolicy']/constructor[@name='ScribeBackoffPolicy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ScribeBackoffPolicy ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ScribeBackoffPolicy)) {
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

		static Delegate cb_backoff_Lcom_mopub_volley_VolleyError_;
#pragma warning disable 0169
		static Delegate GetBackoff_Lcom_mopub_volley_VolleyError_Handler ()
		{
			if (cb_backoff_Lcom_mopub_volley_VolleyError_ == null)
				cb_backoff_Lcom_mopub_volley_VolleyError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Backoff_Lcom_mopub_volley_VolleyError_);
			return cb_backoff_Lcom_mopub_volley_VolleyError_;
		}

		static void n_Backoff_Lcom_mopub_volley_VolleyError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Network.ScribeBackoffPolicy __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.ScribeBackoffPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.VolleyError p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.VolleyError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Backoff (p0);
		}
#pragma warning restore 0169

		static IntPtr id_backoff_Lcom_mopub_volley_VolleyError_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='ScribeBackoffPolicy']/method[@name='backoff' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.VolleyError']]"
		[Register ("backoff", "(Lcom/mopub/volley/VolleyError;)V", "GetBackoff_Lcom_mopub_volley_VolleyError_Handler")]
		public override unsafe void Backoff (global::Com.Mopub.Volley.VolleyError p0)
		{
			if (id_backoff_Lcom_mopub_volley_VolleyError_ == IntPtr.Zero)
				id_backoff_Lcom_mopub_volley_VolleyError_ = JNIEnv.GetMethodID (class_ref, "backoff", "(Lcom/mopub/volley/VolleyError;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_backoff_Lcom_mopub_volley_VolleyError_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "backoff", "(Lcom/mopub/volley/VolleyError;)V"), __args);
			} finally {
			}
		}

	}
}
