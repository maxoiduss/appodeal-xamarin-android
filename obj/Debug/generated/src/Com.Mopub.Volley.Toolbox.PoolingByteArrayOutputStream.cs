using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley.Toolbox {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='PoolingByteArrayOutputStream']"
	[global::Android.Runtime.Register ("com/mopub/volley/toolbox/PoolingByteArrayOutputStream", DoNotGenerateAcw=true)]
	public partial class PoolingByteArrayOutputStream : global::Java.IO.ByteArrayOutputStream {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/toolbox/PoolingByteArrayOutputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PoolingByteArrayOutputStream); }
		}

		protected PoolingByteArrayOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mopub_volley_toolbox_ByteArrayPool_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='PoolingByteArrayOutputStream']/constructor[@name='PoolingByteArrayOutputStream' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.toolbox.ByteArrayPool']]"
		[Register (".ctor", "(Lcom/mopub/volley/toolbox/ByteArrayPool;)V", "")]
		public unsafe PoolingByteArrayOutputStream (global::Com.Mopub.Volley.Toolbox.ByteArrayPool p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (PoolingByteArrayOutputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/volley/toolbox/ByteArrayPool;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/volley/toolbox/ByteArrayPool;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mopub_volley_toolbox_ByteArrayPool_ == IntPtr.Zero)
					id_ctor_Lcom_mopub_volley_toolbox_ByteArrayPool_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/volley/toolbox/ByteArrayPool;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_volley_toolbox_ByteArrayPool_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_volley_toolbox_ByteArrayPool_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_mopub_volley_toolbox_ByteArrayPool_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='PoolingByteArrayOutputStream']/constructor[@name='PoolingByteArrayOutputStream' and count(parameter)=2 and parameter[1][@type='com.mopub.volley.toolbox.ByteArrayPool'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lcom/mopub/volley/toolbox/ByteArrayPool;I)V", "")]
		public unsafe PoolingByteArrayOutputStream (global::Com.Mopub.Volley.Toolbox.ByteArrayPool p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (PoolingByteArrayOutputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/volley/toolbox/ByteArrayPool;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/volley/toolbox/ByteArrayPool;I)V", __args);
					return;
				}

				if (id_ctor_Lcom_mopub_volley_toolbox_ByteArrayPool_I == IntPtr.Zero)
					id_ctor_Lcom_mopub_volley_toolbox_ByteArrayPool_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/volley/toolbox/ByteArrayPool;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_volley_toolbox_ByteArrayPool_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_volley_toolbox_ByteArrayPool_I, __args);
			} finally {
			}
		}

		static Delegate cb_finalize;
#pragma warning disable 0169
		static Delegate GetFinalizeHandler ()
		{
			if (cb_finalize == null)
				cb_finalize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Finalize);
			return cb_finalize;
		}

		static void n_Finalize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Toolbox.PoolingByteArrayOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.PoolingByteArrayOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finalize ();
		}
#pragma warning restore 0169

		static IntPtr id_finalize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='PoolingByteArrayOutputStream']/method[@name='finalize' and count(parameter)=0]"
		[Register ("finalize", "()V", "GetFinalizeHandler")]
		public virtual unsafe void Finalize ()
		{
			if (id_finalize == IntPtr.Zero)
				id_finalize = JNIEnv.GetMethodID (class_ref, "finalize", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_finalize);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finalize", "()V"));
			} finally {
			}
		}

	}
}
