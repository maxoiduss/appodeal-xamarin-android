using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Vast.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTMediaFile']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/vast/model/VASTMediaFile", DoNotGenerateAcw=true)]
	public partial class VASTMediaFile : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/vast/model/VASTMediaFile", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VASTMediaFile); }
		}

		protected VASTMediaFile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTMediaFile']/constructor[@name='VASTMediaFile' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VASTMediaFile ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VASTMediaFile)) {
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

		static Delegate cb_getApiFramework;
#pragma warning disable 0169
		static Delegate GetGetApiFrameworkHandler ()
		{
			if (cb_getApiFramework == null)
				cb_getApiFramework = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApiFramework);
			return cb_getApiFramework;
		}

		static IntPtr n_GetApiFramework (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApiFramework);
		}
#pragma warning restore 0169

		static Delegate cb_setApiFramework_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetApiFramework_Ljava_lang_String_Handler ()
		{
			if (cb_setApiFramework_Ljava_lang_String_ == null)
				cb_setApiFramework_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetApiFramework_Ljava_lang_String_);
			return cb_setApiFramework_Ljava_lang_String_;
		}

		static void n_SetApiFramework_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ApiFramework = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getApiFramework;
		static IntPtr id_setApiFramework_Ljava_lang_String_;
		public virtual unsafe string ApiFramework {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTMediaFile']/method[@name='getApiFramework' and count(parameter)=0]"
			[Register ("getApiFramework", "()Ljava/lang/String;", "GetGetApiFrameworkHandler")]
			get {
				if (id_getApiFramework == IntPtr.Zero)
					id_getApiFramework = JNIEnv.GetMethodID (class_ref, "getApiFramework", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getApiFramework), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApiFramework", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTMediaFile']/method[@name='setApiFramework' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setApiFramework", "(Ljava/lang/String;)V", "GetSetApiFramework_Ljava_lang_String_Handler")]
			set {
				if (id_setApiFramework_Ljava_lang_String_ == IntPtr.Zero)
					id_setApiFramework_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApiFramework", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setApiFramework_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setApiFramework", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBitrate;
#pragma warning disable 0169
		static Delegate GetGetBitrateHandler ()
		{
			if (cb_getBitrate == null)
				cb_getBitrate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBitrate);
			return cb_getBitrate;
		}

		static IntPtr n_GetBitrate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Bitrate);
		}
#pragma warning restore 0169

		static Delegate cb_setBitrate_Ljava_math_BigInteger_;
#pragma warning disable 0169
		static Delegate GetSetBitrate_Ljava_math_BigInteger_Handler ()
		{
			if (cb_setBitrate_Ljava_math_BigInteger_ == null)
				cb_setBitrate_Ljava_math_BigInteger_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBitrate_Ljava_math_BigInteger_);
			return cb_setBitrate_Ljava_math_BigInteger_;
		}

		static void n_SetBitrate_Ljava_math_BigInteger_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Math.BigInteger p0 = global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Bitrate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBitrate;
		static IntPtr id_setBitrate_Ljava_math_BigInteger_;
		public virtual unsafe global::Java.Math.BigInteger Bitrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTMediaFile']/method[@name='getBitrate' and count(parameter)=0]"
			[Register ("getBitrate", "()Ljava/math/BigInteger;", "GetGetBitrateHandler")]
			get {
				if (id_getBitrate == IntPtr.Zero)
					id_getBitrate = JNIEnv.GetMethodID (class_ref, "getBitrate", "()Ljava/math/BigInteger;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallObjectMethod  (Handle, id_getBitrate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitrate", "()Ljava/math/BigInteger;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTMediaFile']/method[@name='setBitrate' and count(parameter)=1 and parameter[1][@type='java.math.BigInteger']]"
			[Register ("setBitrate", "(Ljava/math/BigInteger;)V", "GetSetBitrate_Ljava_math_BigInteger_Handler")]
			set {
				if (id_setBitrate_Ljava_math_BigInteger_ == IntPtr.Zero)
					id_setBitrate_Ljava_math_BigInteger_ = JNIEnv.GetMethodID (class_ref, "setBitrate", "(Ljava/math/BigInteger;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBitrate_Ljava_math_BigInteger_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBitrate", "(Ljava/math/BigInteger;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDelivery;
#pragma warning disable 0169
		static Delegate GetGetDeliveryHandler ()
		{
			if (cb_getDelivery == null)
				cb_getDelivery = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDelivery);
			return cb_getDelivery;
		}

		static IntPtr n_GetDelivery (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Delivery);
		}
#pragma warning restore 0169

		static Delegate cb_setDelivery_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDelivery_Ljava_lang_String_Handler ()
		{
			if (cb_setDelivery_Ljava_lang_String_ == null)
				cb_setDelivery_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDelivery_Ljava_lang_String_);
			return cb_setDelivery_Ljava_lang_String_;
		}

		static void n_SetDelivery_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Delivery = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDelivery;
		static IntPtr id_setDelivery_Ljava_lang_String_;
		public virtual unsafe string Delivery {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTMediaFile']/method[@name='getDelivery' and count(parameter)=0]"
			[Register ("getDelivery", "()Ljava/lang/String;", "GetGetDeliveryHandler")]
			get {
				if (id_getDelivery == IntPtr.Zero)
					id_getDelivery = JNIEnv.GetMethodID (class_ref, "getDelivery", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDelivery), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDelivery", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTMediaFile']/method[@name='setDelivery' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDelivery", "(Ljava/lang/String;)V", "GetSetDelivery_Ljava_lang_String_Handler")]
			set {
				if (id_setDelivery_Ljava_lang_String_ == IntPtr.Zero)
					id_setDelivery_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDelivery", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDelivery_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDelivery", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Height);
		}
#pragma warning restore 0169

		static Delegate cb_setHeight_Ljava_math_BigInteger_;
#pragma warning disable 0169
		static Delegate GetSetHeight_Ljava_math_BigInteger_Handler ()
		{
			if (cb_setHeight_Ljava_math_BigInteger_ == null)
				cb_setHeight_Ljava_math_BigInteger_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHeight_Ljava_math_BigInteger_);
			return cb_setHeight_Ljava_math_BigInteger_;
		}

		static void n_SetHeight_Ljava_math_BigInteger_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Math.BigInteger p0 = global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Height = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		static IntPtr id_setHeight_Ljava_math_BigInteger_;
		public virtual unsafe global::Java.Math.BigInteger Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTMediaFile']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()Ljava/math/BigInteger;", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()Ljava/math/BigInteger;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallObjectMethod  (Handle, id_getHeight), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()Ljava/math/BigInteger;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTMediaFile']/method[@name='setHeight' and count(parameter)=1 and parameter[1][@type='java.math.BigInteger']]"
			[Register ("setHeight", "(Ljava/math/BigInteger;)V", "GetSetHeight_Ljava_math_BigInteger_Handler")]
			set {
				if (id_setHeight_Ljava_math_BigInteger_ == IntPtr.Zero)
					id_setHeight_Ljava_math_BigInteger_ = JNIEnv.GetMethodID (class_ref, "setHeight", "(Ljava/math/BigInteger;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setHeight_Ljava_math_BigInteger_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeight", "(Ljava/math/BigInteger;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static Delegate cb_setId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetId_Ljava_lang_String_Handler ()
		{
			if (cb_setId_Ljava_lang_String_ == null)
				cb_setId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetId_Ljava_lang_String_);
			return cb_setId_Ljava_lang_String_;
		}

		static void n_SetId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_Ljava_lang_String_;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTMediaFile']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTMediaFile']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setId", "(Ljava/lang/String;)V", "GetSetId_Ljava_lang_String_Handler")]
			set {
				if (id_setId_Ljava_lang_String_ == IntPtr.Zero)
					id_setId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		static Delegate cb_setType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetType_Ljava_lang_String_Handler ()
		{
			if (cb_setType_Ljava_lang_String_ == null)
				cb_setType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetType_Ljava_lang_String_);
			return cb_setType_Ljava_lang_String_;
		}

		static void n_SetType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Type = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		static IntPtr id_setType_Ljava_lang_String_;
		public virtual unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTMediaFile']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTMediaFile']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setType", "(Ljava/lang/String;)V", "GetSetType_Ljava_lang_String_Handler")]
			set {
				if (id_setType_Ljava_lang_String_ == IntPtr.Zero)
					id_setType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value);
		}
#pragma warning restore 0169

		static Delegate cb_setValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetValue_Ljava_lang_String_Handler ()
		{
			if (cb_setValue_Ljava_lang_String_ == null)
				cb_setValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValue_Ljava_lang_String_);
			return cb_setValue_Ljava_lang_String_;
		}

		static void n_SetValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Value = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getValue;
		static IntPtr id_setValue_Ljava_lang_String_;
		public virtual unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTMediaFile']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTMediaFile']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setValue", "(Ljava/lang/String;)V", "GetSetValue_Ljava_lang_String_Handler")]
			set {
				if (id_setValue_Ljava_lang_String_ == IntPtr.Zero)
					id_setValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setValue", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setValue_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Width);
		}
#pragma warning restore 0169

		static Delegate cb_setWidth_Ljava_math_BigInteger_;
#pragma warning disable 0169
		static Delegate GetSetWidth_Ljava_math_BigInteger_Handler ()
		{
			if (cb_setWidth_Ljava_math_BigInteger_ == null)
				cb_setWidth_Ljava_math_BigInteger_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWidth_Ljava_math_BigInteger_);
			return cb_setWidth_Ljava_math_BigInteger_;
		}

		static void n_SetWidth_Ljava_math_BigInteger_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Math.BigInteger p0 = global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Width = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		static IntPtr id_setWidth_Ljava_math_BigInteger_;
		public virtual unsafe global::Java.Math.BigInteger Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTMediaFile']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()Ljava/math/BigInteger;", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()Ljava/math/BigInteger;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallObjectMethod  (Handle, id_getWidth), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()Ljava/math/BigInteger;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTMediaFile']/method[@name='setWidth' and count(parameter)=1 and parameter[1][@type='java.math.BigInteger']]"
			[Register ("setWidth", "(Ljava/math/BigInteger;)V", "GetSetWidth_Ljava_math_BigInteger_Handler")]
			set {
				if (id_setWidth_Ljava_math_BigInteger_ == IntPtr.Zero)
					id_setWidth_Ljava_math_BigInteger_ = JNIEnv.GetMethodID (class_ref, "setWidth", "(Ljava/math/BigInteger;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setWidth_Ljava_math_BigInteger_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWidth", "(Ljava/math/BigInteger;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isMaintainAspectRatio;
#pragma warning disable 0169
		static Delegate GetIsMaintainAspectRatioHandler ()
		{
			if (cb_isMaintainAspectRatio == null)
				cb_isMaintainAspectRatio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsMaintainAspectRatio);
			return cb_isMaintainAspectRatio;
		}

		static IntPtr n_IsMaintainAspectRatio (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsMaintainAspectRatio ());
		}
#pragma warning restore 0169

		static IntPtr id_isMaintainAspectRatio;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTMediaFile']/method[@name='isMaintainAspectRatio' and count(parameter)=0]"
		[Register ("isMaintainAspectRatio", "()Ljava/lang/Boolean;", "GetIsMaintainAspectRatioHandler")]
		public virtual unsafe global::Java.Lang.Boolean IsMaintainAspectRatio ()
		{
			if (id_isMaintainAspectRatio == IntPtr.Zero)
				id_isMaintainAspectRatio = JNIEnv.GetMethodID (class_ref, "isMaintainAspectRatio", "()Ljava/lang/Boolean;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_isMaintainAspectRatio), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMaintainAspectRatio", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isScalable;
#pragma warning disable 0169
		static Delegate GetIsScalableHandler ()
		{
			if (cb_isScalable == null)
				cb_isScalable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsScalable);
			return cb_isScalable;
		}

		static IntPtr n_IsScalable (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsScalable ());
		}
#pragma warning restore 0169

		static IntPtr id_isScalable;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTMediaFile']/method[@name='isScalable' and count(parameter)=0]"
		[Register ("isScalable", "()Ljava/lang/Boolean;", "GetIsScalableHandler")]
		public virtual unsafe global::Java.Lang.Boolean IsScalable ()
		{
			if (id_isScalable == IntPtr.Zero)
				id_isScalable = JNIEnv.GetMethodID (class_ref, "isScalable", "()Ljava/lang/Boolean;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_isScalable), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isScalable", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMaintainAspectRatio_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetMaintainAspectRatio_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setMaintainAspectRatio_Ljava_lang_Boolean_ == null)
				cb_setMaintainAspectRatio_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMaintainAspectRatio_Ljava_lang_Boolean_);
			return cb_setMaintainAspectRatio_Ljava_lang_Boolean_;
		}

		static void n_SetMaintainAspectRatio_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMaintainAspectRatio (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMaintainAspectRatio_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTMediaFile']/method[@name='setMaintainAspectRatio' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setMaintainAspectRatio", "(Ljava/lang/Boolean;)V", "GetSetMaintainAspectRatio_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetMaintainAspectRatio (global::Java.Lang.Boolean p0)
		{
			if (id_setMaintainAspectRatio_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_setMaintainAspectRatio_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setMaintainAspectRatio", "(Ljava/lang/Boolean;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMaintainAspectRatio_Ljava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaintainAspectRatio", "(Ljava/lang/Boolean;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScalable_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetScalable_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setScalable_Ljava_lang_Boolean_ == null)
				cb_setScalable_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScalable_Ljava_lang_Boolean_);
			return cb_setScalable_Ljava_lang_Boolean_;
		}

		static void n_SetScalable_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile __this = global::Java.Lang.Object.GetObject<global::Org.Nexage.Sourcekit.Vast.Model.VASTMediaFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetScalable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScalable_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.vast.model']/class[@name='VASTMediaFile']/method[@name='setScalable' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setScalable", "(Ljava/lang/Boolean;)V", "GetSetScalable_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetScalable (global::Java.Lang.Boolean p0)
		{
			if (id_setScalable_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_setScalable_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setScalable", "(Ljava/lang/Boolean;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScalable_Ljava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScalable", "(Ljava/lang/Boolean;)V"), __args);
			} finally {
			}
		}

	}
}
