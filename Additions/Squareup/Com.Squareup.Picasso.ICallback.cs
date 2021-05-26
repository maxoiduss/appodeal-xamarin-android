using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Squareup.Picasso {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Callback.EmptyCallback']"
	[global::Android.Runtime.Register ("com/squareup/picasso/Callback$EmptyCallback", DoNotGenerateAcw=true)]
	public partial class CallbackEmptyCallback : global::Java.Lang.Object, global::Com.Squareup.Picasso.ICallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/squareup/picasso/Callback$EmptyCallback", typeof (CallbackEmptyCallback));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected CallbackEmptyCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Callback.EmptyCallback']/constructor[@name='Callback.EmptyCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CallbackEmptyCallback () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onError_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_lang_Exception_Handler ()
		{
			if (cb_onError_Ljava_lang_Exception_ == null)
				cb_onError_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnError_Ljava_lang_Exception_);
			return cb_onError_Ljava_lang_Exception_;
		}

		static void n_OnError_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.CallbackEmptyCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.OnError (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Callback.EmptyCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onError", "(Ljava/lang/Exception;)V", "GetOnError_Ljava_lang_Exception_Handler")]
		public virtual unsafe void OnError (global::Java.Lang.Exception e)
		{
			const string __id = "onError.(Ljava/lang/Exception;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (e);
			}
		}

		static Delegate cb_onSuccess;
#pragma warning disable 0169
		static Delegate GetOnSuccessHandler ()
		{
			if (cb_onSuccess == null)
				cb_onSuccess = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnSuccess);
			return cb_onSuccess;
		}

		static void n_OnSuccess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.CallbackEmptyCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/class[@name='Callback.EmptyCallback']/method[@name='onSuccess' and count(parameter)=0]"
		[Register ("onSuccess", "()V", "GetOnSuccessHandler")]
		public virtual unsafe void OnSuccess ()
		{
			const string __id = "onSuccess.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.squareup.picasso']/interface[@name='Callback']"
	[Register ("com/squareup/picasso/Callback", "", "Com.Squareup.Picasso.ICallbackInvoker")]
	public partial interface ICallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/interface[@name='Callback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onError", "(Ljava/lang/Exception;)V", "GetOnError_Ljava_lang_Exception_Handler:Com.Squareup.Picasso.ICallbackInvoker, AppodealXamarinAndroid")]
		void OnError (global::Java.Lang.Exception p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.squareup.picasso']/interface[@name='Callback']/method[@name='onSuccess' and count(parameter)=0]"
		[Register ("onSuccess", "()V", "GetOnSuccessHandler:Com.Squareup.Picasso.ICallbackInvoker, AppodealXamarinAndroid")]
		void OnSuccess ();

	}

	[global::Android.Runtime.Register ("com/squareup/picasso/Callback", DoNotGenerateAcw=true)]
	internal partial class ICallbackInvoker : global::Java.Lang.Object, ICallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/squareup/picasso/Callback", typeof (ICallbackInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.squareup.picasso.Callback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onError_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_lang_Exception_Handler ()
		{
			if (cb_onError_Ljava_lang_Exception_ == null)
				cb_onError_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnError_Ljava_lang_Exception_);
			return cb_onError_Ljava_lang_Exception_;
		}

		static void n_OnError_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Ljava_lang_Exception_;
		public unsafe void OnError (global::Java.Lang.Exception p0)
		{
			if (id_onError_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onError_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Exception_, __args);
		}

		static Delegate cb_onSuccess;
#pragma warning disable 0169
		static Delegate GetOnSuccessHandler ()
		{
			if (cb_onSuccess == null)
				cb_onSuccess = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnSuccess);
			return cb_onSuccess;
		}

		static void n_OnSuccess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Squareup.Picasso.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onSuccess;
		public unsafe void OnSuccess ()
		{
			if (id_onSuccess == IntPtr.Zero)
				id_onSuccess = JNIEnv.GetMethodID (class_ref, "onSuccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess);
		}

	}
}
