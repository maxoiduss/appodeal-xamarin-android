using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.event']/class[@name='ErrorEvent']"
	[global::Android.Runtime.Register ("com/mopub/common/event/ErrorEvent", DoNotGenerateAcw=true)]
	public partial class ErrorEvent : global::Com.Mopub.Common.Event.BaseEvent {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.event']/class[@name='ErrorEvent.Builder']"
		[global::Android.Runtime.Register ("com/mopub/common/event/ErrorEvent$Builder", DoNotGenerateAcw=true)]
		public new partial class Builder : global::Com.Mopub.Common.Event.BaseEvent.Builder {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/event/ErrorEvent$Builder", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common.event']/class[@name='ErrorEvent.Builder']/constructor[@name='ErrorEvent.Builder' and count(parameter)=3 and parameter[1][@type='com.mopub.common.event.BaseEvent.Name'] and parameter[2][@type='com.mopub.common.event.BaseEvent.Category'] and parameter[3][@type='double']]"
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
				global::Com.Mopub.Common.Event.ErrorEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='ErrorEvent.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/mopub/common/event/ErrorEvent;", "GetBuildHandler")]
			public virtual unsafe global::Com.Mopub.Common.Event.ErrorEvent Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/mopub/common/event/ErrorEvent;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/mopub/common/event/ErrorEvent;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_withErrorClassName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithErrorClassName_Ljava_lang_String_Handler ()
			{
				if (cb_withErrorClassName_Ljava_lang_String_ == null)
					cb_withErrorClassName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithErrorClassName_Ljava_lang_String_);
				return cb_withErrorClassName_Ljava_lang_String_;
			}

			static IntPtr n_WithErrorClassName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.Event.ErrorEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithErrorClassName (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withErrorClassName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='ErrorEvent.Builder']/method[@name='withErrorClassName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("withErrorClassName", "(Ljava/lang/String;)Lcom/mopub/common/event/ErrorEvent$Builder;", "GetWithErrorClassName_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Event.ErrorEvent.Builder WithErrorClassName (string p0)
			{
				if (id_withErrorClassName_Ljava_lang_String_ == IntPtr.Zero)
					id_withErrorClassName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withErrorClassName", "(Ljava/lang/String;)Lcom/mopub/common/event/ErrorEvent$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Common.Event.ErrorEvent.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withErrorClassName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withErrorClassName", "(Ljava/lang/String;)Lcom/mopub/common/event/ErrorEvent$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_withErrorExceptionClassName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithErrorExceptionClassName_Ljava_lang_String_Handler ()
			{
				if (cb_withErrorExceptionClassName_Ljava_lang_String_ == null)
					cb_withErrorExceptionClassName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithErrorExceptionClassName_Ljava_lang_String_);
				return cb_withErrorExceptionClassName_Ljava_lang_String_;
			}

			static IntPtr n_WithErrorExceptionClassName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.Event.ErrorEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithErrorExceptionClassName (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withErrorExceptionClassName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='ErrorEvent.Builder']/method[@name='withErrorExceptionClassName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("withErrorExceptionClassName", "(Ljava/lang/String;)Lcom/mopub/common/event/ErrorEvent$Builder;", "GetWithErrorExceptionClassName_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Event.ErrorEvent.Builder WithErrorExceptionClassName (string p0)
			{
				if (id_withErrorExceptionClassName_Ljava_lang_String_ == IntPtr.Zero)
					id_withErrorExceptionClassName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withErrorExceptionClassName", "(Ljava/lang/String;)Lcom/mopub/common/event/ErrorEvent$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Common.Event.ErrorEvent.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withErrorExceptionClassName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withErrorExceptionClassName", "(Ljava/lang/String;)Lcom/mopub/common/event/ErrorEvent$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_withErrorFileName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithErrorFileName_Ljava_lang_String_Handler ()
			{
				if (cb_withErrorFileName_Ljava_lang_String_ == null)
					cb_withErrorFileName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithErrorFileName_Ljava_lang_String_);
				return cb_withErrorFileName_Ljava_lang_String_;
			}

			static IntPtr n_WithErrorFileName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.Event.ErrorEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithErrorFileName (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withErrorFileName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='ErrorEvent.Builder']/method[@name='withErrorFileName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("withErrorFileName", "(Ljava/lang/String;)Lcom/mopub/common/event/ErrorEvent$Builder;", "GetWithErrorFileName_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Event.ErrorEvent.Builder WithErrorFileName (string p0)
			{
				if (id_withErrorFileName_Ljava_lang_String_ == IntPtr.Zero)
					id_withErrorFileName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withErrorFileName", "(Ljava/lang/String;)Lcom/mopub/common/event/ErrorEvent$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Common.Event.ErrorEvent.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withErrorFileName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withErrorFileName", "(Ljava/lang/String;)Lcom/mopub/common/event/ErrorEvent$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_withErrorLineNumber_Ljava_lang_Integer_;
#pragma warning disable 0169
			static Delegate GetWithErrorLineNumber_Ljava_lang_Integer_Handler ()
			{
				if (cb_withErrorLineNumber_Ljava_lang_Integer_ == null)
					cb_withErrorLineNumber_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithErrorLineNumber_Ljava_lang_Integer_);
				return cb_withErrorLineNumber_Ljava_lang_Integer_;
			}

			static IntPtr n_WithErrorLineNumber_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.Event.ErrorEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithErrorLineNumber (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withErrorLineNumber_Ljava_lang_Integer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='ErrorEvent.Builder']/method[@name='withErrorLineNumber' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("withErrorLineNumber", "(Ljava/lang/Integer;)Lcom/mopub/common/event/ErrorEvent$Builder;", "GetWithErrorLineNumber_Ljava_lang_Integer_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Event.ErrorEvent.Builder WithErrorLineNumber (global::Java.Lang.Integer p0)
			{
				if (id_withErrorLineNumber_Ljava_lang_Integer_ == IntPtr.Zero)
					id_withErrorLineNumber_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "withErrorLineNumber", "(Ljava/lang/Integer;)Lcom/mopub/common/event/ErrorEvent$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mopub.Common.Event.ErrorEvent.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withErrorLineNumber_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withErrorLineNumber", "(Ljava/lang/Integer;)Lcom/mopub/common/event/ErrorEvent$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_withErrorMessage_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithErrorMessage_Ljava_lang_String_Handler ()
			{
				if (cb_withErrorMessage_Ljava_lang_String_ == null)
					cb_withErrorMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithErrorMessage_Ljava_lang_String_);
				return cb_withErrorMessage_Ljava_lang_String_;
			}

			static IntPtr n_WithErrorMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.Event.ErrorEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithErrorMessage (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withErrorMessage_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='ErrorEvent.Builder']/method[@name='withErrorMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("withErrorMessage", "(Ljava/lang/String;)Lcom/mopub/common/event/ErrorEvent$Builder;", "GetWithErrorMessage_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Event.ErrorEvent.Builder WithErrorMessage (string p0)
			{
				if (id_withErrorMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_withErrorMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withErrorMessage", "(Ljava/lang/String;)Lcom/mopub/common/event/ErrorEvent$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Common.Event.ErrorEvent.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withErrorMessage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withErrorMessage", "(Ljava/lang/String;)Lcom/mopub/common/event/ErrorEvent$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_withErrorMethodName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithErrorMethodName_Ljava_lang_String_Handler ()
			{
				if (cb_withErrorMethodName_Ljava_lang_String_ == null)
					cb_withErrorMethodName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithErrorMethodName_Ljava_lang_String_);
				return cb_withErrorMethodName_Ljava_lang_String_;
			}

			static IntPtr n_WithErrorMethodName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.Event.ErrorEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithErrorMethodName (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withErrorMethodName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='ErrorEvent.Builder']/method[@name='withErrorMethodName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("withErrorMethodName", "(Ljava/lang/String;)Lcom/mopub/common/event/ErrorEvent$Builder;", "GetWithErrorMethodName_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Event.ErrorEvent.Builder WithErrorMethodName (string p0)
			{
				if (id_withErrorMethodName_Ljava_lang_String_ == IntPtr.Zero)
					id_withErrorMethodName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withErrorMethodName", "(Ljava/lang/String;)Lcom/mopub/common/event/ErrorEvent$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Common.Event.ErrorEvent.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withErrorMethodName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withErrorMethodName", "(Ljava/lang/String;)Lcom/mopub/common/event/ErrorEvent$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_withErrorStackTrace_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithErrorStackTrace_Ljava_lang_String_Handler ()
			{
				if (cb_withErrorStackTrace_Ljava_lang_String_ == null)
					cb_withErrorStackTrace_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithErrorStackTrace_Ljava_lang_String_);
				return cb_withErrorStackTrace_Ljava_lang_String_;
			}

			static IntPtr n_WithErrorStackTrace_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.Event.ErrorEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithErrorStackTrace (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withErrorStackTrace_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='ErrorEvent.Builder']/method[@name='withErrorStackTrace' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("withErrorStackTrace", "(Ljava/lang/String;)Lcom/mopub/common/event/ErrorEvent$Builder;", "GetWithErrorStackTrace_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Event.ErrorEvent.Builder WithErrorStackTrace (string p0)
			{
				if (id_withErrorStackTrace_Ljava_lang_String_ == IntPtr.Zero)
					id_withErrorStackTrace_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withErrorStackTrace", "(Ljava/lang/String;)Lcom/mopub/common/event/ErrorEvent$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Common.Event.ErrorEvent.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withErrorStackTrace_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withErrorStackTrace", "(Ljava/lang/String;)Lcom/mopub/common/event/ErrorEvent$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_withException_Ljava_lang_Exception_;
#pragma warning disable 0169
			static Delegate GetWithException_Ljava_lang_Exception_Handler ()
			{
				if (cb_withException_Ljava_lang_Exception_ == null)
					cb_withException_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithException_Ljava_lang_Exception_);
				return cb_withException_Ljava_lang_Exception_;
			}

			static IntPtr n_WithException_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.Event.ErrorEvent.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithException (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withException_Ljava_lang_Exception_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='ErrorEvent.Builder']/method[@name='withException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
			[Register ("withException", "(Ljava/lang/Exception;)Lcom/mopub/common/event/ErrorEvent$Builder;", "GetWithException_Ljava_lang_Exception_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Event.ErrorEvent.Builder WithException (global::Java.Lang.Exception p0)
			{
				if (id_withException_Ljava_lang_Exception_ == IntPtr.Zero)
					id_withException_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "withException", "(Ljava/lang/Exception;)Lcom/mopub/common/event/ErrorEvent$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mopub.Common.Event.ErrorEvent.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withException_Ljava_lang_Exception_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withException", "(Ljava/lang/Exception;)Lcom/mopub/common/event/ErrorEvent$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/event/ErrorEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ErrorEvent); }
		}

		protected ErrorEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getErrorClassName;
#pragma warning disable 0169
		static Delegate GetGetErrorClassNameHandler ()
		{
			if (cb_getErrorClassName == null)
				cb_getErrorClassName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorClassName);
			return cb_getErrorClassName;
		}

		static IntPtr n_GetErrorClassName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.ErrorEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorClassName);
		}
#pragma warning restore 0169

		static IntPtr id_getErrorClassName;
		public virtual unsafe string ErrorClassName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='ErrorEvent']/method[@name='getErrorClassName' and count(parameter)=0]"
			[Register ("getErrorClassName", "()Ljava/lang/String;", "GetGetErrorClassNameHandler")]
			get {
				if (id_getErrorClassName == IntPtr.Zero)
					id_getErrorClassName = JNIEnv.GetMethodID (class_ref, "getErrorClassName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getErrorClassName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorClassName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getErrorExceptionClassName;
#pragma warning disable 0169
		static Delegate GetGetErrorExceptionClassNameHandler ()
		{
			if (cb_getErrorExceptionClassName == null)
				cb_getErrorExceptionClassName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorExceptionClassName);
			return cb_getErrorExceptionClassName;
		}

		static IntPtr n_GetErrorExceptionClassName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.ErrorEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorExceptionClassName);
		}
#pragma warning restore 0169

		static IntPtr id_getErrorExceptionClassName;
		public virtual unsafe string ErrorExceptionClassName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='ErrorEvent']/method[@name='getErrorExceptionClassName' and count(parameter)=0]"
			[Register ("getErrorExceptionClassName", "()Ljava/lang/String;", "GetGetErrorExceptionClassNameHandler")]
			get {
				if (id_getErrorExceptionClassName == IntPtr.Zero)
					id_getErrorExceptionClassName = JNIEnv.GetMethodID (class_ref, "getErrorExceptionClassName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getErrorExceptionClassName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorExceptionClassName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getErrorFileName;
#pragma warning disable 0169
		static Delegate GetGetErrorFileNameHandler ()
		{
			if (cb_getErrorFileName == null)
				cb_getErrorFileName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorFileName);
			return cb_getErrorFileName;
		}

		static IntPtr n_GetErrorFileName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.ErrorEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorFileName);
		}
#pragma warning restore 0169

		static IntPtr id_getErrorFileName;
		public virtual unsafe string ErrorFileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='ErrorEvent']/method[@name='getErrorFileName' and count(parameter)=0]"
			[Register ("getErrorFileName", "()Ljava/lang/String;", "GetGetErrorFileNameHandler")]
			get {
				if (id_getErrorFileName == IntPtr.Zero)
					id_getErrorFileName = JNIEnv.GetMethodID (class_ref, "getErrorFileName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getErrorFileName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorFileName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getErrorLineNumber;
#pragma warning disable 0169
		static Delegate GetGetErrorLineNumberHandler ()
		{
			if (cb_getErrorLineNumber == null)
				cb_getErrorLineNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorLineNumber);
			return cb_getErrorLineNumber;
		}

		static IntPtr n_GetErrorLineNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.ErrorEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ErrorLineNumber);
		}
#pragma warning restore 0169

		static IntPtr id_getErrorLineNumber;
		public virtual unsafe global::Java.Lang.Integer ErrorLineNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='ErrorEvent']/method[@name='getErrorLineNumber' and count(parameter)=0]"
			[Register ("getErrorLineNumber", "()Ljava/lang/Integer;", "GetGetErrorLineNumberHandler")]
			get {
				if (id_getErrorLineNumber == IntPtr.Zero)
					id_getErrorLineNumber = JNIEnv.GetMethodID (class_ref, "getErrorLineNumber", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getErrorLineNumber), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorLineNumber", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getErrorMessage;
#pragma warning disable 0169
		static Delegate GetGetErrorMessageHandler ()
		{
			if (cb_getErrorMessage == null)
				cb_getErrorMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorMessage);
			return cb_getErrorMessage;
		}

		static IntPtr n_GetErrorMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.ErrorEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorMessage);
		}
#pragma warning restore 0169

		static IntPtr id_getErrorMessage;
		public virtual unsafe string ErrorMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='ErrorEvent']/method[@name='getErrorMessage' and count(parameter)=0]"
			[Register ("getErrorMessage", "()Ljava/lang/String;", "GetGetErrorMessageHandler")]
			get {
				if (id_getErrorMessage == IntPtr.Zero)
					id_getErrorMessage = JNIEnv.GetMethodID (class_ref, "getErrorMessage", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getErrorMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getErrorMethodName;
#pragma warning disable 0169
		static Delegate GetGetErrorMethodNameHandler ()
		{
			if (cb_getErrorMethodName == null)
				cb_getErrorMethodName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorMethodName);
			return cb_getErrorMethodName;
		}

		static IntPtr n_GetErrorMethodName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.ErrorEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorMethodName);
		}
#pragma warning restore 0169

		static IntPtr id_getErrorMethodName;
		public virtual unsafe string ErrorMethodName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='ErrorEvent']/method[@name='getErrorMethodName' and count(parameter)=0]"
			[Register ("getErrorMethodName", "()Ljava/lang/String;", "GetGetErrorMethodNameHandler")]
			get {
				if (id_getErrorMethodName == IntPtr.Zero)
					id_getErrorMethodName = JNIEnv.GetMethodID (class_ref, "getErrorMethodName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getErrorMethodName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorMethodName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getErrorStackTrace;
#pragma warning disable 0169
		static Delegate GetGetErrorStackTraceHandler ()
		{
			if (cb_getErrorStackTrace == null)
				cb_getErrorStackTrace = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorStackTrace);
			return cb_getErrorStackTrace;
		}

		static IntPtr n_GetErrorStackTrace (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Event.ErrorEvent __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Event.ErrorEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorStackTrace);
		}
#pragma warning restore 0169

		static IntPtr id_getErrorStackTrace;
		public virtual unsafe string ErrorStackTrace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='ErrorEvent']/method[@name='getErrorStackTrace' and count(parameter)=0]"
			[Register ("getErrorStackTrace", "()Ljava/lang/String;", "GetGetErrorStackTraceHandler")]
			get {
				if (id_getErrorStackTrace == IntPtr.Zero)
					id_getErrorStackTrace = JNIEnv.GetMethodID (class_ref, "getErrorStackTrace", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getErrorStackTrace), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorStackTrace", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
