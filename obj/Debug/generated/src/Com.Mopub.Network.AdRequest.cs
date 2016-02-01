using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.network']/class[@name='AdRequest']"
	[global::Android.Runtime.Register ("com/mopub/network/AdRequest", DoNotGenerateAcw=true)]
	public partial class AdRequest : global::Com.Mopub.Volley.Request {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.network']/interface[@name='AdRequest.Listener']"
		[Register ("com/mopub/network/AdRequest$Listener", "", "Com.Mopub.Network.AdRequest/IListenerInvoker")]
		public partial interface IListener : global::Com.Mopub.Volley.Response.IErrorListener {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/interface[@name='AdRequest.Listener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='com.mopub.network.AdResponse']]"
			[Register ("onSuccess", "(Lcom/mopub/network/AdResponse;)V", "GetOnSuccess_Lcom_mopub_network_AdResponse_Handler:Com.Mopub.Network.AdRequest/IListenerInvoker, AppodealXamarinPlugin")]
			void OnSuccess (global::Com.Mopub.Network.AdResponse p0);

		}

		[global::Android.Runtime.Register ("com/mopub/network/AdRequest$Listener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/network/AdRequest$Listener");
			IntPtr class_ref;

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.network.AdRequest.Listener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IListenerInvoker); }
			}

			static Delegate cb_onSuccess_Lcom_mopub_network_AdResponse_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_Lcom_mopub_network_AdResponse_Handler ()
			{
				if (cb_onSuccess_Lcom_mopub_network_AdResponse_ == null)
					cb_onSuccess_Lcom_mopub_network_AdResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Lcom_mopub_network_AdResponse_);
				return cb_onSuccess_Lcom_mopub_network_AdResponse_;
			}

			static void n_OnSuccess_Lcom_mopub_network_AdResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Network.AdRequest.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdRequest.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Network.AdResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSuccess_Lcom_mopub_network_AdResponse_;
			public unsafe void OnSuccess (global::Com.Mopub.Network.AdResponse p0)
			{
				if (id_onSuccess_Lcom_mopub_network_AdResponse_ == IntPtr.Zero)
					id_onSuccess_Lcom_mopub_network_AdResponse_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lcom/mopub/network/AdResponse;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onSuccess_Lcom_mopub_network_AdResponse_, __args);
			}

			static Delegate cb_onErrorResponse_Lcom_mopub_volley_VolleyError_;
#pragma warning disable 0169
			static Delegate GetOnErrorResponse_Lcom_mopub_volley_VolleyError_Handler ()
			{
				if (cb_onErrorResponse_Lcom_mopub_volley_VolleyError_ == null)
					cb_onErrorResponse_Lcom_mopub_volley_VolleyError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnErrorResponse_Lcom_mopub_volley_VolleyError_);
				return cb_onErrorResponse_Lcom_mopub_volley_VolleyError_;
			}

			static void n_OnErrorResponse_Lcom_mopub_volley_VolleyError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Network.AdRequest.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdRequest.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Volley.VolleyError p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.VolleyError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnErrorResponse (p0);
			}
#pragma warning restore 0169

			IntPtr id_onErrorResponse_Lcom_mopub_volley_VolleyError_;
			public unsafe void OnErrorResponse (global::Com.Mopub.Volley.VolleyError p0)
			{
				if (id_onErrorResponse_Lcom_mopub_volley_VolleyError_ == IntPtr.Zero)
					id_onErrorResponse_Lcom_mopub_volley_VolleyError_ = JNIEnv.GetMethodID (class_ref, "onErrorResponse", "(Lcom/mopub/volley/VolleyError;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onErrorResponse_Lcom_mopub_volley_VolleyError_, __args);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/network/AdRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdRequest); }
		}

		protected AdRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_mopub_common_AdFormat_Ljava_lang_String_Landroid_content_Context_Lcom_mopub_network_AdRequest_Listener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.network']/class[@name='AdRequest']/constructor[@name='AdRequest' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.common.AdFormat'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.content.Context'] and parameter[5][@type='com.mopub.network.AdRequest.Listener']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/mopub/common/AdFormat;Ljava/lang/String;Landroid/content/Context;Lcom/mopub/network/AdRequest$Listener;)V", "")]
		public unsafe AdRequest (string p0, global::Com.Mopub.Common.AdFormat p1, string p2, global::Android.Content.Context p3, global::Com.Mopub.Network.AdRequest.IListener p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (AdRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/mopub/common/AdFormat;Ljava/lang/String;Landroid/content/Context;Lcom/mopub/network/AdRequest$Listener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lcom/mopub/common/AdFormat;Ljava/lang/String;Landroid/content/Context;Lcom/mopub/network/AdRequest$Listener;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_mopub_common_AdFormat_Ljava_lang_String_Landroid_content_Context_Lcom_mopub_network_AdRequest_Listener_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_mopub_common_AdFormat_Ljava_lang_String_Landroid_content_Context_Lcom_mopub_network_AdRequest_Listener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/mopub/common/AdFormat;Ljava/lang/String;Landroid/content/Context;Lcom/mopub/network/AdRequest$Listener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_mopub_common_AdFormat_Ljava_lang_String_Landroid_content_Context_Lcom_mopub_network_AdRequest_Listener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_mopub_common_AdFormat_Ljava_lang_String_Landroid_content_Context_Lcom_mopub_network_AdRequest_Listener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getListener;
#pragma warning disable 0169
		static Delegate GetGetListenerHandler ()
		{
			if (cb_getListener == null)
				cb_getListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetListener);
			return cb_getListener;
		}

		static IntPtr n_GetListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.AdRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Listener);
		}
#pragma warning restore 0169

		static IntPtr id_getListener;
		public virtual unsafe global::Com.Mopub.Network.AdRequest.IListener Listener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdRequest']/method[@name='getListener' and count(parameter)=0]"
			[Register ("getListener", "()Lcom/mopub/network/AdRequest$Listener;", "GetGetListenerHandler")]
			get {
				if (id_getListener == IntPtr.Zero)
					id_getListener = JNIEnv.GetMethodID (class_ref, "getListener", "()Lcom/mopub/network/AdRequest$Listener;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdRequest.IListener> (JNIEnv.CallObjectMethod  (Handle, id_getListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdRequest.IListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getListener", "()Lcom/mopub/network/AdRequest$Listener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_deliverResponse_Lcom_mopub_network_AdResponse_;
#pragma warning disable 0169
		static Delegate GetDeliverResponse_Lcom_mopub_network_AdResponse_Handler ()
		{
			if (cb_deliverResponse_Lcom_mopub_network_AdResponse_ == null)
				cb_deliverResponse_Lcom_mopub_network_AdResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeliverResponse_Lcom_mopub_network_AdResponse_);
			return cb_deliverResponse_Lcom_mopub_network_AdResponse_;
		}

		static void n_DeliverResponse_Lcom_mopub_network_AdResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Network.AdRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Network.AdResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeliverResponse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deliverResponse_Lcom_mopub_network_AdResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdRequest']/method[@name='deliverResponse' and count(parameter)=1 and parameter[1][@type='com.mopub.network.AdResponse']]"
		[Register ("deliverResponse", "(Lcom/mopub/network/AdResponse;)V", "GetDeliverResponse_Lcom_mopub_network_AdResponse_Handler")]
		protected virtual unsafe void DeliverResponse (global::Com.Mopub.Network.AdResponse p0)
		{
			if (id_deliverResponse_Lcom_mopub_network_AdResponse_ == IntPtr.Zero)
				id_deliverResponse_Lcom_mopub_network_AdResponse_ = JNIEnv.GetMethodID (class_ref, "deliverResponse", "(Lcom/mopub/network/AdResponse;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_deliverResponse_Lcom_mopub_network_AdResponse_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deliverResponse", "(Lcom/mopub/network/AdResponse;)V"), __args);
			} finally {
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
			global::Com.Mopub.Network.AdRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.NetworkResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.NetworkResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ParseNetworkResponse (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdRequest']/method[@name='parseNetworkResponse' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.NetworkResponse']]"
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

		static Delegate cb_parseStringBody_Lcom_mopub_volley_NetworkResponse_;
#pragma warning disable 0169
		static Delegate GetParseStringBody_Lcom_mopub_volley_NetworkResponse_Handler ()
		{
			if (cb_parseStringBody_Lcom_mopub_volley_NetworkResponse_ == null)
				cb_parseStringBody_Lcom_mopub_volley_NetworkResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ParseStringBody_Lcom_mopub_volley_NetworkResponse_);
			return cb_parseStringBody_Lcom_mopub_volley_NetworkResponse_;
		}

		static IntPtr n_ParseStringBody_Lcom_mopub_volley_NetworkResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Network.AdRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.NetworkResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.NetworkResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ParseStringBody (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_parseStringBody_Lcom_mopub_volley_NetworkResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdRequest']/method[@name='parseStringBody' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.NetworkResponse']]"
		[Register ("parseStringBody", "(Lcom/mopub/volley/NetworkResponse;)Ljava/lang/String;", "GetParseStringBody_Lcom_mopub_volley_NetworkResponse_Handler")]
		protected virtual unsafe string ParseStringBody (global::Com.Mopub.Volley.NetworkResponse p0)
		{
			if (id_parseStringBody_Lcom_mopub_volley_NetworkResponse_ == IntPtr.Zero)
				id_parseStringBody_Lcom_mopub_volley_NetworkResponse_ = JNIEnv.GetMethodID (class_ref, "parseStringBody", "(Lcom/mopub/volley/NetworkResponse;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_parseStringBody_Lcom_mopub_volley_NetworkResponse_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parseStringBody", "(Lcom/mopub/volley/NetworkResponse;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
