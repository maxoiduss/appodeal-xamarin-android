using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Mraid.Properties {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDOrientationProperties']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/mraid/properties/MRAIDOrientationProperties", DoNotGenerateAcw=true)]
	public sealed partial class MRAIDOrientationProperties : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDOrientationProperties']/field[@name='FORCE_ORIENTATION_LANDSCAPE']"
		[Register ("FORCE_ORIENTATION_LANDSCAPE")]
		public const int ForceOrientationLandscape = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDOrientationProperties']/field[@name='FORCE_ORIENTATION_NONE']"
		[Register ("FORCE_ORIENTATION_NONE")]
		public const int ForceOrientationNone = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDOrientationProperties']/field[@name='FORCE_ORIENTATION_PORTRAIT']"
		[Register ("FORCE_ORIENTATION_PORTRAIT")]
		public const int ForceOrientationPortrait = (int) 0;

		static IntPtr allowOrientationChange_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDOrientationProperties']/field[@name='allowOrientationChange']"
		[Register ("allowOrientationChange")]
		public bool AllowOrientationChange {
			get {
				if (allowOrientationChange_jfieldId == IntPtr.Zero)
					allowOrientationChange_jfieldId = JNIEnv.GetFieldID (class_ref, "allowOrientationChange", "Z");
				return JNIEnv.GetBooleanField (Handle, allowOrientationChange_jfieldId);
			}
			set {
				if (allowOrientationChange_jfieldId == IntPtr.Zero)
					allowOrientationChange_jfieldId = JNIEnv.GetFieldID (class_ref, "allowOrientationChange", "Z");
				try {
					JNIEnv.SetField (Handle, allowOrientationChange_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr forceOrientation_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDOrientationProperties']/field[@name='forceOrientation']"
		[Register ("forceOrientation")]
		public int ForceOrientation {
			get {
				if (forceOrientation_jfieldId == IntPtr.Zero)
					forceOrientation_jfieldId = JNIEnv.GetFieldID (class_ref, "forceOrientation", "I");
				return JNIEnv.GetIntField (Handle, forceOrientation_jfieldId);
			}
			set {
				if (forceOrientation_jfieldId == IntPtr.Zero)
					forceOrientation_jfieldId = JNIEnv.GetFieldID (class_ref, "forceOrientation", "I");
				try {
					JNIEnv.SetField (Handle, forceOrientation_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/mraid/properties/MRAIDOrientationProperties", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MRAIDOrientationProperties); }
		}

		internal MRAIDOrientationProperties (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDOrientationProperties']/constructor[@name='MRAIDOrientationProperties' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MRAIDOrientationProperties ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MRAIDOrientationProperties)) {
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

		static IntPtr id_ctor_ZI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDOrientationProperties']/constructor[@name='MRAIDOrientationProperties' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='int']]"
		[Register (".ctor", "(ZI)V", "")]
		public unsafe MRAIDOrientationProperties (bool p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (MRAIDOrientationProperties)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ZI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ZI)V", __args);
					return;
				}

				if (id_ctor_ZI == IntPtr.Zero)
					id_ctor_ZI = JNIEnv.GetMethodID (class_ref, "<init>", "(ZI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ZI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ZI, __args);
			} finally {
			}
		}

		static IntPtr id_forceOrientationFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDOrientationProperties']/method[@name='forceOrientationFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("forceOrientationFromString", "(Ljava/lang/String;)I", "")]
		public static unsafe int ForceOrientationFromString (string p0)
		{
			if (id_forceOrientationFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_forceOrientationFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "forceOrientationFromString", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_forceOrientationFromString_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_forceOrientationString;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDOrientationProperties']/method[@name='forceOrientationString' and count(parameter)=0]"
		[Register ("forceOrientationString", "()Ljava/lang/String;", "")]
		public unsafe string ForceOrientationString ()
		{
			if (id_forceOrientationString == IntPtr.Zero)
				id_forceOrientationString = JNIEnv.GetMethodID (class_ref, "forceOrientationString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_forceOrientationString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
