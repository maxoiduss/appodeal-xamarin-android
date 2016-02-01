using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley.Toolbox {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.volley.toolbox']/interface[@name='Authenticator']"
	[Register ("com/mopub/volley/toolbox/Authenticator", "", "Com.Mopub.Volley.Toolbox.IAuthenticatorInvoker")]
	public partial interface IAuthenticator : IJavaObject {

		string AuthToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/interface[@name='Authenticator']/method[@name='getAuthToken' and count(parameter)=0]"
			[Register ("getAuthToken", "()Ljava/lang/String;", "GetGetAuthTokenHandler:Com.Mopub.Volley.Toolbox.IAuthenticatorInvoker, AppodealXamarinPlugin")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/interface[@name='Authenticator']/method[@name='invalidateAuthToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("invalidateAuthToken", "(Ljava/lang/String;)V", "GetInvalidateAuthToken_Ljava_lang_String_Handler:Com.Mopub.Volley.Toolbox.IAuthenticatorInvoker, AppodealXamarinPlugin")]
		void InvalidateAuthToken (string p0);

	}

	[global::Android.Runtime.Register ("com/mopub/volley/toolbox/Authenticator", DoNotGenerateAcw=true)]
	internal class IAuthenticatorInvoker : global::Java.Lang.Object, IAuthenticator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/volley/toolbox/Authenticator");
		IntPtr class_ref;

		public static IAuthenticator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAuthenticator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mopub.volley.toolbox.Authenticator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAuthenticatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAuthenticatorInvoker); }
		}

		static Delegate cb_getAuthToken;
#pragma warning disable 0169
		static Delegate GetGetAuthTokenHandler ()
		{
			if (cb_getAuthToken == null)
				cb_getAuthToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthToken);
			return cb_getAuthToken;
		}

		static IntPtr n_GetAuthToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Toolbox.IAuthenticator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.IAuthenticator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthToken);
		}
#pragma warning restore 0169

		IntPtr id_getAuthToken;
		public unsafe string AuthToken {
			get {
				if (id_getAuthToken == IntPtr.Zero)
					id_getAuthToken = JNIEnv.GetMethodID (class_ref, "getAuthToken", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getAuthToken), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_invalidateAuthToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvalidateAuthToken_Ljava_lang_String_Handler ()
		{
			if (cb_invalidateAuthToken_Ljava_lang_String_ == null)
				cb_invalidateAuthToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InvalidateAuthToken_Ljava_lang_String_);
			return cb_invalidateAuthToken_Ljava_lang_String_;
		}

		static void n_InvalidateAuthToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Toolbox.IAuthenticator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.IAuthenticator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InvalidateAuthToken (p0);
		}
#pragma warning restore 0169

		IntPtr id_invalidateAuthToken_Ljava_lang_String_;
		public unsafe void InvalidateAuthToken (string p0)
		{
			if (id_invalidateAuthToken_Ljava_lang_String_ == IntPtr.Zero)
				id_invalidateAuthToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "invalidateAuthToken", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_invalidateAuthToken_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
