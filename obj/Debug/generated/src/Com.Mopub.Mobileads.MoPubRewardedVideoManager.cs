using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubRewardedVideoManager", DoNotGenerateAcw=true)]
	public partial class MoPubRewardedVideoManager : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager.ForEachMoPubIdRunnable']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubRewardedVideoManager$ForEachMoPubIdRunnable", DoNotGenerateAcw=true)]
		public abstract partial class ForEachMoPubIdRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/MoPubRewardedVideoManager$ForEachMoPubIdRunnable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ForEachMoPubIdRunnable); }
			}

			protected ForEachMoPubIdRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_forEach_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetForEach_Ljava_lang_String_Handler ()
			{
				if (cb_forEach_Ljava_lang_String_ == null)
					cb_forEach_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ForEach_Ljava_lang_String_);
				return cb_forEach_Ljava_lang_String_;
			}

			static void n_ForEach_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.MoPubRewardedVideoManager.ForEachMoPubIdRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubRewardedVideoManager.ForEachMoPubIdRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ForEach (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager.ForEachMoPubIdRunnable']/method[@name='forEach' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("forEach", "(Ljava/lang/String;)V", "GetForEach_Ljava_lang_String_Handler")]
			protected abstract void ForEach (string p0);

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Mobileads.MoPubRewardedVideoManager.ForEachMoPubIdRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubRewardedVideoManager.ForEachMoPubIdRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager.ForEachMoPubIdRunnable']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubRewardedVideoManager$ForEachMoPubIdRunnable", DoNotGenerateAcw=true)]
		internal partial class ForEachMoPubIdRunnableInvoker : ForEachMoPubIdRunnable {

			public ForEachMoPubIdRunnableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (ForEachMoPubIdRunnableInvoker); }
			}

			static IntPtr id_forEach_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager.ForEachMoPubIdRunnable']/method[@name='forEach' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("forEach", "(Ljava/lang/String;)V", "GetForEach_Ljava_lang_String_Handler")]
			protected override unsafe void ForEach (string p0)
			{
				if (id_forEach_Ljava_lang_String_ == IntPtr.Zero)
					id_forEach_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "forEach", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					JNIEnv.CallVoidMethod  (Handle, id_forEach_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager.RewardedVideoRequestListener']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubRewardedVideoManager$RewardedVideoRequestListener", DoNotGenerateAcw=true)]
		public partial class RewardedVideoRequestListener : global::Java.Lang.Object, global::Com.Mopub.Network.AdRequest.IListener {


			static IntPtr adUnitId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager.RewardedVideoRequestListener']/field[@name='adUnitId']"
			[Register ("adUnitId")]
			public string AdUnitId {
				get {
					if (adUnitId_jfieldId == IntPtr.Zero)
						adUnitId_jfieldId = JNIEnv.GetFieldID (class_ref, "adUnitId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, adUnitId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (adUnitId_jfieldId == IntPtr.Zero)
						adUnitId_jfieldId = JNIEnv.GetFieldID (class_ref, "adUnitId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, adUnitId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/MoPubRewardedVideoManager$RewardedVideoRequestListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RewardedVideoRequestListener); }
			}

			protected RewardedVideoRequestListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_mopub_mobileads_MoPubRewardedVideoManager_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager.RewardedVideoRequestListener']/constructor[@name='MoPubRewardedVideoManager.RewardedVideoRequestListener' and count(parameter)=2 and parameter[1][@type='com.mopub.mobileads.MoPubRewardedVideoManager'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/mopub/mobileads/MoPubRewardedVideoManager;Ljava/lang/String;)V", "")]
			public unsafe RewardedVideoRequestListener (global::Com.Mopub.Mobileads.MoPubRewardedVideoManager p0, string p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					if (GetType () != typeof (RewardedVideoRequestListener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/mobileads/MoPubRewardedVideoManager;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/mobileads/MoPubRewardedVideoManager;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_mopub_mobileads_MoPubRewardedVideoManager_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_mopub_mobileads_MoPubRewardedVideoManager_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/mobileads/MoPubRewardedVideoManager;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_mobileads_MoPubRewardedVideoManager_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_mobileads_MoPubRewardedVideoManager_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
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
				global::Com.Mopub.Mobileads.MoPubRewardedVideoManager.RewardedVideoRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubRewardedVideoManager.RewardedVideoRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Volley.VolleyError p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.VolleyError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnErrorResponse (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onErrorResponse_Lcom_mopub_volley_VolleyError_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager.RewardedVideoRequestListener']/method[@name='onErrorResponse' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.VolleyError']]"
			[Register ("onErrorResponse", "(Lcom/mopub/volley/VolleyError;)V", "GetOnErrorResponse_Lcom_mopub_volley_VolleyError_Handler")]
			public virtual unsafe void OnErrorResponse (global::Com.Mopub.Volley.VolleyError p0)
			{
				if (id_onErrorResponse_Lcom_mopub_volley_VolleyError_ == IntPtr.Zero)
					id_onErrorResponse_Lcom_mopub_volley_VolleyError_ = JNIEnv.GetMethodID (class_ref, "onErrorResponse", "(Lcom/mopub/volley/VolleyError;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onErrorResponse_Lcom_mopub_volley_VolleyError_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onErrorResponse", "(Lcom/mopub/volley/VolleyError;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onSuccess_Lcom_mopub_network_AdResponse_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_Lcom_mopub_network_AdResponse_Handler ()
			{
				if (cb_onSuccess_Lcom_mopub_network_AdResponse_ == null)
					cb_onSuccess_Lcom_mopub_network_AdResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Lcom_mopub_network_AdResponse_);
				return cb_onSuccess_Lcom_mopub_network_AdResponse_;
			}

			static void n_OnSuccess_Lcom_mopub_network_AdResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Mobileads.MoPubRewardedVideoManager.RewardedVideoRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubRewardedVideoManager.RewardedVideoRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Network.AdResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.AdResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onSuccess_Lcom_mopub_network_AdResponse_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager.RewardedVideoRequestListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='com.mopub.network.AdResponse']]"
			[Register ("onSuccess", "(Lcom/mopub/network/AdResponse;)V", "GetOnSuccess_Lcom_mopub_network_AdResponse_Handler")]
			public virtual unsafe void OnSuccess (global::Com.Mopub.Network.AdResponse p0)
			{
				if (id_onSuccess_Lcom_mopub_network_AdResponse_ == IntPtr.Zero)
					id_onSuccess_Lcom_mopub_network_AdResponse_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lcom/mopub/network/AdResponse;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onSuccess_Lcom_mopub_network_AdResponse_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSuccess", "(Lcom/mopub/network/AdResponse;)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/MoPubRewardedVideoManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoPubRewardedVideoManager); }
		}

		protected MoPubRewardedVideoManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getGlobalMediationSettings_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager']/method[@name='getGlobalMediationSettings' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("getGlobalMediationSettings", "(Ljava/lang/Class;)Lcom/mopub/common/MediationSettings;", "")]
		public static unsafe global::Com.Mopub.Common.IMediationSettings GetGlobalMediationSettings (global::Java.Lang.Class p0)
		{
			if (id_getGlobalMediationSettings_Ljava_lang_Class_ == IntPtr.Zero)
				id_getGlobalMediationSettings_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getGlobalMediationSettings", "(Ljava/lang/Class;)Lcom/mopub/common/MediationSettings;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Mopub.Common.IMediationSettings __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.IMediationSettings> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getGlobalMediationSettings_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getInstanceMediationSettings_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager']/method[@name='getInstanceMediationSettings' and count(parameter)=2 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.String']]"
		[Register ("getInstanceMediationSettings", "(Ljava/lang/Class;Ljava/lang/String;)Lcom/mopub/common/MediationSettings;", "")]
		public static unsafe global::Com.Mopub.Common.IMediationSettings GetInstanceMediationSettings (global::Java.Lang.Class p0, string p1)
		{
			if (id_getInstanceMediationSettings_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_getInstanceMediationSettings_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getInstanceMediationSettings", "(Ljava/lang/Class;Ljava/lang/String;)Lcom/mopub/common/MediationSettings;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Mopub.Common.IMediationSettings __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.IMediationSettings> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstanceMediationSettings_Ljava_lang_Class_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_hasVideo_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager']/method[@name='hasVideo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hasVideo", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool HasVideo (string p0)
		{
			if (id_hasVideo_Ljava_lang_String_ == IntPtr.Zero)
				id_hasVideo_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hasVideo", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasVideo_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_init_Landroid_app_Activity_arrayLcom_mopub_common_MediationSettings_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.mopub.common.MediationSettings...']]"
		[Register ("init", "(Landroid/app/Activity;[Lcom/mopub/common/MediationSettings;)V", "")]
		public static unsafe void Init (global::Android.App.Activity p0, params global:: Com.Mopub.Common.IMediationSettings[] p1)
		{
			if (id_init_Landroid_app_Activity_arrayLcom_mopub_common_MediationSettings_ == IntPtr.Zero)
				id_init_Landroid_app_Activity_arrayLcom_mopub_common_MediationSettings_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/app/Activity;[Lcom/mopub/common/MediationSettings;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init_Landroid_app_Activity_arrayLcom_mopub_common_MediationSettings_, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_loadVideo_Ljava_lang_String_arrayLcom_mopub_common_MediationSettings_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager']/method[@name='loadVideo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.common.MediationSettings...']]"
		[Register ("loadVideo", "(Ljava/lang/String;[Lcom/mopub/common/MediationSettings;)V", "")]
		public static unsafe void LoadVideo (string p0, params global:: Com.Mopub.Common.IMediationSettings[] p1)
		{
			if (id_loadVideo_Ljava_lang_String_arrayLcom_mopub_common_MediationSettings_ == IntPtr.Zero)
				id_loadVideo_Ljava_lang_String_arrayLcom_mopub_common_MediationSettings_ = JNIEnv.GetStaticMethodID (class_ref, "loadVideo", "(Ljava/lang/String;[Lcom/mopub/common/MediationSettings;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_loadVideo_Ljava_lang_String_arrayLcom_mopub_common_MediationSettings_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_onRewardedVideoClicked_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager']/method[@name='onRewardedVideoClicked' and count(parameter)=2 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.String']]"
		[Register ("onRewardedVideoClicked", "(Ljava/lang/Class;Ljava/lang/String;)V", "")]
		public static unsafe void OnRewardedVideoClicked (global::Java.Lang.Class p0, string p1)
		{
			if (id_onRewardedVideoClicked_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_onRewardedVideoClicked_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "onRewardedVideoClicked", "(Ljava/lang/Class;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onRewardedVideoClicked_Ljava_lang_Class_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_onRewardedVideoClosed_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager']/method[@name='onRewardedVideoClosed' and count(parameter)=2 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.String']]"
		[Register ("onRewardedVideoClosed", "(Ljava/lang/Class;Ljava/lang/String;)V", "")]
		public static unsafe void OnRewardedVideoClosed (global::Java.Lang.Class p0, string p1)
		{
			if (id_onRewardedVideoClosed_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_onRewardedVideoClosed_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "onRewardedVideoClosed", "(Ljava/lang/Class;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onRewardedVideoClosed_Ljava_lang_Class_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_onRewardedVideoCompleted_Ljava_lang_Class_Ljava_lang_String_Lcom_mopub_common_MoPubReward_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager']/method[@name='onRewardedVideoCompleted' and count(parameter)=3 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.mopub.common.MoPubReward']]"
		[Register ("onRewardedVideoCompleted", "(Ljava/lang/Class;Ljava/lang/String;Lcom/mopub/common/MoPubReward;)V", "")]
		public static unsafe void OnRewardedVideoCompleted (global::Java.Lang.Class p0, string p1, global::Com.Mopub.Common.MoPubReward p2)
		{
			if (id_onRewardedVideoCompleted_Ljava_lang_Class_Ljava_lang_String_Lcom_mopub_common_MoPubReward_ == IntPtr.Zero)
				id_onRewardedVideoCompleted_Ljava_lang_Class_Ljava_lang_String_Lcom_mopub_common_MoPubReward_ = JNIEnv.GetStaticMethodID (class_ref, "onRewardedVideoCompleted", "(Ljava/lang/Class;Ljava/lang/String;Lcom/mopub/common/MoPubReward;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onRewardedVideoCompleted_Ljava_lang_Class_Ljava_lang_String_Lcom_mopub_common_MoPubReward_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_onRewardedVideoLoadFailure_Ljava_lang_Class_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager']/method[@name='onRewardedVideoLoadFailure' and count(parameter)=3 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.mopub.mobileads.MoPubErrorCode']]"
		[Register ("onRewardedVideoLoadFailure", "(Ljava/lang/Class;Ljava/lang/String;Lcom/mopub/mobileads/MoPubErrorCode;)V", "")]
		public static unsafe void OnRewardedVideoLoadFailure (global::Java.Lang.Class p0, string p1, global::Com.Mopub.Mobileads.MoPubErrorCode p2)
		{
			if (id_onRewardedVideoLoadFailure_Ljava_lang_Class_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_ == IntPtr.Zero)
				id_onRewardedVideoLoadFailure_Ljava_lang_Class_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_ = JNIEnv.GetStaticMethodID (class_ref, "onRewardedVideoLoadFailure", "(Ljava/lang/Class;Ljava/lang/String;Lcom/mopub/mobileads/MoPubErrorCode;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onRewardedVideoLoadFailure_Ljava_lang_Class_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_onRewardedVideoLoadSuccess_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager']/method[@name='onRewardedVideoLoadSuccess' and count(parameter)=2 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.String']]"
		[Register ("onRewardedVideoLoadSuccess", "(Ljava/lang/Class;Ljava/lang/String;)V", "")]
		public static unsafe void OnRewardedVideoLoadSuccess (global::Java.Lang.Class p0, string p1)
		{
			if (id_onRewardedVideoLoadSuccess_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_onRewardedVideoLoadSuccess_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "onRewardedVideoLoadSuccess", "(Ljava/lang/Class;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onRewardedVideoLoadSuccess_Ljava_lang_Class_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_onRewardedVideoPlaybackError_Ljava_lang_Class_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager']/method[@name='onRewardedVideoPlaybackError' and count(parameter)=3 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.mopub.mobileads.MoPubErrorCode']]"
		[Register ("onRewardedVideoPlaybackError", "(Ljava/lang/Class;Ljava/lang/String;Lcom/mopub/mobileads/MoPubErrorCode;)V", "")]
		public static unsafe void OnRewardedVideoPlaybackError (global::Java.Lang.Class p0, string p1, global::Com.Mopub.Mobileads.MoPubErrorCode p2)
		{
			if (id_onRewardedVideoPlaybackError_Ljava_lang_Class_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_ == IntPtr.Zero)
				id_onRewardedVideoPlaybackError_Ljava_lang_Class_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_ = JNIEnv.GetStaticMethodID (class_ref, "onRewardedVideoPlaybackError", "(Ljava/lang/Class;Ljava/lang/String;Lcom/mopub/mobileads/MoPubErrorCode;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onRewardedVideoPlaybackError_Ljava_lang_Class_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_onRewardedVideoStarted_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager']/method[@name='onRewardedVideoStarted' and count(parameter)=2 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.String']]"
		[Register ("onRewardedVideoStarted", "(Ljava/lang/Class;Ljava/lang/String;)V", "")]
		public static unsafe void OnRewardedVideoStarted (global::Java.Lang.Class p0, string p1)
		{
			if (id_onRewardedVideoStarted_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_onRewardedVideoStarted_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "onRewardedVideoStarted", "(Ljava/lang/Class;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onRewardedVideoStarted_Ljava_lang_Class_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setVideoListener_Lcom_mopub_mobileads_MoPubRewardedVideoListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager']/method[@name='setVideoListener' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubRewardedVideoListener']]"
		[Register ("setVideoListener", "(Lcom/mopub/mobileads/MoPubRewardedVideoListener;)V", "")]
		public static unsafe void SetVideoListener (global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener p0)
		{
			if (id_setVideoListener_Lcom_mopub_mobileads_MoPubRewardedVideoListener_ == IntPtr.Zero)
				id_setVideoListener_Lcom_mopub_mobileads_MoPubRewardedVideoListener_ = JNIEnv.GetStaticMethodID (class_ref, "setVideoListener", "(Lcom/mopub/mobileads/MoPubRewardedVideoListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setVideoListener_Lcom_mopub_mobileads_MoPubRewardedVideoListener_, __args);
			} finally {
			}
		}

		static IntPtr id_showVideo_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager']/method[@name='showVideo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("showVideo", "(Ljava/lang/String;)V", "")]
		public static unsafe void ShowVideo (string p0)
		{
			if (id_showVideo_Ljava_lang_String_ == IntPtr.Zero)
				id_showVideo_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "showVideo", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_showVideo_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_updateActivity_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubRewardedVideoManager']/method[@name='updateActivity' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("updateActivity", "(Landroid/app/Activity;)V", "")]
		public static unsafe void UpdateActivity (global::Android.App.Activity p0)
		{
			if (id_updateActivity_Landroid_app_Activity_ == IntPtr.Zero)
				id_updateActivity_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "updateActivity", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_updateActivity_Landroid_app_Activity_, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Mopub.Mobileads.IMoPubRewardedVideoListener"
		public event EventHandler<global::Com.Mopub.Mobileads.RewardedVideoClosedEventArgs> RewardedVideoClosed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener, global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor>(
						ref weak_implementor_SetVideoListener,
						__CreateIMoPubRewardedVideoListenerImplementor,
						SetVideoListener,
						__h => __h.OnRewardedVideoClosedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener, global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor>(
						ref weak_implementor_SetVideoListener,
						global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor.__IsEmpty,
						__v => SetVideoListener (null),
						__h => __h.OnRewardedVideoClosedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Mobileads.RewardedVideoCompletedEventArgs> RewardedVideoCompleted {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener, global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor>(
						ref weak_implementor_SetVideoListener,
						__CreateIMoPubRewardedVideoListenerImplementor,
						SetVideoListener,
						__h => __h.OnRewardedVideoCompletedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener, global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor>(
						ref weak_implementor_SetVideoListener,
						global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor.__IsEmpty,
						__v => SetVideoListener (null),
						__h => __h.OnRewardedVideoCompletedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Mobileads.RewardedVideoLoadFailureEventArgs> RewardedVideoLoadFailure {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener, global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor>(
						ref weak_implementor_SetVideoListener,
						__CreateIMoPubRewardedVideoListenerImplementor,
						SetVideoListener,
						__h => __h.OnRewardedVideoLoadFailureHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener, global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor>(
						ref weak_implementor_SetVideoListener,
						global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor.__IsEmpty,
						__v => SetVideoListener (null),
						__h => __h.OnRewardedVideoLoadFailureHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Mobileads.RewardedVideoLoadSuccessEventArgs> RewardedVideoLoadSuccess {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener, global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor>(
						ref weak_implementor_SetVideoListener,
						__CreateIMoPubRewardedVideoListenerImplementor,
						SetVideoListener,
						__h => __h.OnRewardedVideoLoadSuccessHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener, global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor>(
						ref weak_implementor_SetVideoListener,
						global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor.__IsEmpty,
						__v => SetVideoListener (null),
						__h => __h.OnRewardedVideoLoadSuccessHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Mobileads.RewardedVideoPlaybackErrorEventArgs> RewardedVideoPlaybackError {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener, global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor>(
						ref weak_implementor_SetVideoListener,
						__CreateIMoPubRewardedVideoListenerImplementor,
						SetVideoListener,
						__h => __h.OnRewardedVideoPlaybackErrorHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener, global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor>(
						ref weak_implementor_SetVideoListener,
						global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor.__IsEmpty,
						__v => SetVideoListener (null),
						__h => __h.OnRewardedVideoPlaybackErrorHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Mobileads.RewardedVideoStartedEventArgs> RewardedVideoStarted {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener, global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor>(
						ref weak_implementor_SetVideoListener,
						__CreateIMoPubRewardedVideoListenerImplementor,
						SetVideoListener,
						__h => __h.OnRewardedVideoStartedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener, global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor>(
						ref weak_implementor_SetVideoListener,
						global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor.__IsEmpty,
						__v => SetVideoListener (null),
						__h => __h.OnRewardedVideoStartedHandler -= value);
			}
		}

		WeakReference weak_implementor_SetVideoListener;

		global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor __CreateIMoPubRewardedVideoListenerImplementor ()
		{
			return new global::Com.Mopub.Mobileads.IMoPubRewardedVideoListenerImplementor (this);
		}
#endregion
	}
}
