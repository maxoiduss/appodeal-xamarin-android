using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='MrecCallbacks']"
	[Register ("com/appodeal/ads/MrecCallbacks", "", "Com.Appodeal.Ads.IMrecCallbacksInvoker")]
	public partial interface IMrecCallbacks : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='MrecCallbacks']/method[@name='onMrecClicked' and count(parameter)=0]"
		[Register ("onMrecClicked", "()V", "GetOnMrecClickedHandler:Com.Appodeal.Ads.IMrecCallbacksInvoker, AppodealXamarinPlugin")]
		void OnMrecClicked ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='MrecCallbacks']/method[@name='onMrecFailedToLoad' and count(parameter)=0]"
		[Register ("onMrecFailedToLoad", "()V", "GetOnMrecFailedToLoadHandler:Com.Appodeal.Ads.IMrecCallbacksInvoker, AppodealXamarinPlugin")]
		void OnMrecFailedToLoad ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='MrecCallbacks']/method[@name='onMrecLoaded' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onMrecLoaded", "(Z)V", "GetOnMrecLoaded_ZHandler:Com.Appodeal.Ads.IMrecCallbacksInvoker, AppodealXamarinPlugin")]
		void OnMrecLoaded (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='MrecCallbacks']/method[@name='onMrecShown' and count(parameter)=0]"
		[Register ("onMrecShown", "()V", "GetOnMrecShownHandler:Com.Appodeal.Ads.IMrecCallbacksInvoker, AppodealXamarinPlugin")]
		void OnMrecShown ();

	}

	[global::Android.Runtime.Register ("com/appodeal/ads/MrecCallbacks", DoNotGenerateAcw=true)]
	internal class IMrecCallbacksInvoker : global::Java.Lang.Object, IMrecCallbacks {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/appodeal/ads/MrecCallbacks");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMrecCallbacksInvoker); }
		}

		IntPtr class_ref;

		public static IMrecCallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMrecCallbacks> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.appodeal.ads.MrecCallbacks"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMrecCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onMrecClicked;
#pragma warning disable 0169
		static Delegate GetOnMrecClickedHandler ()
		{
			if (cb_onMrecClicked == null)
				cb_onMrecClicked = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMrecClicked);
			return cb_onMrecClicked;
		}

		static void n_OnMrecClicked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.IMrecCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.IMrecCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMrecClicked ();
		}
#pragma warning restore 0169

		IntPtr id_onMrecClicked;
		public unsafe void OnMrecClicked ()
		{
			if (id_onMrecClicked == IntPtr.Zero)
				id_onMrecClicked = JNIEnv.GetMethodID (class_ref, "onMrecClicked", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMrecClicked);
		}

		static Delegate cb_onMrecFailedToLoad;
#pragma warning disable 0169
		static Delegate GetOnMrecFailedToLoadHandler ()
		{
			if (cb_onMrecFailedToLoad == null)
				cb_onMrecFailedToLoad = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMrecFailedToLoad);
			return cb_onMrecFailedToLoad;
		}

		static void n_OnMrecFailedToLoad (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.IMrecCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.IMrecCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMrecFailedToLoad ();
		}
#pragma warning restore 0169

		IntPtr id_onMrecFailedToLoad;
		public unsafe void OnMrecFailedToLoad ()
		{
			if (id_onMrecFailedToLoad == IntPtr.Zero)
				id_onMrecFailedToLoad = JNIEnv.GetMethodID (class_ref, "onMrecFailedToLoad", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMrecFailedToLoad);
		}

		static Delegate cb_onMrecLoaded_Z;
#pragma warning disable 0169
		static Delegate GetOnMrecLoaded_ZHandler ()
		{
			if (cb_onMrecLoaded_Z == null)
				cb_onMrecLoaded_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnMrecLoaded_Z);
			return cb_onMrecLoaded_Z;
		}

		static void n_OnMrecLoaded_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Appodeal.Ads.IMrecCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.IMrecCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMrecLoaded (p0);
		}
#pragma warning restore 0169

		IntPtr id_onMrecLoaded_Z;
		public unsafe void OnMrecLoaded (bool p0)
		{
			if (id_onMrecLoaded_Z == IntPtr.Zero)
				id_onMrecLoaded_Z = JNIEnv.GetMethodID (class_ref, "onMrecLoaded", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMrecLoaded_Z, __args);
		}

		static Delegate cb_onMrecShown;
#pragma warning disable 0169
		static Delegate GetOnMrecShownHandler ()
		{
			if (cb_onMrecShown == null)
				cb_onMrecShown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMrecShown);
			return cb_onMrecShown;
		}

		static void n_OnMrecShown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.IMrecCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.IMrecCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMrecShown ();
		}
#pragma warning restore 0169

		IntPtr id_onMrecShown;
		public unsafe void OnMrecShown ()
		{
			if (id_onMrecShown == IntPtr.Zero)
				id_onMrecShown = JNIEnv.GetMethodID (class_ref, "onMrecShown", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMrecShown);
		}

	}

}
