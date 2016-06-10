using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdAlertGestureListener']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/AdAlertGestureListener", DoNotGenerateAcw=true)]
	public partial class AdAlertGestureListener : global::Android.Views.GestureDetector.SimpleOnGestureListener {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdAlertGestureListener.ZigZagState']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/AdAlertGestureListener$ZigZagState", DoNotGenerateAcw=true)]
		public sealed partial class ZigZagState : global::Java.Lang.Enum {


			static IntPtr FAILED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdAlertGestureListener.ZigZagState']/field[@name='FAILED']"
			[Register ("FAILED")]
			public static global::Com.Mopub.Mobileads.AdAlertGestureListener.ZigZagState Failed {
				get {
					if (FAILED_jfieldId == IntPtr.Zero)
						FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAILED", "Lcom/mopub/mobileads/AdAlertGestureListener$ZigZagState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAILED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdAlertGestureListener.ZigZagState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FINISHED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdAlertGestureListener.ZigZagState']/field[@name='FINISHED']"
			[Register ("FINISHED")]
			public static global::Com.Mopub.Mobileads.AdAlertGestureListener.ZigZagState Finished {
				get {
					if (FINISHED_jfieldId == IntPtr.Zero)
						FINISHED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FINISHED", "Lcom/mopub/mobileads/AdAlertGestureListener$ZigZagState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FINISHED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdAlertGestureListener.ZigZagState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr GOING_LEFT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdAlertGestureListener.ZigZagState']/field[@name='GOING_LEFT']"
			[Register ("GOING_LEFT")]
			public static global::Com.Mopub.Mobileads.AdAlertGestureListener.ZigZagState GoingLeft {
				get {
					if (GOING_LEFT_jfieldId == IntPtr.Zero)
						GOING_LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GOING_LEFT", "Lcom/mopub/mobileads/AdAlertGestureListener$ZigZagState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GOING_LEFT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdAlertGestureListener.ZigZagState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr GOING_RIGHT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdAlertGestureListener.ZigZagState']/field[@name='GOING_RIGHT']"
			[Register ("GOING_RIGHT")]
			public static global::Com.Mopub.Mobileads.AdAlertGestureListener.ZigZagState GoingRight {
				get {
					if (GOING_RIGHT_jfieldId == IntPtr.Zero)
						GOING_RIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GOING_RIGHT", "Lcom/mopub/mobileads/AdAlertGestureListener$ZigZagState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GOING_RIGHT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdAlertGestureListener.ZigZagState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNSET_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdAlertGestureListener.ZigZagState']/field[@name='UNSET']"
			[Register ("UNSET")]
			public static global::Com.Mopub.Mobileads.AdAlertGestureListener.ZigZagState Unset {
				get {
					if (UNSET_jfieldId == IntPtr.Zero)
						UNSET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSET", "Lcom/mopub/mobileads/AdAlertGestureListener$ZigZagState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNSET_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdAlertGestureListener.ZigZagState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/AdAlertGestureListener$ZigZagState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ZigZagState); }
			}

			internal ZigZagState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		protected AdAlertGestureListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
