using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='InterstitialCallbacks']"
	[Register ("com/appodeal/ads/InterstitialCallbacks", "", "Com.Appodeal.Ads.IInterstitialCallbacksInvoker")]
	public partial interface IInterstitialCallbacks : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='InterstitialCallbacks']/method[@name='onInterstitialClicked' and count(parameter)=0]"
		[Register ("onInterstitialClicked", "()V", "GetOnInterstitialClickedHandler:Com.Appodeal.Ads.IInterstitialCallbacksInvoker, AppodealXamarinPlugin")]
		void OnInterstitialClicked ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='InterstitialCallbacks']/method[@name='onInterstitialClosed' and count(parameter)=0]"
		[Register ("onInterstitialClosed", "()V", "GetOnInterstitialClosedHandler:Com.Appodeal.Ads.IInterstitialCallbacksInvoker, AppodealXamarinPlugin")]
		void OnInterstitialClosed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='InterstitialCallbacks']/method[@name='onInterstitialFailedToLoad' and count(parameter)=0]"
		[Register ("onInterstitialFailedToLoad", "()V", "GetOnInterstitialFailedToLoadHandler:Com.Appodeal.Ads.IInterstitialCallbacksInvoker, AppodealXamarinPlugin")]
		void OnInterstitialFailedToLoad ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='InterstitialCallbacks']/method[@name='onInterstitialLoaded' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onInterstitialLoaded", "(Z)V", "GetOnInterstitialLoaded_ZHandler:Com.Appodeal.Ads.IInterstitialCallbacksInvoker, AppodealXamarinPlugin")]
		void OnInterstitialLoaded (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='InterstitialCallbacks']/method[@name='onInterstitialShown' and count(parameter)=0]"
		[Register ("onInterstitialShown", "()V", "GetOnInterstitialShownHandler:Com.Appodeal.Ads.IInterstitialCallbacksInvoker, AppodealXamarinPlugin")]
		void OnInterstitialShown ();

	}

	[global::Android.Runtime.Register ("com/appodeal/ads/InterstitialCallbacks", DoNotGenerateAcw=true)]
	internal class IInterstitialCallbacksInvoker : global::Java.Lang.Object, IInterstitialCallbacks {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/appodeal/ads/InterstitialCallbacks");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IInterstitialCallbacksInvoker); }
		}

		IntPtr class_ref;

		public static IInterstitialCallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInterstitialCallbacks> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.appodeal.ads.InterstitialCallbacks"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInterstitialCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

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
			global::Com.Appodeal.Ads.IInterstitialCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.IInterstitialCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialClicked ();
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialClicked;
		public unsafe void OnInterstitialClicked ()
		{
			if (id_onInterstitialClicked == IntPtr.Zero)
				id_onInterstitialClicked = JNIEnv.GetMethodID (class_ref, "onInterstitialClicked", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onInterstitialClicked);
		}

		static Delegate cb_onInterstitialClosed;
#pragma warning disable 0169
		static Delegate GetOnInterstitialClosedHandler ()
		{
			if (cb_onInterstitialClosed == null)
				cb_onInterstitialClosed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialClosed);
			return cb_onInterstitialClosed;
		}

		static void n_OnInterstitialClosed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.IInterstitialCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.IInterstitialCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialClosed ();
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialClosed;
		public unsafe void OnInterstitialClosed ()
		{
			if (id_onInterstitialClosed == IntPtr.Zero)
				id_onInterstitialClosed = JNIEnv.GetMethodID (class_ref, "onInterstitialClosed", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onInterstitialClosed);
		}

		static Delegate cb_onInterstitialFailedToLoad;
#pragma warning disable 0169
		static Delegate GetOnInterstitialFailedToLoadHandler ()
		{
			if (cb_onInterstitialFailedToLoad == null)
				cb_onInterstitialFailedToLoad = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialFailedToLoad);
			return cb_onInterstitialFailedToLoad;
		}

		static void n_OnInterstitialFailedToLoad (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.IInterstitialCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.IInterstitialCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialFailedToLoad ();
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialFailedToLoad;
		public unsafe void OnInterstitialFailedToLoad ()
		{
			if (id_onInterstitialFailedToLoad == IntPtr.Zero)
				id_onInterstitialFailedToLoad = JNIEnv.GetMethodID (class_ref, "onInterstitialFailedToLoad", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onInterstitialFailedToLoad);
		}

		static Delegate cb_onInterstitialLoaded_Z;
#pragma warning disable 0169
		static Delegate GetOnInterstitialLoaded_ZHandler ()
		{
			if (cb_onInterstitialLoaded_Z == null)
				cb_onInterstitialLoaded_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnInterstitialLoaded_Z);
			return cb_onInterstitialLoaded_Z;
		}

		static void n_OnInterstitialLoaded_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Appodeal.Ads.IInterstitialCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.IInterstitialCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialLoaded (p0);
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialLoaded_Z;
		public unsafe void OnInterstitialLoaded (bool p0)
		{
			if (id_onInterstitialLoaded_Z == IntPtr.Zero)
				id_onInterstitialLoaded_Z = JNIEnv.GetMethodID (class_ref, "onInterstitialLoaded", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onInterstitialLoaded_Z, __args);
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
			global::Com.Appodeal.Ads.IInterstitialCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.IInterstitialCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialShown ();
		}
#pragma warning restore 0169

		IntPtr id_onInterstitialShown;
		public unsafe void OnInterstitialShown ()
		{
			if (id_onInterstitialShown == IntPtr.Zero)
				id_onInterstitialShown = JNIEnv.GetMethodID (class_ref, "onInterstitialShown", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onInterstitialShown);
		}

	}

}
