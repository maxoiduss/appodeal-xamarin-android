using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='HtmlWebViewListener']"
	[Register ("com/mopub/mobileads/HtmlWebViewListener", "", "Com.Mopub.Mobileads.IHtmlWebViewListenerInvoker")]
	public partial interface IHtmlWebViewListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='HtmlWebViewListener']/method[@name='onClicked' and count(parameter)=0]"
		[Register ("onClicked", "()V", "GetOnClickedHandler:Com.Mopub.Mobileads.IHtmlWebViewListenerInvoker, AppodealXamarinPlugin")]
		void OnClicked ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='HtmlWebViewListener']/method[@name='onCollapsed' and count(parameter)=0]"
		[Register ("onCollapsed", "()V", "GetOnCollapsedHandler:Com.Mopub.Mobileads.IHtmlWebViewListenerInvoker, AppodealXamarinPlugin")]
		void OnCollapsed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='HtmlWebViewListener']/method[@name='onFailed' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubErrorCode']]"
		[Register ("onFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V", "GetOnFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler:Com.Mopub.Mobileads.IHtmlWebViewListenerInvoker, AppodealXamarinPlugin")]
		void OnFailed (global::Com.Mopub.Mobileads.MoPubErrorCode p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='HtmlWebViewListener']/method[@name='onLoaded' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.BaseHtmlWebView']]"
		[Register ("onLoaded", "(Lcom/mopub/mobileads/BaseHtmlWebView;)V", "GetOnLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_Handler:Com.Mopub.Mobileads.IHtmlWebViewListenerInvoker, AppodealXamarinPlugin")]
		void OnLoaded (global::Com.Mopub.Mobileads.BaseHtmlWebView p0);

	}

	[global::Android.Runtime.Register ("com/mopub/mobileads/HtmlWebViewListener", DoNotGenerateAcw=true)]
	internal class IHtmlWebViewListenerInvoker : global::Java.Lang.Object, IHtmlWebViewListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/HtmlWebViewListener");
		IntPtr class_ref;

		public static IHtmlWebViewListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHtmlWebViewListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.HtmlWebViewListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHtmlWebViewListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IHtmlWebViewListenerInvoker); }
		}

		static Delegate cb_onClicked;
#pragma warning disable 0169
		static Delegate GetOnClickedHandler ()
		{
			if (cb_onClicked == null)
				cb_onClicked = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnClicked);
			return cb_onClicked;
		}

		static void n_OnClicked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.IHtmlWebViewListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.IHtmlWebViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnClicked ();
		}
#pragma warning restore 0169

		IntPtr id_onClicked;
		public unsafe void OnClicked ()
		{
			if (id_onClicked == IntPtr.Zero)
				id_onClicked = JNIEnv.GetMethodID (class_ref, "onClicked", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onClicked);
		}

		static Delegate cb_onCollapsed;
#pragma warning disable 0169
		static Delegate GetOnCollapsedHandler ()
		{
			if (cb_onCollapsed == null)
				cb_onCollapsed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCollapsed);
			return cb_onCollapsed;
		}

		static void n_OnCollapsed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.IHtmlWebViewListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.IHtmlWebViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCollapsed ();
		}
#pragma warning restore 0169

		IntPtr id_onCollapsed;
		public unsafe void OnCollapsed ()
		{
			if (id_onCollapsed == IntPtr.Zero)
				id_onCollapsed = JNIEnv.GetMethodID (class_ref, "onCollapsed", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onCollapsed);
		}

		static Delegate cb_onFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
#pragma warning disable 0169
		static Delegate GetOnFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler ()
		{
			if (cb_onFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == null)
				cb_onFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailed_Lcom_mopub_mobileads_MoPubErrorCode_);
			return cb_onFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
		}

		static void n_OnFailed_Lcom_mopub_mobileads_MoPubErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.IHtmlWebViewListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.IHtmlWebViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubErrorCode p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
		public unsafe void OnFailed (global::Com.Mopub.Mobileads.MoPubErrorCode p0)
		{
			if (id_onFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == IntPtr.Zero)
				id_onFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNIEnv.GetMethodID (class_ref, "onFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onFailed_Lcom_mopub_mobileads_MoPubErrorCode_, __args);
		}

		static Delegate cb_onLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_;
#pragma warning disable 0169
		static Delegate GetOnLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_Handler ()
		{
			if (cb_onLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_ == null)
				cb_onLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_);
			return cb_onLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_;
		}

		static void n_OnLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.IHtmlWebViewListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.IHtmlWebViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.BaseHtmlWebView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseHtmlWebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLoaded (p0);
		}
#pragma warning restore 0169

		IntPtr id_onLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_;
		public unsafe void OnLoaded (global::Com.Mopub.Mobileads.BaseHtmlWebView p0)
		{
			if (id_onLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_ == IntPtr.Zero)
				id_onLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_ = JNIEnv.GetMethodID (class_ref, "onLoaded", "(Lcom/mopub/mobileads/BaseHtmlWebView;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_, __args);
		}

	}

	public partial class FailedEventArgs : global::System.EventArgs {

		public FailedEventArgs (global::Com.Mopub.Mobileads.MoPubErrorCode p0)
		{
			this.p0 = p0;
		}

		global::Com.Mopub.Mobileads.MoPubErrorCode p0;
		public global::Com.Mopub.Mobileads.MoPubErrorCode P0 {
			get { return p0; }
		}
	}

	public partial class LoadedEventArgs : global::System.EventArgs {

		public LoadedEventArgs (global::Com.Mopub.Mobileads.BaseHtmlWebView p0)
		{
			this.p0 = p0;
		}

		global::Com.Mopub.Mobileads.BaseHtmlWebView p0;
		public global::Com.Mopub.Mobileads.BaseHtmlWebView P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mopub/mobileads/HtmlWebViewListenerImplementor")]
	internal sealed partial class IHtmlWebViewListenerImplementor : global::Java.Lang.Object, IHtmlWebViewListener {

		object sender;

		public IHtmlWebViewListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/mobileads/HtmlWebViewListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler OnClickedHandler;
#pragma warning restore 0649

		public void OnClicked ()
		{
			var __h = OnClickedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnCollapsedHandler;
#pragma warning restore 0649

		public void OnCollapsed ()
		{
			var __h = OnCollapsedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<FailedEventArgs> OnFailedHandler;
#pragma warning restore 0649

		public void OnFailed (global::Com.Mopub.Mobileads.MoPubErrorCode p0)
		{
			var __h = OnFailedHandler;
			if (__h != null)
				__h (sender, new FailedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<LoadedEventArgs> OnLoadedHandler;
#pragma warning restore 0649

		public void OnLoaded (global::Com.Mopub.Mobileads.BaseHtmlWebView p0)
		{
			var __h = OnLoadedHandler;
			if (__h != null)
				__h (sender, new LoadedEventArgs (p0));
		}

		internal static bool __IsEmpty (IHtmlWebViewListenerImplementor value)
		{
			return value.OnClickedHandler == null && value.OnCollapsedHandler == null && value.OnFailedHandler == null && value.OnLoadedHandler == null;
		}
	}

}
