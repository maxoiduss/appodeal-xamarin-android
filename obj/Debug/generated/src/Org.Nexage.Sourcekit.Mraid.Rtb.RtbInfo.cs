using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Mraid.Rtb {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.mraid.rtb']/class[@name='RtbInfo']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/mraid/rtb/RtbInfo", DoNotGenerateAcw=true)]
	public partial class RtbInfo : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/mraid/rtb/RtbInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RtbInfo); }
		}

		protected RtbInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.mraid.rtb']/class[@name='RtbInfo']/constructor[@name='RtbInfo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Ljava/lang/String;Lorg/json/JSONObject;)V", "")]
		public unsafe RtbInfo (string p0, global::Org.Json.JSONObject p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (RtbInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lorg/json/JSONObject;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lorg/json/JSONObject;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lorg/json/JSONObject;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lorg_json_JSONObject_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lorg_json_JSONObject_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getBidderName;
#pragma warning disable 0169
		static Delegate GetGetBidderNameHandler ()
		{
			if (cb_getBidderName == null)
				cb_getBidderName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBidderName);
			return cb_getBidderName;
		}

		static IntPtr n_GetBidderName (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Mraid.Rtb.RtbInfo __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.Rtb.RtbInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BidderName);
		}
#pragma warning restore 0169

		static IntPtr id_getBidderName;
		public virtual unsafe string BidderName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.rtb']/class[@name='RtbInfo']/method[@name='getBidderName' and count(parameter)=0]"
			[Register ("getBidderName", "()Ljava/lang/String;", "GetGetBidderNameHandler")]
			get {
				if (id_getBidderName == IntPtr.Zero)
					id_getBidderName = JNIEnv.GetMethodID (class_ref, "getBidderName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBidderName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBidderName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getReportInfo;
#pragma warning disable 0169
		static Delegate GetGetReportInfoHandler ()
		{
			if (cb_getReportInfo == null)
				cb_getReportInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReportInfo);
			return cb_getReportInfo;
		}

		static IntPtr n_GetReportInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Mraid.Rtb.RtbInfo __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.Rtb.RtbInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReportInfo);
		}
#pragma warning restore 0169

		static IntPtr id_getReportInfo;
		public virtual unsafe global::Org.Json.JSONObject ReportInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.rtb']/class[@name='RtbInfo']/method[@name='getReportInfo' and count(parameter)=0]"
			[Register ("getReportInfo", "()Lorg/json/JSONObject;", "GetGetReportInfoHandler")]
			get {
				if (id_getReportInfo == IntPtr.Zero)
					id_getReportInfo = JNIEnv.GetMethodID (class_ref, "getReportInfo", "()Lorg/json/JSONObject;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getReportInfo), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReportInfo", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
