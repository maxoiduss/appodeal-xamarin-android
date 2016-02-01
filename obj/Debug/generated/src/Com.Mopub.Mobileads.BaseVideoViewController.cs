using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoViewController']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/BaseVideoViewController", DoNotGenerateAcw=true)]
	public abstract partial class BaseVideoViewController : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='BaseVideoViewController.BaseVideoViewControllerListener']"
		[Register ("com/mopub/mobileads/BaseVideoViewController$BaseVideoViewControllerListener", "", "Com.Mopub.Mobileads.BaseVideoViewController/IBaseVideoViewControllerListenerInvoker")]
		public partial interface IBaseVideoViewControllerListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='BaseVideoViewController.BaseVideoViewControllerListener']/method[@name='onFinish' and count(parameter)=0]"
			[Register ("onFinish", "()V", "GetOnFinishHandler:Com.Mopub.Mobileads.BaseVideoViewController/IBaseVideoViewControllerListenerInvoker, AppodealXamarinPlugin")]
			void OnFinish ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='BaseVideoViewController.BaseVideoViewControllerListener']/method[@name='onSetContentView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("onSetContentView", "(Landroid/view/View;)V", "GetOnSetContentView_Landroid_view_View_Handler:Com.Mopub.Mobileads.BaseVideoViewController/IBaseVideoViewControllerListenerInvoker, AppodealXamarinPlugin")]
			void OnSetContentView (global::Android.Views.View p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='BaseVideoViewController.BaseVideoViewControllerListener']/method[@name='onSetRequestedOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onSetRequestedOrientation", "(I)V", "GetOnSetRequestedOrientation_IHandler:Com.Mopub.Mobileads.BaseVideoViewController/IBaseVideoViewControllerListenerInvoker, AppodealXamarinPlugin")]
			void OnSetRequestedOrientation (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='BaseVideoViewController.BaseVideoViewControllerListener']/method[@name='onStartActivityForResult' and count(parameter)=3 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='int'] and parameter[3][@type='android.os.Bundle']]"
			[Register ("onStartActivityForResult", "(Ljava/lang/Class;ILandroid/os/Bundle;)V", "GetOnStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_Handler:Com.Mopub.Mobileads.BaseVideoViewController/IBaseVideoViewControllerListenerInvoker, AppodealXamarinPlugin")]
			void OnStartActivityForResult (global::Java.Lang.Class p0, int p1, global::Android.OS.Bundle p2);

		}

		[global::Android.Runtime.Register ("com/mopub/mobileads/BaseVideoViewController$BaseVideoViewControllerListener", DoNotGenerateAcw=true)]
		internal class IBaseVideoViewControllerListenerInvoker : global::Java.Lang.Object, IBaseVideoViewControllerListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/BaseVideoViewController$BaseVideoViewControllerListener");
			IntPtr class_ref;

			public static IBaseVideoViewControllerListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBaseVideoViewControllerListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.BaseVideoViewController.BaseVideoViewControllerListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBaseVideoViewControllerListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IBaseVideoViewControllerListenerInvoker); }
			}

			static Delegate cb_onFinish;
#pragma warning disable 0169
			static Delegate GetOnFinishHandler ()
			{
				if (cb_onFinish == null)
					cb_onFinish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFinish);
				return cb_onFinish;
			}

			static void n_OnFinish (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.BaseVideoViewController.IBaseVideoViewControllerListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseVideoViewController.IBaseVideoViewControllerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnFinish ();
			}
#pragma warning restore 0169

			IntPtr id_onFinish;
			public unsafe void OnFinish ()
			{
				if (id_onFinish == IntPtr.Zero)
					id_onFinish = JNIEnv.GetMethodID (class_ref, "onFinish", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onFinish);
			}

			static Delegate cb_onSetContentView_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetOnSetContentView_Landroid_view_View_Handler ()
			{
				if (cb_onSetContentView_Landroid_view_View_ == null)
					cb_onSetContentView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSetContentView_Landroid_view_View_);
				return cb_onSetContentView_Landroid_view_View_;
			}

			static void n_OnSetContentView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.BaseVideoViewController.IBaseVideoViewControllerListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseVideoViewController.IBaseVideoViewControllerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSetContentView (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSetContentView_Landroid_view_View_;
			public unsafe void OnSetContentView (global::Android.Views.View p0)
			{
				if (id_onSetContentView_Landroid_view_View_ == IntPtr.Zero)
					id_onSetContentView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onSetContentView", "(Landroid/view/View;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onSetContentView_Landroid_view_View_, __args);
			}

			static Delegate cb_onSetRequestedOrientation_I;
#pragma warning disable 0169
			static Delegate GetOnSetRequestedOrientation_IHandler ()
			{
				if (cb_onSetRequestedOrientation_I == null)
					cb_onSetRequestedOrientation_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnSetRequestedOrientation_I);
				return cb_onSetRequestedOrientation_I;
			}

			static void n_OnSetRequestedOrientation_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Mopub.Mobileads.BaseVideoViewController.IBaseVideoViewControllerListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseVideoViewController.IBaseVideoViewControllerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnSetRequestedOrientation (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSetRequestedOrientation_I;
			public unsafe void OnSetRequestedOrientation (int p0)
			{
				if (id_onSetRequestedOrientation_I == IntPtr.Zero)
					id_onSetRequestedOrientation_I = JNIEnv.GetMethodID (class_ref, "onSetRequestedOrientation", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onSetRequestedOrientation_I, __args);
			}

			static Delegate cb_onStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetOnStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_Handler ()
			{
				if (cb_onStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_ == null)
					cb_onStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_);
				return cb_onStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_;
			}

			static void n_OnStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
			{
				global::Com.Mopub.Mobileads.BaseVideoViewController.IBaseVideoViewControllerListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseVideoViewController.IBaseVideoViewControllerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnStartActivityForResult (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_;
			public unsafe void OnStartActivityForResult (global::Java.Lang.Class p0, int p1, global::Android.OS.Bundle p2)
			{
				if (id_onStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_ == IntPtr.Zero)
					id_onStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onStartActivityForResult", "(Ljava/lang/Class;ILandroid/os/Bundle;)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (Handle, id_onStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_, __args);
			}

		}

		public partial class SetContentViewEventArgs : global::System.EventArgs {

			public SetContentViewEventArgs (global::Android.Views.View p0)
			{
				this.p0 = p0;
			}

			global::Android.Views.View p0;
			public global::Android.Views.View P0 {
				get { return p0; }
			}
		}

		public partial class SetRequestedOrientationEventArgs : global::System.EventArgs {

			public SetRequestedOrientationEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		public partial class StartActivityForResultEventArgs : global::System.EventArgs {

			public StartActivityForResultEventArgs (global::Java.Lang.Class p0, int p1, global::Android.OS.Bundle p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Java.Lang.Class p0;
			public global::Java.Lang.Class P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}

			global::Android.OS.Bundle p2;
			public global::Android.OS.Bundle P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/mobileads/BaseVideoViewController_BaseVideoViewControllerListenerImplementor")]
		internal sealed partial class IBaseVideoViewControllerListenerImplementor : global::Java.Lang.Object, IBaseVideoViewControllerListener {

			object sender;

			public IBaseVideoViewControllerListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/mobileads/BaseVideoViewController_BaseVideoViewControllerListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnFinishHandler;
#pragma warning restore 0649

			public void OnFinish ()
			{
				var __h = OnFinishHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<SetContentViewEventArgs> OnSetContentViewHandler;
#pragma warning restore 0649

			public void OnSetContentView (global::Android.Views.View p0)
			{
				var __h = OnSetContentViewHandler;
				if (__h != null)
					__h (sender, new SetContentViewEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<SetRequestedOrientationEventArgs> OnSetRequestedOrientationHandler;
#pragma warning restore 0649

			public void OnSetRequestedOrientation (int p0)
			{
				var __h = OnSetRequestedOrientationHandler;
				if (__h != null)
					__h (sender, new SetRequestedOrientationEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<StartActivityForResultEventArgs> OnStartActivityForResultHandler;
#pragma warning restore 0649

			public void OnStartActivityForResult (global::Java.Lang.Class p0, int p1, global::Android.OS.Bundle p2)
			{
				var __h = OnStartActivityForResultHandler;
				if (__h != null)
					__h (sender, new StartActivityForResultEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IBaseVideoViewControllerListenerImplementor value)
			{
				return value.OnFinishHandler == null && value.OnSetContentViewHandler == null && value.OnSetRequestedOrientationHandler == null && value.OnStartActivityForResultHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/BaseVideoViewController", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseVideoViewController); }
		}

		protected BaseVideoViewController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_Long_Lcom_mopub_mobileads_BaseVideoViewController_BaseVideoViewControllerListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoViewController']/constructor[@name='BaseVideoViewController' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='com.mopub.mobileads.BaseVideoViewController.BaseVideoViewControllerListener']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/Long;Lcom/mopub/mobileads/BaseVideoViewController$BaseVideoViewControllerListener;)V", "")]
		protected unsafe BaseVideoViewController (global::Android.Content.Context p0, global::Java.Lang.Long p1, global::Com.Mopub.Mobileads.BaseVideoViewController.IBaseVideoViewControllerListener p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (BaseVideoViewController)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/Long;Lcom/mopub/mobileads/BaseVideoViewController$BaseVideoViewControllerListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/Long;Lcom/mopub/mobileads/BaseVideoViewController$BaseVideoViewControllerListener;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_Long_Lcom_mopub_mobileads_BaseVideoViewController_BaseVideoViewControllerListener_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_Long_Lcom_mopub_mobileads_BaseVideoViewController_BaseVideoViewControllerListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/Long;Lcom/mopub/mobileads/BaseVideoViewController$BaseVideoViewControllerListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_Long_Lcom_mopub_mobileads_BaseVideoViewController_BaseVideoViewControllerListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_Long_Lcom_mopub_mobileads_BaseVideoViewController_BaseVideoViewControllerListener_, __args);
			} finally {
			}
		}

		static Delegate cb_getBaseVideoViewControllerListener;
#pragma warning disable 0169
		static Delegate GetGetBaseVideoViewControllerListenerHandler ()
		{
			if (cb_getBaseVideoViewControllerListener == null)
				cb_getBaseVideoViewControllerListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBaseVideoViewControllerListener);
			return cb_getBaseVideoViewControllerListener;
		}

		static IntPtr n_GetBaseVideoViewControllerListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.BaseVideoViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseVideoViewController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BaseVideoViewControllerListener);
		}
#pragma warning restore 0169

		static IntPtr id_getBaseVideoViewControllerListener;
		protected virtual unsafe global::Com.Mopub.Mobileads.BaseVideoViewController.IBaseVideoViewControllerListener BaseVideoViewControllerListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoViewController']/method[@name='getBaseVideoViewControllerListener' and count(parameter)=0]"
			[Register ("getBaseVideoViewControllerListener", "()Lcom/mopub/mobileads/BaseVideoViewController$BaseVideoViewControllerListener;", "GetGetBaseVideoViewControllerListenerHandler")]
			get {
				if (id_getBaseVideoViewControllerListener == IntPtr.Zero)
					id_getBaseVideoViewControllerListener = JNIEnv.GetMethodID (class_ref, "getBaseVideoViewControllerListener", "()Lcom/mopub/mobileads/BaseVideoViewController$BaseVideoViewControllerListener;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseVideoViewController.IBaseVideoViewControllerListener> (JNIEnv.CallObjectMethod  (Handle, id_getBaseVideoViewControllerListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseVideoViewController.IBaseVideoViewControllerListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBaseVideoViewControllerListener", "()Lcom/mopub/mobileads/BaseVideoViewController$BaseVideoViewControllerListener;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mopub.Mobileads.BaseVideoViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseVideoViewController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		static IntPtr id_getContext;
		protected virtual unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoViewController']/method[@name='getContext' and count(parameter)=0]"
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

		static Delegate cb_getLayout;
#pragma warning disable 0169
		static Delegate GetGetLayoutHandler ()
		{
			if (cb_getLayout == null)
				cb_getLayout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLayout);
			return cb_getLayout;
		}

		static IntPtr n_GetLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.BaseVideoViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseVideoViewController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Layout);
		}
#pragma warning restore 0169

		static IntPtr id_getLayout;
		public virtual unsafe global::Android.Views.ViewGroup Layout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoViewController']/method[@name='getLayout' and count(parameter)=0]"
			[Register ("getLayout", "()Landroid/view/ViewGroup;", "GetGetLayoutHandler")]
			get {
				if (id_getLayout == IntPtr.Zero)
					id_getLayout = JNIEnv.GetMethodID (class_ref, "getLayout", "()Landroid/view/ViewGroup;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (JNIEnv.CallObjectMethod  (Handle, id_getLayout), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLayout", "()Landroid/view/ViewGroup;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoView;
#pragma warning disable 0169
		static Delegate GetGetVideoViewHandler ()
		{
			if (cb_getVideoView == null)
				cb_getVideoView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVideoView);
			return cb_getVideoView;
		}

		static IntPtr n_GetVideoView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.BaseVideoViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseVideoViewController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VideoView);
		}
#pragma warning restore 0169

		protected abstract global::Android.Widget.VideoView VideoView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoViewController']/method[@name='getVideoView' and count(parameter)=0]"
			[Register ("getVideoView", "()Landroid/widget/VideoView;", "GetGetVideoViewHandler")] get;
		}

		static Delegate cb_backButtonEnabled;
#pragma warning disable 0169
		static Delegate GetBackButtonEnabledHandler ()
		{
			if (cb_backButtonEnabled == null)
				cb_backButtonEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_BackButtonEnabled);
			return cb_backButtonEnabled;
		}

		static bool n_BackButtonEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.BaseVideoViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseVideoViewController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BackButtonEnabled ();
		}
#pragma warning restore 0169

		static IntPtr id_backButtonEnabled;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoViewController']/method[@name='backButtonEnabled' and count(parameter)=0]"
		[Register ("backButtonEnabled", "()Z", "GetBackButtonEnabledHandler")]
		public virtual unsafe bool BackButtonEnabled ()
		{
			if (id_backButtonEnabled == IntPtr.Zero)
				id_backButtonEnabled = JNIEnv.GetMethodID (class_ref, "backButtonEnabled", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_backButtonEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "backButtonEnabled", "()Z"));
			} finally {
			}
		}

		static Delegate cb_onConfigurationChanged_Landroid_content_res_Configuration_;
#pragma warning disable 0169
		static Delegate GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler ()
		{
			if (cb_onConfigurationChanged_Landroid_content_res_Configuration_ == null)
				cb_onConfigurationChanged_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConfigurationChanged_Landroid_content_res_Configuration_);
			return cb_onConfigurationChanged_Landroid_content_res_Configuration_;
		}

		static void n_OnConfigurationChanged_Landroid_content_res_Configuration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.BaseVideoViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseVideoViewController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.Configuration p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Configuration> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConfigurationChanged (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoViewController']/method[@name='onConfigurationChanged' and count(parameter)=1 and parameter[1][@type='android.content.res.Configuration']]"
		[Register ("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", "GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler")]
		protected abstract void OnConfigurationChanged (global::Android.Content.Res.Configuration p0);

		static Delegate cb_onCreate;
#pragma warning disable 0169
		static Delegate GetOnCreateHandler ()
		{
			if (cb_onCreate == null)
				cb_onCreate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCreate);
			return cb_onCreate;
		}

		static void n_OnCreate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.BaseVideoViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseVideoViewController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate ();
		}
#pragma warning restore 0169

		static IntPtr id_onCreate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoViewController']/method[@name='onCreate' and count(parameter)=0]"
		[Register ("onCreate", "()V", "GetOnCreateHandler")]
		protected virtual unsafe void OnCreate ()
		{
			if (id_onCreate == IntPtr.Zero)
				id_onCreate = JNIEnv.GetMethodID (class_ref, "onCreate", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCreate);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "()V"));
			} finally {
			}
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.BaseVideoViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseVideoViewController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoViewController']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		protected abstract void OnDestroy ();

		static Delegate cb_onPause;
#pragma warning disable 0169
		static Delegate GetOnPauseHandler ()
		{
			if (cb_onPause == null)
				cb_onPause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPause);
			return cb_onPause;
		}

		static void n_OnPause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.BaseVideoViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseVideoViewController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoViewController']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler")]
		protected abstract void OnPause ();

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResume);
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.BaseVideoViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseVideoViewController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoViewController']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler")]
		protected abstract void OnResume ();

		static Delegate cb_onSaveInstanceState_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnSaveInstanceState_Landroid_os_Bundle_Handler ()
		{
			if (cb_onSaveInstanceState_Landroid_os_Bundle_ == null)
				cb_onSaveInstanceState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSaveInstanceState_Landroid_os_Bundle_);
			return cb_onSaveInstanceState_Landroid_os_Bundle_;
		}

		static void n_OnSaveInstanceState_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.BaseVideoViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseVideoViewController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSaveInstanceState (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoViewController']/method[@name='onSaveInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onSaveInstanceState", "(Landroid/os/Bundle;)V", "GetOnSaveInstanceState_Landroid_os_Bundle_Handler")]
		protected abstract void OnSaveInstanceState (global::Android.OS.Bundle p0);

		static Delegate cb_videoCompleted_Z;
#pragma warning disable 0169
		static Delegate GetVideoCompleted_ZHandler ()
		{
			if (cb_videoCompleted_Z == null)
				cb_videoCompleted_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_VideoCompleted_Z);
			return cb_videoCompleted_Z;
		}

		static void n_VideoCompleted_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mopub.Mobileads.BaseVideoViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseVideoViewController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VideoCompleted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_videoCompleted_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoViewController']/method[@name='videoCompleted' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("videoCompleted", "(Z)V", "GetVideoCompleted_ZHandler")]
		protected virtual unsafe void VideoCompleted (bool p0)
		{
			if (id_videoCompleted_Z == IntPtr.Zero)
				id_videoCompleted_Z = JNIEnv.GetMethodID (class_ref, "videoCompleted", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_videoCompleted_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "videoCompleted", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_videoError_Z;
#pragma warning disable 0169
		static Delegate GetVideoError_ZHandler ()
		{
			if (cb_videoError_Z == null)
				cb_videoError_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_VideoError_Z);
			return cb_videoError_Z;
		}

		static void n_VideoError_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mopub.Mobileads.BaseVideoViewController __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseVideoViewController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VideoError (p0);
		}
#pragma warning restore 0169

		static IntPtr id_videoError_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoViewController']/method[@name='videoError' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("videoError", "(Z)V", "GetVideoError_ZHandler")]
		protected virtual unsafe void VideoError (bool p0)
		{
			if (id_videoError_Z == IntPtr.Zero)
				id_videoError_Z = JNIEnv.GetMethodID (class_ref, "videoError", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_videoError_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "videoError", "(Z)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/mopub/mobileads/BaseVideoViewController", DoNotGenerateAcw=true)]
	internal partial class BaseVideoViewControllerInvoker : BaseVideoViewController {

		public BaseVideoViewControllerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseVideoViewControllerInvoker); }
		}

		static IntPtr id_getVideoView;
		protected override unsafe global::Android.Widget.VideoView VideoView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoViewController']/method[@name='getVideoView' and count(parameter)=0]"
			[Register ("getVideoView", "()Landroid/widget/VideoView;", "GetGetVideoViewHandler")]
			get {
				if (id_getVideoView == IntPtr.Zero)
					id_getVideoView = JNIEnv.GetMethodID (class_ref, "getVideoView", "()Landroid/widget/VideoView;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Widget.VideoView> (JNIEnv.CallObjectMethod  (Handle, id_getVideoView), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_onConfigurationChanged_Landroid_content_res_Configuration_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoViewController']/method[@name='onConfigurationChanged' and count(parameter)=1 and parameter[1][@type='android.content.res.Configuration']]"
		[Register ("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", "GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler")]
		protected override unsafe void OnConfigurationChanged (global::Android.Content.Res.Configuration p0)
		{
			if (id_onConfigurationChanged_Landroid_content_res_Configuration_ == IntPtr.Zero)
				id_onConfigurationChanged_Landroid_content_res_Configuration_ = JNIEnv.GetMethodID (class_ref, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_onConfigurationChanged_Landroid_content_res_Configuration_, __args);
			} finally {
			}
		}

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoViewController']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		protected override unsafe void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_onDestroy);
			} finally {
			}
		}

		static IntPtr id_onPause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoViewController']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler")]
		protected override unsafe void OnPause ()
		{
			if (id_onPause == IntPtr.Zero)
				id_onPause = JNIEnv.GetMethodID (class_ref, "onPause", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_onPause);
			} finally {
			}
		}

		static IntPtr id_onResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoViewController']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler")]
		protected override unsafe void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_onResume);
			} finally {
			}
		}

		static IntPtr id_onSaveInstanceState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoViewController']/method[@name='onSaveInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onSaveInstanceState", "(Landroid/os/Bundle;)V", "GetOnSaveInstanceState_Landroid_os_Bundle_Handler")]
		protected override unsafe void OnSaveInstanceState (global::Android.OS.Bundle p0)
		{
			if (id_onSaveInstanceState_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onSaveInstanceState_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onSaveInstanceState", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_onSaveInstanceState_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

	}

}
