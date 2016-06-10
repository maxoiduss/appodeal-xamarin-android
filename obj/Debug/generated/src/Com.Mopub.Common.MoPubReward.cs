using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPubReward']"
	[global::Android.Runtime.Register ("com/mopub/common/MoPubReward", DoNotGenerateAcw=true)]
	public sealed partial class MoPubReward : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPubReward']/field[@name='NO_REWARD_AMOUNT']"
		[Register ("NO_REWARD_AMOUNT")]
		public const int NoRewardAmount = (int) -123;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPubReward']/field[@name='NO_REWARD_LABEL']"
		[Register ("NO_REWARD_LABEL")]
		public const string NoRewardLabel = (string) "";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/MoPubReward", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoPubReward); }
		}

		internal MoPubReward (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAmount;
		public unsafe int Amount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPubReward']/method[@name='getAmount' and count(parameter)=0]"
			[Register ("getAmount", "()I", "GetGetAmountHandler")]
			get {
				if (id_getAmount == IntPtr.Zero)
					id_getAmount = JNIEnv.GetMethodID (class_ref, "getAmount", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getAmount);
				} finally {
				}
			}
		}

		static IntPtr id_isSuccessful;
		public unsafe bool IsSuccessful {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPubReward']/method[@name='isSuccessful' and count(parameter)=0]"
			[Register ("isSuccessful", "()Z", "GetIsSuccessfulHandler")]
			get {
				if (id_isSuccessful == IntPtr.Zero)
					id_isSuccessful = JNIEnv.GetMethodID (class_ref, "isSuccessful", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isSuccessful);
				} finally {
				}
			}
		}

		static IntPtr id_getLabel;
		public unsafe string Label {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPubReward']/method[@name='getLabel' and count(parameter)=0]"
			[Register ("getLabel", "()Ljava/lang/String;", "GetGetLabelHandler")]
			get {
				if (id_getLabel == IntPtr.Zero)
					id_getLabel = JNIEnv.GetMethodID (class_ref, "getLabel", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLabel), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_failure;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPubReward']/method[@name='failure' and count(parameter)=0]"
		[Register ("failure", "()Lcom/mopub/common/MoPubReward;", "")]
		public static unsafe global::Com.Mopub.Common.MoPubReward Failure ()
		{
			if (id_failure == IntPtr.Zero)
				id_failure = JNIEnv.GetStaticMethodID (class_ref, "failure", "()Lcom/mopub/common/MoPubReward;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.MoPubReward> (JNIEnv.CallStaticObjectMethod  (class_ref, id_failure), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_success_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPubReward']/method[@name='success' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("success", "(Ljava/lang/String;I)Lcom/mopub/common/MoPubReward;", "")]
		public static unsafe global::Com.Mopub.Common.MoPubReward Success (string p0, int p1)
		{
			if (id_success_Ljava_lang_String_I == IntPtr.Zero)
				id_success_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "success", "(Ljava/lang/String;I)Lcom/mopub/common/MoPubReward;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Mopub.Common.MoPubReward __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.MoPubReward> (JNIEnv.CallStaticObjectMethod  (class_ref, id_success_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
