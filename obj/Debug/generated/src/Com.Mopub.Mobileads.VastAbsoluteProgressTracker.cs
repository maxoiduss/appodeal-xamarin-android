using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastAbsoluteProgressTracker']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/VastAbsoluteProgressTracker", DoNotGenerateAcw=true)]
	public partial class VastAbsoluteProgressTracker : global::Com.Mopub.Mobileads.VastTracker, global::Java.IO.ISerializable, global::Java.Lang.IComparable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/VastAbsoluteProgressTracker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VastAbsoluteProgressTracker); }
		}

		protected VastAbsoluteProgressTracker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastAbsoluteProgressTracker']/constructor[@name='VastAbsoluteProgressTracker' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		public unsafe VastAbsoluteProgressTracker (string p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (VastAbsoluteProgressTracker)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_I == IntPtr.Zero)
					id_ctor_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getTrackingMilliseconds;
#pragma warning disable 0169
		static Delegate GetGetTrackingMillisecondsHandler ()
		{
			if (cb_getTrackingMilliseconds == null)
				cb_getTrackingMilliseconds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTrackingMilliseconds);
			return cb_getTrackingMilliseconds;
		}

		static int n_GetTrackingMilliseconds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastAbsoluteProgressTracker __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastAbsoluteProgressTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrackingMilliseconds;
		}
#pragma warning restore 0169

		static IntPtr id_getTrackingMilliseconds;
		public virtual unsafe int TrackingMilliseconds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastAbsoluteProgressTracker']/method[@name='getTrackingMilliseconds' and count(parameter)=0]"
			[Register ("getTrackingMilliseconds", "()I", "GetGetTrackingMillisecondsHandler")]
			get {
				if (id_getTrackingMilliseconds == IntPtr.Zero)
					id_getTrackingMilliseconds = JNIEnv.GetMethodID (class_ref, "getTrackingMilliseconds", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTrackingMilliseconds);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrackingMilliseconds", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_compareTo_Lcom_mopub_mobileads_VastAbsoluteProgressTracker_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_mopub_mobileads_VastAbsoluteProgressTracker_Handler ()
		{
			if (cb_compareTo_Lcom_mopub_mobileads_VastAbsoluteProgressTracker_ == null)
				cb_compareTo_Lcom_mopub_mobileads_VastAbsoluteProgressTracker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_mopub_mobileads_VastAbsoluteProgressTracker_);
			return cb_compareTo_Lcom_mopub_mobileads_VastAbsoluteProgressTracker_;
		}

		static int n_CompareTo_Lcom_mopub_mobileads_VastAbsoluteProgressTracker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastAbsoluteProgressTracker __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastAbsoluteProgressTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.VastAbsoluteProgressTracker p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastAbsoluteProgressTracker> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_mopub_mobileads_VastAbsoluteProgressTracker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastAbsoluteProgressTracker']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.VastAbsoluteProgressTracker']]"
		[Register ("compareTo", "(Lcom/mopub/mobileads/VastAbsoluteProgressTracker;)I", "GetCompareTo_Lcom_mopub_mobileads_VastAbsoluteProgressTracker_Handler")]
		public virtual unsafe int CompareTo (global::Com.Mopub.Mobileads.VastAbsoluteProgressTracker p0)
		{
			if (id_compareTo_Lcom_mopub_mobileads_VastAbsoluteProgressTracker_ == IntPtr.Zero)
				id_compareTo_Lcom_mopub_mobileads_VastAbsoluteProgressTracker_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/mopub/mobileads/VastAbsoluteProgressTracker;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lcom_mopub_mobileads_VastAbsoluteProgressTracker_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lcom/mopub/mobileads/VastAbsoluteProgressTracker;)I"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
