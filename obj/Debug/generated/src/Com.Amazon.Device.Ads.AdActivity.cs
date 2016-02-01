using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Device.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdActivity']"
	[global::Android.Runtime.Register ("com/amazon/device/ads/AdActivity", DoNotGenerateAcw=true)]
	public partial class AdActivity : global::Android.App.Activity {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdActivity.ActivityAdapterFactory']"
		[global::Android.Runtime.Register ("com/amazon/device/ads/AdActivity$ActivityAdapterFactory", DoNotGenerateAcw=true)]
		public partial class ActivityAdapterFactory : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/device/ads/AdActivity$ActivityAdapterFactory", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ActivityAdapterFactory); }
			}

			protected ActivityAdapterFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_amazon_device_ads_MobileAdsLoggerFactory_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdActivity.ActivityAdapterFactory']/constructor[@name='AdActivity.ActivityAdapterFactory' and count(parameter)=1 and parameter[1][@type='com.amazon.device.ads.MobileAdsLoggerFactory']]"
			[Register (".ctor", "(Lcom/amazon/device/ads/MobileAdsLoggerFactory;)V", "")]
			public unsafe ActivityAdapterFactory (global::Com.Amazon.Device.Ads.MobileAdsLoggerFactory p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (ActivityAdapterFactory)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/device/ads/MobileAdsLoggerFactory;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/device/ads/MobileAdsLoggerFactory;)V", __args);
						return;
					}

					if (id_ctor_Lcom_amazon_device_ads_MobileAdsLoggerFactory_ == IntPtr.Zero)
						id_ctor_Lcom_amazon_device_ads_MobileAdsLoggerFactory_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/device/ads/MobileAdsLoggerFactory;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_device_ads_MobileAdsLoggerFactory_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_device_ads_MobileAdsLoggerFactory_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='AdActivity.IAdActivityAdapter']"
		[Register ("com/amazon/device/ads/AdActivity$IAdActivityAdapter", "", "Com.Amazon.Device.Ads.AdActivity/IAdActivityAdapterInvoker")]
		public partial interface IAdActivityAdapter : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='AdActivity.IAdActivityAdapter']/method[@name='onBackPressed' and count(parameter)=0]"
			[Register ("onBackPressed", "()Z", "GetOnBackPressedHandler:Com.Amazon.Device.Ads.AdActivity/IAdActivityAdapterInvoker, AppodealXamarinPlugin")]
			bool OnBackPressed ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='AdActivity.IAdActivityAdapter']/method[@name='onConfigurationChanged' and count(parameter)=1 and parameter[1][@type='android.content.res.Configuration']]"
			[Register ("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", "GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler:Com.Amazon.Device.Ads.AdActivity/IAdActivityAdapterInvoker, AppodealXamarinPlugin")]
			void OnConfigurationChanged (global::Android.Content.Res.Configuration p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='AdActivity.IAdActivityAdapter']/method[@name='onCreate' and count(parameter)=0]"
			[Register ("onCreate", "()V", "GetOnCreateHandler:Com.Amazon.Device.Ads.AdActivity/IAdActivityAdapterInvoker, AppodealXamarinPlugin")]
			void OnCreate ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='AdActivity.IAdActivityAdapter']/method[@name='onPause' and count(parameter)=0]"
			[Register ("onPause", "()V", "GetOnPauseHandler:Com.Amazon.Device.Ads.AdActivity/IAdActivityAdapterInvoker, AppodealXamarinPlugin")]
			void OnPause ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='AdActivity.IAdActivityAdapter']/method[@name='onResume' and count(parameter)=0]"
			[Register ("onResume", "()V", "GetOnResumeHandler:Com.Amazon.Device.Ads.AdActivity/IAdActivityAdapterInvoker, AppodealXamarinPlugin")]
			void OnResume ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='AdActivity.IAdActivityAdapter']/method[@name='onStop' and count(parameter)=0]"
			[Register ("onStop", "()V", "GetOnStopHandler:Com.Amazon.Device.Ads.AdActivity/IAdActivityAdapterInvoker, AppodealXamarinPlugin")]
			void OnStop ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='AdActivity.IAdActivityAdapter']/method[@name='preOnCreate' and count(parameter)=0]"
			[Register ("preOnCreate", "()V", "GetPreOnCreateHandler:Com.Amazon.Device.Ads.AdActivity/IAdActivityAdapterInvoker, AppodealXamarinPlugin")]
			void PreOnCreate ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/interface[@name='AdActivity.IAdActivityAdapter']/method[@name='setActivity' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register ("setActivity", "(Landroid/app/Activity;)V", "GetSetActivity_Landroid_app_Activity_Handler:Com.Amazon.Device.Ads.AdActivity/IAdActivityAdapterInvoker, AppodealXamarinPlugin")]
			void SetActivity (global::Android.App.Activity p0);

		}

		[global::Android.Runtime.Register ("com/amazon/device/ads/AdActivity$IAdActivityAdapter", DoNotGenerateAcw=true)]
		internal class IAdActivityAdapterInvoker : global::Java.Lang.Object, IAdActivityAdapter {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/device/ads/AdActivity$IAdActivityAdapter");
			IntPtr class_ref;

			public static IAdActivityAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAdActivityAdapter> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.amazon.device.ads.AdActivity.IAdActivityAdapter"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAdActivityAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IAdActivityAdapterInvoker); }
			}

			static Delegate cb_onBackPressed;
#pragma warning disable 0169
			static Delegate GetOnBackPressedHandler ()
			{
				if (cb_onBackPressed == null)
					cb_onBackPressed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OnBackPressed);
				return cb_onBackPressed;
			}

			static bool n_OnBackPressed (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Device.Ads.AdActivity.IAdActivityAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdActivity.IAdActivityAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.OnBackPressed ();
			}
#pragma warning restore 0169

			IntPtr id_onBackPressed;
			public unsafe bool OnBackPressed ()
			{
				if (id_onBackPressed == IntPtr.Zero)
					id_onBackPressed = JNIEnv.GetMethodID (class_ref, "onBackPressed", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_onBackPressed);
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
				global::Com.Amazon.Device.Ads.AdActivity.IAdActivityAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdActivity.IAdActivityAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Res.Configuration p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Configuration> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnConfigurationChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_onConfigurationChanged_Landroid_content_res_Configuration_;
			public unsafe void OnConfigurationChanged (global::Android.Content.Res.Configuration p0)
			{
				if (id_onConfigurationChanged_Landroid_content_res_Configuration_ == IntPtr.Zero)
					id_onConfigurationChanged_Landroid_content_res_Configuration_ = JNIEnv.GetMethodID (class_ref, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onConfigurationChanged_Landroid_content_res_Configuration_, __args);
			}

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
				global::Com.Amazon.Device.Ads.AdActivity.IAdActivityAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdActivity.IAdActivityAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCreate ();
			}
#pragma warning restore 0169

			IntPtr id_onCreate;
			public unsafe void OnCreate ()
			{
				if (id_onCreate == IntPtr.Zero)
					id_onCreate = JNIEnv.GetMethodID (class_ref, "onCreate", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onCreate);
			}

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
				global::Com.Amazon.Device.Ads.AdActivity.IAdActivityAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdActivity.IAdActivityAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPause ();
			}
#pragma warning restore 0169

			IntPtr id_onPause;
			public unsafe void OnPause ()
			{
				if (id_onPause == IntPtr.Zero)
					id_onPause = JNIEnv.GetMethodID (class_ref, "onPause", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onPause);
			}

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
				global::Com.Amazon.Device.Ads.AdActivity.IAdActivityAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdActivity.IAdActivityAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnResume ();
			}
#pragma warning restore 0169

			IntPtr id_onResume;
			public unsafe void OnResume ()
			{
				if (id_onResume == IntPtr.Zero)
					id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onResume);
			}

			static Delegate cb_onStop;
#pragma warning disable 0169
			static Delegate GetOnStopHandler ()
			{
				if (cb_onStop == null)
					cb_onStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStop);
				return cb_onStop;
			}

			static void n_OnStop (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Device.Ads.AdActivity.IAdActivityAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdActivity.IAdActivityAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnStop ();
			}
#pragma warning restore 0169

			IntPtr id_onStop;
			public unsafe void OnStop ()
			{
				if (id_onStop == IntPtr.Zero)
					id_onStop = JNIEnv.GetMethodID (class_ref, "onStop", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onStop);
			}

			static Delegate cb_preOnCreate;
#pragma warning disable 0169
			static Delegate GetPreOnCreateHandler ()
			{
				if (cb_preOnCreate == null)
					cb_preOnCreate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PreOnCreate);
				return cb_preOnCreate;
			}

			static void n_PreOnCreate (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amazon.Device.Ads.AdActivity.IAdActivityAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdActivity.IAdActivityAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.PreOnCreate ();
			}
#pragma warning restore 0169

			IntPtr id_preOnCreate;
			public unsafe void PreOnCreate ()
			{
				if (id_preOnCreate == IntPtr.Zero)
					id_preOnCreate = JNIEnv.GetMethodID (class_ref, "preOnCreate", "()V");
				JNIEnv.CallVoidMethod (Handle, id_preOnCreate);
			}

			static Delegate cb_setActivity_Landroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetSetActivity_Landroid_app_Activity_Handler ()
			{
				if (cb_setActivity_Landroid_app_Activity_ == null)
					cb_setActivity_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActivity_Landroid_app_Activity_);
				return cb_setActivity_Landroid_app_Activity_;
			}

			static void n_SetActivity_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amazon.Device.Ads.AdActivity.IAdActivityAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdActivity.IAdActivityAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetActivity (p0);
			}
#pragma warning restore 0169

			IntPtr id_setActivity_Landroid_app_Activity_;
			public unsafe void SetActivity (global::Android.App.Activity p0)
			{
				if (id_setActivity_Landroid_app_Activity_ == IntPtr.Zero)
					id_setActivity_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "setActivity", "(Landroid/app/Activity;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_setActivity_Landroid_app_Activity_, __args);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/device/ads/AdActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdActivity); }
		}

		protected AdActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdActivity']/constructor[@name='AdActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AdActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AdActivity)) {
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

		static Delegate cb_onCreate_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreate_Landroid_os_Bundle_ == null)
				cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_os_Bundle_);
			return cb_onCreate_Landroid_os_Bundle_;
		}

		static void n_OnCreate_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Device.Ads.AdActivity __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCreate_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdActivity']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnCreate (global::Android.OS.Bundle p0)
		{
			if (id_onCreate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreate_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCreate_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

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
			global::Com.Amazon.Device.Ads.AdActivity __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		static IntPtr id_onPause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdActivity']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler")]
		public virtual unsafe void OnPause ()
		{
			if (id_onPause == IntPtr.Zero)
				id_onPause = JNIEnv.GetMethodID (class_ref, "onPause", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onPause);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPause", "()V"));
			} finally {
			}
		}

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
			global::Com.Amazon.Device.Ads.AdActivity __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		static IntPtr id_onResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdActivity']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler")]
		public virtual unsafe void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onResume);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResume", "()V"));
			} finally {
			}
		}

		static Delegate cb_onStop;
#pragma warning disable 0169
		static Delegate GetOnStopHandler ()
		{
			if (cb_onStop == null)
				cb_onStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStop);
			return cb_onStop;
		}

		static void n_OnStop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.AdActivity __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStop ();
		}
#pragma warning restore 0169

		static IntPtr id_onStop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdActivity']/method[@name='onStop' and count(parameter)=0]"
		[Register ("onStop", "()V", "GetOnStopHandler")]
		public virtual unsafe void OnStop ()
		{
			if (id_onStop == IntPtr.Zero)
				id_onStop = JNIEnv.GetMethodID (class_ref, "onStop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onStop);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStop", "()V"));
			} finally {
			}
		}

	}
}
