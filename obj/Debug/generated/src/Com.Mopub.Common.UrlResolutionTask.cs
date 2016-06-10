using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlResolutionTask']"
	[global::Android.Runtime.Register ("com/mopub/common/UrlResolutionTask", DoNotGenerateAcw=true)]
	public partial class UrlResolutionTask : global::Android.OS.AsyncTask {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.common']/interface[@name='UrlResolutionTask.UrlResolutionListener']"
		[Register ("com/mopub/common/UrlResolutionTask$UrlResolutionListener", "", "Com.Mopub.Common.UrlResolutionTask/IUrlResolutionListenerInvoker")]
		public partial interface IUrlResolutionListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/interface[@name='UrlResolutionTask.UrlResolutionListener']/method[@name='onFailure' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
			[Register ("onFailure", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetOnFailure_Ljava_lang_String_Ljava_lang_Throwable_Handler:Com.Mopub.Common.UrlResolutionTask/IUrlResolutionListenerInvoker, AppodealXamarinPlugin")]
			void OnFailure (string p0, global::Java.Lang.Throwable p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/interface[@name='UrlResolutionTask.UrlResolutionListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onSuccess", "(Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Handler:Com.Mopub.Common.UrlResolutionTask/IUrlResolutionListenerInvoker, AppodealXamarinPlugin")]
			void OnSuccess (string p0);

		}

		[global::Android.Runtime.Register ("com/mopub/common/UrlResolutionTask$UrlResolutionListener", DoNotGenerateAcw=true)]
		internal class IUrlResolutionListenerInvoker : global::Java.Lang.Object, IUrlResolutionListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/common/UrlResolutionTask$UrlResolutionListener");
			IntPtr class_ref;

			public static IUrlResolutionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IUrlResolutionListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.common.UrlResolutionTask.UrlResolutionListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IUrlResolutionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IUrlResolutionListenerInvoker); }
			}

			static Delegate cb_onFailure_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetOnFailure_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
			{
				if (cb_onFailure_Ljava_lang_String_Ljava_lang_Throwable_ == null)
					cb_onFailure_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFailure_Ljava_lang_String_Ljava_lang_Throwable_);
				return cb_onFailure_Ljava_lang_String_Ljava_lang_Throwable_;
			}

			static void n_OnFailure_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mopub.Common.UrlResolutionTask.IUrlResolutionListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlResolutionTask.IUrlResolutionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnFailure (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onFailure_Ljava_lang_String_Ljava_lang_Throwable_;
			public unsafe void OnFailure (string p0, global::Java.Lang.Throwable p1)
			{
				if (id_onFailure_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_onFailure_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_onFailure_Ljava_lang_String_Ljava_lang_Throwable_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onSuccess_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_Ljava_lang_String_Handler ()
			{
				if (cb_onSuccess_Ljava_lang_String_ == null)
					cb_onSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_lang_String_);
				return cb_onSuccess_Ljava_lang_String_;
			}

			static void n_OnSuccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.UrlResolutionTask.IUrlResolutionListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlResolutionTask.IUrlResolutionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSuccess_Ljava_lang_String_;
			public unsafe void OnSuccess (string p0)
			{
				if (id_onSuccess_Ljava_lang_String_ == IntPtr.Zero)
					id_onSuccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (Handle, id_onSuccess_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		public partial class FailureEventArgs : global::System.EventArgs {

			public FailureEventArgs (string p0, global::Java.Lang.Throwable p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}

			global::Java.Lang.Throwable p1;
			public global::Java.Lang.Throwable P1 {
				get { return p1; }
			}
		}

		public partial class SuccessEventArgs : global::System.EventArgs {

			public SuccessEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/common/UrlResolutionTask_UrlResolutionListenerImplementor")]
		internal sealed partial class IUrlResolutionListenerImplementor : global::Java.Lang.Object, IUrlResolutionListener {

			object sender;

			public IUrlResolutionListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/common/UrlResolutionTask_UrlResolutionListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<FailureEventArgs> OnFailureHandler;
#pragma warning restore 0649

			public void OnFailure (string p0, global::Java.Lang.Throwable p1)
			{
				var __h = OnFailureHandler;
				if (__h != null)
					__h (sender, new FailureEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<SuccessEventArgs> OnSuccessHandler;
#pragma warning restore 0649

			public void OnSuccess (string p0)
			{
				var __h = OnSuccessHandler;
				if (__h != null)
					__h (sender, new SuccessEventArgs (p0));
			}

			internal static bool __IsEmpty (IUrlResolutionListenerImplementor value)
			{
				return value.OnFailureHandler == null && value.OnSuccessHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/UrlResolutionTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UrlResolutionTask); }
		}

		protected UrlResolutionTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Mopub.Common.UrlResolutionTask __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlResolutionTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.NewString (__this.DoInBackground (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_doInBackground_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlResolutionTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("doInBackground", "([Ljava/lang/String;)Ljava/lang/String;", "GetDoInBackground_arrayLjava_lang_String_Handler")]
		protected virtual unsafe string DoInBackground (params  string[] p0)
		{
			if (id_doInBackground_arrayLjava_lang_String_ == IntPtr.Zero)
				id_doInBackground_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_doInBackground_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_onPostExecute_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnPostExecute_Ljava_lang_String_Handler ()
		{
			if (cb_onPostExecute_Ljava_lang_String_ == null)
				cb_onPostExecute_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPostExecute_Ljava_lang_String_);
			return cb_onPostExecute_Ljava_lang_String_;
		}

		static void n_OnPostExecute_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.UrlResolutionTask __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlResolutionTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPostExecute (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPostExecute_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlResolutionTask']/method[@name='onPostExecute' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onPostExecute", "(Ljava/lang/String;)V", "GetOnPostExecute_Ljava_lang_String_Handler")]
		protected virtual unsafe void OnPostExecute (string p0)
		{
			if (id_onPostExecute_Ljava_lang_String_ == IntPtr.Zero)
				id_onPostExecute_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onPostExecute", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onPostExecute_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPostExecute", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
