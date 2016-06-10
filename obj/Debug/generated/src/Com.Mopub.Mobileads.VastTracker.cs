using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastTracker']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/VastTracker", DoNotGenerateAcw=true)]
	public partial class VastTracker : global::Java.Lang.Object, global::Java.IO.ISerializable {


		static IntPtr mTrackingUrl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastTracker']/field[@name='mTrackingUrl']"
		[Register ("mTrackingUrl")]
		protected string MTrackingUrl {
			get {
				if (mTrackingUrl_jfieldId == IntPtr.Zero)
					mTrackingUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "mTrackingUrl", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mTrackingUrl_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTrackingUrl_jfieldId == IntPtr.Zero)
					mTrackingUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "mTrackingUrl", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, mTrackingUrl_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/VastTracker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VastTracker); }
		}

		protected VastTracker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastTracker']/constructor[@name='VastTracker' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe VastTracker (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (VastTracker)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastTracker']/constructor[@name='VastTracker' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Z)V", "")]
		public unsafe VastTracker (string p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (VastTracker)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Z)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Z == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isRepeatable;
#pragma warning disable 0169
		static Delegate GetIsRepeatableHandler ()
		{
			if (cb_isRepeatable == null)
				cb_isRepeatable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRepeatable);
			return cb_isRepeatable;
		}

		static bool n_IsRepeatable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastTracker __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRepeatable;
		}
#pragma warning restore 0169

		static IntPtr id_isRepeatable;
		public virtual unsafe bool IsRepeatable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastTracker']/method[@name='isRepeatable' and count(parameter)=0]"
			[Register ("isRepeatable", "()Z", "GetIsRepeatableHandler")]
			get {
				if (id_isRepeatable == IntPtr.Zero)
					id_isRepeatable = JNIEnv.GetMethodID (class_ref, "isRepeatable", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isRepeatable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRepeatable", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isTracked;
#pragma warning disable 0169
		static Delegate GetIsTrackedHandler ()
		{
			if (cb_isTracked == null)
				cb_isTracked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTracked);
			return cb_isTracked;
		}

		static bool n_IsTracked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastTracker __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTracked;
		}
#pragma warning restore 0169

		static IntPtr id_isTracked;
		public virtual unsafe bool IsTracked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastTracker']/method[@name='isTracked' and count(parameter)=0]"
			[Register ("isTracked", "()Z", "GetIsTrackedHandler")]
			get {
				if (id_isTracked == IntPtr.Zero)
					id_isTracked = JNIEnv.GetMethodID (class_ref, "isTracked", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isTracked);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTracked", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getTrackingUrl;
#pragma warning disable 0169
		static Delegate GetGetTrackingUrlHandler ()
		{
			if (cb_getTrackingUrl == null)
				cb_getTrackingUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackingUrl);
			return cb_getTrackingUrl;
		}

		static IntPtr n_GetTrackingUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastTracker __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TrackingUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getTrackingUrl;
		public virtual unsafe string TrackingUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastTracker']/method[@name='getTrackingUrl' and count(parameter)=0]"
			[Register ("getTrackingUrl", "()Ljava/lang/String;", "GetGetTrackingUrlHandler")]
			get {
				if (id_getTrackingUrl == IntPtr.Zero)
					id_getTrackingUrl = JNIEnv.GetMethodID (class_ref, "getTrackingUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTrackingUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrackingUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setTracked;
#pragma warning disable 0169
		static Delegate GetSetTrackedHandler ()
		{
			if (cb_setTracked == null)
				cb_setTracked = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetTracked);
			return cb_setTracked;
		}

		static void n_SetTracked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastTracker __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTracked ();
		}
#pragma warning restore 0169

		static IntPtr id_setTracked;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastTracker']/method[@name='setTracked' and count(parameter)=0]"
		[Register ("setTracked", "()V", "GetSetTrackedHandler")]
		public virtual unsafe void SetTracked ()
		{
			if (id_setTracked == IntPtr.Zero)
				id_setTracked = JNIEnv.GetMethodID (class_ref, "setTracked", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTracked);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTracked", "()V"));
			} finally {
			}
		}

	}
}
