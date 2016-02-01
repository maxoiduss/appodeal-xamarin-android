using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.volley']/interface[@name='Network']"
	[Register ("com/mopub/volley/Network", "", "Com.Mopub.Volley.INetworkInvoker")]
	public partial interface INetwork : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/interface[@name='Network']/method[@name='performRequest' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.Request']]"
		[Register ("performRequest", "(Lcom/mopub/volley/Request;)Lcom/mopub/volley/NetworkResponse;", "GetPerformRequest_Lcom_mopub_volley_Request_Handler:Com.Mopub.Volley.INetworkInvoker, AppodealXamarinPlugin")]
		global::Com.Mopub.Volley.NetworkResponse PerformRequest (global::Com.Mopub.Volley.Request p0);

	}

	[global::Android.Runtime.Register ("com/mopub/volley/Network", DoNotGenerateAcw=true)]
	internal class INetworkInvoker : global::Java.Lang.Object, INetwork {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/volley/Network");
		IntPtr class_ref;

		public static INetwork GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INetwork> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mopub.volley.Network"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INetworkInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (INetworkInvoker); }
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
			global::Com.Mopub.Volley.INetwork __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.INetwork> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PerformRequest (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_performRequest_Lcom_mopub_volley_Request_;
		public unsafe global::Com.Mopub.Volley.NetworkResponse PerformRequest (global::Com.Mopub.Volley.Request p0)
		{
			if (id_performRequest_Lcom_mopub_volley_Request_ == IntPtr.Zero)
				id_performRequest_Lcom_mopub_volley_Request_ = JNIEnv.GetMethodID (class_ref, "performRequest", "(Lcom/mopub/volley/Request;)Lcom/mopub/volley/NetworkResponse;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Com.Mopub.Volley.NetworkResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.NetworkResponse> (JNIEnv.CallObjectMethod (Handle, id_performRequest_Lcom_mopub_volley_Request_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
