using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastFractionalProgressTracker']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/VastFractionalProgressTracker", DoNotGenerateAcw=true)]
	public partial class VastFractionalProgressTracker : global::Com.Mopub.Mobileads.VastTracker, global::Java.IO.ISerializable, global::Java.Lang.IComparable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/VastFractionalProgressTracker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VastFractionalProgressTracker); }
		}

		protected VastFractionalProgressTracker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_F;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastFractionalProgressTracker']/constructor[@name='VastFractionalProgressTracker' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
		[Register (".ctor", "(Ljava/lang/String;F)V", "")]
		public unsafe VastFractionalProgressTracker (string p0, float p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (VastFractionalProgressTracker)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;F)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;F)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_F == IntPtr.Zero)
					id_ctor_Ljava_lang_String_F = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;F)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_F, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_F, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_compareTo_Lcom_mopub_mobileads_VastFractionalProgressTracker_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_mopub_mobileads_VastFractionalProgressTracker_Handler ()
		{
			if (cb_compareTo_Lcom_mopub_mobileads_VastFractionalProgressTracker_ == null)
				cb_compareTo_Lcom_mopub_mobileads_VastFractionalProgressTracker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_mopub_mobileads_VastFractionalProgressTracker_);
			return cb_compareTo_Lcom_mopub_mobileads_VastFractionalProgressTracker_;
		}

		static int n_CompareTo_Lcom_mopub_mobileads_VastFractionalProgressTracker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastFractionalProgressTracker __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastFractionalProgressTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.VastFractionalProgressTracker p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastFractionalProgressTracker> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_mopub_mobileads_VastFractionalProgressTracker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastFractionalProgressTracker']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.VastFractionalProgressTracker']]"
		[Register ("compareTo", "(Lcom/mopub/mobileads/VastFractionalProgressTracker;)I", "GetCompareTo_Lcom_mopub_mobileads_VastFractionalProgressTracker_Handler")]
		public virtual unsafe int CompareTo (global::Com.Mopub.Mobileads.VastFractionalProgressTracker p0)
		{
			if (id_compareTo_Lcom_mopub_mobileads_VastFractionalProgressTracker_ == IntPtr.Zero)
				id_compareTo_Lcom_mopub_mobileads_VastFractionalProgressTracker_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/mopub/mobileads/VastFractionalProgressTracker;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lcom_mopub_mobileads_VastFractionalProgressTracker_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lcom/mopub/mobileads/VastFractionalProgressTracker;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_trackingFraction;
#pragma warning disable 0169
		static Delegate GetTrackingFractionHandler ()
		{
			if (cb_trackingFraction == null)
				cb_trackingFraction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_TrackingFraction);
			return cb_trackingFraction;
		}

		static float n_TrackingFraction (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastFractionalProgressTracker __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastFractionalProgressTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrackingFraction ();
		}
#pragma warning restore 0169

		static IntPtr id_trackingFraction;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastFractionalProgressTracker']/method[@name='trackingFraction' and count(parameter)=0]"
		[Register ("trackingFraction", "()F", "GetTrackingFractionHandler")]
		public virtual unsafe float TrackingFraction ()
		{
			if (id_trackingFraction == IntPtr.Zero)
				id_trackingFraction = JNIEnv.GetMethodID (class_ref, "trackingFraction", "()F");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_trackingFraction);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trackingFraction", "()F"));
			} finally {
			}
		}

	}
}
