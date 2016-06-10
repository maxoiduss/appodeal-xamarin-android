using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Vast.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VAST_DOC_ELEMENTS']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/vast/model/VAST_DOC_ELEMENTS", DoNotGenerateAcw=true)]
	public sealed partial class VAST_DOC_ELEMENTS : global::Java.Lang.Enum {


		static IntPtr vastAdTagURI_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VAST_DOC_ELEMENTS']/field[@name='vastAdTagURI']"
		[Register ("vastAdTagURI")]
		public static global::Org.Nexage.Sourcekit.Vast.Model.VAST_DOC_ELEMENTS VastAdTagURI {
			get {
				if (vastAdTagURI_jfieldId == IntPtr.Zero)
					vastAdTagURI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vastAdTagURI", "Lorg/nexage/sourcekit/vast/model/VAST_DOC_ELEMENTS;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, vastAdTagURI_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VAST_DOC_ELEMENTS> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr vastVersion_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VAST_DOC_ELEMENTS']/field[@name='vastVersion']"
		[Register ("vastVersion")]
		public static global::Org.Nexage.Sourcekit.Vast.Model.VAST_DOC_ELEMENTS VastVersion {
			get {
				if (vastVersion_jfieldId == IntPtr.Zero)
					vastVersion_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vastVersion", "Lorg/nexage/sourcekit/vast/model/VAST_DOC_ELEMENTS;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, vastVersion_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VAST_DOC_ELEMENTS> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr vastVersionAttribute_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VAST_DOC_ELEMENTS']/field[@name='vastVersionAttribute']"
		[Register ("vastVersionAttribute")]
		public static global::Org.Nexage.Sourcekit.Vast.Model.VAST_DOC_ELEMENTS VastVersionAttribute {
			get {
				if (vastVersionAttribute_jfieldId == IntPtr.Zero)
					vastVersionAttribute_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vastVersionAttribute", "Lorg/nexage/sourcekit/vast/model/VAST_DOC_ELEMENTS;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, vastVersionAttribute_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VAST_DOC_ELEMENTS> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr vasts_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VAST_DOC_ELEMENTS']/field[@name='vasts']"
		[Register ("vasts")]
		public static global::Org.Nexage.Sourcekit.Vast.Model.VAST_DOC_ELEMENTS Vasts {
			get {
				if (vasts_jfieldId == IntPtr.Zero)
					vasts_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "vasts", "Lorg/nexage/sourcekit/vast/model/VAST_DOC_ELEMENTS;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, vasts_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VAST_DOC_ELEMENTS> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/vast/model/VAST_DOC_ELEMENTS", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VAST_DOC_ELEMENTS); }
		}

		internal VAST_DOC_ELEMENTS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getValue;
		public unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VAST_DOC_ELEMENTS']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VAST_DOC_ELEMENTS']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/nexage/sourcekit/vast/model/VAST_DOC_ELEMENTS;", "")]
		public static unsafe global::Org.Nexage.Sourcekit.Vast.Model.VAST_DOC_ELEMENTS ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/nexage/sourcekit/vast/model/VAST_DOC_ELEMENTS;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Nexage.Sourcekit.Vast.Model.VAST_DOC_ELEMENTS __ret = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VAST_DOC_ELEMENTS> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VAST_DOC_ELEMENTS']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/nexage/sourcekit/vast/model/VAST_DOC_ELEMENTS;", "")]
		public static unsafe global::Org.Nexage.Sourcekit.Vast.Model.VAST_DOC_ELEMENTS[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/nexage/sourcekit/vast/model/VAST_DOC_ELEMENTS;");
			try {
				return (global::Org.Nexage.Sourcekit.Vast.Model.VAST_DOC_ELEMENTS[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Nexage.Sourcekit.Vast.Model.VAST_DOC_ELEMENTS));
			} finally {
			}
		}

	}
}
