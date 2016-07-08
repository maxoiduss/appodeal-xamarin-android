using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='RewardedVideoCallbacks']"
	[Register ("com/appodeal/ads/RewardedVideoCallbacks", "", "Com.Appodeal.Ads.IRewardedVideoCallbacksInvoker")]
	public partial interface IRewardedVideoCallbacks : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='RewardedVideoCallbacks']/method[@name='onRewardedVideoClosed' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onRewardedVideoClosed", "(Z)V", "GetOnRewardedVideoClosed_ZHandler:Com.Appodeal.Ads.IRewardedVideoCallbacksInvoker, AppodealXamarinPlugin")]
		void OnRewardedVideoClosed (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='RewardedVideoCallbacks']/method[@name='onRewardedVideoFailedToLoad' and count(parameter)=0]"
		[Register ("onRewardedVideoFailedToLoad", "()V", "GetOnRewardedVideoFailedToLoadHandler:Com.Appodeal.Ads.IRewardedVideoCallbacksInvoker, AppodealXamarinPlugin")]
		void OnRewardedVideoFailedToLoad ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='RewardedVideoCallbacks']/method[@name='onRewardedVideoFinished' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onRewardedVideoFinished", "(ILjava/lang/String;)V", "GetOnRewardedVideoFinished_ILjava_lang_String_Handler:Com.Appodeal.Ads.IRewardedVideoCallbacksInvoker, AppodealXamarinPlugin")]
		void OnRewardedVideoFinished (int p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='RewardedVideoCallbacks']/method[@name='onRewardedVideoLoaded' and count(parameter)=0]"
		[Register ("onRewardedVideoLoaded", "()V", "GetOnRewardedVideoLoadedHandler:Com.Appodeal.Ads.IRewardedVideoCallbacksInvoker, AppodealXamarinPlugin")]
		void OnRewardedVideoLoaded ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='RewardedVideoCallbacks']/method[@name='onRewardedVideoShown' and count(parameter)=0]"
		[Register ("onRewardedVideoShown", "()V", "GetOnRewardedVideoShownHandler:Com.Appodeal.Ads.IRewardedVideoCallbacksInvoker, AppodealXamarinPlugin")]
		void OnRewardedVideoShown ();

	}

	[global::Android.Runtime.Register ("com/appodeal/ads/RewardedVideoCallbacks", DoNotGenerateAcw=true)]
	internal class IRewardedVideoCallbacksInvoker : global::Java.Lang.Object, IRewardedVideoCallbacks {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/appodeal/ads/RewardedVideoCallbacks");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IRewardedVideoCallbacksInvoker); }
		}

		IntPtr class_ref;

		public static IRewardedVideoCallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRewardedVideoCallbacks> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.appodeal.ads.RewardedVideoCallbacks"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRewardedVideoCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRewardedVideoClosed_Z;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoClosed_ZHandler ()
		{
			if (cb_onRewardedVideoClosed_Z == null)
				cb_onRewardedVideoClosed_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnRewardedVideoClosed_Z);
			return cb_onRewardedVideoClosed_Z;
		}

		static void n_OnRewardedVideoClosed_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Appodeal.Ads.IRewardedVideoCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.IRewardedVideoCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoClosed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoClosed_Z;
		public unsafe void OnRewardedVideoClosed (bool p0)
		{
			if (id_onRewardedVideoClosed_Z == IntPtr.Zero)
				id_onRewardedVideoClosed_Z = JNIEnv.GetMethodID (class_ref, "onRewardedVideoClosed", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onRewardedVideoClosed_Z, __args);
		}

		static Delegate cb_onRewardedVideoFailedToLoad;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoFailedToLoadHandler ()
		{
			if (cb_onRewardedVideoFailedToLoad == null)
				cb_onRewardedVideoFailedToLoad = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRewardedVideoFailedToLoad);
			return cb_onRewardedVideoFailedToLoad;
		}

		static void n_OnRewardedVideoFailedToLoad (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.IRewardedVideoCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.IRewardedVideoCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoFailedToLoad ();
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoFailedToLoad;
		public unsafe void OnRewardedVideoFailedToLoad ()
		{
			if (id_onRewardedVideoFailedToLoad == IntPtr.Zero)
				id_onRewardedVideoFailedToLoad = JNIEnv.GetMethodID (class_ref, "onRewardedVideoFailedToLoad", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onRewardedVideoFailedToLoad);
		}

		static Delegate cb_onRewardedVideoFinished_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoFinished_ILjava_lang_String_Handler ()
		{
			if (cb_onRewardedVideoFinished_ILjava_lang_String_ == null)
				cb_onRewardedVideoFinished_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnRewardedVideoFinished_ILjava_lang_String_);
			return cb_onRewardedVideoFinished_ILjava_lang_String_;
		}

		static void n_OnRewardedVideoFinished_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Appodeal.Ads.IRewardedVideoCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.IRewardedVideoCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoFinished (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoFinished_ILjava_lang_String_;
		public unsafe void OnRewardedVideoFinished (int p0, string p1)
		{
			if (id_onRewardedVideoFinished_ILjava_lang_String_ == IntPtr.Zero)
				id_onRewardedVideoFinished_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onRewardedVideoFinished", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (Handle, id_onRewardedVideoFinished_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onRewardedVideoLoaded;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoLoadedHandler ()
		{
			if (cb_onRewardedVideoLoaded == null)
				cb_onRewardedVideoLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRewardedVideoLoaded);
			return cb_onRewardedVideoLoaded;
		}

		static void n_OnRewardedVideoLoaded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.IRewardedVideoCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.IRewardedVideoCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoLoaded ();
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoLoaded;
		public unsafe void OnRewardedVideoLoaded ()
		{
			if (id_onRewardedVideoLoaded == IntPtr.Zero)
				id_onRewardedVideoLoaded = JNIEnv.GetMethodID (class_ref, "onRewardedVideoLoaded", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onRewardedVideoLoaded);
		}

		static Delegate cb_onRewardedVideoShown;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoShownHandler ()
		{
			if (cb_onRewardedVideoShown == null)
				cb_onRewardedVideoShown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRewardedVideoShown);
			return cb_onRewardedVideoShown;
		}

		static void n_OnRewardedVideoShown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.IRewardedVideoCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.IRewardedVideoCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoShown ();
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoShown;
		public unsafe void OnRewardedVideoShown ()
		{
			if (id_onRewardedVideoShown == IntPtr.Zero)
				id_onRewardedVideoShown = JNIEnv.GetMethodID (class_ref, "onRewardedVideoShown", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onRewardedVideoShown);
		}

	}

}
