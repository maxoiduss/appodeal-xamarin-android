using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Mraid {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/interface[@name='MRAIDViewListener']"
	[Register ("org/nexage/sourcekit/mraid/MRAIDViewListener", "", "Org.Nexage.Sourcekit.Mraid.IMRAIDViewListenerInvoker")]
	public partial interface IMRAIDViewListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/interface[@name='MRAIDViewListener']/method[@name='mraidViewClose' and count(parameter)=1 and parameter[1][@type='org.nexage.sourcekit.mraid.MRAIDView']]"
		[Register ("mraidViewClose", "(Lorg/nexage/sourcekit/mraid/MRAIDView;)V", "GetMraidViewClose_Lorg_nexage_sourcekit_mraid_MRAIDView_Handler:Org.Nexage.Sourcekit.Mraid.IMRAIDViewListenerInvoker, AppodealXamarinPlugin")]
		void MraidViewClose (global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/interface[@name='MRAIDViewListener']/method[@name='mraidViewExpand' and count(parameter)=1 and parameter[1][@type='org.nexage.sourcekit.mraid.MRAIDView']]"
		[Register ("mraidViewExpand", "(Lorg/nexage/sourcekit/mraid/MRAIDView;)V", "GetMraidViewExpand_Lorg_nexage_sourcekit_mraid_MRAIDView_Handler:Org.Nexage.Sourcekit.Mraid.IMRAIDViewListenerInvoker, AppodealXamarinPlugin")]
		void MraidViewExpand (global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/interface[@name='MRAIDViewListener']/method[@name='mraidViewLoaded' and count(parameter)=1 and parameter[1][@type='org.nexage.sourcekit.mraid.MRAIDView']]"
		[Register ("mraidViewLoaded", "(Lorg/nexage/sourcekit/mraid/MRAIDView;)V", "GetMraidViewLoaded_Lorg_nexage_sourcekit_mraid_MRAIDView_Handler:Org.Nexage.Sourcekit.Mraid.IMRAIDViewListenerInvoker, AppodealXamarinPlugin")]
		void MraidViewLoaded (global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/interface[@name='MRAIDViewListener']/method[@name='mraidViewResize' and count(parameter)=5 and parameter[1][@type='org.nexage.sourcekit.mraid.MRAIDView'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("mraidViewResize", "(Lorg/nexage/sourcekit/mraid/MRAIDView;IIII)Z", "GetMraidViewResize_Lorg_nexage_sourcekit_mraid_MRAIDView_IIIIHandler:Org.Nexage.Sourcekit.Mraid.IMRAIDViewListenerInvoker, AppodealXamarinPlugin")]
		bool MraidViewResize (global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0, int p1, int p2, int p3, int p4);

	}

	[global::Android.Runtime.Register ("org/nexage/sourcekit/mraid/MRAIDViewListener", DoNotGenerateAcw=true)]
	internal class IMRAIDViewListenerInvoker : global::Java.Lang.Object, IMRAIDViewListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/nexage/sourcekit/mraid/MRAIDViewListener");
		IntPtr class_ref;

		public static IMRAIDViewListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMRAIDViewListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.nexage.sourcekit.mraid.MRAIDViewListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMRAIDViewListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMRAIDViewListenerInvoker); }
		}

		static Delegate cb_mraidViewClose_Lorg_nexage_sourcekit_mraid_MRAIDView_;
#pragma warning disable 0169
		static Delegate GetMraidViewClose_Lorg_nexage_sourcekit_mraid_MRAIDView_Handler ()
		{
			if (cb_mraidViewClose_Lorg_nexage_sourcekit_mraid_MRAIDView_ == null)
				cb_mraidViewClose_Lorg_nexage_sourcekit_mraid_MRAIDView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MraidViewClose_Lorg_nexage_sourcekit_mraid_MRAIDView_);
			return cb_mraidViewClose_Lorg_nexage_sourcekit_mraid_MRAIDView_;
		}

		static void n_MraidViewClose_Lorg_nexage_sourcekit_mraid_MRAIDView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Mraid.IMRAIDViewListener __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.IMRAIDViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0 = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.MRAIDView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MraidViewClose (p0);
		}
#pragma warning restore 0169

		IntPtr id_mraidViewClose_Lorg_nexage_sourcekit_mraid_MRAIDView_;
		public unsafe void MraidViewClose (global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0)
		{
			if (id_mraidViewClose_Lorg_nexage_sourcekit_mraid_MRAIDView_ == IntPtr.Zero)
				id_mraidViewClose_Lorg_nexage_sourcekit_mraid_MRAIDView_ = JNIEnv.GetMethodID (class_ref, "mraidViewClose", "(Lorg/nexage/sourcekit/mraid/MRAIDView;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_mraidViewClose_Lorg_nexage_sourcekit_mraid_MRAIDView_, __args);
		}

		static Delegate cb_mraidViewExpand_Lorg_nexage_sourcekit_mraid_MRAIDView_;
#pragma warning disable 0169
		static Delegate GetMraidViewExpand_Lorg_nexage_sourcekit_mraid_MRAIDView_Handler ()
		{
			if (cb_mraidViewExpand_Lorg_nexage_sourcekit_mraid_MRAIDView_ == null)
				cb_mraidViewExpand_Lorg_nexage_sourcekit_mraid_MRAIDView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MraidViewExpand_Lorg_nexage_sourcekit_mraid_MRAIDView_);
			return cb_mraidViewExpand_Lorg_nexage_sourcekit_mraid_MRAIDView_;
		}

		static void n_MraidViewExpand_Lorg_nexage_sourcekit_mraid_MRAIDView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Mraid.IMRAIDViewListener __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.IMRAIDViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0 = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.MRAIDView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MraidViewExpand (p0);
		}
#pragma warning restore 0169

		IntPtr id_mraidViewExpand_Lorg_nexage_sourcekit_mraid_MRAIDView_;
		public unsafe void MraidViewExpand (global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0)
		{
			if (id_mraidViewExpand_Lorg_nexage_sourcekit_mraid_MRAIDView_ == IntPtr.Zero)
				id_mraidViewExpand_Lorg_nexage_sourcekit_mraid_MRAIDView_ = JNIEnv.GetMethodID (class_ref, "mraidViewExpand", "(Lorg/nexage/sourcekit/mraid/MRAIDView;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_mraidViewExpand_Lorg_nexage_sourcekit_mraid_MRAIDView_, __args);
		}

		static Delegate cb_mraidViewLoaded_Lorg_nexage_sourcekit_mraid_MRAIDView_;
#pragma warning disable 0169
		static Delegate GetMraidViewLoaded_Lorg_nexage_sourcekit_mraid_MRAIDView_Handler ()
		{
			if (cb_mraidViewLoaded_Lorg_nexage_sourcekit_mraid_MRAIDView_ == null)
				cb_mraidViewLoaded_Lorg_nexage_sourcekit_mraid_MRAIDView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MraidViewLoaded_Lorg_nexage_sourcekit_mraid_MRAIDView_);
			return cb_mraidViewLoaded_Lorg_nexage_sourcekit_mraid_MRAIDView_;
		}

		static void n_MraidViewLoaded_Lorg_nexage_sourcekit_mraid_MRAIDView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Mraid.IMRAIDViewListener __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.IMRAIDViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0 = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.MRAIDView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MraidViewLoaded (p0);
		}
#pragma warning restore 0169

		IntPtr id_mraidViewLoaded_Lorg_nexage_sourcekit_mraid_MRAIDView_;
		public unsafe void MraidViewLoaded (global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0)
		{
			if (id_mraidViewLoaded_Lorg_nexage_sourcekit_mraid_MRAIDView_ == IntPtr.Zero)
				id_mraidViewLoaded_Lorg_nexage_sourcekit_mraid_MRAIDView_ = JNIEnv.GetMethodID (class_ref, "mraidViewLoaded", "(Lorg/nexage/sourcekit/mraid/MRAIDView;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_mraidViewLoaded_Lorg_nexage_sourcekit_mraid_MRAIDView_, __args);
		}

		static Delegate cb_mraidViewResize_Lorg_nexage_sourcekit_mraid_MRAIDView_IIII;
#pragma warning disable 0169
		static Delegate GetMraidViewResize_Lorg_nexage_sourcekit_mraid_MRAIDView_IIIIHandler ()
		{
			if (cb_mraidViewResize_Lorg_nexage_sourcekit_mraid_MRAIDView_IIII == null)
				cb_mraidViewResize_Lorg_nexage_sourcekit_mraid_MRAIDView_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int, int, bool>) n_MraidViewResize_Lorg_nexage_sourcekit_mraid_MRAIDView_IIII);
			return cb_mraidViewResize_Lorg_nexage_sourcekit_mraid_MRAIDView_IIII;
		}

		static bool n_MraidViewResize_Lorg_nexage_sourcekit_mraid_MRAIDView_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4)
		{
			global::Org.Nexage.Sourcekit.Mraid.IMRAIDViewListener __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.IMRAIDViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0 = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.MRAIDView> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.MraidViewResize (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_mraidViewResize_Lorg_nexage_sourcekit_mraid_MRAIDView_IIII;
		public unsafe bool MraidViewResize (global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0, int p1, int p2, int p3, int p4)
		{
			if (id_mraidViewResize_Lorg_nexage_sourcekit_mraid_MRAIDView_IIII == IntPtr.Zero)
				id_mraidViewResize_Lorg_nexage_sourcekit_mraid_MRAIDView_IIII = JNIEnv.GetMethodID (class_ref, "mraidViewResize", "(Lorg/nexage/sourcekit/mraid/MRAIDView;IIII)Z");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_mraidViewResize_Lorg_nexage_sourcekit_mraid_MRAIDView_IIII, __args);
			return __ret;
		}

	}

	public partial class MraidViewCloseEventArgs : global::System.EventArgs {

		public MraidViewCloseEventArgs (global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0)
		{
			this.p0 = p0;
		}

		global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0;
		public global::Org.Nexage.Sourcekit.Mraid.MRAIDView P0 {
			get { return p0; }
		}
	}

	public partial class MraidViewExpandEventArgs : global::System.EventArgs {

		public MraidViewExpandEventArgs (global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0)
		{
			this.p0 = p0;
		}

		global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0;
		public global::Org.Nexage.Sourcekit.Mraid.MRAIDView P0 {
			get { return p0; }
		}
	}

	public partial class MraidViewLoadedEventArgs : global::System.EventArgs {

		public MraidViewLoadedEventArgs (global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0)
		{
			this.p0 = p0;
		}

		global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0;
		public global::Org.Nexage.Sourcekit.Mraid.MRAIDView P0 {
			get { return p0; }
		}
	}

	public partial class MraidViewResizeEventArgs : global::System.EventArgs {

		public MraidViewResizeEventArgs (bool handled, global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0, int p1, int p2, int p3, int p4)
		{
			this.handled = handled;
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
		}

		bool handled;
		public bool Handled {
			get { return handled; }
			set { handled = value; }
		}

		global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0;
		public global::Org.Nexage.Sourcekit.Mraid.MRAIDView P0 {
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

		int p4;
		public int P4 {
			get { return p4; }
		}
	}

	[global::Android.Runtime.Register ("mono/org/nexage/sourcekit/mraid/MRAIDViewListenerImplementor")]
	internal sealed partial class IMRAIDViewListenerImplementor : global::Java.Lang.Object, IMRAIDViewListener {

		object sender;

		public IMRAIDViewListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/nexage/sourcekit/mraid/MRAIDViewListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MraidViewCloseEventArgs> MraidViewCloseHandler;
#pragma warning restore 0649

		public void MraidViewClose (global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0)
		{
			var __h = MraidViewCloseHandler;
			if (__h != null)
				__h (sender, new MraidViewCloseEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<MraidViewExpandEventArgs> MraidViewExpandHandler;
#pragma warning restore 0649

		public void MraidViewExpand (global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0)
		{
			var __h = MraidViewExpandHandler;
			if (__h != null)
				__h (sender, new MraidViewExpandEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<MraidViewLoadedEventArgs> MraidViewLoadedHandler;
#pragma warning restore 0649

		public void MraidViewLoaded (global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0)
		{
			var __h = MraidViewLoadedHandler;
			if (__h != null)
				__h (sender, new MraidViewLoadedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<MraidViewResizeEventArgs> MraidViewResizeHandler;
#pragma warning restore 0649

		public bool MraidViewResize (global::Org.Nexage.Sourcekit.Mraid.MRAIDView p0, int p1, int p2, int p3, int p4)
		{
			var __h = MraidViewResizeHandler;
			if (__h == null)
				return false;
			var __e = new MraidViewResizeEventArgs (true, p0, p1, p2, p3, p4);
			__h (sender, __e);
			return __e.Handled;
		}

		internal static bool __IsEmpty (IMRAIDViewListenerImplementor value)
		{
			return value.MraidViewCloseHandler == null && value.MraidViewExpandHandler == null && value.MraidViewLoadedHandler == null && value.MraidViewResizeHandler == null;
		}
	}

}
