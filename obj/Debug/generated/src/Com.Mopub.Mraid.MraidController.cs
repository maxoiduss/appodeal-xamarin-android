using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mraid {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidController']"
	[global::Android.Runtime.Register ("com/mopub/mraid/MraidController", DoNotGenerateAcw=true)]
	public partial class MraidController : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidController.MraidListener']"
		[Register ("com/mopub/mraid/MraidController$MraidListener", "", "Com.Mopub.Mraid.MraidController/IMraidListenerInvoker")]
		public partial interface IMraidListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidController.MraidListener']/method[@name='onClose' and count(parameter)=0]"
			[Register ("onClose", "()V", "GetOnCloseHandler:Com.Mopub.Mraid.MraidController/IMraidListenerInvoker, AppodealXamarinPlugin")]
			void OnClose ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidController.MraidListener']/method[@name='onExpand' and count(parameter)=0]"
			[Register ("onExpand", "()V", "GetOnExpandHandler:Com.Mopub.Mraid.MraidController/IMraidListenerInvoker, AppodealXamarinPlugin")]
			void OnExpand ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidController.MraidListener']/method[@name='onFailedToLoad' and count(parameter)=0]"
			[Register ("onFailedToLoad", "()V", "GetOnFailedToLoadHandler:Com.Mopub.Mraid.MraidController/IMraidListenerInvoker, AppodealXamarinPlugin")]
			void OnFailedToLoad ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidController.MraidListener']/method[@name='onLoaded' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("onLoaded", "(Landroid/view/View;)V", "GetOnLoaded_Landroid_view_View_Handler:Com.Mopub.Mraid.MraidController/IMraidListenerInvoker, AppodealXamarinPlugin")]
			void OnLoaded (global::Android.Views.View p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidController.MraidListener']/method[@name='onOpen' and count(parameter)=0]"
			[Register ("onOpen", "()V", "GetOnOpenHandler:Com.Mopub.Mraid.MraidController/IMraidListenerInvoker, AppodealXamarinPlugin")]
			void OnOpen ();

		}

		[global::Android.Runtime.Register ("com/mopub/mraid/MraidController$MraidListener", DoNotGenerateAcw=true)]
		internal class IMraidListenerInvoker : global::Java.Lang.Object, IMraidListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mraid/MraidController$MraidListener");
			IntPtr class_ref;

			public static IMraidListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMraidListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mraid.MraidController.MraidListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMraidListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IMraidListenerInvoker); }
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
				global::Com.Mopub.Mraid.MraidController.IMraidListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidController.IMraidListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static Delegate cb_onExpand;
#pragma warning disable 0169
			static Delegate GetOnExpandHandler ()
			{
				if (cb_onExpand == null)
					cb_onExpand = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnExpand);
				return cb_onExpand;
			}

			static void n_OnExpand (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mraid.MraidController.IMraidListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidController.IMraidListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnExpand ();
			}
#pragma warning restore 0169

			IntPtr id_onExpand;
			public unsafe void OnExpand ()
			{
				if (id_onExpand == IntPtr.Zero)
					id_onExpand = JNIEnv.GetMethodID (class_ref, "onExpand", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onExpand);
			}

			static Delegate cb_onFailedToLoad;
#pragma warning disable 0169
			static Delegate GetOnFailedToLoadHandler ()
			{
				if (cb_onFailedToLoad == null)
					cb_onFailedToLoad = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFailedToLoad);
				return cb_onFailedToLoad;
			}

			static void n_OnFailedToLoad (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mraid.MraidController.IMraidListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidController.IMraidListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnFailedToLoad ();
			}
#pragma warning restore 0169

			IntPtr id_onFailedToLoad;
			public unsafe void OnFailedToLoad ()
			{
				if (id_onFailedToLoad == IntPtr.Zero)
					id_onFailedToLoad = JNIEnv.GetMethodID (class_ref, "onFailedToLoad", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onFailedToLoad);
			}

			static Delegate cb_onLoaded_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetOnLoaded_Landroid_view_View_Handler ()
			{
				if (cb_onLoaded_Landroid_view_View_ == null)
					cb_onLoaded_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLoaded_Landroid_view_View_);
				return cb_onLoaded_Landroid_view_View_;
			}

			static void n_OnLoaded_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mraid.MraidController.IMraidListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidController.IMraidListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLoaded (p0);
			}
#pragma warning restore 0169

			IntPtr id_onLoaded_Landroid_view_View_;
			public unsafe void OnLoaded (global::Android.Views.View p0)
			{
				if (id_onLoaded_Landroid_view_View_ == IntPtr.Zero)
					id_onLoaded_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onLoaded", "(Landroid/view/View;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onLoaded_Landroid_view_View_, __args);
			}

			static Delegate cb_onOpen;
#pragma warning disable 0169
			static Delegate GetOnOpenHandler ()
			{
				if (cb_onOpen == null)
					cb_onOpen = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnOpen);
				return cb_onOpen;
			}

			static void n_OnOpen (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mraid.MraidController.IMraidListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidController.IMraidListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnOpen ();
			}
#pragma warning restore 0169

			IntPtr id_onOpen;
			public unsafe void OnOpen ()
			{
				if (id_onOpen == IntPtr.Zero)
					id_onOpen = JNIEnv.GetMethodID (class_ref, "onOpen", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onOpen);
			}

		}

		public partial class LoadedEventArgs : global::System.EventArgs {

			public LoadedEventArgs (global::Android.Views.View p0)
			{
				this.p0 = p0;
			}

			global::Android.Views.View p0;
			public global::Android.Views.View P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/mraid/MraidController_MraidListenerImplementor")]
		internal sealed partial class IMraidListenerImplementor : global::Java.Lang.Object, IMraidListener {

			object sender;

			public IMraidListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/mraid/MraidController_MraidListenerImplementor", "()V"),
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
			public EventHandler OnExpandHandler;
#pragma warning restore 0649

			public void OnExpand ()
			{
				var __h = OnExpandHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnFailedToLoadHandler;
#pragma warning restore 0649

			public void OnFailedToLoad ()
			{
				var __h = OnFailedToLoadHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<LoadedEventArgs> OnLoadedHandler;
#pragma warning restore 0649

			public void OnLoaded (global::Android.Views.View p0)
			{
				var __h = OnLoadedHandler;
				if (__h != null)
					__h (sender, new LoadedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler OnOpenHandler;
#pragma warning restore 0649

			public void OnOpen ()
			{
				var __h = OnOpenHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IMraidListenerImplementor value)
			{
				return value.OnCloseHandler == null && value.OnExpandHandler == null && value.OnFailedToLoadHandler == null && value.OnLoadedHandler == null && value.OnOpenHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidController.OrientationBroadcastReceiver']"
		[global::Android.Runtime.Register ("com/mopub/mraid/MraidController$OrientationBroadcastReceiver", DoNotGenerateAcw=true)]
		public partial class OrientationBroadcastReceiver : global::Android.Content.BroadcastReceiver {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mraid/MraidController$OrientationBroadcastReceiver", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OrientationBroadcastReceiver); }
			}

			protected OrientationBroadcastReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
			static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler ()
			{
				if (cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
					cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceive_Landroid_content_Context_Landroid_content_Intent_);
				return cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
			}

			static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mopub.Mraid.MraidController.OrientationBroadcastReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidController.OrientationBroadcastReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnReceive (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidController.OrientationBroadcastReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
			[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
			public override unsafe void OnReceive (global::Android.Content.Context p0, global::Android.Content.Intent p1)
			{
				if (id_onReceive_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
					id_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onReceive_Landroid_content_Context_Landroid_content_Intent_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_register_Landroid_content_Context_;
#pragma warning disable 0169
			static Delegate GetRegister_Landroid_content_Context_Handler ()
			{
				if (cb_register_Landroid_content_Context_ == null)
					cb_register_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Register_Landroid_content_Context_);
				return cb_register_Landroid_content_Context_;
			}

			static void n_Register_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mraid.MraidController.OrientationBroadcastReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidController.OrientationBroadcastReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Register (p0);
			}
#pragma warning restore 0169

			static IntPtr id_register_Landroid_content_Context_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidController.OrientationBroadcastReceiver']/method[@name='register' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("register", "(Landroid/content/Context;)V", "GetRegister_Landroid_content_Context_Handler")]
			public virtual unsafe void Register (global::Android.Content.Context p0)
			{
				if (id_register_Landroid_content_Context_ == IntPtr.Zero)
					id_register_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "register", "(Landroid/content/Context;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_register_Landroid_content_Context_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "register", "(Landroid/content/Context;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_unregister;
#pragma warning disable 0169
			static Delegate GetUnregisterHandler ()
			{
				if (cb_unregister == null)
					cb_unregister = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Unregister);
				return cb_unregister;
			}

			static void n_Unregister (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mraid.MraidController.OrientationBroadcastReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidController.OrientationBroadcastReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Unregister ();
			}
#pragma warning restore 0169

			static IntPtr id_unregister;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidController.OrientationBroadcastReceiver']/method[@name='unregister' and count(parameter)=0]"
			[Register ("unregister", "()V", "GetUnregisterHandler")]
			public virtual unsafe void Unregister ()
			{
				if (id_unregister == IntPtr.Zero)
					id_unregister = JNIEnv.GetMethodID (class_ref, "unregister", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_unregister);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregister", "()V"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidController.ScreenMetricsWaiter']"
		[global::Android.Runtime.Register ("com/mopub/mraid/MraidController$ScreenMetricsWaiter", DoNotGenerateAcw=true)]
		public partial class ScreenMetricsWaiter : global::Java.Lang.Object {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidController.ScreenMetricsWaiter.WaitRequest']"
			[global::Android.Runtime.Register ("com/mopub/mraid/MraidController$ScreenMetricsWaiter$WaitRequest", DoNotGenerateAcw=true)]
			public partial class WaitRequest : global::Java.Lang.Object {

				protected WaitRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			}

			protected ScreenMetricsWaiter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidController.UseCustomCloseListener']"
		[Register ("com/mopub/mraid/MraidController$UseCustomCloseListener", "", "Com.Mopub.Mraid.MraidController/IUseCustomCloseListenerInvoker")]
		public partial interface IUseCustomCloseListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidController.UseCustomCloseListener']/method[@name='useCustomCloseChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("useCustomCloseChanged", "(Z)V", "GetUseCustomCloseChanged_ZHandler:Com.Mopub.Mraid.MraidController/IUseCustomCloseListenerInvoker, AppodealXamarinPlugin")]
			void UseCustomCloseChanged (bool p0);

		}

		[global::Android.Runtime.Register ("com/mopub/mraid/MraidController$UseCustomCloseListener", DoNotGenerateAcw=true)]
		internal class IUseCustomCloseListenerInvoker : global::Java.Lang.Object, IUseCustomCloseListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mraid/MraidController$UseCustomCloseListener");
			IntPtr class_ref;

			public static IUseCustomCloseListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IUseCustomCloseListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mraid.MraidController.UseCustomCloseListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IUseCustomCloseListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IUseCustomCloseListenerInvoker); }
			}

			static Delegate cb_useCustomCloseChanged_Z;
#pragma warning disable 0169
			static Delegate GetUseCustomCloseChanged_ZHandler ()
			{
				if (cb_useCustomCloseChanged_Z == null)
					cb_useCustomCloseChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_UseCustomCloseChanged_Z);
				return cb_useCustomCloseChanged_Z;
			}

			static void n_UseCustomCloseChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Mopub.Mraid.MraidController.IUseCustomCloseListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidController.IUseCustomCloseListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.UseCustomCloseChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_useCustomCloseChanged_Z;
			public unsafe void UseCustomCloseChanged (bool p0)
			{
				if (id_useCustomCloseChanged_Z == IntPtr.Zero)
					id_useCustomCloseChanged_Z = JNIEnv.GetMethodID (class_ref, "useCustomCloseChanged", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_useCustomCloseChanged_Z, __args);
			}

		}

		public partial class UseCustomCloseEventArgs : global::System.EventArgs {

			public UseCustomCloseEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/mraid/MraidController_UseCustomCloseListenerImplementor")]
		internal sealed partial class IUseCustomCloseListenerImplementor : global::Java.Lang.Object, IUseCustomCloseListener {

			object sender;

			public IUseCustomCloseListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/mraid/MraidController_UseCustomCloseListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<UseCustomCloseEventArgs> Handler;
#pragma warning restore 0649

			public void UseCustomCloseChanged (bool p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new UseCustomCloseEventArgs (p0));
			}

			internal static bool __IsEmpty (IUseCustomCloseListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mraid/MraidController", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MraidController); }
		}

		protected MraidController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mraid_PlacementType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidController']/constructor[@name='MraidController' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.common.AdReport'] and parameter[3][@type='com.mopub.mraid.PlacementType']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/mopub/common/AdReport;Lcom/mopub/mraid/PlacementType;)V", "")]
		public unsafe MraidController (global::Android.Content.Context p0, global::Com.Mopub.Common.AdReport p1, global::Com.Mopub.Mraid.PlacementType p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (MraidController)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/mopub/common/AdReport;Lcom/mopub/mraid/PlacementType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/mopub/common/AdReport;Lcom/mopub/mraid/PlacementType;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mraid_PlacementType_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mraid_PlacementType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/mopub/common/AdReport;Lcom/mopub/mraid/PlacementType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mraid_PlacementType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mraid_PlacementType_, __args);
			} finally {
			}
		}

		static Delegate cb_getAdContainer;
#pragma warning disable 0169
		static Delegate GetGetAdContainerHandler ()
		{
			if (cb_getAdContainer == null)
				cb_getAdContainer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdContainer);
			return cb_getAdContainer;
		}

		static IntPtr n_GetAdContainer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mraid.MraidController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdContainer);
		}
#pragma warning restore 0169

		static IntPtr id_getAdContainer;
		public virtual unsafe global::Android.Widget.FrameLayout AdContainer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidController']/method[@name='getAdContainer' and count(parameter)=0]"
			[Register ("getAdContainer", "()Landroid/widget/FrameLayout;", "GetGetAdContainerHandler")]
			get {
				if (id_getAdContainer == IntPtr.Zero)
					id_getAdContainer = JNIEnv.GetMethodID (class_ref, "getAdContainer", "()Landroid/widget/FrameLayout;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.FrameLayout> (JNIEnv.CallObjectMethod  (Handle, id_getAdContainer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.FrameLayout> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdContainer", "()Landroid/widget/FrameLayout;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContext);
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mraid.MraidController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		static IntPtr id_getContext;
		public virtual unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidController']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				if (id_getContext == IntPtr.Zero)
					id_getContext = JNIEnv.GetMethodID (class_ref, "getContext", "()Landroid/content/Context;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod  (Handle, id_getContext), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContext", "()Landroid/content/Context;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mraid.MraidController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidController']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_destroy);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroy", "()V"));
			} finally {
			}
		}

		static Delegate cb_loadContent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadContent_Ljava_lang_String_Handler ()
		{
			if (cb_loadContent_Ljava_lang_String_ == null)
				cb_loadContent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadContent_Ljava_lang_String_);
			return cb_loadContent_Ljava_lang_String_;
		}

		static void n_LoadContent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mraid.MraidController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadContent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadContent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidController']/method[@name='loadContent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadContent", "(Ljava/lang/String;)V", "GetLoadContent_Ljava_lang_String_Handler")]
		public virtual unsafe void LoadContent (string p0)
		{
			if (id_loadContent_Ljava_lang_String_ == IntPtr.Zero)
				id_loadContent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadContent", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_loadContent_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadContent", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_loadJavascript_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadJavascript_Ljava_lang_String_Handler ()
		{
			if (cb_loadJavascript_Ljava_lang_String_ == null)
				cb_loadJavascript_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadJavascript_Ljava_lang_String_);
			return cb_loadJavascript_Ljava_lang_String_;
		}

		static void n_LoadJavascript_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mraid.MraidController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadJavascript (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadJavascript_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidController']/method[@name='loadJavascript' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadJavascript", "(Ljava/lang/String;)V", "GetLoadJavascript_Ljava_lang_String_Handler")]
		public virtual unsafe void LoadJavascript (string p0)
		{
			if (id_loadJavascript_Ljava_lang_String_ == IntPtr.Zero)
				id_loadJavascript_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadJavascript", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_loadJavascript_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadJavascript", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_pause_Z;
#pragma warning disable 0169
		static Delegate GetPause_ZHandler ()
		{
			if (cb_pause_Z == null)
				cb_pause_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_Pause_Z);
			return cb_pause_Z;
		}

		static void n_Pause_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mopub.Mraid.MraidController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause (p0);
		}
#pragma warning restore 0169

		static IntPtr id_pause_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidController']/method[@name='pause' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("pause", "(Z)V", "GetPause_ZHandler")]
		public virtual unsafe void Pause (bool p0)
		{
			if (id_pause_Z == IntPtr.Zero)
				id_pause_Z = JNIEnv.GetMethodID (class_ref, "pause", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_pause_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pause", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_resume;
#pragma warning disable 0169
		static Delegate GetResumeHandler ()
		{
			if (cb_resume == null)
				cb_resume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Resume);
			return cb_resume;
		}

		static void n_Resume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mraid.MraidController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		static IntPtr id_resume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidController']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public virtual unsafe void Resume ()
		{
			if (id_resume == IntPtr.Zero)
				id_resume = JNIEnv.GetMethodID (class_ref, "resume", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_resume);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resume", "()V"));
			} finally {
			}
		}

		static Delegate cb_setDebugListener_Lcom_mopub_mraid_MraidWebViewDebugListener_;
#pragma warning disable 0169
		static Delegate GetSetDebugListener_Lcom_mopub_mraid_MraidWebViewDebugListener_Handler ()
		{
			if (cb_setDebugListener_Lcom_mopub_mraid_MraidWebViewDebugListener_ == null)
				cb_setDebugListener_Lcom_mopub_mraid_MraidWebViewDebugListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDebugListener_Lcom_mopub_mraid_MraidWebViewDebugListener_);
			return cb_setDebugListener_Lcom_mopub_mraid_MraidWebViewDebugListener_;
		}

		static void n_SetDebugListener_Lcom_mopub_mraid_MraidWebViewDebugListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mraid.MraidController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mraid.IMraidWebViewDebugListener p0 = (global::Com.Mopub.Mraid.IMraidWebViewDebugListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.IMraidWebViewDebugListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDebugListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDebugListener_Lcom_mopub_mraid_MraidWebViewDebugListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidController']/method[@name='setDebugListener' and count(parameter)=1 and parameter[1][@type='com.mopub.mraid.MraidWebViewDebugListener']]"
		[Register ("setDebugListener", "(Lcom/mopub/mraid/MraidWebViewDebugListener;)V", "GetSetDebugListener_Lcom_mopub_mraid_MraidWebViewDebugListener_Handler")]
		public virtual unsafe void SetDebugListener (global::Com.Mopub.Mraid.IMraidWebViewDebugListener p0)
		{
			if (id_setDebugListener_Lcom_mopub_mraid_MraidWebViewDebugListener_ == IntPtr.Zero)
				id_setDebugListener_Lcom_mopub_mraid_MraidWebViewDebugListener_ = JNIEnv.GetMethodID (class_ref, "setDebugListener", "(Lcom/mopub/mraid/MraidWebViewDebugListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDebugListener_Lcom_mopub_mraid_MraidWebViewDebugListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDebugListener", "(Lcom/mopub/mraid/MraidWebViewDebugListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMraidListener_Lcom_mopub_mraid_MraidController_MraidListener_;
#pragma warning disable 0169
		static Delegate GetSetMraidListener_Lcom_mopub_mraid_MraidController_MraidListener_Handler ()
		{
			if (cb_setMraidListener_Lcom_mopub_mraid_MraidController_MraidListener_ == null)
				cb_setMraidListener_Lcom_mopub_mraid_MraidController_MraidListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMraidListener_Lcom_mopub_mraid_MraidController_MraidListener_);
			return cb_setMraidListener_Lcom_mopub_mraid_MraidController_MraidListener_;
		}

		static void n_SetMraidListener_Lcom_mopub_mraid_MraidController_MraidListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mraid.MraidController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mraid.MraidController.IMraidListener p0 = (global::Com.Mopub.Mraid.MraidController.IMraidListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidController.IMraidListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMraidListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMraidListener_Lcom_mopub_mraid_MraidController_MraidListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidController']/method[@name='setMraidListener' and count(parameter)=1 and parameter[1][@type='com.mopub.mraid.MraidController.MraidListener']]"
		[Register ("setMraidListener", "(Lcom/mopub/mraid/MraidController$MraidListener;)V", "GetSetMraidListener_Lcom_mopub_mraid_MraidController_MraidListener_Handler")]
		public virtual unsafe void SetMraidListener (global::Com.Mopub.Mraid.MraidController.IMraidListener p0)
		{
			if (id_setMraidListener_Lcom_mopub_mraid_MraidController_MraidListener_ == IntPtr.Zero)
				id_setMraidListener_Lcom_mopub_mraid_MraidController_MraidListener_ = JNIEnv.GetMethodID (class_ref, "setMraidListener", "(Lcom/mopub/mraid/MraidController$MraidListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMraidListener_Lcom_mopub_mraid_MraidController_MraidListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMraidListener", "(Lcom/mopub/mraid/MraidController$MraidListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setUseCustomCloseListener_Lcom_mopub_mraid_MraidController_UseCustomCloseListener_;
#pragma warning disable 0169
		static Delegate GetSetUseCustomCloseListener_Lcom_mopub_mraid_MraidController_UseCustomCloseListener_Handler ()
		{
			if (cb_setUseCustomCloseListener_Lcom_mopub_mraid_MraidController_UseCustomCloseListener_ == null)
				cb_setUseCustomCloseListener_Lcom_mopub_mraid_MraidController_UseCustomCloseListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUseCustomCloseListener_Lcom_mopub_mraid_MraidController_UseCustomCloseListener_);
			return cb_setUseCustomCloseListener_Lcom_mopub_mraid_MraidController_UseCustomCloseListener_;
		}

		static void n_SetUseCustomCloseListener_Lcom_mopub_mraid_MraidController_UseCustomCloseListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mraid.MraidController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mraid.MraidController.IUseCustomCloseListener p0 = (global::Com.Mopub.Mraid.MraidController.IUseCustomCloseListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidController.IUseCustomCloseListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetUseCustomCloseListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setUseCustomCloseListener_Lcom_mopub_mraid_MraidController_UseCustomCloseListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidController']/method[@name='setUseCustomCloseListener' and count(parameter)=1 and parameter[1][@type='com.mopub.mraid.MraidController.UseCustomCloseListener']]"
		[Register ("setUseCustomCloseListener", "(Lcom/mopub/mraid/MraidController$UseCustomCloseListener;)V", "GetSetUseCustomCloseListener_Lcom_mopub_mraid_MraidController_UseCustomCloseListener_Handler")]
		public virtual unsafe void SetUseCustomCloseListener (global::Com.Mopub.Mraid.MraidController.IUseCustomCloseListener p0)
		{
			if (id_setUseCustomCloseListener_Lcom_mopub_mraid_MraidController_UseCustomCloseListener_ == IntPtr.Zero)
				id_setUseCustomCloseListener_Lcom_mopub_mraid_MraidController_UseCustomCloseListener_ = JNIEnv.GetMethodID (class_ref, "setUseCustomCloseListener", "(Lcom/mopub/mraid/MraidController$UseCustomCloseListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUseCustomCloseListener_Lcom_mopub_mraid_MraidController_UseCustomCloseListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUseCustomCloseListener", "(Lcom/mopub/mraid/MraidController$UseCustomCloseListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Mopub.Mraid.IMraidWebViewDebugListener"
		public event EventHandler<global::Com.Mopub.Mraid.ConsoleMessageEventArgs> ConsoleMessage {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mraid.IMraidWebViewDebugListener, global::Com.Mopub.Mraid.IMraidWebViewDebugListenerImplementor>(
						ref weak_implementor_SetDebugListener,
						__CreateIMraidWebViewDebugListenerImplementor,
						SetDebugListener,
						__h => __h.OnConsoleMessageHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mraid.IMraidWebViewDebugListener, global::Com.Mopub.Mraid.IMraidWebViewDebugListenerImplementor>(
						ref weak_implementor_SetDebugListener,
						global::Com.Mopub.Mraid.IMraidWebViewDebugListenerImplementor.__IsEmpty,
						__v => SetDebugListener (null),
						__h => __h.OnConsoleMessageHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Mraid.JsAlertEventArgs> JsAlert {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mraid.IMraidWebViewDebugListener, global::Com.Mopub.Mraid.IMraidWebViewDebugListenerImplementor>(
						ref weak_implementor_SetDebugListener,
						__CreateIMraidWebViewDebugListenerImplementor,
						SetDebugListener,
						__h => __h.OnJsAlertHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mraid.IMraidWebViewDebugListener, global::Com.Mopub.Mraid.IMraidWebViewDebugListenerImplementor>(
						ref weak_implementor_SetDebugListener,
						global::Com.Mopub.Mraid.IMraidWebViewDebugListenerImplementor.__IsEmpty,
						__v => SetDebugListener (null),
						__h => __h.OnJsAlertHandler -= value);
			}
		}

		WeakReference weak_implementor_SetDebugListener;

		global::Com.Mopub.Mraid.IMraidWebViewDebugListenerImplementor __CreateIMraidWebViewDebugListenerImplementor ()
		{
			return new global::Com.Mopub.Mraid.IMraidWebViewDebugListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mopub.Mraid.MraidController.IMraidListener"
		public event EventHandler Close {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mraid.MraidController.IMraidListener, global::Com.Mopub.Mraid.MraidController.IMraidListenerImplementor>(
						ref weak_implementor_SetMraidListener,
						__CreateIMraidListenerImplementor,
						SetMraidListener,
						__h => __h.OnCloseHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mraid.MraidController.IMraidListener, global::Com.Mopub.Mraid.MraidController.IMraidListenerImplementor>(
						ref weak_implementor_SetMraidListener,
						global::Com.Mopub.Mraid.MraidController.IMraidListenerImplementor.__IsEmpty,
						__v => SetMraidListener (null),
						__h => __h.OnCloseHandler -= value);
			}
		}

		public event EventHandler Expand {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mraid.MraidController.IMraidListener, global::Com.Mopub.Mraid.MraidController.IMraidListenerImplementor>(
						ref weak_implementor_SetMraidListener,
						__CreateIMraidListenerImplementor,
						SetMraidListener,
						__h => __h.OnExpandHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mraid.MraidController.IMraidListener, global::Com.Mopub.Mraid.MraidController.IMraidListenerImplementor>(
						ref weak_implementor_SetMraidListener,
						global::Com.Mopub.Mraid.MraidController.IMraidListenerImplementor.__IsEmpty,
						__v => SetMraidListener (null),
						__h => __h.OnExpandHandler -= value);
			}
		}

		public event EventHandler FailedToLoad {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mraid.MraidController.IMraidListener, global::Com.Mopub.Mraid.MraidController.IMraidListenerImplementor>(
						ref weak_implementor_SetMraidListener,
						__CreateIMraidListenerImplementor,
						SetMraidListener,
						__h => __h.OnFailedToLoadHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mraid.MraidController.IMraidListener, global::Com.Mopub.Mraid.MraidController.IMraidListenerImplementor>(
						ref weak_implementor_SetMraidListener,
						global::Com.Mopub.Mraid.MraidController.IMraidListenerImplementor.__IsEmpty,
						__v => SetMraidListener (null),
						__h => __h.OnFailedToLoadHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Mraid.MraidController.LoadedEventArgs> Loaded {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mraid.MraidController.IMraidListener, global::Com.Mopub.Mraid.MraidController.IMraidListenerImplementor>(
						ref weak_implementor_SetMraidListener,
						__CreateIMraidListenerImplementor,
						SetMraidListener,
						__h => __h.OnLoadedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mraid.MraidController.IMraidListener, global::Com.Mopub.Mraid.MraidController.IMraidListenerImplementor>(
						ref weak_implementor_SetMraidListener,
						global::Com.Mopub.Mraid.MraidController.IMraidListenerImplementor.__IsEmpty,
						__v => SetMraidListener (null),
						__h => __h.OnLoadedHandler -= value);
			}
		}

		public event EventHandler Open {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mraid.MraidController.IMraidListener, global::Com.Mopub.Mraid.MraidController.IMraidListenerImplementor>(
						ref weak_implementor_SetMraidListener,
						__CreateIMraidListenerImplementor,
						SetMraidListener,
						__h => __h.OnOpenHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mraid.MraidController.IMraidListener, global::Com.Mopub.Mraid.MraidController.IMraidListenerImplementor>(
						ref weak_implementor_SetMraidListener,
						global::Com.Mopub.Mraid.MraidController.IMraidListenerImplementor.__IsEmpty,
						__v => SetMraidListener (null),
						__h => __h.OnOpenHandler -= value);
			}
		}

		WeakReference weak_implementor_SetMraidListener;

		global::Com.Mopub.Mraid.MraidController.IMraidListenerImplementor __CreateIMraidListenerImplementor ()
		{
			return new global::Com.Mopub.Mraid.MraidController.IMraidListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mopub.Mraid.MraidController.IUseCustomCloseListener"
		public event EventHandler<global::Com.Mopub.Mraid.MraidController.UseCustomCloseEventArgs> UseCustomClose {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mraid.MraidController.IUseCustomCloseListener, global::Com.Mopub.Mraid.MraidController.IUseCustomCloseListenerImplementor>(
						ref weak_implementor_SetUseCustomCloseListener,
						__CreateIUseCustomCloseListenerImplementor,
						SetUseCustomCloseListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mraid.MraidController.IUseCustomCloseListener, global::Com.Mopub.Mraid.MraidController.IUseCustomCloseListenerImplementor>(
						ref weak_implementor_SetUseCustomCloseListener,
						global::Com.Mopub.Mraid.MraidController.IUseCustomCloseListenerImplementor.__IsEmpty,
						__v => SetUseCustomCloseListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetUseCustomCloseListener;

		global::Com.Mopub.Mraid.MraidController.IUseCustomCloseListenerImplementor __CreateIUseCustomCloseListenerImplementor ()
		{
			return new global::Com.Mopub.Mraid.MraidController.IUseCustomCloseListenerImplementor (this);
		}
#endregion
	}
}
