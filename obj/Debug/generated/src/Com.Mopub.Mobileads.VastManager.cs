using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastManager']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/VastManager", DoNotGenerateAcw=true)]
	public partial class VastManager : global::Java.Lang.Object, global::Com.Mopub.Mobileads.VastXmlManagerAggregator.IVastXmlManagerAggregatorListener {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='VastManager.VastManagerListener']"
		[Register ("com/mopub/mobileads/VastManager$VastManagerListener", "", "Com.Mopub.Mobileads.VastManager/IVastManagerListenerInvoker")]
		public partial interface IVastManagerListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='VastManager.VastManagerListener']/method[@name='onVastVideoConfigurationPrepared' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.VastVideoConfig']]"
			[Register ("onVastVideoConfigurationPrepared", "(Lcom/mopub/mobileads/VastVideoConfig;)V", "GetOnVastVideoConfigurationPrepared_Lcom_mopub_mobileads_VastVideoConfig_Handler:Com.Mopub.Mobileads.VastManager/IVastManagerListenerInvoker, AppodealXamarinPlugin")]
			void OnVastVideoConfigurationPrepared (global::Com.Mopub.Mobileads.VastVideoConfig p0);

		}

		[global::Android.Runtime.Register ("com/mopub/mobileads/VastManager$VastManagerListener", DoNotGenerateAcw=true)]
		internal class IVastManagerListenerInvoker : global::Java.Lang.Object, IVastManagerListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/VastManager$VastManagerListener");
			IntPtr class_ref;

			public static IVastManagerListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IVastManagerListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.VastManager.VastManagerListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IVastManagerListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IVastManagerListenerInvoker); }
			}

			static Delegate cb_onVastVideoConfigurationPrepared_Lcom_mopub_mobileads_VastVideoConfig_;
#pragma warning disable 0169
			static Delegate GetOnVastVideoConfigurationPrepared_Lcom_mopub_mobileads_VastVideoConfig_Handler ()
			{
				if (cb_onVastVideoConfigurationPrepared_Lcom_mopub_mobileads_VastVideoConfig_ == null)
					cb_onVastVideoConfigurationPrepared_Lcom_mopub_mobileads_VastVideoConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnVastVideoConfigurationPrepared_Lcom_mopub_mobileads_VastVideoConfig_);
				return cb_onVastVideoConfigurationPrepared_Lcom_mopub_mobileads_VastVideoConfig_;
			}

			static void n_OnVastVideoConfigurationPrepared_Lcom_mopub_mobileads_VastVideoConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.VastManager.IVastManagerListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastManager.IVastManagerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.VastVideoConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnVastVideoConfigurationPrepared (p0);
			}
#pragma warning restore 0169

			IntPtr id_onVastVideoConfigurationPrepared_Lcom_mopub_mobileads_VastVideoConfig_;
			public unsafe void OnVastVideoConfigurationPrepared (global::Com.Mopub.Mobileads.VastVideoConfig p0)
			{
				if (id_onVastVideoConfigurationPrepared_Lcom_mopub_mobileads_VastVideoConfig_ == IntPtr.Zero)
					id_onVastVideoConfigurationPrepared_Lcom_mopub_mobileads_VastVideoConfig_ = JNIEnv.GetMethodID (class_ref, "onVastVideoConfigurationPrepared", "(Lcom/mopub/mobileads/VastVideoConfig;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onVastVideoConfigurationPrepared_Lcom_mopub_mobileads_VastVideoConfig_, __args);
			}

		}

		public partial class VastManagerEventArgs : global::System.EventArgs {

			public VastManagerEventArgs (global::Com.Mopub.Mobileads.VastVideoConfig p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Mobileads.VastVideoConfig p0;
			public global::Com.Mopub.Mobileads.VastVideoConfig P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/mobileads/VastManager_VastManagerListenerImplementor")]
		internal sealed partial class IVastManagerListenerImplementor : global::Java.Lang.Object, IVastManagerListener {

			object sender;

			public IVastManagerListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/mobileads/VastManager_VastManagerListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<VastManagerEventArgs> Handler;
#pragma warning restore 0649

			public void OnVastVideoConfigurationPrepared (global::Com.Mopub.Mobileads.VastVideoConfig p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new VastManagerEventArgs (p0));
			}

			internal static bool __IsEmpty (IVastManagerListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/VastManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VastManager); }
		}

		protected VastManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastManager']/constructor[@name='VastManager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe VastManager (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (VastManager)) {
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

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastManager __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastManager']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cancel);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "()V"));
			} finally {
			}
		}

		static Delegate cb_onAggregationComplete_Lcom_mopub_mobileads_VastVideoConfig_;
#pragma warning disable 0169
		static Delegate GetOnAggregationComplete_Lcom_mopub_mobileads_VastVideoConfig_Handler ()
		{
			if (cb_onAggregationComplete_Lcom_mopub_mobileads_VastVideoConfig_ == null)
				cb_onAggregationComplete_Lcom_mopub_mobileads_VastVideoConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAggregationComplete_Lcom_mopub_mobileads_VastVideoConfig_);
			return cb_onAggregationComplete_Lcom_mopub_mobileads_VastVideoConfig_;
		}

		static void n_OnAggregationComplete_Lcom_mopub_mobileads_VastVideoConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastManager __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.VastVideoConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAggregationComplete (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onAggregationComplete_Lcom_mopub_mobileads_VastVideoConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastManager']/method[@name='onAggregationComplete' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.VastVideoConfig']]"
		[Register ("onAggregationComplete", "(Lcom/mopub/mobileads/VastVideoConfig;)V", "GetOnAggregationComplete_Lcom_mopub_mobileads_VastVideoConfig_Handler")]
		public virtual unsafe void OnAggregationComplete (global::Com.Mopub.Mobileads.VastVideoConfig p0)
		{
			if (id_onAggregationComplete_Lcom_mopub_mobileads_VastVideoConfig_ == IntPtr.Zero)
				id_onAggregationComplete_Lcom_mopub_mobileads_VastVideoConfig_ = JNIEnv.GetMethodID (class_ref, "onAggregationComplete", "(Lcom/mopub/mobileads/VastVideoConfig;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAggregationComplete_Lcom_mopub_mobileads_VastVideoConfig_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAggregationComplete", "(Lcom/mopub/mobileads/VastVideoConfig;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_prepareVastVideoConfiguration_Ljava_lang_String_Lcom_mopub_mobileads_VastManager_VastManagerListener_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetPrepareVastVideoConfiguration_Ljava_lang_String_Lcom_mopub_mobileads_VastManager_VastManagerListener_Landroid_content_Context_Handler ()
		{
			if (cb_prepareVastVideoConfiguration_Ljava_lang_String_Lcom_mopub_mobileads_VastManager_VastManagerListener_Landroid_content_Context_ == null)
				cb_prepareVastVideoConfiguration_Ljava_lang_String_Lcom_mopub_mobileads_VastManager_VastManagerListener_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PrepareVastVideoConfiguration_Ljava_lang_String_Lcom_mopub_mobileads_VastManager_VastManagerListener_Landroid_content_Context_);
			return cb_prepareVastVideoConfiguration_Ljava_lang_String_Lcom_mopub_mobileads_VastManager_VastManagerListener_Landroid_content_Context_;
		}

		static void n_PrepareVastVideoConfiguration_Ljava_lang_String_Lcom_mopub_mobileads_VastManager_VastManagerListener_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mopub.Mobileads.VastManager __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.VastManager.IVastManagerListener p1 = (global::Com.Mopub.Mobileads.VastManager.IVastManagerListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastManager.IVastManagerListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.PrepareVastVideoConfiguration (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_prepareVastVideoConfiguration_Ljava_lang_String_Lcom_mopub_mobileads_VastManager_VastManagerListener_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastManager']/method[@name='prepareVastVideoConfiguration' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.mobileads.VastManager.VastManagerListener'] and parameter[3][@type='android.content.Context']]"
		[Register ("prepareVastVideoConfiguration", "(Ljava/lang/String;Lcom/mopub/mobileads/VastManager$VastManagerListener;Landroid/content/Context;)V", "GetPrepareVastVideoConfiguration_Ljava_lang_String_Lcom_mopub_mobileads_VastManager_VastManagerListener_Landroid_content_Context_Handler")]
		public virtual unsafe void PrepareVastVideoConfiguration (string p0, global::Com.Mopub.Mobileads.VastManager.IVastManagerListener p1, global::Android.Content.Context p2)
		{
			if (id_prepareVastVideoConfiguration_Ljava_lang_String_Lcom_mopub_mobileads_VastManager_VastManagerListener_Landroid_content_Context_ == IntPtr.Zero)
				id_prepareVastVideoConfiguration_Ljava_lang_String_Lcom_mopub_mobileads_VastManager_VastManagerListener_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "prepareVastVideoConfiguration", "(Ljava/lang/String;Lcom/mopub/mobileads/VastManager$VastManagerListener;Landroid/content/Context;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_prepareVastVideoConfiguration_Ljava_lang_String_Lcom_mopub_mobileads_VastManager_VastManagerListener_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prepareVastVideoConfiguration", "(Ljava/lang/String;Lcom/mopub/mobileads/VastManager$VastManagerListener;Landroid/content/Context;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
