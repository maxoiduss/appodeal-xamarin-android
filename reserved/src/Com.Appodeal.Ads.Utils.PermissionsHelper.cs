using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appodeal.ads.utils']/class[@name='PermissionsHelper']"
	[global::Android.Runtime.Register ("com/appodeal/ads/utils/PermissionsHelper", DoNotGenerateAcw=true)]
	public partial class PermissionsHelper : global::Java.Lang.Object {


		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads.utils']/class[@name='PermissionsHelper']/field[@name='b']"
		[Register ("b")]
		public static bool B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, b_jfieldId);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, b_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.appodeal.ads.utils']/interface[@name='PermissionsHelper.AppodealPermissionCallbacks']"
		[Register ("com/appodeal/ads/utils/PermissionsHelper$AppodealPermissionCallbacks", "", "Com.Appodeal.Ads.Utils.PermissionsHelper/IAppodealPermissionCallbacksInvoker")]
		public partial interface IAppodealPermissionCallbacks : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads.utils']/interface[@name='PermissionsHelper.AppodealPermissionCallbacks']/method[@name='accessCoarseLocationResponse' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("accessCoarseLocationResponse", "(I)V", "GetAccessCoarseLocationResponse_IHandler:Com.Appodeal.Ads.Utils.PermissionsHelper/IAppodealPermissionCallbacksInvoker, AppodealXamarinPlugin")]
			void AccessCoarseLocationResponse (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads.utils']/interface[@name='PermissionsHelper.AppodealPermissionCallbacks']/method[@name='writeExternalStorageResponse' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("writeExternalStorageResponse", "(I)V", "GetWriteExternalStorageResponse_IHandler:Com.Appodeal.Ads.Utils.PermissionsHelper/IAppodealPermissionCallbacksInvoker, AppodealXamarinPlugin")]
			void WriteExternalStorageResponse (int p0);

		}

		[global::Android.Runtime.Register ("com/appodeal/ads/utils/PermissionsHelper$AppodealPermissionCallbacks", DoNotGenerateAcw=true)]
		internal class IAppodealPermissionCallbacksInvoker : global::Java.Lang.Object, IAppodealPermissionCallbacks {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/appodeal/ads/utils/PermissionsHelper$AppodealPermissionCallbacks");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IAppodealPermissionCallbacksInvoker); }
			}

			IntPtr class_ref;

			public static IAppodealPermissionCallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAppodealPermissionCallbacks> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.appodeal.ads.utils.PermissionsHelper.AppodealPermissionCallbacks"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAppodealPermissionCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_accessCoarseLocationResponse_I;
#pragma warning disable 0169
			static Delegate GetAccessCoarseLocationResponse_IHandler ()
			{
				if (cb_accessCoarseLocationResponse_I == null)
					cb_accessCoarseLocationResponse_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_AccessCoarseLocationResponse_I);
				return cb_accessCoarseLocationResponse_I;
			}

			static void n_AccessCoarseLocationResponse_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Appodeal.Ads.Utils.PermissionsHelper.IAppodealPermissionCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Utils.PermissionsHelper.IAppodealPermissionCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.AccessCoarseLocationResponse (p0);
			}
#pragma warning restore 0169

			IntPtr id_accessCoarseLocationResponse_I;
			public unsafe void AccessCoarseLocationResponse (int p0)
			{
				if (id_accessCoarseLocationResponse_I == IntPtr.Zero)
					id_accessCoarseLocationResponse_I = JNIEnv.GetMethodID (class_ref, "accessCoarseLocationResponse", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_accessCoarseLocationResponse_I, __args);
			}

			static Delegate cb_writeExternalStorageResponse_I;
#pragma warning disable 0169
			static Delegate GetWriteExternalStorageResponse_IHandler ()
			{
				if (cb_writeExternalStorageResponse_I == null)
					cb_writeExternalStorageResponse_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_WriteExternalStorageResponse_I);
				return cb_writeExternalStorageResponse_I;
			}

			static void n_WriteExternalStorageResponse_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Appodeal.Ads.Utils.PermissionsHelper.IAppodealPermissionCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Utils.PermissionsHelper.IAppodealPermissionCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.WriteExternalStorageResponse (p0);
			}
#pragma warning restore 0169

			IntPtr id_writeExternalStorageResponse_I;
			public unsafe void WriteExternalStorageResponse (int p0)
			{
				if (id_writeExternalStorageResponse_I == IntPtr.Zero)
					id_writeExternalStorageResponse_I = JNIEnv.GetMethodID (class_ref, "writeExternalStorageResponse", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_writeExternalStorageResponse_I, __args);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/appodeal/ads/utils/PermissionsHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PermissionsHelper); }
		}

		protected PermissionsHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.appodeal.ads.utils']/class[@name='PermissionsHelper']/constructor[@name='PermissionsHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PermissionsHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PermissionsHelper)) {
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

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads.utils']/class[@name='PermissionsHelper']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lcom/appodeal/ads/utils/PermissionsHelper;", "")]
		public static unsafe global::Com.Appodeal.Ads.Utils.PermissionsHelper A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()Lcom/appodeal/ads/utils/PermissionsHelper;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Utils.PermissionsHelper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_a_Landroid_app_Activity_Lcom_appodeal_ads_utils_PermissionsHelper_AppodealPermissionCallbacks_;
#pragma warning disable 0169
		static Delegate GetA_Landroid_app_Activity_Lcom_appodeal_ads_utils_PermissionsHelper_AppodealPermissionCallbacks_Handler ()
		{
			if (cb_a_Landroid_app_Activity_Lcom_appodeal_ads_utils_PermissionsHelper_AppodealPermissionCallbacks_ == null)
				cb_a_Landroid_app_Activity_Lcom_appodeal_ads_utils_PermissionsHelper_AppodealPermissionCallbacks_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Landroid_app_Activity_Lcom_appodeal_ads_utils_PermissionsHelper_AppodealPermissionCallbacks_);
			return cb_a_Landroid_app_Activity_Lcom_appodeal_ads_utils_PermissionsHelper_AppodealPermissionCallbacks_;
		}

		static void n_A_Landroid_app_Activity_Lcom_appodeal_ads_utils_PermissionsHelper_AppodealPermissionCallbacks_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Appodeal.Ads.Utils.PermissionsHelper __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Utils.PermissionsHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Appodeal.Ads.Utils.PermissionsHelper.IAppodealPermissionCallbacks p1 = (global::Com.Appodeal.Ads.Utils.PermissionsHelper.IAppodealPermissionCallbacks)global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Utils.PermissionsHelper.IAppodealPermissionCallbacks> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_a_Landroid_app_Activity_Lcom_appodeal_ads_utils_PermissionsHelper_AppodealPermissionCallbacks_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads.utils']/class[@name='PermissionsHelper']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.appodeal.ads.utils.PermissionsHelper.AppodealPermissionCallbacks']]"
		[Register ("a", "(Landroid/app/Activity;Lcom/appodeal/ads/utils/PermissionsHelper$AppodealPermissionCallbacks;)V", "GetA_Landroid_app_Activity_Lcom_appodeal_ads_utils_PermissionsHelper_AppodealPermissionCallbacks_Handler")]
		public virtual unsafe void A (global::Android.App.Activity p0, global::Com.Appodeal.Ads.Utils.PermissionsHelper.IAppodealPermissionCallbacks p1)
		{
			if (id_a_Landroid_app_Activity_Lcom_appodeal_ads_utils_PermissionsHelper_AppodealPermissionCallbacks_ == IntPtr.Zero)
				id_a_Landroid_app_Activity_Lcom_appodeal_ads_utils_PermissionsHelper_AppodealPermissionCallbacks_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/app/Activity;Lcom/appodeal/ads/utils/PermissionsHelper$AppodealPermissionCallbacks;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_a_Landroid_app_Activity_Lcom_appodeal_ads_utils_PermissionsHelper_AppodealPermissionCallbacks_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Landroid/app/Activity;Lcom/appodeal/ads/utils/PermissionsHelper$AppodealPermissionCallbacks;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_a_II;
#pragma warning disable 0169
		static Delegate GetA_IIHandler ()
		{
			if (cb_a_II == null)
				cb_a_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_A_II);
			return cb_a_II;
		}

		static void n_A_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Appodeal.Ads.Utils.PermissionsHelper __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Utils.PermissionsHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_a_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads.utils']/class[@name='PermissionsHelper']/method[@name='a' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("a", "(II)V", "GetA_IIHandler")]
		public virtual unsafe void A (int p0, int p1)
		{
			if (id_a_II == IntPtr.Zero)
				id_a_II = JNIEnv.GetMethodID (class_ref, "a", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_a_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(II)V"), __args);
			} finally {
			}
		}

	}
}
