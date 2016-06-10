using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Mraid {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDView']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/mraid/MRAIDView", DoNotGenerateAcw=true)]
	public partial class MRAIDView : global::Android.Widget.RelativeLayout {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDView']/field[@name='STATE_DEFAULT']"
		[Register ("STATE_DEFAULT")]
		public const int StateDefault = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDView']/field[@name='STATE_EXPANDED']"
		[Register ("STATE_EXPANDED")]
		public const int StateExpanded = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDView']/field[@name='STATE_HIDDEN']"
		[Register ("STATE_HIDDEN")]
		public const int StateHidden = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDView']/field[@name='STATE_LOADING']"
		[Register ("STATE_LOADING")]
		public const int StateLoading = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDView']/field[@name='STATE_RESIZED']"
		[Register ("STATE_RESIZED")]
		public const int StateResized = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDView']/field[@name='VERSION']"
		[Register ("VERSION")]
		public const string Version = (string) "1.1.1";
		// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDView.MRAIDWebChromeClient']"
		[global::Android.Runtime.Register ("org/nexage/sourcekit/mraid/MRAIDView$MRAIDWebChromeClient", DoNotGenerateAcw=true)]
		public partial class MRAIDWebChromeClient : global::Android.Webkit.WebChromeClient {

			protected MRAIDWebChromeClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDView.MRAIDWebViewClient']"
		[global::Android.Runtime.Register ("org/nexage/sourcekit/mraid/MRAIDView$MRAIDWebViewClient", DoNotGenerateAcw=true)]
		public partial class MRAIDWebViewClient : global::Android.Webkit.WebViewClient {

			protected MRAIDWebViewClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDView.Size']"
		[global::Android.Runtime.Register ("org/nexage/sourcekit/mraid/MRAIDView$Size", DoNotGenerateAcw=true)]
		public sealed partial class Size : global::Java.Lang.Object {


			static IntPtr height_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDView.Size']/field[@name='height']"
			[Register ("height")]
			public int Height {
				get {
					if (height_jfieldId == IntPtr.Zero)
						height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
					return JNIEnv.GetIntField (Handle, height_jfieldId);
				}
				set {
					if (height_jfieldId == IntPtr.Zero)
						height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
					try {
						JNIEnv.SetField (Handle, height_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr width_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDView.Size']/field[@name='width']"
			[Register ("width")]
			public int Width {
				get {
					if (width_jfieldId == IntPtr.Zero)
						width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
					return JNIEnv.GetIntField (Handle, width_jfieldId);
				}
				set {
					if (width_jfieldId == IntPtr.Zero)
						width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
					try {
						JNIEnv.SetField (Handle, width_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/nexage/sourcekit/mraid/MRAIDView$Size", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Size); }
			}

			internal Size (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/mraid/MRAIDView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MRAIDView); }
		}

		protected MRAIDView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lorg_nexage_sourcekit_mraid_MRAIDViewListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_ZIILorg_nexage_sourcekit_mraid_rtb_RtbInfo_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDView']/constructor[@name='MRAIDView' and count(parameter)=10 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='org.nexage.sourcekit.mraid.MRAIDViewListener'] and parameter[6][@type='org.nexage.sourcekit.mraid.MRAIDNativeFeatureListener'] and parameter[7][@type='boolean'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='org.nexage.sourcekit.mraid.rtb.RtbInfo']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Lorg/nexage/sourcekit/mraid/MRAIDViewListener;Lorg/nexage/sourcekit/mraid/MRAIDNativeFeatureListener;ZIILorg/nexage/sourcekit/mraid/rtb/RtbInfo;)V", "")]
		public unsafe MRAIDView (global::Android.Content.Context p0, string p1, string p2, string[] p3, global::Org.Nexage.Sourcekit.Mraid.IMRAIDViewListener p4, global::Org.Nexage.Sourcekit.Mraid.IMRAIDNativeFeatureListener p5, bool p6, int p7, int p8, global::Org.Nexage.Sourcekit.Mraid.Rtb.RtbInfo p9)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				if (GetType () != typeof (MRAIDView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Lorg/nexage/sourcekit/mraid/MRAIDViewListener;Lorg/nexage/sourcekit/mraid/MRAIDNativeFeatureListener;ZIILorg/nexage/sourcekit/mraid/rtb/RtbInfo;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Lorg/nexage/sourcekit/mraid/MRAIDViewListener;Lorg/nexage/sourcekit/mraid/MRAIDNativeFeatureListener;ZIILorg/nexage/sourcekit/mraid/rtb/RtbInfo;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lorg_nexage_sourcekit_mraid_MRAIDViewListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_ZIILorg_nexage_sourcekit_mraid_rtb_RtbInfo_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lorg_nexage_sourcekit_mraid_MRAIDViewListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_ZIILorg_nexage_sourcekit_mraid_rtb_RtbInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Lorg/nexage/sourcekit/mraid/MRAIDViewListener;Lorg/nexage/sourcekit/mraid/MRAIDNativeFeatureListener;ZIILorg/nexage/sourcekit/mraid/rtb/RtbInfo;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lorg_nexage_sourcekit_mraid_MRAIDViewListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_ZIILorg_nexage_sourcekit_mraid_rtb_RtbInfo_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lorg_nexage_sourcekit_mraid_MRAIDViewListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_ZIILorg_nexage_sourcekit_mraid_rtb_RtbInfo_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lorg_nexage_sourcekit_mraid_MRAIDViewListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_ZII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDView']/constructor[@name='MRAIDView' and count(parameter)=9 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='org.nexage.sourcekit.mraid.MRAIDViewListener'] and parameter[6][@type='org.nexage.sourcekit.mraid.MRAIDNativeFeatureListener'] and parameter[7][@type='boolean'] and parameter[8][@type='int'] and parameter[9][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Lorg/nexage/sourcekit/mraid/MRAIDViewListener;Lorg/nexage/sourcekit/mraid/MRAIDNativeFeatureListener;ZII)V", "")]
		public unsafe MRAIDView (global::Android.Content.Context p0, string p1, string p2, string[] p3, global::Org.Nexage.Sourcekit.Mraid.IMRAIDViewListener p4, global::Org.Nexage.Sourcekit.Mraid.IMRAIDNativeFeatureListener p5, bool p6, int p7, int p8)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				if (GetType () != typeof (MRAIDView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Lorg/nexage/sourcekit/mraid/MRAIDViewListener;Lorg/nexage/sourcekit/mraid/MRAIDNativeFeatureListener;ZII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Lorg/nexage/sourcekit/mraid/MRAIDViewListener;Lorg/nexage/sourcekit/mraid/MRAIDNativeFeatureListener;ZII)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lorg_nexage_sourcekit_mraid_MRAIDViewListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_ZII == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lorg_nexage_sourcekit_mraid_MRAIDViewListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_ZII = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Lorg/nexage/sourcekit/mraid/MRAIDViewListener;Lorg/nexage/sourcekit/mraid/MRAIDNativeFeatureListener;ZII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lorg_nexage_sourcekit_mraid_MRAIDViewListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_ZII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lorg_nexage_sourcekit_mraid_MRAIDViewListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_ZII, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lorg_nexage_sourcekit_mraid_MRAIDViewListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_IILorg_nexage_sourcekit_mraid_rtb_RtbInfo_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDView']/constructor[@name='MRAIDView' and count(parameter)=9 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='org.nexage.sourcekit.mraid.MRAIDViewListener'] and parameter[6][@type='org.nexage.sourcekit.mraid.MRAIDNativeFeatureListener'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='org.nexage.sourcekit.mraid.rtb.RtbInfo']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Lorg/nexage/sourcekit/mraid/MRAIDViewListener;Lorg/nexage/sourcekit/mraid/MRAIDNativeFeatureListener;IILorg/nexage/sourcekit/mraid/rtb/RtbInfo;)V", "")]
		public unsafe MRAIDView (global::Android.Content.Context p0, string p1, string p2, string[] p3, global::Org.Nexage.Sourcekit.Mraid.IMRAIDViewListener p4, global::Org.Nexage.Sourcekit.Mraid.IMRAIDNativeFeatureListener p5, int p6, int p7, global::Org.Nexage.Sourcekit.Mraid.Rtb.RtbInfo p8)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				if (GetType () != typeof (MRAIDView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Lorg/nexage/sourcekit/mraid/MRAIDViewListener;Lorg/nexage/sourcekit/mraid/MRAIDNativeFeatureListener;IILorg/nexage/sourcekit/mraid/rtb/RtbInfo;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Lorg/nexage/sourcekit/mraid/MRAIDViewListener;Lorg/nexage/sourcekit/mraid/MRAIDNativeFeatureListener;IILorg/nexage/sourcekit/mraid/rtb/RtbInfo;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lorg_nexage_sourcekit_mraid_MRAIDViewListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_IILorg_nexage_sourcekit_mraid_rtb_RtbInfo_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lorg_nexage_sourcekit_mraid_MRAIDViewListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_IILorg_nexage_sourcekit_mraid_rtb_RtbInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Lorg/nexage/sourcekit/mraid/MRAIDViewListener;Lorg/nexage/sourcekit/mraid/MRAIDNativeFeatureListener;IILorg/nexage/sourcekit/mraid/rtb/RtbInfo;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lorg_nexage_sourcekit_mraid_MRAIDViewListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_IILorg_nexage_sourcekit_mraid_rtb_RtbInfo_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lorg_nexage_sourcekit_mraid_MRAIDViewListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_IILorg_nexage_sourcekit_mraid_rtb_RtbInfo_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lorg_nexage_sourcekit_mraid_MRAIDViewListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDView']/constructor[@name='MRAIDView' and count(parameter)=8 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='org.nexage.sourcekit.mraid.MRAIDViewListener'] and parameter[6][@type='org.nexage.sourcekit.mraid.MRAIDNativeFeatureListener'] and parameter[7][@type='int'] and parameter[8][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Lorg/nexage/sourcekit/mraid/MRAIDViewListener;Lorg/nexage/sourcekit/mraid/MRAIDNativeFeatureListener;II)V", "")]
		public unsafe MRAIDView (global::Android.Content.Context p0, string p1, string p2, string[] p3, global::Org.Nexage.Sourcekit.Mraid.IMRAIDViewListener p4, global::Org.Nexage.Sourcekit.Mraid.IMRAIDNativeFeatureListener p5, int p6, int p7)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				if (GetType () != typeof (MRAIDView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Lorg/nexage/sourcekit/mraid/MRAIDViewListener;Lorg/nexage/sourcekit/mraid/MRAIDNativeFeatureListener;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Lorg/nexage/sourcekit/mraid/MRAIDViewListener;Lorg/nexage/sourcekit/mraid/MRAIDNativeFeatureListener;II)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lorg_nexage_sourcekit_mraid_MRAIDViewListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_II == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lorg_nexage_sourcekit_mraid_MRAIDViewListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Lorg/nexage/sourcekit/mraid/MRAIDViewListener;Lorg/nexage/sourcekit/mraid/MRAIDNativeFeatureListener;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lorg_nexage_sourcekit_mraid_MRAIDViewListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lorg_nexage_sourcekit_mraid_MRAIDViewListener_Lorg_nexage_sourcekit_mraid_MRAIDNativeFeatureListener_II, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetState);
			return cb_getState;
		}

		static int n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Mraid.MRAIDView __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.MRAIDView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.State;
		}
#pragma warning restore 0169

		static IntPtr id_getState;
		public virtual unsafe int State {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDView']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()I", "GetGetStateHandler")]
			get {
				if (id_getState == IntPtr.Zero)
					id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getState);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getState", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_clearView;
#pragma warning disable 0169
		static Delegate GetClearViewHandler ()
		{
			if (cb_clearView == null)
				cb_clearView = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearView);
			return cb_clearView;
		}

		static void n_ClearView (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Mraid.MRAIDView __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.MRAIDView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearView ();
		}
#pragma warning restore 0169

		static IntPtr id_clearView;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDView']/method[@name='clearView' and count(parameter)=0]"
		[Register ("clearView", "()V", "GetClearViewHandler")]
		public virtual unsafe void ClearView ()
		{
			if (id_clearView == IntPtr.Zero)
				id_clearView = JNIEnv.GetMethodID (class_ref, "clearView", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearView);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearView", "()V"));
			} finally {
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Mraid.MRAIDView __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.MRAIDView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDView']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_destroy);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroy", "()V"));
			} finally {
			}
		}

		static Delegate cb_onConfigurationChanged_Landroid_content_res_Configuration_;
#pragma warning disable 0169
		static Delegate GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler ()
		{
			if (cb_onConfigurationChanged_Landroid_content_res_Configuration_ == null)
				cb_onConfigurationChanged_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConfigurationChanged_Landroid_content_res_Configuration_);
			return cb_onConfigurationChanged_Landroid_content_res_Configuration_;
		}

		static void n_OnConfigurationChanged_Landroid_content_res_Configuration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Mraid.MRAIDView __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.MRAIDView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.Configuration p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Configuration> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConfigurationChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConfigurationChanged_Landroid_content_res_Configuration_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDView']/method[@name='onConfigurationChanged' and count(parameter)=1 and parameter[1][@type='android.content.res.Configuration']]"
		[Register ("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", "GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler")]
		public virtual unsafe void OnConfigurationChanged (global::Android.Content.Res.Configuration p0)
		{
			if (id_onConfigurationChanged_Landroid_content_res_Configuration_ == IntPtr.Zero)
				id_onConfigurationChanged_Landroid_content_res_Configuration_ = JNIEnv.GetMethodID (class_ref, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onConfigurationChanged_Landroid_content_res_Configuration_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_showAsInterstitial_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetShowAsInterstitial_Landroid_app_Activity_Handler ()
		{
			if (cb_showAsInterstitial_Landroid_app_Activity_ == null)
				cb_showAsInterstitial_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowAsInterstitial_Landroid_app_Activity_);
			return cb_showAsInterstitial_Landroid_app_Activity_;
		}

		static void n_ShowAsInterstitial_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Mraid.MRAIDView __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Mraid.MRAIDView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShowAsInterstitial (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showAsInterstitial_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.mraid']/class[@name='MRAIDView']/method[@name='showAsInterstitial' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("showAsInterstitial", "(Landroid/app/Activity;)V", "GetShowAsInterstitial_Landroid_app_Activity_Handler")]
		protected virtual unsafe void ShowAsInterstitial (global::Android.App.Activity p0)
		{
			if (id_showAsInterstitial_Landroid_app_Activity_ == IntPtr.Zero)
				id_showAsInterstitial_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "showAsInterstitial", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_showAsInterstitial_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showAsInterstitial", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

	}
}
