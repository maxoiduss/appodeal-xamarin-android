using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mraid {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidBridge']"
	[global::Android.Runtime.Register ("com/mopub/mraid/MraidBridge", DoNotGenerateAcw=true)]
	public partial class MraidBridge : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidBridge.MraidBridgeListener']"
		[Register ("com/mopub/mraid/MraidBridge$MraidBridgeListener", "", "Com.Mopub.Mraid.MraidBridge/IMraidBridgeListenerInvoker")]
		public partial interface IMraidBridgeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidBridge.MraidBridgeListener']/method[@name='onClose' and count(parameter)=0]"
			[Register ("onClose", "()V", "GetOnCloseHandler:Com.Mopub.Mraid.MraidBridge/IMraidBridgeListenerInvoker, AppodealXamarinPlugin")]
			void OnClose ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidBridge.MraidBridgeListener']/method[@name='onConsoleMessage' and count(parameter)=1 and parameter[1][@type='android.webkit.ConsoleMessage']]"
			[Register ("onConsoleMessage", "(Landroid/webkit/ConsoleMessage;)Z", "GetOnConsoleMessage_Landroid_webkit_ConsoleMessage_Handler:Com.Mopub.Mraid.MraidBridge/IMraidBridgeListenerInvoker, AppodealXamarinPlugin")]
			bool OnConsoleMessage (global::Android.Webkit.ConsoleMessage p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidBridge.MraidBridgeListener']/method[@name='onExpand' and count(parameter)=2 and parameter[1][@type='java.net.URI'] and parameter[2][@type='boolean']]"
			[Register ("onExpand", "(Ljava/net/URI;Z)V", "GetOnExpand_Ljava_net_URI_ZHandler:Com.Mopub.Mraid.MraidBridge/IMraidBridgeListenerInvoker, AppodealXamarinPlugin")]
			void OnExpand (global::Java.Net.URI p0, bool p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidBridge.MraidBridgeListener']/method[@name='onJsAlert' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.webkit.JsResult']]"
			[Register ("onJsAlert", "(Ljava/lang/String;Landroid/webkit/JsResult;)Z", "GetOnJsAlert_Ljava_lang_String_Landroid_webkit_JsResult_Handler:Com.Mopub.Mraid.MraidBridge/IMraidBridgeListenerInvoker, AppodealXamarinPlugin")]
			bool OnJsAlert (string p0, global::Android.Webkit.JsResult p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidBridge.MraidBridgeListener']/method[@name='onOpen' and count(parameter)=1 and parameter[1][@type='java.net.URI']]"
			[Register ("onOpen", "(Ljava/net/URI;)V", "GetOnOpen_Ljava_net_URI_Handler:Com.Mopub.Mraid.MraidBridge/IMraidBridgeListenerInvoker, AppodealXamarinPlugin")]
			void OnOpen (global::Java.Net.URI p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidBridge.MraidBridgeListener']/method[@name='onPageFailedToLoad' and count(parameter)=0]"
			[Register ("onPageFailedToLoad", "()V", "GetOnPageFailedToLoadHandler:Com.Mopub.Mraid.MraidBridge/IMraidBridgeListenerInvoker, AppodealXamarinPlugin")]
			void OnPageFailedToLoad ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidBridge.MraidBridgeListener']/method[@name='onPageLoaded' and count(parameter)=0]"
			[Register ("onPageLoaded", "()V", "GetOnPageLoadedHandler:Com.Mopub.Mraid.MraidBridge/IMraidBridgeListenerInvoker, AppodealXamarinPlugin")]
			void OnPageLoaded ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidBridge.MraidBridgeListener']/method[@name='onPlayVideo' and count(parameter)=1 and parameter[1][@type='java.net.URI']]"
			[Register ("onPlayVideo", "(Ljava/net/URI;)V", "GetOnPlayVideo_Ljava_net_URI_Handler:Com.Mopub.Mraid.MraidBridge/IMraidBridgeListenerInvoker, AppodealXamarinPlugin")]
			void OnPlayVideo (global::Java.Net.URI p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidBridge.MraidBridgeListener']/method[@name='onResize' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.mopub.common.CloseableLayout.ClosePosition'] and parameter[6][@type='boolean']]"
			[Register ("onResize", "(IIIILcom/mopub/common/CloseableLayout$ClosePosition;Z)V", "GetOnResize_IIIILcom_mopub_common_CloseableLayout_ClosePosition_ZHandler:Com.Mopub.Mraid.MraidBridge/IMraidBridgeListenerInvoker, AppodealXamarinPlugin")]
			void OnResize (int p0, int p1, int p2, int p3, global::Com.Mopub.Common.CloseableLayout.ClosePosition p4, bool p5);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidBridge.MraidBridgeListener']/method[@name='onUseCustomClose' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("onUseCustomClose", "(Z)V", "GetOnUseCustomClose_ZHandler:Com.Mopub.Mraid.MraidBridge/IMraidBridgeListenerInvoker, AppodealXamarinPlugin")]
			void OnUseCustomClose (bool p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidBridge.MraidBridgeListener']/method[@name='onVisibilityChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("onVisibilityChanged", "(Z)V", "GetOnVisibilityChanged_ZHandler:Com.Mopub.Mraid.MraidBridge/IMraidBridgeListenerInvoker, AppodealXamarinPlugin")]
			void OnVisibilityChanged (bool p0);

		}

		[global::Android.Runtime.Register ("com/mopub/mraid/MraidBridge$MraidBridgeListener", DoNotGenerateAcw=true)]
		internal class IMraidBridgeListenerInvoker : global::Java.Lang.Object, IMraidBridgeListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mraid/MraidBridge$MraidBridgeListener");
			IntPtr class_ref;

			public static IMraidBridgeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMraidBridgeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mraid.MraidBridge.MraidBridgeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMraidBridgeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IMraidBridgeListenerInvoker); }
			}

			static Delegate cb_onClose;
#pragma warning disable 0169
			static Delegate GetOnCloseHandler ()
			{
				if (cb_onClose == null)
					cb_onClose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnClose);
				return cb_onClose;
			}

			static void n_OnClose (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mraid.MraidBridge.IMraidBridgeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidBridge.IMraidBridgeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnClose ();
			}
#pragma warning restore 0169

			IntPtr id_onClose;
			public unsafe void OnClose ()
			{
				if (id_onClose == IntPtr.Zero)
					id_onClose = JNIEnv.GetMethodID (class_ref, "onClose", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onClose);
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
				global::Com.Mopub.Mraid.MraidBridge.IMraidBridgeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidBridge.IMraidBridgeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static Delegate cb_onExpand_Ljava_net_URI_Z;
#pragma warning disable 0169
			static Delegate GetOnExpand_Ljava_net_URI_ZHandler ()
			{
				if (cb_onExpand_Ljava_net_URI_Z == null)
					cb_onExpand_Ljava_net_URI_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnExpand_Ljava_net_URI_Z);
				return cb_onExpand_Ljava_net_URI_Z;
			}

			static void n_OnExpand_Ljava_net_URI_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
			{
				global::Com.Mopub.Mraid.MraidBridge.IMraidBridgeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidBridge.IMraidBridgeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Net.URI p0 = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnExpand (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onExpand_Ljava_net_URI_Z;
			public unsafe void OnExpand (global::Java.Net.URI p0, bool p1)
			{
				if (id_onExpand_Ljava_net_URI_Z == IntPtr.Zero)
					id_onExpand_Ljava_net_URI_Z = JNIEnv.GetMethodID (class_ref, "onExpand", "(Ljava/net/URI;Z)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_onExpand_Ljava_net_URI_Z, __args);
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
				global::Com.Mopub.Mraid.MraidBridge.IMraidBridgeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidBridge.IMraidBridgeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static Delegate cb_onOpen_Ljava_net_URI_;
#pragma warning disable 0169
			static Delegate GetOnOpen_Ljava_net_URI_Handler ()
			{
				if (cb_onOpen_Ljava_net_URI_ == null)
					cb_onOpen_Ljava_net_URI_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnOpen_Ljava_net_URI_);
				return cb_onOpen_Ljava_net_URI_;
			}

			static void n_OnOpen_Ljava_net_URI_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mraid.MraidBridge.IMraidBridgeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidBridge.IMraidBridgeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Net.URI p0 = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnOpen (p0);
			}
#pragma warning restore 0169

			IntPtr id_onOpen_Ljava_net_URI_;
			public unsafe void OnOpen (global::Java.Net.URI p0)
			{
				if (id_onOpen_Ljava_net_URI_ == IntPtr.Zero)
					id_onOpen_Ljava_net_URI_ = JNIEnv.GetMethodID (class_ref, "onOpen", "(Ljava/net/URI;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onOpen_Ljava_net_URI_, __args);
			}

			static Delegate cb_onPageFailedToLoad;
#pragma warning disable 0169
			static Delegate GetOnPageFailedToLoadHandler ()
			{
				if (cb_onPageFailedToLoad == null)
					cb_onPageFailedToLoad = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPageFailedToLoad);
				return cb_onPageFailedToLoad;
			}

			static void n_OnPageFailedToLoad (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mraid.MraidBridge.IMraidBridgeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidBridge.IMraidBridgeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPageFailedToLoad ();
			}
#pragma warning restore 0169

			IntPtr id_onPageFailedToLoad;
			public unsafe void OnPageFailedToLoad ()
			{
				if (id_onPageFailedToLoad == IntPtr.Zero)
					id_onPageFailedToLoad = JNIEnv.GetMethodID (class_ref, "onPageFailedToLoad", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onPageFailedToLoad);
			}

			static Delegate cb_onPageLoaded;
#pragma warning disable 0169
			static Delegate GetOnPageLoadedHandler ()
			{
				if (cb_onPageLoaded == null)
					cb_onPageLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPageLoaded);
				return cb_onPageLoaded;
			}

			static void n_OnPageLoaded (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mraid.MraidBridge.IMraidBridgeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidBridge.IMraidBridgeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPageLoaded ();
			}
#pragma warning restore 0169

			IntPtr id_onPageLoaded;
			public unsafe void OnPageLoaded ()
			{
				if (id_onPageLoaded == IntPtr.Zero)
					id_onPageLoaded = JNIEnv.GetMethodID (class_ref, "onPageLoaded", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onPageLoaded);
			}

			static Delegate cb_onPlayVideo_Ljava_net_URI_;
#pragma warning disable 0169
			static Delegate GetOnPlayVideo_Ljava_net_URI_Handler ()
			{
				if (cb_onPlayVideo_Ljava_net_URI_ == null)
					cb_onPlayVideo_Ljava_net_URI_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPlayVideo_Ljava_net_URI_);
				return cb_onPlayVideo_Ljava_net_URI_;
			}

			static void n_OnPlayVideo_Ljava_net_URI_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mraid.MraidBridge.IMraidBridgeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidBridge.IMraidBridgeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Net.URI p0 = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPlayVideo (p0);
			}
#pragma warning restore 0169

			IntPtr id_onPlayVideo_Ljava_net_URI_;
			public unsafe void OnPlayVideo (global::Java.Net.URI p0)
			{
				if (id_onPlayVideo_Ljava_net_URI_ == IntPtr.Zero)
					id_onPlayVideo_Ljava_net_URI_ = JNIEnv.GetMethodID (class_ref, "onPlayVideo", "(Ljava/net/URI;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onPlayVideo_Ljava_net_URI_, __args);
			}

			static Delegate cb_onResize_IIIILcom_mopub_common_CloseableLayout_ClosePosition_Z;
#pragma warning disable 0169
			static Delegate GetOnResize_IIIILcom_mopub_common_CloseableLayout_ClosePosition_ZHandler ()
			{
				if (cb_onResize_IIIILcom_mopub_common_CloseableLayout_ClosePosition_Z == null)
					cb_onResize_IIIILcom_mopub_common_CloseableLayout_ClosePosition_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int, IntPtr, bool>) n_OnResize_IIIILcom_mopub_common_CloseableLayout_ClosePosition_Z);
				return cb_onResize_IIIILcom_mopub_common_CloseableLayout_ClosePosition_Z;
			}

			static void n_OnResize_IIIILcom_mopub_common_CloseableLayout_ClosePosition_Z (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, IntPtr native_p4, bool p5)
			{
				global::Com.Mopub.Mraid.MraidBridge.IMraidBridgeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidBridge.IMraidBridgeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Common.CloseableLayout.ClosePosition p4 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CloseableLayout.ClosePosition> (native_p4, JniHandleOwnership.DoNotTransfer);
				__this.OnResize (p0, p1, p2, p3, p4, p5);
			}
#pragma warning restore 0169

			IntPtr id_onResize_IIIILcom_mopub_common_CloseableLayout_ClosePosition_Z;
			public unsafe void OnResize (int p0, int p1, int p2, int p3, global::Com.Mopub.Common.CloseableLayout.ClosePosition p4, bool p5)
			{
				if (id_onResize_IIIILcom_mopub_common_CloseableLayout_ClosePosition_Z == IntPtr.Zero)
					id_onResize_IIIILcom_mopub_common_CloseableLayout_ClosePosition_Z = JNIEnv.GetMethodID (class_ref, "onResize", "(IIIILcom/mopub/common/CloseableLayout$ClosePosition;Z)V");
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallVoidMethod (Handle, id_onResize_IIIILcom_mopub_common_CloseableLayout_ClosePosition_Z, __args);
			}

			static Delegate cb_onUseCustomClose_Z;
#pragma warning disable 0169
			static Delegate GetOnUseCustomClose_ZHandler ()
			{
				if (cb_onUseCustomClose_Z == null)
					cb_onUseCustomClose_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnUseCustomClose_Z);
				return cb_onUseCustomClose_Z;
			}

			static void n_OnUseCustomClose_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Mopub.Mraid.MraidBridge.IMraidBridgeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidBridge.IMraidBridgeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnUseCustomClose (p0);
			}
#pragma warning restore 0169

			IntPtr id_onUseCustomClose_Z;
			public unsafe void OnUseCustomClose (bool p0)
			{
				if (id_onUseCustomClose_Z == IntPtr.Zero)
					id_onUseCustomClose_Z = JNIEnv.GetMethodID (class_ref, "onUseCustomClose", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onUseCustomClose_Z, __args);
			}

			static Delegate cb_onVisibilityChanged_Z;
#pragma warning disable 0169
			static Delegate GetOnVisibilityChanged_ZHandler ()
			{
				if (cb_onVisibilityChanged_Z == null)
					cb_onVisibilityChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnVisibilityChanged_Z);
				return cb_onVisibilityChanged_Z;
			}

			static void n_OnVisibilityChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Mopub.Mraid.MraidBridge.IMraidBridgeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidBridge.IMraidBridgeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnVisibilityChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_onVisibilityChanged_Z;
			public unsafe void OnVisibilityChanged (bool p0)
			{
				if (id_onVisibilityChanged_Z == IntPtr.Zero)
					id_onVisibilityChanged_Z = JNIEnv.GetMethodID (class_ref, "onVisibilityChanged", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onVisibilityChanged_Z, __args);
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

		public partial class ExpandEventArgs : global::System.EventArgs {

			public ExpandEventArgs (global::Java.Net.URI p0, bool p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Java.Net.URI p0;
			public global::Java.Net.URI P0 {
				get { return p0; }
			}

			bool p1;
			public bool P1 {
				get { return p1; }
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

		public partial class OpenEventArgs : global::System.EventArgs {

			public OpenEventArgs (global::Java.Net.URI p0)
			{
				this.p0 = p0;
			}

			global::Java.Net.URI p0;
			public global::Java.Net.URI P0 {
				get { return p0; }
			}
		}

		public partial class PlayVideoEventArgs : global::System.EventArgs {

			public PlayVideoEventArgs (global::Java.Net.URI p0)
			{
				this.p0 = p0;
			}

			global::Java.Net.URI p0;
			public global::Java.Net.URI P0 {
				get { return p0; }
			}
		}

		public partial class ResizeEventArgs : global::System.EventArgs {

			public ResizeEventArgs (int p0, int p1, int p2, int p3, global::Com.Mopub.Common.CloseableLayout.ClosePosition p4, bool p5)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
				this.p4 = p4;
				this.p5 = p5;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}

			int p2;
			public int P2 {
				get { return p2; }
			}

			int p3;
			public int P3 {
				get { return p3; }
			}

			global::Com.Mopub.Common.CloseableLayout.ClosePosition p4;
			public global::Com.Mopub.Common.CloseableLayout.ClosePosition P4 {
				get { return p4; }
			}

			bool p5;
			public bool P5 {
				get { return p5; }
			}
		}

		public partial class UseCustomCloseEventArgs : global::System.EventArgs {

			public UseCustomCloseEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		public partial class VisibilityChangedEventArgs : global::System.EventArgs {

			public VisibilityChangedEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/mraid/MraidBridge_MraidBridgeListenerImplementor")]
		internal sealed partial class IMraidBridgeListenerImplementor : global::Java.Lang.Object, IMraidBridgeListener {

			object sender;

			public IMraidBridgeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/mraid/MraidBridge_MraidBridgeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnCloseHandler;
#pragma warning restore 0649

			public void OnClose ()
			{
				var __h = OnCloseHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
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
			public EventHandler<ExpandEventArgs> OnExpandHandler;
#pragma warning restore 0649

			public void OnExpand (global::Java.Net.URI p0, bool p1)
			{
				var __h = OnExpandHandler;
				if (__h != null)
					__h (sender, new ExpandEventArgs (p0, p1));
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
#pragma warning disable 0649
			public EventHandler<OpenEventArgs> OnOpenHandler;
#pragma warning restore 0649

			public void OnOpen (global::Java.Net.URI p0)
			{
				var __h = OnOpenHandler;
				if (__h != null)
					__h (sender, new OpenEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler OnPageFailedToLoadHandler;
#pragma warning restore 0649

			public void OnPageFailedToLoad ()
			{
				var __h = OnPageFailedToLoadHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnPageLoadedHandler;
#pragma warning restore 0649

			public void OnPageLoaded ()
			{
				var __h = OnPageLoadedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<PlayVideoEventArgs> OnPlayVideoHandler;
#pragma warning restore 0649

			public void OnPlayVideo (global::Java.Net.URI p0)
			{
				var __h = OnPlayVideoHandler;
				if (__h != null)
					__h (sender, new PlayVideoEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<ResizeEventArgs> OnResizeHandler;
#pragma warning restore 0649

			public void OnResize (int p0, int p1, int p2, int p3, global::Com.Mopub.Common.CloseableLayout.ClosePosition p4, bool p5)
			{
				var __h = OnResizeHandler;
				if (__h != null)
					__h (sender, new ResizeEventArgs (p0, p1, p2, p3, p4, p5));
			}
#pragma warning disable 0649
			public EventHandler<UseCustomCloseEventArgs> OnUseCustomCloseHandler;
#pragma warning restore 0649

			public void OnUseCustomClose (bool p0)
			{
				var __h = OnUseCustomCloseHandler;
				if (__h != null)
					__h (sender, new UseCustomCloseEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<VisibilityChangedEventArgs> OnVisibilityChangedHandler;
#pragma warning restore 0649

			public void OnVisibilityChanged (bool p0)
			{
				var __h = OnVisibilityChangedHandler;
				if (__h != null)
					__h (sender, new VisibilityChangedEventArgs (p0));
			}

			internal static bool __IsEmpty (IMraidBridgeListenerImplementor value)
			{
				return value.OnCloseHandler == null && value.OnConsoleMessageHandler == null && value.OnExpandHandler == null && value.OnJsAlertHandler == null && value.OnOpenHandler == null && value.OnPageFailedToLoadHandler == null && value.OnPageLoadedHandler == null && value.OnPlayVideoHandler == null && value.OnResizeHandler == null && value.OnUseCustomCloseHandler == null && value.OnVisibilityChangedHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidBridge.MraidWebView']"
		[global::Android.Runtime.Register ("com/mopub/mraid/MraidBridge$MraidWebView", DoNotGenerateAcw=true)]
		public partial class MraidWebView : global::Com.Mopub.Mobileads.BaseWebView {

			// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidBridge.MraidWebView.OnVisibilityChangedListener']"
			[Register ("com/mopub/mraid/MraidBridge$MraidWebView$OnVisibilityChangedListener", "", "Com.Mopub.Mraid.MraidBridge/MraidWebView/IOnVisibilityChangedListenerInvoker")]
			public partial interface IOnVisibilityChangedListener : IJavaObject {

				// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/interface[@name='MraidBridge.MraidWebView.OnVisibilityChangedListener']/method[@name='onVisibilityChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
				[Register ("onVisibilityChanged", "(Z)V", "GetOnVisibilityChanged_ZHandler:Com.Mopub.Mraid.MraidBridge/MraidWebView/IOnVisibilityChangedListenerInvoker, AppodealXamarinPlugin")]
				void OnVisibilityChanged (bool p0);

			}

			[global::Android.Runtime.Register ("com/mopub/mraid/MraidBridge$MraidWebView$OnVisibilityChangedListener", DoNotGenerateAcw=true)]
			internal class IOnVisibilityChangedListenerInvoker : global::Java.Lang.Object, IOnVisibilityChangedListener {

				static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mraid/MraidBridge$MraidWebView$OnVisibilityChangedListener");
				IntPtr class_ref;

				public static IOnVisibilityChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
				{
					return global::Java.Lang.Object.GetObject<IOnVisibilityChangedListener> (handle, transfer);
				}

				static IntPtr Validate (IntPtr handle)
				{
					if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
						throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
									JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mraid.MraidBridge.MraidWebView.OnVisibilityChangedListener"));
					return handle;
				}

				protected override void Dispose (bool disposing)
				{
					if (this.class_ref != IntPtr.Zero)
						JNIEnv.DeleteGlobalRef (this.class_ref);
					this.class_ref = IntPtr.Zero;
					base.Dispose (disposing);
				}

				public IOnVisibilityChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
				{
					IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
					this.class_ref = JNIEnv.NewGlobalRef (local_ref);
					JNIEnv.DeleteLocalRef (local_ref);
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (IOnVisibilityChangedListenerInvoker); }
				}

				static Delegate cb_onVisibilityChanged_Z;
#pragma warning disable 0169
				static Delegate GetOnVisibilityChanged_ZHandler ()
				{
					if (cb_onVisibilityChanged_Z == null)
						cb_onVisibilityChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnVisibilityChanged_Z);
					return cb_onVisibilityChanged_Z;
				}

				static void n_OnVisibilityChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
				{
					global::Com.Mopub.Mraid.MraidBridge.MraidWebView.IOnVisibilityChangedListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidBridge.MraidWebView.IOnVisibilityChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					__this.OnVisibilityChanged (p0);
				}
#pragma warning restore 0169

				IntPtr id_onVisibilityChanged_Z;
				public unsafe void OnVisibilityChanged (bool p0)
				{
					if (id_onVisibilityChanged_Z == IntPtr.Zero)
						id_onVisibilityChanged_Z = JNIEnv.GetMethodID (class_ref, "onVisibilityChanged", "(Z)V");
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					JNIEnv.CallVoidMethod (Handle, id_onVisibilityChanged_Z, __args);
				}

			}

			public partial class VisibilityChangedEventArgs : global::System.EventArgs {

				public VisibilityChangedEventArgs (bool p0)
				{
					this.p0 = p0;
				}

				bool p0;
				public bool P0 {
					get { return p0; }
				}
			}

			[global::Android.Runtime.Register ("mono/com/mopub/mraid/MraidBridge_MraidWebView_OnVisibilityChangedListenerImplementor")]
			internal sealed partial class IOnVisibilityChangedListenerImplementor : global::Java.Lang.Object, IOnVisibilityChangedListener {

				object sender;

				public IOnVisibilityChangedListenerImplementor (object sender)
					: base (
						global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/mraid/MraidBridge_MraidWebView_OnVisibilityChangedListenerImplementor", "()V"),
						JniHandleOwnership.TransferLocalRef)
				{
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					this.sender = sender;
				}

#pragma warning disable 0649
				public EventHandler<VisibilityChangedEventArgs> Handler;
#pragma warning restore 0649

				public void OnVisibilityChanged (bool p0)
				{
					var __h = Handler;
					if (__h != null)
						__h (sender, new VisibilityChangedEventArgs (p0));
				}

				internal static bool __IsEmpty (IOnVisibilityChangedListenerImplementor value)
				{
					return value.Handler == null;
				}
			}


			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mraid/MraidBridge$MraidWebView", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MraidWebView); }
			}

			protected MraidWebView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidBridge.MraidWebView']/constructor[@name='MraidBridge.MraidWebView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe MraidWebView (global::Android.Content.Context p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (MraidWebView)) {
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

			static Delegate cb_isVisible;
#pragma warning disable 0169
			static Delegate GetIsVisibleHandler ()
			{
				if (cb_isVisible == null)
					cb_isVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVisible);
				return cb_isVisible;
			}

			static bool n_IsVisible (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mraid.MraidBridge.MraidWebView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidBridge.MraidWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsVisible;
			}
#pragma warning restore 0169

			static IntPtr id_isVisible;
			public virtual unsafe bool IsVisible {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidBridge.MraidWebView']/method[@name='isVisible' and count(parameter)=0]"
				[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
				get {
					if (id_isVisible == IntPtr.Zero)
						id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod  (Handle, id_isVisible);
						else
							return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isVisible", "()Z"));
					} finally {
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mraid/MraidBridge", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MraidBridge); }
		}

		protected MraidBridge (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_setContentHtml_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentHtml_Ljava_lang_String_Handler ()
		{
			if (cb_setContentHtml_Ljava_lang_String_ == null)
				cb_setContentHtml_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentHtml_Ljava_lang_String_);
			return cb_setContentHtml_Ljava_lang_String_;
		}

		static void n_SetContentHtml_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mraid.MraidBridge __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetContentHtml (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setContentHtml_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidBridge']/method[@name='setContentHtml' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setContentHtml", "(Ljava/lang/String;)V", "GetSetContentHtml_Ljava_lang_String_Handler")]
		public virtual unsafe void SetContentHtml (string p0)
		{
			if (id_setContentHtml_Ljava_lang_String_ == IntPtr.Zero)
				id_setContentHtml_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentHtml", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setContentHtml_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentHtml", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setContentUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setContentUrl_Ljava_lang_String_ == null)
				cb_setContentUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentUrl_Ljava_lang_String_);
			return cb_setContentUrl_Ljava_lang_String_;
		}

		static void n_SetContentUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mraid.MraidBridge __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetContentUrl (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setContentUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidBridge']/method[@name='setContentUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setContentUrl", "(Ljava/lang/String;)V", "GetSetContentUrl_Ljava_lang_String_Handler")]
		public virtual unsafe void SetContentUrl (string p0)
		{
			if (id_setContentUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_setContentUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentUrl", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setContentUrl_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentUrl", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
