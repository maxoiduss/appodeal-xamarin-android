using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoViewProgressRunnable']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/VastVideoViewProgressRunnable", DoNotGenerateAcw=true)]
	public partial class VastVideoViewProgressRunnable : global::Com.Mopub.Mobileads.RepeatingHandlerRunnable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/VastVideoViewProgressRunnable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VastVideoViewProgressRunnable); }
		}

		protected VastVideoViewProgressRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mopub_mobileads_VastVideoViewController_Lcom_mopub_mobileads_VastVideoConfig_Landroid_os_Handler_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoViewProgressRunnable']/constructor[@name='VastVideoViewProgressRunnable' and count(parameter)=3 and parameter[1][@type='com.mopub.mobileads.VastVideoViewController'] and parameter[2][@type='com.mopub.mobileads.VastVideoConfig'] and parameter[3][@type='android.os.Handler']]"
		[Register (".ctor", "(Lcom/mopub/mobileads/VastVideoViewController;Lcom/mopub/mobileads/VastVideoConfig;Landroid/os/Handler;)V", "")]
		public unsafe VastVideoViewProgressRunnable (global::Com.Mopub.Mobileads.VastVideoViewController p0, global::Com.Mopub.Mobileads.VastVideoConfig p1, global::Android.OS.Handler p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (VastVideoViewProgressRunnable)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/mobileads/VastVideoViewController;Lcom/mopub/mobileads/VastVideoConfig;Landroid/os/Handler;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/mobileads/VastVideoViewController;Lcom/mopub/mobileads/VastVideoConfig;Landroid/os/Handler;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mopub_mobileads_VastVideoViewController_Lcom_mopub_mobileads_VastVideoConfig_Landroid_os_Handler_ == IntPtr.Zero)
					id_ctor_Lcom_mopub_mobileads_VastVideoViewController_Lcom_mopub_mobileads_VastVideoConfig_Landroid_os_Handler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/mobileads/VastVideoViewController;Lcom/mopub/mobileads/VastVideoConfig;Landroid/os/Handler;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_mobileads_VastVideoViewController_Lcom_mopub_mobileads_VastVideoConfig_Landroid_os_Handler_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_mobileads_VastVideoViewController_Lcom_mopub_mobileads_VastVideoConfig_Landroid_os_Handler_, __args);
			} finally {
			}
		}

		static Delegate cb_doWork;
#pragma warning disable 0169
		static Delegate GetDoWorkHandler ()
		{
			if (cb_doWork == null)
				cb_doWork = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DoWork);
			return cb_doWork;
		}

		static void n_DoWork (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastVideoViewProgressRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoViewProgressRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoWork ();
		}
#pragma warning restore 0169

		static IntPtr id_doWork;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoViewProgressRunnable']/method[@name='doWork' and count(parameter)=0]"
		[Register ("doWork", "()V", "GetDoWorkHandler")]
		public override unsafe void DoWork ()
		{
			if (id_doWork == IntPtr.Zero)
				id_doWork = JNIEnv.GetMethodID (class_ref, "doWork", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_doWork);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doWork", "()V"));
			} finally {
			}
		}

	}
}
