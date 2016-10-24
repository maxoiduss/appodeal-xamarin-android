using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeAdBoxListener']"
	[Register ("com/appodeal/ads/NativeAdBoxListener", "", "Com.Appodeal.Ads.INativeAdBoxListenerInvoker")]
	public partial interface INativeAdBoxListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeAdBoxListener']/method[@name='onNativeAdBoxLoaded' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onNativeAdBoxLoaded", "(I)V", "GetOnNativeAdBoxLoaded_IHandler:Com.Appodeal.Ads.INativeAdBoxListenerInvoker, AppodealXamarinPlugin")]
		void OnNativeAdBoxLoaded (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeAdBoxListener']/method[@name='onNativeClicked' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.NativeAd']]"
		[Register ("onNativeClicked", "(Lcom/appodeal/ads/NativeAd;)V", "GetOnNativeClicked_Lcom_appodeal_ads_NativeAd_Handler:Com.Appodeal.Ads.INativeAdBoxListenerInvoker, AppodealXamarinPlugin")]
		void OnNativeClicked (global::Com.Appodeal.Ads.INativeAd p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeAdBoxListener']/method[@name='onNativeShown' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.NativeAd']]"
		[Register ("onNativeShown", "(Lcom/appodeal/ads/NativeAd;)V", "GetOnNativeShown_Lcom_appodeal_ads_NativeAd_Handler:Com.Appodeal.Ads.INativeAdBoxListenerInvoker, AppodealXamarinPlugin")]
		void OnNativeShown (global::Com.Appodeal.Ads.INativeAd p0);

	}

	[global::Android.Runtime.Register ("com/appodeal/ads/NativeAdBoxListener", DoNotGenerateAcw=true)]
	internal class INativeAdBoxListenerInvoker : global::Java.Lang.Object, INativeAdBoxListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/appodeal/ads/NativeAdBoxListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (INativeAdBoxListenerInvoker); }
		}

		IntPtr class_ref;

		public static INativeAdBoxListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INativeAdBoxListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.appodeal.ads.NativeAdBoxListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INativeAdBoxListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onNativeAdBoxLoaded_I;
#pragma warning disable 0169
		static Delegate GetOnNativeAdBoxLoaded_IHandler ()
		{
			if (cb_onNativeAdBoxLoaded_I == null)
				cb_onNativeAdBoxLoaded_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnNativeAdBoxLoaded_I);
			return cb_onNativeAdBoxLoaded_I;
		}

		static void n_OnNativeAdBoxLoaded_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Appodeal.Ads.INativeAdBoxListener __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeAdBoxListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNativeAdBoxLoaded (p0);
		}
#pragma warning restore 0169

		IntPtr id_onNativeAdBoxLoaded_I;
		public unsafe void OnNativeAdBoxLoaded (int p0)
		{
			if (id_onNativeAdBoxLoaded_I == IntPtr.Zero)
				id_onNativeAdBoxLoaded_I = JNIEnv.GetMethodID (class_ref, "onNativeAdBoxLoaded", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeAdBoxLoaded_I, __args);
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
			global::Com.Appodeal.Ads.INativeAdBoxListener __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeAdBoxListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Appodeal.Ads.INativeAd p0 = (global::Com.Appodeal.Ads.INativeAd)global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeAd> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNativeClicked (p0);
		}
#pragma warning restore 0169

		IntPtr id_onNativeClicked_Lcom_appodeal_ads_NativeAd_;
		public unsafe void OnNativeClicked (global::Com.Appodeal.Ads.INativeAd p0)
		{
			if (id_onNativeClicked_Lcom_appodeal_ads_NativeAd_ == IntPtr.Zero)
				id_onNativeClicked_Lcom_appodeal_ads_NativeAd_ = JNIEnv.GetMethodID (class_ref, "onNativeClicked", "(Lcom/appodeal/ads/NativeAd;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeClicked_Lcom_appodeal_ads_NativeAd_, __args);
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
			global::Com.Appodeal.Ads.INativeAdBoxListener __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeAdBoxListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Appodeal.Ads.INativeAd p0 = (global::Com.Appodeal.Ads.INativeAd)global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeAd> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNativeShown (p0);
		}
#pragma warning restore 0169

		IntPtr id_onNativeShown_Lcom_appodeal_ads_NativeAd_;
		public unsafe void OnNativeShown (global::Com.Appodeal.Ads.INativeAd p0)
		{
			if (id_onNativeShown_Lcom_appodeal_ads_NativeAd_ == IntPtr.Zero)
				id_onNativeShown_Lcom_appodeal_ads_NativeAd_ = JNIEnv.GetMethodID (class_ref, "onNativeShown", "(Lcom/appodeal/ads/NativeAd;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeShown_Lcom_appodeal_ads_NativeAd_, __args);
		}

	}

	public partial class NativeAdBoxLoadedEventArgs : global::System.EventArgs {

		public NativeAdBoxLoadedEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	public partial class NativeClickedEventArgs : global::System.EventArgs {

		public NativeClickedEventArgs (global::Com.Appodeal.Ads.INativeAd p0)
		{
			this.p0 = p0;
		}

		global::Com.Appodeal.Ads.INativeAd p0;
		public global::Com.Appodeal.Ads.INativeAd P0 {
			get { return p0; }
		}
	}

	public partial class NativeShownEventArgs : global::System.EventArgs {

		public NativeShownEventArgs (global::Com.Appodeal.Ads.INativeAd p0)
		{
			this.p0 = p0;
		}

		global::Com.Appodeal.Ads.INativeAd p0;
		public global::Com.Appodeal.Ads.INativeAd P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/appodeal/ads/NativeAdBoxListenerImplementor")]
	internal sealed partial class INativeAdBoxListenerImplementor : global::Java.Lang.Object, INativeAdBoxListener {

		object sender;

		public INativeAdBoxListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/appodeal/ads/NativeAdBoxListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<NativeAdBoxLoadedEventArgs> OnNativeAdBoxLoadedHandler;
#pragma warning restore 0649

		public void OnNativeAdBoxLoaded (int p0)
		{
			var __h = OnNativeAdBoxLoadedHandler;
			if (__h != null)
				__h (sender, new NativeAdBoxLoadedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<NativeClickedEventArgs> OnNativeClickedHandler;
#pragma warning restore 0649

		public void OnNativeClicked (global::Com.Appodeal.Ads.INativeAd p0)
		{
			var __h = OnNativeClickedHandler;
			if (__h != null)
				__h (sender, new NativeClickedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<NativeShownEventArgs> OnNativeShownHandler;
#pragma warning restore 0649

		public void OnNativeShown (global::Com.Appodeal.Ads.INativeAd p0)
		{
			var __h = OnNativeShownHandler;
			if (__h != null)
				__h (sender, new NativeShownEventArgs (p0));
		}

		internal static bool __IsEmpty (INativeAdBoxListenerImplementor value)
		{
			return value.OnNativeAdBoxLoadedHandler == null && value.OnNativeClickedHandler == null && value.OnNativeShownHandler == null;
		}
	}

}
