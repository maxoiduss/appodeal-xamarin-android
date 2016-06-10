using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='RepeatingHandlerRunnable']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/RepeatingHandlerRunnable", DoNotGenerateAcw=true)]
	public abstract partial class RepeatingHandlerRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {


		static IntPtr mHandler_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='RepeatingHandlerRunnable']/field[@name='mHandler']"
		[Register ("mHandler")]
		protected global::Android.OS.Handler MHandler {
			get {
				if (mHandler_jfieldId == IntPtr.Zero)
					mHandler_jfieldId = JNIEnv.GetFieldID (class_ref, "mHandler", "Landroid/os/Handler;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mHandler_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mHandler_jfieldId == IntPtr.Zero)
					mHandler_jfieldId = JNIEnv.GetFieldID (class_ref, "mHandler", "Landroid/os/Handler;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mHandler_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/RepeatingHandlerRunnable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RepeatingHandlerRunnable); }
		}

		protected RepeatingHandlerRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_doWork;
#pragma warning disable 0169
		static Delegate GetDoWorkHandler ()
		{
			if (cb_doWork == null)
				cb_doWork = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DoWork);
			return cb_doWork;
		}

		static void n_DoWork (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.RepeatingHandlerRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.RepeatingHandlerRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoWork ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='RepeatingHandlerRunnable']/method[@name='doWork' and count(parameter)=0]"
		[Register ("doWork", "()V", "GetDoWorkHandler")]
		public abstract void DoWork ();

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
			global::Com.Mopub.Mobileads.RepeatingHandlerRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.RepeatingHandlerRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='RepeatingHandlerRunnable']/method[@name='run' and count(parameter)=0]"
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

		static Delegate cb_startRepeating_J;
#pragma warning disable 0169
		static Delegate GetStartRepeating_JHandler ()
		{
			if (cb_startRepeating_J == null)
				cb_startRepeating_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_StartRepeating_J);
			return cb_startRepeating_J;
		}

		static void n_StartRepeating_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Mopub.Mobileads.RepeatingHandlerRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.RepeatingHandlerRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartRepeating (p0);
		}
#pragma warning restore 0169

		static IntPtr id_startRepeating_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='RepeatingHandlerRunnable']/method[@name='startRepeating' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("startRepeating", "(J)V", "GetStartRepeating_JHandler")]
		public virtual unsafe void StartRepeating (long p0)
		{
			if (id_startRepeating_J == IntPtr.Zero)
				id_startRepeating_J = JNIEnv.GetMethodID (class_ref, "startRepeating", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startRepeating_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startRepeating", "(J)V"), __args);
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
			global::Com.Mopub.Mobileads.RepeatingHandlerRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.RepeatingHandlerRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='RepeatingHandlerRunnable']/method[@name='stop' and count(parameter)=0]"
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

	[global::Android.Runtime.Register ("com/mopub/mobileads/RepeatingHandlerRunnable", DoNotGenerateAcw=true)]
	internal partial class RepeatingHandlerRunnableInvoker : RepeatingHandlerRunnable {

		public RepeatingHandlerRunnableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (RepeatingHandlerRunnableInvoker); }
		}

		static IntPtr id_doWork;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='RepeatingHandlerRunnable']/method[@name='doWork' and count(parameter)=0]"
		[Register ("doWork", "()V", "GetDoWorkHandler")]
		public override unsafe void DoWork ()
		{
			if (id_doWork == IntPtr.Zero)
				id_doWork = JNIEnv.GetMethodID (class_ref, "doWork", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_doWork);
			} finally {
			}
		}

	}

}
