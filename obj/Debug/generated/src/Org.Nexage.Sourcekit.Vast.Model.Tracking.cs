using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Vast.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='Tracking']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/vast/model/Tracking", DoNotGenerateAcw=true)]
	public partial class Tracking : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/vast/model/Tracking", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Tracking); }
		}

		protected Tracking (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='Tracking']/constructor[@name='Tracking' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Tracking ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Tracking)) {
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

		static Delegate cb_getEvent;
#pragma warning disable 0169
		static Delegate GetGetEventHandler ()
		{
			if (cb_getEvent == null)
				cb_getEvent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEvent);
			return cb_getEvent;
		}

		static IntPtr n_GetEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.Tracking __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.Tracking> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Event);
		}
#pragma warning restore 0169

		static Delegate cb_setEvent_Lorg_nexage_sourcekit_vast_model_TRACKING_EVENTS_TYPE_;
#pragma warning disable 0169
		static Delegate GetSetEvent_Lorg_nexage_sourcekit_vast_model_TRACKING_EVENTS_TYPE_Handler ()
		{
			if (cb_setEvent_Lorg_nexage_sourcekit_vast_model_TRACKING_EVENTS_TYPE_ == null)
				cb_setEvent_Lorg_nexage_sourcekit_vast_model_TRACKING_EVENTS_TYPE_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEvent_Lorg_nexage_sourcekit_vast_model_TRACKING_EVENTS_TYPE_);
			return cb_setEvent_Lorg_nexage_sourcekit_vast_model_TRACKING_EVENTS_TYPE_;
		}

		static void n_SetEvent_Lorg_nexage_sourcekit_vast_model_TRACKING_EVENTS_TYPE_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.Tracking __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.Tracking> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Nexage.Sourcekit.Vast.Model.TRACKING_EVENTS_TYPE p0 = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.TRACKING_EVENTS_TYPE> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Event = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEvent;
		static IntPtr id_setEvent_Lorg_nexage_sourcekit_vast_model_TRACKING_EVENTS_TYPE_;
		public virtual unsafe global::Org.Nexage.Sourcekit.Vast.Model.TRACKING_EVENTS_TYPE Event {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='Tracking']/method[@name='getEvent' and count(parameter)=0]"
			[Register ("getEvent", "()Lorg/nexage/sourcekit/vast/model/TRACKING_EVENTS_TYPE;", "GetGetEventHandler")]
			get {
				if (id_getEvent == IntPtr.Zero)
					id_getEvent = JNIEnv.GetMethodID (class_ref, "getEvent", "()Lorg/nexage/sourcekit/vast/model/TRACKING_EVENTS_TYPE;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.TRACKING_EVENTS_TYPE> (JNIEnv.CallObjectMethod  (Handle, id_getEvent), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.TRACKING_EVENTS_TYPE> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEvent", "()Lorg/nexage/sourcekit/vast/model/TRACKING_EVENTS_TYPE;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='Tracking']/method[@name='setEvent' and count(parameter)=1 and parameter[1][@type='org.nexage.sourcekit.vast.model.TRACKING_EVENTS_TYPE']]"
			[Register ("setEvent", "(Lorg/nexage/sourcekit/vast/model/TRACKING_EVENTS_TYPE;)V", "GetSetEvent_Lorg_nexage_sourcekit_vast_model_TRACKING_EVENTS_TYPE_Handler")]
			set {
				if (id_setEvent_Lorg_nexage_sourcekit_vast_model_TRACKING_EVENTS_TYPE_ == IntPtr.Zero)
					id_setEvent_Lorg_nexage_sourcekit_vast_model_TRACKING_EVENTS_TYPE_ = JNIEnv.GetMethodID (class_ref, "setEvent", "(Lorg/nexage/sourcekit/vast/model/TRACKING_EVENTS_TYPE;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setEvent_Lorg_nexage_sourcekit_vast_model_TRACKING_EVENTS_TYPE_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEvent", "(Lorg/nexage/sourcekit/vast/model/TRACKING_EVENTS_TYPE;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.Tracking __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.Tracking> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value);
		}
#pragma warning restore 0169

		static Delegate cb_setValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetValue_Ljava_lang_String_Handler ()
		{
			if (cb_setValue_Ljava_lang_String_ == null)
				cb_setValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValue_Ljava_lang_String_);
			return cb_setValue_Ljava_lang_String_;
		}

		static void n_SetValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.Tracking __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.Tracking> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Value = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getValue;
		static IntPtr id_setValue_Ljava_lang_String_;
		public virtual unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='Tracking']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='Tracking']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setValue", "(Ljava/lang/String;)V", "GetSetValue_Ljava_lang_String_Handler")]
			set {
				if (id_setValue_Ljava_lang_String_ == IntPtr.Zero)
					id_setValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setValue", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setValue_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
