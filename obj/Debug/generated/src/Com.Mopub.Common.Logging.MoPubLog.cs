using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Logging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.logging']/class[@name='MoPubLog']"
	[global::Android.Runtime.Register ("com/mopub/common/logging/MoPubLog", DoNotGenerateAcw=true)]
	public partial class MoPubLog : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.logging']/class[@name='MoPubLog']/field[@name='LOGGER_NAMESPACE']"
		[Register ("LOGGER_NAMESPACE")]
		public const string LoggerNamespace = (string) "com.mopub";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.logging']/class[@name='MoPubLog.MoPubLogHandler']"
		[global::Android.Runtime.Register ("com/mopub/common/logging/MoPubLog$MoPubLogHandler", DoNotGenerateAcw=true)]
		public sealed partial class MoPubLogHandler : global::Java.Util.Logging.Handler {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/logging/MoPubLog$MoPubLogHandler", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MoPubLogHandler); }
			}

			internal MoPubLogHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_close;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.logging']/class[@name='MoPubLog.MoPubLogHandler']/method[@name='close' and count(parameter)=0]"
			[Register ("close", "()V", "")]
			public override unsafe void Close ()
			{
				if (id_close == IntPtr.Zero)
					id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
				try {
					JNIEnv.CallVoidMethod  (Handle, id_close);
				} finally {
				}
			}

			static IntPtr id_flush;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.logging']/class[@name='MoPubLog.MoPubLogHandler']/method[@name='flush' and count(parameter)=0]"
			[Register ("flush", "()V", "")]
			public override unsafe void Flush ()
			{
				if (id_flush == IntPtr.Zero)
					id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
				try {
					JNIEnv.CallVoidMethod  (Handle, id_flush);
				} finally {
				}
			}

			static IntPtr id_publish_Ljava_util_logging_LogRecord_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.logging']/class[@name='MoPubLog.MoPubLogHandler']/method[@name='publish' and count(parameter)=1 and parameter[1][@type='java.util.logging.LogRecord']]"
			[Register ("publish", "(Ljava/util/logging/LogRecord;)V", "")]
			public override unsafe void Publish (global::Java.Util.Logging.LogRecord p0)
			{
				if (id_publish_Ljava_util_logging_LogRecord_ == IntPtr.Zero)
					id_publish_Ljava_util_logging_LogRecord_ = JNIEnv.GetMethodID (class_ref, "publish", "(Ljava/util/logging/LogRecord;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					JNIEnv.CallVoidMethod  (Handle, id_publish_Ljava_util_logging_LogRecord_, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/logging/MoPubLog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoPubLog); }
		}

		protected MoPubLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_c_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.logging']/class[@name='MoPubLog']/method[@name='c' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("c", "(Ljava/lang/String;)V", "")]
		public static unsafe void C (string p0)
		{
			if (id_c_Ljava_lang_String_ == IntPtr.Zero)
				id_c_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_c_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_c_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.logging']/class[@name='MoPubLog']/method[@name='c' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("c", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void C (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_c_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_c_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_c_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_d_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.logging']/class[@name='MoPubLog']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_d_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.logging']/class[@name='MoPubLog']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void D (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_d_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_d_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_e_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.logging']/class[@name='MoPubLog']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_e_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.logging']/class[@name='MoPubLog']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void E (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_e_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_e_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_i_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.logging']/class[@name='MoPubLog']/method[@name='i' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_i_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.logging']/class[@name='MoPubLog']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void I (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_i_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_i_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_i_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setSdkHandlerLevel_Ljava_util_logging_Level_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.logging']/class[@name='MoPubLog']/method[@name='setSdkHandlerLevel' and count(parameter)=1 and parameter[1][@type='java.util.logging.Level']]"
		[Register ("setSdkHandlerLevel", "(Ljava/util/logging/Level;)V", "")]
		public static unsafe void SetSdkHandlerLevel (global::Java.Util.Logging.Level p0)
		{
			if (id_setSdkHandlerLevel_Ljava_util_logging_Level_ == IntPtr.Zero)
				id_setSdkHandlerLevel_Ljava_util_logging_Level_ = JNIEnv.GetStaticMethodID (class_ref, "setSdkHandlerLevel", "(Ljava/util/logging/Level;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setSdkHandlerLevel_Ljava_util_logging_Level_, __args);
			} finally {
			}
		}

		static IntPtr id_v_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.logging']/class[@name='MoPubLog']/method[@name='v' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_v_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.logging']/class[@name='MoPubLog']/method[@name='v' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void V (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_v_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_v_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "v", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_v_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_w_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.logging']/class[@name='MoPubLog']/method[@name='w' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_w_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.logging']/class[@name='MoPubLog']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void W (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_w_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_w_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "w", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_w_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
