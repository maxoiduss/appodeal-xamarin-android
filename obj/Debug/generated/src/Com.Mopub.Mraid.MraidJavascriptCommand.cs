using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mraid {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidJavascriptCommand']"
	[global::Android.Runtime.Register ("com/mopub/mraid/MraidJavascriptCommand", DoNotGenerateAcw=true)]
	public partial class MraidJavascriptCommand : global::Java.Lang.Enum {


		static IntPtr CLOSE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidJavascriptCommand']/field[@name='CLOSE']"
		[Register ("CLOSE")]
		public static global::Com.Mopub.Mraid.MraidJavascriptCommand Close {
			get {
				if (CLOSE_jfieldId == IntPtr.Zero)
					CLOSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOSE", "Lcom/mopub/mraid/MraidJavascriptCommand;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLOSE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidJavascriptCommand> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CREATE_CALENDAR_EVENT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidJavascriptCommand']/field[@name='CREATE_CALENDAR_EVENT']"
		[Register ("CREATE_CALENDAR_EVENT")]
		public static global::Com.Mopub.Mraid.MraidJavascriptCommand CreateCalendarEvent {
			get {
				if (CREATE_CALENDAR_EVENT_jfieldId == IntPtr.Zero)
					CREATE_CALENDAR_EVENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATE_CALENDAR_EVENT", "Lcom/mopub/mraid/MraidJavascriptCommand;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATE_CALENDAR_EVENT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidJavascriptCommand> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXPAND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidJavascriptCommand']/field[@name='EXPAND']"
		[Register ("EXPAND")]
		public static global::Com.Mopub.Mraid.MraidJavascriptCommand Expand {
			get {
				if (EXPAND_jfieldId == IntPtr.Zero)
					EXPAND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXPAND", "Lcom/mopub/mraid/MraidJavascriptCommand;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXPAND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidJavascriptCommand> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OPEN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidJavascriptCommand']/field[@name='OPEN']"
		[Register ("OPEN")]
		public static global::Com.Mopub.Mraid.MraidJavascriptCommand Open {
			get {
				if (OPEN_jfieldId == IntPtr.Zero)
					OPEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPEN", "Lcom/mopub/mraid/MraidJavascriptCommand;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OPEN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidJavascriptCommand> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PLAY_VIDEO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidJavascriptCommand']/field[@name='PLAY_VIDEO']"
		[Register ("PLAY_VIDEO")]
		public static global::Com.Mopub.Mraid.MraidJavascriptCommand PlayVideo {
			get {
				if (PLAY_VIDEO_jfieldId == IntPtr.Zero)
					PLAY_VIDEO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAY_VIDEO", "Lcom/mopub/mraid/MraidJavascriptCommand;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAY_VIDEO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidJavascriptCommand> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RESIZE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidJavascriptCommand']/field[@name='RESIZE']"
		[Register ("RESIZE")]
		public static global::Com.Mopub.Mraid.MraidJavascriptCommand Resize {
			get {
				if (RESIZE_jfieldId == IntPtr.Zero)
					RESIZE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESIZE", "Lcom/mopub/mraid/MraidJavascriptCommand;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RESIZE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidJavascriptCommand> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SET_ORIENTATION_PROPERTIES_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidJavascriptCommand']/field[@name='SET_ORIENTATION_PROPERTIES']"
		[Register ("SET_ORIENTATION_PROPERTIES")]
		public static global::Com.Mopub.Mraid.MraidJavascriptCommand SetOrientationProperties {
			get {
				if (SET_ORIENTATION_PROPERTIES_jfieldId == IntPtr.Zero)
					SET_ORIENTATION_PROPERTIES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SET_ORIENTATION_PROPERTIES", "Lcom/mopub/mraid/MraidJavascriptCommand;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SET_ORIENTATION_PROPERTIES_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidJavascriptCommand> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr STORE_PICTURE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidJavascriptCommand']/field[@name='STORE_PICTURE']"
		[Register ("STORE_PICTURE")]
		public static global::Com.Mopub.Mraid.MraidJavascriptCommand StorePicture {
			get {
				if (STORE_PICTURE_jfieldId == IntPtr.Zero)
					STORE_PICTURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STORE_PICTURE", "Lcom/mopub/mraid/MraidJavascriptCommand;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STORE_PICTURE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidJavascriptCommand> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNSPECIFIED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidJavascriptCommand']/field[@name='UNSPECIFIED']"
		[Register ("UNSPECIFIED")]
		public static global::Com.Mopub.Mraid.MraidJavascriptCommand Unspecified {
			get {
				if (UNSPECIFIED_jfieldId == IntPtr.Zero)
					UNSPECIFIED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSPECIFIED", "Lcom/mopub/mraid/MraidJavascriptCommand;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNSPECIFIED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidJavascriptCommand> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr USE_CUSTOM_CLOSE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidJavascriptCommand']/field[@name='USE_CUSTOM_CLOSE']"
		[Register ("USE_CUSTOM_CLOSE")]
		public static global::Com.Mopub.Mraid.MraidJavascriptCommand UseCustomClose {
			get {
				if (USE_CUSTOM_CLOSE_jfieldId == IntPtr.Zero)
					USE_CUSTOM_CLOSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USE_CUSTOM_CLOSE", "Lcom/mopub/mraid/MraidJavascriptCommand;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USE_CUSTOM_CLOSE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidJavascriptCommand> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mraid/MraidJavascriptCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MraidJavascriptCommand); }
		}

		protected MraidJavascriptCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidJavascriptCommand']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/mraid/MraidJavascriptCommand;", "")]
		public static unsafe global::Com.Mopub.Mraid.MraidJavascriptCommand ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/mraid/MraidJavascriptCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Mopub.Mraid.MraidJavascriptCommand __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mraid.MraidJavascriptCommand> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mraid']/class[@name='MraidJavascriptCommand']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/mopub/mraid/MraidJavascriptCommand;", "")]
		public static unsafe global::Com.Mopub.Mraid.MraidJavascriptCommand[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/mraid/MraidJavascriptCommand;");
			try {
				return (global::Com.Mopub.Mraid.MraidJavascriptCommand[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Mraid.MraidJavascriptCommand));
			} finally {
			}
		}

	}
}
