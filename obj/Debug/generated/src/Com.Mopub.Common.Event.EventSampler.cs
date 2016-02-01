using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventSampler']"
	[global::Android.Runtime.Register ("com/mopub/common/event/EventSampler", DoNotGenerateAcw=true)]
	public partial class EventSampler : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/event/EventSampler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventSampler); }
		}

		protected EventSampler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventSampler']/constructor[@name='EventSampler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventSampler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (EventSampler)) {
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

		static IntPtr id_ctor_Ljava_util_Random_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventSampler']/constructor[@name='EventSampler' and count(parameter)=1 and parameter[1][@type='java.util.Random']]"
		[Register (".ctor", "(Ljava/util/Random;)V", "")]
		public unsafe EventSampler (global::Java.Util.Random p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (EventSampler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/Random;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/Random;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_Random_ == IntPtr.Zero)
					id_ctor_Ljava_util_Random_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Random;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Random_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_Random_, __args);
			} finally {
			}
		}

	}
}
