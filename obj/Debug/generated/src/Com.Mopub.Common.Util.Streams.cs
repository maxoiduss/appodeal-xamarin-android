using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Streams']"
	[global::Android.Runtime.Register ("com/mopub/common/util/Streams", DoNotGenerateAcw=true)]
	public partial class Streams : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/util/Streams", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Streams); }
		}

		protected Streams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Streams']/constructor[@name='Streams' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Streams ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Streams)) {
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

		static IntPtr id_closeStream_Ljava_io_Closeable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Streams']/method[@name='closeStream' and count(parameter)=1 and parameter[1][@type='java.io.Closeable']]"
		[Register ("closeStream", "(Ljava/io/Closeable;)V", "")]
		public static unsafe void CloseStream (global::Java.IO.ICloseable p0)
		{
			if (id_closeStream_Ljava_io_Closeable_ == IntPtr.Zero)
				id_closeStream_Ljava_io_Closeable_ = JNIEnv.GetStaticMethodID (class_ref, "closeStream", "(Ljava/io/Closeable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_closeStream_Ljava_io_Closeable_, __args);
			} finally {
			}
		}

		static IntPtr id_copyContent_Ljava_io_InputStream_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Streams']/method[@name='copyContent' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("copyContent", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V", "")]
		public static unsafe void CopyContent (global::System.IO.Stream p0, global::System.IO.Stream p1)
		{
			if (id_copyContent_Ljava_io_InputStream_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_copyContent_Ljava_io_InputStream_Ljava_io_OutputStream_ = JNIEnv.GetStaticMethodID (class_ref, "copyContent", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_copyContent_Ljava_io_InputStream_Ljava_io_OutputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_copyContent_Ljava_io_InputStream_Ljava_io_OutputStream_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Streams']/method[@name='copyContent' and count(parameter)=3 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream'] and parameter[3][@type='long']]"
		[Register ("copyContent", "(Ljava/io/InputStream;Ljava/io/OutputStream;J)V", "")]
		public static unsafe void CopyContent (global::System.IO.Stream p0, global::System.IO.Stream p1, long p2)
		{
			if (id_copyContent_Ljava_io_InputStream_Ljava_io_OutputStream_J == IntPtr.Zero)
				id_copyContent_Ljava_io_InputStream_Ljava_io_OutputStream_J = JNIEnv.GetStaticMethodID (class_ref, "copyContent", "(Ljava/io/InputStream;Ljava/io/OutputStream;J)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_copyContent_Ljava_io_InputStream_Ljava_io_OutputStream_J, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_readStream_Ljava_io_InputStream_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Streams']/method[@name='readStream' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='byte[]']]"
		[Register ("readStream", "(Ljava/io/InputStream;[B)V", "")]
		public static unsafe void ReadStream (global::System.IO.Stream p0, byte[] p1)
		{
			if (id_readStream_Ljava_io_InputStream_arrayB == IntPtr.Zero)
				id_readStream_Ljava_io_InputStream_arrayB = JNIEnv.GetStaticMethodID (class_ref, "readStream", "(Ljava/io/InputStream;[B)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_readStream_Ljava_io_InputStream_arrayB, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
