using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Reflection']"
	[global::Android.Runtime.Register ("com/mopub/common/util/Reflection", DoNotGenerateAcw=true)]
	public partial class Reflection : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Reflection.MethodBuilder']"
		[global::Android.Runtime.Register ("com/mopub/common/util/Reflection$MethodBuilder", DoNotGenerateAcw=true)]
		public partial class MethodBuilder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/util/Reflection$MethodBuilder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MethodBuilder); }
			}

			protected MethodBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_Object_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Reflection.MethodBuilder']/constructor[@name='Reflection.MethodBuilder' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/String;)V", "")]
			public unsafe MethodBuilder (global::Java.Lang.Object p0, string p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					if (GetType () != typeof (MethodBuilder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Object;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Object;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_addParam_Ljava_lang_Class_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetAddParam_Ljava_lang_Class_Ljava_lang_Object_Handler ()
			{
				if (cb_addParam_Ljava_lang_Class_Ljava_lang_Object_ == null)
					cb_addParam_Ljava_lang_Class_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddParam_Ljava_lang_Class_Ljava_lang_Object_);
				return cb_addParam_Ljava_lang_Class_Ljava_lang_Object_;
			}

			static IntPtr n_AddParam_Ljava_lang_Class_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mopub.Common.Util.Reflection.MethodBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.Reflection.MethodBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddParam (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_addParam_Ljava_lang_Class_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Reflection.MethodBuilder']/method[@name='addParam' and count(parameter)=2 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.Object']]"
			[Register ("addParam", "(Ljava/lang/Class;Ljava/lang/Object;)Lcom/mopub/common/util/Reflection$MethodBuilder;", "GetAddParam_Ljava_lang_Class_Ljava_lang_Object_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Util.Reflection.MethodBuilder AddParam (global::Java.Lang.Class p0, global::Java.Lang.Object p1)
			{
				if (id_addParam_Ljava_lang_Class_Ljava_lang_Object_ == IntPtr.Zero)
					id_addParam_Ljava_lang_Class_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "addParam", "(Ljava/lang/Class;Ljava/lang/Object;)Lcom/mopub/common/util/Reflection$MethodBuilder;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					global::Com.Mopub.Common.Util.Reflection.MethodBuilder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.Reflection.MethodBuilder> (JNIEnv.CallObjectMethod  (Handle, id_addParam_Ljava_lang_Class_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.Reflection.MethodBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addParam", "(Ljava/lang/Class;Ljava/lang/Object;)Lcom/mopub/common/util/Reflection$MethodBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_execute;
#pragma warning disable 0169
			static Delegate GetExecuteHandler ()
			{
				if (cb_execute == null)
					cb_execute = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Execute);
				return cb_execute;
			}

			static IntPtr n_Execute (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Common.Util.Reflection.MethodBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.Reflection.MethodBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Execute ());
			}
#pragma warning restore 0169

			static IntPtr id_execute;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Reflection.MethodBuilder']/method[@name='execute' and count(parameter)=0]"
			[Register ("execute", "()Ljava/lang/Object;", "GetExecuteHandler")]
			public virtual unsafe global::Java.Lang.Object Execute ()
			{
				if (id_execute == IntPtr.Zero)
					id_execute = JNIEnv.GetMethodID (class_ref, "execute", "()Ljava/lang/Object;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_execute), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAccessible;
#pragma warning disable 0169
			static Delegate GetSetAccessibleHandler ()
			{
				if (cb_setAccessible == null)
					cb_setAccessible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SetAccessible);
				return cb_setAccessible;
			}

			static IntPtr n_SetAccessible (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Common.Util.Reflection.MethodBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.Reflection.MethodBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetAccessible ());
			}
#pragma warning restore 0169

			static IntPtr id_setAccessible;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Reflection.MethodBuilder']/method[@name='setAccessible' and count(parameter)=0]"
			[Register ("setAccessible", "()Lcom/mopub/common/util/Reflection$MethodBuilder;", "GetSetAccessibleHandler")]
			public virtual unsafe global::Com.Mopub.Common.Util.Reflection.MethodBuilder SetAccessible ()
			{
				if (id_setAccessible == IntPtr.Zero)
					id_setAccessible = JNIEnv.GetMethodID (class_ref, "setAccessible", "()Lcom/mopub/common/util/Reflection$MethodBuilder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.Reflection.MethodBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setAccessible), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.Reflection.MethodBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAccessible", "()Lcom/mopub/common/util/Reflection$MethodBuilder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setStatic_Ljava_lang_Class_;
#pragma warning disable 0169
			static Delegate GetSetStatic_Ljava_lang_Class_Handler ()
			{
				if (cb_setStatic_Ljava_lang_Class_ == null)
					cb_setStatic_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetStatic_Ljava_lang_Class_);
				return cb_setStatic_Ljava_lang_Class_;
			}

			static IntPtr n_SetStatic_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.Util.Reflection.MethodBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.Reflection.MethodBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetStatic (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setStatic_Ljava_lang_Class_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Reflection.MethodBuilder']/method[@name='setStatic' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
			[Register ("setStatic", "(Ljava/lang/Class;)Lcom/mopub/common/util/Reflection$MethodBuilder;", "GetSetStatic_Ljava_lang_Class_Handler")]
			public virtual unsafe global::Com.Mopub.Common.Util.Reflection.MethodBuilder SetStatic (global::Java.Lang.Class p0)
			{
				if (id_setStatic_Ljava_lang_Class_ == IntPtr.Zero)
					id_setStatic_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "setStatic", "(Ljava/lang/Class;)Lcom/mopub/common/util/Reflection$MethodBuilder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mopub.Common.Util.Reflection.MethodBuilder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.Reflection.MethodBuilder> (JNIEnv.CallObjectMethod  (Handle, id_setStatic_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.Reflection.MethodBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatic", "(Ljava/lang/Class;)Lcom/mopub/common/util/Reflection$MethodBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/util/Reflection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Reflection); }
		}

		protected Reflection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Reflection']/constructor[@name='Reflection' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Reflection ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Reflection)) {
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

		static IntPtr id_classFound_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Reflection']/method[@name='classFound' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("classFound", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool ClassFound (string p0)
		{
			if (id_classFound_Ljava_lang_String_ == IntPtr.Zero)
				id_classFound_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "classFound", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_classFound_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getDeclaredMethodWithTraversal_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Reflection']/method[@name='getDeclaredMethodWithTraversal' and count(parameter)=3 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class...']]"
		[Register ("getDeclaredMethodWithTraversal", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", "")]
		public static unsafe global::Java.Lang.Reflect.Method GetDeclaredMethodWithTraversal (global::Java.Lang.Class p0, string p1, params global:: Java.Lang.Class[] p2)
		{
			if (id_getDeclaredMethodWithTraversal_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_ == IntPtr.Zero)
				id_getDeclaredMethodWithTraversal_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getDeclaredMethodWithTraversal", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::Java.Lang.Reflect.Method __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeclaredMethodWithTraversal_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_instantiateClassWithEmptyConstructor_Ljava_lang_String_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Reflection']/method[@name='instantiateClassWithEmptyConstructor' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class']]"
		[Register ("instantiateClassWithEmptyConstructor", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object InstantiateClassWithEmptyConstructor (string p0, global::Java.Lang.Class p1)
		{
			if (id_instantiateClassWithEmptyConstructor_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
				id_instantiateClassWithEmptyConstructor_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "instantiateClassWithEmptyConstructor", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_instantiateClassWithEmptyConstructor_Ljava_lang_String_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
