using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Numbers']"
	[global::Android.Runtime.Register ("com/mopub/common/util/Numbers", DoNotGenerateAcw=true)]
	public partial class Numbers : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/util/Numbers", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Numbers); }
		}

		protected Numbers (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_convertMillisecondsToSecondsRoundedUp_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Numbers']/method[@name='convertMillisecondsToSecondsRoundedUp' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("convertMillisecondsToSecondsRoundedUp", "(J)J", "")]
		public static unsafe long ConvertMillisecondsToSecondsRoundedUp (long p0)
		{
			if (id_convertMillisecondsToSecondsRoundedUp_J == IntPtr.Zero)
				id_convertMillisecondsToSecondsRoundedUp_J = JNIEnv.GetStaticMethodID (class_ref, "convertMillisecondsToSecondsRoundedUp", "(J)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticLongMethod  (class_ref, id_convertMillisecondsToSecondsRoundedUp_J, __args);
			} finally {
			}
		}

		static IntPtr id_parseDouble_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Numbers']/method[@name='parseDouble' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("parseDouble", "(Ljava/lang/Object;)Ljava/lang/Double;", "")]
		public static unsafe global::Java.Lang.Double ParseDouble (global::Java.Lang.Object p0)
		{
			if (id_parseDouble_Ljava_lang_Object_ == IntPtr.Zero)
				id_parseDouble_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "parseDouble", "(Ljava/lang/Object;)Ljava/lang/Double;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Double __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDouble_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
