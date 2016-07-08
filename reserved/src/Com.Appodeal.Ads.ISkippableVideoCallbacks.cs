using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='SkippableVideoCallbacks']"
	[Register ("com/appodeal/ads/SkippableVideoCallbacks", "", "Com.Appodeal.Ads.ISkippableVideoCallbacksInvoker")]
	public partial interface ISkippableVideoCallbacks : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='SkippableVideoCallbacks']/method[@name='onSkippableVideoClosed' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onSkippableVideoClosed", "(Z)V", "GetOnSkippableVideoClosed_ZHandler:Com.Appodeal.Ads.ISkippableVideoCallbacksInvoker, AppodealXamarinPlugin")]
		void OnSkippableVideoClosed (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='SkippableVideoCallbacks']/method[@name='onSkippableVideoFailedToLoad' and count(parameter)=0]"
		[Register ("onSkippableVideoFailedToLoad", "()V", "GetOnSkippableVideoFailedToLoadHandler:Com.Appodeal.Ads.ISkippableVideoCallbacksInvoker, AppodealXamarinPlugin")]
		void OnSkippableVideoFailedToLoad ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='SkippableVideoCallbacks']/method[@name='onSkippableVideoFinished' and count(parameter)=0]"
		[Register ("onSkippableVideoFinished", "()V", "GetOnSkippableVideoFinishedHandler:Com.Appodeal.Ads.ISkippableVideoCallbacksInvoker, AppodealXamarinPlugin")]
		void OnSkippableVideoFinished ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='SkippableVideoCallbacks']/method[@name='onSkippableVideoLoaded' and count(parameter)=0]"
		[Register ("onSkippableVideoLoaded", "()V", "GetOnSkippableVideoLoadedHandler:Com.Appodeal.Ads.ISkippableVideoCallbacksInvoker, AppodealXamarinPlugin")]
		void OnSkippableVideoLoaded ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='SkippableVideoCallbacks']/method[@name='onSkippableVideoShown' and count(parameter)=0]"
		[Register ("onSkippableVideoShown", "()V", "GetOnSkippableVideoShownHandler:Com.Appodeal.Ads.ISkippableVideoCallbacksInvoker, AppodealXamarinPlugin")]
		void OnSkippableVideoShown ();

	}

	[global::Android.Runtime.Register ("com/appodeal/ads/SkippableVideoCallbacks", DoNotGenerateAcw=true)]
	internal class ISkippableVideoCallbacksInvoker : global::Java.Lang.Object, ISkippableVideoCallbacks {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/appodeal/ads/SkippableVideoCallbacks");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISkippableVideoCallbacksInvoker); }
		}

		IntPtr class_ref;

		public static ISkippableVideoCallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISkippableVideoCallbacks> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.appodeal.ads.SkippableVideoCallbacks"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISkippableVideoCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSkippableVideoClosed_Z;
#pragma warning disable 0169
		static Delegate GetOnSkippableVideoClosed_ZHandler ()
		{
			if (cb_onSkippableVideoClosed_Z == null)
				cb_onSkippableVideoClosed_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnSkippableVideoClosed_Z);
			return cb_onSkippableVideoClosed_Z;
		}

		static void n_OnSkippableVideoClosed_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Appodeal.Ads.ISkippableVideoCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.ISkippableVideoCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSkippableVideoClosed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSkippableVideoClosed_Z;
		public unsafe void OnSkippableVideoClosed (bool p0)
		{
			if (id_onSkippableVideoClosed_Z == IntPtr.Zero)
				id_onSkippableVideoClosed_Z = JNIEnv.GetMethodID (class_ref, "onSkippableVideoClosed", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onSkippableVideoClosed_Z, __args);
		}

		static Delegate cb_onSkippableVideoFailedToLoad;
#pragma warning disable 0169
		static Delegate GetOnSkippableVideoFailedToLoadHandler ()
		{
			if (cb_onSkippableVideoFailedToLoad == null)
				cb_onSkippableVideoFailedToLoad = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSkippableVideoFailedToLoad);
			return cb_onSkippableVideoFailedToLoad;
		}

		static void n_OnSkippableVideoFailedToLoad (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.ISkippableVideoCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.ISkippableVideoCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSkippableVideoFailedToLoad ();
		}
#pragma warning restore 0169

		IntPtr id_onSkippableVideoFailedToLoad;
		public unsafe void OnSkippableVideoFailedToLoad ()
		{
			if (id_onSkippableVideoFailedToLoad == IntPtr.Zero)
				id_onSkippableVideoFailedToLoad = JNIEnv.GetMethodID (class_ref, "onSkippableVideoFailedToLoad", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onSkippableVideoFailedToLoad);
		}

		static Delegate cb_onSkippableVideoFinished;
#pragma warning disable 0169
		static Delegate GetOnSkippableVideoFinishedHandler ()
		{
			if (cb_onSkippableVideoFinished == null)
				cb_onSkippableVideoFinished = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSkippableVideoFinished);
			return cb_onSkippableVideoFinished;
		}

		static void n_OnSkippableVideoFinished (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.ISkippableVideoCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.ISkippableVideoCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSkippableVideoFinished ();
		}
#pragma warning restore 0169

		IntPtr id_onSkippableVideoFinished;
		public unsafe void OnSkippableVideoFinished ()
		{
			if (id_onSkippableVideoFinished == IntPtr.Zero)
				id_onSkippableVideoFinished = JNIEnv.GetMethodID (class_ref, "onSkippableVideoFinished", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onSkippableVideoFinished);
		}

		static Delegate cb_onSkippableVideoLoaded;
#pragma warning disable 0169
		static Delegate GetOnSkippableVideoLoadedHandler ()
		{
			if (cb_onSkippableVideoLoaded == null)
				cb_onSkippableVideoLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSkippableVideoLoaded);
			return cb_onSkippableVideoLoaded;
		}

		static void n_OnSkippableVideoLoaded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.ISkippableVideoCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.ISkippableVideoCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSkippableVideoLoaded ();
		}
#pragma warning restore 0169

		IntPtr id_onSkippableVideoLoaded;
		public unsafe void OnSkippableVideoLoaded ()
		{
			if (id_onSkippableVideoLoaded == IntPtr.Zero)
				id_onSkippableVideoLoaded = JNIEnv.GetMethodID (class_ref, "onSkippableVideoLoaded", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onSkippableVideoLoaded);
		}

		static Delegate cb_onSkippableVideoShown;
#pragma warning disable 0169
		static Delegate GetOnSkippableVideoShownHandler ()
		{
			if (cb_onSkippableVideoShown == null)
				cb_onSkippableVideoShown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSkippableVideoShown);
			return cb_onSkippableVideoShown;
		}

		static void n_OnSkippableVideoShown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.ISkippableVideoCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.ISkippableVideoCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSkippableVideoShown ();
		}
#pragma warning restore 0169

		IntPtr id_onSkippableVideoShown;
		public unsafe void OnSkippableVideoShown ()
		{
			if (id_onSkippableVideoShown == IntPtr.Zero)
				id_onSkippableVideoShown = JNIEnv.GetMethodID (class_ref, "onSkippableVideoShown", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onSkippableVideoShown);
		}

	}

}
