using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley']/class[@name='ExecutorDelivery']"
	[global::Android.Runtime.Register ("com/mopub/volley/ExecutorDelivery", DoNotGenerateAcw=true)]
	public partial class ExecutorDelivery : global::Java.Lang.Object, global::Com.Mopub.Volley.IResponseDelivery {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley']/class[@name='ExecutorDelivery.ResponseDeliveryRunnable']"
		[global::Android.Runtime.Register ("com/mopub/volley/ExecutorDelivery$ResponseDeliveryRunnable", DoNotGenerateAcw=true)]
		public partial class ResponseDeliveryRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/volley/ExecutorDelivery$ResponseDeliveryRunnable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ResponseDeliveryRunnable); }
			}

			protected ResponseDeliveryRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_mopub_volley_ExecutorDelivery_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='ExecutorDelivery.ResponseDeliveryRunnable']/constructor[@name='ExecutorDelivery.ResponseDeliveryRunnable' and count(parameter)=4 and parameter[1][@type='com.mopub.volley.ExecutorDelivery'] and parameter[2][@type='com.mopub.volley.Request'] and parameter[3][@type='com.mopub.volley.Response'] and parameter[4][@type='java.lang.Runnable']]"
			[Register (".ctor", "(Lcom/mopub/volley/ExecutorDelivery;Lcom/mopub/volley/Request;Lcom/mopub/volley/Response;Ljava/lang/Runnable;)V", "")]
			public unsafe ResponseDeliveryRunnable (global::Com.Mopub.Volley.ExecutorDelivery __self, global::Com.Mopub.Volley.Request p1, global::Com.Mopub.Volley.Response p2, global::Java.Lang.IRunnable p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					if (GetType () != typeof (ResponseDeliveryRunnable)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/mopub/volley/Request;Lcom/mopub/volley/Response;Ljava/lang/Runnable;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/mopub/volley/Request;Lcom/mopub/volley/Response;Ljava/lang/Runnable;)V", __args);
						return;
					}

					if (id_ctor_Lcom_mopub_volley_ExecutorDelivery_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_ == IntPtr.Zero)
						id_ctor_Lcom_mopub_volley_ExecutorDelivery_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/volley/ExecutorDelivery;Lcom/mopub/volley/Request;Lcom/mopub/volley/Response;Ljava/lang/Runnable;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_volley_ExecutorDelivery_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_volley_ExecutorDelivery_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_, __args);
				} finally {
				}
			}

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
				global::Com.Mopub.Volley.ExecutorDelivery.ResponseDeliveryRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.ExecutorDelivery.ResponseDeliveryRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='ExecutorDelivery.ResponseDeliveryRunnable']/method[@name='run' and count(parameter)=0]"
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
				return JNIEnv.FindClass ("com/mopub/volley/ExecutorDelivery", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExecutorDelivery); }
		}

		protected ExecutorDelivery (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Handler_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='ExecutorDelivery']/constructor[@name='ExecutorDelivery' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
		[Register (".ctor", "(Landroid/os/Handler;)V", "")]
		public unsafe ExecutorDelivery (global::Android.OS.Handler p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ExecutorDelivery)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Handler;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Handler;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Handler_ == IntPtr.Zero)
					id_ctor_Landroid_os_Handler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Handler;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Handler_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Handler_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_util_concurrent_Executor_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='ExecutorDelivery']/constructor[@name='ExecutorDelivery' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Executor']]"
		[Register (".ctor", "(Ljava/util/concurrent/Executor;)V", "")]
		public unsafe ExecutorDelivery (global::Java.Util.Concurrent.IExecutor p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ExecutorDelivery)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/concurrent/Executor;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/concurrent/Executor;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_concurrent_Executor_ == IntPtr.Zero)
					id_ctor_Ljava_util_concurrent_Executor_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/concurrent/Executor;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_concurrent_Executor_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_concurrent_Executor_, __args);
			} finally {
			}
		}

		static Delegate cb_postError_Lcom_mopub_volley_Request_Lcom_mopub_volley_VolleyError_;
#pragma warning disable 0169
		static Delegate GetPostError_Lcom_mopub_volley_Request_Lcom_mopub_volley_VolleyError_Handler ()
		{
			if (cb_postError_Lcom_mopub_volley_Request_Lcom_mopub_volley_VolleyError_ == null)
				cb_postError_Lcom_mopub_volley_Request_Lcom_mopub_volley_VolleyError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PostError_Lcom_mopub_volley_Request_Lcom_mopub_volley_VolleyError_);
			return cb_postError_Lcom_mopub_volley_Request_Lcom_mopub_volley_VolleyError_;
		}

		static void n_PostError_Lcom_mopub_volley_Request_Lcom_mopub_volley_VolleyError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Volley.ExecutorDelivery __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.ExecutorDelivery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.VolleyError p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.VolleyError> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PostError (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_postError_Lcom_mopub_volley_Request_Lcom_mopub_volley_VolleyError_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='ExecutorDelivery']/method[@name='postError' and count(parameter)=2 and parameter[1][@type='com.mopub.volley.Request'] and parameter[2][@type='com.mopub.volley.VolleyError']]"
		[Register ("postError", "(Lcom/mopub/volley/Request;Lcom/mopub/volley/VolleyError;)V", "GetPostError_Lcom_mopub_volley_Request_Lcom_mopub_volley_VolleyError_Handler")]
		public virtual unsafe void PostError (global::Com.Mopub.Volley.Request p0, global::Com.Mopub.Volley.VolleyError p1)
		{
			if (id_postError_Lcom_mopub_volley_Request_Lcom_mopub_volley_VolleyError_ == IntPtr.Zero)
				id_postError_Lcom_mopub_volley_Request_Lcom_mopub_volley_VolleyError_ = JNIEnv.GetMethodID (class_ref, "postError", "(Lcom/mopub/volley/Request;Lcom/mopub/volley/VolleyError;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_postError_Lcom_mopub_volley_Request_Lcom_mopub_volley_VolleyError_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postError", "(Lcom/mopub/volley/Request;Lcom/mopub/volley/VolleyError;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_;
#pragma warning disable 0169
		static Delegate GetPostResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Handler ()
		{
			if (cb_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_ == null)
				cb_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PostResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_);
			return cb_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_;
		}

		static void n_PostResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Volley.ExecutorDelivery __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.ExecutorDelivery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.Response p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Response> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PostResponse (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='ExecutorDelivery']/method[@name='postResponse' and count(parameter)=2 and parameter[1][@type='com.mopub.volley.Request'] and parameter[2][@type='com.mopub.volley.Response']]"
		[Register ("postResponse", "(Lcom/mopub/volley/Request;Lcom/mopub/volley/Response;)V", "GetPostResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Handler")]
		public virtual unsafe void PostResponse (global::Com.Mopub.Volley.Request p0, global::Com.Mopub.Volley.Response p1)
		{
			if (id_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_ == IntPtr.Zero)
				id_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_ = JNIEnv.GetMethodID (class_ref, "postResponse", "(Lcom/mopub/volley/Request;Lcom/mopub/volley/Response;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postResponse", "(Lcom/mopub/volley/Request;Lcom/mopub/volley/Response;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetPostResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_Handler ()
		{
			if (cb_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_ == null)
				cb_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PostResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_);
			return cb_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_;
		}

		static void n_PostResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mopub.Volley.ExecutorDelivery __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.ExecutorDelivery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.Response p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Response> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p2 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.PostResponse (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='ExecutorDelivery']/method[@name='postResponse' and count(parameter)=3 and parameter[1][@type='com.mopub.volley.Request'] and parameter[2][@type='com.mopub.volley.Response'] and parameter[3][@type='java.lang.Runnable']]"
		[Register ("postResponse", "(Lcom/mopub/volley/Request;Lcom/mopub/volley/Response;Ljava/lang/Runnable;)V", "GetPostResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_Handler")]
		public virtual unsafe void PostResponse (global::Com.Mopub.Volley.Request p0, global::Com.Mopub.Volley.Response p1, global::Java.Lang.IRunnable p2)
		{
			if (id_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "postResponse", "(Lcom/mopub/volley/Request;Lcom/mopub/volley/Response;Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_postResponse_Lcom_mopub_volley_Request_Lcom_mopub_volley_Response_Ljava_lang_Runnable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postResponse", "(Lcom/mopub/volley/Request;Lcom/mopub/volley/Response;Ljava/lang/Runnable;)V"), __args);
			} finally {
			}
		}

	}
}
