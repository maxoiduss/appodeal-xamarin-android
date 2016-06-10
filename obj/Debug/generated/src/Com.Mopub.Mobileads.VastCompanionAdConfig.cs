using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastCompanionAdConfig']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/VastCompanionAdConfig", DoNotGenerateAcw=true)]
	public partial class VastCompanionAdConfig : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/VastCompanionAdConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VastCompanionAdConfig); }
		}

		protected VastCompanionAdConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IILcom_mopub_mobileads_VastResource_Ljava_lang_String_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastCompanionAdConfig']/constructor[@name='VastCompanionAdConfig' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.mopub.mobileads.VastResource'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.util.List'] and parameter[6][@type='java.util.List']]"
		[Register (".ctor", "(IILcom/mopub/mobileads/VastResource;Ljava/lang/String;Ljava/util/List;Ljava/util/List;)V", "")]
		public unsafe VastCompanionAdConfig (int p0, int p1, global::Com.Mopub.Mobileads.VastResource p2, string p3, global::System.Collections.IList p4, global::System.Collections.IList p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaList.ToLocalJniHandle (p4);
			IntPtr native_p5 = global::Android.Runtime.JavaList.ToLocalJniHandle (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				if (GetType () != typeof (VastCompanionAdConfig)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IILcom/mopub/mobileads/VastResource;Ljava/lang/String;Ljava/util/List;Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IILcom/mopub/mobileads/VastResource;Ljava/lang/String;Ljava/util/List;Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_IILcom_mopub_mobileads_VastResource_Ljava_lang_String_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_IILcom_mopub_mobileads_VastResource_Ljava_lang_String_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IILcom/mopub/mobileads/VastResource;Ljava/lang/String;Ljava/util/List;Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IILcom_mopub_mobileads_VastResource_Ljava_lang_String_Ljava_util_List_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IILcom_mopub_mobileads_VastResource_Ljava_lang_String_Ljava_util_List_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_getClickThroughUrl;
#pragma warning disable 0169
		static Delegate GetGetClickThroughUrlHandler ()
		{
			if (cb_getClickThroughUrl == null)
				cb_getClickThroughUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClickThroughUrl);
			return cb_getClickThroughUrl;
		}

		static IntPtr n_GetClickThroughUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastCompanionAdConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastCompanionAdConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClickThroughUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getClickThroughUrl;
		public virtual unsafe string ClickThroughUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastCompanionAdConfig']/method[@name='getClickThroughUrl' and count(parameter)=0]"
			[Register ("getClickThroughUrl", "()Ljava/lang/String;", "GetGetClickThroughUrlHandler")]
			get {
				if (id_getClickThroughUrl == IntPtr.Zero)
					id_getClickThroughUrl = JNIEnv.GetMethodID (class_ref, "getClickThroughUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getClickThroughUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClickThroughUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClickTrackers;
#pragma warning disable 0169
		static Delegate GetGetClickTrackersHandler ()
		{
			if (cb_getClickTrackers == null)
				cb_getClickTrackers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClickTrackers);
			return cb_getClickTrackers;
		}

		static IntPtr n_GetClickTrackers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastCompanionAdConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastCompanionAdConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.ClickTrackers);
		}
#pragma warning restore 0169

		static IntPtr id_getClickTrackers;
		public virtual unsafe global::System.Collections.IList ClickTrackers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastCompanionAdConfig']/method[@name='getClickTrackers' and count(parameter)=0]"
			[Register ("getClickTrackers", "()Ljava/util/List;", "GetGetClickTrackersHandler")]
			get {
				if (id_getClickTrackers == IntPtr.Zero)
					id_getClickTrackers = JNIEnv.GetMethodID (class_ref, "getClickTrackers", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getClickTrackers), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClickTrackers", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCreativeViewTrackers;
#pragma warning disable 0169
		static Delegate GetGetCreativeViewTrackersHandler ()
		{
			if (cb_getCreativeViewTrackers == null)
				cb_getCreativeViewTrackers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreativeViewTrackers);
			return cb_getCreativeViewTrackers;
		}

		static IntPtr n_GetCreativeViewTrackers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Mobileads.VastCompanionAdConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastCompanionAdConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.CreativeViewTrackers);
		}
#pragma warning restore 0169

		static IntPtr id_getCreativeViewTrackers;
		public virtual unsafe global::System.Collections.IList CreativeViewTrackers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastCompanionAdConfig']/method[@name='getCreativeViewTrackers' and count(parameter)=0]"
			[Register ("getCreativeViewTrackers", "()Ljava/util/List;", "GetGetCreativeViewTrackersHandler")]
			get {
				if (id_getCreativeViewTrackers == IntPtr.Zero)
					id_getCreativeViewTrackers = JNIEnv.GetMethodID (class_ref, "getCreativeViewTrackers", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getCreativeViewTrackers), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreativeViewTrackers", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mopub.Mobileads.VastCompanionAdConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastCompanionAdConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastCompanionAdConfig']/method[@name='getHeight' and count(parameter)=0]"
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
			global::Com.Mopub.Mobileads.VastCompanionAdConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastCompanionAdConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastCompanionAdConfig']/method[@name='getWidth' and count(parameter)=0]"
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

		static Delegate cb_addClickTrackers_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddClickTrackers_Ljava_util_List_Handler ()
		{
			if (cb_addClickTrackers_Ljava_util_List_ == null)
				cb_addClickTrackers_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddClickTrackers_Ljava_util_List_);
			return cb_addClickTrackers_Ljava_util_List_;
		}

		static void n_AddClickTrackers_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastCompanionAdConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastCompanionAdConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddClickTrackers (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addClickTrackers_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastCompanionAdConfig']/method[@name='addClickTrackers' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("addClickTrackers", "(Ljava/util/List;)V", "GetAddClickTrackers_Ljava_util_List_Handler")]
		public virtual unsafe void AddClickTrackers (global::System.Collections.IList p0)
		{
			if (id_addClickTrackers_Ljava_util_List_ == IntPtr.Zero)
				id_addClickTrackers_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addClickTrackers", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addClickTrackers_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addClickTrackers", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addCreativeViewTrackers_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddCreativeViewTrackers_Ljava_util_List_Handler ()
		{
			if (cb_addCreativeViewTrackers_Ljava_util_List_ == null)
				cb_addCreativeViewTrackers_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddCreativeViewTrackers_Ljava_util_List_);
			return cb_addCreativeViewTrackers_Ljava_util_List_;
		}

		static void n_AddCreativeViewTrackers_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.VastCompanionAdConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastCompanionAdConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddCreativeViewTrackers (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addCreativeViewTrackers_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VastCompanionAdConfig']/method[@name='addCreativeViewTrackers' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("addCreativeViewTrackers", "(Ljava/util/List;)V", "GetAddCreativeViewTrackers_Ljava_util_List_Handler")]
		public virtual unsafe void AddCreativeViewTrackers (global::System.Collections.IList p0)
		{
			if (id_addCreativeViewTrackers_Ljava_util_List_ == IntPtr.Zero)
				id_addCreativeViewTrackers_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addCreativeViewTrackers", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addCreativeViewTrackers_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addCreativeViewTrackers", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
