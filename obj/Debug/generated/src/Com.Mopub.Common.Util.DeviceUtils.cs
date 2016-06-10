using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DeviceUtils']"
	[global::Android.Runtime.Register ("com/mopub/common/util/DeviceUtils", DoNotGenerateAcw=true)]
	public partial class DeviceUtils : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DeviceUtils.ForceOrientation']"
		[global::Android.Runtime.Register ("com/mopub/common/util/DeviceUtils$ForceOrientation", DoNotGenerateAcw=true)]
		public sealed partial class ForceOrientation : global::Java.Lang.Enum {


			static IntPtr DEVICE_ORIENTATION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DeviceUtils.ForceOrientation']/field[@name='DEVICE_ORIENTATION']"
			[Register ("DEVICE_ORIENTATION")]
			public static global::Com.Mopub.Common.Util.DeviceUtils.ForceOrientation DeviceOrientation {
				get {
					if (DEVICE_ORIENTATION_jfieldId == IntPtr.Zero)
						DEVICE_ORIENTATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_ORIENTATION", "Lcom/mopub/common/util/DeviceUtils$ForceOrientation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_ORIENTATION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.DeviceUtils.ForceOrientation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FORCE_LANDSCAPE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DeviceUtils.ForceOrientation']/field[@name='FORCE_LANDSCAPE']"
			[Register ("FORCE_LANDSCAPE")]
			public static global::Com.Mopub.Common.Util.DeviceUtils.ForceOrientation ForceLandscape {
				get {
					if (FORCE_LANDSCAPE_jfieldId == IntPtr.Zero)
						FORCE_LANDSCAPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FORCE_LANDSCAPE", "Lcom/mopub/common/util/DeviceUtils$ForceOrientation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FORCE_LANDSCAPE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.DeviceUtils.ForceOrientation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FORCE_PORTRAIT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DeviceUtils.ForceOrientation']/field[@name='FORCE_PORTRAIT']"
			[Register ("FORCE_PORTRAIT")]
			public static global::Com.Mopub.Common.Util.DeviceUtils.ForceOrientation ForcePortrait {
				get {
					if (FORCE_PORTRAIT_jfieldId == IntPtr.Zero)
						FORCE_PORTRAIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FORCE_PORTRAIT", "Lcom/mopub/common/util/DeviceUtils$ForceOrientation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FORCE_PORTRAIT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.DeviceUtils.ForceOrientation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNDEFINED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DeviceUtils.ForceOrientation']/field[@name='UNDEFINED']"
			[Register ("UNDEFINED")]
			public static global::Com.Mopub.Common.Util.DeviceUtils.ForceOrientation Undefined {
				get {
					if (UNDEFINED_jfieldId == IntPtr.Zero)
						UNDEFINED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNDEFINED", "Lcom/mopub/common/util/DeviceUtils$ForceOrientation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNDEFINED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.DeviceUtils.ForceOrientation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/util/DeviceUtils$ForceOrientation", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ForceOrientation); }
			}

			internal ForceOrientation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getForceOrientation_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DeviceUtils.ForceOrientation']/method[@name='getForceOrientation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getForceOrientation", "(Ljava/lang/String;)Lcom/mopub/common/util/DeviceUtils$ForceOrientation;", "")]
			public static unsafe global::Com.Mopub.Common.Util.DeviceUtils.ForceOrientation GetForceOrientation (string p0)
			{
				if (id_getForceOrientation_Ljava_lang_String_ == IntPtr.Zero)
					id_getForceOrientation_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getForceOrientation", "(Ljava/lang/String;)Lcom/mopub/common/util/DeviceUtils$ForceOrientation;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mopub.Common.Util.DeviceUtils.ForceOrientation __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.DeviceUtils.ForceOrientation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getForceOrientation_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DeviceUtils.ForceOrientation']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/common/util/DeviceUtils$ForceOrientation;", "")]
			public static unsafe global::Com.Mopub.Common.Util.DeviceUtils.ForceOrientation ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/common/util/DeviceUtils$ForceOrientation;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mopub.Common.Util.DeviceUtils.ForceOrientation __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.DeviceUtils.ForceOrientation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DeviceUtils.ForceOrientation']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/common/util/DeviceUtils$ForceOrientation;", "")]
			public static unsafe global::Com.Mopub.Common.Util.DeviceUtils.ForceOrientation[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/common/util/DeviceUtils$ForceOrientation;");
				try {
					return (global::Com.Mopub.Common.Util.DeviceUtils.ForceOrientation[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Common.Util.DeviceUtils.ForceOrientation));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DeviceUtils.IP']"
		[global::Android.Runtime.Register ("com/mopub/common/util/DeviceUtils$IP", DoNotGenerateAcw=true)]
		public sealed partial class IP : global::Java.Lang.Enum {


			static IntPtr IPv4_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DeviceUtils.IP']/field[@name='IPv4']"
			[Register ("IPv4")]
			public static global::Com.Mopub.Common.Util.DeviceUtils.IP IPv4 {
				get {
					if (IPv4_jfieldId == IntPtr.Zero)
						IPv4_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IPv4", "Lcom/mopub/common/util/DeviceUtils$IP;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IPv4_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.DeviceUtils.IP> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr IPv6_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DeviceUtils.IP']/field[@name='IPv6']"
			[Register ("IPv6")]
			public static global::Com.Mopub.Common.Util.DeviceUtils.IP IPv6 {
				get {
					if (IPv6_jfieldId == IntPtr.Zero)
						IPv6_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IPv6", "Lcom/mopub/common/util/DeviceUtils$IP;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IPv6_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.DeviceUtils.IP> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/util/DeviceUtils$IP", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IP); }
			}

			internal IP (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DeviceUtils.IP']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/common/util/DeviceUtils$IP;", "")]
			public static unsafe global::Com.Mopub.Common.Util.DeviceUtils.IP ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/common/util/DeviceUtils$IP;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mopub.Common.Util.DeviceUtils.IP __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.DeviceUtils.IP> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DeviceUtils.IP']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/common/util/DeviceUtils$IP;", "")]
			public static unsafe global::Com.Mopub.Common.Util.DeviceUtils.IP[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/common/util/DeviceUtils$IP;");
				try {
					return (global::Com.Mopub.Common.Util.DeviceUtils.IP[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Common.Util.DeviceUtils.IP));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/util/DeviceUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceUtils); }
		}

		protected DeviceUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_diskCacheSizeBytes_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DeviceUtils']/method[@name='diskCacheSizeBytes' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("diskCacheSizeBytes", "(Ljava/io/File;)J", "")]
		public static unsafe long DiskCacheSizeBytes (global::Java.IO.File p0)
		{
			if (id_diskCacheSizeBytes_Ljava_io_File_ == IntPtr.Zero)
				id_diskCacheSizeBytes_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "diskCacheSizeBytes", "(Ljava/io/File;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_diskCacheSizeBytes_Ljava_io_File_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_diskCacheSizeBytes_Ljava_io_File_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DeviceUtils']/method[@name='diskCacheSizeBytes' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='long']]"
		[Register ("diskCacheSizeBytes", "(Ljava/io/File;J)J", "")]
		public static unsafe long DiskCacheSizeBytes (global::Java.IO.File p0, long p1)
		{
			if (id_diskCacheSizeBytes_Ljava_io_File_J == IntPtr.Zero)
				id_diskCacheSizeBytes_Ljava_io_File_J = JNIEnv.GetStaticMethodID (class_ref, "diskCacheSizeBytes", "(Ljava/io/File;J)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_diskCacheSizeBytes_Ljava_io_File_J, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDeviceDimensions_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DeviceUtils']/method[@name='getDeviceDimensions' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDeviceDimensions", "(Landroid/content/Context;)Landroid/graphics/Point;", "")]
		public static unsafe global::Android.Graphics.Point GetDeviceDimensions (global::Android.Content.Context p0)
		{
			if (id_getDeviceDimensions_Landroid_content_Context_ == IntPtr.Zero)
				id_getDeviceDimensions_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getDeviceDimensions", "(Landroid/content/Context;)Landroid/graphics/Point;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Graphics.Point __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeviceDimensions_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getHashedUdid_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DeviceUtils']/method[@name='getHashedUdid' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getHashedUdid", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetHashedUdid (global::Android.Content.Context p0)
		{
			if (id_getHashedUdid_Landroid_content_Context_ == IntPtr.Zero)
				id_getHashedUdid_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getHashedUdid", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getHashedUdid_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getIpAddress_Lcom_mopub_common_util_DeviceUtils_IP_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DeviceUtils']/method[@name='getIpAddress' and count(parameter)=1 and parameter[1][@type='com.mopub.common.util.DeviceUtils.IP']]"
		[Register ("getIpAddress", "(Lcom/mopub/common/util/DeviceUtils$IP;)Ljava/lang/String;", "")]
		public static unsafe string GetIpAddress (global::Com.Mopub.Common.Util.DeviceUtils.IP p0)
		{
			if (id_getIpAddress_Lcom_mopub_common_util_DeviceUtils_IP_ == IntPtr.Zero)
				id_getIpAddress_Lcom_mopub_common_util_DeviceUtils_IP_ = JNIEnv.GetStaticMethodID (class_ref, "getIpAddress", "(Lcom/mopub/common/util/DeviceUtils$IP;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getIpAddress_Lcom_mopub_common_util_DeviceUtils_IP_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getScreenOrientation_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DeviceUtils']/method[@name='getScreenOrientation' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("getScreenOrientation", "(Landroid/app/Activity;)I", "")]
		public static unsafe int GetScreenOrientation (global::Android.App.Activity p0)
		{
			if (id_getScreenOrientation_Landroid_app_Activity_ == IntPtr.Zero)
				id_getScreenOrientation_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "getScreenOrientation", "(Landroid/app/Activity;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getScreenOrientation_Landroid_app_Activity_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isNetworkAvailable_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DeviceUtils']/method[@name='isNetworkAvailable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isNetworkAvailable", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsNetworkAvailable (global::Android.Content.Context p0)
		{
			if (id_isNetworkAvailable_Landroid_content_Context_ == IntPtr.Zero)
				id_isNetworkAvailable_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isNetworkAvailable", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNetworkAvailable_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_lockOrientation_Landroid_app_Activity_Lcom_mopub_common_CreativeOrientation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DeviceUtils']/method[@name='lockOrientation' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.mopub.common.CreativeOrientation']]"
		[Register ("lockOrientation", "(Landroid/app/Activity;Lcom/mopub/common/CreativeOrientation;)V", "")]
		public static unsafe void LockOrientation (global::Android.App.Activity p0, global::Com.Mopub.Common.CreativeOrientation p1)
		{
			if (id_lockOrientation_Landroid_app_Activity_Lcom_mopub_common_CreativeOrientation_ == IntPtr.Zero)
				id_lockOrientation_Landroid_app_Activity_Lcom_mopub_common_CreativeOrientation_ = JNIEnv.GetStaticMethodID (class_ref, "lockOrientation", "(Landroid/app/Activity;Lcom/mopub/common/CreativeOrientation;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_lockOrientation_Landroid_app_Activity_Lcom_mopub_common_CreativeOrientation_, __args);
			} finally {
			}
		}

		static IntPtr id_memoryCacheSizeBytes_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DeviceUtils']/method[@name='memoryCacheSizeBytes' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("memoryCacheSizeBytes", "(Landroid/content/Context;)I", "")]
		public static unsafe int MemoryCacheSizeBytes (global::Android.Content.Context p0)
		{
			if (id_memoryCacheSizeBytes_Landroid_content_Context_ == IntPtr.Zero)
				id_memoryCacheSizeBytes_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "memoryCacheSizeBytes", "(Landroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_memoryCacheSizeBytes_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
