using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley.Toolbox {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='StringRequest']"
	[global::Android.Runtime.Register ("com/mopub/volley/toolbox/StringRequest", DoNotGenerateAcw=true)]
	public partial class StringRequest : global::Com.Mopub.Volley.Request {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/toolbox/StringRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StringRequest); }
		}

		protected StringRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILjava_lang_String_Lcom_mopub_volley_Response_Listener_Lcom_mopub_volley_Response_ErrorListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='StringRequest']/constructor[@name='StringRequest' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.mopub.volley.Response.Listener'] and parameter[4][@type='com.mopub.volley.Response.ErrorListener']]"
		[Register (".ctor", "(ILjava/lang/String;Lcom/mopub/volley/Response$Listener;Lcom/mopub/volley/Response$ErrorListener;)V", "")]
		public unsafe StringRequest (int p0, string p1, global::Com.Mopub.Volley.Response.IListener p2, global::Com.Mopub.Volley.Response.IErrorListener p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (StringRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILjava/lang/String;Lcom/mopub/volley/Response$Listener;Lcom/mopub/volley/Response$ErrorListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILjava/lang/String;Lcom/mopub/volley/Response$Listener;Lcom/mopub/volley/Response$ErrorListener;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_String_Lcom_mopub_volley_Response_Listener_Lcom_mopub_volley_Response_ErrorListener_ == IntPtr.Zero)
					id_ctor_ILjava_lang_String_Lcom_mopub_volley_Response_Listener_Lcom_mopub_volley_Response_ErrorListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;Lcom/mopub/volley/Response$Listener;Lcom/mopub/volley/Response$ErrorListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_Lcom_mopub_volley_Response_Listener_Lcom_mopub_volley_Response_ErrorListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILjava_lang_String_Lcom_mopub_volley_Response_Listener_Lcom_mopub_volley_Response_ErrorListener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_mopub_volley_Response_Listener_Lcom_mopub_volley_Response_ErrorListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='StringRequest']/constructor[@name='StringRequest' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.volley.Response.Listener'] and parameter[3][@type='com.mopub.volley.Response.ErrorListener']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/mopub/volley/Response$Listener;Lcom/mopub/volley/Response$ErrorListener;)V", "")]
		public unsafe StringRequest (string p0, global::Com.Mopub.Volley.Response.IListener p1, global::Com.Mopub.Volley.Response.IErrorListener p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (StringRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/mopub/volley/Response$Listener;Lcom/mopub/volley/Response$ErrorListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lcom/mopub/volley/Response$Listener;Lcom/mopub/volley/Response$ErrorListener;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_mopub_volley_Response_Listener_Lcom_mopub_volley_Response_ErrorListener_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_mopub_volley_Response_Listener_Lcom_mopub_volley_Response_ErrorListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/mopub/volley/Response$Listener;Lcom/mopub/volley/Response$ErrorListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_mopub_volley_Response_Listener_Lcom_mopub_volley_Response_ErrorListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_mopub_volley_Response_Listener_Lcom_mopub_volley_Response_ErrorListener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_deliverResponse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeliverResponse_Ljava_lang_String_Handler ()
		{
			if (cb_deliverResponse_Ljava_lang_String_ == null)
				cb_deliverResponse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeliverResponse_Ljava_lang_String_);
			return cb_deliverResponse_Ljava_lang_String_;
		}

		static void n_DeliverResponse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Toolbox.StringRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.StringRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeliverResponse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deliverResponse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='StringRequest']/method[@name='deliverResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deliverResponse", "(Ljava/lang/String;)V", "GetDeliverResponse_Ljava_lang_String_Handler")]
		protected virtual unsafe void DeliverResponse (string p0)
		{
			if (id_deliverResponse_Ljava_lang_String_ == IntPtr.Zero)
				id_deliverResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deliverResponse", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_deliverResponse_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deliverResponse", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_;
#pragma warning disable 0169
		static Delegate GetParseNetworkResponse_Lcom_mopub_volley_NetworkResponse_Handler ()
		{
			if (cb_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_ == null)
				cb_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ParseNetworkResponse_Lcom_mopub_volley_NetworkResponse_);
			return cb_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_;
		}

		static IntPtr n_ParseNetworkResponse_Lcom_mopub_volley_NetworkResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Toolbox.StringRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.StringRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.NetworkResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.NetworkResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ParseNetworkResponse (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='StringRequest']/method[@name='parseNetworkResponse' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.NetworkResponse']]"
		[Register ("parseNetworkResponse", "(Lcom/mopub/volley/NetworkResponse;)Lcom/mopub/volley/Response;", "GetParseNetworkResponse_Lcom_mopub_volley_NetworkResponse_Handler")]
		protected override unsafe global::Com.Mopub.Volley.Response ParseNetworkResponse (global::Com.Mopub.Volley.NetworkResponse p0)
		{
			if (id_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_ == IntPtr.Zero)
				id_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_ = JNIEnv.GetMethodID (class_ref, "parseNetworkResponse", "(Lcom/mopub/volley/NetworkResponse;)Lcom/mopub/volley/Response;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mopub.Volley.Response __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Response> (JNIEnv.CallObjectMethod  (Handle, id_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Response> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parseNetworkResponse", "(Lcom/mopub/volley/NetworkResponse;)Lcom/mopub/volley/Response;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
