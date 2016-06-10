using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley']/class[@name='DefaultRetryPolicy']"
	[global::Android.Runtime.Register ("com/mopub/volley/DefaultRetryPolicy", DoNotGenerateAcw=true)]
	public partial class DefaultRetryPolicy : global::Java.Lang.Object, global::Com.Mopub.Volley.IRetryPolicy {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='DefaultRetryPolicy']/field[@name='DEFAULT_BACKOFF_MULT']"
		[Register ("DEFAULT_BACKOFF_MULT")]
		public const float DefaultBackoffMult = (float) 1.000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='DefaultRetryPolicy']/field[@name='DEFAULT_MAX_RETRIES']"
		[Register ("DEFAULT_MAX_RETRIES")]
		public const int DefaultMaxRetries = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='DefaultRetryPolicy']/field[@name='DEFAULT_TIMEOUT_MS']"
		[Register ("DEFAULT_TIMEOUT_MS")]
		public const int DefaultTimeoutMs = (int) 2500;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/DefaultRetryPolicy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultRetryPolicy); }
		}

		protected DefaultRetryPolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='DefaultRetryPolicy']/constructor[@name='DefaultRetryPolicy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultRetryPolicy ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DefaultRetryPolicy)) {
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

		static IntPtr id_ctor_IIF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='DefaultRetryPolicy']/constructor[@name='DefaultRetryPolicy' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='float']]"
		[Register (".ctor", "(IIF)V", "")]
		public unsafe DefaultRetryPolicy (int p0, int p1, float p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (DefaultRetryPolicy)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIF)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IIF)V", __args);
					return;
				}

				if (id_ctor_IIF == IntPtr.Zero)
					id_ctor_IIF = JNIEnv.GetMethodID (class_ref, "<init>", "(IIF)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIF, __args);
			} finally {
			}
		}

		static Delegate cb_getBackoffMultiplier;
#pragma warning disable 0169
		static Delegate GetGetBackoffMultiplierHandler ()
		{
			if (cb_getBackoffMultiplier == null)
				cb_getBackoffMultiplier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetBackoffMultiplier);
			return cb_getBackoffMultiplier;
		}

		static float n_GetBackoffMultiplier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.DefaultRetryPolicy __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.DefaultRetryPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BackoffMultiplier;
		}
#pragma warning restore 0169

		static IntPtr id_getBackoffMultiplier;
		public virtual unsafe float BackoffMultiplier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='DefaultRetryPolicy']/method[@name='getBackoffMultiplier' and count(parameter)=0]"
			[Register ("getBackoffMultiplier", "()F", "GetGetBackoffMultiplierHandler")]
			get {
				if (id_getBackoffMultiplier == IntPtr.Zero)
					id_getBackoffMultiplier = JNIEnv.GetMethodID (class_ref, "getBackoffMultiplier", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getBackoffMultiplier);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBackoffMultiplier", "()F"));
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentRetryCount;
#pragma warning disable 0169
		static Delegate GetGetCurrentRetryCountHandler ()
		{
			if (cb_getCurrentRetryCount == null)
				cb_getCurrentRetryCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentRetryCount);
			return cb_getCurrentRetryCount;
		}

		static int n_GetCurrentRetryCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.DefaultRetryPolicy __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.DefaultRetryPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentRetryCount;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentRetryCount;
		public virtual unsafe int CurrentRetryCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='DefaultRetryPolicy']/method[@name='getCurrentRetryCount' and count(parameter)=0]"
			[Register ("getCurrentRetryCount", "()I", "GetGetCurrentRetryCountHandler")]
			get {
				if (id_getCurrentRetryCount == IntPtr.Zero)
					id_getCurrentRetryCount = JNIEnv.GetMethodID (class_ref, "getCurrentRetryCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCurrentRetryCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentRetryCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentTimeout;
#pragma warning disable 0169
		static Delegate GetGetCurrentTimeoutHandler ()
		{
			if (cb_getCurrentTimeout == null)
				cb_getCurrentTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentTimeout);
			return cb_getCurrentTimeout;
		}

		static int n_GetCurrentTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.DefaultRetryPolicy __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.DefaultRetryPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentTimeout;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentTimeout;
		public virtual unsafe int CurrentTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='DefaultRetryPolicy']/method[@name='getCurrentTimeout' and count(parameter)=0]"
			[Register ("getCurrentTimeout", "()I", "GetGetCurrentTimeoutHandler")]
			get {
				if (id_getCurrentTimeout == IntPtr.Zero)
					id_getCurrentTimeout = JNIEnv.GetMethodID (class_ref, "getCurrentTimeout", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCurrentTimeout);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentTimeout", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_hasAttemptRemaining;
#pragma warning disable 0169
		static Delegate GetHasAttemptRemainingHandler ()
		{
			if (cb_hasAttemptRemaining == null)
				cb_hasAttemptRemaining = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasAttemptRemaining);
			return cb_hasAttemptRemaining;
		}

		static bool n_HasAttemptRemaining (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.DefaultRetryPolicy __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.DefaultRetryPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAttemptRemaining;
		}
#pragma warning restore 0169

		static IntPtr id_hasAttemptRemaining;
		protected virtual unsafe bool HasAttemptRemaining {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='DefaultRetryPolicy']/method[@name='hasAttemptRemaining' and count(parameter)=0]"
			[Register ("hasAttemptRemaining", "()Z", "GetHasAttemptRemainingHandler")]
			get {
				if (id_hasAttemptRemaining == IntPtr.Zero)
					id_hasAttemptRemaining = JNIEnv.GetMethodID (class_ref, "hasAttemptRemaining", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_hasAttemptRemaining);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasAttemptRemaining", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_retry_Lcom_mopub_volley_VolleyError_;
#pragma warning disable 0169
		static Delegate GetRetry_Lcom_mopub_volley_VolleyError_Handler ()
		{
			if (cb_retry_Lcom_mopub_volley_VolleyError_ == null)
				cb_retry_Lcom_mopub_volley_VolleyError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Retry_Lcom_mopub_volley_VolleyError_);
			return cb_retry_Lcom_mopub_volley_VolleyError_;
		}

		static void n_Retry_Lcom_mopub_volley_VolleyError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.DefaultRetryPolicy __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.DefaultRetryPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.VolleyError p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.VolleyError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Retry (p0);
		}
#pragma warning restore 0169

		static IntPtr id_retry_Lcom_mopub_volley_VolleyError_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='DefaultRetryPolicy']/method[@name='retry' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.VolleyError']]"
		[Register ("retry", "(Lcom/mopub/volley/VolleyError;)V", "GetRetry_Lcom_mopub_volley_VolleyError_Handler")]
		public virtual unsafe void Retry (global::Com.Mopub.Volley.VolleyError p0)
		{
			if (id_retry_Lcom_mopub_volley_VolleyError_ == IntPtr.Zero)
				id_retry_Lcom_mopub_volley_VolleyError_ = JNIEnv.GetMethodID (class_ref, "retry", "(Lcom/mopub/volley/VolleyError;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_retry_Lcom_mopub_volley_VolleyError_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "retry", "(Lcom/mopub/volley/VolleyError;)V"), __args);
			} finally {
			}
		}

	}
}
