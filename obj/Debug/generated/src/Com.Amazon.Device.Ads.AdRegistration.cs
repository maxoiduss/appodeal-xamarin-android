using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Device.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdRegistration']"
	[global::Android.Runtime.Register ("com/amazon/device/ads/AdRegistration", DoNotGenerateAcw=true)]
	public partial class AdRegistration : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/device/ads/AdRegistration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdRegistration); }
		}

		protected AdRegistration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getVersion;
		public static unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdRegistration']/method[@name='getVersion' and count(parameter)=0]"
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

		static IntPtr id_enableLogging_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdRegistration']/method[@name='enableLogging' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableLogging", "(Z)V", "")]
		public static unsafe void EnableLogging (bool p0)
		{
			if (id_enableLogging_Z == IntPtr.Zero)
				id_enableLogging_Z = JNIEnv.GetStaticMethodID (class_ref, "enableLogging", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_enableLogging_Z, __args);
			} finally {
			}
		}

		static IntPtr id_enableTesting_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdRegistration']/method[@name='enableTesting' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableTesting", "(Z)V", "")]
		public static unsafe void EnableTesting (bool p0)
		{
			if (id_enableTesting_Z == IntPtr.Zero)
				id_enableTesting_Z = JNIEnv.GetStaticMethodID (class_ref, "enableTesting", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_enableTesting_Z, __args);
			} finally {
			}
		}

		static IntPtr id_registerApp_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdRegistration']/method[@name='registerApp' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("registerApp", "(Landroid/content/Context;)V", "")]
		public static unsafe void RegisterApp (global::Android.Content.Context p0)
		{
			if (id_registerApp_Landroid_content_Context_ == IntPtr.Zero)
				id_registerApp_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "registerApp", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_registerApp_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_setAppKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdRegistration']/method[@name='setAppKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAppKey", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetAppKey (string p0)
		{
			if (id_setAppKey_Ljava_lang_String_ == IntPtr.Zero)
				id_setAppKey_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setAppKey", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAppKey_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
