using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Factories {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='MraidControllerFactory']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/factories/MraidControllerFactory", DoNotGenerateAcw=true)]
	public partial class MraidControllerFactory : global::Java.Lang.Object {


		static IntPtr instance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='MraidControllerFactory']/field[@name='instance']"
		[Register ("instance")]
		protected static global::Com.Mopub.Mobileads.Factories.MraidControllerFactory Instance {
			get {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/mobileads/factories/MraidControllerFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, instance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.MraidControllerFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/mobileads/factories/MraidControllerFactory;");
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
				return JNIEnv.FindClass ("com/mopub/mobileads/factories/MraidControllerFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MraidControllerFactory); }
		}

		protected MraidControllerFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='MraidControllerFactory']/constructor[@name='MraidControllerFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MraidControllerFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MraidControllerFactory)) {
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

		static IntPtr id_create_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mraid_PlacementType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='MraidControllerFactory']/method[@name='create' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.common.AdReport'] and parameter[3][@type='com.mopub.mraid.PlacementType']]"
		[Register ("create", "(Landroid/content/Context;Lcom/mopub/common/AdReport;Lcom/mopub/mraid/PlacementType;)Lcom/mopub/mraid/MraidController;", "")]
		public static unsafe global::Com.Mopub.Mraid.MraidController Create (global::Android.Content.Context p0, global::Com.Mopub.Common.AdReport p1, global::Com.Mopub.Mraid.PlacementType p2)
		{
			if (id_create_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mraid_PlacementType_ == IntPtr.Zero)
				id_create_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mraid_PlacementType_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Landroid/content/Context;Lcom/mopub/common/AdReport;Lcom/mopub/mraid/PlacementType;)Lcom/mopub/mraid/MraidController;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Mopub.Mraid.MraidController __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidController> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mraid_PlacementType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_internalCreate_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mraid_PlacementType_;
#pragma warning disable 0169
		static Delegate GetInternalCreate_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mraid_PlacementType_Handler ()
		{
			if (cb_internalCreate_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mraid_PlacementType_ == null)
				cb_internalCreate_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mraid_PlacementType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InternalCreate_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mraid_PlacementType_);
			return cb_internalCreate_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mraid_PlacementType_;
		}

		static IntPtr n_InternalCreate_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mraid_PlacementType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mopub.Mobileads.Factories.MraidControllerFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.MraidControllerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Common.AdReport p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdReport> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mraid.PlacementType p2 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.PlacementType> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InternalCreate (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_internalCreate_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mraid_PlacementType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='MraidControllerFactory']/method[@name='internalCreate' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.common.AdReport'] and parameter[3][@type='com.mopub.mraid.PlacementType']]"
		[Register ("internalCreate", "(Landroid/content/Context;Lcom/mopub/common/AdReport;Lcom/mopub/mraid/PlacementType;)Lcom/mopub/mraid/MraidController;", "GetInternalCreate_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mraid_PlacementType_Handler")]
		protected virtual unsafe global::Com.Mopub.Mraid.MraidController InternalCreate (global::Android.Content.Context p0, global::Com.Mopub.Common.AdReport p1, global::Com.Mopub.Mraid.PlacementType p2)
		{
			if (id_internalCreate_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mraid_PlacementType_ == IntPtr.Zero)
				id_internalCreate_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mraid_PlacementType_ = JNIEnv.GetMethodID (class_ref, "internalCreate", "(Landroid/content/Context;Lcom/mopub/common/AdReport;Lcom/mopub/mraid/PlacementType;)Lcom/mopub/mraid/MraidController;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Com.Mopub.Mraid.MraidController __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidController> (JNIEnv.CallObjectMethod  (Handle, id_internalCreate_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mraid_PlacementType_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidController> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "internalCreate", "(Landroid/content/Context;Lcom/mopub/common/AdReport;Lcom/mopub/mraid/PlacementType;)Lcom/mopub/mraid/MraidController;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setInstance_Lcom_mopub_mobileads_factories_MraidControllerFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='MraidControllerFactory']/method[@name='setInstance' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.factories.MraidControllerFactory']]"
		[Register ("setInstance", "(Lcom/mopub/mobileads/factories/MraidControllerFactory;)V", "")]
		public static unsafe void SetInstance (global::Com.Mopub.Mobileads.Factories.MraidControllerFactory p0)
		{
			if (id_setInstance_Lcom_mopub_mobileads_factories_MraidControllerFactory_ == IntPtr.Zero)
				id_setInstance_Lcom_mopub_mobileads_factories_MraidControllerFactory_ = JNIEnv.GetStaticMethodID (class_ref, "setInstance", "(Lcom/mopub/mobileads/factories/MraidControllerFactory;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setInstance_Lcom_mopub_mobileads_factories_MraidControllerFactory_, __args);
			} finally {
			}
		}

	}
}
