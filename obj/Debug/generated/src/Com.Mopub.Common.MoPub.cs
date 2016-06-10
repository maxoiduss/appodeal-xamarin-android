using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub']"
	[global::Android.Runtime.Register ("com/mopub/common/MoPub", DoNotGenerateAcw=true)]
	public partial class MoPub : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub']/field[@name='SDK_VERSION']"
		[Register ("SDK_VERSION")]
		public const string SdkVersion = (string) "3.10.0";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub.LocationAwareness']"
		[global::Android.Runtime.Register ("com/mopub/common/MoPub$LocationAwareness", DoNotGenerateAcw=true)]
		public sealed partial class LocationAwareness : global::Java.Lang.Enum {


			static IntPtr DISABLED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub.LocationAwareness']/field[@name='DISABLED']"
			[Register ("DISABLED")]
			public static global::Com.Mopub.Common.MoPub.LocationAwareness Disabled {
				get {
					if (DISABLED_jfieldId == IntPtr.Zero)
						DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISABLED", "Lcom/mopub/common/MoPub$LocationAwareness;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DISABLED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.MoPub.LocationAwareness> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NORMAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub.LocationAwareness']/field[@name='NORMAL']"
			[Register ("NORMAL")]
			public static global::Com.Mopub.Common.MoPub.LocationAwareness Normal {
				get {
					if (NORMAL_jfieldId == IntPtr.Zero)
						NORMAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NORMAL", "Lcom/mopub/common/MoPub$LocationAwareness;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NORMAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.MoPub.LocationAwareness> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRUNCATED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub.LocationAwareness']/field[@name='TRUNCATED']"
			[Register ("TRUNCATED")]
			public static global::Com.Mopub.Common.MoPub.LocationAwareness Truncated {
				get {
					if (TRUNCATED_jfieldId == IntPtr.Zero)
						TRUNCATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRUNCATED", "Lcom/mopub/common/MoPub$LocationAwareness;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRUNCATED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.MoPub.LocationAwareness> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/MoPub$LocationAwareness", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LocationAwareness); }
			}

			internal LocationAwareness (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub.LocationAwareness']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/common/MoPub$LocationAwareness;", "")]
			public static unsafe global::Com.Mopub.Common.MoPub.LocationAwareness ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/common/MoPub$LocationAwareness;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mopub.Common.MoPub.LocationAwareness __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.MoPub.LocationAwareness> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub.LocationAwareness']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/common/MoPub$LocationAwareness;", "")]
			public static unsafe global::Com.Mopub.Common.MoPub.LocationAwareness[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/common/MoPub$LocationAwareness;");
				try {
					return (global::Com.Mopub.Common.MoPub.LocationAwareness[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Common.MoPub.LocationAwareness));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/MoPub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoPub); }
		}

		protected MoPub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub']/constructor[@name='MoPub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MoPub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MoPub)) {
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

		static IntPtr id_getLocationPrecision;
		static IntPtr id_setLocationPrecision_I;
		public static unsafe int LocationPrecision {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub']/method[@name='getLocationPrecision' and count(parameter)=0]"
			[Register ("getLocationPrecision", "()I", "GetGetLocationPrecisionHandler")]
			get {
				if (id_getLocationPrecision == IntPtr.Zero)
					id_getLocationPrecision = JNIEnv.GetStaticMethodID (class_ref, "getLocationPrecision", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getLocationPrecision);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub']/method[@name='setLocationPrecision' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLocationPrecision", "(I)V", "GetSetLocationPrecision_IHandler")]
			set {
				if (id_setLocationPrecision_I == IntPtr.Zero)
					id_setLocationPrecision_I = JNIEnv.GetStaticMethodID (class_ref, "setLocationPrecision", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setLocationPrecision_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getLocationAwareness;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub']/method[@name='getLocationAwareness' and count(parameter)=0]"
		[Register ("getLocationAwareness", "()Lcom/mopub/common/MoPub$LocationAwareness;", "")]
		public static unsafe global::Com.Mopub.Common.MoPub.LocationAwareness GetLocationAwareness ()
		{
			if (id_getLocationAwareness == IntPtr.Zero)
				id_getLocationAwareness = JNIEnv.GetStaticMethodID (class_ref, "getLocationAwareness", "()Lcom/mopub/common/MoPub$LocationAwareness;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.MoPub.LocationAwareness> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLocationAwareness), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_hasRewardedVideo_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub']/method[@name='hasRewardedVideo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hasRewardedVideo", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool HasRewardedVideo (string p0)
		{
			if (id_hasRewardedVideo_Ljava_lang_String_ == IntPtr.Zero)
				id_hasRewardedVideo_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hasRewardedVideo", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasRewardedVideo_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_initializeRewardedVideo_Landroid_app_Activity_arrayLcom_mopub_common_MediationSettings_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub']/method[@name='initializeRewardedVideo' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.mopub.common.MediationSettings...']]"
		[Register ("initializeRewardedVideo", "(Landroid/app/Activity;[Lcom/mopub/common/MediationSettings;)V", "")]
		public static unsafe void InitializeRewardedVideo (global::Android.App.Activity p0, params global:: Com.Mopub.Common.IMediationSettings[] p1)
		{
			if (id_initializeRewardedVideo_Landroid_app_Activity_arrayLcom_mopub_common_MediationSettings_ == IntPtr.Zero)
				id_initializeRewardedVideo_Landroid_app_Activity_arrayLcom_mopub_common_MediationSettings_ = JNIEnv.GetStaticMethodID (class_ref, "initializeRewardedVideo", "(Landroid/app/Activity;[Lcom/mopub/common/MediationSettings;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initializeRewardedVideo_Landroid_app_Activity_arrayLcom_mopub_common_MediationSettings_, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_loadRewardedVideo_Ljava_lang_String_arrayLcom_mopub_common_MediationSettings_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub']/method[@name='loadRewardedVideo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.common.MediationSettings...']]"
		[Register ("loadRewardedVideo", "(Ljava/lang/String;[Lcom/mopub/common/MediationSettings;)V", "")]
		public static unsafe void LoadRewardedVideo (string p0, params global:: Com.Mopub.Common.IMediationSettings[] p1)
		{
			if (id_loadRewardedVideo_Ljava_lang_String_arrayLcom_mopub_common_MediationSettings_ == IntPtr.Zero)
				id_loadRewardedVideo_Ljava_lang_String_arrayLcom_mopub_common_MediationSettings_ = JNIEnv.GetStaticMethodID (class_ref, "loadRewardedVideo", "(Ljava/lang/String;[Lcom/mopub/common/MediationSettings;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_loadRewardedVideo_Ljava_lang_String_arrayLcom_mopub_common_MediationSettings_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_onBackPressed_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub']/method[@name='onBackPressed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onBackPressed", "(Landroid/app/Activity;)V", "")]
		public static unsafe void OnBackPressed (global::Android.App.Activity p0)
		{
			if (id_onBackPressed_Landroid_app_Activity_ == IntPtr.Zero)
				id_onBackPressed_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "onBackPressed", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onBackPressed_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_onCreate_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onCreate", "(Landroid/app/Activity;)V", "")]
		public static unsafe void OnCreate (global::Android.App.Activity p0)
		{
			if (id_onCreate_Landroid_app_Activity_ == IntPtr.Zero)
				id_onCreate_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "onCreate", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onCreate_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_onDestroy_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub']/method[@name='onDestroy' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onDestroy", "(Landroid/app/Activity;)V", "")]
		public static unsafe void OnDestroy (global::Android.App.Activity p0)
		{
			if (id_onDestroy_Landroid_app_Activity_ == IntPtr.Zero)
				id_onDestroy_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "onDestroy", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onDestroy_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_onPause_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub']/method[@name='onPause' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onPause", "(Landroid/app/Activity;)V", "")]
		public static unsafe void OnPause (global::Android.App.Activity p0)
		{
			if (id_onPause_Landroid_app_Activity_ == IntPtr.Zero)
				id_onPause_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "onPause", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onPause_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_onRestart_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub']/method[@name='onRestart' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onRestart", "(Landroid/app/Activity;)V", "")]
		public static unsafe void OnRestart (global::Android.App.Activity p0)
		{
			if (id_onRestart_Landroid_app_Activity_ == IntPtr.Zero)
				id_onRestart_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "onRestart", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onRestart_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_onResume_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub']/method[@name='onResume' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onResume", "(Landroid/app/Activity;)V", "")]
		public static unsafe void OnResume (global::Android.App.Activity p0)
		{
			if (id_onResume_Landroid_app_Activity_ == IntPtr.Zero)
				id_onResume_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "onResume", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onResume_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_onStart_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub']/method[@name='onStart' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onStart", "(Landroid/app/Activity;)V", "")]
		public static unsafe void OnStart (global::Android.App.Activity p0)
		{
			if (id_onStart_Landroid_app_Activity_ == IntPtr.Zero)
				id_onStart_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "onStart", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onStart_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_onStop_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub']/method[@name='onStop' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onStop", "(Landroid/app/Activity;)V", "")]
		public static unsafe void OnStop (global::Android.App.Activity p0)
		{
			if (id_onStop_Landroid_app_Activity_ == IntPtr.Zero)
				id_onStop_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "onStop", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onStop_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_setLocationAwareness_Lcom_mopub_common_MoPub_LocationAwareness_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub']/method[@name='setLocationAwareness' and count(parameter)=1 and parameter[1][@type='com.mopub.common.MoPub.LocationAwareness']]"
		[Register ("setLocationAwareness", "(Lcom/mopub/common/MoPub$LocationAwareness;)V", "")]
		public static unsafe void SetLocationAwareness (global::Com.Mopub.Common.MoPub.LocationAwareness p0)
		{
			if (id_setLocationAwareness_Lcom_mopub_common_MoPub_LocationAwareness_ == IntPtr.Zero)
				id_setLocationAwareness_Lcom_mopub_common_MoPub_LocationAwareness_ = JNIEnv.GetStaticMethodID (class_ref, "setLocationAwareness", "(Lcom/mopub/common/MoPub$LocationAwareness;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setLocationAwareness_Lcom_mopub_common_MoPub_LocationAwareness_, __args);
			} finally {
			}
		}

		static IntPtr id_setRewardedVideoListener_Lcom_mopub_mobileads_MoPubRewardedVideoListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub']/method[@name='setRewardedVideoListener' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubRewardedVideoListener']]"
		[Register ("setRewardedVideoListener", "(Lcom/mopub/mobileads/MoPubRewardedVideoListener;)V", "")]
		public static unsafe void SetRewardedVideoListener (global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener p0)
		{
			if (id_setRewardedVideoListener_Lcom_mopub_mobileads_MoPubRewardedVideoListener_ == IntPtr.Zero)
				id_setRewardedVideoListener_Lcom_mopub_mobileads_MoPubRewardedVideoListener_ = JNIEnv.GetStaticMethodID (class_ref, "setRewardedVideoListener", "(Lcom/mopub/mobileads/MoPubRewardedVideoListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setRewardedVideoListener_Lcom_mopub_mobileads_MoPubRewardedVideoListener_, __args);
			} finally {
			}
		}

		static IntPtr id_showRewardedVideo_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPub']/method[@name='showRewardedVideo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("showRewardedVideo", "(Ljava/lang/String;)V", "")]
		public static unsafe void ShowRewardedVideo (string p0)
		{
			if (id_showRewardedVideo_Ljava_lang_String_ == IntPtr.Zero)
				id_showRewardedVideo_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "showRewardedVideo", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_showRewardedVideo_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

#region "Event implementation for Com.Mopub.Mobileads.IMoPubRewardedVideoListener"
		public event EventHandler<global::Com.Mopub.Mobileads.RewardedVideoClosedEventArgs> RewardedVideoClosed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener, global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor>(
						ref weak_implementor_SetRewardedVideoListener,
						__CreateIMoPubRewardedVideoListenerImplementor,
						SetRewardedVideoListener,
						__h => __h.OnRewardedVideoClosedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener, global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor>(
						ref weak_implementor_SetRewardedVideoListener,
						global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor.__IsEmpty,
						__v => SetRewardedVideoListener (null),
						__h => __h.OnRewardedVideoClosedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Mobileads.RewardedVideoCompletedEventArgs> RewardedVideoCompleted {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener, global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor>(
						ref weak_implementor_SetRewardedVideoListener,
						__CreateIMoPubRewardedVideoListenerImplementor,
						SetRewardedVideoListener,
						__h => __h.OnRewardedVideoCompletedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener, global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor>(
						ref weak_implementor_SetRewardedVideoListener,
						global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor.__IsEmpty,
						__v => SetRewardedVideoListener (null),
						__h => __h.OnRewardedVideoCompletedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Mobileads.RewardedVideoLoadFailureEventArgs> RewardedVideoLoadFailure {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener, global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor>(
						ref weak_implementor_SetRewardedVideoListener,
						__CreateIMoPubRewardedVideoListenerImplementor,
						SetRewardedVideoListener,
						__h => __h.OnRewardedVideoLoadFailureHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener, global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor>(
						ref weak_implementor_SetRewardedVideoListener,
						global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor.__IsEmpty,
						__v => SetRewardedVideoListener (null),
						__h => __h.OnRewardedVideoLoadFailureHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Mobileads.RewardedVideoLoadSuccessEventArgs> RewardedVideoLoadSuccess {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener, global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor>(
						ref weak_implementor_SetRewardedVideoListener,
						__CreateIMoPubRewardedVideoListenerImplementor,
						SetRewardedVideoListener,
						__h => __h.OnRewardedVideoLoadSuccessHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener, global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor>(
						ref weak_implementor_SetRewardedVideoListener,
						global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor.__IsEmpty,
						__v => SetRewardedVideoListener (null),
						__h => __h.OnRewardedVideoLoadSuccessHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Mobileads.RewardedVideoPlaybackErrorEventArgs> RewardedVideoPlaybackError {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener, global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor>(
						ref weak_implementor_SetRewardedVideoListener,
						__CreateIMoPubRewardedVideoListenerImplementor,
						SetRewardedVideoListener,
						__h => __h.OnRewardedVideoPlaybackErrorHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener, global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor>(
						ref weak_implementor_SetRewardedVideoListener,
						global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor.__IsEmpty,
						__v => SetRewardedVideoListener (null),
						__h => __h.OnRewardedVideoPlaybackErrorHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Mobileads.RewardedVideoStartedEventArgs> RewardedVideoStarted {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener, global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor>(
						ref weak_implementor_SetRewardedVideoListener,
						__CreateIMoPubRewardedVideoListenerImplementor,
						SetRewardedVideoListener,
						__h => __h.OnRewardedVideoStartedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener, global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor>(
						ref weak_implementor_SetRewardedVideoListener,
						global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor.__IsEmpty,
						__v => SetRewardedVideoListener (null),
						__h => __h.OnRewardedVideoStartedHandler -= value);
			}
		}

		WeakReference weak_implementor_SetRewardedVideoListener;

		global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor __CreateIMoPubRewardedVideoListenerImplementor ()
		{
			return new global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor (this);
		}
#endregion
	}
}
