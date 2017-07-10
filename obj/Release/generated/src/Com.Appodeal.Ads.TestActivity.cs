using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']"
	[global::Android.Runtime.Register ("com/appodeal/ads/TestActivity", DoNotGenerateAcw=true)]
	public partial class TestActivity : global::Android.App.Activity, global::Com.Appodeal.Ads.IBannerCallbacks, global::Com.Appodeal.Ads.IInterstitialCallbacks, global::Com.Appodeal.Ads.IMrecCallbacks, global::Com.Appodeal.Ads.INativeCallbacks, global::Com.Appodeal.Ads.IRewardedVideoCallbacks {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/appodeal/ads/TestActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TestActivity); }
		}

		protected TestActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/constructor[@name='TestActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TestActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TestActivity)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_A);
			return cb_a;
		}

		static void n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A ();
		}
#pragma warning restore 0169

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "GetAHandler")]
		public virtual unsafe void A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "()V"));
			} finally {
			}
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_B);
			return cb_b;
		}

		static void n_B (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.B ();
		}
#pragma warning restore 0169

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "GetBHandler")]
		public virtual unsafe void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_b);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "()V"));
			} finally {
			}
		}

		static Delegate cb_onBannerClicked;
#pragma warning disable 0169
		static Delegate GetOnBannerClickedHandler ()
		{
			if (cb_onBannerClicked == null)
				cb_onBannerClicked = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBannerClicked);
			return cb_onBannerClicked;
		}

		static void n_OnBannerClicked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerClicked ();
		}
#pragma warning restore 0169

		static IntPtr id_onBannerClicked;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='onBannerClicked' and count(parameter)=0]"
		[Register ("onBannerClicked", "()V", "GetOnBannerClickedHandler")]
		public virtual unsafe void OnBannerClicked ()
		{
			if (id_onBannerClicked == IntPtr.Zero)
				id_onBannerClicked = JNIEnv.GetMethodID (class_ref, "onBannerClicked", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerClicked);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBannerClicked", "()V"));
			} finally {
			}
		}

		static Delegate cb_onBannerFailedToLoad;
#pragma warning disable 0169
		static Delegate GetOnBannerFailedToLoadHandler ()
		{
			if (cb_onBannerFailedToLoad == null)
				cb_onBannerFailedToLoad = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBannerFailedToLoad);
			return cb_onBannerFailedToLoad;
		}

		static void n_OnBannerFailedToLoad (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerFailedToLoad ();
		}
#pragma warning restore 0169

		static IntPtr id_onBannerFailedToLoad;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='onBannerFailedToLoad' and count(parameter)=0]"
		[Register ("onBannerFailedToLoad", "()V", "GetOnBannerFailedToLoadHandler")]
		public virtual unsafe void OnBannerFailedToLoad ()
		{
			if (id_onBannerFailedToLoad == IntPtr.Zero)
				id_onBannerFailedToLoad = JNIEnv.GetMethodID (class_ref, "onBannerFailedToLoad", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerFailedToLoad);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBannerFailedToLoad", "()V"));
			} finally {
			}
		}

		static Delegate cb_onBannerLoaded_IZ;
#pragma warning disable 0169
		static Delegate GetOnBannerLoaded_IZHandler ()
		{
			if (cb_onBannerLoaded_IZ == null)
				cb_onBannerLoaded_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_OnBannerLoaded_IZ);
			return cb_onBannerLoaded_IZ;
		}

		static void n_OnBannerLoaded_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerLoaded (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onBannerLoaded_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='onBannerLoaded' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("onBannerLoaded", "(IZ)V", "GetOnBannerLoaded_IZHandler")]
		public virtual unsafe void OnBannerLoaded (int p0, bool p1)
		{
			if (id_onBannerLoaded_IZ == IntPtr.Zero)
				id_onBannerLoaded_IZ = JNIEnv.GetMethodID (class_ref, "onBannerLoaded", "(IZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerLoaded_IZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBannerLoaded", "(IZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onBannerShown;
#pragma warning disable 0169
		static Delegate GetOnBannerShownHandler ()
		{
			if (cb_onBannerShown == null)
				cb_onBannerShown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBannerShown);
			return cb_onBannerShown;
		}

		static void n_OnBannerShown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerShown ();
		}
#pragma warning restore 0169

		static IntPtr id_onBannerShown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='onBannerShown' and count(parameter)=0]"
		[Register ("onBannerShown", "()V", "GetOnBannerShownHandler")]
		public virtual unsafe void OnBannerShown ()
		{
			if (id_onBannerShown == IntPtr.Zero)
				id_onBannerShown = JNIEnv.GetMethodID (class_ref, "onBannerShown", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerShown);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBannerShown", "()V"));
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
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCreate_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnCreate (global::Android.OS.Bundle p0)
		{
			if (id_onCreate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreate_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreate_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onInterstitialClicked;
#pragma warning disable 0169
		static Delegate GetOnInterstitialClickedHandler ()
		{
			if (cb_onInterstitialClicked == null)
				cb_onInterstitialClicked = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialClicked);
			return cb_onInterstitialClicked;
		}

		static void n_OnInterstitialClicked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialClicked ();
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialClicked;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='onInterstitialClicked' and count(parameter)=0]"
		[Register ("onInterstitialClicked", "()V", "GetOnInterstitialClickedHandler")]
		public virtual unsafe void OnInterstitialClicked ()
		{
			if (id_onInterstitialClicked == IntPtr.Zero)
				id_onInterstitialClicked = JNIEnv.GetMethodID (class_ref, "onInterstitialClicked", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialClicked);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialClicked", "()V"));
			} finally {
			}
		}

		static Delegate cb_onInterstitialClosed;
#pragma warning disable 0169
		static Delegate GetOnInterstitialClosedHandler ()
		{
			if (cb_onInterstitialClosed == null)
				cb_onInterstitialClosed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialClosed);
			return cb_onInterstitialClosed;
		}

		static void n_OnInterstitialClosed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialClosed ();
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialClosed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='onInterstitialClosed' and count(parameter)=0]"
		[Register ("onInterstitialClosed", "()V", "GetOnInterstitialClosedHandler")]
		public virtual unsafe void OnInterstitialClosed ()
		{
			if (id_onInterstitialClosed == IntPtr.Zero)
				id_onInterstitialClosed = JNIEnv.GetMethodID (class_ref, "onInterstitialClosed", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialClosed);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialClosed", "()V"));
			} finally {
			}
		}

		static Delegate cb_onInterstitialFailedToLoad;
#pragma warning disable 0169
		static Delegate GetOnInterstitialFailedToLoadHandler ()
		{
			if (cb_onInterstitialFailedToLoad == null)
				cb_onInterstitialFailedToLoad = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialFailedToLoad);
			return cb_onInterstitialFailedToLoad;
		}

		static void n_OnInterstitialFailedToLoad (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialFailedToLoad ();
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialFailedToLoad;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='onInterstitialFailedToLoad' and count(parameter)=0]"
		[Register ("onInterstitialFailedToLoad", "()V", "GetOnInterstitialFailedToLoadHandler")]
		public virtual unsafe void OnInterstitialFailedToLoad ()
		{
			if (id_onInterstitialFailedToLoad == IntPtr.Zero)
				id_onInterstitialFailedToLoad = JNIEnv.GetMethodID (class_ref, "onInterstitialFailedToLoad", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialFailedToLoad);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialFailedToLoad", "()V"));
			} finally {
			}
		}

		static Delegate cb_onInterstitialLoaded_Z;
#pragma warning disable 0169
		static Delegate GetOnInterstitialLoaded_ZHandler ()
		{
			if (cb_onInterstitialLoaded_Z == null)
				cb_onInterstitialLoaded_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnInterstitialLoaded_Z);
			return cb_onInterstitialLoaded_Z;
		}

		static void n_OnInterstitialLoaded_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialLoaded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialLoaded_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='onInterstitialLoaded' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onInterstitialLoaded", "(Z)V", "GetOnInterstitialLoaded_ZHandler")]
		public virtual unsafe void OnInterstitialLoaded (bool p0)
		{
			if (id_onInterstitialLoaded_Z == IntPtr.Zero)
				id_onInterstitialLoaded_Z = JNIEnv.GetMethodID (class_ref, "onInterstitialLoaded", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialLoaded_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialLoaded", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onInterstitialShown;
#pragma warning disable 0169
		static Delegate GetOnInterstitialShownHandler ()
		{
			if (cb_onInterstitialShown == null)
				cb_onInterstitialShown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialShown);
			return cb_onInterstitialShown;
		}

		static void n_OnInterstitialShown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialShown ();
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialShown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='onInterstitialShown' and count(parameter)=0]"
		[Register ("onInterstitialShown", "()V", "GetOnInterstitialShownHandler")]
		public virtual unsafe void OnInterstitialShown ()
		{
			if (id_onInterstitialShown == IntPtr.Zero)
				id_onInterstitialShown = JNIEnv.GetMethodID (class_ref, "onInterstitialShown", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialShown);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialShown", "()V"));
			} finally {
			}
		}

		static Delegate cb_onMrecClicked;
#pragma warning disable 0169
		static Delegate GetOnMrecClickedHandler ()
		{
			if (cb_onMrecClicked == null)
				cb_onMrecClicked = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMrecClicked);
			return cb_onMrecClicked;
		}

		static void n_OnMrecClicked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMrecClicked ();
		}
#pragma warning restore 0169

		static IntPtr id_onMrecClicked;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='onMrecClicked' and count(parameter)=0]"
		[Register ("onMrecClicked", "()V", "GetOnMrecClickedHandler")]
		public virtual unsafe void OnMrecClicked ()
		{
			if (id_onMrecClicked == IntPtr.Zero)
				id_onMrecClicked = JNIEnv.GetMethodID (class_ref, "onMrecClicked", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMrecClicked);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMrecClicked", "()V"));
			} finally {
			}
		}

		static Delegate cb_onMrecFailedToLoad;
#pragma warning disable 0169
		static Delegate GetOnMrecFailedToLoadHandler ()
		{
			if (cb_onMrecFailedToLoad == null)
				cb_onMrecFailedToLoad = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMrecFailedToLoad);
			return cb_onMrecFailedToLoad;
		}

		static void n_OnMrecFailedToLoad (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMrecFailedToLoad ();
		}
#pragma warning restore 0169

		static IntPtr id_onMrecFailedToLoad;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='onMrecFailedToLoad' and count(parameter)=0]"
		[Register ("onMrecFailedToLoad", "()V", "GetOnMrecFailedToLoadHandler")]
		public virtual unsafe void OnMrecFailedToLoad ()
		{
			if (id_onMrecFailedToLoad == IntPtr.Zero)
				id_onMrecFailedToLoad = JNIEnv.GetMethodID (class_ref, "onMrecFailedToLoad", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMrecFailedToLoad);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMrecFailedToLoad", "()V"));
			} finally {
			}
		}

		static Delegate cb_onMrecLoaded_Z;
#pragma warning disable 0169
		static Delegate GetOnMrecLoaded_ZHandler ()
		{
			if (cb_onMrecLoaded_Z == null)
				cb_onMrecLoaded_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnMrecLoaded_Z);
			return cb_onMrecLoaded_Z;
		}

		static void n_OnMrecLoaded_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMrecLoaded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onMrecLoaded_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='onMrecLoaded' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onMrecLoaded", "(Z)V", "GetOnMrecLoaded_ZHandler")]
		public virtual unsafe void OnMrecLoaded (bool p0)
		{
			if (id_onMrecLoaded_Z == IntPtr.Zero)
				id_onMrecLoaded_Z = JNIEnv.GetMethodID (class_ref, "onMrecLoaded", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMrecLoaded_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMrecLoaded", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onMrecShown;
#pragma warning disable 0169
		static Delegate GetOnMrecShownHandler ()
		{
			if (cb_onMrecShown == null)
				cb_onMrecShown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMrecShown);
			return cb_onMrecShown;
		}

		static void n_OnMrecShown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMrecShown ();
		}
#pragma warning restore 0169

		static IntPtr id_onMrecShown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='onMrecShown' and count(parameter)=0]"
		[Register ("onMrecShown", "()V", "GetOnMrecShownHandler")]
		public virtual unsafe void OnMrecShown ()
		{
			if (id_onMrecShown == IntPtr.Zero)
				id_onMrecShown = JNIEnv.GetMethodID (class_ref, "onMrecShown", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMrecShown);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMrecShown", "()V"));
			} finally {
			}
		}

		static Delegate cb_onNativeClicked_Lcom_appodeal_ads_NativeAd_;
#pragma warning disable 0169
		static Delegate GetOnNativeClicked_Lcom_appodeal_ads_NativeAd_Handler ()
		{
			if (cb_onNativeClicked_Lcom_appodeal_ads_NativeAd_ == null)
				cb_onNativeClicked_Lcom_appodeal_ads_NativeAd_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNativeClicked_Lcom_appodeal_ads_NativeAd_);
			return cb_onNativeClicked_Lcom_appodeal_ads_NativeAd_;
		}

		static void n_OnNativeClicked_Lcom_appodeal_ads_NativeAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Appodeal.Ads.INativeAd p0 = (global::Com.Appodeal.Ads.INativeAd)global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeAd> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNativeClicked (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onNativeClicked_Lcom_appodeal_ads_NativeAd_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='onNativeClicked' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.NativeAd']]"
		[Register ("onNativeClicked", "(Lcom/appodeal/ads/NativeAd;)V", "GetOnNativeClicked_Lcom_appodeal_ads_NativeAd_Handler")]
		public virtual unsafe void OnNativeClicked (global::Com.Appodeal.Ads.INativeAd p0)
		{
			if (id_onNativeClicked_Lcom_appodeal_ads_NativeAd_ == IntPtr.Zero)
				id_onNativeClicked_Lcom_appodeal_ads_NativeAd_ = JNIEnv.GetMethodID (class_ref, "onNativeClicked", "(Lcom/appodeal/ads/NativeAd;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeClicked_Lcom_appodeal_ads_NativeAd_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNativeClicked", "(Lcom/appodeal/ads/NativeAd;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onNativeFailedToLoad;
#pragma warning disable 0169
		static Delegate GetOnNativeFailedToLoadHandler ()
		{
			if (cb_onNativeFailedToLoad == null)
				cb_onNativeFailedToLoad = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnNativeFailedToLoad);
			return cb_onNativeFailedToLoad;
		}

		static void n_OnNativeFailedToLoad (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNativeFailedToLoad ();
		}
#pragma warning restore 0169

		static IntPtr id_onNativeFailedToLoad;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='onNativeFailedToLoad' and count(parameter)=0]"
		[Register ("onNativeFailedToLoad", "()V", "GetOnNativeFailedToLoadHandler")]
		public virtual unsafe void OnNativeFailedToLoad ()
		{
			if (id_onNativeFailedToLoad == IntPtr.Zero)
				id_onNativeFailedToLoad = JNIEnv.GetMethodID (class_ref, "onNativeFailedToLoad", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeFailedToLoad);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNativeFailedToLoad", "()V"));
			} finally {
			}
		}

		static Delegate cb_onNativeLoaded;
#pragma warning disable 0169
		static Delegate GetOnNativeLoadedHandler ()
		{
			if (cb_onNativeLoaded == null)
				cb_onNativeLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnNativeLoaded);
			return cb_onNativeLoaded;
		}

		static void n_OnNativeLoaded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNativeLoaded ();
		}
#pragma warning restore 0169

		static IntPtr id_onNativeLoaded;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='onNativeLoaded' and count(parameter)=0]"
		[Register ("onNativeLoaded", "()V", "GetOnNativeLoadedHandler")]
		public virtual unsafe void OnNativeLoaded ()
		{
			if (id_onNativeLoaded == IntPtr.Zero)
				id_onNativeLoaded = JNIEnv.GetMethodID (class_ref, "onNativeLoaded", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeLoaded);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNativeLoaded", "()V"));
			} finally {
			}
		}

		static Delegate cb_onNativeShown_Lcom_appodeal_ads_NativeAd_;
#pragma warning disable 0169
		static Delegate GetOnNativeShown_Lcom_appodeal_ads_NativeAd_Handler ()
		{
			if (cb_onNativeShown_Lcom_appodeal_ads_NativeAd_ == null)
				cb_onNativeShown_Lcom_appodeal_ads_NativeAd_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNativeShown_Lcom_appodeal_ads_NativeAd_);
			return cb_onNativeShown_Lcom_appodeal_ads_NativeAd_;
		}

		static void n_OnNativeShown_Lcom_appodeal_ads_NativeAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Appodeal.Ads.INativeAd p0 = (global::Com.Appodeal.Ads.INativeAd)global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeAd> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNativeShown (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onNativeShown_Lcom_appodeal_ads_NativeAd_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='onNativeShown' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.NativeAd']]"
		[Register ("onNativeShown", "(Lcom/appodeal/ads/NativeAd;)V", "GetOnNativeShown_Lcom_appodeal_ads_NativeAd_Handler")]
		public virtual unsafe void OnNativeShown (global::Com.Appodeal.Ads.INativeAd p0)
		{
			if (id_onNativeShown_Lcom_appodeal_ads_NativeAd_ == IntPtr.Zero)
				id_onNativeShown_Lcom_appodeal_ads_NativeAd_ = JNIEnv.GetMethodID (class_ref, "onNativeShown", "(Lcom/appodeal/ads/NativeAd;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeShown_Lcom_appodeal_ads_NativeAd_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNativeShown", "(Lcom/appodeal/ads/NativeAd;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResume);
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		static IntPtr id_onResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler")]
		public virtual unsafe void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResume);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResume", "()V"));
			} finally {
			}
		}

		static Delegate cb_onRewardedVideoClosed_Z;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoClosed_ZHandler ()
		{
			if (cb_onRewardedVideoClosed_Z == null)
				cb_onRewardedVideoClosed_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnRewardedVideoClosed_Z);
			return cb_onRewardedVideoClosed_Z;
		}

		static void n_OnRewardedVideoClosed_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoClosed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRewardedVideoClosed_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='onRewardedVideoClosed' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onRewardedVideoClosed", "(Z)V", "GetOnRewardedVideoClosed_ZHandler")]
		public virtual unsafe void OnRewardedVideoClosed (bool p0)
		{
			if (id_onRewardedVideoClosed_Z == IntPtr.Zero)
				id_onRewardedVideoClosed_Z = JNIEnv.GetMethodID (class_ref, "onRewardedVideoClosed", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoClosed_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRewardedVideoClosed", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onRewardedVideoFailedToLoad;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoFailedToLoadHandler ()
		{
			if (cb_onRewardedVideoFailedToLoad == null)
				cb_onRewardedVideoFailedToLoad = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRewardedVideoFailedToLoad);
			return cb_onRewardedVideoFailedToLoad;
		}

		static void n_OnRewardedVideoFailedToLoad (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoFailedToLoad ();
		}
#pragma warning restore 0169

		static IntPtr id_onRewardedVideoFailedToLoad;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='onRewardedVideoFailedToLoad' and count(parameter)=0]"
		[Register ("onRewardedVideoFailedToLoad", "()V", "GetOnRewardedVideoFailedToLoadHandler")]
		public virtual unsafe void OnRewardedVideoFailedToLoad ()
		{
			if (id_onRewardedVideoFailedToLoad == IntPtr.Zero)
				id_onRewardedVideoFailedToLoad = JNIEnv.GetMethodID (class_ref, "onRewardedVideoFailedToLoad", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoFailedToLoad);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRewardedVideoFailedToLoad", "()V"));
			} finally {
			}
		}

		static Delegate cb_onRewardedVideoFinished_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoFinished_ILjava_lang_String_Handler ()
		{
			if (cb_onRewardedVideoFinished_ILjava_lang_String_ == null)
				cb_onRewardedVideoFinished_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnRewardedVideoFinished_ILjava_lang_String_);
			return cb_onRewardedVideoFinished_ILjava_lang_String_;
		}

		static void n_OnRewardedVideoFinished_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoFinished (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onRewardedVideoFinished_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='onRewardedVideoFinished' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onRewardedVideoFinished", "(ILjava/lang/String;)V", "GetOnRewardedVideoFinished_ILjava_lang_String_Handler")]
		public virtual unsafe void OnRewardedVideoFinished (int p0, string p1)
		{
			if (id_onRewardedVideoFinished_ILjava_lang_String_ == IntPtr.Zero)
				id_onRewardedVideoFinished_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onRewardedVideoFinished", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoFinished_ILjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRewardedVideoFinished", "(ILjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_onRewardedVideoLoaded;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoLoadedHandler ()
		{
			if (cb_onRewardedVideoLoaded == null)
				cb_onRewardedVideoLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRewardedVideoLoaded);
			return cb_onRewardedVideoLoaded;
		}

		static void n_OnRewardedVideoLoaded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoLoaded ();
		}
#pragma warning restore 0169

		static IntPtr id_onRewardedVideoLoaded;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='onRewardedVideoLoaded' and count(parameter)=0]"
		[Register ("onRewardedVideoLoaded", "()V", "GetOnRewardedVideoLoadedHandler")]
		public virtual unsafe void OnRewardedVideoLoaded ()
		{
			if (id_onRewardedVideoLoaded == IntPtr.Zero)
				id_onRewardedVideoLoaded = JNIEnv.GetMethodID (class_ref, "onRewardedVideoLoaded", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoLoaded);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRewardedVideoLoaded", "()V"));
			} finally {
			}
		}

		static Delegate cb_onRewardedVideoShown;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoShownHandler ()
		{
			if (cb_onRewardedVideoShown == null)
				cb_onRewardedVideoShown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRewardedVideoShown);
			return cb_onRewardedVideoShown;
		}

		static void n_OnRewardedVideoShown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.TestActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.TestActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoShown ();
		}
#pragma warning restore 0169

		static IntPtr id_onRewardedVideoShown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='TestActivity']/method[@name='onRewardedVideoShown' and count(parameter)=0]"
		[Register ("onRewardedVideoShown", "()V", "GetOnRewardedVideoShownHandler")]
		public virtual unsafe void OnRewardedVideoShown ()
		{
			if (id_onRewardedVideoShown == IntPtr.Zero)
				id_onRewardedVideoShown = JNIEnv.GetMethodID (class_ref, "onRewardedVideoShown", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRewardedVideoShown);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRewardedVideoShown", "()V"));
			} finally {
			}
		}

	}
}
