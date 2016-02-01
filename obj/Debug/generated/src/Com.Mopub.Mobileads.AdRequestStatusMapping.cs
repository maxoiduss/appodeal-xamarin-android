using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdRequestStatusMapping']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/AdRequestStatusMapping", DoNotGenerateAcw=true)]
	public partial class AdRequestStatusMapping : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdRequestStatusMapping.AdRequestStatus']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/AdRequestStatusMapping$AdRequestStatus", DoNotGenerateAcw=true)]
		public partial class AdRequestStatus : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/AdRequestStatusMapping$AdRequestStatus", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AdRequestStatus); }
			}

			protected AdRequestStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_mopub_mobileads_AdRequestStatusMapping_LoadingStatus_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdRequestStatusMapping.AdRequestStatus']/constructor[@name='AdRequestStatusMapping.AdRequestStatus' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.AdRequestStatusMapping.LoadingStatus']]"
			[Register (".ctor", "(Lcom/mopub/mobileads/AdRequestStatusMapping$LoadingStatus;)V", "")]
			public unsafe AdRequestStatus (global::Com.Mopub.Mobileads.AdRequestStatusMapping.LoadingStatus p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (AdRequestStatus)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/mobileads/AdRequestStatusMapping$LoadingStatus;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/mobileads/AdRequestStatusMapping$LoadingStatus;)V", __args);
						return;
					}

					if (id_ctor_Lcom_mopub_mobileads_AdRequestStatusMapping_LoadingStatus_ == IntPtr.Zero)
						id_ctor_Lcom_mopub_mobileads_AdRequestStatusMapping_LoadingStatus_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/mobileads/AdRequestStatusMapping$LoadingStatus;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_mobileads_AdRequestStatusMapping_LoadingStatus_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_mobileads_AdRequestStatusMapping_LoadingStatus_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_Lcom_mopub_mobileads_AdRequestStatusMapping_LoadingStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdRequestStatusMapping.AdRequestStatus']/constructor[@name='AdRequestStatusMapping.AdRequestStatus' and count(parameter)=4 and parameter[1][@type='com.mopub.mobileads.AdRequestStatusMapping.LoadingStatus'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/mopub/mobileads/AdRequestStatusMapping$LoadingStatus;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe AdRequestStatus (global::Com.Mopub.Mobileads.AdRequestStatusMapping.LoadingStatus p0, string p1, string p2, string p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				IntPtr native_p3 = JNIEnv.NewString (p3);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (native_p3);
					if (GetType () != typeof (AdRequestStatus)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/mobileads/AdRequestStatusMapping$LoadingStatus;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/mobileads/AdRequestStatusMapping$LoadingStatus;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_mopub_mobileads_AdRequestStatusMapping_LoadingStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_mopub_mobileads_AdRequestStatusMapping_LoadingStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/mobileads/AdRequestStatusMapping$LoadingStatus;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_mobileads_AdRequestStatusMapping_LoadingStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_mobileads_AdRequestStatusMapping_LoadingStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdRequestStatusMapping.LoadingStatus']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/AdRequestStatusMapping$LoadingStatus", DoNotGenerateAcw=true)]
		public sealed partial class LoadingStatus : global::Java.Lang.Enum {


			static IntPtr LOADED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdRequestStatusMapping.LoadingStatus']/field[@name='LOADED']"
			[Register ("LOADED")]
			public static global::Com.Mopub.Mobileads.AdRequestStatusMapping.LoadingStatus Loaded {
				get {
					if (LOADED_jfieldId == IntPtr.Zero)
						LOADED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOADED", "Lcom/mopub/mobileads/AdRequestStatusMapping$LoadingStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOADED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdRequestStatusMapping.LoadingStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LOADING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdRequestStatusMapping.LoadingStatus']/field[@name='LOADING']"
			[Register ("LOADING")]
			public static global::Com.Mopub.Mobileads.AdRequestStatusMapping.LoadingStatus Loading {
				get {
					if (LOADING_jfieldId == IntPtr.Zero)
						LOADING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOADING", "Lcom/mopub/mobileads/AdRequestStatusMapping$LoadingStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOADING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdRequestStatusMapping.LoadingStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PLAYED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdRequestStatusMapping.LoadingStatus']/field[@name='PLAYED']"
			[Register ("PLAYED")]
			public static global::Com.Mopub.Mobileads.AdRequestStatusMapping.LoadingStatus Played {
				get {
					if (PLAYED_jfieldId == IntPtr.Zero)
						PLAYED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAYED", "Lcom/mopub/mobileads/AdRequestStatusMapping$LoadingStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAYED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.AdRequestStatusMapping.LoadingStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/AdRequestStatusMapping$LoadingStatus", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LoadingStatus); }
			}

			internal LoadingStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/AdRequestStatusMapping", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdRequestStatusMapping); }
		}

		protected AdRequestStatusMapping (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdRequestStatusMapping']/constructor[@name='AdRequestStatusMapping' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AdRequestStatusMapping ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AdRequestStatusMapping)) {
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
