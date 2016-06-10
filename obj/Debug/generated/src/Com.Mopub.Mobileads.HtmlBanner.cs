using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='HtmlBanner']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/HtmlBanner", DoNotGenerateAcw=true)]
	public partial class HtmlBanner : global::Com.Mopub.Mobileads.CustomEventBanner {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/HtmlBanner", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HtmlBanner); }
		}

		protected HtmlBanner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='HtmlBanner']/constructor[@name='HtmlBanner' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HtmlBanner ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HtmlBanner)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetLoadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_Handler ()
		{
			if (cb_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_ == null)
				cb_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_);
			return cb_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_;
		}

		static void n_LoadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Mopub.Mobileads.HtmlBanner __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.HtmlBanner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener p1 = (global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.LoadBanner (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='HtmlBanner']/method[@name='loadBanner' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.mobileads.CustomEventBanner.CustomEventBannerListener'] and parameter[3][@type='java.util.Map'] and parameter[4][@type='java.util.Map']]"
		[Register ("loadBanner", "(Landroid/content/Context;Lcom/mopub/mobileads/CustomEventBanner$CustomEventBannerListener;Ljava/util/Map;Ljava/util/Map;)V", "GetLoadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_Handler")]
		protected override unsafe void LoadBanner (global::Android.Content.Context p0, global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener p1, global::System.Collections.IDictionary p2, global::System.Collections.IDictionary p3)
		{
			if (id_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
				id_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "loadBanner", "(Landroid/content/Context;Lcom/mopub/mobileads/CustomEventBanner$CustomEventBannerListener;Ljava/util/Map;Ljava/util/Map;)V");
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadBanner", "(Landroid/content/Context;Lcom/mopub/mobileads/CustomEventBanner$CustomEventBannerListener;Ljava/util/Map;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_onInvalidate;
#pragma warning disable 0169
		static Delegate GetOnInvalidateHandler ()
		{
			if (cb_onInvalidate == null)
				cb_onInvalidate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInvalidate);
			return cb_onInvalidate;
		}

		static void n_OnInvalidate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.HtmlBanner __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.HtmlBanner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInvalidate ();
		}
#pragma warning restore 0169

		static IntPtr id_onInvalidate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='HtmlBanner']/method[@name='onInvalidate' and count(parameter)=0]"
		[Register ("onInvalidate", "()V", "GetOnInvalidateHandler")]
		protected override unsafe void OnInvalidate ()
		{
			if (id_onInvalidate == IntPtr.Zero)
				id_onInvalidate = JNIEnv.GetMethodID (class_ref, "onInvalidate", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onInvalidate);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInvalidate", "()V"));
			} finally {
			}
		}

	}
}
