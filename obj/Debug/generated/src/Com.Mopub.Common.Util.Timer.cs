using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Timer']"
	[global::Android.Runtime.Register ("com/mopub/common/util/Timer", DoNotGenerateAcw=true)]
	public partial class Timer : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Timer.State']"
		[global::Android.Runtime.Register ("com/mopub/common/util/Timer$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {


			static IntPtr STARTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Timer.State']/field[@name='STARTED']"
			[Register ("STARTED")]
			public static global::Com.Mopub.Common.Util.Timer.State Started {
				get {
					if (STARTED_jfieldId == IntPtr.Zero)
						STARTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STARTED", "Lcom/mopub/common/util/Timer$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STARTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.Timer.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr STOPPED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Timer.State']/field[@name='STOPPED']"
			[Register ("STOPPED")]
			public static global::Com.Mopub.Common.Util.Timer.State Stopped {
				get {
					if (STOPPED_jfieldId == IntPtr.Zero)
						STOPPED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STOPPED", "Lcom/mopub/common/util/Timer$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STOPPED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.Timer.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/util/Timer$State", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (State); }
			}

			internal State (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/util/Timer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Timer); }
		}

		protected Timer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Timer']/constructor[@name='Timer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Timer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Timer)) {
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

		static Delegate cb_getTime;
#pragma warning disable 0169
		static Delegate GetGetTimeHandler ()
		{
			if (cb_getTime == null)
				cb_getTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTime);
			return cb_getTime;
		}

		static long n_GetTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Util.Timer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.Timer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Time;
		}
#pragma warning restore 0169

		static IntPtr id_getTime;
		public virtual unsafe long Time {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Timer']/method[@name='getTime' and count(parameter)=0]"
			[Register ("getTime", "()J", "GetGetTimeHandler")]
			get {
				if (id_getTime == IntPtr.Zero)
					id_getTime = JNIEnv.GetMethodID (class_ref, "getTime", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getTime);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTime", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Util.Timer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.Timer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Timer']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.Util.Timer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.Timer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Timer']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

	}
}
