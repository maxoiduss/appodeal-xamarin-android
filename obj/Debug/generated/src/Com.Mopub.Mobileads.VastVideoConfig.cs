using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/VastVideoConfig", DoNotGenerateAcw=true)]
	public partial class VastVideoConfig : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/VastVideoConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VastVideoConfig); }
		}

		protected VastVideoConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/constructor[@name='VastVideoConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VastVideoConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VastVideoConfig)) {
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

		static Delegate cb_getAbsoluteTrackers;
#pragma warning disable 0169
		static Delegate GetGetAbsoluteTrackersHandler ()
		{
			if (cb_getAbsoluteTrackers == null)
				cb_getAbsoluteTrackers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAbsoluteTrackers);
			return cb_getAbsoluteTrackers;
		}

		static IntPtr n_GetAbsoluteTrackers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.AbsoluteTrackers);
		}
#pragma warning restore 0169

		static IntPtr id_getAbsoluteTrackers;
		public virtual unsafe global::System.Collections.IList AbsoluteTrackers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='getAbsoluteTrackers' and count(parameter)=0]"
			[Register ("getAbsoluteTrackers", "()Ljava/util/ArrayList;", "GetGetAbsoluteTrackersHandler")]
			get {
				if (id_getAbsoluteTrackers == IntPtr.Zero)
					id_getAbsoluteTrackers = JNIEnv.GetMethodID (class_ref, "getAbsoluteTrackers", "()Ljava/util/ArrayList;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getAbsoluteTrackers), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAbsoluteTrackers", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClickThroughUrl;
#pragma warning disable 0169
		static Delegate GetGetClickThroughUrlHandler ()
		{
			if (cb_getClickThroughUrl == null)
				cb_getClickThroughUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClickThroughUrl);
			return cb_getClickThroughUrl;
		}

		static IntPtr n_GetClickThroughUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClickThroughUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setClickThroughUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClickThroughUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setClickThroughUrl_Ljava_lang_String_ == null)
				cb_setClickThroughUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClickThroughUrl_Ljava_lang_String_);
			return cb_setClickThroughUrl_Ljava_lang_String_;
		}

		static void n_SetClickThroughUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClickThroughUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClickThroughUrl;
		static IntPtr id_setClickThroughUrl_Ljava_lang_String_;
		public virtual unsafe string ClickThroughUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='getClickThroughUrl' and count(parameter)=0]"
			[Register ("getClickThroughUrl", "()Ljava/lang/String;", "GetGetClickThroughUrlHandler")]
			get {
				if (id_getClickThroughUrl == IntPtr.Zero)
					id_getClickThroughUrl = JNIEnv.GetMethodID (class_ref, "getClickThroughUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getClickThroughUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClickThroughUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='setClickThroughUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClickThroughUrl", "(Ljava/lang/String;)V", "GetSetClickThroughUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setClickThroughUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setClickThroughUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setClickThroughUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setClickThroughUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClickThroughUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getClickTrackers;
#pragma warning disable 0169
		static Delegate GetGetClickTrackersHandler ()
		{
			if (cb_getClickTrackers == null)
				cb_getClickTrackers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClickTrackers);
			return cb_getClickTrackers;
		}

		static IntPtr n_GetClickTrackers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.ClickTrackers);
		}
#pragma warning restore 0169

		static IntPtr id_getClickTrackers;
		public virtual unsafe global::System.Collections.IList ClickTrackers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='getClickTrackers' and count(parameter)=0]"
			[Register ("getClickTrackers", "()Ljava/util/List;", "GetGetClickTrackersHandler")]
			get {
				if (id_getClickTrackers == IntPtr.Zero)
					id_getClickTrackers = JNIEnv.GetMethodID (class_ref, "getClickTrackers", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getClickTrackers), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClickTrackers", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCloseTrackers;
#pragma warning disable 0169
		static Delegate GetGetCloseTrackersHandler ()
		{
			if (cb_getCloseTrackers == null)
				cb_getCloseTrackers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCloseTrackers);
			return cb_getCloseTrackers;
		}

		static IntPtr n_GetCloseTrackers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.CloseTrackers);
		}
#pragma warning restore 0169

		static IntPtr id_getCloseTrackers;
		public virtual unsafe global::System.Collections.IList CloseTrackers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='getCloseTrackers' and count(parameter)=0]"
			[Register ("getCloseTrackers", "()Ljava/util/List;", "GetGetCloseTrackersHandler")]
			get {
				if (id_getCloseTrackers == IntPtr.Zero)
					id_getCloseTrackers = JNIEnv.GetMethodID (class_ref, "getCloseTrackers", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getCloseTrackers), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCloseTrackers", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCompleteTrackers;
#pragma warning disable 0169
		static Delegate GetGetCompleteTrackersHandler ()
		{
			if (cb_getCompleteTrackers == null)
				cb_getCompleteTrackers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCompleteTrackers);
			return cb_getCompleteTrackers;
		}

		static IntPtr n_GetCompleteTrackers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.CompleteTrackers);
		}
#pragma warning restore 0169

		static IntPtr id_getCompleteTrackers;
		public virtual unsafe global::System.Collections.IList CompleteTrackers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='getCompleteTrackers' and count(parameter)=0]"
			[Register ("getCompleteTrackers", "()Ljava/util/List;", "GetGetCompleteTrackersHandler")]
			get {
				if (id_getCompleteTrackers == IntPtr.Zero)
					id_getCompleteTrackers = JNIEnv.GetMethodID (class_ref, "getCompleteTrackers", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getCompleteTrackers), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCompleteTrackers", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCustomCloseIconUrl;
#pragma warning disable 0169
		static Delegate GetGetCustomCloseIconUrlHandler ()
		{
			if (cb_getCustomCloseIconUrl == null)
				cb_getCustomCloseIconUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomCloseIconUrl);
			return cb_getCustomCloseIconUrl;
		}

		static IntPtr n_GetCustomCloseIconUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CustomCloseIconUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setCustomCloseIconUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCustomCloseIconUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setCustomCloseIconUrl_Ljava_lang_String_ == null)
				cb_setCustomCloseIconUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomCloseIconUrl_Ljava_lang_String_);
			return cb_setCustomCloseIconUrl_Ljava_lang_String_;
		}

		static void n_SetCustomCloseIconUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CustomCloseIconUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCustomCloseIconUrl;
		static IntPtr id_setCustomCloseIconUrl_Ljava_lang_String_;
		public virtual unsafe string CustomCloseIconUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='getCustomCloseIconUrl' and count(parameter)=0]"
			[Register ("getCustomCloseIconUrl", "()Ljava/lang/String;", "GetGetCustomCloseIconUrlHandler")]
			get {
				if (id_getCustomCloseIconUrl == IntPtr.Zero)
					id_getCustomCloseIconUrl = JNIEnv.GetMethodID (class_ref, "getCustomCloseIconUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCustomCloseIconUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCustomCloseIconUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='setCustomCloseIconUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCustomCloseIconUrl", "(Ljava/lang/String;)V", "GetSetCustomCloseIconUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setCustomCloseIconUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setCustomCloseIconUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCustomCloseIconUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCustomCloseIconUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomCloseIconUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCustomCtaText;
#pragma warning disable 0169
		static Delegate GetGetCustomCtaTextHandler ()
		{
			if (cb_getCustomCtaText == null)
				cb_getCustomCtaText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomCtaText);
			return cb_getCustomCtaText;
		}

		static IntPtr n_GetCustomCtaText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CustomCtaText);
		}
#pragma warning restore 0169

		static Delegate cb_setCustomCtaText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCustomCtaText_Ljava_lang_String_Handler ()
		{
			if (cb_setCustomCtaText_Ljava_lang_String_ == null)
				cb_setCustomCtaText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomCtaText_Ljava_lang_String_);
			return cb_setCustomCtaText_Ljava_lang_String_;
		}

		static void n_SetCustomCtaText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CustomCtaText = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCustomCtaText;
		static IntPtr id_setCustomCtaText_Ljava_lang_String_;
		public virtual unsafe string CustomCtaText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='getCustomCtaText' and count(parameter)=0]"
			[Register ("getCustomCtaText", "()Ljava/lang/String;", "GetGetCustomCtaTextHandler")]
			get {
				if (id_getCustomCtaText == IntPtr.Zero)
					id_getCustomCtaText = JNIEnv.GetMethodID (class_ref, "getCustomCtaText", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCustomCtaText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCustomCtaText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='setCustomCtaText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCustomCtaText", "(Ljava/lang/String;)V", "GetSetCustomCtaText_Ljava_lang_String_Handler")]
			set {
				if (id_setCustomCtaText_Ljava_lang_String_ == IntPtr.Zero)
					id_setCustomCtaText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCustomCtaText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCustomCtaText_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomCtaText", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCustomForceOrientation;
#pragma warning disable 0169
		static Delegate GetGetCustomForceOrientationHandler ()
		{
			if (cb_getCustomForceOrientation == null)
				cb_getCustomForceOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomForceOrientation);
			return cb_getCustomForceOrientation;
		}

		static IntPtr n_GetCustomForceOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CustomForceOrientation);
		}
#pragma warning restore 0169

		static Delegate cb_setCustomForceOrientation_Lcom_mopub_common_util_DeviceUtils_ForceOrientation_;
#pragma warning disable 0169
		static Delegate GetSetCustomForceOrientation_Lcom_mopub_common_util_DeviceUtils_ForceOrientation_Handler ()
		{
			if (cb_setCustomForceOrientation_Lcom_mopub_common_util_DeviceUtils_ForceOrientation_ == null)
				cb_setCustomForceOrientation_Lcom_mopub_common_util_DeviceUtils_ForceOrientation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomForceOrientation_Lcom_mopub_common_util_DeviceUtils_ForceOrientation_);
			return cb_setCustomForceOrientation_Lcom_mopub_common_util_DeviceUtils_ForceOrientation_;
		}

		static void n_SetCustomForceOrientation_Lcom_mopub_common_util_DeviceUtils_ForceOrientation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Common.Util.DeviceUtils.ForceOrientation p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.DeviceUtils.ForceOrientation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CustomForceOrientation = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCustomForceOrientation;
		static IntPtr id_setCustomForceOrientation_Lcom_mopub_common_util_DeviceUtils_ForceOrientation_;
		public virtual unsafe global::Com.Mopub.Common.Util.DeviceUtils.ForceOrientation CustomForceOrientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='getCustomForceOrientation' and count(parameter)=0]"
			[Register ("getCustomForceOrientation", "()Lcom/mopub/common/util/DeviceUtils$ForceOrientation;", "GetGetCustomForceOrientationHandler")]
			get {
				if (id_getCustomForceOrientation == IntPtr.Zero)
					id_getCustomForceOrientation = JNIEnv.GetMethodID (class_ref, "getCustomForceOrientation", "()Lcom/mopub/common/util/DeviceUtils$ForceOrientation;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.DeviceUtils.ForceOrientation> (JNIEnv.CallObjectMethod  (Handle, id_getCustomForceOrientation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.DeviceUtils.ForceOrientation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCustomForceOrientation", "()Lcom/mopub/common/util/DeviceUtils$ForceOrientation;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='setCustomForceOrientation' and count(parameter)=1 and parameter[1][@type='com.mopub.common.util.DeviceUtils.ForceOrientation']]"
			[Register ("setCustomForceOrientation", "(Lcom/mopub/common/util/DeviceUtils$ForceOrientation;)V", "GetSetCustomForceOrientation_Lcom_mopub_common_util_DeviceUtils_ForceOrientation_Handler")]
			set {
				if (id_setCustomForceOrientation_Lcom_mopub_common_util_DeviceUtils_ForceOrientation_ == IntPtr.Zero)
					id_setCustomForceOrientation_Lcom_mopub_common_util_DeviceUtils_ForceOrientation_ = JNIEnv.GetMethodID (class_ref, "setCustomForceOrientation", "(Lcom/mopub/common/util/DeviceUtils$ForceOrientation;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCustomForceOrientation_Lcom_mopub_common_util_DeviceUtils_ForceOrientation_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomForceOrientation", "(Lcom/mopub/common/util/DeviceUtils$ForceOrientation;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCustomSkipText;
#pragma warning disable 0169
		static Delegate GetGetCustomSkipTextHandler ()
		{
			if (cb_getCustomSkipText == null)
				cb_getCustomSkipText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomSkipText);
			return cb_getCustomSkipText;
		}

		static IntPtr n_GetCustomSkipText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CustomSkipText);
		}
#pragma warning restore 0169

		static Delegate cb_setCustomSkipText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCustomSkipText_Ljava_lang_String_Handler ()
		{
			if (cb_setCustomSkipText_Ljava_lang_String_ == null)
				cb_setCustomSkipText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomSkipText_Ljava_lang_String_);
			return cb_setCustomSkipText_Ljava_lang_String_;
		}

		static void n_SetCustomSkipText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CustomSkipText = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCustomSkipText;
		static IntPtr id_setCustomSkipText_Ljava_lang_String_;
		public virtual unsafe string CustomSkipText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='getCustomSkipText' and count(parameter)=0]"
			[Register ("getCustomSkipText", "()Ljava/lang/String;", "GetGetCustomSkipTextHandler")]
			get {
				if (id_getCustomSkipText == IntPtr.Zero)
					id_getCustomSkipText = JNIEnv.GetMethodID (class_ref, "getCustomSkipText", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCustomSkipText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCustomSkipText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='setCustomSkipText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCustomSkipText", "(Ljava/lang/String;)V", "GetSetCustomSkipText_Ljava_lang_String_Handler")]
			set {
				if (id_setCustomSkipText_Ljava_lang_String_ == IntPtr.Zero)
					id_setCustomSkipText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCustomSkipText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCustomSkipText_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomSkipText", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDiskMediaFileUrl;
#pragma warning disable 0169
		static Delegate GetGetDiskMediaFileUrlHandler ()
		{
			if (cb_getDiskMediaFileUrl == null)
				cb_getDiskMediaFileUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDiskMediaFileUrl);
			return cb_getDiskMediaFileUrl;
		}

		static IntPtr n_GetDiskMediaFileUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DiskMediaFileUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setDiskMediaFileUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDiskMediaFileUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setDiskMediaFileUrl_Ljava_lang_String_ == null)
				cb_setDiskMediaFileUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDiskMediaFileUrl_Ljava_lang_String_);
			return cb_setDiskMediaFileUrl_Ljava_lang_String_;
		}

		static void n_SetDiskMediaFileUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DiskMediaFileUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDiskMediaFileUrl;
		static IntPtr id_setDiskMediaFileUrl_Ljava_lang_String_;
		public virtual unsafe string DiskMediaFileUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='getDiskMediaFileUrl' and count(parameter)=0]"
			[Register ("getDiskMediaFileUrl", "()Ljava/lang/String;", "GetGetDiskMediaFileUrlHandler")]
			get {
				if (id_getDiskMediaFileUrl == IntPtr.Zero)
					id_getDiskMediaFileUrl = JNIEnv.GetMethodID (class_ref, "getDiskMediaFileUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDiskMediaFileUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDiskMediaFileUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='setDiskMediaFileUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDiskMediaFileUrl", "(Ljava/lang/String;)V", "GetSetDiskMediaFileUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setDiskMediaFileUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setDiskMediaFileUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDiskMediaFileUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDiskMediaFileUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDiskMediaFileUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getErrorTrackers;
#pragma warning disable 0169
		static Delegate GetGetErrorTrackersHandler ()
		{
			if (cb_getErrorTrackers == null)
				cb_getErrorTrackers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorTrackers);
			return cb_getErrorTrackers;
		}

		static IntPtr n_GetErrorTrackers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.ErrorTrackers);
		}
#pragma warning restore 0169

		static IntPtr id_getErrorTrackers;
		public virtual unsafe global::System.Collections.IList ErrorTrackers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='getErrorTrackers' and count(parameter)=0]"
			[Register ("getErrorTrackers", "()Ljava/util/List;", "GetGetErrorTrackersHandler")]
			get {
				if (id_getErrorTrackers == IntPtr.Zero)
					id_getErrorTrackers = JNIEnv.GetMethodID (class_ref, "getErrorTrackers", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getErrorTrackers), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorTrackers", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFractionalTrackers;
#pragma warning disable 0169
		static Delegate GetGetFractionalTrackersHandler ()
		{
			if (cb_getFractionalTrackers == null)
				cb_getFractionalTrackers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFractionalTrackers);
			return cb_getFractionalTrackers;
		}

		static IntPtr n_GetFractionalTrackers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.FractionalTrackers);
		}
#pragma warning restore 0169

		static IntPtr id_getFractionalTrackers;
		public virtual unsafe global::System.Collections.IList FractionalTrackers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='getFractionalTrackers' and count(parameter)=0]"
			[Register ("getFractionalTrackers", "()Ljava/util/ArrayList;", "GetGetFractionalTrackersHandler")]
			get {
				if (id_getFractionalTrackers == IntPtr.Zero)
					id_getFractionalTrackers = JNIEnv.GetMethodID (class_ref, "getFractionalTrackers", "()Ljava/util/ArrayList;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getFractionalTrackers), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFractionalTrackers", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasCompanionAd;
#pragma warning disable 0169
		static Delegate GetHasCompanionAdHandler ()
		{
			if (cb_hasCompanionAd == null)
				cb_hasCompanionAd = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasCompanionAd);
			return cb_hasCompanionAd;
		}

		static bool n_HasCompanionAd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasCompanionAd;
		}
#pragma warning restore 0169

		static IntPtr id_hasCompanionAd;
		public virtual unsafe bool HasCompanionAd {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='hasCompanionAd' and count(parameter)=0]"
			[Register ("hasCompanionAd", "()Z", "GetHasCompanionAdHandler")]
			get {
				if (id_hasCompanionAd == IntPtr.Zero)
					id_hasCompanionAd = JNIEnv.GetMethodID (class_ref, "hasCompanionAd", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_hasCompanionAd);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasCompanionAd", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getImpressionTrackers;
#pragma warning disable 0169
		static Delegate GetGetImpressionTrackersHandler ()
		{
			if (cb_getImpressionTrackers == null)
				cb_getImpressionTrackers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImpressionTrackers);
			return cb_getImpressionTrackers;
		}

		static IntPtr n_GetImpressionTrackers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.ImpressionTrackers);
		}
#pragma warning restore 0169

		static IntPtr id_getImpressionTrackers;
		public virtual unsafe global::System.Collections.IList ImpressionTrackers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='getImpressionTrackers' and count(parameter)=0]"
			[Register ("getImpressionTrackers", "()Ljava/util/List;", "GetGetImpressionTrackersHandler")]
			get {
				if (id_getImpressionTrackers == IntPtr.Zero)
					id_getImpressionTrackers = JNIEnv.GetMethodID (class_ref, "getImpressionTrackers", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getImpressionTrackers), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImpressionTrackers", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isCustomForceOrientationSet;
#pragma warning disable 0169
		static Delegate GetIsCustomForceOrientationSetHandler ()
		{
			if (cb_isCustomForceOrientationSet == null)
				cb_isCustomForceOrientationSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCustomForceOrientationSet);
			return cb_isCustomForceOrientationSet;
		}

		static bool n_IsCustomForceOrientationSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCustomForceOrientationSet;
		}
#pragma warning restore 0169

		static IntPtr id_isCustomForceOrientationSet;
		public virtual unsafe bool IsCustomForceOrientationSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='isCustomForceOrientationSet' and count(parameter)=0]"
			[Register ("isCustomForceOrientationSet", "()Z", "GetIsCustomForceOrientationSetHandler")]
			get {
				if (id_isCustomForceOrientationSet == IntPtr.Zero)
					id_isCustomForceOrientationSet = JNIEnv.GetMethodID (class_ref, "isCustomForceOrientationSet", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isCustomForceOrientationSet);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCustomForceOrientationSet", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getNetworkMediaFileUrl;
#pragma warning disable 0169
		static Delegate GetGetNetworkMediaFileUrlHandler ()
		{
			if (cb_getNetworkMediaFileUrl == null)
				cb_getNetworkMediaFileUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetworkMediaFileUrl);
			return cb_getNetworkMediaFileUrl;
		}

		static IntPtr n_GetNetworkMediaFileUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NetworkMediaFileUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setNetworkMediaFileUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNetworkMediaFileUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setNetworkMediaFileUrl_Ljava_lang_String_ == null)
				cb_setNetworkMediaFileUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNetworkMediaFileUrl_Ljava_lang_String_);
			return cb_setNetworkMediaFileUrl_Ljava_lang_String_;
		}

		static void n_SetNetworkMediaFileUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NetworkMediaFileUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkMediaFileUrl;
		static IntPtr id_setNetworkMediaFileUrl_Ljava_lang_String_;
		public virtual unsafe string NetworkMediaFileUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='getNetworkMediaFileUrl' and count(parameter)=0]"
			[Register ("getNetworkMediaFileUrl", "()Ljava/lang/String;", "GetGetNetworkMediaFileUrlHandler")]
			get {
				if (id_getNetworkMediaFileUrl == IntPtr.Zero)
					id_getNetworkMediaFileUrl = JNIEnv.GetMethodID (class_ref, "getNetworkMediaFileUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNetworkMediaFileUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetworkMediaFileUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='setNetworkMediaFileUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNetworkMediaFileUrl", "(Ljava/lang/String;)V", "GetSetNetworkMediaFileUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setNetworkMediaFileUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setNetworkMediaFileUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNetworkMediaFileUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setNetworkMediaFileUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNetworkMediaFileUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPauseTrackers;
#pragma warning disable 0169
		static Delegate GetGetPauseTrackersHandler ()
		{
			if (cb_getPauseTrackers == null)
				cb_getPauseTrackers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPauseTrackers);
			return cb_getPauseTrackers;
		}

		static IntPtr n_GetPauseTrackers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.PauseTrackers);
		}
#pragma warning restore 0169

		static IntPtr id_getPauseTrackers;
		public virtual unsafe global::System.Collections.IList PauseTrackers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='getPauseTrackers' and count(parameter)=0]"
			[Register ("getPauseTrackers", "()Ljava/util/List;", "GetGetPauseTrackersHandler")]
			get {
				if (id_getPauseTrackers == IntPtr.Zero)
					id_getPauseTrackers = JNIEnv.GetMethodID (class_ref, "getPauseTrackers", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPauseTrackers), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPauseTrackers", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRemainingProgressTrackerCount;
#pragma warning disable 0169
		static Delegate GetGetRemainingProgressTrackerCountHandler ()
		{
			if (cb_getRemainingProgressTrackerCount == null)
				cb_getRemainingProgressTrackerCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRemainingProgressTrackerCount);
			return cb_getRemainingProgressTrackerCount;
		}

		static int n_GetRemainingProgressTrackerCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemainingProgressTrackerCount;
		}
#pragma warning restore 0169

		static IntPtr id_getRemainingProgressTrackerCount;
		public virtual unsafe int RemainingProgressTrackerCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='getRemainingProgressTrackerCount' and count(parameter)=0]"
			[Register ("getRemainingProgressTrackerCount", "()I", "GetGetRemainingProgressTrackerCountHandler")]
			get {
				if (id_getRemainingProgressTrackerCount == IntPtr.Zero)
					id_getRemainingProgressTrackerCount = JNIEnv.GetMethodID (class_ref, "getRemainingProgressTrackerCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getRemainingProgressTrackerCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRemainingProgressTrackerCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getResumeTrackers;
#pragma warning disable 0169
		static Delegate GetGetResumeTrackersHandler ()
		{
			if (cb_getResumeTrackers == null)
				cb_getResumeTrackers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResumeTrackers);
			return cb_getResumeTrackers;
		}

		static IntPtr n_GetResumeTrackers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.ResumeTrackers);
		}
#pragma warning restore 0169

		static IntPtr id_getResumeTrackers;
		public virtual unsafe global::System.Collections.IList ResumeTrackers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='getResumeTrackers' and count(parameter)=0]"
			[Register ("getResumeTrackers", "()Ljava/util/List;", "GetGetResumeTrackersHandler")]
			get {
				if (id_getResumeTrackers == IntPtr.Zero)
					id_getResumeTrackers = JNIEnv.GetMethodID (class_ref, "getResumeTrackers", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getResumeTrackers), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResumeTrackers", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSkipOffsetString;
#pragma warning disable 0169
		static Delegate GetGetSkipOffsetStringHandler ()
		{
			if (cb_getSkipOffsetString == null)
				cb_getSkipOffsetString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSkipOffsetString);
			return cb_getSkipOffsetString;
		}

		static IntPtr n_GetSkipOffsetString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SkipOffsetString);
		}
#pragma warning restore 0169

		static IntPtr id_getSkipOffsetString;
		public virtual unsafe string SkipOffsetString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='getSkipOffsetString' and count(parameter)=0]"
			[Register ("getSkipOffsetString", "()Ljava/lang/String;", "GetGetSkipOffsetStringHandler")]
			get {
				if (id_getSkipOffsetString == IntPtr.Zero)
					id_getSkipOffsetString = JNIEnv.GetMethodID (class_ref, "getSkipOffsetString", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSkipOffsetString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSkipOffsetString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSkipTrackers;
#pragma warning disable 0169
		static Delegate GetGetSkipTrackersHandler ()
		{
			if (cb_getSkipTrackers == null)
				cb_getSkipTrackers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSkipTrackers);
			return cb_getSkipTrackers;
		}

		static IntPtr n_GetSkipTrackers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.SkipTrackers);
		}
#pragma warning restore 0169

		static IntPtr id_getSkipTrackers;
		public virtual unsafe global::System.Collections.IList SkipTrackers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='getSkipTrackers' and count(parameter)=0]"
			[Register ("getSkipTrackers", "()Ljava/util/List;", "GetGetSkipTrackersHandler")]
			get {
				if (id_getSkipTrackers == IntPtr.Zero)
					id_getSkipTrackers = JNIEnv.GetMethodID (class_ref, "getSkipTrackers", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getSkipTrackers), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSkipTrackers", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addAbsoluteTrackers_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddAbsoluteTrackers_Ljava_util_List_Handler ()
		{
			if (cb_addAbsoluteTrackers_Ljava_util_List_ == null)
				cb_addAbsoluteTrackers_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddAbsoluteTrackers_Ljava_util_List_);
			return cb_addAbsoluteTrackers_Ljava_util_List_;
		}

		static void n_AddAbsoluteTrackers_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddAbsoluteTrackers (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addAbsoluteTrackers_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='addAbsoluteTrackers' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("addAbsoluteTrackers", "(Ljava/util/List;)V", "GetAddAbsoluteTrackers_Ljava_util_List_Handler")]
		public virtual unsafe void AddAbsoluteTrackers (global::System.Collections.IList p0)
		{
			if (id_addAbsoluteTrackers_Ljava_util_List_ == IntPtr.Zero)
				id_addAbsoluteTrackers_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addAbsoluteTrackers", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addAbsoluteTrackers_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAbsoluteTrackers", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addClickTrackers_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddClickTrackers_Ljava_util_List_Handler ()
		{
			if (cb_addClickTrackers_Ljava_util_List_ == null)
				cb_addClickTrackers_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddClickTrackers_Ljava_util_List_);
			return cb_addClickTrackers_Ljava_util_List_;
		}

		static void n_AddClickTrackers_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddClickTrackers (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addClickTrackers_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='addClickTrackers' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("addClickTrackers", "(Ljava/util/List;)V", "GetAddClickTrackers_Ljava_util_List_Handler")]
		public virtual unsafe void AddClickTrackers (global::System.Collections.IList p0)
		{
			if (id_addClickTrackers_Ljava_util_List_ == IntPtr.Zero)
				id_addClickTrackers_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addClickTrackers", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addClickTrackers_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addClickTrackers", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addCloseTrackers_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddCloseTrackers_Ljava_util_List_Handler ()
		{
			if (cb_addCloseTrackers_Ljava_util_List_ == null)
				cb_addCloseTrackers_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddCloseTrackers_Ljava_util_List_);
			return cb_addCloseTrackers_Ljava_util_List_;
		}

		static void n_AddCloseTrackers_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddCloseTrackers (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addCloseTrackers_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='addCloseTrackers' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("addCloseTrackers", "(Ljava/util/List;)V", "GetAddCloseTrackers_Ljava_util_List_Handler")]
		public virtual unsafe void AddCloseTrackers (global::System.Collections.IList p0)
		{
			if (id_addCloseTrackers_Ljava_util_List_ == IntPtr.Zero)
				id_addCloseTrackers_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addCloseTrackers", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addCloseTrackers_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addCloseTrackers", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addCompleteTrackers_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddCompleteTrackers_Ljava_util_List_Handler ()
		{
			if (cb_addCompleteTrackers_Ljava_util_List_ == null)
				cb_addCompleteTrackers_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddCompleteTrackers_Ljava_util_List_);
			return cb_addCompleteTrackers_Ljava_util_List_;
		}

		static void n_AddCompleteTrackers_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddCompleteTrackers (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addCompleteTrackers_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='addCompleteTrackers' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("addCompleteTrackers", "(Ljava/util/List;)V", "GetAddCompleteTrackers_Ljava_util_List_Handler")]
		public virtual unsafe void AddCompleteTrackers (global::System.Collections.IList p0)
		{
			if (id_addCompleteTrackers_Ljava_util_List_ == IntPtr.Zero)
				id_addCompleteTrackers_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addCompleteTrackers", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addCompleteTrackers_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addCompleteTrackers", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addErrorTrackers_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddErrorTrackers_Ljava_util_List_Handler ()
		{
			if (cb_addErrorTrackers_Ljava_util_List_ == null)
				cb_addErrorTrackers_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddErrorTrackers_Ljava_util_List_);
			return cb_addErrorTrackers_Ljava_util_List_;
		}

		static void n_AddErrorTrackers_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddErrorTrackers (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addErrorTrackers_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='addErrorTrackers' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("addErrorTrackers", "(Ljava/util/List;)V", "GetAddErrorTrackers_Ljava_util_List_Handler")]
		public virtual unsafe void AddErrorTrackers (global::System.Collections.IList p0)
		{
			if (id_addErrorTrackers_Ljava_util_List_ == IntPtr.Zero)
				id_addErrorTrackers_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addErrorTrackers", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addErrorTrackers_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addErrorTrackers", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addFractionalTrackers_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddFractionalTrackers_Ljava_util_List_Handler ()
		{
			if (cb_addFractionalTrackers_Ljava_util_List_ == null)
				cb_addFractionalTrackers_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddFractionalTrackers_Ljava_util_List_);
			return cb_addFractionalTrackers_Ljava_util_List_;
		}

		static void n_AddFractionalTrackers_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddFractionalTrackers (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addFractionalTrackers_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='addFractionalTrackers' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("addFractionalTrackers", "(Ljava/util/List;)V", "GetAddFractionalTrackers_Ljava_util_List_Handler")]
		public virtual unsafe void AddFractionalTrackers (global::System.Collections.IList p0)
		{
			if (id_addFractionalTrackers_Ljava_util_List_ == IntPtr.Zero)
				id_addFractionalTrackers_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addFractionalTrackers", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addFractionalTrackers_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFractionalTrackers", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addImpressionTrackers_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddImpressionTrackers_Ljava_util_List_Handler ()
		{
			if (cb_addImpressionTrackers_Ljava_util_List_ == null)
				cb_addImpressionTrackers_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddImpressionTrackers_Ljava_util_List_);
			return cb_addImpressionTrackers_Ljava_util_List_;
		}

		static void n_AddImpressionTrackers_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddImpressionTrackers (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addImpressionTrackers_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='addImpressionTrackers' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("addImpressionTrackers", "(Ljava/util/List;)V", "GetAddImpressionTrackers_Ljava_util_List_Handler")]
		public virtual unsafe void AddImpressionTrackers (global::System.Collections.IList p0)
		{
			if (id_addImpressionTrackers_Ljava_util_List_ == IntPtr.Zero)
				id_addImpressionTrackers_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addImpressionTrackers", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addImpressionTrackers_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addImpressionTrackers", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addPauseTrackers_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddPauseTrackers_Ljava_util_List_Handler ()
		{
			if (cb_addPauseTrackers_Ljava_util_List_ == null)
				cb_addPauseTrackers_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddPauseTrackers_Ljava_util_List_);
			return cb_addPauseTrackers_Ljava_util_List_;
		}

		static void n_AddPauseTrackers_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddPauseTrackers (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addPauseTrackers_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='addPauseTrackers' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("addPauseTrackers", "(Ljava/util/List;)V", "GetAddPauseTrackers_Ljava_util_List_Handler")]
		public virtual unsafe void AddPauseTrackers (global::System.Collections.IList p0)
		{
			if (id_addPauseTrackers_Ljava_util_List_ == IntPtr.Zero)
				id_addPauseTrackers_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addPauseTrackers", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addPauseTrackers_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addPauseTrackers", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addResumeTrackers_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddResumeTrackers_Ljava_util_List_Handler ()
		{
			if (cb_addResumeTrackers_Ljava_util_List_ == null)
				cb_addResumeTrackers_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddResumeTrackers_Ljava_util_List_);
			return cb_addResumeTrackers_Ljava_util_List_;
		}

		static void n_AddResumeTrackers_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddResumeTrackers (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addResumeTrackers_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='addResumeTrackers' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("addResumeTrackers", "(Ljava/util/List;)V", "GetAddResumeTrackers_Ljava_util_List_Handler")]
		public virtual unsafe void AddResumeTrackers (global::System.Collections.IList p0)
		{
			if (id_addResumeTrackers_Ljava_util_List_ == IntPtr.Zero)
				id_addResumeTrackers_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addResumeTrackers", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addResumeTrackers_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addResumeTrackers", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addSkipTrackers_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddSkipTrackers_Ljava_util_List_Handler ()
		{
			if (cb_addSkipTrackers_Ljava_util_List_ == null)
				cb_addSkipTrackers_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddSkipTrackers_Ljava_util_List_);
			return cb_addSkipTrackers_Ljava_util_List_;
		}

		static void n_AddSkipTrackers_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddSkipTrackers (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addSkipTrackers_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='addSkipTrackers' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("addSkipTrackers", "(Ljava/util/List;)V", "GetAddSkipTrackers_Ljava_util_List_Handler")]
		public virtual unsafe void AddSkipTrackers (global::System.Collections.IList p0)
		{
			if (id_addSkipTrackers_Ljava_util_List_ == IntPtr.Zero)
				id_addSkipTrackers_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addSkipTrackers", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addSkipTrackers_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addSkipTrackers", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getSkipOffsetMillis_I;
#pragma warning disable 0169
		static Delegate GetGetSkipOffsetMillis_IHandler ()
		{
			if (cb_getSkipOffsetMillis_I == null)
				cb_getSkipOffsetMillis_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetSkipOffsetMillis_I);
			return cb_getSkipOffsetMillis_I;
		}

		static IntPtr n_GetSkipOffsetMillis_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetSkipOffsetMillis (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getSkipOffsetMillis_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='getSkipOffsetMillis' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSkipOffsetMillis", "(I)Ljava/lang/Integer;", "GetGetSkipOffsetMillis_IHandler")]
		public virtual unsafe global::Java.Lang.Integer GetSkipOffsetMillis (int p0)
		{
			if (id_getSkipOffsetMillis_I == IntPtr.Zero)
				id_getSkipOffsetMillis_I = JNIEnv.GetMethodID (class_ref, "getSkipOffsetMillis", "(I)Ljava/lang/Integer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getSkipOffsetMillis_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSkipOffsetMillis", "(I)Ljava/lang/Integer;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getUntriggeredTrackersBefore_II;
#pragma warning disable 0169
		static Delegate GetGetUntriggeredTrackersBefore_IIHandler ()
		{
			if (cb_getUntriggeredTrackersBefore_II == null)
				cb_getUntriggeredTrackersBefore_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_GetUntriggeredTrackersBefore_II);
			return cb_getUntriggeredTrackersBefore_II;
		}

		static IntPtr n_GetUntriggeredTrackersBefore_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.GetUntriggeredTrackersBefore (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_getUntriggeredTrackersBefore_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='getUntriggeredTrackersBefore' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getUntriggeredTrackersBefore", "(II)Ljava/util/List;", "GetGetUntriggeredTrackersBefore_IIHandler")]
		public virtual unsafe global::System.Collections.IList GetUntriggeredTrackersBefore (int p0, int p1)
		{
			if (id_getUntriggeredTrackersBefore_II == IntPtr.Zero)
				id_getUntriggeredTrackersBefore_II = JNIEnv.GetMethodID (class_ref, "getUntriggeredTrackersBefore", "(II)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getUntriggeredTrackersBefore_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUntriggeredTrackersBefore", "(II)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getVastCompanionAd_I;
#pragma warning disable 0169
		static Delegate GetGetVastCompanionAd_IHandler ()
		{
			if (cb_getVastCompanionAd_I == null)
				cb_getVastCompanionAd_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetVastCompanionAd_I);
			return cb_getVastCompanionAd_I;
		}

		static IntPtr n_GetVastCompanionAd_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetVastCompanionAd (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getVastCompanionAd_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='getVastCompanionAd' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getVastCompanionAd", "(I)Lcom/mopub/mobileads/VastCompanionAdConfig;", "GetGetVastCompanionAd_IHandler")]
		public virtual unsafe global::Com.Mopub.Mobileads.VastCompanionAdConfig GetVastCompanionAd (int p0)
		{
			if (id_getVastCompanionAd_I == IntPtr.Zero)
				id_getVastCompanionAd_I = JNIEnv.GetMethodID (class_ref, "getVastCompanionAd", "(I)Lcom/mopub/mobileads/VastCompanionAdConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastCompanionAdConfig> (JNIEnv.CallObjectMethod  (Handle, id_getVastCompanionAd_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastCompanionAdConfig> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVastCompanionAd", "(I)Lcom/mopub/mobileads/VastCompanionAdConfig;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_handleClick_Landroid_app_Activity_II;
#pragma warning disable 0169
		static Delegate GetHandleClick_Landroid_app_Activity_IIHandler ()
		{
			if (cb_handleClick_Landroid_app_Activity_II == null)
				cb_handleClick_Landroid_app_Activity_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_HandleClick_Landroid_app_Activity_II);
			return cb_handleClick_Landroid_app_Activity_II;
		}

		static void n_HandleClick_Landroid_app_Activity_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleClick (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_handleClick_Landroid_app_Activity_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='handleClick' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("handleClick", "(Landroid/app/Activity;II)V", "GetHandleClick_Landroid_app_Activity_IIHandler")]
		public virtual unsafe void HandleClick (global::Android.App.Activity p0, int p1, int p2)
		{
			if (id_handleClick_Landroid_app_Activity_II == IntPtr.Zero)
				id_handleClick_Landroid_app_Activity_II = JNIEnv.GetMethodID (class_ref, "handleClick", "(Landroid/app/Activity;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_handleClick_Landroid_app_Activity_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleClick", "(Landroid/app/Activity;II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_handleClose_Landroid_content_Context_I;
#pragma warning disable 0169
		static Delegate GetHandleClose_Landroid_content_Context_IHandler ()
		{
			if (cb_handleClose_Landroid_content_Context_I == null)
				cb_handleClose_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_HandleClose_Landroid_content_Context_I);
			return cb_handleClose_Landroid_content_Context_I;
		}

		static void n_HandleClose_Landroid_content_Context_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleClose (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_handleClose_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='handleClose' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("handleClose", "(Landroid/content/Context;I)V", "GetHandleClose_Landroid_content_Context_IHandler")]
		public virtual unsafe void HandleClose (global::Android.Content.Context p0, int p1)
		{
			if (id_handleClose_Landroid_content_Context_I == IntPtr.Zero)
				id_handleClose_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "handleClose", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_handleClose_Landroid_content_Context_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleClose", "(Landroid/content/Context;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_handleComplete_Landroid_content_Context_I;
#pragma warning disable 0169
		static Delegate GetHandleComplete_Landroid_content_Context_IHandler ()
		{
			if (cb_handleComplete_Landroid_content_Context_I == null)
				cb_handleComplete_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_HandleComplete_Landroid_content_Context_I);
			return cb_handleComplete_Landroid_content_Context_I;
		}

		static void n_HandleComplete_Landroid_content_Context_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleComplete (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_handleComplete_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='handleComplete' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("handleComplete", "(Landroid/content/Context;I)V", "GetHandleComplete_Landroid_content_Context_IHandler")]
		public virtual unsafe void HandleComplete (global::Android.Content.Context p0, int p1)
		{
			if (id_handleComplete_Landroid_content_Context_I == IntPtr.Zero)
				id_handleComplete_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "handleComplete", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_handleComplete_Landroid_content_Context_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleComplete", "(Landroid/content/Context;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_handleError_Landroid_content_Context_Lcom_mopub_mobileads_VastErrorCode_I;
#pragma warning disable 0169
		static Delegate GetHandleError_Landroid_content_Context_Lcom_mopub_mobileads_VastErrorCode_IHandler ()
		{
			if (cb_handleError_Landroid_content_Context_Lcom_mopub_mobileads_VastErrorCode_I == null)
				cb_handleError_Landroid_content_Context_Lcom_mopub_mobileads_VastErrorCode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_HandleError_Landroid_content_Context_Lcom_mopub_mobileads_VastErrorCode_I);
			return cb_handleError_Landroid_content_Context_Lcom_mopub_mobileads_VastErrorCode_I;
		}

		static void n_HandleError_Landroid_content_Context_Lcom_mopub_mobileads_VastErrorCode_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.VastErrorCode p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastErrorCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.HandleError (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_handleError_Landroid_content_Context_Lcom_mopub_mobileads_VastErrorCode_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='handleError' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.mobileads.VastErrorCode'] and parameter[3][@type='int']]"
		[Register ("handleError", "(Landroid/content/Context;Lcom/mopub/mobileads/VastErrorCode;I)V", "GetHandleError_Landroid_content_Context_Lcom_mopub_mobileads_VastErrorCode_IHandler")]
		public virtual unsafe void HandleError (global::Android.Content.Context p0, global::Com.Mopub.Mobileads.VastErrorCode p1, int p2)
		{
			if (id_handleError_Landroid_content_Context_Lcom_mopub_mobileads_VastErrorCode_I == IntPtr.Zero)
				id_handleError_Landroid_content_Context_Lcom_mopub_mobileads_VastErrorCode_I = JNIEnv.GetMethodID (class_ref, "handleError", "(Landroid/content/Context;Lcom/mopub/mobileads/VastErrorCode;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_handleError_Landroid_content_Context_Lcom_mopub_mobileads_VastErrorCode_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleError", "(Landroid/content/Context;Lcom/mopub/mobileads/VastErrorCode;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_handleImpression_Landroid_content_Context_I;
#pragma warning disable 0169
		static Delegate GetHandleImpression_Landroid_content_Context_IHandler ()
		{
			if (cb_handleImpression_Landroid_content_Context_I == null)
				cb_handleImpression_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_HandleImpression_Landroid_content_Context_I);
			return cb_handleImpression_Landroid_content_Context_I;
		}

		static void n_HandleImpression_Landroid_content_Context_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleImpression (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_handleImpression_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='handleImpression' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("handleImpression", "(Landroid/content/Context;I)V", "GetHandleImpression_Landroid_content_Context_IHandler")]
		public virtual unsafe void HandleImpression (global::Android.Content.Context p0, int p1)
		{
			if (id_handleImpression_Landroid_content_Context_I == IntPtr.Zero)
				id_handleImpression_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "handleImpression", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_handleImpression_Landroid_content_Context_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleImpression", "(Landroid/content/Context;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_handlePause_Landroid_content_Context_I;
#pragma warning disable 0169
		static Delegate GetHandlePause_Landroid_content_Context_IHandler ()
		{
			if (cb_handlePause_Landroid_content_Context_I == null)
				cb_handlePause_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_HandlePause_Landroid_content_Context_I);
			return cb_handlePause_Landroid_content_Context_I;
		}

		static void n_HandlePause_Landroid_content_Context_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandlePause (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_handlePause_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='handlePause' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("handlePause", "(Landroid/content/Context;I)V", "GetHandlePause_Landroid_content_Context_IHandler")]
		public virtual unsafe void HandlePause (global::Android.Content.Context p0, int p1)
		{
			if (id_handlePause_Landroid_content_Context_I == IntPtr.Zero)
				id_handlePause_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "handlePause", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_handlePause_Landroid_content_Context_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handlePause", "(Landroid/content/Context;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_handleResume_Landroid_content_Context_I;
#pragma warning disable 0169
		static Delegate GetHandleResume_Landroid_content_Context_IHandler ()
		{
			if (cb_handleResume_Landroid_content_Context_I == null)
				cb_handleResume_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_HandleResume_Landroid_content_Context_I);
			return cb_handleResume_Landroid_content_Context_I;
		}

		static void n_HandleResume_Landroid_content_Context_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleResume (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_handleResume_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='handleResume' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("handleResume", "(Landroid/content/Context;I)V", "GetHandleResume_Landroid_content_Context_IHandler")]
		public virtual unsafe void HandleResume (global::Android.Content.Context p0, int p1)
		{
			if (id_handleResume_Landroid_content_Context_I == IntPtr.Zero)
				id_handleResume_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "handleResume", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_handleResume_Landroid_content_Context_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleResume", "(Landroid/content/Context;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSkipOffset_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSkipOffset_Ljava_lang_String_Handler ()
		{
			if (cb_setSkipOffset_Ljava_lang_String_ == null)
				cb_setSkipOffset_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSkipOffset_Ljava_lang_String_);
			return cb_setSkipOffset_Ljava_lang_String_;
		}

		static void n_SetSkipOffset_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSkipOffset (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSkipOffset_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='setSkipOffset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSkipOffset", "(Ljava/lang/String;)V", "GetSetSkipOffset_Ljava_lang_String_Handler")]
		public virtual unsafe void SetSkipOffset (string p0)
		{
			if (id_setSkipOffset_Ljava_lang_String_ == IntPtr.Zero)
				id_setSkipOffset_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSkipOffset", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSkipOffset_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSkipOffset", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setVastCompanionAd_Lcom_mopub_mobileads_VastCompanionAdConfig_Lcom_mopub_mobileads_VastCompanionAdConfig_;
#pragma warning disable 0169
		static Delegate GetSetVastCompanionAd_Lcom_mopub_mobileads_VastCompanionAdConfig_Lcom_mopub_mobileads_VastCompanionAdConfig_Handler ()
		{
			if (cb_setVastCompanionAd_Lcom_mopub_mobileads_VastCompanionAdConfig_Lcom_mopub_mobileads_VastCompanionAdConfig_ == null)
				cb_setVastCompanionAd_Lcom_mopub_mobileads_VastCompanionAdConfig_Lcom_mopub_mobileads_VastCompanionAdConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetVastCompanionAd_Lcom_mopub_mobileads_VastCompanionAdConfig_Lcom_mopub_mobileads_VastCompanionAdConfig_);
			return cb_setVastCompanionAd_Lcom_mopub_mobileads_VastCompanionAdConfig_Lcom_mopub_mobileads_VastCompanionAdConfig_;
		}

		static void n_SetVastCompanionAd_Lcom_mopub_mobileads_VastCompanionAdConfig_Lcom_mopub_mobileads_VastCompanionAdConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Mobileads.VastVideoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.VastCompanionAdConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastCompanionAdConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.VastCompanionAdConfig p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastCompanionAdConfig> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetVastCompanionAd (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setVastCompanionAd_Lcom_mopub_mobileads_VastCompanionAdConfig_Lcom_mopub_mobileads_VastCompanionAdConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastVideoConfig']/method[@name='setVastCompanionAd' and count(parameter)=2 and parameter[1][@type='com.mopub.mobileads.VastCompanionAdConfig'] and parameter[2][@type='com.mopub.mobileads.VastCompanionAdConfig']]"
		[Register ("setVastCompanionAd", "(Lcom/mopub/mobileads/VastCompanionAdConfig;Lcom/mopub/mobileads/VastCompanionAdConfig;)V", "GetSetVastCompanionAd_Lcom_mopub_mobileads_VastCompanionAdConfig_Lcom_mopub_mobileads_VastCompanionAdConfig_Handler")]
		public virtual unsafe void SetVastCompanionAd (global::Com.Mopub.Mobileads.VastCompanionAdConfig p0, global::Com.Mopub.Mobileads.VastCompanionAdConfig p1)
		{
			if (id_setVastCompanionAd_Lcom_mopub_mobileads_VastCompanionAdConfig_Lcom_mopub_mobileads_VastCompanionAdConfig_ == IntPtr.Zero)
				id_setVastCompanionAd_Lcom_mopub_mobileads_VastCompanionAdConfig_Lcom_mopub_mobileads_VastCompanionAdConfig_ = JNIEnv.GetMethodID (class_ref, "setVastCompanionAd", "(Lcom/mopub/mobileads/VastCompanionAdConfig;Lcom/mopub/mobileads/VastCompanionAdConfig;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setVastCompanionAd_Lcom_mopub_mobileads_VastCompanionAdConfig_Lcom_mopub_mobileads_VastCompanionAdConfig_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVastCompanionAd", "(Lcom/mopub/mobileads/VastCompanionAdConfig;Lcom/mopub/mobileads/VastCompanionAdConfig;)V"), __args);
			} finally {
			}
		}

	}
}
