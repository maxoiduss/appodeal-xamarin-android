using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='AsyncTasks']"
	[global::Android.Runtime.Register ("com/mopub/common/util/AsyncTasks", DoNotGenerateAcw=true)]
	public partial class AsyncTasks : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/util/AsyncTasks", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncTasks); }
		}

		protected AsyncTasks (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common.util']/class[@name='AsyncTasks']/constructor[@name='AsyncTasks' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AsyncTasks ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AsyncTasks)) {
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

		static IntPtr id_safeExecuteOnExecutor_Landroid_os_AsyncTask_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='AsyncTasks']/method[@name='safeExecuteOnExecutor' and count(parameter)=2 and parameter[1][@type='android.os.AsyncTask'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("safeExecuteOnExecutor", "(Landroid/os/AsyncTask;[Ljava/lang/Object;)V", "")]
		public static unsafe void SafeExecuteOnExecutor (global::Android.OS.AsyncTask p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_safeExecuteOnExecutor_Landroid_os_AsyncTask_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_safeExecuteOnExecutor_Landroid_os_AsyncTask_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "safeExecuteOnExecutor", "(Landroid/os/AsyncTask;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_safeExecuteOnExecutor_Landroid_os_AsyncTask_arrayLjava_lang_Object_, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_setExecutor_Ljava_util_concurrent_Executor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='AsyncTasks']/method[@name='setExecutor' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Executor']]"
		[Register ("setExecutor", "(Ljava/util/concurrent/Executor;)V", "")]
		public static unsafe void SetExecutor (global::Java.Util.Concurrent.IExecutor p0)
		{
			if (id_setExecutor_Ljava_util_concurrent_Executor_ == IntPtr.Zero)
				id_setExecutor_Ljava_util_concurrent_Executor_ = JNIEnv.GetStaticMethodID (class_ref, "setExecutor", "(Ljava/util/concurrent/Executor;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setExecutor_Ljava_util_concurrent_Executor_, __args);
			} finally {
			}
		}

	}
}
