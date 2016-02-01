using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoCtaButtonWidget']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/VastVideoCtaButtonWidget", DoNotGenerateAcw=true)]
	public partial class VastVideoCtaButtonWidget : global::Android.Widget.ImageView {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/VastVideoCtaButtonWidget", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VastVideoCtaButtonWidget); }
		}

		protected VastVideoCtaButtonWidget (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_IZZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoCtaButtonWidget']/constructor[@name='VastVideoCtaButtonWidget' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;IZZ)V", "")]
		public unsafe VastVideoCtaButtonWidget (global::Android.Content.Context p0, int p1, bool p2, bool p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (VastVideoCtaButtonWidget)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;IZZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;IZZ)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_IZZ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_IZZ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;IZZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_IZZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_IZZ, __args);
			} finally {
			}
		}

	}
}
