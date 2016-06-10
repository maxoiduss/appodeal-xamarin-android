using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='SharedPreferencesHelper']"
	[global::Android.Runtime.Register ("com/mopub/common/SharedPreferencesHelper", DoNotGenerateAcw=true)]
	public sealed partial class SharedPreferencesHelper : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='SharedPreferencesHelper']/field[@name='PREFERENCE_NAME']"
		[Register ("PREFERENCE_NAME")]
		public const string PreferenceName = (string) "mopubSettings";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/SharedPreferencesHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SharedPreferencesHelper); }
		}

		internal SharedPreferencesHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getSharedPreferences_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='SharedPreferencesHelper']/method[@name='getSharedPreferences' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getSharedPreferences", "(Landroid/content/Context;)Landroid/content/SharedPreferences;", "")]
		public static unsafe global::Android.Content.ISharedPreferences GetSharedPreferences (global::Android.Content.Context p0)
		{
			if (id_getSharedPreferences_Landroid_content_Context_ == IntPtr.Zero)
				id_getSharedPreferences_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getSharedPreferences", "(Landroid/content/Context;)Landroid/content/SharedPreferences;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Content.ISharedPreferences __ret = global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSharedPreferences_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
