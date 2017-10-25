using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']"
	[global::Android.Runtime.Register ("com/appodeal/ads/Native", DoNotGenerateAcw=true)]
	public partial class Native : global::Java.Lang.Object {


		static IntPtr B_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/field[@name='B']"
		[Register ("B")]
		public static global::Com.Appodeal.Ads.Native.NativeAdType B {
			get {
				if (B_jfieldId == IntPtr.Zero)
					B_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "B", "Lcom/appodeal/ads/Native$NativeAdType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, B_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Native.NativeAdType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (B_jfieldId == IntPtr.Zero)
					B_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "B", "Lcom/appodeal/ads/Native$NativeAdType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, B_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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

		static IntPtr e_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/field[@name='e']"
		[Register ("e")]
		public static global::Com.Appodeal.Ads.INativeCallbacksInternal E {
			get {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "e", "Lcom/appodeal/ads/NativeCallbacksInternal;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, e_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeCallbacksInternal> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "e", "Lcom/appodeal/ads/NativeCallbacksInternal;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, e_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr g_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/field[@name='g']"
		[Register ("g")]
		public static long G {
			get {
				if (g_jfieldId == IntPtr.Zero)
					g_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "g", "J");
				return JNIEnv.GetStaticLongField (class_ref, g_jfieldId);
			}
			set {
				if (g_jfieldId == IntPtr.Zero)
					g_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "g", "J");
				try {
					JNIEnv.SetStaticField (class_ref, g_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr j_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/field[@name='j']"
		[Register ("j")]
		public static bool J {
			get {
				if (j_jfieldId == IntPtr.Zero)
					j_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, j_jfieldId);
			}
			set {
				if (j_jfieldId == IntPtr.Zero)
					j_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, j_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr l_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/field[@name='l']"
		[Register ("l")]
		public static int L {
			get {
				if (l_jfieldId == IntPtr.Zero)
					l_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "l", "I");
				return JNIEnv.GetStaticIntField (class_ref, l_jfieldId);
			}
			set {
				if (l_jfieldId == IntPtr.Zero)
					l_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "l", "I");
				try {
					JNIEnv.SetStaticField (class_ref, l_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/field[@name='m']"
		[Register ("m")]
		public static global::System.Collections.IList M {
			get {
				if (m_jfieldId == IntPtr.Zero)
					m_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "m", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, m_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr n_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/field[@name='n']"
		[Register ("n")]
		public static int N {
			get {
				if (n_jfieldId == IntPtr.Zero)
					n_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "n", "I");
				return JNIEnv.GetStaticIntField (class_ref, n_jfieldId);
			}
			set {
				if (n_jfieldId == IntPtr.Zero)
					n_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "n", "I");
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
		public static bool P {
			get {
				if (p_jfieldId == IntPtr.Zero)
					p_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "p", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, p_jfieldId);
			}
			set {
				if (p_jfieldId == IntPtr.Zero)
					p_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "p", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, p_jfieldId, value);
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
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
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

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
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

		static IntPtr id_a_ILjava_lang_Double_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/method[@name='a' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Double']]"
		[Register ("a", "(ILjava/lang/Double;)V", "")]
		public static unsafe void A (int p0, global::Java.Lang.Double p1)
		{
			if (id_a_ILjava_lang_Double_ == IntPtr.Zero)
				id_a_ILjava_lang_Double_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(ILjava/lang/Double;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_ILjava_lang_Double_, __args);
			} finally {
			}
		}

		static IntPtr id_c_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='Native']/method[@name='c' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("c", "(Landroid/content/Context;)Landroid/widget/ImageView;", "")]
		public static unsafe global::Android.Widget.ImageView C (global::Android.Content.Context p0)
		{
			if (id_c_Landroid_content_Context_ == IntPtr.Zero)
				id_c_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Landroid/content/Context;)Landroid/widget/ImageView;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Widget.ImageView __ret = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_c_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
