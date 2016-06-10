using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.util']/class[@name='NetworkTools']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/util/NetworkTools", DoNotGenerateAcw=true)]
	public partial class NetworkTools : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/util/NetworkTools", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkTools); }
		}

		protected NetworkTools (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.util']/class[@name='NetworkTools']/constructor[@name='NetworkTools' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NetworkTools ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (NetworkTools)) {
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

		static IntPtr id_connectedToInternet_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.util']/class[@name='NetworkTools']/method[@name='connectedToInternet' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("connectedToInternet", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool ConnectedToInternet (global::Android.Content.Context p0)
		{
			if (id_connectedToInternet_Landroid_content_Context_ == IntPtr.Zero)
				id_connectedToInternet_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "connectedToInternet", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_connectedToInternet_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
