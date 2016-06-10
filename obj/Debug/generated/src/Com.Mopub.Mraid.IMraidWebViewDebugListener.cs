using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mraid {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidWebViewDebugListener']"
	[Register ("com/mopub/mraid/MraidWebViewDebugListener", "", "Com.Mopub.Mraid.IMraidWebViewDebugListenerInvoker")]
	public partial interface IMraidWebViewDebugListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidWebViewDebugListener']/method[@name='onConsoleMessage' and count(parameter)=1 and parameter[1][@type='android.webkit.ConsoleMessage']]"
		[Register ("onConsoleMessage", "(Landroid/webkit/ConsoleMessage;)Z", "GetOnConsoleMessage_Landroid_webkit_ConsoleMessage_Handler:Com.Mopub.Mraid.IMraidWebViewDebugListenerInvoker, AppodealXamarinPlugin")]
		bool OnConsoleMessage (global::Android.Webkit.ConsoleMessage p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidWebViewDebugListener']/method[@name='onJsAlert' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.webkit.JsResult']]"
		[Register ("onJsAlert", "(Ljava/lang/String;Landroid/webkit/JsResult;)Z", "GetOnJsAlert_Ljava_lang_String_Landroid_webkit_JsResult_Handler:Com.Mopub.Mraid.IMraidWebViewDebugListenerInvoker, AppodealXamarinPlugin")]
		bool OnJsAlert (string p0, global::Android.Webkit.JsResult p1);

	}

	[global::Android.Runtime.Register ("com/mopub/mraid/MraidWebViewDebugListener", DoNotGenerateAcw=true)]
	internal class IMraidWebViewDebugListenerInvoker : global::Java.Lang.Object, IMraidWebViewDebugListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mraid/MraidWebViewDebugListener");
		IntPtr class_ref;

		public static IMraidWebViewDebugListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMraidWebViewDebugListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mraid.MraidWebViewDebugListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMraidWebViewDebugListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMraidWebViewDebugListenerInvoker); }
		}

		static Delegate cb_onConsoleMessage_Landroid_webkit_ConsoleMessage_;
#pragma warning disable 0169
		static Delegate GetOnConsoleMessage_Landroid_webkit_ConsoleMessage_Handler ()
		{
			if (cb_onConsoleMessage_Landroid_webkit_ConsoleMessage_ == null)
				cb_onConsoleMessage_Landroid_webkit_ConsoleMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnConsoleMessage_Landroid_webkit_ConsoleMessage_);
			return cb_onConsoleMessage_Landroid_webkit_ConsoleMessage_;
		}

		static bool n_OnConsoleMessage_Landroid_webkit_ConsoleMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mraid.IMraidWebViewDebugListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.IMraidWebViewDebugListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Webkit.ConsoleMessage p0 = global::Java.Lang.Object.GetObject<global::Android.Webkit.ConsoleMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnConsoleMessage (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onConsoleMessage_Landroid_webkit_ConsoleMessage_;
		public unsafe bool OnConsoleMessage (global::Android.Webkit.ConsoleMessage p0)
		{
			if (id_onConsoleMessage_Landroid_webkit_ConsoleMessage_ == IntPtr.Zero)
				id_onConsoleMessage_Landroid_webkit_ConsoleMessage_ = JNIEnv.GetMethodID (class_ref, "onConsoleMessage", "(Landroid/webkit/ConsoleMessage;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onConsoleMessage_Landroid_webkit_ConsoleMessage_, __args);
			return __ret;
		}

		static Delegate cb_onJsAlert_Ljava_lang_String_Landroid_webkit_JsResult_;
#pragma warning disable 0169
		static Delegate GetOnJsAlert_Ljava_lang_String_Landroid_webkit_JsResult_Handler ()
		{
			if (cb_onJsAlert_Ljava_lang_String_Landroid_webkit_JsResult_ == null)
				cb_onJsAlert_Ljava_lang_String_Landroid_webkit_JsResult_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnJsAlert_Ljava_lang_String_Landroid_webkit_JsResult_);
			return cb_onJsAlert_Ljava_lang_String_Landroid_webkit_JsResult_;
		}

		static bool n_OnJsAlert_Ljava_lang_String_Landroid_webkit_JsResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Mraid.IMraidWebViewDebugListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.IMraidWebViewDebugListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Webkit.JsResult p1 = global::Java.Lang.Object.GetObject<global::Android.Webkit.JsResult> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnJsAlert (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onJsAlert_Ljava_lang_String_Landroid_webkit_JsResult_;
		public unsafe bool OnJsAlert (string p0, global::Android.Webkit.JsResult p1)
		{
			if (id_onJsAlert_Ljava_lang_String_Landroid_webkit_JsResult_ == IntPtr.Zero)
				id_onJsAlert_Ljava_lang_String_Landroid_webkit_JsResult_ = JNIEnv.GetMethodID (class_ref, "onJsAlert", "(Ljava/lang/String;Landroid/webkit/JsResult;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onJsAlert_Ljava_lang_String_Landroid_webkit_JsResult_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

	public partial class ConsoleMessageEventArgs : global::System.EventArgs {

		public ConsoleMessageEventArgs (bool handled, global::Android.Webkit.ConsoleMessage p0)
		{
			this.handled = handled;
			this.p0 = p0;
		}

		bool handled;
		public bool Handled {
			get { return handled; }
			set { handled = value; }
		}

		global::Android.Webkit.ConsoleMessage p0;
		public global::Android.Webkit.ConsoleMessage P0 {
			get { return p0; }
		}
	}

	public partial class JsAlertEventArgs : global::System.EventArgs {

		public JsAlertEventArgs (bool handled, string p0, global::Android.Webkit.JsResult p1)
		{
			this.handled = handled;
			this.p0 = p0;
			this.p1 = p1;
		}

		bool handled;
		public bool Handled {
			get { return handled; }
			set { handled = value; }
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		global::Android.Webkit.JsResult p1;
		public global::Android.Webkit.JsResult P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mopub/mraid/MraidWebViewDebugListenerImplementor")]
	internal sealed partial class IMraidWebViewDebugListenerImplementor : global::Java.Lang.Object, IMraidWebViewDebugListener {

		object sender;

		public IMraidWebViewDebugListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/mraid/MraidWebViewDebugListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ConsoleMessageEventArgs> OnConsoleMessageHandler;
#pragma warning restore 0649

		public bool OnConsoleMessage (global::Android.Webkit.ConsoleMessage p0)
		{
			var __h = OnConsoleMessageHandler;
			if (__h == null)
				return false;
			var __e = new ConsoleMessageEventArgs (true, p0);
			__h (sender, __e);
			return __e.Handled;
		}
#pragma warning disable 0649
		public EventHandler<JsAlertEventArgs> OnJsAlertHandler;
#pragma warning restore 0649

		public bool OnJsAlert (string p0, global::Android.Webkit.JsResult p1)
		{
			var __h = OnJsAlertHandler;
			if (__h == null)
				return false;
			var __e = new JsAlertEventArgs (true, p0, p1);
			__h (sender, __e);
			return __e.Handled;
		}

		internal static bool __IsEmpty (IMraidWebViewDebugListenerImplementor value)
		{
			return value.OnConsoleMessageHandler == null && value.OnJsAlertHandler == null;
		}
	}

}
