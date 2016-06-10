using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Mraid.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDHtmlProcessor']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/mraid/internal/MRAIDHtmlProcessor", DoNotGenerateAcw=true)]
	public partial class MRAIDHtmlProcessor : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/mraid/internal/MRAIDHtmlProcessor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MRAIDHtmlProcessor); }
		}

		protected MRAIDHtmlProcessor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDHtmlProcessor']/constructor[@name='MRAIDHtmlProcessor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MRAIDHtmlProcessor ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MRAIDHtmlProcessor)) {
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

		static IntPtr id_processRawHtml_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDHtmlProcessor']/method[@name='processRawHtml' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("processRawHtml", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ProcessRawHtml (string p0)
		{
			if (id_processRawHtml_Ljava_lang_String_ == IntPtr.Zero)
				id_processRawHtml_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "processRawHtml", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_processRawHtml_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
