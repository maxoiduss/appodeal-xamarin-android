using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Utils']"
	[global::Android.Runtime.Register ("com/mopub/common/util/Utils", DoNotGenerateAcw=true)]
	public partial class Utils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/util/Utils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Utils); }
		}

		protected Utils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Utils']/constructor[@name='Utils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Utils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Utils)) {
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

		static IntPtr id_bitMaskContainsFlag_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Utils']/method[@name='bitMaskContainsFlag' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("bitMaskContainsFlag", "(II)Z", "")]
		public static unsafe bool BitMaskContainsFlag (int p0, int p1)
		{
			if (id_bitMaskContainsFlag_II == IntPtr.Zero)
				id_bitMaskContainsFlag_II = JNIEnv.GetStaticMethodID (class_ref, "bitMaskContainsFlag", "(II)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_bitMaskContainsFlag_II, __args);
			} finally {
			}
		}

		static IntPtr id_generateUniqueId;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Utils']/method[@name='generateUniqueId' and count(parameter)=0]"
		[Register ("generateUniqueId", "()J", "")]
		public static unsafe long GenerateUniqueId ()
		{
			if (id_generateUniqueId == IntPtr.Zero)
				id_generateUniqueId = JNIEnv.GetStaticMethodID (class_ref, "generateUniqueId", "()J");
			try {
				return JNIEnv.CallStaticLongMethod  (class_ref, id_generateUniqueId);
			} finally {
			}
		}

		static IntPtr id_sha1_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Utils']/method[@name='sha1' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sha1", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Sha1 (string p0)
		{
			if (id_sha1_Ljava_lang_String_ == IntPtr.Zero)
				id_sha1_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sha1", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha1_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
