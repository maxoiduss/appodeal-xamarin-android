using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AppodealCustomEventInterstitial']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/AppodealCustomEventInterstitial", DoNotGenerateAcw=true)]
	public partial class AppodealCustomEventInterstitial : global::Com.Mopub.Mobileads.CustomEventInterstitial, global::Com.Appodeal.Ads.IInterstitialCallbacks {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AppodealCustomEventInterstitial']/field[@name='API_KEY']"
		[Register ("API_KEY")]
		public const string ApiKey = (string) "appKey";

		static IntPtr Tag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AppodealCustomEventInterstitial']/field[@name='Tag']"
		[Register ("Tag")]
		public string Tag {
			get {
				if (Tag_jfieldId == IntPtr.Zero)
					Tag_jfieldId = JNIEnv.GetFieldID (class_ref, "Tag", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, Tag_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (Tag_jfieldId == IntPtr.Zero)
					Tag_jfieldId = JNIEnv.GetFieldID (class_ref, "Tag", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, Tag_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/AppodealCustomEventInterstitial", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppodealCustomEventInterstitial); }
		}

		protected AppodealCustomEventInterstitial (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AppodealCustomEventInterstitial']/constructor[@name='AppodealCustomEventInterstitial' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AppodealCustomEventInterstitial ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AppodealCustomEventInterstitial)) {
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
			global::Com.Mopub.Mobileads.AppodealCustomEventInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AppodealCustomEventInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener p1 = (global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventInterstitial.ICustomEventInterstitialListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.LoadInterstitial (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_loadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AppodealCustomEventInterstitial']/method[@name='loadInterstitial' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.mobileads.CustomEventInterstitial.CustomEventInterstitialListener'] and parameter[3][@type='java.util.Map'] and parameter[4][@type='java.util.Map']]"
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

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_loadInterstitial_Landroid_content_Context_Lcom_mopub_mobileads_CustomEventInterstitial_CustomEventInterstitialListener_Ljava_util_Map_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadInterstitial", "(Landroid/content/Context;Lcom/mopub/mobileads/CustomEventInterstitial$CustomEventInterstitialListener;Ljava/util/Map;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
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
			global::Com.Mopub.Mobileads.AppodealCustomEventInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AppodealCustomEventInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialClicked ();
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialClicked;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AppodealCustomEventInterstitial']/method[@name='onInterstitialClicked' and count(parameter)=0]"
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

		static Delegate cb_onInterstitialClosed;
#pragma warning disable 0169
		static Delegate GetOnInterstitialClosedHandler ()
		{
			if (cb_onInterstitialClosed == null)
				cb_onInterstitialClosed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialClosed);
			return cb_onInterstitialClosed;
		}

		static void n_OnInterstitialClosed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.AppodealCustomEventInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AppodealCustomEventInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialClosed ();
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialClosed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AppodealCustomEventInterstitial']/method[@name='onInterstitialClosed' and count(parameter)=0]"
		[Register ("onInterstitialClosed", "()V", "GetOnInterstitialClosedHandler")]
		public virtual unsafe void OnInterstitialClosed ()
		{
			if (id_onInterstitialClosed == IntPtr.Zero)
				id_onInterstitialClosed = JNIEnv.GetMethodID (class_ref, "onInterstitialClosed", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onInterstitialClosed);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialClosed", "()V"));
			} finally {
			}
		}

		static Delegate cb_onInterstitialFailedToLoad;
#pragma warning disable 0169
		static Delegate GetOnInterstitialFailedToLoadHandler ()
		{
			if (cb_onInterstitialFailedToLoad == null)
				cb_onInterstitialFailedToLoad = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialFailedToLoad);
			return cb_onInterstitialFailedToLoad;
		}

		static void n_OnInterstitialFailedToLoad (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.AppodealCustomEventInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AppodealCustomEventInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialFailedToLoad ();
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialFailedToLoad;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AppodealCustomEventInterstitial']/method[@name='onInterstitialFailedToLoad' and count(parameter)=0]"
		[Register ("onInterstitialFailedToLoad", "()V", "GetOnInterstitialFailedToLoadHandler")]
		public virtual unsafe void OnInterstitialFailedToLoad ()
		{
			if (id_onInterstitialFailedToLoad == IntPtr.Zero)
				id_onInterstitialFailedToLoad = JNIEnv.GetMethodID (class_ref, "onInterstitialFailedToLoad", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onInterstitialFailedToLoad);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialFailedToLoad", "()V"));
			} finally {
			}
		}

		static Delegate cb_onInterstitialLoaded_Z;
#pragma warning disable 0169
		static Delegate GetOnInterstitialLoaded_ZHandler ()
		{
			if (cb_onInterstitialLoaded_Z == null)
				cb_onInterstitialLoaded_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnInterstitialLoaded_Z);
			return cb_onInterstitialLoaded_Z;
		}

		static void n_OnInterstitialLoaded_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mopub.Mobileads.AppodealCustomEventInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AppodealCustomEventInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialLoaded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialLoaded_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AppodealCustomEventInterstitial']/method[@name='onInterstitialLoaded' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onInterstitialLoaded", "(Z)V", "GetOnInterstitialLoaded_ZHandler")]
		public virtual unsafe void OnInterstitialLoaded (bool p0)
		{
			if (id_onInterstitialLoaded_Z == IntPtr.Zero)
				id_onInterstitialLoaded_Z = JNIEnv.GetMethodID (class_ref, "onInterstitialLoaded", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onInterstitialLoaded_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialLoaded", "(Z)V"), __args);
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
			global::Com.Mopub.Mobileads.AppodealCustomEventInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AppodealCustomEventInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialShown ();
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialShown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AppodealCustomEventInterstitial']/method[@name='onInterstitialShown' and count(parameter)=0]"
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
			global::Com.Mopub.Mobileads.AppodealCustomEventInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AppodealCustomEventInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInvalidate ();
		}
#pragma warning restore 0169

		static IntPtr id_onInvalidate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AppodealCustomEventInterstitial']/method[@name='onInvalidate' and count(parameter)=0]"
		[Register ("onInvalidate", "()V", "GetOnInvalidateHandler")]
		protected override unsafe void OnInvalidate ()
		{
			if (id_onInvalidate == IntPtr.Zero)
				id_onInvalidate = JNIEnv.GetMethodID (class_ref, "onInvalidate", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onInvalidate);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInvalidate", "()V"));
			} finally {
			}
		}

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
			global::Com.Mopub.Mobileads.AppodealCustomEventInterstitial __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AppodealCustomEventInterstitial> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowInterstitial ();
		}
#pragma warning restore 0169

		static IntPtr id_showInterstitial;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AppodealCustomEventInterstitial']/method[@name='showInterstitial' and count(parameter)=0]"
		[Register ("showInterstitial", "()V", "GetShowInterstitialHandler")]
		protected override unsafe void ShowInterstitial ()
		{
			if (id_showInterstitial == IntPtr.Zero)
				id_showInterstitial = JNIEnv.GetMethodID (class_ref, "showInterstitial", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_showInterstitial);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showInterstitial", "()V"));
			} finally {
			}
		}

	}
}
