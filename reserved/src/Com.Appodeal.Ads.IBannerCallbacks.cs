using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='BannerCallbacks']"
	[Register ("com/appodeal/ads/BannerCallbacks", "", "Com.Appodeal.Ads.IBannerCallbacksInvoker")]
	public partial interface IBannerCallbacks : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='BannerCallbacks']/method[@name='onBannerClicked' and count(parameter)=0]"
		[Register ("onBannerClicked", "()V", "GetOnBannerClickedHandler:Com.Appodeal.Ads.IBannerCallbacksInvoker, AppodealXamarinPlugin")]
		void OnBannerClicked ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='BannerCallbacks']/method[@name='onBannerFailedToLoad' and count(parameter)=0]"
		[Register ("onBannerFailedToLoad", "()V", "GetOnBannerFailedToLoadHandler:Com.Appodeal.Ads.IBannerCallbacksInvoker, AppodealXamarinPlugin")]
		void OnBannerFailedToLoad ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='BannerCallbacks']/method[@name='onBannerLoaded' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("onBannerLoaded", "(IZ)V", "GetOnBannerLoaded_IZHandler:Com.Appodeal.Ads.IBannerCallbacksInvoker, AppodealXamarinPlugin")]
		void OnBannerLoaded (int p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='BannerCallbacks']/method[@name='onBannerShown' and count(parameter)=0]"
		[Register ("onBannerShown", "()V", "GetOnBannerShownHandler:Com.Appodeal.Ads.IBannerCallbacksInvoker, AppodealXamarinPlugin")]
		void OnBannerShown ();

	}

	[global::Android.Runtime.Register ("com/appodeal/ads/BannerCallbacks", DoNotGenerateAcw=true)]
	internal class IBannerCallbacksInvoker : global::Java.Lang.Object, IBannerCallbacks {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/appodeal/ads/BannerCallbacks");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBannerCallbacksInvoker); }
		}

		IntPtr class_ref;

		public static IBannerCallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBannerCallbacks> (handle, transfer);
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

		public IBannerCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Appodeal.Ads.IBannerCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.IBannerCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerClicked ();
		}
#pragma warning restore 0169

		IntPtr id_onBannerClicked;
		public unsafe void OnBannerClicked ()
		{
			if (id_onBannerClicked == IntPtr.Zero)
				id_onBannerClicked = JNIEnv.GetMethodID (class_ref, "onBannerClicked", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerClicked);
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
			global::Com.Appodeal.Ads.IBannerCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.IBannerCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerFailedToLoad ();
		}
#pragma warning restore 0169

		IntPtr id_onBannerFailedToLoad;
		public unsafe void OnBannerFailedToLoad ()
		{
			if (id_onBannerFailedToLoad == IntPtr.Zero)
				id_onBannerFailedToLoad = JNIEnv.GetMethodID (class_ref, "onBannerFailedToLoad", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerFailedToLoad);
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
			global::Com.Appodeal.Ads.IBannerCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.IBannerCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerLoaded (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onBannerLoaded_IZ;
		public unsafe void OnBannerLoaded (int p0, bool p1)
		{
			if (id_onBannerLoaded_IZ == IntPtr.Zero)
				id_onBannerLoaded_IZ = JNIEnv.GetMethodID (class_ref, "onBannerLoaded", "(IZ)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerLoaded_IZ, __args);
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
			global::Com.Appodeal.Ads.IBannerCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.IBannerCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBannerShown ();
		}
#pragma warning restore 0169

		IntPtr id_onBannerShown;
		public unsafe void OnBannerShown ()
		{
			if (id_onBannerShown == IntPtr.Zero)
				id_onBannerShown = JNIEnv.GetMethodID (class_ref, "onBannerShown", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerShown);
		}

	}

}
