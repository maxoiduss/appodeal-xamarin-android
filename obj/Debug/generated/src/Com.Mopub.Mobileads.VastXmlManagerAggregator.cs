using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastXmlManagerAggregator']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/VastXmlManagerAggregator", DoNotGenerateAcw=true)]
	public partial class VastXmlManagerAggregator : global::Android.OS.AsyncTask {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastXmlManagerAggregator.CompanionOrientation']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/VastXmlManagerAggregator$CompanionOrientation", DoNotGenerateAcw=true)]
		public sealed partial class CompanionOrientation : global::Java.Lang.Enum {


			static IntPtr LANDSCAPE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastXmlManagerAggregator.CompanionOrientation']/field[@name='LANDSCAPE']"
			[Register ("LANDSCAPE")]
			public static global::Com.Mopub.Mobileads.VastXmlManagerAggregator.CompanionOrientation Landscape {
				get {
					if (LANDSCAPE_jfieldId == IntPtr.Zero)
						LANDSCAPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LANDSCAPE", "Lcom/mopub/mobileads/VastXmlManagerAggregator$CompanionOrientation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LANDSCAPE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastXmlManagerAggregator.CompanionOrientation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PORTRAIT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastXmlManagerAggregator.CompanionOrientation']/field[@name='PORTRAIT']"
			[Register ("PORTRAIT")]
			public static global::Com.Mopub.Mobileads.VastXmlManagerAggregator.CompanionOrientation Portrait {
				get {
					if (PORTRAIT_jfieldId == IntPtr.Zero)
						PORTRAIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PORTRAIT", "Lcom/mopub/mobileads/VastXmlManagerAggregator$CompanionOrientation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PORTRAIT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastXmlManagerAggregator.CompanionOrientation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/VastXmlManagerAggregator$CompanionOrientation", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CompanionOrientation); }
			}

			internal CompanionOrientation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='VastXmlManagerAggregator.VastXmlManagerAggregatorListener']"
		[Register ("com/mopub/mobileads/VastXmlManagerAggregator$VastXmlManagerAggregatorListener", "", "Com.Mopub.Mobileads.VastXmlManagerAggregator/IVastXmlManagerAggregatorListenerInvoker")]
		public partial interface IVastXmlManagerAggregatorListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='VastXmlManagerAggregator.VastXmlManagerAggregatorListener']/method[@name='onAggregationComplete' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.VastVideoConfig']]"
			[Register ("onAggregationComplete", "(Lcom/mopub/mobileads/VastVideoConfig;)V", "GetOnAggregationComplete_Lcom_mopub_mobileads_VastVideoConfig_Handler:Com.Mopub.Mobileads.VastXmlManagerAggregator/IVastXmlManagerAggregatorListenerInvoker, AppodealXamarinPlugin")]
			void OnAggregationComplete (global::Com.Mopub.Mobileads.VastVideoConfig p0);

		}

		[global::Android.Runtime.Register ("com/mopub/mobileads/VastXmlManagerAggregator$VastXmlManagerAggregatorListener", DoNotGenerateAcw=true)]
		internal class IVastXmlManagerAggregatorListenerInvoker : global::Java.Lang.Object, IVastXmlManagerAggregatorListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/VastXmlManagerAggregator$VastXmlManagerAggregatorListener");
			IntPtr class_ref;

			public static IVastXmlManagerAggregatorListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IVastXmlManagerAggregatorListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.VastXmlManagerAggregator.VastXmlManagerAggregatorListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IVastXmlManagerAggregatorListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IVastXmlManagerAggregatorListenerInvoker); }
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
				global::Com.Mopub.Mobileads.VastXmlManagerAggregator.IVastXmlManagerAggregatorListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastXmlManagerAggregator.IVastXmlManagerAggregatorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.VastVideoConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAggregationComplete (p0);
			}
#pragma warning restore 0169

			IntPtr id_onAggregationComplete_Lcom_mopub_mobileads_VastVideoConfig_;
			public unsafe void OnAggregationComplete (global::Com.Mopub.Mobileads.VastVideoConfig p0)
			{
				if (id_onAggregationComplete_Lcom_mopub_mobileads_VastVideoConfig_ == IntPtr.Zero)
					id_onAggregationComplete_Lcom_mopub_mobileads_VastVideoConfig_ = JNIEnv.GetMethodID (class_ref, "onAggregationComplete", "(Lcom/mopub/mobileads/VastVideoConfig;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onAggregationComplete_Lcom_mopub_mobileads_VastVideoConfig_, __args);
			}

		}

		public partial class VastXmlManagerAggregatorEventArgs : global::System.EventArgs {

			public VastXmlManagerAggregatorEventArgs (global::Com.Mopub.Mobileads.VastVideoConfig p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Mobileads.VastVideoConfig p0;
			public global::Com.Mopub.Mobileads.VastVideoConfig P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/mobileads/VastXmlManagerAggregator_VastXmlManagerAggregatorListenerImplementor")]
		internal sealed partial class IVastXmlManagerAggregatorListenerImplementor : global::Java.Lang.Object, IVastXmlManagerAggregatorListener {

			object sender;

			public IVastXmlManagerAggregatorListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/mobileads/VastXmlManagerAggregator_VastXmlManagerAggregatorListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<VastXmlManagerAggregatorEventArgs> Handler;
#pragma warning restore 0649

			public void OnAggregationComplete (global::Com.Mopub.Mobileads.VastVideoConfig p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new VastXmlManagerAggregatorEventArgs (p0));
			}

			internal static bool __IsEmpty (IVastXmlManagerAggregatorListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/VastXmlManagerAggregator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VastXmlManagerAggregator); }
		}

		protected VastXmlManagerAggregator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_doInBackground_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDoInBackground_arrayLjava_lang_String_Handler ()
		{
			if (cb_doInBackground_arrayLjava_lang_String_ == null)
				cb_doInBackground_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_String_);
			return cb_doInBackground_arrayLjava_lang_String_;
		}

		static IntPtr n_DoInBackground_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastXmlManagerAggregator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastXmlManagerAggregator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_doInBackground_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastXmlManagerAggregator']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("doInBackground", "([Ljava/lang/String;)Lcom/mopub/mobileads/VastVideoConfig;", "GetDoInBackground_arrayLjava_lang_String_Handler")]
		protected virtual unsafe global::Com.Mopub.Mobileads.VastVideoConfig DoInBackground (params  string[] p0)
		{
			if (id_doInBackground_arrayLjava_lang_String_ == IntPtr.Zero)
				id_doInBackground_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/String;)Lcom/mopub/mobileads/VastVideoConfig;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mopub.Mobileads.VastVideoConfig __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (JNIEnv.CallObjectMethod  (Handle, id_doInBackground_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Ljava/lang/String;)Lcom/mopub/mobileads/VastVideoConfig;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_onPostExecute_Lcom_mopub_mobileads_VastVideoConfig_;
#pragma warning disable 0169
		static Delegate GetOnPostExecute_Lcom_mopub_mobileads_VastVideoConfig_Handler ()
		{
			if (cb_onPostExecute_Lcom_mopub_mobileads_VastVideoConfig_ == null)
				cb_onPostExecute_Lcom_mopub_mobileads_VastVideoConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPostExecute_Lcom_mopub_mobileads_VastVideoConfig_);
			return cb_onPostExecute_Lcom_mopub_mobileads_VastVideoConfig_;
		}

		static void n_OnPostExecute_Lcom_mopub_mobileads_VastVideoConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastXmlManagerAggregator __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastXmlManagerAggregator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.VastVideoConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPostExecute (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPostExecute_Lcom_mopub_mobileads_VastVideoConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastXmlManagerAggregator']/method[@name='onPostExecute' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.VastVideoConfig']]"
		[Register ("onPostExecute", "(Lcom/mopub/mobileads/VastVideoConfig;)V", "GetOnPostExecute_Lcom_mopub_mobileads_VastVideoConfig_Handler")]
		protected virtual unsafe void OnPostExecute (global::Com.Mopub.Mobileads.VastVideoConfig p0)
		{
			if (id_onPostExecute_Lcom_mopub_mobileads_VastVideoConfig_ == IntPtr.Zero)
				id_onPostExecute_Lcom_mopub_mobileads_VastVideoConfig_ = JNIEnv.GetMethodID (class_ref, "onPostExecute", "(Lcom/mopub/mobileads/VastVideoConfig;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onPostExecute_Lcom_mopub_mobileads_VastVideoConfig_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPostExecute", "(Lcom/mopub/mobileads/VastVideoConfig;)V"), __args);
			} finally {
			}
		}

	}
}
