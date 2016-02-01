using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='CreativeOrientation']"
	[global::Android.Runtime.Register ("com/mopub/common/CreativeOrientation", DoNotGenerateAcw=true)]
	public sealed partial class CreativeOrientation : global::Java.Lang.Enum {


		static IntPtr LANDSCAPE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='CreativeOrientation']/field[@name='LANDSCAPE']"
		[Register ("LANDSCAPE")]
		public static global::Com.Mopub.Common.CreativeOrientation Landscape {
			get {
				if (LANDSCAPE_jfieldId == IntPtr.Zero)
					LANDSCAPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LANDSCAPE", "Lcom/mopub/common/CreativeOrientation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LANDSCAPE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CreativeOrientation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PORTRAIT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='CreativeOrientation']/field[@name='PORTRAIT']"
		[Register ("PORTRAIT")]
		public static global::Com.Mopub.Common.CreativeOrientation Portrait {
			get {
				if (PORTRAIT_jfieldId == IntPtr.Zero)
					PORTRAIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PORTRAIT", "Lcom/mopub/common/CreativeOrientation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PORTRAIT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CreativeOrientation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNDEFINED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='CreativeOrientation']/field[@name='UNDEFINED']"
		[Register ("UNDEFINED")]
		public static global::Com.Mopub.Common.CreativeOrientation Undefined {
			get {
				if (UNDEFINED_jfieldId == IntPtr.Zero)
					UNDEFINED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNDEFINED", "Lcom/mopub/common/CreativeOrientation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNDEFINED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CreativeOrientation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/CreativeOrientation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CreativeOrientation); }
		}

		internal CreativeOrientation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_fromHeader_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CreativeOrientation']/method[@name='fromHeader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromHeader", "(Ljava/lang/String;)Lcom/mopub/common/CreativeOrientation;", "")]
		public static unsafe global::Com.Mopub.Common.CreativeOrientation FromHeader (string p0)
		{
			if (id_fromHeader_Ljava_lang_String_ == IntPtr.Zero)
				id_fromHeader_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromHeader", "(Ljava/lang/String;)Lcom/mopub/common/CreativeOrientation;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Mopub.Common.CreativeOrientation __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CreativeOrientation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromHeader_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CreativeOrientation']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/common/CreativeOrientation;", "")]
		public static unsafe global::Com.Mopub.Common.CreativeOrientation ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/common/CreativeOrientation;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Mopub.Common.CreativeOrientation __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.CreativeOrientation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='CreativeOrientation']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/mopub/common/CreativeOrientation;", "")]
		public static unsafe global::Com.Mopub.Common.CreativeOrientation[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/common/CreativeOrientation;");
			try {
				return (global::Com.Mopub.Common.CreativeOrientation[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Common.CreativeOrientation));
			} finally {
			}
		}

	}
}
