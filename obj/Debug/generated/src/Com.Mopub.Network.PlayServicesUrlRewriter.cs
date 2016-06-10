using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.network']/class[@name='PlayServicesUrlRewriter']"
	[global::Android.Runtime.Register ("com/mopub/network/PlayServicesUrlRewriter", DoNotGenerateAcw=true)]
	public partial class PlayServicesUrlRewriter : global::Java.Lang.Object, global::Com.Mopub.Volley.Toolbox.HurlStack.IUrlRewriter {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.network']/class[@name='PlayServicesUrlRewriter']/field[@name='DO_NOT_TRACK_TEMPLATE']"
		[Register ("DO_NOT_TRACK_TEMPLATE")]
		public const string DoNotTrackTemplate = (string) "mp_tmpl_do_not_track";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.network']/class[@name='PlayServicesUrlRewriter']/field[@name='UDID_TEMPLATE']"
		[Register ("UDID_TEMPLATE")]
		public const string UdidTemplate = (string) "mp_tmpl_advertising_id";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/network/PlayServicesUrlRewriter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlayServicesUrlRewriter); }
		}

		protected PlayServicesUrlRewriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.network']/class[@name='PlayServicesUrlRewriter']/constructor[@name='PlayServicesUrlRewriter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register (".ctor", "(Ljava/lang/String;Landroid/content/Context;)V", "")]
		public unsafe PlayServicesUrlRewriter (string p0, global::Android.Content.Context p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (PlayServicesUrlRewriter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Landroid_content_Context_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_rewriteUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRewriteUrl_Ljava_lang_String_Handler ()
		{
			if (cb_rewriteUrl_Ljava_lang_String_ == null)
				cb_rewriteUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RewriteUrl_Ljava_lang_String_);
			return cb_rewriteUrl_Ljava_lang_String_;
		}

		static IntPtr n_RewriteUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Network.PlayServicesUrlRewriter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.PlayServicesUrlRewriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.RewriteUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_rewriteUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='PlayServicesUrlRewriter']/method[@name='rewriteUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("rewriteUrl", "(Ljava/lang/String;)Ljava/lang/String;", "GetRewriteUrl_Ljava_lang_String_Handler")]
		public virtual unsafe string RewriteUrl (string p0)
		{
			if (id_rewriteUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_rewriteUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "rewriteUrl", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_rewriteUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rewriteUrl", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
