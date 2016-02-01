using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']"
	[global::Android.Runtime.Register ("com/mopub/common/ClientMetadata", DoNotGenerateAcw=true)]
	public partial class ClientMetadata : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata.MoPubNetworkType']"
		[global::Android.Runtime.Register ("com/mopub/common/ClientMetadata$MoPubNetworkType", DoNotGenerateAcw=true)]
		public sealed partial class MoPubNetworkType : global::Java.Lang.Enum {


			static IntPtr ETHERNET_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata.MoPubNetworkType']/field[@name='ETHERNET']"
			[Register ("ETHERNET")]
			public static global::Com.Mopub.Common.ClientMetadata.MoPubNetworkType Ethernet {
				get {
					if (ETHERNET_jfieldId == IntPtr.Zero)
						ETHERNET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ETHERNET", "Lcom/mopub/common/ClientMetadata$MoPubNetworkType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ETHERNET_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata.MoPubNetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MOBILE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata.MoPubNetworkType']/field[@name='MOBILE']"
			[Register ("MOBILE")]
			public static global::Com.Mopub.Common.ClientMetadata.MoPubNetworkType Mobile {
				get {
					if (MOBILE_jfieldId == IntPtr.Zero)
						MOBILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOBILE", "Lcom/mopub/common/ClientMetadata$MoPubNetworkType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MOBILE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata.MoPubNetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata.MoPubNetworkType']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Mopub.Common.ClientMetadata.MoPubNetworkType Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/mopub/common/ClientMetadata$MoPubNetworkType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata.MoPubNetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WIFI_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata.MoPubNetworkType']/field[@name='WIFI']"
			[Register ("WIFI")]
			public static global::Com.Mopub.Common.ClientMetadata.MoPubNetworkType Wifi {
				get {
					if (WIFI_jfieldId == IntPtr.Zero)
						WIFI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WIFI", "Lcom/mopub/common/ClientMetadata$MoPubNetworkType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WIFI_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata.MoPubNetworkType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/ClientMetadata$MoPubNetworkType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MoPubNetworkType); }
			}

			internal MoPubNetworkType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getId;
			public unsafe int Id {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata.MoPubNetworkType']/method[@name='getId' and count(parameter)=0]"
				[Register ("getId", "()I", "GetGetIdHandler")]
				get {
					if (id_getId == IntPtr.Zero)
						id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()I");
					try {
						return JNIEnv.CallIntMethod  (Handle, id_getId);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata.MoPubNetworkType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/common/ClientMetadata$MoPubNetworkType;", "")]
			public static unsafe global::Com.Mopub.Common.ClientMetadata.MoPubNetworkType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/common/ClientMetadata$MoPubNetworkType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mopub.Common.ClientMetadata.MoPubNetworkType __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata.MoPubNetworkType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata.MoPubNetworkType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/common/ClientMetadata$MoPubNetworkType;", "")]
			public static unsafe global::Com.Mopub.Common.ClientMetadata.MoPubNetworkType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/common/ClientMetadata$MoPubNetworkType;");
				try {
					return (global::Com.Mopub.Common.ClientMetadata.MoPubNetworkType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Common.ClientMetadata.MoPubNetworkType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/ClientMetadata", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClientMetadata); }
		}

		protected ClientMetadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/constructor[@name='ClientMetadata' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ClientMetadata (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ClientMetadata)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getActiveNetworkType;
#pragma warning disable 0169
		static Delegate GetGetActiveNetworkTypeHandler ()
		{
			if (cb_getActiveNetworkType == null)
				cb_getActiveNetworkType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActiveNetworkType);
			return cb_getActiveNetworkType;
		}

		static IntPtr n_GetActiveNetworkType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActiveNetworkType);
		}
#pragma warning restore 0169

		static IntPtr id_getActiveNetworkType;
		public virtual unsafe global::Com.Mopub.Common.ClientMetadata.MoPubNetworkType ActiveNetworkType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getActiveNetworkType' and count(parameter)=0]"
			[Register ("getActiveNetworkType", "()Lcom/mopub/common/ClientMetadata$MoPubNetworkType;", "GetGetActiveNetworkTypeHandler")]
			get {
				if (id_getActiveNetworkType == IntPtr.Zero)
					id_getActiveNetworkType = JNIEnv.GetMethodID (class_ref, "getActiveNetworkType", "()Lcom/mopub/common/ClientMetadata$MoPubNetworkType;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata.MoPubNetworkType> (JNIEnv.CallObjectMethod  (Handle, id_getActiveNetworkType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata.MoPubNetworkType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActiveNetworkType", "()Lcom/mopub/common/ClientMetadata$MoPubNetworkType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAppName;
#pragma warning disable 0169
		static Delegate GetGetAppNameHandler ()
		{
			if (cb_getAppName == null)
				cb_getAppName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppName);
			return cb_getAppName;
		}

		static IntPtr n_GetAppName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppName);
		}
#pragma warning restore 0169

		static IntPtr id_getAppName;
		public virtual unsafe string AppName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getAppName' and count(parameter)=0]"
			[Register ("getAppName", "()Ljava/lang/String;", "GetGetAppNameHandler")]
			get {
				if (id_getAppName == IntPtr.Zero)
					id_getAppName = JNIEnv.GetMethodID (class_ref, "getAppName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAppPackageName;
#pragma warning disable 0169
		static Delegate GetGetAppPackageNameHandler ()
		{
			if (cb_getAppPackageName == null)
				cb_getAppPackageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppPackageName);
			return cb_getAppPackageName;
		}

		static IntPtr n_GetAppPackageName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppPackageName);
		}
#pragma warning restore 0169

		static IntPtr id_getAppPackageName;
		public virtual unsafe string AppPackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getAppPackageName' and count(parameter)=0]"
			[Register ("getAppPackageName", "()Ljava/lang/String;", "GetGetAppPackageNameHandler")]
			get {
				if (id_getAppPackageName == IntPtr.Zero)
					id_getAppPackageName = JNIEnv.GetMethodID (class_ref, "getAppPackageName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppPackageName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppPackageName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAppVersion;
#pragma warning disable 0169
		static Delegate GetGetAppVersionHandler ()
		{
			if (cb_getAppVersion == null)
				cb_getAppVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppVersion);
			return cb_getAppVersion;
		}

		static IntPtr n_GetAppVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getAppVersion;
		public virtual unsafe string AppVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getAppVersion' and count(parameter)=0]"
			[Register ("getAppVersion", "()Ljava/lang/String;", "GetGetAppVersionHandler")]
			get {
				if (id_getAppVersion == IntPtr.Zero)
					id_getAppVersion = JNIEnv.GetMethodID (class_ref, "getAppVersion", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDensity;
#pragma warning disable 0169
		static Delegate GetGetDensityHandler ()
		{
			if (cb_getDensity == null)
				cb_getDensity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetDensity);
			return cb_getDensity;
		}

		static float n_GetDensity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Density;
		}
#pragma warning restore 0169

		static IntPtr id_getDensity;
		public virtual unsafe float Density {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getDensity' and count(parameter)=0]"
			[Register ("getDensity", "()F", "GetGetDensityHandler")]
			get {
				if (id_getDensity == IntPtr.Zero)
					id_getDensity = JNIEnv.GetMethodID (class_ref, "getDensity", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getDensity);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDensity", "()F"));
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceDimensions;
#pragma warning disable 0169
		static Delegate GetGetDeviceDimensionsHandler ()
		{
			if (cb_getDeviceDimensions == null)
				cb_getDeviceDimensions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceDimensions);
			return cb_getDeviceDimensions;
		}

		static IntPtr n_GetDeviceDimensions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeviceDimensions);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceDimensions;
		public virtual unsafe global::Android.Graphics.Point DeviceDimensions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getDeviceDimensions' and count(parameter)=0]"
			[Register ("getDeviceDimensions", "()Landroid/graphics/Point;", "GetGetDeviceDimensionsHandler")]
			get {
				if (id_getDeviceDimensions == IntPtr.Zero)
					id_getDeviceDimensions = JNIEnv.GetMethodID (class_ref, "getDeviceDimensions", "()Landroid/graphics/Point;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallObjectMethod  (Handle, id_getDeviceDimensions), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceDimensions", "()Landroid/graphics/Point;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceId;
#pragma warning disable 0169
		static Delegate GetGetDeviceIdHandler ()
		{
			if (cb_getDeviceId == null)
				cb_getDeviceId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceId);
			return cb_getDeviceId;
		}

		static IntPtr n_GetDeviceId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceId);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceId;
		public virtual unsafe string DeviceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getDeviceId' and count(parameter)=0]"
			[Register ("getDeviceId", "()Ljava/lang/String;", "GetGetDeviceIdHandler")]
			get {
				if (id_getDeviceId == IntPtr.Zero)
					id_getDeviceId = JNIEnv.GetMethodID (class_ref, "getDeviceId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDeviceId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceLocale;
#pragma warning disable 0169
		static Delegate GetGetDeviceLocaleHandler ()
		{
			if (cb_getDeviceLocale == null)
				cb_getDeviceLocale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceLocale);
			return cb_getDeviceLocale;
		}

		static IntPtr n_GetDeviceLocale (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeviceLocale);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceLocale;
		public virtual unsafe global::Java.Util.Locale DeviceLocale {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getDeviceLocale' and count(parameter)=0]"
			[Register ("getDeviceLocale", "()Ljava/util/Locale;", "GetGetDeviceLocaleHandler")]
			get {
				if (id_getDeviceLocale == IntPtr.Zero)
					id_getDeviceLocale = JNIEnv.GetMethodID (class_ref, "getDeviceLocale", "()Ljava/util/Locale;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (JNIEnv.CallObjectMethod  (Handle, id_getDeviceLocale), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceLocale", "()Ljava/util/Locale;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceManufacturer;
#pragma warning disable 0169
		static Delegate GetGetDeviceManufacturerHandler ()
		{
			if (cb_getDeviceManufacturer == null)
				cb_getDeviceManufacturer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceManufacturer);
			return cb_getDeviceManufacturer;
		}

		static IntPtr n_GetDeviceManufacturer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceManufacturer);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceManufacturer;
		public virtual unsafe string DeviceManufacturer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getDeviceManufacturer' and count(parameter)=0]"
			[Register ("getDeviceManufacturer", "()Ljava/lang/String;", "GetGetDeviceManufacturerHandler")]
			get {
				if (id_getDeviceManufacturer == IntPtr.Zero)
					id_getDeviceManufacturer = JNIEnv.GetMethodID (class_ref, "getDeviceManufacturer", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDeviceManufacturer), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceManufacturer", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceModel;
#pragma warning disable 0169
		static Delegate GetGetDeviceModelHandler ()
		{
			if (cb_getDeviceModel == null)
				cb_getDeviceModel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceModel);
			return cb_getDeviceModel;
		}

		static IntPtr n_GetDeviceModel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceModel);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceModel;
		public virtual unsafe string DeviceModel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getDeviceModel' and count(parameter)=0]"
			[Register ("getDeviceModel", "()Ljava/lang/String;", "GetGetDeviceModelHandler")]
			get {
				if (id_getDeviceModel == IntPtr.Zero)
					id_getDeviceModel = JNIEnv.GetMethodID (class_ref, "getDeviceModel", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDeviceModel), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceModel", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceOsVersion;
#pragma warning disable 0169
		static Delegate GetGetDeviceOsVersionHandler ()
		{
			if (cb_getDeviceOsVersion == null)
				cb_getDeviceOsVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceOsVersion);
			return cb_getDeviceOsVersion;
		}

		static IntPtr n_GetDeviceOsVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceOsVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceOsVersion;
		public virtual unsafe string DeviceOsVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getDeviceOsVersion' and count(parameter)=0]"
			[Register ("getDeviceOsVersion", "()Ljava/lang/String;", "GetGetDeviceOsVersionHandler")]
			get {
				if (id_getDeviceOsVersion == IntPtr.Zero)
					id_getDeviceOsVersion = JNIEnv.GetMethodID (class_ref, "getDeviceOsVersion", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDeviceOsVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceOsVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceProduct;
#pragma warning disable 0169
		static Delegate GetGetDeviceProductHandler ()
		{
			if (cb_getDeviceProduct == null)
				cb_getDeviceProduct = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceProduct);
			return cb_getDeviceProduct;
		}

		static IntPtr n_GetDeviceProduct (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceProduct);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceProduct;
		public virtual unsafe string DeviceProduct {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getDeviceProduct' and count(parameter)=0]"
			[Register ("getDeviceProduct", "()Ljava/lang/String;", "GetGetDeviceProductHandler")]
			get {
				if (id_getDeviceProduct == IntPtr.Zero)
					id_getDeviceProduct = JNIEnv.GetMethodID (class_ref, "getDeviceProduct", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDeviceProduct), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceProduct", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceScreenHeightDip;
#pragma warning disable 0169
		static Delegate GetGetDeviceScreenHeightDipHandler ()
		{
			if (cb_getDeviceScreenHeightDip == null)
				cb_getDeviceScreenHeightDip = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDeviceScreenHeightDip);
			return cb_getDeviceScreenHeightDip;
		}

		static int n_GetDeviceScreenHeightDip (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeviceScreenHeightDip;
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceScreenHeightDip;
		public virtual unsafe int DeviceScreenHeightDip {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getDeviceScreenHeightDip' and count(parameter)=0]"
			[Register ("getDeviceScreenHeightDip", "()I", "GetGetDeviceScreenHeightDipHandler")]
			get {
				if (id_getDeviceScreenHeightDip == IntPtr.Zero)
					id_getDeviceScreenHeightDip = JNIEnv.GetMethodID (class_ref, "getDeviceScreenHeightDip", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getDeviceScreenHeightDip);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceScreenHeightDip", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceScreenWidthDip;
#pragma warning disable 0169
		static Delegate GetGetDeviceScreenWidthDipHandler ()
		{
			if (cb_getDeviceScreenWidthDip == null)
				cb_getDeviceScreenWidthDip = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDeviceScreenWidthDip);
			return cb_getDeviceScreenWidthDip;
		}

		static int n_GetDeviceScreenWidthDip (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeviceScreenWidthDip;
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceScreenWidthDip;
		public virtual unsafe int DeviceScreenWidthDip {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getDeviceScreenWidthDip' and count(parameter)=0]"
			[Register ("getDeviceScreenWidthDip", "()I", "GetGetDeviceScreenWidthDipHandler")]
			get {
				if (id_getDeviceScreenWidthDip == IntPtr.Zero)
					id_getDeviceScreenWidthDip = JNIEnv.GetMethodID (class_ref, "getDeviceScreenWidthDip", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getDeviceScreenWidthDip);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceScreenWidthDip", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		static IntPtr id_setInstance_Lcom_mopub_common_ClientMetadata_;
		public static unsafe global::Com.Mopub.Common.ClientMetadata Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/mopub/common/ClientMetadata;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/mopub/common/ClientMetadata;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='setInstance' and count(parameter)=1 and parameter[1][@type='com.mopub.common.ClientMetadata']]"
			[Register ("setInstance", "(Lcom/mopub/common/ClientMetadata;)V", "GetSetInstance_Lcom_mopub_common_ClientMetadata_Handler")]
			set {
				if (id_setInstance_Lcom_mopub_common_ClientMetadata_ == IntPtr.Zero)
					id_setInstance_Lcom_mopub_common_ClientMetadata_ = JNIEnv.GetStaticMethodID (class_ref, "setInstance", "(Lcom/mopub/common/ClientMetadata;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setInstance_Lcom_mopub_common_ClientMetadata_, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isAdvertisingInfoSet;
#pragma warning disable 0169
		static Delegate GetIsAdvertisingInfoSetHandler ()
		{
			if (cb_isAdvertisingInfoSet == null)
				cb_isAdvertisingInfoSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAdvertisingInfoSet);
			return cb_isAdvertisingInfoSet;
		}

		static bool n_IsAdvertisingInfoSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAdvertisingInfoSet;
		}
#pragma warning restore 0169

		static IntPtr id_isAdvertisingInfoSet;
		public virtual unsafe bool IsAdvertisingInfoSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='isAdvertisingInfoSet' and count(parameter)=0]"
			[Register ("isAdvertisingInfoSet", "()Z", "GetIsAdvertisingInfoSetHandler")]
			get {
				if (id_isAdvertisingInfoSet == IntPtr.Zero)
					id_isAdvertisingInfoSet = JNIEnv.GetMethodID (class_ref, "isAdvertisingInfoSet", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isAdvertisingInfoSet);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAdvertisingInfoSet", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isDoNotTrackSet;
#pragma warning disable 0169
		static Delegate GetIsDoNotTrackSetHandler ()
		{
			if (cb_isDoNotTrackSet == null)
				cb_isDoNotTrackSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDoNotTrackSet);
			return cb_isDoNotTrackSet;
		}

		static bool n_IsDoNotTrackSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDoNotTrackSet;
		}
#pragma warning restore 0169

		static IntPtr id_isDoNotTrackSet;
		public virtual unsafe bool IsDoNotTrackSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='isDoNotTrackSet' and count(parameter)=0]"
			[Register ("isDoNotTrackSet", "()Z", "GetIsDoNotTrackSetHandler")]
			get {
				if (id_isDoNotTrackSet == IntPtr.Zero)
					id_isDoNotTrackSet = JNIEnv.GetMethodID (class_ref, "isDoNotTrackSet", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isDoNotTrackSet);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDoNotTrackSet", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getIsoCountryCode;
#pragma warning disable 0169
		static Delegate GetGetIsoCountryCodeHandler ()
		{
			if (cb_getIsoCountryCode == null)
				cb_getIsoCountryCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIsoCountryCode);
			return cb_getIsoCountryCode;
		}

		static IntPtr n_GetIsoCountryCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IsoCountryCode);
		}
#pragma warning restore 0169

		static IntPtr id_getIsoCountryCode;
		public virtual unsafe string IsoCountryCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getIsoCountryCode' and count(parameter)=0]"
			[Register ("getIsoCountryCode", "()Ljava/lang/String;", "GetGetIsoCountryCodeHandler")]
			get {
				if (id_getIsoCountryCode == IntPtr.Zero)
					id_getIsoCountryCode = JNIEnv.GetMethodID (class_ref, "getIsoCountryCode", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getIsoCountryCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIsoCountryCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNetworkOperator;
#pragma warning disable 0169
		static Delegate GetGetNetworkOperatorHandler ()
		{
			if (cb_getNetworkOperator == null)
				cb_getNetworkOperator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetworkOperator);
			return cb_getNetworkOperator;
		}

		static IntPtr n_GetNetworkOperator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NetworkOperator);
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkOperator;
		public virtual unsafe string NetworkOperator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getNetworkOperator' and count(parameter)=0]"
			[Register ("getNetworkOperator", "()Ljava/lang/String;", "GetGetNetworkOperatorHandler")]
			get {
				if (id_getNetworkOperator == IntPtr.Zero)
					id_getNetworkOperator = JNIEnv.GetMethodID (class_ref, "getNetworkOperator", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNetworkOperator), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetworkOperator", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNetworkOperatorForUrl;
#pragma warning disable 0169
		static Delegate GetGetNetworkOperatorForUrlHandler ()
		{
			if (cb_getNetworkOperatorForUrl == null)
				cb_getNetworkOperatorForUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetworkOperatorForUrl);
			return cb_getNetworkOperatorForUrl;
		}

		static IntPtr n_GetNetworkOperatorForUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NetworkOperatorForUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkOperatorForUrl;
		public virtual unsafe string NetworkOperatorForUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getNetworkOperatorForUrl' and count(parameter)=0]"
			[Register ("getNetworkOperatorForUrl", "()Ljava/lang/String;", "GetGetNetworkOperatorForUrlHandler")]
			get {
				if (id_getNetworkOperatorForUrl == IntPtr.Zero)
					id_getNetworkOperatorForUrl = JNIEnv.GetMethodID (class_ref, "getNetworkOperatorForUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNetworkOperatorForUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetworkOperatorForUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNetworkOperatorName;
#pragma warning disable 0169
		static Delegate GetGetNetworkOperatorNameHandler ()
		{
			if (cb_getNetworkOperatorName == null)
				cb_getNetworkOperatorName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetworkOperatorName);
			return cb_getNetworkOperatorName;
		}

		static IntPtr n_GetNetworkOperatorName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NetworkOperatorName);
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkOperatorName;
		public virtual unsafe string NetworkOperatorName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getNetworkOperatorName' and count(parameter)=0]"
			[Register ("getNetworkOperatorName", "()Ljava/lang/String;", "GetGetNetworkOperatorNameHandler")]
			get {
				if (id_getNetworkOperatorName == IntPtr.Zero)
					id_getNetworkOperatorName = JNIEnv.GetMethodID (class_ref, "getNetworkOperatorName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNetworkOperatorName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetworkOperatorName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOrientationString;
#pragma warning disable 0169
		static Delegate GetGetOrientationStringHandler ()
		{
			if (cb_getOrientationString == null)
				cb_getOrientationString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrientationString);
			return cb_getOrientationString;
		}

		static IntPtr n_GetOrientationString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OrientationString);
		}
#pragma warning restore 0169

		static IntPtr id_getOrientationString;
		public virtual unsafe string OrientationString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getOrientationString' and count(parameter)=0]"
			[Register ("getOrientationString", "()Ljava/lang/String;", "GetGetOrientationStringHandler")]
			get {
				if (id_getOrientationString == IntPtr.Zero)
					id_getOrientationString = JNIEnv.GetMethodID (class_ref, "getOrientationString", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getOrientationString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrientationString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSdkVersion;
#pragma warning disable 0169
		static Delegate GetGetSdkVersionHandler ()
		{
			if (cb_getSdkVersion == null)
				cb_getSdkVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSdkVersion);
			return cb_getSdkVersion;
		}

		static IntPtr n_GetSdkVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SdkVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getSdkVersion;
		public virtual unsafe string SdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getSdkVersion' and count(parameter)=0]"
			[Register ("getSdkVersion", "()Ljava/lang/String;", "GetGetSdkVersionHandler")]
			get {
				if (id_getSdkVersion == IntPtr.Zero)
					id_getSdkVersion = JNIEnv.GetMethodID (class_ref, "getSdkVersion", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSdkVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSdkVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSimIsoCountryCode;
#pragma warning disable 0169
		static Delegate GetGetSimIsoCountryCodeHandler ()
		{
			if (cb_getSimIsoCountryCode == null)
				cb_getSimIsoCountryCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSimIsoCountryCode);
			return cb_getSimIsoCountryCode;
		}

		static IntPtr n_GetSimIsoCountryCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SimIsoCountryCode);
		}
#pragma warning restore 0169

		static IntPtr id_getSimIsoCountryCode;
		public virtual unsafe string SimIsoCountryCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getSimIsoCountryCode' and count(parameter)=0]"
			[Register ("getSimIsoCountryCode", "()Ljava/lang/String;", "GetGetSimIsoCountryCodeHandler")]
			get {
				if (id_getSimIsoCountryCode == IntPtr.Zero)
					id_getSimIsoCountryCode = JNIEnv.GetMethodID (class_ref, "getSimIsoCountryCode", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSimIsoCountryCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSimIsoCountryCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSimOperator;
#pragma warning disable 0169
		static Delegate GetGetSimOperatorHandler ()
		{
			if (cb_getSimOperator == null)
				cb_getSimOperator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSimOperator);
			return cb_getSimOperator;
		}

		static IntPtr n_GetSimOperator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SimOperator);
		}
#pragma warning restore 0169

		static IntPtr id_getSimOperator;
		public virtual unsafe string SimOperator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getSimOperator' and count(parameter)=0]"
			[Register ("getSimOperator", "()Ljava/lang/String;", "GetGetSimOperatorHandler")]
			get {
				if (id_getSimOperator == IntPtr.Zero)
					id_getSimOperator = JNIEnv.GetMethodID (class_ref, "getSimOperator", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSimOperator), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSimOperator", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSimOperatorName;
#pragma warning disable 0169
		static Delegate GetGetSimOperatorNameHandler ()
		{
			if (cb_getSimOperatorName == null)
				cb_getSimOperatorName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSimOperatorName);
			return cb_getSimOperatorName;
		}

		static IntPtr n_GetSimOperatorName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SimOperatorName);
		}
#pragma warning restore 0169

		static IntPtr id_getSimOperatorName;
		public virtual unsafe string SimOperatorName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getSimOperatorName' and count(parameter)=0]"
			[Register ("getSimOperatorName", "()Ljava/lang/String;", "GetGetSimOperatorNameHandler")]
			get {
				if (id_getSimOperatorName == IntPtr.Zero)
					id_getSimOperatorName = JNIEnv.GetMethodID (class_ref, "getSimOperatorName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSimOperatorName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSimOperatorName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_clearForTesting;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='clearForTesting' and count(parameter)=0]"
		[Register ("clearForTesting", "()V", "")]
		public static unsafe void ClearForTesting ()
		{
			if (id_clearForTesting == IntPtr.Zero)
				id_clearForTesting = JNIEnv.GetStaticMethodID (class_ref, "clearForTesting", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clearForTesting);
			} finally {
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/mopub/common/ClientMetadata;", "")]
		public static unsafe global::Com.Mopub.Common.ClientMetadata GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/mopub/common/ClientMetadata;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Mopub.Common.ClientMetadata __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setAdvertisingInfo_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSetAdvertisingInfo_Ljava_lang_String_ZHandler ()
		{
			if (cb_setAdvertisingInfo_Ljava_lang_String_Z == null)
				cb_setAdvertisingInfo_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetAdvertisingInfo_Ljava_lang_String_Z);
			return cb_setAdvertisingInfo_Ljava_lang_String_Z;
		}

		static void n_SetAdvertisingInfo_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Mopub.Common.ClientMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAdvertisingInfo (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setAdvertisingInfo_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='ClientMetadata']/method[@name='setAdvertisingInfo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("setAdvertisingInfo", "(Ljava/lang/String;Z)V", "GetSetAdvertisingInfo_Ljava_lang_String_ZHandler")]
		public virtual unsafe void SetAdvertisingInfo (string p0, bool p1)
		{
			if (id_setAdvertisingInfo_Ljava_lang_String_Z == IntPtr.Zero)
				id_setAdvertisingInfo_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "setAdvertisingInfo", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAdvertisingInfo_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdvertisingInfo", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
