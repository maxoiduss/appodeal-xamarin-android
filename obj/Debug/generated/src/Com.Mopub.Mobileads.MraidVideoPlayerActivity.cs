using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidVideoPlayerActivity']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/MraidVideoPlayerActivity", DoNotGenerateAcw=true)]
	public partial class MraidVideoPlayerActivity : global::Com.Mopub.Mobileads.BaseVideoPlayerActivity, global::Com.Mopub.Mobileads.BaseVideoViewController.IBaseVideoViewControllerListener {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/MraidVideoPlayerActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MraidVideoPlayerActivity); }
		}

		protected MraidVideoPlayerActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidVideoPlayerActivity']/constructor[@name='MraidVideoPlayerActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MraidVideoPlayerActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MraidVideoPlayerActivity)) {
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

		static IntPtr id_getBroadcastIdentifierFromIntent_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidVideoPlayerActivity']/method[@name='getBroadcastIdentifierFromIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("getBroadcastIdentifierFromIntent", "(Landroid/content/Intent;)J", "")]
		protected static unsafe long GetBroadcastIdentifierFromIntent (global::Android.Content.Intent p0)
		{
			if (id_getBroadcastIdentifierFromIntent_Landroid_content_Intent_ == IntPtr.Zero)
				id_getBroadcastIdentifierFromIntent_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "getBroadcastIdentifierFromIntent", "(Landroid/content/Intent;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getBroadcastIdentifierFromIntent_Landroid_content_Intent_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onFinish;
#pragma warning disable 0169
		static Delegate GetOnFinishHandler ()
		{
			if (cb_onFinish == null)
				cb_onFinish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFinish);
			return cb_onFinish;
		}

		static void n_OnFinish (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MraidVideoPlayerActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidVideoPlayerActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFinish ();
		}
#pragma warning restore 0169

		static IntPtr id_onFinish;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidVideoPlayerActivity']/method[@name='onFinish' and count(parameter)=0]"
		[Register ("onFinish", "()V", "GetOnFinishHandler")]
		public virtual unsafe void OnFinish ()
		{
			if (id_onFinish == IntPtr.Zero)
				id_onFinish = JNIEnv.GetMethodID (class_ref, "onFinish", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onFinish);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFinish", "()V"));
			} finally {
			}
		}

		static Delegate cb_onSetContentView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnSetContentView_Landroid_view_View_Handler ()
		{
			if (cb_onSetContentView_Landroid_view_View_ == null)
				cb_onSetContentView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSetContentView_Landroid_view_View_);
			return cb_onSetContentView_Landroid_view_View_;
		}

		static void n_OnSetContentView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MraidVideoPlayerActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidVideoPlayerActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSetContentView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSetContentView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidVideoPlayerActivity']/method[@name='onSetContentView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onSetContentView", "(Landroid/view/View;)V", "GetOnSetContentView_Landroid_view_View_Handler")]
		public virtual unsafe void OnSetContentView (global::Android.Views.View p0)
		{
			if (id_onSetContentView_Landroid_view_View_ == IntPtr.Zero)
				id_onSetContentView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onSetContentView", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onSetContentView_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSetContentView", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSetRequestedOrientation_I;
#pragma warning disable 0169
		static Delegate GetOnSetRequestedOrientation_IHandler ()
		{
			if (cb_onSetRequestedOrientation_I == null)
				cb_onSetRequestedOrientation_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnSetRequestedOrientation_I);
			return cb_onSetRequestedOrientation_I;
		}

		static void n_OnSetRequestedOrientation_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Mobileads.MraidVideoPlayerActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidVideoPlayerActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSetRequestedOrientation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSetRequestedOrientation_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidVideoPlayerActivity']/method[@name='onSetRequestedOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onSetRequestedOrientation", "(I)V", "GetOnSetRequestedOrientation_IHandler")]
		public virtual unsafe void OnSetRequestedOrientation (int p0)
		{
			if (id_onSetRequestedOrientation_I == IntPtr.Zero)
				id_onSetRequestedOrientation_I = JNIEnv.GetMethodID (class_ref, "onSetRequestedOrientation", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onSetRequestedOrientation_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSetRequestedOrientation", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_Handler ()
		{
			if (cb_onStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_ == null)
				cb_onStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_);
			return cb_onStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_;
		}

		static void n_OnStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Mopub.Mobileads.MraidVideoPlayerActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidVideoPlayerActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnStartActivityForResult (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidVideoPlayerActivity']/method[@name='onStartActivityForResult' and count(parameter)=3 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='int'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("onStartActivityForResult", "(Ljava/lang/Class;ILandroid/os/Bundle;)V", "GetOnStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_Handler")]
		public virtual unsafe void OnStartActivityForResult (global::Java.Lang.Class p0, int p1, global::Android.OS.Bundle p2)
		{
			if (id_onStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_ == IntPtr.Zero)
				id_onStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onStartActivityForResult", "(Ljava/lang/Class;ILandroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStartActivityForResult", "(Ljava/lang/Class;ILandroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

	}
}
