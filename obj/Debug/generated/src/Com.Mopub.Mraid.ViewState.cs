using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mraid {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mraid']/class[@name='ViewState']"
	[global::Android.Runtime.Register ("com/mopub/mraid/ViewState", DoNotGenerateAcw=true)]
	public sealed partial class ViewState : global::Java.Lang.Enum {


		static IntPtr DEFAULT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mraid']/class[@name='ViewState']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Com.Mopub.Mraid.ViewState Default {
			get {
				if (DEFAULT_jfieldId == IntPtr.Zero)
					DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lcom/mopub/mraid/ViewState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.ViewState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXPANDED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mraid']/class[@name='ViewState']/field[@name='EXPANDED']"
		[Register ("EXPANDED")]
		public static global::Com.Mopub.Mraid.ViewState Expanded {
			get {
				if (EXPANDED_jfieldId == IntPtr.Zero)
					EXPANDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXPANDED", "Lcom/mopub/mraid/ViewState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXPANDED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.ViewState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HIDDEN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mraid']/class[@name='ViewState']/field[@name='HIDDEN']"
		[Register ("HIDDEN")]
		public static global::Com.Mopub.Mraid.ViewState Hidden {
			get {
				if (HIDDEN_jfieldId == IntPtr.Zero)
					HIDDEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HIDDEN", "Lcom/mopub/mraid/ViewState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HIDDEN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.ViewState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LOADING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mraid']/class[@name='ViewState']/field[@name='LOADING']"
		[Register ("LOADING")]
		public static global::Com.Mopub.Mraid.ViewState Loading {
			get {
				if (LOADING_jfieldId == IntPtr.Zero)
					LOADING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOADING", "Lcom/mopub/mraid/ViewState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOADING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.ViewState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RESIZED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mraid']/class[@name='ViewState']/field[@name='RESIZED']"
		[Register ("RESIZED")]
		public static global::Com.Mopub.Mraid.ViewState Resized {
			get {
				if (RESIZED_jfieldId == IntPtr.Zero)
					RESIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESIZED", "Lcom/mopub/mraid/ViewState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RESIZED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.ViewState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mraid/ViewState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewState); }
		}

		internal ViewState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_toJavascriptString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='ViewState']/method[@name='toJavascriptString' and count(parameter)=0]"
		[Register ("toJavascriptString", "()Ljava/lang/String;", "")]
		public unsafe string ToJavascriptString ()
		{
			if (id_toJavascriptString == IntPtr.Zero)
				id_toJavascriptString = JNIEnv.GetMethodID (class_ref, "toJavascriptString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toJavascriptString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='ViewState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/mraid/ViewState;", "")]
		public static unsafe global::Com.Mopub.Mraid.ViewState ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/mraid/ViewState;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Mopub.Mraid.ViewState __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.ViewState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='ViewState']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/mopub/mraid/ViewState;", "")]
		public static unsafe global::Com.Mopub.Mraid.ViewState[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/mraid/ViewState;");
			try {
				return (global::Com.Mopub.Mraid.ViewState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Mraid.ViewState));
			} finally {
			}
		}

	}
}
