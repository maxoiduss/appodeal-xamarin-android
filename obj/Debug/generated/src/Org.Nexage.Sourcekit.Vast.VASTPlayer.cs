using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Vast {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.vast']/class[@name='VASTPlayer']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/vast/VASTPlayer", DoNotGenerateAcw=true)]
	public partial class VASTPlayer : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.vast']/class[@name='VASTPlayer']/field[@name='ERROR_CACHE']"
		[Register ("ERROR_CACHE")]
		public const int ErrorCache = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.vast']/class[@name='VASTPlayer']/field[@name='ERROR_EXCEEDED_WRAPPER_LIMIT']"
		[Register ("ERROR_EXCEEDED_WRAPPER_LIMIT")]
		public const int ErrorExceededWrapperLimit = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.vast']/class[@name='VASTPlayer']/field[@name='ERROR_NONE']"
		[Register ("ERROR_NONE")]
		public const int ErrorNone = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.vast']/class[@name='VASTPlayer']/field[@name='ERROR_NO_NETWORK']"
		[Register ("ERROR_NO_NETWORK")]
		public const int ErrorNoNetwork = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.vast']/class[@name='VASTPlayer']/field[@name='ERROR_POST_VALIDATION']"
		[Register ("ERROR_POST_VALIDATION")]
		public const int ErrorPostValidation = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.vast']/class[@name='VASTPlayer']/field[@name='ERROR_SCHEMA_VALIDATION']"
		[Register ("ERROR_SCHEMA_VALIDATION")]
		public const int ErrorSchemaValidation = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.vast']/class[@name='VASTPlayer']/field[@name='ERROR_VIDEO_PLAYBACK']"
		[Register ("ERROR_VIDEO_PLAYBACK")]
		public const int ErrorVideoPlayback = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.vast']/class[@name='VASTPlayer']/field[@name='ERROR_XML_OPEN_OR_READ']"
		[Register ("ERROR_XML_OPEN_OR_READ")]
		public const int ErrorXmlOpenOrRead = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.vast']/class[@name='VASTPlayer']/field[@name='ERROR_XML_PARSE']"
		[Register ("ERROR_XML_PARSE")]
		public const int ErrorXmlParse = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.vast']/class[@name='VASTPlayer']/field[@name='VERSION']"
		[Register ("VERSION")]
		public const string Version = (string) "1.3";

		static IntPtr listener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.vast']/class[@name='VASTPlayer']/field[@name='listener']"
		[Register ("listener")]
		public static global::Org.Nexage.Sourcekit.Vast.VASTPlayer.IVASTPlayerListener Listener {
			get {
				if (listener_jfieldId == IntPtr.Zero)
					listener_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "listener", "Lorg/nexage/sourcekit/vast/VASTPlayer$VASTPlayerListener;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, listener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.VASTPlayer.IVASTPlayerListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (listener_jfieldId == IntPtr.Zero)
					listener_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "listener", "Lorg/nexage/sourcekit/vast/VASTPlayer$VASTPlayerListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, listener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='org.nexage.sourcekit.vast']/interface[@name='VASTPlayer.VASTPlayerListener']"
		[Register ("org/nexage/sourcekit/vast/VASTPlayer$VASTPlayerListener", "", "Org.Nexage.Sourcekit.Vast.VASTPlayer/IVASTPlayerListenerInvoker")]
		public partial interface IVASTPlayerListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast']/interface[@name='VASTPlayer.VASTPlayerListener']/method[@name='vastClick' and count(parameter)=0]"
			[Register ("vastClick", "()V", "GetVastClickHandler:Org.Nexage.Sourcekit.Vast.VASTPlayer/IVASTPlayerListenerInvoker, AppodealXamarinPlugin")]
			void VastClick ();

			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast']/interface[@name='VASTPlayer.VASTPlayerListener']/method[@name='vastComplete' and count(parameter)=0]"
			[Register ("vastComplete", "()V", "GetVastCompleteHandler:Org.Nexage.Sourcekit.Vast.VASTPlayer/IVASTPlayerListenerInvoker, AppodealXamarinPlugin")]
			void VastComplete ();

			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast']/interface[@name='VASTPlayer.VASTPlayerListener']/method[@name='vastDismiss' and count(parameter)=0]"
			[Register ("vastDismiss", "()V", "GetVastDismissHandler:Org.Nexage.Sourcekit.Vast.VASTPlayer/IVASTPlayerListenerInvoker, AppodealXamarinPlugin")]
			void VastDismiss ();

			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast']/interface[@name='VASTPlayer.VASTPlayerListener']/method[@name='vastError' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("vastError", "(I)V", "GetVastError_IHandler:Org.Nexage.Sourcekit.Vast.VASTPlayer/IVASTPlayerListenerInvoker, AppodealXamarinPlugin")]
			void VastError (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast']/interface[@name='VASTPlayer.VASTPlayerListener']/method[@name='vastReady' and count(parameter)=0]"
			[Register ("vastReady", "()V", "GetVastReadyHandler:Org.Nexage.Sourcekit.Vast.VASTPlayer/IVASTPlayerListenerInvoker, AppodealXamarinPlugin")]
			void VastReady ();

		}

		[global::Android.Runtime.Register ("org/nexage/sourcekit/vast/VASTPlayer$VASTPlayerListener", DoNotGenerateAcw=true)]
		internal class IVASTPlayerListenerInvoker : global::Java.Lang.Object, IVASTPlayerListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/nexage/sourcekit/vast/VASTPlayer$VASTPlayerListener");
			IntPtr class_ref;

			public static IVASTPlayerListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IVASTPlayerListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.nexage.sourcekit.vast.VASTPlayer.VASTPlayerListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IVASTPlayerListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IVASTPlayerListenerInvoker); }
			}

			static Delegate cb_vastClick;
#pragma warning disable 0169
			static Delegate GetVastClickHandler ()
			{
				if (cb_vastClick == null)
					cb_vastClick = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_VastClick);
				return cb_vastClick;
			}

			static void n_VastClick (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Nexage.Sourcekit.Vast.VASTPlayer.IVASTPlayerListener __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.VASTPlayer.IVASTPlayerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.VastClick ();
			}
#pragma warning restore 0169

			IntPtr id_vastClick;
			public unsafe void VastClick ()
			{
				if (id_vastClick == IntPtr.Zero)
					id_vastClick = JNIEnv.GetMethodID (class_ref, "vastClick", "()V");
				JNIEnv.CallVoidMethod (Handle, id_vastClick);
			}

			static Delegate cb_vastComplete;
#pragma warning disable 0169
			static Delegate GetVastCompleteHandler ()
			{
				if (cb_vastComplete == null)
					cb_vastComplete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_VastComplete);
				return cb_vastComplete;
			}

			static void n_VastComplete (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Nexage.Sourcekit.Vast.VASTPlayer.IVASTPlayerListener __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.VASTPlayer.IVASTPlayerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.VastComplete ();
			}
#pragma warning restore 0169

			IntPtr id_vastComplete;
			public unsafe void VastComplete ()
			{
				if (id_vastComplete == IntPtr.Zero)
					id_vastComplete = JNIEnv.GetMethodID (class_ref, "vastComplete", "()V");
				JNIEnv.CallVoidMethod (Handle, id_vastComplete);
			}

			static Delegate cb_vastDismiss;
#pragma warning disable 0169
			static Delegate GetVastDismissHandler ()
			{
				if (cb_vastDismiss == null)
					cb_vastDismiss = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_VastDismiss);
				return cb_vastDismiss;
			}

			static void n_VastDismiss (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Nexage.Sourcekit.Vast.VASTPlayer.IVASTPlayerListener __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.VASTPlayer.IVASTPlayerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.VastDismiss ();
			}
#pragma warning restore 0169

			IntPtr id_vastDismiss;
			public unsafe void VastDismiss ()
			{
				if (id_vastDismiss == IntPtr.Zero)
					id_vastDismiss = JNIEnv.GetMethodID (class_ref, "vastDismiss", "()V");
				JNIEnv.CallVoidMethod (Handle, id_vastDismiss);
			}

			static Delegate cb_vastError_I;
#pragma warning disable 0169
			static Delegate GetVastError_IHandler ()
			{
				if (cb_vastError_I == null)
					cb_vastError_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_VastError_I);
				return cb_vastError_I;
			}

			static void n_VastError_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Org.Nexage.Sourcekit.Vast.VASTPlayer.IVASTPlayerListener __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.VASTPlayer.IVASTPlayerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.VastError (p0);
			}
#pragma warning restore 0169

			IntPtr id_vastError_I;
			public unsafe void VastError (int p0)
			{
				if (id_vastError_I == IntPtr.Zero)
					id_vastError_I = JNIEnv.GetMethodID (class_ref, "vastError", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_vastError_I, __args);
			}

			static Delegate cb_vastReady;
#pragma warning disable 0169
			static Delegate GetVastReadyHandler ()
			{
				if (cb_vastReady == null)
					cb_vastReady = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_VastReady);
				return cb_vastReady;
			}

			static void n_VastReady (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Nexage.Sourcekit.Vast.VASTPlayer.IVASTPlayerListener __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.VASTPlayer.IVASTPlayerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.VastReady ();
			}
#pragma warning restore 0169

			IntPtr id_vastReady;
			public unsafe void VastReady ()
			{
				if (id_vastReady == IntPtr.Zero)
					id_vastReady = JNIEnv.GetMethodID (class_ref, "vastReady", "()V");
				JNIEnv.CallVoidMethod (Handle, id_vastReady);
			}

		}

		public partial class VastErrorEventArgs : global::System.EventArgs {

			public VastErrorEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/org/nexage/sourcekit/vast/VASTPlayer_VASTPlayerListenerImplementor")]
		internal sealed partial class IVASTPlayerListenerImplementor : global::Java.Lang.Object, IVASTPlayerListener {

			object sender;

			public IVASTPlayerListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/nexage/sourcekit/vast/VASTPlayer_VASTPlayerListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler VastClickHandler;
#pragma warning restore 0649

			public void VastClick ()
			{
				var __h = VastClickHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler VastCompleteHandler;
#pragma warning restore 0649

			public void VastComplete ()
			{
				var __h = VastCompleteHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler VastDismissHandler;
#pragma warning restore 0649

			public void VastDismiss ()
			{
				var __h = VastDismissHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<VastErrorEventArgs> VastErrorHandler;
#pragma warning restore 0649

			public void VastError (int p0)
			{
				var __h = VastErrorHandler;
				if (__h != null)
					__h (sender, new VastErrorEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler VastReadyHandler;
#pragma warning restore 0649

			public void VastReady ()
			{
				var __h = VastReadyHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IVASTPlayerListenerImplementor value)
			{
				return value.VastClickHandler == null && value.VastCompleteHandler == null && value.VastDismissHandler == null && value.VastErrorHandler == null && value.VastReadyHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/vast/VASTPlayer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VASTPlayer); }
		}

		protected VASTPlayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lorg_nexage_sourcekit_vast_VASTPlayer_VASTPlayerListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.vast']/class[@name='VASTPlayer']/constructor[@name='VASTPlayer' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.nexage.sourcekit.vast.VASTPlayer.VASTPlayerListener']]"
		[Register (".ctor", "(Landroid/content/Context;Lorg/nexage/sourcekit/vast/VASTPlayer$VASTPlayerListener;)V", "")]
		public unsafe VASTPlayer (global::Android.Content.Context p0, global::Org.Nexage.Sourcekit.Vast.VASTPlayer.IVASTPlayerListener p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (VASTPlayer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lorg/nexage/sourcekit/vast/VASTPlayer$VASTPlayerListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lorg/nexage/sourcekit/vast/VASTPlayer$VASTPlayerListener;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lorg_nexage_sourcekit_vast_VASTPlayer_VASTPlayerListener_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lorg_nexage_sourcekit_vast_VASTPlayer_VASTPlayerListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lorg/nexage/sourcekit/vast/VASTPlayer$VASTPlayerListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lorg_nexage_sourcekit_vast_VASTPlayer_VASTPlayerListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lorg_nexage_sourcekit_vast_VASTPlayer_VASTPlayerListener_, __args);
			} finally {
			}
		}

		static Delegate cb_loadVideoWithData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadVideoWithData_Ljava_lang_String_Handler ()
		{
			if (cb_loadVideoWithData_Ljava_lang_String_ == null)
				cb_loadVideoWithData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadVideoWithData_Ljava_lang_String_);
			return cb_loadVideoWithData_Ljava_lang_String_;
		}

		static void n_LoadVideoWithData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Vast.VASTPlayer __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.VASTPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadVideoWithData (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadVideoWithData_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast']/class[@name='VASTPlayer']/method[@name='loadVideoWithData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadVideoWithData", "(Ljava/lang/String;)V", "GetLoadVideoWithData_Ljava_lang_String_Handler")]
		public virtual unsafe void LoadVideoWithData (string p0)
		{
			if (id_loadVideoWithData_Ljava_lang_String_ == IntPtr.Zero)
				id_loadVideoWithData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadVideoWithData", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_loadVideoWithData_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadVideoWithData", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_loadVideoWithUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadVideoWithUrl_Ljava_lang_String_Handler ()
		{
			if (cb_loadVideoWithUrl_Ljava_lang_String_ == null)
				cb_loadVideoWithUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadVideoWithUrl_Ljava_lang_String_);
			return cb_loadVideoWithUrl_Ljava_lang_String_;
		}

		static void n_LoadVideoWithUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Vast.VASTPlayer __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.VASTPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadVideoWithUrl (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadVideoWithUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast']/class[@name='VASTPlayer']/method[@name='loadVideoWithUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadVideoWithUrl", "(Ljava/lang/String;)V", "GetLoadVideoWithUrl_Ljava_lang_String_Handler")]
		public virtual unsafe void LoadVideoWithUrl (string p0)
		{
			if (id_loadVideoWithUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_loadVideoWithUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadVideoWithUrl", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_loadVideoWithUrl_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadVideoWithUrl", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_play;
#pragma warning disable 0169
		static Delegate GetPlayHandler ()
		{
			if (cb_play == null)
				cb_play = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Play);
			return cb_play;
		}

		static void n_Play (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Vast.VASTPlayer __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.VASTPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Play ();
		}
#pragma warning restore 0169

		static IntPtr id_play;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast']/class[@name='VASTPlayer']/method[@name='play' and count(parameter)=0]"
		[Register ("play", "()V", "GetPlayHandler")]
		public virtual unsafe void Play ()
		{
			if (id_play == IntPtr.Zero)
				id_play = JNIEnv.GetMethodID (class_ref, "play", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_play);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "play", "()V"));
			} finally {
			}
		}

		static Delegate cb_setPrecache_Z;
#pragma warning disable 0169
		static Delegate GetSetPrecache_ZHandler ()
		{
			if (cb_setPrecache_Z == null)
				cb_setPrecache_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPrecache_Z);
			return cb_setPrecache_Z;
		}

		static void n_SetPrecache_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Nexage.Sourcekit.Vast.VASTPlayer __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.VASTPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPrecache (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPrecache_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast']/class[@name='VASTPlayer']/method[@name='setPrecache' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPrecache", "(Z)V", "GetSetPrecache_ZHandler")]
		public virtual unsafe void SetPrecache (bool p0)
		{
			if (id_setPrecache_Z == IntPtr.Zero)
				id_setPrecache_Z = JNIEnv.GetMethodID (class_ref, "setPrecache", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPrecache_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPrecache", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
