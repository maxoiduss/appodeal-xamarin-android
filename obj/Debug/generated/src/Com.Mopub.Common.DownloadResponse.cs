using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='DownloadResponse']"
	[global::Android.Runtime.Register ("com/mopub/common/DownloadResponse", DoNotGenerateAcw=true)]
	public partial class DownloadResponse : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/DownloadResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DownloadResponse); }
		}

		protected DownloadResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_apache_http_HttpResponse_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common']/class[@name='DownloadResponse']/constructor[@name='DownloadResponse' and count(parameter)=1 and parameter[1][@type='org.apache.http.HttpResponse']]"
		[Register (".ctor", "(Lorg/apache/http/HttpResponse;)V", "")]
		public unsafe DownloadResponse (global::Org.Apache.Http.IHttpResponse p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DownloadResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/apache/http/HttpResponse;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/apache/http/HttpResponse;)V", __args);
					return;
				}

				if (id_ctor_Lorg_apache_http_HttpResponse_ == IntPtr.Zero)
					id_ctor_Lorg_apache_http_HttpResponse_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/http/HttpResponse;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_http_HttpResponse_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_apache_http_HttpResponse_, __args);
			} finally {
			}
		}

		static Delegate cb_getContentLength;
#pragma warning disable 0169
		static Delegate GetGetContentLengthHandler ()
		{
			if (cb_getContentLength == null)
				cb_getContentLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetContentLength);
			return cb_getContentLength;
		}

		static long n_GetContentLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.DownloadResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.DownloadResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentLength;
		}
#pragma warning restore 0169

		static IntPtr id_getContentLength;
		public virtual unsafe long ContentLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='DownloadResponse']/method[@name='getContentLength' and count(parameter)=0]"
			[Register ("getContentLength", "()J", "GetGetContentLengthHandler")]
			get {
				if (id_getContentLength == IntPtr.Zero)
					id_getContentLength = JNIEnv.GetMethodID (class_ref, "getContentLength", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getContentLength);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentLength", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getStatusCode;
#pragma warning disable 0169
		static Delegate GetGetStatusCodeHandler ()
		{
			if (cb_getStatusCode == null)
				cb_getStatusCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatusCode);
			return cb_getStatusCode;
		}

		static int n_GetStatusCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.DownloadResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.DownloadResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StatusCode;
		}
#pragma warning restore 0169

		static IntPtr id_getStatusCode;
		public virtual unsafe int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='DownloadResponse']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "GetGetStatusCodeHandler")]
			get {
				if (id_getStatusCode == IntPtr.Zero)
					id_getStatusCode = JNIEnv.GetMethodID (class_ref, "getStatusCode", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getStatusCode);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatusCode", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getByteArray;
#pragma warning disable 0169
		static Delegate GetGetByteArrayHandler ()
		{
			if (cb_getByteArray == null)
				cb_getByteArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetByteArray);
			return cb_getByteArray;
		}

		static IntPtr n_GetByteArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.DownloadResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.DownloadResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetByteArray ());
		}
#pragma warning restore 0169

		static IntPtr id_getByteArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='DownloadResponse']/method[@name='getByteArray' and count(parameter)=0]"
		[Register ("getByteArray", "()[B", "GetGetByteArrayHandler")]
		public virtual unsafe byte[] GetByteArray ()
		{
			if (id_getByteArray == IntPtr.Zero)
				id_getByteArray = JNIEnv.GetMethodID (class_ref, "getByteArray", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getByteArray), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getByteArray", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getFirstHeader_Lcom_mopub_common_util_ResponseHeader_;
#pragma warning disable 0169
		static Delegate GetGetFirstHeader_Lcom_mopub_common_util_ResponseHeader_Handler ()
		{
			if (cb_getFirstHeader_Lcom_mopub_common_util_ResponseHeader_ == null)
				cb_getFirstHeader_Lcom_mopub_common_util_ResponseHeader_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFirstHeader_Lcom_mopub_common_util_ResponseHeader_);
			return cb_getFirstHeader_Lcom_mopub_common_util_ResponseHeader_;
		}

		static IntPtr n_GetFirstHeader_Lcom_mopub_common_util_ResponseHeader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.DownloadResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.DownloadResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Common.Util.ResponseHeader p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ResponseHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetFirstHeader (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFirstHeader_Lcom_mopub_common_util_ResponseHeader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='DownloadResponse']/method[@name='getFirstHeader' and count(parameter)=1 and parameter[1][@type='com.mopub.common.util.ResponseHeader']]"
		[Register ("getFirstHeader", "(Lcom/mopub/common/util/ResponseHeader;)Ljava/lang/String;", "GetGetFirstHeader_Lcom_mopub_common_util_ResponseHeader_Handler")]
		public virtual unsafe string GetFirstHeader (global::Com.Mopub.Common.Util.ResponseHeader p0)
		{
			if (id_getFirstHeader_Lcom_mopub_common_util_ResponseHeader_ == IntPtr.Zero)
				id_getFirstHeader_Lcom_mopub_common_util_ResponseHeader_ = JNIEnv.GetMethodID (class_ref, "getFirstHeader", "(Lcom/mopub/common/util/ResponseHeader;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFirstHeader_Lcom_mopub_common_util_ResponseHeader_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirstHeader", "(Lcom/mopub/common/util/ResponseHeader;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
