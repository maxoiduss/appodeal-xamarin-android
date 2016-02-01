using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Factories {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.factories']/class[@name='MethodBuilderFactory']"
	[global::Android.Runtime.Register ("com/mopub/common/factories/MethodBuilderFactory", DoNotGenerateAcw=true)]
	public partial class MethodBuilderFactory : global::Java.Lang.Object {


		static IntPtr instance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.factories']/class[@name='MethodBuilderFactory']/field[@name='instance']"
		[Register ("instance")]
		protected static global::Com.Mopub.Common.Factories.MethodBuilderFactory Instance {
			get {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/common/factories/MethodBuilderFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, instance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Factories.MethodBuilderFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/common/factories/MethodBuilderFactory;");
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
				return JNIEnv.FindClass ("com/mopub/common/factories/MethodBuilderFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MethodBuilderFactory); }
		}

		protected MethodBuilderFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common.factories']/class[@name='MethodBuilderFactory']/constructor[@name='MethodBuilderFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MethodBuilderFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MethodBuilderFactory)) {
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

		static IntPtr id_create_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.factories']/class[@name='MethodBuilderFactory']/method[@name='create' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("create", "(Ljava/lang/Object;Ljava/lang/String;)Lcom/mopub/common/util/Reflection$MethodBuilder;", "")]
		public static unsafe global::Com.Mopub.Common.Util.Reflection.MethodBuilder Create (global::Java.Lang.Object p0, string p1)
		{
			if (id_create_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_create_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/Object;Ljava/lang/String;)Lcom/mopub/common/util/Reflection$MethodBuilder;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Mopub.Common.Util.Reflection.MethodBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.Reflection.MethodBuilder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_Object_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_internalCreate_Ljava_lang_Object_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInternalCreate_Ljava_lang_Object_Ljava_lang_String_Handler ()
		{
			if (cb_internalCreate_Ljava_lang_Object_Ljava_lang_String_ == null)
				cb_internalCreate_Ljava_lang_Object_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InternalCreate_Ljava_lang_Object_Ljava_lang_String_);
			return cb_internalCreate_Ljava_lang_Object_Ljava_lang_String_;
		}

		static IntPtr n_InternalCreate_Ljava_lang_Object_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Common.Factories.MethodBuilderFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Factories.MethodBuilderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InternalCreate (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_internalCreate_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.factories']/class[@name='MethodBuilderFactory']/method[@name='internalCreate' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("internalCreate", "(Ljava/lang/Object;Ljava/lang/String;)Lcom/mopub/common/util/Reflection$MethodBuilder;", "GetInternalCreate_Ljava_lang_Object_Ljava_lang_String_Handler")]
		protected virtual unsafe global::Com.Mopub.Common.Util.Reflection.MethodBuilder InternalCreate (global::Java.Lang.Object p0, string p1)
		{
			if (id_internalCreate_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_internalCreate_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "internalCreate", "(Ljava/lang/Object;Ljava/lang/String;)Lcom/mopub/common/util/Reflection$MethodBuilder;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Com.Mopub.Common.Util.Reflection.MethodBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.Reflection.MethodBuilder> (JNIEnv.CallObjectMethod  (Handle, id_internalCreate_Ljava_lang_Object_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.Reflection.MethodBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "internalCreate", "(Ljava/lang/Object;Ljava/lang/String;)Lcom/mopub/common/util/Reflection$MethodBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setInstance_Lcom_mopub_common_factories_MethodBuilderFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.factories']/class[@name='MethodBuilderFactory']/method[@name='setInstance' and count(parameter)=1 and parameter[1][@type='com.mopub.common.factories.MethodBuilderFactory']]"
		[Obsolete (@"deprecated")]
		[Register ("setInstance", "(Lcom/mopub/common/factories/MethodBuilderFactory;)V", "")]
		public static unsafe void SetInstance (global::Com.Mopub.Common.Factories.MethodBuilderFactory p0)
		{
			if (id_setInstance_Lcom_mopub_common_factories_MethodBuilderFactory_ == IntPtr.Zero)
				id_setInstance_Lcom_mopub_common_factories_MethodBuilderFactory_ = JNIEnv.GetStaticMethodID (class_ref, "setInstance", "(Lcom/mopub/common/factories/MethodBuilderFactory;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setInstance_Lcom_mopub_common_factories_MethodBuilderFactory_, __args);
			} finally {
			}
		}

	}
}
