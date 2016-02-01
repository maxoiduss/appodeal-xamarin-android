using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Resource {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='BaseWidgetDrawable']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/resource/BaseWidgetDrawable", DoNotGenerateAcw=true)]
	public abstract partial class BaseWidgetDrawable : global::Android.Graphics.Drawables.Drawable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/resource/BaseWidgetDrawable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseWidgetDrawable); }
		}

		protected BaseWidgetDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='BaseWidgetDrawable']/constructor[@name='BaseWidgetDrawable' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseWidgetDrawable ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BaseWidgetDrawable)) {
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

		static Delegate cb_getOpacity;
#pragma warning disable 0169
		static Delegate GetGetOpacityHandler ()
		{
			if (cb_getOpacity == null)
				cb_getOpacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOpacity);
			return cb_getOpacity;
		}

		static int n_GetOpacity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.Resource.BaseWidgetDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.BaseWidgetDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Opacity;
		}
#pragma warning restore 0169

		static IntPtr id_getOpacity;
		public override unsafe int Opacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='BaseWidgetDrawable']/method[@name='getOpacity' and count(parameter)=0]"
			[Register ("getOpacity", "()I", "GetGetOpacityHandler")]
			get {
				if (id_getOpacity == IntPtr.Zero)
					id_getOpacity = JNIEnv.GetMethodID (class_ref, "getOpacity", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getOpacity);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOpacity", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_drawTextWithinBounds_Landroid_graphics_Canvas_Landroid_graphics_Paint_Landroid_graphics_Rect_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDrawTextWithinBounds_Landroid_graphics_Canvas_Landroid_graphics_Paint_Landroid_graphics_Rect_Ljava_lang_String_Handler ()
		{
			if (cb_drawTextWithinBounds_Landroid_graphics_Canvas_Landroid_graphics_Paint_Landroid_graphics_Rect_Ljava_lang_String_ == null)
				cb_drawTextWithinBounds_Landroid_graphics_Canvas_Landroid_graphics_Paint_Landroid_graphics_Rect_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DrawTextWithinBounds_Landroid_graphics_Canvas_Landroid_graphics_Paint_Landroid_graphics_Rect_Ljava_lang_String_);
			return cb_drawTextWithinBounds_Landroid_graphics_Canvas_Landroid_graphics_Paint_Landroid_graphics_Rect_Ljava_lang_String_;
		}

		static void n_DrawTextWithinBounds_Landroid_graphics_Canvas_Landroid_graphics_Paint_Landroid_graphics_Rect_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Mopub.Mobileads.Resource.BaseWidgetDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.BaseWidgetDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.DrawTextWithinBounds (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_drawTextWithinBounds_Landroid_graphics_Canvas_Landroid_graphics_Paint_Landroid_graphics_Rect_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='BaseWidgetDrawable']/method[@name='drawTextWithinBounds' and count(parameter)=4 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='android.graphics.Paint'] and parameter[3][@type='android.graphics.Rect'] and parameter[4][@type='java.lang.String']]"
		[Register ("drawTextWithinBounds", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;Landroid/graphics/Rect;Ljava/lang/String;)V", "GetDrawTextWithinBounds_Landroid_graphics_Canvas_Landroid_graphics_Paint_Landroid_graphics_Rect_Ljava_lang_String_Handler")]
		protected virtual unsafe void DrawTextWithinBounds (global::Android.Graphics.Canvas p0, global::Android.Graphics.Paint p1, global::Android.Graphics.Rect p2, string p3)
		{
			if (id_drawTextWithinBounds_Landroid_graphics_Canvas_Landroid_graphics_Paint_Landroid_graphics_Rect_Ljava_lang_String_ == IntPtr.Zero)
				id_drawTextWithinBounds_Landroid_graphics_Canvas_Landroid_graphics_Paint_Landroid_graphics_Rect_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "drawTextWithinBounds", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;Landroid/graphics/Rect;Ljava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_drawTextWithinBounds_Landroid_graphics_Canvas_Landroid_graphics_Paint_Landroid_graphics_Rect_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawTextWithinBounds", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;Landroid/graphics/Rect;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_setAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetAlpha_IHandler ()
		{
			if (cb_setAlpha_I == null)
				cb_setAlpha_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAlpha_I);
			return cb_setAlpha_I;
		}

		static void n_SetAlpha_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Mobileads.Resource.BaseWidgetDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.BaseWidgetDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAlpha (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAlpha_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='BaseWidgetDrawable']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAlpha", "(I)V", "GetSetAlpha_IHandler")]
		public override unsafe void SetAlpha (int p0)
		{
			if (id_setAlpha_I == IntPtr.Zero)
				id_setAlpha_I = JNIEnv.GetMethodID (class_ref, "setAlpha", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAlpha_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlpha", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setColorFilter_Landroid_graphics_ColorFilter_;
#pragma warning disable 0169
		static Delegate GetSetColorFilter_Landroid_graphics_ColorFilter_Handler ()
		{
			if (cb_setColorFilter_Landroid_graphics_ColorFilter_ == null)
				cb_setColorFilter_Landroid_graphics_ColorFilter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColorFilter_Landroid_graphics_ColorFilter_);
			return cb_setColorFilter_Landroid_graphics_ColorFilter_;
		}

		static void n_SetColorFilter_Landroid_graphics_ColorFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.Resource.BaseWidgetDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.BaseWidgetDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.ColorFilter p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetColorFilter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColorFilter_Landroid_graphics_ColorFilter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='BaseWidgetDrawable']/method[@name='setColorFilter' and count(parameter)=1 and parameter[1][@type='android.graphics.ColorFilter']]"
		[Register ("setColorFilter", "(Landroid/graphics/ColorFilter;)V", "GetSetColorFilter_Landroid_graphics_ColorFilter_Handler")]
		public override unsafe void SetColorFilter (global::Android.Graphics.ColorFilter p0)
		{
			if (id_setColorFilter_Landroid_graphics_ColorFilter_ == IntPtr.Zero)
				id_setColorFilter_Landroid_graphics_ColorFilter_ = JNIEnv.GetMethodID (class_ref, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setColorFilter_Landroid_graphics_ColorFilter_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/mopub/mobileads/resource/BaseWidgetDrawable", DoNotGenerateAcw=true)]
	internal partial class BaseWidgetDrawableInvoker : BaseWidgetDrawable {

		public BaseWidgetDrawableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseWidgetDrawableInvoker); }
		}

		static IntPtr id_draw_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.graphics.drawable']/class[@name='Drawable']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='Android.Graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public override unsafe void Draw (global::Android.Graphics.Canvas canvas)
		{
			if (id_draw_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (canvas);
				JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_, __args);
			} finally {
			}
		}

	}

}
