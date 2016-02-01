using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='GpsHelper']"
	[global::Android.Runtime.Register ("com/mopub/common/GpsHelper", DoNotGenerateAcw=true)]
	public partial class GpsHelper : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='GpsHelper']/field[@name='ADVERTISING_ID_KEY']"
		[Register ("ADVERTISING_ID_KEY")]
		public const string AdvertisingIdKey = (string) "advertisingId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='GpsHelper']/field[@name='GOOGLE_PLAY_SUCCESS_CODE']"
		[Register ("GOOGLE_PLAY_SUCCESS_CODE")]
		public const int GooglePlaySuccessCode = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='GpsHelper']/field[@name='IS_LIMIT_AD_TRACKING_ENABLED_KEY']"
		[Register ("IS_LIMIT_AD_TRACKING_ENABLED_KEY")]
		public const string IsLimitAdTrackingEnabledKey = (string) "isLimitAdTrackingEnabled";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='GpsHelper.AdvertisingInfo']"
		[global::Android.Runtime.Register ("com/mopub/common/GpsHelper$AdvertisingInfo", DoNotGenerateAcw=true)]
		public partial class AdvertisingInfo : global::Java.Lang.Object {


			static IntPtr advertisingId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='GpsHelper.AdvertisingInfo']/field[@name='advertisingId']"
			[Register ("advertisingId")]
			public string AdvertisingId {
				get {
					if (advertisingId_jfieldId == IntPtr.Zero)
						advertisingId_jfieldId = JNIEnv.GetFieldID (class_ref, "advertisingId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, advertisingId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (advertisingId_jfieldId == IntPtr.Zero)
						advertisingId_jfieldId = JNIEnv.GetFieldID (class_ref, "advertisingId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, advertisingId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr limitAdTracking_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='GpsHelper.AdvertisingInfo']/field[@name='limitAdTracking']"
			[Register ("limitAdTracking")]
			public bool LimitAdTracking {
				get {
					if (limitAdTracking_jfieldId == IntPtr.Zero)
						limitAdTracking_jfieldId = JNIEnv.GetFieldID (class_ref, "limitAdTracking", "Z");
					return JNIEnv.GetBooleanField (Handle, limitAdTracking_jfieldId);
				}
				set {
					if (limitAdTracking_jfieldId == IntPtr.Zero)
						limitAdTracking_jfieldId = JNIEnv.GetFieldID (class_ref, "limitAdTracking", "Z");
					try {
						JNIEnv.SetField (Handle, limitAdTracking_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/GpsHelper$AdvertisingInfo", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AdvertisingInfo); }
			}

			protected AdvertisingInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_Z;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common']/class[@name='GpsHelper.AdvertisingInfo']/constructor[@name='GpsHelper.AdvertisingInfo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
			[Register (".ctor", "(Ljava/lang/String;Z)V", "")]
			public unsafe AdvertisingInfo (string p0, bool p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (AdvertisingInfo)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Z)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Z)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_Z == IntPtr.Zero)
						id_ctor_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Z)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Z, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Z, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='GpsHelper.FetchAdvertisingInfoTask']"
		[global::Android.Runtime.Register ("com/mopub/common/GpsHelper$FetchAdvertisingInfoTask", DoNotGenerateAcw=true)]
		public partial class FetchAdvertisingInfoTask : global::Android.OS.AsyncTask {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/GpsHelper$FetchAdvertisingInfoTask", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FetchAdvertisingInfoTask); }
			}

			protected FetchAdvertisingInfoTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_Lcom_mopub_common_GpsHelper_GpsHelperListener_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common']/class[@name='GpsHelper.FetchAdvertisingInfoTask']/constructor[@name='GpsHelper.FetchAdvertisingInfoTask' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.common.GpsHelper.GpsHelperListener']]"
			[Register (".ctor", "(Landroid/content/Context;Lcom/mopub/common/GpsHelper$GpsHelperListener;)V", "")]
			public unsafe FetchAdvertisingInfoTask (global::Android.Content.Context p0, global::Com.Mopub.Common.GpsHelper.IGpsHelperListener p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (FetchAdvertisingInfoTask)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/mopub/common/GpsHelper$GpsHelperListener;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/mopub/common/GpsHelper$GpsHelperListener;)V", __args);
						return;
					}

					if (id_ctor_Landroid_content_Context_Lcom_mopub_common_GpsHelper_GpsHelperListener_ == IntPtr.Zero)
						id_ctor_Landroid_content_Context_Lcom_mopub_common_GpsHelper_GpsHelperListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/mopub/common/GpsHelper$GpsHelperListener;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_mopub_common_GpsHelper_GpsHelperListener_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_mopub_common_GpsHelper_GpsHelperListener_, __args);
				} finally {
				}
			}

			static Delegate cb_doInBackground_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetDoInBackground_arrayLjava_lang_Object_Handler ()
			{
				if (cb_doInBackground_arrayLjava_lang_Object_ == null)
					cb_doInBackground_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_Object_);
				return cb_doInBackground_arrayLjava_lang_Object_;
			}

			static IntPtr n_DoInBackground_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.GpsHelper.FetchAdvertisingInfoTask __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.GpsHelper.FetchAdvertisingInfoTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_doInBackground_arrayLjava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='GpsHelper.FetchAdvertisingInfoTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
			[Register ("doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;", "GetDoInBackground_arrayLjava_lang_Object_Handler")]
			protected override unsafe global::Java.Lang.Object DoInBackground (global::Java.Lang.Object[] p0)
			{
				if (id_doInBackground_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_doInBackground_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Java.Lang.Object __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_doInBackground_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_doInBackground_arrayLjava_lang_Void_;
#pragma warning disable 0169
			static Delegate GetDoInBackground_arrayLjava_lang_Void_Handler ()
			{
				if (cb_doInBackground_arrayLjava_lang_Void_ == null)
					cb_doInBackground_arrayLjava_lang_Void_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_Void_);
				return cb_doInBackground_arrayLjava_lang_Void_;
			}

			static IntPtr n_DoInBackground_arrayLjava_lang_Void_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.GpsHelper.FetchAdvertisingInfoTask __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.GpsHelper.FetchAdvertisingInfoTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Void[] p0 = (global::Java.Lang.Void[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Void));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_doInBackground_arrayLjava_lang_Void_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='GpsHelper.FetchAdvertisingInfoTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Void...']]"
			[Register ("doInBackground", "([Ljava/lang/Void;)Ljava/lang/Void;", "GetDoInBackground_arrayLjava_lang_Void_Handler")]
			protected virtual unsafe global::Java.Lang.Void DoInBackground (params global:: Java.Lang.Void[] p0)
			{
				if (id_doInBackground_arrayLjava_lang_Void_ == IntPtr.Zero)
					id_doInBackground_arrayLjava_lang_Void_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/Void;)Ljava/lang/Void;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Java.Lang.Void __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Void> (JNIEnv.CallObjectMethod  (Handle, id_doInBackground_arrayLjava_lang_Void_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Void> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Ljava/lang/Void;)Ljava/lang/Void;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_onPostExecute_Ljava_lang_Void_;
#pragma warning disable 0169
			static Delegate GetOnPostExecute_Ljava_lang_Void_Handler ()
			{
				if (cb_onPostExecute_Ljava_lang_Void_ == null)
					cb_onPostExecute_Ljava_lang_Void_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPostExecute_Ljava_lang_Void_);
				return cb_onPostExecute_Ljava_lang_Void_;
			}

			static void n_OnPostExecute_Ljava_lang_Void_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Common.GpsHelper.FetchAdvertisingInfoTask __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.GpsHelper.FetchAdvertisingInfoTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Void p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Void> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPostExecute (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onPostExecute_Ljava_lang_Void_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='GpsHelper.FetchAdvertisingInfoTask']/method[@name='onPostExecute' and count(parameter)=1 and parameter[1][@type='java.lang.Void']]"
			[Register ("onPostExecute", "(Ljava/lang/Void;)V", "GetOnPostExecute_Ljava_lang_Void_Handler")]
			protected virtual unsafe void OnPostExecute (global::Java.Lang.Void p0)
			{
				if (id_onPostExecute_Ljava_lang_Void_ == IntPtr.Zero)
					id_onPostExecute_Ljava_lang_Void_ = JNIEnv.GetMethodID (class_ref, "onPostExecute", "(Ljava/lang/Void;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onPostExecute_Ljava_lang_Void_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPostExecute", "(Ljava/lang/Void;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.common']/interface[@name='GpsHelper.GpsHelperListener']"
		[Register ("com/mopub/common/GpsHelper$GpsHelperListener", "", "Com.Mopub.Common.GpsHelper/IGpsHelperListenerInvoker")]
		public partial interface IGpsHelperListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/interface[@name='GpsHelper.GpsHelperListener']/method[@name='onFetchAdInfoCompleted' and count(parameter)=0]"
			[Register ("onFetchAdInfoCompleted", "()V", "GetOnFetchAdInfoCompletedHandler:Com.Mopub.Common.GpsHelper/IGpsHelperListenerInvoker, AppodealXamarinPlugin")]
			void OnFetchAdInfoCompleted ();

		}

		[global::Android.Runtime.Register ("com/mopub/common/GpsHelper$GpsHelperListener", DoNotGenerateAcw=true)]
		internal class IGpsHelperListenerInvoker : global::Java.Lang.Object, IGpsHelperListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/common/GpsHelper$GpsHelperListener");
			IntPtr class_ref;

			public static IGpsHelperListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IGpsHelperListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.common.GpsHelper.GpsHelperListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IGpsHelperListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IGpsHelperListenerInvoker); }
			}

			static Delegate cb_onFetchAdInfoCompleted;
#pragma warning disable 0169
			static Delegate GetOnFetchAdInfoCompletedHandler ()
			{
				if (cb_onFetchAdInfoCompleted == null)
					cb_onFetchAdInfoCompleted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFetchAdInfoCompleted);
				return cb_onFetchAdInfoCompleted;
			}

			static void n_OnFetchAdInfoCompleted (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Common.GpsHelper.IGpsHelperListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.GpsHelper.IGpsHelperListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnFetchAdInfoCompleted ();
			}
#pragma warning restore 0169

			IntPtr id_onFetchAdInfoCompleted;
			public unsafe void OnFetchAdInfoCompleted ()
			{
				if (id_onFetchAdInfoCompleted == IntPtr.Zero)
					id_onFetchAdInfoCompleted = JNIEnv.GetMethodID (class_ref, "onFetchAdInfoCompleted", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onFetchAdInfoCompleted);
			}

		}

		[global::Android.Runtime.Register ("mono/com/mopub/common/GpsHelper_GpsHelperListenerImplementor")]
		internal sealed partial class IGpsHelperListenerImplementor : global::Java.Lang.Object, IGpsHelperListener {

			object sender;

			public IGpsHelperListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/common/GpsHelper_GpsHelperListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnFetchAdInfoCompleted ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IGpsHelperListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/GpsHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GpsHelper); }
		}

		protected GpsHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common']/class[@name='GpsHelper']/constructor[@name='GpsHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GpsHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (GpsHelper)) {
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

		static IntPtr id_fetchAdvertisingInfoAsync_Landroid_content_Context_Lcom_mopub_common_GpsHelper_GpsHelperListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='GpsHelper']/method[@name='fetchAdvertisingInfoAsync' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.common.GpsHelper.GpsHelperListener']]"
		[Register ("fetchAdvertisingInfoAsync", "(Landroid/content/Context;Lcom/mopub/common/GpsHelper$GpsHelperListener;)V", "")]
		public static unsafe void FetchAdvertisingInfoAsync (global::Android.Content.Context p0, global::Com.Mopub.Common.GpsHelper.IGpsHelperListener p1)
		{
			if (id_fetchAdvertisingInfoAsync_Landroid_content_Context_Lcom_mopub_common_GpsHelper_GpsHelperListener_ == IntPtr.Zero)
				id_fetchAdvertisingInfoAsync_Landroid_content_Context_Lcom_mopub_common_GpsHelper_GpsHelperListener_ = JNIEnv.GetStaticMethodID (class_ref, "fetchAdvertisingInfoAsync", "(Landroid/content/Context;Lcom/mopub/common/GpsHelper$GpsHelperListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fetchAdvertisingInfoAsync_Landroid_content_Context_Lcom_mopub_common_GpsHelper_GpsHelperListener_, __args);
			} finally {
			}
		}

		static IntPtr id_fetchAdvertisingInfoSync_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='GpsHelper']/method[@name='fetchAdvertisingInfoSync' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("fetchAdvertisingInfoSync", "(Landroid/content/Context;)Lcom/mopub/common/GpsHelper$AdvertisingInfo;", "")]
		public static unsafe global::Com.Mopub.Common.GpsHelper.AdvertisingInfo FetchAdvertisingInfoSync (global::Android.Content.Context p0)
		{
			if (id_fetchAdvertisingInfoSync_Landroid_content_Context_ == IntPtr.Zero)
				id_fetchAdvertisingInfoSync_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "fetchAdvertisingInfoSync", "(Landroid/content/Context;)Lcom/mopub/common/GpsHelper$AdvertisingInfo;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Mopub.Common.GpsHelper.AdvertisingInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.GpsHelper.AdvertisingInfo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fetchAdvertisingInfoSync_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isLimitAdTrackingEnabled_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='GpsHelper']/method[@name='isLimitAdTrackingEnabled' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isLimitAdTrackingEnabled", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsLimitAdTrackingEnabled (global::Android.Content.Context p0)
		{
			if (id_isLimitAdTrackingEnabled_Landroid_content_Context_ == IntPtr.Zero)
				id_isLimitAdTrackingEnabled_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isLimitAdTrackingEnabled", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isLimitAdTrackingEnabled_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isPlayServicesAvailable_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='GpsHelper']/method[@name='isPlayServicesAvailable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isPlayServicesAvailable", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsPlayServicesAvailable (global::Android.Content.Context p0)
		{
			if (id_isPlayServicesAvailable_Landroid_content_Context_ == IntPtr.Zero)
				id_isPlayServicesAvailable_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isPlayServicesAvailable", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isPlayServicesAvailable_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setClassNamesForTesting;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='GpsHelper']/method[@name='setClassNamesForTesting' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("setClassNamesForTesting", "()V", "")]
		public static unsafe void SetClassNamesForTesting ()
		{
			if (id_setClassNamesForTesting == IntPtr.Zero)
				id_setClassNamesForTesting = JNIEnv.GetStaticMethodID (class_ref, "setClassNamesForTesting", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setClassNamesForTesting);
			} finally {
			}
		}

	}
}
