using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='AppodealRequestCallbacks']"
	[Register ("com/appodeal/ads/AppodealRequestCallbacks", "", "Com.Appodeal.Ads.IAppodealRequestCallbacksInvoker")]
	public partial interface IAppodealRequestCallbacks : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='AppodealRequestCallbacks']/method[@name='onClick' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onClick", "(ILjava/lang/String;)V", "GetOnClick_ILjava_lang_String_Handler:Com.Appodeal.Ads.IAppodealRequestCallbacksInvoker, AppodealXamarinPlugin")]
		void OnClick (int p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='AppodealRequestCallbacks']/method[@name='onImpression' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onImpression", "(ILjava/lang/String;)V", "GetOnImpression_ILjava_lang_String_Handler:Com.Appodeal.Ads.IAppodealRequestCallbacksInvoker, AppodealXamarinPlugin")]
		void OnImpression (int p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='AppodealRequestCallbacks']/method[@name='onRequestFinish' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("onRequestFinish", "(ILjava/lang/String;Z)V", "GetOnRequestFinish_ILjava_lang_String_ZHandler:Com.Appodeal.Ads.IAppodealRequestCallbacksInvoker, AppodealXamarinPlugin")]
		void OnRequestFinish (int p0, string p1, bool p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='AppodealRequestCallbacks']/method[@name='onRequestStart' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("onRequestStart", "(ILjava/lang/String;Ljava/lang/String;)V", "GetOnRequestStart_ILjava_lang_String_Ljava_lang_String_Handler:Com.Appodeal.Ads.IAppodealRequestCallbacksInvoker, AppodealXamarinPlugin")]
		void OnRequestStart (int p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='AppodealRequestCallbacks']/method[@name='onWaterfallFinish' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("onWaterfallFinish", "(IZ)V", "GetOnWaterfallFinish_IZHandler:Com.Appodeal.Ads.IAppodealRequestCallbacksInvoker, AppodealXamarinPlugin")]
		void OnWaterfallFinish (int p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='AppodealRequestCallbacks']/method[@name='onWaterfallStart' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onWaterfallStart", "(I)V", "GetOnWaterfallStart_IHandler:Com.Appodeal.Ads.IAppodealRequestCallbacksInvoker, AppodealXamarinPlugin")]
		void OnWaterfallStart (int p0);

	}

	[global::Android.Runtime.Register ("com/appodeal/ads/AppodealRequestCallbacks", DoNotGenerateAcw=true)]
	internal class IAppodealRequestCallbacksInvoker : global::Java.Lang.Object, IAppodealRequestCallbacks {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/appodeal/ads/AppodealRequestCallbacks");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAppodealRequestCallbacksInvoker); }
		}

		IntPtr class_ref;

		public static IAppodealRequestCallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAppodealRequestCallbacks> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.appodeal.ads.AppodealRequestCallbacks"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAppodealRequestCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onClick_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnClick_ILjava_lang_String_Handler ()
		{
			if (cb_onClick_ILjava_lang_String_ == null)
				cb_onClick_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnClick_ILjava_lang_String_);
			return cb_onClick_ILjava_lang_String_;
		}

		static void n_OnClick_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Appodeal.Ads.IAppodealRequestCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.IAppodealRequestCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onClick_ILjava_lang_String_;
		public unsafe void OnClick (int p0, string p1)
		{
			if (id_onClick_ILjava_lang_String_ == IntPtr.Zero)
				id_onClick_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onClick", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onImpression_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnImpression_ILjava_lang_String_Handler ()
		{
			if (cb_onImpression_ILjava_lang_String_ == null)
				cb_onImpression_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnImpression_ILjava_lang_String_);
			return cb_onImpression_ILjava_lang_String_;
		}

		static void n_OnImpression_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Appodeal.Ads.IAppodealRequestCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.IAppodealRequestCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnImpression (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onImpression_ILjava_lang_String_;
		public unsafe void OnImpression (int p0, string p1)
		{
			if (id_onImpression_ILjava_lang_String_ == IntPtr.Zero)
				id_onImpression_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onImpression", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onImpression_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onRequestFinish_ILjava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetOnRequestFinish_ILjava_lang_String_ZHandler ()
		{
			if (cb_onRequestFinish_ILjava_lang_String_Z == null)
				cb_onRequestFinish_ILjava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, bool>) n_OnRequestFinish_ILjava_lang_String_Z);
			return cb_onRequestFinish_ILjava_lang_String_Z;
		}

		static void n_OnRequestFinish_ILjava_lang_String_Z (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, bool p2)
		{
			global::Com.Appodeal.Ads.IAppodealRequestCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.IAppodealRequestCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRequestFinish (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onRequestFinish_ILjava_lang_String_Z;
		public unsafe void OnRequestFinish (int p0, string p1, bool p2)
		{
			if (id_onRequestFinish_ILjava_lang_String_Z == IntPtr.Zero)
				id_onRequestFinish_ILjava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "onRequestFinish", "(ILjava/lang/String;Z)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRequestFinish_ILjava_lang_String_Z, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onRequestStart_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnRequestStart_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onRequestStart_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_onRequestStart_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnRequestStart_ILjava_lang_String_Ljava_lang_String_);
			return cb_onRequestStart_ILjava_lang_String_Ljava_lang_String_;
		}

		static void n_OnRequestStart_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Appodeal.Ads.IAppodealRequestCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.IAppodealRequestCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnRequestStart (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onRequestStart_ILjava_lang_String_Ljava_lang_String_;
		public unsafe void OnRequestStart (int p0, string p1, string p2)
		{
			if (id_onRequestStart_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onRequestStart_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onRequestStart", "(ILjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRequestStart_ILjava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_onWaterfallFinish_IZ;
#pragma warning disable 0169
		static Delegate GetOnWaterfallFinish_IZHandler ()
		{
			if (cb_onWaterfallFinish_IZ == null)
				cb_onWaterfallFinish_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_OnWaterfallFinish_IZ);
			return cb_onWaterfallFinish_IZ;
		}

		static void n_OnWaterfallFinish_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Appodeal.Ads.IAppodealRequestCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.IAppodealRequestCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnWaterfallFinish (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onWaterfallFinish_IZ;
		public unsafe void OnWaterfallFinish (int p0, bool p1)
		{
			if (id_onWaterfallFinish_IZ == IntPtr.Zero)
				id_onWaterfallFinish_IZ = JNIEnv.GetMethodID (class_ref, "onWaterfallFinish", "(IZ)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWaterfallFinish_IZ, __args);
		}

		static Delegate cb_onWaterfallStart_I;
#pragma warning disable 0169
		static Delegate GetOnWaterfallStart_IHandler ()
		{
			if (cb_onWaterfallStart_I == null)
				cb_onWaterfallStart_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnWaterfallStart_I);
			return cb_onWaterfallStart_I;
		}

		static void n_OnWaterfallStart_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Appodeal.Ads.IAppodealRequestCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.IAppodealRequestCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnWaterfallStart (p0);
		}
#pragma warning restore 0169

		IntPtr id_onWaterfallStart_I;
		public unsafe void OnWaterfallStart (int p0)
		{
			if (id_onWaterfallStart_I == IntPtr.Zero)
				id_onWaterfallStart_I = JNIEnv.GetMethodID (class_ref, "onWaterfallStart", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWaterfallStart_I, __args);
		}

	}

}
