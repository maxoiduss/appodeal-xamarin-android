using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Resource {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='CtaButtonDrawable']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/resource/CtaButtonDrawable", DoNotGenerateAcw=true)]
	public partial class CtaButtonDrawable : global::Com.Mopub.Mobileads.Resource.BaseWidgetDrawable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/resource/CtaButtonDrawable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CtaButtonDrawable); }
		}

		protected CtaButtonDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='CtaButtonDrawable']/constructor[@name='CtaButtonDrawable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CtaButtonDrawable (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (CtaButtonDrawable)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getCtaText;
#pragma warning disable 0169
		static Delegate GetGetCtaTextHandler ()
		{
			if (cb_getCtaText == null)
				cb_getCtaText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCtaText);
			return cb_getCtaText;
		}

		static IntPtr n_GetCtaText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.Resource.CtaButtonDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.CtaButtonDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CtaText);
		}
#pragma warning restore 0169

		static Delegate cb_setCtaText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCtaText_Ljava_lang_String_Handler ()
		{
			if (cb_setCtaText_Ljava_lang_String_ == null)
				cb_setCtaText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCtaText_Ljava_lang_String_);
			return cb_setCtaText_Ljava_lang_String_;
		}

		static void n_SetCtaText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.Resource.CtaButtonDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.CtaButtonDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CtaText = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCtaText;
		static IntPtr id_setCtaText_Ljava_lang_String_;
		public virtual unsafe string CtaText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='CtaButtonDrawable']/method[@name='getCtaText' and count(parameter)=0]"
			[Register ("getCtaText", "()Ljava/lang/String;", "GetGetCtaTextHandler")]
			get {
				if (id_getCtaText == IntPtr.Zero)
					id_getCtaText = JNIEnv.GetMethodID (class_ref, "getCtaText", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCtaText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCtaText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='CtaButtonDrawable']/method[@name='setCtaText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCtaText", "(Ljava/lang/String;)V", "GetSetCtaText_Ljava_lang_String_Handler")]
			set {
				if (id_setCtaText_Ljava_lang_String_ == IntPtr.Zero)
					id_setCtaText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCtaText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCtaText_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCtaText", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_ == null)
				cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Draw_Landroid_graphics_Canvas_);
			return cb_draw_Landroid_graphics_Canvas_;
		}

		static void n_Draw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.Resource.CtaButtonDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.CtaButtonDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='CtaButtonDrawable']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public override unsafe void Draw (global::Android.Graphics.Canvas p0)
		{
			if (id_draw_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;)V"), __args);
			} finally {
			}
		}

	}
}
