using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']"
	[global::Android.Runtime.Register ("com/appodeal/ads/Appodeal", DoNotGenerateAcw=true)]
	public partial class Appodeal : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/field[@name='ALL']"
		[Register ("ALL")]
		public const int All = (int) 255;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/field[@name='ANY']"
		[Register ("ANY")]
		public const int Any = (int) 255;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/field[@name='BANNER']"
		[Register ("BANNER")]
		public const int Banner = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/field[@name='BANNER_BOTTOM']"
		[Register ("BANNER_BOTTOM")]
		public const int BannerBottom = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/field[@name='BANNER_CENTER']"
		[Register ("BANNER_CENTER")]
		public const int BannerCenter = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/field[@name='BANNER_TOP']"
		[Register ("BANNER_TOP")]
		public const int BannerTop = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/field[@name='BANNER_VIEW']"
		[Register ("BANNER_VIEW")]
		public const int BannerView = (int) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/field[@name='INTERSTITIAL']"
		[Register ("INTERSTITIAL")]
		public const int Interstitial = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/field[@name='NONE']"
		[Register ("NONE")]
		public const int None = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/field[@name='VIDEO']"
		[Register ("VIDEO")]
		public const int Video = (int) 2;

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

		static IntPtr c_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/field[@name='c']"
		[Register ("c")]
		public static global::Com.Appodeal.Ads.LoaderActivity C {
			get {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/appodeal/ads/LoaderActivity;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, c_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.LoaderActivity> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/appodeal/ads/LoaderActivity;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, c_jfieldId, native_value);
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
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Appodeal)) {
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

		static IntPtr id_a_Ljava_lang_Error_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Error']]"
		[Register ("a", "(Ljava/lang/Error;)V", "")]
		public static unsafe void A (global::Java.Lang.Error p0)
		{
			if (id_a_Ljava_lang_Error_ == IntPtr.Zero)
				id_a_Ljava_lang_Error_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/Error;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Ljava_lang_Error_, __args);
			} finally {
			}
		}

		static IntPtr id_a_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("a", "(Ljava/lang/Exception;)V", "")]
		public static unsafe void A (global::Java.Lang.Exception p0)
		{
			if (id_a_Ljava_lang_Exception_ == IntPtr.Zero)
				id_a_Ljava_lang_Exception_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/Exception;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Ljava_lang_Exception_, __args);
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

		static IntPtr id_a_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='a' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("a", "(Lorg/json/JSONObject;)V", "")]
		public static unsafe void A (global::Org.Json.JSONObject p0)
		{
			if (id_a_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_a_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Lorg_json_JSONObject_, __args);
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

		static IntPtr id_initialize_Landroid_app_Activity_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String']]"
		[Register ("initialize", "(Landroid/app/Activity;Ljava/lang/String;)V", "")]
		public static unsafe void Initialize (global::Android.App.Activity p0, string p1)
		{
			if (id_initialize_Landroid_app_Activity_Ljava_lang_String_ == IntPtr.Zero)
				id_initialize_Landroid_app_Activity_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Landroid/app/Activity;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initialize_Landroid_app_Activity_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
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

		static IntPtr id_isLoadedWithPriceFloor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='isLoadedWithPriceFloor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isLoadedWithPriceFloor", "(I)Z", "")]
		public static unsafe bool IsLoadedWithPriceFloor (int p0)
		{
			if (id_isLoadedWithPriceFloor_I == IntPtr.Zero)
				id_isLoadedWithPriceFloor_I = JNIEnv.GetStaticMethodID (class_ref, "isLoadedWithPriceFloor", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isLoadedWithPriceFloor_I, __args);
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

		static IntPtr id_setVideoCallbacks_Lcom_appodeal_ads_VideoCallbacks_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='setVideoCallbacks' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.VideoCallbacks']]"
		[Register ("setVideoCallbacks", "(Lcom/appodeal/ads/VideoCallbacks;)V", "")]
		public static unsafe void SetVideoCallbacks (global::Com.Appodeal.Ads.IVideoCallbacks p0)
		{
			if (id_setVideoCallbacks_Lcom_appodeal_ads_VideoCallbacks_ == IntPtr.Zero)
				id_setVideoCallbacks_Lcom_appodeal_ads_VideoCallbacks_ = JNIEnv.GetStaticMethodID (class_ref, "setVideoCallbacks", "(Lcom/appodeal/ads/VideoCallbacks;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setVideoCallbacks_Lcom_appodeal_ads_VideoCallbacks_, __args);
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

		static IntPtr id_showWithPriceFloor_Landroid_app_Activity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Appodeal']/method[@name='showWithPriceFloor' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("showWithPriceFloor", "(Landroid/app/Activity;I)Z", "")]
		public static unsafe bool ShowWithPriceFloor (global::Android.App.Activity p0, int p1)
		{
			if (id_showWithPriceFloor_Landroid_app_Activity_I == IntPtr.Zero)
				id_showWithPriceFloor_Landroid_app_Activity_I = JNIEnv.GetStaticMethodID (class_ref, "showWithPriceFloor", "(Landroid/app/Activity;I)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_showWithPriceFloor_Landroid_app_Activity_I, __args);
				return __ret;
			} finally {
			}
		}

	}
}
