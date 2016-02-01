using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley']/class[@name='AuthFailureError']"
	[global::Android.Runtime.Register ("com/mopub/volley/AuthFailureError", DoNotGenerateAcw=true)]
	public partial class AuthFailureError : global::Com.Mopub.Volley.VolleyError {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/AuthFailureError", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthFailureError); }
		}

		protected AuthFailureError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Exception_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='AuthFailureError']/constructor[@name='AuthFailureError' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Exception']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Exception;)V", "")]
		public unsafe AuthFailureError (string p0, global::Java.Lang.Exception p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (AuthFailureError)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/Exception;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/Exception;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Exception;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Exception_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Exception_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='AuthFailureError']/constructor[@name='AuthFailureError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe AuthFailureError (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (AuthFailureError)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='AuthFailureError']/constructor[@name='AuthFailureError' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.NetworkResponse']]"
		[Register (".ctor", "(Lcom/mopub/volley/NetworkResponse;)V", "")]
		public unsafe AuthFailureError (global::Com.Mopub.Volley.NetworkResponse p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AuthFailureError)) {
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

		static IntPtr id_ctor_Landroid_content_Intent_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='AuthFailureError']/constructor[@name='AuthFailureError' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register (".ctor", "(Landroid/content/Intent;)V", "")]
		public unsafe AuthFailureError (global::Android.Content.Intent p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AuthFailureError)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Intent;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Intent;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Intent_ == IntPtr.Zero)
					id_ctor_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Intent;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Intent_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Intent_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='AuthFailureError']/constructor[@name='AuthFailureError' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AuthFailureError ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AuthFailureError)) {
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

		static Delegate cb_getResolutionIntent;
#pragma warning disable 0169
		static Delegate GetGetResolutionIntentHandler ()
		{
			if (cb_getResolutionIntent == null)
				cb_getResolutionIntent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResolutionIntent);
			return cb_getResolutionIntent;
		}

		static IntPtr n_GetResolutionIntent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.AuthFailureError __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.AuthFailureError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResolutionIntent);
		}
#pragma warning restore 0169

		static IntPtr id_getResolutionIntent;
		public virtual unsafe global::Android.Content.Intent ResolutionIntent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='AuthFailureError']/method[@name='getResolutionIntent' and count(parameter)=0]"
			[Register ("getResolutionIntent", "()Landroid/content/Intent;", "GetGetResolutionIntentHandler")]
			get {
				if (id_getResolutionIntent == IntPtr.Zero)
					id_getResolutionIntent = JNIEnv.GetMethodID (class_ref, "getResolutionIntent", "()Landroid/content/Intent;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod  (Handle, id_getResolutionIntent), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResolutionIntent", "()Landroid/content/Intent;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
