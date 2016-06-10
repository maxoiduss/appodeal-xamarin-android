using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ImageUtils']"
	[global::Android.Runtime.Register ("com/mopub/common/util/ImageUtils", DoNotGenerateAcw=true)]
	public partial class ImageUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/util/ImageUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageUtils); }
		}

		protected ImageUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ImageUtils']/constructor[@name='ImageUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ImageUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ImageUtils)) {
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

		static IntPtr id_applyFastGaussianBlurToBitmap_Landroid_graphics_Bitmap_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ImageUtils']/method[@name='applyFastGaussianBlurToBitmap' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int']]"
		[Register ("applyFastGaussianBlurToBitmap", "(Landroid/graphics/Bitmap;I)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap ApplyFastGaussianBlurToBitmap (global::Android.Graphics.Bitmap p0, int p1)
		{
			if (id_applyFastGaussianBlurToBitmap_Landroid_graphics_Bitmap_I == IntPtr.Zero)
				id_applyFastGaussianBlurToBitmap_Landroid_graphics_Bitmap_I = JNIEnv.GetStaticMethodID (class_ref, "applyFastGaussianBlurToBitmap", "(Landroid/graphics/Bitmap;I)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_applyFastGaussianBlurToBitmap_Landroid_graphics_Bitmap_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setImageViewAlpha_Landroid_widget_ImageView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ImageUtils']/method[@name='setImageViewAlpha' and count(parameter)=2 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='int']]"
		[Register ("setImageViewAlpha", "(Landroid/widget/ImageView;I)V", "")]
		public static unsafe void SetImageViewAlpha (global::Android.Widget.ImageView p0, int p1)
		{
			if (id_setImageViewAlpha_Landroid_widget_ImageView_I == IntPtr.Zero)
				id_setImageViewAlpha_Landroid_widget_ImageView_I = JNIEnv.GetStaticMethodID (class_ref, "setImageViewAlpha", "(Landroid/widget/ImageView;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setImageViewAlpha_Landroid_widget_ImageView_I, __args);
			} finally {
			}
		}

	}
}
