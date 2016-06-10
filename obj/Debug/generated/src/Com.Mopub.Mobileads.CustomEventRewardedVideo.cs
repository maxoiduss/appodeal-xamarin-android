using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/CustomEventRewardedVideo", DoNotGenerateAcw=true)]
	public abstract partial class CustomEventRewardedVideo : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='CustomEventRewardedVideo.CustomEventRewardedVideoListener']"
		[Register ("com/mopub/mobileads/CustomEventRewardedVideo$CustomEventRewardedVideoListener", "", "Com.Mopub.Mobileads.CustomEventRewardedVideo/ICustomEventRewardedVideoListenerInvoker")]
		protected internal partial interface ICustomEventRewardedVideoListener : IJavaObject {

		}

		[global::Android.Runtime.Register ("com/mopub/mobileads/CustomEventRewardedVideo$CustomEventRewardedVideoListener", DoNotGenerateAcw=true)]
		internal class ICustomEventRewardedVideoListenerInvoker : global::Java.Lang.Object, ICustomEventRewardedVideoListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/CustomEventRewardedVideo$CustomEventRewardedVideoListener");
			IntPtr class_ref;

			public static ICustomEventRewardedVideoListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICustomEventRewardedVideoListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.CustomEventRewardedVideo.CustomEventRewardedVideoListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICustomEventRewardedVideoListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICustomEventRewardedVideoListenerInvoker); }
			}

		}

		[global::Android.Runtime.Register ("mono/com/mopub/mobileads/CustomEventRewardedVideo_CustomEventRewardedVideoListenerImplementor")]
		internal sealed partial class ICustomEventRewardedVideoListenerImplementor : global::Java.Lang.Object, ICustomEventRewardedVideoListener {

			public ICustomEventRewardedVideoListenerImplementor ()
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/mobileads/CustomEventRewardedVideo_CustomEventRewardedVideoListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			}


			internal static bool __IsEmpty (ICustomEventRewardedVideoListenerImplementor value)
			{
				return true;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/CustomEventRewardedVideo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CustomEventRewardedVideo); }
		}

		protected CustomEventRewardedVideo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/constructor[@name='CustomEventRewardedVideo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CustomEventRewardedVideo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CustomEventRewardedVideo)) {
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

		static Delegate cb_getAdNetworkId;
#pragma warning disable 0169
		static Delegate GetGetAdNetworkIdHandler ()
		{
			if (cb_getAdNetworkId == null)
				cb_getAdNetworkId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdNetworkId);
			return cb_getAdNetworkId;
		}

		static IntPtr n_GetAdNetworkId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.CustomEventRewardedVideo __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventRewardedVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdNetworkId);
		}
#pragma warning restore 0169

		protected abstract string AdNetworkId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='getAdNetworkId' and count(parameter)=0]"
			[Register ("getAdNetworkId", "()Ljava/lang/String;", "GetGetAdNetworkIdHandler")] get;
		}

		static Delegate cb_hasVideoAvailable;
#pragma warning disable 0169
		static Delegate GetHasVideoAvailableHandler ()
		{
			if (cb_hasVideoAvailable == null)
				cb_hasVideoAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasVideoAvailable);
			return cb_hasVideoAvailable;
		}

		static bool n_HasVideoAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.CustomEventRewardedVideo __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventRewardedVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasVideoAvailable;
		}
#pragma warning restore 0169

		protected abstract bool HasVideoAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='hasVideoAvailable' and count(parameter)=0]"
			[Register ("hasVideoAvailable", "()Z", "GetHasVideoAvailableHandler")] get;
		}

		static Delegate cb_getLifecycleListener;
#pragma warning disable 0169
		static Delegate GetGetLifecycleListenerHandler ()
		{
			if (cb_getLifecycleListener == null)
				cb_getLifecycleListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLifecycleListener);
			return cb_getLifecycleListener;
		}

		static IntPtr n_GetLifecycleListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.CustomEventRewardedVideo __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventRewardedVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LifecycleListener);
		}
#pragma warning restore 0169

		protected abstract global::Com.Mopub.Common.ILifecycleListener LifecycleListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='getLifecycleListener' and count(parameter)=0]"
			[Register ("getLifecycleListener", "()Lcom/mopub/common/LifecycleListener;", "GetGetLifecycleListenerHandler")] get;
		}

		static Delegate cb_getVideoListenerForSdk;
#pragma warning disable 0169
		static Delegate GetGetVideoListenerForSdkHandler ()
		{
			if (cb_getVideoListenerForSdk == null)
				cb_getVideoListenerForSdk = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVideoListenerForSdk);
			return cb_getVideoListenerForSdk;
		}

		static IntPtr n_GetVideoListenerForSdk (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.CustomEventRewardedVideo __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventRewardedVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VideoListenerForSdk);
		}
#pragma warning restore 0169

		protected abstract global::Com.Mopub.Mobileads.CustomEventRewardedVideo.ICustomEventRewardedVideoListener VideoListenerForSdk {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='getVideoListenerForSdk' and count(parameter)=0]"
			[Register ("getVideoListenerForSdk", "()Lcom/mopub/mobileads/CustomEventRewardedVideo$CustomEventRewardedVideoListener;", "GetGetVideoListenerForSdkHandler")] get;
		}

		static Delegate cb_checkAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetCheckAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_Handler ()
		{
			if (cb_checkAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_ == null)
				cb_checkAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_CheckAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_);
			return cb_checkAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_;
		}

		static bool n_CheckAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mopub.Mobileads.CustomEventRewardedVideo __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventRewardedVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CheckAndInitializeSdk (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='checkAndInitializeSdk' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.util.Map'] and parameter[3][@type='java.util.Map']]"
		[Register ("checkAndInitializeSdk", "(Landroid/app/Activity;Ljava/util/Map;Ljava/util/Map;)Z", "GetCheckAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_Handler")]
		protected abstract bool CheckAndInitializeSdk (global::Android.App.Activity p0, global::System.Collections.IDictionary p1, global::System.Collections.IDictionary p2);

		static Delegate cb_loadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetLoadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_Handler ()
		{
			if (cb_loadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_ == null)
				cb_loadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_);
			return cb_loadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_;
		}

		static void n_LoadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mopub.Mobileads.CustomEventRewardedVideo __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventRewardedVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.LoadWithSdkInitialized (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='loadWithSdkInitialized' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.util.Map'] and parameter[3][@type='java.util.Map']]"
		[Register ("loadWithSdkInitialized", "(Landroid/app/Activity;Ljava/util/Map;Ljava/util/Map;)V", "GetLoadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_Handler")]
		protected abstract void LoadWithSdkInitialized (global::Android.App.Activity p0, global::System.Collections.IDictionary p1, global::System.Collections.IDictionary p2);

		static Delegate cb_onInvalidate;
#pragma warning disable 0169
		static Delegate GetOnInvalidateHandler ()
		{
			if (cb_onInvalidate == null)
				cb_onInvalidate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInvalidate);
			return cb_onInvalidate;
		}

		static void n_OnInvalidate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.CustomEventRewardedVideo __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventRewardedVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInvalidate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='onInvalidate' and count(parameter)=0]"
		[Register ("onInvalidate", "()V", "GetOnInvalidateHandler")]
		protected abstract void OnInvalidate ();

		static Delegate cb_showVideo;
#pragma warning disable 0169
		static Delegate GetShowVideoHandler ()
		{
			if (cb_showVideo == null)
				cb_showVideo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowVideo);
			return cb_showVideo;
		}

		static void n_ShowVideo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.CustomEventRewardedVideo __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventRewardedVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowVideo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='showVideo' and count(parameter)=0]"
		[Register ("showVideo", "()V", "GetShowVideoHandler")]
		protected abstract void ShowVideo ();

	}

	[global::Android.Runtime.Register ("com/mopub/mobileads/CustomEventRewardedVideo", DoNotGenerateAcw=true)]
	internal partial class CustomEventRewardedVideoInvoker : CustomEventRewardedVideo {

		public CustomEventRewardedVideoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (CustomEventRewardedVideoInvoker); }
		}

		static IntPtr id_getAdNetworkId;
		protected override unsafe string AdNetworkId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='getAdNetworkId' and count(parameter)=0]"
			[Register ("getAdNetworkId", "()Ljava/lang/String;", "GetGetAdNetworkIdHandler")]
			get {
				if (id_getAdNetworkId == IntPtr.Zero)
					id_getAdNetworkId = JNIEnv.GetMethodID (class_ref, "getAdNetworkId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAdNetworkId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_hasVideoAvailable;
		protected override unsafe bool HasVideoAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='hasVideoAvailable' and count(parameter)=0]"
			[Register ("hasVideoAvailable", "()Z", "GetHasVideoAvailableHandler")]
			get {
				if (id_hasVideoAvailable == IntPtr.Zero)
					id_hasVideoAvailable = JNIEnv.GetMethodID (class_ref, "hasVideoAvailable", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_hasVideoAvailable);
				} finally {
				}
			}
		}

		static IntPtr id_getLifecycleListener;
		protected override unsafe global::Com.Mopub.Common.ILifecycleListener LifecycleListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='getLifecycleListener' and count(parameter)=0]"
			[Register ("getLifecycleListener", "()Lcom/mopub/common/LifecycleListener;", "GetGetLifecycleListenerHandler")]
			get {
				if (id_getLifecycleListener == IntPtr.Zero)
					id_getLifecycleListener = JNIEnv.GetMethodID (class_ref, "getLifecycleListener", "()Lcom/mopub/common/LifecycleListener;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ILifecycleListener> (JNIEnv.CallObjectMethod  (Handle, id_getLifecycleListener), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getVideoListenerForSdk;
		protected override unsafe global::Com.Mopub.Mobileads.CustomEventRewardedVideo.ICustomEventRewardedVideoListener VideoListenerForSdk {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='getVideoListenerForSdk' and count(parameter)=0]"
			[Register ("getVideoListenerForSdk", "()Lcom/mopub/mobileads/CustomEventRewardedVideo$CustomEventRewardedVideoListener;", "GetGetVideoListenerForSdkHandler")]
			get {
				if (id_getVideoListenerForSdk == IntPtr.Zero)
					id_getVideoListenerForSdk = JNIEnv.GetMethodID (class_ref, "getVideoListenerForSdk", "()Lcom/mopub/mobileads/CustomEventRewardedVideo$CustomEventRewardedVideoListener;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventRewardedVideo.ICustomEventRewardedVideoListener> (JNIEnv.CallObjectMethod  (Handle, id_getVideoListenerForSdk), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_checkAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='checkAndInitializeSdk' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.util.Map'] and parameter[3][@type='java.util.Map']]"
		[Register ("checkAndInitializeSdk", "(Landroid/app/Activity;Ljava/util/Map;Ljava/util/Map;)Z", "GetCheckAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_Handler")]
		protected override unsafe bool CheckAndInitializeSdk (global::Android.App.Activity p0, global::System.Collections.IDictionary p1, global::System.Collections.IDictionary p2)
		{
			if (id_checkAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
				id_checkAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "checkAndInitializeSdk", "(Landroid/app/Activity;Ljava/util/Map;Ljava/util/Map;)Z");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_checkAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_loadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='loadWithSdkInitialized' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.util.Map'] and parameter[3][@type='java.util.Map']]"
		[Register ("loadWithSdkInitialized", "(Landroid/app/Activity;Ljava/util/Map;Ljava/util/Map;)V", "GetLoadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_Handler")]
		protected override unsafe void LoadWithSdkInitialized (global::Android.App.Activity p0, global::System.Collections.IDictionary p1, global::System.Collections.IDictionary p2)
		{
			if (id_loadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
				id_loadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "loadWithSdkInitialized", "(Landroid/app/Activity;Ljava/util/Map;Ljava/util/Map;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod  (Handle, id_loadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_onInvalidate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='onInvalidate' and count(parameter)=0]"
		[Register ("onInvalidate", "()V", "GetOnInvalidateHandler")]
		protected override unsafe void OnInvalidate ()
		{
			if (id_onInvalidate == IntPtr.Zero)
				id_onInvalidate = JNIEnv.GetMethodID (class_ref, "onInvalidate", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_onInvalidate);
			} finally {
			}
		}

		static IntPtr id_showVideo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='showVideo' and count(parameter)=0]"
		[Register ("showVideo", "()V", "GetShowVideoHandler")]
		protected override unsafe void ShowVideo ()
		{
			if (id_showVideo == IntPtr.Zero)
				id_showVideo = JNIEnv.GetMethodID (class_ref, "showVideo", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_showVideo);
			} finally {
			}
		}

	}

}
