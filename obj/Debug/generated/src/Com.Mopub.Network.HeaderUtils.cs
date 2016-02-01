using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.network']/class[@name='HeaderUtils']"
	[global::Android.Runtime.Register ("com/mopub/network/HeaderUtils", DoNotGenerateAcw=true)]
	public partial class HeaderUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/network/HeaderUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HeaderUtils); }
		}

		protected HeaderUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.network']/class[@name='HeaderUtils']/constructor[@name='HeaderUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HeaderUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HeaderUtils)) {
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

		static IntPtr id_extractBooleanHeader_Ljava_util_Map_Lcom_mopub_common_util_ResponseHeader_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='HeaderUtils']/method[@name='extractBooleanHeader' and count(parameter)=3 and parameter[1][@type='java.util.Map'] and parameter[2][@type='com.mopub.common.util.ResponseHeader'] and parameter[3][@type='boolean']]"
		[Register ("extractBooleanHeader", "(Ljava/util/Map;Lcom/mopub/common/util/ResponseHeader;Z)Z", "")]
		public static unsafe bool ExtractBooleanHeader (global::System.Collections.IDictionary p0, global::Com.Mopub.Common.Util.ResponseHeader p1, bool p2)
		{
			if (id_extractBooleanHeader_Ljava_util_Map_Lcom_mopub_common_util_ResponseHeader_Z == IntPtr.Zero)
				id_extractBooleanHeader_Ljava_util_Map_Lcom_mopub_common_util_ResponseHeader_Z = JNIEnv.GetStaticMethodID (class_ref, "extractBooleanHeader", "(Ljava/util/Map;Lcom/mopub/common/util/ResponseHeader;Z)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_extractBooleanHeader_Ljava_util_Map_Lcom_mopub_common_util_ResponseHeader_Z, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_extractBooleanHeader_Lorg_apache_http_HttpResponse_Lcom_mopub_common_util_ResponseHeader_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='HeaderUtils']/method[@name='extractBooleanHeader' and count(parameter)=3 and parameter[1][@type='org.apache.http.HttpResponse'] and parameter[2][@type='com.mopub.common.util.ResponseHeader'] and parameter[3][@type='boolean']]"
		[Register ("extractBooleanHeader", "(Lorg/apache/http/HttpResponse;Lcom/mopub/common/util/ResponseHeader;Z)Z", "")]
		public static unsafe bool ExtractBooleanHeader (global::Org.Apache.Http.IHttpResponse p0, global::Com.Mopub.Common.Util.ResponseHeader p1, bool p2)
		{
			if (id_extractBooleanHeader_Lorg_apache_http_HttpResponse_Lcom_mopub_common_util_ResponseHeader_Z == IntPtr.Zero)
				id_extractBooleanHeader_Lorg_apache_http_HttpResponse_Lcom_mopub_common_util_ResponseHeader_Z = JNIEnv.GetStaticMethodID (class_ref, "extractBooleanHeader", "(Lorg/apache/http/HttpResponse;Lcom/mopub/common/util/ResponseHeader;Z)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_extractBooleanHeader_Lorg_apache_http_HttpResponse_Lcom_mopub_common_util_ResponseHeader_Z, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_extractHeader_Ljava_util_Map_Lcom_mopub_common_util_ResponseHeader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='HeaderUtils']/method[@name='extractHeader' and count(parameter)=2 and parameter[1][@type='java.util.Map'] and parameter[2][@type='com.mopub.common.util.ResponseHeader']]"
		[Register ("extractHeader", "(Ljava/util/Map;Lcom/mopub/common/util/ResponseHeader;)Ljava/lang/String;", "")]
		public static unsafe string ExtractHeader (global::System.Collections.IDictionary p0, global::Com.Mopub.Common.Util.ResponseHeader p1)
		{
			if (id_extractHeader_Ljava_util_Map_Lcom_mopub_common_util_ResponseHeader_ == IntPtr.Zero)
				id_extractHeader_Ljava_util_Map_Lcom_mopub_common_util_ResponseHeader_ = JNIEnv.GetStaticMethodID (class_ref, "extractHeader", "(Ljava/util/Map;Lcom/mopub/common/util/ResponseHeader;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_extractHeader_Ljava_util_Map_Lcom_mopub_common_util_ResponseHeader_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_extractHeader_Lorg_apache_http_HttpResponse_Lcom_mopub_common_util_ResponseHeader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='HeaderUtils']/method[@name='extractHeader' and count(parameter)=2 and parameter[1][@type='org.apache.http.HttpResponse'] and parameter[2][@type='com.mopub.common.util.ResponseHeader']]"
		[Register ("extractHeader", "(Lorg/apache/http/HttpResponse;Lcom/mopub/common/util/ResponseHeader;)Ljava/lang/String;", "")]
		public static unsafe string ExtractHeader (global::Org.Apache.Http.IHttpResponse p0, global::Com.Mopub.Common.Util.ResponseHeader p1)
		{
			if (id_extractHeader_Lorg_apache_http_HttpResponse_Lcom_mopub_common_util_ResponseHeader_ == IntPtr.Zero)
				id_extractHeader_Lorg_apache_http_HttpResponse_Lcom_mopub_common_util_ResponseHeader_ = JNIEnv.GetStaticMethodID (class_ref, "extractHeader", "(Lorg/apache/http/HttpResponse;Lcom/mopub/common/util/ResponseHeader;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_extractHeader_Lorg_apache_http_HttpResponse_Lcom_mopub_common_util_ResponseHeader_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_extractIntHeader_Lorg_apache_http_HttpResponse_Lcom_mopub_common_util_ResponseHeader_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='HeaderUtils']/method[@name='extractIntHeader' and count(parameter)=3 and parameter[1][@type='org.apache.http.HttpResponse'] and parameter[2][@type='com.mopub.common.util.ResponseHeader'] and parameter[3][@type='int']]"
		[Register ("extractIntHeader", "(Lorg/apache/http/HttpResponse;Lcom/mopub/common/util/ResponseHeader;I)I", "")]
		public static unsafe int ExtractIntHeader (global::Org.Apache.Http.IHttpResponse p0, global::Com.Mopub.Common.Util.ResponseHeader p1, int p2)
		{
			if (id_extractIntHeader_Lorg_apache_http_HttpResponse_Lcom_mopub_common_util_ResponseHeader_I == IntPtr.Zero)
				id_extractIntHeader_Lorg_apache_http_HttpResponse_Lcom_mopub_common_util_ResponseHeader_I = JNIEnv.GetStaticMethodID (class_ref, "extractIntHeader", "(Lorg/apache/http/HttpResponse;Lcom/mopub/common/util/ResponseHeader;I)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_extractIntHeader_Lorg_apache_http_HttpResponse_Lcom_mopub_common_util_ResponseHeader_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_extractIntegerHeader_Ljava_util_Map_Lcom_mopub_common_util_ResponseHeader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='HeaderUtils']/method[@name='extractIntegerHeader' and count(parameter)=2 and parameter[1][@type='java.util.Map'] and parameter[2][@type='com.mopub.common.util.ResponseHeader']]"
		[Register ("extractIntegerHeader", "(Ljava/util/Map;Lcom/mopub/common/util/ResponseHeader;)Ljava/lang/Integer;", "")]
		public static unsafe global::Java.Lang.Integer ExtractIntegerHeader (global::System.Collections.IDictionary p0, global::Com.Mopub.Common.Util.ResponseHeader p1)
		{
			if (id_extractIntegerHeader_Ljava_util_Map_Lcom_mopub_common_util_ResponseHeader_ == IntPtr.Zero)
				id_extractIntegerHeader_Ljava_util_Map_Lcom_mopub_common_util_ResponseHeader_ = JNIEnv.GetStaticMethodID (class_ref, "extractIntegerHeader", "(Ljava/util/Map;Lcom/mopub/common/util/ResponseHeader;)Ljava/lang/Integer;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Integer __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_extractIntegerHeader_Ljava_util_Map_Lcom_mopub_common_util_ResponseHeader_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_extractIntegerHeader_Lorg_apache_http_HttpResponse_Lcom_mopub_common_util_ResponseHeader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='HeaderUtils']/method[@name='extractIntegerHeader' and count(parameter)=2 and parameter[1][@type='org.apache.http.HttpResponse'] and parameter[2][@type='com.mopub.common.util.ResponseHeader']]"
		[Register ("extractIntegerHeader", "(Lorg/apache/http/HttpResponse;Lcom/mopub/common/util/ResponseHeader;)Ljava/lang/Integer;", "")]
		public static unsafe global::Java.Lang.Integer ExtractIntegerHeader (global::Org.Apache.Http.IHttpResponse p0, global::Com.Mopub.Common.Util.ResponseHeader p1)
		{
			if (id_extractIntegerHeader_Lorg_apache_http_HttpResponse_Lcom_mopub_common_util_ResponseHeader_ == IntPtr.Zero)
				id_extractIntegerHeader_Lorg_apache_http_HttpResponse_Lcom_mopub_common_util_ResponseHeader_ = JNIEnv.GetStaticMethodID (class_ref, "extractIntegerHeader", "(Lorg/apache/http/HttpResponse;Lcom/mopub/common/util/ResponseHeader;)Ljava/lang/Integer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Integer __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_extractIntegerHeader_Lorg_apache_http_HttpResponse_Lcom_mopub_common_util_ResponseHeader_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
