using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Vast.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VideoClicks']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/vast/model/VideoClicks", DoNotGenerateAcw=true)]
	public partial class VideoClicks : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/vast/model/VideoClicks", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoClicks); }
		}

		protected VideoClicks (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VideoClicks']/constructor[@name='VideoClicks' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VideoClicks ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VideoClicks)) {
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

		static Delegate cb_getClickThrough;
#pragma warning disable 0169
		static Delegate GetGetClickThroughHandler ()
		{
			if (cb_getClickThrough == null)
				cb_getClickThrough = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClickThrough);
			return cb_getClickThrough;
		}

		static IntPtr n_GetClickThrough (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VideoClicks __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VideoClicks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClickThrough);
		}
#pragma warning restore 0169

		static Delegate cb_setClickThrough_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClickThrough_Ljava_lang_String_Handler ()
		{
			if (cb_setClickThrough_Ljava_lang_String_ == null)
				cb_setClickThrough_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClickThrough_Ljava_lang_String_);
			return cb_setClickThrough_Ljava_lang_String_;
		}

		static void n_SetClickThrough_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VideoClicks __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VideoClicks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClickThrough = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClickThrough;
		static IntPtr id_setClickThrough_Ljava_lang_String_;
		public virtual unsafe string ClickThrough {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VideoClicks']/method[@name='getClickThrough' and count(parameter)=0]"
			[Register ("getClickThrough", "()Ljava/lang/String;", "GetGetClickThroughHandler")]
			get {
				if (id_getClickThrough == IntPtr.Zero)
					id_getClickThrough = JNIEnv.GetMethodID (class_ref, "getClickThrough", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getClickThrough), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClickThrough", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VideoClicks']/method[@name='setClickThrough' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClickThrough", "(Ljava/lang/String;)V", "GetSetClickThrough_Ljava_lang_String_Handler")]
			set {
				if (id_setClickThrough_Ljava_lang_String_ == IntPtr.Zero)
					id_setClickThrough_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setClickThrough", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setClickThrough_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClickThrough", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getClickTracking;
#pragma warning disable 0169
		static Delegate GetGetClickTrackingHandler ()
		{
			if (cb_getClickTracking == null)
				cb_getClickTracking = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClickTracking);
			return cb_getClickTracking;
		}

		static IntPtr n_GetClickTracking (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VideoClicks __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VideoClicks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.ClickTracking);
		}
#pragma warning restore 0169

		static IntPtr id_getClickTracking;
		public virtual unsafe global::System.Collections.IList ClickTracking {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VideoClicks']/method[@name='getClickTracking' and count(parameter)=0]"
			[Register ("getClickTracking", "()Ljava/util/List;", "GetGetClickTrackingHandler")]
			get {
				if (id_getClickTracking == IntPtr.Zero)
					id_getClickTracking = JNIEnv.GetMethodID (class_ref, "getClickTracking", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getClickTracking), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClickTracking", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCustomClick;
#pragma warning disable 0169
		static Delegate GetGetCustomClickHandler ()
		{
			if (cb_getCustomClick == null)
				cb_getCustomClick = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomClick);
			return cb_getCustomClick;
		}

		static IntPtr n_GetCustomClick (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VideoClicks __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VideoClicks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.CustomClick);
		}
#pragma warning restore 0169

		static IntPtr id_getCustomClick;
		public virtual unsafe global::System.Collections.IList CustomClick {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VideoClicks']/method[@name='getCustomClick' and count(parameter)=0]"
			[Register ("getCustomClick", "()Ljava/util/List;", "GetGetCustomClickHandler")]
			get {
				if (id_getCustomClick == IntPtr.Zero)
					id_getCustomClick = JNIEnv.GetMethodID (class_ref, "getCustomClick", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getCustomClick), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCustomClick", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
