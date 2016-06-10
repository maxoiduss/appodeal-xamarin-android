using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Vast.Activity {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.vast.activity']/class[@name='VASTActivity']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/vast/activity/VASTActivity", DoNotGenerateAcw=true)]
	public partial class VASTActivity : global::Android.App.Activity, global::Android.Media.MediaPlayer.IOnCompletionListener, global::Android.Media.MediaPlayer.IOnErrorListener, global::Android.Media.MediaPlayer.IOnPreparedListener, global::Android.Media.MediaPlayer.IOnVideoSizeChangedListener, global::Android.Views.ISurfaceHolderCallback {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/vast/activity/VASTActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VASTActivity); }
		}

		protected VASTActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.vast.activity']/class[@name='VASTActivity']/constructor[@name='VASTActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VASTActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VASTActivity)) {
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

		static Delegate cb_onCompletion_Landroid_media_MediaPlayer_;
#pragma warning disable 0169
		static Delegate GetOnCompletion_Landroid_media_MediaPlayer_Handler ()
		{
			if (cb_onCompletion_Landroid_media_MediaPlayer_ == null)
				cb_onCompletion_Landroid_media_MediaPlayer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCompletion_Landroid_media_MediaPlayer_);
			return cb_onCompletion_Landroid_media_MediaPlayer_;
		}

		static void n_OnCompletion_Landroid_media_MediaPlayer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Vast.Activity.VASTActivity __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Activity.VASTActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCompletion (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCompletion_Landroid_media_MediaPlayer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.activity']/class[@name='VASTActivity']/method[@name='onCompletion' and count(parameter)=1 and parameter[1][@type='android.media.MediaPlayer']]"
		[Register ("onCompletion", "(Landroid/media/MediaPlayer;)V", "GetOnCompletion_Landroid_media_MediaPlayer_Handler")]
		public virtual unsafe void OnCompletion (global::Android.Media.MediaPlayer p0)
		{
			if (id_onCompletion_Landroid_media_MediaPlayer_ == IntPtr.Zero)
				id_onCompletion_Landroid_media_MediaPlayer_ = JNIEnv.GetMethodID (class_ref, "onCompletion", "(Landroid/media/MediaPlayer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCompletion_Landroid_media_MediaPlayer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCompletion", "(Landroid/media/MediaPlayer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onError_Landroid_media_MediaPlayer_II;
#pragma warning disable 0169
		static Delegate GetOnError_Landroid_media_MediaPlayer_IIHandler ()
		{
			if (cb_onError_Landroid_media_MediaPlayer_II == null)
				cb_onError_Landroid_media_MediaPlayer_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool>) n_OnError_Landroid_media_MediaPlayer_II);
			return cb_onError_Landroid_media_MediaPlayer_II;
		}

		static bool n_OnError_Landroid_media_MediaPlayer_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1, int p2)
		{
			global::Org.Nexage.Sourcekit.Vast.Activity.VASTActivity __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Activity.VASTActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaError p1 = (global::Android.Media.MediaError) native_p1;
			bool __ret = __this.OnError (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onError_Landroid_media_MediaPlayer_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.activity']/class[@name='VASTActivity']/method[@name='onError' and count(parameter)=3 and parameter[1][@type='android.media.MediaPlayer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onError", "(Landroid/media/MediaPlayer;II)Z", "GetOnError_Landroid_media_MediaPlayer_IIHandler")]
		public virtual unsafe bool OnError (global::Android.Media.MediaPlayer p0, [global::Android.Runtime.GeneratedEnum] global::Android.Media.MediaError p1, int p2)
		{
			if (id_onError_Landroid_media_MediaPlayer_II == IntPtr.Zero)
				id_onError_Landroid_media_MediaPlayer_II = JNIEnv.GetMethodID (class_ref, "onError", "(Landroid/media/MediaPlayer;II)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onError_Landroid_media_MediaPlayer_II, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onError", "(Landroid/media/MediaPlayer;II)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onPrepared_Landroid_media_MediaPlayer_;
#pragma warning disable 0169
		static Delegate GetOnPrepared_Landroid_media_MediaPlayer_Handler ()
		{
			if (cb_onPrepared_Landroid_media_MediaPlayer_ == null)
				cb_onPrepared_Landroid_media_MediaPlayer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPrepared_Landroid_media_MediaPlayer_);
			return cb_onPrepared_Landroid_media_MediaPlayer_;
		}

		static void n_OnPrepared_Landroid_media_MediaPlayer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Vast.Activity.VASTActivity __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Activity.VASTActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPrepared (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPrepared_Landroid_media_MediaPlayer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.activity']/class[@name='VASTActivity']/method[@name='onPrepared' and count(parameter)=1 and parameter[1][@type='android.media.MediaPlayer']]"
		[Register ("onPrepared", "(Landroid/media/MediaPlayer;)V", "GetOnPrepared_Landroid_media_MediaPlayer_Handler")]
		public virtual unsafe void OnPrepared (global::Android.Media.MediaPlayer p0)
		{
			if (id_onPrepared_Landroid_media_MediaPlayer_ == IntPtr.Zero)
				id_onPrepared_Landroid_media_MediaPlayer_ = JNIEnv.GetMethodID (class_ref, "onPrepared", "(Landroid/media/MediaPlayer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onPrepared_Landroid_media_MediaPlayer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPrepared", "(Landroid/media/MediaPlayer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onRestoreInstanceState_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnRestoreInstanceState_Landroid_os_Bundle_Handler ()
		{
			if (cb_onRestoreInstanceState_Landroid_os_Bundle_ == null)
				cb_onRestoreInstanceState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRestoreInstanceState_Landroid_os_Bundle_);
			return cb_onRestoreInstanceState_Landroid_os_Bundle_;
		}

		static void n_OnRestoreInstanceState_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Vast.Activity.VASTActivity __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Activity.VASTActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRestoreInstanceState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRestoreInstanceState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.activity']/class[@name='VASTActivity']/method[@name='onRestoreInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onRestoreInstanceState", "(Landroid/os/Bundle;)V", "GetOnRestoreInstanceState_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnRestoreInstanceState (global::Android.OS.Bundle p0)
		{
			if (id_onRestoreInstanceState_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onRestoreInstanceState_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onRestoreInstanceState_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSaveInstanceState_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnSaveInstanceState_Landroid_os_Bundle_Handler ()
		{
			if (cb_onSaveInstanceState_Landroid_os_Bundle_ == null)
				cb_onSaveInstanceState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSaveInstanceState_Landroid_os_Bundle_);
			return cb_onSaveInstanceState_Landroid_os_Bundle_;
		}

		static void n_OnSaveInstanceState_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Vast.Activity.VASTActivity __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Activity.VASTActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSaveInstanceState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSaveInstanceState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.activity']/class[@name='VASTActivity']/method[@name='onSaveInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onSaveInstanceState", "(Landroid/os/Bundle;)V", "GetOnSaveInstanceState_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnSaveInstanceState (global::Android.OS.Bundle p0)
		{
			if (id_onSaveInstanceState_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onSaveInstanceState_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onSaveInstanceState", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onSaveInstanceState_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onVideoSizeChanged_Landroid_media_MediaPlayer_II;
#pragma warning disable 0169
		static Delegate GetOnVideoSizeChanged_Landroid_media_MediaPlayer_IIHandler ()
		{
			if (cb_onVideoSizeChanged_Landroid_media_MediaPlayer_II == null)
				cb_onVideoSizeChanged_Landroid_media_MediaPlayer_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnVideoSizeChanged_Landroid_media_MediaPlayer_II);
			return cb_onVideoSizeChanged_Landroid_media_MediaPlayer_II;
		}

		static void n_OnVideoSizeChanged_Landroid_media_MediaPlayer_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Org.Nexage.Sourcekit.Vast.Activity.VASTActivity __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Activity.VASTActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnVideoSizeChanged (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onVideoSizeChanged_Landroid_media_MediaPlayer_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.activity']/class[@name='VASTActivity']/method[@name='onVideoSizeChanged' and count(parameter)=3 and parameter[1][@type='android.media.MediaPlayer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onVideoSizeChanged", "(Landroid/media/MediaPlayer;II)V", "GetOnVideoSizeChanged_Landroid_media_MediaPlayer_IIHandler")]
		public virtual unsafe void OnVideoSizeChanged (global::Android.Media.MediaPlayer p0, int p1, int p2)
		{
			if (id_onVideoSizeChanged_Landroid_media_MediaPlayer_II == IntPtr.Zero)
				id_onVideoSizeChanged_Landroid_media_MediaPlayer_II = JNIEnv.GetMethodID (class_ref, "onVideoSizeChanged", "(Landroid/media/MediaPlayer;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onVideoSizeChanged_Landroid_media_MediaPlayer_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onVideoSizeChanged", "(Landroid/media/MediaPlayer;II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_surfaceChanged_Landroid_view_SurfaceHolder_III;
#pragma warning disable 0169
		static Delegate GetSurfaceChanged_Landroid_view_SurfaceHolder_IIIHandler ()
		{
			if (cb_surfaceChanged_Landroid_view_SurfaceHolder_III == null)
				cb_surfaceChanged_Landroid_view_SurfaceHolder_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_SurfaceChanged_Landroid_view_SurfaceHolder_III);
			return cb_surfaceChanged_Landroid_view_SurfaceHolder_III;
		}

		static void n_SurfaceChanged_Landroid_view_SurfaceHolder_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1, int p2, int p3)
		{
			global::Org.Nexage.Sourcekit.Vast.Activity.VASTActivity __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Activity.VASTActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Format p1 = (global::Android.Graphics.Format) native_p1;
			__this.SurfaceChanged (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_surfaceChanged_Landroid_view_SurfaceHolder_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.activity']/class[@name='VASTActivity']/method[@name='surfaceChanged' and count(parameter)=4 and parameter[1][@type='android.view.SurfaceHolder'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("surfaceChanged", "(Landroid/view/SurfaceHolder;III)V", "GetSurfaceChanged_Landroid_view_SurfaceHolder_IIIHandler")]
		public virtual unsafe void SurfaceChanged (global::Android.Views.ISurfaceHolder p0, [global::Android.Runtime.GeneratedEnum] global::Android.Graphics.Format p1, int p2, int p3)
		{
			if (id_surfaceChanged_Landroid_view_SurfaceHolder_III == IntPtr.Zero)
				id_surfaceChanged_Landroid_view_SurfaceHolder_III = JNIEnv.GetMethodID (class_ref, "surfaceChanged", "(Landroid/view/SurfaceHolder;III)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_surfaceChanged_Landroid_view_SurfaceHolder_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "surfaceChanged", "(Landroid/view/SurfaceHolder;III)V"), __args);
			} finally {
			}
		}

		static Delegate cb_surfaceCreated_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSurfaceCreated_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_surfaceCreated_Landroid_view_SurfaceHolder_ == null)
				cb_surfaceCreated_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SurfaceCreated_Landroid_view_SurfaceHolder_);
			return cb_surfaceCreated_Landroid_view_SurfaceHolder_;
		}

		static void n_SurfaceCreated_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Vast.Activity.VASTActivity __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Activity.VASTActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceCreated (p0);
		}
#pragma warning restore 0169

		static IntPtr id_surfaceCreated_Landroid_view_SurfaceHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.activity']/class[@name='VASTActivity']/method[@name='surfaceCreated' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("surfaceCreated", "(Landroid/view/SurfaceHolder;)V", "GetSurfaceCreated_Landroid_view_SurfaceHolder_Handler")]
		public virtual unsafe void SurfaceCreated (global::Android.Views.ISurfaceHolder p0)
		{
			if (id_surfaceCreated_Landroid_view_SurfaceHolder_ == IntPtr.Zero)
				id_surfaceCreated_Landroid_view_SurfaceHolder_ = JNIEnv.GetMethodID (class_ref, "surfaceCreated", "(Landroid/view/SurfaceHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_surfaceCreated_Landroid_view_SurfaceHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "surfaceCreated", "(Landroid/view/SurfaceHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_surfaceDestroyed_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSurfaceDestroyed_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_surfaceDestroyed_Landroid_view_SurfaceHolder_ == null)
				cb_surfaceDestroyed_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SurfaceDestroyed_Landroid_view_SurfaceHolder_);
			return cb_surfaceDestroyed_Landroid_view_SurfaceHolder_;
		}

		static void n_SurfaceDestroyed_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Vast.Activity.VASTActivity __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Activity.VASTActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceDestroyed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_surfaceDestroyed_Landroid_view_SurfaceHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.activity']/class[@name='VASTActivity']/method[@name='surfaceDestroyed' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V", "GetSurfaceDestroyed_Landroid_view_SurfaceHolder_Handler")]
		public virtual unsafe void SurfaceDestroyed (global::Android.Views.ISurfaceHolder p0)
		{
			if (id_surfaceDestroyed_Landroid_view_SurfaceHolder_ == IntPtr.Zero)
				id_surfaceDestroyed_Landroid_view_SurfaceHolder_ = JNIEnv.GetMethodID (class_ref, "surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_surfaceDestroyed_Landroid_view_SurfaceHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V"), __args);
			} finally {
			}
		}

	}
}
