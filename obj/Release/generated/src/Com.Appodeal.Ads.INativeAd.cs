using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeAd']"
	[Register ("com/appodeal/ads/NativeAd", "", "Com.Appodeal.Ads.INativeAdInvoker")]
	public partial interface INativeAd : IJavaObject {

		string AdProvider {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeAd']/method[@name='getAdProvider' and count(parameter)=0]"
			[Register ("getAdProvider", "()Ljava/lang/String;", "GetGetAdProviderHandler:Com.Appodeal.Ads.INativeAdInvoker, AppodealXamarinPlugin")] get;
		}

		string AgeRestrictions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeAd']/method[@name='getAgeRestrictions' and count(parameter)=0]"
			[Register ("getAgeRestrictions", "()Ljava/lang/String;", "GetGetAgeRestrictionsHandler:Com.Appodeal.Ads.INativeAdInvoker, AppodealXamarinPlugin")] get;
		}

		string CallToAction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeAd']/method[@name='getCallToAction' and count(parameter)=0]"
			[Register ("getCallToAction", "()Ljava/lang/String;", "GetGetCallToActionHandler:Com.Appodeal.Ads.INativeAdInvoker, AppodealXamarinPlugin")] get;
		}

		string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeAd']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler:Com.Appodeal.Ads.INativeAdInvoker, AppodealXamarinPlugin")] get;
		}

		global::Android.Graphics.Bitmap Icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeAd']/method[@name='getIcon' and count(parameter)=0]"
			[Register ("getIcon", "()Landroid/graphics/Bitmap;", "GetGetIconHandler:Com.Appodeal.Ads.INativeAdInvoker, AppodealXamarinPlugin")] get;
		}

		string IconUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeAd']/method[@name='getIconUrl' and count(parameter)=0]"
			[Register ("getIconUrl", "()Ljava/lang/String;", "GetGetIconUrlHandler:Com.Appodeal.Ads.INativeAdInvoker, AppodealXamarinPlugin")] get;
		}

		global::Android.Graphics.Bitmap Image {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeAd']/method[@name='getImage' and count(parameter)=0]"
			[Register ("getImage", "()Landroid/graphics/Bitmap;", "GetGetImageHandler:Com.Appodeal.Ads.INativeAdInvoker, AppodealXamarinPlugin")] get;
		}

		string MainImageUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeAd']/method[@name='getMainImageUrl' and count(parameter)=0]"
			[Register ("getMainImageUrl", "()Ljava/lang/String;", "GetGetMainImageUrlHandler:Com.Appodeal.Ads.INativeAdInvoker, AppodealXamarinPlugin")] get;
		}

		float Rating {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeAd']/method[@name='getRating' and count(parameter)=0]"
			[Register ("getRating", "()F", "GetGetRatingHandler:Com.Appodeal.Ads.INativeAdInvoker, AppodealXamarinPlugin")] get;
		}

		string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeAd']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler:Com.Appodeal.Ads.INativeAdInvoker, AppodealXamarinPlugin")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeAd']/method[@name='containsVideo' and count(parameter)=0]"
		[Register ("containsVideo", "()Z", "GetContainsVideoHandler:Com.Appodeal.Ads.INativeAdInvoker, AppodealXamarinPlugin")]
		bool ContainsVideo ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeAd']/method[@name='getProviderView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getProviderView", "(Landroid/content/Context;)Landroid/view/View;", "GetGetProviderView_Landroid_content_Context_Handler:Com.Appodeal.Ads.INativeAdInvoker, AppodealXamarinPlugin")]
		global::Android.Views.View GetProviderView (global::Android.Content.Context p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeAd']/method[@name='registerViewForInteraction' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
		[Register ("registerViewForInteraction", "(Landroid/view/ViewGroup;)V", "GetRegisterViewForInteraction_Landroid_view_ViewGroup_Handler:Com.Appodeal.Ads.INativeAdInvoker, AppodealXamarinPlugin")]
		void RegisterViewForInteraction (global::Android.Views.ViewGroup p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeAd']/method[@name='setNativeMediaView' and count(parameter)=1 and parameter[1][@type='com.appodeal.ads.NativeMediaView']]"
		[Register ("setNativeMediaView", "(Lcom/appodeal/ads/NativeMediaView;)V", "GetSetNativeMediaView_Lcom_appodeal_ads_NativeMediaView_Handler:Com.Appodeal.Ads.INativeAdInvoker, AppodealXamarinPlugin")]
		void SetNativeMediaView (global::Com.Appodeal.Ads.NativeMediaView p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/interface[@name='NativeAd']/method[@name='unregisterViewForInteraction' and count(parameter)=0]"
		[Register ("unregisterViewForInteraction", "()V", "GetUnregisterViewForInteractionHandler:Com.Appodeal.Ads.INativeAdInvoker, AppodealXamarinPlugin")]
		void UnregisterViewForInteraction ();

	}

	[global::Android.Runtime.Register ("com/appodeal/ads/NativeAd", DoNotGenerateAcw=true)]
	internal class INativeAdInvoker : global::Java.Lang.Object, INativeAd {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/appodeal/ads/NativeAd");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (INativeAdInvoker); }
		}

		IntPtr class_ref;

		public static INativeAd GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INativeAd> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.appodeal.ads.NativeAd"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INativeAdInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAdProvider;
#pragma warning disable 0169
		static Delegate GetGetAdProviderHandler ()
		{
			if (cb_getAdProvider == null)
				cb_getAdProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdProvider);
			return cb_getAdProvider;
		}

		static IntPtr n_GetAdProvider (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.INativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdProvider);
		}
#pragma warning restore 0169

		IntPtr id_getAdProvider;
		public unsafe string AdProvider {
			get {
				if (id_getAdProvider == IntPtr.Zero)
					id_getAdProvider = JNIEnv.GetMethodID (class_ref, "getAdProvider", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdProvider), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAgeRestrictions;
#pragma warning disable 0169
		static Delegate GetGetAgeRestrictionsHandler ()
		{
			if (cb_getAgeRestrictions == null)
				cb_getAgeRestrictions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAgeRestrictions);
			return cb_getAgeRestrictions;
		}

		static IntPtr n_GetAgeRestrictions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.INativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AgeRestrictions);
		}
#pragma warning restore 0169

		IntPtr id_getAgeRestrictions;
		public unsafe string AgeRestrictions {
			get {
				if (id_getAgeRestrictions == IntPtr.Zero)
					id_getAgeRestrictions = JNIEnv.GetMethodID (class_ref, "getAgeRestrictions", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAgeRestrictions), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCallToAction;
#pragma warning disable 0169
		static Delegate GetGetCallToActionHandler ()
		{
			if (cb_getCallToAction == null)
				cb_getCallToAction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallToAction);
			return cb_getCallToAction;
		}

		static IntPtr n_GetCallToAction (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.INativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CallToAction);
		}
#pragma warning restore 0169

		IntPtr id_getCallToAction;
		public unsafe string CallToAction {
			get {
				if (id_getCallToAction == IntPtr.Zero)
					id_getCallToAction = JNIEnv.GetMethodID (class_ref, "getCallToAction", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCallToAction), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.INativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		IntPtr id_getDescription;
		public unsafe string Description {
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getIcon;
#pragma warning disable 0169
		static Delegate GetGetIconHandler ()
		{
			if (cb_getIcon == null)
				cb_getIcon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIcon);
			return cb_getIcon;
		}

		static IntPtr n_GetIcon (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.INativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Icon);
		}
#pragma warning restore 0169

		IntPtr id_getIcon;
		public unsafe global::Android.Graphics.Bitmap Icon {
			get {
				if (id_getIcon == IntPtr.Zero)
					id_getIcon = JNIEnv.GetMethodID (class_ref, "getIcon", "()Landroid/graphics/Bitmap;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIcon), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getIconUrl;
#pragma warning disable 0169
		static Delegate GetGetIconUrlHandler ()
		{
			if (cb_getIconUrl == null)
				cb_getIconUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconUrl);
			return cb_getIconUrl;
		}

		static IntPtr n_GetIconUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.INativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IconUrl);
		}
#pragma warning restore 0169

		IntPtr id_getIconUrl;
		public unsafe string IconUrl {
			get {
				if (id_getIconUrl == IntPtr.Zero)
					id_getIconUrl = JNIEnv.GetMethodID (class_ref, "getIconUrl", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIconUrl), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getImage;
#pragma warning disable 0169
		static Delegate GetGetImageHandler ()
		{
			if (cb_getImage == null)
				cb_getImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImage);
			return cb_getImage;
		}

		static IntPtr n_GetImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.INativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Image);
		}
#pragma warning restore 0169

		IntPtr id_getImage;
		public unsafe global::Android.Graphics.Bitmap Image {
			get {
				if (id_getImage == IntPtr.Zero)
					id_getImage = JNIEnv.GetMethodID (class_ref, "getImage", "()Landroid/graphics/Bitmap;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImage), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMainImageUrl;
#pragma warning disable 0169
		static Delegate GetGetMainImageUrlHandler ()
		{
			if (cb_getMainImageUrl == null)
				cb_getMainImageUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMainImageUrl);
			return cb_getMainImageUrl;
		}

		static IntPtr n_GetMainImageUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.INativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MainImageUrl);
		}
#pragma warning restore 0169

		IntPtr id_getMainImageUrl;
		public unsafe string MainImageUrl {
			get {
				if (id_getMainImageUrl == IntPtr.Zero)
					id_getMainImageUrl = JNIEnv.GetMethodID (class_ref, "getMainImageUrl", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMainImageUrl), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRating;
#pragma warning disable 0169
		static Delegate GetGetRatingHandler ()
		{
			if (cb_getRating == null)
				cb_getRating = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetRating);
			return cb_getRating;
		}

		static float n_GetRating (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.INativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Rating;
		}
#pragma warning restore 0169

		IntPtr id_getRating;
		public unsafe float Rating {
			get {
				if (id_getRating == IntPtr.Zero)
					id_getRating = JNIEnv.GetMethodID (class_ref, "getRating", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getRating);
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.INativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		IntPtr id_getTitle;
		public unsafe string Title {
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_containsVideo;
#pragma warning disable 0169
		static Delegate GetContainsVideoHandler ()
		{
			if (cb_containsVideo == null)
				cb_containsVideo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ContainsVideo);
			return cb_containsVideo;
		}

		static bool n_ContainsVideo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.INativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContainsVideo ();
		}
#pragma warning restore 0169

		IntPtr id_containsVideo;
		public unsafe bool ContainsVideo ()
		{
			if (id_containsVideo == IntPtr.Zero)
				id_containsVideo = JNIEnv.GetMethodID (class_ref, "containsVideo", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_containsVideo);
		}

		static Delegate cb_getProviderView_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetProviderView_Landroid_content_Context_Handler ()
		{
			if (cb_getProviderView_Landroid_content_Context_ == null)
				cb_getProviderView_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetProviderView_Landroid_content_Context_);
			return cb_getProviderView_Landroid_content_Context_;
		}

		static IntPtr n_GetProviderView_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Appodeal.Ads.INativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetProviderView (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getProviderView_Landroid_content_Context_;
		public unsafe global::Android.Views.View GetProviderView (global::Android.Content.Context p0)
		{
			if (id_getProviderView_Landroid_content_Context_ == IntPtr.Zero)
				id_getProviderView_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getProviderView", "(Landroid/content/Context;)Landroid/view/View;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProviderView_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_registerViewForInteraction_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetRegisterViewForInteraction_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_registerViewForInteraction_Landroid_view_ViewGroup_ == null)
				cb_registerViewForInteraction_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterViewForInteraction_Landroid_view_ViewGroup_);
			return cb_registerViewForInteraction_Landroid_view_ViewGroup_;
		}

		static void n_RegisterViewForInteraction_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Appodeal.Ads.INativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterViewForInteraction (p0);
		}
#pragma warning restore 0169

		IntPtr id_registerViewForInteraction_Landroid_view_ViewGroup_;
		public unsafe void RegisterViewForInteraction (global::Android.Views.ViewGroup p0)
		{
			if (id_registerViewForInteraction_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_registerViewForInteraction_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "registerViewForInteraction", "(Landroid/view/ViewGroup;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerViewForInteraction_Landroid_view_ViewGroup_, __args);
		}

		static Delegate cb_setNativeMediaView_Lcom_appodeal_ads_NativeMediaView_;
#pragma warning disable 0169
		static Delegate GetSetNativeMediaView_Lcom_appodeal_ads_NativeMediaView_Handler ()
		{
			if (cb_setNativeMediaView_Lcom_appodeal_ads_NativeMediaView_ == null)
				cb_setNativeMediaView_Lcom_appodeal_ads_NativeMediaView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNativeMediaView_Lcom_appodeal_ads_NativeMediaView_);
			return cb_setNativeMediaView_Lcom_appodeal_ads_NativeMediaView_;
		}

		static void n_SetNativeMediaView_Lcom_appodeal_ads_NativeMediaView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Appodeal.Ads.INativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Appodeal.Ads.NativeMediaView p0 = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.NativeMediaView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNativeMediaView (p0);
		}
#pragma warning restore 0169

		IntPtr id_setNativeMediaView_Lcom_appodeal_ads_NativeMediaView_;
		public unsafe void SetNativeMediaView (global::Com.Appodeal.Ads.NativeMediaView p0)
		{
			if (id_setNativeMediaView_Lcom_appodeal_ads_NativeMediaView_ == IntPtr.Zero)
				id_setNativeMediaView_Lcom_appodeal_ads_NativeMediaView_ = JNIEnv.GetMethodID (class_ref, "setNativeMediaView", "(Lcom/appodeal/ads/NativeMediaView;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNativeMediaView_Lcom_appodeal_ads_NativeMediaView_, __args);
		}

		static Delegate cb_unregisterViewForInteraction;
#pragma warning disable 0169
		static Delegate GetUnregisterViewForInteractionHandler ()
		{
			if (cb_unregisterViewForInteraction == null)
				cb_unregisterViewForInteraction = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnregisterViewForInteraction);
			return cb_unregisterViewForInteraction;
		}

		static void n_UnregisterViewForInteraction (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Appodeal.Ads.INativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.INativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterViewForInteraction ();
		}
#pragma warning restore 0169

		IntPtr id_unregisterViewForInteraction;
		public unsafe void UnregisterViewForInteraction ()
		{
			if (id_unregisterViewForInteraction == IntPtr.Zero)
				id_unregisterViewForInteraction = JNIEnv.GetMethodID (class_ref, "unregisterViewForInteraction", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterViewForInteraction);
		}

	}

}
