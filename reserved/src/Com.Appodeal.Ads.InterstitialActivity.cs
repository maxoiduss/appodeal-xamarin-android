using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appodeal.ads']/class[@name='InterstitialActivity']"
	[global::Android.Runtime.Register ("com/appodeal/ads/InterstitialActivity", DoNotGenerateAcw=true)]
	public partial class InterstitialActivity : global::Android.App.Activity {


		static IntPtr a_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='InterstitialActivity']/field[@name='a']"
		[Register ("a")]
		public global::Android.Widget.RelativeLayout A {
			get {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Landroid/widget/RelativeLayout;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, a_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.RelativeLayout> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Landroid/widget/RelativeLayout;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, a_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='InterstitialActivity']/field[@name='b']"
		[Register ("b")]
		public global::Android.Widget.ProgressBar B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Landroid/widget/ProgressBar;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, b_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ProgressBar> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Landroid/widget/ProgressBar;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, b_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/appodeal/ads/InterstitialActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InterstitialActivity); }
		}

		protected InterstitialActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.appodeal.ads']/class[@name='InterstitialActivity']/constructor[@name='InterstitialActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InterstitialActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (InterstitialActivity)) {
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

		static Delegate cb_onCreate_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreate_Landroid_os_Bundle_ == null)
				cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_os_Bundle_);
			return cb_onCreate_Landroid_os_Bundle_;
		}

		static void n_OnCreate_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Appodeal.Ads.InterstitialActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.InterstitialActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCreate_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='InterstitialActivity']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnCreate (global::Android.OS.Bundle p0)
		{
			if (id_onCreate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreate_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCreate_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.InterstitialActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.InterstitialActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='InterstitialActivity']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual unsafe void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDestroy);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDestroy", "()V"));
			} finally {
			}
		}

	}
}
