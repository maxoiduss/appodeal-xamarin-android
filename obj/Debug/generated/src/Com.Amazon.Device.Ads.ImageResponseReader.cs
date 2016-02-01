using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Device.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ImageResponseReader']"
	[global::Android.Runtime.Register ("com/amazon/device/ads/ImageResponseReader", DoNotGenerateAcw=true)]
	public partial class ImageResponseReader : global::Com.Amazon.Device.Ads.ResponseReader {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/device/ads/ImageResponseReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageResponseReader); }
		}

		protected ImageResponseReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getInputStream;
#pragma warning disable 0169
		static Delegate GetGetInputStreamHandler ()
		{
			if (cb_getInputStream == null)
				cb_getInputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputStream);
			return cb_getInputStream;
		}

		static IntPtr n_GetInputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.ImageResponseReader __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.ImageResponseReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		static IntPtr id_getInputStream;
		public override unsafe global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ImageResponseReader']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler")]
			get {
				if (id_getInputStream == IntPtr.Zero)
					id_getInputStream = JNIEnv.GetMethodID (class_ref, "getInputStream", "()Ljava/io/InputStream;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getInputStream), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputStream", "()Ljava/io/InputStream;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_enableLog_Z;
#pragma warning disable 0169
		static Delegate GetEnableLog_ZHandler ()
		{
			if (cb_enableLog_Z == null)
				cb_enableLog_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_EnableLog_Z);
			return cb_enableLog_Z;
		}

		static void n_EnableLog_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amazon.Device.Ads.ImageResponseReader __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.ImageResponseReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableLog (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enableLog_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ImageResponseReader']/method[@name='enableLog' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableLog", "(Z)V", "GetEnableLog_ZHandler")]
		public override unsafe void EnableLog (bool p0)
		{
			if (id_enableLog_Z == IntPtr.Zero)
				id_enableLog_Z = JNIEnv.GetMethodID (class_ref, "enableLog", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_enableLog_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableLog", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_readAsBitmap;
#pragma warning disable 0169
		static Delegate GetReadAsBitmapHandler ()
		{
			if (cb_readAsBitmap == null)
				cb_readAsBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadAsBitmap);
			return cb_readAsBitmap;
		}

		static IntPtr n_ReadAsBitmap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.ImageResponseReader __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.ImageResponseReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadAsBitmap ());
		}
#pragma warning restore 0169

		static IntPtr id_readAsBitmap;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ImageResponseReader']/method[@name='readAsBitmap' and count(parameter)=0]"
		[Register ("readAsBitmap", "()Landroid/graphics/Bitmap;", "GetReadAsBitmapHandler")]
		public virtual unsafe global::Android.Graphics.Bitmap ReadAsBitmap ()
		{
			if (id_readAsBitmap == IntPtr.Zero)
				id_readAsBitmap = JNIEnv.GetMethodID (class_ref, "readAsBitmap", "()Landroid/graphics/Bitmap;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_readAsBitmap), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readAsBitmap", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readAsJSON;
#pragma warning disable 0169
		static Delegate GetReadAsJSONHandler ()
		{
			if (cb_readAsJSON == null)
				cb_readAsJSON = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadAsJSON);
			return cb_readAsJSON;
		}

		static IntPtr n_ReadAsJSON (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.ImageResponseReader __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.ImageResponseReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadAsJSON ());
		}
#pragma warning restore 0169

		static IntPtr id_readAsJSON;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ImageResponseReader']/method[@name='readAsJSON' and count(parameter)=0]"
		[Register ("readAsJSON", "()Lorg/json/JSONObject;", "GetReadAsJSONHandler")]
		public override unsafe global::Org.Json.JSONObject ReadAsJSON ()
		{
			if (id_readAsJSON == IntPtr.Zero)
				id_readAsJSON = JNIEnv.GetMethodID (class_ref, "readAsJSON", "()Lorg/json/JSONObject;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_readAsJSON), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readAsJSON", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readAsString;
#pragma warning disable 0169
		static Delegate GetReadAsStringHandler ()
		{
			if (cb_readAsString == null)
				cb_readAsString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadAsString);
			return cb_readAsString;
		}

		static IntPtr n_ReadAsString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.ImageResponseReader __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.ImageResponseReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReadAsString ());
		}
#pragma warning restore 0169

		static IntPtr id_readAsString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ImageResponseReader']/method[@name='readAsString' and count(parameter)=0]"
		[Register ("readAsString", "()Ljava/lang/String;", "GetReadAsStringHandler")]
		public override unsafe string ReadAsString ()
		{
			if (id_readAsString == IntPtr.Zero)
				id_readAsString = JNIEnv.GetMethodID (class_ref, "readAsString", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_readAsString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readAsString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setExternalLogTag_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExternalLogTag_Ljava_lang_String_Handler ()
		{
			if (cb_setExternalLogTag_Ljava_lang_String_ == null)
				cb_setExternalLogTag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExternalLogTag_Ljava_lang_String_);
			return cb_setExternalLogTag_Ljava_lang_String_;
		}

		static void n_SetExternalLogTag_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Device.Ads.ImageResponseReader __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.ImageResponseReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetExternalLogTag (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setExternalLogTag_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='ImageResponseReader']/method[@name='setExternalLogTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setExternalLogTag", "(Ljava/lang/String;)V", "GetSetExternalLogTag_Ljava_lang_String_Handler")]
		public override unsafe void SetExternalLogTag (string p0)
		{
			if (id_setExternalLogTag_Ljava_lang_String_ == IntPtr.Zero)
				id_setExternalLogTag_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setExternalLogTag", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setExternalLogTag_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExternalLogTag", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
