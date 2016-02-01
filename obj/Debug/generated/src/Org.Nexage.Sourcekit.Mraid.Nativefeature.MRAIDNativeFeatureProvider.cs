using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Mraid.Nativefeature {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.mraid.nativefeature']/class[@name='MRAIDNativeFeatureProvider']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/mraid/nativefeature/MRAIDNativeFeatureProvider", DoNotGenerateAcw=true)]
	public partial class MRAIDNativeFeatureProvider : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/mraid/nativefeature/MRAIDNativeFeatureProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MRAIDNativeFeatureProvider); }
		}

		protected MRAIDNativeFeatureProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lorg_nexage_sourcekit_mraid_internal_MRAIDNativeFeatureManager_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.mraid.nativefeature']/class[@name='MRAIDNativeFeatureProvider']/constructor[@name='MRAIDNativeFeatureProvider' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.nexage.sourcekit.mraid.internal.MRAIDNativeFeatureManager']]"
		[Register (".ctor", "(Landroid/content/Context;Lorg/nexage/sourcekit/mraid/internal/MRAIDNativeFeatureManager;)V", "")]
		public unsafe MRAIDNativeFeatureProvider (global::Android.Content.Context p0, global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDNativeFeatureManager p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (MRAIDNativeFeatureProvider)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lorg/nexage/sourcekit/mraid/internal/MRAIDNativeFeatureManager;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lorg/nexage/sourcekit/mraid/internal/MRAIDNativeFeatureManager;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lorg_nexage_sourcekit_mraid_internal_MRAIDNativeFeatureManager_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lorg_nexage_sourcekit_mraid_internal_MRAIDNativeFeatureManager_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lorg/nexage/sourcekit/mraid/internal/MRAIDNativeFeatureManager;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lorg_nexage_sourcekit_mraid_internal_MRAIDNativeFeatureManager_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lorg_nexage_sourcekit_mraid_internal_MRAIDNativeFeatureManager_, __args);
			} finally {
			}
		}

		static IntPtr id_callTel_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.nativefeature']/class[@name='MRAIDNativeFeatureProvider']/method[@name='callTel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("callTel", "(Ljava/lang/String;)V", "")]
		public unsafe void CallTel (string p0)
		{
			if (id_callTel_Ljava_lang_String_ == IntPtr.Zero)
				id_callTel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "callTel", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_callTel_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_createCalendarEvent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateCalendarEvent_Ljava_lang_String_Handler ()
		{
			if (cb_createCalendarEvent_Ljava_lang_String_ == null)
				cb_createCalendarEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CreateCalendarEvent_Ljava_lang_String_);
			return cb_createCalendarEvent_Ljava_lang_String_;
		}

		static void n_CreateCalendarEvent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Mraid.Nativefeature.MRAIDNativeFeatureProvider __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.Nativefeature.MRAIDNativeFeatureProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreateCalendarEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_createCalendarEvent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.nativefeature']/class[@name='MRAIDNativeFeatureProvider']/method[@name='createCalendarEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createCalendarEvent", "(Ljava/lang/String;)V", "GetCreateCalendarEvent_Ljava_lang_String_Handler")]
		public virtual unsafe void CreateCalendarEvent (string p0)
		{
			if (id_createCalendarEvent_Ljava_lang_String_ == IntPtr.Zero)
				id_createCalendarEvent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createCalendarEvent", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_createCalendarEvent_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createCalendarEvent", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_openBrowser_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpenBrowser_Ljava_lang_String_Handler ()
		{
			if (cb_openBrowser_Ljava_lang_String_ == null)
				cb_openBrowser_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OpenBrowser_Ljava_lang_String_);
			return cb_openBrowser_Ljava_lang_String_;
		}

		static void n_OpenBrowser_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Mraid.Nativefeature.MRAIDNativeFeatureProvider __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.Nativefeature.MRAIDNativeFeatureProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OpenBrowser (p0);
		}
#pragma warning restore 0169

		static IntPtr id_openBrowser_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.nativefeature']/class[@name='MRAIDNativeFeatureProvider']/method[@name='openBrowser' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("openBrowser", "(Ljava/lang/String;)V", "GetOpenBrowser_Ljava_lang_String_Handler")]
		public virtual unsafe void OpenBrowser (string p0)
		{
			if (id_openBrowser_Ljava_lang_String_ == IntPtr.Zero)
				id_openBrowser_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "openBrowser", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_openBrowser_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openBrowser", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_playVideo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPlayVideo_Ljava_lang_String_Handler ()
		{
			if (cb_playVideo_Ljava_lang_String_ == null)
				cb_playVideo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PlayVideo_Ljava_lang_String_);
			return cb_playVideo_Ljava_lang_String_;
		}

		static void n_PlayVideo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Mraid.Nativefeature.MRAIDNativeFeatureProvider __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.Nativefeature.MRAIDNativeFeatureProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PlayVideo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_playVideo_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.nativefeature']/class[@name='MRAIDNativeFeatureProvider']/method[@name='playVideo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("playVideo", "(Ljava/lang/String;)V", "GetPlayVideo_Ljava_lang_String_Handler")]
		public virtual unsafe void PlayVideo (string p0)
		{
			if (id_playVideo_Ljava_lang_String_ == IntPtr.Zero)
				id_playVideo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "playVideo", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_playVideo_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "playVideo", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendSms_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendSms_Ljava_lang_String_Handler ()
		{
			if (cb_sendSms_Ljava_lang_String_ == null)
				cb_sendSms_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendSms_Ljava_lang_String_);
			return cb_sendSms_Ljava_lang_String_;
		}

		static void n_SendSms_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Mraid.Nativefeature.MRAIDNativeFeatureProvider __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.Nativefeature.MRAIDNativeFeatureProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendSms (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendSms_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.nativefeature']/class[@name='MRAIDNativeFeatureProvider']/method[@name='sendSms' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sendSms", "(Ljava/lang/String;)V", "GetSendSms_Ljava_lang_String_Handler")]
		public virtual unsafe void SendSms (string p0)
		{
			if (id_sendSms_Ljava_lang_String_ == IntPtr.Zero)
				id_sendSms_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendSms", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_sendSms_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendSms", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_storePicture_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStorePicture_Ljava_lang_String_Handler ()
		{
			if (cb_storePicture_Ljava_lang_String_ == null)
				cb_storePicture_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StorePicture_Ljava_lang_String_);
			return cb_storePicture_Ljava_lang_String_;
		}

		static void n_StorePicture_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Mraid.Nativefeature.MRAIDNativeFeatureProvider __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.Nativefeature.MRAIDNativeFeatureProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StorePicture (p0);
		}
#pragma warning restore 0169

		static IntPtr id_storePicture_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.nativefeature']/class[@name='MRAIDNativeFeatureProvider']/method[@name='storePicture' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("storePicture", "(Ljava/lang/String;)V", "GetStorePicture_Ljava_lang_String_Handler")]
		public virtual unsafe void StorePicture (string p0)
		{
			if (id_storePicture_Ljava_lang_String_ == IntPtr.Zero)
				id_storePicture_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "storePicture", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_storePicture_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "storePicture", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
