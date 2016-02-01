using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyError']"
	[global::Android.Runtime.Register ("com/mopub/volley/VolleyError", DoNotGenerateAcw=true)]
	public partial class VolleyError : global::Java.Lang.Exception {


		static IntPtr networkResponse_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyError']/field[@name='networkResponse']"
		[Register ("networkResponse")]
		public global::Com.Mopub.Volley.NetworkResponse NetworkResponse {
			get {
				if (networkResponse_jfieldId == IntPtr.Zero)
					networkResponse_jfieldId = JNIEnv.GetFieldID (class_ref, "networkResponse", "Lcom/mopub/volley/NetworkResponse;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, networkResponse_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.NetworkResponse> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (networkResponse_jfieldId == IntPtr.Zero)
					networkResponse_jfieldId = JNIEnv.GetFieldID (class_ref, "networkResponse", "Lcom/mopub/volley/NetworkResponse;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, networkResponse_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/VolleyError", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VolleyError); }
		}

		protected VolleyError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyError']/constructor[@name='VolleyError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/Throwable;)V", "")]
		public unsafe VolleyError (global::Java.Lang.Throwable p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (VolleyError)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Throwable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Throwable;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Throwable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyError']/constructor[@name='VolleyError' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe VolleyError (string p0, global::Java.Lang.Throwable p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (VolleyError)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/Throwable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/Throwable;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Throwable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyError']/constructor[@name='VolleyError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe VolleyError (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (VolleyError)) {
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

		static IntPtr id_ctor_Lcom_mopub_volley_NetworkResponse_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyError']/constructor[@name='VolleyError' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.NetworkResponse']]"
		[Register (".ctor", "(Lcom/mopub/volley/NetworkResponse;)V", "")]
		public unsafe VolleyError (global::Com.Mopub.Volley.NetworkResponse p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (VolleyError)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/volley/NetworkResponse;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/volley/NetworkResponse;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mopub_volley_NetworkResponse_ == IntPtr.Zero)
					id_ctor_Lcom_mopub_volley_NetworkResponse_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/volley/NetworkResponse;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_volley_NetworkResponse_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_volley_NetworkResponse_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyError']/constructor[@name='VolleyError' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VolleyError ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VolleyError)) {
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

		static Delegate cb_getNetworkTimeMs;
#pragma warning disable 0169
		static Delegate GetGetNetworkTimeMsHandler ()
		{
			if (cb_getNetworkTimeMs == null)
				cb_getNetworkTimeMs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNetworkTimeMs);
			return cb_getNetworkTimeMs;
		}

		static long n_GetNetworkTimeMs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.VolleyError __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.VolleyError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NetworkTimeMs;
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkTimeMs;
		public virtual unsafe long NetworkTimeMs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyError']/method[@name='getNetworkTimeMs' and count(parameter)=0]"
			[Register ("getNetworkTimeMs", "()J", "GetGetNetworkTimeMsHandler")]
			get {
				if (id_getNetworkTimeMs == IntPtr.Zero)
					id_getNetworkTimeMs = JNIEnv.GetMethodID (class_ref, "getNetworkTimeMs", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getNetworkTimeMs);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetworkTimeMs", "()J"));
				} finally {
				}
			}
		}

	}
}
