using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.network']/class[@name='TrackingRequest']"
	[global::Android.Runtime.Register ("com/mopub/network/TrackingRequest", DoNotGenerateAcw=true)]
	public partial class TrackingRequest : global::Com.Mopub.Volley.Request {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.network']/interface[@name='TrackingRequest.Listener']"
		[Register ("com/mopub/network/TrackingRequest$Listener", "", "Com.Mopub.Network.TrackingRequest/IListenerInvoker")]
		public partial interface IListener : global::Com.Mopub.Volley.Response.IErrorListener {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/interface[@name='TrackingRequest.Listener']/method[@name='onResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onResponse", "(Ljava/lang/String;)V", "GetOnResponse_Ljava_lang_String_Handler:Com.Mopub.Network.TrackingRequest/IListenerInvoker, AppodealXamarinPlugin")]
			void OnResponse (string p0);

		}

		[global::Android.Runtime.Register ("com/mopub/network/TrackingRequest$Listener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/network/TrackingRequest$Listener");
			IntPtr class_ref;

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.network.TrackingRequest.Listener"));
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

			static Delegate cb_onResponse_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnResponse_Ljava_lang_String_Handler ()
			{
				if (cb_onResponse_Ljava_lang_String_ == null)
					cb_onResponse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResponse_Ljava_lang_String_);
				return cb_onResponse_Ljava_lang_String_;
			}

			static void n_OnResponse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Network.TrackingRequest.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.TrackingRequest.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnResponse (p0);
			}
#pragma warning restore 0169

			IntPtr id_onResponse_Ljava_lang_String_;
			public unsafe void OnResponse (string p0)
			{
				if (id_onResponse_Ljava_lang_String_ == IntPtr.Zero)
					id_onResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onResponse", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (Handle, id_onResponse_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
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
				global::Com.Mopub.Network.TrackingRequest.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.TrackingRequest.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				return JNIEnv.FindClass ("com/mopub/network/TrackingRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TrackingRequest); }
		}

		protected TrackingRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Mopub.Network.TrackingRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.TrackingRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Void p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Void> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeliverResponse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deliverResponse_Ljava_lang_Void_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='TrackingRequest']/method[@name='deliverResponse' and count(parameter)=1 and parameter[1][@type='java.lang.Void']]"
		[Register ("deliverResponse", "(Ljava/lang/Void;)V", "GetDeliverResponse_Ljava_lang_Void_Handler")]
		public virtual unsafe void DeliverResponse (global::Java.Lang.Void p0)
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

		static IntPtr id_makeTrackingHttpRequest_Ljava_lang_Iterable_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='TrackingRequest']/method[@name='makeTrackingHttpRequest' and count(parameter)=2 and parameter[1][@type='java.lang.Iterable'] and parameter[2][@type='android.content.Context']]"
		[Register ("makeTrackingHttpRequest", "(Ljava/lang/Iterable;Landroid/content/Context;)V", "")]
		public static unsafe void MakeTrackingHttpRequest (global::Java.Lang.IIterable p0, global::Android.Content.Context p1)
		{
			if (id_makeTrackingHttpRequest_Ljava_lang_Iterable_Landroid_content_Context_ == IntPtr.Zero)
				id_makeTrackingHttpRequest_Ljava_lang_Iterable_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "makeTrackingHttpRequest", "(Ljava/lang/Iterable;Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_makeTrackingHttpRequest_Ljava_lang_Iterable_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_makeTrackingHttpRequest_Ljava_lang_Iterable_Landroid_content_Context_Lcom_mopub_common_event_BaseEvent_Name_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='TrackingRequest']/method[@name='makeTrackingHttpRequest' and count(parameter)=3 and parameter[1][@type='java.lang.Iterable'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.mopub.common.event.BaseEvent.Name']]"
		[Register ("makeTrackingHttpRequest", "(Ljava/lang/Iterable;Landroid/content/Context;Lcom/mopub/common/event/BaseEvent$Name;)V", "")]
		public static unsafe void MakeTrackingHttpRequest (global::Java.Lang.IIterable p0, global::Android.Content.Context p1, global::Com.Mopub.Common.Event.BaseEvent.Name p2)
		{
			if (id_makeTrackingHttpRequest_Ljava_lang_Iterable_Landroid_content_Context_Lcom_mopub_common_event_BaseEvent_Name_ == IntPtr.Zero)
				id_makeTrackingHttpRequest_Ljava_lang_Iterable_Landroid_content_Context_Lcom_mopub_common_event_BaseEvent_Name_ = JNIEnv.GetStaticMethodID (class_ref, "makeTrackingHttpRequest", "(Ljava/lang/Iterable;Landroid/content/Context;Lcom/mopub/common/event/BaseEvent$Name;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_makeTrackingHttpRequest_Ljava_lang_Iterable_Landroid_content_Context_Lcom_mopub_common_event_BaseEvent_Name_, __args);
			} finally {
			}
		}

		static IntPtr id_makeTrackingHttpRequest_Ljava_lang_Iterable_Landroid_content_Context_Lcom_mopub_network_TrackingRequest_Listener_Lcom_mopub_common_event_BaseEvent_Name_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='TrackingRequest']/method[@name='makeTrackingHttpRequest' and count(parameter)=4 and parameter[1][@type='java.lang.Iterable'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.mopub.network.TrackingRequest.Listener'] and parameter[4][@type='com.mopub.common.event.BaseEvent.Name']]"
		[Register ("makeTrackingHttpRequest", "(Ljava/lang/Iterable;Landroid/content/Context;Lcom/mopub/network/TrackingRequest$Listener;Lcom/mopub/common/event/BaseEvent$Name;)V", "")]
		public static unsafe void MakeTrackingHttpRequest (global::Java.Lang.IIterable p0, global::Android.Content.Context p1, global::Com.Mopub.Network.TrackingRequest.IListener p2, global::Com.Mopub.Common.Event.BaseEvent.Name p3)
		{
			if (id_makeTrackingHttpRequest_Ljava_lang_Iterable_Landroid_content_Context_Lcom_mopub_network_TrackingRequest_Listener_Lcom_mopub_common_event_BaseEvent_Name_ == IntPtr.Zero)
				id_makeTrackingHttpRequest_Ljava_lang_Iterable_Landroid_content_Context_Lcom_mopub_network_TrackingRequest_Listener_Lcom_mopub_common_event_BaseEvent_Name_ = JNIEnv.GetStaticMethodID (class_ref, "makeTrackingHttpRequest", "(Ljava/lang/Iterable;Landroid/content/Context;Lcom/mopub/network/TrackingRequest$Listener;Lcom/mopub/common/event/BaseEvent$Name;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_makeTrackingHttpRequest_Ljava_lang_Iterable_Landroid_content_Context_Lcom_mopub_network_TrackingRequest_Listener_Lcom_mopub_common_event_BaseEvent_Name_, __args);
			} finally {
			}
		}

		static IntPtr id_makeTrackingHttpRequest_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='TrackingRequest']/method[@name='makeTrackingHttpRequest' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("makeTrackingHttpRequest", "(Ljava/lang/String;Landroid/content/Context;)V", "")]
		public static unsafe void MakeTrackingHttpRequest (string p0, global::Android.Content.Context p1)
		{
			if (id_makeTrackingHttpRequest_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_makeTrackingHttpRequest_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "makeTrackingHttpRequest", "(Ljava/lang/String;Landroid/content/Context;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_makeTrackingHttpRequest_Ljava_lang_String_Landroid_content_Context_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_makeTrackingHttpRequest_Ljava_lang_String_Landroid_content_Context_Lcom_mopub_common_event_BaseEvent_Name_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='TrackingRequest']/method[@name='makeTrackingHttpRequest' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.mopub.common.event.BaseEvent.Name']]"
		[Register ("makeTrackingHttpRequest", "(Ljava/lang/String;Landroid/content/Context;Lcom/mopub/common/event/BaseEvent$Name;)V", "")]
		public static unsafe void MakeTrackingHttpRequest (string p0, global::Android.Content.Context p1, global::Com.Mopub.Common.Event.BaseEvent.Name p2)
		{
			if (id_makeTrackingHttpRequest_Ljava_lang_String_Landroid_content_Context_Lcom_mopub_common_event_BaseEvent_Name_ == IntPtr.Zero)
				id_makeTrackingHttpRequest_Ljava_lang_String_Landroid_content_Context_Lcom_mopub_common_event_BaseEvent_Name_ = JNIEnv.GetStaticMethodID (class_ref, "makeTrackingHttpRequest", "(Ljava/lang/String;Landroid/content/Context;Lcom/mopub/common/event/BaseEvent$Name;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_makeTrackingHttpRequest_Ljava_lang_String_Landroid_content_Context_Lcom_mopub_common_event_BaseEvent_Name_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_makeTrackingHttpRequest_Ljava_lang_String_Landroid_content_Context_Lcom_mopub_network_TrackingRequest_Listener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='TrackingRequest']/method[@name='makeTrackingHttpRequest' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.mopub.network.TrackingRequest.Listener']]"
		[Register ("makeTrackingHttpRequest", "(Ljava/lang/String;Landroid/content/Context;Lcom/mopub/network/TrackingRequest$Listener;)V", "")]
		public static unsafe void MakeTrackingHttpRequest (string p0, global::Android.Content.Context p1, global::Com.Mopub.Network.TrackingRequest.IListener p2)
		{
			if (id_makeTrackingHttpRequest_Ljava_lang_String_Landroid_content_Context_Lcom_mopub_network_TrackingRequest_Listener_ == IntPtr.Zero)
				id_makeTrackingHttpRequest_Ljava_lang_String_Landroid_content_Context_Lcom_mopub_network_TrackingRequest_Listener_ = JNIEnv.GetStaticMethodID (class_ref, "makeTrackingHttpRequest", "(Ljava/lang/String;Landroid/content/Context;Lcom/mopub/network/TrackingRequest$Listener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_makeTrackingHttpRequest_Ljava_lang_String_Landroid_content_Context_Lcom_mopub_network_TrackingRequest_Listener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_makeTrackingHttpRequest_Ljava_lang_String_Landroid_content_Context_Lcom_mopub_network_TrackingRequest_Listener_Lcom_mopub_common_event_BaseEvent_Name_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='TrackingRequest']/method[@name='makeTrackingHttpRequest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.mopub.network.TrackingRequest.Listener'] and parameter[4][@type='com.mopub.common.event.BaseEvent.Name']]"
		[Register ("makeTrackingHttpRequest", "(Ljava/lang/String;Landroid/content/Context;Lcom/mopub/network/TrackingRequest$Listener;Lcom/mopub/common/event/BaseEvent$Name;)V", "")]
		public static unsafe void MakeTrackingHttpRequest (string p0, global::Android.Content.Context p1, global::Com.Mopub.Network.TrackingRequest.IListener p2, global::Com.Mopub.Common.Event.BaseEvent.Name p3)
		{
			if (id_makeTrackingHttpRequest_Ljava_lang_String_Landroid_content_Context_Lcom_mopub_network_TrackingRequest_Listener_Lcom_mopub_common_event_BaseEvent_Name_ == IntPtr.Zero)
				id_makeTrackingHttpRequest_Ljava_lang_String_Landroid_content_Context_Lcom_mopub_network_TrackingRequest_Listener_Lcom_mopub_common_event_BaseEvent_Name_ = JNIEnv.GetStaticMethodID (class_ref, "makeTrackingHttpRequest", "(Ljava/lang/String;Landroid/content/Context;Lcom/mopub/network/TrackingRequest$Listener;Lcom/mopub/common/event/BaseEvent$Name;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_makeTrackingHttpRequest_Ljava_lang_String_Landroid_content_Context_Lcom_mopub_network_TrackingRequest_Listener_Lcom_mopub_common_event_BaseEvent_Name_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_makeVastTrackingHttpRequest_Ljava_util_List_Lcom_mopub_mobileads_VastErrorCode_Ljava_lang_Integer_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='TrackingRequest']/method[@name='makeVastTrackingHttpRequest' and count(parameter)=5 and parameter[1][@type='java.util.List'] and parameter[2][@type='com.mopub.mobileads.VastErrorCode'] and parameter[3][@type='java.lang.Integer'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='android.content.Context']]"
		[Register ("makeVastTrackingHttpRequest", "(Ljava/util/List;Lcom/mopub/mobileads/VastErrorCode;Ljava/lang/Integer;Ljava/lang/String;Landroid/content/Context;)V", "")]
		public static unsafe void MakeVastTrackingHttpRequest (global::System.Collections.IList p0, global::Com.Mopub.Mobileads.VastErrorCode p1, global::Java.Lang.Integer p2, string p3, global::Android.Content.Context p4)
		{
			if (id_makeVastTrackingHttpRequest_Ljava_util_List_Lcom_mopub_mobileads_VastErrorCode_Ljava_lang_Integer_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_makeVastTrackingHttpRequest_Ljava_util_List_Lcom_mopub_mobileads_VastErrorCode_Ljava_lang_Integer_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "makeVastTrackingHttpRequest", "(Ljava/util/List;Lcom/mopub/mobileads/VastErrorCode;Ljava/lang/Integer;Ljava/lang/String;Landroid/content/Context;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_makeVastTrackingHttpRequest_Ljava_util_List_Lcom_mopub_mobileads_VastErrorCode_Ljava_lang_Integer_Ljava_lang_String_Landroid_content_Context_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
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
			global::Com.Mopub.Network.TrackingRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.TrackingRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.NetworkResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.NetworkResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ParseNetworkResponse (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='TrackingRequest']/method[@name='parseNetworkResponse' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.NetworkResponse']]"
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
