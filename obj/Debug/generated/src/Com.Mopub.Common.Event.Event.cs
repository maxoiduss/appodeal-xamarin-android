using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.event']/class[@name='Event']"
	[global::Android.Runtime.Register ("com/mopub/common/event/Event", DoNotGenerateAcw=true)]
	public partial class Event : global::Com.Mopub.Common.Event.BaseEvent {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.event']/class[@name='Event.Builder']"
		[global::Android.Runtime.Register ("com/mopub/common/event/Event$Builder", DoNotGenerateAcw=true)]
		public new partial class Builder : global::Com.Mopub.Common.Event.BaseEvent.Builder {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/event/Event$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_mopub_common_event_BaseEvent_Name_Lcom_mopub_common_event_BaseEvent_Category_D;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common.event']/class[@name='Event.Builder']/constructor[@name='Event.Builder' and count(parameter)=3 and parameter[1][@type='com.mopub.common.event.BaseEvent.Name'] and parameter[2][@type='com.mopub.common.event.BaseEvent.Category'] and parameter[3][@type='double']]"
			[Register (".ctor", "(Lcom/mopub/common/event/BaseEvent$Name;Lcom/mopub/common/event/BaseEvent$Category;D)V", "")]
			public unsafe Builder (global::Com.Mopub.Common.Event.BaseEvent.Name p0, global::Com.Mopub.Common.Event.BaseEvent.Category p1, double p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (Builder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/common/event/BaseEvent$Name;Lcom/mopub/common/event/BaseEvent$Category;D)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/common/event/BaseEvent$Name;Lcom/mopub/common/event/BaseEvent$Category;D)V", __args);
						return;
					}

					if (id_ctor_Lcom_mopub_common_event_BaseEvent_Name_Lcom_mopub_common_event_BaseEvent_Category_D == IntPtr.Zero)
						id_ctor_Lcom_mopub_common_event_BaseEvent_Name_Lcom_mopub_common_event_BaseEvent_Category_D = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/common/event/BaseEvent$Name;Lcom/mopub/common/event/BaseEvent$Category;D)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_common_event_BaseEvent_Name_Lcom_mopub_common_event_BaseEvent_Category_D, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_common_event_BaseEvent_Name_Lcom_mopub_common_event_BaseEvent_Category_D, __args);
				} finally {
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Common.Event.Event.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.Event.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='Event.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/mopub/common/event/Event;", "GetBuildHandler")]
			public virtual unsafe global::Com.Mopub.Common.Event.Event Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/mopub/common/event/Event;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.Event> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.Event> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/mopub/common/event/Event;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		protected Event (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
