using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Mraid {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/interface[@name='MRAIDInterstitialListener']"
	[Register ("org/nexage/sourcekit/mraid/MRAIDInterstitialListener", "", "Org.Nexage.Sourcekit.Mraid.IMRAIDInterstitialListenerInvoker")]
	public partial interface IMRAIDInterstitialListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/interface[@name='MRAIDInterstitialListener']/method[@name='mraidInterstitialHide' and count(parameter)=1 and parameter[1][@type='org.nexage.sourcekit.mraid.MRAIDInterstitial']]"
		[Register ("mraidInterstitialHide", "(Lorg/nexage/sourcekit/mraid/MRAIDInterstitial;)V", "GetMraidInterstitialHide_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_Handler:Org.Nexage.Sourcekit.Mraid.IMRAIDInterstitialListenerInvoker, AppodealXamarinPlugin")]
		void MraidInterstitialHide (global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/interface[@name='MRAIDInterstitialListener']/method[@name='mraidInterstitialLoaded' and count(parameter)=1 and parameter[1][@type='org.nexage.sourcekit.mraid.MRAIDInterstitial']]"
		[Register ("mraidInterstitialLoaded", "(Lorg/nexage/sourcekit/mraid/MRAIDInterstitial;)V", "GetMraidInterstitialLoaded_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_Handler:Org.Nexage.Sourcekit.Mraid.IMRAIDInterstitialListenerInvoker, AppodealXamarinPlugin")]
		void MraidInterstitialLoaded (global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/interface[@name='MRAIDInterstitialListener']/method[@name='mraidInterstitialShow' and count(parameter)=1 and parameter[1][@type='org.nexage.sourcekit.mraid.MRAIDInterstitial']]"
		[Register ("mraidInterstitialShow", "(Lorg/nexage/sourcekit/mraid/MRAIDInterstitial;)V", "GetMraidInterstitialShow_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_Handler:Org.Nexage.Sourcekit.Mraid.IMRAIDInterstitialListenerInvoker, AppodealXamarinPlugin")]
		void MraidInterstitialShow (global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial p0);

	}

	[global::Android.Runtime.Register ("org/nexage/sourcekit/mraid/MRAIDInterstitialListener", DoNotGenerateAcw=true)]
	internal class IMRAIDInterstitialListenerInvoker : global::Java.Lang.Object, IMRAIDInterstitialListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/nexage/sourcekit/mraid/MRAIDInterstitialListener");
		IntPtr class_ref;

		public static IMRAIDInterstitialListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMRAIDInterstitialListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.nexage.sourcekit.mraid.MRAIDInterstitialListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMRAIDInterstitialListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMRAIDInterstitialListenerInvoker); }
		}

		static Delegate cb_mraidInterstitialHide_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_;
#pragma warning disable 0169
		static Delegate GetMraidInterstitialHide_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_Handler ()
		{
			if (cb_mraidInterstitialHide_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_ == null)
				cb_mraidInterstitialHide_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MraidInterstitialHide_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_);
			return cb_mraidInterstitialHide_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_;
		}

		static void n_MraidInterstitialHide_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Mraid.IMRAIDInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.IMRAIDInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial p0 = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MraidInterstitialHide (p0);
		}
#pragma warning restore 0169

		IntPtr id_mraidInterstitialHide_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_;
		public unsafe void MraidInterstitialHide (global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial p0)
		{
			if (id_mraidInterstitialHide_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_ == IntPtr.Zero)
				id_mraidInterstitialHide_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_ = JNIEnv.GetMethodID (class_ref, "mraidInterstitialHide", "(Lorg/nexage/sourcekit/mraid/MRAIDInterstitial;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_mraidInterstitialHide_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_, __args);
		}

		static Delegate cb_mraidInterstitialLoaded_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_;
#pragma warning disable 0169
		static Delegate GetMraidInterstitialLoaded_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_Handler ()
		{
			if (cb_mraidInterstitialLoaded_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_ == null)
				cb_mraidInterstitialLoaded_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MraidInterstitialLoaded_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_);
			return cb_mraidInterstitialLoaded_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_;
		}

		static void n_MraidInterstitialLoaded_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Mraid.IMRAIDInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.IMRAIDInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial p0 = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MraidInterstitialLoaded (p0);
		}
#pragma warning restore 0169

		IntPtr id_mraidInterstitialLoaded_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_;
		public unsafe void MraidInterstitialLoaded (global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial p0)
		{
			if (id_mraidInterstitialLoaded_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_ == IntPtr.Zero)
				id_mraidInterstitialLoaded_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_ = JNIEnv.GetMethodID (class_ref, "mraidInterstitialLoaded", "(Lorg/nexage/sourcekit/mraid/MRAIDInterstitial;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_mraidInterstitialLoaded_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_, __args);
		}

		static Delegate cb_mraidInterstitialShow_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_;
#pragma warning disable 0169
		static Delegate GetMraidInterstitialShow_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_Handler ()
		{
			if (cb_mraidInterstitialShow_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_ == null)
				cb_mraidInterstitialShow_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MraidInterstitialShow_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_);
			return cb_mraidInterstitialShow_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_;
		}

		static void n_MraidInterstitialShow_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Mraid.IMRAIDInterstitialListener __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.IMRAIDInterstitialListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial p0 = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MraidInterstitialShow (p0);
		}
#pragma warning restore 0169

		IntPtr id_mraidInterstitialShow_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_;
		public unsafe void MraidInterstitialShow (global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial p0)
		{
			if (id_mraidInterstitialShow_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_ == IntPtr.Zero)
				id_mraidInterstitialShow_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_ = JNIEnv.GetMethodID (class_ref, "mraidInterstitialShow", "(Lorg/nexage/sourcekit/mraid/MRAIDInterstitial;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_mraidInterstitialShow_Lorg_nexage_sourcekit_mraid_MRAIDInterstitial_, __args);
		}

	}

	public partial class MraidInterstitialHideEventArgs : global::System.EventArgs {

		public MraidInterstitialHideEventArgs (global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial p0)
		{
			this.p0 = p0;
		}

		global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial p0;
		public global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial P0 {
			get { return p0; }
		}
	}

	public partial class MraidInterstitialLoadedEventArgs : global::System.EventArgs {

		public MraidInterstitialLoadedEventArgs (global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial p0)
		{
			this.p0 = p0;
		}

		global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial p0;
		public global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial P0 {
			get { return p0; }
		}
	}

	public partial class MraidInterstitialShowEventArgs : global::System.EventArgs {

		public MraidInterstitialShowEventArgs (global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial p0)
		{
			this.p0 = p0;
		}

		global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial p0;
		public global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/org/nexage/sourcekit/mraid/MRAIDInterstitialListenerImplementor")]
	internal sealed partial class IMRAIDInterstitialListenerImplementor : global::Java.Lang.Object, IMRAIDInterstitialListener {

		object sender;

		public IMRAIDInterstitialListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/nexage/sourcekit/mraid/MRAIDInterstitialListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MraidInterstitialHideEventArgs> MraidInterstitialHideHandler;
#pragma warning restore 0649

		public void MraidInterstitialHide (global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial p0)
		{
			var __h = MraidInterstitialHideHandler;
			if (__h != null)
				__h (sender, new MraidInterstitialHideEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<MraidInterstitialLoadedEventArgs> MraidInterstitialLoadedHandler;
#pragma warning restore 0649

		public void MraidInterstitialLoaded (global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial p0)
		{
			var __h = MraidInterstitialLoadedHandler;
			if (__h != null)
				__h (sender, new MraidInterstitialLoadedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<MraidInterstitialShowEventArgs> MraidInterstitialShowHandler;
#pragma warning restore 0649

		public void MraidInterstitialShow (global::Org.Nexage.Sourcekit.Mraid.MRAIDInterstitial p0)
		{
			var __h = MraidInterstitialShowHandler;
			if (__h != null)
				__h (sender, new MraidInterstitialShowEventArgs (p0));
		}

		internal static bool __IsEmpty (IMRAIDInterstitialListenerImplementor value)
		{
			return value.MraidInterstitialHideHandler == null && value.MraidInterstitialLoadedHandler == null && value.MraidInterstitialShowHandler == null;
		}
	}

}
