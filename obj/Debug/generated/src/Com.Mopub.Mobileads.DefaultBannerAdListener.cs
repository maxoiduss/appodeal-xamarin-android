using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='DefaultBannerAdListener']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/DefaultBannerAdListener", DoNotGenerateAcw=true)]
	public partial class DefaultBannerAdListener : global::Java.Lang.Object, global::Com.Mopub.Mobileads.MoPubView.IBannerAdListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/DefaultBannerAdListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultBannerAdListener); }
		}

		protected DefaultBannerAdListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='DefaultBannerAdListener']/constructor[@name='DefaultBannerAdListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultBannerAdListener ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DefaultBannerAdListener)) {
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

		static Delegate cb_onBannerClicked_Lcom_mopub_mobileads_MoPubView_;
#pragma warning disable 0169
		static Delegate GetOnBannerClicked_Lcom_mopub_mobileads_MoPubView_Handler ()
		{
			if (cb_onBannerClicked_Lcom_mopub_mobileads_MoPubView_ == null)
				cb_onBannerClicked_Lcom_mopub_mobileads_MoPubView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBannerClicked_Lcom_mopub_mobileads_MoPubView_);
			return cb_onBannerClicked_Lcom_mopub_mobileads_MoPubView_;
		}

		static void n_OnBannerClicked_Lcom_mopub_mobileads_MoPubView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.DefaultBannerAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.DefaultBannerAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerClicked (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onBannerClicked_Lcom_mopub_mobileads_MoPubView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='DefaultBannerAdListener']/method[@name='onBannerClicked' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView']]"
		[Register ("onBannerClicked", "(Lcom/mopub/mobileads/MoPubView;)V", "GetOnBannerClicked_Lcom_mopub_mobileads_MoPubView_Handler")]
		public virtual unsafe void OnBannerClicked (global::Com.Mopub.Mobileads.MoPubView p0)
		{
			if (id_onBannerClicked_Lcom_mopub_mobileads_MoPubView_ == IntPtr.Zero)
				id_onBannerClicked_Lcom_mopub_mobileads_MoPubView_ = JNIEnv.GetMethodID (class_ref, "onBannerClicked", "(Lcom/mopub/mobileads/MoPubView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onBannerClicked_Lcom_mopub_mobileads_MoPubView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBannerClicked", "(Lcom/mopub/mobileads/MoPubView;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onBannerCollapsed_Lcom_mopub_mobileads_MoPubView_;
#pragma warning disable 0169
		static Delegate GetOnBannerCollapsed_Lcom_mopub_mobileads_MoPubView_Handler ()
		{
			if (cb_onBannerCollapsed_Lcom_mopub_mobileads_MoPubView_ == null)
				cb_onBannerCollapsed_Lcom_mopub_mobileads_MoPubView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBannerCollapsed_Lcom_mopub_mobileads_MoPubView_);
			return cb_onBannerCollapsed_Lcom_mopub_mobileads_MoPubView_;
		}

		static void n_OnBannerCollapsed_Lcom_mopub_mobileads_MoPubView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.DefaultBannerAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.DefaultBannerAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerCollapsed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onBannerCollapsed_Lcom_mopub_mobileads_MoPubView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='DefaultBannerAdListener']/method[@name='onBannerCollapsed' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView']]"
		[Register ("onBannerCollapsed", "(Lcom/mopub/mobileads/MoPubView;)V", "GetOnBannerCollapsed_Lcom_mopub_mobileads_MoPubView_Handler")]
		public virtual unsafe void OnBannerCollapsed (global::Com.Mopub.Mobileads.MoPubView p0)
		{
			if (id_onBannerCollapsed_Lcom_mopub_mobileads_MoPubView_ == IntPtr.Zero)
				id_onBannerCollapsed_Lcom_mopub_mobileads_MoPubView_ = JNIEnv.GetMethodID (class_ref, "onBannerCollapsed", "(Lcom/mopub/mobileads/MoPubView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onBannerCollapsed_Lcom_mopub_mobileads_MoPubView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBannerCollapsed", "(Lcom/mopub/mobileads/MoPubView;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onBannerExpanded_Lcom_mopub_mobileads_MoPubView_;
#pragma warning disable 0169
		static Delegate GetOnBannerExpanded_Lcom_mopub_mobileads_MoPubView_Handler ()
		{
			if (cb_onBannerExpanded_Lcom_mopub_mobileads_MoPubView_ == null)
				cb_onBannerExpanded_Lcom_mopub_mobileads_MoPubView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBannerExpanded_Lcom_mopub_mobileads_MoPubView_);
			return cb_onBannerExpanded_Lcom_mopub_mobileads_MoPubView_;
		}

		static void n_OnBannerExpanded_Lcom_mopub_mobileads_MoPubView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.DefaultBannerAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.DefaultBannerAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerExpanded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onBannerExpanded_Lcom_mopub_mobileads_MoPubView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='DefaultBannerAdListener']/method[@name='onBannerExpanded' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView']]"
		[Register ("onBannerExpanded", "(Lcom/mopub/mobileads/MoPubView;)V", "GetOnBannerExpanded_Lcom_mopub_mobileads_MoPubView_Handler")]
		public virtual unsafe void OnBannerExpanded (global::Com.Mopub.Mobileads.MoPubView p0)
		{
			if (id_onBannerExpanded_Lcom_mopub_mobileads_MoPubView_ == IntPtr.Zero)
				id_onBannerExpanded_Lcom_mopub_mobileads_MoPubView_ = JNIEnv.GetMethodID (class_ref, "onBannerExpanded", "(Lcom/mopub/mobileads/MoPubView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onBannerExpanded_Lcom_mopub_mobileads_MoPubView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBannerExpanded", "(Lcom/mopub/mobileads/MoPubView;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_;
#pragma warning disable 0169
		static Delegate GetOnBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_Handler ()
		{
			if (cb_onBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_ == null)
				cb_onBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_);
			return cb_onBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_;
		}

		static void n_OnBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Mobileads.DefaultBannerAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.DefaultBannerAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubErrorCode p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerFailed (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='DefaultBannerAdListener']/method[@name='onBannerFailed' and count(parameter)=2 and parameter[1][@type='com.mopub.mobileads.MoPubView'] and parameter[2][@type='com.mopub.mobileads.MoPubErrorCode']]"
		[Register ("onBannerFailed", "(Lcom/mopub/mobileads/MoPubView;Lcom/mopub/mobileads/MoPubErrorCode;)V", "GetOnBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_Handler")]
		public virtual unsafe void OnBannerFailed (global::Com.Mopub.Mobileads.MoPubView p0, global::Com.Mopub.Mobileads.MoPubErrorCode p1)
		{
			if (id_onBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_ == IntPtr.Zero)
				id_onBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_ = JNIEnv.GetMethodID (class_ref, "onBannerFailed", "(Lcom/mopub/mobileads/MoPubView;Lcom/mopub/mobileads/MoPubErrorCode;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBannerFailed", "(Lcom/mopub/mobileads/MoPubView;Lcom/mopub/mobileads/MoPubErrorCode;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onBannerLoaded_Lcom_mopub_mobileads_MoPubView_;
#pragma warning disable 0169
		static Delegate GetOnBannerLoaded_Lcom_mopub_mobileads_MoPubView_Handler ()
		{
			if (cb_onBannerLoaded_Lcom_mopub_mobileads_MoPubView_ == null)
				cb_onBannerLoaded_Lcom_mopub_mobileads_MoPubView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBannerLoaded_Lcom_mopub_mobileads_MoPubView_);
			return cb_onBannerLoaded_Lcom_mopub_mobileads_MoPubView_;
		}

		static void n_OnBannerLoaded_Lcom_mopub_mobileads_MoPubView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.DefaultBannerAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.DefaultBannerAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerLoaded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onBannerLoaded_Lcom_mopub_mobileads_MoPubView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='DefaultBannerAdListener']/method[@name='onBannerLoaded' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView']]"
		[Register ("onBannerLoaded", "(Lcom/mopub/mobileads/MoPubView;)V", "GetOnBannerLoaded_Lcom_mopub_mobileads_MoPubView_Handler")]
		public virtual unsafe void OnBannerLoaded (global::Com.Mopub.Mobileads.MoPubView p0)
		{
			if (id_onBannerLoaded_Lcom_mopub_mobileads_MoPubView_ == IntPtr.Zero)
				id_onBannerLoaded_Lcom_mopub_mobileads_MoPubView_ = JNIEnv.GetMethodID (class_ref, "onBannerLoaded", "(Lcom/mopub/mobileads/MoPubView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onBannerLoaded_Lcom_mopub_mobileads_MoPubView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBannerLoaded", "(Lcom/mopub/mobileads/MoPubView;)V"), __args);
			} finally {
			}
		}

	}
}
