using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Mraid {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/interface[@name='MRAIDNativeFeatureListener']"
	[Register ("org/nexage/sourcekit/mraid/MRAIDNativeFeatureListener", "", "Org.Nexage.Sourcekit.Mraid.IMRAIDNativeFeatureListenerInvoker")]
	public partial interface IMRAIDNativeFeatureListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/interface[@name='MRAIDNativeFeatureListener']/method[@name='mraidNativeFeatureCallTel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("mraidNativeFeatureCallTel", "(Ljava/lang/String;)V", "GetMraidNativeFeatureCallTel_Ljava_lang_String_Handler:Org.Nexage.Sourcekit.Mraid.IMRAIDNativeFeatureListenerInvoker, AppodealXamarinPlugin")]
		void MraidNativeFeatureCallTel (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/interface[@name='MRAIDNativeFeatureListener']/method[@name='mraidNativeFeatureCreateCalendarEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("mraidNativeFeatureCreateCalendarEvent", "(Ljava/lang/String;)V", "GetMraidNativeFeatureCreateCalendarEvent_Ljava_lang_String_Handler:Org.Nexage.Sourcekit.Mraid.IMRAIDNativeFeatureListenerInvoker, AppodealXamarinPlugin")]
		void MraidNativeFeatureCreateCalendarEvent (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/interface[@name='MRAIDNativeFeatureListener']/method[@name='mraidNativeFeatureOpenBrowser' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.webkit.WebView']]"
		[Register ("mraidNativeFeatureOpenBrowser", "(Ljava/lang/String;Landroid/webkit/WebView;)V", "GetMraidNativeFeatureOpenBrowser_Ljava_lang_String_Landroid_webkit_WebView_Handler:Org.Nexage.Sourcekit.Mraid.IMRAIDNativeFeatureListenerInvoker, AppodealXamarinPlugin")]
		void MraidNativeFeatureOpenBrowser (string p0, global::Android.Webkit.WebView p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/interface[@name='MRAIDNativeFeatureListener']/method[@name='mraidNativeFeaturePlayVideo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("mraidNativeFeaturePlayVideo", "(Ljava/lang/String;)V", "GetMraidNativeFeaturePlayVideo_Ljava_lang_String_Handler:Org.Nexage.Sourcekit.Mraid.IMRAIDNativeFeatureListenerInvoker, AppodealXamarinPlugin")]
		void MraidNativeFeaturePlayVideo (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/interface[@name='MRAIDNativeFeatureListener']/method[@name='mraidNativeFeatureSendSms' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("mraidNativeFeatureSendSms", "(Ljava/lang/String;)V", "GetMraidNativeFeatureSendSms_Ljava_lang_String_Handler:Org.Nexage.Sourcekit.Mraid.IMRAIDNativeFeatureListenerInvoker, AppodealXamarinPlugin")]
		void MraidNativeFeatureSendSms (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/interface[@name='MRAIDNativeFeatureListener']/method[@name='mraidNativeFeatureStorePicture' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("mraidNativeFeatureStorePicture", "(Ljava/lang/String;)V", "GetMraidNativeFeatureStorePicture_Ljava_lang_String_Handler:Org.Nexage.Sourcekit.Mraid.IMRAIDNativeFeatureListenerInvoker, AppodealXamarinPlugin")]
		void MraidNativeFeatureStorePicture (string p0);

	}

	[global::Android.Runtime.Register ("org/nexage/sourcekit/mraid/MRAIDNativeFeatureListener", DoNotGenerateAcw=true)]
	internal class IMRAIDNativeFeatureListenerInvoker : global::Java.Lang.Object, IMRAIDNativeFeatureListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/nexage/sourcekit/mraid/MRAIDNativeFeatureListener");
		IntPtr class_ref;

		public static IMRAIDNativeFeatureListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMRAIDNativeFeatureListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.nexage.sourcekit.mraid.MRAIDNativeFeatureListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMRAIDNativeFeatureListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMRAIDNativeFeatureListenerInvoker); }
		}

		static Delegate cb_mraidNativeFeatureCallTel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMraidNativeFeatureCallTel_Ljava_lang_String_Handler ()
		{
			if (cb_mraidNativeFeatureCallTel_Ljava_lang_String_ == null)
				cb_mraidNativeFeatureCallTel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MraidNativeFeatureCallTel_Ljava_lang_String_);
			return cb_mraidNativeFeatureCallTel_Ljava_lang_String_;
		}

		static void n_MraidNativeFeatureCallTel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Mraid.IMRAIDNativeFeatureListener __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.IMRAIDNativeFeatureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MraidNativeFeatureCallTel (p0);
		}
#pragma warning restore 0169

		IntPtr id_mraidNativeFeatureCallTel_Ljava_lang_String_;
		public unsafe void MraidNativeFeatureCallTel (string p0)
		{
			if (id_mraidNativeFeatureCallTel_Ljava_lang_String_ == IntPtr.Zero)
				id_mraidNativeFeatureCallTel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "mraidNativeFeatureCallTel", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_mraidNativeFeatureCallTel_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_mraidNativeFeatureCreateCalendarEvent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMraidNativeFeatureCreateCalendarEvent_Ljava_lang_String_Handler ()
		{
			if (cb_mraidNativeFeatureCreateCalendarEvent_Ljava_lang_String_ == null)
				cb_mraidNativeFeatureCreateCalendarEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MraidNativeFeatureCreateCalendarEvent_Ljava_lang_String_);
			return cb_mraidNativeFeatureCreateCalendarEvent_Ljava_lang_String_;
		}

		static void n_MraidNativeFeatureCreateCalendarEvent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Mraid.IMRAIDNativeFeatureListener __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.IMRAIDNativeFeatureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MraidNativeFeatureCreateCalendarEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_mraidNativeFeatureCreateCalendarEvent_Ljava_lang_String_;
		public unsafe void MraidNativeFeatureCreateCalendarEvent (string p0)
		{
			if (id_mraidNativeFeatureCreateCalendarEvent_Ljava_lang_String_ == IntPtr.Zero)
				id_mraidNativeFeatureCreateCalendarEvent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "mraidNativeFeatureCreateCalendarEvent", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_mraidNativeFeatureCreateCalendarEvent_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_mraidNativeFeatureOpenBrowser_Ljava_lang_String_Landroid_webkit_WebView_;
#pragma warning disable 0169
		static Delegate GetMraidNativeFeatureOpenBrowser_Ljava_lang_String_Landroid_webkit_WebView_Handler ()
		{
			if (cb_mraidNativeFeatureOpenBrowser_Ljava_lang_String_Landroid_webkit_WebView_ == null)
				cb_mraidNativeFeatureOpenBrowser_Ljava_lang_String_Landroid_webkit_WebView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_MraidNativeFeatureOpenBrowser_Ljava_lang_String_Landroid_webkit_WebView_);
			return cb_mraidNativeFeatureOpenBrowser_Ljava_lang_String_Landroid_webkit_WebView_;
		}

		static void n_MraidNativeFeatureOpenBrowser_Ljava_lang_String_Landroid_webkit_WebView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Nexage.Sourcekit.Mraid.IMRAIDNativeFeatureListener __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.IMRAIDNativeFeatureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Webkit.WebView p1 = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.MraidNativeFeatureOpenBrowser (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_mraidNativeFeatureOpenBrowser_Ljava_lang_String_Landroid_webkit_WebView_;
		public unsafe void MraidNativeFeatureOpenBrowser (string p0, global::Android.Webkit.WebView p1)
		{
			if (id_mraidNativeFeatureOpenBrowser_Ljava_lang_String_Landroid_webkit_WebView_ == IntPtr.Zero)
				id_mraidNativeFeatureOpenBrowser_Ljava_lang_String_Landroid_webkit_WebView_ = JNIEnv.GetMethodID (class_ref, "mraidNativeFeatureOpenBrowser", "(Ljava/lang/String;Landroid/webkit/WebView;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_mraidNativeFeatureOpenBrowser_Ljava_lang_String_Landroid_webkit_WebView_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_mraidNativeFeaturePlayVideo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMraidNativeFeaturePlayVideo_Ljava_lang_String_Handler ()
		{
			if (cb_mraidNativeFeaturePlayVideo_Ljava_lang_String_ == null)
				cb_mraidNativeFeaturePlayVideo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MraidNativeFeaturePlayVideo_Ljava_lang_String_);
			return cb_mraidNativeFeaturePlayVideo_Ljava_lang_String_;
		}

		static void n_MraidNativeFeaturePlayVideo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Mraid.IMRAIDNativeFeatureListener __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.IMRAIDNativeFeatureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MraidNativeFeaturePlayVideo (p0);
		}
#pragma warning restore 0169

		IntPtr id_mraidNativeFeaturePlayVideo_Ljava_lang_String_;
		public unsafe void MraidNativeFeaturePlayVideo (string p0)
		{
			if (id_mraidNativeFeaturePlayVideo_Ljava_lang_String_ == IntPtr.Zero)
				id_mraidNativeFeaturePlayVideo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "mraidNativeFeaturePlayVideo", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_mraidNativeFeaturePlayVideo_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_mraidNativeFeatureSendSms_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMraidNativeFeatureSendSms_Ljava_lang_String_Handler ()
		{
			if (cb_mraidNativeFeatureSendSms_Ljava_lang_String_ == null)
				cb_mraidNativeFeatureSendSms_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MraidNativeFeatureSendSms_Ljava_lang_String_);
			return cb_mraidNativeFeatureSendSms_Ljava_lang_String_;
		}

		static void n_MraidNativeFeatureSendSms_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Mraid.IMRAIDNativeFeatureListener __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.IMRAIDNativeFeatureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MraidNativeFeatureSendSms (p0);
		}
#pragma warning restore 0169

		IntPtr id_mraidNativeFeatureSendSms_Ljava_lang_String_;
		public unsafe void MraidNativeFeatureSendSms (string p0)
		{
			if (id_mraidNativeFeatureSendSms_Ljava_lang_String_ == IntPtr.Zero)
				id_mraidNativeFeatureSendSms_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "mraidNativeFeatureSendSms", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_mraidNativeFeatureSendSms_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_mraidNativeFeatureStorePicture_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMraidNativeFeatureStorePicture_Ljava_lang_String_Handler ()
		{
			if (cb_mraidNativeFeatureStorePicture_Ljava_lang_String_ == null)
				cb_mraidNativeFeatureStorePicture_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MraidNativeFeatureStorePicture_Ljava_lang_String_);
			return cb_mraidNativeFeatureStorePicture_Ljava_lang_String_;
		}

		static void n_MraidNativeFeatureStorePicture_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Mraid.IMRAIDNativeFeatureListener __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.IMRAIDNativeFeatureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MraidNativeFeatureStorePicture (p0);
		}
#pragma warning restore 0169

		IntPtr id_mraidNativeFeatureStorePicture_Ljava_lang_String_;
		public unsafe void MraidNativeFeatureStorePicture (string p0)
		{
			if (id_mraidNativeFeatureStorePicture_Ljava_lang_String_ == IntPtr.Zero)
				id_mraidNativeFeatureStorePicture_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "mraidNativeFeatureStorePicture", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_mraidNativeFeatureStorePicture_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	public partial class MraidNativeFeatureCallTelEventArgs : global::System.EventArgs {

		public MraidNativeFeatureCallTelEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	public partial class MraidNativeFeatureCreateCalendarEventEventArgs : global::System.EventArgs {

		public MraidNativeFeatureCreateCalendarEventEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	public partial class MraidNativeFeatureOpenBrowserEventArgs : global::System.EventArgs {

		public MraidNativeFeatureOpenBrowserEventArgs (string p0, global::Android.Webkit.WebView p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		global::Android.Webkit.WebView p1;
		public global::Android.Webkit.WebView P1 {
			get { return p1; }
		}
	}

	public partial class MraidNativeFeaturePlayVideoEventArgs : global::System.EventArgs {

		public MraidNativeFeaturePlayVideoEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	public partial class MraidNativeFeatureSendSmsEventArgs : global::System.EventArgs {

		public MraidNativeFeatureSendSmsEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	public partial class MraidNativeFeatureStorePictureEventArgs : global::System.EventArgs {

		public MraidNativeFeatureStorePictureEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/org/nexage/sourcekit/mraid/MRAIDNativeFeatureListenerImplementor")]
	internal sealed partial class IMRAIDNativeFeatureListenerImplementor : global::Java.Lang.Object, IMRAIDNativeFeatureListener {

		object sender;

		public IMRAIDNativeFeatureListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/nexage/sourcekit/mraid/MRAIDNativeFeatureListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MraidNativeFeatureCallTelEventArgs> MraidNativeFeatureCallTelHandler;
#pragma warning restore 0649

		public void MraidNativeFeatureCallTel (string p0)
		{
			var __h = MraidNativeFeatureCallTelHandler;
			if (__h != null)
				__h (sender, new MraidNativeFeatureCallTelEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<MraidNativeFeatureCreateCalendarEventEventArgs> MraidNativeFeatureCreateCalendarEventHandler;
#pragma warning restore 0649

		public void MraidNativeFeatureCreateCalendarEvent (string p0)
		{
			var __h = MraidNativeFeatureCreateCalendarEventHandler;
			if (__h != null)
				__h (sender, new MraidNativeFeatureCreateCalendarEventEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<MraidNativeFeatureOpenBrowserEventArgs> MraidNativeFeatureOpenBrowserHandler;
#pragma warning restore 0649

		public void MraidNativeFeatureOpenBrowser (string p0, global::Android.Webkit.WebView p1)
		{
			var __h = MraidNativeFeatureOpenBrowserHandler;
			if (__h != null)
				__h (sender, new MraidNativeFeatureOpenBrowserEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<MraidNativeFeaturePlayVideoEventArgs> MraidNativeFeaturePlayVideoHandler;
#pragma warning restore 0649

		public void MraidNativeFeaturePlayVideo (string p0)
		{
			var __h = MraidNativeFeaturePlayVideoHandler;
			if (__h != null)
				__h (sender, new MraidNativeFeaturePlayVideoEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<MraidNativeFeatureSendSmsEventArgs> MraidNativeFeatureSendSmsHandler;
#pragma warning restore 0649

		public void MraidNativeFeatureSendSms (string p0)
		{
			var __h = MraidNativeFeatureSendSmsHandler;
			if (__h != null)
				__h (sender, new MraidNativeFeatureSendSmsEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<MraidNativeFeatureStorePictureEventArgs> MraidNativeFeatureStorePictureHandler;
#pragma warning restore 0649

		public void MraidNativeFeatureStorePicture (string p0)
		{
			var __h = MraidNativeFeatureStorePictureHandler;
			if (__h != null)
				__h (sender, new MraidNativeFeatureStorePictureEventArgs (p0));
		}

		internal static bool __IsEmpty (IMRAIDNativeFeatureListenerImplementor value)
		{
			return value.MraidNativeFeatureCallTelHandler == null && value.MraidNativeFeatureCreateCalendarEventHandler == null && value.MraidNativeFeatureOpenBrowserHandler == null && value.MraidNativeFeaturePlayVideoHandler == null && value.MraidNativeFeatureSendSmsHandler == null && value.MraidNativeFeatureStorePictureHandler == null;
		}
	}

}
