using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mraid {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mraid']/class[@name='PlacementType']"
	[global::Android.Runtime.Register ("com/mopub/mraid/PlacementType", DoNotGenerateAcw=true)]
	public sealed partial class PlacementType : global::Java.Lang.Enum {


		static IntPtr INLINE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mraid']/class[@name='PlacementType']/field[@name='INLINE']"
		[Register ("INLINE")]
		public static global::Com.Mopub.Mraid.PlacementType Inline {
			get {
				if (INLINE_jfieldId == IntPtr.Zero)
					INLINE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INLINE", "Lcom/mopub/mraid/PlacementType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INLINE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.PlacementType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INTERSTITIAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mraid']/class[@name='PlacementType']/field[@name='INTERSTITIAL']"
		[Register ("INTERSTITIAL")]
		public static global::Com.Mopub.Mraid.PlacementType Interstitial {
			get {
				if (INTERSTITIAL_jfieldId == IntPtr.Zero)
					INTERSTITIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERSTITIAL", "Lcom/mopub/mraid/PlacementType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERSTITIAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.PlacementType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mraid/PlacementType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlacementType); }
		}

		internal PlacementType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='PlacementType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/mraid/PlacementType;", "")]
		public static unsafe global::Com.Mopub.Mraid.PlacementType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/mraid/PlacementType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Mopub.Mraid.PlacementType __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.PlacementType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='PlacementType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/mopub/mraid/PlacementType;", "")]
		public static unsafe global::Com.Mopub.Mraid.PlacementType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/mraid/PlacementType;");
			try {
				return (global::Com.Mopub.Mraid.PlacementType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Mraid.PlacementType));
			} finally {
			}
		}

	}
}
