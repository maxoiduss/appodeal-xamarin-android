using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.network']/class[@name='MaxWidthImageLoader']"
	[global::Android.Runtime.Register ("com/mopub/network/MaxWidthImageLoader", DoNotGenerateAcw=true)]
	public partial class MaxWidthImageLoader : global::Com.Mopub.Volley.Toolbox.ImageLoader {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/network/MaxWidthImageLoader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MaxWidthImageLoader); }
		}

		protected MaxWidthImageLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mopub_volley_RequestQueue_Landroid_content_Context_Lcom_mopub_volley_toolbox_ImageLoader_ImageCache_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.network']/class[@name='MaxWidthImageLoader']/constructor[@name='MaxWidthImageLoader' and count(parameter)=3 and parameter[1][@type='com.mopub.volley.RequestQueue'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.mopub.volley.toolbox.ImageLoader.ImageCache']]"
		[Register (".ctor", "(Lcom/mopub/volley/RequestQueue;Landroid/content/Context;Lcom/mopub/volley/toolbox/ImageLoader$ImageCache;)V", "")]
		public unsafe MaxWidthImageLoader (global::Com.Mopub.Volley.RequestQueue p0, global::Android.Content.Context p1, global::Com.Mopub.Volley.Toolbox.ImageLoader.IImageCache p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (MaxWidthImageLoader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/volley/RequestQueue;Landroid/content/Context;Lcom/mopub/volley/toolbox/ImageLoader$ImageCache;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/volley/RequestQueue;Landroid/content/Context;Lcom/mopub/volley/toolbox/ImageLoader$ImageCache;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mopub_volley_RequestQueue_Landroid_content_Context_Lcom_mopub_volley_toolbox_ImageLoader_ImageCache_ == IntPtr.Zero)
					id_ctor_Lcom_mopub_volley_RequestQueue_Landroid_content_Context_Lcom_mopub_volley_toolbox_ImageLoader_ImageCache_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/volley/RequestQueue;Landroid/content/Context;Lcom/mopub/volley/toolbox/ImageLoader$ImageCache;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_volley_RequestQueue_Landroid_content_Context_Lcom_mopub_volley_toolbox_ImageLoader_ImageCache_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_volley_RequestQueue_Landroid_content_Context_Lcom_mopub_volley_toolbox_ImageLoader_ImageCache_, __args);
			} finally {
			}
		}

	}
}
