using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']"
	[global::Android.Runtime.Register ("com/appodeal/ads/Appodeal", DoNotGenerateAcw=true)]
	public partial class Appodeal : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/field[@name='BANNER']"
		[Register ("BANNER")]
		public const int BANNER = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/field[@name='BANNER_BOTTOM']"
		[Register ("BANNER_BOTTOM")]
		public const int BANNER_BOTTOM = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/field[@name='BANNER_TOP']"
		[Register ("BANNER_TOP")]
		public const int BANNER_TOP = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/field[@name='BANNER_VIEW']"
		[Register ("BANNER_VIEW")]
		public const int BANNER_VIEW = (int) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/field[@name='INTERSTITIAL']"
		[Register ("INTERSTITIAL")]
		public const int INTERSTITIAL = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/field[@name='MREC']"
		[Register ("MREC")]
		public const int MREC = (int) 256;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/field[@name='NATIVE']"
		[Register ("NATIVE")]
		public const int NATIVE = (int) 512;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/field[@name='NONE']"
		[Register ("NONE")]
		public const int NONE = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/field[@name='NON_SKIPPABLE_VIDEO']"
		[Register ("NON_SKIPPABLE_VIDEO")]
		public const int NON_SKIPPABLE_VIDEO = (int) 128;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/field[@name='REWARDED_VIDEO']"
		[Register ("REWARDED_VIDEO")]
		public const int REWARDED_VIDEO = (int) 128;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/field[@name='SKIPPABLE_VIDEO']"
		[Register ("SKIPPABLE_VIDEO")]
		public const int SKIPPABLE_VIDEO = (int) 2;

		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/field[@name='b']"
		[Register ("b")]
		public static global::Android.App.Activity B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Landroid/app/Activity;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, b_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Landroid/app/Activity;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, b_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/appodeal/ads/Appodeal", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Appodeal); }
		}

		protected Appodeal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/constructor[@name='Appodeal' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Appodeal ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Appodeal)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_getLogLevel;
		static IntPtr id_setLogLevel_Lcom_appodeal_ads_utils_Log_LogLevel_;
		public static unsafe global::Com.Appodeal.Ads.Utils.Log.LogLevel LogLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='getLogLevel' and count(parameter)=0]"
			[Register ("getLogLevel", "()Lcom/appodeal/ads/utils/Log$LogLevel;", "GetGetLogLevelHandler")]
			get {
				if (id_getLogLevel == IntPtr.Zero)
					id_getLogLevel = JNIEnv.GetStaticMethodID (class_ref, "getLogLevel", "()Lcom/appodeal/ads/utils/Log$LogLevel;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Utils.Log.LogLevel> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLogLevel), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='setLogLevel' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.utils.Log.LogLevel']]"
			[Register ("setLogLevel", "(Lcom/appodeal/ads/utils/Log$LogLevel;)V", "GetSetLogLevel_Lcom_appodeal_ads_utils_Log_LogLevel_Handler")]
			set {
				if (id_setLogLevel_Lcom_appodeal_ads_utils_Log_LogLevel_ == IntPtr.Zero)
					id_setLogLevel_Lcom_appodeal_ads_utils_Log_LogLevel_ = JNIEnv.GetStaticMethodID (class_ref, "setLogLevel", "(Lcom/appodeal/ads/utils/Log$LogLevel;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setLogLevel_Lcom_appodeal_ads_utils_Log_LogLevel_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getNativeAdBox;
		public static unsafe global::Com.Appodeal.Ads.NativeAdBox NativeAdBox {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='getNativeAdBox' and count(parameter)=0]"
			[Register ("getNativeAdBox", "()Lcom/appodeal/ads/NativeAdBox;", "GetGetNativeAdBoxHandler")]
			get {
				if (id_getNativeAdBox == IntPtr.Zero)
					id_getNativeAdBox = JNIEnv.GetStaticMethodID (class_ref, "getNativeAdBox", "()Lcom/appodeal/ads/NativeAdBox;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.NativeAdBox> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNativeAdBox), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getVersion;
		public static unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetStaticMethodID (class_ref, "getVersion", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getVersion), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_a_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("a", "(Landroid/content/Context;I)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> A (global::Android.Content.Context p0, int p1)
		{
			if (id_a_Landroid_content_Context_I == IntPtr.Zero)
				id_a_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;I)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_content_Context_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)V", "")]
		public static unsafe void A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_a_Ljava_lang_String_Lcom_appodeal_ads_utils_Log_LogLevel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.appodeal.ads.utils.Log.LogLevel']]"
		[Register ("a", "(Ljava/lang/String;Lcom/appodeal/ads/utils/Log$LogLevel;)V", "")]
		public static unsafe void A (string p0, global::Com.Appodeal.Ads.Utils.Log.LogLevel p1)
		{
			if (id_a_Ljava_lang_String_Lcom_appodeal_ads_utils_Log_LogLevel_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Lcom_appodeal_ads_utils_Log_LogLevel_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;Lcom/appodeal/ads/utils/Log$LogLevel;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Ljava_lang_String_Lcom_appodeal_ads_utils_Log_LogLevel_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_a_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("a", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void A (global::Java.Lang.Throwable p0)
		{
			if (id_a_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_a_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_cache_Landroid_app_Activity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='cache' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("cache", "(Landroid/app/Activity;I)V", "")]
		public static unsafe void Cache (global::Android.App.Activity p0, int p1)
		{
			if (id_cache_Landroid_app_Activity_I == IntPtr.Zero)
				id_cache_Landroid_app_Activity_I = JNIEnv.GetStaticMethodID (class_ref, "cache", "(Landroid/app/Activity;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_cache_Landroid_app_Activity_I, __args);
			} finally {
			}
		}

		static IntPtr id_cache_Landroid_app_Activity_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='cache' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("cache", "(Landroid/app/Activity;II)V", "")]
		public static unsafe void Cache (global::Android.App.Activity p0, int p1, int p2)
		{
			if (id_cache_Landroid_app_Activity_II == IntPtr.Zero)
				id_cache_Landroid_app_Activity_II = JNIEnv.GetStaticMethodID (class_ref, "cache", "(Landroid/app/Activity;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_cache_Landroid_app_Activity_II, __args);
			} finally {
			}
		}

		static IntPtr id_confirm_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='confirm' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("confirm", "(I)V", "")]
		public static unsafe void Confirm (int p0)
		{
			if (id_confirm_I == IntPtr.Zero)
				id_confirm_I = JNIEnv.GetStaticMethodID (class_ref, "confirm", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_confirm_I, __args);
			} finally {
			}
		}

		static IntPtr id_disableLocationPermissionCheck;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='disableLocationPermissionCheck' and count(parameter)=0]"
		[Register ("disableLocationPermissionCheck", "()V", "")]
		public static unsafe void DisableLocationPermissionCheck ()
		{
			if (id_disableLocationPermissionCheck == IntPtr.Zero)
				id_disableLocationPermissionCheck = JNIEnv.GetStaticMethodID (class_ref, "disableLocationPermissionCheck", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_disableLocationPermissionCheck);
			} finally {
			}
		}

		static IntPtr id_disableNetwork_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='disableNetwork' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("disableNetwork", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void DisableNetwork (global::Android.Content.Context p0, string p1)
		{
			if (id_disableNetwork_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_disableNetwork_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "disableNetwork", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_disableNetwork_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_disableNetwork_Landroid_content_Context_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='disableNetwork' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("disableNetwork", "(Landroid/content/Context;Ljava/lang/String;I)V", "")]
		public static unsafe void DisableNetwork (global::Android.Content.Context p0, string p1, int p2)
		{
			if (id_disableNetwork_Landroid_content_Context_Ljava_lang_String_I == IntPtr.Zero)
				id_disableNetwork_Landroid_content_Context_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "disableNetwork", "(Landroid/content/Context;Ljava/lang/String;I)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_disableNetwork_Landroid_content_Context_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_disableWriteExternalStoragePermissionCheck;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='disableWriteExternalStoragePermissionCheck' and count(parameter)=0]"
		[Register ("disableWriteExternalStoragePermissionCheck", "()V", "")]
		public static unsafe void DisableWriteExternalStoragePermissionCheck ()
		{
			if (id_disableWriteExternalStoragePermissionCheck == IntPtr.Zero)
				id_disableWriteExternalStoragePermissionCheck = JNIEnv.GetStaticMethodID (class_ref, "disableWriteExternalStoragePermissionCheck", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_disableWriteExternalStoragePermissionCheck);
			} finally {
			}
		}

		static IntPtr id_getBannerView_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='getBannerView' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("getBannerView", "(Landroid/app/Activity;)Lcom/appodeal/ads/BannerView;", "")]
		public static unsafe global::Com.Appodeal.Ads.BannerView GetBannerView (global::Android.App.Activity p0)
		{
			if (id_getBannerView_Landroid_app_Activity_ == IntPtr.Zero)
				id_getBannerView_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "getBannerView", "(Landroid/app/Activity;)Lcom/appodeal/ads/BannerView;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Appodeal.Ads.BannerView __ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.BannerView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBannerView_Landroid_app_Activity_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getMrecView_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='getMrecView' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("getMrecView", "(Landroid/app/Activity;)Lcom/appodeal/ads/MrecView;", "")]
		public static unsafe global::Com.Appodeal.Ads.MrecView GetMrecView (global::Android.App.Activity p0)
		{
			if (id_getMrecView_Landroid_app_Activity_ == IntPtr.Zero)
				id_getMrecView_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "getMrecView", "(Landroid/app/Activity;)Lcom/appodeal/ads/MrecView;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Appodeal.Ads.MrecView __ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.MrecView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMrecView_Landroid_app_Activity_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getUserSettings_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='getUserSettings' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getUserSettings", "(Landroid/content/Context;)Lcom/appodeal/ads/UserSettings;", "")]
		public static unsafe global::Com.Appodeal.Ads.UserSettings GetUserSettings (global::Android.Content.Context p0)
		{
			if (id_getUserSettings_Landroid_content_Context_ == IntPtr.Zero)
				id_getUserSettings_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getUserSettings", "(Landroid/content/Context;)Lcom/appodeal/ads/UserSettings;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Appodeal.Ads.UserSettings __ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUserSettings_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hide_Landroid_app_Activity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='hide' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("hide", "(Landroid/app/Activity;I)V", "")]
		public static unsafe void Hide (global::Android.App.Activity p0, int p1)
		{
			if (id_hide_Landroid_app_Activity_I == IntPtr.Zero)
				id_hide_Landroid_app_Activity_I = JNIEnv.GetStaticMethodID (class_ref, "hide", "(Landroid/app/Activity;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_hide_Landroid_app_Activity_I, __args);
			} finally {
			}
		}

		static IntPtr id_initialize_Landroid_app_Activity_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='initialize' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("initialize", "(Landroid/app/Activity;Ljava/lang/String;I)V", "")]
		public static unsafe void Initialize (global::Android.App.Activity p0, string p1, int p2)
		{
			if (id_initialize_Landroid_app_Activity_Ljava_lang_String_I == IntPtr.Zero)
				id_initialize_Landroid_app_Activity_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Landroid/app/Activity;Ljava/lang/String;I)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initialize_Landroid_app_Activity_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_isLoaded_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='isLoaded' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isLoaded", "(I)Z", "")]
		public static unsafe bool IsLoaded (int p0)
		{
			if (id_isLoaded_I == IntPtr.Zero)
				id_isLoaded_I = JNIEnv.GetStaticMethodID (class_ref, "isLoaded", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isLoaded_I, __args);
			} finally {
			}
		}

		static IntPtr id_isPrecache_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='isPrecache' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isPrecache", "(I)Z", "")]
		public static unsafe bool IsPrecache (int p0)
		{
			if (id_isPrecache_I == IntPtr.Zero)
				id_isPrecache_I = JNIEnv.GetStaticMethodID (class_ref, "isPrecache", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isPrecache_I, __args);
			} finally {
			}
		}

		static IntPtr id_onResume_Landroid_app_Activity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='onResume' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("onResume", "(Landroid/app/Activity;I)V", "")]
		public static unsafe void OnResume (global::Android.App.Activity p0, int p1)
		{
			if (id_onResume_Landroid_app_Activity_I == IntPtr.Zero)
				id_onResume_Landroid_app_Activity_I = JNIEnv.GetStaticMethodID (class_ref, "onResume", "(Landroid/app/Activity;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onResume_Landroid_app_Activity_I, __args);
			} finally {
			}
		}

		static IntPtr id_requestAndroidMPermissions_Landroid_app_Activity_Lcom_appodeal_ads_utils_PermissionsHelper_AppodealPermissionCallbacks_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='requestAndroidMPermissions' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.appodeal.ads.utils.PermissionsHelper.AppodealPermissionCallbacks']]"
		[Register ("requestAndroidMPermissions", "(Landroid/app/Activity;Lcom/appodeal/ads/utils/PermissionsHelper$AppodealPermissionCallbacks;)V", "")]
		public static unsafe void RequestAndroidMPermissions (global::Android.App.Activity p0, global::Com.Appodeal.Ads.Utils.PermissionsHelper.IAppodealPermissionCallbacks p1)
		{
			if (id_requestAndroidMPermissions_Landroid_app_Activity_Lcom_appodeal_ads_utils_PermissionsHelper_AppodealPermissionCallbacks_ == IntPtr.Zero)
				id_requestAndroidMPermissions_Landroid_app_Activity_Lcom_appodeal_ads_utils_PermissionsHelper_AppodealPermissionCallbacks_ = JNIEnv.GetStaticMethodID (class_ref, "requestAndroidMPermissions", "(Landroid/app/Activity;Lcom/appodeal/ads/utils/PermissionsHelper$AppodealPermissionCallbacks;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_requestAndroidMPermissions_Landroid_app_Activity_Lcom_appodeal_ads_utils_PermissionsHelper_AppodealPermissionCallbacks_, __args);
			} finally {
			}
		}

		static IntPtr id_set728x90Banners_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='set728x90Banners' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("set728x90Banners", "(Z)V", "")]
		public static unsafe void Set728x90Banners (bool p0)
		{
			if (id_set728x90Banners_Z == IntPtr.Zero)
				id_set728x90Banners_Z = JNIEnv.GetStaticMethodID (class_ref, "set728x90Banners", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_set728x90Banners_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setAutoCache_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='setAutoCache' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setAutoCache", "(IZ)V", "")]
		public static unsafe void SetAutoCache (int p0, bool p1)
		{
			if (id_setAutoCache_IZ == IntPtr.Zero)
				id_setAutoCache_IZ = JNIEnv.GetStaticMethodID (class_ref, "setAutoCache", "(IZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAutoCache_IZ, __args);
			} finally {
			}
		}

		static IntPtr id_setAutoCacheNativeIcons_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='setAutoCacheNativeIcons' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAutoCacheNativeIcons", "(Z)V", "")]
		public static unsafe void SetAutoCacheNativeIcons (bool p0)
		{
			if (id_setAutoCacheNativeIcons_Z == IntPtr.Zero)
				id_setAutoCacheNativeIcons_Z = JNIEnv.GetStaticMethodID (class_ref, "setAutoCacheNativeIcons", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAutoCacheNativeIcons_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setAutoCacheNativeMedia_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='setAutoCacheNativeMedia' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAutoCacheNativeMedia", "(Z)V", "")]
		public static unsafe void SetAutoCacheNativeMedia (bool p0)
		{
			if (id_setAutoCacheNativeMedia_Z == IntPtr.Zero)
				id_setAutoCacheNativeMedia_Z = JNIEnv.GetStaticMethodID (class_ref, "setAutoCacheNativeMedia", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAutoCacheNativeMedia_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setBannerAnimation_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='setBannerAnimation' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setBannerAnimation", "(Z)V", "")]
		public static unsafe void SetBannerAnimation (bool p0)
		{
			if (id_setBannerAnimation_Z == IntPtr.Zero)
				id_setBannerAnimation_Z = JNIEnv.GetStaticMethodID (class_ref, "setBannerAnimation", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setBannerAnimation_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setBannerCallbacks_Lcom_appodeal_ads_BannerCallbacks_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='setBannerCallbacks' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.BannerCallbacks']]"
		[Register ("setBannerCallbacks", "(Lcom/appodeal/ads/BannerCallbacks;)V", "")]
		public static unsafe void SetBannerCallbacks (global::Com.Appodeal.Ads.IBannerCallbacks p0)
		{
			if (id_setBannerCallbacks_Lcom_appodeal_ads_BannerCallbacks_ == IntPtr.Zero)
				id_setBannerCallbacks_Lcom_appodeal_ads_BannerCallbacks_ = JNIEnv.GetStaticMethodID (class_ref, "setBannerCallbacks", "(Lcom/appodeal/ads/BannerCallbacks;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setBannerCallbacks_Lcom_appodeal_ads_BannerCallbacks_, __args);
			} finally {
			}
		}

		static IntPtr id_setBannerViewId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='setBannerViewId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBannerViewId", "(I)V", "")]
		public static unsafe void SetBannerViewId (int p0)
		{
			if (id_setBannerViewId_I == IntPtr.Zero)
				id_setBannerViewId_I = JNIEnv.GetStaticMethodID (class_ref, "setBannerViewId", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setBannerViewId_I, __args);
			} finally {
			}
		}

		static IntPtr id_setCustomRule_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='setCustomRule' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("setCustomRule", "(Ljava/lang/String;Z)V", "")]
		public static unsafe void SetCustomRule (string p0, bool p1)
		{
			if (id_setCustomRule_Ljava_lang_String_Z == IntPtr.Zero)
				id_setCustomRule_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "setCustomRule", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setCustomRule_Ljava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setCustomRule_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='setCustomRule' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("setCustomRule", "(Ljava/lang/String;D)V", "")]
		public static unsafe void SetCustomRule (string p0, double p1)
		{
			if (id_setCustomRule_Ljava_lang_String_D == IntPtr.Zero)
				id_setCustomRule_Ljava_lang_String_D = JNIEnv.GetStaticMethodID (class_ref, "setCustomRule", "(Ljava/lang/String;D)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setCustomRule_Ljava_lang_String_D, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setCustomRule_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='setCustomRule' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("setCustomRule", "(Ljava/lang/String;I)V", "")]
		public static unsafe void SetCustomRule (string p0, int p1)
		{
			if (id_setCustomRule_Ljava_lang_String_I == IntPtr.Zero)
				id_setCustomRule_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "setCustomRule", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setCustomRule_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setCustomRule_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='setCustomRule' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setCustomRule", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetCustomRule (string p0, string p1)
		{
			if (id_setCustomRule_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setCustomRule_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setCustomRule", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setCustomRule_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setInterstitialCallbacks_Lcom_appodeal_ads_InterstitialCallbacks_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='setInterstitialCallbacks' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.InterstitialCallbacks']]"
		[Register ("setInterstitialCallbacks", "(Lcom/appodeal/ads/InterstitialCallbacks;)V", "")]
		public static unsafe void SetInterstitialCallbacks (global::Com.Appodeal.Ads.IInterstitialCallbacks p0)
		{
			if (id_setInterstitialCallbacks_Lcom_appodeal_ads_InterstitialCallbacks_ == IntPtr.Zero)
				id_setInterstitialCallbacks_Lcom_appodeal_ads_InterstitialCallbacks_ = JNIEnv.GetStaticMethodID (class_ref, "setInterstitialCallbacks", "(Lcom/appodeal/ads/InterstitialCallbacks;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setInterstitialCallbacks_Lcom_appodeal_ads_InterstitialCallbacks_, __args);
			} finally {
			}
		}

		static IntPtr id_setMrecCallbacks_Lcom_appodeal_ads_MrecCallbacks_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='setMrecCallbacks' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.MrecCallbacks']]"
		[Register ("setMrecCallbacks", "(Lcom/appodeal/ads/MrecCallbacks;)V", "")]
		public static unsafe void SetMrecCallbacks (global::Com.Appodeal.Ads.IMrecCallbacks p0)
		{
			if (id_setMrecCallbacks_Lcom_appodeal_ads_MrecCallbacks_ == IntPtr.Zero)
				id_setMrecCallbacks_Lcom_appodeal_ads_MrecCallbacks_ = JNIEnv.GetStaticMethodID (class_ref, "setMrecCallbacks", "(Lcom/appodeal/ads/MrecCallbacks;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setMrecCallbacks_Lcom_appodeal_ads_MrecCallbacks_, __args);
			} finally {
			}
		}

		static IntPtr id_setMrecViewId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='setMrecViewId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMrecViewId", "(I)V", "")]
		public static unsafe void SetMrecViewId (int p0)
		{
			if (id_setMrecViewId_I == IntPtr.Zero)
				id_setMrecViewId_I = JNIEnv.GetStaticMethodID (class_ref, "setMrecViewId", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setMrecViewId_I, __args);
			} finally {
			}
		}

		static IntPtr id_setNativeAdType_Lcom_appodeal_ads_Native_NativeAdType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='setNativeAdType' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.Native.NativeAdType']]"
		[Register ("setNativeAdType", "(Lcom/appodeal/ads/Native$NativeAdType;)V", "")]
		public static unsafe void SetNativeAdType (global::Com.Appodeal.Ads.Native.NativeAdType p0)
		{
			if (id_setNativeAdType_Lcom_appodeal_ads_Native_NativeAdType_ == IntPtr.Zero)
				id_setNativeAdType_Lcom_appodeal_ads_Native_NativeAdType_ = JNIEnv.GetStaticMethodID (class_ref, "setNativeAdType", "(Lcom/appodeal/ads/Native$NativeAdType;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setNativeAdType_Lcom_appodeal_ads_Native_NativeAdType_, __args);
			} finally {
			}
		}

		static IntPtr id_setNativeCallbacks_Lcom_appodeal_ads_NativeCallbacks_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='setNativeCallbacks' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.NativeCallbacks']]"
		[Register ("setNativeCallbacks", "(Lcom/appodeal/ads/NativeCallbacks;)V", "")]
		public static unsafe void SetNativeCallbacks (global::Com.Appodeal.Ads.INativeCallbacks p0)
		{
			if (id_setNativeCallbacks_Lcom_appodeal_ads_NativeCallbacks_ == IntPtr.Zero)
				id_setNativeCallbacks_Lcom_appodeal_ads_NativeCallbacks_ = JNIEnv.GetStaticMethodID (class_ref, "setNativeCallbacks", "(Lcom/appodeal/ads/NativeCallbacks;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setNativeCallbacks_Lcom_appodeal_ads_NativeCallbacks_, __args);
			} finally {
			}
		}

		static IntPtr id_setNonSkippableVideoCallbacks_Lcom_appodeal_ads_NonSkippableVideoCallbacks_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='setNonSkippableVideoCallbacks' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.NonSkippableVideoCallbacks']]"
		[Register ("setNonSkippableVideoCallbacks", "(Lcom/appodeal/ads/NonSkippableVideoCallbacks;)V", "")]
		public static unsafe void SetNonSkippableVideoCallbacks (global::Com.Appodeal.Ads.INonSkippableVideoCallbacks p0)
		{
			if (id_setNonSkippableVideoCallbacks_Lcom_appodeal_ads_NonSkippableVideoCallbacks_ == IntPtr.Zero)
				id_setNonSkippableVideoCallbacks_Lcom_appodeal_ads_NonSkippableVideoCallbacks_ = JNIEnv.GetStaticMethodID (class_ref, "setNonSkippableVideoCallbacks", "(Lcom/appodeal/ads/NonSkippableVideoCallbacks;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setNonSkippableVideoCallbacks_Lcom_appodeal_ads_NonSkippableVideoCallbacks_, __args);
			} finally {
			}
		}

		static IntPtr id_setOnLoadedTriggerBoth_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='setOnLoadedTriggerBoth' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setOnLoadedTriggerBoth", "(IZ)V", "")]
		public static unsafe void SetOnLoadedTriggerBoth (int p0, bool p1)
		{
			if (id_setOnLoadedTriggerBoth_IZ == IntPtr.Zero)
				id_setOnLoadedTriggerBoth_IZ = JNIEnv.GetStaticMethodID (class_ref, "setOnLoadedTriggerBoth", "(IZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setOnLoadedTriggerBoth_IZ, __args);
			} finally {
			}
		}

		static IntPtr id_setRewardedVideoCallbacks_Lcom_appodeal_ads_RewardedVideoCallbacks_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='setRewardedVideoCallbacks' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.RewardedVideoCallbacks']]"
		[Register ("setRewardedVideoCallbacks", "(Lcom/appodeal/ads/RewardedVideoCallbacks;)V", "")]
		public static unsafe void SetRewardedVideoCallbacks (global::Com.Appodeal.Ads.IRewardedVideoCallbacks p0)
		{
			if (id_setRewardedVideoCallbacks_Lcom_appodeal_ads_RewardedVideoCallbacks_ == IntPtr.Zero)
				id_setRewardedVideoCallbacks_Lcom_appodeal_ads_RewardedVideoCallbacks_ = JNIEnv.GetStaticMethodID (class_ref, "setRewardedVideoCallbacks", "(Lcom/appodeal/ads/RewardedVideoCallbacks;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setRewardedVideoCallbacks_Lcom_appodeal_ads_RewardedVideoCallbacks_, __args);
			} finally {
			}
		}

		static IntPtr id_setSkippableVideoCallbacks_Lcom_appodeal_ads_SkippableVideoCallbacks_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='setSkippableVideoCallbacks' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.SkippableVideoCallbacks']]"
		[Register ("setSkippableVideoCallbacks", "(Lcom/appodeal/ads/SkippableVideoCallbacks;)V", "")]
		public static unsafe void SetSkippableVideoCallbacks (global::Com.Appodeal.Ads.ISkippableVideoCallbacks p0)
		{
			if (id_setSkippableVideoCallbacks_Lcom_appodeal_ads_SkippableVideoCallbacks_ == IntPtr.Zero)
				id_setSkippableVideoCallbacks_Lcom_appodeal_ads_SkippableVideoCallbacks_ = JNIEnv.GetStaticMethodID (class_ref, "setSkippableVideoCallbacks", "(Lcom/appodeal/ads/SkippableVideoCallbacks;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setSkippableVideoCallbacks_Lcom_appodeal_ads_SkippableVideoCallbacks_, __args);
			} finally {
			}
		}

		static IntPtr id_setSmartBanners_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='setSmartBanners' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSmartBanners", "(Z)V", "")]
		public static unsafe void SetSmartBanners (bool p0)
		{
			if (id_setSmartBanners_Z == IntPtr.Zero)
				id_setSmartBanners_Z = JNIEnv.GetStaticMethodID (class_ref, "setSmartBanners", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setSmartBanners_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setTesting_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='setTesting' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setTesting", "(Z)V", "")]
		public static unsafe void SetTesting (bool p0)
		{
			if (id_setTesting_Z == IntPtr.Zero)
				id_setTesting_Z = JNIEnv.GetStaticMethodID (class_ref, "setTesting", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setTesting_Z, __args);
			} finally {
			}
		}

		static IntPtr id_show_Landroid_app_Activity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='show' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("show", "(Landroid/app/Activity;I)Z", "")]
		public static unsafe bool Show (global::Android.App.Activity p0, int p1)
		{
			if (id_show_Landroid_app_Activity_I == IntPtr.Zero)
				id_show_Landroid_app_Activity_I = JNIEnv.GetStaticMethodID (class_ref, "show", "(Landroid/app/Activity;I)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_show_Landroid_app_Activity_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_show_Landroid_app_Activity_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='show' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("show", "(Landroid/app/Activity;ILjava/lang/String;)Z", "")]
		public static unsafe bool Show (global::Android.App.Activity p0, int p1, string p2)
		{
			if (id_show_Landroid_app_Activity_ILjava_lang_String_ == IntPtr.Zero)
				id_show_Landroid_app_Activity_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "show", "(Landroid/app/Activity;ILjava/lang/String;)Z");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_show_Landroid_app_Activity_ILjava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_trackInAppPurchase_Landroid_content_Context_DLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='trackInAppPurchase' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='double'] and parameter[3][@type='java.lang.String']]"
		[Register ("trackInAppPurchase", "(Landroid/content/Context;DLjava/lang/String;)V", "")]
		public static unsafe void TrackInAppPurchase (global::Android.Content.Context p0, double p1, string p2)
		{
			if (id_trackInAppPurchase_Landroid_content_Context_DLjava_lang_String_ == IntPtr.Zero)
				id_trackInAppPurchase_Landroid_content_Context_DLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "trackInAppPurchase", "(Landroid/content/Context;DLjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_trackInAppPurchase_Landroid_content_Context_DLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
