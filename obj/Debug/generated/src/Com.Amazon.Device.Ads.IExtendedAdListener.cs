using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Device.Ads {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='ExtendedAdListener']"
	[Register ("com/amazon/device/ads/ExtendedAdListener", "", "Com.Amazon.Device.Ads.IExtendedAdListenerInvoker")]
	public partial interface IExtendedAdListener : global::Com.Amazon.Device.Ads.IAdListener {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='ExtendedAdListener']/method[@name='onAdExpired' and count(parameter)=1 and parameter[1][@type='com.amazon.device.ads.Ad']]"
		[Register ("onAdExpired", "(Lcom/amazon/device/ads/Ad;)V", "GetOnAdExpired_Lcom_amazon_device_ads_Ad_Handler:Com.Amazon.Device.Ads.IExtendedAdListenerInvoker, AppodealXamarinPlugin")]
		void OnAdExpired (global::Com.Amazon.Device.Ads.IAd p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='ExtendedAdListener']/method[@name='onAdResized' and count(parameter)=2 and parameter[1][@type='com.amazon.device.ads.Ad'] and parameter[2][@type='android.graphics.Rect']]"
		[Register ("onAdResized", "(Lcom/amazon/device/ads/Ad;Landroid/graphics/Rect;)V", "GetOnAdResized_Lcom_amazon_device_ads_Ad_Landroid_graphics_Rect_Handler:Com.Amazon.Device.Ads.IExtendedAdListenerInvoker, AppodealXamarinPlugin")]
		void OnAdResized (global::Com.Amazon.Device.Ads.IAd p0, global::Android.Graphics.Rect p1);

	}

	[global::Android.Runtime.Register ("com/amazon/device/ads/ExtendedAdListener", DoNotGenerateAcw=true)]
	internal class IExtendedAdListenerInvoker : global::Java.Lang.Object, IExtendedAdListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/device/ads/ExtendedAdListener");
		IntPtr class_ref;

		public static IExtendedAdListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExtendedAdListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.device.ads.ExtendedAdListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExtendedAdListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IExtendedAdListenerInvoker); }
		}

		static Delegate cb_onAdExpired_Lcom_amazon_device_ads_Ad_;
#pragma warning disable 0169
		static Delegate GetOnAdExpired_Lcom_amazon_device_ads_Ad_Handler ()
		{
			if (cb_onAdExpired_Lcom_amazon_device_ads_Ad_ == null)
				cb_onAdExpired_Lcom_amazon_device_ads_Ad_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAdExpired_Lcom_amazon_device_ads_Ad_);
			return cb_onAdExpired_Lcom_amazon_device_ads_Ad_;
		}

		static void n_OnAdExpired_Lcom_amazon_device_ads_Ad_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Device.Ads.IExtendedAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IExtendedAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Device.Ads.IAd p0 = (global::Com.Amazon.Device.Ads.IAd)global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IAd> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdExpired (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdExpired_Lcom_amazon_device_ads_Ad_;
		public unsafe void OnAdExpired (global::Com.Amazon.Device.Ads.IAd p0)
		{
			if (id_onAdExpired_Lcom_amazon_device_ads_Ad_ == IntPtr.Zero)
				id_onAdExpired_Lcom_amazon_device_ads_Ad_ = JNIEnv.GetMethodID (class_ref, "onAdExpired", "(Lcom/amazon/device/ads/Ad;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onAdExpired_Lcom_amazon_device_ads_Ad_, __args);
		}

		static Delegate cb_onAdResized_Lcom_amazon_device_ads_Ad_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetOnAdResized_Lcom_amazon_device_ads_Ad_Landroid_graphics_Rect_Handler ()
		{
			if (cb_onAdResized_Lcom_amazon_device_ads_Ad_Landroid_graphics_Rect_ == null)
				cb_onAdResized_Lcom_amazon_device_ads_Ad_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAdResized_Lcom_amazon_device_ads_Ad_Landroid_graphics_Rect_);
			return cb_onAdResized_Lcom_amazon_device_ads_Ad_Landroid_graphics_Rect_;
		}

		static void n_OnAdResized_Lcom_amazon_device_ads_Ad_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Device.Ads.IExtendedAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IExtendedAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Device.Ads.IAd p0 = (global::Com.Amazon.Device.Ads.IAd)global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IAd> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAdResized (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAdResized_Lcom_amazon_device_ads_Ad_Landroid_graphics_Rect_;
		public unsafe void OnAdResized (global::Com.Amazon.Device.Ads.IAd p0, global::Android.Graphics.Rect p1)
		{
			if (id_onAdResized_Lcom_amazon_device_ads_Ad_Landroid_graphics_Rect_ == IntPtr.Zero)
				id_onAdResized_Lcom_amazon_device_ads_Ad_Landroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "onAdResized", "(Lcom/amazon/device/ads/Ad;Landroid/graphics/Rect;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onAdResized_Lcom_amazon_device_ads_Ad_Landroid_graphics_Rect_, __args);
		}

		static Delegate cb_onAdCollapsed_Lcom_amazon_device_ads_Ad_;
#pragma warning disable 0169
		static Delegate GetOnAdCollapsed_Lcom_amazon_device_ads_Ad_Handler ()
		{
			if (cb_onAdCollapsed_Lcom_amazon_device_ads_Ad_ == null)
				cb_onAdCollapsed_Lcom_amazon_device_ads_Ad_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAdCollapsed_Lcom_amazon_device_ads_Ad_);
			return cb_onAdCollapsed_Lcom_amazon_device_ads_Ad_;
		}

		static void n_OnAdCollapsed_Lcom_amazon_device_ads_Ad_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Device.Ads.IExtendedAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IExtendedAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Device.Ads.IAd p0 = (global::Com.Amazon.Device.Ads.IAd)global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IAd> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdCollapsed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdCollapsed_Lcom_amazon_device_ads_Ad_;
		public unsafe void OnAdCollapsed (global::Com.Amazon.Device.Ads.IAd p0)
		{
			if (id_onAdCollapsed_Lcom_amazon_device_ads_Ad_ == IntPtr.Zero)
				id_onAdCollapsed_Lcom_amazon_device_ads_Ad_ = JNIEnv.GetMethodID (class_ref, "onAdCollapsed", "(Lcom/amazon/device/ads/Ad;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onAdCollapsed_Lcom_amazon_device_ads_Ad_, __args);
		}

		static Delegate cb_onAdDismissed_Lcom_amazon_device_ads_Ad_;
#pragma warning disable 0169
		static Delegate GetOnAdDismissed_Lcom_amazon_device_ads_Ad_Handler ()
		{
			if (cb_onAdDismissed_Lcom_amazon_device_ads_Ad_ == null)
				cb_onAdDismissed_Lcom_amazon_device_ads_Ad_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAdDismissed_Lcom_amazon_device_ads_Ad_);
			return cb_onAdDismissed_Lcom_amazon_device_ads_Ad_;
		}

		static void n_OnAdDismissed_Lcom_amazon_device_ads_Ad_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Device.Ads.IExtendedAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IExtendedAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Device.Ads.IAd p0 = (global::Com.Amazon.Device.Ads.IAd)global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IAd> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdDismissed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdDismissed_Lcom_amazon_device_ads_Ad_;
		public unsafe void OnAdDismissed (global::Com.Amazon.Device.Ads.IAd p0)
		{
			if (id_onAdDismissed_Lcom_amazon_device_ads_Ad_ == IntPtr.Zero)
				id_onAdDismissed_Lcom_amazon_device_ads_Ad_ = JNIEnv.GetMethodID (class_ref, "onAdDismissed", "(Lcom/amazon/device/ads/Ad;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onAdDismissed_Lcom_amazon_device_ads_Ad_, __args);
		}

		static Delegate cb_onAdExpanded_Lcom_amazon_device_ads_Ad_;
#pragma warning disable 0169
		static Delegate GetOnAdExpanded_Lcom_amazon_device_ads_Ad_Handler ()
		{
			if (cb_onAdExpanded_Lcom_amazon_device_ads_Ad_ == null)
				cb_onAdExpanded_Lcom_amazon_device_ads_Ad_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAdExpanded_Lcom_amazon_device_ads_Ad_);
			return cb_onAdExpanded_Lcom_amazon_device_ads_Ad_;
		}

		static void n_OnAdExpanded_Lcom_amazon_device_ads_Ad_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Device.Ads.IExtendedAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IExtendedAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Device.Ads.IAd p0 = (global::Com.Amazon.Device.Ads.IAd)global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IAd> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdExpanded (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdExpanded_Lcom_amazon_device_ads_Ad_;
		public unsafe void OnAdExpanded (global::Com.Amazon.Device.Ads.IAd p0)
		{
			if (id_onAdExpanded_Lcom_amazon_device_ads_Ad_ == IntPtr.Zero)
				id_onAdExpanded_Lcom_amazon_device_ads_Ad_ = JNIEnv.GetMethodID (class_ref, "onAdExpanded", "(Lcom/amazon/device/ads/Ad;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onAdExpanded_Lcom_amazon_device_ads_Ad_, __args);
		}

		static Delegate cb_onAdFailedToLoad_Lcom_amazon_device_ads_Ad_Lcom_amazon_device_ads_AdError_;
#pragma warning disable 0169
		static Delegate GetOnAdFailedToLoad_Lcom_amazon_device_ads_Ad_Lcom_amazon_device_ads_AdError_Handler ()
		{
			if (cb_onAdFailedToLoad_Lcom_amazon_device_ads_Ad_Lcom_amazon_device_ads_AdError_ == null)
				cb_onAdFailedToLoad_Lcom_amazon_device_ads_Ad_Lcom_amazon_device_ads_AdError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAdFailedToLoad_Lcom_amazon_device_ads_Ad_Lcom_amazon_device_ads_AdError_);
			return cb_onAdFailedToLoad_Lcom_amazon_device_ads_Ad_Lcom_amazon_device_ads_AdError_;
		}

		static void n_OnAdFailedToLoad_Lcom_amazon_device_ads_Ad_Lcom_amazon_device_ads_AdError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Device.Ads.IExtendedAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IExtendedAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Device.Ads.IAd p0 = (global::Com.Amazon.Device.Ads.IAd)global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IAd> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Device.Ads.AdError p1 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdError> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAdFailedToLoad (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAdFailedToLoad_Lcom_amazon_device_ads_Ad_Lcom_amazon_device_ads_AdError_;
		public unsafe void OnAdFailedToLoad (global::Com.Amazon.Device.Ads.IAd p0, global::Com.Amazon.Device.Ads.AdError p1)
		{
			if (id_onAdFailedToLoad_Lcom_amazon_device_ads_Ad_Lcom_amazon_device_ads_AdError_ == IntPtr.Zero)
				id_onAdFailedToLoad_Lcom_amazon_device_ads_Ad_Lcom_amazon_device_ads_AdError_ = JNIEnv.GetMethodID (class_ref, "onAdFailedToLoad", "(Lcom/amazon/device/ads/Ad;Lcom/amazon/device/ads/AdError;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onAdFailedToLoad_Lcom_amazon_device_ads_Ad_Lcom_amazon_device_ads_AdError_, __args);
		}

		static Delegate cb_onAdLoaded_Lcom_amazon_device_ads_Ad_Lcom_amazon_device_ads_AdProperties_;
#pragma warning disable 0169
		static Delegate GetOnAdLoaded_Lcom_amazon_device_ads_Ad_Lcom_amazon_device_ads_AdProperties_Handler ()
		{
			if (cb_onAdLoaded_Lcom_amazon_device_ads_Ad_Lcom_amazon_device_ads_AdProperties_ == null)
				cb_onAdLoaded_Lcom_amazon_device_ads_Ad_Lcom_amazon_device_ads_AdProperties_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAdLoaded_Lcom_amazon_device_ads_Ad_Lcom_amazon_device_ads_AdProperties_);
			return cb_onAdLoaded_Lcom_amazon_device_ads_Ad_Lcom_amazon_device_ads_AdProperties_;
		}

		static void n_OnAdLoaded_Lcom_amazon_device_ads_Ad_Lcom_amazon_device_ads_AdProperties_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Device.Ads.IExtendedAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IExtendedAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Device.Ads.IAd p0 = (global::Com.Amazon.Device.Ads.IAd)global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IAd> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Device.Ads.AdProperties p1 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdProperties> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAdLoaded (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAdLoaded_Lcom_amazon_device_ads_Ad_Lcom_amazon_device_ads_AdProperties_;
		public unsafe void OnAdLoaded (global::Com.Amazon.Device.Ads.IAd p0, global::Com.Amazon.Device.Ads.AdProperties p1)
		{
			if (id_onAdLoaded_Lcom_amazon_device_ads_Ad_Lcom_amazon_device_ads_AdProperties_ == IntPtr.Zero)
				id_onAdLoaded_Lcom_amazon_device_ads_Ad_Lcom_amazon_device_ads_AdProperties_ = JNIEnv.GetMethodID (class_ref, "onAdLoaded", "(Lcom/amazon/device/ads/Ad;Lcom/amazon/device/ads/AdProperties;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onAdLoaded_Lcom_amazon_device_ads_Ad_Lcom_amazon_device_ads_AdProperties_, __args);
		}

	}

}
