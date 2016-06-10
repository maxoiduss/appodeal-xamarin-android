using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Device.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize']"
	[global::Android.Runtime.Register ("com/amazon/device/ads/AdSize", DoNotGenerateAcw=true)]
	public partial class AdSize : global::Java.Lang.Object {


		static IntPtr SIZE_1024x50_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize']/field[@name='SIZE_1024x50']"
		[Register ("SIZE_1024x50")]
		public static global::Com.Amazon.Device.Ads.AdSize SIZE1024x50 {
			get {
				if (SIZE_1024x50_jfieldId == IntPtr.Zero)
					SIZE_1024x50_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIZE_1024x50", "Lcom/amazon/device/ads/AdSize;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIZE_1024x50_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdSize> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SIZE_300x250_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize']/field[@name='SIZE_300x250']"
		[Register ("SIZE_300x250")]
		public static global::Com.Amazon.Device.Ads.AdSize SIZE300x250 {
			get {
				if (SIZE_300x250_jfieldId == IntPtr.Zero)
					SIZE_300x250_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIZE_300x250", "Lcom/amazon/device/ads/AdSize;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIZE_300x250_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdSize> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SIZE_300x50_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize']/field[@name='SIZE_300x50']"
		[Register ("SIZE_300x50")]
		public static global::Com.Amazon.Device.Ads.AdSize SIZE300x50 {
			get {
				if (SIZE_300x50_jfieldId == IntPtr.Zero)
					SIZE_300x50_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIZE_300x50", "Lcom/amazon/device/ads/AdSize;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIZE_300x50_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdSize> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SIZE_320x50_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize']/field[@name='SIZE_320x50']"
		[Register ("SIZE_320x50")]
		public static global::Com.Amazon.Device.Ads.AdSize SIZE320x50 {
			get {
				if (SIZE_320x50_jfieldId == IntPtr.Zero)
					SIZE_320x50_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIZE_320x50", "Lcom/amazon/device/ads/AdSize;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIZE_320x50_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdSize> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SIZE_600x90_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize']/field[@name='SIZE_600x90']"
		[Register ("SIZE_600x90")]
		public static global::Com.Amazon.Device.Ads.AdSize SIZE600x90 {
			get {
				if (SIZE_600x90_jfieldId == IntPtr.Zero)
					SIZE_600x90_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIZE_600x90", "Lcom/amazon/device/ads/AdSize;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIZE_600x90_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdSize> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SIZE_728x90_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize']/field[@name='SIZE_728x90']"
		[Register ("SIZE_728x90")]
		public static global::Com.Amazon.Device.Ads.AdSize SIZE728x90 {
			get {
				if (SIZE_728x90_jfieldId == IntPtr.Zero)
					SIZE_728x90_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIZE_728x90", "Lcom/amazon/device/ads/AdSize;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIZE_728x90_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdSize> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SIZE_AUTO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize']/field[@name='SIZE_AUTO']"
		[Register ("SIZE_AUTO")]
		public static global::Com.Amazon.Device.Ads.AdSize SizeAuto {
			get {
				if (SIZE_AUTO_jfieldId == IntPtr.Zero)
					SIZE_AUTO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIZE_AUTO", "Lcom/amazon/device/ads/AdSize;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIZE_AUTO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdSize> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SIZE_AUTO_NO_SCALE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize']/field[@name='SIZE_AUTO_NO_SCALE']"
		[Register ("SIZE_AUTO_NO_SCALE")]
		public static global::Com.Amazon.Device.Ads.AdSize SizeAutoNoScale {
			get {
				if (SIZE_AUTO_NO_SCALE_jfieldId == IntPtr.Zero)
					SIZE_AUTO_NO_SCALE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIZE_AUTO_NO_SCALE", "Lcom/amazon/device/ads/AdSize;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIZE_AUTO_NO_SCALE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdSize> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize.Modality']"
		[global::Android.Runtime.Register ("com/amazon/device/ads/AdSize$Modality", DoNotGenerateAcw=true)]
		public sealed partial class Modality : global::Java.Lang.Enum {


			static IntPtr MODAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize.Modality']/field[@name='MODAL']"
			[Register ("MODAL")]
			public static global::Com.Amazon.Device.Ads.AdSize.Modality Modal {
				get {
					if (MODAL_jfieldId == IntPtr.Zero)
						MODAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MODAL", "Lcom/amazon/device/ads/AdSize$Modality;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MODAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdSize.Modality> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MODELESS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize.Modality']/field[@name='MODELESS']"
			[Register ("MODELESS")]
			public static global::Com.Amazon.Device.Ads.AdSize.Modality Modeless {
				get {
					if (MODELESS_jfieldId == IntPtr.Zero)
						MODELESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MODELESS", "Lcom/amazon/device/ads/AdSize$Modality;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MODELESS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdSize.Modality> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/device/ads/AdSize$Modality", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Modality); }
			}

			internal Modality (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize.Scaling']"
		[global::Android.Runtime.Register ("com/amazon/device/ads/AdSize$Scaling", DoNotGenerateAcw=true)]
		public sealed partial class Scaling : global::Java.Lang.Enum {


			static IntPtr CAN_UPSCALE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize.Scaling']/field[@name='CAN_UPSCALE']"
			[Register ("CAN_UPSCALE")]
			public static global::Com.Amazon.Device.Ads.AdSize.Scaling CanUpscale {
				get {
					if (CAN_UPSCALE_jfieldId == IntPtr.Zero)
						CAN_UPSCALE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAN_UPSCALE", "Lcom/amazon/device/ads/AdSize$Scaling;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CAN_UPSCALE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdSize.Scaling> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NO_UPSCALE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize.Scaling']/field[@name='NO_UPSCALE']"
			[Register ("NO_UPSCALE")]
			public static global::Com.Amazon.Device.Ads.AdSize.Scaling NoUpscale {
				get {
					if (NO_UPSCALE_jfieldId == IntPtr.Zero)
						NO_UPSCALE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_UPSCALE", "Lcom/amazon/device/ads/AdSize$Scaling;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_UPSCALE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdSize.Scaling> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/device/ads/AdSize$Scaling", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Scaling); }
			}

			internal Scaling (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize.SizeType']"
		[global::Android.Runtime.Register ("com/amazon/device/ads/AdSize$SizeType", DoNotGenerateAcw=true)]
		public sealed partial class SizeType : global::Java.Lang.Enum {


			static IntPtr AUTO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize.SizeType']/field[@name='AUTO']"
			[Register ("AUTO")]
			public static global::Com.Amazon.Device.Ads.AdSize.SizeType Auto {
				get {
					if (AUTO_jfieldId == IntPtr.Zero)
						AUTO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTO", "Lcom/amazon/device/ads/AdSize$SizeType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdSize.SizeType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr EXPLICIT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize.SizeType']/field[@name='EXPLICIT']"
			[Register ("EXPLICIT")]
			public static global::Com.Amazon.Device.Ads.AdSize.SizeType Explicit {
				get {
					if (EXPLICIT_jfieldId == IntPtr.Zero)
						EXPLICIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXPLICIT", "Lcom/amazon/device/ads/AdSize$SizeType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXPLICIT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdSize.SizeType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INTERSTITIAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize.SizeType']/field[@name='INTERSTITIAL']"
			[Register ("INTERSTITIAL")]
			public static global::Com.Amazon.Device.Ads.AdSize.SizeType Interstitial {
				get {
					if (INTERSTITIAL_jfieldId == IntPtr.Zero)
						INTERSTITIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERSTITIAL", "Lcom/amazon/device/ads/AdSize$SizeType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERSTITIAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdSize.SizeType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/device/ads/AdSize$SizeType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SizeType); }
			}

			internal SizeType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/device/ads/AdSize", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdSize); }
		}

		protected AdSize (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize']/constructor[@name='AdSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe AdSize (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (AdSize)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static Delegate cb_getGravity;
#pragma warning disable 0169
		static Delegate GetGetGravityHandler ()
		{
			if (cb_getGravity == null)
				cb_getGravity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetGravity);
			return cb_getGravity;
		}

		static int n_GetGravity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.AdSize __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdSize> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Gravity;
		}
#pragma warning restore 0169

		static IntPtr id_getGravity;
		public virtual unsafe int Gravity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize']/method[@name='getGravity' and count(parameter)=0]"
			[Register ("getGravity", "()I", "GetGetGravityHandler")]
			get {
				if (id_getGravity == IntPtr.Zero)
					id_getGravity = JNIEnv.GetMethodID (class_ref, "getGravity", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getGravity);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGravity", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.AdSize __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdSize> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isAuto;
#pragma warning disable 0169
		static Delegate GetIsAutoHandler ()
		{
			if (cb_isAuto == null)
				cb_isAuto = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAuto);
			return cb_isAuto;
		}

		static bool n_IsAuto (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.AdSize __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdSize> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAuto;
		}
#pragma warning restore 0169

		static IntPtr id_isAuto;
		public virtual unsafe bool IsAuto {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize']/method[@name='isAuto' and count(parameter)=0]"
			[Register ("isAuto", "()Z", "GetIsAutoHandler")]
			get {
				if (id_isAuto == IntPtr.Zero)
					id_isAuto = JNIEnv.GetMethodID (class_ref, "isAuto", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isAuto);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAuto", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.AdSize __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdSize> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_canUpscale;
#pragma warning disable 0169
		static Delegate GetCanUpscaleHandler ()
		{
			if (cb_canUpscale == null)
				cb_canUpscale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanUpscale);
			return cb_canUpscale;
		}

		static bool n_CanUpscale (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Device.Ads.AdSize __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdSize> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanUpscale ();
		}
#pragma warning restore 0169

		static IntPtr id_canUpscale;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize']/method[@name='canUpscale' and count(parameter)=0]"
		[Register ("canUpscale", "()Z", "GetCanUpscaleHandler")]
		public virtual unsafe bool CanUpscale ()
		{
			if (id_canUpscale == IntPtr.Zero)
				id_canUpscale = JNIEnv.GetMethodID (class_ref, "canUpscale", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_canUpscale);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canUpscale", "()Z"));
			} finally {
			}
		}

		static Delegate cb_newGravity_I;
#pragma warning disable 0169
		static Delegate GetNewGravity_IHandler ()
		{
			if (cb_newGravity_I == null)
				cb_newGravity_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_NewGravity_I);
			return cb_newGravity_I;
		}

		static IntPtr n_NewGravity_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amazon.Device.Ads.AdSize __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdSize> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewGravity (p0));
		}
#pragma warning restore 0169

		static IntPtr id_newGravity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.device.ads']/class[@name='AdSize']/method[@name='newGravity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("newGravity", "(I)Lcom/amazon/device/ads/AdSize;", "GetNewGravity_IHandler")]
		public virtual unsafe global::Com.Amazon.Device.Ads.AdSize NewGravity (int p0)
		{
			if (id_newGravity_I == IntPtr.Zero)
				id_newGravity_I = JNIEnv.GetMethodID (class_ref, "newGravity", "(I)Lcom/amazon/device/ads/AdSize;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdSize> (JNIEnv.CallObjectMethod  (Handle, id_newGravity_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Device.Ads.AdSize> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newGravity", "(I)Lcom/amazon/device/ads/AdSize;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
