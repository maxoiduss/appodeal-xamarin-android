using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Mraid.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDParser']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/mraid/internal/MRAIDParser", DoNotGenerateAcw=true)]
	public partial class MRAIDParser : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/mraid/internal/MRAIDParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MRAIDParser); }
		}

		protected MRAIDParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDParser']/constructor[@name='MRAIDParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MRAIDParser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MRAIDParser)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_parseCommandUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetParseCommandUrl_Ljava_lang_String_Handler ()
		{
			if (cb_parseCommandUrl_Ljava_lang_String_ == null)
				cb_parseCommandUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ParseCommandUrl_Ljava_lang_String_);
			return cb_parseCommandUrl_Ljava_lang_String_;
		}

		static IntPtr n_ParseCommandUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDParser __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (__this.ParseCommandUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_parseCommandUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDParser']/method[@name='parseCommandUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseCommandUrl", "(Ljava/lang/String;)Ljava/util/Map;", "GetParseCommandUrl_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.IDictionary ParseCommandUrl (string p0)
		{
			if (id_parseCommandUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_parseCommandUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "parseCommandUrl", "(Ljava/lang/String;)Ljava/util/Map;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.IDictionary __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_parseCommandUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parseCommandUrl", "(Ljava/lang/String;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
