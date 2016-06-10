using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyLog']"
	[global::Android.Runtime.Register ("com/mopub/volley/VolleyLog", DoNotGenerateAcw=true)]
	public partial class VolleyLog : global::Java.Lang.Object {


		static IntPtr DEBUG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyLog']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public static bool Debug {
			get {
				if (DEBUG_jfieldId == IntPtr.Zero)
					DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, DEBUG_jfieldId);
			}
			set {
				if (DEBUG_jfieldId == IntPtr.Zero)
					DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, DEBUG_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyLog']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, TAG_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyLog.MarkerLog']"
		[global::Android.Runtime.Register ("com/mopub/volley/VolleyLog$MarkerLog", DoNotGenerateAcw=true)]
		public partial class MarkerLog : global::Java.Lang.Object {


			static IntPtr ENABLED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyLog.MarkerLog']/field[@name='ENABLED']"
			[Register ("ENABLED")]
			public static bool Enabled {
				get {
					if (ENABLED_jfieldId == IntPtr.Zero)
						ENABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENABLED", "Z");
					return JNIEnv.GetStaticBooleanField (class_ref, ENABLED_jfieldId);
				}
			}
			// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyLog.MarkerLog.Marker']"
			[global::Android.Runtime.Register ("com/mopub/volley/VolleyLog$MarkerLog$Marker", DoNotGenerateAcw=true)]
			public partial class Marker : global::Java.Lang.Object {


				static IntPtr name_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyLog.MarkerLog.Marker']/field[@name='name']"
				[Register ("name")]
				public string Name {
					get {
						if (name_jfieldId == IntPtr.Zero)
							name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
						IntPtr __ret = JNIEnv.GetObjectField (Handle, name_jfieldId);
						return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (name_jfieldId == IntPtr.Zero)
							name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
						IntPtr native_value = JNIEnv.NewString (value);
						try {
							JNIEnv.SetField (Handle, name_jfieldId, native_value);
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}

				static IntPtr thread_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyLog.MarkerLog.Marker']/field[@name='thread']"
				[Register ("thread")]
				public long Thread {
					get {
						if (thread_jfieldId == IntPtr.Zero)
							thread_jfieldId = JNIEnv.GetFieldID (class_ref, "thread", "J");
						return JNIEnv.GetLongField (Handle, thread_jfieldId);
					}
					set {
						if (thread_jfieldId == IntPtr.Zero)
							thread_jfieldId = JNIEnv.GetFieldID (class_ref, "thread", "J");
						try {
							JNIEnv.SetField (Handle, thread_jfieldId, value);
						} finally {
						}
					}
				}

				static IntPtr time_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyLog.MarkerLog.Marker']/field[@name='time']"
				[Register ("time")]
				public long Time {
					get {
						if (time_jfieldId == IntPtr.Zero)
							time_jfieldId = JNIEnv.GetFieldID (class_ref, "time", "J");
						return JNIEnv.GetLongField (Handle, time_jfieldId);
					}
					set {
						if (time_jfieldId == IntPtr.Zero)
							time_jfieldId = JNIEnv.GetFieldID (class_ref, "time", "J");
						try {
							JNIEnv.SetField (Handle, time_jfieldId, value);
						} finally {
						}
					}
				}
				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/mopub/volley/VolleyLog$MarkerLog$Marker", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (Marker); }
				}

				protected Marker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_ctor_Ljava_lang_String_JJ;
				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyLog.MarkerLog.Marker']/constructor[@name='VolleyLog.MarkerLog.Marker' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
				[Register (".ctor", "(Ljava/lang/String;JJ)V", "")]
				public unsafe Marker (string p0, long p1, long p2)
					: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					if (Handle != IntPtr.Zero)
						return;

					IntPtr native_p0 = JNIEnv.NewString (p0);
					try {
						JValue* __args = stackalloc JValue [3];
						__args [0] = new JValue (native_p0);
						__args [1] = new JValue (p1);
						__args [2] = new JValue (p2);
						if (GetType () != typeof (Marker)) {
							SetHandle (
									global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;JJ)V", __args),
									JniHandleOwnership.TransferLocalRef);
							global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;JJ)V", __args);
							return;
						}

						if (id_ctor_Ljava_lang_String_JJ == IntPtr.Zero)
							id_ctor_Ljava_lang_String_JJ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;JJ)V");
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_JJ, __args),
								JniHandleOwnership.TransferLocalRef);
						JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_JJ, __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/volley/VolleyLog$MarkerLog", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MarkerLog); }
			}

			protected MarkerLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_add_Ljava_lang_String_J;
#pragma warning disable 0169
			static Delegate GetAdd_Ljava_lang_String_JHandler ()
			{
				if (cb_add_Ljava_lang_String_J == null)
					cb_add_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_Add_Ljava_lang_String_J);
				return cb_add_Ljava_lang_String_J;
			}

			static void n_Add_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
			{
				global::Com.Mopub.Volley.VolleyLog.MarkerLog __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.VolleyLog.MarkerLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Add (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_add_Ljava_lang_String_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyLog.MarkerLog']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
			[Register ("add", "(Ljava/lang/String;J)V", "GetAdd_Ljava_lang_String_JHandler")]
			public virtual unsafe void Add (string p0, long p1)
			{
				if (id_add_Ljava_lang_String_J == IntPtr.Zero)
					id_add_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;J)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_add_Ljava_lang_String_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/lang/String;J)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_finish_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetFinish_Ljava_lang_String_Handler ()
			{
				if (cb_finish_Ljava_lang_String_ == null)
					cb_finish_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Finish_Ljava_lang_String_);
				return cb_finish_Ljava_lang_String_;
			}

			static void n_Finish_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Volley.VolleyLog.MarkerLog __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.VolleyLog.MarkerLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Finish (p0);
			}
#pragma warning restore 0169

			static IntPtr id_finish_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyLog.MarkerLog']/method[@name='finish' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("finish", "(Ljava/lang/String;)V", "GetFinish_Ljava_lang_String_Handler")]
			public virtual unsafe void Finish (string p0)
			{
				if (id_finish_Ljava_lang_String_ == IntPtr.Zero)
					id_finish_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "finish", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_finish_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finish", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/VolleyLog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VolleyLog); }
		}

		protected VolleyLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyLog']/constructor[@name='VolleyLog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VolleyLog ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VolleyLog)) {
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

		static IntPtr id_d_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyLog']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("d", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void D (string p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_d_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_d_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_e_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyLog']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void E (string p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_e_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_e_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyLog']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void E (global::Java.Lang.Throwable p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_setTag_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyLog']/method[@name='setTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTag", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetTag (string p0)
		{
			if (id_setTag_Ljava_lang_String_ == IntPtr.Zero)
				id_setTag_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setTag", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setTag_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_v_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyLog']/method[@name='v' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("v", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void V (string p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_v_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_v_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "v", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_v_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_wtf_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyLog']/method[@name='wtf' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("wtf", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Wtf (string p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_wtf_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_wtf_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "wtf", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_wtf_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_wtf_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='VolleyLog']/method[@name='wtf' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("wtf", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Wtf (global::Java.Lang.Throwable p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_wtf_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_wtf_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "wtf", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_wtf_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

	}
}
