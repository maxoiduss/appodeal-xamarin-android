using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Views']"
	[global::Android.Runtime.Register ("com/mopub/common/util/Views", DoNotGenerateAcw=true)]
	public partial class Views : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/util/Views", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Views); }
		}

		protected Views (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Views']/constructor[@name='Views' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Views ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Views)) {
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

		static IntPtr id_removeFromParent_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Views']/method[@name='removeFromParent' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("removeFromParent", "(Landroid/view/View;)V", "")]
		public static unsafe void RemoveFromParent (global::Android.Views.View p0)
		{
			if (id_removeFromParent_Landroid_view_View_ == IntPtr.Zero)
				id_removeFromParent_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "removeFromParent", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_removeFromParent_Landroid_view_View_, __args);
			} finally {
			}
		}

	}
}
