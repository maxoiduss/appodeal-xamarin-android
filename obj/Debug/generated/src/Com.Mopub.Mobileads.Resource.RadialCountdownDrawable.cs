using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Resource {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='RadialCountdownDrawable']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/resource/RadialCountdownDrawable", DoNotGenerateAcw=true)]
	public partial class RadialCountdownDrawable : global::Com.Mopub.Mobileads.Resource.BaseWidgetDrawable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/resource/RadialCountdownDrawable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RadialCountdownDrawable); }
		}

		protected RadialCountdownDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='RadialCountdownDrawable']/constructor[@name='RadialCountdownDrawable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe RadialCountdownDrawable (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (RadialCountdownDrawable)) {
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

		static Delegate cb_getInitialCountdownMilliseconds;
#pragma warning disable 0169
		static Delegate GetGetInitialCountdownMillisecondsHandler ()
		{
			if (cb_getInitialCountdownMilliseconds == null)
				cb_getInitialCountdownMilliseconds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetInitialCountdownMilliseconds);
			return cb_getInitialCountdownMilliseconds;
		}

		static int n_GetInitialCountdownMilliseconds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.Resource.RadialCountdownDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.RadialCountdownDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InitialCountdownMilliseconds;
		}
#pragma warning restore 0169

		static IntPtr id_getInitialCountdownMilliseconds;
		[Obsolete (@"deprecated")]
		public virtual unsafe int InitialCountdownMilliseconds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='RadialCountdownDrawable']/method[@name='getInitialCountdownMilliseconds' and count(parameter)=0]"
			[Register ("getInitialCountdownMilliseconds", "()I", "GetGetInitialCountdownMillisecondsHandler")]
			get {
				if (id_getInitialCountdownMilliseconds == IntPtr.Zero)
					id_getInitialCountdownMilliseconds = JNIEnv.GetMethodID (class_ref, "getInitialCountdownMilliseconds", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getInitialCountdownMilliseconds);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInitialCountdownMilliseconds", "()I"));
				} finally {
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
			global::Com.Mopub.Mobileads.Resource.RadialCountdownDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.RadialCountdownDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='RadialCountdownDrawable']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
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

		static Delegate cb_setInitialCountdown_I;
#pragma warning disable 0169
		static Delegate GetSetInitialCountdown_IHandler ()
		{
			if (cb_setInitialCountdown_I == null)
				cb_setInitialCountdown_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetInitialCountdown_I);
			return cb_setInitialCountdown_I;
		}

		static void n_SetInitialCountdown_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Mobileads.Resource.RadialCountdownDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.RadialCountdownDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInitialCountdown (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInitialCountdown_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='RadialCountdownDrawable']/method[@name='setInitialCountdown' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setInitialCountdown", "(I)V", "GetSetInitialCountdown_IHandler")]
		public virtual unsafe void SetInitialCountdown (int p0)
		{
			if (id_setInitialCountdown_I == IntPtr.Zero)
				id_setInitialCountdown_I = JNIEnv.GetMethodID (class_ref, "setInitialCountdown", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setInitialCountdown_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInitialCountdown", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateCountdownProgress_I;
#pragma warning disable 0169
		static Delegate GetUpdateCountdownProgress_IHandler ()
		{
			if (cb_updateCountdownProgress_I == null)
				cb_updateCountdownProgress_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_UpdateCountdownProgress_I);
			return cb_updateCountdownProgress_I;
		}

		static void n_UpdateCountdownProgress_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Mobileads.Resource.RadialCountdownDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.RadialCountdownDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateCountdownProgress (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateCountdownProgress_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='RadialCountdownDrawable']/method[@name='updateCountdownProgress' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("updateCountdownProgress", "(I)V", "GetUpdateCountdownProgress_IHandler")]
		public virtual unsafe void UpdateCountdownProgress (int p0)
		{
			if (id_updateCountdownProgress_I == IntPtr.Zero)
				id_updateCountdownProgress_I = JNIEnv.GetMethodID (class_ref, "updateCountdownProgress", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_updateCountdownProgress_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateCountdownProgress", "(I)V"), __args);
			} finally {
			}
		}

	}
}
