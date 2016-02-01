using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley.Toolbox {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='NetworkImageView']"
	[global::Android.Runtime.Register ("com/mopub/volley/toolbox/NetworkImageView", DoNotGenerateAcw=true)]
	public partial class NetworkImageView : global::Android.Widget.ImageView {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/toolbox/NetworkImageView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkImageView); }
		}

		protected NetworkImageView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='NetworkImageView']/constructor[@name='NetworkImageView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe NetworkImageView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (NetworkImageView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='NetworkImageView']/constructor[@name='NetworkImageView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe NetworkImageView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (NetworkImageView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='NetworkImageView']/constructor[@name='NetworkImageView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe NetworkImageView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (NetworkImageView)) {
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

		static Delegate cb_setDefaultImageResId_I;
#pragma warning disable 0169
		static Delegate GetSetDefaultImageResId_IHandler ()
		{
			if (cb_setDefaultImageResId_I == null)
				cb_setDefaultImageResId_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDefaultImageResId_I);
			return cb_setDefaultImageResId_I;
		}

		static void n_SetDefaultImageResId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Volley.Toolbox.NetworkImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.NetworkImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultImageResId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDefaultImageResId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='NetworkImageView']/method[@name='setDefaultImageResId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDefaultImageResId", "(I)V", "GetSetDefaultImageResId_IHandler")]
		public virtual unsafe void SetDefaultImageResId (int p0)
		{
			if (id_setDefaultImageResId_I == IntPtr.Zero)
				id_setDefaultImageResId_I = JNIEnv.GetMethodID (class_ref, "setDefaultImageResId", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDefaultImageResId_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultImageResId", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setErrorImageResId_I;
#pragma warning disable 0169
		static Delegate GetSetErrorImageResId_IHandler ()
		{
			if (cb_setErrorImageResId_I == null)
				cb_setErrorImageResId_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetErrorImageResId_I);
			return cb_setErrorImageResId_I;
		}

		static void n_SetErrorImageResId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Volley.Toolbox.NetworkImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.NetworkImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetErrorImageResId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setErrorImageResId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='NetworkImageView']/method[@name='setErrorImageResId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setErrorImageResId", "(I)V", "GetSetErrorImageResId_IHandler")]
		public virtual unsafe void SetErrorImageResId (int p0)
		{
			if (id_setErrorImageResId_I == IntPtr.Zero)
				id_setErrorImageResId_I = JNIEnv.GetMethodID (class_ref, "setErrorImageResId", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setErrorImageResId_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setErrorImageResId", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setImageUrl_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_;
#pragma warning disable 0169
		static Delegate GetSetImageUrl_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_Handler ()
		{
			if (cb_setImageUrl_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ == null)
				cb_setImageUrl_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetImageUrl_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_);
			return cb_setImageUrl_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_;
		}

		static void n_SetImageUrl_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Volley.Toolbox.NetworkImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.NetworkImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.Toolbox.ImageLoader p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetImageUrl (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setImageUrl_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='NetworkImageView']/method[@name='setImageUrl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.volley.toolbox.ImageLoader']]"
		[Register ("setImageUrl", "(Ljava/lang/String;Lcom/mopub/volley/toolbox/ImageLoader;)V", "GetSetImageUrl_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_Handler")]
		public virtual unsafe void SetImageUrl (string p0, global::Com.Mopub.Volley.Toolbox.ImageLoader p1)
		{
			if (id_setImageUrl_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ == IntPtr.Zero)
				id_setImageUrl_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ = JNIEnv.GetMethodID (class_ref, "setImageUrl", "(Ljava/lang/String;Lcom/mopub/volley/toolbox/ImageLoader;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setImageUrl_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageUrl", "(Ljava/lang/String;Lcom/mopub/volley/toolbox/ImageLoader;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
