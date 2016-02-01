using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.event']/class[@name='ScribeEventRecorder']"
	[global::Android.Runtime.Register ("com/mopub/common/event/ScribeEventRecorder", DoNotGenerateAcw=true)]
	public partial class ScribeEventRecorder : global::Java.Lang.Object, global::Com.Mopub.Common.Event.IEventRecorder {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.event']/class[@name='ScribeEventRecorder.PollingRunnable']"
		[global::Android.Runtime.Register ("com/mopub/common/event/ScribeEventRecorder$PollingRunnable", DoNotGenerateAcw=true)]
		public partial class PollingRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/event/ScribeEventRecorder$PollingRunnable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PollingRunnable); }
			}

			protected PollingRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Common.Event.ScribeEventRecorder.PollingRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ScribeEventRecorder.PollingRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='ScribeEventRecorder.PollingRunnable']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/event/ScribeEventRecorder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScribeEventRecorder); }
		}

		protected ScribeEventRecorder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Mopub.Common.Event.ScribeEventRecorder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ScribeEventRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Common.Event.BaseEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.BaseEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Record (p0);
		}
#pragma warning restore 0169

		static IntPtr id_record_Lcom_mopub_common_event_BaseEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='ScribeEventRecorder']/method[@name='record' and count(parameter)=1 and parameter[1][@type='com.mopub.common.event.BaseEvent']]"
		[Register ("record", "(Lcom/mopub/common/event/BaseEvent;)V", "GetRecord_Lcom_mopub_common_event_BaseEvent_Handler")]
		public virtual unsafe void Record (global::Com.Mopub.Common.Event.BaseEvent p0)
		{
			if (id_record_Lcom_mopub_common_event_BaseEvent_ == IntPtr.Zero)
				id_record_Lcom_mopub_common_event_BaseEvent_ = JNIEnv.GetMethodID (class_ref, "record", "(Lcom/mopub/common/event/BaseEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_record_Lcom_mopub_common_event_BaseEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "record", "(Lcom/mopub/common/event/BaseEvent;)V"), __args);
			} finally {
			}
		}

	}
}
