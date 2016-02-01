using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventSerializer']"
	[global::Android.Runtime.Register ("com/mopub/common/event/EventSerializer", DoNotGenerateAcw=true)]
	public partial class EventSerializer : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/event/EventSerializer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventSerializer); }
		}

		protected EventSerializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventSerializer']/constructor[@name='EventSerializer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventSerializer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (EventSerializer)) {
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

		static Delegate cb_serializeAsJson_Lcom_mopub_common_event_BaseEvent_;
#pragma warning disable 0169
		static Delegate GetSerializeAsJson_Lcom_mopub_common_event_BaseEvent_Handler ()
		{
			if (cb_serializeAsJson_Lcom_mopub_common_event_BaseEvent_ == null)
				cb_serializeAsJson_Lcom_mopub_common_event_BaseEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SerializeAsJson_Lcom_mopub_common_event_BaseEvent_);
			return cb_serializeAsJson_Lcom_mopub_common_event_BaseEvent_;
		}

		static IntPtr n_SerializeAsJson_Lcom_mopub_common_event_BaseEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.Event.EventSerializer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.EventSerializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Common.Event.BaseEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SerializeAsJson (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_serializeAsJson_Lcom_mopub_common_event_BaseEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventSerializer']/method[@name='serializeAsJson' and count(parameter)=1 and parameter[1][@type='com.mopub.common.event.BaseEvent']]"
		[Register ("serializeAsJson", "(Lcom/mopub/common/event/BaseEvent;)Lorg/json/JSONObject;", "GetSerializeAsJson_Lcom_mopub_common_event_BaseEvent_Handler")]
		public virtual unsafe global::Org.Json.JSONObject SerializeAsJson (global::Com.Mopub.Common.Event.BaseEvent p0)
		{
			if (id_serializeAsJson_Lcom_mopub_common_event_BaseEvent_ == IntPtr.Zero)
				id_serializeAsJson_Lcom_mopub_common_event_BaseEvent_ = JNIEnv.GetMethodID (class_ref, "serializeAsJson", "(Lcom/mopub/common/event/BaseEvent;)Lorg/json/JSONObject;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Json.JSONObject __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_serializeAsJson_Lcom_mopub_common_event_BaseEvent_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "serializeAsJson", "(Lcom/mopub/common/event/BaseEvent;)Lorg/json/JSONObject;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_serializeAsJson_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSerializeAsJson_Ljava_util_List_Handler ()
		{
			if (cb_serializeAsJson_Ljava_util_List_ == null)
				cb_serializeAsJson_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SerializeAsJson_Ljava_util_List_);
			return cb_serializeAsJson_Ljava_util_List_;
		}

		static IntPtr n_SerializeAsJson_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.Event.EventSerializer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.EventSerializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SerializeAsJson (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_serializeAsJson_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventSerializer']/method[@name='serializeAsJson' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("serializeAsJson", "(Ljava/util/List;)Lorg/json/JSONArray;", "GetSerializeAsJson_Ljava_util_List_Handler")]
		public virtual unsafe global::Org.Json.JSONArray SerializeAsJson (global::System.Collections.IList p0)
		{
			if (id_serializeAsJson_Ljava_util_List_ == IntPtr.Zero)
				id_serializeAsJson_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "serializeAsJson", "(Ljava/util/List;)Lorg/json/JSONArray;");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Org.Json.JSONArray __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallObjectMethod  (Handle, id_serializeAsJson_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "serializeAsJson", "(Ljava/util/List;)Lorg/json/JSONArray;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
