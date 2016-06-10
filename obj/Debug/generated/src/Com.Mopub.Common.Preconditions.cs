using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions']"
	[global::Android.Runtime.Register ("com/mopub/common/Preconditions", DoNotGenerateAcw=true)]
	public sealed partial class Preconditions : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions']/field[@name='EMPTY_ARGUMENTS']"
		[Register ("EMPTY_ARGUMENTS")]
		public const string EmptyArguments = (string) "";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions.NoThrow']"
		[global::Android.Runtime.Register ("com/mopub/common/Preconditions$NoThrow", DoNotGenerateAcw=true)]
		public sealed partial class NoThrow : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/Preconditions$NoThrow", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NoThrow); }
			}

			internal NoThrow (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions.NoThrow']/constructor[@name='Preconditions.NoThrow' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe NoThrow ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (NoThrow)) {
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

			static IntPtr id_checkArgument_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions.NoThrow']/method[@name='checkArgument' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("checkArgument", "(Z)Z", "")]
			public static unsafe bool CheckArgument (bool p0)
			{
				if (id_checkArgument_Z == IntPtr.Zero)
					id_checkArgument_Z = JNIEnv.GetStaticMethodID (class_ref, "checkArgument", "(Z)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkArgument_Z, __args);
				} finally {
				}
			}

			static IntPtr id_checkArgument_ZLjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions.NoThrow']/method[@name='checkArgument' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
			[Register ("checkArgument", "(ZLjava/lang/String;)Z", "")]
			public static unsafe bool CheckArgument (bool p0, string p1)
			{
				if (id_checkArgument_ZLjava_lang_String_ == IntPtr.Zero)
					id_checkArgument_ZLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "checkArgument", "(ZLjava/lang/String;)Z");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkArgument_ZLjava_lang_String_, __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static IntPtr id_checkArgument_ZLjava_lang_String_arrayLjava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions.NoThrow']/method[@name='checkArgument' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
			[Register ("checkArgument", "(ZLjava/lang/String;[Ljava/lang/Object;)Z", "")]
			public static unsafe bool CheckArgument (bool p0, string p1, params global:: Java.Lang.Object[] p2)
			{
				if (id_checkArgument_ZLjava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_checkArgument_ZLjava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkArgument", "(ZLjava/lang/String;[Ljava/lang/Object;)Z");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkArgument_ZLjava_lang_String_arrayLjava_lang_Object_, __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
				}
			}

			static IntPtr id_checkNotNull_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions.NoThrow']/method[@name='checkNotNull' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("checkNotNull", "(Ljava/lang/Object;)Z", "")]
			public static unsafe bool CheckNotNull (global::Java.Lang.Object p0)
			{
				if (id_checkNotNull_Ljava_lang_Object_ == IntPtr.Zero)
					id_checkNotNull_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkNotNull", "(Ljava/lang/Object;)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkNotNull_Ljava_lang_Object_, __args);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_checkNotNull_Ljava_lang_Object_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions.NoThrow']/method[@name='checkNotNull' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
			[Register ("checkNotNull", "(Ljava/lang/Object;Ljava/lang/String;)Z", "")]
			public static unsafe bool CheckNotNull (global::Java.Lang.Object p0, string p1)
			{
				if (id_checkNotNull_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
					id_checkNotNull_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "checkNotNull", "(Ljava/lang/Object;Ljava/lang/String;)Z");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkNotNull_Ljava_lang_Object_Ljava_lang_String_, __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static IntPtr id_checkNotNull_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions.NoThrow']/method[@name='checkNotNull' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
			[Register ("checkNotNull", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)Z", "")]
			public static unsafe bool CheckNotNull (global::Java.Lang.Object p0, string p1, params global:: Java.Lang.Object[] p2)
			{
				if (id_checkNotNull_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_checkNotNull_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkNotNull", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)Z");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkNotNull_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_, __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
				}
			}

			static IntPtr id_checkState_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions.NoThrow']/method[@name='checkState' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("checkState", "(Z)Z", "")]
			public static unsafe bool CheckState (bool p0)
			{
				if (id_checkState_Z == IntPtr.Zero)
					id_checkState_Z = JNIEnv.GetStaticMethodID (class_ref, "checkState", "(Z)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkState_Z, __args);
				} finally {
				}
			}

			static IntPtr id_checkState_ZLjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions.NoThrow']/method[@name='checkState' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
			[Register ("checkState", "(ZLjava/lang/String;)Z", "")]
			public static unsafe bool CheckState (bool p0, string p1)
			{
				if (id_checkState_ZLjava_lang_String_ == IntPtr.Zero)
					id_checkState_ZLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "checkState", "(ZLjava/lang/String;)Z");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkState_ZLjava_lang_String_, __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static IntPtr id_checkState_ZLjava_lang_String_arrayLjava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions.NoThrow']/method[@name='checkState' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
			[Register ("checkState", "(ZLjava/lang/String;[Ljava/lang/Object;)Z", "")]
			public static unsafe bool CheckState (bool p0, string p1, params global:: Java.Lang.Object[] p2)
			{
				if (id_checkState_ZLjava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_checkState_ZLjava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkState", "(ZLjava/lang/String;[Ljava/lang/Object;)Z");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkState_ZLjava_lang_String_arrayLjava_lang_Object_, __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
				}
			}

			static IntPtr id_checkUiThread;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions.NoThrow']/method[@name='checkUiThread' and count(parameter)=0]"
			[Register ("checkUiThread", "()Z", "")]
			public static unsafe bool CheckUiThread ()
			{
				if (id_checkUiThread == IntPtr.Zero)
					id_checkUiThread = JNIEnv.GetStaticMethodID (class_ref, "checkUiThread", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkUiThread);
				} finally {
				}
			}

			static IntPtr id_checkUiThread_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions.NoThrow']/method[@name='checkUiThread' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("checkUiThread", "(Ljava/lang/String;)Z", "")]
			public static unsafe bool CheckUiThread (string p0)
			{
				if (id_checkUiThread_Ljava_lang_String_ == IntPtr.Zero)
					id_checkUiThread_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "checkUiThread", "(Ljava/lang/String;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkUiThread_Ljava_lang_String_, __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_checkUiThread_Ljava_lang_String_arrayLjava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions.NoThrow']/method[@name='checkUiThread' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
			[Register ("checkUiThread", "(Ljava/lang/String;[Ljava/lang/Object;)Z", "")]
			public static unsafe bool CheckUiThread (string p0, params global:: Java.Lang.Object[] p1)
			{
				if (id_checkUiThread_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_checkUiThread_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkUiThread", "(Ljava/lang/String;[Ljava/lang/Object;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkUiThread_Ljava_lang_String_arrayLjava_lang_Object_, __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static IntPtr id_setStrictMode_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions.NoThrow']/method[@name='setStrictMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setStrictMode", "(Z)V", "")]
			public static unsafe void SetStrictMode (bool p0)
			{
				if (id_setStrictMode_Z == IntPtr.Zero)
					id_setStrictMode_Z = JNIEnv.GetStaticMethodID (class_ref, "setStrictMode", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setStrictMode_Z, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/Preconditions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Preconditions); }
		}

		internal Preconditions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_checkArgument_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions']/method[@name='checkArgument' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("checkArgument", "(Z)V", "")]
		public static unsafe void CheckArgument (bool p0)
		{
			if (id_checkArgument_Z == IntPtr.Zero)
				id_checkArgument_Z = JNIEnv.GetStaticMethodID (class_ref, "checkArgument", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkArgument_Z, __args);
			} finally {
			}
		}

		static IntPtr id_checkArgument_ZLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions']/method[@name='checkArgument' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
		[Register ("checkArgument", "(ZLjava/lang/String;)V", "")]
		public static unsafe void CheckArgument (bool p0, string p1)
		{
			if (id_checkArgument_ZLjava_lang_String_ == IntPtr.Zero)
				id_checkArgument_ZLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "checkArgument", "(ZLjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkArgument_ZLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_checkArgument_ZLjava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions']/method[@name='checkArgument' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("checkArgument", "(ZLjava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void CheckArgument (bool p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_checkArgument_ZLjava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_checkArgument_ZLjava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkArgument", "(ZLjava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkArgument_ZLjava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_checkNotNull_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions']/method[@name='checkNotNull' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("checkNotNull", "(Ljava/lang/Object;)V", "")]
		public static unsafe void CheckNotNull (global::Java.Lang.Object p0)
		{
			if (id_checkNotNull_Ljava_lang_Object_ == IntPtr.Zero)
				id_checkNotNull_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkNotNull", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkNotNull_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_checkNotNull_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions']/method[@name='checkNotNull' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("checkNotNull", "(Ljava/lang/Object;Ljava/lang/String;)V", "")]
		public static unsafe void CheckNotNull (global::Java.Lang.Object p0, string p1)
		{
			if (id_checkNotNull_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_checkNotNull_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "checkNotNull", "(Ljava/lang/Object;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkNotNull_Ljava_lang_Object_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_checkNotNull_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions']/method[@name='checkNotNull' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("checkNotNull", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void CheckNotNull (global::Java.Lang.Object p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_checkNotNull_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_checkNotNull_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkNotNull", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkNotNull_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_checkState_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions']/method[@name='checkState' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("checkState", "(Z)V", "")]
		public static unsafe void CheckState (bool p0)
		{
			if (id_checkState_Z == IntPtr.Zero)
				id_checkState_Z = JNIEnv.GetStaticMethodID (class_ref, "checkState", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkState_Z, __args);
			} finally {
			}
		}

		static IntPtr id_checkState_ZLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions']/method[@name='checkState' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
		[Register ("checkState", "(ZLjava/lang/String;)V", "")]
		public static unsafe void CheckState (bool p0, string p1)
		{
			if (id_checkState_ZLjava_lang_String_ == IntPtr.Zero)
				id_checkState_ZLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "checkState", "(ZLjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkState_ZLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_checkState_ZLjava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions']/method[@name='checkState' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("checkState", "(ZLjava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void CheckState (bool p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_checkState_ZLjava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_checkState_ZLjava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkState", "(ZLjava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkState_ZLjava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_checkUiThread;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions']/method[@name='checkUiThread' and count(parameter)=0]"
		[Register ("checkUiThread", "()V", "")]
		public static unsafe void CheckUiThread ()
		{
			if (id_checkUiThread == IntPtr.Zero)
				id_checkUiThread = JNIEnv.GetStaticMethodID (class_ref, "checkUiThread", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkUiThread);
			} finally {
			}
		}

		static IntPtr id_checkUiThread_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions']/method[@name='checkUiThread' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkUiThread", "(Ljava/lang/String;)V", "")]
		public static unsafe void CheckUiThread (string p0)
		{
			if (id_checkUiThread_Ljava_lang_String_ == IntPtr.Zero)
				id_checkUiThread_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "checkUiThread", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkUiThread_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_checkUiThread_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='Preconditions']/method[@name='checkUiThread' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("checkUiThread", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void CheckUiThread (string p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_checkUiThread_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_checkUiThread_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkUiThread", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkUiThread_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
