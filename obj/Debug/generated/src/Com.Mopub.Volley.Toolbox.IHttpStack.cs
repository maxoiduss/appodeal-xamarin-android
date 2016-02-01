using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley.Toolbox {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.volley.toolbox']/interface[@name='HttpStack']"
	[Register ("com/mopub/volley/toolbox/HttpStack", "", "Com.Mopub.Volley.Toolbox.IHttpStackInvoker")]
	public partial interface IHttpStack : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/interface[@name='HttpStack']/method[@name='performRequest' and count(parameter)=2 and parameter[1][@type='com.mopub.volley.Request'] and parameter[2][@type='java.util.Map']]"
		[Register ("performRequest", "(Lcom/mopub/volley/Request;Ljava/util/Map;)Lorg/apache/http/HttpResponse;", "GetPerformRequest_Lcom_mopub_volley_Request_Ljava_util_Map_Handler:Com.Mopub.Volley.Toolbox.IHttpStackInvoker, AppodealXamarinPlugin")]
		global::Org.Apache.Http.IHttpResponse PerformRequest (global::Com.Mopub.Volley.Request p0, global::System.Collections.IDictionary p1);

	}

	[global::Android.Runtime.Register ("com/mopub/volley/toolbox/HttpStack", DoNotGenerateAcw=true)]
	internal class IHttpStackInvoker : global::Java.Lang.Object, IHttpStack {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/volley/toolbox/HttpStack");
		IntPtr class_ref;

		public static IHttpStack GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHttpStack> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mopub.volley.toolbox.HttpStack"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHttpStackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IHttpStackInvoker); }
		}

		static Delegate cb_performRequest_Lcom_mopub_volley_Request_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetPerformRequest_Lcom_mopub_volley_Request_Ljava_util_Map_Handler ()
		{
			if (cb_performRequest_Lcom_mopub_volley_Request_Ljava_util_Map_ == null)
				cb_performRequest_Lcom_mopub_volley_Request_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PerformRequest_Lcom_mopub_volley_Request_Ljava_util_Map_);
			return cb_performRequest_Lcom_mopub_volley_Request_Ljava_util_Map_;
		}

		static IntPtr n_PerformRequest_Lcom_mopub_volley_Request_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Volley.Toolbox.IHttpStack __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.IHttpStack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PerformRequest (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_performRequest_Lcom_mopub_volley_Request_Ljava_util_Map_;
		public unsafe global::Org.Apache.Http.IHttpResponse PerformRequest (global::Com.Mopub.Volley.Request p0, global::System.Collections.IDictionary p1)
		{
			if (id_performRequest_Lcom_mopub_volley_Request_Ljava_util_Map_ == IntPtr.Zero)
				id_performRequest_Lcom_mopub_volley_Request_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "performRequest", "(Lcom/mopub/volley/Request;Ljava/util/Map;)Lorg/apache/http/HttpResponse;");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			global::Org.Apache.Http.IHttpResponse __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHttpResponse> (JNIEnv.CallObjectMethod (Handle, id_performRequest_Lcom_mopub_volley_Request_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

}
