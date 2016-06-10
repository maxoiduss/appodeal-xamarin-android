using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Mraid {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDNativeFeature']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/mraid/MRAIDNativeFeature", DoNotGenerateAcw=true)]
	public sealed partial class MRAIDNativeFeature : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDNativeFeature']/field[@name='CALENDAR']"
		[Register ("CALENDAR")]
		public const string Calendar = (string) "calendar";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDNativeFeature']/field[@name='INLINE_VIDEO']"
		[Register ("INLINE_VIDEO")]
		public const string InlineVideo = (string) "inlineVideo";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDNativeFeature']/field[@name='SMS']"
		[Register ("SMS")]
		public const string Sms = (string) "sms";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDNativeFeature']/field[@name='STORE_PICTURE']"
		[Register ("STORE_PICTURE")]
		public const string StorePicture = (string) "storePicture";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDNativeFeature']/field[@name='TEL']"
		[Register ("TEL")]
		public const string Tel = (string) "tel";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/mraid/MRAIDNativeFeature", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MRAIDNativeFeature); }
		}

		internal MRAIDNativeFeature (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDNativeFeature']/constructor[@name='MRAIDNativeFeature' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MRAIDNativeFeature ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MRAIDNativeFeature)) {
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

	}
}
