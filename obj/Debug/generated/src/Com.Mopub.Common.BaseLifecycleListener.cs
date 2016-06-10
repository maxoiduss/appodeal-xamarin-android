using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseLifecycleListener']"
	[global::Android.Runtime.Register ("com/mopub/common/BaseLifecycleListener", DoNotGenerateAcw=true)]
	public partial class BaseLifecycleListener : global::Java.Lang.Object, global::Com.Mopub.Common.ILifecycleListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/BaseLifecycleListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseLifecycleListener); }
		}

		protected BaseLifecycleListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseLifecycleListener']/constructor[@name='BaseLifecycleListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseLifecycleListener ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BaseLifecycleListener)) {
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

		static Delegate cb_onBackPressed_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnBackPressed_Landroid_app_Activity_Handler ()
		{
			if (cb_onBackPressed_Landroid_app_Activity_ == null)
				cb_onBackPressed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBackPressed_Landroid_app_Activity_);
			return cb_onBackPressed_Landroid_app_Activity_;
		}

		static void n_OnBackPressed_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.BaseLifecycleListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.BaseLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBackPressed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onBackPressed_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseLifecycleListener']/method[@name='onBackPressed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onBackPressed", "(Landroid/app/Activity;)V", "GetOnBackPressed_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnBackPressed (global::Android.App.Activity p0)
		{
			if (id_onBackPressed_Landroid_app_Activity_ == IntPtr.Zero)
				id_onBackPressed_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onBackPressed", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onBackPressed_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBackPressed", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onCreate_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_app_Activity_Handler ()
		{
			if (cb_onCreate_Landroid_app_Activity_ == null)
				cb_onCreate_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_app_Activity_);
			return cb_onCreate_Landroid_app_Activity_;
		}

		static void n_OnCreate_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.BaseLifecycleListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.BaseLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCreate_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseLifecycleListener']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onCreate", "(Landroid/app/Activity;)V", "GetOnCreate_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnCreate (global::Android.App.Activity p0)
		{
			if (id_onCreate_Landroid_app_Activity_ == IntPtr.Zero)
				id_onCreate_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCreate_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onDestroy_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnDestroy_Landroid_app_Activity_Handler ()
		{
			if (cb_onDestroy_Landroid_app_Activity_ == null)
				cb_onDestroy_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDestroy_Landroid_app_Activity_);
			return cb_onDestroy_Landroid_app_Activity_;
		}

		static void n_OnDestroy_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.BaseLifecycleListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.BaseLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onDestroy_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseLifecycleListener']/method[@name='onDestroy' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onDestroy", "(Landroid/app/Activity;)V", "GetOnDestroy_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnDestroy (global::Android.App.Activity p0)
		{
			if (id_onDestroy_Landroid_app_Activity_ == IntPtr.Zero)
				id_onDestroy_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onDestroy", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDestroy_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDestroy", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onPause_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnPause_Landroid_app_Activity_Handler ()
		{
			if (cb_onPause_Landroid_app_Activity_ == null)
				cb_onPause_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPause_Landroid_app_Activity_);
			return cb_onPause_Landroid_app_Activity_;
		}

		static void n_OnPause_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.BaseLifecycleListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.BaseLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPause (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPause_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseLifecycleListener']/method[@name='onPause' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onPause", "(Landroid/app/Activity;)V", "GetOnPause_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnPause (global::Android.App.Activity p0)
		{
			if (id_onPause_Landroid_app_Activity_ == IntPtr.Zero)
				id_onPause_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onPause", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onPause_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPause", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onRestart_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnRestart_Landroid_app_Activity_Handler ()
		{
			if (cb_onRestart_Landroid_app_Activity_ == null)
				cb_onRestart_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRestart_Landroid_app_Activity_);
			return cb_onRestart_Landroid_app_Activity_;
		}

		static void n_OnRestart_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.BaseLifecycleListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.BaseLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRestart (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRestart_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseLifecycleListener']/method[@name='onRestart' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onRestart", "(Landroid/app/Activity;)V", "GetOnRestart_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnRestart (global::Android.App.Activity p0)
		{
			if (id_onRestart_Landroid_app_Activity_ == IntPtr.Zero)
				id_onRestart_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onRestart", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onRestart_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRestart", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onResume_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnResume_Landroid_app_Activity_Handler ()
		{
			if (cb_onResume_Landroid_app_Activity_ == null)
				cb_onResume_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResume_Landroid_app_Activity_);
			return cb_onResume_Landroid_app_Activity_;
		}

		static void n_OnResume_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.BaseLifecycleListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.BaseLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResume (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onResume_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseLifecycleListener']/method[@name='onResume' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onResume", "(Landroid/app/Activity;)V", "GetOnResume_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnResume (global::Android.App.Activity p0)
		{
			if (id_onResume_Landroid_app_Activity_ == IntPtr.Zero)
				id_onResume_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onResume", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onResume_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResume", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onStart_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnStart_Landroid_app_Activity_Handler ()
		{
			if (cb_onStart_Landroid_app_Activity_ == null)
				cb_onStart_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStart_Landroid_app_Activity_);
			return cb_onStart_Landroid_app_Activity_;
		}

		static void n_OnStart_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.BaseLifecycleListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.BaseLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStart (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onStart_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseLifecycleListener']/method[@name='onStart' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onStart", "(Landroid/app/Activity;)V", "GetOnStart_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnStart (global::Android.App.Activity p0)
		{
			if (id_onStart_Landroid_app_Activity_ == IntPtr.Zero)
				id_onStart_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onStart", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onStart_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStart", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onStop_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnStop_Landroid_app_Activity_Handler ()
		{
			if (cb_onStop_Landroid_app_Activity_ == null)
				cb_onStop_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStop_Landroid_app_Activity_);
			return cb_onStop_Landroid_app_Activity_;
		}

		static void n_OnStop_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Common.BaseLifecycleListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.BaseLifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStop (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onStop_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='BaseLifecycleListener']/method[@name='onStop' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onStop", "(Landroid/app/Activity;)V", "GetOnStop_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnStop (global::Android.App.Activity p0)
		{
			if (id_onStop_Landroid_app_Activity_ == IntPtr.Zero)
				id_onStop_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onStop", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onStop_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStop", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

	}
}
