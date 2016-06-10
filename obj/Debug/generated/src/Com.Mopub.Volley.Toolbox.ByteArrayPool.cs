using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley.Toolbox {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ByteArrayPool']"
	[global::Android.Runtime.Register ("com/mopub/volley/toolbox/ByteArrayPool", DoNotGenerateAcw=true)]
	public partial class ByteArrayPool : global::Java.Lang.Object {


		static IntPtr BUF_COMPARATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ByteArrayPool']/field[@name='BUF_COMPARATOR']"
		[Register ("BUF_COMPARATOR")]
		protected static global::Java.Util.IComparator BufComparator {
			get {
				if (BUF_COMPARATOR_jfieldId == IntPtr.Zero)
					BUF_COMPARATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BUF_COMPARATOR", "Ljava/util/Comparator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BUF_COMPARATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/toolbox/ByteArrayPool", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ByteArrayPool); }
		}

		protected ByteArrayPool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ByteArrayPool']/constructor[@name='ByteArrayPool' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe ByteArrayPool (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ByteArrayPool)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_getBuf_I;
#pragma warning disable 0169
		static Delegate GetGetBuf_IHandler ()
		{
			if (cb_getBuf_I == null)
				cb_getBuf_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetBuf_I);
			return cb_getBuf_I;
		}

		static IntPtr n_GetBuf_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Volley.Toolbox.ByteArrayPool __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ByteArrayPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBuf (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getBuf_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ByteArrayPool']/method[@name='getBuf' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getBuf", "(I)[B", "GetGetBuf_IHandler")]
		public virtual unsafe byte[] GetBuf (int p0)
		{
			if (id_getBuf_I == IntPtr.Zero)
				id_getBuf_I = JNIEnv.GetMethodID (class_ref, "getBuf", "(I)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getBuf_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBuf", "(I)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_returnBuf_arrayB;
#pragma warning disable 0169
		static Delegate GetReturnBuf_arrayBHandler ()
		{
			if (cb_returnBuf_arrayB == null)
				cb_returnBuf_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReturnBuf_arrayB);
			return cb_returnBuf_arrayB;
		}

		static void n_ReturnBuf_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Toolbox.ByteArrayPool __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ByteArrayPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.ReturnBuf (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_returnBuf_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ByteArrayPool']/method[@name='returnBuf' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("returnBuf", "([B)V", "GetReturnBuf_arrayBHandler")]
		public virtual unsafe void ReturnBuf (byte[] p0)
		{
			if (id_returnBuf_arrayB == IntPtr.Zero)
				id_returnBuf_arrayB = JNIEnv.GetMethodID (class_ref, "returnBuf", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_returnBuf_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "returnBuf", "([B)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
