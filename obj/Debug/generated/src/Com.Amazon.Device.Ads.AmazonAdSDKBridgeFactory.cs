using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Device.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AmazonAdSDKBridgeFactory']"
	[global::Android.Runtime.Register ("com/amazon/device/ads/AmazonAdSDKBridgeFactory", DoNotGenerateAcw=true)]
	public partial class AmazonAdSDKBridgeFactory : global::Java.Lang.Object, global::Com.Amazon.Device.Ads.IAdSDKBridgeFactory {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/device/ads/AmazonAdSDKBridgeFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmazonAdSDKBridgeFactory); }
		}

		protected AmazonAdSDKBridgeFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AmazonAdSDKBridgeFactory']/constructor[@name='AmazonAdSDKBridgeFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AmazonAdSDKBridgeFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AmazonAdSDKBridgeFactory)) {
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
