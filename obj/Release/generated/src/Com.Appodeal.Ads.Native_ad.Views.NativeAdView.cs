using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads.Native_ad.Views {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appodeal.ads.native_ad.views']/class[@name='NativeAdView']"
	[global::Android.Runtime.Register ("com/appodeal/ads/native_ad/views/NativeAdView", DoNotGenerateAcw=true)]
	public abstract partial class NativeAdView : global::Android.Widget.FrameLayout {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/appodeal/ads/native_ad/views/NativeAdView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeAdView); }
		}

		protected NativeAdView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.appodeal.ads.native_ad.views']/class[@name='NativeAdView']/constructor[@name='NativeAdView' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", "")]
		public unsafe NativeAdView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (NativeAdView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.appodeal.ads.native_ad.views']/class[@name='NativeAdView']/constructor[@name='NativeAdView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe NativeAdView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (NativeAdView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.appodeal.ads.native_ad.views']/class[@name='NativeAdView']/constructor[@name='NativeAdView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe NativeAdView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (NativeAdView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.appodeal.ads.native_ad.views']/class[@name='NativeAdView']/constructor[@name='NativeAdView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe NativeAdView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (NativeAdView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_appodeal_ads_NativeAd_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.appodeal.ads.native_ad.views']/class[@name='NativeAdView']/constructor[@name='NativeAdView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.appodeal.ads.NativeAd']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/appodeal/ads/NativeAd;)V", "")]
		public unsafe NativeAdView (global::Android.Content.Context p0, global::Com.Appodeal.Ads.INativeAd p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (NativeAdView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/appodeal/ads/NativeAd;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/appodeal/ads/NativeAd;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_appodeal_ads_NativeAd_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_appodeal_ads_NativeAd_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/appodeal/ads/NativeAd;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_appodeal_ads_NativeAd_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_appodeal_ads_NativeAd_, __args);
			} finally {
			}
		}

		static Delegate cb_getCallToActionView;
#pragma warning disable 0169
		static Delegate GetGetCallToActionViewHandler ()
		{
			if (cb_getCallToActionView == null)
				cb_getCallToActionView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallToActionView);
			return cb_getCallToActionView;
		}

		static IntPtr n_GetCallToActionView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.Native_ad.Views.NativeAdView __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Native_ad.Views.NativeAdView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CallToActionView);
		}
#pragma warning restore 0169

		static IntPtr id_getCallToActionView;
		public virtual unsafe global::Android.Widget.TextView CallToActionView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads.native_ad.views']/class[@name='NativeAdView']/method[@name='getCallToActionView' and count(parameter)=0]"
			[Register ("getCallToActionView", "()Landroid/widget/TextView;", "GetGetCallToActionViewHandler")]
			get {
				if (id_getCallToActionView == IntPtr.Zero)
					id_getCallToActionView = JNIEnv.GetMethodID (class_ref, "getCallToActionView", "()Landroid/widget/TextView;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCallToActionView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCallToActionView", "()Landroid/widget/TextView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDescriptionView;
#pragma warning disable 0169
		static Delegate GetGetDescriptionViewHandler ()
		{
			if (cb_getDescriptionView == null)
				cb_getDescriptionView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescriptionView);
			return cb_getDescriptionView;
		}

		static IntPtr n_GetDescriptionView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.Native_ad.Views.NativeAdView __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Native_ad.Views.NativeAdView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DescriptionView);
		}
#pragma warning restore 0169

		static IntPtr id_getDescriptionView;
		public virtual unsafe global::Android.Widget.TextView DescriptionView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads.native_ad.views']/class[@name='NativeAdView']/method[@name='getDescriptionView' and count(parameter)=0]"
			[Register ("getDescriptionView", "()Landroid/widget/TextView;", "GetGetDescriptionViewHandler")]
			get {
				if (id_getDescriptionView == IntPtr.Zero)
					id_getDescriptionView = JNIEnv.GetMethodID (class_ref, "getDescriptionView", "()Landroid/widget/TextView;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDescriptionView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDescriptionView", "()Landroid/widget/TextView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconView;
#pragma warning disable 0169
		static Delegate GetGetIconViewHandler ()
		{
			if (cb_getIconView == null)
				cb_getIconView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconView);
			return cb_getIconView;
		}

		static IntPtr n_GetIconView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.Native_ad.Views.NativeAdView __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Native_ad.Views.NativeAdView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconView);
		}
#pragma warning restore 0169

		static IntPtr id_getIconView;
		public virtual unsafe global::Android.Widget.ImageView IconView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads.native_ad.views']/class[@name='NativeAdView']/method[@name='getIconView' and count(parameter)=0]"
			[Register ("getIconView", "()Landroid/widget/ImageView;", "GetGetIconViewHandler")]
			get {
				if (id_getIconView == IntPtr.Zero)
					id_getIconView = JNIEnv.GetMethodID (class_ref, "getIconView", "()Landroid/widget/ImageView;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIconView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIconView", "()Landroid/widget/ImageView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNativeMediaView;
#pragma warning disable 0169
		static Delegate GetGetNativeMediaViewHandler ()
		{
			if (cb_getNativeMediaView == null)
				cb_getNativeMediaView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNativeMediaView);
			return cb_getNativeMediaView;
		}

		static IntPtr n_GetNativeMediaView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.Native_ad.Views.NativeAdView __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Native_ad.Views.NativeAdView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NativeMediaView);
		}
#pragma warning restore 0169

		static IntPtr id_getNativeMediaView;
		public virtual unsafe global::Com.Appodeal.Ads.NativeMediaView NativeMediaView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads.native_ad.views']/class[@name='NativeAdView']/method[@name='getNativeMediaView' and count(parameter)=0]"
			[Register ("getNativeMediaView", "()Lcom/appodeal/ads/NativeMediaView;", "GetGetNativeMediaViewHandler")]
			get {
				if (id_getNativeMediaView == IntPtr.Zero)
					id_getNativeMediaView = JNIEnv.GetMethodID (class_ref, "getNativeMediaView", "()Lcom/appodeal/ads/NativeMediaView;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.NativeMediaView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNativeMediaView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.NativeMediaView> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNativeMediaView", "()Lcom/appodeal/ads/NativeMediaView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRatingBar;
#pragma warning disable 0169
		static Delegate GetGetRatingBarHandler ()
		{
			if (cb_getRatingBar == null)
				cb_getRatingBar = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRatingBar);
			return cb_getRatingBar;
		}

		static IntPtr n_GetRatingBar (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.Native_ad.Views.NativeAdView __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Native_ad.Views.NativeAdView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RatingBar);
		}
#pragma warning restore 0169

		static IntPtr id_getRatingBar;
		public virtual unsafe global::Android.Widget.RatingBar RatingBar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads.native_ad.views']/class[@name='NativeAdView']/method[@name='getRatingBar' and count(parameter)=0]"
			[Register ("getRatingBar", "()Landroid/widget/RatingBar;", "GetGetRatingBarHandler")]
			get {
				if (id_getRatingBar == IntPtr.Zero)
					id_getRatingBar = JNIEnv.GetMethodID (class_ref, "getRatingBar", "()Landroid/widget/RatingBar;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.RatingBar> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRatingBar), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.RatingBar> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRatingBar", "()Landroid/widget/RatingBar;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTitleView;
#pragma warning disable 0169
		static Delegate GetGetTitleViewHandler ()
		{
			if (cb_getTitleView == null)
				cb_getTitleView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitleView);
			return cb_getTitleView;
		}

		static IntPtr n_GetTitleView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.Native_ad.Views.NativeAdView __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Native_ad.Views.NativeAdView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TitleView);
		}
#pragma warning restore 0169

		static IntPtr id_getTitleView;
		public virtual unsafe global::Android.Widget.TextView TitleView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads.native_ad.views']/class[@name='NativeAdView']/method[@name='getTitleView' and count(parameter)=0]"
			[Register ("getTitleView", "()Landroid/widget/TextView;", "GetGetTitleViewHandler")]
			get {
				if (id_getTitleView == IntPtr.Zero)
					id_getTitleView = JNIEnv.GetMethodID (class_ref, "getTitleView", "()Landroid/widget/TextView;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTitleView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitleView", "()Landroid/widget/TextView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setCallToActionColor_I;
#pragma warning disable 0169
		static Delegate GetSetCallToActionColor_IHandler ()
		{
			if (cb_setCallToActionColor_I == null)
				cb_setCallToActionColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCallToActionColor_I);
			return cb_setCallToActionColor_I;
		}

		static void n_SetCallToActionColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Appodeal.Ads.Native_ad.Views.NativeAdView __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Native_ad.Views.NativeAdView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCallToActionColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCallToActionColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads.native_ad.views']/class[@name='NativeAdView']/method[@name='setCallToActionColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCallToActionColor", "(I)V", "GetSetCallToActionColor_IHandler")]
		public virtual unsafe void SetCallToActionColor (int p0)
		{
			if (id_setCallToActionColor_I == IntPtr.Zero)
				id_setCallToActionColor_I = JNIEnv.GetMethodID (class_ref, "setCallToActionColor", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCallToActionColor_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallToActionColor", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCallToActionColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCallToActionColor_Ljava_lang_String_Handler ()
		{
			if (cb_setCallToActionColor_Ljava_lang_String_ == null)
				cb_setCallToActionColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallToActionColor_Ljava_lang_String_);
			return cb_setCallToActionColor_Ljava_lang_String_;
		}

		static void n_SetCallToActionColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Appodeal.Ads.Native_ad.Views.NativeAdView __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Native_ad.Views.NativeAdView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCallToActionColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCallToActionColor_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads.native_ad.views']/class[@name='NativeAdView']/method[@name='setCallToActionColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCallToActionColor", "(Ljava/lang/String;)V", "GetSetCallToActionColor_Ljava_lang_String_Handler")]
		public virtual unsafe void SetCallToActionColor (string p0)
		{
			if (id_setCallToActionColor_Ljava_lang_String_ == IntPtr.Zero)
				id_setCallToActionColor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCallToActionColor", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCallToActionColor_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallToActionColor", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setNativeAd_Lcom_appodeal_ads_NativeAd_;
#pragma warning disable 0169
		static Delegate GetSetNativeAd_Lcom_appodeal_ads_NativeAd_Handler ()
		{
			if (cb_setNativeAd_Lcom_appodeal_ads_NativeAd_ == null)
				cb_setNativeAd_Lcom_appodeal_ads_NativeAd_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNativeAd_Lcom_appodeal_ads_NativeAd_);
			return cb_setNativeAd_Lcom_appodeal_ads_NativeAd_;
		}

		static void n_SetNativeAd_Lcom_appodeal_ads_NativeAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Appodeal.Ads.Native_ad.Views.NativeAdView __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Native_ad.Views.NativeAdView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Appodeal.Ads.INativeAd p0 = (global::Com.Appodeal.Ads.INativeAd)global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeAd> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNativeAd (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setNativeAd_Lcom_appodeal_ads_NativeAd_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads.native_ad.views']/class[@name='NativeAdView']/method[@name='setNativeAd' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.NativeAd']]"
		[Register ("setNativeAd", "(Lcom/appodeal/ads/NativeAd;)V", "GetSetNativeAd_Lcom_appodeal_ads_NativeAd_Handler")]
		public virtual unsafe void SetNativeAd (global::Com.Appodeal.Ads.INativeAd p0)
		{
			if (id_setNativeAd_Lcom_appodeal_ads_NativeAd_ == IntPtr.Zero)
				id_setNativeAd_Lcom_appodeal_ads_NativeAd_ = JNIEnv.GetMethodID (class_ref, "setNativeAd", "(Lcom/appodeal/ads/NativeAd;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNativeAd_Lcom_appodeal_ads_NativeAd_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNativeAd", "(Lcom/appodeal/ads/NativeAd;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_showSponsored_Z;
#pragma warning disable 0169
		static Delegate GetShowSponsored_ZHandler ()
		{
			if (cb_showSponsored_Z == null)
				cb_showSponsored_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ShowSponsored_Z);
			return cb_showSponsored_Z;
		}

		static void n_ShowSponsored_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Appodeal.Ads.Native_ad.Views.NativeAdView __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Native_ad.Views.NativeAdView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowSponsored (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showSponsored_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads.native_ad.views']/class[@name='NativeAdView']/method[@name='showSponsored' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showSponsored", "(Z)V", "GetShowSponsored_ZHandler")]
		public virtual unsafe void ShowSponsored (bool p0)
		{
			if (id_showSponsored_Z == IntPtr.Zero)
				id_showSponsored_Z = JNIEnv.GetMethodID (class_ref, "showSponsored", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showSponsored_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showSponsored", "(Z)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/appodeal/ads/native_ad/views/NativeAdView", DoNotGenerateAcw=true)]
	internal partial class NativeAdViewInvoker : NativeAdView {

		public NativeAdViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeAdViewInvoker); }
		}

	}

}
