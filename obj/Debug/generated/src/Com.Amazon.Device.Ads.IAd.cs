using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Device.Ads {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='Ad']"
	[Register ("com/amazon/device/ads/Ad", "", "Com.Amazon.Device.Ads.IAdInvoker")]
	public partial interface IAd : IJavaObject {

		bool IsLoading {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='Ad']/method[@name='isLoading' and count(parameter)=0]"
			[Register ("isLoading", "()Z", "GetIsLoadingHandler:Com.Amazon.Device.Ads.IAdInvoker, AppodealXamarinPlugin")] get;
		}

		int Timeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='Ad']/method[@name='getTimeout' and count(parameter)=0]"
			[Register ("getTimeout", "()I", "GetGetTimeoutHandler:Com.Amazon.Device.Ads.IAdInvoker, AppodealXamarinPlugin")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='Ad']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTimeout", "(I)V", "GetSetTimeout_IHandler:Com.Amazon.Device.Ads.IAdInvoker, AppodealXamarinPlugin")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='Ad']/method[@name='loadAd' and count(parameter)=0]"
		[Register ("loadAd", "()Z", "GetLoadAdHandler:Com.Amazon.Device.Ads.IAdInvoker, AppodealXamarinPlugin")]
		bool LoadAd ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='Ad']/method[@name='loadAd' and count(parameter)=1 and parameter[1][@type='com.amazon.device.ads.AdTargetingOptions']]"
		[Register ("loadAd", "(Lcom/amazon/device/ads/AdTargetingOptions;)Z", "GetLoadAd_Lcom_amazon_device_ads_AdTargetingOptions_Handler:Com.Amazon.Device.Ads.IAdInvoker, AppodealXamarinPlugin")]
		bool LoadAd (global::Com.Amazon.Device.Ads.AdTargetingOptions p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='Ad']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.amazon.device.ads.AdListener']]"
		[Register ("setListener", "(Lcom/amazon/device/ads/AdListener;)V", "GetSetListener_Lcom_amazon_device_ads_AdListener_Handler:Com.Amazon.Device.Ads.IAdInvoker, AppodealXamarinPlugin")]
		void SetListener (global::Com.Amazon.Device.Ads.IAdListener p0);

	}

	[global::Android.Runtime.Register ("com/amazon/device/ads/Ad", DoNotGenerateAcw=true)]
	internal class IAdInvoker : global::Java.Lang.Object, IAd {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/device/ads/Ad");
		IntPtr class_ref;

		public static IAd GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAd> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.device.ads.Ad"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdInvoker); }
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
			global::Com.Amazon.Device.Ads.IAd __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLoading;
		}
#pragma warning restore 0169

		IntPtr id_isLoading;
		public unsafe bool IsLoading {
			get {
				if (id_isLoading == IntPtr.Zero)
					id_isLoading = JNIEnv.GetMethodID (class_ref, "isLoading", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isLoading);
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
			global::Com.Amazon.Device.Ads.IAd __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Device.Ads.IAd __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Timeout = p0;
		}
#pragma warning restore 0169

		IntPtr id_getTimeout;
		IntPtr id_setTimeout_I;
		public unsafe int Timeout {
			get {
				if (id_getTimeout == IntPtr.Zero)
					id_getTimeout = JNIEnv.GetMethodID (class_ref, "getTimeout", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getTimeout);
			}
			set {
				if (id_setTimeout_I == IntPtr.Zero)
					id_setTimeout_I = JNIEnv.GetMethodID (class_ref, "setTimeout", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (Handle, id_setTimeout_I, __args);
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
			global::Com.Amazon.Device.Ads.IAd __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LoadAd ();
		}
#pragma warning restore 0169

		IntPtr id_loadAd;
		public unsafe bool LoadAd ()
		{
			if (id_loadAd == IntPtr.Zero)
				id_loadAd = JNIEnv.GetMethodID (class_ref, "loadAd", "()Z");
			return JNIEnv.CallBooleanMethod (Handle, id_loadAd);
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
			global::Com.Amazon.Device.Ads.IAd __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Device.Ads.AdTargetingOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdTargetingOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.LoadAd (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_loadAd_Lcom_amazon_device_ads_AdTargetingOptions_;
		public unsafe bool LoadAd (global::Com.Amazon.Device.Ads.AdTargetingOptions p0)
		{
			if (id_loadAd_Lcom_amazon_device_ads_AdTargetingOptions_ == IntPtr.Zero)
				id_loadAd_Lcom_amazon_device_ads_AdTargetingOptions_ = JNIEnv.GetMethodID (class_ref, "loadAd", "(Lcom/amazon/device/ads/AdTargetingOptions;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_loadAd_Lcom_amazon_device_ads_AdTargetingOptions_, __args);
			return __ret;
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
			global::Com.Amazon.Device.Ads.IAd __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Device.Ads.IAdListener p0 = (global::Com.Amazon.Device.Ads.IAdListener)global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IAdListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setListener_Lcom_amazon_device_ads_AdListener_;
		public unsafe void SetListener (global::Com.Amazon.Device.Ads.IAdListener p0)
		{
			if (id_setListener_Lcom_amazon_device_ads_AdListener_ == IntPtr.Zero)
				id_setListener_Lcom_amazon_device_ads_AdListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/amazon/device/ads/AdListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_setListener_Lcom_amazon_device_ads_AdListener_, __args);
		}

	}

}
