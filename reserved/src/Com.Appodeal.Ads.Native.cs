using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']"
	[global::Android.Runtime.Register ("com/appodeal/ads/Native", DoNotGenerateAcw=true)]
	public partial class Native : global::Java.Lang.Object {


		static IntPtr c_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/field[@name='c']"
		[Register ("c")]
		public static bool C {
			get {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, c_jfieldId);
			}
			set {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, c_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr d_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/field[@name='d']"
		[Register ("d")]
		public static global::Com.Appodeal.Ads.INativeCallbacks D {
			get {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "Lcom/appodeal/ads/NativeCallbacks;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, d_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeCallbacks> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "Lcom/appodeal/ads/NativeCallbacks;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, d_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr f_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/field[@name='f']"
		[Register ("f")]
		public static long F {
			get {
				if (f_jfieldId == IntPtr.Zero)
					f_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "f", "J");
				return JNIEnv.GetStaticLongField (class_ref, f_jfieldId);
			}
			set {
				if (f_jfieldId == IntPtr.Zero)
					f_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "f", "J");
				try {
					JNIEnv.SetStaticField (class_ref, f_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr i_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/field[@name='i']"
		[Register ("i")]
		public static bool I {
			get {
				if (i_jfieldId == IntPtr.Zero)
					i_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "i", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, i_jfieldId);
			}
			set {
				if (i_jfieldId == IntPtr.Zero)
					i_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "i", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, i_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr k_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/field[@name='k']"
		[Register ("k")]
		public static int K {
			get {
				if (k_jfieldId == IntPtr.Zero)
					k_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "k", "I");
				return JNIEnv.GetStaticIntField (class_ref, k_jfieldId);
			}
			set {
				if (k_jfieldId == IntPtr.Zero)
					k_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "k", "I");
				try {
					JNIEnv.SetStaticField (class_ref, k_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr l_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/field[@name='l']"
		[Register ("l")]
		public static global::System.Collections.IList L {
			get {
				if (l_jfieldId == IntPtr.Zero)
					l_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "l", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, l_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr m_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/field[@name='m']"
		[Register ("m")]
		public static int M {
			get {
				if (m_jfieldId == IntPtr.Zero)
					m_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "m", "I");
				return JNIEnv.GetStaticIntField (class_ref, m_jfieldId);
			}
			set {
				if (m_jfieldId == IntPtr.Zero)
					m_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "m", "I");
				try {
					JNIEnv.SetStaticField (class_ref, m_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr n_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/field[@name='n']"
		[Register ("n")]
		public static bool N {
			get {
				if (n_jfieldId == IntPtr.Zero)
					n_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "n", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, n_jfieldId);
			}
			set {
				if (n_jfieldId == IntPtr.Zero)
					n_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "n", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, n_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr o_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/field[@name='o']"
		[Register ("o")]
		public static bool O {
			get {
				if (o_jfieldId == IntPtr.Zero)
					o_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "o", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, o_jfieldId);
			}
			set {
				if (o_jfieldId == IntPtr.Zero)
					o_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "o", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, o_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr p_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/field[@name='p']"
		[Register ("p")]
		public static int P {
			get {
				if (p_jfieldId == IntPtr.Zero)
					p_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "p", "I");
				return JNIEnv.GetStaticIntField (class_ref, p_jfieldId);
			}
			set {
				if (p_jfieldId == IntPtr.Zero)
					p_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "p", "I");
				try {
					JNIEnv.SetStaticField (class_ref, p_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr q_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/field[@name='q']"
		[Register ("q")]
		public static int Q {
			get {
				if (q_jfieldId == IntPtr.Zero)
					q_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "q", "I");
				return JNIEnv.GetStaticIntField (class_ref, q_jfieldId);
			}
			set {
				if (q_jfieldId == IntPtr.Zero)
					q_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "q", "I");
				try {
					JNIEnv.SetStaticField (class_ref, q_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr s_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/field[@name='s']"
		[Register ("s")]
		public static bool S {
			get {
				if (s_jfieldId == IntPtr.Zero)
					s_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "s", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, s_jfieldId);
			}
			set {
				if (s_jfieldId == IntPtr.Zero)
					s_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "s", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, s_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr w_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/field[@name='w']"
		[Register ("w")]
		public static int W {
			get {
				if (w_jfieldId == IntPtr.Zero)
					w_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "w", "I");
				return JNIEnv.GetStaticIntField (class_ref, w_jfieldId);
			}
			set {
				if (w_jfieldId == IntPtr.Zero)
					w_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "w", "I");
				try {
					JNIEnv.SetStaticField (class_ref, w_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr x_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/field[@name='x']"
		[Register ("x")]
		public static bool X {
			get {
				if (x_jfieldId == IntPtr.Zero)
					x_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "x", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, x_jfieldId);
			}
			set {
				if (x_jfieldId == IntPtr.Zero)
					x_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "x", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, x_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native.NativeAdType']"
		[global::Android.Runtime.Register ("com/appodeal/ads/Native$NativeAdType", DoNotGenerateAcw=true)]
		public sealed partial class NativeAdType : global::Java.Lang.Enum {


			static IntPtr Auto_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native.NativeAdType']/field[@name='Auto']"
			[Register ("Auto")]
			public static global::Com.Appodeal.Ads.Native.NativeAdType Auto {
				get {
					if (Auto_jfieldId == IntPtr.Zero)
						Auto_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Auto", "Lcom/appodeal/ads/Native$NativeAdType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Auto_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Native.NativeAdType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NoVideo_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native.NativeAdType']/field[@name='NoVideo']"
			[Register ("NoVideo")]
			public static global::Com.Appodeal.Ads.Native.NativeAdType NoVideo {
				get {
					if (NoVideo_jfieldId == IntPtr.Zero)
						NoVideo_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NoVideo", "Lcom/appodeal/ads/Native$NativeAdType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NoVideo_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Native.NativeAdType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Video_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native.NativeAdType']/field[@name='Video']"
			[Register ("Video")]
			public static global::Com.Appodeal.Ads.Native.NativeAdType Video {
				get {
					if (Video_jfieldId == IntPtr.Zero)
						Video_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Video", "Lcom/appodeal/ads/Native$NativeAdType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Video_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Native.NativeAdType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/appodeal/ads/Native$NativeAdType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NativeAdType); }
			}

			internal NativeAdType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native.NativeAdType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/appodeal/ads/Native$NativeAdType;", "")]
			public static unsafe global::Com.Appodeal.Ads.Native.NativeAdType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/appodeal/ads/Native$NativeAdType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Appodeal.Ads.Native.NativeAdType __ret = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Native.NativeAdType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native.NativeAdType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/appodeal/ads/Native$NativeAdType;", "")]
			public static unsafe global::Com.Appodeal.Ads.Native.NativeAdType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/appodeal/ads/Native$NativeAdType;");
				try {
					return (global::Com.Appodeal.Ads.Native.NativeAdType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Appodeal.Ads.Native.NativeAdType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/appodeal/ads/Native", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Native); }
		}

		protected Native (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Class_ZarrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/method[@name='a' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String...']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Class;Z[Ljava/lang/String;)V", "")]
		public static unsafe void A (global::Android.Content.Context p0, string p1, global::Java.Lang.Class p2, bool p3, params  string[] p4)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Class_ZarrayLjava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Class_ZarrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Class;Z[Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Class_ZarrayLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

		static IntPtr id_a_IZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/method[@name='a' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='int']]"
		[Register ("a", "(IZI)V", "")]
		public static unsafe void A (int p0, bool p1, int p2)
		{
			if (id_a_IZI == IntPtr.Zero)
				id_a_IZI = JNIEnv.GetStaticMethodID (class_ref, "a", "(IZI)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_IZI, __args);
			} finally {
			}
		}

		static IntPtr id_b_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("b", "(Landroid/content/Context;)Landroid/widget/ImageView;", "")]
		public static unsafe global::Android.Widget.ImageView B (global::Android.Content.Context p0)
		{
			if (id_b_Landroid_content_Context_ == IntPtr.Zero)
				id_b_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/content/Context;)Landroid/widget/ImageView;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Widget.ImageView __ret = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
