using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NonSkippableVideoCallbacks']"
	[Register ("com/appodeal/ads/NonSkippableVideoCallbacks", "", "Com.Appodeal.Ads.INonSkippableVideoCallbacksInvoker")]
	public partial interface INonSkippableVideoCallbacks : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NonSkippableVideoCallbacks']/method[@name='onNonSkippableVideoClosed' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onNonSkippableVideoClosed", "(Z)V", "GetOnNonSkippableVideoClosed_ZHandler:Com.Appodeal.Ads.INonSkippableVideoCallbacksInvoker, AppodealXamarinPlugin")]
		void OnNonSkippableVideoClosed (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NonSkippableVideoCallbacks']/method[@name='onNonSkippableVideoFailedToLoad' and count(parameter)=0]"
		[Register ("onNonSkippableVideoFailedToLoad", "()V", "GetOnNonSkippableVideoFailedToLoadHandler:Com.Appodeal.Ads.INonSkippableVideoCallbacksInvoker, AppodealXamarinPlugin")]
		void OnNonSkippableVideoFailedToLoad ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NonSkippableVideoCallbacks']/method[@name='onNonSkippableVideoFinished' and count(parameter)=0]"
		[Register ("onNonSkippableVideoFinished", "()V", "GetOnNonSkippableVideoFinishedHandler:Com.Appodeal.Ads.INonSkippableVideoCallbacksInvoker, AppodealXamarinPlugin")]
		void OnNonSkippableVideoFinished ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NonSkippableVideoCallbacks']/method[@name='onNonSkippableVideoLoaded' and count(parameter)=0]"
		[Register ("onNonSkippableVideoLoaded", "()V", "GetOnNonSkippableVideoLoadedHandler:Com.Appodeal.Ads.INonSkippableVideoCallbacksInvoker, AppodealXamarinPlugin")]
		void OnNonSkippableVideoLoaded ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NonSkippableVideoCallbacks']/method[@name='onNonSkippableVideoShown' and count(parameter)=0]"
		[Register ("onNonSkippableVideoShown", "()V", "GetOnNonSkippableVideoShownHandler:Com.Appodeal.Ads.INonSkippableVideoCallbacksInvoker, AppodealXamarinPlugin")]
		void OnNonSkippableVideoShown ();

	}

	[global::Android.Runtime.Register ("com/appodeal/ads/NonSkippableVideoCallbacks", DoNotGenerateAcw=true)]
	internal class INonSkippableVideoCallbacksInvoker : global::Java.Lang.Object, INonSkippableVideoCallbacks {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/appodeal/ads/NonSkippableVideoCallbacks");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (INonSkippableVideoCallbacksInvoker); }
		}

		IntPtr class_ref;

		public static INonSkippableVideoCallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INonSkippableVideoCallbacks> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.appodeal.ads.NonSkippableVideoCallbacks"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INonSkippableVideoCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onNonSkippableVideoClosed_Z;
#pragma warning disable 0169
		static Delegate GetOnNonSkippableVideoClosed_ZHandler ()
		{
			if (cb_onNonSkippableVideoClosed_Z == null)
				cb_onNonSkippableVideoClosed_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnNonSkippableVideoClosed_Z);
			return cb_onNonSkippableVideoClosed_Z;
		}

		static void n_OnNonSkippableVideoClosed_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Appodeal.Ads.INonSkippableVideoCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INonSkippableVideoCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNonSkippableVideoClosed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onNonSkippableVideoClosed_Z;
		public unsafe void OnNonSkippableVideoClosed (bool p0)
		{
			if (id_onNonSkippableVideoClosed_Z == IntPtr.Zero)
				id_onNonSkippableVideoClosed_Z = JNIEnv.GetMethodID (class_ref, "onNonSkippableVideoClosed", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNonSkippableVideoClosed_Z, __args);
		}

		static Delegate cb_onNonSkippableVideoFailedToLoad;
#pragma warning disable 0169
		static Delegate GetOnNonSkippableVideoFailedToLoadHandler ()
		{
			if (cb_onNonSkippableVideoFailedToLoad == null)
				cb_onNonSkippableVideoFailedToLoad = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnNonSkippableVideoFailedToLoad);
			return cb_onNonSkippableVideoFailedToLoad;
		}

		static void n_OnNonSkippableVideoFailedToLoad (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.INonSkippableVideoCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INonSkippableVideoCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNonSkippableVideoFailedToLoad ();
		}
#pragma warning restore 0169

		IntPtr id_onNonSkippableVideoFailedToLoad;
		public unsafe void OnNonSkippableVideoFailedToLoad ()
		{
			if (id_onNonSkippableVideoFailedToLoad == IntPtr.Zero)
				id_onNonSkippableVideoFailedToLoad = JNIEnv.GetMethodID (class_ref, "onNonSkippableVideoFailedToLoad", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNonSkippableVideoFailedToLoad);
		}

		static Delegate cb_onNonSkippableVideoFinished;
#pragma warning disable 0169
		static Delegate GetOnNonSkippableVideoFinishedHandler ()
		{
			if (cb_onNonSkippableVideoFinished == null)
				cb_onNonSkippableVideoFinished = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnNonSkippableVideoFinished);
			return cb_onNonSkippableVideoFinished;
		}

		static void n_OnNonSkippableVideoFinished (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.INonSkippableVideoCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INonSkippableVideoCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNonSkippableVideoFinished ();
		}
#pragma warning restore 0169

		IntPtr id_onNonSkippableVideoFinished;
		public unsafe void OnNonSkippableVideoFinished ()
		{
			if (id_onNonSkippableVideoFinished == IntPtr.Zero)
				id_onNonSkippableVideoFinished = JNIEnv.GetMethodID (class_ref, "onNonSkippableVideoFinished", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNonSkippableVideoFinished);
		}

		static Delegate cb_onNonSkippableVideoLoaded;
#pragma warning disable 0169
		static Delegate GetOnNonSkippableVideoLoadedHandler ()
		{
			if (cb_onNonSkippableVideoLoaded == null)
				cb_onNonSkippableVideoLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnNonSkippableVideoLoaded);
			return cb_onNonSkippableVideoLoaded;
		}

		static void n_OnNonSkippableVideoLoaded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.INonSkippableVideoCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INonSkippableVideoCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNonSkippableVideoLoaded ();
		}
#pragma warning restore 0169

		IntPtr id_onNonSkippableVideoLoaded;
		public unsafe void OnNonSkippableVideoLoaded ()
		{
			if (id_onNonSkippableVideoLoaded == IntPtr.Zero)
				id_onNonSkippableVideoLoaded = JNIEnv.GetMethodID (class_ref, "onNonSkippableVideoLoaded", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNonSkippableVideoLoaded);
		}

		static Delegate cb_onNonSkippableVideoShown;
#pragma warning disable 0169
		static Delegate GetOnNonSkippableVideoShownHandler ()
		{
			if (cb_onNonSkippableVideoShown == null)
				cb_onNonSkippableVideoShown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnNonSkippableVideoShown);
			return cb_onNonSkippableVideoShown;
		}

		static void n_OnNonSkippableVideoShown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.INonSkippableVideoCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INonSkippableVideoCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNonSkippableVideoShown ();
		}
#pragma warning restore 0169

		IntPtr id_onNonSkippableVideoShown;
		public unsafe void OnNonSkippableVideoShown ()
		{
			if (id_onNonSkippableVideoShown == IntPtr.Zero)
				id_onNonSkippableVideoShown = JNIEnv.GetMethodID (class_ref, "onNonSkippableVideoShown", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNonSkippableVideoShown);
		}

	}

}
