using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoGradientStripWidget']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/VastVideoGradientStripWidget", DoNotGenerateAcw=true)]
	public partial class VastVideoGradientStripWidget : global::Android.Widget.ImageView {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/VastVideoGradientStripWidget", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VastVideoGradientStripWidget); }
		}

		protected VastVideoGradientStripWidget (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_graphics_drawable_GradientDrawable_Orientation_Lcom_mopub_common_util_DeviceUtils_ForceOrientation_ZIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoGradientStripWidget']/constructor[@name='VastVideoGradientStripWidget' and count(parameter)=7 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.graphics.drawable.GradientDrawable.Orientation'] and parameter[3][@type='com.mopub.common.util.DeviceUtils.ForceOrientation'] and parameter[4][@type='boolean'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/graphics/drawable/GradientDrawable$Orientation;Lcom/mopub/common/util/DeviceUtils$ForceOrientation;ZIII)V", "")]
		public unsafe VastVideoGradientStripWidget (global::Android.Content.Context p0, global::Android.Graphics.Drawables.GradientDrawable.Orientation p1, global::Com.Mopub.Common.Util.DeviceUtils.ForceOrientation p2, bool p3, int p4, int p5, int p6)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				if (GetType () != typeof (VastVideoGradientStripWidget)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/graphics/drawable/GradientDrawable$Orientation;Lcom/mopub/common/util/DeviceUtils$ForceOrientation;ZIII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/graphics/drawable/GradientDrawable$Orientation;Lcom/mopub/common/util/DeviceUtils$ForceOrientation;ZIII)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_graphics_drawable_GradientDrawable_Orientation_Lcom_mopub_common_util_DeviceUtils_ForceOrientation_ZIII == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_graphics_drawable_GradientDrawable_Orientation_Lcom_mopub_common_util_DeviceUtils_ForceOrientation_ZIII = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/graphics/drawable/GradientDrawable$Orientation;Lcom/mopub/common/util/DeviceUtils$ForceOrientation;ZIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_graphics_drawable_GradientDrawable_Orientation_Lcom_mopub_common_util_DeviceUtils_ForceOrientation_ZIII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_graphics_drawable_GradientDrawable_Orientation_Lcom_mopub_common_util_DeviceUtils_ForceOrientation_ZIII, __args);
			} finally {
			}
		}

	}
}
