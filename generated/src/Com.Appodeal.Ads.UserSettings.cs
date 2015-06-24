using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']"
	[global::Android.Runtime.Register ("com/appodeal/ads/UserSettings", DoNotGenerateAcw=true)]
	public partial class UserSettings : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Alcohol']"
		[global::Android.Runtime.Register ("com/appodeal/ads/UserSettings$Alcohol", DoNotGenerateAcw=true)]
		public sealed partial class Alcohol : global::Java.Lang.Enum {


			static IntPtr NEGATIVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Alcohol']/field[@name='NEGATIVE']"
			[Register ("NEGATIVE")]
			public static global::Com.Appodeal.Ads.UserSettings.Alcohol Negative {
				get {
					if (NEGATIVE_jfieldId == IntPtr.Zero)
						NEGATIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEGATIVE", "Lcom/appodeal/ads/UserSettings$Alcohol;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEGATIVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Alcohol> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NEUTRAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Alcohol']/field[@name='NEUTRAL']"
			[Register ("NEUTRAL")]
			public static global::Com.Appodeal.Ads.UserSettings.Alcohol Neutral {
				get {
					if (NEUTRAL_jfieldId == IntPtr.Zero)
						NEUTRAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEUTRAL", "Lcom/appodeal/ads/UserSettings$Alcohol;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEUTRAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Alcohol> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr POSITIVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Alcohol']/field[@name='POSITIVE']"
			[Register ("POSITIVE")]
			public static global::Com.Appodeal.Ads.UserSettings.Alcohol Positive {
				get {
					if (POSITIVE_jfieldId == IntPtr.Zero)
						POSITIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POSITIVE", "Lcom/appodeal/ads/UserSettings$Alcohol;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POSITIVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Alcohol> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/appodeal/ads/UserSettings$Alcohol", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Alcohol); }
			}

			internal Alcohol (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public unsafe int Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Alcohol']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()I", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
					try {
						return JNIEnv.CallIntMethod  (Handle, id_getValue);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Alcohol']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings$Alcohol;", "")]
			public static unsafe global::Com.Appodeal.Ads.UserSettings.Alcohol ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings$Alcohol;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Appodeal.Ads.UserSettings.Alcohol __ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Alcohol> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Alcohol']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/appodeal/ads/UserSettings$Alcohol;", "")]
			public static unsafe global::Com.Appodeal.Ads.UserSettings.Alcohol[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/appodeal/ads/UserSettings$Alcohol;");
				try {
					return (global::Com.Appodeal.Ads.UserSettings.Alcohol[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Appodeal.Ads.UserSettings.Alcohol));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Gender']"
		[global::Android.Runtime.Register ("com/appodeal/ads/UserSettings$Gender", DoNotGenerateAcw=true)]
		public sealed partial class Gender : global::Java.Lang.Enum {


			static IntPtr FEMALE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Gender']/field[@name='FEMALE']"
			[Register ("FEMALE")]
			public static global::Com.Appodeal.Ads.UserSettings.Gender Female {
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
			public static global::Com.Appodeal.Ads.UserSettings.Gender Male {
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
			public static global::Com.Appodeal.Ads.UserSettings.Gender Other {
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

			static IntPtr id_getMopubValue;
			public unsafe string MopubValue {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Gender']/method[@name='getMopubValue' and count(parameter)=0]"
				[Register ("getMopubValue", "()Ljava/lang/String;", "GetGetMopubValueHandler")]
				get {
					if (id_getMopubValue == IntPtr.Zero)
						id_getMopubValue = JNIEnv.GetMethodID (class_ref, "getMopubValue", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMopubValue), JniHandleOwnership.TransferLocalRef);
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
						return JNIEnv.CallIntMethod  (Handle, id_getValue);
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Occupation']"
		[global::Android.Runtime.Register ("com/appodeal/ads/UserSettings$Occupation", DoNotGenerateAcw=true)]
		public sealed partial class Occupation : global::Java.Lang.Enum {


			static IntPtr OTHER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Occupation']/field[@name='OTHER']"
			[Register ("OTHER")]
			public static global::Com.Appodeal.Ads.UserSettings.Occupation Other {
				get {
					if (OTHER_jfieldId == IntPtr.Zero)
						OTHER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OTHER", "Lcom/appodeal/ads/UserSettings$Occupation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OTHER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Occupation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SCHOOL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Occupation']/field[@name='SCHOOL']"
			[Register ("SCHOOL")]
			public static global::Com.Appodeal.Ads.UserSettings.Occupation School {
				get {
					if (SCHOOL_jfieldId == IntPtr.Zero)
						SCHOOL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SCHOOL", "Lcom/appodeal/ads/UserSettings$Occupation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SCHOOL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Occupation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNIVERSITY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Occupation']/field[@name='UNIVERSITY']"
			[Register ("UNIVERSITY")]
			public static global::Com.Appodeal.Ads.UserSettings.Occupation University {
				get {
					if (UNIVERSITY_jfieldId == IntPtr.Zero)
						UNIVERSITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNIVERSITY", "Lcom/appodeal/ads/UserSettings$Occupation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNIVERSITY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Occupation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WORK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Occupation']/field[@name='WORK']"
			[Register ("WORK")]
			public static global::Com.Appodeal.Ads.UserSettings.Occupation Work {
				get {
					if (WORK_jfieldId == IntPtr.Zero)
						WORK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WORK", "Lcom/appodeal/ads/UserSettings$Occupation;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WORK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Occupation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/appodeal/ads/UserSettings$Occupation", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Occupation); }
			}

			internal Occupation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public unsafe int Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Occupation']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()I", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
					try {
						return JNIEnv.CallIntMethod  (Handle, id_getValue);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Occupation']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings$Occupation;", "")]
			public static unsafe global::Com.Appodeal.Ads.UserSettings.Occupation ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings$Occupation;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Appodeal.Ads.UserSettings.Occupation __ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Occupation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Occupation']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/appodeal/ads/UserSettings$Occupation;", "")]
			public static unsafe global::Com.Appodeal.Ads.UserSettings.Occupation[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/appodeal/ads/UserSettings$Occupation;");
				try {
					return (global::Com.Appodeal.Ads.UserSettings.Occupation[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Appodeal.Ads.UserSettings.Occupation));
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
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMopubValue), JniHandleOwnership.TransferLocalRef);
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
						return JNIEnv.CallIntMethod  (Handle, id_getValue);
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Smoking']"
		[global::Android.Runtime.Register ("com/appodeal/ads/UserSettings$Smoking", DoNotGenerateAcw=true)]
		public sealed partial class Smoking : global::Java.Lang.Enum {


			static IntPtr NEGATIVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Smoking']/field[@name='NEGATIVE']"
			[Register ("NEGATIVE")]
			public static global::Com.Appodeal.Ads.UserSettings.Smoking Negative {
				get {
					if (NEGATIVE_jfieldId == IntPtr.Zero)
						NEGATIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEGATIVE", "Lcom/appodeal/ads/UserSettings$Smoking;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEGATIVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Smoking> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NEUTRAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Smoking']/field[@name='NEUTRAL']"
			[Register ("NEUTRAL")]
			public static global::Com.Appodeal.Ads.UserSettings.Smoking Neutral {
				get {
					if (NEUTRAL_jfieldId == IntPtr.Zero)
						NEUTRAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEUTRAL", "Lcom/appodeal/ads/UserSettings$Smoking;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEUTRAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Smoking> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr POSITIVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Smoking']/field[@name='POSITIVE']"
			[Register ("POSITIVE")]
			public static global::Com.Appodeal.Ads.UserSettings.Smoking Positive {
				get {
					if (POSITIVE_jfieldId == IntPtr.Zero)
						POSITIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POSITIVE", "Lcom/appodeal/ads/UserSettings$Smoking;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POSITIVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Smoking> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/appodeal/ads/UserSettings$Smoking", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Smoking); }
			}

			internal Smoking (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public unsafe int Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Smoking']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()I", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
					try {
						return JNIEnv.CallIntMethod  (Handle, id_getValue);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Smoking']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings$Smoking;", "")]
			public static unsafe global::Com.Appodeal.Ads.UserSettings.Smoking ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings$Smoking;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Appodeal.Ads.UserSettings.Smoking __ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Smoking> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings.Smoking']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/appodeal/ads/UserSettings$Smoking;", "")]
			public static unsafe global::Com.Appodeal.Ads.UserSettings.Smoking[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/appodeal/ads/UserSettings$Smoking;");
				try {
					return (global::Com.Appodeal.Ads.UserSettings.Smoking[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Appodeal.Ads.UserSettings.Smoking));
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
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getAge), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAge", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBirthday;
#pragma warning disable 0169
		static Delegate GetGetBirthdayHandler ()
		{
			if (cb_getBirthday == null)
				cb_getBirthday = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBirthday);
			return cb_getBirthday;
		}

		static IntPtr n_GetBirthday (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Birthday);
		}
#pragma warning restore 0169

		static IntPtr id_getBirthday;
		public virtual unsafe string Birthday {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='getBirthday' and count(parameter)=0]"
			[Register ("getBirthday", "()Ljava/lang/String;", "GetGetBirthdayHandler")]
			get {
				if (id_getBirthday == IntPtr.Zero)
					id_getBirthday = JNIEnv.GetMethodID (class_ref, "getBirthday", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBirthday), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBirthday", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEmail;
#pragma warning disable 0169
		static Delegate GetGetEmailHandler ()
		{
			if (cb_getEmail == null)
				cb_getEmail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmail);
			return cb_getEmail;
		}

		static IntPtr n_GetEmail (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Email);
		}
#pragma warning restore 0169

		static IntPtr id_getEmail;
		public virtual unsafe string Email {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='getEmail' and count(parameter)=0]"
			[Register ("getEmail", "()Ljava/lang/String;", "GetGetEmailHandler")]
			get {
				if (id_getEmail == IntPtr.Zero)
					id_getEmail = JNIEnv.GetMethodID (class_ref, "getEmail", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getEmail), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmail", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFacebookId;
#pragma warning disable 0169
		static Delegate GetGetFacebookIdHandler ()
		{
			if (cb_getFacebookId == null)
				cb_getFacebookId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFacebookId);
			return cb_getFacebookId;
		}

		static IntPtr n_GetFacebookId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FacebookId);
		}
#pragma warning restore 0169

		static IntPtr id_getFacebookId;
		public virtual unsafe string FacebookId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='getFacebookId' and count(parameter)=0]"
			[Register ("getFacebookId", "()Ljava/lang/String;", "GetGetFacebookIdHandler")]
			get {
				if (id_getFacebookId == IntPtr.Zero)
					id_getFacebookId = JNIEnv.GetMethodID (class_ref, "getFacebookId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFacebookId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFacebookId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInterests;
#pragma warning disable 0169
		static Delegate GetGetInterestsHandler ()
		{
			if (cb_getInterests == null)
				cb_getInterests = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInterests);
			return cb_getInterests;
		}

		static IntPtr n_GetInterests (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Interests);
		}
#pragma warning restore 0169

		static IntPtr id_getInterests;
		public virtual unsafe string Interests {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='getInterests' and count(parameter)=0]"
			[Register ("getInterests", "()Ljava/lang/String;", "GetGetInterestsHandler")]
			get {
				if (id_getInterests == IntPtr.Zero)
					id_getInterests = JNIEnv.GetMethodID (class_ref, "getInterests", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getInterests), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInterests", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVkId;
#pragma warning disable 0169
		static Delegate GetGetVkIdHandler ()
		{
			if (cb_getVkId == null)
				cb_getVkId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVkId);
			return cb_getVkId;
		}

		static IntPtr n_GetVkId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VkId);
		}
#pragma warning restore 0169

		static IntPtr id_getVkId;
		public virtual unsafe string VkId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='getVkId' and count(parameter)=0]"
			[Register ("getVkId", "()Ljava/lang/String;", "GetGetVkIdHandler")]
			get {
				if (id_getVkId == IntPtr.Zero)
					id_getVkId = JNIEnv.GetMethodID (class_ref, "getVkId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getVkId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVkId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAlcohol;
#pragma warning disable 0169
		static Delegate GetGetAlcoholHandler ()
		{
			if (cb_getAlcohol == null)
				cb_getAlcohol = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAlcohol);
			return cb_getAlcohol;
		}

		static IntPtr n_GetAlcohol (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetAlcohol ());
		}
#pragma warning restore 0169

		static IntPtr id_getAlcohol;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='getAlcohol' and count(parameter)=0]"
		[Register ("getAlcohol", "()Lcom/appodeal/ads/UserSettings$Alcohol;", "GetGetAlcoholHandler")]
		public virtual unsafe global::Com.Appodeal.Ads.UserSettings.Alcohol GetAlcohol ()
		{
			if (id_getAlcohol == IntPtr.Zero)
				id_getAlcohol = JNIEnv.GetMethodID (class_ref, "getAlcohol", "()Lcom/appodeal/ads/UserSettings$Alcohol;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Alcohol> (JNIEnv.CallObjectMethod  (Handle, id_getAlcohol), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Alcohol> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlcohol", "()Lcom/appodeal/ads/UserSettings$Alcohol;")), JniHandleOwnership.TransferLocalRef);
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
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Gender> (JNIEnv.CallObjectMethod  (Handle, id_getGender), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Gender> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGender", "()Lcom/appodeal/ads/UserSettings$Gender;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getOccupation;
#pragma warning disable 0169
		static Delegate GetGetOccupationHandler ()
		{
			if (cb_getOccupation == null)
				cb_getOccupation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOccupation);
			return cb_getOccupation;
		}

		static IntPtr n_GetOccupation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetOccupation ());
		}
#pragma warning restore 0169

		static IntPtr id_getOccupation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='getOccupation' and count(parameter)=0]"
		[Register ("getOccupation", "()Lcom/appodeal/ads/UserSettings$Occupation;", "GetGetOccupationHandler")]
		public virtual unsafe global::Com.Appodeal.Ads.UserSettings.Occupation GetOccupation ()
		{
			if (id_getOccupation == IntPtr.Zero)
				id_getOccupation = JNIEnv.GetMethodID (class_ref, "getOccupation", "()Lcom/appodeal/ads/UserSettings$Occupation;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Occupation> (JNIEnv.CallObjectMethod  (Handle, id_getOccupation), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Occupation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOccupation", "()Lcom/appodeal/ads/UserSettings$Occupation;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getRelation;
#pragma warning disable 0169
		static Delegate GetGetRelationHandler ()
		{
			if (cb_getRelation == null)
				cb_getRelation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRelation);
			return cb_getRelation;
		}

		static IntPtr n_GetRelation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetRelation ());
		}
#pragma warning restore 0169

		static IntPtr id_getRelation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='getRelation' and count(parameter)=0]"
		[Register ("getRelation", "()Lcom/appodeal/ads/UserSettings$Relation;", "GetGetRelationHandler")]
		public virtual unsafe global::Com.Appodeal.Ads.UserSettings.Relation GetRelation ()
		{
			if (id_getRelation == IntPtr.Zero)
				id_getRelation = JNIEnv.GetMethodID (class_ref, "getRelation", "()Lcom/appodeal/ads/UserSettings$Relation;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Relation> (JNIEnv.CallObjectMethod  (Handle, id_getRelation), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Relation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRelation", "()Lcom/appodeal/ads/UserSettings$Relation;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getSmoking;
#pragma warning disable 0169
		static Delegate GetGetSmokingHandler ()
		{
			if (cb_getSmoking == null)
				cb_getSmoking = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSmoking);
			return cb_getSmoking;
		}

		static IntPtr n_GetSmoking (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetSmoking ());
		}
#pragma warning restore 0169

		static IntPtr id_getSmoking;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='getSmoking' and count(parameter)=0]"
		[Register ("getSmoking", "()Lcom/appodeal/ads/UserSettings$Smoking;", "GetGetSmokingHandler")]
		public virtual unsafe global::Com.Appodeal.Ads.UserSettings.Smoking GetSmoking ()
		{
			if (id_getSmoking == IntPtr.Zero)
				id_getSmoking = JNIEnv.GetMethodID (class_ref, "getSmoking", "()Lcom/appodeal/ads/UserSettings$Smoking;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Smoking> (JNIEnv.CallObjectMethod  (Handle, id_getSmoking), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Smoking> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSmoking", "()Lcom/appodeal/ads/UserSettings$Smoking;")), JniHandleOwnership.TransferLocalRef);
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
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallObjectMethod  (Handle, id_setAge_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAge", "(I)Lcom/appodeal/ads/UserSettings;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAlcohol_Lcom_appodeal_ads_UserSettings_Alcohol_;
#pragma warning disable 0169
		static Delegate GetSetAlcohol_Lcom_appodeal_ads_UserSettings_Alcohol_Handler ()
		{
			if (cb_setAlcohol_Lcom_appodeal_ads_UserSettings_Alcohol_ == null)
				cb_setAlcohol_Lcom_appodeal_ads_UserSettings_Alcohol_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAlcohol_Lcom_appodeal_ads_UserSettings_Alcohol_);
			return cb_setAlcohol_Lcom_appodeal_ads_UserSettings_Alcohol_;
		}

		static IntPtr n_SetAlcohol_Lcom_appodeal_ads_UserSettings_Alcohol_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Appodeal.Ads.UserSettings.Alcohol p0 = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Alcohol> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAlcohol (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setAlcohol_Lcom_appodeal_ads_UserSettings_Alcohol_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='setAlcohol' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.UserSettings.Alcohol']]"
		[Register ("setAlcohol", "(Lcom/appodeal/ads/UserSettings$Alcohol;)Lcom/appodeal/ads/UserSettings;", "GetSetAlcohol_Lcom_appodeal_ads_UserSettings_Alcohol_Handler")]
		public virtual unsafe global::Com.Appodeal.Ads.UserSettings SetAlcohol (global::Com.Appodeal.Ads.UserSettings.Alcohol p0)
		{
			if (id_setAlcohol_Lcom_appodeal_ads_UserSettings_Alcohol_ == IntPtr.Zero)
				id_setAlcohol_Lcom_appodeal_ads_UserSettings_Alcohol_ = JNIEnv.GetMethodID (class_ref, "setAlcohol", "(Lcom/appodeal/ads/UserSettings$Alcohol;)Lcom/appodeal/ads/UserSettings;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Appodeal.Ads.UserSettings __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallObjectMethod  (Handle, id_setAlcohol_Lcom_appodeal_ads_UserSettings_Alcohol_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlcohol", "(Lcom/appodeal/ads/UserSettings$Alcohol;)Lcom/appodeal/ads/UserSettings;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setBirthday_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBirthday_Ljava_lang_String_Handler ()
		{
			if (cb_setBirthday_Ljava_lang_String_ == null)
				cb_setBirthday_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetBirthday_Ljava_lang_String_);
			return cb_setBirthday_Ljava_lang_String_;
		}

		static IntPtr n_SetBirthday_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetBirthday (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setBirthday_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='setBirthday' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setBirthday", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings;", "GetSetBirthday_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Appodeal.Ads.UserSettings SetBirthday (string p0)
		{
			if (id_setBirthday_Ljava_lang_String_ == IntPtr.Zero)
				id_setBirthday_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBirthday", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Appodeal.Ads.UserSettings __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallObjectMethod  (Handle, id_setBirthday_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBirthday", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setEmail_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEmail_Ljava_lang_String_Handler ()
		{
			if (cb_setEmail_Ljava_lang_String_ == null)
				cb_setEmail_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetEmail_Ljava_lang_String_);
			return cb_setEmail_Ljava_lang_String_;
		}

		static IntPtr n_SetEmail_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetEmail (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setEmail_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='setEmail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setEmail", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings;", "GetSetEmail_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Appodeal.Ads.UserSettings SetEmail (string p0)
		{
			if (id_setEmail_Ljava_lang_String_ == IntPtr.Zero)
				id_setEmail_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEmail", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Appodeal.Ads.UserSettings __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallObjectMethod  (Handle, id_setEmail_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmail", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setFacebookId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFacebookId_Ljava_lang_String_Handler ()
		{
			if (cb_setFacebookId_Ljava_lang_String_ == null)
				cb_setFacebookId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFacebookId_Ljava_lang_String_);
			return cb_setFacebookId_Ljava_lang_String_;
		}

		static IntPtr n_SetFacebookId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFacebookId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setFacebookId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='setFacebookId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setFacebookId", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings;", "GetSetFacebookId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Appodeal.Ads.UserSettings SetFacebookId (string p0)
		{
			if (id_setFacebookId_Ljava_lang_String_ == IntPtr.Zero)
				id_setFacebookId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFacebookId", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Appodeal.Ads.UserSettings __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallObjectMethod  (Handle, id_setFacebookId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFacebookId", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallObjectMethod  (Handle, id_setGender_Lcom_appodeal_ads_UserSettings_Gender_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGender", "(Lcom/appodeal/ads/UserSettings$Gender;)Lcom/appodeal/ads/UserSettings;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setInterests_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetInterests_Ljava_lang_String_Handler ()
		{
			if (cb_setInterests_Ljava_lang_String_ == null)
				cb_setInterests_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetInterests_Ljava_lang_String_);
			return cb_setInterests_Ljava_lang_String_;
		}

		static IntPtr n_SetInterests_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetInterests (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setInterests_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='setInterests' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setInterests", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings;", "GetSetInterests_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Appodeal.Ads.UserSettings SetInterests (string p0)
		{
			if (id_setInterests_Ljava_lang_String_ == IntPtr.Zero)
				id_setInterests_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setInterests", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Appodeal.Ads.UserSettings __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallObjectMethod  (Handle, id_setInterests_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInterests", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setOccupation_Lcom_appodeal_ads_UserSettings_Occupation_;
#pragma warning disable 0169
		static Delegate GetSetOccupation_Lcom_appodeal_ads_UserSettings_Occupation_Handler ()
		{
			if (cb_setOccupation_Lcom_appodeal_ads_UserSettings_Occupation_ == null)
				cb_setOccupation_Lcom_appodeal_ads_UserSettings_Occupation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOccupation_Lcom_appodeal_ads_UserSettings_Occupation_);
			return cb_setOccupation_Lcom_appodeal_ads_UserSettings_Occupation_;
		}

		static IntPtr n_SetOccupation_Lcom_appodeal_ads_UserSettings_Occupation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Appodeal.Ads.UserSettings.Occupation p0 = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Occupation> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOccupation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setOccupation_Lcom_appodeal_ads_UserSettings_Occupation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='setOccupation' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.UserSettings.Occupation']]"
		[Register ("setOccupation", "(Lcom/appodeal/ads/UserSettings$Occupation;)Lcom/appodeal/ads/UserSettings;", "GetSetOccupation_Lcom_appodeal_ads_UserSettings_Occupation_Handler")]
		public virtual unsafe global::Com.Appodeal.Ads.UserSettings SetOccupation (global::Com.Appodeal.Ads.UserSettings.Occupation p0)
		{
			if (id_setOccupation_Lcom_appodeal_ads_UserSettings_Occupation_ == IntPtr.Zero)
				id_setOccupation_Lcom_appodeal_ads_UserSettings_Occupation_ = JNIEnv.GetMethodID (class_ref, "setOccupation", "(Lcom/appodeal/ads/UserSettings$Occupation;)Lcom/appodeal/ads/UserSettings;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Appodeal.Ads.UserSettings __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallObjectMethod  (Handle, id_setOccupation_Lcom_appodeal_ads_UserSettings_Occupation_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOccupation", "(Lcom/appodeal/ads/UserSettings$Occupation;)Lcom/appodeal/ads/UserSettings;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setRelation_Lcom_appodeal_ads_UserSettings_Relation_;
#pragma warning disable 0169
		static Delegate GetSetRelation_Lcom_appodeal_ads_UserSettings_Relation_Handler ()
		{
			if (cb_setRelation_Lcom_appodeal_ads_UserSettings_Relation_ == null)
				cb_setRelation_Lcom_appodeal_ads_UserSettings_Relation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRelation_Lcom_appodeal_ads_UserSettings_Relation_);
			return cb_setRelation_Lcom_appodeal_ads_UserSettings_Relation_;
		}

		static IntPtr n_SetRelation_Lcom_appodeal_ads_UserSettings_Relation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Appodeal.Ads.UserSettings.Relation p0 = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Relation> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRelation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setRelation_Lcom_appodeal_ads_UserSettings_Relation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='setRelation' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.UserSettings.Relation']]"
		[Register ("setRelation", "(Lcom/appodeal/ads/UserSettings$Relation;)Lcom/appodeal/ads/UserSettings;", "GetSetRelation_Lcom_appodeal_ads_UserSettings_Relation_Handler")]
		public virtual unsafe global::Com.Appodeal.Ads.UserSettings SetRelation (global::Com.Appodeal.Ads.UserSettings.Relation p0)
		{
			if (id_setRelation_Lcom_appodeal_ads_UserSettings_Relation_ == IntPtr.Zero)
				id_setRelation_Lcom_appodeal_ads_UserSettings_Relation_ = JNIEnv.GetMethodID (class_ref, "setRelation", "(Lcom/appodeal/ads/UserSettings$Relation;)Lcom/appodeal/ads/UserSettings;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Appodeal.Ads.UserSettings __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallObjectMethod  (Handle, id_setRelation_Lcom_appodeal_ads_UserSettings_Relation_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRelation", "(Lcom/appodeal/ads/UserSettings$Relation;)Lcom/appodeal/ads/UserSettings;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setSmoking_Lcom_appodeal_ads_UserSettings_Smoking_;
#pragma warning disable 0169
		static Delegate GetSetSmoking_Lcom_appodeal_ads_UserSettings_Smoking_Handler ()
		{
			if (cb_setSmoking_Lcom_appodeal_ads_UserSettings_Smoking_ == null)
				cb_setSmoking_Lcom_appodeal_ads_UserSettings_Smoking_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetSmoking_Lcom_appodeal_ads_UserSettings_Smoking_);
			return cb_setSmoking_Lcom_appodeal_ads_UserSettings_Smoking_;
		}

		static IntPtr n_SetSmoking_Lcom_appodeal_ads_UserSettings_Smoking_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Appodeal.Ads.UserSettings.Smoking p0 = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings.Smoking> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSmoking (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setSmoking_Lcom_appodeal_ads_UserSettings_Smoking_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='setSmoking' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.UserSettings.Smoking']]"
		[Register ("setSmoking", "(Lcom/appodeal/ads/UserSettings$Smoking;)Lcom/appodeal/ads/UserSettings;", "GetSetSmoking_Lcom_appodeal_ads_UserSettings_Smoking_Handler")]
		public virtual unsafe global::Com.Appodeal.Ads.UserSettings SetSmoking (global::Com.Appodeal.Ads.UserSettings.Smoking p0)
		{
			if (id_setSmoking_Lcom_appodeal_ads_UserSettings_Smoking_ == IntPtr.Zero)
				id_setSmoking_Lcom_appodeal_ads_UserSettings_Smoking_ = JNIEnv.GetMethodID (class_ref, "setSmoking", "(Lcom/appodeal/ads/UserSettings$Smoking;)Lcom/appodeal/ads/UserSettings;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Appodeal.Ads.UserSettings __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallObjectMethod  (Handle, id_setSmoking_Lcom_appodeal_ads_UserSettings_Smoking_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSmoking", "(Lcom/appodeal/ads/UserSettings$Smoking;)Lcom/appodeal/ads/UserSettings;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setVkId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVkId_Ljava_lang_String_Handler ()
		{
			if (cb_setVkId_Ljava_lang_String_ == null)
				cb_setVkId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetVkId_Ljava_lang_String_);
			return cb_setVkId_Ljava_lang_String_;
		}

		static IntPtr n_SetVkId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetVkId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setVkId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='setVkId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setVkId", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings;", "GetSetVkId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Appodeal.Ads.UserSettings SetVkId (string p0)
		{
			if (id_setVkId_Ljava_lang_String_ == IntPtr.Zero)
				id_setVkId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setVkId", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Appodeal.Ads.UserSettings __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallObjectMethod  (Handle, id_setVkId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVkId", "(Ljava/lang/String;)Lcom/appodeal/ads/UserSettings;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_toMopubString;
#pragma warning disable 0169
		static Delegate GetToMopubStringHandler ()
		{
			if (cb_toMopubString == null)
				cb_toMopubString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToMopubString);
			return cb_toMopubString;
		}

		static IntPtr n_ToMopubString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.UserSettings __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.UserSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToMopubString ());
		}
#pragma warning restore 0169

		static IntPtr id_toMopubString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='UserSettings']/method[@name='toMopubString' and count(parameter)=0]"
		[Register ("toMopubString", "()Ljava/lang/String;", "GetToMopubStringHandler")]
		public virtual unsafe string ToMopubString ()
		{
			if (id_toMopubString == IntPtr.Zero)
				id_toMopubString = JNIEnv.GetMethodID (class_ref, "toMopubString", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toMopubString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toMopubString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
