using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.util']/class[@name='MoPubCollections']"
	[global::Android.Runtime.Register ("com/mopub/common/util/MoPubCollections", DoNotGenerateAcw=true)]
	public partial class MoPubCollections : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/util/MoPubCollections", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoPubCollections); }
		}

		protected MoPubCollections (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common.util']/class[@name='MoPubCollections']/constructor[@name='MoPubCollections' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MoPubCollections ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MoPubCollections)) {
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

		static IntPtr id_addAllNonNull_Ljava_util_Collection_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.util']/class[@name='MoPubCollections']/method[@name='addAllNonNull' and count(parameter)=2 and parameter[1][@type='java.util.Collection'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("addAllNonNull", "(Ljava/util/Collection;[Ljava/lang/Object;)V", "")]
		public static unsafe void AddAllNonNull (global::System.Collections.ICollection p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_addAllNonNull_Ljava_util_Collection_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_addAllNonNull_Ljava_util_Collection_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "addAllNonNull", "(Ljava/util/Collection;[Ljava/lang/Object;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addAllNonNull_Ljava_util_Collection_arrayLjava_lang_Object_, __args);
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
