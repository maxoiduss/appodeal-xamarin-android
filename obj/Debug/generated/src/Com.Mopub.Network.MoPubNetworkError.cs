using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.network']/class[@name='MoPubNetworkError']"
	[global::Android.Runtime.Register ("com/mopub/network/MoPubNetworkError", DoNotGenerateAcw=true)]
	public partial class MoPubNetworkError : global::Com.Mopub.Volley.VolleyError {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.network']/class[@name='MoPubNetworkError.Reason']"
		[global::Android.Runtime.Register ("com/mopub/network/MoPubNetworkError$Reason", DoNotGenerateAcw=true)]
		public sealed partial class Reason : global::Java.Lang.Enum {


			static IntPtr BAD_BODY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.network']/class[@name='MoPubNetworkError.Reason']/field[@name='BAD_BODY']"
			[Register ("BAD_BODY")]
			public static global::Com.Mopub.Network.MoPubNetworkError.Reason BadBody {
				get {
					if (BAD_BODY_jfieldId == IntPtr.Zero)
						BAD_BODY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BAD_BODY", "Lcom/mopub/network/MoPubNetworkError$Reason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BAD_BODY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.MoPubNetworkError.Reason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BAD_HEADER_DATA_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.network']/class[@name='MoPubNetworkError.Reason']/field[@name='BAD_HEADER_DATA']"
			[Register ("BAD_HEADER_DATA")]
			public static global::Com.Mopub.Network.MoPubNetworkError.Reason BadHeaderData {
				get {
					if (BAD_HEADER_DATA_jfieldId == IntPtr.Zero)
						BAD_HEADER_DATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BAD_HEADER_DATA", "Lcom/mopub/network/MoPubNetworkError$Reason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BAD_HEADER_DATA_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.MoPubNetworkError.Reason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NO_FILL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.network']/class[@name='MoPubNetworkError.Reason']/field[@name='NO_FILL']"
			[Register ("NO_FILL")]
			public static global::Com.Mopub.Network.MoPubNetworkError.Reason NoFill {
				get {
					if (NO_FILL_jfieldId == IntPtr.Zero)
						NO_FILL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_FILL", "Lcom/mopub/network/MoPubNetworkError$Reason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_FILL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.MoPubNetworkError.Reason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRACKING_FAILURE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.network']/class[@name='MoPubNetworkError.Reason']/field[@name='TRACKING_FAILURE']"
			[Register ("TRACKING_FAILURE")]
			public static global::Com.Mopub.Network.MoPubNetworkError.Reason TrackingFailure {
				get {
					if (TRACKING_FAILURE_jfieldId == IntPtr.Zero)
						TRACKING_FAILURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRACKING_FAILURE", "Lcom/mopub/network/MoPubNetworkError$Reason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRACKING_FAILURE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.MoPubNetworkError.Reason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNSPECIFIED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.network']/class[@name='MoPubNetworkError.Reason']/field[@name='UNSPECIFIED']"
			[Register ("UNSPECIFIED")]
			public static global::Com.Mopub.Network.MoPubNetworkError.Reason Unspecified {
				get {
					if (UNSPECIFIED_jfieldId == IntPtr.Zero)
						UNSPECIFIED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSPECIFIED", "Lcom/mopub/network/MoPubNetworkError$Reason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNSPECIFIED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.MoPubNetworkError.Reason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WARMING_UP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.network']/class[@name='MoPubNetworkError.Reason']/field[@name='WARMING_UP']"
			[Register ("WARMING_UP")]
			public static global::Com.Mopub.Network.MoPubNetworkError.Reason WarmingUp {
				get {
					if (WARMING_UP_jfieldId == IntPtr.Zero)
						WARMING_UP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WARMING_UP", "Lcom/mopub/network/MoPubNetworkError$Reason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WARMING_UP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.MoPubNetworkError.Reason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/network/MoPubNetworkError$Reason", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Reason); }
			}

			internal Reason (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='MoPubNetworkError.Reason']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/network/MoPubNetworkError$Reason;", "")]
			public static unsafe global::Com.Mopub.Network.MoPubNetworkError.Reason ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/network/MoPubNetworkError$Reason;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mopub.Network.MoPubNetworkError.Reason __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.MoPubNetworkError.Reason> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='MoPubNetworkError.Reason']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/network/MoPubNetworkError$Reason;", "")]
			public static unsafe global::Com.Mopub.Network.MoPubNetworkError.Reason[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/network/MoPubNetworkError$Reason;");
				try {
					return (global::Com.Mopub.Network.MoPubNetworkError.Reason[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Network.MoPubNetworkError.Reason));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/network/MoPubNetworkError", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoPubNetworkError); }
		}

		protected MoPubNetworkError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_mopub_network_MoPubNetworkError_Reason_Ljava_lang_Integer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.network']/class[@name='MoPubNetworkError']/constructor[@name='MoPubNetworkError' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.network.MoPubNetworkError.Reason'] and parameter[3][@type='java.lang.Integer']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/mopub/network/MoPubNetworkError$Reason;Ljava/lang/Integer;)V", "")]
		public unsafe MoPubNetworkError (string p0, global::Com.Mopub.Network.MoPubNetworkError.Reason p1, global::Java.Lang.Integer p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (MoPubNetworkError)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/mopub/network/MoPubNetworkError$Reason;Ljava/lang/Integer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lcom/mopub/network/MoPubNetworkError$Reason;Ljava/lang/Integer;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_mopub_network_MoPubNetworkError_Reason_Ljava_lang_Integer_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_mopub_network_MoPubNetworkError_Reason_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/mopub/network/MoPubNetworkError$Reason;Ljava/lang/Integer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_mopub_network_MoPubNetworkError_Reason_Ljava_lang_Integer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_mopub_network_MoPubNetworkError_Reason_Ljava_lang_Integer_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Throwable_Lcom_mopub_network_MoPubNetworkError_Reason_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.network']/class[@name='MoPubNetworkError']/constructor[@name='MoPubNetworkError' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='com.mopub.network.MoPubNetworkError.Reason']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Throwable;Lcom/mopub/network/MoPubNetworkError$Reason;)V", "")]
		public unsafe MoPubNetworkError (string p0, global::Java.Lang.Throwable p1, global::Com.Mopub.Network.MoPubNetworkError.Reason p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (MoPubNetworkError)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/Throwable;Lcom/mopub/network/MoPubNetworkError$Reason;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/Throwable;Lcom/mopub/network/MoPubNetworkError$Reason;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Throwable_Lcom_mopub_network_MoPubNetworkError_Reason_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Throwable_Lcom_mopub_network_MoPubNetworkError_Reason_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;Lcom/mopub/network/MoPubNetworkError$Reason;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Throwable_Lcom_mopub_network_MoPubNetworkError_Reason_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Throwable_Lcom_mopub_network_MoPubNetworkError_Reason_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_mopub_network_MoPubNetworkError_Reason_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.network']/class[@name='MoPubNetworkError']/constructor[@name='MoPubNetworkError' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.network.MoPubNetworkError.Reason']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/mopub/network/MoPubNetworkError$Reason;)V", "")]
		public unsafe MoPubNetworkError (string p0, global::Com.Mopub.Network.MoPubNetworkError.Reason p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (MoPubNetworkError)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/mopub/network/MoPubNetworkError$Reason;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lcom/mopub/network/MoPubNetworkError$Reason;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_mopub_network_MoPubNetworkError_Reason_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_mopub_network_MoPubNetworkError_Reason_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/mopub/network/MoPubNetworkError$Reason;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_mopub_network_MoPubNetworkError_Reason_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_mopub_network_MoPubNetworkError_Reason_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Lcom_mopub_network_MoPubNetworkError_Reason_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.network']/class[@name='MoPubNetworkError']/constructor[@name='MoPubNetworkError' and count(parameter)=1 and parameter[1][@type='com.mopub.network.MoPubNetworkError.Reason']]"
		[Register (".ctor", "(Lcom/mopub/network/MoPubNetworkError$Reason;)V", "")]
		public unsafe MoPubNetworkError (global::Com.Mopub.Network.MoPubNetworkError.Reason p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MoPubNetworkError)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/network/MoPubNetworkError$Reason;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/network/MoPubNetworkError$Reason;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mopub_network_MoPubNetworkError_Reason_ == IntPtr.Zero)
					id_ctor_Lcom_mopub_network_MoPubNetworkError_Reason_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/network/MoPubNetworkError$Reason;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_network_MoPubNetworkError_Reason_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_network_MoPubNetworkError_Reason_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_mopub_volley_NetworkResponse_Lcom_mopub_network_MoPubNetworkError_Reason_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.network']/class[@name='MoPubNetworkError']/constructor[@name='MoPubNetworkError' and count(parameter)=2 and parameter[1][@type='com.mopub.volley.NetworkResponse'] and parameter[2][@type='com.mopub.network.MoPubNetworkError.Reason']]"
		[Register (".ctor", "(Lcom/mopub/volley/NetworkResponse;Lcom/mopub/network/MoPubNetworkError$Reason;)V", "")]
		public unsafe MoPubNetworkError (global::Com.Mopub.Volley.NetworkResponse p0, global::Com.Mopub.Network.MoPubNetworkError.Reason p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (MoPubNetworkError)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/volley/NetworkResponse;Lcom/mopub/network/MoPubNetworkError$Reason;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/volley/NetworkResponse;Lcom/mopub/network/MoPubNetworkError$Reason;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mopub_volley_NetworkResponse_Lcom_mopub_network_MoPubNetworkError_Reason_ == IntPtr.Zero)
					id_ctor_Lcom_mopub_volley_NetworkResponse_Lcom_mopub_network_MoPubNetworkError_Reason_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/volley/NetworkResponse;Lcom/mopub/network/MoPubNetworkError$Reason;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_volley_NetworkResponse_Lcom_mopub_network_MoPubNetworkError_Reason_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_volley_NetworkResponse_Lcom_mopub_network_MoPubNetworkError_Reason_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_Throwable_Lcom_mopub_network_MoPubNetworkError_Reason_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.network']/class[@name='MoPubNetworkError']/constructor[@name='MoPubNetworkError' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='com.mopub.network.MoPubNetworkError.Reason']]"
		[Register (".ctor", "(Ljava/lang/Throwable;Lcom/mopub/network/MoPubNetworkError$Reason;)V", "")]
		public unsafe MoPubNetworkError (global::Java.Lang.Throwable p0, global::Com.Mopub.Network.MoPubNetworkError.Reason p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (MoPubNetworkError)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Throwable;Lcom/mopub/network/MoPubNetworkError$Reason;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Throwable;Lcom/mopub/network/MoPubNetworkError$Reason;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Throwable_Lcom_mopub_network_MoPubNetworkError_Reason_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Throwable_Lcom_mopub_network_MoPubNetworkError_Reason_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Throwable;Lcom/mopub/network/MoPubNetworkError$Reason;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Throwable_Lcom_mopub_network_MoPubNetworkError_Reason_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Throwable_Lcom_mopub_network_MoPubNetworkError_Reason_, __args);
			} finally {
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
			global::Com.Mopub.Network.MoPubNetworkError __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.MoPubNetworkError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RefreshTimeMillis);
		}
#pragma warning restore 0169

		static IntPtr id_getRefreshTimeMillis;
		public virtual unsafe global::Java.Lang.Integer RefreshTimeMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='MoPubNetworkError']/method[@name='getRefreshTimeMillis' and count(parameter)=0]"
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

		static Delegate cb_getReason;
#pragma warning disable 0169
		static Delegate GetGetReasonHandler ()
		{
			if (cb_getReason == null)
				cb_getReason = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReason);
			return cb_getReason;
		}

		static IntPtr n_GetReason (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.MoPubNetworkError __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.MoPubNetworkError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetReason ());
		}
#pragma warning restore 0169

		static IntPtr id_getReason;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='MoPubNetworkError']/method[@name='getReason' and count(parameter)=0]"
		[Register ("getReason", "()Lcom/mopub/network/MoPubNetworkError$Reason;", "GetGetReasonHandler")]
		public virtual unsafe global::Com.Mopub.Network.MoPubNetworkError.Reason GetReason ()
		{
			if (id_getReason == IntPtr.Zero)
				id_getReason = JNIEnv.GetMethodID (class_ref, "getReason", "()Lcom/mopub/network/MoPubNetworkError$Reason;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.MoPubNetworkError.Reason> (JNIEnv.CallObjectMethod  (Handle, id_getReason), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.MoPubNetworkError.Reason> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReason", "()Lcom/mopub/network/MoPubNetworkError$Reason;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
