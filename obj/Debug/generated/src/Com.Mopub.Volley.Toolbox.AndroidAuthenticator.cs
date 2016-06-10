using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley.Toolbox {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='AndroidAuthenticator']"
	[global::Android.Runtime.Register ("com/mopub/volley/toolbox/AndroidAuthenticator", DoNotGenerateAcw=true)]
	public partial class AndroidAuthenticator : global::Java.Lang.Object, global::Com.Mopub.Volley.Toolbox.IAuthenticator {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/toolbox/AndroidAuthenticator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AndroidAuthenticator); }
		}

		protected AndroidAuthenticator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_accounts_Account_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='AndroidAuthenticator']/constructor[@name='AndroidAuthenticator' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.accounts.Account'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/accounts/Account;Ljava/lang/String;)V", "")]
		public unsafe AndroidAuthenticator (global::Android.Content.Context p0, global::Android.Accounts.Account p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (AndroidAuthenticator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/accounts/Account;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/accounts/Account;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_accounts_Account_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_accounts_Account_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/accounts/Account;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_accounts_Account_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_accounts_Account_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_accounts_Account_Ljava_lang_String_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='AndroidAuthenticator']/constructor[@name='AndroidAuthenticator' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.accounts.Account'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/accounts/Account;Ljava/lang/String;Z)V", "")]
		public unsafe AndroidAuthenticator (global::Android.Content.Context p0, global::Android.Accounts.Account p1, string p2, bool p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (AndroidAuthenticator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/accounts/Account;Ljava/lang/String;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/accounts/Account;Ljava/lang/String;Z)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_accounts_Account_Ljava_lang_String_Z == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_accounts_Account_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/accounts/Account;Ljava/lang/String;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_accounts_Account_Ljava_lang_String_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_accounts_Account_Ljava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getAccount;
#pragma warning disable 0169
		static Delegate GetGetAccountHandler ()
		{
			if (cb_getAccount == null)
				cb_getAccount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccount);
			return cb_getAccount;
		}

		static IntPtr n_GetAccount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Toolbox.AndroidAuthenticator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.AndroidAuthenticator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Account);
		}
#pragma warning restore 0169

		static IntPtr id_getAccount;
		public virtual unsafe global::Android.Accounts.Account Account {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='AndroidAuthenticator']/method[@name='getAccount' and count(parameter)=0]"
			[Register ("getAccount", "()Landroid/accounts/Account;", "GetGetAccountHandler")]
			get {
				if (id_getAccount == IntPtr.Zero)
					id_getAccount = JNIEnv.GetMethodID (class_ref, "getAccount", "()Landroid/accounts/Account;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Accounts.Account> (JNIEnv.CallObjectMethod  (Handle, id_getAccount), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Accounts.Account> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccount", "()Landroid/accounts/Account;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
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
			global::Com.Mopub.Volley.Toolbox.AndroidAuthenticator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.AndroidAuthenticator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthToken);
		}
#pragma warning restore 0169

		static IntPtr id_getAuthToken;
		public virtual unsafe string AuthToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='AndroidAuthenticator']/method[@name='getAuthToken' and count(parameter)=0]"
			[Register ("getAuthToken", "()Ljava/lang/String;", "GetGetAuthTokenHandler")]
			get {
				if (id_getAuthToken == IntPtr.Zero)
					id_getAuthToken = JNIEnv.GetMethodID (class_ref, "getAuthToken", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAuthToken), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Mopub.Volley.Toolbox.AndroidAuthenticator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.AndroidAuthenticator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InvalidateAuthToken (p0);
		}
#pragma warning restore 0169

		static IntPtr id_invalidateAuthToken_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='AndroidAuthenticator']/method[@name='invalidateAuthToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("invalidateAuthToken", "(Ljava/lang/String;)V", "GetInvalidateAuthToken_Ljava_lang_String_Handler")]
		public virtual unsafe void InvalidateAuthToken (string p0)
		{
			if (id_invalidateAuthToken_Ljava_lang_String_ == IntPtr.Zero)
				id_invalidateAuthToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "invalidateAuthToken", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_invalidateAuthToken_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invalidateAuthToken", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
