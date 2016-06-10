using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoBlurLastVideoFrameTask']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/VastVideoBlurLastVideoFrameTask", DoNotGenerateAcw=true)]
	public partial class VastVideoBlurLastVideoFrameTask : global::Android.OS.AsyncTask {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/VastVideoBlurLastVideoFrameTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VastVideoBlurLastVideoFrameTask); }
		}

		protected VastVideoBlurLastVideoFrameTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_media_MediaMetadataRetriever_Landroid_widget_ImageView_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoBlurLastVideoFrameTask']/constructor[@name='VastVideoBlurLastVideoFrameTask' and count(parameter)=3 and parameter[1][@type='android.media.MediaMetadataRetriever'] and parameter[2][@type='android.widget.ImageView'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/media/MediaMetadataRetriever;Landroid/widget/ImageView;I)V", "")]
		public unsafe VastVideoBlurLastVideoFrameTask (global::Android.Media.MediaMetadataRetriever p0, global::Android.Widget.ImageView p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (VastVideoBlurLastVideoFrameTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/media/MediaMetadataRetriever;Landroid/widget/ImageView;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/media/MediaMetadataRetriever;Landroid/widget/ImageView;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_media_MediaMetadataRetriever_Landroid_widget_ImageView_I == IntPtr.Zero)
					id_ctor_Landroid_media_MediaMetadataRetriever_Landroid_widget_ImageView_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/media/MediaMetadataRetriever;Landroid/widget/ImageView;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_media_MediaMetadataRetriever_Landroid_widget_ImageView_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_media_MediaMetadataRetriever_Landroid_widget_ImageView_I, __args);
			} finally {
			}
		}

		static Delegate cb_doInBackground_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDoInBackground_arrayLjava_lang_String_Handler ()
		{
			if (cb_doInBackground_arrayLjava_lang_String_ == null)
				cb_doInBackground_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_String_);
			return cb_doInBackground_arrayLjava_lang_String_;
		}

		static IntPtr n_DoInBackground_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastVideoBlurLastVideoFrameTask __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoBlurLastVideoFrameTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_doInBackground_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoBlurLastVideoFrameTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("doInBackground", "([Ljava/lang/String;)Ljava/lang/Boolean;", "GetDoInBackground_arrayLjava_lang_String_Handler")]
		protected virtual unsafe global::Java.Lang.Boolean DoInBackground (params  string[] p0)
		{
			if (id_doInBackground_arrayLjava_lang_String_ == IntPtr.Zero)
				id_doInBackground_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/String;)Ljava/lang/Boolean;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Java.Lang.Boolean __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_doInBackground_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Ljava/lang/String;)Ljava/lang/Boolean;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_onPostExecute_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetOnPostExecute_Ljava_lang_Boolean_Handler ()
		{
			if (cb_onPostExecute_Ljava_lang_Boolean_ == null)
				cb_onPostExecute_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPostExecute_Ljava_lang_Boolean_);
			return cb_onPostExecute_Ljava_lang_Boolean_;
		}

		static void n_OnPostExecute_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastVideoBlurLastVideoFrameTask __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoBlurLastVideoFrameTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPostExecute (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPostExecute_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoBlurLastVideoFrameTask']/method[@name='onPostExecute' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("onPostExecute", "(Ljava/lang/Boolean;)V", "GetOnPostExecute_Ljava_lang_Boolean_Handler")]
		protected virtual unsafe void OnPostExecute (global::Java.Lang.Boolean p0)
		{
			if (id_onPostExecute_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_onPostExecute_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "onPostExecute", "(Ljava/lang/Boolean;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onPostExecute_Ljava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPostExecute", "(Ljava/lang/Boolean;)V"), __args);
			} finally {
			}
		}

	}
}
