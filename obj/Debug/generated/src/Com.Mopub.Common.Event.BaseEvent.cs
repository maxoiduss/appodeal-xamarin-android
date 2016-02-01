using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']"
	[global::Android.Runtime.Register ("com/mopub/common/event/BaseEvent", DoNotGenerateAcw=true)]
	public abstract partial class BaseEvent : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.AppPlatform']"
		[global::Android.Runtime.Register ("com/mopub/common/event/BaseEvent$AppPlatform", DoNotGenerateAcw=true)]
		public sealed partial class AppPlatform : global::Java.Lang.Enum {


			static IntPtr ANDROID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.AppPlatform']/field[@name='ANDROID']"
			[Register ("ANDROID")]
			public static global::Com.Mopub.Common.Event.BaseEvent.AppPlatform Android {
				get {
					if (ANDROID_jfieldId == IntPtr.Zero)
						ANDROID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ANDROID", "Lcom/mopub/common/event/BaseEvent$AppPlatform;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ANDROID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.AppPlatform> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr IOS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.AppPlatform']/field[@name='IOS']"
			[Register ("IOS")]
			public static global::Com.Mopub.Common.Event.BaseEvent.AppPlatform Ios {
				get {
					if (IOS_jfieldId == IntPtr.Zero)
						IOS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IOS", "Lcom/mopub/common/event/BaseEvent$AppPlatform;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IOS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.AppPlatform> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MOBILE_WEB_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.AppPlatform']/field[@name='MOBILE_WEB']"
			[Register ("MOBILE_WEB")]
			public static global::Com.Mopub.Common.Event.BaseEvent.AppPlatform MobileWeb {
				get {
					if (MOBILE_WEB_jfieldId == IntPtr.Zero)
						MOBILE_WEB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOBILE_WEB", "Lcom/mopub/common/event/BaseEvent$AppPlatform;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MOBILE_WEB_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.AppPlatform> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NONE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.AppPlatform']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Com.Mopub.Common.Event.BaseEvent.AppPlatform None {
				get {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/mopub/common/event/BaseEvent$AppPlatform;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.AppPlatform> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/event/BaseEvent$AppPlatform", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AppPlatform); }
			}

			internal AppPlatform (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getType;
			public unsafe int Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.AppPlatform']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()I", "GetGetTypeHandler")]
				get {
					if (id_getType == IntPtr.Zero)
						id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
					try {
						return JNIEnv.CallIntMethod  (Handle, id_getType);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.AppPlatform']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$AppPlatform;", "")]
			public static unsafe global::Com.Mopub.Common.Event.BaseEvent.AppPlatform ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$AppPlatform;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mopub.Common.Event.BaseEvent.AppPlatform __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.AppPlatform> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.AppPlatform']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/common/event/BaseEvent$AppPlatform;", "")]
			public static unsafe global::Com.Mopub.Common.Event.BaseEvent.AppPlatform[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/common/event/BaseEvent$AppPlatform;");
				try {
					return (global::Com.Mopub.Common.Event.BaseEvent.AppPlatform[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Common.Event.BaseEvent.AppPlatform));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Builder']"
		[global::Android.Runtime.Register ("com/mopub/common/event/BaseEvent$Builder", DoNotGenerateAcw=true)]
		public abstract partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/event/BaseEvent$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_mopub_common_event_BaseEvent_ScribeCategory_Lcom_mopub_common_event_BaseEvent_Name_Lcom_mopub_common_event_BaseEvent_Category_D;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Builder']/constructor[@name='BaseEvent.Builder' and count(parameter)=4 and parameter[1][@type='com.mopub.common.event.BaseEvent.ScribeCategory'] and parameter[2][@type='com.mopub.common.event.BaseEvent.Name'] and parameter[3][@type='com.mopub.common.event.BaseEvent.Category'] and parameter[4][@type='double']]"
			[Register (".ctor", "(Lcom/mopub/common/event/BaseEvent$ScribeCategory;Lcom/mopub/common/event/BaseEvent$Name;Lcom/mopub/common/event/BaseEvent$Category;D)V", "")]
			public unsafe Builder (global::Com.Mopub.Common.Event.BaseEvent.ScribeCategory p0, global::Com.Mopub.Common.Event.BaseEvent.Name p1, global::Com.Mopub.Common.Event.BaseEvent.Category p2, double p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					if (GetType () != typeof (Builder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/common/event/BaseEvent$ScribeCategory;Lcom/mopub/common/event/BaseEvent$Name;Lcom/mopub/common/event/BaseEvent$Category;D)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/common/event/BaseEvent$ScribeCategory;Lcom/mopub/common/event/BaseEvent$Name;Lcom/mopub/common/event/BaseEvent$Category;D)V", __args);
						return;
					}

					if (id_ctor_Lcom_mopub_common_event_BaseEvent_ScribeCategory_Lcom_mopub_common_event_BaseEvent_Name_Lcom_mopub_common_event_BaseEvent_Category_D == IntPtr.Zero)
						id_ctor_Lcom_mopub_common_event_BaseEvent_ScribeCategory_Lcom_mopub_common_event_BaseEvent_Name_Lcom_mopub_common_event_BaseEvent_Category_D = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/common/event/BaseEvent$ScribeCategory;Lcom/mopub/common/event/BaseEvent$Name;Lcom/mopub/common/event/BaseEvent$Category;D)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_common_event_BaseEvent_ScribeCategory_Lcom_mopub_common_event_BaseEvent_Name_Lcom_mopub_common_event_BaseEvent_Category_D, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_common_event_BaseEvent_ScribeCategory_Lcom_mopub_common_event_BaseEvent_Name_Lcom_mopub_common_event_BaseEvent_Category_D, __args);
				} finally {
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Common.Event.BaseEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/mopub/common/event/BaseEvent;", "GetBuildHandler")]
			public abstract global::Com.Mopub.Common.Event.BaseEvent Build ();

			static Delegate cb_withAdCreativeId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithAdCreativeId_Ljava_lang_String_Handler ()
			{
				if (cb_withAdCreativeId_Ljava_lang_String_ == null)
					cb_withAdCreativeId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithAdCreativeId_Ljava_lang_String_);
				return cb_withAdCreativeId_Ljava_lang_String_;
			}

			static IntPtr n_WithAdCreativeId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.Event.BaseEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAdCreativeId (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withAdCreativeId_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Builder']/method[@name='withAdCreativeId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("withAdCreativeId", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$Builder;", "GetWithAdCreativeId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Event.BaseEvent.Builder WithAdCreativeId (string p0)
			{
				if (id_withAdCreativeId_Ljava_lang_String_ == IntPtr.Zero)
					id_withAdCreativeId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withAdCreativeId", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Common.Event.BaseEvent.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withAdCreativeId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withAdCreativeId", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_withAdHeightPx_Ljava_lang_Double_;
#pragma warning disable 0169
			static Delegate GetWithAdHeightPx_Ljava_lang_Double_Handler ()
			{
				if (cb_withAdHeightPx_Ljava_lang_Double_ == null)
					cb_withAdHeightPx_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithAdHeightPx_Ljava_lang_Double_);
				return cb_withAdHeightPx_Ljava_lang_Double_;
			}

			static IntPtr n_WithAdHeightPx_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.Event.BaseEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAdHeightPx (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withAdHeightPx_Ljava_lang_Double_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Builder']/method[@name='withAdHeightPx' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("withAdHeightPx", "(Ljava/lang/Double;)Lcom/mopub/common/event/BaseEvent$Builder;", "GetWithAdHeightPx_Ljava_lang_Double_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Event.BaseEvent.Builder WithAdHeightPx (global::Java.Lang.Double p0)
			{
				if (id_withAdHeightPx_Ljava_lang_Double_ == IntPtr.Zero)
					id_withAdHeightPx_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "withAdHeightPx", "(Ljava/lang/Double;)Lcom/mopub/common/event/BaseEvent$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mopub.Common.Event.BaseEvent.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withAdHeightPx_Ljava_lang_Double_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withAdHeightPx", "(Ljava/lang/Double;)Lcom/mopub/common/event/BaseEvent$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_withAdNetworkType_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithAdNetworkType_Ljava_lang_String_Handler ()
			{
				if (cb_withAdNetworkType_Ljava_lang_String_ == null)
					cb_withAdNetworkType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithAdNetworkType_Ljava_lang_String_);
				return cb_withAdNetworkType_Ljava_lang_String_;
			}

			static IntPtr n_WithAdNetworkType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.Event.BaseEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAdNetworkType (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withAdNetworkType_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Builder']/method[@name='withAdNetworkType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("withAdNetworkType", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$Builder;", "GetWithAdNetworkType_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Event.BaseEvent.Builder WithAdNetworkType (string p0)
			{
				if (id_withAdNetworkType_Ljava_lang_String_ == IntPtr.Zero)
					id_withAdNetworkType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withAdNetworkType", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Common.Event.BaseEvent.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withAdNetworkType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withAdNetworkType", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_withAdType_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithAdType_Ljava_lang_String_Handler ()
			{
				if (cb_withAdType_Ljava_lang_String_ == null)
					cb_withAdType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithAdType_Ljava_lang_String_);
				return cb_withAdType_Ljava_lang_String_;
			}

			static IntPtr n_WithAdType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.Event.BaseEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAdType (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withAdType_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Builder']/method[@name='withAdType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("withAdType", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$Builder;", "GetWithAdType_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Event.BaseEvent.Builder WithAdType (string p0)
			{
				if (id_withAdType_Ljava_lang_String_ == IntPtr.Zero)
					id_withAdType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withAdType", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Common.Event.BaseEvent.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withAdType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withAdType", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
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
				global::Com.Mopub.Common.Event.BaseEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAdUnitId (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withAdUnitId_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Builder']/method[@name='withAdUnitId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("withAdUnitId", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$Builder;", "GetWithAdUnitId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Event.BaseEvent.Builder WithAdUnitId (string p0)
			{
				if (id_withAdUnitId_Ljava_lang_String_ == IntPtr.Zero)
					id_withAdUnitId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withAdUnitId", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Common.Event.BaseEvent.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withAdUnitId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withAdUnitId", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_withAdWidthPx_Ljava_lang_Double_;
#pragma warning disable 0169
			static Delegate GetWithAdWidthPx_Ljava_lang_Double_Handler ()
			{
				if (cb_withAdWidthPx_Ljava_lang_Double_ == null)
					cb_withAdWidthPx_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithAdWidthPx_Ljava_lang_Double_);
				return cb_withAdWidthPx_Ljava_lang_Double_;
			}

			static IntPtr n_WithAdWidthPx_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.Event.BaseEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAdWidthPx (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withAdWidthPx_Ljava_lang_Double_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Builder']/method[@name='withAdWidthPx' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("withAdWidthPx", "(Ljava/lang/Double;)Lcom/mopub/common/event/BaseEvent$Builder;", "GetWithAdWidthPx_Ljava_lang_Double_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Event.BaseEvent.Builder WithAdWidthPx (global::Java.Lang.Double p0)
			{
				if (id_withAdWidthPx_Ljava_lang_Double_ == IntPtr.Zero)
					id_withAdWidthPx_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "withAdWidthPx", "(Ljava/lang/Double;)Lcom/mopub/common/event/BaseEvent$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mopub.Common.Event.BaseEvent.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withAdWidthPx_Ljava_lang_Double_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withAdWidthPx", "(Ljava/lang/Double;)Lcom/mopub/common/event/BaseEvent$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_withGeoAccuracy_Ljava_lang_Double_;
#pragma warning disable 0169
			static Delegate GetWithGeoAccuracy_Ljava_lang_Double_Handler ()
			{
				if (cb_withGeoAccuracy_Ljava_lang_Double_ == null)
					cb_withGeoAccuracy_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithGeoAccuracy_Ljava_lang_Double_);
				return cb_withGeoAccuracy_Ljava_lang_Double_;
			}

			static IntPtr n_WithGeoAccuracy_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.Event.BaseEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithGeoAccuracy (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withGeoAccuracy_Ljava_lang_Double_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Builder']/method[@name='withGeoAccuracy' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("withGeoAccuracy", "(Ljava/lang/Double;)Lcom/mopub/common/event/BaseEvent$Builder;", "GetWithGeoAccuracy_Ljava_lang_Double_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Event.BaseEvent.Builder WithGeoAccuracy (global::Java.Lang.Double p0)
			{
				if (id_withGeoAccuracy_Ljava_lang_Double_ == IntPtr.Zero)
					id_withGeoAccuracy_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "withGeoAccuracy", "(Ljava/lang/Double;)Lcom/mopub/common/event/BaseEvent$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mopub.Common.Event.BaseEvent.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withGeoAccuracy_Ljava_lang_Double_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withGeoAccuracy", "(Ljava/lang/Double;)Lcom/mopub/common/event/BaseEvent$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_withGeoLat_Ljava_lang_Double_;
#pragma warning disable 0169
			static Delegate GetWithGeoLat_Ljava_lang_Double_Handler ()
			{
				if (cb_withGeoLat_Ljava_lang_Double_ == null)
					cb_withGeoLat_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithGeoLat_Ljava_lang_Double_);
				return cb_withGeoLat_Ljava_lang_Double_;
			}

			static IntPtr n_WithGeoLat_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.Event.BaseEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithGeoLat (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withGeoLat_Ljava_lang_Double_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Builder']/method[@name='withGeoLat' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("withGeoLat", "(Ljava/lang/Double;)Lcom/mopub/common/event/BaseEvent$Builder;", "GetWithGeoLat_Ljava_lang_Double_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Event.BaseEvent.Builder WithGeoLat (global::Java.Lang.Double p0)
			{
				if (id_withGeoLat_Ljava_lang_Double_ == IntPtr.Zero)
					id_withGeoLat_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "withGeoLat", "(Ljava/lang/Double;)Lcom/mopub/common/event/BaseEvent$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mopub.Common.Event.BaseEvent.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withGeoLat_Ljava_lang_Double_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withGeoLat", "(Ljava/lang/Double;)Lcom/mopub/common/event/BaseEvent$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_withGeoLon_Ljava_lang_Double_;
#pragma warning disable 0169
			static Delegate GetWithGeoLon_Ljava_lang_Double_Handler ()
			{
				if (cb_withGeoLon_Ljava_lang_Double_ == null)
					cb_withGeoLon_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithGeoLon_Ljava_lang_Double_);
				return cb_withGeoLon_Ljava_lang_Double_;
			}

			static IntPtr n_WithGeoLon_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.Event.BaseEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithGeoLon (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withGeoLon_Ljava_lang_Double_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Builder']/method[@name='withGeoLon' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("withGeoLon", "(Ljava/lang/Double;)Lcom/mopub/common/event/BaseEvent$Builder;", "GetWithGeoLon_Ljava_lang_Double_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Event.BaseEvent.Builder WithGeoLon (global::Java.Lang.Double p0)
			{
				if (id_withGeoLon_Ljava_lang_Double_ == IntPtr.Zero)
					id_withGeoLon_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "withGeoLon", "(Ljava/lang/Double;)Lcom/mopub/common/event/BaseEvent$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mopub.Common.Event.BaseEvent.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withGeoLon_Ljava_lang_Double_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withGeoLon", "(Ljava/lang/Double;)Lcom/mopub/common/event/BaseEvent$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_withPerformanceDurationMs_Ljava_lang_Double_;
#pragma warning disable 0169
			static Delegate GetWithPerformanceDurationMs_Ljava_lang_Double_Handler ()
			{
				if (cb_withPerformanceDurationMs_Ljava_lang_Double_ == null)
					cb_withPerformanceDurationMs_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithPerformanceDurationMs_Ljava_lang_Double_);
				return cb_withPerformanceDurationMs_Ljava_lang_Double_;
			}

			static IntPtr n_WithPerformanceDurationMs_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.Event.BaseEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithPerformanceDurationMs (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withPerformanceDurationMs_Ljava_lang_Double_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Builder']/method[@name='withPerformanceDurationMs' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("withPerformanceDurationMs", "(Ljava/lang/Double;)Lcom/mopub/common/event/BaseEvent$Builder;", "GetWithPerformanceDurationMs_Ljava_lang_Double_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Event.BaseEvent.Builder WithPerformanceDurationMs (global::Java.Lang.Double p0)
			{
				if (id_withPerformanceDurationMs_Ljava_lang_Double_ == IntPtr.Zero)
					id_withPerformanceDurationMs_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "withPerformanceDurationMs", "(Ljava/lang/Double;)Lcom/mopub/common/event/BaseEvent$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mopub.Common.Event.BaseEvent.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withPerformanceDurationMs_Ljava_lang_Double_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withPerformanceDurationMs", "(Ljava/lang/Double;)Lcom/mopub/common/event/BaseEvent$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_withRequestId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithRequestId_Ljava_lang_String_Handler ()
			{
				if (cb_withRequestId_Ljava_lang_String_ == null)
					cb_withRequestId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithRequestId_Ljava_lang_String_);
				return cb_withRequestId_Ljava_lang_String_;
			}

			static IntPtr n_WithRequestId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.Event.BaseEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithRequestId (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withRequestId_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Builder']/method[@name='withRequestId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("withRequestId", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$Builder;", "GetWithRequestId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Event.BaseEvent.Builder WithRequestId (string p0)
			{
				if (id_withRequestId_Ljava_lang_String_ == IntPtr.Zero)
					id_withRequestId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withRequestId", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Common.Event.BaseEvent.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withRequestId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withRequestId", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_withRequestRetries_Ljava_lang_Integer_;
#pragma warning disable 0169
			static Delegate GetWithRequestRetries_Ljava_lang_Integer_Handler ()
			{
				if (cb_withRequestRetries_Ljava_lang_Integer_ == null)
					cb_withRequestRetries_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithRequestRetries_Ljava_lang_Integer_);
				return cb_withRequestRetries_Ljava_lang_Integer_;
			}

			static IntPtr n_WithRequestRetries_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.Event.BaseEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithRequestRetries (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withRequestRetries_Ljava_lang_Integer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Builder']/method[@name='withRequestRetries' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("withRequestRetries", "(Ljava/lang/Integer;)Lcom/mopub/common/event/BaseEvent$Builder;", "GetWithRequestRetries_Ljava_lang_Integer_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Event.BaseEvent.Builder WithRequestRetries (global::Java.Lang.Integer p0)
			{
				if (id_withRequestRetries_Ljava_lang_Integer_ == IntPtr.Zero)
					id_withRequestRetries_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "withRequestRetries", "(Ljava/lang/Integer;)Lcom/mopub/common/event/BaseEvent$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mopub.Common.Event.BaseEvent.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withRequestRetries_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withRequestRetries", "(Ljava/lang/Integer;)Lcom/mopub/common/event/BaseEvent$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_withRequestStatusCode_Ljava_lang_Integer_;
#pragma warning disable 0169
			static Delegate GetWithRequestStatusCode_Ljava_lang_Integer_Handler ()
			{
				if (cb_withRequestStatusCode_Ljava_lang_Integer_ == null)
					cb_withRequestStatusCode_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithRequestStatusCode_Ljava_lang_Integer_);
				return cb_withRequestStatusCode_Ljava_lang_Integer_;
			}

			static IntPtr n_WithRequestStatusCode_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.Event.BaseEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithRequestStatusCode (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withRequestStatusCode_Ljava_lang_Integer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Builder']/method[@name='withRequestStatusCode' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("withRequestStatusCode", "(Ljava/lang/Integer;)Lcom/mopub/common/event/BaseEvent$Builder;", "GetWithRequestStatusCode_Ljava_lang_Integer_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Event.BaseEvent.Builder WithRequestStatusCode (global::Java.Lang.Integer p0)
			{
				if (id_withRequestStatusCode_Ljava_lang_Integer_ == IntPtr.Zero)
					id_withRequestStatusCode_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "withRequestStatusCode", "(Ljava/lang/Integer;)Lcom/mopub/common/event/BaseEvent$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mopub.Common.Event.BaseEvent.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withRequestStatusCode_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withRequestStatusCode", "(Ljava/lang/Integer;)Lcom/mopub/common/event/BaseEvent$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_withRequestUri_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithRequestUri_Ljava_lang_String_Handler ()
			{
				if (cb_withRequestUri_Ljava_lang_String_ == null)
					cb_withRequestUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithRequestUri_Ljava_lang_String_);
				return cb_withRequestUri_Ljava_lang_String_;
			}

			static IntPtr n_WithRequestUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.Event.BaseEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithRequestUri (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withRequestUri_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Builder']/method[@name='withRequestUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("withRequestUri", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$Builder;", "GetWithRequestUri_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Event.BaseEvent.Builder WithRequestUri (string p0)
			{
				if (id_withRequestUri_Ljava_lang_String_ == IntPtr.Zero)
					id_withRequestUri_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withRequestUri", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Common.Event.BaseEvent.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withRequestUri_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withRequestUri", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_withSdkProduct_Lcom_mopub_common_event_BaseEvent_SdkProduct_;
#pragma warning disable 0169
			static Delegate GetWithSdkProduct_Lcom_mopub_common_event_BaseEvent_SdkProduct_Handler ()
			{
				if (cb_withSdkProduct_Lcom_mopub_common_event_BaseEvent_SdkProduct_ == null)
					cb_withSdkProduct_Lcom_mopub_common_event_BaseEvent_SdkProduct_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithSdkProduct_Lcom_mopub_common_event_BaseEvent_SdkProduct_);
				return cb_withSdkProduct_Lcom_mopub_common_event_BaseEvent_SdkProduct_;
			}

			static IntPtr n_WithSdkProduct_Lcom_mopub_common_event_BaseEvent_SdkProduct_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.Event.BaseEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Common.Event.BaseEvent.SdkProduct p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.SdkProduct> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSdkProduct (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withSdkProduct_Lcom_mopub_common_event_BaseEvent_SdkProduct_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Builder']/method[@name='withSdkProduct' and count(parameter)=1 and parameter[1][@type='com.mopub.common.event.BaseEvent.SdkProduct']]"
			[Register ("withSdkProduct", "(Lcom/mopub/common/event/BaseEvent$SdkProduct;)Lcom/mopub/common/event/BaseEvent$Builder;", "GetWithSdkProduct_Lcom_mopub_common_event_BaseEvent_SdkProduct_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Event.BaseEvent.Builder WithSdkProduct (global::Com.Mopub.Common.Event.BaseEvent.SdkProduct p0)
			{
				if (id_withSdkProduct_Lcom_mopub_common_event_BaseEvent_SdkProduct_ == IntPtr.Zero)
					id_withSdkProduct_Lcom_mopub_common_event_BaseEvent_SdkProduct_ = JNIEnv.GetMethodID (class_ref, "withSdkProduct", "(Lcom/mopub/common/event/BaseEvent$SdkProduct;)Lcom/mopub/common/event/BaseEvent$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mopub.Common.Event.BaseEvent.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withSdkProduct_Lcom_mopub_common_event_BaseEvent_SdkProduct_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSdkProduct", "(Lcom/mopub/common/event/BaseEvent$SdkProduct;)Lcom/mopub/common/event/BaseEvent$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("com/mopub/common/event/BaseEvent$Builder", DoNotGenerateAcw=true)]
		internal partial class BuilderInvoker : Builder {

			public BuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (BuilderInvoker); }
			}

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/mopub/common/event/BaseEvent;", "GetBuildHandler")]
			public override unsafe global::Com.Mopub.Common.Event.BaseEvent Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/mopub/common/event/BaseEvent;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Category']"
		[global::Android.Runtime.Register ("com/mopub/common/event/BaseEvent$Category", DoNotGenerateAcw=true)]
		public sealed partial class Category : global::Java.Lang.Enum {


			static IntPtr REQUESTS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Category']/field[@name='REQUESTS']"
			[Register ("REQUESTS")]
			public static global::Com.Mopub.Common.Event.BaseEvent.Category Requests {
				get {
					if (REQUESTS_jfieldId == IntPtr.Zero)
						REQUESTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REQUESTS", "Lcom/mopub/common/event/BaseEvent$Category;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REQUESTS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Category> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/event/BaseEvent$Category", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Category); }
			}

			internal Category (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getCategory;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Category']/method[@name='getCategory' and count(parameter)=0]"
			[Register ("getCategory", "()Ljava/lang/String;", "")]
			public unsafe string GetCategory ()
			{
				if (id_getCategory == IntPtr.Zero)
					id_getCategory = JNIEnv.GetMethodID (class_ref, "getCategory", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCategory), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Category']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$Category;", "")]
			public static unsafe global::Com.Mopub.Common.Event.BaseEvent.Category ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$Category;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mopub.Common.Event.BaseEvent.Category __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Category> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Category']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/common/event/BaseEvent$Category;", "")]
			public static unsafe global::Com.Mopub.Common.Event.BaseEvent.Category[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/common/event/BaseEvent$Category;");
				try {
					return (global::Com.Mopub.Common.Event.BaseEvent.Category[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Common.Event.BaseEvent.Category));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Name']"
		[global::Android.Runtime.Register ("com/mopub/common/event/BaseEvent$Name", DoNotGenerateAcw=true)]
		public sealed partial class Name : global::Java.Lang.Enum {


			static IntPtr AD_REQUEST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Name']/field[@name='AD_REQUEST']"
			[Register ("AD_REQUEST")]
			public static global::Com.Mopub.Common.Event.BaseEvent.Name AdRequest {
				get {
					if (AD_REQUEST_jfieldId == IntPtr.Zero)
						AD_REQUEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AD_REQUEST", "Lcom/mopub/common/event/BaseEvent$Name;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AD_REQUEST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Name> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CLICK_REQUEST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Name']/field[@name='CLICK_REQUEST']"
			[Register ("CLICK_REQUEST")]
			public static global::Com.Mopub.Common.Event.BaseEvent.Name ClickRequest {
				get {
					if (CLICK_REQUEST_jfieldId == IntPtr.Zero)
						CLICK_REQUEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLICK_REQUEST", "Lcom/mopub/common/event/BaseEvent$Name;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLICK_REQUEST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Name> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr IMPRESSION_REQUEST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Name']/field[@name='IMPRESSION_REQUEST']"
			[Register ("IMPRESSION_REQUEST")]
			public static global::Com.Mopub.Common.Event.BaseEvent.Name ImpressionRequest {
				get {
					if (IMPRESSION_REQUEST_jfieldId == IntPtr.Zero)
						IMPRESSION_REQUEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IMPRESSION_REQUEST", "Lcom/mopub/common/event/BaseEvent$Name;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IMPRESSION_REQUEST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Name> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/event/BaseEvent$Name", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Name); }
			}

			internal Name (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getName;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Name']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "")]
			public unsafe string GetName ()
			{
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Name']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$Name;", "")]
			public static unsafe global::Com.Mopub.Common.Event.BaseEvent.Name ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$Name;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mopub.Common.Event.BaseEvent.Name __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Name> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.Name']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/common/event/BaseEvent$Name;", "")]
			public static unsafe global::Com.Mopub.Common.Event.BaseEvent.Name[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/common/event/BaseEvent$Name;");
				try {
					return (global::Com.Mopub.Common.Event.BaseEvent.Name[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Common.Event.BaseEvent.Name));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.SamplingRate']"
		[global::Android.Runtime.Register ("com/mopub/common/event/BaseEvent$SamplingRate", DoNotGenerateAcw=true)]
		public sealed partial class SamplingRate : global::Java.Lang.Enum {


			static IntPtr AD_REQUEST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.SamplingRate']/field[@name='AD_REQUEST']"
			[Register ("AD_REQUEST")]
			public static global::Com.Mopub.Common.Event.BaseEvent.SamplingRate AdRequest {
				get {
					if (AD_REQUEST_jfieldId == IntPtr.Zero)
						AD_REQUEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AD_REQUEST", "Lcom/mopub/common/event/BaseEvent$SamplingRate;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AD_REQUEST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.SamplingRate> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/event/BaseEvent$SamplingRate", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SamplingRate); }
			}

			internal SamplingRate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getSamplingRate;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.SamplingRate']/method[@name='getSamplingRate' and count(parameter)=0]"
			[Register ("getSamplingRate", "()D", "")]
			public unsafe double GetSamplingRate ()
			{
				if (id_getSamplingRate == IntPtr.Zero)
					id_getSamplingRate = JNIEnv.GetMethodID (class_ref, "getSamplingRate", "()D");
				try {
					return JNIEnv.CallDoubleMethod  (Handle, id_getSamplingRate);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.SamplingRate']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$SamplingRate;", "")]
			public static unsafe global::Com.Mopub.Common.Event.BaseEvent.SamplingRate ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$SamplingRate;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mopub.Common.Event.BaseEvent.SamplingRate __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.SamplingRate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.SamplingRate']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/common/event/BaseEvent$SamplingRate;", "")]
			public static unsafe global::Com.Mopub.Common.Event.BaseEvent.SamplingRate[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/common/event/BaseEvent$SamplingRate;");
				try {
					return (global::Com.Mopub.Common.Event.BaseEvent.SamplingRate[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Common.Event.BaseEvent.SamplingRate));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.ScribeCategory']"
		[global::Android.Runtime.Register ("com/mopub/common/event/BaseEvent$ScribeCategory", DoNotGenerateAcw=true)]
		public sealed partial class ScribeCategory : global::Java.Lang.Enum {


			static IntPtr EXCHANGE_CLIENT_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.ScribeCategory']/field[@name='EXCHANGE_CLIENT_ERROR']"
			[Register ("EXCHANGE_CLIENT_ERROR")]
			public static global::Com.Mopub.Common.Event.BaseEvent.ScribeCategory ExchangeClientError {
				get {
					if (EXCHANGE_CLIENT_ERROR_jfieldId == IntPtr.Zero)
						EXCHANGE_CLIENT_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXCHANGE_CLIENT_ERROR", "Lcom/mopub/common/event/BaseEvent$ScribeCategory;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXCHANGE_CLIENT_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.ScribeCategory> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr EXCHANGE_CLIENT_EVENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.ScribeCategory']/field[@name='EXCHANGE_CLIENT_EVENT']"
			[Register ("EXCHANGE_CLIENT_EVENT")]
			public static global::Com.Mopub.Common.Event.BaseEvent.ScribeCategory ExchangeClientEvent {
				get {
					if (EXCHANGE_CLIENT_EVENT_jfieldId == IntPtr.Zero)
						EXCHANGE_CLIENT_EVENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXCHANGE_CLIENT_EVENT", "Lcom/mopub/common/event/BaseEvent$ScribeCategory;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXCHANGE_CLIENT_EVENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.ScribeCategory> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/event/BaseEvent$ScribeCategory", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ScribeCategory); }
			}

			internal ScribeCategory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getCategory;
			public unsafe string Category {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.ScribeCategory']/method[@name='getCategory' and count(parameter)=0]"
				[Register ("getCategory", "()Ljava/lang/String;", "GetGetCategoryHandler")]
				get {
					if (id_getCategory == IntPtr.Zero)
						id_getCategory = JNIEnv.GetMethodID (class_ref, "getCategory", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCategory), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.ScribeCategory']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$ScribeCategory;", "")]
			public static unsafe global::Com.Mopub.Common.Event.BaseEvent.ScribeCategory ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$ScribeCategory;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mopub.Common.Event.BaseEvent.ScribeCategory __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.ScribeCategory> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.ScribeCategory']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/common/event/BaseEvent$ScribeCategory;", "")]
			public static unsafe global::Com.Mopub.Common.Event.BaseEvent.ScribeCategory[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/common/event/BaseEvent$ScribeCategory;");
				try {
					return (global::Com.Mopub.Common.Event.BaseEvent.ScribeCategory[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Common.Event.BaseEvent.ScribeCategory));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.SdkProduct']"
		[global::Android.Runtime.Register ("com/mopub/common/event/BaseEvent$SdkProduct", DoNotGenerateAcw=true)]
		public sealed partial class SdkProduct : global::Java.Lang.Enum {


			static IntPtr NATIVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.SdkProduct']/field[@name='NATIVE']"
			[Register ("NATIVE")]
			public static global::Com.Mopub.Common.Event.BaseEvent.SdkProduct Native {
				get {
					if (NATIVE_jfieldId == IntPtr.Zero)
						NATIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NATIVE", "Lcom/mopub/common/event/BaseEvent$SdkProduct;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NATIVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.SdkProduct> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NONE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.SdkProduct']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Com.Mopub.Common.Event.BaseEvent.SdkProduct None {
				get {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/mopub/common/event/BaseEvent$SdkProduct;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.SdkProduct> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WEB_VIEW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.SdkProduct']/field[@name='WEB_VIEW']"
			[Register ("WEB_VIEW")]
			public static global::Com.Mopub.Common.Event.BaseEvent.SdkProduct WebView {
				get {
					if (WEB_VIEW_jfieldId == IntPtr.Zero)
						WEB_VIEW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WEB_VIEW", "Lcom/mopub/common/event/BaseEvent$SdkProduct;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WEB_VIEW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.SdkProduct> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/event/BaseEvent$SdkProduct", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SdkProduct); }
			}

			internal SdkProduct (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getType;
			public unsafe int Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.SdkProduct']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()I", "GetGetTypeHandler")]
				get {
					if (id_getType == IntPtr.Zero)
						id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
					try {
						return JNIEnv.CallIntMethod  (Handle, id_getType);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.SdkProduct']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$SdkProduct;", "")]
			public static unsafe global::Com.Mopub.Common.Event.BaseEvent.SdkProduct ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/common/event/BaseEvent$SdkProduct;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mopub.Common.Event.BaseEvent.SdkProduct __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.SdkProduct> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent.SdkProduct']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/common/event/BaseEvent$SdkProduct;", "")]
			public static unsafe global::Com.Mopub.Common.Event.BaseEvent.SdkProduct[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/common/event/BaseEvent$SdkProduct;");
				try {
					return (global::Com.Mopub.Common.Event.BaseEvent.SdkProduct[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Common.Event.BaseEvent.SdkProduct));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/event/BaseEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseEvent); }
		}

		protected BaseEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mopub_common_event_BaseEvent_Builder_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/constructor[@name='BaseEvent' and count(parameter)=1 and parameter[1][@type='com.mopub.common.event.BaseEvent.Builder']]"
		[Register (".ctor", "(Lcom/mopub/common/event/BaseEvent$Builder;)V", "")]
		public unsafe BaseEvent (global::Com.Mopub.Common.Event.BaseEvent.Builder p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BaseEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/common/event/BaseEvent$Builder;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/common/event/BaseEvent$Builder;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mopub_common_event_BaseEvent_Builder_ == IntPtr.Zero)
					id_ctor_Lcom_mopub_common_event_BaseEvent_Builder_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/common/event/BaseEvent$Builder;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_common_event_BaseEvent_Builder_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_common_event_BaseEvent_Builder_, __args);
			} finally {
			}
		}

		static Delegate cb_getAdCreativeId;
#pragma warning disable 0169
		static Delegate GetGetAdCreativeIdHandler ()
		{
			if (cb_getAdCreativeId == null)
				cb_getAdCreativeId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdCreativeId);
			return cb_getAdCreativeId;
		}

		static IntPtr n_GetAdCreativeId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdCreativeId);
		}
#pragma warning restore 0169

		static IntPtr id_getAdCreativeId;
		public virtual unsafe string AdCreativeId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getAdCreativeId' and count(parameter)=0]"
			[Register ("getAdCreativeId", "()Ljava/lang/String;", "GetGetAdCreativeIdHandler")]
			get {
				if (id_getAdCreativeId == IntPtr.Zero)
					id_getAdCreativeId = JNIEnv.GetMethodID (class_ref, "getAdCreativeId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAdCreativeId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdCreativeId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdHeightPx;
#pragma warning disable 0169
		static Delegate GetGetAdHeightPxHandler ()
		{
			if (cb_getAdHeightPx == null)
				cb_getAdHeightPx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdHeightPx);
			return cb_getAdHeightPx;
		}

		static IntPtr n_GetAdHeightPx (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdHeightPx);
		}
#pragma warning restore 0169

		static IntPtr id_getAdHeightPx;
		public virtual unsafe global::Java.Lang.Double AdHeightPx {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getAdHeightPx' and count(parameter)=0]"
			[Register ("getAdHeightPx", "()Ljava/lang/Double;", "GetGetAdHeightPxHandler")]
			get {
				if (id_getAdHeightPx == IntPtr.Zero)
					id_getAdHeightPx = JNIEnv.GetMethodID (class_ref, "getAdHeightPx", "()Ljava/lang/Double;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod  (Handle, id_getAdHeightPx), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdHeightPx", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdNetworkType;
#pragma warning disable 0169
		static Delegate GetGetAdNetworkTypeHandler ()
		{
			if (cb_getAdNetworkType == null)
				cb_getAdNetworkType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdNetworkType);
			return cb_getAdNetworkType;
		}

		static IntPtr n_GetAdNetworkType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdNetworkType);
		}
#pragma warning restore 0169

		static IntPtr id_getAdNetworkType;
		public virtual unsafe string AdNetworkType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getAdNetworkType' and count(parameter)=0]"
			[Register ("getAdNetworkType", "()Ljava/lang/String;", "GetGetAdNetworkTypeHandler")]
			get {
				if (id_getAdNetworkType == IntPtr.Zero)
					id_getAdNetworkType = JNIEnv.GetMethodID (class_ref, "getAdNetworkType", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAdNetworkType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdNetworkType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdType;
#pragma warning disable 0169
		static Delegate GetGetAdTypeHandler ()
		{
			if (cb_getAdType == null)
				cb_getAdType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdType);
			return cb_getAdType;
		}

		static IntPtr n_GetAdType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdType);
		}
#pragma warning restore 0169

		static IntPtr id_getAdType;
		public virtual unsafe string AdType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getAdType' and count(parameter)=0]"
			[Register ("getAdType", "()Ljava/lang/String;", "GetGetAdTypeHandler")]
			get {
				if (id_getAdType == IntPtr.Zero)
					id_getAdType = JNIEnv.GetMethodID (class_ref, "getAdType", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAdType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdUnitId;
#pragma warning disable 0169
		static Delegate GetGetAdUnitIdHandler ()
		{
			if (cb_getAdUnitId == null)
				cb_getAdUnitId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdUnitId);
			return cb_getAdUnitId;
		}

		static IntPtr n_GetAdUnitId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdUnitId);
		}
#pragma warning restore 0169

		static IntPtr id_getAdUnitId;
		public virtual unsafe string AdUnitId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getAdUnitId' and count(parameter)=0]"
			[Register ("getAdUnitId", "()Ljava/lang/String;", "GetGetAdUnitIdHandler")]
			get {
				if (id_getAdUnitId == IntPtr.Zero)
					id_getAdUnitId = JNIEnv.GetMethodID (class_ref, "getAdUnitId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAdUnitId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdUnitId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdWidthPx;
#pragma warning disable 0169
		static Delegate GetGetAdWidthPxHandler ()
		{
			if (cb_getAdWidthPx == null)
				cb_getAdWidthPx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdWidthPx);
			return cb_getAdWidthPx;
		}

		static IntPtr n_GetAdWidthPx (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdWidthPx);
		}
#pragma warning restore 0169

		static IntPtr id_getAdWidthPx;
		public virtual unsafe global::Java.Lang.Double AdWidthPx {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getAdWidthPx' and count(parameter)=0]"
			[Register ("getAdWidthPx", "()Ljava/lang/Double;", "GetGetAdWidthPxHandler")]
			get {
				if (id_getAdWidthPx == IntPtr.Zero)
					id_getAdWidthPx = JNIEnv.GetMethodID (class_ref, "getAdWidthPx", "()Ljava/lang/Double;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod  (Handle, id_getAdWidthPx), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdWidthPx", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppName);
		}
#pragma warning restore 0169

		static IntPtr id_getAppName;
		public virtual unsafe string AppName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getAppName' and count(parameter)=0]"
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
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppPackageName);
		}
#pragma warning restore 0169

		static IntPtr id_getAppPackageName;
		public virtual unsafe string AppPackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getAppPackageName' and count(parameter)=0]"
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
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getAppVersion;
		public virtual unsafe string AppVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getAppVersion' and count(parameter)=0]"
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

		static Delegate cb_getClientAdvertisingId;
#pragma warning disable 0169
		static Delegate GetGetClientAdvertisingIdHandler ()
		{
			if (cb_getClientAdvertisingId == null)
				cb_getClientAdvertisingId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientAdvertisingId);
			return cb_getClientAdvertisingId;
		}

		static IntPtr n_GetClientAdvertisingId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientAdvertisingId);
		}
#pragma warning restore 0169

		static IntPtr id_getClientAdvertisingId;
		public virtual unsafe string ClientAdvertisingId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getClientAdvertisingId' and count(parameter)=0]"
			[Register ("getClientAdvertisingId", "()Ljava/lang/String;", "GetGetClientAdvertisingIdHandler")]
			get {
				if (id_getClientAdvertisingId == IntPtr.Zero)
					id_getClientAdvertisingId = JNIEnv.GetMethodID (class_ref, "getClientAdvertisingId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getClientAdvertisingId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientAdvertisingId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClientDoNotTrack;
#pragma warning disable 0169
		static Delegate GetGetClientDoNotTrackHandler ()
		{
			if (cb_getClientDoNotTrack == null)
				cb_getClientDoNotTrack = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientDoNotTrack);
			return cb_getClientDoNotTrack;
		}

		static IntPtr n_GetClientDoNotTrack (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClientDoNotTrack);
		}
#pragma warning restore 0169

		static IntPtr id_getClientDoNotTrack;
		public virtual unsafe global::Java.Lang.Boolean ClientDoNotTrack {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getClientDoNotTrack' and count(parameter)=0]"
			[Register ("getClientDoNotTrack", "()Ljava/lang/Boolean;", "GetGetClientDoNotTrackHandler")]
			get {
				if (id_getClientDoNotTrack == IntPtr.Zero)
					id_getClientDoNotTrack = JNIEnv.GetMethodID (class_ref, "getClientDoNotTrack", "()Ljava/lang/Boolean;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_getClientDoNotTrack), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientDoNotTrack", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceManufacturer);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceManufacturer;
		public virtual unsafe string DeviceManufacturer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getDeviceManufacturer' and count(parameter)=0]"
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
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceModel);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceModel;
		public virtual unsafe string DeviceModel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getDeviceModel' and count(parameter)=0]"
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
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceOsVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceOsVersion;
		public virtual unsafe string DeviceOsVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getDeviceOsVersion' and count(parameter)=0]"
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
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceProduct);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceProduct;
		public virtual unsafe string DeviceProduct {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getDeviceProduct' and count(parameter)=0]"
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
				cb_getDeviceScreenHeightDip = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceScreenHeightDip);
			return cb_getDeviceScreenHeightDip;
		}

		static IntPtr n_GetDeviceScreenHeightDip (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeviceScreenHeightDip);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceScreenHeightDip;
		public virtual unsafe global::Java.Lang.Integer DeviceScreenHeightDip {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getDeviceScreenHeightDip' and count(parameter)=0]"
			[Register ("getDeviceScreenHeightDip", "()Ljava/lang/Integer;", "GetGetDeviceScreenHeightDipHandler")]
			get {
				if (id_getDeviceScreenHeightDip == IntPtr.Zero)
					id_getDeviceScreenHeightDip = JNIEnv.GetMethodID (class_ref, "getDeviceScreenHeightDip", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getDeviceScreenHeightDip), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceScreenHeightDip", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceScreenWidthDip;
#pragma warning disable 0169
		static Delegate GetGetDeviceScreenWidthDipHandler ()
		{
			if (cb_getDeviceScreenWidthDip == null)
				cb_getDeviceScreenWidthDip = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceScreenWidthDip);
			return cb_getDeviceScreenWidthDip;
		}

		static IntPtr n_GetDeviceScreenWidthDip (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeviceScreenWidthDip);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceScreenWidthDip;
		public virtual unsafe global::Java.Lang.Integer DeviceScreenWidthDip {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getDeviceScreenWidthDip' and count(parameter)=0]"
			[Register ("getDeviceScreenWidthDip", "()Ljava/lang/Integer;", "GetGetDeviceScreenWidthDipHandler")]
			get {
				if (id_getDeviceScreenWidthDip == IntPtr.Zero)
					id_getDeviceScreenWidthDip = JNIEnv.GetMethodID (class_ref, "getDeviceScreenWidthDip", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getDeviceScreenWidthDip), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceScreenWidthDip", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGeoAccuracy;
#pragma warning disable 0169
		static Delegate GetGetGeoAccuracyHandler ()
		{
			if (cb_getGeoAccuracy == null)
				cb_getGeoAccuracy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGeoAccuracy);
			return cb_getGeoAccuracy;
		}

		static IntPtr n_GetGeoAccuracy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GeoAccuracy);
		}
#pragma warning restore 0169

		static IntPtr id_getGeoAccuracy;
		public virtual unsafe global::Java.Lang.Double GeoAccuracy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getGeoAccuracy' and count(parameter)=0]"
			[Register ("getGeoAccuracy", "()Ljava/lang/Double;", "GetGetGeoAccuracyHandler")]
			get {
				if (id_getGeoAccuracy == IntPtr.Zero)
					id_getGeoAccuracy = JNIEnv.GetMethodID (class_ref, "getGeoAccuracy", "()Ljava/lang/Double;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod  (Handle, id_getGeoAccuracy), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGeoAccuracy", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGeoLat;
#pragma warning disable 0169
		static Delegate GetGetGeoLatHandler ()
		{
			if (cb_getGeoLat == null)
				cb_getGeoLat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGeoLat);
			return cb_getGeoLat;
		}

		static IntPtr n_GetGeoLat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GeoLat);
		}
#pragma warning restore 0169

		static IntPtr id_getGeoLat;
		public virtual unsafe global::Java.Lang.Double GeoLat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getGeoLat' and count(parameter)=0]"
			[Register ("getGeoLat", "()Ljava/lang/Double;", "GetGetGeoLatHandler")]
			get {
				if (id_getGeoLat == IntPtr.Zero)
					id_getGeoLat = JNIEnv.GetMethodID (class_ref, "getGeoLat", "()Ljava/lang/Double;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod  (Handle, id_getGeoLat), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGeoLat", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGeoLon;
#pragma warning disable 0169
		static Delegate GetGetGeoLonHandler ()
		{
			if (cb_getGeoLon == null)
				cb_getGeoLon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGeoLon);
			return cb_getGeoLon;
		}

		static IntPtr n_GetGeoLon (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GeoLon);
		}
#pragma warning restore 0169

		static IntPtr id_getGeoLon;
		public virtual unsafe global::Java.Lang.Double GeoLon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getGeoLon' and count(parameter)=0]"
			[Register ("getGeoLon", "()Ljava/lang/Double;", "GetGetGeoLonHandler")]
			get {
				if (id_getGeoLon == IntPtr.Zero)
					id_getGeoLon = JNIEnv.GetMethodID (class_ref, "getGeoLon", "()Ljava/lang/Double;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod  (Handle, id_getGeoLon), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGeoLon", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNetworkIsoCountryCode;
#pragma warning disable 0169
		static Delegate GetGetNetworkIsoCountryCodeHandler ()
		{
			if (cb_getNetworkIsoCountryCode == null)
				cb_getNetworkIsoCountryCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetworkIsoCountryCode);
			return cb_getNetworkIsoCountryCode;
		}

		static IntPtr n_GetNetworkIsoCountryCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NetworkIsoCountryCode);
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkIsoCountryCode;
		public virtual unsafe string NetworkIsoCountryCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getNetworkIsoCountryCode' and count(parameter)=0]"
			[Register ("getNetworkIsoCountryCode", "()Ljava/lang/String;", "GetGetNetworkIsoCountryCodeHandler")]
			get {
				if (id_getNetworkIsoCountryCode == IntPtr.Zero)
					id_getNetworkIsoCountryCode = JNIEnv.GetMethodID (class_ref, "getNetworkIsoCountryCode", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNetworkIsoCountryCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetworkIsoCountryCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNetworkOperatorCode;
#pragma warning disable 0169
		static Delegate GetGetNetworkOperatorCodeHandler ()
		{
			if (cb_getNetworkOperatorCode == null)
				cb_getNetworkOperatorCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetworkOperatorCode);
			return cb_getNetworkOperatorCode;
		}

		static IntPtr n_GetNetworkOperatorCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NetworkOperatorCode);
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkOperatorCode;
		public virtual unsafe string NetworkOperatorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getNetworkOperatorCode' and count(parameter)=0]"
			[Register ("getNetworkOperatorCode", "()Ljava/lang/String;", "GetGetNetworkOperatorCodeHandler")]
			get {
				if (id_getNetworkOperatorCode == IntPtr.Zero)
					id_getNetworkOperatorCode = JNIEnv.GetMethodID (class_ref, "getNetworkOperatorCode", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNetworkOperatorCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetworkOperatorCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NetworkOperatorName);
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkOperatorName;
		public virtual unsafe string NetworkOperatorName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getNetworkOperatorName' and count(parameter)=0]"
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

		static Delegate cb_getNetworkSimCode;
#pragma warning disable 0169
		static Delegate GetGetNetworkSimCodeHandler ()
		{
			if (cb_getNetworkSimCode == null)
				cb_getNetworkSimCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetworkSimCode);
			return cb_getNetworkSimCode;
		}

		static IntPtr n_GetNetworkSimCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NetworkSimCode);
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkSimCode;
		public virtual unsafe string NetworkSimCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getNetworkSimCode' and count(parameter)=0]"
			[Register ("getNetworkSimCode", "()Ljava/lang/String;", "GetGetNetworkSimCodeHandler")]
			get {
				if (id_getNetworkSimCode == IntPtr.Zero)
					id_getNetworkSimCode = JNIEnv.GetMethodID (class_ref, "getNetworkSimCode", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNetworkSimCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetworkSimCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNetworkSimIsoCountryCode;
#pragma warning disable 0169
		static Delegate GetGetNetworkSimIsoCountryCodeHandler ()
		{
			if (cb_getNetworkSimIsoCountryCode == null)
				cb_getNetworkSimIsoCountryCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetworkSimIsoCountryCode);
			return cb_getNetworkSimIsoCountryCode;
		}

		static IntPtr n_GetNetworkSimIsoCountryCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NetworkSimIsoCountryCode);
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkSimIsoCountryCode;
		public virtual unsafe string NetworkSimIsoCountryCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getNetworkSimIsoCountryCode' and count(parameter)=0]"
			[Register ("getNetworkSimIsoCountryCode", "()Ljava/lang/String;", "GetGetNetworkSimIsoCountryCodeHandler")]
			get {
				if (id_getNetworkSimIsoCountryCode == IntPtr.Zero)
					id_getNetworkSimIsoCountryCode = JNIEnv.GetMethodID (class_ref, "getNetworkSimIsoCountryCode", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNetworkSimIsoCountryCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetworkSimIsoCountryCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNetworkSimOperatorName;
#pragma warning disable 0169
		static Delegate GetGetNetworkSimOperatorNameHandler ()
		{
			if (cb_getNetworkSimOperatorName == null)
				cb_getNetworkSimOperatorName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetworkSimOperatorName);
			return cb_getNetworkSimOperatorName;
		}

		static IntPtr n_GetNetworkSimOperatorName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NetworkSimOperatorName);
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkSimOperatorName;
		public virtual unsafe string NetworkSimOperatorName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getNetworkSimOperatorName' and count(parameter)=0]"
			[Register ("getNetworkSimOperatorName", "()Ljava/lang/String;", "GetGetNetworkSimOperatorNameHandler")]
			get {
				if (id_getNetworkSimOperatorName == IntPtr.Zero)
					id_getNetworkSimOperatorName = JNIEnv.GetMethodID (class_ref, "getNetworkSimOperatorName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNetworkSimOperatorName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetworkSimOperatorName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNetworkType;
#pragma warning disable 0169
		static Delegate GetGetNetworkTypeHandler ()
		{
			if (cb_getNetworkType == null)
				cb_getNetworkType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetworkType);
			return cb_getNetworkType;
		}

		static IntPtr n_GetNetworkType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NetworkType);
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkType;
		public virtual unsafe global::Com.Mopub.Common.ClientMetadata.MoPubNetworkType NetworkType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getNetworkType' and count(parameter)=0]"
			[Register ("getNetworkType", "()Lcom/mopub/common/ClientMetadata$MoPubNetworkType;", "GetGetNetworkTypeHandler")]
			get {
				if (id_getNetworkType == IntPtr.Zero)
					id_getNetworkType = JNIEnv.GetMethodID (class_ref, "getNetworkType", "()Lcom/mopub/common/ClientMetadata$MoPubNetworkType;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata.MoPubNetworkType> (JNIEnv.CallObjectMethod  (Handle, id_getNetworkType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ClientMetadata.MoPubNetworkType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetworkType", "()Lcom/mopub/common/ClientMetadata$MoPubNetworkType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getObfuscatedClientAdvertisingId;
#pragma warning disable 0169
		static Delegate GetGetObfuscatedClientAdvertisingIdHandler ()
		{
			if (cb_getObfuscatedClientAdvertisingId == null)
				cb_getObfuscatedClientAdvertisingId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetObfuscatedClientAdvertisingId);
			return cb_getObfuscatedClientAdvertisingId;
		}

		static IntPtr n_GetObfuscatedClientAdvertisingId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ObfuscatedClientAdvertisingId);
		}
#pragma warning restore 0169

		static IntPtr id_getObfuscatedClientAdvertisingId;
		public virtual unsafe string ObfuscatedClientAdvertisingId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getObfuscatedClientAdvertisingId' and count(parameter)=0]"
			[Register ("getObfuscatedClientAdvertisingId", "()Ljava/lang/String;", "GetGetObfuscatedClientAdvertisingIdHandler")]
			get {
				if (id_getObfuscatedClientAdvertisingId == IntPtr.Zero)
					id_getObfuscatedClientAdvertisingId = JNIEnv.GetMethodID (class_ref, "getObfuscatedClientAdvertisingId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getObfuscatedClientAdvertisingId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getObfuscatedClientAdvertisingId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPerformanceDurationMs;
#pragma warning disable 0169
		static Delegate GetGetPerformanceDurationMsHandler ()
		{
			if (cb_getPerformanceDurationMs == null)
				cb_getPerformanceDurationMs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPerformanceDurationMs);
			return cb_getPerformanceDurationMs;
		}

		static IntPtr n_GetPerformanceDurationMs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PerformanceDurationMs);
		}
#pragma warning restore 0169

		static IntPtr id_getPerformanceDurationMs;
		public virtual unsafe global::Java.Lang.Double PerformanceDurationMs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getPerformanceDurationMs' and count(parameter)=0]"
			[Register ("getPerformanceDurationMs", "()Ljava/lang/Double;", "GetGetPerformanceDurationMsHandler")]
			get {
				if (id_getPerformanceDurationMs == IntPtr.Zero)
					id_getPerformanceDurationMs = JNIEnv.GetMethodID (class_ref, "getPerformanceDurationMs", "()Ljava/lang/Double;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod  (Handle, id_getPerformanceDurationMs), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPerformanceDurationMs", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestId;
#pragma warning disable 0169
		static Delegate GetGetRequestIdHandler ()
		{
			if (cb_getRequestId == null)
				cb_getRequestId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestId);
			return cb_getRequestId;
		}

		static IntPtr n_GetRequestId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestId);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestId;
		public virtual unsafe string RequestId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getRequestId' and count(parameter)=0]"
			[Register ("getRequestId", "()Ljava/lang/String;", "GetGetRequestIdHandler")]
			get {
				if (id_getRequestId == IntPtr.Zero)
					id_getRequestId = JNIEnv.GetMethodID (class_ref, "getRequestId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRequestId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestRetries;
#pragma warning disable 0169
		static Delegate GetGetRequestRetriesHandler ()
		{
			if (cb_getRequestRetries == null)
				cb_getRequestRetries = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestRetries);
			return cb_getRequestRetries;
		}

		static IntPtr n_GetRequestRetries (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestRetries);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestRetries;
		public virtual unsafe global::Java.Lang.Integer RequestRetries {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getRequestRetries' and count(parameter)=0]"
			[Register ("getRequestRetries", "()Ljava/lang/Integer;", "GetGetRequestRetriesHandler")]
			get {
				if (id_getRequestRetries == IntPtr.Zero)
					id_getRequestRetries = JNIEnv.GetMethodID (class_ref, "getRequestRetries", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getRequestRetries), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestRetries", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestStatusCode;
#pragma warning disable 0169
		static Delegate GetGetRequestStatusCodeHandler ()
		{
			if (cb_getRequestStatusCode == null)
				cb_getRequestStatusCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestStatusCode);
			return cb_getRequestStatusCode;
		}

		static IntPtr n_GetRequestStatusCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestStatusCode);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestStatusCode;
		public virtual unsafe global::Java.Lang.Integer RequestStatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getRequestStatusCode' and count(parameter)=0]"
			[Register ("getRequestStatusCode", "()Ljava/lang/Integer;", "GetGetRequestStatusCodeHandler")]
			get {
				if (id_getRequestStatusCode == IntPtr.Zero)
					id_getRequestStatusCode = JNIEnv.GetMethodID (class_ref, "getRequestStatusCode", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getRequestStatusCode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestStatusCode", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestUri;
#pragma warning disable 0169
		static Delegate GetGetRequestUriHandler ()
		{
			if (cb_getRequestUri == null)
				cb_getRequestUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestUri);
			return cb_getRequestUri;
		}

		static IntPtr n_GetRequestUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestUri);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestUri;
		public virtual unsafe string RequestUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getRequestUri' and count(parameter)=0]"
			[Register ("getRequestUri", "()Ljava/lang/String;", "GetGetRequestUriHandler")]
			get {
				if (id_getRequestUri == IntPtr.Zero)
					id_getRequestUri = JNIEnv.GetMethodID (class_ref, "getRequestUri", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRequestUri), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestUri", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SdkVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getSdkVersion;
		public virtual unsafe string SdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getSdkVersion' and count(parameter)=0]"
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

		static Delegate cb_getTimestampUtcMs;
#pragma warning disable 0169
		static Delegate GetGetTimestampUtcMsHandler ()
		{
			if (cb_getTimestampUtcMs == null)
				cb_getTimestampUtcMs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimestampUtcMs);
			return cb_getTimestampUtcMs;
		}

		static IntPtr n_GetTimestampUtcMs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TimestampUtcMs);
		}
#pragma warning restore 0169

		static IntPtr id_getTimestampUtcMs;
		public virtual unsafe global::Java.Lang.Long TimestampUtcMs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getTimestampUtcMs' and count(parameter)=0]"
			[Register ("getTimestampUtcMs", "()Ljava/lang/Long;", "GetGetTimestampUtcMsHandler")]
			get {
				if (id_getTimestampUtcMs == IntPtr.Zero)
					id_getTimestampUtcMs = JNIEnv.GetMethodID (class_ref, "getTimestampUtcMs", "()Ljava/lang/Long;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_getTimestampUtcMs), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimestampUtcMs", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAppPlatform;
#pragma warning disable 0169
		static Delegate GetGetAppPlatformHandler ()
		{
			if (cb_getAppPlatform == null)
				cb_getAppPlatform = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppPlatform);
			return cb_getAppPlatform;
		}

		static IntPtr n_GetAppPlatform (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetAppPlatform ());
		}
#pragma warning restore 0169

		static IntPtr id_getAppPlatform;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getAppPlatform' and count(parameter)=0]"
		[Register ("getAppPlatform", "()Lcom/mopub/common/event/BaseEvent$AppPlatform;", "GetGetAppPlatformHandler")]
		public virtual unsafe global::Com.Mopub.Common.Event.BaseEvent.AppPlatform GetAppPlatform ()
		{
			if (id_getAppPlatform == IntPtr.Zero)
				id_getAppPlatform = JNIEnv.GetMethodID (class_ref, "getAppPlatform", "()Lcom/mopub/common/event/BaseEvent$AppPlatform;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.AppPlatform> (JNIEnv.CallObjectMethod  (Handle, id_getAppPlatform), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.AppPlatform> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppPlatform", "()Lcom/mopub/common/event/BaseEvent$AppPlatform;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getCategory;
#pragma warning disable 0169
		static Delegate GetGetCategoryHandler ()
		{
			if (cb_getCategory == null)
				cb_getCategory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCategory);
			return cb_getCategory;
		}

		static IntPtr n_GetCategory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetCategory ());
		}
#pragma warning restore 0169

		static IntPtr id_getCategory;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getCategory' and count(parameter)=0]"
		[Register ("getCategory", "()Lcom/mopub/common/event/BaseEvent$Category;", "GetGetCategoryHandler")]
		public virtual unsafe global::Com.Mopub.Common.Event.BaseEvent.Category GetCategory ()
		{
			if (id_getCategory == IntPtr.Zero)
				id_getCategory = JNIEnv.GetMethodID (class_ref, "getCategory", "()Lcom/mopub/common/event/BaseEvent$Category;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Category> (JNIEnv.CallObjectMethod  (Handle, id_getCategory), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Category> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCategory", "()Lcom/mopub/common/event/BaseEvent$Category;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetName ());
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getName' and count(parameter)=0]"
		[Register ("getName", "()Lcom/mopub/common/event/BaseEvent$Name;", "GetGetNameHandler")]
		public virtual unsafe global::Com.Mopub.Common.Event.BaseEvent.Name GetName ()
		{
			if (id_getName == IntPtr.Zero)
				id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Lcom/mopub/common/event/BaseEvent$Name;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Name> (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.Name> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Lcom/mopub/common/event/BaseEvent$Name;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getSamplingRate;
#pragma warning disable 0169
		static Delegate GetGetSamplingRateHandler ()
		{
			if (cb_getSamplingRate == null)
				cb_getSamplingRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetSamplingRate);
			return cb_getSamplingRate;
		}

		static double n_GetSamplingRate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetSamplingRate ();
		}
#pragma warning restore 0169

		static IntPtr id_getSamplingRate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getSamplingRate' and count(parameter)=0]"
		[Register ("getSamplingRate", "()D", "GetGetSamplingRateHandler")]
		public virtual unsafe double GetSamplingRate ()
		{
			if (id_getSamplingRate == IntPtr.Zero)
				id_getSamplingRate = JNIEnv.GetMethodID (class_ref, "getSamplingRate", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getSamplingRate);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSamplingRate", "()D"));
			} finally {
			}
		}

		static Delegate cb_getScribeCategory;
#pragma warning disable 0169
		static Delegate GetGetScribeCategoryHandler ()
		{
			if (cb_getScribeCategory == null)
				cb_getScribeCategory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScribeCategory);
			return cb_getScribeCategory;
		}

		static IntPtr n_GetScribeCategory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetScribeCategory ());
		}
#pragma warning restore 0169

		static IntPtr id_getScribeCategory;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getScribeCategory' and count(parameter)=0]"
		[Register ("getScribeCategory", "()Lcom/mopub/common/event/BaseEvent$ScribeCategory;", "GetGetScribeCategoryHandler")]
		public virtual unsafe global::Com.Mopub.Common.Event.BaseEvent.ScribeCategory GetScribeCategory ()
		{
			if (id_getScribeCategory == IntPtr.Zero)
				id_getScribeCategory = JNIEnv.GetMethodID (class_ref, "getScribeCategory", "()Lcom/mopub/common/event/BaseEvent$ScribeCategory;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.ScribeCategory> (JNIEnv.CallObjectMethod  (Handle, id_getScribeCategory), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.ScribeCategory> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScribeCategory", "()Lcom/mopub/common/event/BaseEvent$ScribeCategory;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getSdkProduct;
#pragma warning disable 0169
		static Delegate GetGetSdkProductHandler ()
		{
			if (cb_getSdkProduct == null)
				cb_getSdkProduct = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSdkProduct);
			return cb_getSdkProduct;
		}

		static IntPtr n_GetSdkProduct (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.BaseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetSdkProduct ());
		}
#pragma warning restore 0169

		static IntPtr id_getSdkProduct;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='BaseEvent']/method[@name='getSdkProduct' and count(parameter)=0]"
		[Register ("getSdkProduct", "()Lcom/mopub/common/event/BaseEvent$SdkProduct;", "GetGetSdkProductHandler")]
		public virtual unsafe global::Com.Mopub.Common.Event.BaseEvent.SdkProduct GetSdkProduct ()
		{
			if (id_getSdkProduct == IntPtr.Zero)
				id_getSdkProduct = JNIEnv.GetMethodID (class_ref, "getSdkProduct", "()Lcom/mopub/common/event/BaseEvent$SdkProduct;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.SdkProduct> (JNIEnv.CallObjectMethod  (Handle, id_getSdkProduct), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent.SdkProduct> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSdkProduct", "()Lcom/mopub/common/event/BaseEvent$SdkProduct;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/mopub/common/event/BaseEvent", DoNotGenerateAcw=true)]
	internal partial class BaseEventInvoker : BaseEvent {

		public BaseEventInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseEventInvoker); }
		}

	}

}
