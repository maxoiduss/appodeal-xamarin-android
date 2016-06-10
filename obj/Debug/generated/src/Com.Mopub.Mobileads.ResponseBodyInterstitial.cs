using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='ResponseBodyInterstitial']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/ResponseBodyInterstitial", DoNotGenerateAcw=true)]
	public abstract partial class ResponseBodyInterstitial : global::Com.Mopub.Mobileads.CustomEventInterstitial {


		static IntPtr mAdReport_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='ResponseBodyInterstitial']/field[@name='mAdReport']"
		[Register ("mAdReport")]
		protected global::Com.Mopub.Common.AdReport MAdReport {
			get {
				if (mAdReport_jfieldId == IntPtr.Zero)
					mAdReport_jfieldId = JNIEnv.GetFieldID (class_ref, "mAdReport", "Lcom/mopub/common/AdReport;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mAdReport_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdReport> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAdReport_jfieldId == IntPtr.Zero)
					mAdReport_jfieldId = JNIEnv.GetFieldID (class_ref, "mAdReport", "Lcom/mopub/common/AdReport;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mAdReport_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mBroadcastIdentifier_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='ResponseBodyInterstitial']/field[@name='mBroadcastIdentifier']"
		[Register ("mBroadcastIdentifier")]
		protected long MBroadcastIdentifier {
			get {
				if (mBroadcastIdentifier_jfieldId == IntPtr.Zero)
					mBroadcastIdentifier_jfieldId = JNIEnv.GetFieldID (class_ref, "mBroadcastIdentifier", "J");
				return JNIEnv.GetLongField (Handle, mBroadcastIdentifier_jfieldId);
			}
			set {
				if (mBroadcastIdentifier_jfieldId == IntPtr.Zero)
					mBroadcastIdentifier_jfieldId = JNIEnv.GetFieldID (class_ref, "mBroadcastIdentifier", "J");
				try {
					JNIEnv.SetField (Handle, mBroadcastIdentifier_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mContext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='ResponseBodyInterstitial']/field[@name='mContext']"
		[Register ("mContext")]
		protected global::Android.Content.Context MContext {
			get {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mContext_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mContext_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/ResponseBodyInterstitial", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResponseBodyInterstitial); }
		}

		protected ResponseBodyInterstitial (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='ResponseBodyInterstitial']/constructor[@name='ResponseBodyInterstitial' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResponseBodyInterstitial ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ResponseBodyInterstitial)) {
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
			global::Com.Mopub.Mobileads.ResponseBodyInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.ResponseBodyInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExtractExtras (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='ResponseBodyInterstitial']/method[@name='extractExtras' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("extractExtras", "(Ljava/util/Map;)V", "GetExtractExtras_Ljava_util_Map_Handler")]
		protected abstract void ExtractExtras (global::System.Collections.IDictionary p0);

		static Delegate cb_loadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetLoadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_Handler ()
		{
			if (cb_loadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_ == null)
				cb_loadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_);
			return cb_loadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_;
		}

		static void n_LoadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Mopub.Mobileads.ResponseBodyInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.ResponseBodyInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener p1 = (global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.LoadInterstitial (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_loadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='ResponseBodyInterstitial']/method[@name='loadInterstitial' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.mobileads.CustomEventInterstitial.CustomEventInterstitialListener'] and parameter[3][@type='java.util.Map'] and parameter[4][@type='java.util.Map']]"
		[Register ("loadInterstitial", "(Landroid/content/Context;Lcom/mopub/mobileads/CustomEventInterstitial$CustomEventInterstitialListener;Ljava/util/Map;Ljava/util/Map;)V", "GetLoadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_Handler")]
		public override unsafe void LoadInterstitial (global::Android.Content.Context p0, global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener p1, global::System.Collections.IDictionary p2, global::System.Collections.IDictionary p3)
		{
			if (id_loadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
				id_loadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "loadInterstitial", "(Landroid/content/Context;Lcom/mopub/mobileads/CustomEventInterstitial$CustomEventInterstitialListener;Ljava/util/Map;Ljava/util/Map;)V");
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_loadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadInterstitial", "(Landroid/content/Context;Lcom/mopub/mobileads/CustomEventInterstitial$CustomEventInterstitialListener;Ljava/util/Map;Ljava/util/Map;)V"), __args);
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
			global::Com.Mopub.Mobileads.ResponseBodyInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.ResponseBodyInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInvalidate ();
		}
#pragma warning restore 0169

		static IntPtr id_onInvalidate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='ResponseBodyInterstitial']/method[@name='onInvalidate' and count(parameter)=0]"
		[Register ("onInvalidate", "()V", "GetOnInvalidateHandler")]
		public override unsafe void OnInvalidate ()
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
			global::Com.Mopub.Mobileads.ResponseBodyInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.ResponseBodyInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener p0 = (global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PreRenderHtml (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='ResponseBodyInterstitial']/method[@name='preRenderHtml' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.CustomEventInterstitial.CustomEventInterstitialListener']]"
		[Register ("preRenderHtml", "(Lcom/mopub/mobileads/CustomEventInterstitial$CustomEventInterstitialListener;)V", "GetPreRenderHtml_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Handler")]
		protected abstract void PreRenderHtml (global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener p0);

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
			global::Com.Mopub.Mobileads.ResponseBodyInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.ResponseBodyInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowInterstitial ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='ResponseBodyInterstitial']/method[@name='showInterstitial' and count(parameter)=0]"
		[Register ("showInterstitial", "()V", "GetShowInterstitialHandler")]
		public abstract void ShowInterstitial ();

	}

	[global::Android.Runtime.Register ("com/mopub/mobileads/ResponseBodyInterstitial", DoNotGenerateAcw=true)]
	internal partial class ResponseBodyInterstitialInvoker : ResponseBodyInterstitial {

		public ResponseBodyInterstitialInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResponseBodyInterstitialInvoker); }
		}

		static IntPtr id_extractExtras_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='ResponseBodyInterstitial']/method[@name='extractExtras' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("extractExtras", "(Ljava/util/Map;)V", "GetExtractExtras_Ljava_util_Map_Handler")]
		protected override unsafe void ExtractExtras (global::System.Collections.IDictionary p0)
		{
			if (id_extractExtras_Ljava_util_Map_ == IntPtr.Zero)
				id_extractExtras_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "extractExtras", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_extractExtras_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_preRenderHtml_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='ResponseBodyInterstitial']/method[@name='preRenderHtml' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.CustomEventInterstitial.CustomEventInterstitialListener']]"
		[Register ("preRenderHtml", "(Lcom/mopub/mobileads/CustomEventInterstitial$CustomEventInterstitialListener;)V", "GetPreRenderHtml_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Handler")]
		protected override unsafe void PreRenderHtml (global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener p0)
		{
			if (id_preRenderHtml_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_ == IntPtr.Zero)
				id_preRenderHtml_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_ = JNIEnv.GetMethodID (class_ref, "preRenderHtml", "(Lcom/mopub/mobileads/CustomEventInterstitial$CustomEventInterstitialListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_preRenderHtml_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_, __args);
			} finally {
			}
		}

		static IntPtr id_showInterstitial;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='ResponseBodyInterstitial']/method[@name='showInterstitial' and count(parameter)=0]"
		[Register ("showInterstitial", "()V", "GetShowInterstitialHandler")]
		public override unsafe void ShowInterstitial ()
		{
			if (id_showInterstitial == IntPtr.Zero)
				id_showInterstitial = JNIEnv.GetMethodID (class_ref, "showInterstitial", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_showInterstitial);
			} finally {
			}
		}

	}

}
