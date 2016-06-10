using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='AdReport']"
	[global::Android.Runtime.Register ("com/mopub/common/AdReport", DoNotGenerateAcw=true)]
	public partial class AdReport : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/AdReport", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdReport); }
		}

		protected AdReport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_mopub_common_ClientMetadata_Lcom_mopub_network_AdResponse_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common']/class[@name='AdReport']/constructor[@name='AdReport' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.common.ClientMetadata'] and parameter[3][@type='com.mopub.network.AdResponse']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/mopub/common/ClientMetadata;Lcom/mopub/network/AdResponse;)V", "")]
		public unsafe AdReport (string p0, global::Com.Mopub.Common.ClientMetadata p1, global::Com.Mopub.Network.AdResponse p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (AdReport)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/mopub/common/ClientMetadata;Lcom/mopub/network/AdResponse;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lcom/mopub/common/ClientMetadata;Lcom/mopub/network/AdResponse;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_mopub_common_ClientMetadata_Lcom_mopub_network_AdResponse_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_mopub_common_ClientMetadata_Lcom_mopub_network_AdResponse_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/mopub/common/ClientMetadata;Lcom/mopub/network/AdResponse;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_mopub_common_ClientMetadata_Lcom_mopub_network_AdResponse_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_mopub_common_ClientMetadata_Lcom_mopub_network_AdResponse_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAdResponse;
#pragma warning disable 0169
		static Delegate GetGetAdResponseHandler ()
		{
			if (cb_getAdResponse == null)
				cb_getAdResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdResponse);
			return cb_getAdResponse;
		}

		static IntPtr n_GetAdResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.AdReport __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdResponse);
		}
#pragma warning restore 0169

		static IntPtr id_getAdResponse;
		public virtual unsafe global::Com.Mopub.Network.AdResponse AdResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='AdReport']/method[@name='getAdResponse' and count(parameter)=0]"
			[Register ("getAdResponse", "()Lcom/mopub/network/AdResponse;", "GetGetAdResponseHandler")]
			get {
				if (id_getAdResponse == IntPtr.Zero)
					id_getAdResponse = JNIEnv.GetMethodID (class_ref, "getAdResponse", "()Lcom/mopub/network/AdResponse;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (JNIEnv.CallObjectMethod  (Handle, id_getAdResponse), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdResponse", "()Lcom/mopub/network/AdResponse;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResponseString;
#pragma warning disable 0169
		static Delegate GetGetResponseStringHandler ()
		{
			if (cb_getResponseString == null)
				cb_getResponseString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseString);
			return cb_getResponseString;
		}

		static IntPtr n_GetResponseString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Common.AdReport __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.AdReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResponseString);
		}
#pragma warning restore 0169

		static IntPtr id_getResponseString;
		public virtual unsafe string ResponseString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='AdReport']/method[@name='getResponseString' and count(parameter)=0]"
			[Register ("getResponseString", "()Ljava/lang/String;", "GetGetResponseStringHandler")]
			get {
				if (id_getResponseString == IntPtr.Zero)
					id_getResponseString = JNIEnv.GetMethodID (class_ref, "getResponseString", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getResponseString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
