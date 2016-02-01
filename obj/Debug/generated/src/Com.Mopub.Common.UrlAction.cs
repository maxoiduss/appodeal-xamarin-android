using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlAction']"
	[global::Android.Runtime.Register ("com/mopub/common/UrlAction", DoNotGenerateAcw=true)]
	public abstract partial class UrlAction : global::Java.Lang.Enum {


		static IntPtr FOLLOW_DEEP_LINK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlAction']/field[@name='FOLLOW_DEEP_LINK']"
		[Register ("FOLLOW_DEEP_LINK")]
		public static global::Com.Mopub.Common.UrlAction FollowDeepLink {
			get {
				if (FOLLOW_DEEP_LINK_jfieldId == IntPtr.Zero)
					FOLLOW_DEEP_LINK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FOLLOW_DEEP_LINK", "Lcom/mopub/common/UrlAction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FOLLOW_DEEP_LINK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlAction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FOLLOW_DEEP_LINK_WITH_FALLBACK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlAction']/field[@name='FOLLOW_DEEP_LINK_WITH_FALLBACK']"
		[Register ("FOLLOW_DEEP_LINK_WITH_FALLBACK")]
		public static global::Com.Mopub.Common.UrlAction FollowDeepLinkWithFallback {
			get {
				if (FOLLOW_DEEP_LINK_WITH_FALLBACK_jfieldId == IntPtr.Zero)
					FOLLOW_DEEP_LINK_WITH_FALLBACK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FOLLOW_DEEP_LINK_WITH_FALLBACK", "Lcom/mopub/common/UrlAction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FOLLOW_DEEP_LINK_WITH_FALLBACK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlAction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HANDLE_MOPUB_SCHEME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlAction']/field[@name='HANDLE_MOPUB_SCHEME']"
		[Register ("HANDLE_MOPUB_SCHEME")]
		public static global::Com.Mopub.Common.UrlAction HandleMopubScheme {
			get {
				if (HANDLE_MOPUB_SCHEME_jfieldId == IntPtr.Zero)
					HANDLE_MOPUB_SCHEME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HANDLE_MOPUB_SCHEME", "Lcom/mopub/common/UrlAction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HANDLE_MOPUB_SCHEME_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlAction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HANDLE_PHONE_SCHEME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlAction']/field[@name='HANDLE_PHONE_SCHEME']"
		[Register ("HANDLE_PHONE_SCHEME")]
		public static global::Com.Mopub.Common.UrlAction HandlePhoneScheme {
			get {
				if (HANDLE_PHONE_SCHEME_jfieldId == IntPtr.Zero)
					HANDLE_PHONE_SCHEME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HANDLE_PHONE_SCHEME", "Lcom/mopub/common/UrlAction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HANDLE_PHONE_SCHEME_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlAction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HANDLE_SHARE_TWEET_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlAction']/field[@name='HANDLE_SHARE_TWEET']"
		[Register ("HANDLE_SHARE_TWEET")]
		public static global::Com.Mopub.Common.UrlAction HandleShareTweet {
			get {
				if (HANDLE_SHARE_TWEET_jfieldId == IntPtr.Zero)
					HANDLE_SHARE_TWEET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HANDLE_SHARE_TWEET", "Lcom/mopub/common/UrlAction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HANDLE_SHARE_TWEET_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlAction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr IGNORE_ABOUT_SCHEME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlAction']/field[@name='IGNORE_ABOUT_SCHEME']"
		[Register ("IGNORE_ABOUT_SCHEME")]
		public static global::Com.Mopub.Common.UrlAction IgnoreAboutScheme {
			get {
				if (IGNORE_ABOUT_SCHEME_jfieldId == IntPtr.Zero)
					IGNORE_ABOUT_SCHEME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IGNORE_ABOUT_SCHEME", "Lcom/mopub/common/UrlAction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IGNORE_ABOUT_SCHEME_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlAction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NOOP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlAction']/field[@name='NOOP']"
		[Register ("NOOP")]
		public static global::Com.Mopub.Common.UrlAction Noop {
			get {
				if (NOOP_jfieldId == IntPtr.Zero)
					NOOP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOOP", "Lcom/mopub/common/UrlAction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOOP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlAction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OPEN_APP_MARKET_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlAction']/field[@name='OPEN_APP_MARKET']"
		[Register ("OPEN_APP_MARKET")]
		public static global::Com.Mopub.Common.UrlAction OpenAppMarket {
			get {
				if (OPEN_APP_MARKET_jfieldId == IntPtr.Zero)
					OPEN_APP_MARKET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPEN_APP_MARKET", "Lcom/mopub/common/UrlAction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OPEN_APP_MARKET_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlAction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OPEN_IN_APP_BROWSER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlAction']/field[@name='OPEN_IN_APP_BROWSER']"
		[Register ("OPEN_IN_APP_BROWSER")]
		public static global::Com.Mopub.Common.UrlAction OpenInAppBrowser {
			get {
				if (OPEN_IN_APP_BROWSER_jfieldId == IntPtr.Zero)
					OPEN_IN_APP_BROWSER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPEN_IN_APP_BROWSER", "Lcom/mopub/common/UrlAction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OPEN_IN_APP_BROWSER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlAction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OPEN_NATIVE_BROWSER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlAction']/field[@name='OPEN_NATIVE_BROWSER']"
		[Register ("OPEN_NATIVE_BROWSER")]
		public static global::Com.Mopub.Common.UrlAction OpenNativeBrowser {
			get {
				if (OPEN_NATIVE_BROWSER_jfieldId == IntPtr.Zero)
					OPEN_NATIVE_BROWSER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPEN_NATIVE_BROWSER", "Lcom/mopub/common/UrlAction;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OPEN_NATIVE_BROWSER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlAction> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/UrlAction", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UrlAction); }
		}

		protected UrlAction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_handleUrl_Lcom_mopub_common_UrlHandler_Landroid_content_Context_Landroid_net_Uri_Z;
#pragma warning disable 0169
		static Delegate GetHandleUrl_Lcom_mopub_common_UrlHandler_Landroid_content_Context_Landroid_net_Uri_ZHandler ()
		{
			if (cb_handleUrl_Lcom_mopub_common_UrlHandler_Landroid_content_Context_Landroid_net_Uri_Z == null)
				cb_handleUrl_Lcom_mopub_common_UrlHandler_Landroid_content_Context_Landroid_net_Uri_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_HandleUrl_Lcom_mopub_common_UrlHandler_Landroid_content_Context_Landroid_net_Uri_Z);
			return cb_handleUrl_Lcom_mopub_common_UrlHandler_Landroid_content_Context_Landroid_net_Uri_Z;
		}

		static void n_HandleUrl_Lcom_mopub_common_UrlHandler_Landroid_content_Context_Landroid_net_Uri_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			global::Com.Mopub.Common.UrlAction __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Common.UrlHandler p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p2 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.HandleUrl (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_handleUrl_Lcom_mopub_common_UrlHandler_Landroid_content_Context_Landroid_net_Uri_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlAction']/method[@name='handleUrl' and count(parameter)=4 and parameter[1][@type='com.mopub.common.UrlHandler'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='android.net.Uri'] and parameter[4][@type='boolean']]"
		[Register ("handleUrl", "(Lcom/mopub/common/UrlHandler;Landroid/content/Context;Landroid/net/Uri;Z)V", "GetHandleUrl_Lcom_mopub_common_UrlHandler_Landroid_content_Context_Landroid_net_Uri_ZHandler")]
		public virtual unsafe void HandleUrl (global::Com.Mopub.Common.UrlHandler p0, global::Android.Content.Context p1, global::Android.Net.Uri p2, bool p3)
		{
			if (id_handleUrl_Lcom_mopub_common_UrlHandler_Landroid_content_Context_Landroid_net_Uri_Z == IntPtr.Zero)
				id_handleUrl_Lcom_mopub_common_UrlHandler_Landroid_content_Context_Landroid_net_Uri_Z = JNIEnv.GetMethodID (class_ref, "handleUrl", "(Lcom/mopub/common/UrlHandler;Landroid/content/Context;Landroid/net/Uri;Z)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_handleUrl_Lcom_mopub_common_UrlHandler_Landroid_content_Context_Landroid_net_Uri_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleUrl", "(Lcom/mopub/common/UrlHandler;Landroid/content/Context;Landroid/net/Uri;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_performAction_Landroid_content_Context_Landroid_net_Uri_Lcom_mopub_common_UrlHandler_;
#pragma warning disable 0169
		static Delegate GetPerformAction_Landroid_content_Context_Landroid_net_Uri_Lcom_mopub_common_UrlHandler_Handler ()
		{
			if (cb_performAction_Landroid_content_Context_Landroid_net_Uri_Lcom_mopub_common_UrlHandler_ == null)
				cb_performAction_Landroid_content_Context_Landroid_net_Uri_Lcom_mopub_common_UrlHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PerformAction_Landroid_content_Context_Landroid_net_Uri_Lcom_mopub_common_UrlHandler_);
			return cb_performAction_Landroid_content_Context_Landroid_net_Uri_Lcom_mopub_common_UrlHandler_;
		}

		static void n_PerformAction_Landroid_content_Context_Landroid_net_Uri_Lcom_mopub_common_UrlHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mopub.Common.UrlAction __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Common.UrlHandler p2 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.PerformAction (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlAction']/method[@name='performAction' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='com.mopub.common.UrlHandler']]"
		[Register ("performAction", "(Landroid/content/Context;Landroid/net/Uri;Lcom/mopub/common/UrlHandler;)V", "GetPerformAction_Landroid_content_Context_Landroid_net_Uri_Lcom_mopub_common_UrlHandler_Handler")]
		protected abstract void PerformAction (global::Android.Content.Context p0, global::Android.Net.Uri p1, global::Com.Mopub.Common.UrlHandler p2);

		static Delegate cb_shouldTryHandlingUrl_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetShouldTryHandlingUrl_Landroid_net_Uri_Handler ()
		{
			if (cb_shouldTryHandlingUrl_Landroid_net_Uri_ == null)
				cb_shouldTryHandlingUrl_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ShouldTryHandlingUrl_Landroid_net_Uri_);
			return cb_shouldTryHandlingUrl_Landroid_net_Uri_;
		}

		static bool n_ShouldTryHandlingUrl_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.UrlAction __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ShouldTryHandlingUrl (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlAction']/method[@name='shouldTryHandlingUrl' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("shouldTryHandlingUrl", "(Landroid/net/Uri;)Z", "GetShouldTryHandlingUrl_Landroid_net_Uri_Handler")]
		public abstract bool ShouldTryHandlingUrl (global::Android.Net.Uri p0);

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlAction']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/common/UrlAction;", "")]
		public static unsafe global::Com.Mopub.Common.UrlAction ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/common/UrlAction;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Mopub.Common.UrlAction __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlAction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlAction']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/mopub/common/UrlAction;", "")]
		public static unsafe global::Com.Mopub.Common.UrlAction[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/common/UrlAction;");
			try {
				return (global::Com.Mopub.Common.UrlAction[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Common.UrlAction));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/mopub/common/UrlAction", DoNotGenerateAcw=true)]
	internal partial class UrlActionInvoker : UrlAction {

		public UrlActionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (UrlActionInvoker); }
		}

		static IntPtr id_performAction_Landroid_content_Context_Landroid_net_Uri_Lcom_mopub_common_UrlHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlAction']/method[@name='performAction' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='com.mopub.common.UrlHandler']]"
		[Register ("performAction", "(Landroid/content/Context;Landroid/net/Uri;Lcom/mopub/common/UrlHandler;)V", "GetPerformAction_Landroid_content_Context_Landroid_net_Uri_Lcom_mopub_common_UrlHandler_Handler")]
		protected override unsafe void PerformAction (global::Android.Content.Context p0, global::Android.Net.Uri p1, global::Com.Mopub.Common.UrlHandler p2)
		{
			if (id_performAction_Landroid_content_Context_Landroid_net_Uri_Lcom_mopub_common_UrlHandler_ == IntPtr.Zero)
				id_performAction_Landroid_content_Context_Landroid_net_Uri_Lcom_mopub_common_UrlHandler_ = JNIEnv.GetMethodID (class_ref, "performAction", "(Landroid/content/Context;Landroid/net/Uri;Lcom/mopub/common/UrlHandler;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod  (Handle, id_performAction_Landroid_content_Context_Landroid_net_Uri_Lcom_mopub_common_UrlHandler_, __args);
			} finally {
			}
		}

		static IntPtr id_shouldTryHandlingUrl_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlAction']/method[@name='shouldTryHandlingUrl' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("shouldTryHandlingUrl", "(Landroid/net/Uri;)Z", "GetShouldTryHandlingUrl_Landroid_net_Uri_Handler")]
		public override unsafe bool ShouldTryHandlingUrl (global::Android.Net.Uri p0)
		{
			if (id_shouldTryHandlingUrl_Landroid_net_Uri_ == IntPtr.Zero)
				id_shouldTryHandlingUrl_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "shouldTryHandlingUrl", "(Landroid/net/Uri;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_shouldTryHandlingUrl_Landroid_net_Uri_, __args);
				return __ret;
			} finally {
			}
		}

	}

}
