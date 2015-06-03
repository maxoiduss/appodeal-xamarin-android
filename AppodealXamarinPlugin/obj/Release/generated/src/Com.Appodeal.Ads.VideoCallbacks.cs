using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='VideoCallbacks']"
	[Register ("com/appodeal/ads/VideoCallbacks", "", "Com.Appodeal.Ads.VideoCallbacksInvoker")]
	public partial interface VideoCallbacks : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='VideoCallbacks']/method[@name='onVideoClosed' and count(parameter)=0]"
		[Register ("onVideoClosed", "()V", "GetOnVideoClosedHandler:Com.Appodeal.Ads.VideoCallbacksInvoker, AppodealXamarinPlugin")]
		void OnVideoClosed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='VideoCallbacks']/method[@name='onVideoFailedToLoad' and count(parameter)=0]"
		[Register ("onVideoFailedToLoad", "()V", "GetOnVideoFailedToLoadHandler:Com.Appodeal.Ads.VideoCallbacksInvoker, AppodealXamarinPlugin")]
		void OnVideoFailedToLoad ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='VideoCallbacks']/method[@name='onVideoFinished' and count(parameter)=0]"
		[Register ("onVideoFinished", "()V", "GetOnVideoFinishedHandler:Com.Appodeal.Ads.VideoCallbacksInvoker, AppodealXamarinPlugin")]
		void OnVideoFinished ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='VideoCallbacks']/method[@name='onVideoLoaded' and count(parameter)=0]"
		[Register ("onVideoLoaded", "()V", "GetOnVideoLoadedHandler:Com.Appodeal.Ads.VideoCallbacksInvoker, AppodealXamarinPlugin")]
		void OnVideoLoaded ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='VideoCallbacks']/method[@name='onVideoShown' and count(parameter)=0]"
		[Register ("onVideoShown", "()V", "GetOnVideoShownHandler:Com.Appodeal.Ads.VideoCallbacksInvoker, AppodealXamarinPlugin")]
		void OnVideoShown ();

	}

	[global::Android.Runtime.Register ("com/appodeal/ads/VideoCallbacks", DoNotGenerateAcw=true)]
	internal class VideoCallbacksInvoker : global::Java.Lang.Object, VideoCallbacks {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/appodeal/ads/VideoCallbacks");
		IntPtr class_ref;

		public static VideoCallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<VideoCallbacks> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.appodeal.ads.VideoCallbacks"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public VideoCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (VideoCallbacksInvoker); }
		}

		static Delegate cb_onVideoClosed;
#pragma warning disable 0169
		static Delegate GetOnVideoClosedHandler ()
		{
			if (cb_onVideoClosed == null)
				cb_onVideoClosed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnVideoClosed);
			return cb_onVideoClosed;
		}

		static void n_OnVideoClosed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.VideoCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.VideoCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnVideoClosed ();
		}
#pragma warning restore 0169

		IntPtr id_onVideoClosed;
		public unsafe void OnVideoClosed ()
		{
			if (id_onVideoClosed == IntPtr.Zero)
				id_onVideoClosed = JNIEnv.GetMethodID (class_ref, "onVideoClosed", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onVideoClosed);
		}

		static Delegate cb_onVideoFailedToLoad;
#pragma warning disable 0169
		static Delegate GetOnVideoFailedToLoadHandler ()
		{
			if (cb_onVideoFailedToLoad == null)
				cb_onVideoFailedToLoad = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnVideoFailedToLoad);
			return cb_onVideoFailedToLoad;
		}

		static void n_OnVideoFailedToLoad (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.VideoCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.VideoCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnVideoFailedToLoad ();
		}
#pragma warning restore 0169

		IntPtr id_onVideoFailedToLoad;
		public unsafe void OnVideoFailedToLoad ()
		{
			if (id_onVideoFailedToLoad == IntPtr.Zero)
				id_onVideoFailedToLoad = JNIEnv.GetMethodID (class_ref, "onVideoFailedToLoad", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onVideoFailedToLoad);
		}

		static Delegate cb_onVideoFinished;
#pragma warning disable 0169
		static Delegate GetOnVideoFinishedHandler ()
		{
			if (cb_onVideoFinished == null)
				cb_onVideoFinished = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnVideoFinished);
			return cb_onVideoFinished;
		}

		static void n_OnVideoFinished (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.VideoCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.VideoCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnVideoFinished ();
		}
#pragma warning restore 0169

		IntPtr id_onVideoFinished;
		public unsafe void OnVideoFinished ()
		{
			if (id_onVideoFinished == IntPtr.Zero)
				id_onVideoFinished = JNIEnv.GetMethodID (class_ref, "onVideoFinished", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onVideoFinished);
		}

		static Delegate cb_onVideoLoaded;
#pragma warning disable 0169
		static Delegate GetOnVideoLoadedHandler ()
		{
			if (cb_onVideoLoaded == null)
				cb_onVideoLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnVideoLoaded);
			return cb_onVideoLoaded;
		}

		static void n_OnVideoLoaded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.VideoCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.VideoCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnVideoLoaded ();
		}
#pragma warning restore 0169

		IntPtr id_onVideoLoaded;
		public unsafe void OnVideoLoaded ()
		{
			if (id_onVideoLoaded == IntPtr.Zero)
				id_onVideoLoaded = JNIEnv.GetMethodID (class_ref, "onVideoLoaded", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onVideoLoaded);
		}

		static Delegate cb_onVideoShown;
#pragma warning disable 0169
		static Delegate GetOnVideoShownHandler ()
		{
			if (cb_onVideoShown == null)
				cb_onVideoShown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnVideoShown);
			return cb_onVideoShown;
		}

		static void n_OnVideoShown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.VideoCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.VideoCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnVideoShown ();
		}
#pragma warning restore 0169

		IntPtr id_onVideoShown;
		public unsafe void OnVideoShown ()
		{
			if (id_onVideoShown == IntPtr.Zero)
				id_onVideoShown = JNIEnv.GetMethodID (class_ref, "onVideoShown", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onVideoShown);
		}

	}

}
