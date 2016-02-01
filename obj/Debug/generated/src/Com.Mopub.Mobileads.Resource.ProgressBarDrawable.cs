using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Resource {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='ProgressBarDrawable']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/resource/ProgressBarDrawable", DoNotGenerateAcw=true)]
	public partial class ProgressBarDrawable : global::Com.Mopub.Mobileads.Resource.BaseWidgetDrawable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/resource/ProgressBarDrawable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProgressBarDrawable); }
		}

		protected ProgressBarDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='ProgressBarDrawable']/constructor[@name='ProgressBarDrawable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ProgressBarDrawable (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ProgressBarDrawable)) {
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

		static Delegate cb_getCurrentProgress;
#pragma warning disable 0169
		static Delegate GetGetCurrentProgressHandler ()
		{
			if (cb_getCurrentProgress == null)
				cb_getCurrentProgress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentProgress);
			return cb_getCurrentProgress;
		}

		static int n_GetCurrentProgress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.Resource.ProgressBarDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.ProgressBarDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentProgress;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentProgress;
		[Obsolete (@"deprecated")]
		public virtual unsafe int CurrentProgress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='ProgressBarDrawable']/method[@name='getCurrentProgress' and count(parameter)=0]"
			[Register ("getCurrentProgress", "()I", "GetGetCurrentProgressHandler")]
			get {
				if (id_getCurrentProgress == IntPtr.Zero)
					id_getCurrentProgress = JNIEnv.GetMethodID (class_ref, "getCurrentProgress", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCurrentProgress);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentProgress", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSkipRatio;
#pragma warning disable 0169
		static Delegate GetGetSkipRatioHandler ()
		{
			if (cb_getSkipRatio == null)
				cb_getSkipRatio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetSkipRatio);
			return cb_getSkipRatio;
		}

		static float n_GetSkipRatio (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.Resource.ProgressBarDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.ProgressBarDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SkipRatio;
		}
#pragma warning restore 0169

		static IntPtr id_getSkipRatio;
		[Obsolete (@"deprecated")]
		public virtual unsafe float SkipRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='ProgressBarDrawable']/method[@name='getSkipRatio' and count(parameter)=0]"
			[Register ("getSkipRatio", "()F", "GetGetSkipRatioHandler")]
			get {
				if (id_getSkipRatio == IntPtr.Zero)
					id_getSkipRatio = JNIEnv.GetMethodID (class_ref, "getSkipRatio", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getSkipRatio);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSkipRatio", "()F"));
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
			global::Com.Mopub.Mobileads.Resource.ProgressBarDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.ProgressBarDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='ProgressBarDrawable']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
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

		static Delegate cb_forceCompletion;
#pragma warning disable 0169
		static Delegate GetForceCompletionHandler ()
		{
			if (cb_forceCompletion == null)
				cb_forceCompletion = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ForceCompletion);
			return cb_forceCompletion;
		}

		static void n_ForceCompletion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.Resource.ProgressBarDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.ProgressBarDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ForceCompletion ();
		}
#pragma warning restore 0169

		static IntPtr id_forceCompletion;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='ProgressBarDrawable']/method[@name='forceCompletion' and count(parameter)=0]"
		[Register ("forceCompletion", "()V", "GetForceCompletionHandler")]
		public virtual unsafe void ForceCompletion ()
		{
			if (id_forceCompletion == IntPtr.Zero)
				id_forceCompletion = JNIEnv.GetMethodID (class_ref, "forceCompletion", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_forceCompletion);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "forceCompletion", "()V"));
			} finally {
			}
		}

		static Delegate cb_setDurationAndSkipOffset_II;
#pragma warning disable 0169
		static Delegate GetSetDurationAndSkipOffset_IIHandler ()
		{
			if (cb_setDurationAndSkipOffset_II == null)
				cb_setDurationAndSkipOffset_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetDurationAndSkipOffset_II);
			return cb_setDurationAndSkipOffset_II;
		}

		static void n_SetDurationAndSkipOffset_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Mopub.Mobileads.Resource.ProgressBarDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.ProgressBarDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDurationAndSkipOffset (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setDurationAndSkipOffset_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='ProgressBarDrawable']/method[@name='setDurationAndSkipOffset' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setDurationAndSkipOffset", "(II)V", "GetSetDurationAndSkipOffset_IIHandler")]
		public virtual unsafe void SetDurationAndSkipOffset (int p0, int p1)
		{
			if (id_setDurationAndSkipOffset_II == IntPtr.Zero)
				id_setDurationAndSkipOffset_II = JNIEnv.GetMethodID (class_ref, "setDurationAndSkipOffset", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDurationAndSkipOffset_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDurationAndSkipOffset", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setProgress_I;
#pragma warning disable 0169
		static Delegate GetSetProgress_IHandler ()
		{
			if (cb_setProgress_I == null)
				cb_setProgress_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetProgress_I);
			return cb_setProgress_I;
		}

		static void n_SetProgress_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Mobileads.Resource.ProgressBarDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.ProgressBarDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetProgress (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setProgress_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='ProgressBarDrawable']/method[@name='setProgress' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setProgress", "(I)V", "GetSetProgress_IHandler")]
		public virtual unsafe void SetProgress (int p0)
		{
			if (id_setProgress_I == IntPtr.Zero)
				id_setProgress_I = JNIEnv.GetMethodID (class_ref, "setProgress", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setProgress_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProgress", "(I)V"), __args);
			} finally {
			}
		}

	}
}
