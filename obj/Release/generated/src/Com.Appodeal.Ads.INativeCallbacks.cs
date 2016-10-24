using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeCallbacks']"
	[Register ("com/appodeal/ads/NativeCallbacks", "", "Com.Appodeal.Ads.INativeCallbacksInvoker")]
	public partial interface INativeCallbacks : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeCallbacks']/method[@name='onNativeClicked' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.NativeAd']]"
		[Register ("onNativeClicked", "(Lcom/appodeal/ads/NativeAd;)V", "GetOnNativeClicked_Lcom_appodeal_ads_NativeAd_Handler:Com.Appodeal.Ads.INativeCallbacksInvoker, AppodealXamarinPlugin")]
		void OnNativeClicked (global::Com.Appodeal.Ads.INativeAd p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeCallbacks']/method[@name='onNativeFailedToLoad' and count(parameter)=0]"
		[Register ("onNativeFailedToLoad", "()V", "GetOnNativeFailedToLoadHandler:Com.Appodeal.Ads.INativeCallbacksInvoker, AppodealXamarinPlugin")]
		void OnNativeFailedToLoad ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeCallbacks']/method[@name='onNativeLoaded' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.appodeal.ads.NativeAd&gt;']]"
		[Register ("onNativeLoaded", "(Ljava/util/List;)V", "GetOnNativeLoaded_Ljava_util_List_Handler:Com.Appodeal.Ads.INativeCallbacksInvoker, AppodealXamarinPlugin")]
		void OnNativeLoaded (global::System.Collections.Generic.IList<global::Com.Appodeal.Ads.INativeAd> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeCallbacks']/method[@name='onNativeShown' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.NativeAd']]"
		[Register ("onNativeShown", "(Lcom/appodeal/ads/NativeAd;)V", "GetOnNativeShown_Lcom_appodeal_ads_NativeAd_Handler:Com.Appodeal.Ads.INativeCallbacksInvoker, AppodealXamarinPlugin")]
		void OnNativeShown (global::Com.Appodeal.Ads.INativeAd p0);

	}

	[global::Android.Runtime.Register ("com/appodeal/ads/NativeCallbacks", DoNotGenerateAcw=true)]
	internal class INativeCallbacksInvoker : global::Java.Lang.Object, INativeCallbacks {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/appodeal/ads/NativeCallbacks");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (INativeCallbacksInvoker); }
		}

		IntPtr class_ref;

		public static INativeCallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INativeCallbacks> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.appodeal.ads.NativeCallbacks"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INativeCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Appodeal.Ads.INativeCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onNativeFailedToLoad;
#pragma warning disable 0169
		static Delegate GetOnNativeFailedToLoadHandler ()
		{
			if (cb_onNativeFailedToLoad == null)
				cb_onNativeFailedToLoad = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnNativeFailedToLoad);
			return cb_onNativeFailedToLoad;
		}

		static void n_OnNativeFailedToLoad (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.INativeCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNativeFailedToLoad ();
		}
#pragma warning restore 0169

		IntPtr id_onNativeFailedToLoad;
		public unsafe void OnNativeFailedToLoad ()
		{
			if (id_onNativeFailedToLoad == IntPtr.Zero)
				id_onNativeFailedToLoad = JNIEnv.GetMethodID (class_ref, "onNativeFailedToLoad", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeFailedToLoad);
		}

		static Delegate cb_onNativeLoaded_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnNativeLoaded_Ljava_util_List_Handler ()
		{
			if (cb_onNativeLoaded_Ljava_util_List_ == null)
				cb_onNativeLoaded_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNativeLoaded_Ljava_util_List_);
			return cb_onNativeLoaded_Ljava_util_List_;
		}

		static void n_OnNativeLoaded_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Appodeal.Ads.INativeCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Appodeal.Ads.INativeAd>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNativeLoaded (p0);
		}
#pragma warning restore 0169

		IntPtr id_onNativeLoaded_Ljava_util_List_;
		public unsafe void OnNativeLoaded (global::System.Collections.Generic.IList<global::Com.Appodeal.Ads.INativeAd> p0)
		{
			if (id_onNativeLoaded_Ljava_util_List_ == IntPtr.Zero)
				id_onNativeLoaded_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onNativeLoaded", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Appodeal.Ads.INativeAd>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeLoaded_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Appodeal.Ads.INativeCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

}
