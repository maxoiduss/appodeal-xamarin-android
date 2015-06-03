using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='BannerCallbacks']"
	[Register ("com/appodeal/ads/BannerCallbacks", "", "Com.Appodeal.Ads.BannerCallbacksInvoker")]
	public partial interface BannerCallbacks : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='BannerCallbacks']/method[@name='onBannerClicked' and count(parameter)=0]"
		[Register ("onBannerClicked", "()V", "GetOnBannerClickedHandler:Com.Appodeal.Ads.BannerCallbacksInvoker, AppodealXamarinPlugin")]
		void OnBannerClicked ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='BannerCallbacks']/method[@name='onBannerFailedToLoad' and count(parameter)=0]"
		[Register ("onBannerFailedToLoad", "()V", "GetOnBannerFailedToLoadHandler:Com.Appodeal.Ads.BannerCallbacksInvoker, AppodealXamarinPlugin")]
		void OnBannerFailedToLoad ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='BannerCallbacks']/method[@name='onBannerLoaded' and count(parameter)=0]"
		[Register ("onBannerLoaded", "()V", "GetOnBannerLoadedHandler:Com.Appodeal.Ads.BannerCallbacksInvoker, AppodealXamarinPlugin")]
		void OnBannerLoaded ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='BannerCallbacks']/method[@name='onBannerShown' and count(parameter)=0]"
		[Register ("onBannerShown", "()V", "GetOnBannerShownHandler:Com.Appodeal.Ads.BannerCallbacksInvoker, AppodealXamarinPlugin")]
		void OnBannerShown ();

	}

	[global::Android.Runtime.Register ("com/appodeal/ads/BannerCallbacks", DoNotGenerateAcw=true)]
	internal class BannerCallbacksInvoker : global::Java.Lang.Object, BannerCallbacks {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/appodeal/ads/BannerCallbacks");
		IntPtr class_ref;

		public static BannerCallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<BannerCallbacks> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.appodeal.ads.BannerCallbacks"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public BannerCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (BannerCallbacksInvoker); }
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
			global::Com.Appodeal.Ads.BannerCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.BannerCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerClicked ();
		}
#pragma warning restore 0169

		IntPtr id_onBannerClicked;
		public unsafe void OnBannerClicked ()
		{
			if (id_onBannerClicked == IntPtr.Zero)
				id_onBannerClicked = JNIEnv.GetMethodID (class_ref, "onBannerClicked", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onBannerClicked);
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
			global::Com.Appodeal.Ads.BannerCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.BannerCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerFailedToLoad ();
		}
#pragma warning restore 0169

		IntPtr id_onBannerFailedToLoad;
		public unsafe void OnBannerFailedToLoad ()
		{
			if (id_onBannerFailedToLoad == IntPtr.Zero)
				id_onBannerFailedToLoad = JNIEnv.GetMethodID (class_ref, "onBannerFailedToLoad", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onBannerFailedToLoad);
		}

		static Delegate cb_onBannerLoaded;
#pragma warning disable 0169
		static Delegate GetOnBannerLoadedHandler ()
		{
			if (cb_onBannerLoaded == null)
				cb_onBannerLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBannerLoaded);
			return cb_onBannerLoaded;
		}

		static void n_OnBannerLoaded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.BannerCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.BannerCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerLoaded ();
		}
#pragma warning restore 0169

		IntPtr id_onBannerLoaded;
		public unsafe void OnBannerLoaded ()
		{
			if (id_onBannerLoaded == IntPtr.Zero)
				id_onBannerLoaded = JNIEnv.GetMethodID (class_ref, "onBannerLoaded", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onBannerLoaded);
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
			global::Com.Appodeal.Ads.BannerCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.BannerCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerShown ();
		}
#pragma warning restore 0169

		IntPtr id_onBannerShown;
		public unsafe void OnBannerShown ()
		{
			if (id_onBannerShown == IntPtr.Zero)
				id_onBannerShown = JNIEnv.GetMethodID (class_ref, "onBannerShown", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onBannerShown);
		}

	}

}
