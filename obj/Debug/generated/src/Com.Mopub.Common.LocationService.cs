using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='LocationService']"
	[global::Android.Runtime.Register ("com/mopub/common/LocationService", DoNotGenerateAcw=true)]
	public partial class LocationService : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='LocationService.LocationAwareness']"
		[global::Android.Runtime.Register ("com/mopub/common/LocationService$LocationAwareness", DoNotGenerateAcw=true)]
		public sealed partial class LocationAwareness : global::Java.Lang.Enum {


			static IntPtr DISABLED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='LocationService.LocationAwareness']/field[@name='DISABLED']"
			[Register ("DISABLED")]
			public static global::Com.Mopub.Common.LocationService.LocationAwareness Disabled {
				get {
					if (DISABLED_jfieldId == IntPtr.Zero)
						DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISABLED", "Lcom/mopub/common/LocationService$LocationAwareness;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DISABLED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.LocationService.LocationAwareness> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NORMAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='LocationService.LocationAwareness']/field[@name='NORMAL']"
			[Register ("NORMAL")]
			public static global::Com.Mopub.Common.LocationService.LocationAwareness Normal {
				get {
					if (NORMAL_jfieldId == IntPtr.Zero)
						NORMAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NORMAL", "Lcom/mopub/common/LocationService$LocationAwareness;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NORMAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.LocationService.LocationAwareness> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRUNCATED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='LocationService.LocationAwareness']/field[@name='TRUNCATED']"
			[Register ("TRUNCATED")]
			public static global::Com.Mopub.Common.LocationService.LocationAwareness Truncated {
				get {
					if (TRUNCATED_jfieldId == IntPtr.Zero)
						TRUNCATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRUNCATED", "Lcom/mopub/common/LocationService$LocationAwareness;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRUNCATED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.LocationService.LocationAwareness> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/LocationService$LocationAwareness", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LocationAwareness); }
			}

			internal LocationAwareness (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getNewLocationAwareness;
			[Obsolete (@"deprecated")]
			public unsafe global::Com.Mopub.Common.MoPub.LocationAwareness NewLocationAwareness {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='LocationService.LocationAwareness']/method[@name='getNewLocationAwareness' and count(parameter)=0]"
				[Register ("getNewLocationAwareness", "()Lcom/mopub/common/MoPub$LocationAwareness;", "GetGetNewLocationAwarenessHandler")]
				get {
					if (id_getNewLocationAwareness == IntPtr.Zero)
						id_getNewLocationAwareness = JNIEnv.GetMethodID (class_ref, "getNewLocationAwareness", "()Lcom/mopub/common/MoPub$LocationAwareness;");
					try {
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.MoPub.LocationAwareness> (JNIEnv.CallObjectMethod  (Handle, id_getNewLocationAwareness), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_fromMoPubLocationAwareness_Lcom_mopub_common_MoPub_LocationAwareness_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='LocationService.LocationAwareness']/method[@name='fromMoPubLocationAwareness' and count(parameter)=1 and parameter[1][@type='com.mopub.common.MoPub.LocationAwareness']]"
			[Obsolete (@"deprecated")]
			[Register ("fromMoPubLocationAwareness", "(Lcom/mopub/common/MoPub$LocationAwareness;)Lcom/mopub/common/LocationService$LocationAwareness;", "")]
			public static unsafe global::Com.Mopub.Common.LocationService.LocationAwareness FromMoPubLocationAwareness (global::Com.Mopub.Common.MoPub.LocationAwareness p0)
			{
				if (id_fromMoPubLocationAwareness_Lcom_mopub_common_MoPub_LocationAwareness_ == IntPtr.Zero)
					id_fromMoPubLocationAwareness_Lcom_mopub_common_MoPub_LocationAwareness_ = JNIEnv.GetStaticMethodID (class_ref, "fromMoPubLocationAwareness", "(Lcom/mopub/common/MoPub$LocationAwareness;)Lcom/mopub/common/LocationService$LocationAwareness;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Mopub.Common.LocationService.LocationAwareness __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.LocationService.LocationAwareness> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromMoPubLocationAwareness_Lcom_mopub_common_MoPub_LocationAwareness_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='LocationService.LocationAwareness']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/common/LocationService$LocationAwareness;", "")]
			public static unsafe global::Com.Mopub.Common.LocationService.LocationAwareness ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/common/LocationService$LocationAwareness;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mopub.Common.LocationService.LocationAwareness __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.LocationService.LocationAwareness> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='LocationService.LocationAwareness']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/common/LocationService$LocationAwareness;", "")]
			public static unsafe global::Com.Mopub.Common.LocationService.LocationAwareness[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/common/LocationService$LocationAwareness;");
				try {
					return (global::Com.Mopub.Common.LocationService.LocationAwareness[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Common.LocationService.LocationAwareness));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/LocationService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocationService); }
		}

		protected LocationService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common']/class[@name='LocationService']/constructor[@name='LocationService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LocationService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (LocationService)) {
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

		static IntPtr id_getLastKnownLocation_Landroid_content_Context_ILcom_mopub_common_MoPub_LocationAwareness_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='LocationService']/method[@name='getLastKnownLocation' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='com.mopub.common.MoPub.LocationAwareness']]"
		[Register ("getLastKnownLocation", "(Landroid/content/Context;ILcom/mopub/common/MoPub$LocationAwareness;)Landroid/location/Location;", "")]
		public static unsafe global::Android.Locations.Location GetLastKnownLocation (global::Android.Content.Context p0, int p1, global::Com.Mopub.Common.MoPub.LocationAwareness p2)
		{
			if (id_getLastKnownLocation_Landroid_content_Context_ILcom_mopub_common_MoPub_LocationAwareness_ == IntPtr.Zero)
				id_getLastKnownLocation_Landroid_content_Context_ILcom_mopub_common_MoPub_LocationAwareness_ = JNIEnv.GetStaticMethodID (class_ref, "getLastKnownLocation", "(Landroid/content/Context;ILcom/mopub/common/MoPub$LocationAwareness;)Landroid/location/Location;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Android.Locations.Location __ret = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLastKnownLocation_Landroid_content_Context_ILcom_mopub_common_MoPub_LocationAwareness_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
