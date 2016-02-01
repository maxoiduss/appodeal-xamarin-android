using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseHtmlWebView']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/BaseHtmlWebView", DoNotGenerateAcw=true)]
	public partial class BaseHtmlWebView : global::Com.Mopub.Mobileads.BaseWebView, global::Com.Mopub.Mobileads.ViewGestureDetector.IUserClickListener {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/BaseHtmlWebView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseHtmlWebView); }
		}

		protected BaseHtmlWebView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_mopub_common_AdReport_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseHtmlWebView']/constructor[@name='BaseHtmlWebView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.common.AdReport']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/mopub/common/AdReport;)V", "")]
		public unsafe BaseHtmlWebView (global::Android.Content.Context p0, global::Com.Mopub.Common.AdReport p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (BaseHtmlWebView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/mopub/common/AdReport;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/mopub/common/AdReport;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_mopub_common_AdReport_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_mopub_common_AdReport_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/mopub/common/AdReport;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_mopub_common_AdReport_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_mopub_common_AdReport_, __args);
			} finally {
			}
		}

		static Delegate cb_init_Z;
#pragma warning disable 0169
		static Delegate GetInit_ZHandler ()
		{
			if (cb_init_Z == null)
				cb_init_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_Init_Z);
			return cb_init_Z;
		}

		static void n_Init_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mopub.Mobileads.BaseHtmlWebView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseHtmlWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		static IntPtr id_init_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseHtmlWebView']/method[@name='init' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("init", "(Z)V", "GetInit_ZHandler")]
		public virtual unsafe void Init (bool p0)
		{
			if (id_init_Z == IntPtr.Zero)
				id_init_Z = JNIEnv.GetMethodID (class_ref, "init", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_init_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onResetUserClick;
#pragma warning disable 0169
		static Delegate GetOnResetUserClickHandler ()
		{
			if (cb_onResetUserClick == null)
				cb_onResetUserClick = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResetUserClick);
			return cb_onResetUserClick;
		}

		static void n_OnResetUserClick (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.BaseHtmlWebView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseHtmlWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResetUserClick ();
		}
#pragma warning restore 0169

		static IntPtr id_onResetUserClick;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseHtmlWebView']/method[@name='onResetUserClick' and count(parameter)=0]"
		[Register ("onResetUserClick", "()V", "GetOnResetUserClickHandler")]
		public virtual unsafe void OnResetUserClick ()
		{
			if (id_onResetUserClick == IntPtr.Zero)
				id_onResetUserClick = JNIEnv.GetMethodID (class_ref, "onResetUserClick", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onResetUserClick);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResetUserClick", "()V"));
			} finally {
			}
		}

		static Delegate cb_onUserClick;
#pragma warning disable 0169
		static Delegate GetOnUserClickHandler ()
		{
			if (cb_onUserClick == null)
				cb_onUserClick = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnUserClick);
			return cb_onUserClick;
		}

		static void n_OnUserClick (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.BaseHtmlWebView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseHtmlWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUserClick ();
		}
#pragma warning restore 0169

		static IntPtr id_onUserClick;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseHtmlWebView']/method[@name='onUserClick' and count(parameter)=0]"
		[Register ("onUserClick", "()V", "GetOnUserClickHandler")]
		public virtual unsafe void OnUserClick ()
		{
			if (id_onUserClick == IntPtr.Zero)
				id_onUserClick = JNIEnv.GetMethodID (class_ref, "onUserClick", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onUserClick);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUserClick", "()V"));
			} finally {
			}
		}

		static Delegate cb_wasClicked;
#pragma warning disable 0169
		static Delegate GetWasClickedHandler ()
		{
			if (cb_wasClicked == null)
				cb_wasClicked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_WasClicked);
			return cb_wasClicked;
		}

		static bool n_WasClicked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.BaseHtmlWebView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseHtmlWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WasClicked ();
		}
#pragma warning restore 0169

		static IntPtr id_wasClicked;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseHtmlWebView']/method[@name='wasClicked' and count(parameter)=0]"
		[Register ("wasClicked", "()Z", "GetWasClickedHandler")]
		public virtual unsafe bool WasClicked ()
		{
			if (id_wasClicked == IntPtr.Zero)
				id_wasClicked = JNIEnv.GetMethodID (class_ref, "wasClicked", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_wasClicked);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "wasClicked", "()Z"));
			} finally {
			}
		}

	}
}
