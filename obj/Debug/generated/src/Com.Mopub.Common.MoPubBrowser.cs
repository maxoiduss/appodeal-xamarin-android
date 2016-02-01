using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPubBrowser']"
	[global::Android.Runtime.Register ("com/mopub/common/MoPubBrowser", DoNotGenerateAcw=true)]
	public partial class MoPubBrowser : global::Android.App.Activity {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPubBrowser']/field[@name='DESTINATION_URL_KEY']"
		[Register ("DESTINATION_URL_KEY")]
		public const string DestinationUrlKey = (string) "URL";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/MoPubBrowser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoPubBrowser); }
		}

		protected MoPubBrowser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPubBrowser']/constructor[@name='MoPubBrowser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MoPubBrowser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MoPubBrowser)) {
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

		static Delegate cb_getBackButton;
#pragma warning disable 0169
		static Delegate GetGetBackButtonHandler ()
		{
			if (cb_getBackButton == null)
				cb_getBackButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBackButton);
			return cb_getBackButton;
		}

		static IntPtr n_GetBackButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.MoPubBrowser __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.MoPubBrowser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BackButton);
		}
#pragma warning restore 0169

		static IntPtr id_getBackButton;
		public virtual unsafe global::Android.Widget.ImageButton BackButton {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPubBrowser']/method[@name='getBackButton' and count(parameter)=0]"
			[Register ("getBackButton", "()Landroid/widget/ImageButton;", "GetGetBackButtonHandler")]
			get {
				if (id_getBackButton == IntPtr.Zero)
					id_getBackButton = JNIEnv.GetMethodID (class_ref, "getBackButton", "()Landroid/widget/ImageButton;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageButton> (JNIEnv.CallObjectMethod  (Handle, id_getBackButton), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageButton> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBackButton", "()Landroid/widget/ImageButton;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCloseButton;
#pragma warning disable 0169
		static Delegate GetGetCloseButtonHandler ()
		{
			if (cb_getCloseButton == null)
				cb_getCloseButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCloseButton);
			return cb_getCloseButton;
		}

		static IntPtr n_GetCloseButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.MoPubBrowser __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.MoPubBrowser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CloseButton);
		}
#pragma warning restore 0169

		static IntPtr id_getCloseButton;
		public virtual unsafe global::Android.Widget.ImageButton CloseButton {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPubBrowser']/method[@name='getCloseButton' and count(parameter)=0]"
			[Register ("getCloseButton", "()Landroid/widget/ImageButton;", "GetGetCloseButtonHandler")]
			get {
				if (id_getCloseButton == IntPtr.Zero)
					id_getCloseButton = JNIEnv.GetMethodID (class_ref, "getCloseButton", "()Landroid/widget/ImageButton;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageButton> (JNIEnv.CallObjectMethod  (Handle, id_getCloseButton), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageButton> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCloseButton", "()Landroid/widget/ImageButton;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getForwardButton;
#pragma warning disable 0169
		static Delegate GetGetForwardButtonHandler ()
		{
			if (cb_getForwardButton == null)
				cb_getForwardButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetForwardButton);
			return cb_getForwardButton;
		}

		static IntPtr n_GetForwardButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.MoPubBrowser __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.MoPubBrowser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ForwardButton);
		}
#pragma warning restore 0169

		static IntPtr id_getForwardButton;
		public virtual unsafe global::Android.Widget.ImageButton ForwardButton {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPubBrowser']/method[@name='getForwardButton' and count(parameter)=0]"
			[Register ("getForwardButton", "()Landroid/widget/ImageButton;", "GetGetForwardButtonHandler")]
			get {
				if (id_getForwardButton == IntPtr.Zero)
					id_getForwardButton = JNIEnv.GetMethodID (class_ref, "getForwardButton", "()Landroid/widget/ImageButton;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageButton> (JNIEnv.CallObjectMethod  (Handle, id_getForwardButton), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageButton> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getForwardButton", "()Landroid/widget/ImageButton;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRefreshButton;
#pragma warning disable 0169
		static Delegate GetGetRefreshButtonHandler ()
		{
			if (cb_getRefreshButton == null)
				cb_getRefreshButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRefreshButton);
			return cb_getRefreshButton;
		}

		static IntPtr n_GetRefreshButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.MoPubBrowser __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.MoPubBrowser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RefreshButton);
		}
#pragma warning restore 0169

		static IntPtr id_getRefreshButton;
		public virtual unsafe global::Android.Widget.ImageButton RefreshButton {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPubBrowser']/method[@name='getRefreshButton' and count(parameter)=0]"
			[Register ("getRefreshButton", "()Landroid/widget/ImageButton;", "GetGetRefreshButtonHandler")]
			get {
				if (id_getRefreshButton == IntPtr.Zero)
					id_getRefreshButton = JNIEnv.GetMethodID (class_ref, "getRefreshButton", "()Landroid/widget/ImageButton;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageButton> (JNIEnv.CallObjectMethod  (Handle, id_getRefreshButton), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageButton> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRefreshButton", "()Landroid/widget/ImageButton;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWebView;
#pragma warning disable 0169
		static Delegate GetGetWebViewHandler ()
		{
			if (cb_getWebView == null)
				cb_getWebView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWebView);
			return cb_getWebView;
		}

		static IntPtr n_GetWebView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.MoPubBrowser __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.MoPubBrowser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WebView);
		}
#pragma warning restore 0169

		static IntPtr id_getWebView;
		public virtual unsafe global::Android.Webkit.WebView WebView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPubBrowser']/method[@name='getWebView' and count(parameter)=0]"
			[Register ("getWebView", "()Landroid/webkit/WebView;", "GetGetWebViewHandler")]
			get {
				if (id_getWebView == IntPtr.Zero)
					id_getWebView = JNIEnv.GetMethodID (class_ref, "getWebView", "()Landroid/webkit/WebView;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (JNIEnv.CallObjectMethod  (Handle, id_getWebView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWebView", "()Landroid/webkit/WebView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Mopub.Common.MoPubBrowser __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.MoPubBrowser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCreate_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPubBrowser']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
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

		static IntPtr id_open_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPubBrowser']/method[@name='open' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("open", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void Open (global::Android.Content.Context p0, string p1)
		{
			if (id_open_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_open_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "open", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_open_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
