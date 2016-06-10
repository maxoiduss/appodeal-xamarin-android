using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Mraid.Properties {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDResizeProperties']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/mraid/properties/MRAIDResizeProperties", DoNotGenerateAcw=true)]
	public sealed partial class MRAIDResizeProperties : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDResizeProperties']/field[@name='CUSTOM_CLOSE_POSITION_BOTTOM_CENTER']"
		[Register ("CUSTOM_CLOSE_POSITION_BOTTOM_CENTER")]
		public const int CustomClosePositionBottomCenter = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDResizeProperties']/field[@name='CUSTOM_CLOSE_POSITION_BOTTOM_LEFT']"
		[Register ("CUSTOM_CLOSE_POSITION_BOTTOM_LEFT")]
		public const int CustomClosePositionBottomLeft = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDResizeProperties']/field[@name='CUSTOM_CLOSE_POSITION_BOTTOM_RIGHT']"
		[Register ("CUSTOM_CLOSE_POSITION_BOTTOM_RIGHT")]
		public const int CustomClosePositionBottomRight = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDResizeProperties']/field[@name='CUSTOM_CLOSE_POSITION_CENTER']"
		[Register ("CUSTOM_CLOSE_POSITION_CENTER")]
		public const int CustomClosePositionCenter = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDResizeProperties']/field[@name='CUSTOM_CLOSE_POSITION_TOP_CENTER']"
		[Register ("CUSTOM_CLOSE_POSITION_TOP_CENTER")]
		public const int CustomClosePositionTopCenter = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDResizeProperties']/field[@name='CUSTOM_CLOSE_POSITION_TOP_LEFT']"
		[Register ("CUSTOM_CLOSE_POSITION_TOP_LEFT")]
		public const int CustomClosePositionTopLeft = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDResizeProperties']/field[@name='CUSTOM_CLOSE_POSITION_TOP_RIGHT']"
		[Register ("CUSTOM_CLOSE_POSITION_TOP_RIGHT")]
		public const int CustomClosePositionTopRight = (int) 2;

		static IntPtr allowOffscreen_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDResizeProperties']/field[@name='allowOffscreen']"
		[Register ("allowOffscreen")]
		public bool AllowOffscreen {
			get {
				if (allowOffscreen_jfieldId == IntPtr.Zero)
					allowOffscreen_jfieldId = JNIEnv.GetFieldID (class_ref, "allowOffscreen", "Z");
				return JNIEnv.GetBooleanField (Handle, allowOffscreen_jfieldId);
			}
			set {
				if (allowOffscreen_jfieldId == IntPtr.Zero)
					allowOffscreen_jfieldId = JNIEnv.GetFieldID (class_ref, "allowOffscreen", "Z");
				try {
					JNIEnv.SetField (Handle, allowOffscreen_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr customClosePosition_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDResizeProperties']/field[@name='customClosePosition']"
		[Register ("customClosePosition")]
		public int CustomClosePosition {
			get {
				if (customClosePosition_jfieldId == IntPtr.Zero)
					customClosePosition_jfieldId = JNIEnv.GetFieldID (class_ref, "customClosePosition", "I");
				return JNIEnv.GetIntField (Handle, customClosePosition_jfieldId);
			}
			set {
				if (customClosePosition_jfieldId == IntPtr.Zero)
					customClosePosition_jfieldId = JNIEnv.GetFieldID (class_ref, "customClosePosition", "I");
				try {
					JNIEnv.SetField (Handle, customClosePosition_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr height_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDResizeProperties']/field[@name='height']"
		[Register ("height")]
		public int Height {
			get {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
				return JNIEnv.GetIntField (Handle, height_jfieldId);
			}
			set {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
				try {
					JNIEnv.SetField (Handle, height_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr offsetX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDResizeProperties']/field[@name='offsetX']"
		[Register ("offsetX")]
		public int OffsetX {
			get {
				if (offsetX_jfieldId == IntPtr.Zero)
					offsetX_jfieldId = JNIEnv.GetFieldID (class_ref, "offsetX", "I");
				return JNIEnv.GetIntField (Handle, offsetX_jfieldId);
			}
			set {
				if (offsetX_jfieldId == IntPtr.Zero)
					offsetX_jfieldId = JNIEnv.GetFieldID (class_ref, "offsetX", "I");
				try {
					JNIEnv.SetField (Handle, offsetX_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr offsetY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDResizeProperties']/field[@name='offsetY']"
		[Register ("offsetY")]
		public int OffsetY {
			get {
				if (offsetY_jfieldId == IntPtr.Zero)
					offsetY_jfieldId = JNIEnv.GetFieldID (class_ref, "offsetY", "I");
				return JNIEnv.GetIntField (Handle, offsetY_jfieldId);
			}
			set {
				if (offsetY_jfieldId == IntPtr.Zero)
					offsetY_jfieldId = JNIEnv.GetFieldID (class_ref, "offsetY", "I");
				try {
					JNIEnv.SetField (Handle, offsetY_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr width_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDResizeProperties']/field[@name='width']"
		[Register ("width")]
		public int Width {
			get {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
				return JNIEnv.GetIntField (Handle, width_jfieldId);
			}
			set {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
				try {
					JNIEnv.SetField (Handle, width_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/mraid/properties/MRAIDResizeProperties", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MRAIDResizeProperties); }
		}

		internal MRAIDResizeProperties (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDResizeProperties']/constructor[@name='MRAIDResizeProperties' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MRAIDResizeProperties ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MRAIDResizeProperties)) {
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

		static IntPtr id_ctor_IIIIIZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDResizeProperties']/constructor[@name='MRAIDResizeProperties' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='boolean']]"
		[Register (".ctor", "(IIIIIZ)V", "")]
		public unsafe MRAIDResizeProperties (int p0, int p1, int p2, int p3, int p4, bool p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				if (GetType () != typeof (MRAIDResizeProperties)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIIIIZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IIIIIZ)V", __args);
					return;
				}

				if (id_ctor_IIIIIZ == IntPtr.Zero)
					id_ctor_IIIIIZ = JNIEnv.GetMethodID (class_ref, "<init>", "(IIIIIZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIIIIZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIIIIZ, __args);
			} finally {
			}
		}

		static IntPtr id_customClosePositionFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid.properties']/class[@name='MRAIDResizeProperties']/method[@name='customClosePositionFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("customClosePositionFromString", "(Ljava/lang/String;)I", "")]
		public static unsafe int CustomClosePositionFromString (string p0)
		{
			if (id_customClosePositionFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_customClosePositionFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "customClosePositionFromString", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_customClosePositionFromString_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
