using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.util']/class[@name='HttpTools']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/util/HttpTools", DoNotGenerateAcw=true)]
	public partial class HttpTools : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/util/HttpTools", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpTools); }
		}

		protected HttpTools (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.util']/class[@name='HttpTools']/constructor[@name='HttpTools' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpTools ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HttpTools)) {
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

		static IntPtr id_httpGetURL_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.util']/class[@name='HttpTools']/method[@name='httpGetURL' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("httpGetURL", "(Ljava/lang/String;)V", "")]
		public static unsafe void HttpGetURL (string p0)
		{
			if (id_httpGetURL_Ljava_lang_String_ == IntPtr.Zero)
				id_httpGetURL_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "httpGetURL", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_httpGetURL_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
