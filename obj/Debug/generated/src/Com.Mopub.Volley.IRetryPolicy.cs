using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.volley']/interface[@name='RetryPolicy']"
	[Register ("com/mopub/volley/RetryPolicy", "", "Com.Mopub.Volley.IRetryPolicyInvoker")]
	public partial interface IRetryPolicy : IJavaObject {

		int CurrentRetryCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/interface[@name='RetryPolicy']/method[@name='getCurrentRetryCount' and count(parameter)=0]"
			[Register ("getCurrentRetryCount", "()I", "GetGetCurrentRetryCountHandler:Com.Mopub.Volley.IRetryPolicyInvoker, AppodealXamarinPlugin")] get;
		}

		int CurrentTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/interface[@name='RetryPolicy']/method[@name='getCurrentTimeout' and count(parameter)=0]"
			[Register ("getCurrentTimeout", "()I", "GetGetCurrentTimeoutHandler:Com.Mopub.Volley.IRetryPolicyInvoker, AppodealXamarinPlugin")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/interface[@name='RetryPolicy']/method[@name='retry' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.VolleyError']]"
		[Register ("retry", "(Lcom/mopub/volley/VolleyError;)V", "GetRetry_Lcom_mopub_volley_VolleyError_Handler:Com.Mopub.Volley.IRetryPolicyInvoker, AppodealXamarinPlugin")]
		void Retry (global::Com.Mopub.Volley.VolleyError p0);

	}

	[global::Android.Runtime.Register ("com/mopub/volley/RetryPolicy", DoNotGenerateAcw=true)]
	internal class IRetryPolicyInvoker : global::Java.Lang.Object, IRetryPolicy {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/volley/RetryPolicy");
		IntPtr class_ref;

		public static IRetryPolicy GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRetryPolicy> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mopub.volley.RetryPolicy"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRetryPolicyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IRetryPolicyInvoker); }
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
			global::Com.Mopub.Volley.IRetryPolicy __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.IRetryPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentRetryCount;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentRetryCount;
		public unsafe int CurrentRetryCount {
			get {
				if (id_getCurrentRetryCount == IntPtr.Zero)
					id_getCurrentRetryCount = JNIEnv.GetMethodID (class_ref, "getCurrentRetryCount", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getCurrentRetryCount);
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
			global::Com.Mopub.Volley.IRetryPolicy __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.IRetryPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentTimeout;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentTimeout;
		public unsafe int CurrentTimeout {
			get {
				if (id_getCurrentTimeout == IntPtr.Zero)
					id_getCurrentTimeout = JNIEnv.GetMethodID (class_ref, "getCurrentTimeout", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getCurrentTimeout);
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
			global::Com.Mopub.Volley.IRetryPolicy __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.IRetryPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.VolleyError p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.VolleyError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Retry (p0);
		}
#pragma warning restore 0169

		IntPtr id_retry_Lcom_mopub_volley_VolleyError_;
		public unsafe void Retry (global::Com.Mopub.Volley.VolleyError p0)
		{
			if (id_retry_Lcom_mopub_volley_VolleyError_ == IntPtr.Zero)
				id_retry_Lcom_mopub_volley_VolleyError_ = JNIEnv.GetMethodID (class_ref, "retry", "(Lcom/mopub/volley/VolleyError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_retry_Lcom_mopub_volley_VolleyError_, __args);
		}

	}

}
