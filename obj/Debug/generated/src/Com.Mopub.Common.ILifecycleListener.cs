using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.common']/interface[@name='LifecycleListener']"
	[Register ("com/mopub/common/LifecycleListener", "", "Com.Mopub.Common.ILifecycleListenerInvoker")]
	public partial interface ILifecycleListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/interface[@name='LifecycleListener']/method[@name='onBackPressed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onBackPressed", "(Landroid/app/Activity;)V", "GetOnBackPressed_Landroid_app_Activity_Handler:Com.Mopub.Common.ILifecycleListenerInvoker, AppodealXamarinPlugin")]
		void OnBackPressed (global::Android.App.Activity p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/interface[@name='LifecycleListener']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onCreate", "(Landroid/app/Activity;)V", "GetOnCreate_Landroid_app_Activity_Handler:Com.Mopub.Common.ILifecycleListenerInvoker, AppodealXamarinPlugin")]
		void OnCreate (global::Android.App.Activity p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/interface[@name='LifecycleListener']/method[@name='onDestroy' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onDestroy", "(Landroid/app/Activity;)V", "GetOnDestroy_Landroid_app_Activity_Handler:Com.Mopub.Common.ILifecycleListenerInvoker, AppodealXamarinPlugin")]
		void OnDestroy (global::Android.App.Activity p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/interface[@name='LifecycleListener']/method[@name='onPause' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onPause", "(Landroid/app/Activity;)V", "GetOnPause_Landroid_app_Activity_Handler:Com.Mopub.Common.ILifecycleListenerInvoker, AppodealXamarinPlugin")]
		void OnPause (global::Android.App.Activity p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/interface[@name='LifecycleListener']/method[@name='onRestart' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onRestart", "(Landroid/app/Activity;)V", "GetOnRestart_Landroid_app_Activity_Handler:Com.Mopub.Common.ILifecycleListenerInvoker, AppodealXamarinPlugin")]
		void OnRestart (global::Android.App.Activity p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/interface[@name='LifecycleListener']/method[@name='onResume' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onResume", "(Landroid/app/Activity;)V", "GetOnResume_Landroid_app_Activity_Handler:Com.Mopub.Common.ILifecycleListenerInvoker, AppodealXamarinPlugin")]
		void OnResume (global::Android.App.Activity p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/interface[@name='LifecycleListener']/method[@name='onStart' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onStart", "(Landroid/app/Activity;)V", "GetOnStart_Landroid_app_Activity_Handler:Com.Mopub.Common.ILifecycleListenerInvoker, AppodealXamarinPlugin")]
		void OnStart (global::Android.App.Activity p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/interface[@name='LifecycleListener']/method[@name='onStop' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onStop", "(Landroid/app/Activity;)V", "GetOnStop_Landroid_app_Activity_Handler:Com.Mopub.Common.ILifecycleListenerInvoker, AppodealXamarinPlugin")]
		void OnStop (global::Android.App.Activity p0);

	}

	[global::Android.Runtime.Register ("com/mopub/common/LifecycleListener", DoNotGenerateAcw=true)]
	internal class ILifecycleListenerInvoker : global::Java.Lang.Object, ILifecycleListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/common/LifecycleListener");
		IntPtr class_ref;

		public static ILifecycleListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILifecycleListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mopub.common.LifecycleListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILifecycleListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILifecycleListenerInvoker); }
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
			global::Com.Mopub.Common.ILifecycleListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ILifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBackPressed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBackPressed_Landroid_app_Activity_;
		public unsafe void OnBackPressed (global::Android.App.Activity p0)
		{
			if (id_onBackPressed_Landroid_app_Activity_ == IntPtr.Zero)
				id_onBackPressed_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onBackPressed", "(Landroid/app/Activity;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onBackPressed_Landroid_app_Activity_, __args);
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
			global::Com.Mopub.Common.ILifecycleListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ILifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCreate_Landroid_app_Activity_;
		public unsafe void OnCreate (global::Android.App.Activity p0)
		{
			if (id_onCreate_Landroid_app_Activity_ == IntPtr.Zero)
				id_onCreate_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/app/Activity;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onCreate_Landroid_app_Activity_, __args);
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
			global::Com.Mopub.Common.ILifecycleListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ILifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDestroy_Landroid_app_Activity_;
		public unsafe void OnDestroy (global::Android.App.Activity p0)
		{
			if (id_onDestroy_Landroid_app_Activity_ == IntPtr.Zero)
				id_onDestroy_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onDestroy", "(Landroid/app/Activity;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onDestroy_Landroid_app_Activity_, __args);
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
			global::Com.Mopub.Common.ILifecycleListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ILifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPause (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPause_Landroid_app_Activity_;
		public unsafe void OnPause (global::Android.App.Activity p0)
		{
			if (id_onPause_Landroid_app_Activity_ == IntPtr.Zero)
				id_onPause_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onPause", "(Landroid/app/Activity;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onPause_Landroid_app_Activity_, __args);
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
			global::Com.Mopub.Common.ILifecycleListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ILifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRestart (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRestart_Landroid_app_Activity_;
		public unsafe void OnRestart (global::Android.App.Activity p0)
		{
			if (id_onRestart_Landroid_app_Activity_ == IntPtr.Zero)
				id_onRestart_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onRestart", "(Landroid/app/Activity;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onRestart_Landroid_app_Activity_, __args);
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
			global::Com.Mopub.Common.ILifecycleListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ILifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResume (p0);
		}
#pragma warning restore 0169

		IntPtr id_onResume_Landroid_app_Activity_;
		public unsafe void OnResume (global::Android.App.Activity p0)
		{
			if (id_onResume_Landroid_app_Activity_ == IntPtr.Zero)
				id_onResume_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onResume", "(Landroid/app/Activity;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onResume_Landroid_app_Activity_, __args);
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
			global::Com.Mopub.Common.ILifecycleListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ILifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStart (p0);
		}
#pragma warning restore 0169

		IntPtr id_onStart_Landroid_app_Activity_;
		public unsafe void OnStart (global::Android.App.Activity p0)
		{
			if (id_onStart_Landroid_app_Activity_ == IntPtr.Zero)
				id_onStart_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onStart", "(Landroid/app/Activity;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onStart_Landroid_app_Activity_, __args);
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
			global::Com.Mopub.Common.ILifecycleListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.ILifecycleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStop (p0);
		}
#pragma warning restore 0169

		IntPtr id_onStop_Landroid_app_Activity_;
		public unsafe void OnStop (global::Android.App.Activity p0)
		{
			if (id_onStop_Landroid_app_Activity_ == IntPtr.Zero)
				id_onStop_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onStop", "(Landroid/app/Activity;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onStop_Landroid_app_Activity_, __args);
		}

	}

	public partial class BackPressedEventArgs : global::System.EventArgs {

		public BackPressedEventArgs (global::Android.App.Activity p0)
		{
			this.p0 = p0;
		}

		global::Android.App.Activity p0;
		public global::Android.App.Activity P0 {
			get { return p0; }
		}
	}

	public partial class CreateEventArgs : global::System.EventArgs {

		public CreateEventArgs (global::Android.App.Activity p0)
		{
			this.p0 = p0;
		}

		global::Android.App.Activity p0;
		public global::Android.App.Activity P0 {
			get { return p0; }
		}
	}

	public partial class DestroyEventArgs : global::System.EventArgs {

		public DestroyEventArgs (global::Android.App.Activity p0)
		{
			this.p0 = p0;
		}

		global::Android.App.Activity p0;
		public global::Android.App.Activity P0 {
			get { return p0; }
		}
	}

	public partial class PauseEventArgs : global::System.EventArgs {

		public PauseEventArgs (global::Android.App.Activity p0)
		{
			this.p0 = p0;
		}

		global::Android.App.Activity p0;
		public global::Android.App.Activity P0 {
			get { return p0; }
		}
	}

	public partial class RestartEventArgs : global::System.EventArgs {

		public RestartEventArgs (global::Android.App.Activity p0)
		{
			this.p0 = p0;
		}

		global::Android.App.Activity p0;
		public global::Android.App.Activity P0 {
			get { return p0; }
		}
	}

	public partial class ResumeEventArgs : global::System.EventArgs {

		public ResumeEventArgs (global::Android.App.Activity p0)
		{
			this.p0 = p0;
		}

		global::Android.App.Activity p0;
		public global::Android.App.Activity P0 {
			get { return p0; }
		}
	}

	public partial class StartEventArgs : global::System.EventArgs {

		public StartEventArgs (global::Android.App.Activity p0)
		{
			this.p0 = p0;
		}

		global::Android.App.Activity p0;
		public global::Android.App.Activity P0 {
			get { return p0; }
		}
	}

	public partial class StopEventArgs : global::System.EventArgs {

		public StopEventArgs (global::Android.App.Activity p0)
		{
			this.p0 = p0;
		}

		global::Android.App.Activity p0;
		public global::Android.App.Activity P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mopub/common/LifecycleListenerImplementor")]
	internal sealed partial class ILifecycleListenerImplementor : global::Java.Lang.Object, ILifecycleListener {

		object sender;

		public ILifecycleListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/common/LifecycleListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BackPressedEventArgs> OnBackPressedHandler;
#pragma warning restore 0649

		public void OnBackPressed (global::Android.App.Activity p0)
		{
			var __h = OnBackPressedHandler;
			if (__h != null)
				__h (sender, new BackPressedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<CreateEventArgs> OnCreateHandler;
#pragma warning restore 0649

		public void OnCreate (global::Android.App.Activity p0)
		{
			var __h = OnCreateHandler;
			if (__h != null)
				__h (sender, new CreateEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<DestroyEventArgs> OnDestroyHandler;
#pragma warning restore 0649

		public void OnDestroy (global::Android.App.Activity p0)
		{
			var __h = OnDestroyHandler;
			if (__h != null)
				__h (sender, new DestroyEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<PauseEventArgs> OnPauseHandler;
#pragma warning restore 0649

		public void OnPause (global::Android.App.Activity p0)
		{
			var __h = OnPauseHandler;
			if (__h != null)
				__h (sender, new PauseEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<RestartEventArgs> OnRestartHandler;
#pragma warning restore 0649

		public void OnRestart (global::Android.App.Activity p0)
		{
			var __h = OnRestartHandler;
			if (__h != null)
				__h (sender, new RestartEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<ResumeEventArgs> OnResumeHandler;
#pragma warning restore 0649

		public void OnResume (global::Android.App.Activity p0)
		{
			var __h = OnResumeHandler;
			if (__h != null)
				__h (sender, new ResumeEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<StartEventArgs> OnStartHandler;
#pragma warning restore 0649

		public void OnStart (global::Android.App.Activity p0)
		{
			var __h = OnStartHandler;
			if (__h != null)
				__h (sender, new StartEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<StopEventArgs> OnStopHandler;
#pragma warning restore 0649

		public void OnStop (global::Android.App.Activity p0)
		{
			var __h = OnStopHandler;
			if (__h != null)
				__h (sender, new StopEventArgs (p0));
		}

		internal static bool __IsEmpty (ILifecycleListenerImplementor value)
		{
			return value.OnBackPressedHandler == null && value.OnCreateHandler == null && value.OnDestroyHandler == null && value.OnPauseHandler == null && value.OnRestartHandler == null && value.OnResumeHandler == null && value.OnStartHandler == null && value.OnStopHandler == null;
		}
	}

}
