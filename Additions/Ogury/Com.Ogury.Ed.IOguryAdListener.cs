using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ogury.ED
{

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ogury.ed']/interface[@name='OguryAdListener']"
	[Register("com/ogury/ed/OguryAdListener", "", "Com.Ogury.ED.IOguryAdListenerInvoker")]
	public partial interface IOguryAdListener : IJavaObject, IJavaPeerable
	{
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogury.ed']/interface[@name='OguryAdListener']/method[@name='onAdClicked' and count(parameter)=0]"
		[Register("onAdClicked", "()V", "GetOnAdClickedHandler:Com.Ogury.ED.IOguryAdListenerInvoker, AppodealXamarinAndroid")]
		void OnAdClicked();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogury.ed']/interface[@name='OguryAdListener']/method[@name='onAdClosed' and count(parameter)=0]"
		[Register("onAdClosed", "()V", "GetOnAdClosedHandler:Com.Ogury.ED.IOguryAdListenerInvoker, AppodealXamarinAndroid")]
		void OnAdClosed();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogury.ed']/interface[@name='OguryAdListener']/method[@name='onAdDisplayed' and count(parameter)=0]"
		[Register("onAdDisplayed", "()V", "GetOnAdDisplayedHandler:Com.Ogury.ED.IOguryAdListenerInvoker, AppodealXamarinAndroid")]
		void OnAdDisplayed();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogury.ed']/interface[@name='OguryAdListener']/method[@name='onAdError' and count(parameter)=1 and parameter[1][@type='com.ogury.core.OguryError']]"
		[Register("onAdError", "(Lcom/ogury/core/OguryError;)V", "GetOnAdError_Lcom_ogury_core_OguryError_Handler:Com.Ogury.ED.IOguryAdListenerInvoker, AppodealXamarinAndroid")]
		void OnAdError(global::Com.Ogury.Core.OguryError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ogury.ed']/interface[@name='OguryAdListener']/method[@name='onAdLoaded' and count(parameter)=0]"
		[Register("onAdLoaded", "()V", "GetOnAdLoadedHandler:Com.Ogury.ED.IOguryAdListenerInvoker, AppodealXamarinAndroid")]
		void OnAdLoaded();

	}

	[global::Android.Runtime.Register("com/ogury/ed/OguryAdListener", DoNotGenerateAcw = true)]
	internal partial class IOguryAdListenerInvoker : global::Java.Lang.Object, IOguryAdListener
	{
		static readonly JniPeerMembers _members = new XAPeerMembers("com/ogury/ed/OguryAdListener", typeof(IOguryAdListenerInvoker));

		static IntPtr java_class_ref
		{
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers
		{
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType
		{
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IOguryAdListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOguryAdListener>(handle, transfer);
		}

		static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
				throw new InvalidCastException($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance(handle)}' to type 'com.ogury.ed.OguryAdListener'.");
			return handle;
		}

		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef(this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		public IOguryAdListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef(local_ref);
			JNIEnv.DeleteLocalRef(local_ref);
		}

		static Delegate cb_onAdClicked;
#pragma warning disable 0169
		static Delegate GetOnAdClickedHandler()
		{
			if (cb_onAdClicked == null)
				cb_onAdClicked = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_V)n_OnAdClicked);
			return cb_onAdClicked;
		}

		static void n_OnAdClicked(IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ogury.ED.IOguryAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAdClicked();
		}
#pragma warning restore 0169

		IntPtr id_onAdClicked;
		public unsafe void OnAdClicked()
		{
			if (id_onAdClicked == IntPtr.Zero)
				id_onAdClicked = JNIEnv.GetMethodID(class_ref, "onAdClicked", "()V");
			JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onAdClicked);
		}

		static Delegate cb_onAdClosed;
#pragma warning disable 0169
		static Delegate GetOnAdClosedHandler()
		{
			if (cb_onAdClosed == null)
				cb_onAdClosed = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_V)n_OnAdClosed);
			return cb_onAdClosed;
		}

		static void n_OnAdClosed(IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ogury.ED.IOguryAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAdClosed();
		}
#pragma warning restore 0169

		IntPtr id_onAdClosed;
		public unsafe void OnAdClosed()
		{
			if (id_onAdClosed == IntPtr.Zero)
				id_onAdClosed = JNIEnv.GetMethodID(class_ref, "onAdClosed", "()V");
			JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onAdClosed);
		}

		static Delegate cb_onAdDisplayed;
#pragma warning disable 0169
		static Delegate GetOnAdDisplayedHandler()
		{
			if (cb_onAdDisplayed == null)
				cb_onAdDisplayed = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_V)n_OnAdDisplayed);
			return cb_onAdDisplayed;
		}

		static void n_OnAdDisplayed(IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ogury.ED.IOguryAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAdDisplayed();
		}
#pragma warning restore 0169

		IntPtr id_onAdDisplayed;
		public unsafe void OnAdDisplayed()
		{
			if (id_onAdDisplayed == IntPtr.Zero)
				id_onAdDisplayed = JNIEnv.GetMethodID(class_ref, "onAdDisplayed", "()V");
			JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onAdDisplayed);
		}

		static Delegate cb_onAdError_Lcom_ogury_core_OguryError_;
#pragma warning disable 0169
		static Delegate GetOnAdError_Lcom_ogury_core_OguryError_Handler()
		{
			if (cb_onAdError_Lcom_ogury_core_OguryError_ == null)
				cb_onAdError_Lcom_ogury_core_OguryError_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_V)n_OnAdError_Lcom_ogury_core_OguryError_);
			return cb_onAdError_Lcom_ogury_core_OguryError_;
		}

		static void n_OnAdError_Lcom_ogury_core_OguryError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ogury.ED.IOguryAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Ogury.Core.OguryError>(native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdError(p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdError_Lcom_ogury_core_OguryError_;
		public unsafe void OnAdError(global::Com.Ogury.Core.OguryError p0)
		{
			if (id_onAdError_Lcom_ogury_core_OguryError_ == IntPtr.Zero)
				id_onAdError_Lcom_ogury_core_OguryError_ = JNIEnv.GetMethodID(class_ref, "onAdError", "(Lcom/ogury/core/OguryError;)V");
			JValue* __args = stackalloc JValue[1];
			__args[0] = new JValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable)p0).Handle);
			JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onAdError_Lcom_ogury_core_OguryError_, __args);
		}

		static Delegate cb_onAdLoaded;
#pragma warning disable 0169
		static Delegate GetOnAdLoadedHandler()
		{
			if (cb_onAdLoaded == null)
				cb_onAdLoaded = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_V)n_OnAdLoaded);
			return cb_onAdLoaded;
		}

		static void n_OnAdLoaded(IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Ogury.ED.IOguryAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAdLoaded();
		}
#pragma warning restore 0169

		IntPtr id_onAdLoaded;
		public unsafe void OnAdLoaded()
		{
			if (id_onAdLoaded == IntPtr.Zero)
				id_onAdLoaded = JNIEnv.GetMethodID(class_ref, "onAdLoaded", "()V");
			JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onAdLoaded);
		}

	}

	// event args for com.ogury.ed.OguryAdListener.onAdError
	public partial class AdErrorEventArgs : global::System.EventArgs
	{
		public AdErrorEventArgs(global::Com.Ogury.Core.OguryError p0)
		{
			this.p0 = p0;
		}

		global::Com.Ogury.Core.OguryError p0;

		public global::Com.Ogury.Core.OguryError P0
		{
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register("mono/com/ogury/ed/OguryAdListenerImplementor")]
	internal sealed partial class IOguryAdListenerImplementor : global::Java.Lang.Object, IOguryAdListener
	{

		object sender;

		public IOguryAdListenerImplementor(object sender) : base(global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/ogury/ed/OguryAdListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler OnAdClickedHandler;
#pragma warning restore 0649

		public void OnAdClicked()
		{
			var __h = OnAdClickedHandler;
			if (__h != null)
				__h(sender, new EventArgs());
		}

#pragma warning disable 0649
		public EventHandler OnAdClosedHandler;
#pragma warning restore 0649

		public void OnAdClosed()
		{
			var __h = OnAdClosedHandler;
			if (__h != null)
				__h(sender, new EventArgs());
		}

#pragma warning disable 0649
		public EventHandler OnAdDisplayedHandler;
#pragma warning restore 0649

		public void OnAdDisplayed()
		{
			var __h = OnAdDisplayedHandler;
			if (__h != null)
				__h(sender, new EventArgs());
		}

#pragma warning disable 0649
		public EventHandler<AdErrorEventArgs> OnAdErrorHandler;
#pragma warning restore 0649

		public void OnAdError(global::Com.Ogury.Core.OguryError p0)
		{
			var __h = OnAdErrorHandler;
			if (__h != null)
				__h(sender, new AdErrorEventArgs(p0));
		}

#pragma warning disable 0649
		public EventHandler OnAdLoadedHandler;
#pragma warning restore 0649

		public void OnAdLoaded()
		{
			var __h = OnAdLoadedHandler;
			if (__h != null)
				__h(sender, new EventArgs());
		}

		internal static bool __IsEmpty(IOguryAdListenerImplementor value)
		{
			return value.OnAdClickedHandler == null && value.OnAdClosedHandler == null && value.OnAdDisplayedHandler == null && value.OnAdErrorHandler == null && value.OnAdLoadedHandler == null;
		}

	}
}
