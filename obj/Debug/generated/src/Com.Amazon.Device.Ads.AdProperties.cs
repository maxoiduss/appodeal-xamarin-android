using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Device.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdProperties']"
	[global::Android.Runtime.Register ("com/amazon/device/ads/AdProperties", DoNotGenerateAcw=true)]
	public partial class AdProperties : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdProperties']/field[@name='CAN_EXPAND1']"
		[Register ("CAN_EXPAND1")]
		public const int CanExpand1 = (int) 1003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdProperties']/field[@name='CAN_EXPAND2']"
		[Register ("CAN_EXPAND2")]
		public const int CanExpand2 = (int) 1004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdProperties']/field[@name='CAN_PLAY_AUDIO1']"
		[Register ("CAN_PLAY_AUDIO1")]
		public const int CanPlayAudio1 = (int) 1001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdProperties']/field[@name='CAN_PLAY_AUDIO2']"
		[Register ("CAN_PLAY_AUDIO2")]
		public const int CanPlayAudio2 = (int) 1002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdProperties']/field[@name='HTML']"
		[Register ("HTML")]
		public const int Html = (int) 1007;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdProperties']/field[@name='INTERSTITIAL']"
		[Register ("INTERSTITIAL")]
		public const int Interstitial = (int) 1008;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdProperties']/field[@name='MRAID1']"
		[Register ("MRAID1")]
		public const int Mraid1 = (int) 1016;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdProperties']/field[@name='MRAID2']"
		[Register ("MRAID2")]
		public const int Mraid2 = (int) 1017;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdProperties']/field[@name='REQUIRES_TRANSPARENCY']"
		[Register ("REQUIRES_TRANSPARENCY")]
		public const int RequiresTransparency = (int) 1031;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdProperties']/field[@name='VIDEO_INTERSTITIAL']"
		[Register ("VIDEO_INTERSTITIAL")]
		public const int VideoInterstitial = (int) 1030;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdProperties.AdType']"
		[global::Android.Runtime.Register ("com/amazon/device/ads/AdProperties$AdType", DoNotGenerateAcw=true)]
		public sealed partial class AdType : global::Java.Lang.Enum {


			static IntPtr IMAGE_BANNER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdProperties.AdType']/field[@name='IMAGE_BANNER']"
			[Register ("IMAGE_BANNER")]
			public static global::Com.Amazon.Device.Ads.AdProperties.AdType ImageBanner {
				get {
					if (IMAGE_BANNER_jfieldId == IntPtr.Zero)
						IMAGE_BANNER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IMAGE_BANNER", "Lcom/amazon/device/ads/AdProperties$AdType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IMAGE_BANNER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdProperties.AdType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INTERSTITIAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdProperties.AdType']/field[@name='INTERSTITIAL']"
			[Register ("INTERSTITIAL")]
			public static global::Com.Amazon.Device.Ads.AdProperties.AdType Interstitial {
				get {
					if (INTERSTITIAL_jfieldId == IntPtr.Zero)
						INTERSTITIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERSTITIAL", "Lcom/amazon/device/ads/AdProperties$AdType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERSTITIAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdProperties.AdType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MODELESS_INTERSTITIAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdProperties.AdType']/field[@name='MODELESS_INTERSTITIAL']"
			[Register ("MODELESS_INTERSTITIAL")]
			public static global::Com.Amazon.Device.Ads.AdProperties.AdType ModelessInterstitial {
				get {
					if (MODELESS_INTERSTITIAL_jfieldId == IntPtr.Zero)
						MODELESS_INTERSTITIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MODELESS_INTERSTITIAL", "Lcom/amazon/device/ads/AdProperties$AdType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MODELESS_INTERSTITIAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdProperties.AdType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MRAID_1_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdProperties.AdType']/field[@name='MRAID_1']"
			[Register ("MRAID_1")]
			public static global::Com.Amazon.Device.Ads.AdProperties.AdType Mraid1 {
				get {
					if (MRAID_1_jfieldId == IntPtr.Zero)
						MRAID_1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MRAID_1", "Lcom/amazon/device/ads/AdProperties$AdType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MRAID_1_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdProperties.AdType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MRAID_2_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdProperties.AdType']/field[@name='MRAID_2']"
			[Register ("MRAID_2")]
			public static global::Com.Amazon.Device.Ads.AdProperties.AdType Mraid2 {
				get {
					if (MRAID_2_jfieldId == IntPtr.Zero)
						MRAID_2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MRAID_2", "Lcom/amazon/device/ads/AdProperties$AdType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MRAID_2_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdProperties.AdType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/device/ads/AdProperties$AdType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AdType); }
			}

			internal AdType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdProperties.AdType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amazon/device/ads/AdProperties$AdType;", "")]
			public static unsafe global::Com.Amazon.Device.Ads.AdProperties.AdType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/amazon/device/ads/AdProperties$AdType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Amazon.Device.Ads.AdProperties.AdType __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdProperties.AdType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdProperties.AdType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amazon/device/ads/AdProperties$AdType;", "")]
			public static unsafe global::Com.Amazon.Device.Ads.AdProperties.AdType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/amazon/device/ads/AdProperties$AdType;");
				try {
					return (global::Com.Amazon.Device.Ads.AdProperties.AdType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amazon.Device.Ads.AdProperties.AdType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/device/ads/AdProperties", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdProperties); }
		}

		protected AdProperties (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_canExpand;
#pragma warning disable 0169
		static Delegate GetCanExpandHandler ()
		{
			if (cb_canExpand == null)
				cb_canExpand = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanExpand);
			return cb_canExpand;
		}

		static bool n_CanExpand (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.AdProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanExpand ();
		}
#pragma warning restore 0169

		static IntPtr id_canExpand;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdProperties']/method[@name='canExpand' and count(parameter)=0]"
		[Register ("canExpand", "()Z", "GetCanExpandHandler")]
		public virtual unsafe bool CanExpand ()
		{
			if (id_canExpand == IntPtr.Zero)
				id_canExpand = JNIEnv.GetMethodID (class_ref, "canExpand", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_canExpand);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canExpand", "()Z"));
			} finally {
			}
		}

		static Delegate cb_canPlayAudio;
#pragma warning disable 0169
		static Delegate GetCanPlayAudioHandler ()
		{
			if (cb_canPlayAudio == null)
				cb_canPlayAudio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanPlayAudio);
			return cb_canPlayAudio;
		}

		static bool n_CanPlayAudio (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.AdProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanPlayAudio ();
		}
#pragma warning restore 0169

		static IntPtr id_canPlayAudio;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdProperties']/method[@name='canPlayAudio' and count(parameter)=0]"
		[Register ("canPlayAudio", "()Z", "GetCanPlayAudioHandler")]
		public virtual unsafe bool CanPlayAudio ()
		{
			if (id_canPlayAudio == IntPtr.Zero)
				id_canPlayAudio = JNIEnv.GetMethodID (class_ref, "canPlayAudio", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_canPlayAudio);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canPlayAudio", "()Z"));
			} finally {
			}
		}

		static Delegate cb_canPlayVideo;
#pragma warning disable 0169
		static Delegate GetCanPlayVideoHandler ()
		{
			if (cb_canPlayVideo == null)
				cb_canPlayVideo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanPlayVideo);
			return cb_canPlayVideo;
		}

		static bool n_CanPlayVideo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.AdProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanPlayVideo ();
		}
#pragma warning restore 0169

		static IntPtr id_canPlayVideo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdProperties']/method[@name='canPlayVideo' and count(parameter)=0]"
		[Register ("canPlayVideo", "()Z", "GetCanPlayVideoHandler")]
		public virtual unsafe bool CanPlayVideo ()
		{
			if (id_canPlayVideo == IntPtr.Zero)
				id_canPlayVideo = JNIEnv.GetMethodID (class_ref, "canPlayVideo", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_canPlayVideo);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canPlayVideo", "()Z"));
			} finally {
			}
		}

		static Delegate cb_getAdType;
#pragma warning disable 0169
		static Delegate GetGetAdTypeHandler ()
		{
			if (cb_getAdType == null)
				cb_getAdType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdType);
			return cb_getAdType;
		}

		static IntPtr n_GetAdType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.AdProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetAdType ());
		}
#pragma warning restore 0169

		static IntPtr id_getAdType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdProperties']/method[@name='getAdType' and count(parameter)=0]"
		[Register ("getAdType", "()Lcom/amazon/device/ads/AdProperties$AdType;", "GetGetAdTypeHandler")]
		public virtual unsafe global::Com.Amazon.Device.Ads.AdProperties.AdType GetAdType ()
		{
			if (id_getAdType == IntPtr.Zero)
				id_getAdType = JNIEnv.GetMethodID (class_ref, "getAdType", "()Lcom/amazon/device/ads/AdProperties$AdType;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdProperties.AdType> (JNIEnv.CallObjectMethod  (Handle, id_getAdType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdProperties.AdType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdType", "()Lcom/amazon/device/ads/AdProperties$AdType;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
