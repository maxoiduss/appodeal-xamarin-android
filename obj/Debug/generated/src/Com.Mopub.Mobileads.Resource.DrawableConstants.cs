using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Resource {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/resource/DrawableConstants", DoNotGenerateAcw=true)]
	public partial class DrawableConstants : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.BlurredLastVideoFrame']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/resource/DrawableConstants$BlurredLastVideoFrame", DoNotGenerateAcw=true)]
		public partial class BlurredLastVideoFrame : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.BlurredLastVideoFrame']/field[@name='ALPHA']"
			[Register ("ALPHA")]
			public const int Alpha = (int) 128;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/resource/DrawableConstants$BlurredLastVideoFrame", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BlurredLastVideoFrame); }
			}

			protected BlurredLastVideoFrame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.BlurredLastVideoFrame']/constructor[@name='DrawableConstants.BlurredLastVideoFrame' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe BlurredLastVideoFrame ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (BlurredLastVideoFrame)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CloseButton']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/resource/DrawableConstants$CloseButton", DoNotGenerateAcw=true)]
		public partial class CloseButton : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CloseButton']/field[@name='DEFAULT_CLOSE_BUTTON_TEXT']"
			[Register ("DEFAULT_CLOSE_BUTTON_TEXT")]
			public const string DefaultCloseButtonText = (string) "";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CloseButton']/field[@name='EDGE_PADDING']"
			[Register ("EDGE_PADDING")]
			public const int EdgePadding = (int) 16;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CloseButton']/field[@name='IMAGE_PADDING_DIPS']"
			[Register ("IMAGE_PADDING_DIPS")]
			public const int ImagePaddingDips = (int) 5;

			static IntPtr STROKE_CAP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CloseButton']/field[@name='STROKE_CAP']"
			[Register ("STROKE_CAP")]
			public static global::Android.Graphics.Paint.Cap StrokeCap {
				get {
					if (STROKE_CAP_jfieldId == IntPtr.Zero)
						STROKE_CAP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STROKE_CAP", "Landroid/graphics/Paint$Cap;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STROKE_CAP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Cap> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CloseButton']/field[@name='STROKE_COLOR']"
			[Register ("STROKE_COLOR")]
			public const int StrokeColor = (int) -1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CloseButton']/field[@name='STROKE_WIDTH']"
			[Register ("STROKE_WIDTH")]
			public const float StrokeWidth = (float) 8.000000;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CloseButton']/field[@name='TEXT_COLOR']"
			[Register ("TEXT_COLOR")]
			public const int TextColor = (int) -1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CloseButton']/field[@name='TEXT_RIGHT_MARGIN_DIPS']"
			[Register ("TEXT_RIGHT_MARGIN_DIPS")]
			public const int TextRightMarginDips = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CloseButton']/field[@name='TEXT_SIZE_SP']"
			[Register ("TEXT_SIZE_SP")]
			public const float TextSizeSp = (float) 20.000000;

			static IntPtr TEXT_TYPEFACE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CloseButton']/field[@name='TEXT_TYPEFACE']"
			[Register ("TEXT_TYPEFACE")]
			public static global::Android.Graphics.Typeface TextTypeface {
				get {
					if (TEXT_TYPEFACE_jfieldId == IntPtr.Zero)
						TEXT_TYPEFACE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT_TYPEFACE", "Landroid/graphics/Typeface;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXT_TYPEFACE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CloseButton']/field[@name='WIDGET_HEIGHT_DIPS']"
			[Register ("WIDGET_HEIGHT_DIPS")]
			public const int WidgetHeightDips = (int) 46;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/resource/DrawableConstants$CloseButton", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CloseButton); }
			}

			protected CloseButton (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CloseButton']/constructor[@name='DrawableConstants.CloseButton' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe CloseButton ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (CloseButton)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CtaButton']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/resource/DrawableConstants$CtaButton", DoNotGenerateAcw=true)]
		public partial class CtaButton : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CtaButton']/field[@name='BACKGROUND_ALPHA']"
			[Register ("BACKGROUND_ALPHA")]
			public const int BackgroundAlpha = (int) 51;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CtaButton']/field[@name='BACKGROUND_COLOR']"
			[Register ("BACKGROUND_COLOR")]
			public const int BackgroundColor = (int) -16777216;

			static IntPtr BACKGROUND_STYLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CtaButton']/field[@name='BACKGROUND_STYLE']"
			[Register ("BACKGROUND_STYLE")]
			public static global::Android.Graphics.Paint.Style BackgroundStyle {
				get {
					if (BACKGROUND_STYLE_jfieldId == IntPtr.Zero)
						BACKGROUND_STYLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BACKGROUND_STYLE", "Landroid/graphics/Paint$Style;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BACKGROUND_STYLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Style> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CtaButton']/field[@name='CORNER_RADIUS_DIPS']"
			[Register ("CORNER_RADIUS_DIPS")]
			public const int CornerRadiusDips = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CtaButton']/field[@name='DEFAULT_CTA_TEXT']"
			[Register ("DEFAULT_CTA_TEXT")]
			public const string DefaultCtaText = (string) "Learn More";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CtaButton']/field[@name='HEIGHT_DIPS']"
			[Register ("HEIGHT_DIPS")]
			public const int HeightDips = (int) 42;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CtaButton']/field[@name='MARGIN_DIPS']"
			[Register ("MARGIN_DIPS")]
			public const int MarginDips = (int) 16;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CtaButton']/field[@name='OUTLINE_ALPHA']"
			[Register ("OUTLINE_ALPHA")]
			public const int OutlineAlpha = (int) 51;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CtaButton']/field[@name='OUTLINE_COLOR']"
			[Register ("OUTLINE_COLOR")]
			public const int OutlineColor = (int) -1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CtaButton']/field[@name='OUTLINE_STROKE_WIDTH_DIPS']"
			[Register ("OUTLINE_STROKE_WIDTH_DIPS")]
			public const int OutlineStrokeWidthDips = (int) 2;

			static IntPtr OUTLINE_STYLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CtaButton']/field[@name='OUTLINE_STYLE']"
			[Register ("OUTLINE_STYLE")]
			public static global::Android.Graphics.Paint.Style OutlineStyle {
				get {
					if (OUTLINE_STYLE_jfieldId == IntPtr.Zero)
						OUTLINE_STYLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OUTLINE_STYLE", "Landroid/graphics/Paint$Style;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OUTLINE_STYLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Style> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TEXT_ALIGN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CtaButton']/field[@name='TEXT_ALIGN']"
			[Register ("TEXT_ALIGN")]
			public static global::Android.Graphics.Paint.Align TextAlign {
				get {
					if (TEXT_ALIGN_jfieldId == IntPtr.Zero)
						TEXT_ALIGN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT_ALIGN", "Landroid/graphics/Paint$Align;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXT_ALIGN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Align> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CtaButton']/field[@name='TEXT_COLOR']"
			[Register ("TEXT_COLOR")]
			public const int TextColor = (int) -1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CtaButton']/field[@name='TEXT_SIZE_SP']"
			[Register ("TEXT_SIZE_SP")]
			public const float TextSizeSp = (float) 20.000000;

			static IntPtr TEXT_TYPEFACE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CtaButton']/field[@name='TEXT_TYPEFACE']"
			[Register ("TEXT_TYPEFACE")]
			public static global::Android.Graphics.Typeface TextTypeface {
				get {
					if (TEXT_TYPEFACE_jfieldId == IntPtr.Zero)
						TEXT_TYPEFACE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT_TYPEFACE", "Landroid/graphics/Typeface;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXT_TYPEFACE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CtaButton']/field[@name='WIDTH_DIPS']"
			[Register ("WIDTH_DIPS")]
			public const int WidthDips = (int) 200;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/resource/DrawableConstants$CtaButton", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CtaButton); }
			}

			protected CtaButton (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.CtaButton']/constructor[@name='DrawableConstants.CtaButton' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe CtaButton ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (CtaButton)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.GradientStrip']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/resource/DrawableConstants$GradientStrip", DoNotGenerateAcw=true)]
		public partial class GradientStrip : global::Java.Lang.Object {


			static IntPtr END_COLOR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.GradientStrip']/field[@name='END_COLOR']"
			[Register ("END_COLOR")]
			public static int EndColor {
				get {
					if (END_COLOR_jfieldId == IntPtr.Zero)
						END_COLOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "END_COLOR", "I");
					return JNIEnv.GetStaticIntField (class_ref, END_COLOR_jfieldId);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.GradientStrip']/field[@name='GRADIENT_STRIP_HEIGHT_DIPS']"
			[Register ("GRADIENT_STRIP_HEIGHT_DIPS")]
			public const int GradientStripHeightDips = (int) 72;

			static IntPtr START_COLOR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.GradientStrip']/field[@name='START_COLOR']"
			[Register ("START_COLOR")]
			public static int StartColor {
				get {
					if (START_COLOR_jfieldId == IntPtr.Zero)
						START_COLOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "START_COLOR", "I");
					return JNIEnv.GetStaticIntField (class_ref, START_COLOR_jfieldId);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/resource/DrawableConstants$GradientStrip", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GradientStrip); }
			}

			protected GradientStrip (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.GradientStrip']/constructor[@name='DrawableConstants.GradientStrip' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe GradientStrip ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (GradientStrip)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.ProgressBar']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/resource/DrawableConstants$ProgressBar", DoNotGenerateAcw=true)]
		public partial class ProgressBar : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.ProgressBar']/field[@name='BACKGROUND_ALPHA']"
			[Register ("BACKGROUND_ALPHA")]
			public const int BackgroundAlpha = (int) 128;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.ProgressBar']/field[@name='BACKGROUND_COLOR']"
			[Register ("BACKGROUND_COLOR")]
			public const int BackgroundColor = (int) -1;

			static IntPtr BACKGROUND_STYLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.ProgressBar']/field[@name='BACKGROUND_STYLE']"
			[Register ("BACKGROUND_STYLE")]
			public static global::Android.Graphics.Paint.Style BackgroundStyle {
				get {
					if (BACKGROUND_STYLE_jfieldId == IntPtr.Zero)
						BACKGROUND_STYLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BACKGROUND_STYLE", "Landroid/graphics/Paint$Style;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BACKGROUND_STYLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Style> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.ProgressBar']/field[@name='HEIGHT_DIPS']"
			[Register ("HEIGHT_DIPS")]
			public const int HeightDips = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.ProgressBar']/field[@name='NUGGET_WIDTH_DIPS']"
			[Register ("NUGGET_WIDTH_DIPS")]
			public const int NuggetWidthDips = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.ProgressBar']/field[@name='PROGRESS_ALPHA']"
			[Register ("PROGRESS_ALPHA")]
			public const int ProgressAlpha = (int) 255;

			static IntPtr PROGRESS_COLOR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.ProgressBar']/field[@name='PROGRESS_COLOR']"
			[Register ("PROGRESS_COLOR")]
			public static int ProgressColor {
				get {
					if (PROGRESS_COLOR_jfieldId == IntPtr.Zero)
						PROGRESS_COLOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROGRESS_COLOR", "I");
					return JNIEnv.GetStaticIntField (class_ref, PROGRESS_COLOR_jfieldId);
				}
			}

			static IntPtr PROGRESS_STYLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.ProgressBar']/field[@name='PROGRESS_STYLE']"
			[Register ("PROGRESS_STYLE")]
			public static global::Android.Graphics.Paint.Style ProgressStyle {
				get {
					if (PROGRESS_STYLE_jfieldId == IntPtr.Zero)
						PROGRESS_STYLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROGRESS_STYLE", "Landroid/graphics/Paint$Style;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROGRESS_STYLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Style> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/resource/DrawableConstants$ProgressBar", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ProgressBar); }
			}

			protected ProgressBar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.ProgressBar']/constructor[@name='DrawableConstants.ProgressBar' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ProgressBar ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (ProgressBar)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.RadialCountdown']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/resource/DrawableConstants$RadialCountdown", DoNotGenerateAcw=true)]
		public partial class RadialCountdown : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.RadialCountdown']/field[@name='BACKGROUND_ALPHA']"
			[Register ("BACKGROUND_ALPHA")]
			public const int BackgroundAlpha = (int) 128;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.RadialCountdown']/field[@name='BACKGROUND_COLOR']"
			[Register ("BACKGROUND_COLOR")]
			public const int BackgroundColor = (int) -1;

			static IntPtr BACKGROUND_STYLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.RadialCountdown']/field[@name='BACKGROUND_STYLE']"
			[Register ("BACKGROUND_STYLE")]
			public static global::Android.Graphics.Paint.Style BackgroundStyle {
				get {
					if (BACKGROUND_STYLE_jfieldId == IntPtr.Zero)
						BACKGROUND_STYLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BACKGROUND_STYLE", "Landroid/graphics/Paint$Style;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BACKGROUND_STYLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Style> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.RadialCountdown']/field[@name='CIRCLE_STROKE_WIDTH_DIPS']"
			[Register ("CIRCLE_STROKE_WIDTH_DIPS")]
			public const int CircleStrokeWidthDips = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.RadialCountdown']/field[@name='PADDING_DIPS']"
			[Register ("PADDING_DIPS")]
			public const int PaddingDips = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.RadialCountdown']/field[@name='PROGRESS_ALPHA']"
			[Register ("PROGRESS_ALPHA")]
			public const int ProgressAlpha = (int) 255;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.RadialCountdown']/field[@name='PROGRESS_COLOR']"
			[Register ("PROGRESS_COLOR")]
			public const int ProgressColor = (int) -1;

			static IntPtr PROGRESS_STYLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.RadialCountdown']/field[@name='PROGRESS_STYLE']"
			[Register ("PROGRESS_STYLE")]
			public static global::Android.Graphics.Paint.Style ProgressStyle {
				get {
					if (PROGRESS_STYLE_jfieldId == IntPtr.Zero)
						PROGRESS_STYLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROGRESS_STYLE", "Landroid/graphics/Paint$Style;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROGRESS_STYLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Style> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.RadialCountdown']/field[@name='RIGHT_MARGIN_DIPS']"
			[Register ("RIGHT_MARGIN_DIPS")]
			public const int RightMarginDips = (int) 16;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.RadialCountdown']/field[@name='SIDE_LENGTH_DIPS']"
			[Register ("SIDE_LENGTH_DIPS")]
			public const int SideLengthDips = (int) 45;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.RadialCountdown']/field[@name='START_ANGLE']"
			[Register ("START_ANGLE")]
			public const float StartAngle = (float) -90.000000;

			static IntPtr TEXT_ALIGN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.RadialCountdown']/field[@name='TEXT_ALIGN']"
			[Register ("TEXT_ALIGN")]
			public static global::Android.Graphics.Paint.Align TextAlign {
				get {
					if (TEXT_ALIGN_jfieldId == IntPtr.Zero)
						TEXT_ALIGN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT_ALIGN", "Landroid/graphics/Paint$Align;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXT_ALIGN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Align> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.RadialCountdown']/field[@name='TEXT_COLOR']"
			[Register ("TEXT_COLOR")]
			public const int TextColor = (int) -1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.RadialCountdown']/field[@name='TEXT_SIZE_SP']"
			[Register ("TEXT_SIZE_SP")]
			public const float TextSizeSp = (float) 18.000000;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.RadialCountdown']/field[@name='TOP_MARGIN_DIPS']"
			[Register ("TOP_MARGIN_DIPS")]
			public const int TopMarginDips = (int) 16;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/resource/DrawableConstants$RadialCountdown", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RadialCountdown); }
			}

			protected RadialCountdown (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants.RadialCountdown']/constructor[@name='DrawableConstants.RadialCountdown' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe RadialCountdown ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (RadialCountdown)) {
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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/resource/DrawableConstants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DrawableConstants); }
		}

		protected DrawableConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='DrawableConstants']/constructor[@name='DrawableConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DrawableConstants ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DrawableConstants)) {
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
