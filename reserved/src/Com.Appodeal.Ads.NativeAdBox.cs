using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appodeal.ads']/class[@name='NativeAdBox']"
	[global::Android.Runtime.Register ("com/appodeal/ads/NativeAdBox", DoNotGenerateAcw=true)]
	public partial class NativeAdBox : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/appodeal/ads/NativeAdBox", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeAdBox); }
		}

		protected NativeAdBox (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getNativeAds_I;
#pragma warning disable 0169
		static Delegate GetGetNativeAds_IHandler ()
		{
			if (cb_getNativeAds_I == null)
				cb_getNativeAds_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetNativeAds_I);
			return cb_getNativeAds_I;
		}

		static IntPtr n_GetNativeAds_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Appodeal.Ads.NativeAdBox __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.NativeAdBox> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Appodeal.Ads.INativeAd>.ToLocalJniHandle (__this.GetNativeAds (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getNativeAds_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='NativeAdBox']/method[@name='getNativeAds' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getNativeAds", "(I)Ljava/util/List;", "GetGetNativeAds_IHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Appodeal.Ads.INativeAd> GetNativeAds (int p0)
		{
			if (id_getNativeAds_I == IntPtr.Zero)
				id_getNativeAds_I = JNIEnv.GetMethodID (class_ref, "getNativeAds", "(I)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Com.Appodeal.Ads.INativeAd>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNativeAds_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Com.Appodeal.Ads.INativeAd>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNativeAds", "(I)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_load;
#pragma warning disable 0169
		static Delegate GetLoadHandler ()
		{
			if (cb_load == null)
				cb_load = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Load);
			return cb_load;
		}

		static void n_Load (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.NativeAdBox __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.NativeAdBox> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Load ();
		}
#pragma warning restore 0169

		static IntPtr id_load;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='NativeAdBox']/method[@name='load' and count(parameter)=0]"
		[Register ("load", "()V", "GetLoadHandler")]
		public virtual unsafe void Load ()
		{
			if (id_load == IntPtr.Zero)
				id_load = JNIEnv.GetMethodID (class_ref, "load", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_load);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "load", "()V"));
			} finally {
			}
		}

		static Delegate cb_setListener_Lcom_appodeal_ads_NativeAdBoxListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_appodeal_ads_NativeAdBoxListener_Handler ()
		{
			if (cb_setListener_Lcom_appodeal_ads_NativeAdBoxListener_ == null)
				cb_setListener_Lcom_appodeal_ads_NativeAdBoxListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lcom_appodeal_ads_NativeAdBoxListener_);
			return cb_setListener_Lcom_appodeal_ads_NativeAdBoxListener_;
		}

		static void n_SetListener_Lcom_appodeal_ads_NativeAdBoxListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Appodeal.Ads.NativeAdBox __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.NativeAdBox> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Appodeal.Ads.INativeAdBoxListener p0 = (global::Com.Appodeal.Ads.INativeAdBoxListener)global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeAdBoxListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setListener_Lcom_appodeal_ads_NativeAdBoxListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='NativeAdBox']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.NativeAdBoxListener']]"
		[Register ("setListener", "(Lcom/appodeal/ads/NativeAdBoxListener;)V", "GetSetListener_Lcom_appodeal_ads_NativeAdBoxListener_Handler")]
		public virtual unsafe void SetListener (global::Com.Appodeal.Ads.INativeAdBoxListener p0)
		{
			if (id_setListener_Lcom_appodeal_ads_NativeAdBoxListener_ == IntPtr.Zero)
				id_setListener_Lcom_appodeal_ads_NativeAdBoxListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/appodeal/ads/NativeAdBoxListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setListener_Lcom_appodeal_ads_NativeAdBoxListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListener", "(Lcom/appodeal/ads/NativeAdBoxListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSize_I;
#pragma warning disable 0169
		static Delegate GetSetSize_IHandler ()
		{
			if (cb_setSize_I == null)
				cb_setSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSize_I);
			return cb_setSize_I;
		}

		static void n_SetSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Appodeal.Ads.NativeAdBox __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.NativeAdBox> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='NativeAdBox']/method[@name='setSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSize", "(I)V", "GetSetSize_IHandler")]
		public virtual unsafe void SetSize (int p0)
		{
			if (id_setSize_I == IntPtr.Zero)
				id_setSize_I = JNIEnv.GetMethodID (class_ref, "setSize", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSize_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSize", "(I)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Appodeal.Ads.INativeAdBoxListener"

		global::Com.Appodeal.Ads.INativeAdBoxListenerImplementor __CreateINativeAdBoxListenerImplementor ()
		{
			return new global::Com.Appodeal.Ads.INativeAdBoxListenerImplementor (this);
		}
#endregion
	}
}
