using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Mraid.Rtb {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.mraid.rtb']/class[@name='ReportView']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/mraid/rtb/ReportView", DoNotGenerateAcw=true)]
	public partial class ReportView : global::Android.Widget.LinearLayout {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/mraid/rtb/ReportView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReportView); }
		}

		protected ReportView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.mraid.rtb']/class[@name='ReportView']/constructor[@name='ReportView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ReportView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ReportView)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.mraid.rtb']/class[@name='ReportView']/constructor[@name='ReportView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ReportView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ReportView)) {
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

		static Delegate cb_setUrl_Lorg_nexage_sourcekit_mraid_rtb_RtbInfo_;
#pragma warning disable 0169
		static Delegate GetSetUrl_Lorg_nexage_sourcekit_mraid_rtb_RtbInfo_Handler ()
		{
			if (cb_setUrl_Lorg_nexage_sourcekit_mraid_rtb_RtbInfo_ == null)
				cb_setUrl_Lorg_nexage_sourcekit_mraid_rtb_RtbInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUrl_Lorg_nexage_sourcekit_mraid_rtb_RtbInfo_);
			return cb_setUrl_Lorg_nexage_sourcekit_mraid_rtb_RtbInfo_;
		}

		static void n_SetUrl_Lorg_nexage_sourcekit_mraid_rtb_RtbInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Mraid.Rtb.ReportView __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.Rtb.ReportView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Nexage.Sourcekit.Mraid.Rtb.RtbInfo p0 = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.Rtb.RtbInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetUrl (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setUrl_Lorg_nexage_sourcekit_mraid_rtb_RtbInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.rtb']/class[@name='ReportView']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='org.nexage.sourcekit.mraid.rtb.RtbInfo']]"
		[Register ("setUrl", "(Lorg/nexage/sourcekit/mraid/rtb/RtbInfo;)V", "GetSetUrl_Lorg_nexage_sourcekit_mraid_rtb_RtbInfo_Handler")]
		public virtual unsafe void SetUrl (global::Org.Nexage.Sourcekit.Mraid.Rtb.RtbInfo p0)
		{
			if (id_setUrl_Lorg_nexage_sourcekit_mraid_rtb_RtbInfo_ == IntPtr.Zero)
				id_setUrl_Lorg_nexage_sourcekit_mraid_rtb_RtbInfo_ = JNIEnv.GetMethodID (class_ref, "setUrl", "(Lorg/nexage/sourcekit/mraid/rtb/RtbInfo;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUrl_Lorg_nexage_sourcekit_mraid_rtb_RtbInfo_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUrl", "(Lorg/nexage/sourcekit/mraid/rtb/RtbInfo;)V"), __args);
			} finally {
			}
		}

	}
}
