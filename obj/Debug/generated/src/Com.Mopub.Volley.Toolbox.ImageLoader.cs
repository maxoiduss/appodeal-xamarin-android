using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley.Toolbox {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ImageLoader']"
	[global::Android.Runtime.Register ("com/mopub/volley/toolbox/ImageLoader", DoNotGenerateAcw=true)]
	public partial class ImageLoader : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ImageLoader.BatchedImageRequest']"
		[global::Android.Runtime.Register ("com/mopub/volley/toolbox/ImageLoader$BatchedImageRequest", DoNotGenerateAcw=true)]
		public partial class BatchedImageRequest : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/volley/toolbox/ImageLoader$BatchedImageRequest", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BatchedImageRequest); }
			}

			protected BatchedImageRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_mopub_volley_toolbox_ImageLoader_Lcom_mopub_volley_Request_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ImageLoader.BatchedImageRequest']/constructor[@name='ImageLoader.BatchedImageRequest' and count(parameter)=3 and parameter[1][@type='com.mopub.volley.toolbox.ImageLoader'] and parameter[2][@type='com.mopub.volley.Request'] and parameter[3][@type='com.mopub.volley.toolbox.ImageLoader.ImageContainer']]"
			[Register (".ctor", "(Lcom/mopub/volley/toolbox/ImageLoader;Lcom/mopub/volley/Request;Lcom/mopub/volley/toolbox/ImageLoader$ImageContainer;)V", "")]
			public unsafe BatchedImageRequest (global::Com.Mopub.Volley.Toolbox.ImageLoader __self, global::Com.Mopub.Volley.Request p1, global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (BatchedImageRequest)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/mopub/volley/Request;Lcom/mopub/volley/toolbox/ImageLoader$ImageContainer;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/mopub/volley/Request;Lcom/mopub/volley/toolbox/ImageLoader$ImageContainer;)V", __args);
						return;
					}

					if (id_ctor_Lcom_mopub_volley_toolbox_ImageLoader_Lcom_mopub_volley_Request_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_ == IntPtr.Zero)
						id_ctor_Lcom_mopub_volley_toolbox_ImageLoader_Lcom_mopub_volley_Request_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/volley/toolbox/ImageLoader;Lcom/mopub/volley/Request;Lcom/mopub/volley/toolbox/ImageLoader$ImageContainer;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_volley_toolbox_ImageLoader_Lcom_mopub_volley_Request_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_volley_toolbox_ImageLoader_Lcom_mopub_volley_Request_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_, __args);
				} finally {
				}
			}

			static Delegate cb_getError;
#pragma warning disable 0169
			static Delegate GetGetErrorHandler ()
			{
				if (cb_getError == null)
					cb_getError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetError);
				return cb_getError;
			}

			static IntPtr n_GetError (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Volley.Toolbox.ImageLoader.BatchedImageRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader.BatchedImageRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Error);
			}
#pragma warning restore 0169

			static Delegate cb_setError_Lcom_mopub_volley_VolleyError_;
#pragma warning disable 0169
			static Delegate GetSetError_Lcom_mopub_volley_VolleyError_Handler ()
			{
				if (cb_setError_Lcom_mopub_volley_VolleyError_ == null)
					cb_setError_Lcom_mopub_volley_VolleyError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetError_Lcom_mopub_volley_VolleyError_);
				return cb_setError_Lcom_mopub_volley_VolleyError_;
			}

			static void n_SetError_Lcom_mopub_volley_VolleyError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Volley.Toolbox.ImageLoader.BatchedImageRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader.BatchedImageRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Volley.VolleyError p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.VolleyError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Error = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getError;
			static IntPtr id_setError_Lcom_mopub_volley_VolleyError_;
			public virtual unsafe global::Com.Mopub.Volley.VolleyError Error {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ImageLoader.BatchedImageRequest']/method[@name='getError' and count(parameter)=0]"
				[Register ("getError", "()Lcom/mopub/volley/VolleyError;", "GetGetErrorHandler")]
				get {
					if (id_getError == IntPtr.Zero)
						id_getError = JNIEnv.GetMethodID (class_ref, "getError", "()Lcom/mopub/volley/VolleyError;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.VolleyError> (JNIEnv.CallObjectMethod  (Handle, id_getError), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.VolleyError> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getError", "()Lcom/mopub/volley/VolleyError;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ImageLoader.BatchedImageRequest']/method[@name='setError' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.VolleyError']]"
				[Register ("setError", "(Lcom/mopub/volley/VolleyError;)V", "GetSetError_Lcom_mopub_volley_VolleyError_Handler")]
				set {
					if (id_setError_Lcom_mopub_volley_VolleyError_ == IntPtr.Zero)
						id_setError_Lcom_mopub_volley_VolleyError_ = JNIEnv.GetMethodID (class_ref, "setError", "(Lcom/mopub/volley/VolleyError;)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setError_Lcom_mopub_volley_VolleyError_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setError", "(Lcom/mopub/volley/VolleyError;)V"), __args);
					} finally {
					}
				}
			}

			static Delegate cb_addContainer_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_;
#pragma warning disable 0169
			static Delegate GetAddContainer_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_Handler ()
			{
				if (cb_addContainer_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_ == null)
					cb_addContainer_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddContainer_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_);
				return cb_addContainer_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_;
			}

			static void n_AddContainer_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Volley.Toolbox.ImageLoader.BatchedImageRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader.BatchedImageRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.AddContainer (p0);
			}
#pragma warning restore 0169

			static IntPtr id_addContainer_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ImageLoader.BatchedImageRequest']/method[@name='addContainer' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.toolbox.ImageLoader.ImageContainer']]"
			[Register ("addContainer", "(Lcom/mopub/volley/toolbox/ImageLoader$ImageContainer;)V", "GetAddContainer_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_Handler")]
			public virtual unsafe void AddContainer (global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer p0)
			{
				if (id_addContainer_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_ == IntPtr.Zero)
					id_addContainer_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_ = JNIEnv.GetMethodID (class_ref, "addContainer", "(Lcom/mopub/volley/toolbox/ImageLoader$ImageContainer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_addContainer_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addContainer", "(Lcom/mopub/volley/toolbox/ImageLoader$ImageContainer;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_removeContainerAndCancelIfNecessary_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_;
#pragma warning disable 0169
			static Delegate GetRemoveContainerAndCancelIfNecessary_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_Handler ()
			{
				if (cb_removeContainerAndCancelIfNecessary_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_ == null)
					cb_removeContainerAndCancelIfNecessary_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveContainerAndCancelIfNecessary_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_);
				return cb_removeContainerAndCancelIfNecessary_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_;
			}

			static bool n_RemoveContainerAndCancelIfNecessary_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Volley.Toolbox.ImageLoader.BatchedImageRequest __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader.BatchedImageRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.RemoveContainerAndCancelIfNecessary (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_removeContainerAndCancelIfNecessary_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ImageLoader.BatchedImageRequest']/method[@name='removeContainerAndCancelIfNecessary' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.toolbox.ImageLoader.ImageContainer']]"
			[Register ("removeContainerAndCancelIfNecessary", "(Lcom/mopub/volley/toolbox/ImageLoader$ImageContainer;)Z", "GetRemoveContainerAndCancelIfNecessary_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_Handler")]
			public virtual unsafe bool RemoveContainerAndCancelIfNecessary (global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer p0)
			{
				if (id_removeContainerAndCancelIfNecessary_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_ == IntPtr.Zero)
					id_removeContainerAndCancelIfNecessary_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_ = JNIEnv.GetMethodID (class_ref, "removeContainerAndCancelIfNecessary", "(Lcom/mopub/volley/toolbox/ImageLoader$ImageContainer;)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					bool __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod  (Handle, id_removeContainerAndCancelIfNecessary_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeContainerAndCancelIfNecessary", "(Lcom/mopub/volley/toolbox/ImageLoader$ImageContainer;)Z"), __args);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.volley.toolbox']/interface[@name='ImageLoader.ImageCache']"
		[Register ("com/mopub/volley/toolbox/ImageLoader$ImageCache", "", "Com.Mopub.Volley.Toolbox.ImageLoader/IImageCacheInvoker")]
		public partial interface IImageCache : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/interface[@name='ImageLoader.ImageCache']/method[@name='getBitmap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getBitmap", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "GetGetBitmap_Ljava_lang_String_Handler:Com.Mopub.Volley.Toolbox.ImageLoader/IImageCacheInvoker, AppodealXamarinPlugin")]
			global::Android.Graphics.Bitmap GetBitmap (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/interface[@name='ImageLoader.ImageCache']/method[@name='putBitmap' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap']]"
			[Register ("putBitmap", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V", "GetPutBitmap_Ljava_lang_String_Landroid_graphics_Bitmap_Handler:Com.Mopub.Volley.Toolbox.ImageLoader/IImageCacheInvoker, AppodealXamarinPlugin")]
			void PutBitmap (string p0, global::Android.Graphics.Bitmap p1);

		}

		[global::Android.Runtime.Register ("com/mopub/volley/toolbox/ImageLoader$ImageCache", DoNotGenerateAcw=true)]
		internal class IImageCacheInvoker : global::Java.Lang.Object, IImageCache {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/volley/toolbox/ImageLoader$ImageCache");
			IntPtr class_ref;

			public static IImageCache GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IImageCache> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.volley.toolbox.ImageLoader.ImageCache"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IImageCacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IImageCacheInvoker); }
			}

			static Delegate cb_getBitmap_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetBitmap_Ljava_lang_String_Handler ()
			{
				if (cb_getBitmap_Ljava_lang_String_ == null)
					cb_getBitmap_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBitmap_Ljava_lang_String_);
				return cb_getBitmap_Ljava_lang_String_;
			}

			static IntPtr n_GetBitmap_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Volley.Toolbox.ImageLoader.IImageCache __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader.IImageCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBitmap (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_getBitmap_Ljava_lang_String_;
			public unsafe global::Android.Graphics.Bitmap GetBitmap (string p0)
			{
				if (id_getBitmap_Ljava_lang_String_ == IntPtr.Zero)
					id_getBitmap_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBitmap", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (Handle, id_getBitmap_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_putBitmap_Ljava_lang_String_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetPutBitmap_Ljava_lang_String_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_putBitmap_Ljava_lang_String_Landroid_graphics_Bitmap_ == null)
					cb_putBitmap_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PutBitmap_Ljava_lang_String_Landroid_graphics_Bitmap_);
				return cb_putBitmap_Ljava_lang_String_Landroid_graphics_Bitmap_;
			}

			static void n_PutBitmap_Ljava_lang_String_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mopub.Volley.Toolbox.ImageLoader.IImageCache __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader.IImageCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.PutBitmap (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_putBitmap_Ljava_lang_String_Landroid_graphics_Bitmap_;
			public unsafe void PutBitmap (string p0, global::Android.Graphics.Bitmap p1)
			{
				if (id_putBitmap_Ljava_lang_String_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_putBitmap_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "putBitmap", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_putBitmap_Ljava_lang_String_Landroid_graphics_Bitmap_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ImageLoader.ImageContainer']"
		[global::Android.Runtime.Register ("com/mopub/volley/toolbox/ImageLoader$ImageContainer", DoNotGenerateAcw=true)]
		public partial class ImageContainer : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/volley/toolbox/ImageLoader$ImageContainer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ImageContainer); }
			}

			protected ImageContainer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_mopub_volley_toolbox_ImageLoader_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ImageLoader.ImageContainer']/constructor[@name='ImageLoader.ImageContainer' and count(parameter)=5 and parameter[1][@type='com.mopub.volley.toolbox.ImageLoader'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.mopub.volley.toolbox.ImageLoader.ImageListener']]"
			[Register (".ctor", "(Lcom/mopub/volley/toolbox/ImageLoader;Landroid/graphics/Bitmap;Ljava/lang/String;Ljava/lang/String;Lcom/mopub/volley/toolbox/ImageLoader$ImageListener;)V", "")]
			public unsafe ImageContainer (global::Com.Mopub.Volley.Toolbox.ImageLoader __self, global::Android.Graphics.Bitmap p1, string p2, string p3, global::Com.Mopub.Volley.Toolbox.ImageLoader.IImageListener p4)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p2 = JNIEnv.NewString (p2);
				IntPtr native_p3 = JNIEnv.NewString (p3);
				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (native_p3);
					__args [4] = new JValue (p4);
					if (GetType () != typeof (ImageContainer)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/graphics/Bitmap;Ljava/lang/String;Ljava/lang/String;Lcom/mopub/volley/toolbox/ImageLoader$ImageListener;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/graphics/Bitmap;Ljava/lang/String;Ljava/lang/String;Lcom/mopub/volley/toolbox/ImageLoader$ImageListener;)V", __args);
						return;
					}

					if (id_ctor_Lcom_mopub_volley_toolbox_ImageLoader_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_ == IntPtr.Zero)
						id_ctor_Lcom_mopub_volley_toolbox_ImageLoader_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/volley/toolbox/ImageLoader;Landroid/graphics/Bitmap;Ljava/lang/String;Ljava/lang/String;Lcom/mopub/volley/toolbox/ImageLoader$ImageListener;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_volley_toolbox_ImageLoader_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_volley_toolbox_ImageLoader_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p2);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}

			static Delegate cb_getBitmap;
#pragma warning disable 0169
			static Delegate GetGetBitmapHandler ()
			{
				if (cb_getBitmap == null)
					cb_getBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBitmap);
				return cb_getBitmap;
			}

			static IntPtr n_GetBitmap (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Bitmap);
			}
#pragma warning restore 0169

			static IntPtr id_getBitmap;
			public virtual unsafe global::Android.Graphics.Bitmap Bitmap {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ImageLoader.ImageContainer']/method[@name='getBitmap' and count(parameter)=0]"
				[Register ("getBitmap", "()Landroid/graphics/Bitmap;", "GetGetBitmapHandler")]
				get {
					if (id_getBitmap == IntPtr.Zero)
						id_getBitmap = JNIEnv.GetMethodID (class_ref, "getBitmap", "()Landroid/graphics/Bitmap;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_getBitmap), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitmap", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getRequestUrl;
#pragma warning disable 0169
			static Delegate GetGetRequestUrlHandler ()
			{
				if (cb_getRequestUrl == null)
					cb_getRequestUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestUrl);
				return cb_getRequestUrl;
			}

			static IntPtr n_GetRequestUrl (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.RequestUrl);
			}
#pragma warning restore 0169

			static IntPtr id_getRequestUrl;
			public virtual unsafe string RequestUrl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ImageLoader.ImageContainer']/method[@name='getRequestUrl' and count(parameter)=0]"
				[Register ("getRequestUrl", "()Ljava/lang/String;", "GetGetRequestUrlHandler")]
				get {
					if (id_getRequestUrl == IntPtr.Zero)
						id_getRequestUrl = JNIEnv.GetMethodID (class_ref, "getRequestUrl", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRequestUrl), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_cancelRequest;
#pragma warning disable 0169
			static Delegate GetCancelRequestHandler ()
			{
				if (cb_cancelRequest == null)
					cb_cancelRequest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelRequest);
				return cb_cancelRequest;
			}

			static void n_CancelRequest (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.CancelRequest ();
			}
#pragma warning restore 0169

			static IntPtr id_cancelRequest;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ImageLoader.ImageContainer']/method[@name='cancelRequest' and count(parameter)=0]"
			[Register ("cancelRequest", "()V", "GetCancelRequestHandler")]
			public virtual unsafe void CancelRequest ()
			{
				if (id_cancelRequest == IntPtr.Zero)
					id_cancelRequest = JNIEnv.GetMethodID (class_ref, "cancelRequest", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_cancelRequest);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelRequest", "()V"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.volley.toolbox']/interface[@name='ImageLoader.ImageListener']"
		[Register ("com/mopub/volley/toolbox/ImageLoader$ImageListener", "", "Com.Mopub.Volley.Toolbox.ImageLoader/IImageListenerInvoker")]
		public partial interface IImageListener : global::Com.Mopub.Volley.Response.IErrorListener {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/interface[@name='ImageLoader.ImageListener']/method[@name='onResponse' and count(parameter)=2 and parameter[1][@type='com.mopub.volley.toolbox.ImageLoader.ImageContainer'] and parameter[2][@type='boolean']]"
			[Register ("onResponse", "(Lcom/mopub/volley/toolbox/ImageLoader$ImageContainer;Z)V", "GetOnResponse_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_ZHandler:Com.Mopub.Volley.Toolbox.ImageLoader/IImageListenerInvoker, AppodealXamarinPlugin")]
			void OnResponse (global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer p0, bool p1);

		}

		[global::Android.Runtime.Register ("com/mopub/volley/toolbox/ImageLoader$ImageListener", DoNotGenerateAcw=true)]
		internal class IImageListenerInvoker : global::Java.Lang.Object, IImageListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/volley/toolbox/ImageLoader$ImageListener");
			IntPtr class_ref;

			public static IImageListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IImageListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.volley.toolbox.ImageLoader.ImageListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IImageListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IImageListenerInvoker); }
			}

			static Delegate cb_onResponse_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_Z;
#pragma warning disable 0169
			static Delegate GetOnResponse_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_ZHandler ()
			{
				if (cb_onResponse_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_Z == null)
					cb_onResponse_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnResponse_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_Z);
				return cb_onResponse_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_Z;
			}

			static void n_OnResponse_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
			{
				global::Com.Mopub.Volley.Toolbox.ImageLoader.IImageListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader.IImageListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnResponse (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onResponse_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_Z;
			public unsafe void OnResponse (global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer p0, bool p1)
			{
				if (id_onResponse_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_Z == IntPtr.Zero)
					id_onResponse_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_Z = JNIEnv.GetMethodID (class_ref, "onResponse", "(Lcom/mopub/volley/toolbox/ImageLoader$ImageContainer;Z)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_onResponse_Lcom_mopub_volley_toolbox_ImageLoader_ImageContainer_Z, __args);
			}

			static Delegate cb_onErrorResponse_Lcom_mopub_volley_VolleyError_;
#pragma warning disable 0169
			static Delegate GetOnErrorResponse_Lcom_mopub_volley_VolleyError_Handler ()
			{
				if (cb_onErrorResponse_Lcom_mopub_volley_VolleyError_ == null)
					cb_onErrorResponse_Lcom_mopub_volley_VolleyError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnErrorResponse_Lcom_mopub_volley_VolleyError_);
				return cb_onErrorResponse_Lcom_mopub_volley_VolleyError_;
			}

			static void n_OnErrorResponse_Lcom_mopub_volley_VolleyError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Volley.Toolbox.ImageLoader.IImageListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader.IImageListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Volley.VolleyError p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.VolleyError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnErrorResponse (p0);
			}
#pragma warning restore 0169

			IntPtr id_onErrorResponse_Lcom_mopub_volley_VolleyError_;
			public unsafe void OnErrorResponse (global::Com.Mopub.Volley.VolleyError p0)
			{
				if (id_onErrorResponse_Lcom_mopub_volley_VolleyError_ == IntPtr.Zero)
					id_onErrorResponse_Lcom_mopub_volley_VolleyError_ = JNIEnv.GetMethodID (class_ref, "onErrorResponse", "(Lcom/mopub/volley/VolleyError;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onErrorResponse_Lcom_mopub_volley_VolleyError_, __args);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/toolbox/ImageLoader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageLoader); }
		}

		protected ImageLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mopub_volley_RequestQueue_Lcom_mopub_volley_toolbox_ImageLoader_ImageCache_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ImageLoader']/constructor[@name='ImageLoader' and count(parameter)=2 and parameter[1][@type='com.mopub.volley.RequestQueue'] and parameter[2][@type='com.mopub.volley.toolbox.ImageLoader.ImageCache']]"
		[Register (".ctor", "(Lcom/mopub/volley/RequestQueue;Lcom/mopub/volley/toolbox/ImageLoader$ImageCache;)V", "")]
		public unsafe ImageLoader (global::Com.Mopub.Volley.RequestQueue p0, global::Com.Mopub.Volley.Toolbox.ImageLoader.IImageCache p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ImageLoader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/volley/RequestQueue;Lcom/mopub/volley/toolbox/ImageLoader$ImageCache;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/volley/RequestQueue;Lcom/mopub/volley/toolbox/ImageLoader$ImageCache;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mopub_volley_RequestQueue_Lcom_mopub_volley_toolbox_ImageLoader_ImageCache_ == IntPtr.Zero)
					id_ctor_Lcom_mopub_volley_RequestQueue_Lcom_mopub_volley_toolbox_ImageLoader_ImageCache_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/volley/RequestQueue;Lcom/mopub/volley/toolbox/ImageLoader$ImageCache;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_volley_RequestQueue_Lcom_mopub_volley_toolbox_ImageLoader_ImageCache_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_volley_RequestQueue_Lcom_mopub_volley_toolbox_ImageLoader_ImageCache_, __args);
			} finally {
			}
		}

		static Delegate cb_get_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_Handler ()
		{
			if (cb_get_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_ == null)
				cb_get_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_);
			return cb_get_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_;
		}

		static IntPtr n_Get_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Volley.Toolbox.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.Toolbox.ImageLoader.IImageListener p1 = (global::Com.Mopub.Volley.Toolbox.ImageLoader.IImageListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader.IImageListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ImageLoader']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.volley.toolbox.ImageLoader.ImageListener']]"
		[Register ("get", "(Ljava/lang/String;Lcom/mopub/volley/toolbox/ImageLoader$ImageListener;)Lcom/mopub/volley/toolbox/ImageLoader$ImageContainer;", "GetGet_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_Handler")]
		public virtual unsafe global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer Get (string p0, global::Com.Mopub.Volley.Toolbox.ImageLoader.IImageListener p1)
		{
			if (id_get_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_ == IntPtr.Zero)
				id_get_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Lcom/mopub/volley/toolbox/ImageLoader$ImageListener;)Lcom/mopub/volley/toolbox/ImageLoader$ImageContainer;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer> (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;Lcom/mopub/volley/toolbox/ImageLoader$ImageListener;)Lcom/mopub/volley/toolbox/ImageLoader$ImageContainer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_get_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_II;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_IIHandler ()
		{
			if (cb_get_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_II == null)
				cb_get_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_Get_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_II);
			return cb_get_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_II;
		}

		static IntPtr n_Get_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			global::Com.Mopub.Volley.Toolbox.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.Toolbox.ImageLoader.IImageListener p1 = (global::Com.Mopub.Volley.Toolbox.ImageLoader.IImageListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader.IImageListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ImageLoader']/method[@name='get' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.volley.toolbox.ImageLoader.ImageListener'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("get", "(Ljava/lang/String;Lcom/mopub/volley/toolbox/ImageLoader$ImageListener;II)Lcom/mopub/volley/toolbox/ImageLoader$ImageContainer;", "GetGet_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_IIHandler")]
		public virtual unsafe global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer Get (string p0, global::Com.Mopub.Volley.Toolbox.ImageLoader.IImageListener p1, int p2, int p3)
		{
			if (id_get_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_II == IntPtr.Zero)
				id_get_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_II = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Lcom/mopub/volley/toolbox/ImageLoader$ImageListener;II)Lcom/mopub/volley/toolbox/ImageLoader$ImageContainer;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer> (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_Lcom_mopub_volley_toolbox_ImageLoader_ImageListener_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader.ImageContainer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;Lcom/mopub/volley/toolbox/ImageLoader$ImageListener;II)Lcom/mopub/volley/toolbox/ImageLoader$ImageContainer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getImageListener_Landroid_widget_ImageView_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ImageLoader']/method[@name='getImageListener' and count(parameter)=3 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getImageListener", "(Landroid/widget/ImageView;II)Lcom/mopub/volley/toolbox/ImageLoader$ImageListener;", "")]
		public static unsafe global::Com.Mopub.Volley.Toolbox.ImageLoader.IImageListener GetImageListener (global::Android.Widget.ImageView p0, int p1, int p2)
		{
			if (id_getImageListener_Landroid_widget_ImageView_II == IntPtr.Zero)
				id_getImageListener_Landroid_widget_ImageView_II = JNIEnv.GetStaticMethodID (class_ref, "getImageListener", "(Landroid/widget/ImageView;II)Lcom/mopub/volley/toolbox/ImageLoader$ImageListener;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Mopub.Volley.Toolbox.ImageLoader.IImageListener __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader.IImageListener> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getImageListener_Landroid_widget_ImageView_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isCached_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetIsCached_Ljava_lang_String_IIHandler ()
		{
			if (cb_isCached_Ljava_lang_String_II == null)
				cb_isCached_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool>) n_IsCached_Ljava_lang_String_II);
			return cb_isCached_Ljava_lang_String_II;
		}

		static bool n_IsCached_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Mopub.Volley.Toolbox.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsCached (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isCached_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ImageLoader']/method[@name='isCached' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("isCached", "(Ljava/lang/String;II)Z", "GetIsCached_Ljava_lang_String_IIHandler")]
		public virtual unsafe bool IsCached (string p0, int p1, int p2)
		{
			if (id_isCached_Ljava_lang_String_II == IntPtr.Zero)
				id_isCached_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "isCached", "(Ljava/lang/String;II)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_isCached_Ljava_lang_String_II, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCached", "(Ljava/lang/String;II)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_makeImageRequest_Ljava_lang_String_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMakeImageRequest_Ljava_lang_String_IILjava_lang_String_Handler ()
		{
			if (cb_makeImageRequest_Ljava_lang_String_IILjava_lang_String_ == null)
				cb_makeImageRequest_Ljava_lang_String_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_MakeImageRequest_Ljava_lang_String_IILjava_lang_String_);
			return cb_makeImageRequest_Ljava_lang_String_IILjava_lang_String_;
		}

		static IntPtr n_MakeImageRequest_Ljava_lang_String_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			global::Com.Mopub.Volley.Toolbox.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MakeImageRequest (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_makeImageRequest_Ljava_lang_String_IILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ImageLoader']/method[@name='makeImageRequest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("makeImageRequest", "(Ljava/lang/String;IILjava/lang/String;)Lcom/mopub/volley/Request;", "GetMakeImageRequest_Ljava_lang_String_IILjava_lang_String_Handler")]
		protected virtual unsafe global::Com.Mopub.Volley.Request MakeImageRequest (string p0, int p1, int p2, string p3)
		{
			if (id_makeImageRequest_Ljava_lang_String_IILjava_lang_String_ == IntPtr.Zero)
				id_makeImageRequest_Ljava_lang_String_IILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "makeImageRequest", "(Ljava/lang/String;IILjava/lang/String;)Lcom/mopub/volley/Request;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);

				global::Com.Mopub.Volley.Request __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (JNIEnv.CallObjectMethod  (Handle, id_makeImageRequest_Ljava_lang_String_IILjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "makeImageRequest", "(Ljava/lang/String;IILjava/lang/String;)Lcom/mopub/volley/Request;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_onGetImageError_Ljava_lang_String_Lcom_mopub_volley_VolleyError_;
#pragma warning disable 0169
		static Delegate GetOnGetImageError_Ljava_lang_String_Lcom_mopub_volley_VolleyError_Handler ()
		{
			if (cb_onGetImageError_Ljava_lang_String_Lcom_mopub_volley_VolleyError_ == null)
				cb_onGetImageError_Ljava_lang_String_Lcom_mopub_volley_VolleyError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnGetImageError_Ljava_lang_String_Lcom_mopub_volley_VolleyError_);
			return cb_onGetImageError_Ljava_lang_String_Lcom_mopub_volley_VolleyError_;
		}

		static void n_OnGetImageError_Ljava_lang_String_Lcom_mopub_volley_VolleyError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Volley.Toolbox.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.VolleyError p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.VolleyError> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnGetImageError (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onGetImageError_Ljava_lang_String_Lcom_mopub_volley_VolleyError_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ImageLoader']/method[@name='onGetImageError' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.volley.VolleyError']]"
		[Register ("onGetImageError", "(Ljava/lang/String;Lcom/mopub/volley/VolleyError;)V", "GetOnGetImageError_Ljava_lang_String_Lcom_mopub_volley_VolleyError_Handler")]
		protected virtual unsafe void OnGetImageError (string p0, global::Com.Mopub.Volley.VolleyError p1)
		{
			if (id_onGetImageError_Ljava_lang_String_Lcom_mopub_volley_VolleyError_ == IntPtr.Zero)
				id_onGetImageError_Ljava_lang_String_Lcom_mopub_volley_VolleyError_ = JNIEnv.GetMethodID (class_ref, "onGetImageError", "(Ljava/lang/String;Lcom/mopub/volley/VolleyError;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onGetImageError_Ljava_lang_String_Lcom_mopub_volley_VolleyError_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onGetImageError", "(Ljava/lang/String;Lcom/mopub/volley/VolleyError;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onGetImageSuccess_Ljava_lang_String_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetOnGetImageSuccess_Ljava_lang_String_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_onGetImageSuccess_Ljava_lang_String_Landroid_graphics_Bitmap_ == null)
				cb_onGetImageSuccess_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnGetImageSuccess_Ljava_lang_String_Landroid_graphics_Bitmap_);
			return cb_onGetImageSuccess_Ljava_lang_String_Landroid_graphics_Bitmap_;
		}

		static void n_OnGetImageSuccess_Ljava_lang_String_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Volley.Toolbox.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnGetImageSuccess (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onGetImageSuccess_Ljava_lang_String_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ImageLoader']/method[@name='onGetImageSuccess' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("onGetImageSuccess", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V", "GetOnGetImageSuccess_Ljava_lang_String_Landroid_graphics_Bitmap_Handler")]
		protected virtual unsafe void OnGetImageSuccess (string p0, global::Android.Graphics.Bitmap p1)
		{
			if (id_onGetImageSuccess_Ljava_lang_String_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_onGetImageSuccess_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "onGetImageSuccess", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onGetImageSuccess_Ljava_lang_String_Landroid_graphics_Bitmap_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onGetImageSuccess", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setBatchedResponseDelay_I;
#pragma warning disable 0169
		static Delegate GetSetBatchedResponseDelay_IHandler ()
		{
			if (cb_setBatchedResponseDelay_I == null)
				cb_setBatchedResponseDelay_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBatchedResponseDelay_I);
			return cb_setBatchedResponseDelay_I;
		}

		static void n_SetBatchedResponseDelay_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Volley.Toolbox.ImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Toolbox.ImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBatchedResponseDelay (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBatchedResponseDelay_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley.toolbox']/class[@name='ImageLoader']/method[@name='setBatchedResponseDelay' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBatchedResponseDelay", "(I)V", "GetSetBatchedResponseDelay_IHandler")]
		public virtual unsafe void SetBatchedResponseDelay (int p0)
		{
			if (id_setBatchedResponseDelay_I == IntPtr.Zero)
				id_setBatchedResponseDelay_I = JNIEnv.GetMethodID (class_ref, "setBatchedResponseDelay", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setBatchedResponseDelay_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBatchedResponseDelay", "(I)V"), __args);
			} finally {
			}
		}

	}
}
