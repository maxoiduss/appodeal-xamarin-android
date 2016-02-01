using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlHandler']"
	[global::Android.Runtime.Register ("com/mopub/common/UrlHandler", DoNotGenerateAcw=true)]
	public partial class UrlHandler : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlHandler.Builder']"
		[global::Android.Runtime.Register ("com/mopub/common/UrlHandler$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/UrlHandler$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlHandler.Builder']/constructor[@name='UrlHandler.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Builder)) {
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

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Common.UrlHandler.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlHandler.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/mopub/common/UrlHandler;", "GetBuildHandler")]
			public virtual unsafe global::Com.Mopub.Common.UrlHandler Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/mopub/common/UrlHandler;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/mopub/common/UrlHandler;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_withMoPubSchemeListener_Lcom_mopub_common_UrlHandler_MoPubSchemeListener_;
#pragma warning disable 0169
			static Delegate GetWithMoPubSchemeListener_Lcom_mopub_common_UrlHandler_MoPubSchemeListener_Handler ()
			{
				if (cb_withMoPubSchemeListener_Lcom_mopub_common_UrlHandler_MoPubSchemeListener_ == null)
					cb_withMoPubSchemeListener_Lcom_mopub_common_UrlHandler_MoPubSchemeListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithMoPubSchemeListener_Lcom_mopub_common_UrlHandler_MoPubSchemeListener_);
				return cb_withMoPubSchemeListener_Lcom_mopub_common_UrlHandler_MoPubSchemeListener_;
			}

			static IntPtr n_WithMoPubSchemeListener_Lcom_mopub_common_UrlHandler_MoPubSchemeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.UrlHandler.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Common.UrlHandler.IMoPubSchemeListener p0 = (global::Com.Mopub.Common.UrlHandler.IMoPubSchemeListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler.IMoPubSchemeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithMoPubSchemeListener (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withMoPubSchemeListener_Lcom_mopub_common_UrlHandler_MoPubSchemeListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlHandler.Builder']/method[@name='withMoPubSchemeListener' and count(parameter)=1 and parameter[1][@type='com.mopub.common.UrlHandler.MoPubSchemeListener']]"
			[Register ("withMoPubSchemeListener", "(Lcom/mopub/common/UrlHandler$MoPubSchemeListener;)Lcom/mopub/common/UrlHandler$Builder;", "GetWithMoPubSchemeListener_Lcom_mopub_common_UrlHandler_MoPubSchemeListener_Handler")]
			public virtual unsafe global::Com.Mopub.Common.UrlHandler.Builder WithMoPubSchemeListener (global::Com.Mopub.Common.UrlHandler.IMoPubSchemeListener p0)
			{
				if (id_withMoPubSchemeListener_Lcom_mopub_common_UrlHandler_MoPubSchemeListener_ == IntPtr.Zero)
					id_withMoPubSchemeListener_Lcom_mopub_common_UrlHandler_MoPubSchemeListener_ = JNIEnv.GetMethodID (class_ref, "withMoPubSchemeListener", "(Lcom/mopub/common/UrlHandler$MoPubSchemeListener;)Lcom/mopub/common/UrlHandler$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mopub.Common.UrlHandler.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withMoPubSchemeListener_Lcom_mopub_common_UrlHandler_MoPubSchemeListener_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withMoPubSchemeListener", "(Lcom/mopub/common/UrlHandler$MoPubSchemeListener;)Lcom/mopub/common/UrlHandler$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_withResultActions_Lcom_mopub_common_UrlHandler_ResultActions_;
#pragma warning disable 0169
			static Delegate GetWithResultActions_Lcom_mopub_common_UrlHandler_ResultActions_Handler ()
			{
				if (cb_withResultActions_Lcom_mopub_common_UrlHandler_ResultActions_ == null)
					cb_withResultActions_Lcom_mopub_common_UrlHandler_ResultActions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithResultActions_Lcom_mopub_common_UrlHandler_ResultActions_);
				return cb_withResultActions_Lcom_mopub_common_UrlHandler_ResultActions_;
			}

			static IntPtr n_WithResultActions_Lcom_mopub_common_UrlHandler_ResultActions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.UrlHandler.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Common.UrlHandler.IResultActions p0 = (global::Com.Mopub.Common.UrlHandler.IResultActions)global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler.IResultActions> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithResultActions (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withResultActions_Lcom_mopub_common_UrlHandler_ResultActions_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlHandler.Builder']/method[@name='withResultActions' and count(parameter)=1 and parameter[1][@type='com.mopub.common.UrlHandler.ResultActions']]"
			[Register ("withResultActions", "(Lcom/mopub/common/UrlHandler$ResultActions;)Lcom/mopub/common/UrlHandler$Builder;", "GetWithResultActions_Lcom_mopub_common_UrlHandler_ResultActions_Handler")]
			public virtual unsafe global::Com.Mopub.Common.UrlHandler.Builder WithResultActions (global::Com.Mopub.Common.UrlHandler.IResultActions p0)
			{
				if (id_withResultActions_Lcom_mopub_common_UrlHandler_ResultActions_ == IntPtr.Zero)
					id_withResultActions_Lcom_mopub_common_UrlHandler_ResultActions_ = JNIEnv.GetMethodID (class_ref, "withResultActions", "(Lcom/mopub/common/UrlHandler$ResultActions;)Lcom/mopub/common/UrlHandler$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mopub.Common.UrlHandler.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withResultActions_Lcom_mopub_common_UrlHandler_ResultActions_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withResultActions", "(Lcom/mopub/common/UrlHandler$ResultActions;)Lcom/mopub/common/UrlHandler$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_withSupportedUrlActions_Lcom_mopub_common_UrlAction_arrayLcom_mopub_common_UrlAction_;
#pragma warning disable 0169
			static Delegate GetWithSupportedUrlActions_Lcom_mopub_common_UrlAction_arrayLcom_mopub_common_UrlAction_Handler ()
			{
				if (cb_withSupportedUrlActions_Lcom_mopub_common_UrlAction_arrayLcom_mopub_common_UrlAction_ == null)
					cb_withSupportedUrlActions_Lcom_mopub_common_UrlAction_arrayLcom_mopub_common_UrlAction_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WithSupportedUrlActions_Lcom_mopub_common_UrlAction_arrayLcom_mopub_common_UrlAction_);
				return cb_withSupportedUrlActions_Lcom_mopub_common_UrlAction_arrayLcom_mopub_common_UrlAction_;
			}

			static IntPtr n_WithSupportedUrlActions_Lcom_mopub_common_UrlAction_arrayLcom_mopub_common_UrlAction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mopub.Common.UrlHandler.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Common.UrlAction p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlAction> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Common.UrlAction[] p1 = (global::Com.Mopub.Common.UrlAction[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Mopub.Common.UrlAction));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSupportedUrlActions (p0, p1));
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withSupportedUrlActions_Lcom_mopub_common_UrlAction_arrayLcom_mopub_common_UrlAction_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlHandler.Builder']/method[@name='withSupportedUrlActions' and count(parameter)=2 and parameter[1][@type='com.mopub.common.UrlAction'] and parameter[2][@type='com.mopub.common.UrlAction...']]"
			[Register ("withSupportedUrlActions", "(Lcom/mopub/common/UrlAction;[Lcom/mopub/common/UrlAction;)Lcom/mopub/common/UrlHandler$Builder;", "GetWithSupportedUrlActions_Lcom_mopub_common_UrlAction_arrayLcom_mopub_common_UrlAction_Handler")]
			public virtual unsafe global::Com.Mopub.Common.UrlHandler.Builder WithSupportedUrlActions (global::Com.Mopub.Common.UrlAction p0, params global:: Com.Mopub.Common.UrlAction[] p1)
			{
				if (id_withSupportedUrlActions_Lcom_mopub_common_UrlAction_arrayLcom_mopub_common_UrlAction_ == IntPtr.Zero)
					id_withSupportedUrlActions_Lcom_mopub_common_UrlAction_arrayLcom_mopub_common_UrlAction_ = JNIEnv.GetMethodID (class_ref, "withSupportedUrlActions", "(Lcom/mopub/common/UrlAction;[Lcom/mopub/common/UrlAction;)Lcom/mopub/common/UrlHandler$Builder;");
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);

					global::Com.Mopub.Common.UrlHandler.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withSupportedUrlActions_Lcom_mopub_common_UrlAction_arrayLcom_mopub_common_UrlAction_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSupportedUrlActions", "(Lcom/mopub/common/UrlAction;[Lcom/mopub/common/UrlAction;)Lcom/mopub/common/UrlHandler$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static Delegate cb_withSupportedUrlActions_Ljava_util_EnumSet_;
#pragma warning disable 0169
			static Delegate GetWithSupportedUrlActions_Ljava_util_EnumSet_Handler ()
			{
				if (cb_withSupportedUrlActions_Ljava_util_EnumSet_ == null)
					cb_withSupportedUrlActions_Ljava_util_EnumSet_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithSupportedUrlActions_Ljava_util_EnumSet_);
				return cb_withSupportedUrlActions_Ljava_util_EnumSet_;
			}

			static IntPtr n_WithSupportedUrlActions_Ljava_util_EnumSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.UrlHandler.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Util.EnumSet p0 = global::Java.Lang.Object.GetObject<global::Java.Util.EnumSet> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSupportedUrlActions (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withSupportedUrlActions_Ljava_util_EnumSet_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlHandler.Builder']/method[@name='withSupportedUrlActions' and count(parameter)=1 and parameter[1][@type='java.util.EnumSet']]"
			[Register ("withSupportedUrlActions", "(Ljava/util/EnumSet;)Lcom/mopub/common/UrlHandler$Builder;", "GetWithSupportedUrlActions_Ljava_util_EnumSet_Handler")]
			public virtual unsafe global::Com.Mopub.Common.UrlHandler.Builder WithSupportedUrlActions (global::Java.Util.EnumSet p0)
			{
				if (id_withSupportedUrlActions_Ljava_util_EnumSet_ == IntPtr.Zero)
					id_withSupportedUrlActions_Ljava_util_EnumSet_ = JNIEnv.GetMethodID (class_ref, "withSupportedUrlActions", "(Ljava/util/EnumSet;)Lcom/mopub/common/UrlHandler$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mopub.Common.UrlHandler.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withSupportedUrlActions_Ljava_util_EnumSet_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSupportedUrlActions", "(Ljava/util/EnumSet;)Lcom/mopub/common/UrlHandler$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_withoutMoPubBrowser;
#pragma warning disable 0169
			static Delegate GetWithoutMoPubBrowserHandler ()
			{
				if (cb_withoutMoPubBrowser == null)
					cb_withoutMoPubBrowser = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_WithoutMoPubBrowser);
				return cb_withoutMoPubBrowser;
			}

			static IntPtr n_WithoutMoPubBrowser (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Common.UrlHandler.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.WithoutMoPubBrowser ());
			}
#pragma warning restore 0169

			static IntPtr id_withoutMoPubBrowser;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlHandler.Builder']/method[@name='withoutMoPubBrowser' and count(parameter)=0]"
			[Register ("withoutMoPubBrowser", "()Lcom/mopub/common/UrlHandler$Builder;", "GetWithoutMoPubBrowserHandler")]
			public virtual unsafe global::Com.Mopub.Common.UrlHandler.Builder WithoutMoPubBrowser ()
			{
				if (id_withoutMoPubBrowser == IntPtr.Zero)
					id_withoutMoPubBrowser = JNIEnv.GetMethodID (class_ref, "withoutMoPubBrowser", "()Lcom/mopub/common/UrlHandler$Builder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withoutMoPubBrowser), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withoutMoPubBrowser", "()Lcom/mopub/common/UrlHandler$Builder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.common']/interface[@name='UrlHandler.MoPubSchemeListener']"
		[Register ("com/mopub/common/UrlHandler$MoPubSchemeListener", "", "Com.Mopub.Common.UrlHandler/IMoPubSchemeListenerInvoker")]
		public partial interface IMoPubSchemeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/interface[@name='UrlHandler.MoPubSchemeListener']/method[@name='onClose' and count(parameter)=0]"
			[Register ("onClose", "()V", "GetOnCloseHandler:Com.Mopub.Common.UrlHandler/IMoPubSchemeListenerInvoker, AppodealXamarinPlugin")]
			void OnClose ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/interface[@name='UrlHandler.MoPubSchemeListener']/method[@name='onFailLoad' and count(parameter)=0]"
			[Register ("onFailLoad", "()V", "GetOnFailLoadHandler:Com.Mopub.Common.UrlHandler/IMoPubSchemeListenerInvoker, AppodealXamarinPlugin")]
			void OnFailLoad ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/interface[@name='UrlHandler.MoPubSchemeListener']/method[@name='onFinishLoad' and count(parameter)=0]"
			[Register ("onFinishLoad", "()V", "GetOnFinishLoadHandler:Com.Mopub.Common.UrlHandler/IMoPubSchemeListenerInvoker, AppodealXamarinPlugin")]
			void OnFinishLoad ();

		}

		[global::Android.Runtime.Register ("com/mopub/common/UrlHandler$MoPubSchemeListener", DoNotGenerateAcw=true)]
		internal class IMoPubSchemeListenerInvoker : global::Java.Lang.Object, IMoPubSchemeListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/common/UrlHandler$MoPubSchemeListener");
			IntPtr class_ref;

			public static IMoPubSchemeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMoPubSchemeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.common.UrlHandler.MoPubSchemeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMoPubSchemeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IMoPubSchemeListenerInvoker); }
			}

			static Delegate cb_onClose;
#pragma warning disable 0169
			static Delegate GetOnCloseHandler ()
			{
				if (cb_onClose == null)
					cb_onClose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnClose);
				return cb_onClose;
			}

			static void n_OnClose (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Common.UrlHandler.IMoPubSchemeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler.IMoPubSchemeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnClose ();
			}
#pragma warning restore 0169

			IntPtr id_onClose;
			public unsafe void OnClose ()
			{
				if (id_onClose == IntPtr.Zero)
					id_onClose = JNIEnv.GetMethodID (class_ref, "onClose", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onClose);
			}

			static Delegate cb_onFailLoad;
#pragma warning disable 0169
			static Delegate GetOnFailLoadHandler ()
			{
				if (cb_onFailLoad == null)
					cb_onFailLoad = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFailLoad);
				return cb_onFailLoad;
			}

			static void n_OnFailLoad (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Common.UrlHandler.IMoPubSchemeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler.IMoPubSchemeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnFailLoad ();
			}
#pragma warning restore 0169

			IntPtr id_onFailLoad;
			public unsafe void OnFailLoad ()
			{
				if (id_onFailLoad == IntPtr.Zero)
					id_onFailLoad = JNIEnv.GetMethodID (class_ref, "onFailLoad", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onFailLoad);
			}

			static Delegate cb_onFinishLoad;
#pragma warning disable 0169
			static Delegate GetOnFinishLoadHandler ()
			{
				if (cb_onFinishLoad == null)
					cb_onFinishLoad = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFinishLoad);
				return cb_onFinishLoad;
			}

			static void n_OnFinishLoad (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Common.UrlHandler.IMoPubSchemeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler.IMoPubSchemeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnFinishLoad ();
			}
#pragma warning restore 0169

			IntPtr id_onFinishLoad;
			public unsafe void OnFinishLoad ()
			{
				if (id_onFinishLoad == IntPtr.Zero)
					id_onFinishLoad = JNIEnv.GetMethodID (class_ref, "onFinishLoad", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onFinishLoad);
			}

		}

		[global::Android.Runtime.Register ("mono/com/mopub/common/UrlHandler_MoPubSchemeListenerImplementor")]
		internal sealed partial class IMoPubSchemeListenerImplementor : global::Java.Lang.Object, IMoPubSchemeListener {

			object sender;

			public IMoPubSchemeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/common/UrlHandler_MoPubSchemeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnCloseHandler;
#pragma warning restore 0649

			public void OnClose ()
			{
				var __h = OnCloseHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnFailLoadHandler;
#pragma warning restore 0649

			public void OnFailLoad ()
			{
				var __h = OnFailLoadHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnFinishLoadHandler;
#pragma warning restore 0649

			public void OnFinishLoad ()
			{
				var __h = OnFinishLoadHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IMoPubSchemeListenerImplementor value)
			{
				return value.OnCloseHandler == null && value.OnFailLoadHandler == null && value.OnFinishLoadHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.common']/interface[@name='UrlHandler.ResultActions']"
		[Register ("com/mopub/common/UrlHandler$ResultActions", "", "Com.Mopub.Common.UrlHandler/IResultActionsInvoker")]
		public partial interface IResultActions : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/interface[@name='UrlHandler.ResultActions']/method[@name='urlHandlingFailed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.common.UrlAction']]"
			[Register ("urlHandlingFailed", "(Ljava/lang/String;Lcom/mopub/common/UrlAction;)V", "GetUrlHandlingFailed_Ljava_lang_String_Lcom_mopub_common_UrlAction_Handler:Com.Mopub.Common.UrlHandler/IResultActionsInvoker, AppodealXamarinPlugin")]
			void UrlHandlingFailed (string p0, global::Com.Mopub.Common.UrlAction p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/interface[@name='UrlHandler.ResultActions']/method[@name='urlHandlingSucceeded' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.common.UrlAction']]"
			[Register ("urlHandlingSucceeded", "(Ljava/lang/String;Lcom/mopub/common/UrlAction;)V", "GetUrlHandlingSucceeded_Ljava_lang_String_Lcom_mopub_common_UrlAction_Handler:Com.Mopub.Common.UrlHandler/IResultActionsInvoker, AppodealXamarinPlugin")]
			void UrlHandlingSucceeded (string p0, global::Com.Mopub.Common.UrlAction p1);

		}

		[global::Android.Runtime.Register ("com/mopub/common/UrlHandler$ResultActions", DoNotGenerateAcw=true)]
		internal class IResultActionsInvoker : global::Java.Lang.Object, IResultActions {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/common/UrlHandler$ResultActions");
			IntPtr class_ref;

			public static IResultActions GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IResultActions> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.common.UrlHandler.ResultActions"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IResultActionsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IResultActionsInvoker); }
			}

			static Delegate cb_urlHandlingFailed_Ljava_lang_String_Lcom_mopub_common_UrlAction_;
#pragma warning disable 0169
			static Delegate GetUrlHandlingFailed_Ljava_lang_String_Lcom_mopub_common_UrlAction_Handler ()
			{
				if (cb_urlHandlingFailed_Ljava_lang_String_Lcom_mopub_common_UrlAction_ == null)
					cb_urlHandlingFailed_Ljava_lang_String_Lcom_mopub_common_UrlAction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UrlHandlingFailed_Ljava_lang_String_Lcom_mopub_common_UrlAction_);
				return cb_urlHandlingFailed_Ljava_lang_String_Lcom_mopub_common_UrlAction_;
			}

			static void n_UrlHandlingFailed_Ljava_lang_String_Lcom_mopub_common_UrlAction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mopub.Common.UrlHandler.IResultActions __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler.IResultActions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Common.UrlAction p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlAction> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.UrlHandlingFailed (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_urlHandlingFailed_Ljava_lang_String_Lcom_mopub_common_UrlAction_;
			public unsafe void UrlHandlingFailed (string p0, global::Com.Mopub.Common.UrlAction p1)
			{
				if (id_urlHandlingFailed_Ljava_lang_String_Lcom_mopub_common_UrlAction_ == IntPtr.Zero)
					id_urlHandlingFailed_Ljava_lang_String_Lcom_mopub_common_UrlAction_ = JNIEnv.GetMethodID (class_ref, "urlHandlingFailed", "(Ljava/lang/String;Lcom/mopub/common/UrlAction;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_urlHandlingFailed_Ljava_lang_String_Lcom_mopub_common_UrlAction_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_urlHandlingSucceeded_Ljava_lang_String_Lcom_mopub_common_UrlAction_;
#pragma warning disable 0169
			static Delegate GetUrlHandlingSucceeded_Ljava_lang_String_Lcom_mopub_common_UrlAction_Handler ()
			{
				if (cb_urlHandlingSucceeded_Ljava_lang_String_Lcom_mopub_common_UrlAction_ == null)
					cb_urlHandlingSucceeded_Ljava_lang_String_Lcom_mopub_common_UrlAction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UrlHandlingSucceeded_Ljava_lang_String_Lcom_mopub_common_UrlAction_);
				return cb_urlHandlingSucceeded_Ljava_lang_String_Lcom_mopub_common_UrlAction_;
			}

			static void n_UrlHandlingSucceeded_Ljava_lang_String_Lcom_mopub_common_UrlAction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mopub.Common.UrlHandler.IResultActions __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler.IResultActions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Common.UrlAction p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlAction> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.UrlHandlingSucceeded (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_urlHandlingSucceeded_Ljava_lang_String_Lcom_mopub_common_UrlAction_;
			public unsafe void UrlHandlingSucceeded (string p0, global::Com.Mopub.Common.UrlAction p1)
			{
				if (id_urlHandlingSucceeded_Ljava_lang_String_Lcom_mopub_common_UrlAction_ == IntPtr.Zero)
					id_urlHandlingSucceeded_Ljava_lang_String_Lcom_mopub_common_UrlAction_ = JNIEnv.GetMethodID (class_ref, "urlHandlingSucceeded", "(Ljava/lang/String;Lcom/mopub/common/UrlAction;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_urlHandlingSucceeded_Ljava_lang_String_Lcom_mopub_common_UrlAction_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/UrlHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UrlHandler); }
		}

		protected UrlHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_handleResolvedUrl_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_Iterable_;
#pragma warning disable 0169
		static Delegate GetHandleResolvedUrl_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_Iterable_Handler ()
		{
			if (cb_handleResolvedUrl_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_Iterable_ == null)
				cb_handleResolvedUrl_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_Iterable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr, bool>) n_HandleResolvedUrl_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_Iterable_);
			return cb_handleResolvedUrl_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_Iterable_;
		}

		static bool n_HandleResolvedUrl_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_Iterable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2, IntPtr native_p3)
		{
			global::Com.Mopub.Common.UrlHandler __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IIterable p3 = (global::Java.Lang.IIterable)global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleResolvedUrl (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_handleResolvedUrl_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlHandler']/method[@name='handleResolvedUrl' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='java.lang.Iterable']]"
		[Register ("handleResolvedUrl", "(Landroid/content/Context;Ljava/lang/String;ZLjava/lang/Iterable;)Z", "GetHandleResolvedUrl_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_Iterable_Handler")]
		public virtual unsafe bool HandleResolvedUrl (global::Android.Content.Context p0, string p1, bool p2, global::Java.Lang.IIterable p3)
		{
			if (id_handleResolvedUrl_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_Iterable_ == IntPtr.Zero)
				id_handleResolvedUrl_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "handleResolvedUrl", "(Landroid/content/Context;Ljava/lang/String;ZLjava/lang/Iterable;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_handleResolvedUrl_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_Iterable_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleResolvedUrl", "(Landroid/content/Context;Ljava/lang/String;ZLjava/lang/Iterable;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_handleUrl_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHandleUrl_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_handleUrl_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_handleUrl_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_HandleUrl_Landroid_content_Context_Ljava_lang_String_);
			return cb_handleUrl_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_HandleUrl_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Common.UrlHandler __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.HandleUrl (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_handleUrl_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlHandler']/method[@name='handleUrl' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("handleUrl", "(Landroid/content/Context;Ljava/lang/String;)V", "GetHandleUrl_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe void HandleUrl (global::Android.Content.Context p0, string p1)
		{
			if (id_handleUrl_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_handleUrl_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "handleUrl", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_handleUrl_Landroid_content_Context_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleUrl", "(Landroid/content/Context;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_handleUrl_Landroid_content_Context_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetHandleUrl_Landroid_content_Context_Ljava_lang_String_ZHandler ()
		{
			if (cb_handleUrl_Landroid_content_Context_Ljava_lang_String_Z == null)
				cb_handleUrl_Landroid_content_Context_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_HandleUrl_Landroid_content_Context_Ljava_lang_String_Z);
			return cb_handleUrl_Landroid_content_Context_Ljava_lang_String_Z;
		}

		static void n_HandleUrl_Landroid_content_Context_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Mopub.Common.UrlHandler __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.HandleUrl (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_handleUrl_Landroid_content_Context_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlHandler']/method[@name='handleUrl' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("handleUrl", "(Landroid/content/Context;Ljava/lang/String;Z)V", "GetHandleUrl_Landroid_content_Context_Ljava_lang_String_ZHandler")]
		public virtual unsafe void HandleUrl (global::Android.Content.Context p0, string p1, bool p2)
		{
			if (id_handleUrl_Landroid_content_Context_Ljava_lang_String_Z == IntPtr.Zero)
				id_handleUrl_Landroid_content_Context_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "handleUrl", "(Landroid/content/Context;Ljava/lang/String;Z)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_handleUrl_Landroid_content_Context_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleUrl", "(Landroid/content/Context;Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_handleUrl_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_Iterable_;
#pragma warning disable 0169
		static Delegate GetHandleUrl_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_Iterable_Handler ()
		{
			if (cb_handleUrl_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_Iterable_ == null)
				cb_handleUrl_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_Iterable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_HandleUrl_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_Iterable_);
			return cb_handleUrl_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_Iterable_;
		}

		static void n_HandleUrl_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_Iterable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2, IntPtr native_p3)
		{
			global::Com.Mopub.Common.UrlHandler __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.UrlHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IIterable p3 = (global::Java.Lang.IIterable)global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.HandleUrl (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_handleUrl_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='UrlHandler']/method[@name='handleUrl' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='java.lang.Iterable']]"
		[Register ("handleUrl", "(Landroid/content/Context;Ljava/lang/String;ZLjava/lang/Iterable;)V", "GetHandleUrl_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_Iterable_Handler")]
		public virtual unsafe void HandleUrl (global::Android.Content.Context p0, string p1, bool p2, global::Java.Lang.IIterable p3)
		{
			if (id_handleUrl_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_Iterable_ == IntPtr.Zero)
				id_handleUrl_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "handleUrl", "(Landroid/content/Context;Ljava/lang/String;ZLjava/lang/Iterable;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_handleUrl_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_Iterable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleUrl", "(Landroid/content/Context;Ljava/lang/String;ZLjava/lang/Iterable;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
