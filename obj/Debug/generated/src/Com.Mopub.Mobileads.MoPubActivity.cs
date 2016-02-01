using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubActivity", DoNotGenerateAcw=true)]
	public partial class MoPubActivity : global::Com.Mopub.Mobileads.BaseInterstitialActivity {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity.BroadcastingInterstitialListener']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubActivity$BroadcastingInterstitialListener", DoNotGenerateAcw=true)]
		public partial class BroadcastingInterstitialListener : global::Java.Lang.Object, global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/MoPubActivity$BroadcastingInterstitialListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BroadcastingInterstitialListener); }
			}

			protected BroadcastingInterstitialListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnInterstitialClicked ();
			}
#pragma warning restore 0169

			static IntPtr id_onInterstitialClicked;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity.BroadcastingInterstitialListener']/method[@name='onInterstitialClicked' and count(parameter)=0]"
			[Register ("onInterstitialClicked", "()V", "GetOnInterstitialClickedHandler")]
			public virtual unsafe void OnInterstitialClicked ()
			{
				if (id_onInterstitialClicked == IntPtr.Zero)
					id_onInterstitialClicked = JNIEnv.GetMethodID (class_ref, "onInterstitialClicked", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onInterstitialClicked);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialClicked", "()V"));
				} finally {
				}
			}

			static Delegate cb_onInterstitialDismissed;
#pragma warning disable 0169
			static Delegate GetOnInterstitialDismissedHandler ()
			{
				if (cb_onInterstitialDismissed == null)
					cb_onInterstitialDismissed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialDismissed);
				return cb_onInterstitialDismissed;
			}

			static void n_OnInterstitialDismissed (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnInterstitialDismissed ();
			}
#pragma warning restore 0169

			static IntPtr id_onInterstitialDismissed;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity.BroadcastingInterstitialListener']/method[@name='onInterstitialDismissed' and count(parameter)=0]"
			[Register ("onInterstitialDismissed", "()V", "GetOnInterstitialDismissedHandler")]
			public virtual unsafe void OnInterstitialDismissed ()
			{
				if (id_onInterstitialDismissed == IntPtr.Zero)
					id_onInterstitialDismissed = JNIEnv.GetMethodID (class_ref, "onInterstitialDismissed", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onInterstitialDismissed);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialDismissed", "()V"));
				} finally {
				}
			}

			static Delegate cb_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
#pragma warning disable 0169
			static Delegate GetOnInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler ()
			{
				if (cb_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == null)
					cb_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_);
				return cb_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
			}

			static void n_OnInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MoPubErrorCode p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnInterstitialFailed (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity.BroadcastingInterstitialListener']/method[@name='onInterstitialFailed' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubErrorCode']]"
			[Register ("onInterstitialFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V", "GetOnInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler")]
			public virtual unsafe void OnInterstitialFailed (global::Com.Mopub.Mobileads.MoPubErrorCode p0)
			{
				if (id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == IntPtr.Zero)
					id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNIEnv.GetMethodID (class_ref, "onInterstitialFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onInterstitialFinished;
#pragma warning disable 0169
			static Delegate GetOnInterstitialFinishedHandler ()
			{
				if (cb_onInterstitialFinished == null)
					cb_onInterstitialFinished = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialFinished);
				return cb_onInterstitialFinished;
			}

			static void n_OnInterstitialFinished (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnInterstitialFinished ();
			}
#pragma warning restore 0169

			static IntPtr id_onInterstitialFinished;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity.BroadcastingInterstitialListener']/method[@name='onInterstitialFinished' and count(parameter)=0]"
			[Register ("onInterstitialFinished", "()V", "GetOnInterstitialFinishedHandler")]
			public virtual unsafe void OnInterstitialFinished ()
			{
				if (id_onInterstitialFinished == IntPtr.Zero)
					id_onInterstitialFinished = JNIEnv.GetMethodID (class_ref, "onInterstitialFinished", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onInterstitialFinished);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialFinished", "()V"));
				} finally {
				}
			}

			static Delegate cb_onInterstitialLoaded;
#pragma warning disable 0169
			static Delegate GetOnInterstitialLoadedHandler ()
			{
				if (cb_onInterstitialLoaded == null)
					cb_onInterstitialLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialLoaded);
				return cb_onInterstitialLoaded;
			}

			static void n_OnInterstitialLoaded (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnInterstitialLoaded ();
			}
#pragma warning restore 0169

			static IntPtr id_onInterstitialLoaded;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity.BroadcastingInterstitialListener']/method[@name='onInterstitialLoaded' and count(parameter)=0]"
			[Register ("onInterstitialLoaded", "()V", "GetOnInterstitialLoadedHandler")]
			public virtual unsafe void OnInterstitialLoaded ()
			{
				if (id_onInterstitialLoaded == IntPtr.Zero)
					id_onInterstitialLoaded = JNIEnv.GetMethodID (class_ref, "onInterstitialLoaded", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onInterstitialLoaded);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialLoaded", "()V"));
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
				global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnInterstitialShown ();
			}
#pragma warning restore 0169

			static IntPtr id_onInterstitialShown;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity.BroadcastingInterstitialListener']/method[@name='onInterstitialShown' and count(parameter)=0]"
			[Register ("onInterstitialShown", "()V", "GetOnInterstitialShownHandler")]
			public virtual unsafe void OnInterstitialShown ()
			{
				if (id_onInterstitialShown == IntPtr.Zero)
					id_onInterstitialShown = JNIEnv.GetMethodID (class_ref, "onInterstitialShown", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onInterstitialShown);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialShown", "()V"));
				} finally {
				}
			}

			static Delegate cb_onLeaveApplication;
#pragma warning disable 0169
			static Delegate GetOnLeaveApplicationHandler ()
			{
				if (cb_onLeaveApplication == null)
					cb_onLeaveApplication = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLeaveApplication);
				return cb_onLeaveApplication;
			}

			static void n_OnLeaveApplication (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubActivity.BroadcastingInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnLeaveApplication ();
			}
#pragma warning restore 0169

			static IntPtr id_onLeaveApplication;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity.BroadcastingInterstitialListener']/method[@name='onLeaveApplication' and count(parameter)=0]"
			[Register ("onLeaveApplication", "()V", "GetOnLeaveApplicationHandler")]
			public virtual unsafe void OnLeaveApplication ()
			{
				if (id_onLeaveApplication == IntPtr.Zero)
					id_onLeaveApplication = JNIEnv.GetMethodID (class_ref, "onLeaveApplication", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onLeaveApplication);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLeaveApplication", "()V"));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/MoPubActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoPubActivity); }
		}

		protected MoPubActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity']/constructor[@name='MoPubActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MoPubActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MoPubActivity)) {
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

		static Delegate cb_getAdView;
#pragma warning disable 0169
		static Delegate GetGetAdViewHandler ()
		{
			if (cb_getAdView == null)
				cb_getAdView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdView);
			return cb_getAdView;
		}

		static IntPtr n_GetAdView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MoPubActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdView);
		}
#pragma warning restore 0169

		static IntPtr id_getAdView;
		public override unsafe global::Android.Views.View AdView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity']/method[@name='getAdView' and count(parameter)=0]"
			[Register ("getAdView", "()Landroid/view/View;", "GetGetAdViewHandler")]
			get {
				if (id_getAdView == IntPtr.Zero)
					id_getAdView = JNIEnv.GetMethodID (class_ref, "getAdView", "()Landroid/view/View;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getAdView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Mopub.Mobileads.MoPubActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCreate_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		protected override unsafe void OnCreate (global::Android.OS.Bundle p0)
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
			global::Com.Mopub.Mobileads.MoPubActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		protected override unsafe void OnDestroy ()
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

		static IntPtr id_start_Landroid_content_Context_Ljava_lang_String_Lcom_mopub_common_AdReport_ZLjava_lang_String_Ljava_lang_String_Lcom_mopub_common_CreativeOrientation_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubActivity']/method[@name='start' and count(parameter)=8 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.mopub.common.AdReport'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='com.mopub.common.CreativeOrientation'] and parameter[8][@type='long']]"
		[Register ("start", "(Landroid/content/Context;Ljava/lang/String;Lcom/mopub/common/AdReport;ZLjava/lang/String;Ljava/lang/String;Lcom/mopub/common/CreativeOrientation;J)V", "")]
		public static unsafe void Start (global::Android.Content.Context p0, string p1, global::Com.Mopub.Common.AdReport p2, bool p3, string p4, string p5, global::Com.Mopub.Common.CreativeOrientation p6, long p7)
		{
			if (id_start_Landroid_content_Context_Ljava_lang_String_Lcom_mopub_common_AdReport_ZLjava_lang_String_Ljava_lang_String_Lcom_mopub_common_CreativeOrientation_J == IntPtr.Zero)
				id_start_Landroid_content_Context_Ljava_lang_String_Lcom_mopub_common_AdReport_ZLjava_lang_String_Ljava_lang_String_Lcom_mopub_common_CreativeOrientation_J = JNIEnv.GetStaticMethodID (class_ref, "start", "(Landroid/content/Context;Ljava/lang/String;Lcom/mopub/common/AdReport;ZLjava/lang/String;Ljava/lang/String;Lcom/mopub/common/CreativeOrientation;J)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_start_Landroid_content_Context_Ljava_lang_String_Lcom_mopub_common_AdReport_ZLjava_lang_String_Ljava_lang_String_Lcom_mopub_common_CreativeOrientation_J, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

	}
}
