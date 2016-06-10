using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Device.Ads {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='AdListener']"
	[Register ("com/amazon/device/ads/AdListener", "", "Com.Amazon.Device.Ads.IAdListenerInvoker")]
	public partial interface IAdListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='AdListener']/method[@name='onAdCollapsed' and count(parameter)=1 and parameter[1][@type='com.amazon.device.ads.Ad']]"
		[Register ("onAdCollapsed", "(Lcom/amazon/device/ads/Ad;)V", "GetOnAdCollapsed_Lcom_amazon_device_ads_Ad_Handler:Com.Amazon.Device.Ads.IAdListenerInvoker, AppodealXamarinPlugin")]
		void OnAdCollapsed (global::Com.Amazon.Device.Ads.IAd p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='AdListener']/method[@name='onAdDismissed' and count(parameter)=1 and parameter[1][@type='com.amazon.device.ads.Ad']]"
		[Register ("onAdDismissed", "(Lcom/amazon/device/ads/Ad;)V", "GetOnAdDismissed_Lcom_amazon_device_ads_Ad_Handler:Com.Amazon.Device.Ads.IAdListenerInvoker, AppodealXamarinPlugin")]
		void OnAdDismissed (global::Com.Amazon.Device.Ads.IAd p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='AdListener']/method[@name='onAdExpanded' and count(parameter)=1 and parameter[1][@type='com.amazon.device.ads.Ad']]"
		[Register ("onAdExpanded", "(Lcom/amazon/device/ads/Ad;)V", "GetOnAdExpanded_Lcom_amazon_device_ads_Ad_Handler:Com.Amazon.Device.Ads.IAdListenerInvoker, AppodealXamarinPlugin")]
		void OnAdExpanded (global::Com.Amazon.Device.Ads.IAd p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='AdListener']/method[@name='onAdFailedToLoad' and count(parameter)=2 and parameter[1][@type='com.amazon.device.ads.Ad'] and parameter[2][@type='com.amazon.device.ads.AdError']]"
		[Register ("onAdFailedToLoad", "(Lcom/amazon/device/ads/Ad;Lcom/amazon/device/ads/AdError;)V", "GetOnAdFailedToLoad_Lcom_amazon_device_ads_Ad_Lcom_amazon_device_ads_AdError_Handler:Com.Amazon.Device.Ads.IAdListenerInvoker, AppodealXamarinPlugin")]
		void OnAdFailedToLoad (global::Com.Amazon.Device.Ads.IAd p0, global::Com.Amazon.Device.Ads.AdError p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='AdListener']/method[@name='onAdLoaded' and count(parameter)=2 and parameter[1][@type='com.amazon.device.ads.Ad'] and parameter[2][@type='com.amazon.device.ads.AdProperties']]"
		[Register ("onAdLoaded", "(Lcom/amazon/device/ads/Ad;Lcom/amazon/device/ads/AdProperties;)V", "GetOnAdLoaded_Lcom_amazon_device_ads_Ad_Lcom_amazon_device_ads_AdProperties_Handler:Com.Amazon.Device.Ads.IAdListenerInvoker, AppodealXamarinPlugin")]
		void OnAdLoaded (global::Com.Amazon.Device.Ads.IAd p0, global::Com.Amazon.Device.Ads.AdProperties p1);

	}

	[global::Android.Runtime.Register ("com/amazon/device/ads/AdListener", DoNotGenerateAcw=true)]
	internal class IAdListenerInvoker : global::Java.Lang.Object, IAdListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/device/ads/AdListener");
		IntPtr class_ref;

		public static IAdListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.device.ads.AdListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdListenerInvoker); }
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
			global::Com.Amazon.Device.Ads.IAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Device.Ads.IAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Device.Ads.IAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Device.Ads.IAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Device.Ads.IAdListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.IAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	public partial class AdCollapsedEventArgs : global::System.EventArgs {

		public AdCollapsedEventArgs (global::Com.Amazon.Device.Ads.IAd p0)
		{
			this.p0 = p0;
		}

		global::Com.Amazon.Device.Ads.IAd p0;
		public global::Com.Amazon.Device.Ads.IAd P0 {
			get { return p0; }
		}
	}

	public partial class AdDismissedEventArgs : global::System.EventArgs {

		public AdDismissedEventArgs (global::Com.Amazon.Device.Ads.IAd p0)
		{
			this.p0 = p0;
		}

		global::Com.Amazon.Device.Ads.IAd p0;
		public global::Com.Amazon.Device.Ads.IAd P0 {
			get { return p0; }
		}
	}

	public partial class AdExpandedEventArgs : global::System.EventArgs {

		public AdExpandedEventArgs (global::Com.Amazon.Device.Ads.IAd p0)
		{
			this.p0 = p0;
		}

		global::Com.Amazon.Device.Ads.IAd p0;
		public global::Com.Amazon.Device.Ads.IAd P0 {
			get { return p0; }
		}
	}

	public partial class AdFailedToLoadEventArgs : global::System.EventArgs {

		public AdFailedToLoadEventArgs (global::Com.Amazon.Device.Ads.IAd p0, global::Com.Amazon.Device.Ads.AdError p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Amazon.Device.Ads.IAd p0;
		public global::Com.Amazon.Device.Ads.IAd P0 {
			get { return p0; }
		}

		global::Com.Amazon.Device.Ads.AdError p1;
		public global::Com.Amazon.Device.Ads.AdError P1 {
			get { return p1; }
		}
	}

	public partial class AdLoadedEventArgs : global::System.EventArgs {

		public AdLoadedEventArgs (global::Com.Amazon.Device.Ads.IAd p0, global::Com.Amazon.Device.Ads.AdProperties p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Amazon.Device.Ads.IAd p0;
		public global::Com.Amazon.Device.Ads.IAd P0 {
			get { return p0; }
		}

		global::Com.Amazon.Device.Ads.AdProperties p1;
		public global::Com.Amazon.Device.Ads.AdProperties P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/amazon/device/ads/AdListenerImplementor")]
	internal sealed partial class IAdListenerImplementor : global::Java.Lang.Object, IAdListener {

		object sender;

		public IAdListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amazon/device/ads/AdListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AdCollapsedEventArgs> OnAdCollapsedHandler;
#pragma warning restore 0649

		public void OnAdCollapsed (global::Com.Amazon.Device.Ads.IAd p0)
		{
			var __h = OnAdCollapsedHandler;
			if (__h != null)
				__h (sender, new AdCollapsedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<AdDismissedEventArgs> OnAdDismissedHandler;
#pragma warning restore 0649

		public void OnAdDismissed (global::Com.Amazon.Device.Ads.IAd p0)
		{
			var __h = OnAdDismissedHandler;
			if (__h != null)
				__h (sender, new AdDismissedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<AdExpandedEventArgs> OnAdExpandedHandler;
#pragma warning restore 0649

		public void OnAdExpanded (global::Com.Amazon.Device.Ads.IAd p0)
		{
			var __h = OnAdExpandedHandler;
			if (__h != null)
				__h (sender, new AdExpandedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoadHandler;
#pragma warning restore 0649

		public void OnAdFailedToLoad (global::Com.Amazon.Device.Ads.IAd p0, global::Com.Amazon.Device.Ads.AdError p1)
		{
			var __h = OnAdFailedToLoadHandler;
			if (__h != null)
				__h (sender, new AdFailedToLoadEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<AdLoadedEventArgs> OnAdLoadedHandler;
#pragma warning restore 0649

		public void OnAdLoaded (global::Com.Amazon.Device.Ads.IAd p0, global::Com.Amazon.Device.Ads.AdProperties p1)
		{
			var __h = OnAdLoadedHandler;
			if (__h != null)
				__h (sender, new AdLoadedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IAdListenerImplementor value)
		{
			return value.OnAdCollapsedHandler == null && value.OnAdDismissedHandler == null && value.OnAdExpandedHandler == null && value.OnAdFailedToLoadHandler == null && value.OnAdLoadedHandler == null;
		}
	}

}
