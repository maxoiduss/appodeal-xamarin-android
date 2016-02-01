using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='HtmlBannerWebView']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/HtmlBannerWebView", DoNotGenerateAcw=true)]
	public partial class HtmlBannerWebView : global::Com.Mopub.Mobileads.BaseHtmlWebView {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='HtmlBannerWebView']/field[@name='EXTRA_AD_CLICK_DATA']"
		[Register ("EXTRA_AD_CLICK_DATA")]
		public const string ExtraAdClickData = (string) "com.mopub.intent.extra.AD_CLICK_DATA";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='HtmlBannerWebView.HtmlBannerWebViewListener']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/HtmlBannerWebView$HtmlBannerWebViewListener", DoNotGenerateAcw=true)]
		public partial class HtmlBannerWebViewListener : global::Java.Lang.Object, global::Com.Mopub.Mobileads.IHtmlWebViewListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/HtmlBannerWebView$HtmlBannerWebViewListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HtmlBannerWebViewListener); }
			}

			protected HtmlBannerWebViewListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='HtmlBannerWebView.HtmlBannerWebViewListener']/constructor[@name='HtmlBannerWebView.HtmlBannerWebViewListener' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.CustomEventBanner.CustomEventBannerListener']]"
			[Register (".ctor", "(Lcom/mopub/mobileads/CustomEventBanner$CustomEventBannerListener;)V", "")]
			public unsafe HtmlBannerWebViewListener (global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (HtmlBannerWebViewListener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/mobileads/CustomEventBanner$CustomEventBannerListener;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/mobileads/CustomEventBanner$CustomEventBannerListener;)V", __args);
						return;
					}

					if (id_ctor_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ == IntPtr.Zero)
						id_ctor_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/mobileads/CustomEventBanner$CustomEventBannerListener;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_, __args);
				} finally {
				}
			}

			static Delegate cb_onClicked;
#pragma warning disable 0169
			static Delegate GetOnClickedHandler ()
			{
				if (cb_onClicked == null)
					cb_onClicked = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnClicked);
				return cb_onClicked;
			}

			static void n_OnClicked (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.HtmlBannerWebView.HtmlBannerWebViewListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.HtmlBannerWebView.HtmlBannerWebViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnClicked ();
			}
#pragma warning restore 0169

			static IntPtr id_onClicked;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='HtmlBannerWebView.HtmlBannerWebViewListener']/method[@name='onClicked' and count(parameter)=0]"
			[Register ("onClicked", "()V", "GetOnClickedHandler")]
			public virtual unsafe void OnClicked ()
			{
				if (id_onClicked == IntPtr.Zero)
					id_onClicked = JNIEnv.GetMethodID (class_ref, "onClicked", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onClicked);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClicked", "()V"));
				} finally {
				}
			}

			static Delegate cb_onCollapsed;
#pragma warning disable 0169
			static Delegate GetOnCollapsedHandler ()
			{
				if (cb_onCollapsed == null)
					cb_onCollapsed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCollapsed);
				return cb_onCollapsed;
			}

			static void n_OnCollapsed (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.HtmlBannerWebView.HtmlBannerWebViewListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.HtmlBannerWebView.HtmlBannerWebViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCollapsed ();
			}
#pragma warning restore 0169

			static IntPtr id_onCollapsed;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='HtmlBannerWebView.HtmlBannerWebViewListener']/method[@name='onCollapsed' and count(parameter)=0]"
			[Register ("onCollapsed", "()V", "GetOnCollapsedHandler")]
			public virtual unsafe void OnCollapsed ()
			{
				if (id_onCollapsed == IntPtr.Zero)
					id_onCollapsed = JNIEnv.GetMethodID (class_ref, "onCollapsed", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onCollapsed);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCollapsed", "()V"));
				} finally {
				}
			}

			static Delegate cb_onFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
#pragma warning disable 0169
			static Delegate GetOnFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler ()
			{
				if (cb_onFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == null)
					cb_onFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailed_Lcom_mopub_mobileads_MoPubErrorCode_);
				return cb_onFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
			}

			static void n_OnFailed_Lcom_mopub_mobileads_MoPubErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.HtmlBannerWebView.HtmlBannerWebViewListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.HtmlBannerWebView.HtmlBannerWebViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.MoPubErrorCode p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFailed (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='HtmlBannerWebView.HtmlBannerWebViewListener']/method[@name='onFailed' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubErrorCode']]"
			[Register ("onFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V", "GetOnFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler")]
			public virtual unsafe void OnFailed (global::Com.Mopub.Mobileads.MoPubErrorCode p0)
			{
				if (id_onFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == IntPtr.Zero)
					id_onFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNIEnv.GetMethodID (class_ref, "onFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onFailed_Lcom_mopub_mobileads_MoPubErrorCode_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_;
#pragma warning disable 0169
			static Delegate GetOnLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_Handler ()
			{
				if (cb_onLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_ == null)
					cb_onLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_);
				return cb_onLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_;
			}

			static void n_OnLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.HtmlBannerWebView.HtmlBannerWebViewListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.HtmlBannerWebView.HtmlBannerWebViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Mobileads.BaseHtmlWebView p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.BaseHtmlWebView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLoaded (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='HtmlBannerWebView.HtmlBannerWebViewListener']/method[@name='onLoaded' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.BaseHtmlWebView']]"
			[Register ("onLoaded", "(Lcom/mopub/mobileads/BaseHtmlWebView;)V", "GetOnLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_Handler")]
			public virtual unsafe void OnLoaded (global::Com.Mopub.Mobileads.BaseHtmlWebView p0)
			{
				if (id_onLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_ == IntPtr.Zero)
					id_onLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_ = JNIEnv.GetMethodID (class_ref, "onLoaded", "(Lcom/mopub/mobileads/BaseHtmlWebView;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLoaded", "(Lcom/mopub/mobileads/BaseHtmlWebView;)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/HtmlBannerWebView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HtmlBannerWebView); }
		}

		protected HtmlBannerWebView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_mopub_common_AdReport_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='HtmlBannerWebView']/constructor[@name='HtmlBannerWebView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.common.AdReport']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/mopub/common/AdReport;)V", "")]
		public unsafe HtmlBannerWebView (global::Android.Content.Context p0, global::Com.Mopub.Common.AdReport p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (HtmlBannerWebView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/mopub/common/AdReport;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/mopub/common/AdReport;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_mopub_common_AdReport_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_mopub_common_AdReport_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/mopub/common/AdReport;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_mopub_common_AdReport_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_mopub_common_AdReport_, __args);
			} finally {
			}
		}

		static Delegate cb_init_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInit_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_init_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_ == null)
				cb_init_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, IntPtr, IntPtr>) n_Init_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_);
			return cb_init_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_;
		}

		static void n_Init_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Mopub.Mobileads.HtmlBannerWebView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.HtmlBannerWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener p0 = (global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_init_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='HtmlBannerWebView']/method[@name='init' and count(parameter)=4 and parameter[1][@type='com.mopub.mobileads.CustomEventBanner.CustomEventBannerListener'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("init", "(Lcom/mopub/mobileads/CustomEventBanner$CustomEventBannerListener;ZLjava/lang/String;Ljava/lang/String;)V", "GetInit_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Init (global::Com.Mopub.Mobileads.CustomEventBanner.ICustomEventBannerListener p0, bool p1, string p2, string p3)
		{
			if (id_init_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_init_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "init", "(Lcom/mopub/mobileads/CustomEventBanner$CustomEventBannerListener;ZLjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_init_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Lcom/mopub/mobileads/CustomEventBanner$CustomEventBannerListener;ZLjava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}
