using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley.Toolbox {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='BasicNetwork']"
	[global::Android.Runtime.Register ("com/mopub/volley/toolbox/BasicNetwork", DoNotGenerateAcw=true)]
	public partial class BasicNetwork : global::Java.Lang.Object, global::Com.Mopub.Volley.INetwork {


		static IntPtr DEBUG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='BasicNetwork']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		protected static bool Debug {
			get {
				if (DEBUG_jfieldId == IntPtr.Zero)
					DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, DEBUG_jfieldId);
			}
		}

		static IntPtr mHttpStack_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='BasicNetwork']/field[@name='mHttpStack']"
		[Register ("mHttpStack")]
		protected global::Com.Mopub.Volley.Toolbox.IHttpStack MHttpStack {
			get {
				if (mHttpStack_jfieldId == IntPtr.Zero)
					mHttpStack_jfieldId = JNIEnv.GetFieldID (class_ref, "mHttpStack", "Lcom/mopub/volley/toolbox/HttpStack;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mHttpStack_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.IHttpStack> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mHttpStack_jfieldId == IntPtr.Zero)
					mHttpStack_jfieldId = JNIEnv.GetFieldID (class_ref, "mHttpStack", "Lcom/mopub/volley/toolbox/HttpStack;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mHttpStack_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mPool_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='BasicNetwork']/field[@name='mPool']"
		[Register ("mPool")]
		protected global::Com.Mopub.Volley.Toolbox.ByteArrayPool MPool {
			get {
				if (mPool_jfieldId == IntPtr.Zero)
					mPool_jfieldId = JNIEnv.GetFieldID (class_ref, "mPool", "Lcom/mopub/volley/toolbox/ByteArrayPool;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mPool_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ByteArrayPool> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPool_jfieldId == IntPtr.Zero)
					mPool_jfieldId = JNIEnv.GetFieldID (class_ref, "mPool", "Lcom/mopub/volley/toolbox/ByteArrayPool;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mPool_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/toolbox/BasicNetwork", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BasicNetwork); }
		}

		protected BasicNetwork (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mopub_volley_toolbox_HttpStack_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='BasicNetwork']/constructor[@name='BasicNetwork' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.toolbox.HttpStack']]"
		[Register (".ctor", "(Lcom/mopub/volley/toolbox/HttpStack;)V", "")]
		public unsafe BasicNetwork (global::Com.Mopub.Volley.Toolbox.IHttpStack p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BasicNetwork)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/volley/toolbox/HttpStack;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/volley/toolbox/HttpStack;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mopub_volley_toolbox_HttpStack_ == IntPtr.Zero)
					id_ctor_Lcom_mopub_volley_toolbox_HttpStack_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/volley/toolbox/HttpStack;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_volley_toolbox_HttpStack_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_volley_toolbox_HttpStack_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_mopub_volley_toolbox_HttpStack_Lcom_mopub_volley_toolbox_ByteArrayPool_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='BasicNetwork']/constructor[@name='BasicNetwork' and count(parameter)=2 and parameter[1][@type='com.mopub.volley.toolbox.HttpStack'] and parameter[2][@type='com.mopub.volley.toolbox.ByteArrayPool']]"
		[Register (".ctor", "(Lcom/mopub/volley/toolbox/HttpStack;Lcom/mopub/volley/toolbox/ByteArrayPool;)V", "")]
		public unsafe BasicNetwork (global::Com.Mopub.Volley.Toolbox.IHttpStack p0, global::Com.Mopub.Volley.Toolbox.ByteArrayPool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (BasicNetwork)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/volley/toolbox/HttpStack;Lcom/mopub/volley/toolbox/ByteArrayPool;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/volley/toolbox/HttpStack;Lcom/mopub/volley/toolbox/ByteArrayPool;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mopub_volley_toolbox_HttpStack_Lcom_mopub_volley_toolbox_ByteArrayPool_ == IntPtr.Zero)
					id_ctor_Lcom_mopub_volley_toolbox_HttpStack_Lcom_mopub_volley_toolbox_ByteArrayPool_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/volley/toolbox/HttpStack;Lcom/mopub/volley/toolbox/ByteArrayPool;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_volley_toolbox_HttpStack_Lcom_mopub_volley_toolbox_ByteArrayPool_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_volley_toolbox_HttpStack_Lcom_mopub_volley_toolbox_ByteArrayPool_, __args);
			} finally {
			}
		}

		static IntPtr id_convertHeaders_arrayLorg_apache_http_Header_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='BasicNetwork']/method[@name='convertHeaders' and count(parameter)=1 and parameter[1][@type='org.apache.http.Header[]']]"
		[Register ("convertHeaders", "([Lorg/apache/http/Header;)Ljava/util/Map;", "")]
		protected static unsafe global::System.Collections.IDictionary ConvertHeaders (global::Org.Apache.Http.IHeader[] p0)
		{
			if (id_convertHeaders_arrayLorg_apache_http_Header_ == IntPtr.Zero)
				id_convertHeaders_arrayLorg_apache_http_Header_ = JNIEnv.GetStaticMethodID (class_ref, "convertHeaders", "([Lorg/apache/http/Header;)Ljava/util/Map;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.Collections.IDictionary __ret = global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertHeaders_arrayLorg_apache_http_Header_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_logError_Ljava_lang_String_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetLogError_Ljava_lang_String_Ljava_lang_String_JHandler ()
		{
			if (cb_logError_Ljava_lang_String_Ljava_lang_String_J == null)
				cb_logError_Ljava_lang_String_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long>) n_LogError_Ljava_lang_String_Ljava_lang_String_J);
			return cb_logError_Ljava_lang_String_Ljava_lang_String_J;
		}

		static void n_LogError_Ljava_lang_String_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2)
		{
			global::Com.Mopub.Volley.Toolbox.BasicNetwork __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.BasicNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.LogError (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_logError_Ljava_lang_String_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='BasicNetwork']/method[@name='logError' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("logError", "(Ljava/lang/String;Ljava/lang/String;J)V", "GetLogError_Ljava_lang_String_Ljava_lang_String_JHandler")]
		protected virtual unsafe void LogError (string p0, string p1, long p2)
		{
			if (id_logError_Ljava_lang_String_Ljava_lang_String_J == IntPtr.Zero)
				id_logError_Ljava_lang_String_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "logError", "(Ljava/lang/String;Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_logError_Ljava_lang_String_Ljava_lang_String_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logError", "(Ljava/lang/String;Ljava/lang/String;J)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_performRequest_Lcom_mopub_volley_Request_;
#pragma warning disable 0169
		static Delegate GetPerformRequest_Lcom_mopub_volley_Request_Handler ()
		{
			if (cb_performRequest_Lcom_mopub_volley_Request_ == null)
				cb_performRequest_Lcom_mopub_volley_Request_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PerformRequest_Lcom_mopub_volley_Request_);
			return cb_performRequest_Lcom_mopub_volley_Request_;
		}

		static IntPtr n_PerformRequest_Lcom_mopub_volley_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Toolbox.BasicNetwork __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.BasicNetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PerformRequest (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_performRequest_Lcom_mopub_volley_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='BasicNetwork']/method[@name='performRequest' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.Request']]"
		[Register ("performRequest", "(Lcom/mopub/volley/Request;)Lcom/mopub/volley/NetworkResponse;", "GetPerformRequest_Lcom_mopub_volley_Request_Handler")]
		public virtual unsafe global::Com.Mopub.Volley.NetworkResponse PerformRequest (global::Com.Mopub.Volley.Request p0)
		{
			if (id_performRequest_Lcom_mopub_volley_Request_ == IntPtr.Zero)
				id_performRequest_Lcom_mopub_volley_Request_ = JNIEnv.GetMethodID (class_ref, "performRequest", "(Lcom/mopub/volley/Request;)Lcom/mopub/volley/NetworkResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mopub.Volley.NetworkResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.NetworkResponse> (JNIEnv.CallObjectMethod  (Handle, id_performRequest_Lcom_mopub_volley_Request_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.NetworkResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "performRequest", "(Lcom/mopub/volley/Request;)Lcom/mopub/volley/NetworkResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
