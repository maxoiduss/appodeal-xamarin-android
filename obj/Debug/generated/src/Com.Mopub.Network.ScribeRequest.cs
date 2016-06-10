using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.network']/class[@name='ScribeRequest']"
	[global::Android.Runtime.Register ("com/mopub/network/ScribeRequest", DoNotGenerateAcw=true)]
	public partial class ScribeRequest : global::Com.Mopub.Volley.Request {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.network']/interface[@name='ScribeRequest.Listener']"
		[Register ("com/mopub/network/ScribeRequest$Listener", "", "Com.Mopub.Network.ScribeRequest/IListenerInvoker")]
		public partial interface IListener : global::Com.Mopub.Volley.Response.IErrorListener {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/interface[@name='ScribeRequest.Listener']/method[@name='onResponse' and count(parameter)=0]"
			[Register ("onResponse", "()V", "GetOnResponseHandler:Com.Mopub.Network.ScribeRequest/IListenerInvoker, AppodealXamarinPlugin")]
			void OnResponse ();

		}

		[global::Android.Runtime.Register ("com/mopub/network/ScribeRequest$Listener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/network/ScribeRequest$Listener");
			IntPtr class_ref;

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.network.ScribeRequest.Listener"));
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

			static Delegate cb_onResponse;
#pragma warning disable 0169
			static Delegate GetOnResponseHandler ()
			{
				if (cb_onResponse == null)
					cb_onResponse = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResponse);
				return cb_onResponse;
			}

			static void n_OnResponse (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Network.ScribeRequest.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.ScribeRequest.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnResponse ();
			}
#pragma warning restore 0169

			IntPtr id_onResponse;
			public unsafe void OnResponse ()
			{
				if (id_onResponse == IntPtr.Zero)
					id_onResponse = JNIEnv.GetMethodID (class_ref, "onResponse", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onResponse);
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
				global::Com.Mopub.Network.ScribeRequest.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.ScribeRequest.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.network']/interface[@name='ScribeRequest.ScribeRequestFactory']"
		[Register ("com/mopub/network/ScribeRequest$ScribeRequestFactory", "", "Com.Mopub.Network.ScribeRequest/IScribeRequestFactoryInvoker")]
		public partial interface IScribeRequestFactory : global::Com.Mopub.Network.RequestManager.IRequestFactory {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/interface[@name='ScribeRequest.ScribeRequestFactory']/method[@name='createRequest' and count(parameter)=1 and parameter[1][@type='com.mopub.network.ScribeRequest.Listener']]"
			[Register ("createRequest", "(Lcom/mopub/network/ScribeRequest$Listener;)Lcom/mopub/network/ScribeRequest;", "GetCreateRequest_Lcom_mopub_network_ScribeRequest_Listener_Handler:Com.Mopub.Network.ScribeRequest/IScribeRequestFactoryInvoker, AppodealXamarinPlugin")]
			global::Com.Mopub.Network.ScribeRequest CreateRequest (global::Com.Mopub.Network.ScribeRequest.IListener p0);

		}

		[global::Android.Runtime.Register ("com/mopub/network/ScribeRequest$ScribeRequestFactory", DoNotGenerateAcw=true)]
		internal class IScribeRequestFactoryInvoker : global::Java.Lang.Object, IScribeRequestFactory {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/network/ScribeRequest$ScribeRequestFactory");
			IntPtr class_ref;

			public static IScribeRequestFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IScribeRequestFactory> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.network.ScribeRequest.ScribeRequestFactory"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IScribeRequestFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IScribeRequestFactoryInvoker); }
			}

			static Delegate cb_createRequest_Lcom_mopub_network_ScribeRequest_Listener_;
#pragma warning disable 0169
			static Delegate GetCreateRequest_Lcom_mopub_network_ScribeRequest_Listener_Handler ()
			{
				if (cb_createRequest_Lcom_mopub_network_ScribeRequest_Listener_ == null)
					cb_createRequest_Lcom_mopub_network_ScribeRequest_Listener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateRequest_Lcom_mopub_network_ScribeRequest_Listener_);
				return cb_createRequest_Lcom_mopub_network_ScribeRequest_Listener_;
			}

			static IntPtr n_CreateRequest_Lcom_mopub_network_ScribeRequest_Listener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Network.ScribeRequest.IScribeRequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.ScribeRequest.IScribeRequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Network.ScribeRequest.IListener p0 = (global::Com.Mopub.Network.ScribeRequest.IListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.ScribeRequest.IListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateRequest (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_createRequest_Lcom_mopub_network_ScribeRequest_Listener_;
			public unsafe global::Com.Mopub.Network.ScribeRequest CreateRequest (global::Com.Mopub.Network.ScribeRequest.IListener p0)
			{
				if (id_createRequest_Lcom_mopub_network_ScribeRequest_Listener_ == IntPtr.Zero)
					id_createRequest_Lcom_mopub_network_ScribeRequest_Listener_ = JNIEnv.GetMethodID (class_ref, "createRequest", "(Lcom/mopub/network/ScribeRequest$Listener;)Lcom/mopub/network/ScribeRequest;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Mopub.Network.ScribeRequest __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.ScribeRequest> (JNIEnv.CallObjectMethod (Handle, id_createRequest_Lcom_mopub_network_ScribeRequest_Listener_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/network/ScribeRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScribeRequest); }
		}

		protected ScribeRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_List_Lcom_mopub_common_event_EventSerializer_Lcom_mopub_network_ScribeRequest_Listener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.network']/class[@name='ScribeRequest']/constructor[@name='ScribeRequest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List'] and parameter[3][@type='com.mopub.common.event.EventSerializer'] and parameter[4][@type='com.mopub.network.ScribeRequest.Listener']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/List;Lcom/mopub/common/event/EventSerializer;Lcom/mopub/network/ScribeRequest$Listener;)V", "")]
		public unsafe ScribeRequest (string p0, global::System.Collections.IList p1, global::Com.Mopub.Common.Event.EventSerializer p2, global::Com.Mopub.Network.ScribeRequest.IListener p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (ScribeRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/util/List;Lcom/mopub/common/event/EventSerializer;Lcom/mopub/network/ScribeRequest$Listener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/util/List;Lcom/mopub/common/event/EventSerializer;Lcom/mopub/network/ScribeRequest$Listener;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_util_List_Lcom_mopub_common_event_EventSerializer_Lcom_mopub_network_ScribeRequest_Listener_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_util_List_Lcom_mopub_common_event_EventSerializer_Lcom_mopub_network_ScribeRequest_Listener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/List;Lcom/mopub/common/event/EventSerializer;Lcom/mopub/network/ScribeRequest$Listener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_List_Lcom_mopub_common_event_EventSerializer_Lcom_mopub_network_ScribeRequest_Listener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_List_Lcom_mopub_common_event_EventSerializer_Lcom_mopub_network_ScribeRequest_Listener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getEvents;
#pragma warning disable 0169
		static Delegate GetGetEventsHandler ()
		{
			if (cb_getEvents == null)
				cb_getEvents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEvents);
			return cb_getEvents;
		}

		static IntPtr n_GetEvents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.ScribeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.ScribeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.Events);
		}
#pragma warning restore 0169

		static IntPtr id_getEvents;
		[Obsolete (@"deprecated")]
		public virtual unsafe global::System.Collections.IList Events {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='ScribeRequest']/method[@name='getEvents' and count(parameter)=0]"
			[Register ("getEvents", "()Ljava/util/List;", "GetGetEventsHandler")]
			get {
				if (id_getEvents == IntPtr.Zero)
					id_getEvents = JNIEnv.GetMethodID (class_ref, "getEvents", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getEvents), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEvents", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_deliverResponse_Ljava_lang_Void_;
#pragma warning disable 0169
		static Delegate GetDeliverResponse_Ljava_lang_Void_Handler ()
		{
			if (cb_deliverResponse_Ljava_lang_Void_ == null)
				cb_deliverResponse_Ljava_lang_Void_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeliverResponse_Ljava_lang_Void_);
			return cb_deliverResponse_Ljava_lang_Void_;
		}

		static void n_DeliverResponse_Ljava_lang_Void_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Network.ScribeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.ScribeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Void p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Void> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeliverResponse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deliverResponse_Ljava_lang_Void_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='ScribeRequest']/method[@name='deliverResponse' and count(parameter)=1 and parameter[1][@type='java.lang.Void']]"
		[Register ("deliverResponse", "(Ljava/lang/Void;)V", "GetDeliverResponse_Ljava_lang_Void_Handler")]
		protected virtual unsafe void DeliverResponse (global::Java.Lang.Void p0)
		{
			if (id_deliverResponse_Ljava_lang_Void_ == IntPtr.Zero)
				id_deliverResponse_Ljava_lang_Void_ = JNIEnv.GetMethodID (class_ref, "deliverResponse", "(Ljava/lang/Void;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_deliverResponse_Ljava_lang_Void_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deliverResponse", "(Ljava/lang/Void;)V"), __args);
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
			global::Com.Mopub.Network.ScribeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.ScribeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.NetworkResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.NetworkResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ParseNetworkResponse (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='ScribeRequest']/method[@name='parseNetworkResponse' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.NetworkResponse']]"
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
