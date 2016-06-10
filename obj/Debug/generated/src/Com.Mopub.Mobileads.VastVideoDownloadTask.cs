using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoDownloadTask']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/VastVideoDownloadTask", DoNotGenerateAcw=true)]
	public partial class VastVideoDownloadTask : global::Android.OS.AsyncTask {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='VastVideoDownloadTask.VastVideoDownloadTaskListener']"
		[Register ("com/mopub/mobileads/VastVideoDownloadTask$VastVideoDownloadTaskListener", "", "Com.Mopub.Mobileads.VastVideoDownloadTask/IVastVideoDownloadTaskListenerInvoker")]
		public partial interface IVastVideoDownloadTaskListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='VastVideoDownloadTask.VastVideoDownloadTaskListener']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("onComplete", "(Z)V", "GetOnComplete_ZHandler:Com.Mopub.Mobileads.VastVideoDownloadTask/IVastVideoDownloadTaskListenerInvoker, AppodealXamarinPlugin")]
			void OnComplete (bool p0);

		}

		[global::Android.Runtime.Register ("com/mopub/mobileads/VastVideoDownloadTask$VastVideoDownloadTaskListener", DoNotGenerateAcw=true)]
		internal class IVastVideoDownloadTaskListenerInvoker : global::Java.Lang.Object, IVastVideoDownloadTaskListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/VastVideoDownloadTask$VastVideoDownloadTaskListener");
			IntPtr class_ref;

			public static IVastVideoDownloadTaskListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IVastVideoDownloadTaskListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.VastVideoDownloadTask.VastVideoDownloadTaskListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IVastVideoDownloadTaskListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IVastVideoDownloadTaskListenerInvoker); }
			}

			static Delegate cb_onComplete_Z;
#pragma warning disable 0169
			static Delegate GetOnComplete_ZHandler ()
			{
				if (cb_onComplete_Z == null)
					cb_onComplete_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnComplete_Z);
				return cb_onComplete_Z;
			}

			static void n_OnComplete_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Mopub.Mobileads.VastVideoDownloadTask.IVastVideoDownloadTaskListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoDownloadTask.IVastVideoDownloadTaskListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnComplete (p0);
			}
#pragma warning restore 0169

			IntPtr id_onComplete_Z;
			public unsafe void OnComplete (bool p0)
			{
				if (id_onComplete_Z == IntPtr.Zero)
					id_onComplete_Z = JNIEnv.GetMethodID (class_ref, "onComplete", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onComplete_Z, __args);
			}

		}

		public partial class VastVideoDownloadTaskEventArgs : global::System.EventArgs {

			public VastVideoDownloadTaskEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/mobileads/VastVideoDownloadTask_VastVideoDownloadTaskListenerImplementor")]
		internal sealed partial class IVastVideoDownloadTaskListenerImplementor : global::Java.Lang.Object, IVastVideoDownloadTaskListener {

			object sender;

			public IVastVideoDownloadTaskListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/mobileads/VastVideoDownloadTask_VastVideoDownloadTaskListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<VastVideoDownloadTaskEventArgs> Handler;
#pragma warning restore 0649

			public void OnComplete (bool p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new VastVideoDownloadTaskEventArgs (p0));
			}

			internal static bool __IsEmpty (IVastVideoDownloadTaskListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/VastVideoDownloadTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VastVideoDownloadTask); }
		}

		protected VastVideoDownloadTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mopub_mobileads_VastVideoDownloadTask_VastVideoDownloadTaskListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoDownloadTask']/constructor[@name='VastVideoDownloadTask' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.VastVideoDownloadTask.VastVideoDownloadTaskListener']]"
		[Register (".ctor", "(Lcom/mopub/mobileads/VastVideoDownloadTask$VastVideoDownloadTaskListener;)V", "")]
		public unsafe VastVideoDownloadTask (global::Com.Mopub.Mobileads.VastVideoDownloadTask.IVastVideoDownloadTaskListener p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (VastVideoDownloadTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/mobileads/VastVideoDownloadTask$VastVideoDownloadTaskListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/mobileads/VastVideoDownloadTask$VastVideoDownloadTaskListener;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mopub_mobileads_VastVideoDownloadTask_VastVideoDownloadTaskListener_ == IntPtr.Zero)
					id_ctor_Lcom_mopub_mobileads_VastVideoDownloadTask_VastVideoDownloadTaskListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/mobileads/VastVideoDownloadTask$VastVideoDownloadTaskListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_mobileads_VastVideoDownloadTask_VastVideoDownloadTaskListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_mobileads_VastVideoDownloadTask_VastVideoDownloadTaskListener_, __args);
			} finally {
			}
		}

		static Delegate cb_doInBackground_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDoInBackground_arrayLjava_lang_String_Handler ()
		{
			if (cb_doInBackground_arrayLjava_lang_String_ == null)
				cb_doInBackground_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_String_);
			return cb_doInBackground_arrayLjava_lang_String_;
		}

		static IntPtr n_DoInBackground_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastVideoDownloadTask __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoDownloadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_doInBackground_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoDownloadTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("doInBackground", "([Ljava/lang/String;)Ljava/lang/Boolean;", "GetDoInBackground_arrayLjava_lang_String_Handler")]
		protected virtual unsafe global::Java.Lang.Boolean DoInBackground (params  string[] p0)
		{
			if (id_doInBackground_arrayLjava_lang_String_ == IntPtr.Zero)
				id_doInBackground_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/String;)Ljava/lang/Boolean;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Java.Lang.Boolean __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_doInBackground_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Ljava/lang/String;)Ljava/lang/Boolean;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_onPostExecute_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetOnPostExecute_Ljava_lang_Boolean_Handler ()
		{
			if (cb_onPostExecute_Ljava_lang_Boolean_ == null)
				cb_onPostExecute_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPostExecute_Ljava_lang_Boolean_);
			return cb_onPostExecute_Ljava_lang_Boolean_;
		}

		static void n_OnPostExecute_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastVideoDownloadTask __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoDownloadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPostExecute (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPostExecute_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoDownloadTask']/method[@name='onPostExecute' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("onPostExecute", "(Ljava/lang/Boolean;)V", "GetOnPostExecute_Ljava_lang_Boolean_Handler")]
		protected virtual unsafe void OnPostExecute (global::Java.Lang.Boolean p0)
		{
			if (id_onPostExecute_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_onPostExecute_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "onPostExecute", "(Ljava/lang/Boolean;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onPostExecute_Ljava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPostExecute", "(Ljava/lang/Boolean;)V"), __args);
			} finally {
			}
		}

	}
}
