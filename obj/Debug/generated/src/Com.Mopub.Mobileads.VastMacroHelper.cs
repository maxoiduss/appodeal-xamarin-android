using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastMacroHelper']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/VastMacroHelper", DoNotGenerateAcw=true)]
	public partial class VastMacroHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/VastMacroHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VastMacroHelper); }
		}

		protected VastMacroHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastMacroHelper']/constructor[@name='VastMacroHelper' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe VastMacroHelper (global::System.Collections.IList p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (VastMacroHelper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getUris;
#pragma warning disable 0169
		static Delegate GetGetUrisHandler ()
		{
			if (cb_getUris == null)
				cb_getUris = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUris);
			return cb_getUris;
		}

		static IntPtr n_GetUris (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastMacroHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastMacroHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.Uris);
		}
#pragma warning restore 0169

		static IntPtr id_getUris;
		public virtual unsafe global::System.Collections.IList Uris {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastMacroHelper']/method[@name='getUris' and count(parameter)=0]"
			[Register ("getUris", "()Ljava/util/List;", "GetGetUrisHandler")]
			get {
				if (id_getUris == IntPtr.Zero)
					id_getUris = JNIEnv.GetMethodID (class_ref, "getUris", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getUris), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUris", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_withAssetUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithAssetUri_Ljava_lang_String_Handler ()
		{
			if (cb_withAssetUri_Ljava_lang_String_ == null)
				cb_withAssetUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithAssetUri_Ljava_lang_String_);
			return cb_withAssetUri_Ljava_lang_String_;
		}

		static IntPtr n_WithAssetUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastMacroHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastMacroHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAssetUri (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withAssetUri_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastMacroHelper']/method[@name='withAssetUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withAssetUri", "(Ljava/lang/String;)Lcom/mopub/mobileads/VastMacroHelper;", "GetWithAssetUri_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mopub.Mobileads.VastMacroHelper WithAssetUri (string p0)
		{
			if (id_withAssetUri_Ljava_lang_String_ == IntPtr.Zero)
				id_withAssetUri_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withAssetUri", "(Ljava/lang/String;)Lcom/mopub/mobileads/VastMacroHelper;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mopub.Mobileads.VastMacroHelper __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastMacroHelper> (JNIEnv.CallObjectMethod  (Handle, id_withAssetUri_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastMacroHelper> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withAssetUri", "(Ljava/lang/String;)Lcom/mopub/mobileads/VastMacroHelper;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withContentPlayHead_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetWithContentPlayHead_Ljava_lang_Integer_Handler ()
		{
			if (cb_withContentPlayHead_Ljava_lang_Integer_ == null)
				cb_withContentPlayHead_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithContentPlayHead_Ljava_lang_Integer_);
			return cb_withContentPlayHead_Ljava_lang_Integer_;
		}

		static IntPtr n_WithContentPlayHead_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastMacroHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastMacroHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithContentPlayHead (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withContentPlayHead_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastMacroHelper']/method[@name='withContentPlayHead' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("withContentPlayHead", "(Ljava/lang/Integer;)Lcom/mopub/mobileads/VastMacroHelper;", "GetWithContentPlayHead_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Mopub.Mobileads.VastMacroHelper WithContentPlayHead (global::Java.Lang.Integer p0)
		{
			if (id_withContentPlayHead_Ljava_lang_Integer_ == IntPtr.Zero)
				id_withContentPlayHead_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "withContentPlayHead", "(Ljava/lang/Integer;)Lcom/mopub/mobileads/VastMacroHelper;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mopub.Mobileads.VastMacroHelper __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastMacroHelper> (JNIEnv.CallObjectMethod  (Handle, id_withContentPlayHead_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastMacroHelper> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withContentPlayHead", "(Ljava/lang/Integer;)Lcom/mopub/mobileads/VastMacroHelper;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withErrorCode_Lcom_mopub_mobileads_VastErrorCode_;
#pragma warning disable 0169
		static Delegate GetWithErrorCode_Lcom_mopub_mobileads_VastErrorCode_Handler ()
		{
			if (cb_withErrorCode_Lcom_mopub_mobileads_VastErrorCode_ == null)
				cb_withErrorCode_Lcom_mopub_mobileads_VastErrorCode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithErrorCode_Lcom_mopub_mobileads_VastErrorCode_);
			return cb_withErrorCode_Lcom_mopub_mobileads_VastErrorCode_;
		}

		static IntPtr n_WithErrorCode_Lcom_mopub_mobileads_VastErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastMacroHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastMacroHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.VastErrorCode p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastErrorCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithErrorCode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withErrorCode_Lcom_mopub_mobileads_VastErrorCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastMacroHelper']/method[@name='withErrorCode' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.VastErrorCode']]"
		[Register ("withErrorCode", "(Lcom/mopub/mobileads/VastErrorCode;)Lcom/mopub/mobileads/VastMacroHelper;", "GetWithErrorCode_Lcom_mopub_mobileads_VastErrorCode_Handler")]
		public virtual unsafe global::Com.Mopub.Mobileads.VastMacroHelper WithErrorCode (global::Com.Mopub.Mobileads.VastErrorCode p0)
		{
			if (id_withErrorCode_Lcom_mopub_mobileads_VastErrorCode_ == IntPtr.Zero)
				id_withErrorCode_Lcom_mopub_mobileads_VastErrorCode_ = JNIEnv.GetMethodID (class_ref, "withErrorCode", "(Lcom/mopub/mobileads/VastErrorCode;)Lcom/mopub/mobileads/VastMacroHelper;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mopub.Mobileads.VastMacroHelper __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastMacroHelper> (JNIEnv.CallObjectMethod  (Handle, id_withErrorCode_Lcom_mopub_mobileads_VastErrorCode_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastMacroHelper> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withErrorCode", "(Lcom/mopub/mobileads/VastErrorCode;)Lcom/mopub/mobileads/VastMacroHelper;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
