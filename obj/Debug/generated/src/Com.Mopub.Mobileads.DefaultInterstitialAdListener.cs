using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='DefaultInterstitialAdListener']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/DefaultInterstitialAdListener", DoNotGenerateAcw=true)]
	public partial class DefaultInterstitialAdListener : global::Java.Lang.Object, global::Com.Mopub.Mobileads.MoPubInterstitial.IInterstitialAdListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/DefaultInterstitialAdListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultInterstitialAdListener); }
		}

		protected DefaultInterstitialAdListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='DefaultInterstitialAdListener']/constructor[@name='DefaultInterstitialAdListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultInterstitialAdListener ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DefaultInterstitialAdListener)) {
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

		static Delegate cb_onInterstitialClicked_Lcom_mopub_mobileads_MoPubInterstitial_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialClicked_Lcom_mopub_mobileads_MoPubInterstitial_Handler ()
		{
			if (cb_onInterstitialClicked_Lcom_mopub_mobileads_MoPubInterstitial_ == null)
				cb_onInterstitialClicked_Lcom_mopub_mobileads_MoPubInterstitial_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInterstitialClicked_Lcom_mopub_mobileads_MoPubInterstitial_);
			return cb_onInterstitialClicked_Lcom_mopub_mobileads_MoPubInterstitial_;
		}

		static void n_OnInterstitialClicked_Lcom_mopub_mobileads_MoPubInterstitial_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.DefaultInterstitialAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.DefaultInterstitialAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubInterstitial p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialClicked (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialClicked_Lcom_mopub_mobileads_MoPubInterstitial_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='DefaultInterstitialAdListener']/method[@name='onInterstitialClicked' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubInterstitial']]"
		[Register ("onInterstitialClicked", "(Lcom/mopub/mobileads/MoPubInterstitial;)V", "GetOnInterstitialClicked_Lcom_mopub_mobileads_MoPubInterstitial_Handler")]
		public virtual unsafe void OnInterstitialClicked (global::Com.Mopub.Mobileads.MoPubInterstitial p0)
		{
			if (id_onInterstitialClicked_Lcom_mopub_mobileads_MoPubInterstitial_ == IntPtr.Zero)
				id_onInterstitialClicked_Lcom_mopub_mobileads_MoPubInterstitial_ = JNIEnv.GetMethodID (class_ref, "onInterstitialClicked", "(Lcom/mopub/mobileads/MoPubInterstitial;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onInterstitialClicked_Lcom_mopub_mobileads_MoPubInterstitial_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialClicked", "(Lcom/mopub/mobileads/MoPubInterstitial;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onInterstitialDismissed_Lcom_mopub_mobileads_MoPubInterstitial_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialDismissed_Lcom_mopub_mobileads_MoPubInterstitial_Handler ()
		{
			if (cb_onInterstitialDismissed_Lcom_mopub_mobileads_MoPubInterstitial_ == null)
				cb_onInterstitialDismissed_Lcom_mopub_mobileads_MoPubInterstitial_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInterstitialDismissed_Lcom_mopub_mobileads_MoPubInterstitial_);
			return cb_onInterstitialDismissed_Lcom_mopub_mobileads_MoPubInterstitial_;
		}

		static void n_OnInterstitialDismissed_Lcom_mopub_mobileads_MoPubInterstitial_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.DefaultInterstitialAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.DefaultInterstitialAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubInterstitial p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialDismissed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialDismissed_Lcom_mopub_mobileads_MoPubInterstitial_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='DefaultInterstitialAdListener']/method[@name='onInterstitialDismissed' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubInterstitial']]"
		[Register ("onInterstitialDismissed", "(Lcom/mopub/mobileads/MoPubInterstitial;)V", "GetOnInterstitialDismissed_Lcom_mopub_mobileads_MoPubInterstitial_Handler")]
		public virtual unsafe void OnInterstitialDismissed (global::Com.Mopub.Mobileads.MoPubInterstitial p0)
		{
			if (id_onInterstitialDismissed_Lcom_mopub_mobileads_MoPubInterstitial_ == IntPtr.Zero)
				id_onInterstitialDismissed_Lcom_mopub_mobileads_MoPubInterstitial_ = JNIEnv.GetMethodID (class_ref, "onInterstitialDismissed", "(Lcom/mopub/mobileads/MoPubInterstitial;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onInterstitialDismissed_Lcom_mopub_mobileads_MoPubInterstitial_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialDismissed", "(Lcom/mopub/mobileads/MoPubInterstitial;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onInterstitialFailed_Lcom_mopub_mobileads_MoPubInterstitial_Lcom_mopub_mobileads_MoPubErrorCode_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialFailed_Lcom_mopub_mobileads_MoPubInterstitial_Lcom_mopub_mobileads_MoPubErrorCode_Handler ()
		{
			if (cb_onInterstitialFailed_Lcom_mopub_mobileads_MoPubInterstitial_Lcom_mopub_mobileads_MoPubErrorCode_ == null)
				cb_onInterstitialFailed_Lcom_mopub_mobileads_MoPubInterstitial_Lcom_mopub_mobileads_MoPubErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnInterstitialFailed_Lcom_mopub_mobileads_MoPubInterstitial_Lcom_mopub_mobileads_MoPubErrorCode_);
			return cb_onInterstitialFailed_Lcom_mopub_mobileads_MoPubInterstitial_Lcom_mopub_mobileads_MoPubErrorCode_;
		}

		static void n_OnInterstitialFailed_Lcom_mopub_mobileads_MoPubInterstitial_Lcom_mopub_mobileads_MoPubErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Mobileads.DefaultInterstitialAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.DefaultInterstitialAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubInterstitial p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubErrorCode p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialFailed (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubInterstitial_Lcom_mopub_mobileads_MoPubErrorCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='DefaultInterstitialAdListener']/method[@name='onInterstitialFailed' and count(parameter)=2 and parameter[1][@type='com.mopub.mobileads.MoPubInterstitial'] and parameter[2][@type='com.mopub.mobileads.MoPubErrorCode']]"
		[Register ("onInterstitialFailed", "(Lcom/mopub/mobileads/MoPubInterstitial;Lcom/mopub/mobileads/MoPubErrorCode;)V", "GetOnInterstitialFailed_Lcom_mopub_mobileads_MoPubInterstitial_Lcom_mopub_mobileads_MoPubErrorCode_Handler")]
		public virtual unsafe void OnInterstitialFailed (global::Com.Mopub.Mobileads.MoPubInterstitial p0, global::Com.Mopub.Mobileads.MoPubErrorCode p1)
		{
			if (id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubInterstitial_Lcom_mopub_mobileads_MoPubErrorCode_ == IntPtr.Zero)
				id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubInterstitial_Lcom_mopub_mobileads_MoPubErrorCode_ = JNIEnv.GetMethodID (class_ref, "onInterstitialFailed", "(Lcom/mopub/mobileads/MoPubInterstitial;Lcom/mopub/mobileads/MoPubErrorCode;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubInterstitial_Lcom_mopub_mobileads_MoPubErrorCode_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialFailed", "(Lcom/mopub/mobileads/MoPubInterstitial;Lcom/mopub/mobileads/MoPubErrorCode;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onInterstitialFinished_Lcom_mopub_mobileads_MoPubInterstitial_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialFinished_Lcom_mopub_mobileads_MoPubInterstitial_Handler ()
		{
			if (cb_onInterstitialFinished_Lcom_mopub_mobileads_MoPubInterstitial_ == null)
				cb_onInterstitialFinished_Lcom_mopub_mobileads_MoPubInterstitial_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInterstitialFinished_Lcom_mopub_mobileads_MoPubInterstitial_);
			return cb_onInterstitialFinished_Lcom_mopub_mobileads_MoPubInterstitial_;
		}

		static void n_OnInterstitialFinished_Lcom_mopub_mobileads_MoPubInterstitial_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.DefaultInterstitialAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.DefaultInterstitialAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubInterstitial p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialFinished (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialFinished_Lcom_mopub_mobileads_MoPubInterstitial_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='DefaultInterstitialAdListener']/method[@name='onInterstitialFinished' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubInterstitial']]"
		[Register ("onInterstitialFinished", "(Lcom/mopub/mobileads/MoPubInterstitial;)V", "GetOnInterstitialFinished_Lcom_mopub_mobileads_MoPubInterstitial_Handler")]
		public virtual unsafe void OnInterstitialFinished (global::Com.Mopub.Mobileads.MoPubInterstitial p0)
		{
			if (id_onInterstitialFinished_Lcom_mopub_mobileads_MoPubInterstitial_ == IntPtr.Zero)
				id_onInterstitialFinished_Lcom_mopub_mobileads_MoPubInterstitial_ = JNIEnv.GetMethodID (class_ref, "onInterstitialFinished", "(Lcom/mopub/mobileads/MoPubInterstitial;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onInterstitialFinished_Lcom_mopub_mobileads_MoPubInterstitial_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialFinished", "(Lcom/mopub/mobileads/MoPubInterstitial;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onInterstitialLoaded_Lcom_mopub_mobileads_MoPubInterstitial_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialLoaded_Lcom_mopub_mobileads_MoPubInterstitial_Handler ()
		{
			if (cb_onInterstitialLoaded_Lcom_mopub_mobileads_MoPubInterstitial_ == null)
				cb_onInterstitialLoaded_Lcom_mopub_mobileads_MoPubInterstitial_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInterstitialLoaded_Lcom_mopub_mobileads_MoPubInterstitial_);
			return cb_onInterstitialLoaded_Lcom_mopub_mobileads_MoPubInterstitial_;
		}

		static void n_OnInterstitialLoaded_Lcom_mopub_mobileads_MoPubInterstitial_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.DefaultInterstitialAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.DefaultInterstitialAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubInterstitial p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialLoaded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialLoaded_Lcom_mopub_mobileads_MoPubInterstitial_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='DefaultInterstitialAdListener']/method[@name='onInterstitialLoaded' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubInterstitial']]"
		[Register ("onInterstitialLoaded", "(Lcom/mopub/mobileads/MoPubInterstitial;)V", "GetOnInterstitialLoaded_Lcom_mopub_mobileads_MoPubInterstitial_Handler")]
		public virtual unsafe void OnInterstitialLoaded (global::Com.Mopub.Mobileads.MoPubInterstitial p0)
		{
			if (id_onInterstitialLoaded_Lcom_mopub_mobileads_MoPubInterstitial_ == IntPtr.Zero)
				id_onInterstitialLoaded_Lcom_mopub_mobileads_MoPubInterstitial_ = JNIEnv.GetMethodID (class_ref, "onInterstitialLoaded", "(Lcom/mopub/mobileads/MoPubInterstitial;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onInterstitialLoaded_Lcom_mopub_mobileads_MoPubInterstitial_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialLoaded", "(Lcom/mopub/mobileads/MoPubInterstitial;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onInterstitialShown_Lcom_mopub_mobileads_MoPubInterstitial_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialShown_Lcom_mopub_mobileads_MoPubInterstitial_Handler ()
		{
			if (cb_onInterstitialShown_Lcom_mopub_mobileads_MoPubInterstitial_ == null)
				cb_onInterstitialShown_Lcom_mopub_mobileads_MoPubInterstitial_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInterstitialShown_Lcom_mopub_mobileads_MoPubInterstitial_);
			return cb_onInterstitialShown_Lcom_mopub_mobileads_MoPubInterstitial_;
		}

		static void n_OnInterstitialShown_Lcom_mopub_mobileads_MoPubInterstitial_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.DefaultInterstitialAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.DefaultInterstitialAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubInterstitial p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialShown (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialShown_Lcom_mopub_mobileads_MoPubInterstitial_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='DefaultInterstitialAdListener']/method[@name='onInterstitialShown' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubInterstitial']]"
		[Register ("onInterstitialShown", "(Lcom/mopub/mobileads/MoPubInterstitial;)V", "GetOnInterstitialShown_Lcom_mopub_mobileads_MoPubInterstitial_Handler")]
		public virtual unsafe void OnInterstitialShown (global::Com.Mopub.Mobileads.MoPubInterstitial p0)
		{
			if (id_onInterstitialShown_Lcom_mopub_mobileads_MoPubInterstitial_ == IntPtr.Zero)
				id_onInterstitialShown_Lcom_mopub_mobileads_MoPubInterstitial_ = JNIEnv.GetMethodID (class_ref, "onInterstitialShown", "(Lcom/mopub/mobileads/MoPubInterstitial;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onInterstitialShown_Lcom_mopub_mobileads_MoPubInterstitial_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialShown", "(Lcom/mopub/mobileads/MoPubInterstitial;)V"), __args);
			} finally {
			}
		}

	}
}
