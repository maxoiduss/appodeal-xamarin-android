using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Device.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ModelessInterstitialAd']"
	[global::Android.Runtime.Register ("com/amazon/device/ads/ModelessInterstitialAd", DoNotGenerateAcw=true)]
	public partial class ModelessInterstitialAd : global::Java.Lang.Object, global::Com.Amazon.Device.Ads.IAd {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ModelessInterstitialAd.ModelessInterstitialAdControlCallback']"
		[global::Android.Runtime.Register ("com/amazon/device/ads/ModelessInterstitialAd$ModelessInterstitialAdControlCallback", DoNotGenerateAcw=true)]
		public partial class ModelessInterstitialAdControlCallback : global::Java.Lang.Object, global::Com.Amazon.Device.Ads.IAdControlCallback {


			public static class InterfaceConsts {

				// The following are fields from: com.amazon.device.ads.AdControlCallback

				// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='AdControlCallback']/field[@name='CLOSE_EVENT_ONLY']"
				[Register ("CLOSE_EVENT_ONLY")]
				public const int CloseEventOnly = (int) 0;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='AdControlCallback']/field[@name='CLOSE_FULL']"
				[Register ("CLOSE_FULL")]
				public const int CloseFull = (int) 1;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='AdControlCallback']/field[@name='NO_CLOSE']"
				[Register ("NO_CLOSE")]
				public const int NoClose = (int) 2;
			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/device/ads/ModelessInterstitialAd$ModelessInterstitialAdControlCallback", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ModelessInterstitialAdControlCallback); }
			}

			protected ModelessInterstitialAdControlCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_adClosing;
#pragma warning disable 0169
			static Delegate GetAdClosingHandler ()
			{
				if (cb_adClosing == null)
					cb_adClosing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_AdClosing);
				return cb_adClosing;
			}

			static int n_AdClosing (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Device.Ads.ModelessInterstitialAd.ModelessInterstitialAdControlCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.ModelessInterstitialAd.ModelessInterstitialAdControlCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.AdClosing ();
			}
#pragma warning restore 0169

			static IntPtr id_adClosing;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ModelessInterstitialAd.ModelessInterstitialAdControlCallback']/method[@name='adClosing' and count(parameter)=0]"
			[Register ("adClosing", "()I", "GetAdClosingHandler")]
			public virtual unsafe int AdClosing ()
			{
				if (id_adClosing == IntPtr.Zero)
					id_adClosing = JNIEnv.GetMethodID (class_ref, "adClosing", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_adClosing);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "adClosing", "()I"));
				} finally {
				}
			}

			static Delegate cb_isAdReady_Z;
#pragma warning disable 0169
			static Delegate GetIsAdReady_ZHandler ()
			{
				if (cb_isAdReady_Z == null)
					cb_isAdReady_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_IsAdReady_Z);
				return cb_isAdReady_Z;
			}

			static bool n_IsAdReady_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Amazon.Device.Ads.ModelessInterstitialAd.ModelessInterstitialAdControlCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.ModelessInterstitialAd.ModelessInterstitialAdControlCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsAdReady (p0);
			}
#pragma warning restore 0169

			static IntPtr id_isAdReady_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ModelessInterstitialAd.ModelessInterstitialAdControlCallback']/method[@name='isAdReady' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("isAdReady", "(Z)Z", "GetIsAdReady_ZHandler")]
			public virtual unsafe bool IsAdReady (bool p0)
			{
				if (id_isAdReady_Z == IntPtr.Zero)
					id_isAdReady_Z = JNIEnv.GetMethodID (class_ref, "isAdReady", "(Z)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isAdReady_Z, __args);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAdReady", "(Z)Z"), __args);
				} finally {
				}
			}

			static Delegate cb_onAdExpired;
#pragma warning disable 0169
			static Delegate GetOnAdExpiredHandler ()
			{
				if (cb_onAdExpired == null)
					cb_onAdExpired = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAdExpired);
				return cb_onAdExpired;
			}

			static void n_OnAdExpired (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Device.Ads.ModelessInterstitialAd.ModelessInterstitialAdControlCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.ModelessInterstitialAd.ModelessInterstitialAdControlCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnAdExpired ();
			}
#pragma warning restore 0169

			static IntPtr id_onAdExpired;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ModelessInterstitialAd.ModelessInterstitialAdControlCallback']/method[@name='onAdExpired' and count(parameter)=0]"
			[Register ("onAdExpired", "()V", "GetOnAdExpiredHandler")]
			public virtual unsafe void OnAdExpired ()
			{
				if (id_onAdExpired == IntPtr.Zero)
					id_onAdExpired = JNIEnv.GetMethodID (class_ref, "onAdExpired", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onAdExpired);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAdExpired", "()V"));
				} finally {
				}
			}

			static Delegate cb_onAdFailed_Lcom_amazon_device_ads_AdError_;
#pragma warning disable 0169
			static Delegate GetOnAdFailed_Lcom_amazon_device_ads_AdError_Handler ()
			{
				if (cb_onAdFailed_Lcom_amazon_device_ads_AdError_ == null)
					cb_onAdFailed_Lcom_amazon_device_ads_AdError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAdFailed_Lcom_amazon_device_ads_AdError_);
				return cb_onAdFailed_Lcom_amazon_device_ads_AdError_;
			}

			static void n_OnAdFailed_Lcom_amazon_device_ads_AdError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amazon.Device.Ads.ModelessInterstitialAd.ModelessInterstitialAdControlCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.ModelessInterstitialAd.ModelessInterstitialAdControlCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Amazon.Device.Ads.AdError p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAdFailed (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onAdFailed_Lcom_amazon_device_ads_AdError_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ModelessInterstitialAd.ModelessInterstitialAdControlCallback']/method[@name='onAdFailed' and count(parameter)=1 and parameter[1][@type='com.amazon.device.ads.AdError']]"
			[Register ("onAdFailed", "(Lcom/amazon/device/ads/AdError;)V", "GetOnAdFailed_Lcom_amazon_device_ads_AdError_Handler")]
			public virtual unsafe void OnAdFailed (global::Com.Amazon.Device.Ads.AdError p0)
			{
				if (id_onAdFailed_Lcom_amazon_device_ads_AdError_ == IntPtr.Zero)
					id_onAdFailed_Lcom_amazon_device_ads_AdError_ = JNIEnv.GetMethodID (class_ref, "onAdFailed", "(Lcom/amazon/device/ads/AdError;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onAdFailed_Lcom_amazon_device_ads_AdError_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAdFailed", "(Lcom/amazon/device/ads/AdError;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onAdLoaded_Lcom_amazon_device_ads_AdProperties_;
#pragma warning disable 0169
			static Delegate GetOnAdLoaded_Lcom_amazon_device_ads_AdProperties_Handler ()
			{
				if (cb_onAdLoaded_Lcom_amazon_device_ads_AdProperties_ == null)
					cb_onAdLoaded_Lcom_amazon_device_ads_AdProperties_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAdLoaded_Lcom_amazon_device_ads_AdProperties_);
				return cb_onAdLoaded_Lcom_amazon_device_ads_AdProperties_;
			}

			static void n_OnAdLoaded_Lcom_amazon_device_ads_AdProperties_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amazon.Device.Ads.ModelessInterstitialAd.ModelessInterstitialAdControlCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.ModelessInterstitialAd.ModelessInterstitialAdControlCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Amazon.Device.Ads.AdProperties p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdProperties> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAdLoaded (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onAdLoaded_Lcom_amazon_device_ads_AdProperties_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ModelessInterstitialAd.ModelessInterstitialAdControlCallback']/method[@name='onAdLoaded' and count(parameter)=1 and parameter[1][@type='com.amazon.device.ads.AdProperties']]"
			[Register ("onAdLoaded", "(Lcom/amazon/device/ads/AdProperties;)V", "GetOnAdLoaded_Lcom_amazon_device_ads_AdProperties_Handler")]
			public virtual unsafe void OnAdLoaded (global::Com.Amazon.Device.Ads.AdProperties p0)
			{
				if (id_onAdLoaded_Lcom_amazon_device_ads_AdProperties_ == IntPtr.Zero)
					id_onAdLoaded_Lcom_amazon_device_ads_AdProperties_ = JNIEnv.GetMethodID (class_ref, "onAdLoaded", "(Lcom/amazon/device/ads/AdProperties;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onAdLoaded_Lcom_amazon_device_ads_AdProperties_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAdLoaded", "(Lcom/amazon/device/ads/AdProperties;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onAdRendered;
#pragma warning disable 0169
			static Delegate GetOnAdRenderedHandler ()
			{
				if (cb_onAdRendered == null)
					cb_onAdRendered = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAdRendered);
				return cb_onAdRendered;
			}

			static void n_OnAdRendered (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Device.Ads.ModelessInterstitialAd.ModelessInterstitialAdControlCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.ModelessInterstitialAd.ModelessInterstitialAdControlCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnAdRendered ();
			}
#pragma warning restore 0169

			static IntPtr id_onAdRendered;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ModelessInterstitialAd.ModelessInterstitialAdControlCallback']/method[@name='onAdRendered' and count(parameter)=0]"
			[Register ("onAdRendered", "()V", "GetOnAdRenderedHandler")]
			public virtual unsafe void OnAdRendered ()
			{
				if (id_onAdRendered == IntPtr.Zero)
					id_onAdRendered = JNIEnv.GetMethodID (class_ref, "onAdRendered", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onAdRendered);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAdRendered", "()V"));
				} finally {
				}
			}

			static Delegate cb_postAdRendered;
#pragma warning disable 0169
			static Delegate GetPostAdRenderedHandler ()
			{
				if (cb_postAdRendered == null)
					cb_postAdRendered = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PostAdRendered);
				return cb_postAdRendered;
			}

			static void n_PostAdRendered (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Device.Ads.ModelessInterstitialAd.ModelessInterstitialAdControlCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.ModelessInterstitialAd.ModelessInterstitialAdControlCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.PostAdRendered ();
			}
#pragma warning restore 0169

			static IntPtr id_postAdRendered;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ModelessInterstitialAd.ModelessInterstitialAdControlCallback']/method[@name='postAdRendered' and count(parameter)=0]"
			[Register ("postAdRendered", "()V", "GetPostAdRenderedHandler")]
			public virtual unsafe void PostAdRendered ()
			{
				if (id_postAdRendered == IntPtr.Zero)
					id_postAdRendered = JNIEnv.GetMethodID (class_ref, "postAdRendered", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_postAdRendered);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postAdRendered", "()V"));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/device/ads/ModelessInterstitialAd", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ModelessInterstitialAd); }
		}

		protected ModelessInterstitialAd (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_ViewGroup_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ModelessInterstitialAd']/constructor[@name='ModelessInterstitialAd' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
		[Register (".ctor", "(Landroid/view/ViewGroup;)V", "")]
		public unsafe ModelessInterstitialAd (global::Android.Views.ViewGroup p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ModelessInterstitialAd)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/ViewGroup;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/view/ViewGroup;)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_ViewGroup_ == IntPtr.Zero)
					id_ctor_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/ViewGroup;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_ViewGroup_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_view_ViewGroup_, __args);
			} finally {
			}
		}

		static Delegate cb_isLoading;
#pragma warning disable 0169
		static Delegate GetIsLoadingHandler ()
		{
			if (cb_isLoading == null)
				cb_isLoading = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLoading);
			return cb_isLoading;
		}

		static bool n_IsLoading (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.ModelessInterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.ModelessInterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLoading;
		}
#pragma warning restore 0169

		static IntPtr id_isLoading;
		public virtual unsafe bool IsLoading {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ModelessInterstitialAd']/method[@name='isLoading' and count(parameter)=0]"
			[Register ("isLoading", "()Z", "GetIsLoadingHandler")]
			get {
				if (id_isLoading == IntPtr.Zero)
					id_isLoading = JNIEnv.GetMethodID (class_ref, "isLoading", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isLoading);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLoading", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isReady;
#pragma warning disable 0169
		static Delegate GetIsReadyHandler ()
		{
			if (cb_isReady == null)
				cb_isReady = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReady);
			return cb_isReady;
		}

		static bool n_IsReady (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.ModelessInterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.ModelessInterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReady;
		}
#pragma warning restore 0169

		static IntPtr id_isReady;
		public virtual unsafe bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ModelessInterstitialAd']/method[@name='isReady' and count(parameter)=0]"
			[Register ("isReady", "()Z", "GetIsReadyHandler")]
			get {
				if (id_isReady == IntPtr.Zero)
					id_isReady = JNIEnv.GetMethodID (class_ref, "isReady", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isReady);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isReady", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getTimeout;
#pragma warning disable 0169
		static Delegate GetGetTimeoutHandler ()
		{
			if (cb_getTimeout == null)
				cb_getTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTimeout);
			return cb_getTimeout;
		}

		static int n_GetTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.ModelessInterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.ModelessInterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timeout;
		}
#pragma warning restore 0169

		static Delegate cb_setTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetTimeout_IHandler ()
		{
			if (cb_setTimeout_I == null)
				cb_setTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTimeout_I);
			return cb_setTimeout_I;
		}

		static void n_SetTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amazon.Device.Ads.ModelessInterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.ModelessInterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Timeout = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeout;
		static IntPtr id_setTimeout_I;
		public virtual unsafe int Timeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ModelessInterstitialAd']/method[@name='getTimeout' and count(parameter)=0]"
			[Register ("getTimeout", "()I", "GetGetTimeoutHandler")]
			get {
				if (id_getTimeout == IntPtr.Zero)
					id_getTimeout = JNIEnv.GetMethodID (class_ref, "getTimeout", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTimeout);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeout", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ModelessInterstitialAd']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTimeout", "(I)V", "GetSetTimeout_IHandler")]
			set {
				if (id_setTimeout_I == IntPtr.Zero)
					id_setTimeout_I = JNIEnv.GetMethodID (class_ref, "setTimeout", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTimeout_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeout", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_adHidden;
#pragma warning disable 0169
		static Delegate GetAdHiddenHandler ()
		{
			if (cb_adHidden == null)
				cb_adHidden = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AdHidden);
			return cb_adHidden;
		}

		static void n_AdHidden (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.ModelessInterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.ModelessInterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AdHidden ();
		}
#pragma warning restore 0169

		static IntPtr id_adHidden;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ModelessInterstitialAd']/method[@name='adHidden' and count(parameter)=0]"
		[Register ("adHidden", "()V", "GetAdHiddenHandler")]
		public virtual unsafe void AdHidden ()
		{
			if (id_adHidden == IntPtr.Zero)
				id_adHidden = JNIEnv.GetMethodID (class_ref, "adHidden", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_adHidden);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "adHidden", "()V"));
			} finally {
			}
		}

		static Delegate cb_adShown;
#pragma warning disable 0169
		static Delegate GetAdShownHandler ()
		{
			if (cb_adShown == null)
				cb_adShown = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_AdShown);
			return cb_adShown;
		}

		static bool n_AdShown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.ModelessInterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.ModelessInterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdShown ();
		}
#pragma warning restore 0169

		static IntPtr id_adShown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ModelessInterstitialAd']/method[@name='adShown' and count(parameter)=0]"
		[Register ("adShown", "()Z", "GetAdShownHandler")]
		public virtual unsafe bool AdShown ()
		{
			if (id_adShown == IntPtr.Zero)
				id_adShown = JNIEnv.GetMethodID (class_ref, "adShown", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_adShown);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "adShown", "()Z"));
			} finally {
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.ModelessInterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.ModelessInterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ModelessInterstitialAd']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_destroy);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroy", "()V"));
			} finally {
			}
		}

		static Delegate cb_loadAd;
#pragma warning disable 0169
		static Delegate GetLoadAdHandler ()
		{
			if (cb_loadAd == null)
				cb_loadAd = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_LoadAd);
			return cb_loadAd;
		}

		static bool n_LoadAd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.ModelessInterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.ModelessInterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LoadAd ();
		}
#pragma warning restore 0169

		static IntPtr id_loadAd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ModelessInterstitialAd']/method[@name='loadAd' and count(parameter)=0]"
		[Register ("loadAd", "()Z", "GetLoadAdHandler")]
		public virtual unsafe bool LoadAd ()
		{
			if (id_loadAd == IntPtr.Zero)
				id_loadAd = JNIEnv.GetMethodID (class_ref, "loadAd", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_loadAd);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadAd", "()Z"));
			} finally {
			}
		}

		static Delegate cb_loadAd_Lcom_amazon_device_ads_AdTargetingOptions_;
#pragma warning disable 0169
		static Delegate GetLoadAd_Lcom_amazon_device_ads_AdTargetingOptions_Handler ()
		{
			if (cb_loadAd_Lcom_amazon_device_ads_AdTargetingOptions_ == null)
				cb_loadAd_Lcom_amazon_device_ads_AdTargetingOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_LoadAd_Lcom_amazon_device_ads_AdTargetingOptions_);
			return cb_loadAd_Lcom_amazon_device_ads_AdTargetingOptions_;
		}

		static bool n_LoadAd_Lcom_amazon_device_ads_AdTargetingOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Device.Ads.ModelessInterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.ModelessInterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Device.Ads.AdTargetingOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdTargetingOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.LoadAd (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadAd_Lcom_amazon_device_ads_AdTargetingOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ModelessInterstitialAd']/method[@name='loadAd' and count(parameter)=1 and parameter[1][@type='com.amazon.device.ads.AdTargetingOptions']]"
		[Register ("loadAd", "(Lcom/amazon/device/ads/AdTargetingOptions;)Z", "GetLoadAd_Lcom_amazon_device_ads_AdTargetingOptions_Handler")]
		public virtual unsafe bool LoadAd (global::Com.Amazon.Device.Ads.AdTargetingOptions p0)
		{
			if (id_loadAd_Lcom_amazon_device_ads_AdTargetingOptions_ == IntPtr.Zero)
				id_loadAd_Lcom_amazon_device_ads_AdTargetingOptions_ = JNIEnv.GetMethodID (class_ref, "loadAd", "(Lcom/amazon/device/ads/AdTargetingOptions;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_loadAd_Lcom_amazon_device_ads_AdTargetingOptions_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadAd", "(Lcom/amazon/device/ads/AdTargetingOptions;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setListener_Lcom_amazon_device_ads_AdListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_amazon_device_ads_AdListener_Handler ()
		{
			if (cb_setListener_Lcom_amazon_device_ads_AdListener_ == null)
				cb_setListener_Lcom_amazon_device_ads_AdListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lcom_amazon_device_ads_AdListener_);
			return cb_setListener_Lcom_amazon_device_ads_AdListener_;
		}

		static void n_SetListener_Lcom_amazon_device_ads_AdListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Device.Ads.ModelessInterstitialAd __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.ModelessInterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Device.Ads.IAdListener p0 = (global::Com.Amazon.Device.Ads.IAdListener)global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IAdListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setListener_Lcom_amazon_device_ads_AdListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ModelessInterstitialAd']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.amazon.device.ads.AdListener']]"
		[Register ("setListener", "(Lcom/amazon/device/ads/AdListener;)V", "GetSetListener_Lcom_amazon_device_ads_AdListener_Handler")]
		public virtual unsafe void SetListener (global::Com.Amazon.Device.Ads.IAdListener p0)
		{
			if (id_setListener_Lcom_amazon_device_ads_AdListener_ == IntPtr.Zero)
				id_setListener_Lcom_amazon_device_ads_AdListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/amazon/device/ads/AdListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setListener_Lcom_amazon_device_ads_AdListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListener", "(Lcom/amazon/device/ads/AdListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Amazon.Device.Ads.IAdListener"

		global::Com.Amazon.Device.Ads.IAdListenerImplementor __CreateIAdListenerImplementor ()
		{
			return new global::Com.Amazon.Device.Ads.IAdListenerImplementor (this);
		}
#endregion
	}
}
