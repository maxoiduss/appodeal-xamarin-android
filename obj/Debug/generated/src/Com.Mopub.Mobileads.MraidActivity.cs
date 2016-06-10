using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidActivity']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/MraidActivity", DoNotGenerateAcw=true)]
	public partial class MraidActivity : global::Com.Mopub.Mobileads.BaseInterstitialActivity {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/MraidActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MraidActivity); }
		}

		protected MraidActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidActivity']/constructor[@name='MraidActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MraidActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MraidActivity)) {
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

		static Delegate cb_getAdView;
#pragma warning disable 0169
		static Delegate GetGetAdViewHandler ()
		{
			if (cb_getAdView == null)
				cb_getAdView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdView);
			return cb_getAdView;
		}

		static IntPtr n_GetAdView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MraidActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdView);
		}
#pragma warning restore 0169

		static IntPtr id_getAdView;
		public override unsafe global::Android.Views.View AdView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidActivity']/method[@name='getAdView' and count(parameter)=0]"
			[Register ("getAdView", "()Landroid/view/View;", "GetGetAdViewHandler")]
			get {
				if (id_getAdView == IntPtr.Zero)
					id_getAdView = JNIEnv.GetMethodID (class_ref, "getAdView", "()Landroid/view/View;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getAdView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_createIntent_Landroid_content_Context_Lcom_mopub_common_AdReport_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidActivity']/method[@name='createIntent' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.common.AdReport'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long']]"
		[Register ("createIntent", "(Landroid/content/Context;Lcom/mopub/common/AdReport;Ljava/lang/String;J)Landroid/content/Intent;", "")]
		protected static unsafe global::Android.Content.Intent CreateIntent (global::Android.Content.Context p0, global::Com.Mopub.Common.AdReport p1, string p2, long p3)
		{
			if (id_createIntent_Landroid_content_Context_Lcom_mopub_common_AdReport_Ljava_lang_String_J == IntPtr.Zero)
				id_createIntent_Landroid_content_Context_Lcom_mopub_common_AdReport_Ljava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "createIntent", "(Landroid/content/Context;Lcom/mopub/common/AdReport;Ljava/lang/String;J)Landroid/content/Intent;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createIntent_Landroid_content_Context_Lcom_mopub_common_AdReport_Ljava_lang_String_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_onCreate_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreate_Landroid_os_Bundle_ == null)
				cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_os_Bundle_);
			return cb_onCreate_Landroid_os_Bundle_;
		}

		static void n_OnCreate_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MraidActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCreate_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidActivity']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnCreate (global::Android.OS.Bundle p0)
		{
			if (id_onCreate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreate_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCreate_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.MraidActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidActivity']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		protected override unsafe void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDestroy);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDestroy", "()V"));
			} finally {
			}
		}

		static IntPtr id_preRenderHtml_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidActivity']/method[@name='preRenderHtml' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.mobileads.CustomEventInterstitial.CustomEventInterstitialListener'] and parameter[3][@type='java.lang.String']]"
		[Register ("preRenderHtml", "(Landroid/content/Context;Lcom/mopub/mobileads/CustomEventInterstitial$CustomEventInterstitialListener;Ljava/lang/String;)V", "")]
		public static unsafe void PreRenderHtml (global::Android.Content.Context p0, global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener p1, string p2)
		{
			if (id_preRenderHtml_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_lang_String_ == IntPtr.Zero)
				id_preRenderHtml_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "preRenderHtml", "(Landroid/content/Context;Lcom/mopub/mobileads/CustomEventInterstitial$CustomEventInterstitialListener;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_preRenderHtml_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_setDebugListener_Lcom_mopub_mraid_MraidWebViewDebugListener_;
#pragma warning disable 0169
		static Delegate GetSetDebugListener_Lcom_mopub_mraid_MraidWebViewDebugListener_Handler ()
		{
			if (cb_setDebugListener_Lcom_mopub_mraid_MraidWebViewDebugListener_ == null)
				cb_setDebugListener_Lcom_mopub_mraid_MraidWebViewDebugListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDebugListener_Lcom_mopub_mraid_MraidWebViewDebugListener_);
			return cb_setDebugListener_Lcom_mopub_mraid_MraidWebViewDebugListener_;
		}

		static void n_SetDebugListener_Lcom_mopub_mraid_MraidWebViewDebugListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.MraidActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MraidActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mraid.IMraidWebViewDebugListener p0 = (global::Com.Mopub.Mraid.IMraidWebViewDebugListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.IMraidWebViewDebugListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDebugListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDebugListener_Lcom_mopub_mraid_MraidWebViewDebugListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidActivity']/method[@name='setDebugListener' and count(parameter)=1 and parameter[1][@type='com.mopub.mraid.MraidWebViewDebugListener']]"
		[Register ("setDebugListener", "(Lcom/mopub/mraid/MraidWebViewDebugListener;)V", "GetSetDebugListener_Lcom_mopub_mraid_MraidWebViewDebugListener_Handler")]
		public virtual unsafe void SetDebugListener (global::Com.Mopub.Mraid.IMraidWebViewDebugListener p0)
		{
			if (id_setDebugListener_Lcom_mopub_mraid_MraidWebViewDebugListener_ == IntPtr.Zero)
				id_setDebugListener_Lcom_mopub_mraid_MraidWebViewDebugListener_ = JNIEnv.GetMethodID (class_ref, "setDebugListener", "(Lcom/mopub/mraid/MraidWebViewDebugListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDebugListener_Lcom_mopub_mraid_MraidWebViewDebugListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDebugListener", "(Lcom/mopub/mraid/MraidWebViewDebugListener;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_start_Landroid_content_Context_Lcom_mopub_common_AdReport_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MraidActivity']/method[@name='start' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.common.AdReport'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long']]"
		[Register ("start", "(Landroid/content/Context;Lcom/mopub/common/AdReport;Ljava/lang/String;J)V", "")]
		public static unsafe void Start (global::Android.Content.Context p0, global::Com.Mopub.Common.AdReport p1, string p2, long p3)
		{
			if (id_start_Landroid_content_Context_Lcom_mopub_common_AdReport_Ljava_lang_String_J == IntPtr.Zero)
				id_start_Landroid_content_Context_Lcom_mopub_common_AdReport_Ljava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "start", "(Landroid/content/Context;Lcom/mopub/common/AdReport;Ljava/lang/String;J)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_start_Landroid_content_Context_Lcom_mopub_common_AdReport_Ljava_lang_String_J, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

#region "Event implementation for Com.Mopub.Mraid.IMraidWebViewDebugListener"
		public event EventHandler<global::Com.Mopub.Mraid.ConsoleMessageEventArgs> ConsoleMessage {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mraid.IMraidWebViewDebugListener, global::Com.Mopub.Mraid.IMraidWebViewDebugListenerImplementor>(
						ref weak_implementor_SetDebugListener,
						__CreateIMraidWebViewDebugListenerImplementor,
						SetDebugListener,
						__h => __h.OnConsoleMessageHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mraid.IMraidWebViewDebugListener, global::Com.Mopub.Mraid.IMraidWebViewDebugListenerImplementor>(
						ref weak_implementor_SetDebugListener,
						global::Com.Mopub.Mraid.IMraidWebViewDebugListenerImplementor.__IsEmpty,
						__v => SetDebugListener (null),
						__h => __h.OnConsoleMessageHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Mraid.JsAlertEventArgs> JsAlert {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mraid.IMraidWebViewDebugListener, global::Com.Mopub.Mraid.IMraidWebViewDebugListenerImplementor>(
						ref weak_implementor_SetDebugListener,
						__CreateIMraidWebViewDebugListenerImplementor,
						SetDebugListener,
						__h => __h.OnJsAlertHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mraid.IMraidWebViewDebugListener, global::Com.Mopub.Mraid.IMraidWebViewDebugListenerImplementor>(
						ref weak_implementor_SetDebugListener,
						global::Com.Mopub.Mraid.IMraidWebViewDebugListenerImplementor.__IsEmpty,
						__v => SetDebugListener (null),
						__h => __h.OnJsAlertHandler -= value);
			}
		}

		WeakReference weak_implementor_SetDebugListener;

		global::Com.Mopub.Mraid.IMraidWebViewDebugListenerImplementor __CreateIMraidWebViewDebugListenerImplementor ()
		{
			return new global::Com.Mopub.Mraid.IMraidWebViewDebugListenerImplementor (this);
		}
#endregion
	}
}
