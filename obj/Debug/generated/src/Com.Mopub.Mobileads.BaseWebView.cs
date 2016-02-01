using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseWebView']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/BaseWebView", DoNotGenerateAcw=true)]
	public partial class BaseWebView : global::Android.Webkit.WebView {


		static IntPtr mIsDestroyed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseWebView']/field[@name='mIsDestroyed']"
		[Register ("mIsDestroyed")]
		protected bool MIsDestroyed {
			get {
				if (mIsDestroyed_jfieldId == IntPtr.Zero)
					mIsDestroyed_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsDestroyed", "Z");
				return JNIEnv.GetBooleanField (Handle, mIsDestroyed_jfieldId);
			}
			set {
				if (mIsDestroyed_jfieldId == IntPtr.Zero)
					mIsDestroyed_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsDestroyed", "Z");
				try {
					JNIEnv.SetField (Handle, mIsDestroyed_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/BaseWebView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseWebView); }
		}

		protected BaseWebView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseWebView']/constructor[@name='BaseWebView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BaseWebView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BaseWebView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_enablePlugins_Z;
#pragma warning disable 0169
		static Delegate GetEnablePlugins_ZHandler ()
		{
			if (cb_enablePlugins_Z == null)
				cb_enablePlugins_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_EnablePlugins_Z);
			return cb_enablePlugins_Z;
		}

		static void n_EnablePlugins_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mopub.Mobileads.BaseWebView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnablePlugins (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enablePlugins_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseWebView']/method[@name='enablePlugins' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enablePlugins", "(Z)V", "GetEnablePlugins_ZHandler")]
		protected virtual unsafe void EnablePlugins (bool p0)
		{
			if (id_enablePlugins_Z == IntPtr.Zero)
				id_enablePlugins_Z = JNIEnv.GetMethodID (class_ref, "enablePlugins", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_enablePlugins_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enablePlugins", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
