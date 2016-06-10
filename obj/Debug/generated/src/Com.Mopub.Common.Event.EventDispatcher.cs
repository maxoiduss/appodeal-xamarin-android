using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDispatcher']"
	[global::Android.Runtime.Register ("com/mopub/common/event/EventDispatcher", DoNotGenerateAcw=true)]
	public partial class EventDispatcher : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/event/EventDispatcher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventDispatcher); }
		}

		protected EventDispatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_dispatch_Lcom_mopub_common_event_BaseEvent_;
#pragma warning disable 0169
		static Delegate GetDispatch_Lcom_mopub_common_event_BaseEvent_Handler ()
		{
			if (cb_dispatch_Lcom_mopub_common_event_BaseEvent_ == null)
				cb_dispatch_Lcom_mopub_common_event_BaseEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Dispatch_Lcom_mopub_common_event_BaseEvent_);
			return cb_dispatch_Lcom_mopub_common_event_BaseEvent_;
		}

		static void n_Dispatch_Lcom_mopub_common_event_BaseEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.Event.EventDispatcher __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.EventDispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Common.Event.BaseEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Dispatch (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dispatch_Lcom_mopub_common_event_BaseEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDispatcher']/method[@name='dispatch' and count(parameter)=1 and parameter[1][@type='com.mopub.common.event.BaseEvent']]"
		[Register ("dispatch", "(Lcom/mopub/common/event/BaseEvent;)V", "GetDispatch_Lcom_mopub_common_event_BaseEvent_Handler")]
		public virtual unsafe void Dispatch (global::Com.Mopub.Common.Event.BaseEvent p0)
		{
			if (id_dispatch_Lcom_mopub_common_event_BaseEvent_ == IntPtr.Zero)
				id_dispatch_Lcom_mopub_common_event_BaseEvent_ = JNIEnv.GetMethodID (class_ref, "dispatch", "(Lcom/mopub/common/event/BaseEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dispatch_Lcom_mopub_common_event_BaseEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatch", "(Lcom/mopub/common/event/BaseEvent;)V"), __args);
			} finally {
			}
		}

	}
}
