using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley.Toolbox {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='RequestFuture']"
	[global::Android.Runtime.Register ("com/mopub/volley/toolbox/RequestFuture", DoNotGenerateAcw=true)]
	public partial class RequestFuture : global::Java.Lang.Object, global::Com.Mopub.Volley.Response.IErrorListener, global::Com.Mopub.Volley.Response.IListener, global::Java.Util.Concurrent.IFuture {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/toolbox/RequestFuture", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestFuture); }
		}

		protected RequestFuture (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isCancelled;
#pragma warning disable 0169
		static Delegate GetIsCancelledHandler ()
		{
			if (cb_isCancelled == null)
				cb_isCancelled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCancelled);
			return cb_isCancelled;
		}

		static bool n_IsCancelled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Toolbox.RequestFuture __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.RequestFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCancelled;
		}
#pragma warning restore 0169

		static IntPtr id_isCancelled;
		public virtual unsafe bool IsCancelled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='RequestFuture']/method[@name='isCancelled' and count(parameter)=0]"
			[Register ("isCancelled", "()Z", "GetIsCancelledHandler")]
			get {
				if (id_isCancelled == IntPtr.Zero)
					id_isCancelled = JNIEnv.GetMethodID (class_ref, "isCancelled", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isCancelled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCancelled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isDone;
#pragma warning disable 0169
		static Delegate GetIsDoneHandler ()
		{
			if (cb_isDone == null)
				cb_isDone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDone);
			return cb_isDone;
		}

		static bool n_IsDone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Toolbox.RequestFuture __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.RequestFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDone;
		}
#pragma warning restore 0169

		static IntPtr id_isDone;
		public virtual unsafe bool IsDone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='RequestFuture']/method[@name='isDone' and count(parameter)=0]"
			[Register ("isDone", "()Z", "GetIsDoneHandler")]
			get {
				if (id_isDone == IntPtr.Zero)
					id_isDone = JNIEnv.GetMethodID (class_ref, "isDone", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isDone);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDone", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_cancel_Z;
#pragma warning disable 0169
		static Delegate GetCancel_ZHandler ()
		{
			if (cb_cancel_Z == null)
				cb_cancel_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_Cancel_Z);
			return cb_cancel_Z;
		}

		static bool n_Cancel_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mopub.Volley.Toolbox.RequestFuture __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.RequestFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Cancel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_cancel_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='RequestFuture']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("cancel", "(Z)Z", "GetCancel_ZHandler")]
		public virtual unsafe bool Cancel (bool p0)
		{
			if (id_cancel_Z == IntPtr.Zero)
				id_cancel_Z = JNIEnv.GetMethodID (class_ref, "cancel", "(Z)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_cancel_Z, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "(Z)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get);
			return cb_get;
		}

		static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Toolbox.RequestFuture __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.RequestFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='RequestFuture']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/lang/Object;", "GetGetHandler")]
		public virtual unsafe global::Java.Lang.Object Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()Ljava/lang/Object;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetGet_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_get_JLjava_util_concurrent_TimeUnit_ == null)
				cb_get_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_Get_JLjava_util_concurrent_TimeUnit_);
			return cb_get_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_Get_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Mopub.Volley.Toolbox.RequestFuture __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.RequestFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='RequestFuture']/method[@name='get' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", "GetGet_JLjava_util_concurrent_TimeUnit_Handler")]
		public virtual unsafe global::Java.Lang.Object Get (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			if (id_get_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_get_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newFuture;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='RequestFuture']/method[@name='newFuture' and count(parameter)=0]"
		[Register ("newFuture", "()Lcom/mopub/volley/toolbox/RequestFuture;", "")]
		public static unsafe global::Com.Mopub.Volley.Toolbox.RequestFuture NewFuture ()
		{
			if (id_newFuture == IntPtr.Zero)
				id_newFuture = JNIEnv.GetStaticMethodID (class_ref, "newFuture", "()Lcom/mopub/volley/toolbox/RequestFuture;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.RequestFuture> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newFuture), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onErrorResponse_Lcom_mopub_volley_VolleyError_;
#pragma warning disable 0169
		static Delegate GetOnErrorResponse_Lcom_mopub_volley_VolleyError_Handler ()
		{
			if (cb_onErrorResponse_Lcom_mopub_volley_VolleyError_ == null)
				cb_onErrorResponse_Lcom_mopub_volley_VolleyError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnErrorResponse_Lcom_mopub_volley_VolleyError_);
			return cb_onErrorResponse_Lcom_mopub_volley_VolleyError_;
		}

		static void n_OnErrorResponse_Lcom_mopub_volley_VolleyError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Toolbox.RequestFuture __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.RequestFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.VolleyError p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.VolleyError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnErrorResponse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onErrorResponse_Lcom_mopub_volley_VolleyError_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='RequestFuture']/method[@name='onErrorResponse' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.VolleyError']]"
		[Register ("onErrorResponse", "(Lcom/mopub/volley/VolleyError;)V", "GetOnErrorResponse_Lcom_mopub_volley_VolleyError_Handler")]
		public virtual unsafe void OnErrorResponse (global::Com.Mopub.Volley.VolleyError p0)
		{
			if (id_onErrorResponse_Lcom_mopub_volley_VolleyError_ == IntPtr.Zero)
				id_onErrorResponse_Lcom_mopub_volley_VolleyError_ = JNIEnv.GetMethodID (class_ref, "onErrorResponse", "(Lcom/mopub/volley/VolleyError;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onErrorResponse_Lcom_mopub_volley_VolleyError_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onErrorResponse", "(Lcom/mopub/volley/VolleyError;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onResponse_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnResponse_Ljava_lang_Object_Handler ()
		{
			if (cb_onResponse_Ljava_lang_Object_ == null)
				cb_onResponse_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResponse_Ljava_lang_Object_);
			return cb_onResponse_Ljava_lang_Object_;
		}

		static void n_OnResponse_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Toolbox.RequestFuture __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.RequestFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResponse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onResponse_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='RequestFuture']/method[@name='onResponse' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("onResponse", "(Ljava/lang/Object;)V", "GetOnResponse_Ljava_lang_Object_Handler")]
		public virtual unsafe void OnResponse (global::Java.Lang.Object p0)
		{
			if (id_onResponse_Ljava_lang_Object_ == IntPtr.Zero)
				id_onResponse_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onResponse", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onResponse_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResponse", "(Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRequest_Lcom_mopub_volley_Request_;
#pragma warning disable 0169
		static Delegate GetSetRequest_Lcom_mopub_volley_Request_Handler ()
		{
			if (cb_setRequest_Lcom_mopub_volley_Request_ == null)
				cb_setRequest_Lcom_mopub_volley_Request_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRequest_Lcom_mopub_volley_Request_);
			return cb_setRequest_Lcom_mopub_volley_Request_;
		}

		static void n_SetRequest_Lcom_mopub_volley_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Toolbox.RequestFuture __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.RequestFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRequest (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRequest_Lcom_mopub_volley_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='RequestFuture']/method[@name='setRequest' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.Request']]"
		[Register ("setRequest", "(Lcom/mopub/volley/Request;)V", "GetSetRequest_Lcom_mopub_volley_Request_Handler")]
		public virtual unsafe void SetRequest (global::Com.Mopub.Volley.Request p0)
		{
			if (id_setRequest_Lcom_mopub_volley_Request_ == IntPtr.Zero)
				id_setRequest_Lcom_mopub_volley_Request_ = JNIEnv.GetMethodID (class_ref, "setRequest", "(Lcom/mopub/volley/Request;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRequest_Lcom_mopub_volley_Request_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequest", "(Lcom/mopub/volley/Request;)V"), __args);
			} finally {
			}
		}

	}
}
