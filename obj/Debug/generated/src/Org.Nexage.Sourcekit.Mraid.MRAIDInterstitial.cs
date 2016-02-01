using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Mraid {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDInterstitial']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/mraid/MRAIDInterstitial", DoNotGenerateAcw=true)]
	public partial class MRAIDInterstitial : global::Java.Lang.Object, global::Org.Nexage.Sourcekit.Mraid.IMRAIDViewListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/mraid/MRAIDInterstitial", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MRAIDInterstitial); }
		}

		protected MRAIDInterstitial (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_IILorg_nexage_sourcekit_mraid_MRAIDInterstitialListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDInterstitial']/constructor[@name='MRAIDInterstitial' and count(parameter)=8 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='org.nexage.sourcekit.mraid.MRAIDInterstitialListener'] and parameter[8][@type='org.nexage.sourcekit.mraid.MRAIDNativeFeatureListener']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;IILorg/nexage/sourcekit/mraid/MRAIDInterstitialListener;Lorg/nexage/sourcekit/mraid/MRAIDNativeFeatureListener;)V", "")]
		public unsafe MRAIDInterstitial (global::Android.Content.Context p0, string p1, string p2, string[] p3, int p4, int p5, global::Org.Nexage.Sourcekit.Mraid.IMRAIDInterstitialListener p6, global::Org.Nexage.Sourcekit.Mraid.IMRAIDNativeFeatureListener p7)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				if (GetType () != typeof (MRAIDInterstitial)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;IILorg/nexage/sourcekit/mraid/MRAIDInterstitialListener;Lorg/nexage/sourcekit/mraid/MRAIDNativeFeatureListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;IILorg/nexage/sourcekit/mraid/MRAIDInterstitialListener;Lorg/nexage/sourcekit/mraid/MRAIDNativeFeatureListener;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_IILorg_nexage_sourcekit_mraid_MRAIDInterstitialListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_IILorg_nexage_sourcekit_mraid_MRAIDInterstitialListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;IILorg/nexage/sourcekit/mraid/MRAIDInterstitialListener;Lorg/nexage/sourcekit/mraid/MRAIDNativeFeatureListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_IILorg_nexage_sourcekit_mraid_MRAIDInterstitialListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_IILorg_nexage_sourcekit_mraid_MRAIDInterstitialListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static Delegate cb_mraidViewClose_Lorg_nexage_sourcekit_mraid_MRAIDView_;
#pragma warning disable 0169
		static Delegate GetMraidViewClose_Lorg_nexage_sourcekit_mraid_MRAIDView_Handler ()
		{
			if (cb_mraidViewClose_Lorg_nexage_sourcekit_mraid_MRAIDView_ == null)
				cb_mraidViewClose_Lorg_nexage_sourcekit_mraid_MRAIDView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MraidViewClose_Lorg_nexage_sourcekit_mraid_MRAIDView_);
			return cb_mraidViewClose_Lorg_nexage_sourcekit_mraid_MRAIDView_;
		}

		static void n_MraidViewClose_Lorg_nexage_sourcekit_mraid_MRAIDView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0 = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.MRAIDView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MraidViewClose (p0);
		}
#pragma warning restore 0169

		static IntPtr id_mraidViewClose_Lorg_nexage_sourcekit_mraid_MRAIDView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDInterstitial']/method[@name='mraidViewClose' and count(parameter)=1 and parameter[1][@type='org.nexage.sourcekit.mraid.MRAIDView']]"
		[Register ("mraidViewClose", "(Lorg/nexage/sourcekit/mraid/MRAIDView;)V", "GetMraidViewClose_Lorg_nexage_sourcekit_mraid_MRAIDView_Handler")]
		public virtual unsafe void MraidViewClose (global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0)
		{
			if (id_mraidViewClose_Lorg_nexage_sourcekit_mraid_MRAIDView_ == IntPtr.Zero)
				id_mraidViewClose_Lorg_nexage_sourcekit_mraid_MRAIDView_ = JNIEnv.GetMethodID (class_ref, "mraidViewClose", "(Lorg/nexage/sourcekit/mraid/MRAIDView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_mraidViewClose_Lorg_nexage_sourcekit_mraid_MRAIDView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mraidViewClose", "(Lorg/nexage/sourcekit/mraid/MRAIDView;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_mraidViewExpand_Lorg_nexage_sourcekit_mraid_MRAIDView_;
#pragma warning disable 0169
		static Delegate GetMraidViewExpand_Lorg_nexage_sourcekit_mraid_MRAIDView_Handler ()
		{
			if (cb_mraidViewExpand_Lorg_nexage_sourcekit_mraid_MRAIDView_ == null)
				cb_mraidViewExpand_Lorg_nexage_sourcekit_mraid_MRAIDView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MraidViewExpand_Lorg_nexage_sourcekit_mraid_MRAIDView_);
			return cb_mraidViewExpand_Lorg_nexage_sourcekit_mraid_MRAIDView_;
		}

		static void n_MraidViewExpand_Lorg_nexage_sourcekit_mraid_MRAIDView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0 = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.MRAIDView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MraidViewExpand (p0);
		}
#pragma warning restore 0169

		static IntPtr id_mraidViewExpand_Lorg_nexage_sourcekit_mraid_MRAIDView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDInterstitial']/method[@name='mraidViewExpand' and count(parameter)=1 and parameter[1][@type='org.nexage.sourcekit.mraid.MRAIDView']]"
		[Register ("mraidViewExpand", "(Lorg/nexage/sourcekit/mraid/MRAIDView;)V", "GetMraidViewExpand_Lorg_nexage_sourcekit_mraid_MRAIDView_Handler")]
		public virtual unsafe void MraidViewExpand (global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0)
		{
			if (id_mraidViewExpand_Lorg_nexage_sourcekit_mraid_MRAIDView_ == IntPtr.Zero)
				id_mraidViewExpand_Lorg_nexage_sourcekit_mraid_MRAIDView_ = JNIEnv.GetMethodID (class_ref, "mraidViewExpand", "(Lorg/nexage/sourcekit/mraid/MRAIDView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_mraidViewExpand_Lorg_nexage_sourcekit_mraid_MRAIDView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mraidViewExpand", "(Lorg/nexage/sourcekit/mraid/MRAIDView;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_mraidViewLoaded_Lorg_nexage_sourcekit_mraid_MRAIDView_;
#pragma warning disable 0169
		static Delegate GetMraidViewLoaded_Lorg_nexage_sourcekit_mraid_MRAIDView_Handler ()
		{
			if (cb_mraidViewLoaded_Lorg_nexage_sourcekit_mraid_MRAIDView_ == null)
				cb_mraidViewLoaded_Lorg_nexage_sourcekit_mraid_MRAIDView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MraidViewLoaded_Lorg_nexage_sourcekit_mraid_MRAIDView_);
			return cb_mraidViewLoaded_Lorg_nexage_sourcekit_mraid_MRAIDView_;
		}

		static void n_MraidViewLoaded_Lorg_nexage_sourcekit_mraid_MRAIDView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0 = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.MRAIDView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MraidViewLoaded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_mraidViewLoaded_Lorg_nexage_sourcekit_mraid_MRAIDView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDInterstitial']/method[@name='mraidViewLoaded' and count(parameter)=1 and parameter[1][@type='org.nexage.sourcekit.mraid.MRAIDView']]"
		[Register ("mraidViewLoaded", "(Lorg/nexage/sourcekit/mraid/MRAIDView;)V", "GetMraidViewLoaded_Lorg_nexage_sourcekit_mraid_MRAIDView_Handler")]
		public virtual unsafe void MraidViewLoaded (global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0)
		{
			if (id_mraidViewLoaded_Lorg_nexage_sourcekit_mraid_MRAIDView_ == IntPtr.Zero)
				id_mraidViewLoaded_Lorg_nexage_sourcekit_mraid_MRAIDView_ = JNIEnv.GetMethodID (class_ref, "mraidViewLoaded", "(Lorg/nexage/sourcekit/mraid/MRAIDView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_mraidViewLoaded_Lorg_nexage_sourcekit_mraid_MRAIDView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mraidViewLoaded", "(Lorg/nexage/sourcekit/mraid/MRAIDView;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_mraidViewResize_Lorg_nexage_sourcekit_mraid_MRAIDView_IIII;
#pragma warning disable 0169
		static Delegate GetMraidViewResize_Lorg_nexage_sourcekit_mraid_MRAIDView_IIIIHandler ()
		{
			if (cb_mraidViewResize_Lorg_nexage_sourcekit_mraid_MRAIDView_IIII == null)
				cb_mraidViewResize_Lorg_nexage_sourcekit_mraid_MRAIDView_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int, int, bool>) n_MraidViewResize_Lorg_nexage_sourcekit_mraid_MRAIDView_IIII);
			return cb_mraidViewResize_Lorg_nexage_sourcekit_mraid_MRAIDView_IIII;
		}

		static bool n_MraidViewResize_Lorg_nexage_sourcekit_mraid_MRAIDView_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4)
		{
			global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0 = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.MRAIDView> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.MraidViewResize (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_mraidViewResize_Lorg_nexage_sourcekit_mraid_MRAIDView_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDInterstitial']/method[@name='mraidViewResize' and count(parameter)=5 and parameter[1][@type='org.nexage.sourcekit.mraid.MRAIDView'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("mraidViewResize", "(Lorg/nexage/sourcekit/mraid/MRAIDView;IIII)Z", "GetMraidViewResize_Lorg_nexage_sourcekit_mraid_MRAIDView_IIIIHandler")]
		public virtual unsafe bool MraidViewResize (global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0, int p1, int p2, int p3, int p4)
		{
			if (id_mraidViewResize_Lorg_nexage_sourcekit_mraid_MRAIDView_IIII == IntPtr.Zero)
				id_mraidViewResize_Lorg_nexage_sourcekit_mraid_MRAIDView_IIII = JNIEnv.GetMethodID (class_ref, "mraidViewResize", "(Lorg/nexage/sourcekit/mraid/MRAIDView;IIII)Z");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_mraidViewResize_Lorg_nexage_sourcekit_mraid_MRAIDView_IIII, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mraidViewResize", "(Lorg/nexage/sourcekit/mraid/MRAIDView;IIII)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_show;
#pragma warning disable 0169
		static Delegate GetShowHandler ()
		{
			if (cb_show == null)
				cb_show = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Show);
			return cb_show;
		}

		static void n_Show (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Show ();
		}
#pragma warning restore 0169

		static IntPtr id_show;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDInterstitial']/method[@name='show' and count(parameter)=0]"
		[Register ("show", "()V", "GetShowHandler")]
		public virtual unsafe void Show ()
		{
			if (id_show == IntPtr.Zero)
				id_show = JNIEnv.GetMethodID (class_ref, "show", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_show);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "show", "()V"));
			} finally {
			}
		}

		static Delegate cb_show_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetShow_Landroid_app_Activity_Handler ()
		{
			if (cb_show_Landroid_app_Activity_ == null)
				cb_show_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Show_Landroid_app_Activity_);
			return cb_show_Landroid_app_Activity_;
		}

		static void n_Show_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Show (p0);
		}
#pragma warning restore 0169

		static IntPtr id_show_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDInterstitial']/method[@name='show' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("show", "(Landroid/app/Activity;)V", "GetShow_Landroid_app_Activity_Handler")]
		public virtual unsafe void Show (global::Android.App.Activity p0)
		{
			if (id_show_Landroid_app_Activity_ == IntPtr.Zero)
				id_show_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "show", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_show_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "show", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

	}
}
