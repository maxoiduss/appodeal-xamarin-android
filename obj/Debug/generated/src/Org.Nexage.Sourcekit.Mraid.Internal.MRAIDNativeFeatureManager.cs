using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Mraid.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDNativeFeatureManager']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/mraid/internal/MRAIDNativeFeatureManager", DoNotGenerateAcw=true)]
	public partial class MRAIDNativeFeatureManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/mraid/internal/MRAIDNativeFeatureManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MRAIDNativeFeatureManager); }
		}

		protected MRAIDNativeFeatureManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_util_ArrayList_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDNativeFeatureManager']/constructor[@name='MRAIDNativeFeatureManager' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.ArrayList']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/util/ArrayList;)V", "")]
		public unsafe MRAIDNativeFeatureManager (global::Android.Content.Context p0, global::System.Collections.IList p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaList.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (MRAIDNativeFeatureManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/util/ArrayList;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/util/ArrayList;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_util_ArrayList_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/util/ArrayList;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_util_ArrayList_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_util_ArrayList_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_isCalendarSupported;
#pragma warning disable 0169
		static Delegate GetIsCalendarSupportedHandler ()
		{
			if (cb_isCalendarSupported == null)
				cb_isCalendarSupported = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCalendarSupported);
			return cb_isCalendarSupported;
		}

		static bool n_IsCalendarSupported (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDNativeFeatureManager __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDNativeFeatureManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCalendarSupported;
		}
#pragma warning restore 0169

		static IntPtr id_isCalendarSupported;
		public virtual unsafe bool IsCalendarSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDNativeFeatureManager']/method[@name='isCalendarSupported' and count(parameter)=0]"
			[Register ("isCalendarSupported", "()Z", "GetIsCalendarSupportedHandler")]
			get {
				if (id_isCalendarSupported == IntPtr.Zero)
					id_isCalendarSupported = JNIEnv.GetMethodID (class_ref, "isCalendarSupported", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isCalendarSupported);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCalendarSupported", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isInlineVideoSupported;
#pragma warning disable 0169
		static Delegate GetIsInlineVideoSupportedHandler ()
		{
			if (cb_isInlineVideoSupported == null)
				cb_isInlineVideoSupported = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInlineVideoSupported);
			return cb_isInlineVideoSupported;
		}

		static bool n_IsInlineVideoSupported (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDNativeFeatureManager __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDNativeFeatureManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInlineVideoSupported;
		}
#pragma warning restore 0169

		static IntPtr id_isInlineVideoSupported;
		public virtual unsafe bool IsInlineVideoSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDNativeFeatureManager']/method[@name='isInlineVideoSupported' and count(parameter)=0]"
			[Register ("isInlineVideoSupported", "()Z", "GetIsInlineVideoSupportedHandler")]
			get {
				if (id_isInlineVideoSupported == IntPtr.Zero)
					id_isInlineVideoSupported = JNIEnv.GetMethodID (class_ref, "isInlineVideoSupported", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isInlineVideoSupported);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInlineVideoSupported", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isSmsSupported;
#pragma warning disable 0169
		static Delegate GetIsSmsSupportedHandler ()
		{
			if (cb_isSmsSupported == null)
				cb_isSmsSupported = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSmsSupported);
			return cb_isSmsSupported;
		}

		static bool n_IsSmsSupported (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDNativeFeatureManager __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDNativeFeatureManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSmsSupported;
		}
#pragma warning restore 0169

		static IntPtr id_isSmsSupported;
		public virtual unsafe bool IsSmsSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDNativeFeatureManager']/method[@name='isSmsSupported' and count(parameter)=0]"
			[Register ("isSmsSupported", "()Z", "GetIsSmsSupportedHandler")]
			get {
				if (id_isSmsSupported == IntPtr.Zero)
					id_isSmsSupported = JNIEnv.GetMethodID (class_ref, "isSmsSupported", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isSmsSupported);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSmsSupported", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isStorePictureSupported;
#pragma warning disable 0169
		static Delegate GetIsStorePictureSupportedHandler ()
		{
			if (cb_isStorePictureSupported == null)
				cb_isStorePictureSupported = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStorePictureSupported);
			return cb_isStorePictureSupported;
		}

		static bool n_IsStorePictureSupported (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDNativeFeatureManager __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDNativeFeatureManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStorePictureSupported;
		}
#pragma warning restore 0169

		static IntPtr id_isStorePictureSupported;
		public virtual unsafe bool IsStorePictureSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDNativeFeatureManager']/method[@name='isStorePictureSupported' and count(parameter)=0]"
			[Register ("isStorePictureSupported", "()Z", "GetIsStorePictureSupportedHandler")]
			get {
				if (id_isStorePictureSupported == IntPtr.Zero)
					id_isStorePictureSupported = JNIEnv.GetMethodID (class_ref, "isStorePictureSupported", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isStorePictureSupported);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStorePictureSupported", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isTelSupported;
#pragma warning disable 0169
		static Delegate GetIsTelSupportedHandler ()
		{
			if (cb_isTelSupported == null)
				cb_isTelSupported = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTelSupported);
			return cb_isTelSupported;
		}

		static bool n_IsTelSupported (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDNativeFeatureManager __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDNativeFeatureManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTelSupported;
		}
#pragma warning restore 0169

		static IntPtr id_isTelSupported;
		public virtual unsafe bool IsTelSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDNativeFeatureManager']/method[@name='isTelSupported' and count(parameter)=0]"
			[Register ("isTelSupported", "()Z", "GetIsTelSupportedHandler")]
			get {
				if (id_isTelSupported == IntPtr.Zero)
					id_isTelSupported = JNIEnv.GetMethodID (class_ref, "isTelSupported", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isTelSupported);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTelSupported", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getSupportedNativeFeatures;
#pragma warning disable 0169
		static Delegate GetGetSupportedNativeFeaturesHandler ()
		{
			if (cb_getSupportedNativeFeatures == null)
				cb_getSupportedNativeFeatures = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSupportedNativeFeatures);
			return cb_getSupportedNativeFeatures;
		}

		static IntPtr n_GetSupportedNativeFeatures (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDNativeFeatureManager __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDNativeFeatureManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.SupportedNativeFeatures);
		}
#pragma warning restore 0169

		static IntPtr id_getSupportedNativeFeatures;
		public virtual unsafe global::System.Collections.IList SupportedNativeFeatures {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDNativeFeatureManager']/method[@name='getSupportedNativeFeatures' and count(parameter)=0]"
			[Register ("getSupportedNativeFeatures", "()Ljava/util/ArrayList;", "GetGetSupportedNativeFeaturesHandler")]
			get {
				if (id_getSupportedNativeFeatures == IntPtr.Zero)
					id_getSupportedNativeFeatures = JNIEnv.GetMethodID (class_ref, "getSupportedNativeFeatures", "()Ljava/util/ArrayList;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getSupportedNativeFeatures), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSupportedNativeFeatures", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
