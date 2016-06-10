using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Device.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdTargetingOptions']"
	[global::Android.Runtime.Register ("com/amazon/device/ads/AdTargetingOptions", DoNotGenerateAcw=true)]
	public partial class AdTargetingOptions : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/device/ads/AdTargetingOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdTargetingOptions); }
		}

		protected AdTargetingOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdTargetingOptions']/constructor[@name='AdTargetingOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AdTargetingOptions ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AdTargetingOptions)) {
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

		static Delegate cb_getAge;
#pragma warning disable 0169
		static Delegate GetGetAgeHandler ()
		{
			if (cb_getAge == null)
				cb_getAge = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAge);
			return cb_getAge;
		}

		static int n_GetAge (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.AdTargetingOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdTargetingOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Age;
		}
#pragma warning restore 0169

		static IntPtr id_getAge;
		public virtual unsafe int Age {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdTargetingOptions']/method[@name='getAge' and count(parameter)=0]"
			[Register ("getAge", "()I", "GetGetAgeHandler")]
			get {
				if (id_getAge == IntPtr.Zero)
					id_getAge = JNIEnv.GetMethodID (class_ref, "getAge", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getAge);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAge", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getFloorPrice;
#pragma warning disable 0169
		static Delegate GetGetFloorPriceHandler ()
		{
			if (cb_getFloorPrice == null)
				cb_getFloorPrice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetFloorPrice);
			return cb_getFloorPrice;
		}

		static long n_GetFloorPrice (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.AdTargetingOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdTargetingOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FloorPrice;
		}
#pragma warning restore 0169

		static IntPtr id_getFloorPrice;
		public virtual unsafe long FloorPrice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdTargetingOptions']/method[@name='getFloorPrice' and count(parameter)=0]"
			[Register ("getFloorPrice", "()J", "GetGetFloorPriceHandler")]
			get {
				if (id_getFloorPrice == IntPtr.Zero)
					id_getFloorPrice = JNIEnv.GetMethodID (class_ref, "getFloorPrice", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getFloorPrice);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFloorPrice", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_isGeoLocationEnabled;
#pragma warning disable 0169
		static Delegate GetIsGeoLocationEnabledHandler ()
		{
			if (cb_isGeoLocationEnabled == null)
				cb_isGeoLocationEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsGeoLocationEnabled);
			return cb_isGeoLocationEnabled;
		}

		static bool n_IsGeoLocationEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.AdTargetingOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdTargetingOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsGeoLocationEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isGeoLocationEnabled;
		public virtual unsafe bool IsGeoLocationEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdTargetingOptions']/method[@name='isGeoLocationEnabled' and count(parameter)=0]"
			[Register ("isGeoLocationEnabled", "()Z", "GetIsGeoLocationEnabledHandler")]
			get {
				if (id_isGeoLocationEnabled == IntPtr.Zero)
					id_isGeoLocationEnabled = JNIEnv.GetMethodID (class_ref, "isGeoLocationEnabled", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isGeoLocationEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isGeoLocationEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_containsAdvancedOption_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetContainsAdvancedOption_Ljava_lang_String_Handler ()
		{
			if (cb_containsAdvancedOption_Ljava_lang_String_ == null)
				cb_containsAdvancedOption_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ContainsAdvancedOption_Ljava_lang_String_);
			return cb_containsAdvancedOption_Ljava_lang_String_;
		}

		static bool n_ContainsAdvancedOption_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Device.Ads.AdTargetingOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdTargetingOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsAdvancedOption (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_containsAdvancedOption_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdTargetingOptions']/method[@name='containsAdvancedOption' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("containsAdvancedOption", "(Ljava/lang/String;)Z", "GetContainsAdvancedOption_Ljava_lang_String_Handler")]
		public virtual unsafe bool ContainsAdvancedOption (string p0)
		{
			if (id_containsAdvancedOption_Ljava_lang_String_ == IntPtr.Zero)
				id_containsAdvancedOption_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "containsAdvancedOption", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_containsAdvancedOption_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "containsAdvancedOption", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_enableGeoLocation_Z;
#pragma warning disable 0169
		static Delegate GetEnableGeoLocation_ZHandler ()
		{
			if (cb_enableGeoLocation_Z == null)
				cb_enableGeoLocation_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_EnableGeoLocation_Z);
			return cb_enableGeoLocation_Z;
		}

		static IntPtr n_EnableGeoLocation_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amazon.Device.Ads.AdTargetingOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdTargetingOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EnableGeoLocation (p0));
		}
#pragma warning restore 0169

		static IntPtr id_enableGeoLocation_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdTargetingOptions']/method[@name='enableGeoLocation' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableGeoLocation", "(Z)Lcom/amazon/device/ads/AdTargetingOptions;", "GetEnableGeoLocation_ZHandler")]
		public virtual unsafe global::Com.Amazon.Device.Ads.AdTargetingOptions EnableGeoLocation (bool p0)
		{
			if (id_enableGeoLocation_Z == IntPtr.Zero)
				id_enableGeoLocation_Z = JNIEnv.GetMethodID (class_ref, "enableGeoLocation", "(Z)Lcom/amazon/device/ads/AdTargetingOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdTargetingOptions> (JNIEnv.CallObjectMethod  (Handle, id_enableGeoLocation_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdTargetingOptions> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableGeoLocation", "(Z)Lcom/amazon/device/ads/AdTargetingOptions;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getAdvancedOption_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAdvancedOption_Ljava_lang_String_Handler ()
		{
			if (cb_getAdvancedOption_Ljava_lang_String_ == null)
				cb_getAdvancedOption_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAdvancedOption_Ljava_lang_String_);
			return cb_getAdvancedOption_Ljava_lang_String_;
		}

		static IntPtr n_GetAdvancedOption_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Device.Ads.AdTargetingOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdTargetingOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAdvancedOption (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAdvancedOption_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdTargetingOptions']/method[@name='getAdvancedOption' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAdvancedOption", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetAdvancedOption_Ljava_lang_String_Handler")]
		public virtual unsafe string GetAdvancedOption (string p0)
		{
			if (id_getAdvancedOption_Ljava_lang_String_ == IntPtr.Zero)
				id_getAdvancedOption_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAdvancedOption", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAdvancedOption_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdvancedOption", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setAdvancedOption_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAdvancedOption_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setAdvancedOption_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setAdvancedOption_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAdvancedOption_Ljava_lang_String_Ljava_lang_String_);
			return cb_setAdvancedOption_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_SetAdvancedOption_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Device.Ads.AdTargetingOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdTargetingOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAdvancedOption (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setAdvancedOption_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdTargetingOptions']/method[@name='setAdvancedOption' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setAdvancedOption", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/device/ads/AdTargetingOptions;", "GetSetAdvancedOption_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Amazon.Device.Ads.AdTargetingOptions SetAdvancedOption (string p0, string p1)
		{
			if (id_setAdvancedOption_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setAdvancedOption_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAdvancedOption", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/device/ads/AdTargetingOptions;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Amazon.Device.Ads.AdTargetingOptions __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdTargetingOptions> (JNIEnv.CallObjectMethod  (Handle, id_setAdvancedOption_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdTargetingOptions> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdvancedOption", "(Ljava/lang/String;Ljava/lang/String;)Lcom/amazon/device/ads/AdTargetingOptions;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setAge_I;
#pragma warning disable 0169
		static Delegate GetSetAge_IHandler ()
		{
			if (cb_setAge_I == null)
				cb_setAge_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetAge_I);
			return cb_setAge_I;
		}

		static IntPtr n_SetAge_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amazon.Device.Ads.AdTargetingOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdTargetingOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAge (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setAge_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdTargetingOptions']/method[@name='setAge' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAge", "(I)Lcom/amazon/device/ads/AdTargetingOptions;", "GetSetAge_IHandler")]
		public virtual unsafe global::Com.Amazon.Device.Ads.AdTargetingOptions SetAge (int p0)
		{
			if (id_setAge_I == IntPtr.Zero)
				id_setAge_I = JNIEnv.GetMethodID (class_ref, "setAge", "(I)Lcom/amazon/device/ads/AdTargetingOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdTargetingOptions> (JNIEnv.CallObjectMethod  (Handle, id_setAge_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdTargetingOptions> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAge", "(I)Lcom/amazon/device/ads/AdTargetingOptions;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setFloorPrice_J;
#pragma warning disable 0169
		static Delegate GetSetFloorPrice_JHandler ()
		{
			if (cb_setFloorPrice_J == null)
				cb_setFloorPrice_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetFloorPrice_J);
			return cb_setFloorPrice_J;
		}

		static IntPtr n_SetFloorPrice_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amazon.Device.Ads.AdTargetingOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdTargetingOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetFloorPrice (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setFloorPrice_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdTargetingOptions']/method[@name='setFloorPrice' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setFloorPrice", "(J)Lcom/amazon/device/ads/AdTargetingOptions;", "GetSetFloorPrice_JHandler")]
		public virtual unsafe global::Com.Amazon.Device.Ads.AdTargetingOptions SetFloorPrice (long p0)
		{
			if (id_setFloorPrice_J == IntPtr.Zero)
				id_setFloorPrice_J = JNIEnv.GetMethodID (class_ref, "setFloorPrice", "(J)Lcom/amazon/device/ads/AdTargetingOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdTargetingOptions> (JNIEnv.CallObjectMethod  (Handle, id_setFloorPrice_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdTargetingOptions> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFloorPrice", "(J)Lcom/amazon/device/ads/AdTargetingOptions;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
