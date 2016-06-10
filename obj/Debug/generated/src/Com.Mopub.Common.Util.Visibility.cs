using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Visibility']"
	[global::Android.Runtime.Register ("com/mopub/common/util/Visibility", DoNotGenerateAcw=true)]
	public partial class Visibility : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/util/Visibility", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Visibility); }
		}

		protected Visibility (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_hasScreenVisibilityChanged_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Visibility']/method[@name='hasScreenVisibilityChanged' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("hasScreenVisibilityChanged", "(II)Z", "")]
		public static unsafe bool HasScreenVisibilityChanged (int p0, int p1)
		{
			if (id_hasScreenVisibilityChanged_II == IntPtr.Zero)
				id_hasScreenVisibilityChanged_II = JNIEnv.GetStaticMethodID (class_ref, "hasScreenVisibilityChanged", "(II)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasScreenVisibilityChanged_II, __args);
			} finally {
			}
		}

		static IntPtr id_isScreenVisible_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='Visibility']/method[@name='isScreenVisible' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isScreenVisible", "(I)Z", "")]
		public static unsafe bool IsScreenVisible (int p0)
		{
			if (id_isScreenVisible_I == IntPtr.Zero)
				id_isScreenVisible_I = JNIEnv.GetStaticMethodID (class_ref, "isScreenVisible", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isScreenVisible_I, __args);
			} finally {
			}
		}

	}
}
