using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='HttpResponses']"
	[global::Android.Runtime.Register ("com/mopub/common/HttpResponses", DoNotGenerateAcw=true)]
	public sealed partial class HttpResponses : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/HttpResponses", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpResponses); }
		}

		internal HttpResponses (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_asBitmap_Lcom_mopub_common_DownloadResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='HttpResponses']/method[@name='asBitmap' and count(parameter)=1 and parameter[1][@type='com.mopub.common.DownloadResponse']]"
		[Register ("asBitmap", "(Lcom/mopub/common/DownloadResponse;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap AsBitmap (global::Com.Mopub.Common.DownloadResponse p0)
		{
			if (id_asBitmap_Lcom_mopub_common_DownloadResponse_ == IntPtr.Zero)
				id_asBitmap_Lcom_mopub_common_DownloadResponse_ = JNIEnv.GetStaticMethodID (class_ref, "asBitmap", "(Lcom/mopub/common/DownloadResponse;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asBitmap_Lcom_mopub_common_DownloadResponse_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_asJsonObject_Lcom_mopub_common_DownloadResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='HttpResponses']/method[@name='asJsonObject' and count(parameter)=1 and parameter[1][@type='com.mopub.common.DownloadResponse']]"
		[Register ("asJsonObject", "(Lcom/mopub/common/DownloadResponse;)Lorg/json/JSONObject;", "")]
		public static unsafe global::Org.Json.JSONObject AsJsonObject (global::Com.Mopub.Common.DownloadResponse p0)
		{
			if (id_asJsonObject_Lcom_mopub_common_DownloadResponse_ == IntPtr.Zero)
				id_asJsonObject_Lcom_mopub_common_DownloadResponse_ = JNIEnv.GetStaticMethodID (class_ref, "asJsonObject", "(Lcom/mopub/common/DownloadResponse;)Lorg/json/JSONObject;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asJsonObject_Lcom_mopub_common_DownloadResponse_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_asResponseString_Lcom_mopub_common_DownloadResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='HttpResponses']/method[@name='asResponseString' and count(parameter)=1 and parameter[1][@type='com.mopub.common.DownloadResponse']]"
		[Register ("asResponseString", "(Lcom/mopub/common/DownloadResponse;)Ljava/lang/String;", "")]
		public static unsafe string AsResponseString (global::Com.Mopub.Common.DownloadResponse p0)
		{
			if (id_asResponseString_Lcom_mopub_common_DownloadResponse_ == IntPtr.Zero)
				id_asResponseString_Lcom_mopub_common_DownloadResponse_ = JNIEnv.GetStaticMethodID (class_ref, "asResponseString", "(Lcom/mopub/common/DownloadResponse;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_asResponseString_Lcom_mopub_common_DownloadResponse_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
