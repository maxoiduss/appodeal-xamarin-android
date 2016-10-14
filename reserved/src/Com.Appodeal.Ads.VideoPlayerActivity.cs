using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appodeal.ads']/class[@name='VideoPlayerActivity']"
	[global::Android.Runtime.Register ("com/appodeal/ads/VideoPlayerActivity", DoNotGenerateAcw=true)]
	public partial class VideoPlayerActivity : global::Android.App.Activity, global::Android.Media.MediaPlayer.IOnCompletionListener, global::Android.Media.MediaPlayer.IOnErrorListener, global::Android.Media.MediaPlayer.IOnPreparedListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/appodeal/ads/VideoPlayerActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoPlayerActivity); }
		}

		protected VideoPlayerActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.appodeal.ads']/class[@name='VideoPlayerActivity']/constructor[@name='VideoPlayerActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VideoPlayerActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VideoPlayerActivity)) {
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

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='VideoPlayerActivity']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/String;I)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent A (global::Android.Content.Context p0, string p1, int p2)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_String_I == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/String;I)Landroid/content/Intent;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_content_Context_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Appodeal.Ads.VideoPlayerActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.VideoPlayerActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCompletion (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCompletion_Landroid_media_MediaPlayer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='VideoPlayerActivity']/method[@name='onCompletion' and count(parameter)=1 and parameter[1][@type='android.media.MediaPlayer']]"
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
			global::Com.Appodeal.Ads.VideoPlayerActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.VideoPlayerActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaError p1 = (global::Android.Media.MediaError) native_p1;
			bool __ret = __this.OnError (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onError_Landroid_media_MediaPlayer_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='VideoPlayerActivity']/method[@name='onError' and count(parameter)=3 and parameter[1][@type='android.media.MediaPlayer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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
			global::Com.Appodeal.Ads.VideoPlayerActivity __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.VideoPlayerActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPrepared (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPrepared_Landroid_media_MediaPlayer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='VideoPlayerActivity']/method[@name='onPrepared' and count(parameter)=1 and parameter[1][@type='android.media.MediaPlayer']]"
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

	}
}
