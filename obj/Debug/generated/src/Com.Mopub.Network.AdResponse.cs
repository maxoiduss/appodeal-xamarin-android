using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse']"
	[global::Android.Runtime.Register ("com/mopub/network/AdResponse", DoNotGenerateAcw=true)]
	public partial class AdResponse : global::Java.Lang.Object, global::Java.IO.ISerializable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse.Builder']"
		[global::Android.Runtime.Register ("com/mopub/network/AdResponse$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/network/AdResponse$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse.Builder']/constructor[@name='AdResponse.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Builder)) {
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

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Network.AdResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/mopub/network/AdResponse;", "GetBuildHandler")]
			public virtual unsafe global::Com.Mopub.Network.AdResponse Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/mopub/network/AdResponse;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/mopub/network/AdResponse;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAdTimeoutDelayMilliseconds_Ljava_lang_Integer_;
#pragma warning disable 0169
			static Delegate GetSetAdTimeoutDelayMilliseconds_Ljava_lang_Integer_Handler ()
			{
				if (cb_setAdTimeoutDelayMilliseconds_Ljava_lang_Integer_ == null)
					cb_setAdTimeoutDelayMilliseconds_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAdTimeoutDelayMilliseconds_Ljava_lang_Integer_);
				return cb_setAdTimeoutDelayMilliseconds_Ljava_lang_Integer_;
			}

			static IntPtr n_SetAdTimeoutDelayMilliseconds_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Network.AdResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAdTimeoutDelayMilliseconds (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setAdTimeoutDelayMilliseconds_Ljava_lang_Integer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse.Builder']/method[@name='setAdTimeoutDelayMilliseconds' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setAdTimeoutDelayMilliseconds", "(Ljava/lang/Integer;)Lcom/mopub/network/AdResponse$Builder;", "GetSetAdTimeoutDelayMilliseconds_Ljava_lang_Integer_Handler")]
			public virtual unsafe global::Com.Mopub.Network.AdResponse.Builder SetAdTimeoutDelayMilliseconds (global::Java.Lang.Integer p0)
			{
				if (id_setAdTimeoutDelayMilliseconds_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setAdTimeoutDelayMilliseconds_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setAdTimeoutDelayMilliseconds", "(Ljava/lang/Integer;)Lcom/mopub/network/AdResponse$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mopub.Network.AdResponse.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setAdTimeoutDelayMilliseconds_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdTimeoutDelayMilliseconds", "(Ljava/lang/Integer;)Lcom/mopub/network/AdResponse$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setAdType_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetAdType_Ljava_lang_String_Handler ()
			{
				if (cb_setAdType_Ljava_lang_String_ == null)
					cb_setAdType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAdType_Ljava_lang_String_);
				return cb_setAdType_Ljava_lang_String_;
			}

			static IntPtr n_SetAdType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Network.AdResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAdType (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setAdType_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse.Builder']/method[@name='setAdType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAdType", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;", "GetSetAdType_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mopub.Network.AdResponse.Builder SetAdType (string p0)
			{
				if (id_setAdType_Ljava_lang_String_ == IntPtr.Zero)
					id_setAdType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAdType", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Network.AdResponse.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setAdType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdType", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setAdUnitId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetAdUnitId_Ljava_lang_String_Handler ()
			{
				if (cb_setAdUnitId_Ljava_lang_String_ == null)
					cb_setAdUnitId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAdUnitId_Ljava_lang_String_);
				return cb_setAdUnitId_Ljava_lang_String_;
			}

			static IntPtr n_SetAdUnitId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Network.AdResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAdUnitId (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setAdUnitId_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse.Builder']/method[@name='setAdUnitId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAdUnitId", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;", "GetSetAdUnitId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mopub.Network.AdResponse.Builder SetAdUnitId (string p0)
			{
				if (id_setAdUnitId_Ljava_lang_String_ == IntPtr.Zero)
					id_setAdUnitId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAdUnitId", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Network.AdResponse.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setAdUnitId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdUnitId", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setClickTrackingUrl_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetClickTrackingUrl_Ljava_lang_String_Handler ()
			{
				if (cb_setClickTrackingUrl_Ljava_lang_String_ == null)
					cb_setClickTrackingUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetClickTrackingUrl_Ljava_lang_String_);
				return cb_setClickTrackingUrl_Ljava_lang_String_;
			}

			static IntPtr n_SetClickTrackingUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Network.AdResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetClickTrackingUrl (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setClickTrackingUrl_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse.Builder']/method[@name='setClickTrackingUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClickTrackingUrl", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;", "GetSetClickTrackingUrl_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mopub.Network.AdResponse.Builder SetClickTrackingUrl (string p0)
			{
				if (id_setClickTrackingUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setClickTrackingUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setClickTrackingUrl", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Network.AdResponse.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setClickTrackingUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClickTrackingUrl", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setCustomEventClassName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetCustomEventClassName_Ljava_lang_String_Handler ()
			{
				if (cb_setCustomEventClassName_Ljava_lang_String_ == null)
					cb_setCustomEventClassName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCustomEventClassName_Ljava_lang_String_);
				return cb_setCustomEventClassName_Ljava_lang_String_;
			}

			static IntPtr n_SetCustomEventClassName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Network.AdResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCustomEventClassName (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setCustomEventClassName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse.Builder']/method[@name='setCustomEventClassName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCustomEventClassName", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;", "GetSetCustomEventClassName_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mopub.Network.AdResponse.Builder SetCustomEventClassName (string p0)
			{
				if (id_setCustomEventClassName_Ljava_lang_String_ == IntPtr.Zero)
					id_setCustomEventClassName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCustomEventClassName", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Network.AdResponse.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setCustomEventClassName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomEventClassName", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setDimensions_Ljava_lang_Integer_Ljava_lang_Integer_;
#pragma warning disable 0169
			static Delegate GetSetDimensions_Ljava_lang_Integer_Ljava_lang_Integer_Handler ()
			{
				if (cb_setDimensions_Ljava_lang_Integer_Ljava_lang_Integer_ == null)
					cb_setDimensions_Ljava_lang_Integer_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDimensions_Ljava_lang_Integer_Ljava_lang_Integer_);
				return cb_setDimensions_Ljava_lang_Integer_Ljava_lang_Integer_;
			}

			static IntPtr n_SetDimensions_Ljava_lang_Integer_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mopub.Network.AdResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDimensions (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setDimensions_Ljava_lang_Integer_Ljava_lang_Integer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse.Builder']/method[@name='setDimensions' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.Integer']]"
			[Register ("setDimensions", "(Ljava/lang/Integer;Ljava/lang/Integer;)Lcom/mopub/network/AdResponse$Builder;", "GetSetDimensions_Ljava_lang_Integer_Ljava_lang_Integer_Handler")]
			public virtual unsafe global::Com.Mopub.Network.AdResponse.Builder SetDimensions (global::Java.Lang.Integer p0, global::Java.Lang.Integer p1)
			{
				if (id_setDimensions_Ljava_lang_Integer_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setDimensions_Ljava_lang_Integer_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setDimensions", "(Ljava/lang/Integer;Ljava/lang/Integer;)Lcom/mopub/network/AdResponse$Builder;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					global::Com.Mopub.Network.AdResponse.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setDimensions_Ljava_lang_Integer_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDimensions", "(Ljava/lang/Integer;Ljava/lang/Integer;)Lcom/mopub/network/AdResponse$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setDspCreativeId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetDspCreativeId_Ljava_lang_String_Handler ()
			{
				if (cb_setDspCreativeId_Ljava_lang_String_ == null)
					cb_setDspCreativeId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDspCreativeId_Ljava_lang_String_);
				return cb_setDspCreativeId_Ljava_lang_String_;
			}

			static IntPtr n_SetDspCreativeId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Network.AdResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDspCreativeId (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setDspCreativeId_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse.Builder']/method[@name='setDspCreativeId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDspCreativeId", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;", "GetSetDspCreativeId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mopub.Network.AdResponse.Builder SetDspCreativeId (string p0)
			{
				if (id_setDspCreativeId_Ljava_lang_String_ == IntPtr.Zero)
					id_setDspCreativeId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDspCreativeId", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Network.AdResponse.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setDspCreativeId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDspCreativeId", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setFailoverUrl_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetFailoverUrl_Ljava_lang_String_Handler ()
			{
				if (cb_setFailoverUrl_Ljava_lang_String_ == null)
					cb_setFailoverUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFailoverUrl_Ljava_lang_String_);
				return cb_setFailoverUrl_Ljava_lang_String_;
			}

			static IntPtr n_SetFailoverUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Network.AdResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFailoverUrl (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setFailoverUrl_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse.Builder']/method[@name='setFailoverUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFailoverUrl", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;", "GetSetFailoverUrl_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mopub.Network.AdResponse.Builder SetFailoverUrl (string p0)
			{
				if (id_setFailoverUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setFailoverUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFailoverUrl", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Network.AdResponse.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setFailoverUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFailoverUrl", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setFullAdType_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetFullAdType_Ljava_lang_String_Handler ()
			{
				if (cb_setFullAdType_Ljava_lang_String_ == null)
					cb_setFullAdType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFullAdType_Ljava_lang_String_);
				return cb_setFullAdType_Ljava_lang_String_;
			}

			static IntPtr n_SetFullAdType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Network.AdResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFullAdType (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setFullAdType_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse.Builder']/method[@name='setFullAdType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFullAdType", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;", "GetSetFullAdType_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mopub.Network.AdResponse.Builder SetFullAdType (string p0)
			{
				if (id_setFullAdType_Ljava_lang_String_ == IntPtr.Zero)
					id_setFullAdType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFullAdType", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Network.AdResponse.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setFullAdType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFullAdType", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setImpressionTrackingUrl_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetImpressionTrackingUrl_Ljava_lang_String_Handler ()
			{
				if (cb_setImpressionTrackingUrl_Ljava_lang_String_ == null)
					cb_setImpressionTrackingUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetImpressionTrackingUrl_Ljava_lang_String_);
				return cb_setImpressionTrackingUrl_Ljava_lang_String_;
			}

			static IntPtr n_SetImpressionTrackingUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Network.AdResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetImpressionTrackingUrl (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setImpressionTrackingUrl_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse.Builder']/method[@name='setImpressionTrackingUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setImpressionTrackingUrl", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;", "GetSetImpressionTrackingUrl_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mopub.Network.AdResponse.Builder SetImpressionTrackingUrl (string p0)
			{
				if (id_setImpressionTrackingUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setImpressionTrackingUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setImpressionTrackingUrl", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Network.AdResponse.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setImpressionTrackingUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImpressionTrackingUrl", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setJsonBody_Lorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetSetJsonBody_Lorg_json_JSONObject_Handler ()
			{
				if (cb_setJsonBody_Lorg_json_JSONObject_ == null)
					cb_setJsonBody_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetJsonBody_Lorg_json_JSONObject_);
				return cb_setJsonBody_Lorg_json_JSONObject_;
			}

			static IntPtr n_SetJsonBody_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Network.AdResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetJsonBody (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setJsonBody_Lorg_json_JSONObject_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse.Builder']/method[@name='setJsonBody' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("setJsonBody", "(Lorg/json/JSONObject;)Lcom/mopub/network/AdResponse$Builder;", "GetSetJsonBody_Lorg_json_JSONObject_Handler")]
			public virtual unsafe global::Com.Mopub.Network.AdResponse.Builder SetJsonBody (global::Org.Json.JSONObject p0)
			{
				if (id_setJsonBody_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_setJsonBody_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setJsonBody", "(Lorg/json/JSONObject;)Lcom/mopub/network/AdResponse$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mopub.Network.AdResponse.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setJsonBody_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setJsonBody", "(Lorg/json/JSONObject;)Lcom/mopub/network/AdResponse$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setNetworkType_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetNetworkType_Ljava_lang_String_Handler ()
			{
				if (cb_setNetworkType_Ljava_lang_String_ == null)
					cb_setNetworkType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetNetworkType_Ljava_lang_String_);
				return cb_setNetworkType_Ljava_lang_String_;
			}

			static IntPtr n_SetNetworkType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Network.AdResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNetworkType (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setNetworkType_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse.Builder']/method[@name='setNetworkType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNetworkType", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;", "GetSetNetworkType_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mopub.Network.AdResponse.Builder SetNetworkType (string p0)
			{
				if (id_setNetworkType_Ljava_lang_String_ == IntPtr.Zero)
					id_setNetworkType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNetworkType", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Network.AdResponse.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setNetworkType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNetworkType", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setRedirectUrl_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetRedirectUrl_Ljava_lang_String_Handler ()
			{
				if (cb_setRedirectUrl_Ljava_lang_String_ == null)
					cb_setRedirectUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRedirectUrl_Ljava_lang_String_);
				return cb_setRedirectUrl_Ljava_lang_String_;
			}

			static IntPtr n_SetRedirectUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Network.AdResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRedirectUrl (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setRedirectUrl_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse.Builder']/method[@name='setRedirectUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRedirectUrl", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;", "GetSetRedirectUrl_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mopub.Network.AdResponse.Builder SetRedirectUrl (string p0)
			{
				if (id_setRedirectUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setRedirectUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRedirectUrl", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Network.AdResponse.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setRedirectUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRedirectUrl", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setRefreshTimeMilliseconds_Ljava_lang_Integer_;
#pragma warning disable 0169
			static Delegate GetSetRefreshTimeMilliseconds_Ljava_lang_Integer_Handler ()
			{
				if (cb_setRefreshTimeMilliseconds_Ljava_lang_Integer_ == null)
					cb_setRefreshTimeMilliseconds_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRefreshTimeMilliseconds_Ljava_lang_Integer_);
				return cb_setRefreshTimeMilliseconds_Ljava_lang_Integer_;
			}

			static IntPtr n_SetRefreshTimeMilliseconds_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Network.AdResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRefreshTimeMilliseconds (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setRefreshTimeMilliseconds_Ljava_lang_Integer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse.Builder']/method[@name='setRefreshTimeMilliseconds' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setRefreshTimeMilliseconds", "(Ljava/lang/Integer;)Lcom/mopub/network/AdResponse$Builder;", "GetSetRefreshTimeMilliseconds_Ljava_lang_Integer_Handler")]
			public virtual unsafe global::Com.Mopub.Network.AdResponse.Builder SetRefreshTimeMilliseconds (global::Java.Lang.Integer p0)
			{
				if (id_setRefreshTimeMilliseconds_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setRefreshTimeMilliseconds_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setRefreshTimeMilliseconds", "(Ljava/lang/Integer;)Lcom/mopub/network/AdResponse$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mopub.Network.AdResponse.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setRefreshTimeMilliseconds_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRefreshTimeMilliseconds", "(Ljava/lang/Integer;)Lcom/mopub/network/AdResponse$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setRequestId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetRequestId_Ljava_lang_String_Handler ()
			{
				if (cb_setRequestId_Ljava_lang_String_ == null)
					cb_setRequestId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRequestId_Ljava_lang_String_);
				return cb_setRequestId_Ljava_lang_String_;
			}

			static IntPtr n_SetRequestId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Network.AdResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRequestId (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setRequestId_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse.Builder']/method[@name='setRequestId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRequestId", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;", "GetSetRequestId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mopub.Network.AdResponse.Builder SetRequestId (string p0)
			{
				if (id_setRequestId_Ljava_lang_String_ == IntPtr.Zero)
					id_setRequestId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRequestId", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Network.AdResponse.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setRequestId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequestId", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setResponseBody_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetResponseBody_Ljava_lang_String_Handler ()
			{
				if (cb_setResponseBody_Ljava_lang_String_ == null)
					cb_setResponseBody_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetResponseBody_Ljava_lang_String_);
				return cb_setResponseBody_Ljava_lang_String_;
			}

			static IntPtr n_SetResponseBody_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Network.AdResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetResponseBody (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setResponseBody_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse.Builder']/method[@name='setResponseBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setResponseBody", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;", "GetSetResponseBody_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mopub.Network.AdResponse.Builder SetResponseBody (string p0)
			{
				if (id_setResponseBody_Ljava_lang_String_ == IntPtr.Zero)
					id_setResponseBody_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setResponseBody", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Network.AdResponse.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setResponseBody_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResponseBody", "(Ljava/lang/String;)Lcom/mopub/network/AdResponse$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setScrollable_Ljava_lang_Boolean_;
#pragma warning disable 0169
			static Delegate GetSetScrollable_Ljava_lang_Boolean_Handler ()
			{
				if (cb_setScrollable_Ljava_lang_Boolean_ == null)
					cb_setScrollable_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetScrollable_Ljava_lang_Boolean_);
				return cb_setScrollable_Ljava_lang_Boolean_;
			}

			static IntPtr n_SetScrollable_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Network.AdResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetScrollable (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setScrollable_Ljava_lang_Boolean_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse.Builder']/method[@name='setScrollable' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setScrollable", "(Ljava/lang/Boolean;)Lcom/mopub/network/AdResponse$Builder;", "GetSetScrollable_Ljava_lang_Boolean_Handler")]
			public virtual unsafe global::Com.Mopub.Network.AdResponse.Builder SetScrollable (global::Java.Lang.Boolean p0)
			{
				if (id_setScrollable_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_setScrollable_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setScrollable", "(Ljava/lang/Boolean;)Lcom/mopub/network/AdResponse$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mopub.Network.AdResponse.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setScrollable_Ljava_lang_Boolean_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScrollable", "(Ljava/lang/Boolean;)Lcom/mopub/network/AdResponse$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setServerExtras_Ljava_util_Map_;
#pragma warning disable 0169
			static Delegate GetSetServerExtras_Ljava_util_Map_Handler ()
			{
				if (cb_setServerExtras_Ljava_util_Map_ == null)
					cb_setServerExtras_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetServerExtras_Ljava_util_Map_);
				return cb_setServerExtras_Ljava_util_Map_;
			}

			static IntPtr n_SetServerExtras_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Network.AdResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetServerExtras (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setServerExtras_Ljava_util_Map_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse.Builder']/method[@name='setServerExtras' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
			[Register ("setServerExtras", "(Ljava/util/Map;)Lcom/mopub/network/AdResponse$Builder;", "GetSetServerExtras_Ljava_util_Map_Handler")]
			public virtual unsafe global::Com.Mopub.Network.AdResponse.Builder SetServerExtras (global::System.Collections.IDictionary p0)
			{
				if (id_setServerExtras_Ljava_util_Map_ == IntPtr.Zero)
					id_setServerExtras_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setServerExtras", "(Ljava/util/Map;)Lcom/mopub/network/AdResponse$Builder;");
				IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mopub.Network.AdResponse.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setServerExtras_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setServerExtras", "(Ljava/util/Map;)Lcom/mopub/network/AdResponse$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/network/AdResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdResponse); }
		}

		protected AdResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAdTimeoutMillis;
#pragma warning disable 0169
		static Delegate GetGetAdTimeoutMillisHandler ()
		{
			if (cb_getAdTimeoutMillis == null)
				cb_getAdTimeoutMillis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdTimeoutMillis);
			return cb_getAdTimeoutMillis;
		}

		static IntPtr n_GetAdTimeoutMillis (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.AdResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdTimeoutMillis);
		}
#pragma warning restore 0169

		static IntPtr id_getAdTimeoutMillis;
		public virtual unsafe global::Java.Lang.Integer AdTimeoutMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse']/method[@name='getAdTimeoutMillis' and count(parameter)=0]"
			[Register ("getAdTimeoutMillis", "()Ljava/lang/Integer;", "GetGetAdTimeoutMillisHandler")]
			get {
				if (id_getAdTimeoutMillis == IntPtr.Zero)
					id_getAdTimeoutMillis = JNIEnv.GetMethodID (class_ref, "getAdTimeoutMillis", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getAdTimeoutMillis), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdTimeoutMillis", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdType;
#pragma warning disable 0169
		static Delegate GetGetAdTypeHandler ()
		{
			if (cb_getAdType == null)
				cb_getAdType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdType);
			return cb_getAdType;
		}

		static IntPtr n_GetAdType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.AdResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdType);
		}
#pragma warning restore 0169

		static IntPtr id_getAdType;
		public virtual unsafe string AdType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse']/method[@name='getAdType' and count(parameter)=0]"
			[Register ("getAdType", "()Ljava/lang/String;", "GetGetAdTypeHandler")]
			get {
				if (id_getAdType == IntPtr.Zero)
					id_getAdType = JNIEnv.GetMethodID (class_ref, "getAdType", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAdType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdUnitId;
#pragma warning disable 0169
		static Delegate GetGetAdUnitIdHandler ()
		{
			if (cb_getAdUnitId == null)
				cb_getAdUnitId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdUnitId);
			return cb_getAdUnitId;
		}

		static IntPtr n_GetAdUnitId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.AdResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdUnitId);
		}
#pragma warning restore 0169

		static IntPtr id_getAdUnitId;
		public virtual unsafe string AdUnitId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse']/method[@name='getAdUnitId' and count(parameter)=0]"
			[Register ("getAdUnitId", "()Ljava/lang/String;", "GetGetAdUnitIdHandler")]
			get {
				if (id_getAdUnitId == IntPtr.Zero)
					id_getAdUnitId = JNIEnv.GetMethodID (class_ref, "getAdUnitId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAdUnitId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdUnitId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClickTrackingUrl;
#pragma warning disable 0169
		static Delegate GetGetClickTrackingUrlHandler ()
		{
			if (cb_getClickTrackingUrl == null)
				cb_getClickTrackingUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClickTrackingUrl);
			return cb_getClickTrackingUrl;
		}

		static IntPtr n_GetClickTrackingUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.AdResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClickTrackingUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getClickTrackingUrl;
		public virtual unsafe string ClickTrackingUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse']/method[@name='getClickTrackingUrl' and count(parameter)=0]"
			[Register ("getClickTrackingUrl", "()Ljava/lang/String;", "GetGetClickTrackingUrlHandler")]
			get {
				if (id_getClickTrackingUrl == IntPtr.Zero)
					id_getClickTrackingUrl = JNIEnv.GetMethodID (class_ref, "getClickTrackingUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getClickTrackingUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClickTrackingUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCustomEventClassName;
#pragma warning disable 0169
		static Delegate GetGetCustomEventClassNameHandler ()
		{
			if (cb_getCustomEventClassName == null)
				cb_getCustomEventClassName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomEventClassName);
			return cb_getCustomEventClassName;
		}

		static IntPtr n_GetCustomEventClassName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.AdResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CustomEventClassName);
		}
#pragma warning restore 0169

		static IntPtr id_getCustomEventClassName;
		public virtual unsafe string CustomEventClassName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse']/method[@name='getCustomEventClassName' and count(parameter)=0]"
			[Register ("getCustomEventClassName", "()Ljava/lang/String;", "GetGetCustomEventClassNameHandler")]
			get {
				if (id_getCustomEventClassName == IntPtr.Zero)
					id_getCustomEventClassName = JNIEnv.GetMethodID (class_ref, "getCustomEventClassName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCustomEventClassName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCustomEventClassName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDspCreativeId;
#pragma warning disable 0169
		static Delegate GetGetDspCreativeIdHandler ()
		{
			if (cb_getDspCreativeId == null)
				cb_getDspCreativeId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDspCreativeId);
			return cb_getDspCreativeId;
		}

		static IntPtr n_GetDspCreativeId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.AdResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DspCreativeId);
		}
#pragma warning restore 0169

		static IntPtr id_getDspCreativeId;
		public virtual unsafe string DspCreativeId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse']/method[@name='getDspCreativeId' and count(parameter)=0]"
			[Register ("getDspCreativeId", "()Ljava/lang/String;", "GetGetDspCreativeIdHandler")]
			get {
				if (id_getDspCreativeId == IntPtr.Zero)
					id_getDspCreativeId = JNIEnv.GetMethodID (class_ref, "getDspCreativeId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDspCreativeId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDspCreativeId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFailoverUrl;
#pragma warning disable 0169
		static Delegate GetGetFailoverUrlHandler ()
		{
			if (cb_getFailoverUrl == null)
				cb_getFailoverUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFailoverUrl);
			return cb_getFailoverUrl;
		}

		static IntPtr n_GetFailoverUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.AdResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FailoverUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getFailoverUrl;
		public virtual unsafe string FailoverUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse']/method[@name='getFailoverUrl' and count(parameter)=0]"
			[Register ("getFailoverUrl", "()Ljava/lang/String;", "GetGetFailoverUrlHandler")]
			get {
				if (id_getFailoverUrl == IntPtr.Zero)
					id_getFailoverUrl = JNIEnv.GetMethodID (class_ref, "getFailoverUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFailoverUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFailoverUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFullAdType;
#pragma warning disable 0169
		static Delegate GetGetFullAdTypeHandler ()
		{
			if (cb_getFullAdType == null)
				cb_getFullAdType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFullAdType);
			return cb_getFullAdType;
		}

		static IntPtr n_GetFullAdType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.AdResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FullAdType);
		}
#pragma warning restore 0169

		static IntPtr id_getFullAdType;
		public virtual unsafe string FullAdType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse']/method[@name='getFullAdType' and count(parameter)=0]"
			[Register ("getFullAdType", "()Ljava/lang/String;", "GetGetFullAdTypeHandler")]
			get {
				if (id_getFullAdType == IntPtr.Zero)
					id_getFullAdType = JNIEnv.GetMethodID (class_ref, "getFullAdType", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFullAdType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFullAdType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasJson;
#pragma warning disable 0169
		static Delegate GetHasJsonHandler ()
		{
			if (cb_hasJson == null)
				cb_hasJson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasJson);
			return cb_hasJson;
		}

		static bool n_HasJson (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.AdResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasJson;
		}
#pragma warning restore 0169

		static IntPtr id_hasJson;
		public virtual unsafe bool HasJson {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse']/method[@name='hasJson' and count(parameter)=0]"
			[Register ("hasJson", "()Z", "GetHasJsonHandler")]
			get {
				if (id_hasJson == IntPtr.Zero)
					id_hasJson = JNIEnv.GetMethodID (class_ref, "hasJson", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_hasJson);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasJson", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeight);
			return cb_getHeight;
		}

		static IntPtr n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.AdResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Height);
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual unsafe global::Java.Lang.Integer Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()Ljava/lang/Integer;", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getHeight), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getImpressionTrackingUrl;
#pragma warning disable 0169
		static Delegate GetGetImpressionTrackingUrlHandler ()
		{
			if (cb_getImpressionTrackingUrl == null)
				cb_getImpressionTrackingUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImpressionTrackingUrl);
			return cb_getImpressionTrackingUrl;
		}

		static IntPtr n_GetImpressionTrackingUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.AdResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImpressionTrackingUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getImpressionTrackingUrl;
		public virtual unsafe string ImpressionTrackingUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse']/method[@name='getImpressionTrackingUrl' and count(parameter)=0]"
			[Register ("getImpressionTrackingUrl", "()Ljava/lang/String;", "GetGetImpressionTrackingUrlHandler")]
			get {
				if (id_getImpressionTrackingUrl == IntPtr.Zero)
					id_getImpressionTrackingUrl = JNIEnv.GetMethodID (class_ref, "getImpressionTrackingUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getImpressionTrackingUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImpressionTrackingUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isScrollable;
#pragma warning disable 0169
		static Delegate GetIsScrollableHandler ()
		{
			if (cb_isScrollable == null)
				cb_isScrollable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsScrollable);
			return cb_isScrollable;
		}

		static bool n_IsScrollable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.AdResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsScrollable;
		}
#pragma warning restore 0169

		static IntPtr id_isScrollable;
		public virtual unsafe bool IsScrollable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse']/method[@name='isScrollable' and count(parameter)=0]"
			[Register ("isScrollable", "()Z", "GetIsScrollableHandler")]
			get {
				if (id_isScrollable == IntPtr.Zero)
					id_isScrollable = JNIEnv.GetMethodID (class_ref, "isScrollable", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isScrollable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isScrollable", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getJsonBody;
#pragma warning disable 0169
		static Delegate GetGetJsonBodyHandler ()
		{
			if (cb_getJsonBody == null)
				cb_getJsonBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJsonBody);
			return cb_getJsonBody;
		}

		static IntPtr n_GetJsonBody (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.AdResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JsonBody);
		}
#pragma warning restore 0169

		static IntPtr id_getJsonBody;
		public virtual unsafe global::Org.Json.JSONObject JsonBody {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse']/method[@name='getJsonBody' and count(parameter)=0]"
			[Register ("getJsonBody", "()Lorg/json/JSONObject;", "GetGetJsonBodyHandler")]
			get {
				if (id_getJsonBody == IntPtr.Zero)
					id_getJsonBody = JNIEnv.GetMethodID (class_ref, "getJsonBody", "()Lorg/json/JSONObject;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getJsonBody), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJsonBody", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNetworkType;
#pragma warning disable 0169
		static Delegate GetGetNetworkTypeHandler ()
		{
			if (cb_getNetworkType == null)
				cb_getNetworkType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetworkType);
			return cb_getNetworkType;
		}

		static IntPtr n_GetNetworkType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.AdResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NetworkType);
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkType;
		public virtual unsafe string NetworkType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse']/method[@name='getNetworkType' and count(parameter)=0]"
			[Register ("getNetworkType", "()Ljava/lang/String;", "GetGetNetworkTypeHandler")]
			get {
				if (id_getNetworkType == IntPtr.Zero)
					id_getNetworkType = JNIEnv.GetMethodID (class_ref, "getNetworkType", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNetworkType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetworkType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRedirectUrl;
#pragma warning disable 0169
		static Delegate GetGetRedirectUrlHandler ()
		{
			if (cb_getRedirectUrl == null)
				cb_getRedirectUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRedirectUrl);
			return cb_getRedirectUrl;
		}

		static IntPtr n_GetRedirectUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.AdResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RedirectUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getRedirectUrl;
		public virtual unsafe string RedirectUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse']/method[@name='getRedirectUrl' and count(parameter)=0]"
			[Register ("getRedirectUrl", "()Ljava/lang/String;", "GetGetRedirectUrlHandler")]
			get {
				if (id_getRedirectUrl == IntPtr.Zero)
					id_getRedirectUrl = JNIEnv.GetMethodID (class_ref, "getRedirectUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRedirectUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRedirectUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRefreshTimeMillis;
#pragma warning disable 0169
		static Delegate GetGetRefreshTimeMillisHandler ()
		{
			if (cb_getRefreshTimeMillis == null)
				cb_getRefreshTimeMillis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRefreshTimeMillis);
			return cb_getRefreshTimeMillis;
		}

		static IntPtr n_GetRefreshTimeMillis (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.AdResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RefreshTimeMillis);
		}
#pragma warning restore 0169

		static IntPtr id_getRefreshTimeMillis;
		public virtual unsafe global::Java.Lang.Integer RefreshTimeMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse']/method[@name='getRefreshTimeMillis' and count(parameter)=0]"
			[Register ("getRefreshTimeMillis", "()Ljava/lang/Integer;", "GetGetRefreshTimeMillisHandler")]
			get {
				if (id_getRefreshTimeMillis == IntPtr.Zero)
					id_getRefreshTimeMillis = JNIEnv.GetMethodID (class_ref, "getRefreshTimeMillis", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getRefreshTimeMillis), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRefreshTimeMillis", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestId;
#pragma warning disable 0169
		static Delegate GetGetRequestIdHandler ()
		{
			if (cb_getRequestId == null)
				cb_getRequestId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestId);
			return cb_getRequestId;
		}

		static IntPtr n_GetRequestId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.AdResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestId);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestId;
		public virtual unsafe string RequestId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse']/method[@name='getRequestId' and count(parameter)=0]"
			[Register ("getRequestId", "()Ljava/lang/String;", "GetGetRequestIdHandler")]
			get {
				if (id_getRequestId == IntPtr.Zero)
					id_getRequestId = JNIEnv.GetMethodID (class_ref, "getRequestId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRequestId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getServerExtras;
#pragma warning disable 0169
		static Delegate GetGetServerExtrasHandler ()
		{
			if (cb_getServerExtras == null)
				cb_getServerExtras = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServerExtras);
			return cb_getServerExtras;
		}

		static IntPtr n_GetServerExtras (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.AdResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary.ToLocalJniHandle (__this.ServerExtras);
		}
#pragma warning restore 0169

		static IntPtr id_getServerExtras;
		public virtual unsafe global::System.Collections.IDictionary ServerExtras {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse']/method[@name='getServerExtras' and count(parameter)=0]"
			[Register ("getServerExtras", "()Ljava/util/Map;", "GetGetServerExtrasHandler")]
			get {
				if (id_getServerExtras == IntPtr.Zero)
					id_getServerExtras = JNIEnv.GetMethodID (class_ref, "getServerExtras", "()Ljava/util/Map;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getServerExtras), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServerExtras", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStringBody;
#pragma warning disable 0169
		static Delegate GetGetStringBodyHandler ()
		{
			if (cb_getStringBody == null)
				cb_getStringBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStringBody);
			return cb_getStringBody;
		}

		static IntPtr n_GetStringBody (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.AdResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StringBody);
		}
#pragma warning restore 0169

		static IntPtr id_getStringBody;
		public virtual unsafe string StringBody {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse']/method[@name='getStringBody' and count(parameter)=0]"
			[Register ("getStringBody", "()Ljava/lang/String;", "GetGetStringBodyHandler")]
			get {
				if (id_getStringBody == IntPtr.Zero)
					id_getStringBody = JNIEnv.GetMethodID (class_ref, "getStringBody", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getStringBody), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStringBody", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTimestamp;
#pragma warning disable 0169
		static Delegate GetGetTimestampHandler ()
		{
			if (cb_getTimestamp == null)
				cb_getTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimestamp);
			return cb_getTimestamp;
		}

		static long n_GetTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.AdResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timestamp;
		}
#pragma warning restore 0169

		static IntPtr id_getTimestamp;
		public virtual unsafe long Timestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse']/method[@name='getTimestamp' and count(parameter)=0]"
			[Register ("getTimestamp", "()J", "GetGetTimestampHandler")]
			get {
				if (id_getTimestamp == IntPtr.Zero)
					id_getTimestamp = JNIEnv.GetMethodID (class_ref, "getTimestamp", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getTimestamp);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimestamp", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWidth);
			return cb_getWidth;
		}

		static IntPtr n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.AdResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Width);
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual unsafe global::Java.Lang.Integer Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()Ljava/lang/Integer;", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getWidth), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_toBuilder;
#pragma warning disable 0169
		static Delegate GetToBuilderHandler ()
		{
			if (cb_toBuilder == null)
				cb_toBuilder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToBuilder);
			return cb_toBuilder;
		}

		static IntPtr n_ToBuilder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.AdResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToBuilder ());
		}
#pragma warning restore 0169

		static IntPtr id_toBuilder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='AdResponse']/method[@name='toBuilder' and count(parameter)=0]"
		[Register ("toBuilder", "()Lcom/mopub/network/AdResponse$Builder;", "GetToBuilderHandler")]
		public virtual unsafe global::Com.Mopub.Network.AdResponse.Builder ToBuilder ()
		{
			if (id_toBuilder == IntPtr.Zero)
				id_toBuilder = JNIEnv.GetMethodID (class_ref, "toBuilder", "()Lcom/mopub/network/AdResponse$Builder;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallObjectMethod  (Handle, id_toBuilder), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toBuilder", "()Lcom/mopub/network/AdResponse$Builder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
