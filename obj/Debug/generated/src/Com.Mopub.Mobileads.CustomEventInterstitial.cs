using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitial']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/CustomEventInterstitial", DoNotGenerateAcw=true)]
	public abstract partial class CustomEventInterstitial : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='CustomEventInterstitial.CustomEventInterstitialListener']"
		[Register ("com/mopub/mobileads/CustomEventInterstitial$CustomEventInterstitialListener", "", "Com.Mopub.Mobileads.CustomEventInterstitial/ICustomEventInterstitialListenerInvoker")]
		public partial interface ICustomEventInterstitialListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='CustomEventInterstitial.CustomEventInterstitialListener']/method[@name='onInterstitialClicked' and count(parameter)=0]"
			[Register ("onInterstitialClicked", "()V", "GetOnInterstitialClickedHandler:Com.Mopub.Mobileads.CustomEventInterstitial/ICustomEventInterstitialListenerInvoker, AppodealXamarinPlugin")]
			void OnInterstitialClicked ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='CustomEventInterstitial.CustomEventInterstitialListener']/method[@name='onInterstitialDismissed' and count(parameter)=0]"
			[Register ("onInterstitialDismissed", "()V", "GetOnInterstitialDismissedHandler:Com.Mopub.Mobileads.CustomEventInterstitial/ICustomEventInterstitialListenerInvoker, AppodealXamarinPlugin")]
			void OnInterstitialDismissed ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='CustomEventInterstitial.CustomEventInterstitialListener']/method[@name='onInterstitialFailed' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubErrorCode']]"
			[Register ("onInterstitialFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V", "GetOnInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler:Com.Mopub.Mobileads.CustomEventInterstitial/ICustomEventInterstitialListenerInvoker, AppodealXamarinPlugin")]
			void OnInterstitialFailed (global::Com.Mopub.Mobileads.MoPubErrorCode p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='CustomEventInterstitial.CustomEventInterstitialListener']/method[@name='onInterstitialFinished' and count(parameter)=0]"
			[Register ("onInterstitialFinished", "()V", "GetOnInterstitialFinishedHandler:Com.Mopub.Mobileads.CustomEventInterstitial/ICustomEventInterstitialListenerInvoker, AppodealXamarinPlugin")]
			void OnInterstitialFinished ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='CustomEventInterstitial.CustomEventInterstitialListener']/method[@name='onInterstitialLoaded' and count(parameter)=0]"
			[Register ("onInterstitialLoaded", "()V", "GetOnInterstitialLoadedHandler:Com.Mopub.Mobileads.CustomEventInterstitial/ICustomEventInterstitialListenerInvoker, AppodealXamarinPlugin")]
			void OnInterstitialLoaded ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='CustomEventInterstitial.CustomEventInterstitialListener']/method[@name='onInterstitialShown' and count(parameter)=0]"
			[Register ("onInterstitialShown", "()V", "GetOnInterstitialShownHandler:Com.Mopub.Mobileads.CustomEventInterstitial/ICustomEventInterstitialListenerInvoker, AppodealXamarinPlugin")]
			void OnInterstitialShown ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='CustomEventInterstitial.CustomEventInterstitialListener']/method[@name='onLeaveApplication' and count(parameter)=0]"
			[Register ("onLeaveApplication", "()V", "GetOnLeaveApplicationHandler:Com.Mopub.Mobileads.CustomEventInterstitial/ICustomEventInterstitialListenerInvoker, AppodealXamarinPlugin")]
			void OnLeaveApplication ();

		}

		[global::Android.Runtime.Register ("com/mopub/mobileads/CustomEventInterstitial$CustomEventInterstitialListener", DoNotGenerateAcw=true)]
		internal class ICustomEventInterstitialListenerInvoker : global::Java.Lang.Object, ICustomEventInterstitialListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/CustomEventInterstitial$CustomEventInterstitialListener");
			IntPtr class_ref;

			public static ICustomEventInterstitialListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICustomEventInterstitialListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.CustomEventInterstitial.CustomEventInterstitialListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICustomEventInterstitialListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICustomEventInterstitialListenerInvoker); }
			}

			static Delegate cb_onInterstitialClicked;
#pragma warning disable 0169
			static Delegate GetOnInterstitialClickedHandler ()
			{
				if (cb_onInterstitialClicked == null)
					cb_onInterstitialClicked = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialClicked);
				return cb_onInterstitialClicked;
			}

			static void n_OnInterstitialClicked (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnInterstitialClicked ();
			}
#pragma warning restore 0169

			IntPtr id_onInterstitialClicked;
			public unsafe void OnInterstitialClicked ()
			{
				if (id_onInterstitialClicked == IntPtr.Zero)
					id_onInterstitialClicked = JNIEnv.GetMethodID (class_ref, "onInterstitialClicked", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onInterstitialClicked);
			}

			static Delegate cb_onInterstitialDismissed;
#pragma warning disable 0169
			static Delegate GetOnInterstitialDismissedHandler ()
			{
				if (cb_onInterstitialDismissed == null)
					cb_onInterstitialDismissed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialDismissed);
				return cb_onInterstitialDismissed;
			}

			static void n_OnInterstitialDismissed (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnInterstitialDismissed ();
			}
#pragma warning restore 0169

			IntPtr id_onInterstitialDismissed;
			public unsafe void OnInterstitialDismissed ()
			{
				if (id_onInterstitialDismissed == IntPtr.Zero)
					id_onInterstitialDismissed = JNIEnv.GetMethodID (class_ref, "onInterstitialDismissed", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onInterstitialDismissed);
			}

			static Delegate cb_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
#pragma warning disable 0169
			static Delegate GetOnInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler ()
			{
				if (cb_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == null)
					cb_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_);
				return cb_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
			}

			static void n_OnInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MoPubErrorCode p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnInterstitialFailed (p0);
			}
#pragma warning restore 0169

			IntPtr id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
			public unsafe void OnInterstitialFailed (global::Com.Mopub.Mobileads.MoPubErrorCode p0)
			{
				if (id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == IntPtr.Zero)
					id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNIEnv.GetMethodID (class_ref, "onInterstitialFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_, __args);
			}

			static Delegate cb_onInterstitialFinished;
#pragma warning disable 0169
			static Delegate GetOnInterstitialFinishedHandler ()
			{
				if (cb_onInterstitialFinished == null)
					cb_onInterstitialFinished = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialFinished);
				return cb_onInterstitialFinished;
			}

			static void n_OnInterstitialFinished (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnInterstitialFinished ();
			}
#pragma warning restore 0169

			IntPtr id_onInterstitialFinished;
			public unsafe void OnInterstitialFinished ()
			{
				if (id_onInterstitialFinished == IntPtr.Zero)
					id_onInterstitialFinished = JNIEnv.GetMethodID (class_ref, "onInterstitialFinished", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onInterstitialFinished);
			}

			static Delegate cb_onInterstitialLoaded;
#pragma warning disable 0169
			static Delegate GetOnInterstitialLoadedHandler ()
			{
				if (cb_onInterstitialLoaded == null)
					cb_onInterstitialLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialLoaded);
				return cb_onInterstitialLoaded;
			}

			static void n_OnInterstitialLoaded (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnInterstitialLoaded ();
			}
#pragma warning restore 0169

			IntPtr id_onInterstitialLoaded;
			public unsafe void OnInterstitialLoaded ()
			{
				if (id_onInterstitialLoaded == IntPtr.Zero)
					id_onInterstitialLoaded = JNIEnv.GetMethodID (class_ref, "onInterstitialLoaded", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onInterstitialLoaded);
			}

			static Delegate cb_onInterstitialShown;
#pragma warning disable 0169
			static Delegate GetOnInterstitialShownHandler ()
			{
				if (cb_onInterstitialShown == null)
					cb_onInterstitialShown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialShown);
				return cb_onInterstitialShown;
			}

			static void n_OnInterstitialShown (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnInterstitialShown ();
			}
#pragma warning restore 0169

			IntPtr id_onInterstitialShown;
			public unsafe void OnInterstitialShown ()
			{
				if (id_onInterstitialShown == IntPtr.Zero)
					id_onInterstitialShown = JNIEnv.GetMethodID (class_ref, "onInterstitialShown", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onInterstitialShown);
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
				global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		public partial class InterstitialFailedEventArgs : global::System.EventArgs {

			public InterstitialFailedEventArgs (global::Com.Mopub.Mobileads.MoPubErrorCode p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Mobileads.MoPubErrorCode p0;
			public global::Com.Mopub.Mobileads.MoPubErrorCode P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/mobileads/CustomEventInterstitial_CustomEventInterstitialListenerImplementor")]
		internal sealed partial class ICustomEventInterstitialListenerImplementor : global::Java.Lang.Object, ICustomEventInterstitialListener {

			object sender;

			public ICustomEventInterstitialListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/mobileads/CustomEventInterstitial_CustomEventInterstitialListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnInterstitialClickedHandler;
#pragma warning restore 0649

			public void OnInterstitialClicked ()
			{
				var __h = OnInterstitialClickedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnInterstitialDismissedHandler;
#pragma warning restore 0649

			public void OnInterstitialDismissed ()
			{
				var __h = OnInterstitialDismissedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<InterstitialFailedEventArgs> OnInterstitialFailedHandler;
#pragma warning restore 0649

			public void OnInterstitialFailed (global::Com.Mopub.Mobileads.MoPubErrorCode p0)
			{
				var __h = OnInterstitialFailedHandler;
				if (__h != null)
					__h (sender, new InterstitialFailedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler OnInterstitialFinishedHandler;
#pragma warning restore 0649

			public void OnInterstitialFinished ()
			{
				var __h = OnInterstitialFinishedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnInterstitialLoadedHandler;
#pragma warning restore 0649

			public void OnInterstitialLoaded ()
			{
				var __h = OnInterstitialLoadedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnInterstitialShownHandler;
#pragma warning restore 0649

			public void OnInterstitialShown ()
			{
				var __h = OnInterstitialShownHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
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

			internal static bool __IsEmpty (ICustomEventInterstitialListenerImplementor value)
			{
				return value.OnInterstitialClickedHandler == null && value.OnInterstitialDismissedHandler == null && value.OnInterstitialFailedHandler == null && value.OnInterstitialFinishedHandler == null && value.OnInterstitialLoadedHandler == null && value.OnInterstitialShownHandler == null && value.OnLeaveApplicationHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/CustomEventInterstitial", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CustomEventInterstitial); }
		}

		protected CustomEventInterstitial (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitial']/constructor[@name='CustomEventInterstitial' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CustomEventInterstitial ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CustomEventInterstitial)) {
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

		static Delegate cb_loadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetLoadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_Handler ()
		{
			if (cb_loadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_ == null)
				cb_loadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_);
			return cb_loadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_;
		}

		static void n_LoadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Mopub.Mobileads.CustomEventInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener p1 = (global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.LoadInterstitial (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitial']/method[@name='loadInterstitial' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.mobileads.CustomEventInterstitial.CustomEventInterstitialListener'] and parameter[3][@type='java.util.Map'] and parameter[4][@type='java.util.Map']]"
		[Register ("loadInterstitial", "(Landroid/content/Context;Lcom/mopub/mobileads/CustomEventInterstitial$CustomEventInterstitialListener;Ljava/util/Map;Ljava/util/Map;)V", "GetLoadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_Handler")]
		protected abstract void LoadInterstitial (global::Android.Content.Context p0, global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener p1, global::System.Collections.IDictionary p2, global::System.Collections.IDictionary p3);

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
			global::Com.Mopub.Mobileads.CustomEventInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInvalidate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitial']/method[@name='onInvalidate' and count(parameter)=0]"
		[Register ("onInvalidate", "()V", "GetOnInvalidateHandler")]
		protected abstract void OnInvalidate ();

		static Delegate cb_showInterstitial;
#pragma warning disable 0169
		static Delegate GetShowInterstitialHandler ()
		{
			if (cb_showInterstitial == null)
				cb_showInterstitial = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowInterstitial);
			return cb_showInterstitial;
		}

		static void n_ShowInterstitial (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.CustomEventInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowInterstitial ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitial']/method[@name='showInterstitial' and count(parameter)=0]"
		[Register ("showInterstitial", "()V", "GetShowInterstitialHandler")]
		protected abstract void ShowInterstitial ();

	}

	[global::Android.Runtime.Register ("com/mopub/mobileads/CustomEventInterstitial", DoNotGenerateAcw=true)]
	internal partial class CustomEventInterstitialInvoker : CustomEventInterstitial {

		public CustomEventInterstitialInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (CustomEventInterstitialInvoker); }
		}

		static IntPtr id_loadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitial']/method[@name='loadInterstitial' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.mobileads.CustomEventInterstitial.CustomEventInterstitialListener'] and parameter[3][@type='java.util.Map'] and parameter[4][@type='java.util.Map']]"
		[Register ("loadInterstitial", "(Landroid/content/Context;Lcom/mopub/mobileads/CustomEventInterstitial$CustomEventInterstitialListener;Ljava/util/Map;Ljava/util/Map;)V", "GetLoadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_Handler")]
		protected override unsafe void LoadInterstitial (global::Android.Content.Context p0, global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener p1, global::System.Collections.IDictionary p2, global::System.Collections.IDictionary p3)
		{
			if (id_loadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
				id_loadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "loadInterstitial", "(Landroid/content/Context;Lcom/mopub/mobileads/CustomEventInterstitial$CustomEventInterstitialListener;Ljava/util/Map;Ljava/util/Map;)V");
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallVoidMethod  (Handle, id_loadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_onInvalidate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitial']/method[@name='onInvalidate' and count(parameter)=0]"
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

		static IntPtr id_showInterstitial;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitial']/method[@name='showInterstitial' and count(parameter)=0]"
		[Register ("showInterstitial", "()V", "GetShowInterstitialHandler")]
		protected override unsafe void ShowInterstitial ()
		{
			if (id_showInterstitial == IntPtr.Zero)
				id_showInterstitial = JNIEnv.GetMethodID (class_ref, "showInterstitial", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_showInterstitial);
			} finally {
			}
		}

	}

}
