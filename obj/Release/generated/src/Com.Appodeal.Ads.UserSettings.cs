using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']"
	[global::Android.Runtime.Register ("com/appodeal/ads/UserSettings", DoNotGenerateAcw=true)]
	public partial class UserSettings : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Gender']"
		[global::Android.Runtime.Register ("com/appodeal/ads/UserSettings$Gender", DoNotGenerateAcw=true)]
		public sealed partial class Gender : global::Java.Lang.Enum {


			static IntPtr FEMALE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Gender']/field[@name='FEMALE']"
			[Register ("FEMALE")]
			public static global::Com.Appodeal.Ads.UserSettings.Gender FEMALE {
				get {
					if (FEMALE_jfieldId == IntPtr.Zero)
						FEMALE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FEMALE", "Lcom/appodeal/ads/UserSettings$Gender;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FEMALE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Gender> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MALE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Gender']/field[@name='MALE']"
			[Register ("MALE")]
			public static global::Com.Appodeal.Ads.UserSettings.Gender MALE {
				get {
					if (MALE_jfieldId == IntPtr.Zero)
						MALE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MALE", "Lcom/appodeal/ads/UserSettings$Gender;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MALE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Gender> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OTHER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Gender']/field[@name='OTHER']"
			[Register ("OTHER")]
			public static global::Com.Appodeal.Ads.UserSettings.Gender OTHER {
				get {
					if (OTHER_jfieldId == IntPtr.Zero)
						OTHER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OTHER", "Lcom/appodeal/ads/UserSettings$Gender;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OTHER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Gender> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/appodeal/ads/UserSettings$Gender", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Gender); }
			}

			internal Gender (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getMailruValue;
			public unsafe int MailruValue {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Gender']/method[@name='getMailruValue' and count(parameter)=0]"
				[Register ("getMailruValue", "()I", "GetGetMailruValueHandler")]
				get {
					if (id_getMailruValue == IntPtr.Zero)
						id_getMailruValue = JNIEnv.GetMethodID (class_ref, "getMailruValue", "()I");
					try {
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMailruValue);
					} finally {
					}
				}
			}

			static IntPtr id_getMopubValue;
			public unsafe string MopubValue {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Gender']/method[@name='getMopubValue' and count(parameter)=0]"
				[Register ("getMopubValue", "()Ljava/lang/String;", "GetGetMopubValueHandler")]
				get {
					if (id_getMopubValue == IntPtr.Zero)
						id_getMopubValue = JNIEnv.GetMethodID (class_ref, "getMopubValue", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMopubValue), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_getValue;
			public unsafe int Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Gender']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()I", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
					try {
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getValue);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Gender']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings$Gender;", "")]
			public static unsafe global::Com.Appodeal.Ads.UserSettings.Gender ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings$Gender;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Appodeal.Ads.UserSettings.Gender __ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Gender> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Gender']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/appodeal/ads/UserSettings$Gender;", "")]
			public static unsafe global::Com.Appodeal.Ads.UserSettings.Gender[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/appodeal/ads/UserSettings$Gender;");
				try {
					return (global::Com.Appodeal.Ads.UserSettings.Gender[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Appodeal.Ads.UserSettings.Gender));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Relation']"
		[global::Android.Runtime.Register ("com/appodeal/ads/UserSettings$Relation", DoNotGenerateAcw=true)]
		public sealed partial class Relation : global::Java.Lang.Enum {


			static IntPtr DATING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Relation']/field[@name='DATING']"
			[Register ("DATING")]
			public static global::Com.Appodeal.Ads.UserSettings.Relation Dating {
				get {
					if (DATING_jfieldId == IntPtr.Zero)
						DATING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DATING", "Lcom/appodeal/ads/UserSettings$Relation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DATING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Relation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ENGAGED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Relation']/field[@name='ENGAGED']"
			[Register ("ENGAGED")]
			public static global::Com.Appodeal.Ads.UserSettings.Relation Engaged {
				get {
					if (ENGAGED_jfieldId == IntPtr.Zero)
						ENGAGED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENGAGED", "Lcom/appodeal/ads/UserSettings$Relation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENGAGED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Relation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MARRIED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Relation']/field[@name='MARRIED']"
			[Register ("MARRIED")]
			public static global::Com.Appodeal.Ads.UserSettings.Relation Married {
				get {
					if (MARRIED_jfieldId == IntPtr.Zero)
						MARRIED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MARRIED", "Lcom/appodeal/ads/UserSettings$Relation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MARRIED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Relation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OTHER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Relation']/field[@name='OTHER']"
			[Register ("OTHER")]
			public static global::Com.Appodeal.Ads.UserSettings.Relation Other {
				get {
					if (OTHER_jfieldId == IntPtr.Zero)
						OTHER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OTHER", "Lcom/appodeal/ads/UserSettings$Relation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OTHER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Relation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SEARCHING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Relation']/field[@name='SEARCHING']"
			[Register ("SEARCHING")]
			public static global::Com.Appodeal.Ads.UserSettings.Relation Searching {
				get {
					if (SEARCHING_jfieldId == IntPtr.Zero)
						SEARCHING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SEARCHING", "Lcom/appodeal/ads/UserSettings$Relation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SEARCHING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Relation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SINGLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Relation']/field[@name='SINGLE']"
			[Register ("SINGLE")]
			public static global::Com.Appodeal.Ads.UserSettings.Relation Single {
				get {
					if (SINGLE_jfieldId == IntPtr.Zero)
						SINGLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINGLE", "Lcom/appodeal/ads/UserSettings$Relation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SINGLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Relation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/appodeal/ads/UserSettings$Relation", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Relation); }
			}

			internal Relation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getMopubValue;
			public unsafe string MopubValue {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Relation']/method[@name='getMopubValue' and count(parameter)=0]"
				[Register ("getMopubValue", "()Ljava/lang/String;", "GetGetMopubValueHandler")]
				get {
					if (id_getMopubValue == IntPtr.Zero)
						id_getMopubValue = JNIEnv.GetMethodID (class_ref, "getMopubValue", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMopubValue), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_getValue;
			public unsafe int Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Relation']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()I", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
					try {
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getValue);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Relation']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings$Relation;", "")]
			public static unsafe global::Com.Appodeal.Ads.UserSettings.Relation ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings$Relation;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Appodeal.Ads.UserSettings.Relation __ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Relation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Relation']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/appodeal/ads/UserSettings$Relation;", "")]
			public static unsafe global::Com.Appodeal.Ads.UserSettings.Relation[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/appodeal/ads/UserSettings$Relation;");
				try {
					return (global::Com.Appodeal.Ads.UserSettings.Relation[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Appodeal.Ads.UserSettings.Relation));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/appodeal/ads/UserSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UserSettings); }
		}

		protected UserSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAge;
#pragma warning disable 0169
		static Delegate GetGetAgeHandler ()
		{
			if (cb_getAge == null)
				cb_getAge = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAge);
			return cb_getAge;
		}

		static IntPtr n_GetAge (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Age);
		}
#pragma warning restore 0169

		static IntPtr id_getAge;
		public virtual unsafe global::Java.Lang.Integer Age {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='getAge' and count(parameter)=0]"
			[Register ("getAge", "()Ljava/lang/Integer;", "GetGetAgeHandler")]
			get {
				if (id_getAge == IntPtr.Zero)
					id_getAge = JNIEnv.GetMethodID (class_ref, "getAge", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAge), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAge", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserId;
#pragma warning disable 0169
		static Delegate GetGetUserIdHandler ()
		{
			if (cb_getUserId == null)
				cb_getUserId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserId);
			return cb_getUserId;
		}

		static IntPtr n_GetUserId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserId);
		}
#pragma warning restore 0169

		static IntPtr id_getUserId;
		public virtual unsafe string UserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='getUserId' and count(parameter)=0]"
			[Register ("getUserId", "()Ljava/lang/String;", "GetGetUserIdHandler")]
			get {
				if (id_getUserId == IntPtr.Zero)
					id_getUserId = JNIEnv.GetMethodID (class_ref, "getUserId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_A);
			return cb_a;
		}

		static IntPtr n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.A ());
		}
#pragma warning restore 0169

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lcom/appodeal/ads/UserSettings$Relation;", "GetAHandler")]
		public virtual unsafe global::Com.Appodeal.Ads.UserSettings.Relation A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Lcom/appodeal/ads/UserSettings$Relation;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Relation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Relation> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "()Lcom/appodeal/ads/UserSettings$Relation;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_a_Lcom_appodeal_ads_UserSettings_Relation_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_appodeal_ads_UserSettings_Relation_Handler ()
		{
			if (cb_a_Lcom_appodeal_ads_UserSettings_Relation_ == null)
				cb_a_Lcom_appodeal_ads_UserSettings_Relation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Lcom_appodeal_ads_UserSettings_Relation_);
			return cb_a_Lcom_appodeal_ads_UserSettings_Relation_;
		}

		static IntPtr n_A_Lcom_appodeal_ads_UserSettings_Relation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Appodeal.Ads.UserSettings.Relation p0 = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Relation> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.A (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_a_Lcom_appodeal_ads_UserSettings_Relation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.UserSettings.Relation']]"
		[Register ("a", "(Lcom/appodeal/ads/UserSettings$Relation;)Lcom/appodeal/ads/UserSettings;", "GetA_Lcom_appodeal_ads_UserSettings_Relation_Handler")]
		public virtual unsafe global::Com.Appodeal.Ads.UserSettings A (global::Com.Appodeal.Ads.UserSettings.Relation p0)
		{
			if (id_a_Lcom_appodeal_ads_UserSettings_Relation_ == IntPtr.Zero)
				id_a_Lcom_appodeal_ads_UserSettings_Relation_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/appodeal/ads/UserSettings$Relation;)Lcom/appodeal/ads/UserSettings;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Appodeal.Ads.UserSettings __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a_Lcom_appodeal_ads_UserSettings_Relation_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Lcom/appodeal/ads/UserSettings$Relation;)Lcom/appodeal/ads/UserSettings;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_a_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_Handler ()
		{
			if (cb_a_Ljava_lang_String_ == null)
				cb_a_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_String_);
			return cb_a_Ljava_lang_String_;
		}

		static IntPtr n_A_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.A (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings;", "GetA_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Appodeal.Ads.UserSettings A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Appodeal.Ads.UserSettings __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_B);
			return cb_b;
		}

		static IntPtr n_B (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.B ());
		}
#pragma warning restore 0169

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Ljava/lang/String;", "GetBHandler")]
		public virtual unsafe string B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_b), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_c;
#pragma warning disable 0169
		static Delegate GetCHandler ()
		{
			if (cb_c == null)
				cb_c = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_C);
			return cb_c;
		}

		static IntPtr n_C (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.C ());
		}
#pragma warning restore 0169

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/lang/String;", "GetCHandler")]
		public virtual unsafe string C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_c), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "c", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_d;
#pragma warning disable 0169
		static Delegate GetDHandler ()
		{
			if (cb_d == null)
				cb_d = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_D);
			return cb_d;
		}

		static IntPtr n_D (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.D ());
		}
#pragma warning restore 0169

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Ljava/lang/String;", "GetDHandler")]
		public virtual unsafe string D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_d), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "d", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_e;
#pragma warning disable 0169
		static Delegate GetEHandler ()
		{
			if (cb_e == null)
				cb_e = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_E);
			return cb_e;
		}

		static IntPtr n_E (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.E ());
		}
#pragma warning restore 0169

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Ljava/lang/String;", "GetEHandler")]
		public virtual unsafe string E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_e), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "e", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_f;
#pragma warning disable 0169
		static Delegate GetFHandler ()
		{
			if (cb_f == null)
				cb_f = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_F);
			return cb_f;
		}

		static IntPtr n_F (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.F ());
		}
#pragma warning restore 0169

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Ljava/lang/String;", "GetFHandler")]
		public virtual unsafe string F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_f), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "f", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_g;
#pragma warning disable 0169
		static Delegate GetGHandler ()
		{
			if (cb_g == null)
				cb_g = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_G);
			return cb_g;
		}

		static IntPtr n_G (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.G ());
		}
#pragma warning restore 0169

		static IntPtr id_g;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()Ljava/lang/Float;", "GetGHandler")]
		public virtual unsafe global::Java.Lang.Float G ()
		{
			if (id_g == IntPtr.Zero)
				id_g = JNIEnv.GetMethodID (class_ref, "g", "()Ljava/lang/Float;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_g), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "g", "()Ljava/lang/Float;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getGender;
#pragma warning disable 0169
		static Delegate GetGetGenderHandler ()
		{
			if (cb_getGender == null)
				cb_getGender = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGender);
			return cb_getGender;
		}

		static IntPtr n_GetGender (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetGender ());
		}
#pragma warning restore 0169

		static IntPtr id_getGender;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='getGender' and count(parameter)=0]"
		[Register ("getGender", "()Lcom/appodeal/ads/UserSettings$Gender;", "GetGetGenderHandler")]
		public virtual unsafe global::Com.Appodeal.Ads.UserSettings.Gender GetGender ()
		{
			if (id_getGender == IntPtr.Zero)
				id_getGender = JNIEnv.GetMethodID (class_ref, "getGender", "()Lcom/appodeal/ads/UserSettings$Gender;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Gender> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGender), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Gender> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGender", "()Lcom/appodeal/ads/UserSettings$Gender;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_h;
#pragma warning disable 0169
		static Delegate GetHHandler ()
		{
			if (cb_h == null)
				cb_h = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_H);
			return cb_h;
		}

		static IntPtr n_H (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.H ());
		}
#pragma warning restore 0169

		static IntPtr id_h;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()Ljava/lang/Float;", "GetHHandler")]
		public virtual unsafe global::Java.Lang.Float H ()
		{
			if (id_h == IntPtr.Zero)
				id_h = JNIEnv.GetMethodID (class_ref, "h", "()Ljava/lang/Float;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_h), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "h", "()Ljava/lang/Float;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_i;
#pragma warning disable 0169
		static Delegate GetIHandler ()
		{
			if (cb_i == null)
				cb_i = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_I);
			return cb_i;
		}

		static IntPtr n_I (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.I ());
		}
#pragma warning restore 0169

		static IntPtr id_i;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='i' and count(parameter)=0]"
		[Register ("i", "()Ljava/lang/String;", "GetIHandler")]
		public virtual unsafe string I ()
		{
			if (id_i == IntPtr.Zero)
				id_i = JNIEnv.GetMethodID (class_ref, "i", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_i), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "i", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_j;
#pragma warning disable 0169
		static Delegate GetJHandler ()
		{
			if (cb_j == null)
				cb_j = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_J);
			return cb_j;
		}

		static IntPtr n_J (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.J ());
		}
#pragma warning restore 0169

		static IntPtr id_j;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='j' and count(parameter)=0]"
		[Register ("j", "()Ljava/lang/String;", "GetJHandler")]
		public virtual unsafe string J ()
		{
			if (id_j == IntPtr.Zero)
				id_j = JNIEnv.GetMethodID (class_ref, "j", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_j), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "j", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_l;
#pragma warning disable 0169
		static Delegate GetLHandler ()
		{
			if (cb_l == null)
				cb_l = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_L);
			return cb_l;
		}

		static IntPtr n_L (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.L ());
		}
#pragma warning restore 0169

		static IntPtr id_l;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='l' and count(parameter)=0]"
		[Register ("l", "()Ljava/lang/String;", "GetLHandler")]
		public virtual unsafe string L ()
		{
			if (id_l == IntPtr.Zero)
				id_l = JNIEnv.GetMethodID (class_ref, "l", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_l), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "l", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAge (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setAge_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='setAge' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAge", "(I)Lcom/appodeal/ads/UserSettings;", "GetSetAge_IHandler")]
		public virtual unsafe global::Com.Appodeal.Ads.UserSettings SetAge (int p0)
		{
			if (id_setAge_I == IntPtr.Zero)
				id_setAge_I = JNIEnv.GetMethodID (class_ref, "setAge", "(I)Lcom/appodeal/ads/UserSettings;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAge_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAge", "(I)Lcom/appodeal/ads/UserSettings;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setGender_Lcom_appodeal_ads_UserSettings_Gender_;
#pragma warning disable 0169
		static Delegate GetSetGender_Lcom_appodeal_ads_UserSettings_Gender_Handler ()
		{
			if (cb_setGender_Lcom_appodeal_ads_UserSettings_Gender_ == null)
				cb_setGender_Lcom_appodeal_ads_UserSettings_Gender_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetGender_Lcom_appodeal_ads_UserSettings_Gender_);
			return cb_setGender_Lcom_appodeal_ads_UserSettings_Gender_;
		}

		static IntPtr n_SetGender_Lcom_appodeal_ads_UserSettings_Gender_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Appodeal.Ads.UserSettings.Gender p0 = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Gender> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetGender (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setGender_Lcom_appodeal_ads_UserSettings_Gender_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='setGender' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.UserSettings.Gender']]"
		[Register ("setGender", "(Lcom/appodeal/ads/UserSettings$Gender;)Lcom/appodeal/ads/UserSettings;", "GetSetGender_Lcom_appodeal_ads_UserSettings_Gender_Handler")]
		public virtual unsafe global::Com.Appodeal.Ads.UserSettings SetGender (global::Com.Appodeal.Ads.UserSettings.Gender p0)
		{
			if (id_setGender_Lcom_appodeal_ads_UserSettings_Gender_ == IntPtr.Zero)
				id_setGender_Lcom_appodeal_ads_UserSettings_Gender_ = JNIEnv.GetMethodID (class_ref, "setGender", "(Lcom/appodeal/ads/UserSettings$Gender;)Lcom/appodeal/ads/UserSettings;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Appodeal.Ads.UserSettings __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setGender_Lcom_appodeal_ads_UserSettings_Gender_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGender", "(Lcom/appodeal/ads/UserSettings$Gender;)Lcom/appodeal/ads/UserSettings;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setUserId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserId_Ljava_lang_String_Handler ()
		{
			if (cb_setUserId_Ljava_lang_String_ == null)
				cb_setUserId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUserId_Ljava_lang_String_);
			return cb_setUserId_Ljava_lang_String_;
		}

		static IntPtr n_SetUserId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUserId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setUserId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='setUserId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUserId", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings;", "GetSetUserId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Appodeal.Ads.UserSettings SetUserId (string p0)
		{
			if (id_setUserId_Ljava_lang_String_ == IntPtr.Zero)
				id_setUserId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserId", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Appodeal.Ads.UserSettings __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setUserId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserId", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
