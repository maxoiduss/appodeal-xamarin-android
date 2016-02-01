using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Factories {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='MoPubViewFactory']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/factories/MoPubViewFactory", DoNotGenerateAcw=true)]
	public partial class MoPubViewFactory : global::Java.Lang.Object {


		static IntPtr instance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='MoPubViewFactory']/field[@name='instance']"
		[Register ("instance")]
		protected static global::Com.Mopub.Mobileads.Factories.MoPubViewFactory Instance {
			get {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/mobileads/factories/MoPubViewFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, instance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.MoPubViewFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/mobileads/factories/MoPubViewFactory;");
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
				return JNIEnv.FindClass ("com/mopub/mobileads/factories/MoPubViewFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoPubViewFactory); }
		}

		protected MoPubViewFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='MoPubViewFactory']/constructor[@name='MoPubViewFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MoPubViewFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MoPubViewFactory)) {
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

		static IntPtr id_create_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='MoPubViewFactory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("create", "(Landroid/content/Context;)Lcom/mopub/mobileads/MoPubView;", "")]
		public static unsafe global::Com.Mopub.Mobileads.MoPubView Create (global::Android.Content.Context p0)
		{
			if (id_create_Landroid_content_Context_ == IntPtr.Zero)
				id_create_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Landroid/content/Context;)Lcom/mopub/mobileads/MoPubView;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Mopub.Mobileads.MoPubView __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_internalCreate_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInternalCreate_Landroid_content_Context_Handler ()
		{
			if (cb_internalCreate_Landroid_content_Context_ == null)
				cb_internalCreate_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InternalCreate_Landroid_content_Context_);
			return cb_internalCreate_Landroid_content_Context_;
		}

		static IntPtr n_InternalCreate_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.Factories.MoPubViewFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.MoPubViewFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InternalCreate (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_internalCreate_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='MoPubViewFactory']/method[@name='internalCreate' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("internalCreate", "(Landroid/content/Context;)Lcom/mopub/mobileads/MoPubView;", "GetInternalCreate_Landroid_content_Context_Handler")]
		protected virtual unsafe global::Com.Mopub.Mobileads.MoPubView InternalCreate (global::Android.Content.Context p0)
		{
			if (id_internalCreate_Landroid_content_Context_ == IntPtr.Zero)
				id_internalCreate_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "internalCreate", "(Landroid/content/Context;)Lcom/mopub/mobileads/MoPubView;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mopub.Mobileads.MoPubView __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (JNIEnv.CallObjectMethod  (Handle, id_internalCreate_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "internalCreate", "(Landroid/content/Context;)Lcom/mopub/mobileads/MoPubView;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setInstance_Lcom_mopub_mobileads_factories_MoPubViewFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='MoPubViewFactory']/method[@name='setInstance' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.factories.MoPubViewFactory']]"
		[Obsolete (@"deprecated")]
		[Register ("setInstance", "(Lcom/mopub/mobileads/factories/MoPubViewFactory;)V", "")]
		public static unsafe void SetInstance (global::Com.Mopub.Mobileads.Factories.MoPubViewFactory p0)
		{
			if (id_setInstance_Lcom_mopub_mobileads_factories_MoPubViewFactory_ == IntPtr.Zero)
				id_setInstance_Lcom_mopub_mobileads_factories_MoPubViewFactory_ = JNIEnv.GetStaticMethodID (class_ref, "setInstance", "(Lcom/mopub/mobileads/factories/MoPubViewFactory;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setInstance_Lcom_mopub_mobileads_factories_MoPubViewFactory_, __args);
			} finally {
			}
		}

	}
}
