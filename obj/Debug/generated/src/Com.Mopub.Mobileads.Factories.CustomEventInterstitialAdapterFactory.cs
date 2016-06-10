using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Factories {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='CustomEventInterstitialAdapterFactory']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/factories/CustomEventInterstitialAdapterFactory", DoNotGenerateAcw=true)]
	public partial class CustomEventInterstitialAdapterFactory : global::Java.Lang.Object {


		static IntPtr instance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='CustomEventInterstitialAdapterFactory']/field[@name='instance']"
		[Register ("instance")]
		protected static global::Com.Mopub.Mobileads.Factories.CustomEventInterstitialAdapterFactory Instance {
			get {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/mobileads/factories/CustomEventInterstitialAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, instance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.CustomEventInterstitialAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/mobileads/factories/CustomEventInterstitialAdapterFactory;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, instance_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/factories/CustomEventInterstitialAdapterFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CustomEventInterstitialAdapterFactory); }
		}

		protected CustomEventInterstitialAdapterFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='CustomEventInterstitialAdapterFactory']/constructor[@name='CustomEventInterstitialAdapterFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CustomEventInterstitialAdapterFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CustomEventInterstitialAdapterFactory)) {
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

		static IntPtr id_create_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='CustomEventInterstitialAdapterFactory']/method[@name='create' and count(parameter)=5 and parameter[1][@type='com.mopub.mobileads.MoPubInterstitial'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map'] and parameter[4][@type='long'] and parameter[5][@type='com.mopub.common.AdReport']]"
		[Register ("create", "(Lcom/mopub/mobileads/MoPubInterstitial;Ljava/lang/String;Ljava/util/Map;JLcom/mopub/common/AdReport;)Lcom/mopub/mobileads/CustomEventInterstitialAdapter;", "")]
		public static unsafe global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter Create (global::Com.Mopub.Mobileads.MoPubInterstitial p0, string p1, global::System.Collections.IDictionary p2, long p3, global::Com.Mopub.Common.AdReport p4)
		{
			if (id_create_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_ == IntPtr.Zero)
				id_create_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lcom/mopub/mobileads/MoPubInterstitial;Ljava/lang/String;Ljava/util/Map;JLcom/mopub/common/AdReport;)Lcom/mopub/mobileads/CustomEventInterstitialAdapter;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_internalCreate_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_;
#pragma warning disable 0169
		static Delegate GetInternalCreate_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_Handler ()
		{
			if (cb_internalCreate_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_ == null)
				cb_internalCreate_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr>) n_InternalCreate_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_);
			return cb_internalCreate_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_;
		}

		static IntPtr n_InternalCreate_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, long p3, IntPtr native_p4)
		{
			global::Com.Mopub.Mobileads.Factories.CustomEventInterstitialAdapterFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.CustomEventInterstitialAdapterFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubInterstitial p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubInterstitial> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Common.AdReport p4 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdReport> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InternalCreate (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_internalCreate_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='CustomEventInterstitialAdapterFactory']/method[@name='internalCreate' and count(parameter)=5 and parameter[1][@type='com.mopub.mobileads.MoPubInterstitial'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map'] and parameter[4][@type='long'] and parameter[5][@type='com.mopub.common.AdReport']]"
		[Register ("internalCreate", "(Lcom/mopub/mobileads/MoPubInterstitial;Ljava/lang/String;Ljava/util/Map;JLcom/mopub/common/AdReport;)Lcom/mopub/mobileads/CustomEventInterstitialAdapter;", "GetInternalCreate_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_Handler")]
		protected virtual unsafe global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter InternalCreate (global::Com.Mopub.Mobileads.MoPubInterstitial p0, string p1, global::System.Collections.IDictionary p2, long p3, global::Com.Mopub.Common.AdReport p4)
		{
			if (id_internalCreate_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_ == IntPtr.Zero)
				id_internalCreate_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_ = JNIEnv.GetMethodID (class_ref, "internalCreate", "(Lcom/mopub/mobileads/MoPubInterstitial;Ljava/lang/String;Ljava/util/Map;JLcom/mopub/common/AdReport;)Lcom/mopub/mobileads/CustomEventInterstitialAdapter;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter> (JNIEnv.CallObjectMethod  (Handle, id_internalCreate_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "internalCreate", "(Lcom/mopub/mobileads/MoPubInterstitial;Ljava/lang/String;Ljava/util/Map;JLcom/mopub/common/AdReport;)Lcom/mopub/mobileads/CustomEventInterstitialAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_setInstance_Lcom_mopub_mobileads_factories_CustomEventInterstitialAdapterFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='CustomEventInterstitialAdapterFactory']/method[@name='setInstance' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.factories.CustomEventInterstitialAdapterFactory']]"
		[Obsolete (@"deprecated")]
		[Register ("setInstance", "(Lcom/mopub/mobileads/factories/CustomEventInterstitialAdapterFactory;)V", "")]
		public static unsafe void SetInstance (global::Com.Mopub.Mobileads.Factories.CustomEventInterstitialAdapterFactory p0)
		{
			if (id_setInstance_Lcom_mopub_mobileads_factories_CustomEventInterstitialAdapterFactory_ == IntPtr.Zero)
				id_setInstance_Lcom_mopub_mobileads_factories_CustomEventInterstitialAdapterFactory_ = JNIEnv.GetStaticMethodID (class_ref, "setInstance", "(Lcom/mopub/mobileads/factories/CustomEventInterstitialAdapterFactory;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setInstance_Lcom_mopub_mobileads_factories_CustomEventInterstitialAdapterFactory_, __args);
			} finally {
			}
		}

	}
}
