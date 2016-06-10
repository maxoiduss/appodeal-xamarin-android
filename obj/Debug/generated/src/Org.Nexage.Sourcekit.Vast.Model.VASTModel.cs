using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Vast.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTModel']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/vast/model/VASTModel", DoNotGenerateAcw=true)]
	public partial class VASTModel : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/vast/model/VASTModel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VASTModel); }
		}

		protected VASTModel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_w3c_dom_Document_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTModel']/constructor[@name='VASTModel' and count(parameter)=1 and parameter[1][@type='org.w3c.dom.Document']]"
		[Register (".ctor", "(Lorg/w3c/dom/Document;)V", "")]
		public unsafe VASTModel (global::Org.W3c.Dom.IDocument p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (VASTModel)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/w3c/dom/Document;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/w3c/dom/Document;)V", __args);
					return;
				}

				if (id_ctor_Lorg_w3c_dom_Document_ == IntPtr.Zero)
					id_ctor_Lorg_w3c_dom_Document_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/w3c/dom/Document;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_w3c_dom_Document_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_w3c_dom_Document_, __args);
			} finally {
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDuration);
			return cb_getDuration;
		}

		static IntPtr n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTModel __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Duration);
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		public virtual unsafe string Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTModel']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()Ljava/lang/String;", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDuration), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDuration", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getErrorUrl;
#pragma warning disable 0169
		static Delegate GetGetErrorUrlHandler ()
		{
			if (cb_getErrorUrl == null)
				cb_getErrorUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorUrl);
			return cb_getErrorUrl;
		}

		static IntPtr n_GetErrorUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTModel __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.ErrorUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getErrorUrl;
		public virtual unsafe global::System.Collections.IList ErrorUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTModel']/method[@name='getErrorUrl' and count(parameter)=0]"
			[Register ("getErrorUrl", "()Ljava/util/List;", "GetGetErrorUrlHandler")]
			get {
				if (id_getErrorUrl == IntPtr.Zero)
					id_getErrorUrl = JNIEnv.GetMethodID (class_ref, "getErrorUrl", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getErrorUrl), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorUrl", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getImpressions;
#pragma warning disable 0169
		static Delegate GetGetImpressionsHandler ()
		{
			if (cb_getImpressions == null)
				cb_getImpressions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImpressions);
			return cb_getImpressions;
		}

		static IntPtr n_GetImpressions (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTModel __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.Impressions);
		}
#pragma warning restore 0169

		static IntPtr id_getImpressions;
		public virtual unsafe global::System.Collections.IList Impressions {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTModel']/method[@name='getImpressions' and count(parameter)=0]"
			[Register ("getImpressions", "()Ljava/util/List;", "GetGetImpressionsHandler")]
			get {
				if (id_getImpressions == IntPtr.Zero)
					id_getImpressions = JNIEnv.GetMethodID (class_ref, "getImpressions", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getImpressions), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImpressions", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMediaFiles;
#pragma warning disable 0169
		static Delegate GetGetMediaFilesHandler ()
		{
			if (cb_getMediaFiles == null)
				cb_getMediaFiles = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMediaFiles);
			return cb_getMediaFiles;
		}

		static IntPtr n_GetMediaFiles (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTModel __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.MediaFiles);
		}
#pragma warning restore 0169

		static IntPtr id_getMediaFiles;
		public virtual unsafe global::System.Collections.IList MediaFiles {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTModel']/method[@name='getMediaFiles' and count(parameter)=0]"
			[Register ("getMediaFiles", "()Ljava/util/List;", "GetGetMediaFilesHandler")]
			get {
				if (id_getMediaFiles == IntPtr.Zero)
					id_getMediaFiles = JNIEnv.GetMethodID (class_ref, "getMediaFiles", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getMediaFiles), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediaFiles", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPickedMediaFileURL;
#pragma warning disable 0169
		static Delegate GetGetPickedMediaFileURLHandler ()
		{
			if (cb_getPickedMediaFileURL == null)
				cb_getPickedMediaFileURL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPickedMediaFileURL);
			return cb_getPickedMediaFileURL;
		}

		static IntPtr n_GetPickedMediaFileURL (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTModel __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PickedMediaFileURL);
		}
#pragma warning restore 0169

		static Delegate cb_setPickedMediaFileURL_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPickedMediaFileURL_Ljava_lang_String_Handler ()
		{
			if (cb_setPickedMediaFileURL_Ljava_lang_String_ == null)
				cb_setPickedMediaFileURL_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPickedMediaFileURL_Ljava_lang_String_);
			return cb_setPickedMediaFileURL_Ljava_lang_String_;
		}

		static void n_SetPickedMediaFileURL_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTModel __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PickedMediaFileURL = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPickedMediaFileURL;
		static IntPtr id_setPickedMediaFileURL_Ljava_lang_String_;
		public virtual unsafe string PickedMediaFileURL {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTModel']/method[@name='getPickedMediaFileURL' and count(parameter)=0]"
			[Register ("getPickedMediaFileURL", "()Ljava/lang/String;", "GetGetPickedMediaFileURLHandler")]
			get {
				if (id_getPickedMediaFileURL == IntPtr.Zero)
					id_getPickedMediaFileURL = JNIEnv.GetMethodID (class_ref, "getPickedMediaFileURL", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPickedMediaFileURL), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPickedMediaFileURL", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTModel']/method[@name='setPickedMediaFileURL' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPickedMediaFileURL", "(Ljava/lang/String;)V", "GetSetPickedMediaFileURL_Ljava_lang_String_Handler")]
			set {
				if (id_setPickedMediaFileURL_Ljava_lang_String_ == IntPtr.Zero)
					id_setPickedMediaFileURL_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPickedMediaFileURL", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setPickedMediaFileURL_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPickedMediaFileURL", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTrackingUrls;
#pragma warning disable 0169
		static Delegate GetGetTrackingUrlsHandler ()
		{
			if (cb_getTrackingUrls == null)
				cb_getTrackingUrls = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackingUrls);
			return cb_getTrackingUrls;
		}

		static IntPtr n_GetTrackingUrls (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTModel __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary.ToLocalJniHandle (__this.TrackingUrls);
		}
#pragma warning restore 0169

		static IntPtr id_getTrackingUrls;
		public virtual unsafe global::System.Collections.IDictionary TrackingUrls {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTModel']/method[@name='getTrackingUrls' and count(parameter)=0]"
			[Register ("getTrackingUrls", "()Ljava/util/HashMap;", "GetGetTrackingUrlsHandler")]
			get {
				if (id_getTrackingUrls == IntPtr.Zero)
					id_getTrackingUrls = JNIEnv.GetMethodID (class_ref, "getTrackingUrls", "()Ljava/util/HashMap;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getTrackingUrls), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrackingUrls", "()Ljava/util/HashMap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVastsDocument;
#pragma warning disable 0169
		static Delegate GetGetVastsDocumentHandler ()
		{
			if (cb_getVastsDocument == null)
				cb_getVastsDocument = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVastsDocument);
			return cb_getVastsDocument;
		}

		static IntPtr n_GetVastsDocument (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTModel __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VastsDocument);
		}
#pragma warning restore 0169

		static IntPtr id_getVastsDocument;
		public virtual unsafe global::Org.W3c.Dom.IDocument VastsDocument {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTModel']/method[@name='getVastsDocument' and count(parameter)=0]"
			[Register ("getVastsDocument", "()Lorg/w3c/dom/Document;", "GetGetVastsDocumentHandler")]
			get {
				if (id_getVastsDocument == IntPtr.Zero)
					id_getVastsDocument = JNIEnv.GetMethodID (class_ref, "getVastsDocument", "()Lorg/w3c/dom/Document;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.W3c.Dom.IDocument> (JNIEnv.CallObjectMethod  (Handle, id_getVastsDocument), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.W3c.Dom.IDocument> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVastsDocument", "()Lorg/w3c/dom/Document;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoClicks;
#pragma warning disable 0169
		static Delegate GetGetVideoClicksHandler ()
		{
			if (cb_getVideoClicks == null)
				cb_getVideoClicks = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVideoClicks);
			return cb_getVideoClicks;
		}

		static IntPtr n_GetVideoClicks (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTModel __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VideoClicks);
		}
#pragma warning restore 0169

		static IntPtr id_getVideoClicks;
		public virtual unsafe global::Org.Nexage.Sourcekit.Vast.Model.VideoClicks VideoClicks {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTModel']/method[@name='getVideoClicks' and count(parameter)=0]"
			[Register ("getVideoClicks", "()Lorg/nexage/sourcekit/vast/model/VideoClicks;", "GetGetVideoClicksHandler")]
			get {
				if (id_getVideoClicks == IntPtr.Zero)
					id_getVideoClicks = JNIEnv.GetMethodID (class_ref, "getVideoClicks", "()Lorg/nexage/sourcekit/vast/model/VideoClicks;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VideoClicks> (JNIEnv.CallObjectMethod  (Handle, id_getVideoClicks), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VideoClicks> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoClicks", "()Lorg/nexage/sourcekit/vast/model/VideoClicks;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
