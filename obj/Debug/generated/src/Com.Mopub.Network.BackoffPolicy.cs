using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.network']/class[@name='BackoffPolicy']"
	[global::Android.Runtime.Register ("com/mopub/network/BackoffPolicy", DoNotGenerateAcw=true)]
	public abstract partial class BackoffPolicy : global::Java.Lang.Object {


		static IntPtr mBackoffMs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.network']/class[@name='BackoffPolicy']/field[@name='mBackoffMs']"
		[Register ("mBackoffMs")]
		protected int MBackoffMs {
			get {
				if (mBackoffMs_jfieldId == IntPtr.Zero)
					mBackoffMs_jfieldId = JNIEnv.GetFieldID (class_ref, "mBackoffMs", "I");
				return JNIEnv.GetIntField (Handle, mBackoffMs_jfieldId);
			}
			set {
				if (mBackoffMs_jfieldId == IntPtr.Zero)
					mBackoffMs_jfieldId = JNIEnv.GetFieldID (class_ref, "mBackoffMs", "I");
				try {
					JNIEnv.SetField (Handle, mBackoffMs_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mBackoffMultiplier_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.network']/class[@name='BackoffPolicy']/field[@name='mBackoffMultiplier']"
		[Register ("mBackoffMultiplier")]
		protected int MBackoffMultiplier {
			get {
				if (mBackoffMultiplier_jfieldId == IntPtr.Zero)
					mBackoffMultiplier_jfieldId = JNIEnv.GetFieldID (class_ref, "mBackoffMultiplier", "I");
				return JNIEnv.GetIntField (Handle, mBackoffMultiplier_jfieldId);
			}
			set {
				if (mBackoffMultiplier_jfieldId == IntPtr.Zero)
					mBackoffMultiplier_jfieldId = JNIEnv.GetFieldID (class_ref, "mBackoffMultiplier", "I");
				try {
					JNIEnv.SetField (Handle, mBackoffMultiplier_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mDefaultBackoffTimeMs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.network']/class[@name='BackoffPolicy']/field[@name='mDefaultBackoffTimeMs']"
		[Register ("mDefaultBackoffTimeMs")]
		protected int MDefaultBackoffTimeMs {
			get {
				if (mDefaultBackoffTimeMs_jfieldId == IntPtr.Zero)
					mDefaultBackoffTimeMs_jfieldId = JNIEnv.GetFieldID (class_ref, "mDefaultBackoffTimeMs", "I");
				return JNIEnv.GetIntField (Handle, mDefaultBackoffTimeMs_jfieldId);
			}
			set {
				if (mDefaultBackoffTimeMs_jfieldId == IntPtr.Zero)
					mDefaultBackoffTimeMs_jfieldId = JNIEnv.GetFieldID (class_ref, "mDefaultBackoffTimeMs", "I");
				try {
					JNIEnv.SetField (Handle, mDefaultBackoffTimeMs_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mMaxBackoffTimeMs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.network']/class[@name='BackoffPolicy']/field[@name='mMaxBackoffTimeMs']"
		[Register ("mMaxBackoffTimeMs")]
		protected int MMaxBackoffTimeMs {
			get {
				if (mMaxBackoffTimeMs_jfieldId == IntPtr.Zero)
					mMaxBackoffTimeMs_jfieldId = JNIEnv.GetFieldID (class_ref, "mMaxBackoffTimeMs", "I");
				return JNIEnv.GetIntField (Handle, mMaxBackoffTimeMs_jfieldId);
			}
			set {
				if (mMaxBackoffTimeMs_jfieldId == IntPtr.Zero)
					mMaxBackoffTimeMs_jfieldId = JNIEnv.GetFieldID (class_ref, "mMaxBackoffTimeMs", "I");
				try {
					JNIEnv.SetField (Handle, mMaxBackoffTimeMs_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mMaxRetries_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.network']/class[@name='BackoffPolicy']/field[@name='mMaxRetries']"
		[Register ("mMaxRetries")]
		protected int MMaxRetries {
			get {
				if (mMaxRetries_jfieldId == IntPtr.Zero)
					mMaxRetries_jfieldId = JNIEnv.GetFieldID (class_ref, "mMaxRetries", "I");
				return JNIEnv.GetIntField (Handle, mMaxRetries_jfieldId);
			}
			set {
				if (mMaxRetries_jfieldId == IntPtr.Zero)
					mMaxRetries_jfieldId = JNIEnv.GetFieldID (class_ref, "mMaxRetries", "I");
				try {
					JNIEnv.SetField (Handle, mMaxRetries_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mRetryCount_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.network']/class[@name='BackoffPolicy']/field[@name='mRetryCount']"
		[Register ("mRetryCount")]
		protected int MRetryCount {
			get {
				if (mRetryCount_jfieldId == IntPtr.Zero)
					mRetryCount_jfieldId = JNIEnv.GetFieldID (class_ref, "mRetryCount", "I");
				return JNIEnv.GetIntField (Handle, mRetryCount_jfieldId);
			}
			set {
				if (mRetryCount_jfieldId == IntPtr.Zero)
					mRetryCount_jfieldId = JNIEnv.GetFieldID (class_ref, "mRetryCount", "I");
				try {
					JNIEnv.SetField (Handle, mRetryCount_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/network/BackoffPolicy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BackoffPolicy); }
		}

		protected BackoffPolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.network']/class[@name='BackoffPolicy']/constructor[@name='BackoffPolicy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BackoffPolicy ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BackoffPolicy)) {
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

		static Delegate cb_getBackoffMs;
#pragma warning disable 0169
		static Delegate GetGetBackoffMsHandler ()
		{
			if (cb_getBackoffMs == null)
				cb_getBackoffMs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBackoffMs);
			return cb_getBackoffMs;
		}

		static int n_GetBackoffMs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.BackoffPolicy __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.BackoffPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BackoffMs;
		}
#pragma warning restore 0169

		static IntPtr id_getBackoffMs;
		public virtual unsafe int BackoffMs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='BackoffPolicy']/method[@name='getBackoffMs' and count(parameter)=0]"
			[Register ("getBackoffMs", "()I", "GetGetBackoffMsHandler")]
			get {
				if (id_getBackoffMs == IntPtr.Zero)
					id_getBackoffMs = JNIEnv.GetMethodID (class_ref, "getBackoffMs", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getBackoffMs);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBackoffMs", "()I"));
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
			global::Com.Mopub.Network.BackoffPolicy __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.BackoffPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAttemptRemaining;
		}
#pragma warning restore 0169

		static IntPtr id_hasAttemptRemaining;
		public virtual unsafe bool HasAttemptRemaining {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='BackoffPolicy']/method[@name='hasAttemptRemaining' and count(parameter)=0]"
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

		static Delegate cb_getRetryCount;
#pragma warning disable 0169
		static Delegate GetGetRetryCountHandler ()
		{
			if (cb_getRetryCount == null)
				cb_getRetryCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRetryCount);
			return cb_getRetryCount;
		}

		static int n_GetRetryCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.BackoffPolicy __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.BackoffPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetryCount;
		}
#pragma warning restore 0169

		static IntPtr id_getRetryCount;
		public virtual unsafe int RetryCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='BackoffPolicy']/method[@name='getRetryCount' and count(parameter)=0]"
			[Register ("getRetryCount", "()I", "GetGetRetryCountHandler")]
			get {
				if (id_getRetryCount == IntPtr.Zero)
					id_getRetryCount = JNIEnv.GetMethodID (class_ref, "getRetryCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getRetryCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRetryCount", "()I"));
				} finally {
				}
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
			global::Com.Mopub.Network.BackoffPolicy __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.BackoffPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.VolleyError p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.VolleyError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Backoff (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='BackoffPolicy']/method[@name='backoff' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.VolleyError']]"
		[Register ("backoff", "(Lcom/mopub/volley/VolleyError;)V", "GetBackoff_Lcom_mopub_volley_VolleyError_Handler")]
		public abstract void Backoff (global::Com.Mopub.Volley.VolleyError p0);

	}

	[global::Android.Runtime.Register ("com/mopub/network/BackoffPolicy", DoNotGenerateAcw=true)]
	internal partial class BackoffPolicyInvoker : BackoffPolicy {

		public BackoffPolicyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BackoffPolicyInvoker); }
		}

		static IntPtr id_backoff_Lcom_mopub_volley_VolleyError_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='BackoffPolicy']/method[@name='backoff' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.VolleyError']]"
		[Register ("backoff", "(Lcom/mopub/volley/VolleyError;)V", "GetBackoff_Lcom_mopub_volley_VolleyError_Handler")]
		public override unsafe void Backoff (global::Com.Mopub.Volley.VolleyError p0)
		{
			if (id_backoff_Lcom_mopub_volley_VolleyError_ == IntPtr.Zero)
				id_backoff_Lcom_mopub_volley_VolleyError_ = JNIEnv.GetMethodID (class_ref, "backoff", "(Lcom/mopub/volley/VolleyError;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_backoff_Lcom_mopub_volley_VolleyError_, __args);
			} finally {
			}
		}

	}

}
