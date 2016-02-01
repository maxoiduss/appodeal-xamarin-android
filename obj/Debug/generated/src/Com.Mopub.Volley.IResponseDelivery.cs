using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.volley']/interface[@name='ResponseDelivery']"
	[Register ("com/mopub/volley/ResponseDelivery", "", "Com.Mopub.Volley.IResponseDeliveryInvoker")]
	public partial interface IResponseDelivery : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/interface[@name='ResponseDelivery']/method[@name='postError' and count(parameter)=2 and parameter[1][@type='com.mopub.volley.Request'] and parameter[2][@type='com.mopub.volley.VolleyError']]"
		[Register ("postError", "(Lcom/mopub/volley/Request;Lcom/mopub/volley/VolleyError;)V", "GetPostError_Lcom_mopub_volley_Request_Lcom_mopub_volley_VolleyError_Handler:Com.Mopub.Volley.IResponseDeliveryInvoker, AppodealXamarinPlugin")]
		void PostError (global::Com.Mopub.Volley.Request p0, global::Com.Mopub.Volley.VolleyError p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/interface[@name='ResponseDelivery']/method[@name='postResponse' and count(parameter)=2 and parameter[1][@type='com.mopub.volley.Request'] and parameter[2][@type='com.mopub.volley.Response']]"
		[Register ("postResponse", "(Lcom/mopub/volley/Request;Lcom/mopub/volley/Response;)V", "GetPostResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Handler:Com.Mopub.Volley.IResponseDeliveryInvoker, AppodealXamarinPlugin")]
		void PostResponse (global::Com.Mopub.Volley.Request p0, global::Com.Mopub.Volley.Response p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/interface[@name='ResponseDelivery']/method[@name='postResponse' and count(parameter)=3 and parameter[1][@type='com.mopub.volley.Request'] and parameter[2][@type='com.mopub.volley.Response'] and parameter[3][@type='java.lang.Runnable']]"
		[Register ("postResponse", "(Lcom/mopub/volley/Request;Lcom/mopub/volley/Response;Ljava/lang/Runnable;)V", "GetPostResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_Handler:Com.Mopub.Volley.IResponseDeliveryInvoker, AppodealXamarinPlugin")]
		void PostResponse (global::Com.Mopub.Volley.Request p0, global::Com.Mopub.Volley.Response p1, global::Java.Lang.IRunnable p2);

	}

	[global::Android.Runtime.Register ("com/mopub/volley/ResponseDelivery", DoNotGenerateAcw=true)]
	internal class IResponseDeliveryInvoker : global::Java.Lang.Object, IResponseDelivery {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/volley/ResponseDelivery");
		IntPtr class_ref;

		public static IResponseDelivery GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResponseDelivery> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mopub.volley.ResponseDelivery"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResponseDeliveryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IResponseDeliveryInvoker); }
		}

		static Delegate cb_postError_Lcom_mopub_volley_Request_Lcom_mopub_volley_VolleyError_;
#pragma warning disable 0169
		static Delegate GetPostError_Lcom_mopub_volley_Request_Lcom_mopub_volley_VolleyError_Handler ()
		{
			if (cb_postError_Lcom_mopub_volley_Request_Lcom_mopub_volley_VolleyError_ == null)
				cb_postError_Lcom_mopub_volley_Request_Lcom_mopub_volley_VolleyError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PostError_Lcom_mopub_volley_Request_Lcom_mopub_volley_VolleyError_);
			return cb_postError_Lcom_mopub_volley_Request_Lcom_mopub_volley_VolleyError_;
		}

		static void n_PostError_Lcom_mopub_volley_Request_Lcom_mopub_volley_VolleyError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Volley.IResponseDelivery __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.IResponseDelivery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.VolleyError p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.VolleyError> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PostError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_postError_Lcom_mopub_volley_Request_Lcom_mopub_volley_VolleyError_;
		public unsafe void PostError (global::Com.Mopub.Volley.Request p0, global::Com.Mopub.Volley.VolleyError p1)
		{
			if (id_postError_Lcom_mopub_volley_Request_Lcom_mopub_volley_VolleyError_ == IntPtr.Zero)
				id_postError_Lcom_mopub_volley_Request_Lcom_mopub_volley_VolleyError_ = JNIEnv.GetMethodID (class_ref, "postError", "(Lcom/mopub/volley/Request;Lcom/mopub/volley/VolleyError;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_postError_Lcom_mopub_volley_Request_Lcom_mopub_volley_VolleyError_, __args);
		}

		static Delegate cb_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_;
#pragma warning disable 0169
		static Delegate GetPostResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Handler ()
		{
			if (cb_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_ == null)
				cb_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PostResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_);
			return cb_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_;
		}

		static void n_PostResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Volley.IResponseDelivery __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.IResponseDelivery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.Response p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Response> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PostResponse (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_;
		public unsafe void PostResponse (global::Com.Mopub.Volley.Request p0, global::Com.Mopub.Volley.Response p1)
		{
			if (id_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_ == IntPtr.Zero)
				id_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_ = JNIEnv.GetMethodID (class_ref, "postResponse", "(Lcom/mopub/volley/Request;Lcom/mopub/volley/Response;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_, __args);
		}

		static Delegate cb_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetPostResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_Handler ()
		{
			if (cb_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_ == null)
				cb_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PostResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_);
			return cb_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_;
		}

		static void n_PostResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mopub.Volley.IResponseDelivery __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.IResponseDelivery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.Response p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Response> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p2 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.PostResponse (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_;
		public unsafe void PostResponse (global::Com.Mopub.Volley.Request p0, global::Com.Mopub.Volley.Response p1, global::Java.Lang.IRunnable p2)
		{
			if (id_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "postResponse", "(Lcom/mopub/volley/Request;Lcom/mopub/volley/Response;Ljava/lang/Runnable;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (Handle, id_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_, __args);
		}

	}

}
