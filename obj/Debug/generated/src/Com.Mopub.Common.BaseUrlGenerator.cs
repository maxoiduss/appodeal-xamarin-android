using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseUrlGenerator']"
	[global::Android.Runtime.Register ("com/mopub/common/BaseUrlGenerator", DoNotGenerateAcw=true)]
	public abstract partial class BaseUrlGenerator : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/BaseUrlGenerator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseUrlGenerator); }
		}

		protected BaseUrlGenerator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseUrlGenerator']/constructor[@name='BaseUrlGenerator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseUrlGenerator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BaseUrlGenerator)) {
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

		static Delegate cb_getFinalUrlString;
#pragma warning disable 0169
		static Delegate GetGetFinalUrlStringHandler ()
		{
			if (cb_getFinalUrlString == null)
				cb_getFinalUrlString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFinalUrlString);
			return cb_getFinalUrlString;
		}

		static IntPtr n_GetFinalUrlString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.BaseUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.BaseUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FinalUrlString);
		}
#pragma warning restore 0169

		static IntPtr id_getFinalUrlString;
		protected virtual unsafe string FinalUrlString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseUrlGenerator']/method[@name='getFinalUrlString' and count(parameter)=0]"
			[Register ("getFinalUrlString", "()Ljava/lang/String;", "GetGetFinalUrlStringHandler")]
			get {
				if (id_getFinalUrlString == IntPtr.Zero)
					id_getFinalUrlString = JNIEnv.GetMethodID (class_ref, "getFinalUrlString", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFinalUrlString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFinalUrlString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addParam_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddParam_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addParam_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addParam_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddParam_Ljava_lang_String_Ljava_lang_String_);
			return cb_addParam_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddParam_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Common.BaseUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.BaseUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddParam (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addParam_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseUrlGenerator']/method[@name='addParam' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addParam", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddParam_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe void AddParam (string p0, string p1)
		{
			if (id_addParam_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addParam_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addParam", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addParam_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addParam", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_appendAdvertisingInfoTemplates;
#pragma warning disable 0169
		static Delegate GetAppendAdvertisingInfoTemplatesHandler ()
		{
			if (cb_appendAdvertisingInfoTemplates == null)
				cb_appendAdvertisingInfoTemplates = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AppendAdvertisingInfoTemplates);
			return cb_appendAdvertisingInfoTemplates;
		}

		static void n_AppendAdvertisingInfoTemplates (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.BaseUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.BaseUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AppendAdvertisingInfoTemplates ();
		}
#pragma warning restore 0169

		static IntPtr id_appendAdvertisingInfoTemplates;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseUrlGenerator']/method[@name='appendAdvertisingInfoTemplates' and count(parameter)=0]"
		[Register ("appendAdvertisingInfoTemplates", "()V", "GetAppendAdvertisingInfoTemplatesHandler")]
		protected virtual unsafe void AppendAdvertisingInfoTemplates ()
		{
			if (id_appendAdvertisingInfoTemplates == IntPtr.Zero)
				id_appendAdvertisingInfoTemplates = JNIEnv.GetMethodID (class_ref, "appendAdvertisingInfoTemplates", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_appendAdvertisingInfoTemplates);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendAdvertisingInfoTemplates", "()V"));
			} finally {
			}
		}

		static Delegate cb_generateUrlString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGenerateUrlString_Ljava_lang_String_Handler ()
		{
			if (cb_generateUrlString_Ljava_lang_String_ == null)
				cb_generateUrlString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GenerateUrlString_Ljava_lang_String_);
			return cb_generateUrlString_Ljava_lang_String_;
		}

		static IntPtr n_GenerateUrlString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.BaseUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.BaseUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateUrlString (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseUrlGenerator']/method[@name='generateUrlString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("generateUrlString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGenerateUrlString_Ljava_lang_String_Handler")]
		public abstract string GenerateUrlString (string p0);

		static Delegate cb_initUrlString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInitUrlString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_initUrlString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_initUrlString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_InitUrlString_Ljava_lang_String_Ljava_lang_String_);
			return cb_initUrlString_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_InitUrlString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Common.BaseUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.BaseUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.InitUrlString (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_initUrlString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseUrlGenerator']/method[@name='initUrlString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("initUrlString", "(Ljava/lang/String;Ljava/lang/String;)V", "GetInitUrlString_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe void InitUrlString (string p0, string p1)
		{
			if (id_initUrlString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_initUrlString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "initUrlString", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_initUrlString_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initUrlString", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setApiVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetApiVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setApiVersion_Ljava_lang_String_ == null)
				cb_setApiVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetApiVersion_Ljava_lang_String_);
			return cb_setApiVersion_Ljava_lang_String_;
		}

		static void n_SetApiVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.BaseUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.BaseUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetApiVersion (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setApiVersion_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseUrlGenerator']/method[@name='setApiVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setApiVersion", "(Ljava/lang/String;)V", "GetSetApiVersion_Ljava_lang_String_Handler")]
		protected virtual unsafe void SetApiVersion (string p0)
		{
			if (id_setApiVersion_Ljava_lang_String_ == IntPtr.Zero)
				id_setApiVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApiVersion", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setApiVersion_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setApiVersion", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setAppVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setAppVersion_Ljava_lang_String_ == null)
				cb_setAppVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppVersion_Ljava_lang_String_);
			return cb_setAppVersion_Ljava_lang_String_;
		}

		static void n_SetAppVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.BaseUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.BaseUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAppVersion (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAppVersion_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseUrlGenerator']/method[@name='setAppVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAppVersion", "(Ljava/lang/String;)V", "GetSetAppVersion_Ljava_lang_String_Handler")]
		protected virtual unsafe void SetAppVersion (string p0)
		{
			if (id_setAppVersion_Ljava_lang_String_ == IntPtr.Zero)
				id_setAppVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppVersion", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAppVersion_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppVersion", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setDeviceDimensions_Landroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetSetDeviceDimensions_Landroid_graphics_Point_Handler ()
		{
			if (cb_setDeviceDimensions_Landroid_graphics_Point_ == null)
				cb_setDeviceDimensions_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDeviceDimensions_Landroid_graphics_Point_);
			return cb_setDeviceDimensions_Landroid_graphics_Point_;
		}

		static void n_SetDeviceDimensions_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.BaseUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.BaseUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDeviceDimensions (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDeviceDimensions_Landroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseUrlGenerator']/method[@name='setDeviceDimensions' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
		[Register ("setDeviceDimensions", "(Landroid/graphics/Point;)V", "GetSetDeviceDimensions_Landroid_graphics_Point_Handler")]
		protected virtual unsafe void SetDeviceDimensions (global::Android.Graphics.Point p0)
		{
			if (id_setDeviceDimensions_Landroid_graphics_Point_ == IntPtr.Zero)
				id_setDeviceDimensions_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "setDeviceDimensions", "(Landroid/graphics/Point;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDeviceDimensions_Landroid_graphics_Point_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDeviceDimensions", "(Landroid/graphics/Point;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDeviceInfo_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceInfo_arrayLjava_lang_String_Handler ()
		{
			if (cb_setDeviceInfo_arrayLjava_lang_String_ == null)
				cb_setDeviceInfo_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDeviceInfo_arrayLjava_lang_String_);
			return cb_setDeviceInfo_arrayLjava_lang_String_;
		}

		static void n_SetDeviceInfo_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.BaseUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.BaseUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetDeviceInfo (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDeviceInfo_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseUrlGenerator']/method[@name='setDeviceInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("setDeviceInfo", "([Ljava/lang/String;)V", "GetSetDeviceInfo_arrayLjava_lang_String_Handler")]
		protected virtual unsafe void SetDeviceInfo (params  string[] p0)
		{
			if (id_setDeviceInfo_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setDeviceInfo_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDeviceInfo", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDeviceInfo_arrayLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDeviceInfo", "([Ljava/lang/String;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setDoNotTrack_Z;
#pragma warning disable 0169
		static Delegate GetSetDoNotTrack_ZHandler ()
		{
			if (cb_setDoNotTrack_Z == null)
				cb_setDoNotTrack_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDoNotTrack_Z);
			return cb_setDoNotTrack_Z;
		}

		static void n_SetDoNotTrack_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mopub.Common.BaseUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.BaseUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDoNotTrack (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDoNotTrack_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseUrlGenerator']/method[@name='setDoNotTrack' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDoNotTrack", "(Z)V", "GetSetDoNotTrack_ZHandler")]
		protected virtual unsafe void SetDoNotTrack (bool p0)
		{
			if (id_setDoNotTrack_Z == IntPtr.Zero)
				id_setDoNotTrack_Z = JNIEnv.GetMethodID (class_ref, "setDoNotTrack", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDoNotTrack_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDoNotTrack", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setExternalStoragePermission_Z;
#pragma warning disable 0169
		static Delegate GetSetExternalStoragePermission_ZHandler ()
		{
			if (cb_setExternalStoragePermission_Z == null)
				cb_setExternalStoragePermission_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetExternalStoragePermission_Z);
			return cb_setExternalStoragePermission_Z;
		}

		static void n_SetExternalStoragePermission_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mopub.Common.BaseUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.BaseUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetExternalStoragePermission (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setExternalStoragePermission_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseUrlGenerator']/method[@name='setExternalStoragePermission' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setExternalStoragePermission", "(Z)V", "GetSetExternalStoragePermission_ZHandler")]
		protected virtual unsafe void SetExternalStoragePermission (bool p0)
		{
			if (id_setExternalStoragePermission_Z == IntPtr.Zero)
				id_setExternalStoragePermission_Z = JNIEnv.GetMethodID (class_ref, "setExternalStoragePermission", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setExternalStoragePermission_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExternalStoragePermission", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setUdid_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUdid_Ljava_lang_String_Handler ()
		{
			if (cb_setUdid_Ljava_lang_String_ == null)
				cb_setUdid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUdid_Ljava_lang_String_);
			return cb_setUdid_Ljava_lang_String_;
		}

		static void n_SetUdid_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.BaseUrlGenerator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.BaseUrlGenerator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetUdid (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setUdid_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseUrlGenerator']/method[@name='setUdid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUdid", "(Ljava/lang/String;)V", "GetSetUdid_Ljava_lang_String_Handler")]
		protected virtual unsafe void SetUdid (string p0)
		{
			if (id_setUdid_Ljava_lang_String_ == IntPtr.Zero)
				id_setUdid_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUdid", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUdid_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUdid", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	[global::Android.Runtime.Register ("com/mopub/common/BaseUrlGenerator", DoNotGenerateAcw=true)]
	internal partial class BaseUrlGeneratorInvoker : BaseUrlGenerator {

		public BaseUrlGeneratorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseUrlGeneratorInvoker); }
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
