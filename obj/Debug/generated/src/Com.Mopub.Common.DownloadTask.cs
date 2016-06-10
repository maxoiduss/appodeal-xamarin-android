using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='DownloadTask']"
	[global::Android.Runtime.Register ("com/mopub/common/DownloadTask", DoNotGenerateAcw=true)]
	public partial class DownloadTask : global::Android.OS.AsyncTask {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.common']/interface[@name='DownloadTask.DownloadTaskListener']"
		[Register ("com/mopub/common/DownloadTask$DownloadTaskListener", "", "Com.Mopub.Common.DownloadTask/IDownloadTaskListenerInvoker")]
		public partial interface IDownloadTaskListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/interface[@name='DownloadTask.DownloadTaskListener']/method[@name='onComplete' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.common.DownloadResponse']]"
			[Register ("onComplete", "(Ljava/lang/String;Lcom/mopub/common/DownloadResponse;)V", "GetOnComplete_Ljava_lang_String_Lcom_mopub_common_DownloadResponse_Handler:Com.Mopub.Common.DownloadTask/IDownloadTaskListenerInvoker, AppodealXamarinPlugin")]
			void OnComplete (string p0, global::Com.Mopub.Common.DownloadResponse p1);

		}

		[global::Android.Runtime.Register ("com/mopub/common/DownloadTask$DownloadTaskListener", DoNotGenerateAcw=true)]
		internal class IDownloadTaskListenerInvoker : global::Java.Lang.Object, IDownloadTaskListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/common/DownloadTask$DownloadTaskListener");
			IntPtr class_ref;

			public static IDownloadTaskListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDownloadTaskListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.common.DownloadTask.DownloadTaskListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDownloadTaskListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IDownloadTaskListenerInvoker); }
			}

			static Delegate cb_onComplete_Ljava_lang_String_Lcom_mopub_common_DownloadResponse_;
#pragma warning disable 0169
			static Delegate GetOnComplete_Ljava_lang_String_Lcom_mopub_common_DownloadResponse_Handler ()
			{
				if (cb_onComplete_Ljava_lang_String_Lcom_mopub_common_DownloadResponse_ == null)
					cb_onComplete_Ljava_lang_String_Lcom_mopub_common_DownloadResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnComplete_Ljava_lang_String_Lcom_mopub_common_DownloadResponse_);
				return cb_onComplete_Ljava_lang_String_Lcom_mopub_common_DownloadResponse_;
			}

			static void n_OnComplete_Ljava_lang_String_Lcom_mopub_common_DownloadResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mopub.Common.DownloadTask.IDownloadTaskListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.DownloadTask.IDownloadTaskListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Common.DownloadResponse p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.DownloadResponse> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnComplete (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onComplete_Ljava_lang_String_Lcom_mopub_common_DownloadResponse_;
			public unsafe void OnComplete (string p0, global::Com.Mopub.Common.DownloadResponse p1)
			{
				if (id_onComplete_Ljava_lang_String_Lcom_mopub_common_DownloadResponse_ == IntPtr.Zero)
					id_onComplete_Ljava_lang_String_Lcom_mopub_common_DownloadResponse_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Ljava/lang/String;Lcom/mopub/common/DownloadResponse;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_onComplete_Ljava_lang_String_Lcom_mopub_common_DownloadResponse_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		public partial class DownloadTaskEventArgs : global::System.EventArgs {

			public DownloadTaskEventArgs (string p0, global::Com.Mopub.Common.DownloadResponse p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}

			global::Com.Mopub.Common.DownloadResponse p1;
			public global::Com.Mopub.Common.DownloadResponse P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/common/DownloadTask_DownloadTaskListenerImplementor")]
		internal sealed partial class IDownloadTaskListenerImplementor : global::Java.Lang.Object, IDownloadTaskListener {

			object sender;

			public IDownloadTaskListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/common/DownloadTask_DownloadTaskListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DownloadTaskEventArgs> Handler;
#pragma warning restore 0649

			public void OnComplete (string p0, global::Com.Mopub.Common.DownloadResponse p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new DownloadTaskEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IDownloadTaskListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/DownloadTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DownloadTask); }
		}

		protected DownloadTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mopub_common_DownloadTask_DownloadTaskListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common']/class[@name='DownloadTask']/constructor[@name='DownloadTask' and count(parameter)=1 and parameter[1][@type='com.mopub.common.DownloadTask.DownloadTaskListener']]"
		[Register (".ctor", "(Lcom/mopub/common/DownloadTask$DownloadTaskListener;)V", "")]
		public unsafe DownloadTask (global::Com.Mopub.Common.DownloadTask.IDownloadTaskListener p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DownloadTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/common/DownloadTask$DownloadTaskListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/common/DownloadTask$DownloadTaskListener;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mopub_common_DownloadTask_DownloadTaskListener_ == IntPtr.Zero)
					id_ctor_Lcom_mopub_common_DownloadTask_DownloadTaskListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/common/DownloadTask$DownloadTaskListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_common_DownloadTask_DownloadTaskListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_common_DownloadTask_DownloadTaskListener_, __args);
			} finally {
			}
		}

		static Delegate cb_doInBackground_arrayLorg_apache_http_client_methods_HttpUriRequest_;
#pragma warning disable 0169
		static Delegate GetDoInBackground_arrayLorg_apache_http_client_methods_HttpUriRequest_Handler ()
		{
			if (cb_doInBackground_arrayLorg_apache_http_client_methods_HttpUriRequest_ == null)
				cb_doInBackground_arrayLorg_apache_http_client_methods_HttpUriRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLorg_apache_http_client_methods_HttpUriRequest_);
			return cb_doInBackground_arrayLorg_apache_http_client_methods_HttpUriRequest_;
		}

		static IntPtr n_DoInBackground_arrayLorg_apache_http_client_methods_HttpUriRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.DownloadTask __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.DownloadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Http.Client.Methods.IHttpUriRequest[] p0 = (global::Org.Apache.Http.Client.Methods.IHttpUriRequest[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Apache.Http.Client.Methods.IHttpUriRequest));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_doInBackground_arrayLorg_apache_http_client_methods_HttpUriRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='DownloadTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='org.apache.http.client.methods.HttpUriRequest...']]"
		[Register ("doInBackground", "([Lorg/apache/http/client/methods/HttpUriRequest;)Lcom/mopub/common/DownloadResponse;", "GetDoInBackground_arrayLorg_apache_http_client_methods_HttpUriRequest_Handler")]
		protected virtual unsafe global::Com.Mopub.Common.DownloadResponse DoInBackground (params global:: Org.Apache.Http.Client.Methods.IHttpUriRequest[] p0)
		{
			if (id_doInBackground_arrayLorg_apache_http_client_methods_HttpUriRequest_ == IntPtr.Zero)
				id_doInBackground_arrayLorg_apache_http_client_methods_HttpUriRequest_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Lorg/apache/http/client/methods/HttpUriRequest;)Lcom/mopub/common/DownloadResponse;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mopub.Common.DownloadResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.DownloadResponse> (JNIEnv.CallObjectMethod  (Handle, id_doInBackground_arrayLorg_apache_http_client_methods_HttpUriRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.DownloadResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Lorg/apache/http/client/methods/HttpUriRequest;)Lcom/mopub/common/DownloadResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_onPostExecute_Lcom_mopub_common_DownloadResponse_;
#pragma warning disable 0169
		static Delegate GetOnPostExecute_Lcom_mopub_common_DownloadResponse_Handler ()
		{
			if (cb_onPostExecute_Lcom_mopub_common_DownloadResponse_ == null)
				cb_onPostExecute_Lcom_mopub_common_DownloadResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPostExecute_Lcom_mopub_common_DownloadResponse_);
			return cb_onPostExecute_Lcom_mopub_common_DownloadResponse_;
		}

		static void n_OnPostExecute_Lcom_mopub_common_DownloadResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.DownloadTask __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.DownloadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Common.DownloadResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.DownloadResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPostExecute (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPostExecute_Lcom_mopub_common_DownloadResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='DownloadTask']/method[@name='onPostExecute' and count(parameter)=1 and parameter[1][@type='com.mopub.common.DownloadResponse']]"
		[Register ("onPostExecute", "(Lcom/mopub/common/DownloadResponse;)V", "GetOnPostExecute_Lcom_mopub_common_DownloadResponse_Handler")]
		protected virtual unsafe void OnPostExecute (global::Com.Mopub.Common.DownloadResponse p0)
		{
			if (id_onPostExecute_Lcom_mopub_common_DownloadResponse_ == IntPtr.Zero)
				id_onPostExecute_Lcom_mopub_common_DownloadResponse_ = JNIEnv.GetMethodID (class_ref, "onPostExecute", "(Lcom/mopub/common/DownloadResponse;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onPostExecute_Lcom_mopub_common_DownloadResponse_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPostExecute", "(Lcom/mopub/common/DownloadResponse;)V"), __args);
			} finally {
			}
		}

	}
}
