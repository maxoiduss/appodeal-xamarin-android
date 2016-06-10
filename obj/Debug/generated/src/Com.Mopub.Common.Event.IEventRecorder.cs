using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Event {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.common.event']/interface[@name='EventRecorder']"
	[Register ("com/mopub/common/event/EventRecorder", "", "Com.Mopub.Common.Event.IEventRecorderInvoker")]
	public partial interface IEventRecorder : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/interface[@name='EventRecorder']/method[@name='record' and count(parameter)=1 and parameter[1][@type='com.mopub.common.event.BaseEvent']]"
		[Register ("record", "(Lcom/mopub/common/event/BaseEvent;)V", "GetRecord_Lcom_mopub_common_event_BaseEvent_Handler:Com.Mopub.Common.Event.IEventRecorderInvoker, AppodealXamarinPlugin")]
		void Record (global::Com.Mopub.Common.Event.BaseEvent p0);

	}

	[global::Android.Runtime.Register ("com/mopub/common/event/EventRecorder", DoNotGenerateAcw=true)]
	internal class IEventRecorderInvoker : global::Java.Lang.Object, IEventRecorder {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/common/event/EventRecorder");
		IntPtr class_ref;

		public static IEventRecorder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEventRecorder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mopub.common.event.EventRecorder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEventRecorderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IEventRecorderInvoker); }
		}

		static Delegate cb_record_Lcom_mopub_common_event_BaseEvent_;
#pragma warning disable 0169
		static Delegate GetRecord_Lcom_mopub_common_event_BaseEvent_Handler ()
		{
			if (cb_record_Lcom_mopub_common_event_BaseEvent_ == null)
				cb_record_Lcom_mopub_common_event_BaseEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Record_Lcom_mopub_common_event_BaseEvent_);
			return cb_record_Lcom_mopub_common_event_BaseEvent_;
		}

		static void n_Record_Lcom_mopub_common_event_BaseEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.Event.IEventRecorder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.IEventRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Common.Event.BaseEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Record (p0);
		}
#pragma warning restore 0169

		IntPtr id_record_Lcom_mopub_common_event_BaseEvent_;
		public unsafe void Record (global::Com.Mopub.Common.Event.BaseEvent p0)
		{
			if (id_record_Lcom_mopub_common_event_BaseEvent_ == IntPtr.Zero)
				id_record_Lcom_mopub_common_event_BaseEvent_ = JNIEnv.GetMethodID (class_ref, "record", "(Lcom/mopub/common/event/BaseEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_record_Lcom_mopub_common_event_BaseEvent_, __args);
		}

	}

}
