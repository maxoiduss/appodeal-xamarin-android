using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventBanner']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/CustomEventBanner", DoNotGenerateAcw=true)]
	public abstract partial class CustomEventBanner : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='CustomEventBanner.CustomEventBannerListener']"
		[Register ("com/mopub/mobileads/CustomEventBanner$CustomEventBannerListener", "", "Com.Mopub.Mobileads.CustomEventBanner/ICustomEventBannerListenerInvoker")]
		public partial interface ICustomEventBannerListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='CustomEventBanner.CustomEventBannerListener']/method[@name='onBannerClicked' and count(parameter)=0]"
			[Register ("onBannerClicked", "()V", "GetOnBannerClickedHandler:Com.Mopub.Mobileads.CustomEventBanner/ICustomEventBannerListenerInvoker, AppodealXamarinPlugin")]
			void OnBannerClicked ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='CustomEventBanner.CustomEventBannerListener']/method[@name='onBannerCollapsed' and count(parameter)=0]"
			[Register ("onBannerCollapsed", "()V", "GetOnBannerCollapsedHandler:Com.Mopub.Mobileads.CustomEventBanner/ICustomEventBannerListenerInvoker, AppodealXamarinPlugin")]
			void OnBannerCollapsed ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='CustomEventBanner.CustomEventBannerListener']/method[@name='onBannerExpanded' and count(parameter)=0]"
			[Register ("onBannerExpanded", "()V", "GetOnBannerExpandedHandler:Com.Mopub.Mobileads.CustomEventBanner/ICustomEventBannerListenerInvoker, AppodealXamarinPlugin")]
			void OnBannerExpanded ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='CustomEventBanner.CustomEventBannerListener']/method[@name='onBannerFailed' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubErrorCode']]"
			[Register ("onBannerFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V", "GetOnBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler:Com.Mopub.Mobileads.CustomEventBanner/ICustomEventBannerListenerInvoker, AppodealXamarinPlugin")]
			void OnBannerFailed (global::Com.Mopub.Mobileads.MoPubErrorCode p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='CustomEventBanner.CustomEventBannerListener']/method[@name='onBannerLoaded' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("onBannerLoaded", "(Landroid/view/View;)V", "GetOnBannerLoaded_Landroid_view_View_Handler:Com.Mopub.Mobileads.CustomEventBanner/ICustomEventBannerListenerInvoker, AppodealXamarinPlugin")]
			void OnBannerLoaded (global::Android.Views.View p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='CustomEventBanner.CustomEventBannerListener']/method[@name='onLeaveApplication' and count(parameter)=0]"
			[Register ("onLeaveApplication", "()V", "GetOnLeaveApplicationHandler:Com.Mopub.Mobileads.CustomEventBanner/ICustomEventBannerListenerInvoker, AppodealXamarinPlugin")]
			void OnLeaveApplication ();

		}

		[global::Android.Runtime.Register ("com/mopub/mobileads/CustomEventBanner$CustomEventBannerListener", DoNotGenerateAcw=true)]
		internal class ICustomEventBannerListenerInvoker : global::Java.Lang.Object, ICustomEventBannerListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/CustomEventBanner$CustomEventBannerListener");
			IntPtr class_ref;

			public static ICustomEventBannerListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICustomEventBannerListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.CustomEventBanner.CustomEventBannerListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICustomEventBannerListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICustomEventBannerListenerInvoker); }
			}

			static Delegate cb_onBannerClicked;
#pragma warning disable 0169
			static Delegate GetOnBannerClickedHandler ()
			{
				if (cb_onBannerClicked == null)
					cb_onBannerClicked = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBannerClicked);
				return cb_onBannerClicked;
			}

			static void n_OnBannerClicked (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnBannerClicked ();
			}
#pragma warning restore 0169

			IntPtr id_onBannerClicked;
			public unsafe void OnBannerClicked ()
			{
				if (id_onBannerClicked == IntPtr.Zero)
					id_onBannerClicked = JNIEnv.GetMethodID (class_ref, "onBannerClicked", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onBannerClicked);
			}

			static Delegate cb_onBannerCollapsed;
#pragma warning disable 0169
			static Delegate GetOnBannerCollapsedHandler ()
			{
				if (cb_onBannerCollapsed == null)
					cb_onBannerCollapsed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBannerCollapsed);
				return cb_onBannerCollapsed;
			}

			static void n_OnBannerCollapsed (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnBannerCollapsed ();
			}
#pragma warning restore 0169

			IntPtr id_onBannerCollapsed;
			public unsafe void OnBannerCollapsed ()
			{
				if (id_onBannerCollapsed == IntPtr.Zero)
					id_onBannerCollapsed = JNIEnv.GetMethodID (class_ref, "onBannerCollapsed", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onBannerCollapsed);
			}

			static Delegate cb_onBannerExpanded;
#pragma warning disable 0169
			static Delegate GetOnBannerExpandedHandler ()
			{
				if (cb_onBannerExpanded == null)
					cb_onBannerExpanded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBannerExpanded);
				return cb_onBannerExpanded;
			}

			static void n_OnBannerExpanded (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnBannerExpanded ();
			}
#pragma warning restore 0169

			IntPtr id_onBannerExpanded;
			public unsafe void OnBannerExpanded ()
			{
				if (id_onBannerExpanded == IntPtr.Zero)
					id_onBannerExpanded = JNIEnv.GetMethodID (class_ref, "onBannerExpanded", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onBannerExpanded);
			}

			static Delegate cb_onBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
#pragma warning disable 0169
			static Delegate GetOnBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler ()
			{
				if (cb_onBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == null)
					cb_onBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_);
				return cb_onBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
			}

			static void n_OnBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MoPubErrorCode p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnBannerFailed (p0);
			}
#pragma warning restore 0169

			IntPtr id_onBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
			public unsafe void OnBannerFailed (global::Com.Mopub.Mobileads.MoPubErrorCode p0)
			{
				if (id_onBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == IntPtr.Zero)
					id_onBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNIEnv.GetMethodID (class_ref, "onBannerFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_, __args);
			}

			static Delegate cb_onBannerLoaded_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetOnBannerLoaded_Landroid_view_View_Handler ()
			{
				if (cb_onBannerLoaded_Landroid_view_View_ == null)
					cb_onBannerLoaded_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBannerLoaded_Landroid_view_View_);
				return cb_onBannerLoaded_Landroid_view_View_;
			}

			static void n_OnBannerLoaded_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnBannerLoaded (p0);
			}
#pragma warning restore 0169

			IntPtr id_onBannerLoaded_Landroid_view_View_;
			public unsafe void OnBannerLoaded (global::Android.Views.View p0)
			{
				if (id_onBannerLoaded_Landroid_view_View_ == IntPtr.Zero)
					id_onBannerLoaded_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onBannerLoaded", "(Landroid/view/View;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onBannerLoaded_Landroid_view_View_, __args);
			}

			static Delegate cb_onLeaveApplication;
#pragma warning disable 0169
			static Delegate GetOnLeaveApplicationHandler ()
			{
				if (cb_onLeaveApplication == null)
					cb_onLeaveApplication = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLeaveApplication);
				return cb_onLeaveApplication;
			}

			static void n_OnLeaveApplication (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnLeaveApplication ();
			}
#pragma warning restore 0169

			IntPtr id_onLeaveApplication;
			public unsafe void OnLeaveApplication ()
			{
				if (id_onLeaveApplication == IntPtr.Zero)
					id_onLeaveApplication = JNIEnv.GetMethodID (class_ref, "onLeaveApplication", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onLeaveApplication);
			}

		}

		public partial class BannerFailedEventArgs : global::System.EventArgs {

			public BannerFailedEventArgs (global::Com.Mopub.Mobileads.MoPubErrorCode p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Mobileads.MoPubErrorCode p0;
			public global::Com.Mopub.Mobileads.MoPubErrorCode P0 {
				get { return p0; }
			}
		}

		public partial class BannerLoadedEventArgs : global::System.EventArgs {

			public BannerLoadedEventArgs (global::Android.Views.View p0)
			{
				this.p0 = p0;
			}

			global::Android.Views.View p0;
			public global::Android.Views.View P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/mobileads/CustomEventBanner_CustomEventBannerListenerImplementor")]
		internal sealed partial class ICustomEventBannerListenerImplementor : global::Java.Lang.Object, ICustomEventBannerListener {

			object sender;

			public ICustomEventBannerListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/mobileads/CustomEventBanner_CustomEventBannerListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnBannerClickedHandler;
#pragma warning restore 0649

			public void OnBannerClicked ()
			{
				var __h = OnBannerClickedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnBannerCollapsedHandler;
#pragma warning restore 0649

			public void OnBannerCollapsed ()
			{
				var __h = OnBannerCollapsedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnBannerExpandedHandler;
#pragma warning restore 0649

			public void OnBannerExpanded ()
			{
				var __h = OnBannerExpandedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<BannerFailedEventArgs> OnBannerFailedHandler;
#pragma warning restore 0649

			public void OnBannerFailed (global::Com.Mopub.Mobileads.MoPubErrorCode p0)
			{
				var __h = OnBannerFailedHandler;
				if (__h != null)
					__h (sender, new BannerFailedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<BannerLoadedEventArgs> OnBannerLoadedHandler;
#pragma warning restore 0649

			public void OnBannerLoaded (global::Android.Views.View p0)
			{
				var __h = OnBannerLoadedHandler;
				if (__h != null)
					__h (sender, new BannerLoadedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler OnLeaveApplicationHandler;
#pragma warning restore 0649

			public void OnLeaveApplication ()
			{
				var __h = OnLeaveApplicationHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (ICustomEventBannerListenerImplementor value)
			{
				return value.OnBannerClickedHandler == null && value.OnBannerCollapsedHandler == null && value.OnBannerExpandedHandler == null && value.OnBannerFailedHandler == null && value.OnBannerLoadedHandler == null && value.OnLeaveApplicationHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/CustomEventBanner", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CustomEventBanner); }
		}

		protected CustomEventBanner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventBanner']/constructor[@name='CustomEventBanner' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CustomEventBanner ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CustomEventBanner)) {
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

		static Delegate cb_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetLoadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_Handler ()
		{
			if (cb_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_ == null)
				cb_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_);
			return cb_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_;
		}

		static void n_LoadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Mopub.Mobileads.CustomEventBanner __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventBanner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener p1 = (global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.LoadBanner (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventBanner']/method[@name='loadBanner' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.mobileads.CustomEventBanner.CustomEventBannerListener'] and parameter[3][@type='java.util.Map'] and parameter[4][@type='java.util.Map']]"
		[Register ("loadBanner", "(Landroid/content/Context;Lcom/mopub/mobileads/CustomEventBanner$CustomEventBannerListener;Ljava/util/Map;Ljava/util/Map;)V", "GetLoadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_Handler")]
		protected abstract void LoadBanner (global::Android.Content.Context p0, global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener p1, global::System.Collections.IDictionary p2, global::System.Collections.IDictionary p3);

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
			global::Com.Mopub.Mobileads.CustomEventBanner __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventBanner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInvalidate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventBanner']/method[@name='onInvalidate' and count(parameter)=0]"
		[Register ("onInvalidate", "()V", "GetOnInvalidateHandler")]
		protected abstract void OnInvalidate ();

	}

	[global::Android.Runtime.Register ("com/mopub/mobileads/CustomEventBanner", DoNotGenerateAcw=true)]
	internal partial class CustomEventBannerInvoker : CustomEventBanner {

		public CustomEventBannerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (CustomEventBannerInvoker); }
		}

		static IntPtr id_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventBanner']/method[@name='loadBanner' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.mobileads.CustomEventBanner.CustomEventBannerListener'] and parameter[3][@type='java.util.Map'] and parameter[4][@type='java.util.Map']]"
		[Register ("loadBanner", "(Landroid/content/Context;Lcom/mopub/mobileads/CustomEventBanner$CustomEventBannerListener;Ljava/util/Map;Ljava/util/Map;)V", "GetLoadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_Handler")]
		protected override unsafe void LoadBanner (global::Android.Content.Context p0, global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener p1, global::System.Collections.IDictionary p2, global::System.Collections.IDictionary p3)
		{
			if (id_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
				id_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "loadBanner", "(Landroid/content/Context;Lcom/mopub/mobileads/CustomEventBanner$CustomEventBannerListener;Ljava/util/Map;Ljava/util/Map;)V");
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallVoidMethod  (Handle, id_loadBanner_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_Ljava_util_Map_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_onInvalidate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventBanner']/method[@name='onInvalidate' and count(parameter)=0]"
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

	}

}
