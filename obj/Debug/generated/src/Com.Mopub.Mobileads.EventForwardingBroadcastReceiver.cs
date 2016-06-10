using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='EventForwardingBroadcastReceiver']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/EventForwardingBroadcastReceiver", DoNotGenerateAcw=true)]
	public partial class EventForwardingBroadcastReceiver : global::Android.Content.BroadcastReceiver {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='EventForwardingBroadcastReceiver']/field[@name='ACTION_INTERSTITIAL_CLICK']"
		[Register ("ACTION_INTERSTITIAL_CLICK")]
		public const string ActionInterstitialClick = (string) "com.mopub.action.interstitial.click";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='EventForwardingBroadcastReceiver']/field[@name='ACTION_INTERSTITIAL_DISMISS']"
		[Register ("ACTION_INTERSTITIAL_DISMISS")]
		public const string ActionInterstitialDismiss = (string) "com.mopub.action.interstitial.dismiss";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='EventForwardingBroadcastReceiver']/field[@name='ACTION_INTERSTITIAL_FAIL']"
		[Register ("ACTION_INTERSTITIAL_FAIL")]
		public const string ActionInterstitialFail = (string) "com.mopub.action.interstitial.fail";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='EventForwardingBroadcastReceiver']/field[@name='ACTION_INTERSTITIAL_FINISH']"
		[Register ("ACTION_INTERSTITIAL_FINISH")]
		public const string ActionInterstitialFinish = (string) "com.mopub.action.interstitial.finish";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='EventForwardingBroadcastReceiver']/field[@name='ACTION_INTERSTITIAL_SHOW']"
		[Register ("ACTION_INTERSTITIAL_SHOW")]
		public const string ActionInterstitialShow = (string) "com.mopub.action.interstitial.show";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/EventForwardingBroadcastReceiver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventForwardingBroadcastReceiver); }
		}

		protected EventForwardingBroadcastReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='EventForwardingBroadcastReceiver']/constructor[@name='EventForwardingBroadcastReceiver' and count(parameter)=2 and parameter[1][@type='com.mopub.mobileads.CustomEventInterstitial.CustomEventInterstitialListener'] and parameter[2][@type='long']]"
		[Register (".ctor", "(Lcom/mopub/mobileads/CustomEventInterstitial$CustomEventInterstitialListener;J)V", "")]
		public unsafe EventForwardingBroadcastReceiver (global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener p0, long p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (EventForwardingBroadcastReceiver)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/mobileads/CustomEventInterstitial$CustomEventInterstitialListener;J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/mobileads/CustomEventInterstitial$CustomEventInterstitialListener;J)V", __args);
					return;
				}

				if (id_ctor_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_J == IntPtr.Zero)
					id_ctor_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/mobileads/CustomEventInterstitial$CustomEventInterstitialListener;J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_J, __args);
			} finally {
			}
		}

		static IntPtr id_getHtmlInterstitialIntentFilter;
		public static unsafe global::Android.Content.IntentFilter HtmlInterstitialIntentFilter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='EventForwardingBroadcastReceiver']/method[@name='getHtmlInterstitialIntentFilter' and count(parameter)=0]"
			[Register ("getHtmlInterstitialIntentFilter", "()Landroid/content/IntentFilter;", "GetGetHtmlInterstitialIntentFilterHandler")]
			get {
				if (id_getHtmlInterstitialIntentFilter == IntPtr.Zero)
					id_getHtmlInterstitialIntentFilter = JNIEnv.GetStaticMethodID (class_ref, "getHtmlInterstitialIntentFilter", "()Landroid/content/IntentFilter;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Content.IntentFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getHtmlInterstitialIntentFilter), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler ()
		{
			if (cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
				cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceive_Landroid_content_Context_Landroid_content_Intent_);
			return cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		}

		static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Mobileads.EventForwardingBroadcastReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.EventForwardingBroadcastReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnReceive (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='EventForwardingBroadcastReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public override unsafe void OnReceive (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_onReceive_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onReceive_Landroid_content_Context_Landroid_content_Intent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_register_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetRegister_Landroid_content_Context_Handler ()
		{
			if (cb_register_Landroid_content_Context_ == null)
				cb_register_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Register_Landroid_content_Context_);
			return cb_register_Landroid_content_Context_;
		}

		static void n_Register_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.EventForwardingBroadcastReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.EventForwardingBroadcastReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Register (p0);
		}
#pragma warning restore 0169

		static IntPtr id_register_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='EventForwardingBroadcastReceiver']/method[@name='register' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("register", "(Landroid/content/Context;)V", "GetRegister_Landroid_content_Context_Handler")]
		public virtual unsafe void Register (global::Android.Content.Context p0)
		{
			if (id_register_Landroid_content_Context_ == IntPtr.Zero)
				id_register_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "register", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_register_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "register", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_unregister;
#pragma warning disable 0169
		static Delegate GetUnregisterHandler ()
		{
			if (cb_unregister == null)
				cb_unregister = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Unregister);
			return cb_unregister;
		}

		static void n_Unregister (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.EventForwardingBroadcastReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.EventForwardingBroadcastReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Unregister ();
		}
#pragma warning restore 0169

		static IntPtr id_unregister;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='EventForwardingBroadcastReceiver']/method[@name='unregister' and count(parameter)=0]"
		[Register ("unregister", "()V", "GetUnregisterHandler")]
		public virtual unsafe void Unregister ()
		{
			if (id_unregister == IntPtr.Zero)
				id_unregister = JNIEnv.GetMethodID (class_ref, "unregister", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_unregister);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregister", "()V"));
			} finally {
			}
		}

	}
}
