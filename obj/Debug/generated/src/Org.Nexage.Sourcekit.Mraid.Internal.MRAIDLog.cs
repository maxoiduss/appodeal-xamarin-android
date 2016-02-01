using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Mraid.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDLog']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/mraid/internal/MRAIDLog", DoNotGenerateAcw=true)]
	public partial class MRAIDLog : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDLog.LOG_LEVEL']"
		[global::Android.Runtime.Register ("org/nexage/sourcekit/mraid/internal/MRAIDLog$LOG_LEVEL", DoNotGenerateAcw=true)]
		public sealed partial class LOG_LEVEL : global::Java.Lang.Enum {


			static IntPtr debug_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDLog.LOG_LEVEL']/field[@name='debug']"
			[Register ("debug")]
			public static global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDLog.LOG_LEVEL Debug {
				get {
					if (debug_jfieldId == IntPtr.Zero)
						debug_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "debug", "Lorg/nexage/sourcekit/mraid/internal/MRAIDLog$LOG_LEVEL;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, debug_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDLog.LOG_LEVEL> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr error_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDLog.LOG_LEVEL']/field[@name='error']"
			[Register ("error")]
			public static global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDLog.LOG_LEVEL Error {
				get {
					if (error_jfieldId == IntPtr.Zero)
						error_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "error", "Lorg/nexage/sourcekit/mraid/internal/MRAIDLog$LOG_LEVEL;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, error_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDLog.LOG_LEVEL> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr info_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDLog.LOG_LEVEL']/field[@name='info']"
			[Register ("info")]
			public static global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDLog.LOG_LEVEL Info {
				get {
					if (info_jfieldId == IntPtr.Zero)
						info_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "info", "Lorg/nexage/sourcekit/mraid/internal/MRAIDLog$LOG_LEVEL;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, info_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDLog.LOG_LEVEL> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr none_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDLog.LOG_LEVEL']/field[@name='none']"
			[Register ("none")]
			public static global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDLog.LOG_LEVEL None {
				get {
					if (none_jfieldId == IntPtr.Zero)
						none_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "none", "Lorg/nexage/sourcekit/mraid/internal/MRAIDLog$LOG_LEVEL;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, none_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDLog.LOG_LEVEL> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr verbose_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDLog.LOG_LEVEL']/field[@name='verbose']"
			[Register ("verbose")]
			public static global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDLog.LOG_LEVEL Verbose {
				get {
					if (verbose_jfieldId == IntPtr.Zero)
						verbose_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "verbose", "Lorg/nexage/sourcekit/mraid/internal/MRAIDLog$LOG_LEVEL;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, verbose_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDLog.LOG_LEVEL> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr warning_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDLog.LOG_LEVEL']/field[@name='warning']"
			[Register ("warning")]
			public static global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDLog.LOG_LEVEL Warning {
				get {
					if (warning_jfieldId == IntPtr.Zero)
						warning_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "warning", "Lorg/nexage/sourcekit/mraid/internal/MRAIDLog$LOG_LEVEL;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, warning_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDLog.LOG_LEVEL> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/nexage/sourcekit/mraid/internal/MRAIDLog$LOG_LEVEL", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LOG_LEVEL); }
			}

			internal LOG_LEVEL (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public unsafe int Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDLog.LOG_LEVEL']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()I", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
					try {
						return JNIEnv.CallIntMethod  (Handle, id_getValue);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDLog.LOG_LEVEL']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/nexage/sourcekit/mraid/internal/MRAIDLog$LOG_LEVEL;", "")]
			public static unsafe global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDLog.LOG_LEVEL ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/nexage/sourcekit/mraid/internal/MRAIDLog$LOG_LEVEL;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDLog.LOG_LEVEL __ret = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDLog.LOG_LEVEL> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDLog.LOG_LEVEL']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/nexage/sourcekit/mraid/internal/MRAIDLog$LOG_LEVEL;", "")]
			public static unsafe global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDLog.LOG_LEVEL[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/nexage/sourcekit/mraid/internal/MRAIDLog$LOG_LEVEL;");
				try {
					return (global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDLog.LOG_LEVEL[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDLog.LOG_LEVEL));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/mraid/internal/MRAIDLog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MRAIDLog); }
		}

		protected MRAIDLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDLog']/constructor[@name='MRAIDLog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MRAIDLog ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MRAIDLog)) {
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

		static IntPtr id_getLoggingLevel;
		static IntPtr id_setLoggingLevel_Lorg_nexage_sourcekit_mraid_internal_MRAIDLog_LOG_LEVEL_;
		public static unsafe global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDLog.LOG_LEVEL LoggingLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDLog']/method[@name='getLoggingLevel' and count(parameter)=0]"
			[Register ("getLoggingLevel", "()Lorg/nexage/sourcekit/mraid/internal/MRAIDLog$LOG_LEVEL;", "GetGetLoggingLevelHandler")]
			get {
				if (id_getLoggingLevel == IntPtr.Zero)
					id_getLoggingLevel = JNIEnv.GetStaticMethodID (class_ref, "getLoggingLevel", "()Lorg/nexage/sourcekit/mraid/internal/MRAIDLog$LOG_LEVEL;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.Internal.MRAIDLog.LOG_LEVEL> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLoggingLevel), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDLog']/method[@name='setLoggingLevel' and count(parameter)=1 and parameter[1][@type='org.nexage.sourcekit.mraid.internal.MRAIDLog.LOG_LEVEL']]"
			[Register ("setLoggingLevel", "(Lorg/nexage/sourcekit/mraid/internal/MRAIDLog$LOG_LEVEL;)V", "GetSetLoggingLevel_Lorg_nexage_sourcekit_mraid_internal_MRAIDLog_LOG_LEVEL_Handler")]
			set {
				if (id_setLoggingLevel_Lorg_nexage_sourcekit_mraid_internal_MRAIDLog_LOG_LEVEL_ == IntPtr.Zero)
					id_setLoggingLevel_Lorg_nexage_sourcekit_mraid_internal_MRAIDLog_LOG_LEVEL_ = JNIEnv.GetStaticMethodID (class_ref, "setLoggingLevel", "(Lorg/nexage/sourcekit/mraid/internal/MRAIDLog$LOG_LEVEL;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setLoggingLevel_Lorg_nexage_sourcekit_mraid_internal_MRAIDLog_LOG_LEVEL_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_d_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDLog']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;)V", "")]
		public static unsafe void D (string p0)
		{
			if (id_d_Ljava_lang_String_ == IntPtr.Zero)
				id_d_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_d_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDLog']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void D (string p0, string p1)
		{
			if (id_d_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_d_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_e_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDLog']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;)V", "")]
		public static unsafe void E (string p0)
		{
			if (id_e_Ljava_lang_String_ == IntPtr.Zero)
				id_e_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_e_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDLog']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void E (string p0, string p1)
		{
			if (id_e_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_e_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_i_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDLog']/method[@name='i' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("i", "(Ljava/lang/String;)V", "")]
		public static unsafe void I (string p0)
		{
			if (id_i_Ljava_lang_String_ == IntPtr.Zero)
				id_i_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_i_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_i_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDLog']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void I (string p0, string p1)
		{
			if (id_i_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_i_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_i_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_v_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDLog']/method[@name='v' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("v", "(Ljava/lang/String;)V", "")]
		public static unsafe void V (string p0)
		{
			if (id_v_Ljava_lang_String_ == IntPtr.Zero)
				id_v_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "v", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_v_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_v_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDLog']/method[@name='v' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void V (string p0, string p1)
		{
			if (id_v_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_v_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "v", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_v_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_w_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDLog']/method[@name='w' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("w", "(Ljava/lang/String;)V", "")]
		public static unsafe void W (string p0)
		{
			if (id_w_Ljava_lang_String_ == IntPtr.Zero)
				id_w_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "w", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_w_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_w_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.internal']/class[@name='MRAIDLog']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void W (string p0, string p1)
		{
			if (id_w_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_w_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "w", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_w_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
