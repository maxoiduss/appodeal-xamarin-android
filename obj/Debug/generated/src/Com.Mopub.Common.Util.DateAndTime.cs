using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DateAndTime']"
	[global::Android.Runtime.Register ("com/mopub/common/util/DateAndTime", DoNotGenerateAcw=true)]
	public partial class DateAndTime : global::Java.Lang.Object {


		static IntPtr instance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DateAndTime']/field[@name='instance']"
		[Register ("instance")]
		protected static global::Com.Mopub.Common.Util.DateAndTime Instance {
			get {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/common/util/DateAndTime;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, instance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.DateAndTime> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/common/util/DateAndTime;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, instance_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/util/DateAndTime", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DateAndTime); }
		}

		protected DateAndTime (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DateAndTime']/constructor[@name='DateAndTime' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DateAndTime ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DateAndTime)) {
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

		static IntPtr id_getTimeZoneOffsetString;
		public static unsafe string TimeZoneOffsetString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DateAndTime']/method[@name='getTimeZoneOffsetString' and count(parameter)=0]"
			[Register ("getTimeZoneOffsetString", "()Ljava/lang/String;", "GetGetTimeZoneOffsetStringHandler")]
			get {
				if (id_getTimeZoneOffsetString == IntPtr.Zero)
					id_getTimeZoneOffsetString = JNIEnv.GetStaticMethodID (class_ref, "getTimeZoneOffsetString", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTimeZoneOffsetString), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_internalLocalTimeZone;
#pragma warning disable 0169
		static Delegate GetInternalLocalTimeZoneHandler ()
		{
			if (cb_internalLocalTimeZone == null)
				cb_internalLocalTimeZone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InternalLocalTimeZone);
			return cb_internalLocalTimeZone;
		}

		static IntPtr n_InternalLocalTimeZone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Util.DateAndTime __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.DateAndTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InternalLocalTimeZone ());
		}
#pragma warning restore 0169

		static IntPtr id_internalLocalTimeZone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DateAndTime']/method[@name='internalLocalTimeZone' and count(parameter)=0]"
		[Register ("internalLocalTimeZone", "()Ljava/util/TimeZone;", "GetInternalLocalTimeZoneHandler")]
		public virtual unsafe global::Java.Util.TimeZone InternalLocalTimeZone ()
		{
			if (id_internalLocalTimeZone == IntPtr.Zero)
				id_internalLocalTimeZone = JNIEnv.GetMethodID (class_ref, "internalLocalTimeZone", "()Ljava/util/TimeZone;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (JNIEnv.CallObjectMethod  (Handle, id_internalLocalTimeZone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "internalLocalTimeZone", "()Ljava/util/TimeZone;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_internalNow;
#pragma warning disable 0169
		static Delegate GetInternalNowHandler ()
		{
			if (cb_internalNow == null)
				cb_internalNow = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InternalNow);
			return cb_internalNow;
		}

		static IntPtr n_InternalNow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Util.DateAndTime __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.DateAndTime> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InternalNow ());
		}
#pragma warning restore 0169

		static IntPtr id_internalNow;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DateAndTime']/method[@name='internalNow' and count(parameter)=0]"
		[Register ("internalNow", "()Ljava/util/Date;", "GetInternalNowHandler")]
		public virtual unsafe global::Java.Util.Date InternalNow ()
		{
			if (id_internalNow == IntPtr.Zero)
				id_internalNow = JNIEnv.GetMethodID (class_ref, "internalNow", "()Ljava/util/Date;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_internalNow), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "internalNow", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_localTimeZone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DateAndTime']/method[@name='localTimeZone' and count(parameter)=0]"
		[Register ("localTimeZone", "()Ljava/util/TimeZone;", "")]
		public static unsafe global::Java.Util.TimeZone LocalTimeZone ()
		{
			if (id_localTimeZone == IntPtr.Zero)
				id_localTimeZone = JNIEnv.GetStaticMethodID (class_ref, "localTimeZone", "()Ljava/util/TimeZone;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (JNIEnv.CallStaticObjectMethod  (class_ref, id_localTimeZone), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_now;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DateAndTime']/method[@name='now' and count(parameter)=0]"
		[Register ("now", "()Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date Now ()
		{
			if (id_now == IntPtr.Zero)
				id_now = JNIEnv.GetStaticMethodID (class_ref, "now", "()Ljava/util/Date;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_now), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setInstance_Lcom_mopub_common_util_DateAndTime_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='DateAndTime']/method[@name='setInstance' and count(parameter)=1 and parameter[1][@type='com.mopub.common.util.DateAndTime']]"
		[Obsolete (@"deprecated")]
		[Register ("setInstance", "(Lcom/mopub/common/util/DateAndTime;)V", "")]
		public static unsafe void SetInstance (global::Com.Mopub.Common.Util.DateAndTime p0)
		{
			if (id_setInstance_Lcom_mopub_common_util_DateAndTime_ == IntPtr.Zero)
				id_setInstance_Lcom_mopub_common_util_DateAndTime_ = JNIEnv.GetStaticMethodID (class_ref, "setInstance", "(Lcom/mopub/common/util/DateAndTime;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setInstance_Lcom_mopub_common_util_DateAndTime_, __args);
			} finally {
			}
		}

	}
}
