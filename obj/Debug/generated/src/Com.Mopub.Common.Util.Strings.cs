using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Strings']"
	[global::Android.Runtime.Register ("com/mopub/common/util/Strings", DoNotGenerateAcw=true)]
	public partial class Strings : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/util/Strings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Strings); }
		}

		protected Strings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Strings']/constructor[@name='Strings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Strings ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Strings)) {
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

		static IntPtr id_fromStream_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Strings']/method[@name='fromStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("fromStream", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static unsafe string FromStream (global::System.IO.Stream p0)
		{
			if (id_fromStream_Ljava_io_InputStream_ == IntPtr.Zero)
				id_fromStream_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "fromStream", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromStream_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isAbsoluteTracker_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Strings']/method[@name='isAbsoluteTracker' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isAbsoluteTracker", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsAbsoluteTracker (string p0)
		{
			if (id_isAbsoluteTracker_Ljava_lang_String_ == IntPtr.Zero)
				id_isAbsoluteTracker_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isAbsoluteTracker", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAbsoluteTracker_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isPercentageTracker_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Strings']/method[@name='isPercentageTracker' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isPercentageTracker", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsPercentageTracker (string p0)
		{
			if (id_isPercentageTracker_Ljava_lang_String_ == IntPtr.Zero)
				id_isPercentageTracker_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isPercentageTracker", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isPercentageTracker_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_parseAbsoluteOffset_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Strings']/method[@name='parseAbsoluteOffset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseAbsoluteOffset", "(Ljava/lang/String;)Ljava/lang/Integer;", "")]
		public static unsafe global::Java.Lang.Integer ParseAbsoluteOffset (string p0)
		{
			if (id_parseAbsoluteOffset_Ljava_lang_String_ == IntPtr.Zero)
				id_parseAbsoluteOffset_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseAbsoluteOffset", "(Ljava/lang/String;)Ljava/lang/Integer;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Integer __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseAbsoluteOffset_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
