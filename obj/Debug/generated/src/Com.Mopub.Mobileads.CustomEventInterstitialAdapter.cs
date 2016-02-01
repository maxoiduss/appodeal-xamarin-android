using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitialAdapter']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/CustomEventInterstitialAdapter", DoNotGenerateAcw=true)]
	public partial class CustomEventInterstitialAdapter : global::Java.Lang.Object, global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitialAdapter']/field[@name='DEFAULT_INTERSTITIAL_TIMEOUT_DELAY']"
		[Register ("DEFAULT_INTERSTITIAL_TIMEOUT_DELAY")]
		public const int DefaultInterstitialTimeoutDelay = (int) 30000;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='CustomEventInterstitialAdapter.CustomEventInterstitialAdapterListener']"
		[Register ("com/mopub/mobileads/CustomEventInterstitialAdapter$CustomEventInterstitialAdapterListener", "", "Com.Mopub.Mobileads.CustomEventInterstitialAdapter/ICustomEventInterstitialAdapterListenerInvoker")]
		public partial interface ICustomEventInterstitialAdapterListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='CustomEventInterstitialAdapter.CustomEventInterstitialAdapterListener']/method[@name='onCustomEventInterstitialClicked' and count(parameter)=0]"
			[Register ("onCustomEventInterstitialClicked", "()V", "GetOnCustomEventInterstitialClickedHandler:Com.Mopub.Mobileads.CustomEventInterstitialAdapter/ICustomEventInterstitialAdapterListenerInvoker, AppodealXamarinPlugin")]
			void OnCustomEventInterstitialClicked ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='CustomEventInterstitialAdapter.CustomEventInterstitialAdapterListener']/method[@name='onCustomEventInterstitialDismissed' and count(parameter)=0]"
			[Register ("onCustomEventInterstitialDismissed", "()V", "GetOnCustomEventInterstitialDismissedHandler:Com.Mopub.Mobileads.CustomEventInterstitialAdapter/ICustomEventInterstitialAdapterListenerInvoker, AppodealXamarinPlugin")]
			void OnCustomEventInterstitialDismissed ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='CustomEventInterstitialAdapter.CustomEventInterstitialAdapterListener']/method[@name='onCustomEventInterstitialFailed' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubErrorCode']]"
			[Register ("onCustomEventInterstitialFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V", "GetOnCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler:Com.Mopub.Mobileads.CustomEventInterstitialAdapter/ICustomEventInterstitialAdapterListenerInvoker, AppodealXamarinPlugin")]
			void OnCustomEventInterstitialFailed (global::Com.Mopub.Mobileads.MoPubErrorCode p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='CustomEventInterstitialAdapter.CustomEventInterstitialAdapterListener']/method[@name='onCustomEventInterstitialFinished' and count(parameter)=0]"
			[Register ("onCustomEventInterstitialFinished", "()V", "GetOnCustomEventInterstitialFinishedHandler:Com.Mopub.Mobileads.CustomEventInterstitialAdapter/ICustomEventInterstitialAdapterListenerInvoker, AppodealXamarinPlugin")]
			void OnCustomEventInterstitialFinished ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='CustomEventInterstitialAdapter.CustomEventInterstitialAdapterListener']/method[@name='onCustomEventInterstitialLoaded' and count(parameter)=0]"
			[Register ("onCustomEventInterstitialLoaded", "()V", "GetOnCustomEventInterstitialLoadedHandler:Com.Mopub.Mobileads.CustomEventInterstitialAdapter/ICustomEventInterstitialAdapterListenerInvoker, AppodealXamarinPlugin")]
			void OnCustomEventInterstitialLoaded ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='CustomEventInterstitialAdapter.CustomEventInterstitialAdapterListener']/method[@name='onCustomEventInterstitialShown' and count(parameter)=0]"
			[Register ("onCustomEventInterstitialShown", "()V", "GetOnCustomEventInterstitialShownHandler:Com.Mopub.Mobileads.CustomEventInterstitialAdapter/ICustomEventInterstitialAdapterListenerInvoker, AppodealXamarinPlugin")]
			void OnCustomEventInterstitialShown ();

		}

		[global::Android.Runtime.Register ("com/mopub/mobileads/CustomEventInterstitialAdapter$CustomEventInterstitialAdapterListener", DoNotGenerateAcw=true)]
		internal class ICustomEventInterstitialAdapterListenerInvoker : global::Java.Lang.Object, ICustomEventInterstitialAdapterListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/CustomEventInterstitialAdapter$CustomEventInterstitialAdapterListener");
			IntPtr class_ref;

			public static ICustomEventInterstitialAdapterListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICustomEventInterstitialAdapterListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.CustomEventInterstitialAdapter.CustomEventInterstitialAdapterListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICustomEventInterstitialAdapterListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICustomEventInterstitialAdapterListenerInvoker); }
			}

			static Delegate cb_onCustomEventInterstitialClicked;
#pragma warning disable 0169
			static Delegate GetOnCustomEventInterstitialClickedHandler ()
			{
				if (cb_onCustomEventInterstitialClicked == null)
					cb_onCustomEventInterstitialClicked = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCustomEventInterstitialClicked);
				return cb_onCustomEventInterstitialClicked;
			}

			static void n_OnCustomEventInterstitialClicked (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter.ICustomEventInterstitialAdapterListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter.ICustomEventInterstitialAdapterListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCustomEventInterstitialClicked ();
			}
#pragma warning restore 0169

			IntPtr id_onCustomEventInterstitialClicked;
			public unsafe void OnCustomEventInterstitialClicked ()
			{
				if (id_onCustomEventInterstitialClicked == IntPtr.Zero)
					id_onCustomEventInterstitialClicked = JNIEnv.GetMethodID (class_ref, "onCustomEventInterstitialClicked", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onCustomEventInterstitialClicked);
			}

			static Delegate cb_onCustomEventInterstitialDismissed;
#pragma warning disable 0169
			static Delegate GetOnCustomEventInterstitialDismissedHandler ()
			{
				if (cb_onCustomEventInterstitialDismissed == null)
					cb_onCustomEventInterstitialDismissed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCustomEventInterstitialDismissed);
				return cb_onCustomEventInterstitialDismissed;
			}

			static void n_OnCustomEventInterstitialDismissed (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter.ICustomEventInterstitialAdapterListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter.ICustomEventInterstitialAdapterListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCustomEventInterstitialDismissed ();
			}
#pragma warning restore 0169

			IntPtr id_onCustomEventInterstitialDismissed;
			public unsafe void OnCustomEventInterstitialDismissed ()
			{
				if (id_onCustomEventInterstitialDismissed == IntPtr.Zero)
					id_onCustomEventInterstitialDismissed = JNIEnv.GetMethodID (class_ref, "onCustomEventInterstitialDismissed", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onCustomEventInterstitialDismissed);
			}

			static Delegate cb_onCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
#pragma warning disable 0169
			static Delegate GetOnCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler ()
			{
				if (cb_onCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == null)
					cb_onCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_);
				return cb_onCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
			}

			static void n_OnCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter.ICustomEventInterstitialAdapterListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter.ICustomEventInterstitialAdapterListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MoPubErrorCode p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCustomEventInterstitialFailed (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
			public unsafe void OnCustomEventInterstitialFailed (global::Com.Mopub.Mobileads.MoPubErrorCode p0)
			{
				if (id_onCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == IntPtr.Zero)
					id_onCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNIEnv.GetMethodID (class_ref, "onCustomEventInterstitialFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onCustomEventInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_, __args);
			}

			static Delegate cb_onCustomEventInterstitialFinished;
#pragma warning disable 0169
			static Delegate GetOnCustomEventInterstitialFinishedHandler ()
			{
				if (cb_onCustomEventInterstitialFinished == null)
					cb_onCustomEventInterstitialFinished = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCustomEventInterstitialFinished);
				return cb_onCustomEventInterstitialFinished;
			}

			static void n_OnCustomEventInterstitialFinished (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter.ICustomEventInterstitialAdapterListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter.ICustomEventInterstitialAdapterListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCustomEventInterstitialFinished ();
			}
#pragma warning restore 0169

			IntPtr id_onCustomEventInterstitialFinished;
			public unsafe void OnCustomEventInterstitialFinished ()
			{
				if (id_onCustomEventInterstitialFinished == IntPtr.Zero)
					id_onCustomEventInterstitialFinished = JNIEnv.GetMethodID (class_ref, "onCustomEventInterstitialFinished", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onCustomEventInterstitialFinished);
			}

			static Delegate cb_onCustomEventInterstitialLoaded;
#pragma warning disable 0169
			static Delegate GetOnCustomEventInterstitialLoadedHandler ()
			{
				if (cb_onCustomEventInterstitialLoaded == null)
					cb_onCustomEventInterstitialLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCustomEventInterstitialLoaded);
				return cb_onCustomEventInterstitialLoaded;
			}

			static void n_OnCustomEventInterstitialLoaded (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter.ICustomEventInterstitialAdapterListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter.ICustomEventInterstitialAdapterListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCustomEventInterstitialLoaded ();
			}
#pragma warning restore 0169

			IntPtr id_onCustomEventInterstitialLoaded;
			public unsafe void OnCustomEventInterstitialLoaded ()
			{
				if (id_onCustomEventInterstitialLoaded == IntPtr.Zero)
					id_onCustomEventInterstitialLoaded = JNIEnv.GetMethodID (class_ref, "onCustomEventInterstitialLoaded", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onCustomEventInterstitialLoaded);
			}

			static Delegate cb_onCustomEventInterstitialShown;
#pragma warning disable 0169
			static Delegate GetOnCustomEventInterstitialShownHandler ()
			{
				if (cb_onCustomEventInterstitialShown == null)
					cb_onCustomEventInterstitialShown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCustomEventInterstitialShown);
				return cb_onCustomEventInterstitialShown;
			}

			static void n_OnCustomEventInterstitialShown (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter.ICustomEventInterstitialAdapterListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter.ICustomEventInterstitialAdapterListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCustomEventInterstitialShown ();
			}
#pragma warning restore 0169

			IntPtr id_onCustomEventInterstitialShown;
			public unsafe void OnCustomEventInterstitialShown ()
			{
				if (id_onCustomEventInterstitialShown == IntPtr.Zero)
					id_onCustomEventInterstitialShown = JNIEnv.GetMethodID (class_ref, "onCustomEventInterstitialShown", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onCustomEventInterstitialShown);
			}

		}

		public partial class CustomEventInterstitialFailedEventArgs : global::System.EventArgs {

			public CustomEventInterstitialFailedEventArgs (global::Com.Mopub.Mobileads.MoPubErrorCode p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Mobileads.MoPubErrorCode p0;
			public global::Com.Mopub.Mobileads.MoPubErrorCode P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/mobileads/CustomEventInterstitialAdapter_CustomEventInterstitialAdapterListenerImplementor")]
		internal sealed partial class ICustomEventInterstitialAdapterListenerImplementor : global::Java.Lang.Object, ICustomEventInterstitialAdapterListener {

			object sender;

			public ICustomEventInterstitialAdapterListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/mobileads/CustomEventInterstitialAdapter_CustomEventInterstitialAdapterListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnCustomEventInterstitialClickedHandler;
#pragma warning restore 0649

			public void OnCustomEventInterstitialClicked ()
			{
				var __h = OnCustomEventInterstitialClickedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnCustomEventInterstitialDismissedHandler;
#pragma warning restore 0649

			public void OnCustomEventInterstitialDismissed ()
			{
				var __h = OnCustomEventInterstitialDismissedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<CustomEventInterstitialFailedEventArgs> OnCustomEventInterstitialFailedHandler;
#pragma warning restore 0649

			public void OnCustomEventInterstitialFailed (global::Com.Mopub.Mobileads.MoPubErrorCode p0)
			{
				var __h = OnCustomEventInterstitialFailedHandler;
				if (__h != null)
					__h (sender, new CustomEventInterstitialFailedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler OnCustomEventInterstitialFinishedHandler;
#pragma warning restore 0649

			public void OnCustomEventInterstitialFinished ()
			{
				var __h = OnCustomEventInterstitialFinishedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnCustomEventInterstitialLoadedHandler;
#pragma warning restore 0649

			public void OnCustomEventInterstitialLoaded ()
			{
				var __h = OnCustomEventInterstitialLoadedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnCustomEventInterstitialShownHandler;
#pragma warning restore 0649

			public void OnCustomEventInterstitialShown ()
			{
				var __h = OnCustomEventInterstitialShownHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (ICustomEventInterstitialAdapterListenerImplementor value)
			{
				return value.OnCustomEventInterstitialClickedHandler == null && value.OnCustomEventInterstitialDismissedHandler == null && value.OnCustomEventInterstitialFailedHandler == null && value.OnCustomEventInterstitialFinishedHandler == null && value.OnCustomEventInterstitialLoadedHandler == null && value.OnCustomEventInterstitialShownHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/CustomEventInterstitialAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CustomEventInterstitialAdapter); }
		}

		protected CustomEventInterstitialAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitialAdapter']/constructor[@name='CustomEventInterstitialAdapter' and count(parameter)=5 and parameter[1][@type='com.mopub.mobileads.MoPubInterstitial'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map'] and parameter[4][@type='long'] and parameter[5][@type='com.mopub.common.AdReport']]"
		[Register (".ctor", "(Lcom/mopub/mobileads/MoPubInterstitial;Ljava/lang/String;Ljava/util/Map;JLcom/mopub/common/AdReport;)V", "")]
		public unsafe CustomEventInterstitialAdapter (global::Com.Mopub.Mobileads.MoPubInterstitial p0, string p1, global::System.Collections.IDictionary p2, long p3, global::Com.Mopub.Common.AdReport p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (CustomEventInterstitialAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/mobileads/MoPubInterstitial;Ljava/lang/String;Ljava/util/Map;JLcom/mopub/common/AdReport;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/mobileads/MoPubInterstitial;Ljava/lang/String;Ljava/util/Map;JLcom/mopub/common/AdReport;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_ == IntPtr.Zero)
					id_ctor_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/mobileads/MoPubInterstitial;Ljava/lang/String;Ljava/util/Map;JLcom/mopub/common/AdReport;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
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
			global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialClicked ();
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialClicked;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitialAdapter']/method[@name='onInterstitialClicked' and count(parameter)=0]"
		[Register ("onInterstitialClicked", "()V", "GetOnInterstitialClickedHandler")]
		public virtual unsafe void OnInterstitialClicked ()
		{
			if (id_onInterstitialClicked == IntPtr.Zero)
				id_onInterstitialClicked = JNIEnv.GetMethodID (class_ref, "onInterstitialClicked", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onInterstitialClicked);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialClicked", "()V"));
			} finally {
			}
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
			global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialDismissed ();
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialDismissed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitialAdapter']/method[@name='onInterstitialDismissed' and count(parameter)=0]"
		[Register ("onInterstitialDismissed", "()V", "GetOnInterstitialDismissedHandler")]
		public virtual unsafe void OnInterstitialDismissed ()
		{
			if (id_onInterstitialDismissed == IntPtr.Zero)
				id_onInterstitialDismissed = JNIEnv.GetMethodID (class_ref, "onInterstitialDismissed", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onInterstitialDismissed);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialDismissed", "()V"));
			} finally {
			}
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
			global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubErrorCode p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialFailed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitialAdapter']/method[@name='onInterstitialFailed' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubErrorCode']]"
		[Register ("onInterstitialFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V", "GetOnInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler")]
		public virtual unsafe void OnInterstitialFailed (global::Com.Mopub.Mobileads.MoPubErrorCode p0)
		{
			if (id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == IntPtr.Zero)
				id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNIEnv.GetMethodID (class_ref, "onInterstitialFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V"), __args);
			} finally {
			}
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
			global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialFinished ();
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialFinished;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitialAdapter']/method[@name='onInterstitialFinished' and count(parameter)=0]"
		[Register ("onInterstitialFinished", "()V", "GetOnInterstitialFinishedHandler")]
		public virtual unsafe void OnInterstitialFinished ()
		{
			if (id_onInterstitialFinished == IntPtr.Zero)
				id_onInterstitialFinished = JNIEnv.GetMethodID (class_ref, "onInterstitialFinished", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onInterstitialFinished);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialFinished", "()V"));
			} finally {
			}
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
			global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialLoaded ();
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialLoaded;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitialAdapter']/method[@name='onInterstitialLoaded' and count(parameter)=0]"
		[Register ("onInterstitialLoaded", "()V", "GetOnInterstitialLoadedHandler")]
		public virtual unsafe void OnInterstitialLoaded ()
		{
			if (id_onInterstitialLoaded == IntPtr.Zero)
				id_onInterstitialLoaded = JNIEnv.GetMethodID (class_ref, "onInterstitialLoaded", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onInterstitialLoaded);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialLoaded", "()V"));
			} finally {
			}
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
			global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialShown ();
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialShown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitialAdapter']/method[@name='onInterstitialShown' and count(parameter)=0]"
		[Register ("onInterstitialShown", "()V", "GetOnInterstitialShownHandler")]
		public virtual unsafe void OnInterstitialShown ()
		{
			if (id_onInterstitialShown == IntPtr.Zero)
				id_onInterstitialShown = JNIEnv.GetMethodID (class_ref, "onInterstitialShown", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onInterstitialShown);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialShown", "()V"));
			} finally {
			}
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
			global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitialAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLeaveApplication ();
		}
#pragma warning restore 0169

		static IntPtr id_onLeaveApplication;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitialAdapter']/method[@name='onLeaveApplication' and count(parameter)=0]"
		[Register ("onLeaveApplication", "()V", "GetOnLeaveApplicationHandler")]
		public virtual unsafe void OnLeaveApplication ()
		{
			if (id_onLeaveApplication == IntPtr.Zero)
				id_onLeaveApplication = JNIEnv.GetMethodID (class_ref, "onLeaveApplication", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onLeaveApplication);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLeaveApplication", "()V"));
			} finally {
			}
		}

	}
}
