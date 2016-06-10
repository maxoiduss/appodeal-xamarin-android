using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Json']"
	[global::Android.Runtime.Register ("com/mopub/common/util/Json", DoNotGenerateAcw=true)]
	public partial class Json : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/util/Json", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Json); }
		}

		protected Json (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Json']/constructor[@name='Json' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Json ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Json)) {
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

		static IntPtr id_getJsonValue_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Json']/method[@name='getJsonValue' and count(parameter)=3 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class']]"
		[Register ("getJsonValue", "(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object GetJsonValue (global::Org.Json.JSONObject p0, string p1, global::Java.Lang.Class p2)
		{
			if (id_getJsonValue_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
				id_getJsonValue_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getJsonValue", "(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getJsonValue_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_jsonArrayToStringArray_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Json']/method[@name='jsonArrayToStringArray' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("jsonArrayToStringArray", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] JsonArrayToStringArray (string p0)
		{
			if (id_jsonArrayToStringArray_Ljava_lang_String_ == IntPtr.Zero)
				id_jsonArrayToStringArray_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "jsonArrayToStringArray", "(Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_jsonArrayToStringArray_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_jsonStringToMap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Json']/method[@name='jsonStringToMap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("jsonStringToMap", "(Ljava/lang/String;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.IDictionary JsonStringToMap (string p0)
		{
			if (id_jsonStringToMap_Ljava_lang_String_ == IntPtr.Zero)
				id_jsonStringToMap_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "jsonStringToMap", "(Ljava/lang/String;)Ljava/util/Map;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.Collections.IDictionary __ret = global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_jsonStringToMap_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_mapToJsonString_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Json']/method[@name='mapToJsonString' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
		[Register ("mapToJsonString", "(Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string MapToJsonString (global::System.Collections.IDictionary p0)
		{
			if (id_mapToJsonString_Ljava_util_Map_ == IntPtr.Zero)
				id_mapToJsonString_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "mapToJsonString", "(Ljava/util/Map;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_mapToJsonString_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
