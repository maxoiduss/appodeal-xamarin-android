using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Factories {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='AdViewControllerFactory']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/factories/AdViewControllerFactory", DoNotGenerateAcw=true)]
	public partial class AdViewControllerFactory : global::Java.Lang.Object {


		static IntPtr instance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='AdViewControllerFactory']/field[@name='instance']"
		[Register ("instance")]
		protected static global::Com.Mopub.Mobileads.Factories.AdViewControllerFactory Instance {
			get {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/mobileads/factories/AdViewControllerFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, instance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.AdViewControllerFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/mobileads/factories/AdViewControllerFactory;");
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
				return JNIEnv.FindClass ("com/mopub/mobileads/factories/AdViewControllerFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdViewControllerFactory); }
		}

		protected AdViewControllerFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='AdViewControllerFactory']/constructor[@name='AdViewControllerFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AdViewControllerFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AdViewControllerFactory)) {
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

		static IntPtr id_create_Landroid_content_Context_Lcom_mopub_mobileads_MoPubView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='AdViewControllerFactory']/method[@name='create' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.mobileads.MoPubView']]"
		[Register ("create", "(Landroid/content/Context;Lcom/mopub/mobileads/MoPubView;)Lcom/mopub/mobileads/AdViewController;", "")]
		public static unsafe global::Com.Mopub.Mobileads.AdViewController Create (global::Android.Content.Context p0, global::Com.Mopub.Mobileads.MoPubView p1)
		{
			if (id_create_Landroid_content_Context_Lcom_mopub_mobileads_MoPubView_ == IntPtr.Zero)
				id_create_Landroid_content_Context_Lcom_mopub_mobileads_MoPubView_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Landroid/content/Context;Lcom/mopub/mobileads/MoPubView;)Lcom/mopub/mobileads/AdViewController;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Mopub.Mobileads.AdViewController __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Landroid_content_Context_Lcom_mopub_mobileads_MoPubView_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_internalCreate_Landroid_content_Context_Lcom_mopub_mobileads_MoPubView_;
#pragma warning disable 0169
		static Delegate GetInternalCreate_Landroid_content_Context_Lcom_mopub_mobileads_MoPubView_Handler ()
		{
			if (cb_internalCreate_Landroid_content_Context_Lcom_mopub_mobileads_MoPubView_ == null)
				cb_internalCreate_Landroid_content_Context_Lcom_mopub_mobileads_MoPubView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InternalCreate_Landroid_content_Context_Lcom_mopub_mobileads_MoPubView_);
			return cb_internalCreate_Landroid_content_Context_Lcom_mopub_mobileads_MoPubView_;
		}

		static IntPtr n_InternalCreate_Landroid_content_Context_Lcom_mopub_mobileads_MoPubView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Mobileads.Factories.AdViewControllerFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.AdViewControllerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubView p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubView> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InternalCreate (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_internalCreate_Landroid_content_Context_Lcom_mopub_mobileads_MoPubView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='AdViewControllerFactory']/method[@name='internalCreate' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.mobileads.MoPubView']]"
		[Register ("internalCreate", "(Landroid/content/Context;Lcom/mopub/mobileads/MoPubView;)Lcom/mopub/mobileads/AdViewController;", "GetInternalCreate_Landroid_content_Context_Lcom_mopub_mobileads_MoPubView_Handler")]
		protected virtual unsafe global::Com.Mopub.Mobileads.AdViewController InternalCreate (global::Android.Content.Context p0, global::Com.Mopub.Mobileads.MoPubView p1)
		{
			if (id_internalCreate_Landroid_content_Context_Lcom_mopub_mobileads_MoPubView_ == IntPtr.Zero)
				id_internalCreate_Landroid_content_Context_Lcom_mopub_mobileads_MoPubView_ = JNIEnv.GetMethodID (class_ref, "internalCreate", "(Landroid/content/Context;Lcom/mopub/mobileads/MoPubView;)Lcom/mopub/mobileads/AdViewController;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Mopub.Mobileads.AdViewController __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (JNIEnv.CallObjectMethod  (Handle, id_internalCreate_Landroid_content_Context_Lcom_mopub_mobileads_MoPubView_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdViewController> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "internalCreate", "(Landroid/content/Context;Lcom/mopub/mobileads/MoPubView;)Lcom/mopub/mobileads/AdViewController;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setInstance_Lcom_mopub_mobileads_factories_AdViewControllerFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='AdViewControllerFactory']/method[@name='setInstance' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.factories.AdViewControllerFactory']]"
		[Obsolete (@"deprecated")]
		[Register ("setInstance", "(Lcom/mopub/mobileads/factories/AdViewControllerFactory;)V", "")]
		public static unsafe void SetInstance (global::Com.Mopub.Mobileads.Factories.AdViewControllerFactory p0)
		{
			if (id_setInstance_Lcom_mopub_mobileads_factories_AdViewControllerFactory_ == IntPtr.Zero)
				id_setInstance_Lcom_mopub_mobileads_factories_AdViewControllerFactory_ = JNIEnv.GetStaticMethodID (class_ref, "setInstance", "(Lcom/mopub/mobileads/factories/AdViewControllerFactory;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setInstance_Lcom_mopub_mobileads_factories_AdViewControllerFactory_, __args);
			} finally {
			}
		}

	}
}
