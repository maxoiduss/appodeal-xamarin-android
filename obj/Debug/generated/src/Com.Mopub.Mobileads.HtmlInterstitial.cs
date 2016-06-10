using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='HtmlInterstitial']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/HtmlInterstitial", DoNotGenerateAcw=true)]
	public partial class HtmlInterstitial : global::Com.Mopub.Mobileads.ResponseBodyInterstitial {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/HtmlInterstitial", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HtmlInterstitial); }
		}

		protected HtmlInterstitial (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='HtmlInterstitial']/constructor[@name='HtmlInterstitial' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HtmlInterstitial ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HtmlInterstitial)) {
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

		static Delegate cb_extractExtras_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetExtractExtras_Ljava_util_Map_Handler ()
		{
			if (cb_extractExtras_Ljava_util_Map_ == null)
				cb_extractExtras_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ExtractExtras_Ljava_util_Map_);
			return cb_extractExtras_Ljava_util_Map_;
		}

		static void n_ExtractExtras_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.HtmlInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.HtmlInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExtractExtras (p0);
		}
#pragma warning restore 0169

		static IntPtr id_extractExtras_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='HtmlInterstitial']/method[@name='extractExtras' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("extractExtras", "(Ljava/util/Map;)V", "GetExtractExtras_Ljava_util_Map_Handler")]
		protected override unsafe void ExtractExtras (global::System.Collections.IDictionary p0)
		{
			if (id_extractExtras_Ljava_util_Map_ == IntPtr.Zero)
				id_extractExtras_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "extractExtras", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_extractExtras_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "extractExtras", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_preRenderHtml_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_;
#pragma warning disable 0169
		static Delegate GetPreRenderHtml_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Handler ()
		{
			if (cb_preRenderHtml_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_ == null)
				cb_preRenderHtml_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PreRenderHtml_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_);
			return cb_preRenderHtml_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_;
		}

		static void n_PreRenderHtml_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.HtmlInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.HtmlInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener p0 = (global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PreRenderHtml (p0);
		}
#pragma warning restore 0169

		static IntPtr id_preRenderHtml_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='HtmlInterstitial']/method[@name='preRenderHtml' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.CustomEventInterstitial.CustomEventInterstitialListener']]"
		[Register ("preRenderHtml", "(Lcom/mopub/mobileads/CustomEventInterstitial$CustomEventInterstitialListener;)V", "GetPreRenderHtml_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Handler")]
		protected override unsafe void PreRenderHtml (global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener p0)
		{
			if (id_preRenderHtml_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_ == IntPtr.Zero)
				id_preRenderHtml_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_ = JNIEnv.GetMethodID (class_ref, "preRenderHtml", "(Lcom/mopub/mobileads/CustomEventInterstitial$CustomEventInterstitialListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_preRenderHtml_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "preRenderHtml", "(Lcom/mopub/mobileads/CustomEventInterstitial$CustomEventInterstitialListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_showInterstitial;
#pragma warning disable 0169
		static Delegate GetShowInterstitialHandler ()
		{
			if (cb_showInterstitial == null)
				cb_showInterstitial = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowInterstitial);
			return cb_showInterstitial;
		}

		static void n_ShowInterstitial (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.HtmlInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.HtmlInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowInterstitial ();
		}
#pragma warning restore 0169

		static IntPtr id_showInterstitial;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='HtmlInterstitial']/method[@name='showInterstitial' and count(parameter)=0]"
		[Register ("showInterstitial", "()V", "GetShowInterstitialHandler")]
		public override unsafe void ShowInterstitial ()
		{
			if (id_showInterstitial == IntPtr.Zero)
				id_showInterstitial = JNIEnv.GetMethodID (class_ref, "showInterstitial", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_showInterstitial);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showInterstitial", "()V"));
			} finally {
			}
		}

	}
}
