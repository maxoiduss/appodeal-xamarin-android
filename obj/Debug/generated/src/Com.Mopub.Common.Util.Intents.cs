using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Intents']"
	[global::Android.Runtime.Register ("com/mopub/common/util/Intents", DoNotGenerateAcw=true)]
	public partial class Intents : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/util/Intents", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Intents); }
		}

		protected Intents (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_canHandleApplicationUrl_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Intents']/method[@name='canHandleApplicationUrl' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("canHandleApplicationUrl", "(Landroid/content/Context;Landroid/net/Uri;)Z", "")]
		public static unsafe bool CanHandleApplicationUrl (global::Android.Content.Context p0, global::Android.Net.Uri p1)
		{
			if (id_canHandleApplicationUrl_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
				id_canHandleApplicationUrl_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "canHandleApplicationUrl", "(Landroid/content/Context;Landroid/net/Uri;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_canHandleApplicationUrl_Landroid_content_Context_Landroid_net_Uri_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_canHandleApplicationUrl_Landroid_content_Context_Landroid_net_Uri_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Intents']/method[@name='canHandleApplicationUrl' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='boolean']]"
		[Register ("canHandleApplicationUrl", "(Landroid/content/Context;Landroid/net/Uri;Z)Z", "")]
		public static unsafe bool CanHandleApplicationUrl (global::Android.Content.Context p0, global::Android.Net.Uri p1, bool p2)
		{
			if (id_canHandleApplicationUrl_Landroid_content_Context_Landroid_net_Uri_Z == IntPtr.Zero)
				id_canHandleApplicationUrl_Landroid_content_Context_Landroid_net_Uri_Z = JNIEnv.GetStaticMethodID (class_ref, "canHandleApplicationUrl", "(Landroid/content/Context;Landroid/net/Uri;Z)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_canHandleApplicationUrl_Landroid_content_Context_Landroid_net_Uri_Z, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_deviceCanHandleIntent_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Intents']/method[@name='deviceCanHandleIntent' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("deviceCanHandleIntent", "(Landroid/content/Context;Landroid/content/Intent;)Z", "")]
		public static unsafe bool DeviceCanHandleIntent (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_deviceCanHandleIntent_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_deviceCanHandleIntent_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "deviceCanHandleIntent", "(Landroid/content/Context;Landroid/content/Intent;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_deviceCanHandleIntent_Landroid_content_Context_Landroid_content_Intent_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getStartActivityIntent_Landroid_content_Context_Ljava_lang_Class_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Intents']/method[@name='getStartActivityIntent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Class'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("getStartActivityIntent", "(Landroid/content/Context;Ljava/lang/Class;Landroid/os/Bundle;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetStartActivityIntent (global::Android.Content.Context p0, global::Java.Lang.Class p1, global::Android.OS.Bundle p2)
		{
			if (id_getStartActivityIntent_Landroid_content_Context_Ljava_lang_Class_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getStartActivityIntent_Landroid_content_Context_Ljava_lang_Class_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "getStartActivityIntent", "(Landroid/content/Context;Ljava/lang/Class;Landroid/os/Bundle;)Landroid/content/Intent;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStartActivityIntent_Landroid_content_Context_Ljava_lang_Class_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_intentForNativeBrowserScheme_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Intents']/method[@name='intentForNativeBrowserScheme' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("intentForNativeBrowserScheme", "(Landroid/net/Uri;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent IntentForNativeBrowserScheme (global::Android.Net.Uri p0)
		{
			if (id_intentForNativeBrowserScheme_Landroid_net_Uri_ == IntPtr.Zero)
				id_intentForNativeBrowserScheme_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "intentForNativeBrowserScheme", "(Landroid/net/Uri;)Landroid/content/Intent;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_intentForNativeBrowserScheme_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_intentForShareTweet_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Intents']/method[@name='intentForShareTweet' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("intentForShareTweet", "(Landroid/net/Uri;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent IntentForShareTweet (global::Android.Net.Uri p0)
		{
			if (id_intentForShareTweet_Landroid_net_Uri_ == IntPtr.Zero)
				id_intentForShareTweet_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "intentForShareTweet", "(Landroid/net/Uri;)Landroid/content/Intent;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_intentForShareTweet_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_launchActionViewIntent_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Intents']/method[@name='launchActionViewIntent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.lang.String']]"
		[Register ("launchActionViewIntent", "(Landroid/content/Context;Landroid/net/Uri;Ljava/lang/String;)V", "")]
		public static unsafe void LaunchActionViewIntent (global::Android.Content.Context p0, global::Android.Net.Uri p1, string p2)
		{
			if (id_launchActionViewIntent_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_ == IntPtr.Zero)
				id_launchActionViewIntent_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "launchActionViewIntent", "(Landroid/content/Context;Landroid/net/Uri;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_launchActionViewIntent_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_launchApplicationUrl_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Intents']/method[@name='launchApplicationUrl' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("launchApplicationUrl", "(Landroid/content/Context;Landroid/net/Uri;)V", "")]
		public static unsafe void LaunchApplicationUrl (global::Android.Content.Context p0, global::Android.Net.Uri p1)
		{
			if (id_launchApplicationUrl_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
				id_launchApplicationUrl_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "launchApplicationUrl", "(Landroid/content/Context;Landroid/net/Uri;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_launchApplicationUrl_Landroid_content_Context_Landroid_net_Uri_, __args);
			} finally {
			}
		}

		static IntPtr id_launchIntentForUserClick_Landroid_content_Context_Landroid_content_Intent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Intents']/method[@name='launchIntentForUserClick' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='java.lang.String']]"
		[Register ("launchIntentForUserClick", "(Landroid/content/Context;Landroid/content/Intent;Ljava/lang/String;)V", "")]
		public static unsafe void LaunchIntentForUserClick (global::Android.Content.Context p0, global::Android.Content.Intent p1, string p2)
		{
			if (id_launchIntentForUserClick_Landroid_content_Context_Landroid_content_Intent_Ljava_lang_String_ == IntPtr.Zero)
				id_launchIntentForUserClick_Landroid_content_Context_Landroid_content_Intent_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "launchIntentForUserClick", "(Landroid/content/Context;Landroid/content/Intent;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_launchIntentForUserClick_Landroid_content_Context_Landroid_content_Intent_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_showMoPubBrowserForUrl_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Intents']/method[@name='showMoPubBrowserForUrl' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("showMoPubBrowserForUrl", "(Landroid/content/Context;Landroid/net/Uri;)V", "")]
		public static unsafe void ShowMoPubBrowserForUrl (global::Android.Content.Context p0, global::Android.Net.Uri p1)
		{
			if (id_showMoPubBrowserForUrl_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
				id_showMoPubBrowserForUrl_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "showMoPubBrowserForUrl", "(Landroid/content/Context;Landroid/net/Uri;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_showMoPubBrowserForUrl_Landroid_content_Context_Landroid_net_Uri_, __args);
			} finally {
			}
		}

		static IntPtr id_startActivity_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Intents']/method[@name='startActivity' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("startActivity", "(Landroid/content/Context;Landroid/content/Intent;)V", "")]
		public static unsafe void StartActivity (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_startActivity_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_startActivity_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "startActivity", "(Landroid/content/Context;Landroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_startActivity_Landroid_content_Context_Landroid_content_Intent_, __args);
			} finally {
			}
		}

	}
}
