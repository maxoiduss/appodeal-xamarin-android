using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Files']"
	[global::Android.Runtime.Register ("com/mopub/common/util/Files", DoNotGenerateAcw=true)]
	public partial class Files : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/util/Files", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Files); }
		}

		protected Files (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Files']/constructor[@name='Files' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Files ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Files)) {
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

		static IntPtr id_createDirectory_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Files']/method[@name='createDirectory' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createDirectory", "(Ljava/lang/String;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File CreateDirectory (string p0)
		{
			if (id_createDirectory_Ljava_lang_String_ == IntPtr.Zero)
				id_createDirectory_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createDirectory", "(Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createDirectory_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_intLength_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Files']/method[@name='intLength' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("intLength", "(Ljava/io/File;)I", "")]
		public static unsafe int IntLength (global::Java.IO.File p0)
		{
			if (id_intLength_Ljava_io_File_ == IntPtr.Zero)
				id_intLength_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "intLength", "(Ljava/io/File;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_intLength_Ljava_io_File_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
