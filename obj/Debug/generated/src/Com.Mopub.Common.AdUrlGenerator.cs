using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']"
	[global::Android.Runtime.Register ("com/mopub/common/AdUrlGenerator", DoNotGenerateAcw=true)]
	public abstract partial class AdUrlGenerator : global::Com.Mopub.Common.BaseUrlGenerator {


		static IntPtr mAdUnitId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']/field[@name='mAdUnitId']"
		[Register ("mAdUnitId")]
		protected string MAdUnitId {
			get {
				if (mAdUnitId_jfieldId == IntPtr.Zero)
					mAdUnitId_jfieldId = JNIEnv.GetFieldID (class_ref, "mAdUnitId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mAdUnitId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAdUnitId_jfieldId == IntPtr.Zero)
					mAdUnitId_jfieldId = JNIEnv.GetFieldID (class_ref, "mAdUnitId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, mAdUnitId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mContext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']/field[@name='mContext']"
		[Register ("mContext")]
		protected global::Android.Content.Context MContext {
			get {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mContext_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mContext_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mKeywords_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']/field[@name='mKeywords']"
		[Register ("mKeywords")]
		protected string MKeywords {
			get {
				if (mKeywords_jfieldId == IntPtr.Zero)
					mKeywords_jfieldId = JNIEnv.GetFieldID (class_ref, "mKeywords", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mKeywords_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mKeywords_jfieldId == IntPtr.Zero)
					mKeywords_jfieldId = JNIEnv.GetFieldID (class_ref, "mKeywords", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, mKeywords_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mLocation_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']/field[@name='mLocation']"
		[Register ("mLocation")]
		protected global::Android.Locations.Location MLocation {
			get {
				if (mLocation_jfieldId == IntPtr.Zero)
					mLocation_jfieldId = JNIEnv.GetFieldID (class_ref, "mLocation", "Landroid/location/Location;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mLocation_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mLocation_jfieldId == IntPtr.Zero)
					mLocation_jfieldId = JNIEnv.GetFieldID (class_ref, "mLocation", "Landroid/location/Location;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mLocation_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/AdUrlGenerator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdUrlGenerator); }
		}

		protected AdUrlGenerator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']/constructor[@name='AdUrlGenerator' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AdUrlGenerator (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AdUrlGenerator)) {
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

		static Delegate cb_addBaseParams_Lcom_mopub_common_ClientMetadata_;
#pragma warning disable 0169
		static Delegate GetAddBaseParams_Lcom_mopub_common_ClientMetadata_Handler ()
		{
			if (cb_addBaseParams_Lcom_mopub_common_ClientMetadata_ == null)
				cb_addBaseParams_Lcom_mopub_common_ClientMetadata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddBaseParams_Lcom_mopub_common_ClientMetadata_);
			return cb_addBaseParams_Lcom_mopub_common_ClientMetadata_;
		}

		static void n_AddBaseParams_Lcom_mopub_common_ClientMetadata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.AdUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Common.ClientMetadata p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddBaseParams (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addBaseParams_Lcom_mopub_common_ClientMetadata_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']/method[@name='addBaseParams' and count(parameter)=1 and parameter[1][@type='com.mopub.common.ClientMetadata']]"
		[Register ("addBaseParams", "(Lcom/mopub/common/ClientMetadata;)V", "GetAddBaseParams_Lcom_mopub_common_ClientMetadata_Handler")]
		protected virtual unsafe void AddBaseParams (global::Com.Mopub.Common.ClientMetadata p0)
		{
			if (id_addBaseParams_Lcom_mopub_common_ClientMetadata_ == IntPtr.Zero)
				id_addBaseParams_Lcom_mopub_common_ClientMetadata_ = JNIEnv.GetMethodID (class_ref, "addBaseParams", "(Lcom/mopub/common/ClientMetadata;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addBaseParams_Lcom_mopub_common_ClientMetadata_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addBaseParams", "(Lcom/mopub/common/ClientMetadata;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAdUnitId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAdUnitId_Ljava_lang_String_Handler ()
		{
			if (cb_setAdUnitId_Ljava_lang_String_ == null)
				cb_setAdUnitId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdUnitId_Ljava_lang_String_);
			return cb_setAdUnitId_Ljava_lang_String_;
		}

		static void n_SetAdUnitId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.AdUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAdUnitId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAdUnitId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']/method[@name='setAdUnitId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAdUnitId", "(Ljava/lang/String;)V", "GetSetAdUnitId_Ljava_lang_String_Handler")]
		protected virtual unsafe void SetAdUnitId (string p0)
		{
			if (id_setAdUnitId_Ljava_lang_String_ == IntPtr.Zero)
				id_setAdUnitId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAdUnitId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAdUnitId_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdUnitId", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setBundleId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBundleId_Ljava_lang_String_Handler ()
		{
			if (cb_setBundleId_Ljava_lang_String_ == null)
				cb_setBundleId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBundleId_Ljava_lang_String_);
			return cb_setBundleId_Ljava_lang_String_;
		}

		static void n_SetBundleId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.AdUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBundleId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBundleId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']/method[@name='setBundleId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setBundleId", "(Ljava/lang/String;)V", "GetSetBundleId_Ljava_lang_String_Handler")]
		protected virtual unsafe void SetBundleId (string p0)
		{
			if (id_setBundleId_Ljava_lang_String_ == IntPtr.Zero)
				id_setBundleId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBundleId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setBundleId_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBundleId", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setCarrierName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCarrierName_Ljava_lang_String_Handler ()
		{
			if (cb_setCarrierName_Ljava_lang_String_ == null)
				cb_setCarrierName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCarrierName_Ljava_lang_String_);
			return cb_setCarrierName_Ljava_lang_String_;
		}

		static void n_SetCarrierName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.AdUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCarrierName (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCarrierName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']/method[@name='setCarrierName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCarrierName", "(Ljava/lang/String;)V", "GetSetCarrierName_Ljava_lang_String_Handler")]
		protected virtual unsafe void SetCarrierName (string p0)
		{
			if (id_setCarrierName_Ljava_lang_String_ == IntPtr.Zero)
				id_setCarrierName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCarrierName", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setCarrierName_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCarrierName", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setDensity_F;
#pragma warning disable 0169
		static Delegate GetSetDensity_FHandler ()
		{
			if (cb_setDensity_F == null)
				cb_setDensity_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetDensity_F);
			return cb_setDensity_F;
		}

		static void n_SetDensity_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Mopub.Common.AdUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDensity (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDensity_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']/method[@name='setDensity' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setDensity", "(F)V", "GetSetDensity_FHandler")]
		protected virtual unsafe void SetDensity (float p0)
		{
			if (id_setDensity_F == IntPtr.Zero)
				id_setDensity_F = JNIEnv.GetMethodID (class_ref, "setDensity", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDensity_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDensity", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setIsoCountryCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIsoCountryCode_Ljava_lang_String_Handler ()
		{
			if (cb_setIsoCountryCode_Ljava_lang_String_ == null)
				cb_setIsoCountryCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIsoCountryCode_Ljava_lang_String_);
			return cb_setIsoCountryCode_Ljava_lang_String_;
		}

		static void n_SetIsoCountryCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.AdUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIsoCountryCode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIsoCountryCode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']/method[@name='setIsoCountryCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setIsoCountryCode", "(Ljava/lang/String;)V", "GetSetIsoCountryCode_Ljava_lang_String_Handler")]
		protected virtual unsafe void SetIsoCountryCode (string p0)
		{
			if (id_setIsoCountryCode_Ljava_lang_String_ == IntPtr.Zero)
				id_setIsoCountryCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setIsoCountryCode", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setIsoCountryCode_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsoCountryCode", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setKeywords_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetKeywords_Ljava_lang_String_Handler ()
		{
			if (cb_setKeywords_Ljava_lang_String_ == null)
				cb_setKeywords_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetKeywords_Ljava_lang_String_);
			return cb_setKeywords_Ljava_lang_String_;
		}

		static void n_SetKeywords_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.AdUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetKeywords (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setKeywords_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']/method[@name='setKeywords' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setKeywords", "(Ljava/lang/String;)V", "GetSetKeywords_Ljava_lang_String_Handler")]
		protected virtual unsafe void SetKeywords (string p0)
		{
			if (id_setKeywords_Ljava_lang_String_ == IntPtr.Zero)
				id_setKeywords_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setKeywords", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setKeywords_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKeywords", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setLocation_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetSetLocation_Landroid_location_Location_Handler ()
		{
			if (cb_setLocation_Landroid_location_Location_ == null)
				cb_setLocation_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocation_Landroid_location_Location_);
			return cb_setLocation_Landroid_location_Location_;
		}

		static void n_SetLocation_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.AdUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location p0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLocation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLocation_Landroid_location_Location_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register ("setLocation", "(Landroid/location/Location;)V", "GetSetLocation_Landroid_location_Location_Handler")]
		protected virtual unsafe void SetLocation (global::Android.Locations.Location p0)
		{
			if (id_setLocation_Landroid_location_Location_ == IntPtr.Zero)
				id_setLocation_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "setLocation", "(Landroid/location/Location;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLocation_Landroid_location_Location_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocation", "(Landroid/location/Location;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMccCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMccCode_Ljava_lang_String_Handler ()
		{
			if (cb_setMccCode_Ljava_lang_String_ == null)
				cb_setMccCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMccCode_Ljava_lang_String_);
			return cb_setMccCode_Ljava_lang_String_;
		}

		static void n_SetMccCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.AdUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMccCode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMccCode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']/method[@name='setMccCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMccCode", "(Ljava/lang/String;)V", "GetSetMccCode_Ljava_lang_String_Handler")]
		protected virtual unsafe void SetMccCode (string p0)
		{
			if (id_setMccCode_Ljava_lang_String_ == IntPtr.Zero)
				id_setMccCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMccCode", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMccCode_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMccCode", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setMncCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMncCode_Ljava_lang_String_Handler ()
		{
			if (cb_setMncCode_Ljava_lang_String_ == null)
				cb_setMncCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMncCode_Ljava_lang_String_);
			return cb_setMncCode_Ljava_lang_String_;
		}

		static void n_SetMncCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.AdUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMncCode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMncCode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']/method[@name='setMncCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMncCode", "(Ljava/lang/String;)V", "GetSetMncCode_Ljava_lang_String_Handler")]
		protected virtual unsafe void SetMncCode (string p0)
		{
			if (id_setMncCode_Ljava_lang_String_ == IntPtr.Zero)
				id_setMncCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMncCode", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMncCode_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMncCode", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setMraidFlag_Z;
#pragma warning disable 0169
		static Delegate GetSetMraidFlag_ZHandler ()
		{
			if (cb_setMraidFlag_Z == null)
				cb_setMraidFlag_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMraidFlag_Z);
			return cb_setMraidFlag_Z;
		}

		static void n_SetMraidFlag_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mopub.Common.AdUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMraidFlag (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMraidFlag_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']/method[@name='setMraidFlag' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMraidFlag", "(Z)V", "GetSetMraidFlag_ZHandler")]
		protected virtual unsafe void SetMraidFlag (bool p0)
		{
			if (id_setMraidFlag_Z == IntPtr.Zero)
				id_setMraidFlag_Z = JNIEnv.GetMethodID (class_ref, "setMraidFlag", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMraidFlag_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMraidFlag", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setNetworkType_Lcom_mopub_common_ClientMetadata_MoPubNetworkType_;
#pragma warning disable 0169
		static Delegate GetSetNetworkType_Lcom_mopub_common_ClientMetadata_MoPubNetworkType_Handler ()
		{
			if (cb_setNetworkType_Lcom_mopub_common_ClientMetadata_MoPubNetworkType_ == null)
				cb_setNetworkType_Lcom_mopub_common_ClientMetadata_MoPubNetworkType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNetworkType_Lcom_mopub_common_ClientMetadata_MoPubNetworkType_);
			return cb_setNetworkType_Lcom_mopub_common_ClientMetadata_MoPubNetworkType_;
		}

		static void n_SetNetworkType_Lcom_mopub_common_ClientMetadata_MoPubNetworkType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.AdUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Common.ClientMetadata.MoPubNetworkType p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata.MoPubNetworkType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNetworkType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setNetworkType_Lcom_mopub_common_ClientMetadata_MoPubNetworkType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']/method[@name='setNetworkType' and count(parameter)=1 and parameter[1][@type='com.mopub.common.ClientMetadata.MoPubNetworkType']]"
		[Register ("setNetworkType", "(Lcom/mopub/common/ClientMetadata$MoPubNetworkType;)V", "GetSetNetworkType_Lcom_mopub_common_ClientMetadata_MoPubNetworkType_Handler")]
		protected virtual unsafe void SetNetworkType (global::Com.Mopub.Common.ClientMetadata.MoPubNetworkType p0)
		{
			if (id_setNetworkType_Lcom_mopub_common_ClientMetadata_MoPubNetworkType_ == IntPtr.Zero)
				id_setNetworkType_Lcom_mopub_common_ClientMetadata_MoPubNetworkType_ = JNIEnv.GetMethodID (class_ref, "setNetworkType", "(Lcom/mopub/common/ClientMetadata$MoPubNetworkType;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setNetworkType_Lcom_mopub_common_ClientMetadata_MoPubNetworkType_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNetworkType", "(Lcom/mopub/common/ClientMetadata$MoPubNetworkType;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOrientation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOrientation_Ljava_lang_String_Handler ()
		{
			if (cb_setOrientation_Ljava_lang_String_ == null)
				cb_setOrientation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOrientation_Ljava_lang_String_);
			return cb_setOrientation_Ljava_lang_String_;
		}

		static void n_SetOrientation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.AdUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOrientation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOrientation_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']/method[@name='setOrientation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOrientation", "(Ljava/lang/String;)V", "GetSetOrientation_Ljava_lang_String_Handler")]
		protected virtual unsafe void SetOrientation (string p0)
		{
			if (id_setOrientation_Ljava_lang_String_ == IntPtr.Zero)
				id_setOrientation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOrientation", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOrientation_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOrientation", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setSdkVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSdkVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setSdkVersion_Ljava_lang_String_ == null)
				cb_setSdkVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSdkVersion_Ljava_lang_String_);
			return cb_setSdkVersion_Ljava_lang_String_;
		}

		static void n_SetSdkVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.AdUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSdkVersion (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSdkVersion_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']/method[@name='setSdkVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSdkVersion", "(Ljava/lang/String;)V", "GetSetSdkVersion_Ljava_lang_String_Handler")]
		protected virtual unsafe void SetSdkVersion (string p0)
		{
			if (id_setSdkVersion_Ljava_lang_String_ == IntPtr.Zero)
				id_setSdkVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSdkVersion", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSdkVersion_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSdkVersion", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setTimezone_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTimezone_Ljava_lang_String_Handler ()
		{
			if (cb_setTimezone_Ljava_lang_String_ == null)
				cb_setTimezone_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTimezone_Ljava_lang_String_);
			return cb_setTimezone_Ljava_lang_String_;
		}

		static void n_SetTimezone_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.AdUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTimezone (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTimezone_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']/method[@name='setTimezone' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTimezone", "(Ljava/lang/String;)V", "GetSetTimezone_Ljava_lang_String_Handler")]
		protected virtual unsafe void SetTimezone (string p0)
		{
			if (id_setTimezone_Ljava_lang_String_ == IntPtr.Zero)
				id_setTimezone_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTimezone", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTimezone_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimezone", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withAdUnitId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithAdUnitId_Ljava_lang_String_Handler ()
		{
			if (cb_withAdUnitId_Ljava_lang_String_ == null)
				cb_withAdUnitId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithAdUnitId_Ljava_lang_String_);
			return cb_withAdUnitId_Ljava_lang_String_;
		}

		static IntPtr n_WithAdUnitId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.AdUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAdUnitId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withAdUnitId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']/method[@name='withAdUnitId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withAdUnitId", "(Ljava/lang/String;)Lcom/mopub/common/AdUrlGenerator;", "GetWithAdUnitId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mopub.Common.AdUrlGenerator WithAdUnitId (string p0)
		{
			if (id_withAdUnitId_Ljava_lang_String_ == IntPtr.Zero)
				id_withAdUnitId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withAdUnitId", "(Ljava/lang/String;)Lcom/mopub/common/AdUrlGenerator;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mopub.Common.AdUrlGenerator __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (JNIEnv.CallObjectMethod  (Handle, id_withAdUnitId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withAdUnitId", "(Ljava/lang/String;)Lcom/mopub/common/AdUrlGenerator;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withFacebookSupported_Z;
#pragma warning disable 0169
		static Delegate GetWithFacebookSupported_ZHandler ()
		{
			if (cb_withFacebookSupported_Z == null)
				cb_withFacebookSupported_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithFacebookSupported_Z);
			return cb_withFacebookSupported_Z;
		}

		static IntPtr n_WithFacebookSupported_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mopub.Common.AdUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithFacebookSupported (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withFacebookSupported_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']/method[@name='withFacebookSupported' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("withFacebookSupported", "(Z)Lcom/mopub/common/AdUrlGenerator;", "GetWithFacebookSupported_ZHandler")]
		public virtual unsafe global::Com.Mopub.Common.AdUrlGenerator WithFacebookSupported (bool p0)
		{
			if (id_withFacebookSupported_Z == IntPtr.Zero)
				id_withFacebookSupported_Z = JNIEnv.GetMethodID (class_ref, "withFacebookSupported", "(Z)Lcom/mopub/common/AdUrlGenerator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (JNIEnv.CallObjectMethod  (Handle, id_withFacebookSupported_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withFacebookSupported", "(Z)Lcom/mopub/common/AdUrlGenerator;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withKeywords_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithKeywords_Ljava_lang_String_Handler ()
		{
			if (cb_withKeywords_Ljava_lang_String_ == null)
				cb_withKeywords_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithKeywords_Ljava_lang_String_);
			return cb_withKeywords_Ljava_lang_String_;
		}

		static IntPtr n_WithKeywords_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.AdUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithKeywords (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withKeywords_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']/method[@name='withKeywords' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withKeywords", "(Ljava/lang/String;)Lcom/mopub/common/AdUrlGenerator;", "GetWithKeywords_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mopub.Common.AdUrlGenerator WithKeywords (string p0)
		{
			if (id_withKeywords_Ljava_lang_String_ == IntPtr.Zero)
				id_withKeywords_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withKeywords", "(Ljava/lang/String;)Lcom/mopub/common/AdUrlGenerator;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mopub.Common.AdUrlGenerator __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (JNIEnv.CallObjectMethod  (Handle, id_withKeywords_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withKeywords", "(Ljava/lang/String;)Lcom/mopub/common/AdUrlGenerator;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withLocation_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetWithLocation_Landroid_location_Location_Handler ()
		{
			if (cb_withLocation_Landroid_location_Location_ == null)
				cb_withLocation_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithLocation_Landroid_location_Location_);
			return cb_withLocation_Landroid_location_Location_;
		}

		static IntPtr n_WithLocation_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.AdUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location p0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithLocation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withLocation_Landroid_location_Location_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='AdUrlGenerator']/method[@name='withLocation' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register ("withLocation", "(Landroid/location/Location;)Lcom/mopub/common/AdUrlGenerator;", "GetWithLocation_Landroid_location_Location_Handler")]
		public virtual unsafe global::Com.Mopub.Common.AdUrlGenerator WithLocation (global::Android.Locations.Location p0)
		{
			if (id_withLocation_Landroid_location_Location_ == IntPtr.Zero)
				id_withLocation_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "withLocation", "(Landroid/location/Location;)Lcom/mopub/common/AdUrlGenerator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mopub.Common.AdUrlGenerator __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (JNIEnv.CallObjectMethod  (Handle, id_withLocation_Landroid_location_Location_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdUrlGenerator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withLocation", "(Landroid/location/Location;)Lcom/mopub/common/AdUrlGenerator;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/mopub/common/AdUrlGenerator", DoNotGenerateAcw=true)]
	internal partial class AdUrlGeneratorInvoker : AdUrlGenerator {

		public AdUrlGeneratorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdUrlGeneratorInvoker); }
		}

		static IntPtr id_generateUrlString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseUrlGenerator']/method[@name='generateUrlString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("generateUrlString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGenerateUrlString_Ljava_lang_String_Handler")]
		public override unsafe string GenerateUrlString (string p0)
		{
			if (id_generateUrlString_Ljava_lang_String_ == IntPtr.Zero)
				id_generateUrlString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "generateUrlString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_generateUrlString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
