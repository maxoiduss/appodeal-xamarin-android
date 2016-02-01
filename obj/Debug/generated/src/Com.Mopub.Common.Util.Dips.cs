using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Dips']"
	[global::Android.Runtime.Register ("com/mopub/common/util/Dips", DoNotGenerateAcw=true)]
	public partial class Dips : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/util/Dips", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Dips); }
		}

		protected Dips (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Dips']/constructor[@name='Dips' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Dips ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Dips)) {
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

		static IntPtr id_asFloatPixels_FLandroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Dips']/method[@name='asFloatPixels' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='android.content.Context']]"
		[Register ("asFloatPixels", "(FLandroid/content/Context;)F", "")]
		public static unsafe float AsFloatPixels (float p0, global::Android.Content.Context p1)
		{
			if (id_asFloatPixels_FLandroid_content_Context_ == IntPtr.Zero)
				id_asFloatPixels_FLandroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "asFloatPixels", "(FLandroid/content/Context;)F");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_asFloatPixels_FLandroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_asIntPixels_FLandroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Dips']/method[@name='asIntPixels' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='android.content.Context']]"
		[Register ("asIntPixels", "(FLandroid/content/Context;)I", "")]
		public static unsafe int AsIntPixels (float p0, global::Android.Content.Context p1)
		{
			if (id_asIntPixels_FLandroid_content_Context_ == IntPtr.Zero)
				id_asIntPixels_FLandroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "asIntPixels", "(FLandroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_asIntPixels_FLandroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_dipsToFloatPixels_FLandroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Dips']/method[@name='dipsToFloatPixels' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='android.content.Context']]"
		[Register ("dipsToFloatPixels", "(FLandroid/content/Context;)F", "")]
		public static unsafe float DipsToFloatPixels (float p0, global::Android.Content.Context p1)
		{
			if (id_dipsToFloatPixels_FLandroid_content_Context_ == IntPtr.Zero)
				id_dipsToFloatPixels_FLandroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "dipsToFloatPixels", "(FLandroid/content/Context;)F");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_dipsToFloatPixels_FLandroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_dipsToIntPixels_FLandroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Dips']/method[@name='dipsToIntPixels' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='android.content.Context']]"
		[Register ("dipsToIntPixels", "(FLandroid/content/Context;)I", "")]
		public static unsafe int DipsToIntPixels (float p0, global::Android.Content.Context p1)
		{
			if (id_dipsToIntPixels_FLandroid_content_Context_ == IntPtr.Zero)
				id_dipsToIntPixels_FLandroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "dipsToIntPixels", "(FLandroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_dipsToIntPixels_FLandroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_pixelsToFloatDips_FLandroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Dips']/method[@name='pixelsToFloatDips' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='android.content.Context']]"
		[Register ("pixelsToFloatDips", "(FLandroid/content/Context;)F", "")]
		public static unsafe float PixelsToFloatDips (float p0, global::Android.Content.Context p1)
		{
			if (id_pixelsToFloatDips_FLandroid_content_Context_ == IntPtr.Zero)
				id_pixelsToFloatDips_FLandroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "pixelsToFloatDips", "(FLandroid/content/Context;)F");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_pixelsToFloatDips_FLandroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_pixelsToIntDips_FLandroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Dips']/method[@name='pixelsToIntDips' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='android.content.Context']]"
		[Register ("pixelsToIntDips", "(FLandroid/content/Context;)I", "")]
		public static unsafe int PixelsToIntDips (float p0, global::Android.Content.Context p1)
		{
			if (id_pixelsToIntDips_FLandroid_content_Context_ == IntPtr.Zero)
				id_pixelsToIntDips_FLandroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "pixelsToIntDips", "(FLandroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_pixelsToIntDips_FLandroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_screenHeightAsIntDips_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Dips']/method[@name='screenHeightAsIntDips' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("screenHeightAsIntDips", "(Landroid/content/Context;)I", "")]
		public static unsafe int ScreenHeightAsIntDips (global::Android.Content.Context p0)
		{
			if (id_screenHeightAsIntDips_Landroid_content_Context_ == IntPtr.Zero)
				id_screenHeightAsIntDips_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "screenHeightAsIntDips", "(Landroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_screenHeightAsIntDips_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_screenWidthAsIntDips_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Dips']/method[@name='screenWidthAsIntDips' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("screenWidthAsIntDips", "(Landroid/content/Context;)I", "")]
		public static unsafe int ScreenWidthAsIntDips (global::Android.Content.Context p0)
		{
			if (id_screenWidthAsIntDips_Landroid_content_Context_ == IntPtr.Zero)
				id_screenWidthAsIntDips_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "screenWidthAsIntDips", "(Landroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_screenWidthAsIntDips_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
