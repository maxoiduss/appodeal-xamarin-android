using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ManifestUtils']"
	[global::Android.Runtime.Register ("com/mopub/common/util/ManifestUtils", DoNotGenerateAcw=true)]
	public partial class ManifestUtils : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ManifestUtils.ActivityConfigChanges']"
		[global::Android.Runtime.Register ("com/mopub/common/util/ManifestUtils$ActivityConfigChanges", DoNotGenerateAcw=true)]
		public partial class ActivityConfigChanges : global::Java.Lang.Object {


			static IntPtr hasKeyboardHidden_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ManifestUtils.ActivityConfigChanges']/field[@name='hasKeyboardHidden']"
			[Register ("hasKeyboardHidden")]
			public bool HasKeyboardHidden {
				get {
					if (hasKeyboardHidden_jfieldId == IntPtr.Zero)
						hasKeyboardHidden_jfieldId = JNIEnv.GetFieldID (class_ref, "hasKeyboardHidden", "Z");
					return JNIEnv.GetBooleanField (Handle, hasKeyboardHidden_jfieldId);
				}
				set {
					if (hasKeyboardHidden_jfieldId == IntPtr.Zero)
						hasKeyboardHidden_jfieldId = JNIEnv.GetFieldID (class_ref, "hasKeyboardHidden", "Z");
					try {
						JNIEnv.SetField (Handle, hasKeyboardHidden_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr hasOrientation_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ManifestUtils.ActivityConfigChanges']/field[@name='hasOrientation']"
			[Register ("hasOrientation")]
			public bool HasOrientation {
				get {
					if (hasOrientation_jfieldId == IntPtr.Zero)
						hasOrientation_jfieldId = JNIEnv.GetFieldID (class_ref, "hasOrientation", "Z");
					return JNIEnv.GetBooleanField (Handle, hasOrientation_jfieldId);
				}
				set {
					if (hasOrientation_jfieldId == IntPtr.Zero)
						hasOrientation_jfieldId = JNIEnv.GetFieldID (class_ref, "hasOrientation", "Z");
					try {
						JNIEnv.SetField (Handle, hasOrientation_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr hasScreenSize_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ManifestUtils.ActivityConfigChanges']/field[@name='hasScreenSize']"
			[Register ("hasScreenSize")]
			public bool HasScreenSize {
				get {
					if (hasScreenSize_jfieldId == IntPtr.Zero)
						hasScreenSize_jfieldId = JNIEnv.GetFieldID (class_ref, "hasScreenSize", "Z");
					return JNIEnv.GetBooleanField (Handle, hasScreenSize_jfieldId);
				}
				set {
					if (hasScreenSize_jfieldId == IntPtr.Zero)
						hasScreenSize_jfieldId = JNIEnv.GetFieldID (class_ref, "hasScreenSize", "Z");
					try {
						JNIEnv.SetField (Handle, hasScreenSize_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/util/ManifestUtils$ActivityConfigChanges", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ActivityConfigChanges); }
			}

			protected ActivityConfigChanges (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ManifestUtils.FlagCheckUtil']"
		[global::Android.Runtime.Register ("com/mopub/common/util/ManifestUtils$FlagCheckUtil", DoNotGenerateAcw=true)]
		public partial class FlagCheckUtil : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/util/ManifestUtils$FlagCheckUtil", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FlagCheckUtil); }
			}

			protected FlagCheckUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_hasFlag_Ljava_lang_Class_II;
#pragma warning disable 0169
			static Delegate GetHasFlag_Ljava_lang_Class_IIHandler ()
			{
				if (cb_hasFlag_Ljava_lang_Class_II == null)
					cb_hasFlag_Ljava_lang_Class_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool>) n_HasFlag_Ljava_lang_Class_II);
				return cb_hasFlag_Ljava_lang_Class_II;
			}

			static bool n_HasFlag_Ljava_lang_Class_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				global::Com.Mopub.Common.Util.ManifestUtils.FlagCheckUtil __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.Util.ManifestUtils.FlagCheckUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.HasFlag (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_hasFlag_Ljava_lang_Class_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ManifestUtils.FlagCheckUtil']/method[@name='hasFlag' and count(parameter)=3 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("hasFlag", "(Ljava/lang/Class;II)Z", "GetHasFlag_Ljava_lang_Class_IIHandler")]
			public virtual unsafe bool HasFlag (global::Java.Lang.Class p0, int p1, int p2)
			{
				if (id_hasFlag_Ljava_lang_Class_II == IntPtr.Zero)
					id_hasFlag_Ljava_lang_Class_II = JNIEnv.GetMethodID (class_ref, "hasFlag", "(Ljava/lang/Class;II)Z");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					bool __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod  (Handle, id_hasFlag_Ljava_lang_Class_II, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasFlag", "(Ljava/lang/Class;II)Z"), __args);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/util/ManifestUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ManifestUtils); }
		}

		protected ManifestUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_checkNativeActivitiesDeclared_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ManifestUtils']/method[@name='checkNativeActivitiesDeclared' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkNativeActivitiesDeclared", "(Landroid/content/Context;)V", "")]
		public static unsafe void CheckNativeActivitiesDeclared (global::Android.Content.Context p0)
		{
			if (id_checkNativeActivitiesDeclared_Landroid_content_Context_ == IntPtr.Zero)
				id_checkNativeActivitiesDeclared_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkNativeActivitiesDeclared", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkNativeActivitiesDeclared_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_checkWebViewActivitiesDeclared_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ManifestUtils']/method[@name='checkWebViewActivitiesDeclared' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkWebViewActivitiesDeclared", "(Landroid/content/Context;)V", "")]
		public static unsafe void CheckWebViewActivitiesDeclared (global::Android.Content.Context p0)
		{
			if (id_checkWebViewActivitiesDeclared_Landroid_content_Context_ == IntPtr.Zero)
				id_checkWebViewActivitiesDeclared_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkWebViewActivitiesDeclared", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkWebViewActivitiesDeclared_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_isDebuggable_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='ManifestUtils']/method[@name='isDebuggable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isDebuggable", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsDebuggable (global::Android.Content.Context p0)
		{
			if (id_isDebuggable_Landroid_content_Context_ == IntPtr.Zero)
				id_isDebuggable_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isDebuggable", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isDebuggable_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
